Imports MySql.Data.MySqlClient
Imports Pizzaria.ClassesGenerica
Imports Pizzaria.PizzaAcoes


Public Class FrmPedidos

    Dim _funcoes As New Funcoes(Me)     'Tem que chamar pra poder aparecer a combo

    Private Sub FrmPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            _funcoes.AtribuirEventos(Me)                'Serve para a tela ficar colorida e aparecer a data.
            Call ConfiguraGrid()                        'Grid da pesquisa
            Call ConfiguraGridPizza()                   'Grid das Pizzas
            Call ConfiguraGridProduto()                 'Grid dos Produtos

        Catch ex As Exception
            MsgBox("Houve um erro ao tentar executar o método [FrmCadPizza_Load]: " + ex.Message, MsgBoxStyle.Critical)
        End Try

        Call New PizzaAcoes().PreencheComboPizza(cmbPizza)                'Vai preencher as combos com id e o nome 
        Call New FuncionariosAcoes().PreencheComboFuncionario(cmbFuncionario)
        Call New ProdutosAcoes().PreencheComboProdutos(cmbProduto)
        Call New ClientesAcoes().PreencheComboCliente(cmbCliente)
        Call New ProdutosAcoes().PreencheComboProdutos(cmbProduto)
        Call New PagamentosAcoes().PreencheComboPagamento(cmbPagamento)

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
                .Columns(1).Name = "idPedido"
                .Columns(2).Name = "idCliente"
                .Columns(3).Name = "DataPedido"

                .Columns("Exibir").HeaderText = ""
                .Columns("idPedido").HeaderText = "Pedido"
                .Columns("idCliente").HeaderText = "Cliente"
                .Columns("DataPedido").HeaderText = "Data do Pedido"

                .Columns("Exibir").Width = 70
                .Columns("idPedido").Width = 80
                .Columns("idCliente").Width = 290
                .Columns("DataPedido").Width = 130


                .Columns("Exibir").ReadOnly = True
                .Columns("idPedido").ReadOnly = True
                .Columns("idCliente").ReadOnly = True
                .Columns("DataPedido").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("idPedido").Visible = True
                .Columns("idCliente").Visible = True
                .Columns("DataPedido").Visible = True

            End With


        Catch ex As Exception
            Throw
        End Try

    End Sub


    Private Sub ConfiguraGridPizza()

        Try

            With grdPizza

                .RowCount = 0
                .ColumnCount = 0

                .Columns.Add(New DataGridViewButtonColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())

                .Columns(0).Name = "Remover"
                .Columns(1).Name = "Quantidade"
                .Columns(2).Name = "SaborPizza"
                .Columns(3).Name = "Valor"
                .Columns(4).Name = "IdPizza"

                .Columns("Remover").HeaderText = ""
                .Columns("Quantidade").HeaderText = "Quantidade"
                .Columns("SaborPizza").HeaderText = "Pizza"
                .Columns("Valor").HeaderText = "Valor"
                .Columns("IdPizza").HeaderText = "IdPizza"


                .Columns("Remover").Width = 70
                .Columns("Quantidade").Width = 90
                .Columns("SaborPizza").Width = 293
                .Columns("Valor").Width = 70
                .Columns("IdPizza").Width = 0

                .Columns("Remover").ReadOnly = True
                .Columns("Quantidade").ReadOnly = True
                .Columns("SaborPizza").ReadOnly = True
                .Columns("Valor").ReadOnly = True
                .Columns("IdPizza").ReadOnly = True

                .Columns("Remover").Visible = True
                .Columns("Quantidade").Visible = True
                .Columns("SaborPizza").Visible = True
                .Columns("Valor").Visible = True
                .Columns("IdPizza").Visible = False

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
                .Columns(1).Name = "Quantidade"
                .Columns(2).Name = "Produto"
                .Columns(3).Name = "Valor"
                .Columns(4).Name = "IdProduto"

                .Columns("Remover").HeaderText = ""
                .Columns("Quantidade").HeaderText = "Quantidade"
                .Columns("Produto").HeaderText = "Produto"
                .Columns("Valor").HeaderText = "Valor"
                .Columns("IdProduto").HeaderText = "IdProduto"


                .Columns("Remover").Width = 70
                .Columns("Quantidade").Width = 90
                .Columns("Produto").Width = 293
                .Columns("Valor").Width = 70
                .Columns("IdProduto").Width = 0

                .Columns("Remover").ReadOnly = True
                .Columns("Quantidade").ReadOnly = True
                .Columns("Produto").ReadOnly = True
                .Columns("Valor").ReadOnly = True
                .Columns("IdProduto").ReadOnly = True

                .Columns("Remover").Visible = True
                .Columns("Quantidade").Visible = True
                .Columns("Produto").Visible = True
                .Columns("Valor").Visible = True
                .Columns("IdProduto").Visible = False

            End With

        Catch ex As Exception
            Throw
        End Try

    End Sub


    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click


        txtCodigo.Text = ""
        txtDataPedido.Text = ""
        cmbFuncionario.SelectedIndex = 0

        'Cliente
        cmbCliente.SelectedIndex = 0       'Para preencher a combo com a primeira linha vazia
        txtEndereco.Text = ""
        txtTelefone.Text = ""

        'Pizza
        cmbPizza.SelectedIndex = 0
        txtValorPizza.Text = ""
        txtQuantidadePizza.Text = ""

        txtObservacao.Text = ""

        'Produto
        cmbProduto.SelectedIndex = 0
        txtValorProduto.Text = ""
        txtQuantidadeProduto.Text = ""

        'Pagamento
        cmbPagamento.SelectedIndex = 0

        txtQuantidadeTotal.Text = ""
        txtValorTotal.Text = ""

        grdPizza.Rows.Clear()                          'Vai limpar toda a grid de pizza
        grdProduto.Rows.Clear()                        'Vai limpar toda a grid de produto             

        cmbCliente.Focus()
    End Sub

    Private Function ValidarFormulario() As Boolean    'Tudo o que não pode ficar sem preencher.

        Try

            If cmbFuncionario.Text.Trim = "" Then
                MsgBox("Preencha o nome do funcionario responsável", MsgBoxStyle.Exclamation)
                cmbFuncionario.Focus()
                Return False
            End If

            If txtDataPedido.Text.Trim = "" Then
                MsgBox("Preencha a data do Pedido", MsgBoxStyle.Exclamation)
                txtDataPedido.Focus()
                Return False
            End If

            If cmbCliente.Text.Trim = "" Then
                MsgBox("Preencha o nome do cliente", MsgBoxStyle.Exclamation)
                cmbCliente.Focus()
                Return False
            End If


            If grdPizza.Rows.Count = 0 And grdProduto.Rows.Count = 0 Then
                MsgBox("Preencha a quantidade de pizzas ou produtos solicitados ", MsgBoxStyle.Exclamation)
                cmbPizza.Focus()
                Return False
            End If

            If cmbPagamento.Text.Trim = "" Then
                MsgBox("Preencha a forma de pagamento ", MsgBoxStyle.Exclamation)
                cmbPagamento.Focus()
                Return False
            End If

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim con = New Connection                  'Instancia uma conexão

        Try
            Dim validado = ValidarFormulario()         'Ver se está tudo preenchido.

            If validado = False Then                   'Se for falso vai sair do método
                Exit Sub
            End If

            Dim pedido = New Pedido                   'Instancia uma classe e determina aonde cada atributo vai ficar salvo.           

            If IsNumeric(txtCodigo.Text) Then
                pedido.IdPedido = txtCodigo.Text
            End If

            pedido.DataPedido = txtDataPedido.Text
            pedido.Funcionario.IdFuncionario = _funcoes.PegaIdCombo(cmbFuncionario)

            'Cliente
            pedido.Cliente.IdCliente = _funcoes.PegaIdCombo(cmbCliente)

            Dim endereco = pedido.Cliente.Logradouro + pedido.Cliente.Numero.ToString() + pedido.Cliente.Complemento
            endereco = txtEndereco.Text                       'Vai aparecer todos os dados do Cliente concatenados no campo de Endereço.

            pedido.Cliente.TelCelular = txtTelefone.Text

            pedido.Observacao = txtObservacao.Text

            If IsNumeric(_funcoes.PegaIdCombo(cmbPagamento)) Then
                pedido.IdPagamento = _funcoes.PegaIdCombo(cmbPagamento)
            End If

            If IsNumeric(txtValorTotal.Text) Then
                pedido.ValorTotal = txtValorTotal.Text
            End If

            If IsNumeric(txtQuantidadeTotal.Text) Then
                pedido.QuantidadeTotal = txtQuantidadeTotal.Text
            End If

            With grdPizza

                For i As Short = 0 To .Rows.Count - 1

                    Dim pedidoPizza = New PedidoPizza

                    pedidoPizza.Pizza.IdPizza = .Item("IdPizza", i).Value
                    pedidoPizza.Quantidade = .Item("Quantidade", i).Value
                    pedidoPizza.Valor = .Item("Valor", i).Value

                    pedido.ListaPedidoPizza.Add(pedidoPizza)

                Next

            End With

            With grdProduto

                For i As Short = 0 To .Rows.Count - 1

                    Dim pedidoProduto = New PedidoProduto

                    pedidoProduto.Produto.IdProduto = .Item("IdProduto", i).Value       'Não precisa do Nome porque vai salvar no BD com o IdProduto.
                    pedidoProduto.Quantidade = .Item("Quantidade", i).Value
                    pedidoProduto.Valor = .Item("Valor", i).Value

                    pedido.ListaPedidoProduto.Add(pedidoProduto)
                Next

            End With

            Dim pedidoAcoes = New PedidoAcoes()

            con.OpenConnection()
            Dim salvou = pedidoAcoes.Salvar(con, pedido)
            con.CloseConnection()


            Dim saida = New SaidaEstoque                                  'instancia uma classe Saida

            saida.idPedido = pedido.IdPedido                             ' Compara Objeto SaidaEstoque = Objeto Pedido
            saida.idFuncionario = pedido.Funcionario.IdFuncionario
            saida.DataSaida = pedido.DataPedido
            saida.Observacao = pedido.Observacao


            Dim valorTotalGridProduto As Decimal
            Dim quantidadeTotalGridProduto As UShort

            For i As UShort = 0 To pedido.ListaPedidoProduto.Count - 1

                Dim produto = New SaidaProduto

                produto.Produto.IdProduto = pedido.ListaPedidoProduto(i).Produto.IdProduto
                produto.Quantidade = pedido.ListaPedidoProduto(i).Quantidade
                produto.Valor = pedido.ListaPedidoProduto(i).Valor


                valorTotalGridProduto += produto.Valor
                quantidadeTotalGridProduto += produto.Quantidade

                saida.ListaSaidaProduto.Add(produto)

            Next

            saida.QuantidadeTotal = quantidadeTotalGridProduto
            saida.ValorTotal = valorTotalGridProduto


            Dim saidaAcoes = New SaidaProdutoAcoes()
            con.OpenConnection()
            Dim salvarSaida = saidaAcoes.Salvar(con, saida)
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

                Dim pedidoAcoes = New PedidoAcoes

                con.OpenConnection()
                Dim lista = pedidoAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then
                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdPedido", i).Value = lista(i).IdPedido
                        .Item("IdCliente", i).Value = lista(i).Cliente.Nome
                        .Item("DataPedido", i).Value = lista(i).DataPedido
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

    Private Sub grdLista_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdLista.CellContentClick

        Dim con = New Connection

        Try

            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
                Exit Sub
            End If

            If e.ColumnIndex = 0 Then

                grdPizza.Rows.Clear()
                grdProduto.Rows.Clear()

                Dim idPedido = grdLista.Item("IdPedido", e.RowIndex).Value

                Dim pedidoAcoes = New PedidoAcoes

                con.OpenConnection()
                Dim pedido = pedidoAcoes.Detalhe(con, idPedido)
                con.CloseConnection()

                If pedido.IdPedido > 0 Then

                    txtCodigo.Text = pedido.IdPedido
                    _funcoes.BuscaIndex(cmbFuncionario, pedido.Funcionario.IdFuncionario)       'Busca o IdFuncionario mesmo que não seja igual ao indice.
                    txtDataPedido.Text = pedido.DataPedido
                    _funcoes.BuscaIndex(cmbCliente, pedido.Cliente.IdCliente)
                    _funcoes.BuscaIndex(cmbPagamento, pedido.IdPagamento)
                    txtValorTotal.Text = pedido.ValorTotal
                    txtQuantidadeTotal.Text = pedido.QuantidadeTotal
                    chkLevarMaquininha.Checked = pedido.LevarMaquininha

                    With grdPizza

                        For i As Short = 0 To pedido.ListaPedidoPizza.Count - 1

                            .Rows.Add()

                            .Item("Remover", i).Value = "Remover"
                            .Item("Quantidade", i).Value = pedido.ListaPedidoPizza(i).Quantidade
                            .Item("SaborPizza", i).Value = pedido.ListaPedidoPizza(i).Pizza.Nome
                            .Item("Valor", i).Value = pedido.ListaPedidoPizza(i).Valor.ToString("#######0.00")
                            .Item("IdPizza", i).Value = pedido.ListaPedidoPizza(i).Pizza.IdPizza

                        Next
                    End With

                    With grdProduto

                        For i As Short = 0 To pedido.ListaPedidoProduto.Count - 1

                            .Rows.Add()

                            .Item("Remover", i).Value = "Remover"
                            .Item("Quantidade", i).Value = pedido.ListaPedidoProduto(i).Quantidade
                            .Item("Produto", i).Value = pedido.ListaPedidoProduto(i).Produto.Descricao
                            .Item("Valor", i).Value = pedido.ListaPedidoProduto(i).Valor.ToString("#######0.00")
                            .Item("IdProduto", i).Value = pedido.ListaPedidoProduto(i).Produto.IdProduto

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

                Dim resposta = MsgBox("Tem certeza que deseja excluir o registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir")

                If resposta = MsgBoxResult.Yes Then

                    Dim idPedido = txtCodigo.Text

                    Dim pedidoAcoes = New PedidoAcoes             ' Instancia uma classe

                    con.OpenConnection()
                    Dim excluiu = pedidoAcoes.Excluir(con, idPedido)           ' Chama o metodo excluir que está na classe PedidoAcoes
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

    Private Sub btnAdicionarPizza_Click(sender As Object, e As EventArgs) Handles btnAdicionarPizza.Click

        Dim con = New Connection

        Try

            With grdPizza

                Dim pedidoAcoes = New PedidoAcoes

                If .Rows.Count > 0 Then

                    Dim idPizzaSelecionada = _funcoes.PegaIdCombo(cmbPizza)

                    For i As UShort = 0 To .Rows.Count - 1

                        If idPizzaSelecionada = .Item("IdPizza", i).Value Then
                            MsgBox("Este produto já foi adicionado", MsgBoxStyle.Exclamation)
                            Exit Sub
                        End If
                    Next
                End If

                .Rows.Add()

                .Item("Remover", .Rows.Count - 1).Value = "Remover"
                .Item("Quantidade", .Rows.Count - 1).Value = txtQuantidadePizza.Text
                .Item("SaborPizza", .Rows.Count - 1).Value = cmbPizza.Text
                .Item("Valor", .Rows.Count - 1).Value = CDec(txtValorPizza.Text) * CDec(txtQuantidadePizza.Text)
                .Item("IdPizza", .Rows.Count - 1).Value = _funcoes.PegaIdCombo(cmbPizza)


                Dim valorTotalGridPizza As Decimal                          'Adicionar o Valor da produto no Valor Total.
                Dim quantidadeTotalGridPizza As UShort
                Dim valorTotalGridProduto As Decimal
                Dim quantidadeTotalGridProduto As UShort


                If grdProduto.Rows.Count > 0 Then         'Para adicionar o valor da pizza no valor total, primeiro tem que ver se a grid do produto > 0. Se for, irá somar as duas grids

                    For i As UShort = 0 To grdProduto.Rows.Count - 1

                        valorTotalGridProduto += grdProduto.Item("Valor", i).Value
                        quantidadeTotalGridProduto += grdProduto.Item("Quantidade", i).Value

                    Next

                    txtValorTotal.Text = valorTotalGridProduto
                    txtQuantidadeTotal.Text = quantidadeTotalGridProduto

                    For i As UShort = 0 To grdPizza.Rows.Count - 1

                        valorTotalGridPizza += grdPizza.Item("Valor", i).Value
                        quantidadeTotalGridPizza += grdPizza.Item("Quantidade", i).Value

                    Next

                    txtValorTotal.Text = valorTotalGridPizza
                    txtQuantidadeTotal.Text = quantidadeTotalGridPizza

                Else                                                                        ' Se a grid de produto estiver vazia, irá somar somente o valor da grid da pizza

                    For i As UShort = 0 To grdPizza.Rows.Count - 1

                        valorTotalGridPizza += grdPizza.Item("Valor", i).Value
                        quantidadeTotalGridPizza += grdPizza.Item("Quantidade", i).Value

                    Next

                    txtValorTotal.Text = valorTotalGridPizza
                    txtQuantidadeTotal.Text = quantidadeTotalGridPizza

                End If
                txtValorTotal.Text = valorTotalGridPizza + valorTotalGridProduto                                'Adiciona no txtValortotal.Text
                txtQuantidadeTotal.Text = quantidadeTotalGridPizza + quantidadeTotalGridProduto

                cmbPizza.SelectedIndex = 0
                txtValorPizza.Text = ""
                txtQuantidadePizza.Text = ""
            End With



        Catch ex As Exception

            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [btnAdicionarPizza_Click]: " + ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub grdPizza_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdPizza.CellClick

        Dim con = New Connection

        Try
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
                Exit Sub
            End If

            If e.ColumnIndex = 0 Then                    ' Se o numero de colunas for = 0

                Dim valorTotalGridPizza As Decimal
                Dim quantidadeTotalGridPizza As UShort
                Dim valorTotalGridProduto As Decimal
                Dim quantidadeTotalGridProduto As UShort

                If grdProduto.Rows.Count > 0 Then                 'Se numero de contagem de linhas for maior que 0

                    For i As UShort = 0 To grdProduto.Rows.Count - 1

                        valorTotalGridProduto += grdProduto.Item("Valor", i).Value
                        quantidadeTotalGridProduto += grdProduto.Item("Quantidade", i).Value  'Vai somar todos os valores e todas as quantidades da grid de produto e colocar no campo valorTotal e quantidadeTotal   

                    Next

                    txtValorTotal.Text = valorTotalGridProduto
                    txtQuantidadeTotal.Text = quantidadeTotalGridProduto

                End If

                If grdPizza.Rows.Count > 0 Then

                    cmbPizza.Text = grdPizza.Item("SaborPizza", e.RowIndex).Value
                    txtValorPizza.Text = grdPizza.Item("Valor", e.RowIndex).Value
                    txtQuantidadePizza.Text = grdPizza.Item("Quantidade", e.RowIndex).Value

                    cmbPizza.Focus()

                    grdPizza.Rows.RemoveAt(e.RowIndex)                         'Para excluir uma linha de Pizza 

                    For i As UShort = 0 To grdPizza.Rows.Count - 1
                        valorTotalGridPizza += grdPizza.Item("Valor", i).Value
                        quantidadeTotalGridPizza += grdPizza.Item("Quantidade", i).Value               'Vai somar todos os valores e todas as quantidades da grid de pizza e colocar no campo valorTotal e quantidadeTotal
                    Next

                    txtValorTotal.Text = valorTotalGridPizza
                    txtQuantidadeTotal.Text = quantidadeTotalGridPizza

                Else
                    txtValorTotal.Text = ""
                    txtQuantidadeTotal.Text = ""

                End If

                txtValorTotal.Text = valorTotalGridPizza + valorTotalGridProduto
                txtQuantidadeTotal.Text = quantidadeTotalGridPizza + quantidadeTotalGridProduto

            End If

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub btnAdicionarProduto_Click(sender As Object, e As EventArgs) Handles btnAdicionarProduto.Click

        Dim con = New Connection

        Try

            With grdProduto

                Dim pedidoAcoes = New PedidoAcoes

                If .Rows.Count > 0 Then

                    Dim idProdutoSelecionado = _funcoes.PegaIdCombo(cmbProduto)

                    For i As UShort = 0 To .Rows.Count - 1

                        If idProdutoSelecionado = .Item("IdProduto", i).Value Then

                            MsgBox("Este produto já foi adicionado", MsgBoxStyle.Exclamation)

                            Exit Sub
                        End If
                    Next
                End If

                .Rows.Add()

                .Item("Remover", .Rows.Count - 1).Value = "Remover"
                .Item("Quantidade", .Rows.Count - 1).Value = txtQuantidadeProduto.Text
                .Item("Produto", .Rows.Count - 1).Value = cmbProduto.Text
                .Item("Valor", .Rows.Count - 1).Value = CDec(txtValorProduto.Text) * CDec(txtQuantidadeProduto.Text)
                .Item("IdProduto", .Rows.Count - 1).Value = _funcoes.PegaIdCombo(cmbProduto)

                Dim valorTotalGridPizza As Decimal                           'Adicionar o Valor da Produto no Valor Total.
                Dim valorTotalGridProduto As Decimal
                Dim quantidadeTotalGridPizza As UShort
                Dim quantidadeTotalGridProduto As UShort

                If grdPizza.Rows.Count > 0 Then

                    For i As UShort = 0 To grdPizza.Rows.Count - 1

                        valorTotalGridPizza += grdPizza.Item("Valor", i).Value
                        quantidadeTotalGridPizza += grdPizza.Item("Quantidade", i).Value

                    Next

                    txtValorTotal.Text = valorTotalGridPizza
                    txtQuantidadeTotal.Text = quantidadeTotalGridPizza

                    For i As UShort = 0 To grdProduto.Rows.Count - 1

                        valorTotalGridProduto += grdProduto.Item("Valor", i).Value
                        quantidadeTotalGridProduto += grdProduto.Item("Quantidade", i).Value

                    Next

                    txtValorTotal.Text = valorTotalGridProduto
                    txtQuantidadeTotal.Text = quantidadeTotalGridProduto

                Else
                    For i As UShort = 0 To grdProduto.Rows.Count - 1

                        valorTotalGridProduto += grdProduto.Item("Valor", i).Value
                        quantidadeTotalGridProduto += grdProduto.Item("Quantidade", i).Value

                    Next

                    txtValorTotal.Text = valorTotalGridProduto
                    txtQuantidadeTotal.Text = quantidadeTotalGridProduto

                End If

                txtValorTotal.Text = valorTotalGridPizza + valorTotalGridProduto
                txtQuantidadeTotal.Text = quantidadeTotalGridPizza + quantidadeTotalGridProduto

                cmbProduto.Text = 0
                txtValorProduto.Text = ""
                txtQuantidadeProduto.Text = ""


            End With

            cmbProduto.Focus()

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

                Dim valorTotalGridPizza As Decimal
                Dim valorTotalGridProduto As Decimal
                Dim quantidadeTotalGridPizza As UShort
                Dim quantidadeTotalGridProduto As UShort

                If grdPizza.Rows.Count > 0 Then

                    For i As UShort = 0 To grdPizza.Rows.Count - 1

                        valorTotalGridPizza += grdPizza.Item("Valor", i).Value
                        quantidadeTotalGridPizza += grdPizza.Item("Quantidade", i).Value

                    Next

                    txtValorTotal.Text = valorTotalGridPizza
                    txtQuantidadeTotal.Text = quantidadeTotalGridPizza

                End If

                If grdProduto.Rows.Count > 0 Then

                    cmbProduto.Text = grdProduto.Item("Produto", e.RowIndex).Value
                    txtValorProduto.Text = grdProduto.Item("Valor", e.RowIndex).Value
                    txtQuantidadeProduto.Text = grdProduto.Item("Quantidade", e.RowIndex).Value

                    grdProduto.Rows.RemoveAt(e.RowIndex)

                    For i As UShort = 0 To grdProduto.Rows.Count - 1

                        valorTotalGridProduto += grdProduto.Item("Valor", i).Value
                        quantidadeTotalGridProduto += grdProduto.Item("Quantidade", i).Value

                    Next

                    txtValorTotal.Text = valorTotalGridProduto
                    txtQuantidadeTotal.Text = quantidadeTotalGridProduto

                Else

                    txtValorTotal.Text = ""
                    txtQuantidadeTotal.Text = ""

                End If

                txtValorTotal.Text = valorTotalGridPizza + valorTotalGridProduto
                txtQuantidadeTotal.Text = quantidadeTotalGridPizza + quantidadeTotalGridProduto

            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub cmbPizza_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPizza.SelectedIndexChanged

        Dim con = New Connection

        Try
            con.OpenConnection()
            Dim pizza = New PizzaAcoes().Detalhe(con, _funcoes.PegaIdCombo(cmbPizza))
            con.CloseConnection()

            If pizza.IdPizza > 0 Then

                txtValorPizza.Text = pizza.Valor.ToString("######0.00")
                txtQuantidadePizza.Focus()

            End If

        Catch ex As Exception

            Try
                con.CloseConnection()
            Catch ex1 As Exception

            End Try
            MsgBox("Houve um erro ao tentar buscar o valor da pizza:" + ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub cmbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduto.SelectedIndexChanged


        Dim con = New Connection

        Try
            con.OpenConnection()
            Dim produto = New ProdutosAcoes().Detalhe(con, _funcoes.PegaIdCombo(cmbProduto))
            con.CloseConnection()

            If produto.IdProduto > 0 Then

                txtValorProduto.Text = produto.Valor.ToString("######0.00")
                txtQuantidadeProduto.Focus()
            End If

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try
            MsgBox("Houve um erro ao tentar buscar o valor do produto:" + ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged

        Dim con = New Connection

        Try

            con.OpenConnection()
            Dim cliente = New ClientesAcoes().Detalhe(con, _funcoes.PegaIdCombo(cmbCliente))
            con.CloseConnection()

            If cliente.IdCliente > 0 Then

                txtEndereco.Text = cliente.Logradouro + ", " + cliente.Numero.ToString + " - " + cliente.Complemento + " - " + cliente.Bairro
                txtTelefone.Text = cliente.TelCelular

                ' O detalhe que ele vai pegar são as informações da Classe ClienteAcoes.
                ' IFNULL(complemento, '') AS complemento - Coloca isso no Select do Detalhe para caso não tenha um complemento 

            End If

        Catch ex As Exception
            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try
            MsgBox("Houve um erro ao tentar buscar o valor da pizza:" + ex.Message, vbCritical)
        End Try

    End Sub

End Class