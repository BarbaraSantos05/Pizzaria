Imports Pizzaria.ClassesGenerica

Public Class FrmCadPagamentos

    Dim _funcoes As New Funcoes(Me)
    Private Sub FrmCadPagamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            _funcoes.AtribuirEventos(Me)
            Call ConfiguraGrid()

        Catch ex As Exception

            MsgBox("Houve um erro ao tentar executar o método [FrmCadPagamentos_Load]: " + ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub ConfiguraGrid()

        Try
            With grdLista

                .RowCount = 0
                .ColumnCount = 0

                .Columns.Add(New DataGridViewButtonColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())

                .Columns(0).Name = "Exibir"
                .Columns(1).Name = "idPagamento"
                .Columns(2).Name = "Descricao"

                .Columns("Exibir").HeaderText = ""
                .Columns("idPagamento").HeaderText = "Codigo"
                .Columns("Descricao").HeaderText = "Descricao"

                .Columns("Exibir").Width = 70
                .Columns("idPagamento").Width = 80
                .Columns("Descricao").Width = 440

                .Columns("Exibir").ReadOnly = True
                .Columns("idPagamento").ReadOnly = True
                .Columns("Descricao").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("idPagamento").Visible = True
                .Columns("Descricao").Visible = True
            End With

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        txtCodigo.Text = ""
        txtDescricao.Text = ""
        chkAtivo.Checked = True
        chkTemMaquininha.Checked = True
        txtDescricao.Focus()

    End Sub

    Private Function ValidarFormulario() As Boolean

        Try

            If txtDescricao.Text.Trim = "" Then
                MsgBox("Preencha a descricao Pagamento", MsgBoxStyle.Exclamation)
                txtDescricao.Focus()
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim con = New Connection

        Try
            Dim validado = ValidarFormulario()

            If validado = False Then
                Exit Sub
            End If

            Dim pagamento = New Pagamentos

            If IsNumeric(txtCodigo.Text) Then
                pagamento.IdPagamento = txtCodigo.Text
            End If

            pagamento.Descricao = txtDescricao.Text
            pagamento.Ativo = chkAtivo.Checked
            pagamento.TemMaquininha = chkTemMaquininha.Checked

            Dim pagamentosAcoes = New PagamentosAcoes

            con.OpenConnection()
            Dim salvou = pagamentosAcoes.Salvar(con, pagamento)
            con.CloseConnection()

            If salvou Then
                MsgBox("Operação realizada com suceso", MsgBoxStyle.Information)

                Call btnNovo_Click(Nothing, Nothing)
                Call btnPesquisa_Click(Nothing, Nothing)

                TabGeral.SelectedTab = TabPesquisa

            Else
                MsgBox("Houve um erro ao tentar salvar", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [btnSalvar_Click]: " + ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click

        Dim con = New Connection

        Try

            With grdLista

                .RowCount = 0

                Dim pagamentosAcoes = New PagamentosAcoes

                con.OpenConnection()
                Dim lista = pagamentosAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdPagamento", i).Value = lista(i).IdPagamento
                        .Item("Descricao", i).Value = lista(i).Descricao

                    Next
                End If

            End With

        Catch ex As Exception

            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [btnPesquisar_Click]: " + ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub grdLista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdLista.CellContentClick

        Dim con = New Connection

        Try

            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
                Exit Sub
            End If

            If e.ColumnIndex = 0 Then

                With grdLista

                    Dim idPagamento = .Item("idPagamento", e.RowIndex).Value

                    Dim pagamentosAcoes = New PagamentosAcoes

                    con.OpenConnection()
                    Dim pagamento = pagamentosAcoes.Detalhe(con, idPagamento)
                    con.CloseConnection()

                    If pagamento.IdPagamento > 0 Then

                        txtCodigo.Text = pagamento.IdPagamento
                        txtDescricao.Text = pagamento.Descricao
                        chkAtivo.Checked = pagamento.Ativo
                        pagamento.TemMaquininha = chkTemMaquininha.Checked

                        TabGeral.SelectedTab = TabCadastro
                    End If
                End With
            End If
        Catch ex As Exception

            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [grdLista_CellClick]: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click


        Dim con = New Connection

        Try
            If IsNumeric(txtCodigo.Text) Then

                Dim resposta = MsgBox("Tem certeza que deseja excluir o registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir")

                If resposta = MsgBoxResult.Yes Then
                    Dim idPagamento = txtCodigo.Text

                    Dim pagamentosAcoes = New PagamentosAcoes

                    con.OpenConnection()
                    Dim excluiu = pagamentosAcoes.Excluir(con, idPagamento)
                    con.CloseConnection()

                    If excluiu Then

                        MsgBox("Operação realizada com sucesso", MsgBoxStyle.Information)

                        Call btnNovo_Click(Nothing, Nothing)
                        Call btnPesquisa_Click(Nothing, Nothing)

                        TabGeral.SelectedTab = TabPesquisa

                    Else

                        MsgBox("Houve um erro ao tentar excluir o registro", MsgBoxStyle.Exclamation)
                    End If
                End If

            Else

                MsgBox("Selecione a pizza que deseja excluir", MsgBoxStyle.Exclamation)
                TabGeral.SelectedTab = TabPesquisa
            End If


        Catch ex As Exception

            Try
                MsgBox("Houve um erro ao tentar executar o método [btnExcluir_Click]: " + ex.Message, MsgBoxStyle.Critical)
            Catch ex1 As Exception
            End Try

        End Try
    End Sub


End Class