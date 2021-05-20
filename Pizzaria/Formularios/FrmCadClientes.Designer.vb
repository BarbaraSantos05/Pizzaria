<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCadClientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadClientes))
        Me.TabGeral = New System.Windows.Forms.TabControl()
        Me.TabPesquisa = New System.Windows.Forms.TabPage()
        Me.grdLista = New System.Windows.Forms.DataGridView()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.TabCadastro = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.TextBox()
        Me.Logradouro = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Numero = New System.Windows.Forms.Label()
        Me.Cep = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.Label()
        Me.maskCpf = New System.Windows.Forms.MaskedTextBox()
        Me.maskResidencial = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.maskCelular = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Telefone = New System.Windows.Forms.Label()
        Me.NomeProduto = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.CodigoIdProduto = New System.Windows.Forms.Label()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.TabMenu = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.maskCep = New System.Windows.Forms.MaskedTextBox()
        Me.TabGeral.SuspendLayout()
        Me.TabPesquisa.SuspendLayout()
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCadastro.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGeral
        '
        Me.TabGeral.Controls.Add(Me.TabPesquisa)
        Me.TabGeral.Controls.Add(Me.TabCadastro)
        Me.TabGeral.Location = New System.Drawing.Point(12, 2)
        Me.TabGeral.Name = "TabGeral"
        Me.TabGeral.SelectedIndex = 0
        Me.TabGeral.Size = New System.Drawing.Size(589, 408)
        Me.TabGeral.TabIndex = 0
        '
        'TabPesquisa
        '
        Me.TabPesquisa.Controls.Add(Me.grdLista)
        Me.TabPesquisa.Controls.Add(Me.btnPesquisa)
        Me.TabPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.TabPesquisa.Name = "TabPesquisa"
        Me.TabPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPesquisa.Size = New System.Drawing.Size(581, 382)
        Me.TabPesquisa.TabIndex = 0
        Me.TabPesquisa.Text = "Pesquisa"
        Me.TabPesquisa.UseVisualStyleBackColor = True
        '
        'grdLista
        '
        Me.grdLista.AllowUserToAddRows = False
        Me.grdLista.AllowUserToDeleteRows = False
        Me.grdLista.AllowUserToOrderColumns = True
        Me.grdLista.AllowUserToResizeRows = False
        Me.grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLista.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.grdLista.Location = New System.Drawing.Point(6, 84)
        Me.grdLista.Name = "grdLista"
        Me.grdLista.RowHeadersVisible = False
        Me.grdLista.Size = New System.Drawing.Size(552, 304)
        Me.grdLista.TabIndex = 2
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(476, 55)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(82, 23)
        Me.btnPesquisa.TabIndex = 1
        Me.btnPesquisa.Text = "Pesquisar"
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'TabCadastro
        '
        Me.TabCadastro.Controls.Add(Me.GroupBox2)
        Me.TabCadastro.Controls.Add(Me.GroupBox1)
        Me.TabCadastro.Controls.Add(Me.txtCodigo)
        Me.TabCadastro.Controls.Add(Me.CodigoIdProduto)
        Me.TabCadastro.Controls.Add(Me.chkAtivo)
        Me.TabCadastro.Controls.Add(Me.TabMenu)
        Me.TabCadastro.Location = New System.Drawing.Point(4, 22)
        Me.TabCadastro.Name = "TabCadastro"
        Me.TabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCadastro.Size = New System.Drawing.Size(581, 382)
        Me.TabCadastro.TabIndex = 1
        Me.TabCadastro.Text = "Cadastro"
        Me.TabCadastro.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.maskCep)
        Me.GroupBox2.Controls.Add(Me.txtComplemento)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtBairro)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtLogradouro)
        Me.GroupBox2.Controls.Add(Me.Logradouro)
        Me.GroupBox2.Controls.Add(Me.txtNumero)
        Me.GroupBox2.Controls.Add(Me.Numero)
        Me.GroupBox2.Controls.Add(Me.Cep)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 138)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Endereço"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(190, 74)
        Me.txtComplemento.MaxLength = 100
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(337, 20)
        Me.txtComplemento.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Complemento"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(0, 112)
        Me.txtBairro.MaxLength = 45
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(150, 20)
        Me.txtBairro.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-3, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Bairro"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(0, 36)
        Me.txtLogradouro.MaxLength = 100
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(505, 20)
        Me.txtLogradouro.TabIndex = 0
        '
        'Logradouro
        '
        Me.Logradouro.AutoSize = True
        Me.Logradouro.Location = New System.Drawing.Point(-3, 20)
        Me.Logradouro.Name = "Logradouro"
        Me.Logradouro.Size = New System.Drawing.Size(27, 13)
        Me.Logradouro.TabIndex = 32
        Me.Logradouro.Text = "Rua"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(0, 74)
        Me.txtNumero.MaxLength = 5
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(101, 20)
        Me.txtNumero.TabIndex = 1
        '
        'Numero
        '
        Me.Numero.AutoSize = True
        Me.Numero.Location = New System.Drawing.Point(-3, 58)
        Me.Numero.Name = "Numero"
        Me.Numero.Size = New System.Drawing.Size(44, 13)
        Me.Numero.TabIndex = 28
        Me.Numero.Text = "Numero"
        '
        'Cep
        '
        Me.Cep.AutoSize = True
        Me.Cep.Location = New System.Drawing.Point(187, 96)
        Me.Cep.Name = "Cep"
        Me.Cep.Size = New System.Drawing.Size(28, 13)
        Me.Cep.TabIndex = 30
        Me.Cep.Text = "CEP"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.maskCpf)
        Me.GroupBox1.Controls.Add(Me.maskResidencial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.maskCelular)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.Telefone)
        Me.GroupBox1.Controls.Add(Me.NomeProduto)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 134)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(6, 114)
        Me.txtEmail.MaxLength = 45
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(291, 20)
        Me.txtEmail.TabIndex = 4
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(3, 98)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(32, 13)
        Me.Email.TabIndex = 45
        Me.Email.Text = "Email"
        '
        'maskCpf
        '
        Me.maskCpf.Location = New System.Drawing.Point(6, 73)
        Me.maskCpf.Mask = "000.000.000-00"
        Me.maskCpf.Name = "maskCpf"
        Me.maskCpf.Size = New System.Drawing.Size(101, 20)
        Me.maskCpf.TabIndex = 1
        '
        'maskResidencial
        '
        Me.maskResidencial.Location = New System.Drawing.Point(292, 73)
        Me.maskResidencial.Mask = "(00) 0000-0000"
        Me.maskResidencial.Name = "maskResidencial"
        Me.maskResidencial.Size = New System.Drawing.Size(111, 20)
        Me.maskResidencial.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(289, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Residencial"
        '
        'maskCelular
        '
        Me.maskCelular.Location = New System.Drawing.Point(152, 73)
        Me.maskCelular.Mask = "(00) 0 0000-0000"
        Me.maskCelular.Name = "maskCelular"
        Me.maskCelular.Size = New System.Drawing.Size(111, 20)
        Me.maskCelular.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "CPF"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(6, 32)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(496, 20)
        Me.txtNome.TabIndex = 0
        '
        'Telefone
        '
        Me.Telefone.AutoSize = True
        Me.Telefone.Location = New System.Drawing.Point(149, 57)
        Me.Telefone.Name = "Telefone"
        Me.Telefone.Size = New System.Drawing.Size(39, 13)
        Me.Telefone.TabIndex = 36
        Me.Telefone.Text = "Celular"
        '
        'NomeProduto
        '
        Me.NomeProduto.AutoSize = True
        Me.NomeProduto.Location = New System.Drawing.Point(3, 16)
        Me.NomeProduto.Name = "NomeProduto"
        Me.NomeProduto.Size = New System.Drawing.Size(35, 13)
        Me.NomeProduto.TabIndex = 26
        Me.NomeProduto.Text = "Nome"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(12, 53)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'CodigoIdProduto
        '
        Me.CodigoIdProduto.AutoSize = True
        Me.CodigoIdProduto.Location = New System.Drawing.Point(9, 37)
        Me.CodigoIdProduto.Name = "CodigoIdProduto"
        Me.CodigoIdProduto.Size = New System.Drawing.Size(40, 13)
        Me.CodigoIdProduto.TabIndex = 27
        Me.CodigoIdProduto.Text = "Codigo"
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(134, 56)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chkAtivo.TabIndex = 1
        Me.chkAtivo.Text = "Ativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'TabMenu
        '
        Me.TabMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.btnSalvar, Me.ToolStripSeparator2, Me.btnExcluir})
        Me.TabMenu.Location = New System.Drawing.Point(3, 3)
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.Size = New System.Drawing.Size(575, 25)
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
        'maskCep
        '
        Me.maskCep.Location = New System.Drawing.Point(190, 112)
        Me.maskCep.Mask = "00000-000"
        Me.maskCep.Name = "maskCep"
        Me.maskCep.Size = New System.Drawing.Size(111, 20)
        Me.maskCep.TabIndex = 39
        '
        'FrmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 413)
        Me.Controls.Add(Me.TabGeral)
        Me.Name = "FrmCadClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Clientes"
        Me.TabGeral.ResumeLayout(False)
        Me.TabPesquisa.ResumeLayout(False)
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCadastro.ResumeLayout(False)
        Me.TabCadastro.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabMenu.ResumeLayout(False)
        Me.TabMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabGeral As TabControl
    Friend WithEvents TabPesquisa As TabPage
    Friend WithEvents TabCadastro As TabPage
    Friend WithEvents TabMenu As ToolStrip
    Friend WithEvents btnNovo As ToolStripButton
    Friend WithEvents btnSalvar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents txtLogradouro As TextBox
    Friend WithEvents Cep As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Numero As Label
    Friend WithEvents CodigoIdProduto As Label
    Friend WithEvents NomeProduto As Label
    Friend WithEvents chkAtivo As CheckBox
    Friend WithEvents Logradouro As Label
    Friend WithEvents Telefone As Label
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents maskResidencial As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents maskCelular As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBairro As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents maskCpf As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents txtComplemento As TextBox
    Friend WithEvents grdLista As DataGridView
    Friend WithEvents maskCep As MaskedTextBox
End Class
