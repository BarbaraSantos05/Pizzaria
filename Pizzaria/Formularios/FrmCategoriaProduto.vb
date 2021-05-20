Imports Pizzaria.ClassesGenerica

Public Class FrmCategoriaProduto

    Dim _funcoes As New Funcoes(Me)
    Private Sub FrmCategoriaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            _funcoes.AtribuirEventos(Me)
            Call ConfiguraGrid()

        Catch ex As Exception
            MsgBox("Houve um erro ao tentar executar o método [FrmCategoriaProduto_Load]: " + ex.Message, MsgBoxStyle.Critical)
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
                .Columns(1).Name = "IdCategoriaProduto"
                .Columns(2).Name = "Categoria"

                .Columns("Exibir").HeaderText = ""
                .Columns("IdCategoriaProduto").HeaderText = "Código"
                .Columns("Categoria").HeaderText = "Categoria"

                .Columns("Exibir").Width = 70
                .Columns("IdCategoriaProduto").Width = 80
                .Columns("Categoria").Width = 395

                .Columns("Exibir").ReadOnly = True
                .Columns("IdCategoriaProduto").ReadOnly = True
                .Columns("Categoria").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("IdCategoriaProduto").Visible = True
                .Columns("Categoria").Visible = True

            End With


        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        txtCodigo.Text = ""
        txtCategoria.Text = ""
        txtCategoria.Focus()
    End Sub

    Private Function ValidarFormulario() As Boolean

        Try

            If txtCategoria.Text.Trim = "" Then
                MsgBox("Preencha a categoria do Produto", MsgBoxStyle.Exclamation)
                txtCategoria.Focus()
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

            Dim categoria = New CategoriaProduto


            If IsNumeric(txtCodigo.Text) Then
                categoria.IdCategoriaProduto = txtCodigo.Text
            End If

            categoria.Categoria = txtCategoria.Text


            Dim categoriaProdutoAcoes = New CategoriaProdutoAcoes()

            con.OpenConnection()
            Dim salvou = categoriaProdutoAcoes.Salvar(con, categoria)
            con.CloseConnection()

            If salvou Then
                MsgBox("Operação realizada com sucesso", MsgBoxStyle.Information)

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

                Dim categoriaAcoes = New CategoriaProdutoAcoes

                con.OpenConnection()
                Dim lista = categoriaAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdCategoriaProduto", i).Value = lista(i).IdCategoriaProduto
                        .Item("Categoria", i).Value = lista(i).Categoria

                    Next

                End If

            End With

        Catch ex As Exception

            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [btnPesquisa_Click]: " + ex.Message, MsgBoxStyle.Critical)

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

                    Dim idCategoriaProduto = .Item("idCategoriaProduto", e.RowIndex).Value

                    Dim categoriaAcoes = New CategoriaProdutoAcoes

                    con.OpenConnection()
                    Dim categoria = categoriaAcoes.Detalhe(con, idCategoriaProduto)
                    con.CloseConnection()

                    If categoria.IdCategoriaProduto > 0 Then

                        txtCodigo.Text = categoria.IdCategoriaProduto
                        txtCategoria.Text = categoria.Categoria

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
                    Dim idCategoriaProduto = txtCodigo.Text

                    Dim categoriaAcoes = New CategoriaProdutoAcoes

                    con.OpenConnection()
                    Dim excluiu = categoriaAcoes.Excluir(con, idCategoriaProduto)
                    con.CloseConnection()

                    If excluiu Then

                        MsgBox("O Produto foi excluido com sucesso", MsgBoxStyle.Information)

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
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [btnExcluir_Click]: " + ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

End Class