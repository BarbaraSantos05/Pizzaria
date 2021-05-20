Imports Pizzaria.ClassesGenerica

Public Class FrmCadFuncionarios

    Dim _funcoes As New Funcoes(Me)
    Private Sub FrmCadFuncionarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            _funcoes.AtribuirEventos(Me)
            Call ConfiguraGrid()

        Catch ex As Exception
            MsgBox("Houve um erro ao tentar executar o método [FrmCadFuncionarios_Load]: " + ex.Message, MsgBoxStyle.Critical)
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
                .Columns(1).Name = "IdFuncionario"
                .Columns(2).Name = "Nome"

                .Columns("Exibir").HeaderText = ""
                .Columns("IdFuncionario").HeaderText = "Código"
                .Columns("Nome").HeaderText = "Nome"

                .Columns("Exibir").Width = 70
                .Columns("IdFuncionario").Width = 80
                .Columns("Nome").Width = 438

                .Columns("Exibir").ReadOnly = True
                .Columns("IdFuncionario").ReadOnly = True
                .Columns("Nome").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("IdFuncionario").Visible = True
                .Columns("Nome").Visible = True

            End With

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        txtCodigo.Text = ""
        txtNome.Text = ""
        txtCargo.Text = ""
        txtSalario.Text = ""
        chkAtivo.Checked = True
        txtNome.Focus()
    End Sub

    Private Function ValidarFormulario() As Boolean

        Try

            If txtNome.Text.Trim = "" Then

                MsgBox("Preencha o nome", MsgBoxStyle.Exclamation)
                txtNome.Focus()
                Return False

            End If

            If txtSalario.Text.Trim = "" Then

                MsgBox("Preenncha o salario", MsgBoxStyle.Exclamation)
                txtSalario.Focus()
                Return False

            End If

            If txtCargo.Text.Trim = "" Then

                MsgBox("Preencha o cargo", MsgBoxStyle.Exclamation)
                txtCargo.Focus()
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

            Dim funcionario = New Funcionarios

            If IsNumeric(txtCodigo.Text) Then
                funcionario.IdFuncionario = txtCodigo.Text
            End If

            funcionario.Nome = txtNome.Text
            funcionario.Cargo = txtSalario.Text

            If IsNumeric(txtSalario.Text) Then
                funcionario.Salario = txtSalario.Text
            End If

            funcionario.Ativo = chkAtivo.Checked

            Dim funcionariosAcoes = New FuncionariosAcoes()

            con.OpenConnection()
            Dim salvou = funcionariosAcoes.Salvar(con, funcionario)
            con.CloseConnection()

            If salvou Then
                MsgBox("Operação realizada com suceso", MsgBoxStyle.Information)

                Call btnNovo_Click(Nothing, Nothing)
                Call btnPesquisar_Click(Nothing, Nothing)

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

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click

        Dim con = New Connection

        Try

            With grdLista

                .RowCount = 0

                Dim funcionariosAcoes = New FuncionariosAcoes

                con.OpenConnection()
                Dim lista = funcionariosAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdFuncionario", i).Value = lista(i).IdFuncionario
                        .Item("Nome", i).Value = lista(i).Nome
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

                    Dim idFuncionario = .Item("idFuncionario", e.RowIndex).Value

                    Dim funcionariosAcoes = New FuncionariosAcoes

                    con.OpenConnection()
                    Dim funcionario = funcionariosAcoes.Detalhe(con, idFuncionario)
                    con.CloseConnection()

                    If funcionario.IdFuncionario > 0 Then

                        txtCodigo.Text = funcionario.IdFuncionario
                        txtNome.Text = funcionario.Nome
                        txtCargo.Text = funcionario.Cargo
                        txtSalario.Text = funcionario.Salario
                        chkAtivo.Checked = funcionario.Ativo

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
                    Dim idFuncionario = txtCodigo.Text

                    Dim funcionariosAcoes = New FuncionariosAcoes

                    con.OpenConnection()
                    Dim excluiu = funcionariosAcoes.Excluir(con, idFuncionario)
                    con.CloseConnection()

                    If excluiu Then

                        MsgBox("Operação realizada com sucesso", MsgBoxStyle.Information)

                        Call btnNovo_Click(Nothing, Nothing)
                        Call btnPesquisar_Click(Nothing, Nothing)

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