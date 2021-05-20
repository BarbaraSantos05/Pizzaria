Imports Pizzaria.ClassesGenerica

Public Class FrmCadClientes

    Dim _funcoes As New Funcoes(Me)
    Private Sub FrmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            _funcoes.AtribuirEventos(Me)
            Call ConfiguraGrid()

        Catch ex As Exception
            MsgBox("Houve um erro ao tentar executar o método [FrmCadClientes_Load]: " + ex.Message, MsgBoxStyle.Critical)
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
                .Columns(1).Name = "IdCliente"
                .Columns(2).Name = "Nome"

                .Columns("Exibir").HeaderText = ""
                .Columns("IdCliente").HeaderText = "Código"
                .Columns("Nome").HeaderText = "Nome"

                .Columns("Exibir").Width = 70
                .Columns("IdCliente").Width = 80
                .Columns("Nome").Width = 400

                .Columns("Exibir").ReadOnly = True
                .Columns("IdCliente").ReadOnly = True
                .Columns("Nome").ReadOnly = True

                .Columns("Exibir").Visible = True
                .Columns("IdCliente").Visible = True
                .Columns("Nome").Visible = True

            End With

        Catch ex As Exception
            Throw
        End Try


    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click

        txtCodigo.Text = ""
        txtNome.Text = ""
        txtEmail.Text = ""
        maskCpf.Text = ""
        maskCelular.Text = ""
        maskResidencial.Text = ""
        txtLogradouro.Text = ""
        txtNumero.Text = ""
        txtComplemento.Text = ""
        maskCep.Text = ""
        chkAtivo.Checked = True
        txtNome.Focus()

    End Sub

    Private Function ValidarFormulario() As Boolean

        Try

            If txtNome.Text.Trim = "" Then
                MsgBox("Preencha o Nome do Cliente", MsgBoxStyle.Exclamation)
                txtNome.Focus()
                Return False
            End If

            If maskCpf.Text.Trim = "" Then
                MsgBox("Preencha o CPF do Cliente", MsgBoxStyle.Exclamation)
                txtNome.Focus()
                Return False
            End If

            If maskCelular.Text.Trim = "" Then
                MsgBox("Preencha o telefone celular do cliente", MsgBoxStyle.Exclamation)
                maskCelular.Focus()
                Return False
            End If

            If txtLogradouro.Text.Trim = "" Then
                MsgBox("Preencha o Endereço do Cliente", MsgBoxStyle.Exclamation)
                txtLogradouro.Focus()
                Return False
            End If

            If txtNumero.Text.Trim = "" Then
                MsgBox("Preencha o numero do endereço do Cliente", MsgBoxStyle.Exclamation)
                txtNumero.Focus()
                Return False
            End If

            If maskCep.Text.Trim = "" Then
                MsgBox("Preencha o cep do cliente", MsgBoxStyle.Exclamation)
                maskCep.Focus()
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

            Dim cliente = New Clientes

            If IsNumeric(txtCodigo.Text) Then
                cliente.IdCliente = txtCodigo.Text
            End If

            cliente.Nome = txtNome.Text
            cliente.cpf = maskCpf.Text
            cliente.TelCelular = maskCelular.Text
            cliente.TelResidencial = maskResidencial.Text
            cliente.email = txtEmail.Text
            cliente.Logradouro = txtLogradouro.Text

            If IsNumeric(txtNumero.Text) Then
                cliente.Numero = txtNumero.Text
            End If

            cliente.Complemento = txtComplemento.Text
            cliente.Cep = maskCep.Text
            cliente.Bairro = txtBairro.Text

            cliente.Ativo = chkAtivo.Checked

            Dim clientesAcoes = New ClientesAcoes

            con.OpenConnection()
            Dim salvou = clientesAcoes.Salvar(con, cliente)
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

                Dim clientesAcoes = New ClientesAcoes

                con.OpenConnection()
                Dim lista = clientesAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("Exibir", i).Value = "Exibir"
                        .Item("IdCliente", i).Value = lista(i).IdCliente
                        .Item("Nome", i).Value = lista(i).Nome
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
                    Dim idCliente = txtCodigo.Text

                    Dim clientesAcoes = New ClientesAcoes

                    con.OpenConnection()
                    Dim excluiu = clientesAcoes.Excluir(con, idCliente)
                    con.CloseConnection()

                    If excluiu Then
                        MsgBox("O Cliente foi excluido com sucesso", MsgBoxStyle.Information)

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

                Dim idCliente = grdLista.Item("IdCliente", e.RowIndex).Value

                Dim clientesAcoes = New ClientesAcoes

                con.OpenConnection()
                Dim clientes = clientesAcoes.Detalhe(con, idCliente)
                con.CloseConnection()

                If clientes.IdCliente > 0 Then

                    txtCodigo.Text = clientes.IdCliente
                    txtNome.Text = clientes.Nome
                    maskCpf.Text = clientes.cpf
                    maskCelular.Text = clientes.TelCelular
                    maskResidencial.Text = clientes.TelResidencial
                    txtEmail.Text = clientes.email
                    txtLogradouro.Text = clientes.Logradouro
                    txtNumero.Text = clientes.Numero
                    txtComplemento.Text = clientes.Complemento
                    txtBairro.Text = clientes.Bairro
                    maskCep.Text = clientes.Cep.ToString()
                    chkAtivo.Checked = clientes.Ativo

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