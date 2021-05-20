Imports Pizzaria.ClassesGenerica

Public Class FrmEntradaProduto

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

                .Columns(0).Name = "Exibir"
                .Columns(1).Name = "idEntrada"
                .Columns(2).Name = "Fornecedor"
                .Columns(3).Name = "dataEntrada"

                .Columns("Exibir").HeaderText = ""
                .Columns("idEntrada").HeaderText = "Codigo"
                .Columns("Fornecedor").HeaderText = "Fornecedor"
                .Columns("dataEntrada").HeaderText = "Data de Entrada"

                .Columns("Exibir").Width = 70
                .Columns("idEntrada").Width = 80
                .Columns("Fornecedor").Width = 280
                .Columns("dataEntrada").Width = 130

                .Columns("Exibir").ReadOnly = True
                .Columns("idEntrada").ReadOnly = True
                .Columns("Fornecedor").ReadOnly = True
                .Columns("dataEntrada").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("idEntrada").Visible = True
                .Columns("Fornecedor").Visible = True
                .Columns("dataEntrada").Visible = True


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
                .Columns.Add(New DataGridViewTextBoxColumn())

                .Columns(0).Name = "Remover"
                .Columns(1).Name = "IdProduto"
                .Columns(2).Name = "Produto"
                .Columns(3).Name = "Quantidade"
                .Columns(4).Name = "Valor"
                .Columns(5).Name = "DataValidade"

                .Columns("Remover").HeaderText = ""
                .Columns("IdProduto").HeaderText = "IdProduto"
                .Columns("Produto").HeaderText = "Produto"
                .Columns("Quantidade").HeaderText = "Quantidade"
                .Columns("Valor").HeaderText = "Valor"
                .Columns("DataValidade").HeaderText = "Data Validade"

                .Columns("Remover").Width = 70
                .Columns("IdProduto").Width = 0
                .Columns("Produto").Width = 250
                .Columns("Quantidade").Width = 90
                .Columns("Valor").Width = 75
                .Columns("DataValidade").Width = 75

                .Columns("Remover").ReadOnly = True
                .Columns("IdProduto").ReadOnly = True
                .Columns("Produto").ReadOnly = True
                .Columns("Quantidade").ReadOnly = True
                .Columns("Valor").ReadOnly = True
                .Columns("DataValidade").ReadOnly = True

                .Columns("Remover").Visible = True
                .Columns("IdProduto").Visible = False
                .Columns("Produto").Visible = True
                .Columns("Quantidade").Visible = True
                .Columns("Valor").Visible = True
                .Columns("DataValidade").Visible = True

            End With

        Catch ex As Exception
            Throw
        End Try

    End Sub


    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        txtCodigo.Text = ""
        cmbFuncionario.SelectedIndex = 0
        txtFornecedor.Text = ""
        txtNotaFiscal.Text = ""
        mskDataEntrada.Text = Now.ToString("dd/MM/yyyy")
        txtObservacao.Text = ""

        cmbProduto.SelectedIndex = 0
        txtValor.Text = ""
        txtQuantidade.Text = ""
        mskDataValidade.Text = ""

        txtQuantidadeTotal.Text = 0
        txtValorTotal.Text = 0

        grdProduto.Rows.Clear()
        cmbProduto.Focus()

    End Sub


    Private Function ValidarFormulario() As Boolean

        Try
            If cmbFuncionario.Text.Trim = "" Then
                MsgBox("Preencha o nome do funcionario responsável", MsgBoxStyle.Exclamation)
                cmbFuncionario.Focus()
                Return False
            End If

            If txtFornecedor.Text.Trim = "" Then
                MsgBox("Preencha o Fornecedor do Produto", MsgBoxStyle.Exclamation)
                txtFornecedor.Focus()
                Return False
            End If

            If txtNotaFiscal.Text.Trim = "" Then
                MsgBox("Preencha o numero da Nota Fiscal", MsgBoxStyle.Exclamation)
                txtFornecedor.Focus()
                Return False
            End If

            If Not IsDate(mskDataEntrada.Text) Then
                MsgBox("Preencha a data de entrada do Produto", MsgBoxStyle.Exclamation)
                mskDataEntrada.Focus()
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

            Dim entrada = New EntradaEstoque

            If IsNumeric(txtCodigo.Text) Then
                entrada.IdEntrada = txtCodigo.Text
            End If

            entrada.Funcionario.IdFuncionario = _funcoes.PegaIdCombo(cmbFuncionario)
            entrada.Fornecedor = txtFornecedor.Text
            entrada.NotaFiscal = txtNotaFiscal.Text
            entrada.DataEntrada = mskDataEntrada.Text
            entrada.Observacao = txtObservacao.Text
            entrada.ValorTotal = txtValorTotal.Text
            entrada.QuantidadeTotal = txtQuantidadeTotal.Text


            With grdProduto

                For i As Short = 0 To .Rows.Count - 1

                    Dim EntradaProduto = New EntradaProduto

                    EntradaProduto.Produto.IdProduto = .Item("IdProduto", i).Value       'Não precisa do Nome porque vai salvar no BD com o IdProduto.
                    EntradaProduto.Quantidade = .Item("Quantidade", i).Value
                    EntradaProduto.Valor = .Item("Valor", i).Value
                    EntradaProduto.DataValidade = .Item("DataValidade", i).Value

                    entrada.ListaEntradaProduto.Add(EntradaProduto)
                Next

            End With

            Dim EntradaProdutoAcoes = New EntradaProdutoAcoes()

            con.OpenConnection()
            Dim salvou = EntradaProdutoAcoes.Salvar(con, entrada)
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

                Dim EntradaProdutoAcoes = New EntradaProdutoAcoes

                con.OpenConnection()
                Dim lista = EntradaProdutoAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdEntrada", i).Value = lista(i).idEntrada
                        .Item("Fornecedor", i).Value = lista(i).Fornecedor
                        .Item("dataEntrada", i).Value = lista(i).DataEntrada.ToString("dd/MM/yyyy")

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

                Dim idEntrada = grdLista.Item("idEntrada", e.RowIndex).Value

                Dim entradaAcoes = New EntradaProdutoAcoes

                con.OpenConnection()
                Dim entrada = entradaAcoes.Detalhe(con, idEntrada)
                con.CloseConnection()

                If entrada.idEntrada > 0 Then

                    txtCodigo.Text = entrada.idEntrada
                    _funcoes.BuscaIndex(cmbFuncionario, entrada.Funcionario.IdFuncionario)
                    txtFornecedor.Text = entrada.Fornecedor
                    txtNotaFiscal.Text = entrada.NotaFiscal
                    mskDataEntrada.Text = entrada.DataEntrada
                    txtObservacao.Text = entrada.Observacao
                    txtQuantidadeTotal.Text = entrada.QuantidadeTotal
                    txtValorTotal.Text = entrada.ValorTotal

                    With grdProduto


                        For i As Short = 0 To entrada.ListaEntradaProduto.Count - 1

                            .Rows.Add()

                            .Item("Remover", i).Value = "Remover"
                            .Item("IdProduto", i).Value = entrada.ListaEntradaProduto(i).Produto.IdProduto
                            .Item("Produto", i).Value = entrada.ListaEntradaProduto(i).Produto.Descricao
                            .Item("Quantidade", i).Value = entrada.ListaEntradaProduto(i).Quantidade
                            .Item("Valor", i).Value = entrada.ListaEntradaProduto(i).Valor.ToString("#######0.00")

                            If entrada.ListaEntradaProduto(i).DataValidade = "0001/01/01" Then
                                .Item("DataValidade", i).Value = ""
                            Else
                                .Item("DataValidade", i).Value = entrada.ListaEntradaProduto(i).DataValidade
                            End If


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

                    Dim IdEntrada = txtCodigo.Text

                    Dim entradaAcoes = New EntradaProdutoAcoes

                    con.OpenConnection()
                    Dim excluiu = entradaAcoes.Excluir(con, IdEntrada)
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

                Dim entradaAcoes = New EntradaProdutoAcoes

                If .Rows.Count > 0 Then

                    Dim idProdutoSelecionada = _funcoes.PegaIdCombo(cmbProduto)

                    For i As UShort = 0 To .Rows.Count - 1

                        If idProdutoSelecionada = .Item("IdProduto", i).Value Then

                            MsgBox("Este produto já foi adicionado", MsgBoxStyle.Exclamation)
                            Exit Sub

                        End If
                    Next
                End If

                If mskDataValidade.Text = "" Then

                    mskDataValidade.Text = "0001/01/01"            'Data padrão

                End If


                .Rows.Add()

                .Item("Remover", .Rows.Count - 1).Value = "Remover"
                .Item("idProduto", .Rows.Count - 1).Value = _funcoes.PegaIdCombo(cmbProduto)
                .Item("Produto", .Rows.Count - 1).Value = cmbProduto.Text
                .Item("Quantidade", .Rows.Count - 1).Value = txtQuantidade.Text
                .Item("Valor", .Rows.Count - 1).Value = CDec(txtValor.Text) * CDec(txtQuantidade.Text)

                If mskDataValidade.Text = "0001/01/01" Then
                    .Item("DataValidade", .Rows.Count - 1).Value = ""
                Else
                    .Item("DataValidade", .Rows.Count - 1).Value = mskDataValidade.Text
                End If




                Dim valorTotal As Decimal                           'Adicionar o Valor da produto no Valor Total.
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