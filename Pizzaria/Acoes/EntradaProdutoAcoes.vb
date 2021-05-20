Imports MySql.Data.MySqlClient
Imports Pizzaria.ClassesGenerica

Public Class EntradaProdutoAcoes

    Public Function Salvar(ByRef con As Connection, ByVal entrada As EntradaEstoque) As Boolean

        Try

            con.Command.Parameters.Clear()

            If entrada.idEntrada = 0 Then

                entrada.idEntrada = con.GeraCodigo("tbEntradaEstoque", "idEntrada")

                con.Command.CommandText = "Insert Into tbEntradaEstoque (" +
                "idEntrada, idFuncionario, fornecedor, notaFiscal, dataEntrada, quantidadeTotal, valorTotal, observacao" +
                ") Values (" +
                "@idEntrada" +
                ", @idFuncionario" +
                ", @fornecedor" +
                ", @notaFiscal" +
                ", @dataEntrada" +
                ", @quantidadeTotal" +
                ", @valorTotal" +
                ", @observacao" +
                ")"

            Else

                con.Command.CommandText = "Update tbEntradaEstoque Set " +
                " idFuncionario=@idFuncionario, fornecedor=@fornecedor, notaFiscal=@notaFiscal, dataEntrada=@dataEntrada, quantidadeTotal=@quantidadeTotal, valorTotal=@valorTotal, observacao=@observacao" +
                " Where idEntrada=@idEntrada"

            End If


            con.InserirParametroNoCamando(entrada.idEntrada, "@idEntrada", DbType.UInt16)
            con.InserirParametroNoCamando(entrada.Funcionario.IdFuncionario, "@idFuncionario", DbType.UInt16)
            con.InserirParametroNoCamando(entrada.Fornecedor, "@fornecedor", DbType.String)
            con.InserirParametroNoCamando(entrada.NotaFiscal, "@notaFiscal", DbType.String)
            con.InserirParametroNoCamando(entrada.DataEntrada, "@dataEntrada", DbType.Date)
            con.InserirParametroNoCamando(entrada.QuantidadeTotal, "@quantidadeTotal", DbType.UInt16)
            con.InserirParametroNoCamando(entrada.ValorTotal, "@valorTotal", DbType.Decimal)
            con.InserirParametroNoCamando(entrada.Observacao, "@observacao", DbType.String)

            con.Command.ExecuteNonQuery()

            SalvarProduto(con, entrada)

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function


    Private Sub SalvarProduto(ByRef con As Connection, ByVal entrada As EntradaEstoque)

        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbEntradaProduto Where idEntrada=@idEntrada"

            con.InserirParametroNoCamando(entrada.idEntrada, "@idEntrada", DbType.UInt16)

            con.Command.ExecuteNonQuery()

            For i As Short = 0 To entrada.ListaEntradaProduto.Count - 1

                con.Command.Parameters.Clear()

                con.Command.CommandText = "Insert Into tbEntradaProduto (" +
                    "idEntrada, idProduto, quantidade, valor, dataValidade" +
                    ") Values (" +
                    "@idEntrada, @idProduto, @quantidade, @valor, @dataValidade" +
                    ")"

                con.InserirParametroNoCamando(entrada.idEntrada, "@idEntrada", DbType.UInt16)
                con.InserirParametroNoCamando(entrada.ListaEntradaProduto(i).Produto.IdProduto, "@idProduto", DbType.UInt16)
                con.InserirParametroNoCamando(entrada.ListaEntradaProduto(i).Quantidade, "@quantidade", DbType.UInt16)
                con.InserirParametroNoCamando(entrada.ListaEntradaProduto(i).Valor, "@valor", DbType.Decimal)
                con.InserirParametroNoCamando(entrada.ListaEntradaProduto(i).DataValidade, "@dataValidade", DbType.String)

                con.Command.ExecuteNonQuery()

            Next

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Function Lista(ByRef con As Connection) As List(Of EntradaEstoque)

        Try

            Dim ListaEntradaEstoque = New List(Of EntradaEstoque)


            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select tbEntradaEstoque.idEntrada" +
                                    ", tbEntradaEstoque.idFuncionario" +
                                    ", tbFuncionarios.nome" +
                                    ", tbEntradaEstoque.fornecedor" +
                                    ", tbEntradaEstoque.notaFiscal" +
                                    ", tbEntradaEstoque.dataEntrada" +
                                    ", tbEntradaEstoque.quantidadeTotal" +
                                    ", tbEntradaEstoque.valorTotal" +
                                    ", tbEntradaEstoque.observacao" +
                                    " From tbEntradaEstoque Inner Join tbFuncionarios On tbEntradaEstoque.idFuncionario = tbFuncionarios.idFuncionario"

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim entrada = New EntradaEstoque

                    entrada.idEntrada = dt.Rows(i).Item("idEntrada")
                    entrada.Funcionario.IdFuncionario = dt.Rows(i).Item("idFuncionario")
                    entrada.Funcionario.Nome = dt.Rows(i).Item("nome")
                    entrada.Fornecedor = dt.Rows(i).Item("fornecedor")
                    entrada.NotaFiscal = dt.Rows(i).Item("notaFiscal")
                    entrada.DataEntrada = dt.Rows(i).Item("dataEntrada")
                    entrada.QuantidadeTotal = dt.Rows(i).Item("quantidadeTotal")
                    entrada.ValorTotal = dt.Rows(i).Item("valorTotal")
                    entrada.Observacao = dt.Rows(i).Item("observacao")

                    ListaEntradaEstoque.Add(entrada)
                Next

            End If

            Return ListaEntradaEstoque

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idEntrada As UShort) As EntradaEstoque

        Try

            Dim entrada = New EntradaEstoque

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select tbEntradaEstoque.idEntrada," +
                                    " tbEntradaEstoque.idFuncionario, " +
                                    " tbFuncionarios.nome," +
                                    " tbEntradaEstoque.fornecedor, " +
                                    " tbEntradaEstoque.notaFiscal, " +
                                    " tbEntradaEstoque.dataEntrada, " +
                                    " tbEntradaEstoque.quantidadeTotal," +
                                    " tbEntradaEstoque.valorTotal, " +
                                    " tbEntradaEstoque.observacao" +
                                      " From tbEntradaEstoque Inner Join tbFuncionarios On tbEntradaEstoque.idFuncionario = tbFuncionarios.idFuncionario" +
                                      " Where idEntrada=@idEntrada"

            con.InserirParametroNoCamando(idEntrada, "@idEntrada", DbType.UInt16)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count = 1 Then

                entrada.idEntrada = dt.Rows(0).Item("idEntrada")
                entrada.Funcionario.IdFuncionario = dt.Rows(0).Item("idFuncionario")
                entrada.Funcionario.Nome = dt.Rows(0).Item("nome")
                entrada.Fornecedor = dt.Rows(0).Item("fornecedor")
                entrada.NotaFiscal = dt.Rows(0).Item("notaFiscal")
                entrada.DataEntrada = dt.Rows(0).Item("dataEntrada")
                entrada.QuantidadeTotal = dt.Rows(0).Item("quantidadeTotal")
                entrada.ValorTotal = dt.Rows(0).Item("valortotal")
                entrada.Observacao = dt.Rows(0).Item("observacao")
                entrada.ListaEntradaProduto = ListaProduto(con, idEntrada)

            End If

            Return entrada

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idEntrada As UShort) As Boolean

        Try

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbEntradaEstoque" +
                                      " Where idEntrada=@idEntrada"

            con.InserirParametroNoCamando(idEntrada, "@idEntrada", DbType.UInt16)

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    '--------------------------LISTA-------------------------

    Public Function ListaProduto(ByRef con As Connection, ByVal idEntrada As UShort) As List(Of EntradaProduto)

        Try

            Dim listaEntradaProduto = New List(Of EntradaProduto)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select tbEntradaProduto.idEntradaProduto,
                                              tbProdutos.idProduto,
                                              tbProdutos.descricao,
                                              tbEntradaProduto.valor,
                                              tbEntradaProduto.quantidade,
                                              tbEntradaProduto.dataValidade" +
                                      " From tbEntradaProduto" +
                                      " Inner Join tbProdutos on tbEntradaProduto.idProduto = tbProdutos.idProduto" +
                                      " Where idEntrada=@idEntrada"

            con.InserirParametroNoCamando(idEntrada, "@idEntrada", DbType.UInt16)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim entrada = New EntradaProduto

                    entrada.IdEntradaProduto = dt.Rows(i).Item("IdEntradaProduto")
                    entrada.Produto.IdProduto = dt.Rows(i).Item("idProduto")
                    entrada.Produto.Descricao = dt.Rows(i).Item("descricao")
                    entrada.Valor = dt.Rows(i).Item("valor")
                    entrada.Quantidade = dt.Rows(i).Item("quantidade")
                    entrada.DataValidade = dt.Rows(i).Item("dataValidade")

                    listaEntradaProduto.Add(entrada)
                Next

            End If

            Return listaEntradaProduto

        Catch ex As Exception
            Throw
        End Try

    End Function

End Class
