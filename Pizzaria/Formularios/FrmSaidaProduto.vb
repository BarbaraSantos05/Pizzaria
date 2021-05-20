Imports Pizzaria.ClassesGenerica

Public Class FrmSaidaProduto

    Dim _funcoes As New Funcoes(Me)

    Private Sub FrmEntradaProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            _funcoes.AtribuirEventos(Me)
            Call ConfiguraGrid()
            Call ConfiguraGridProduto()

        Catch ex As Exception
            MsgBox("Houve um erro ao tentar executar o método [FrmEntradaProduto_Load]: " + ex.Message, MsgBoxStyle.Critical)
        End Try

        Call New ProdutosAcoes().PreencheComboProdutos(cmbProduto)
        Call New FuncionariosAcoes().PreencheComboFuncionario(cmbFuncionario)

    End Sub

    Private Sub ConfiguraGrid()

        Try

            With grdLista

                .RowCount = 0
                .ColumnCount = 0

                .Columns.Add(New DataGridViewButtonColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())

                .Columns(0).Name = "Exibir"
                .Columns(1).Name = "idSaida"
                .Columns(2).Name = "idPedido"
                .Columns(3).Name = "idFuncionario"
                .Columns(4).Name = "dataSaida"

                .Columns("Exibir").HeaderText = ""
                .Columns("idSaida").HeaderText = "Codigo"
                .Columns("idPedido").HeaderText = "Nº Pedido"
                .Columns("idFuncionario").HeaderText = "Funcionário"
                .Columns("dataSaida").HeaderText = "Data de Saida"

                .Columns("Exibir").Width = 70
                .Columns("idSaida").Width = 80
                .Columns("idPedido").Width = 80
                .Columns("idFuncionario").Width = 200
                .Columns("dataSaida").Width = 120

                .Columns("Exibir").ReadOnly = True
                .Columns("idSaida").ReadOnly = True
                .Columns("idPedido").ReadOnly = True
                .Columns("idFuncionario").ReadOnly = True
                .Columns("dataSaida").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("idSaida").Visible = True
                .Columns("idPedido").Visible = True
                .Columns("idFuncionario").Visible = True
                .Columns("dataSaida").Visible = True

            End With
        Catch ex As Exception
            Throw
        End Try

    End Sub


    Private Sub ConfiguraGridProduto()

        Try

            With grdProduto

                .RowCount = 0
                .ColumnCount = 0

                .Columns.Add(New DataGridViewButtonColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())

                .Columns(0).Name = "Remover"
                .Columns(1).Name = "IdProduto"
                .Columns(2).Name = "Produto"
                .Columns(3).Name = "Quantidade"
                .Columns(4).Name = "Valor"

                .Columns("Remover").HeaderText = ""
                .Columns("IdProduto").HeaderText = "IdProduto"
                .Columns("Produto").HeaderText = "Produto"
                .Columns("Quantidade").HeaderText = "Quantidade"
                .Columns("Valor").HeaderText = "Valor"


                .Columns("Remover").Width = 70
                .Columns("IdProduto").Width = 0
                .Columns("Produto").Width = 293
                .Columns("Quantidade").Width = 90
                .Columns("Valor").Width = 75

                .Columns("Remover").ReadOnly = True
                .Columns("IdProduto").ReadOnly = True
                .Columns("Produto").ReadOnly = True
                .Columns("Quantidade").ReadOnly = True
                .Columns("Valor").ReadOnly = True

                .Columns("Remover").Visible = True
                .Columns("IdProduto").Visible = False
                .Columns("Produto").Visible = True
                .Columns("Quantidade").Visible = True
                .Columns("Valor").Visible = True
            End With

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        txtCodigo.Text = ""

        txtObservacao.Text = ""
        maskDataSaida.Text = Now.ToString("dd/MM/yyyy")
        cmbProduto.SelectedIndex = 0
        txtValor.Text = ""
        txtQuantidade.Text = ""
        txtQuantidadeTotal.Text = 0
        txtValorTotal.Text = 0

        '_funcoes.BuscaIndex(cmbFuncionario, MdiPizzaria.FuncionarioLogado.IdFuncionario)

        grdProduto.Rows.Clear()
        cmbFuncionario.Focus()

    End Sub

    Private Function ValidarFormulario() As Boolean

        Try
            If cmbFuncionario.Text.Trim = "" Then
                MsgBox("Preencha o nome do funcionario responsável", MsgBoxStyle.Exclamation)
                cmbFuncionario.Focus()
                Return False
            End If

            If Not IsDate(maskDataSaida.Text) Then
                MsgBox("Preencha a data de saida  do Produto", MsgBoxStyle.Exclamation)
                maskDataSaida.Focus()
                Return False
            End If

            If grdProduto.Rows.Count = 0 Then
                MsgBox("Preencha o produto ", MsgBoxStyle.Exclamation)
                cmbProduto.Focus()
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

            Dim saida = New SaidaEstoque

            If IsNumeric(txtCodigo.Text) Then
                saida.IdSaida = txtCodigo.Text
            End If

            saida.idFuncionario = _funcoes.PegaIdCombo(cmbFuncionario)
            saida.Observacao = txtObservacao.Text
            saida.DataSaida = maskDataSaida.Text
            saida.ValorTotal = Val(txtValorTotal.Text)
            saida.QuantidadeTotal = Val(txtQuantidadeTotal.Text)

            With grdProduto

                For i As Short = 0 To .Rows.Count - 1

                    Dim SaidaProduto = New SaidaProduto

                    SaidaProduto.Produto.IdProduto = .Item("IdProduto", i).Value       'Não precisa do Nome porque vai salvar no BD com o IdProduto.
                    SaidaProduto.Quantidade = .Item("Quantidade", i).Value
                    SaidaProduto.Valor = .Item("Valor", i).Value

                    saida.ListaSaidaProduto.Add(SaidaProduto)
                Next

            End With

            Dim SaidaProdutoAcoes = New SaidaProdutoAcoes()

            con.OpenConnection()
            Dim salvou = SaidaProdutoAcoes.Salvar(con, saida)
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

                Dim SaidaProdutoAcoes = New SaidaProdutoAcoes

                con.OpenConnection()
                Dim lista = SaidaProdutoAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdSaida", i).Value = lista(i).IdSaida
                        .Item("idPedido", i).Value = lista(i).idPedido
                        .Item("idFuncionario", i).Value = lista(i).Nome
                        .Item("dataSaida", i).Value = lista(i).DataSaida.ToString("dd/MM/yyyy")

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


    Private Sub grdLista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdLista.CellClick

        Dim con = New Connection

        Try
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
                Exit Sub
            End If

            If e.ColumnIndex = 0 Then

                grdProduto.Rows.Clear()

                Dim idSaida = grdLista.Item("idSaida", e.RowIndex).Value

                Dim saidaAcoes = New SaidaProdutoAcoes

                con.OpenConnection()
                Dim saida = saidaAcoes.Detalhe(con, idSaida)
                con.CloseConnection()

                If saida.IdSaida > 0 Then

                    txtCodigo.Text = saida.IdSaida
                    _funcoes.BuscaIndex(cmbFuncionario, saida.idFuncionario)
                    maskDataSaida.Text = saida.DataSaida
                    txtObservacao.Text = saida.Observacao
                    txtQuantidadeTotal.Text = saida.QuantidadeTotal
                    txtValorTotal.Text = saida.ValorTotal.ToString("#######0.00")

                    With grdProduto

                        For i As Short = 0 To saida.ListaSaidaProduto.Count - 1

                            .Rows.Add()

                            .Item("Remover", i).Value = "Remover"
                            .Item("IdProduto", i).Value = saida.ListaSaidaProduto(i).Produto.IdProduto
                            .Item("Produto", i).Value = saida.ListaSaidaProduto(i).Produto.Descricao
                            .Item("Quantidade", i).Value = saida.ListaSaidaProduto(i).Quantidade
                            .Item("Valor", i).Value = saida.ListaSaidaProduto(i).Valor.ToString("#######0.00")

                        Next
                    End With

                    TabGeral.SelectedTab = TabCadastro

                End If
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
                Dim resposta = MsgBox("Tem certeza que deseja excluir o registro? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir")

                If resposta = MsgBoxResult.Yes Then

                    Dim IdSaida = txtCodigo.Text

                    Dim SaidaAcoes = New SaidaProdutoAcoes

                    con.OpenConnection()
                    Dim excluiu = SaidaAcoes.Excluir(con, IdSaida)
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
                MsgBox("Selecione o produto que deseja excluir" + MsgBoxStyle.Exclamation)
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

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click

        Dim con = New Connection

        Try

            With grdProduto

                Dim saidaAcoes = New SaidaProdutoAcoes

                If .Rows.Count > 0 Then

                    Dim idProdutoSelecionada = _funcoes.PegaIdCombo(cmbProduto)

                    For i As UShort = 0 To .Rows.Count - 1

                        If idProdutoSelecionada = .Item("IdProduto", i).Value Then
                            MsgBox("Este produto já foi adicionado", MsgBoxStyle.Exclamation)
                            Exit Sub
                        End If
                    Next
                End If

                .Rows.Add()

                .Item("Remover", .Rows.Count - 1).Value = "Remover"
                .Item("idProduto", .Rows.Count - 1).Value = _funcoes.PegaIdCombo(cmbProduto)
                .Item("Produto", .Rows.Count - 1).Value = cmbProduto.Text
                .Item("Quantidade", .Rows.Count - 1).Value = txtQuantidade.Text
                .Item("Valor", .Rows.Count - 1).Value = CDec(txtValor.Text) * CDec(txtQuantidade.Text)


                Dim valorTotal As Decimal
                Dim quantidadeTotal As Decimal

                For i As UShort = 0 To grdProduto.Rows.Count - 1
                    valorTotal += grdProduto.Item("Valor", i).Value
                    quantidadeTotal += grdProduto.Item("Quantidade", i).Value
                Next

                txtValorTotal.Text = valorTotal
                txtQuantidadeTotal.Text = quantidadeTotal

            End With

        Catch ex As Exception

            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [btnAdicionarPizza_Click]: " + ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub grdProduto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdProduto.CellClick

        Dim con = New Connection

        Try
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
                Exit Sub
            End If

            If e.ColumnIndex = 0 Then

                grdProduto.Rows.RemoveAt(e.RowIndex)

                If grdProduto.Rows.Count > 0 Then

                    Dim valorProduto As Decimal
                    Dim quantidadeTotal As Decimal

                    For i As UShort = 0 To grdProduto.Rows.Count - 1         'Subtrair o valor da Produto excluido do valor total
                        valorProduto += grdProduto.Item("Valor", i).Value
                        quantidadeTotal += grdProduto.Item("Quantidade", i).Value
                    Next

                    txtValorTotal.Text = valorProduto
                    txtQuantidadeTotal.Text = quantidadeTotal

                Else
                    txtValorTotal.Text = ""
                    txtQuantidadeTotal.Text = ""
                End If

            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub


    Private Sub cmbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduto.SelectedIndexChanged

        Dim con = New Connection

        Try

            con.OpenConnection()
            Dim produto = New ProdutosAcoes().Detalhe(con, _funcoes.PegaIdCombo(cmbProduto))
            con.CloseConnection()

            If produto.IdProduto > 0 Then
                txtValor.Text = produto.Valor.ToString("######0.00")
                txtQuantidade.Focus()
            End If

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try
            MsgBox("Houve um erro ao tentar buscar o valor do produto:" + ex.Message, vbCritical)
        End Try

    End Sub
End Class