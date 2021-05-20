<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPedidos
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPedidos))
        Me.TabGeral = New System.Windows.Forms.TabControl()
        Me.TabPesquisa = New System.Windows.Forms.TabPage()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.grdLista = New System.Windows.Forms.DataGridView()
        Me.TabCadastro = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtQuantidadeTotal = New System.Windows.Forms.TextBox()
        Me.cmbFuncionario = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtValorProduto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdicionarProduto = New System.Windows.Forms.Button()
        Me.grdProduto = New System.Windows.Forms.DataGridView()
        Me.cmbProduto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQuantidadeProduto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtValorPizza = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdicionarPizza = New System.Windows.Forms.Button()
        Me.grdPizza = New System.Windows.Forms.DataGridView()
        Me.cmbPizza = New System.Windows.Forms.ComboBox()
        Me.CodigoIdPizza = New System.Windows.Forms.Label()
        Me.txtQuantidadePizza = New System.Windows.Forms.TextBox()
        Me.QuantidadePizza = New System.Windows.Forms.Label()
        Me.Descricao = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.chkLevarMaquininha = New System.Windows.Forms.CheckBox()
        Me.cmbPagamento = New System.Windows.Forms.ComboBox()
        Me.cboxPagamento = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.NomeCliente = New System.Windows.Forms.Label()
        Me.TabMenu = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.txtDataPedido = New System.Windows.Forms.TextBox()
        Me.TabGeral.SuspendLayout()
        Me.TabPesquisa.SuspendLayout()
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCadastro.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGeral
        '
        Me.TabGeral.Controls.Add(Me.TabPesquisa)
        Me.TabGeral.Controls.Add(Me.TabCadastro)
        Me.TabGeral.Location = New System.Drawing.Point(1, 3)
        Me.TabGeral.Name = "TabGeral"
        Me.TabGeral.SelectedIndex = 0
        Me.TabGeral.Size = New System.Drawing.Size(587, 605)
        Me.TabGeral.TabIndex = 2
        '
        'TabPesquisa
        '
        Me.TabPesquisa.Controls.Add(Me.btnPesquisa)
        Me.TabPesquisa.Controls.Add(Me.grdLista)
        Me.TabPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.TabPesquisa.Name = "TabPesquisa"
        Me.TabPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPesquisa.Size = New System.Drawing.Size(579, 579)
        Me.TabPesquisa.TabIndex = 0
        Me.TabPesquisa.Text = "Pesquisa"
        Me.TabPesquisa.UseVisualStyleBackColor = True
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(490, 17)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(82, 23)
        Me.btnPesquisa.TabIndex = 1
        Me.btnPesquisa.Text = "Pesquisar"
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'grdLista
        '
        Me.grdLista.AllowUserToAddRows = False
        Me.grdLista.AllowUserToDeleteRows = False
        Me.grdLista.AllowUserToResizeRows = False
        Me.grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLista.Location = New System.Drawing.Point(6, 46)
        Me.grdLista.Name = "grdLista"
        Me.grdLista.RowHeadersVisible = False
        Me.grdLista.Size = New System.Drawing.Size(567, 527)
        Me.grdLista.TabIndex = 0
        '
        'TabCadastro
        '
        Me.TabCadastro.Controls.Add(Me.txtDataPedido)
        Me.TabCadastro.Controls.Add(Me.Label11)
        Me.TabCadastro.Controls.Add(Me.txtQuantidadeTotal)
        Me.TabCadastro.Controls.Add(Me.cmbFuncionario)
        Me.TabCadastro.Controls.Add(Me.Label8)
        Me.TabCadastro.Controls.Add(Me.Label10)
        Me.TabCadastro.Controls.Add(Me.GroupBox2)
        Me.TabCadastro.Controls.Add(Me.Label5)
        Me.TabCadastro.Controls.Add(Me.txtValorTotal)
        Me.TabCadastro.Controls.Add(Me.GroupBox1)
        Me.TabCadastro.Controls.Add(Me.Descricao)
        Me.TabCadastro.Controls.Add(Me.Label3)
        Me.TabCadastro.Controls.Add(Me.txtObservacao)
        Me.TabCadastro.Controls.Add(Me.txtCodigo)
        Me.TabCadastro.Controls.Add(Me.Label2)
        Me.TabCadastro.Controls.Add(Me.txtTelefone)
        Me.TabCadastro.Controls.Add(Me.Label1)
        Me.TabCadastro.Controls.Add(Me.txtEndereco)
        Me.TabCadastro.Controls.Add(Me.chkLevarMaquininha)
        Me.TabCadastro.Controls.Add(Me.cmbPagamento)
        Me.TabCadastro.Controls.Add(Me.cboxPagamento)
        Me.TabCadastro.Controls.Add(Me.cmbCliente)
        Me.TabCadastro.Controls.Add(Me.NomeCliente)
        Me.TabCadastro.Controls.Add(Me.TabMenu)
        Me.TabCadastro.Location = New System.Drawing.Point(4, 22)
        Me.TabCadastro.Name = "TabCadastro"
        Me.TabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCadastro.Size = New System.Drawing.Size(579, 579)
        Me.TabCadastro.TabIndex = 1
        Me.TabCadastro.Text = "Novo Pedido"
        Me.TabCadastro.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 537)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 13)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Quantidade Total"
        '
        'txtQuantidadeTotal
        '
        Me.txtQuantidadeTotal.Enabled = False
        Me.txtQuantidadeTotal.Location = New System.Drawing.Point(13, 553)
        Me.txtQuantidadeTotal.MaxLength = 45
        Me.txtQuantidadeTotal.Name = "txtQuantidadeTotal"
        Me.txtQuantidadeTotal.Size = New System.Drawing.Size(86, 20)
        Me.txtQuantidadeTotal.TabIndex = 85
        '
        'cmbFuncionario
        '
        Me.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFuncionario.FormattingEnabled = True
        Me.cmbFuncionario.Location = New System.Drawing.Point(176, 48)
        Me.cmbFuncionario.Name = "cmbFuncionario"
        Me.cmbFuncionario.Size = New System.Drawing.Size(370, 21)
        Me.cmbFuncionario.TabIndex = 84
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(173, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Responsável"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(86, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "Data do Pedido"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtValorProduto)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnAdicionarProduto)
        Me.GroupBox2.Controls.Add(Me.grdProduto)
        Me.GroupBox2.Controls.Add(Me.cmbProduto)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtQuantidadeProduto)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 369)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 168)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produtos"
        '
        'txtValorProduto
        '
        Me.txtValorProduto.Location = New System.Drawing.Point(160, 36)
        Me.txtValorProduto.MaxLength = 45
        Me.txtValorProduto.Name = "txtValorProduto"
        Me.txtValorProduto.Size = New System.Drawing.Size(59, 20)
        Me.txtValorProduto.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(157, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Valor"
        '
        'btnAdicionarProduto
        '
        Me.btnAdicionarProduto.Location = New System.Drawing.Point(452, 34)
        Me.btnAdicionarProduto.Name = "btnAdicionarProduto"
        Me.btnAdicionarProduto.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionarProduto.TabIndex = 3
        Me.btnAdicionarProduto.Text = "Adicionar"
        Me.btnAdicionarProduto.UseVisualStyleBackColor = True
        '
        'grdProduto
        '
        Me.grdProduto.AllowUserToAddRows = False
        Me.grdProduto.AllowUserToDeleteRows = False
        Me.grdProduto.AllowUserToResizeRows = False
        Me.grdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProduto.Location = New System.Drawing.Point(6, 62)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.RowHeadersVisible = False
        Me.grdProduto.Size = New System.Drawing.Size(533, 97)
        Me.grdProduto.TabIndex = 4
        '
        'cmbProduto
        '
        Me.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduto.FormattingEnabled = True
        Me.cmbProduto.Location = New System.Drawing.Point(6, 36)
        Me.cmbProduto.Name = "cmbProduto"
        Me.cmbProduto.Size = New System.Drawing.Size(148, 21)
        Me.cmbProduto.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Produto"
        '
        'txtQuantidadeProduto
        '
        Me.txtQuantidadeProduto.Location = New System.Drawing.Point(225, 36)
        Me.txtQuantidadeProduto.MaxLength = 45
        Me.txtQuantidadeProduto.Name = "txtQuantidadeProduto"
        Me.txtQuantidadeProduto.Size = New System.Drawing.Size(59, 20)
        Me.txtQuantidadeProduto.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(222, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Quantidade"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(102, 537)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Valor Total"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Enabled = False
        Me.txtValorTotal.Location = New System.Drawing.Point(105, 553)
        Me.txtValorTotal.MaxLength = 45
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(77, 20)
        Me.txtValorTotal.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtValorPizza)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnAdicionarPizza)
        Me.GroupBox1.Controls.Add(Me.grdPizza)
        Me.GroupBox1.Controls.Add(Me.cmbPizza)
        Me.GroupBox1.Controls.Add(Me.CodigoIdPizza)
        Me.GroupBox1.Controls.Add(Me.txtQuantidadePizza)
        Me.GroupBox1.Controls.Add(Me.QuantidadePizza)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 190)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 173)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pizzas"
        '
        'txtValorPizza
        '
        Me.txtValorPizza.Location = New System.Drawing.Point(160, 36)
        Me.txtValorPizza.MaxLength = 45
        Me.txtValorPizza.Name = "txtValorPizza"
        Me.txtValorPizza.Size = New System.Drawing.Size(59, 20)
        Me.txtValorPizza.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Valor"
        '
        'btnAdicionarPizza
        '
        Me.btnAdicionarPizza.Location = New System.Drawing.Point(458, 34)
        Me.btnAdicionarPizza.Name = "btnAdicionarPizza"
        Me.btnAdicionarPizza.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionarPizza.TabIndex = 3
        Me.btnAdicionarPizza.Text = "Adicionar"
        Me.btnAdicionarPizza.UseVisualStyleBackColor = True
        '
        'grdPizza
        '
        Me.grdPizza.AllowUserToAddRows = False
        Me.grdPizza.AllowUserToDeleteRows = False
        Me.grdPizza.AllowUserToResizeRows = False
        Me.grdPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPizza.Location = New System.Drawing.Point(6, 67)
        Me.grdPizza.Name = "grdPizza"
        Me.grdPizza.RowHeadersVisible = False
        Me.grdPizza.Size = New System.Drawing.Size(533, 97)
        Me.grdPizza.TabIndex = 4
        '
        'cmbPizza
        '
        Me.cmbPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPizza.FormattingEnabled = True
        Me.cmbPizza.Location = New System.Drawing.Point(6, 36)
        Me.cmbPizza.Name = "cmbPizza"
        Me.cmbPizza.Size = New System.Drawing.Size(148, 21)
        Me.cmbPizza.TabIndex = 0
        '
        'CodigoIdPizza
        '
        Me.CodigoIdPizza.AutoSize = True
        Me.CodigoIdPizza.Location = New System.Drawing.Point(3, 19)
        Me.CodigoIdPizza.Name = "CodigoIdPizza"
        Me.CodigoIdPizza.Size = New System.Drawing.Size(32, 13)
        Me.CodigoIdPizza.TabIndex = 27
        Me.CodigoIdPizza.Text = "Pizza"
        '
        'txtQuantidadePizza
        '
        Me.txtQuantidadePizza.Location = New System.Drawing.Point(225, 36)
        Me.txtQuantidadePizza.MaxLength = 45
        Me.txtQuantidadePizza.Name = "txtQuantidadePizza"
        Me.txtQuantidadePizza.Size = New System.Drawing.Size(59, 20)
        Me.txtQuantidadePizza.TabIndex = 2
        '
        'QuantidadePizza
        '
        Me.QuantidadePizza.AutoSize = True
        Me.QuantidadePizza.Location = New System.Drawing.Point(222, 20)
        Me.QuantidadePizza.Name = "QuantidadePizza"
        Me.QuantidadePizza.Size = New System.Drawing.Size(62, 13)
        Me.QuantidadePizza.TabIndex = 38
        Me.QuantidadePizza.Text = "Quantidade"
        '
        'Descricao
        '
        Me.Descricao.AutoSize = True
        Me.Descricao.Location = New System.Drawing.Point(7, 151)
        Me.Descricao.Name = "Descricao"
        Me.Descricao.Size = New System.Drawing.Size(65, 13)
        Me.Descricao.TabIndex = 32
        Me.Descricao.Text = "Observação"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Nº Pedido"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(7, 164)
        Me.txtObservacao.MaxLength = 45
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(539, 20)
        Me.txtObservacao.TabIndex = 5
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(7, 48)
        Me.txtCodigo.MaxLength = 45
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(77, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Telefone"
        '
        'txtTelefone
        '
        Me.txtTelefone.Enabled = False
        Me.txtTelefone.Location = New System.Drawing.Point(407, 128)
        Me.txtTelefone.MaxLength = 45
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(139, 20)
        Me.txtTelefone.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Endereço"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(7, 128)
        Me.txtEndereco.MaxLength = 45
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(394, 20)
        Me.txtEndereco.TabIndex = 2
        '
        'chkLevarMaquininha
        '
        Me.chkLevarMaquininha.AutoSize = True
        Me.chkLevarMaquininha.Location = New System.Drawing.Point(342, 554)
        Me.chkLevarMaquininha.Name = "chkLevarMaquininha"
        Me.chkLevarMaquininha.Size = New System.Drawing.Size(111, 17)
        Me.chkLevarMaquininha.TabIndex = 6
        Me.chkLevarMaquininha.Text = "Levar Maquininha"
        Me.chkLevarMaquininha.UseVisualStyleBackColor = True
        '
        'cmbPagamento
        '
        Me.cmbPagamento.FormattingEnabled = True
        Me.cmbPagamento.Location = New System.Drawing.Point(188, 552)
        Me.cmbPagamento.Name = "cmbPagamento"
        Me.cmbPagamento.Size = New System.Drawing.Size(148, 21)
        Me.cmbPagamento.TabIndex = 5
        '
        'cboxPagamento
        '
        Me.cboxPagamento.AutoSize = True
        Me.cboxPagamento.Location = New System.Drawing.Point(185, 536)
        Me.cboxPagamento.Name = "cboxPagamento"
        Me.cboxPagamento.Size = New System.Drawing.Size(61, 13)
        Me.cboxPagamento.TabIndex = 51
        Me.cboxPagamento.Text = "Pagamento"
        '
        'cmbCliente
        '
        Me.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(7, 88)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(539, 21)
        Me.cmbCliente.TabIndex = 1
        '
        'NomeCliente
        '
        Me.NomeCliente.AutoSize = True
        Me.NomeCliente.Location = New System.Drawing.Point(4, 72)
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.Size = New System.Drawing.Size(39, 13)
        Me.NomeCliente.TabIndex = 26
        Me.NomeCliente.Text = "Cliente"
        '
        'TabMenu
        '
        Me.TabMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.btnSalvar, Me.ToolStripSeparator2, Me.btnExcluir})
        Me.TabMenu.Location = New System.Drawing.Point(3, 3)
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.Size = New System.Drawing.Size(573, 25)
        Me.TabMenu.TabIndex = 9
        Me.TabMenu.Text = "ToolStrip1"
        '
        'btnNovo
        '
        Me.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(23, 22)
        Me.btnNovo.Tag = ""
        Me.btnNovo.Text = "Novo"
        '
        'btnSalvar
        '
        Me.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalvar.Image = CType(resources.GetObject("btnSalvar.Image"), System.Drawing.Image)
        Me.btnSalvar.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(23, 22)
        Me.btnSalvar.Text = "Save"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnExcluir
        '
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(23, 22)
        Me.btnExcluir.Text = "Delete"
        '
        'txtDataPedido
        '
        Me.txtDataPedido.Location = New System.Drawing.Point(89, 48)
        Me.txtDataPedido.MaxLength = 10
        Me.txtDataPedido.Name = "txtDataPedido"
        Me.txtDataPedido.Size = New System.Drawing.Size(77, 20)
        Me.txtDataPedido.TabIndex = 87
        '
        'FrmPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 612)
        Me.Controls.Add(Me.TabGeral)
        Me.Name = "FrmPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pedidos"
        Me.TabGeral.ResumeLayout(False)
        Me.TabPesquisa.ResumeLayout(False)
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCadastro.ResumeLayout(False)
        Me.TabCadastro.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMenu.ResumeLayout(False)
        Me.TabMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabGeral As TabControl
    Friend WithEvents TabPesquisa As TabPage
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents grdLista As DataGridView
    Friend WithEvents TabCadastro As TabPage
    Friend WithEvents cmbPizza As ComboBox
    Friend WithEvents Descricao As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents CodigoIdPizza As Label
    Friend WithEvents NomeCliente As Label
    Friend WithEvents TabMenu As ToolStrip
    Friend WithEvents btnNovo As ToolStripButton
    Friend WithEvents btnSalvar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents QuantidadePizza As Label
    Friend WithEvents txtQuantidadePizza As TextBox
    Friend WithEvents cmbPagamento As ComboBox
    Friend WithEvents cboxPagamento As Label
    Friend WithEvents chkLevarMaquininha As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdicionarPizza As Button
    Friend WithEvents grdPizza As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdicionarProduto As Button
    Friend WithEvents grdProduto As DataGridView
    Friend WithEvents cmbProduto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtQuantidadeProduto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtValorProduto As TextBox
    Friend WithEvents txtValorPizza As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbFuncionario As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtQuantidadeTotal As TextBox
    Friend WithEvents txtDataPedido As TextBox
End Class
