Imports MySql.Data.MySqlClient
Imports Pizzaria.ClassesGenerica

Public Class PagamentosAcoes

    Public Function Salvar(ByRef con As Connection, ByVal pagamento As Pagamentos) As Boolean

        Try
            con.Command.Parameters.Clear()

            If pagamento.IdPagamento = 0 Then

                con.Command.CommandText = "Insert into tbPagamentos
                (" + "idPagamento, descricao, ativo, temMaquininha" + ")
                Values (" + "@idPagamento" +
                        ", @descricao" +
                        ", @ativo" +
                        ", @temMaquininha" + ")"
            Else
                con.Command.CommandText = "Update tbPagamentos Set " +
                    " descricao=@descricao, ativo=@ativo, temMaquininha=@temMaquininha" +
                    " Where idPagamento=@idPagamento"
            End If


            con.InserirParametroNoCamando(pagamento.IdPagamento, "@idPagamento", DbType.UInt16)
            con.InserirParametroNoCamando(pagamento.Descricao, "@descricao", DbType.String)
            con.InserirParametroNoCamando(pagamento.Ativo, "@ativo", DbType.Boolean)
            con.InserirParametroNoCamando(pagamento.TemMaquininha, "@temMaquininha", DbType.Boolean)

            con.Command.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Lista(ByRef con As Connection) As List(Of Pagamentos)

        Try

            Dim listaPagamentos = New List(Of Pagamentos)

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idPagamento, descricao, ativo, temMaquininha" +
                " From tbPagamentos" +
                " Order by descricao"

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim pagamento = New Pagamentos

                    pagamento.IdPagamento = dt.Rows(i).Item("idPagamento")
                    pagamento.Descricao = dt.Rows(i).Item("descricao")
                    pagamento.Ativo = dt.Rows(i).Item("ativo")
                    pagamento.TemMaquininha = dt.Rows(i).Item("temMaquininha")

                    listaPagamentos.Add(pagamento)

                Next
            End If

            Return listaPagamentos

        Catch ex As Exception
            Throw
        End Try
    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idPagamento As UShort) As Pagamentos

        Try

            Dim pagamento = New Pagamentos

            con.Command.Parameters.Clear()

            con.Command.CommandText = "Select idPagamento, descricao, ativo, temMaquininha" +
                " From tbPagamentos" +
                " Where idPagamento=@idPagamento"

            Dim myParamIdPagamento = New MySqlParameter
            myParamIdPagamento.DbType = DbType.UInt16
            myParamIdPagamento.ParameterName = "@idPagamento"
            myParamIdPagamento.Value = idPagamento

            con.Command.Parameters.Add(myParamIdPagamento)

            Dim dt = con.ExecutaComandoDataTable

            If dt.Rows.Count = 1 Then

                pagamento.IdPagamento = dt.Rows(0).Item("idPagamento")
                pagamento.Descricao = dt.Rows(0).Item("descricao")
                pagamento.Ativo = dt.Rows(0).Item("ativo")
                pagamento.TemMaquininha = dt.Rows(0).Item("temMaquininha")

            End If

            Return pagamento

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idPagamento As UShort) As Boolean

        Try
            con.Command.Parameters.Clear()

            con.Command.CommandText = "Delete From tbPagamentos" +
                " Where idPagamento=@idPagamento"

            Dim myParamIdPagamento = New MySqlParameter
            myParamIdPagamento.DbType = DbType.UInt16
            myParamIdPagamento.ParameterName = "@idPagamento"
            myParamIdPagamento.Value = idPagamento

            con.Command.Parameters.Add(myParamIdPagamento)

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function


    Public Sub PreencheComboPagamento(ByRef combo As ComboBox)

        Dim con = New Connection

        Try

            combo.Items.Clear()
            combo.Items.Add("")

            con.OpenConnection()

            Dim listaPagamentos = Lista(con)

            con.CloseConnection()

            If listaPagamentos.Count > 0 Then

                For i As UShort = 0 To listaPagamentos.Count - 1

                    Dim item = New Item(listaPagamentos(i).IdPagamento, listaPagamentos(i).Descricao)

                    combo.Items.Add(item)

                Next

            End If

        Catch ex As Exception
            con.CloseConnection()
            Throw
        End Try

    End Sub


End Class
