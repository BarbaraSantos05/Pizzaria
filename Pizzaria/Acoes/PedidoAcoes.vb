Imports MySql.Data.MySqlClient
Imports Pizzaria
Imports Pizzaria.ClassesGenerica

Public Class PedidoAcoes

    Public Function Salvar(ByRef con As Connection, ByVal pedido As Pedido) As Boolean

        Try

            con.Command.Parameters.Clear()

            If pedido.IdPedido = 0 Then

                pedido.IdPedido = con.GeraCodigo("tbPedido", "idPedido")

                con.Command.CommandText = "Insert Into tbPedido (" +
                "idPedido, idCliente, observacao, valorTotal, quantidadeTotal, idPagamento, levarMaquininha, dataPedido, idFuncionario" +
                ") Values (" + " @idPedido" +
                               ", @idCliente" +
                               ", @observacao" +
                               ", @valorTotal" +
                               ", @quantidadeTotal" +
                               ", @idPagamento" +
                               ", @levarMaquininha" +
                               ", @dataPedido" +
                               ", @idFuncionario" +
                               ")"

            Else

                con.Command.CommandText = "Update tbPedido Set " +
                " idCliente=@idCliente, observacao=@observacao, valorTotal=@valorTotal, quantidadeTotal=@quantidadeTotal, idPagamento=@idPagamento" +
                ", levarMaquininha=@levarMaquininha, dataPedido=@dataPedido, idFuncionario=@idFuncionario" +
                " Where idPedido=@idPedido"

            End If

            con.InserirParametroNoCamando(pedido.IdPedido, "@idPedido", DbType.UInt16)
            con.InserirParametroNoCamando(pedido.Cliente.IdCliente, "@idCliente", DbType.UInt16)
            con.InserirParametroNoCamando(pedido.Observacao, "@observacao", DbType.String)
            con.InserirParametroNoCamando(pedido.ValorTotal, "@valorTotal", DbType.Decimal)
            con.InserirParametroNoCamando(pedido.QuantidadeTotal, "@quantidadeTotal", DbType.UInt16)
            con.InserirParametroNoCamando(pedido.IdPagamento, "@idPagamento", DbType.UInt16)
            con.InserirParametroNoCamando(pedido.LevarMaquininha, "@levarMaquininha", DbType.Boolean)
            con.InserirParametroNoCamando(pedido.DataPedido, "@dataPedido", DbType.String)
            con.InserirParametroNoCamando(pedido.Funcionario.IdFuncionario, "@idFuncionario", DbType.UInt16)

            con.Command.ExecuteNonQuery()

            SalvarPizza(con, pedido)

            SalvarProduto(con, pedido)


            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Sub SalvarPizza(ByRef con As Connection, ByVal pedido As Pedido)

        Try

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbPedidoPizza Where idPedido=@idPedido"

            con.InserirParametroNoCamando(pedido.IdPedido, "@idPedido", DbType.UInt16)

            con.Command.ExecuteNonQuery()

            For i As Short = 0 To pedido.ListaPedidoPizza.Count - 1

                con.Command.Parameters.Clear()

                con.Command.CommandText = "Insert Into tbPedidoPizza (" +
                    "idPedido, idPizza, quantidade, valor" +
                    ") Values (" +
                    "@idPedido, @idPizza, @quantidade, @valor" +
                    ")"

                con.InserirParametroNoCamando(pedido.IdPedido, "@idPedido", DbType.UInt16)
                con.InserirParametroNoCamando(pedido.ListaPedidoPizza(i).Pizza.IdPizza, "@idPizza", DbType.UInt16)
                con.InserirParametroNoCamando(pedido.ListaPedidoPizza(i).Quantidade, "@quantidade", DbType.UInt16)
                con.InserirParametroNoCamando(pedido.ListaPedidoPizza(i).Valor, "@valor", DbType.Decimal)

                con.Command.ExecuteNonQuery()

            Next

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub SalvarProduto(ByRef con As Connection, ByVal pedido As Pedido)

        Try

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbPedidoProduto Where idPedido=@idPedido"

            con.InserirParametroNoCamando(pedido.IdPedido, "@idPedido", DbType.UInt16)

            con.Command.ExecuteNonQuery()

            For i As Short = 0 To pedido.ListaPedidoPizza.Count - 1

                con.Command.Parameters.Clear()

                con.Command.CommandText = "Insert Into tbPedidoProduto (" +
                    "idPedido, idProduto, quantidade, valor" +
                    ") Values (" +
                    "@idPedido, @idProduto, @quantidade, @valor" +
                    ")"

                con.InserirParametroNoCamando(pedido.IdPedido, "@idPedido", DbType.UInt16)
                con.InserirParametroNoCamando(pedido.ListaPedidoProduto(i).Produto.IdProduto, "@idProduto", DbType.UInt16)
                con.InserirParametroNoCamando(pedido.ListaPedidoProduto(i).Quantidade, "@quantidade", DbType.UInt16)
                con.InserirParametroNoCamando(pedido.ListaPedidoProduto(i).Valor, "@valor", DbType.Decimal)

                con.Command.ExecuteNonQuery()

            Next

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Public Function Lista(ByRef con As Connection) As List(Of Pedido)

        Try

            Dim listaPedido = New List(Of Pedido)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select" +
                                      " tbPedido.idPedido" +
                                      ", tbPedido.idCliente" +
                                      ", tbClientes.nome" +
                                      ", logradouro" +
                                      ", numero" +
                                      ", ifNull(complemento, '') as complemento" +
                                      ", tbClientes.telCelular" +
                                      ", observacao" +
                                      ", valorTotal" +
                                      ", quantidadeTotal" +
                                      ", tbPedido.idPagamento" +
                                      ", tbPedido.levarMaquininha" +
                                      ", tbPedido.dataPedido" +
                                      ", tbPedido.idFuncionario" +
                                      ", tbFuncionarios.nome" +
                                      " From tbPedido" +
                                      " Inner Join tbClientes on tbPedido.idCliente = tbClientes.idCliente" +
                                      " Inner Join tbPagamentos on tbPedido.idPagamento = tbPagamentos.idPagamento" +
                                      " Inner Join tbFuncionarios on tbPedido.idFuncionario = tbFuncionarios.idFuncionario"


            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim pedido = New Pedido

                    pedido.IdPedido = dt.Rows(i).Item("idPedido")          'Preenche todas as informações de cliente do Designer do Frm de pedido 
                    pedido.Cliente.IdCliente = dt.Rows(i).Item("idCliente")
                    pedido.Cliente.Logradouro = dt.Rows(i).Item("logradouro")
                    pedido.Cliente.Nome = dt.Rows(i).Item("nome")
                    pedido.Cliente.Numero = dt.Rows(i).Item("numero")
                    pedido.Cliente.Complemento = dt.Rows(i).Item("complemento")
                    pedido.Cliente.TelCelular = dt.Rows(i).Item("telCelular")
                    pedido.Observacao = dt.Rows(i).Item("observacao")
                    pedido.ValorTotal = dt.Rows(i).Item("valortotal")
                    pedido.QuantidadeTotal = dt.Rows(i).Item("quantidadeTotal")
                    pedido.IdPagamento = dt.Rows(i).Item("idPagamento")
                    pedido.LevarMaquininha = dt.Rows(i).Item("levarMaquininha")
                    pedido.DataPedido = dt.Rows(i).Item("dataPedido")
                    pedido.Funcionario.IdFuncionario = dt.Rows(i).Item("idFuncionario")
                    pedido.Funcionario.Nome = dt.Rows(i).Item("nome")

                    listaPedido.Add(pedido)

                Next

            End If

            Return listaPedido

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idPedido As UShort) As Pedido

        Try

            Dim pedido = New Pedido

            con.Command.Parameters.Clear()

            con.Command.CommandText = " Select tbPedido.idPedido, 
                                        tbPedido.idCliente, tbClientes.nome, tbClientes.logradouro, tbClientes.numero, tbClientes.complemento, tbClientes.telCelular, 
                                        IFNULL(tbPedido.observacao, '') AS observacao, 
                                        tbPedido.valorTotal, 
                                        tbPedido.quantidadeTotal, 
                                        tbPedido.idPagamento,
                                        tbPedido.levarMaquininha, tbPedido.dataPedido, 
                                        tbPedido.idFuncionario, tbFuncionarios.nome" +
                                    " From tbPedido" +
                                    " Inner Join tbClientes On tbPedido.idCliente = tbClientes.idCliente" +
                                    " Inner Join tbFuncionarios On tbPedido.idFuncionario = tbFuncionarios.idFuncionario" +
                                    " Where idPedido=@idPedido"

            con.InserirParametroNoCamando(idPedido, "@idPedido", DbType.UInt16)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count = 1 Then

                pedido.IdPedido = dt.Rows(0).Item("idPedido")              'Preenche todas as informações de cliente do Designer do Frm de pedido 

                pedido.Cliente.IdCliente = dt.Rows(0).Item("idCliente")
                pedido.Cliente.Logradouro = dt.Rows(0).Item("logradouro")
                pedido.Cliente.Numero = dt.Rows(0).Item("numero")
                pedido.Cliente.Complemento = dt.Rows(0).Item("complemento")
                pedido.Cliente.TelCelular = dt.Rows(0).Item("telCelular")

                pedido.Observacao = dt.Rows(0).Item("observacao")
                pedido.ValorTotal = dt.Rows(0).Item("valortotal")
                pedido.QuantidadeTotal = dt.Rows(0).Item("quantidadeTotal")
                pedido.IdPagamento = dt.Rows(0).Item("idPagamento")

                pedido.LevarMaquininha = dt.Rows(0).Item("levarMaquininha")
                pedido.DataPedido = dt.Rows(0).Item("dataPedido")
                pedido.Funcionario.IdFuncionario = dt.Rows(0).Item("idFuncionario")
                pedido.Funcionario.Nome = dt.Rows(0).Item("nome")


                pedido.ListaPedidoPizza = ListaPizza(con, idPedido)       'Depois de preencher a listaPizza (listaPedidoPizza), chama ela nesse trecho para ser detalhado

                pedido.ListaPedidoProduto = ListaProduto(con, idPedido)   'Depois de preencher a listaProdutos (listaPedidoProduto), chama ela nesse trecho para ser detalhado

            End If

            Return pedido

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idPedido As UShort) As Boolean

        Try

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbPedido" +
                " Where idPedido=@idPedido"

            con.InserirParametroNoCamando(idPedido, "@idPedido", DbType.UInt16)

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

