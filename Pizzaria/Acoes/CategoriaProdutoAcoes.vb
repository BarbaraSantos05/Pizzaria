Imports MySql.Data.MySqlClient
Imports Pizzaria.ClassesGenerica

Public Class CategoriaProdutoAcoes

    Public Function Salvar(ByRef con As Connection, ByVal categoria As CategoriaProduto) As Boolean

        Try

            con.Command.Parameters.Clear()

            If categoria.IdCategoriaProduto = 0 Then

                con.Command.CommandText = "Insert Into tbCategoriaProduto (" +
                "idCategoriaProduto, categoria" +
                ") Values (" + "@idCategoriaProduto" +
                           ", @categoria" + ")"

            Else

                con.Command.CommandText = "Update tbCategoriaProduto Set " +
                " categoria=@categoria" +
                " Where idCategoriaProduto=@idCategoriaProduto"

            End If

            con.Command.Parameters.Add(con.InserirParametro(categoria.IdCategoriaProduto, "@idCategoriaProduto", DbType.UInt16))
            con.Command.Parameters.Add(con.InserirParametro(categoria.Categoria, "@categoria", DbType.String))

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Lista(ByRef con As Connection) As List(Of CategoriaProduto)

        Try

            Dim listaCategoriaProduto = New List(Of CategoriaProduto)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idCategoriaProduto, categoria" +
                " From tbCategoriaProduto" +
                " Order by categoria"

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim categoria = New CategoriaProduto

                    categoria.IdCategoriaProduto = dt.Rows(i).Item("idCategoriaProduto")
                    categoria.Categoria = dt.Rows(i).Item("categoria")

                    listaCategoriaProduto.Add(categoria)

                Next

            End If

            Return listaCategoriaProduto

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idCategoriaProduto As UShort) As CategoriaProduto

        Try

            Dim categoria = New CategoriaProduto

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idCategoriaProduto, categoria" +
                " From tbCategoriaProduto" +
                " Where idCategoriaProduto=@idCategoriaProduto"

            con.InserirParametroNoCamando(idCategoriaProduto, "@idCategoriaProduto", DbType.UInt16)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count = 1 Then

                categoria.IdCategoriaProduto = dt.Rows(0).Item("idCategoriaProduto")
                categoria.Categoria = dt.Rows(0).Item("categoria")


            End If

            Return categoria

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idCategoriaProduto As UShort) As Boolean

        Try

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbCategoriaProduto" +
                " Where idCategoriaProduto=@idCategoriaProduto"

            con.InserirParametroNoCamando(idCategoriaProduto, "@idCategoriaProduto", DbType.UInt16)


            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try
    End Function



    Public Sub PreencheComboCategoriaProduto(ByRef combo As ComboBox)

        Dim con = New Connection

        Try

            combo.Items.Clear()
            combo.Items.Add("")

            con.OpenConnection()

            Dim listaCategoriaProduto = Lista(con)

            con.CloseConnection()

            If listaCategoriaProduto.Count > 0 Then

                For i As UShort = 0 To listaCategoriaProduto.Count - 1

                    Dim item = New Item(listaCategoriaProduto(i).IdCategoriaProduto, listaCategoriaProduto(i).Categoria)

                    combo.Items.Add(item)

                Next

            End If

        Catch ex As Exception
            con.CloseConnection()
            Throw
        End Try

    End Sub

End Class
