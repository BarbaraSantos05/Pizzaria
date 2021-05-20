Imports Pizzaria.ClassesGenerica

Public Class FrmCadProdutos

    Dim _funcoes As New Funcoes(Me)

    Private Sub FrmCadProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            _funcoes.AtribuirEventos(Me)
            Call ConfiguraGrid()
            Call New CategoriaProdutoAcoes().PreencheComboCategoriaProduto(cmbCategoriaProduto)

        Catch ex As Exception
            MsgBox("Houve um erro ao tentar executar o método [FrmCadProdutos_Load]: " + ex.Message, MsgBoxStyle.Critical)
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
                .Columns(1).Name = "idProduto"
                .Columns(2).Name = "Descricao"

                .Columns("Exibir").HeaderText = ""
                .Columns("idProduto").HeaderText = "Codigo"
                .Columns("Descricao").HeaderText = "Descricao"

                .Columns("Exibir").Width = 70
                .Columns("idProduto").Width = 80
                .Columns("Descricao").Width = 385

                .Columns("Exibir").ReadOnly = True
                .Columns("IdProduto").ReadOnly = True
                .Columns("Descricao").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("idProduto").Visible = True
                .Columns("Descricao").Visible = True

            End With

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        txtCodigo.Text = ""
        txtDescricao.Text = ""
        txtValor.Text = ""
        cmbCategoriaProduto.SelectedIndex = 0
        chkAtivo.Checked = True
        txtDescricao.Focus()

    End Sub


    Private Function ValidarFormulario() As Boolean

        Try

            If txtDescricao.Text.Trim = "" Then
                MsgBox("Preencha a descrição", MsgBoxStyle.Exclamation)
                txtDescricao.Focus()
                Return False
            End If


            If txtValor.Text.Trim = "" Then
                MsgBox("Preenche o valor", MsgBoxStyle.Exclamation)
                txtValor.Focus()
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

            Dim produtos = New Produtos

            If IsNumeric(txtCodigo.Text) Then
                produtos.IdProduto = txtCodigo.Text
            End If

            produtos.Descricao = txtDescricao.Text

            If IsNumeric(txtValor.Text) Then
                produtos.Valor = txtValor.Text
            End If

            produtos.Ativo = chkAtivo.Checked

            produtos.IdCategoriaProduto = _funcoes.PegaIdCombo(cmbCategoriaProduto)

            Dim produtosAcoes = New ProdutosAcoes()

            con.OpenConnection()
            Dim salvou = produtosAcoes.Salvar(con, produtos)
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

                Dim produtosAcoes = New ProdutosAcoes

                con.OpenConnection()
                Dim lista = produtosAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdProduto", i).Value = lista(i).IdProduto
                        .Item("Descricao", i).Value = lista(i).Descricao
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

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Dim con = New Connection

        Try
            If IsNumeric(txtCodigo.Text) Then

                Dim resposta = MsgBox("Tem certeza que deseja excluir o registro? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir")

                If resposta = MsgBoxResult.Yes Then

                    Dim idProduto = txtCodigo.Text

                    Dim produtosAcoes = New ProdutosAcoes

                    con.OpenConnection()
                    Dim excluiu = produtosAcoes.Excluir(con, idProduto)
                    con.CloseConnection()

                    If excluiu Then
                        MsgBox("O Produto foi excluido com sucesso", MsgBoxStyle.Information)

                        Call btnNovo_Click(Nothing, Nothing)
                        Call btnPesquisa_Click(Nothing, Nothing)

                        TabGeral.SelectedTab = TabPesquisa

                    Else
                        MsgBox("Houve um erro ao tentar excluir" + MsgBoxStyle.Exclamation)
                    End If

                End If

            Else
                MsgBox("Selecione a Pizza que deseja excluir" + MsgBoxStyle.Exclamation)
                TabGeral.SelectedTab = TabPesquisa
            End If

        Catch ex As Exception

            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o metodo [btnExcluir_Click]: " + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub grdLista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdLista.CellClick

        Dim con = New Connection

        Try
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
                Exit Sub
            End If

            If e.ColumnIndex = 0 Then

                Dim idProduto = grdLista.Item("IdProduto", e.RowIndex).Value

                Dim produtosAcoes = New ProdutosAcoes

                con.OpenConnection()
                Dim produtos = produtosAcoes.Detalhe(con, idProduto)
                con.CloseConnection()

                If produtos.IdProduto > 0 Then

                    txtCodigo.Text = produtos.IdProduto
                    txtDescricao.Text = produtos.Descricao
                    txtValor.Text = produtos.Valor.ToString("#######0.00")
                    chkAtivo.Checked = produtos.Ativo
                    _funcoes.BuscaIndex(cmbCategoriaProduto, produtos.IdCategoriaProduto)  'Pega o ide procura o Id dentro das linhas da combo.

                    TabGeral.SelectedTab = TabCadastro

                End If

            End If

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
                MsgBox("Houve um erro ao tentar executar o método [grdLista_CellClick]: " + ex.Message, MsgBoxStyle.Critical)
            End Try

        End Try
    End Sub

End Class








