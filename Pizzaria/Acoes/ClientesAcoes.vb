Imports MySql.Data.MySqlClient
Imports Pizzaria.ClassesGenerica

Public Class ClientesAcoes

    Public Function Salvar(ByRef con As Connection, ByVal cliente As Clientes) As Boolean

        Try
            con.Command.Parameters.Clear()

            If cliente.IdCliente = 0 Then

                con.Command.CommandText = "Insert into tbClientes
                (" + "idCliente, nome, cpf, email, telCelular, telResidencial, logradouro, numero, complemento,bairro, cep, ativo" + ")
                Values (" + "@idCliente" +
                        ", @nome" +
                        ", @cpf" +
                        ", @email" +
                        ", @telCelular" +
                        ", @telResidencial" +
                        ", @logradouro" +
                        ", @numero" +
                        ", @complemento" +
                        ", @bairro" +
                        ", @cep" +
                        ", @ativo" + ")"
            Else

                con.Command.CommandText = "Update tbClientes Set " +
                    " nome=@nome, cpf=@cpf, email=@email, telCelular=@teltelCelular, telResidencial=@telResidencial, logradouro=@logradouro, 
                    numero=@numero, complemento=@complemento, bairro=@bairro cep=@cep, ativo=@ativo" +
                    " Where idCliente=@idCliente"
            End If

            con.InserirParametroNoCamando(cliente.IdCliente, "@idCliente", DbType.UInt16)
            con.InserirParametroNoCamando(cliente.Nome, "@nome", DbType.String)
            con.InserirParametroNoCamando(cliente.cpf, "@cpf", DbType.String)
            con.InserirParametroNoCamando(cliente.email, "@email", DbType.String)
            con.InserirParametroNoCamando(cliente.TelCelular, "@telCelular", DbType.String)
            con.InserirParametroNoCamando(cliente.TelResidencial, "@telResidencial", DbType.String)
            con.InserirParametroNoCamando(cliente.Logradouro, "@logradouro", DbType.String)
            con.InserirParametroNoCamando(cliente.Numero, "@numero", DbType.UInt16)
            con.InserirParametroNoCamando(cliente.Complemento, "@complemento", DbType.String)
            con.InserirParametroNoCamando(cliente.Bairro, "@bairro", DbType.String)
            con.InserirParametroNoCamando(cliente.Cep, "@cep", DbType.String)
            con.InserirParametroNoCamando(cliente.Ativo, "@ativo", DbType.Boolean)

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Lista(ByRef con As Connection) As List(Of Clientes)

        Try
            Dim listaClientes = New List(Of Clientes)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idCliente, nome, cpf, email, telCelular, telResidencial, logradouro, numero, 
            complemento, bairro, cep, ativo" +
            " From tbClientes" +
            " Order by nome"

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim cliente = New Clientes

                    cliente.IdCliente = dt.Rows(i).Item("idCliente")
                    cliente.Nome = dt.Rows(i).Item("nome")
                    cliente.cpf = dt.Rows(i).Item("cpf")
                    cliente.email = dt.Rows(i).Item("email")
                    cliente.TelCelular = dt.Rows(i).Item("telCelular")
                    cliente.TelResidencial = dt.Rows(i).Item("telResidencial")
                    cliente.Logradouro = dt.Rows(i).Item("logradouro")
                    cliente.Numero = dt.Rows(i).Item("numero")
                    cliente.Complemento = dt.Rows(i).Item("complemento")
                    cliente.Bairro = dt.Rows(i).Item("bairro")
                    cliente.Cep = dt.Rows(i).Item("cep")
                    cliente.Ativo = dt.Rows(i).Item("ativo")

                    listaClientes.Add(cliente)
                Next
            End If

            Return listaClientes

        Catch ex As Exception
            Throw
        End Try
    End Function


    Public Function Detalhe(ByRef con As Connection, ByVal idCliente As UShort) As Clientes

        Try
            Dim cliente = New Clientes

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idCliente, nome, cpf, email, telCelular, telResidencial, logradouro, numero, 
            IFNULL(complemento, '') AS complemento, bairro, cep, ativo" +
            " From tbClientes" +
            " Where idCliente=@idCliente"

            con.InserirParametroNoCamando(idCliente, "@idCliente", DbType.UInt16)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count = 1 Then

                cliente.IdCliente = dt.Rows(0).Item("idCliente")
                cliente.Nome = dt.Rows(0).Item("nome")
                cliente.cpf = dt.Rows(0).Item("cpf")
                cliente.email = dt.Rows(0).Item("email")
                cliente.TelCelular = dt.Rows(0).Item("telCelular")
                cliente.TelResidencial = dt.Rows(0).Item("telResidencial")
                cliente.Logradouro = dt.Rows(0).Item("logradouro")
                cliente.Numero = dt.Rows(0).Item("numero")
                cliente.Complemento = dt.Rows(0).Item("complemento")
                cliente.Bairro = dt.Rows(0).Item("bairro")
                cliente.Cep = dt.Rows(0).Item("cep")
                cliente.Ativo = dt.Rows(0).Item("ativo")

            End If

            Return cliente

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idCliente As UShort) As Boolean

        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbClientes" +
                " Where idCliente=@idCliente"

            Dim myParamIdCliente = New MySqlParameter
            myParamIdCliente.DbType = DbType.UInt16
            myParamIdCliente.ParameterName = "@idCliente"
            myParamIdCliente.Value = idCliente

            con.Command.Parameters.Add(myParamIdCliente)

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function


    Public Sub PreencheComboCliente(ByRef combo As ComboBox)

        Dim con = New Connection

        Try

            combo.Items.Clear()
            combo.Items.Add("")

            con.OpenConnection()

            Dim listaClientes = Lista(con)

            con.CloseConnection()

            If listaClientes.Count > 0 Then

                For i As UShort = 0 To listaClientes.Count - 1

                    Dim item = New Item(listaClientes(i).IdCliente, listaClientes(i).Nome)

                    combo.Items.Add(item)
                Next

            End If

    Catch ex As Exception
            con.CloseConnection()
            Throw
    End Try

    End Sub

End Class
