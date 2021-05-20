<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadProdutos))
        Me.TabCadastro = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCategoriaProduto = New System.Windows.Forms.ComboBox()
        Me.DescricaoProduto = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.ValorProduto = New System.Windows.Forms.Label()
        Me.CodigoIdProduto = New System.Windows.Forms.Label()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.TabMenu = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.TabGeral = New System.Windows.Forms.TabControl()
        Me.TabPesquisa = New System.Windows.Forms.TabPage()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.grdLista = New System.Windows.Forms.DataGridView()
        Me.TabCadastro.SuspendLayout()
        Me.TabMenu.SuspendLayout()
        Me.TabGeral.SuspendLayout()
        Me.TabPesquisa.SuspendLayout()
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabCadastro
        '
        Me.TabCadastro.Controls.Add(Me.Label1)
        Me.TabCadastro.Controls.Add(Me.cmbCategoriaProduto)
        Me.TabCadastro.Controls.Add(Me.DescricaoProduto)
        Me.TabCadastro.Controls.Add(Me.txtDescricao)
        Me.TabCadastro.Controls.Add(Me.txtValor)
        Me.TabCadastro.Controls.Add(Me.txtCodigo)
        Me.TabCadastro.Controls.Add(Me.ValorProduto)
        Me.TabCadastro.Controls.Add(Me.CodigoIdProduto)
        Me.TabCadastro.Controls.Add(Me.chkAtivo)
        Me.TabCadastro.Controls.Add(Me.TabMenu)
        Me.TabCadastro.Location = New System.Drawing.Point(4, 22)
        Me.TabCadastro.Name = "TabCadastro"
        Me.TabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCadastro.Size = New System.Drawing.Size(546, 252)
        Me.TabCadastro.TabIndex = 2
        Me.TabCadastro.Text = "Cadastro"
        Me.TabCadastro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Categoria do Produto"
        '
        'cmbCategoriaProduto
        '
        Me.cmbCategoriaProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoriaProduto.FormattingEnabled = True
        Me.cmbCategoriaProduto.Location = New System.Drawing.Point(6, 142)
        Me.cmbCategoriaProduto.Name = "cmbCategoriaProduto"
        Me.cmbCategoriaProduto.Size = New System.Drawing.Size(168, 21)
        Me.cmbCategoriaProduto.TabIndex = 3
        '
        'DescricaoProduto
        '
        Me.DescricaoProduto.AutoSize = True
        Me.DescricaoProduto.Location = New System.Drawing.Point(3, 84)
        Me.DescricaoProduto.Name = "DescricaoProduto"
        Me.DescricaoProduto.Size = New System.Drawing.Size(55, 13)
        Me.DescricaoProduto.TabIndex = 21
        Me.DescricaoProduto.Text = "Descrição"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(6, 100)
        Me.txtDescricao.MaxLength = 100
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(515, 20)
        Me.txtDescricao.TabIndex = 2
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(202, 143)
        Me.txtValor.MaxLength = 16
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(101, 20)
        Me.txtValor.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(6, 56)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'ValorProduto
        '
        Me.ValorProduto.AutoSize = True
        Me.ValorProduto.Location = New System.Drawing.Point(202, 127)
        Me.ValorProduto.Name = "ValorProduto"
        Me.ValorProduto.Size = New System.Drawing.Size(31, 13)
        Me.ValorProduto.TabIndex = 19
        Me.ValorProduto.Text = "Valor"
        '
        'CodigoIdProduto
        '
        Me.CodigoIdProduto.AutoSize = True
        Me.CodigoIdProduto.Location = New System.Drawing.Point(6, 40)
        Me.CodigoIdProduto.Name = "CodigoIdProduto"
        Me.CodigoIdProduto.Size = New System.Drawing.Size(40, 13)
        Me.CodigoIdProduto.TabIndex = 18
        Me.CodigoIdProduto.Text = "Codigo"
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(124, 56)
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
        Me.TabMenu.Size = New System.Drawing.Size(540, 25)
        Me.TabMenu.TabIndex = 8
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
        'TabGeral
        '
        Me.TabGeral.Controls.Add(Me.TabPesquisa)
        Me.TabGeral.Controls.Add(Me.TabCadastro)
        Me.TabGeral.Location = New System.Drawing.Point(13, 12)
        Me.TabGeral.Name = "TabGeral"
        Me.TabGeral.SelectedIndex = 0
        Me.TabGeral.Size = New System.Drawing.Size(554, 278)
        Me.TabGeral.TabIndex = 0
        Me.TabGeral.Tag = ""
        '
        'TabPesquisa
        '
        Me.TabPesquisa.BackColor = System.Drawing.Color.Transparent
        Me.TabPesquisa.Controls.Add(Me.btnPesquisa)
        Me.TabPesquisa.Controls.Add(Me.grdLista)
        Me.TabPesquisa.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPesquisa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TabPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.TabPesquisa.Name = "TabPesquisa"
        Me.TabPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPesquisa.Size = New System.Drawing.Size(546, 252)
        Me.TabPesquisa.TabIndex = 0
        Me.TabPesquisa.Text = "Pesquisa"
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(458, 15)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(82, 23)
        Me.btnPesquisa.TabIndex = 24
        Me.btnPesquisa.Text = "Pesquisar"
        Me.btnPesquisa.UseVisualStyleBackColor = True
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
        Me.grdLista.Size = New System.Drawing.Size(534, 201)
        Me.grdLista.TabIndex = 23
        '
        'FrmCadProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(579, 291)
        Me.Controls.Add(Me.TabGeral)
        Me.Name = "FrmCadProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Produtos"
        Me.TabCadastro.ResumeLayout(False)
        Me.TabCadastro.PerformLayout()
        Me.TabMenu.ResumeLayout(False)
        Me.TabMenu.PerformLayout()
        Me.TabGeral.ResumeLayout(False)
        Me.TabPesquisa.ResumeLayout(False)
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabCadastro As TabPage
    Friend WithEvents DescricaoProduto As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents ValorProduto As Label
    Friend WithEvents CodigoIdProduto As Label
    Friend WithEvents chkAtivo As CheckBox
    Friend WithEvents TabMenu As ToolStrip
    Friend WithEvents btnNovo As ToolStripButton
    Friend WithEvents btnSalvar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents TabGeral As TabControl
    Friend WithEvents TabPesquisa As TabPage
    Friend WithEvents grdLista As DataGridView
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCategoriaProduto As ComboBox
End Class
