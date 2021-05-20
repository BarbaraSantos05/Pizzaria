<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntradaProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEntradaProduto))
        Me.TabGeral = New System.Windows.Forms.TabControl()
        Me.TabPesquisa = New System.Windows.Forms.TabPage()
        Me.grdLista = New System.Windows.Forms.DataGridView()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.TabCadastro = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservacao = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQuantidadeTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.grdProduto = New System.Windows.Forms.DataGridView()
        Me.txtQuantidade = New System.Windows.Forms.TextBox()
        Me.QuantidadePizza = New System.Windows.Forms.Label()
        Me.cmbProduto = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNotaFiscal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFornecedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cmbFuncionario = New System.Windows.Forms.ComboBox()
        Me.NomeCliente = New System.Windows.Forms.Label()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.mskDataEntrada = New System.Windows.Forms.MaskedTextBox()
        Me.mskDataValidade = New System.Windows.Forms.MaskedTextBox()
        Me.TabGeral.SuspendLayout()
        Me.TabPesquisa.SuspendLayout()
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCadastro.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGeral
        '
        Me.TabGeral.Controls.Add(Me.TabPesquisa)
        Me.TabGeral.Controls.Add(Me.TabCadastro)
        Me.TabGeral.Location = New System.Drawing.Point(3, 3)
        Me.TabGeral.Name = "TabGeral"
        Me.TabGeral.SelectedIndex = 0
        Me.TabGeral.Size = New System.Drawing.Size(581, 444)
        Me.TabGeral.TabIndex = 1
        '
        'TabPesquisa
        '
        Me.TabPesquisa.Controls.Add(Me.grdLista)
        Me.TabPesquisa.Controls.Add(Me.btnPesquisa)
        Me.TabPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.TabPesquisa.Name = "TabPesquisa"
        Me.TabPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPesquisa.Size = New System.Drawing.Size(573, 418)
        Me.TabPesquisa.TabIndex = 0
        Me.TabPesquisa.Text = "Pesquisa"
        Me.TabPesquisa.UseVisualStyleBackColor = True
        '
        'grdLista
        '
        Me.grdLista.AllowUserToAddRows = False
        Me.grdLista.AllowUserToDeleteRows = False
        Me.grdLista.AllowUserToResizeRows = False
        Me.grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLista.Location = New System.Drawing.Point(6, 44)
        Me.grdLista.Name = "grdLista"
        Me.grdLista.RowHeadersVisible = False
        Me.grdLista.Size = New System.Drawing.Size(561, 333)
        Me.grdLista.TabIndex = 1
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(485, 15)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(82, 23)
        Me.btnPesquisa.TabIndex = 0
        Me.btnPesquisa.Text = "Pesquisar"
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'TabCadastro
        '
        Me.TabCadastro.Controls.Add(Me.mskDataEntrada)
        Me.TabCadastro.Controls.Add(Me.Label6)
        Me.TabCadastro.Controls.Add(Me.txtObservacao)
        Me.TabCadastro.Controls.Add(Me.GroupBox1)
        Me.TabCadastro.Controls.Add(Me.Label2)
        Me.TabCadastro.Controls.Add(Me.txtNotaFiscal)
        Me.TabCadastro.Controls.Add(Me.Label5)
        Me.TabCadastro.Controls.Add(Me.Label1)
        Me.TabCadastro.Controls.Add(Me.txtFornecedor)
        Me.TabCadastro.Controls.Add(Me.Label3)
        Me.TabCadastro.Controls.Add(Me.txtCodigo)
        Me.TabCadastro.Controls.Add(Me.cmbFuncionario)
        Me.TabCadastro.Controls.Add(Me.NomeCliente)
        Me.TabCadastro.Controls.Add(Me.ToolStrip)
        Me.TabCadastro.Location = New System.Drawing.Point(4, 22)
        Me.TabCadastro.Name = "TabCadastro"
        Me.TabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCadastro.Size = New System.Drawing.Size(573, 418)
        Me.TabCadastro.TabIndex = 1
        Me.TabCadastro.Text = "Entrada de Produtos"
        Me.TabCadastro.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Observação"
        '
        'txtObservacao
        '
        Me.txtObservacao.Location = New System.Drawing.Point(15, 134)
        Me.txtObservacao.MaxLength = 45
        Me.txtObservacao.Name = "txtObservacao"
        Me.txtObservacao.Size = New System.Drawing.Size(533, 20)
        Me.txtObservacao.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mskDataValidade)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtQuantidadeTotal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtValorTotal)
        Me.GroupBox1.Controls.Add(Me.txtValor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnAdicionar)
        Me.GroupBox1.Controls.Add(Me.grdProduto)
        Me.GroupBox1.Controls.Add(Me.txtQuantidade)
        Me.GroupBox1.Controls.Add(Me.QuantidadePizza)
        Me.GroupBox1.Controls.Add(Me.cmbProduto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 245)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Produtos"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(457, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Valor Total"
        '
        'txtQuantidadeTotal
        '
        Me.txtQuantidadeTotal.Location = New System.Drawing.Point(365, 206)
        Me.txtQuantidadeTotal.MaxLength = 5
        Me.txtQuantidadeTotal.Name = "txtQuantidadeTotal"
        Me.txtQuantidadeTotal.Size = New System.Drawing.Size(86, 20)
        Me.txtQuantidadeTotal.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(362, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Quantidade Total"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.Location = New System.Drawing.Point(462, 206)
        Me.txtValorTotal.MaxLength = 19
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(71, 20)
        Me.txtValorTotal.TabIndex = 7
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(191, 34)
        Me.txtValor.MaxLength = 45
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(73, 20)
        Me.txtValor.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(335, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Data de Validade"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(188, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Valor Un."
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(458, 34)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 4
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'grdProduto
        '
        Me.grdProduto.AllowUserToAddRows = False
        Me.grdProduto.AllowUserToDeleteRows = False
        Me.grdProduto.AllowUserToResizeRows = False
        Me.grdProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdProduto.Location = New System.Drawing.Point(6, 67)
        Me.grdProduto.Name = "grdProduto"
        Me.grdProduto.RowHeadersVisible = False
        Me.grdProduto.Size = New System.Drawing.Size(525, 112)
        Me.grdProduto.TabIndex = 5
        '
        'txtQuantidade
        '
        Me.txtQuantidade.Location = New System.Drawing.Point(270, 34)
        Me.txtQuantidade.MaxLength = 45
        Me.txtQuantidade.Name = "txtQuantidade"
        Me.txtQuantidade.Size = New System.Drawing.Size(59, 20)
        Me.txtQuantidade.TabIndex = 2
        '
        'QuantidadePizza
        '
        Me.QuantidadePizza.AutoSize = True
        Me.QuantidadePizza.Location = New System.Drawing.Point(267, 16)
        Me.QuantidadePizza.Name = "QuantidadePizza"
        Me.QuantidadePizza.Size = New System.Drawing.Size(62, 13)
        Me.QuantidadePizza.TabIndex = 38
        Me.QuantidadePizza.Text = "Quantidade"
        '
        'cmbProduto
        '
        Me.cmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduto.FormattingEnabled = True
        Me.cmbProduto.Location = New System.Drawing.Point(6, 34)
        Me.cmbProduto.Name = "cmbProduto"
        Me.cmbProduto.Size = New System.Drawing.Size(179, 21)
        Me.cmbProduto.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Produto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(460, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Data de Entrada"
        '
        'txtNotaFiscal
        '
        Me.txtNotaFiscal.Location = New System.Drawing.Point(341, 95)
        Me.txtNotaFiscal.MaxLength = 45
        Me.txtNotaFiscal.Name = "txtNotaFiscal"
        Me.txtNotaFiscal.Size = New System.Drawing.Size(116, 20)
        Me.txtNotaFiscal.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(338, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "Nº Nota Fiscal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Fornecedor"
        '
        'txtFornecedor
        '
        Me.txtFornecedor.Location = New System.Drawing.Point(14, 95)
        Me.txtFornecedor.MaxLength = 45
        Me.txtFornecedor.Name = "txtFornecedor"
        Me.txtFornecedor.Size = New System.Drawing.Size(312, 20)
        Me.txtFornecedor.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Codigo"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(15, 55)
        Me.txtCodigo.MaxLength = 45
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(77, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'cmbFuncionario
        '
        Me.cmbFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFuncionario.FormattingEnabled = True
        Me.cmbFuncionario.Location = New System.Drawing.Point(102, 54)
        Me.cmbFuncionario.Name = "cmbFuncionario"
        Me.cmbFuncionario.Size = New System.Drawing.Size(328, 21)
        Me.cmbFuncionario.TabIndex = 1
        '
        'NomeCliente
        '
        Me.NomeCliente.AutoSize = True
        Me.NomeCliente.Location = New System.Drawing.Point(99, 37)
        Me.NomeCliente.Name = "NomeCliente"
        Me.NomeCliente.Size = New System.Drawing.Size(69, 13)
        Me.NomeCliente.TabIndex = 71
        Me.NomeCliente.Text = "Responsavel"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.btnSalvar, Me.ToolStripSeparator1, Me.btnExcluir})
        Me.ToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(567, 25)
        Me.ToolStrip.TabIndex = 7
        Me.ToolStrip.Text = "ToolStrip"
        '
        'btnNovo
        '
        Me.btnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNovo.Image = CType(resources.GetObject("btnNovo.Image"), System.Drawing.Image)
        Me.btnNovo.ImageTransparentColor = System.Drawing.Color.Black
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(23, 22)
        Me.btnNovo.Text = "New"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnExcluir
        '
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(23, 22)
        Me.btnExcluir.Text = "ToolStripButton1"
        '
        'mskDataEntrada
        '
        Me.mskDataEntrada.Location = New System.Drawing.Point(463, 95)
        Me.mskDataEntrada.Mask = "00/00/0000"
        Me.mskDataEntrada.Name = "mskDataEntrada"
        Me.mskDataEntrada.Size = New System.Drawing.Size(82, 20)
        Me.mskDataEntrada.TabIndex = 88
        '
        'mskDataValidade
        '
        Me.mskDataValidade.Location = New System.Drawing.Point(335, 34)
        Me.mskDataValidade.Mask = "00/00/0000"
        Me.mskDataValidade.Name = "mskDataValidade"
        Me.mskDataValidade.Size = New System.Drawing.Size(89, 20)
        Me.mskDataValidade.TabIndex = 89
        '
        'FrmEntradaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 447)
        Me.Controls.Add(Me.TabGeral)
        Me.Name = "FrmEntradaProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Produtos"
        Me.TabGeral.ResumeLayout(False)
        Me.TabPesquisa.ResumeLayout(False)
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCadastro.ResumeLayout(False)
        Me.TabCadastro.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabGeral As TabControl
    Friend WithEvents TabPesquisa As TabPage
    Friend WithEvents grdLista As DataGridView
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents TabCadastro As TabPage
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents btnNovo As ToolStripButton
    Friend WithEvents btnSalvar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents cmbProduto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFornecedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents cmbFuncionario As ComboBox
    Friend WithEvents NomeCliente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNotaFiscal As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtObservacao As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents grdProduto As DataGridView
    Friend WithEvents txtQuantidade As TextBox
    Friend WithEvents QuantidadePizza As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtQuantidadeTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtValorTotal As TextBox
    Friend WithEvents mskDataEntrada As MaskedTextBox
    Friend WithEvents mskDataValidade As MaskedTextBox
End Class
