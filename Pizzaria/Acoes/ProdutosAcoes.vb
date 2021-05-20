Imports MySql.Data.MySqlClient
Imports Pizzaria.ClassesGenerica

Public Class ProdutosAcoes

    Public Function Salvar(ByRef con As Connection, ByVal produtos As Produtos) As Boolean

        Try

            con.Command.Parameters.Clear()

            If produtos.IdProduto = 0 Then

                con.Command.CommandText = "Insert Into tbProdutos (" +
                "idProduto, descricao, valor, ativo, idCategoriaProduto" +
                ") Values (" +
                "@idProduto" +
                ", @descricao" +
                ", @valor" +
                ", @ativo" +
                ", @idCategoriaProduto" +
                ")"

            Else

                con.Command.CommandText = "Update tbProdutos Set " +
                " descricao=@descricao, valor=@valor, ativo=@ativo, idCategoriaProduto=@idCategoriaProduto" +
                " Where idProduto=@idProduto"

            End If

            con.InserirParametroNoCamando(produtos.IdProduto, "@idProduto", DbType.UInt16)
            con.InserirParametroNoCamando(produtos.Descricao, "@descricao", DbType.String)
            con.InserirParametroNoCamando(produtos.Valor, "@valor", DbType.Decimal)
            con.InserirParametroNoCamando(produtos.Ativo, "@ativo", DbType.Boolean)
            con.InserirParametroNoCamando(produtos.IdCategoriaProduto, "@idCategoriaProduto", DbType.UInt16)

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function


    Public Function Lista(ByRef con As Connection) As List(Of Produtos)

        Try

            Dim listaProdutos = New List(Of Produtos)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idProduto, descricao, valor, ativo" +
                " From tbProdutos" +
                " Order by descricao"

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim produtos = New Produtos

                    produtos.IdProduto = dt.Rows(i).Item("idProduto")
                    produtos.Descricao = dt.Rows(i).Item("descricao")
                    produtos.Valor = dt.Rows(i).Item("valor")
                    produtos.Ativo = dt.Rows(i).Item("ativo")

                    listaProdutos.Add(produtos)

                Next

            End If

            Return listaProdutos

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idProduto As UShort) As Produtos

        Try

            Dim produtos = New Produtos

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idProduto, descricao, valor, ativo, idCategoriaProduto" +
                " From tbProdutos" +
                " Where idProduto=@idProduto"

            Dim myParamIdProduto = New MySqlParameter
            myParamIdProduto.DbType = DbType.UInt16
            myParamIdProduto.ParameterName = "@idProduto"
            myParamIdProduto.Value = idProduto

            con.Command.Parameters.Add(myParamIdProduto)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count = 1 Then

                produtos.IdProduto = dt.Rows(0).Item("idProduto")
                produtos.Descricao = dt.Rows(0).Item("descricao")
                produtos.Valor = dt.Rows(0).Item("valor")
                produtos.Ativo = dt.Rows(0).Item("ativo")
                produtos.IdCategoriaProduto = dt.Rows(0).Item("idCategoriaProduto")

            End If

            Return produtos

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Excluir(con As Connection, ByVal idProduto As UShort) As Boolean
        Try

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete from tbProdutos" +
                                     " Where idProduto=@idProduto"

            Dim myParamIdProduto = New MySqlParameter
            myParamIdProduto.DbType = DbType.UInt16
            myParamIdProduto.ParameterName = "@idProduto"
            myParamIdProduto.Value = idProduto

            con.Command.Parameters.Add(myParamIdProduto)

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Sub PreencheComboProdutos(ByRef combo As ComboBox)

        Dim con = New Connection

        Try

            combo.Items.Clear()
            combo.Items.Add("")

            con.OpenConnection()

            Dim listaProdutos = Lista(con)

            con.CloseConnection()

            If listaProdutos.Count > 0 Then

                For i As UShort = 0 To listaProdutos.Count - 1

                    Dim item = New Item(listaProdutos(i).IdProduto, listaProdutos(i).Descricao)

                    combo.Items.Add(item)
                Next
            End If
        Catch ex As Exception
            con.CloseConnection()
        End Try
    End Sub

End Class
