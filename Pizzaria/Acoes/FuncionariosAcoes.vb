Imports MySql.Data.MySqlClient 'mySqlParameter
Imports Pizzaria
Imports Pizzaria.ClassesGenerica

Public Class FuncionariosAcoes

    Public Function Salvar(ByRef con As Connection, ByRef funcionario As Funcionarios) As Boolean

        Try

            con.Command.Parameters.Clear()

            If funcionario.IdFuncionario = 0 Then

                con.Command.CommandText = "Insert into tbFuncionarios 
                    (" + "idFuncionario, nome, cargo, salario, ativo" + ") 
                    Values (" + "@idFuncionario" +
                            ", @nome" +
                            ", @cargo" +
                            ", @salario" +
                            ", @ativo" + ")"
            Else

                con.Command.CommandText = "Update tbFuncionarios Set " +
                    " nome=@nome, cargo=@cargo, salario=@salario, ativo=@ativo" +
                    " Where idFuncionario=@idFuncionario"

            End If



            con.InserirParametroNoCamando(funcionario.IdFuncionario, "@idFuncionario", DbType.UInt16)
            con.InserirParametroNoCamando(funcionario.Nome, "@nome", DbType.String)
            con.InserirParametroNoCamando(funcionario.Cargo, "@cargo", DbType.String)
            con.InserirParametroNoCamando(funcionario.Salario, "@salario", DbType.Decimal)
            con.InserirParametroNoCamando(funcionario.Ativo, "@ativo", DbType.Boolean)

            con.Command.ExecuteNonQuery()

            Return True


        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Lista(ByRef con As Connection) As List(Of Funcionarios)

        Try

            Dim listaFuncionarios = New List(Of Funcionarios)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idFuncionario, nome, cargo, salario, ativo" +
                " From tbFuncionarios" +
                " Order by nome"

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim funcionario = New Funcionarios

                    funcionario.IdFuncionario = dt.Rows(i).Item("idFuncionario")
                    funcionario.Nome = dt.Rows(i).Item("nome")
                    funcionario.Cargo = dt.Rows(i).Item("cargo")
                    funcionario.Salario = dt.Rows(i).Item("salario")
                    funcionario.Ativo = dt.Rows(i).Item("ativo")

                    listaFuncionarios.Add(funcionario)

                Next
            End If

            Return listaFuncionarios

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idFuncionario As UShort) As Funcionarios

        Try

            Dim funcionario = New Funcionarios

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idFuncionario, nome, cargo, salario, ativo" +
                " From tbFuncionarios" +
                " Where idFuncionario=@idFuncionario"

            Dim myParamIdFuncionario = New MySqlParameter
            myParamIdFuncionario.DbType = DbType.UInt16
            myParamIdFuncionario.ParameterName = "@idFuncionario"
            myParamIdFuncionario.Value = idFuncionario

            con.Command.Parameters.Add(myParamIdFuncionario)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count = 1 Then

                funcionario.IdFuncionario = dt.Rows(0).Item("idFuncionario")
                funcionario.Nome = dt.Rows(0).Item("nome")
                funcionario.Cargo = dt.Rows(0).Item("cargo")
                funcionario.Salario = dt.Rows(0).Item("salario")
                funcionario.Ativo = dt.Rows(0).Item("ativo")

            End If

            Return funcionario

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idFuncionario As UShort) As Boolean

        Try

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbFuncionarios" +
                " Where idFuncionario=@idFuncionario"

            Dim myParamIdFuncionario = New MySqlParameter
            myParamIdFuncionario.DbType = DbType.UInt16
            myParamIdFuncionario.ParameterName = "@idFuncionario"
            myParamIdFuncionario.Value = idFuncionario

            con.Command.Parameters.Add(myParamIdFuncionario)

            con.Command.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Throw
        End Try

    End Function



    Public Sub PreencheComboFuncionario(ByRef combo As ComboBox)

        Dim con = New Connection

        Try

            combo.Items.Clear()
            combo.Items.Add("")

            con.OpenConnection()

            Dim listaFuncionarios = Lista(con)

            con.CloseConnection()

            If listaFuncionarios.Count > 0 Then

                For i As UShort = 0 To listaFuncionarios.Count - 1

                    Dim item = New Item(listaFuncionarios(i).IdFuncionario, listaFuncionarios(i).Nome)

                    combo.Items.Add(item)

                Next

            End If

        Catch ex As Exception
            con.CloseConnection()
            Throw
        End Try

    End Sub


End Class