#Region "PedidoPizza"

    Private Function ListaPizza(ByRef con As Connection, ByVal idPedido As UShort) As List(Of PedidoPizza)

        Try

            Dim listaPedidoPizza = New List(Of PedidoPizza)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select" +                      'Preenche todas as informações da Pizza do Designer do Frm de pedido 
                                      " idPedidoPizza" +
                                      ", tbPizza.idPizza" +
                                      ", nome" +
                                      ", tbPedidoPizza.valor" +
                                      ", quantidade" +
                                      " From tbPedidoPizza" +
                                      " Inner Join tbPizza on tbPizza.idPizza = tbPedidoPizza.idPizza" +
                                      " Where tbPedidoPizza.idPedido = @idPedido" +
                                      " Order by nome;"

            Dim myParamIdPedido = New MySqlParameter
            myParamIdPedido.DbType = DbType.UInt16
            myParamIdPedido.ParameterName = "@idPedido"
            myParamIdPedido.Value = idPedido

            con.Command.Parameters.Add(myParamIdPedido)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim pizza = New PedidoPizza

                    pizza.IdPedidoPizza = dt.Rows(i).Item("idPedidoPizza")
                    pizza.Pizza.IdPizza = dt.Rows(i).Item("idPizza")
                    pizza.Pizza.Nome = dt.Rows(i).Item("nome")
                    pizza.Valor = dt.Rows(i).Item("valor")
                    pizza.Quantidade = dt.Rows(i).Item("quantidade")


                    listaPedidoPizza.Add(pizza)

                Next

            End If

            Return listaPedidoPizza

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Function ListaProduto(ByRef con As Connection, ByVal idPedido As UShort) As List(Of PedidoProduto)

        Try

            Dim listaPedidoProduto = New List(Of PedidoProduto)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select" +                     'Preenche todas as informações da Produto do Designer do Frm de pedido                                        
                                      " idPedidoProduto" +
                                      ", tbProdutos.idProduto" +
                                      ", descricao" +
                                      ", tbPedidoProduto.valor" +
                                      ", quantidade" +
                                      " From tbPedidoProduto" +
                                      " Inner Join tbProdutos on tbProdutos.idProduto = tbPedidoProduto.idProduto" +
                                      " Where tbPedidoProduto.idPedido = @idPedido" +
                                      " Order by descricao;"

            ' tbPedidoProduto.valor == O valor é da tabela Do pedidoProduto para 
            'caso eu queira pegar um preco de um pedido antigo, não pegar o valor atualizado.


            Dim myParamIdPedido = New MySqlParameter
            myParamIdPedido.DbType = DbType.UInt16
            myParamIdPedido.ParameterName = "@idPedido"
            myParamIdPedido.Value = idPedido

            con.Command.Parameters.Add(myParamIdPedido)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim produto = New PedidoProduto

                    produto.IdPedidoProduto = dt.Rows(i).Item("idPedidoProduto")
                    produto.Produto.IdProduto = dt.Rows(i).Item("idProduto")
                    produto.Produto.Descricao = dt.Rows(i).Item("descricao")
                    produto.Valor = dt.Rows(i).Item("valor")
                    produto.Quantidade = dt.Rows(i).Item("quantidade")


                    listaPedidoProduto.Add(produto)

                Next

            End If

            Return listaPedidoProduto

        Catch ex As Exception
            Throw
        End Try


    End Function



#End Region

End Class
