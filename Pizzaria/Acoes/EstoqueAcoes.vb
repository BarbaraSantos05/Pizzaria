Imports Pizzaria.ClassesGenerica

Public Class EstoqueAcoes

    Public Function Lista(ByRef con As Connection) As List(Of Estoque)

        Try
            Dim ListaEstoque = New List(Of Estoque)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select tbEntradaProduto.idProduto, 
                                              tbProdutos.descricao,
                                                Sum(tbEntradaProduto.quantidade) as qtdeEntrada, 
                                                ifnull((Select Sum(tbSaidaProduto.quantidade) From tbSaidaProduto 
                                                Where tbSaidaProduto.idProduto=tbEntradaProduto.idProduto),0) as qtdeSaida" +
                                      " From tbEntradaProduto Inner Join tbProdutos On tbEntradaProduto.idProduto = tbProdutos.idProduto" +
                                      " Group by tbEntradaProduto.idProduto"

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim estoque = New Estoque

                    estoque.Produto.IdProduto = dt.Rows(i).Item("idProduto")
                    estoque.Produto.Descricao = dt.Rows(i).Item("descricao")
                    estoque.qtdeEntrada = dt.Rows(i).Item("qtdeEntrada")
                    estoque.qtdeSaida = dt.Rows(i).Item("qtdeSaida")

                    ListaEstoque.Add(estoque)

                Next
            End If

            Return ListaEstoque

        Catch ex As Exception
            Throw
        End Try

    End Function

End Class
