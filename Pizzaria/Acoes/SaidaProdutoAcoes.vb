Imports Pizzaria.ClassesGenerica

Public Class SaidaProdutoAcoes

    Public Function Salvar(ByRef con As Connection, ByVal saida As SaidaEstoque) As Boolean

        Try

            con.Command.Parameters.Clear()

            If saida.IdSaida = 0 Then

                saida.IdSaida = con.GeraCodigo("tbSaidaEstoque", "idSaida") ' Sempre precisa colocar ???


                con.Command.CommandText = "Insert Into tbSaidaEstoque (" +
                "idSaida, idPedido, idFuncionario, dataSaida, quantidadeTotal, valorTotal, observacao" +
                ") Values (" +
                           "@idSaida" +
                           ", @idPedido" +
                           ", @idFuncionario" +
                           ", @dataSaida" +
                           ", @quantidadeTotal" +
                           ", @valorTotal" +
                           ", @observacao" +
                           ")"
            Else

                con.Command.CommandText = "Update tbSaidaEstoque Set " +
                " idPedido=@idPedido, idFuncionario=@idFuncionario, dataSaida=@dataSaida, quantidadeTotal=@quantidadeTotal, valorTotal=@valorTotal, observacao=@observacao" +
                " Where idSaida=@idSaida"

            End If

            con.InserirParametroNoCamando(saida.IdSaida, "@idSaida", DbType.UInt16)
            If saida.idPedido = 0 Then
                con.InserirParametroNoCamando(DBNull.Value, "@idPedido", DbType.UInt16)   'Se gerar uma saida sem um pedido, ele vai retornar nulo para o banco
            Else
                con.InserirParametroNoCamando(saida.idPedido, "@idPedido", DbType.UInt16)
            End If
            con.InserirParametroNoCamando(saida.idFuncionario, "@idFuncionario", DbType.UInt16)
            con.InserirParametroNoCamando(saida.DataSaida, "@dataSaida", DbType.Date)
            con.InserirParametroNoCamando(saida.QuantidadeTotal, "@quantidadeTotal", DbType.UInt16)
            con.InserirParametroNoCamando(saida.ValorTotal, "@valorTotal", DbType.Decimal)
            con.InserirParametroNoCamando(saida.Observacao, "@observacao", DbType.String)

            con.Command.ExecuteNonQuery()

            SalvarProduto(con, saida)

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function


    Private Sub SalvarProduto(ByRef con As Connection, ByVal saida As SaidaEstoque)


        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbSaidaProduto Where idSaida=@idSaida"

            con.InserirParametroNoCamando(saida.IdSaida, "@idSaida", DbType.UInt16)

            con.Command.ExecuteNonQuery()

            For i As Short = 0 To saida.ListaSaidaProduto.Count - 1

                con.Command.Parameters.Clear()

                con.Command.CommandText = "Insert Into tbSaidaProduto (" +
                    "idSaida, idProduto, quantidade, valor" +
                    ") Values (" +
                    "@idSaida, @idProduto, @quantidade, @valor" +
                    ")"

                con.InserirParametroNoCamando(saida.IdSaida, "@idSaida", DbType.UInt16)
                con.InserirParametroNoCamando(saida.ListaSaidaProduto(i).Produto.IdProduto, "@idProduto", DbType.UInt16)
                con.InserirParametroNoCamando(saida.ListaSaidaProduto(i).Quantidade, "@quantidade", DbType.UInt16)
                con.InserirParametroNoCamando(saida.ListaSaidaProduto(i).Valor, "@valor", DbType.Decimal)

                con.Command.ExecuteNonQuery()

            Next
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Function Lista(ByRef con As Connection) As List(Of SaidaEstoque)

        Try

            Dim ListaSaidaEstoque = New List(Of SaidaEstoque)


            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select tbSaidaEstoque.idSaida,
                                        ifnull(tbSaidaEstoque.idPedido,0) as idPedido,
                                        tbSaidaEstoque.idFuncionario, 
                                        tbFuncionarios.nome,
                                        tbSaidaEstoque.dataSaida,
                                        tbSaidaEstoque.quantidadeTotal,
                                        tbSaidaEstoque.valorTotal,
                                        tbSaidaEstoque.observacao" +
                " From tbSaidaEstoque Inner Join tbFuncionarios On tbSaidaEstoque.idFuncionario = tbFuncionarios.idFuncionario"

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim saida = New SaidaEstoque

                    saida.IdSaida = dt.Rows(i).Item("idSaida")
                    saida.idPedido = dt.Rows(i).Item("idPedido")
                    saida.idFuncionario = dt.Rows(i).Item("idFuncionario")
                    saida.Nome = dt.Rows(i).Item("nome")
                    saida.DataSaida = dt.Rows(i).Item("dataSaida")
                    saida.QuantidadeTotal = dt.Rows(i).Item("quantidadeTotal")
                    saida.ValorTotal = dt.Rows(i).Item("valorTotal")
                    saida.Observacao = dt.Rows(i).Item("observacao")

                    ListaSaidaEstoque.Add(saida)
                Next

            End If
            Return ListaSaidaEstoque

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idSaida As UShort) As SaidaEstoque

        Try

            Dim saida = New SaidaEstoque

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select tbSaidaEstoque.idSaida,
                                        ifnull(tbSaidaEstoque.idPedido,0) as idPedido,
                                        tbSaidaEstoque.idFuncionario, 
                                        tbFuncionarios.nome,                                      
                                        tbSaidaEstoque.dataSaida,
                                        tbSaidaEstoque.quantidadeTotal,
                                        tbSaidaEstoque.valorTotal,
                                        tbSaidaEstoque.observacao" +
                                      " From tbSaidaEstoque Inner Join tbFuncionarios On tbSaidaEstoque.idFuncionario = tbFuncionarios.idFuncionario" +
                                      " Where idSaida=@idSaida"

            con.InserirParametroNoCamando(idSaida, "@idSaida", DbType.UInt16)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count = 1 Then

                saida.IdSaida = dt.Rows(0).Item("idSaida")
                saida.idPedido = dt.Rows(0).Item("idPedido")
                saida.idFuncionario = dt.Rows(0).Item("idFuncionario")
                saida.Nome = dt.Rows(0).Item("nome")
                saida.DataSaida = dt.Rows(0).Item("dataSaida")
                saida.QuantidadeTotal = dt.Rows(0).Item("quantidadeTotal")
                saida.ValorTotal = dt.Rows(0).Item("valortotal")
                saida.Observacao = dt.Rows(0).Item("observacao")

                saida.ListaSaidaProduto = ListaProduto(con, idSaida)

            End If

            Return saida

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idSaida As UShort) As Boolean

        Try

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbSaidaEstoque" +
                                      " Where idSaida=@idSaida"

            con.InserirParametroNoCamando(idSaida, "@idSaida", DbType.UInt16)

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    '--------------------------LISTA PRODUTOS-------------------------'

    Public Function ListaProduto(ByRef con As Connection, ByVal idSaida As UShort) As List(Of SaidaProduto)

        Try

            Dim listaSaidaProduto = New List(Of SaidaProduto)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select tbSaidaProduto.idSaidaProduto,
                                              tbProdutos.idProduto,
                                              tbProdutos.descricao,
                                              tbSaidaProduto.valor,
                                              tbSaidaProduto.quantidade" +
                                      " From tbSaidaProduto" +
                                      " Inner Join tbProdutos on tbSaidaProduto.idProduto = tbProdutos.idProduto" +
                                      " Where idSaida=@idSaida"


            con.InserirParametroNoCamando(idSaida, "@idSaida", DbType.UInt16)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim saida = New SaidaProduto

                    saida.IdSaidaProduto = dt.Rows(i).Item("IdSaidaProduto")
                    saida.Produto.IdProduto = dt.Rows(i).Item("idProduto")
                    saida.Produto.Descricao = dt.Rows(i).Item("descricao")
                    saida.Valor = dt.Rows(i).Item("valor")
                    saida.Quantidade = dt.Rows(i).Item("quantidade")

                    listaSaidaProduto.Add(saida)
                Next

            End If

            Return listaSaidaProduto

        Catch ex As Exception
            Throw
        End Try

    End Function

End Class
