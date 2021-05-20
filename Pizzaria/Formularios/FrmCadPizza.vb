Imports Pizzaria.ClassesGenerica

Public Class FrmCadPizza

    Dim _funcoes As New Funcoes(Me)

    Private Sub FrmCadPizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            _funcoes.AtribuirEventos(Me)
            Call ConfiguraGrid()                'Chama a grid, que é a tela de pesquisa

        Catch ex As Exception
            MsgBox("Houve um erro ao tentar executar o método [FrmCadPizza_Load]: " + ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub ConfiguraGrid()

        Try

            With grdLista     ' Usado para não ter que ficar repetindo no código. É só chamar pelo "."

                .RowCount = 0
                .ColumnCount = 0

                .Columns.Add(New DataGridViewButtonColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())        ' Terá três Colunas
                .Columns.Add(New DataGridViewTextBoxColumn())

                .Columns(0).Name = "Exibir"
                .Columns(1).Name = "IdPizza"                          'Nome das colunas
                .Columns(2).Name = "Nome"

                .Columns("Exibir").HeaderText = ""
                .Columns("IdPizza").HeaderText = "Código"              'O texto que vai aparecer no "cabeçalho"
                .Columns("Nome").HeaderText = "Nome"

                .Columns("Exibir").Width = 70                          'Tamanho de cada coluna
                .Columns("IdPizza").Width = 80
                .Columns("Nome").Width = 375

                .Columns("Exibir").ReadOnly = True
                .Columns("IdPizza").ReadOnly = True                    'Não pode fazer nenhuma alteração. Somente leitura
                .Columns("Nome").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("IdPizza").Visible = True                      'Coluna estará visível
                .Columns("Nome").Visible = True

            End With


        Catch ex As Exception                       'Tratamento de exceção. Se der algum erro ao configurar a Grid.
            Throw
        End Try

    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        txtCodigo.Text = ""                         'Quando clicar no botão novo, todos os campos serão limpos
        txtNome.Text = ""
        txtValor.Text = ""
        chkAtivo.Checked = True
        txtNome.Focus()

    End Sub

    Private Function ValidarFormulario() As Boolean          'Função para preencher todos os campos que são obrigatórios

        Try

            If txtNome.Text.Trim = "" Then
                MsgBox("Preencha o nome", MsgBoxStyle.Exclamation)
                txtNome.Focus()
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

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click     'Clica no botão Salvar

        Dim con = New Connection      'Abre uma conexão'

        Try

            Dim validado = ValidarFormulario()         'Vai verificar se todos os campos obrigatórios foram preenchidos

            If validado = False Then                   'Se estiver faltando algum campo, vai sair da classe.         
                Exit Sub
            End If

            Dim pizza = New Pizza                     'Instancia o objeto Pizza (Todos os atributos)


            If IsNumeric(txtCodigo.Text) Then           'Onde cada atributo está localizado. Quando for numérico, terá que ter o IsNumeric
                pizza.IdPizza = txtCodigo.Text
            End If

            pizza.Nome = txtNome.Text

            If IsNumeric(txtValor.Text) Then
                pizza.Valor = txtValor.Text
            End If

            pizza.Ativo = chkAtivo.Checked

            Dim pizzaAcoes = New PizzaAcoes()            'Instancia a Classe de Ação para salvar no banco.

            con.OpenConnection()                           ' Abre Conexao com o banco
            Dim salvou = pizzaAcoes.Salvar(con, pizza)     ' Chama o metodo o salvar da classe PizzaAcoes
            con.CloseConnection()                          'Fecha conexão com o banco

            If salvou Then
                MsgBox("Operação realizada com sucesso", MsgBoxStyle.Information)

                Call btnNovo_Click(Nothing, Nothing)           'Depois que salvou vai limpar a tela.
                Call btnPesquisa_Click(Nothing, Nothing)       'Chama o botão de pesquisar

                TabGeral.SelectedTab = TabPesquisa             'Vai para a tela de pesquisa para clicar no botão pesquisar

            Else
                MsgBox("Houve um erro ao tentar salvar", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception

            Try
                con.CloseConnection()          'Se deu algum erro, vai fechar a conexão com o banco.
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [btnSalvar_Click]: " + ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click      'Botão de pesquisa

        Dim con = New Connection                        'Vai abrir a conexão

        Try

            With grdLista

                .RowCount = 0                           'A contagem de linhas é igual a 0

                Dim pizzaAcoes = New PizzaAcoes         'Instancia a classe Pizza Acoes que é onde vai puxar a lista de Pizzas do banco.  

                con.OpenConnection()                    'Abre conexão              
                Dim lista = pizzaAcoes.Lista(con)       'Chama o metodo de lista da classe PizzaAcoes
                con.CloseConnection()                   'Fecha Conexão        

                If lista.Count > 0 Then                 'Se o numero de linhas da lsita for maior que 0

                    For i As Short = 0 To lista.Count - 1     'para todas as linhas de 0 até a ultima   ( -1 porque o indíce é um numero a mais do que o nº real de linhas)

                        .Rows.Add()                             'Vai adicionar as linhas

                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdPizza", i).Value = lista(i).IdPizza        'Cada linha da lista vai receber o seu IdPizza
                        .Item("Nome", i).Value = lista(i).Nome              'Cada linha da lista vai receber o seu Nome

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

    Private Sub grdLista_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdLista.CellClick   ' Quando clicar na linha da grid

        Dim con = New Connection                                  'Instancia a conexão com o banco                        

        Try

            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then                ' Se o numero de linhas ou de colunas for menor que 0 entao saírá do metodo
                Exit Sub
            End If

            If e.ColumnIndex = 0 Then                               'Se o numero do indice das colunas for =0

                With grdLista

                    Dim idPizza = .Item("IdPizza", e.RowIndex).Value        'Vai pegar o item que seja da coluna IdPizza e o numero da linha que clicou

                    Dim pizzaAcoes = New PizzaAcoes                         'Instancia a classe PizzaAcoes para ter conexão com banco

                    con.OpenConnection()                                    'Abre conexão
                    Dim pizza = pizzaAcoes.Detalhe(con, idPizza)            'Chama o metodo detalhe que irá mostrar todos os itens que foram salvos no banco     
                    con.CloseConnection()                                   'Fecha conexão   

                    If pizza.IdPizza > 0 Then                               'Se o IdPizza > 0

                        txtCodigo.Text = pizza.IdPizza                        'Cada campo terá que receber o seu atributo correspondente
                        txtNome.Text = pizza.Nome
                        txtValor.Text = pizza.Valor.ToString("#######0.00")
                        chkAtivo.Checked = pizza.Ativo

                        TabGeral.SelectedTab = TabCadastro                      'Vai para a tela de Cadastro para que possam ser feitas alterações

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

        Dim con = New Connection         'Instancia a conexão com banco

        Try

            If IsNumeric(txtCodigo.Text) Then                   'Se tiver um Id ( que está na txtCodigo)

                Dim resposta = MsgBox("Tem certeza que deseja excluir o registro ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Excluir")

                If resposta = MsgBoxResult.Yes Then                 'Se a resposta for sim

                    Dim idPizza = txtCodigo.Text

                    Dim pizzaAcoes = New PizzaAcoes             'Instancia a classe PizzaAcoes para ter conexão com banco

                    con.OpenConnection()                            'Abre conexão
                    Dim excluiu = pizzaAcoes.Excluir(con, idPizza)   'Chama o metodo detalhe que irá excluir os dados no banco 
                    con.CloseConnection()                           'Fecha conexão

                    If excluiu Then

                        MsgBox("O Produto foi excluido com sucesso", MsgBoxStyle.Information)

                        Call btnNovo_Click(Nothing, Nothing)                'Todos os campos serão limpos
                        Call btnPesquisa_Click(Nothing, Nothing)            'Chama o botão de Pesquisa

                        TabGeral.SelectedTab = TabPesquisa                  ' Abre a tela de pesquisa

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