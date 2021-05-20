<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategoriaProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategoriaProduto))
        Me.TabGeral = New System.Windows.Forms.TabControl()
        Me.TabPesquisa = New System.Windows.Forms.TabPage()
        Me.grdLista = New System.Windows.Forms.DataGridView()
        Me.btnPesquisa = New System.Windows.Forms.Button()
        Me.TabCadastro = New System.Windows.Forms.TabPage()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.CodigoIdProduto = New System.Windows.Forms.Label()
        Me.TabMenu = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.TabGeral.SuspendLayout()
        Me.TabPesquisa.SuspendLayout()
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCadastro.SuspendLayout()
        Me.TabMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGeral
        '
        Me.TabGeral.Controls.Add(Me.TabPesquisa)
        Me.TabGeral.Controls.Add(Me.TabCadastro)
        Me.TabGeral.Location = New System.Drawing.Point(2, 2)
        Me.TabGeral.Name = "TabGeral"
        Me.TabGeral.SelectedIndex = 0
        Me.TabGeral.Size = New System.Drawing.Size(559, 302)
        Me.TabGeral.TabIndex = 2
        '
        'TabPesquisa
        '
        Me.TabPesquisa.Controls.Add(Me.grdLista)
        Me.TabPesquisa.Controls.Add(Me.btnPesquisa)
        Me.TabPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.TabPesquisa.Name = "TabPesquisa"
        Me.TabPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPesquisa.Size = New System.Drawing.Size(551, 276)
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
        Me.grdLista.Location = New System.Drawing.Point(6, 60)
        Me.grdLista.Name = "grdLista"
        Me.grdLista.RowHeadersVisible = False
        Me.grdLista.Size = New System.Drawing.Size(539, 210)
        Me.grdLista.TabIndex = 2
        '
        'btnPesquisa
        '
        Me.btnPesquisa.Location = New System.Drawing.Point(463, 15)
        Me.btnPesquisa.Name = "btnPesquisa"
        Me.btnPesquisa.Size = New System.Drawing.Size(82, 23)
        Me.btnPesquisa.TabIndex = 1
        Me.btnPesquisa.Text = "Pesquisar"
        Me.btnPesquisa.UseVisualStyleBackColor = True
        '
        'TabCadastro
        '
        Me.TabCadastro.Controls.Add(Me.txtCategoria)
        Me.TabCadastro.Controls.Add(Me.Label1)
        Me.TabCadastro.Controls.Add(Me.txtCodigo)
        Me.TabCadastro.Controls.Add(Me.CodigoIdProduto)
        Me.TabCadastro.Controls.Add(Me.TabMenu)
        Me.TabCadastro.Location = New System.Drawing.Point(4, 22)
        Me.TabCadastro.Name = "TabCadastro"
        Me.TabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCadastro.Size = New System.Drawing.Size(551, 276)
        Me.TabCadastro.TabIndex = 1
        Me.TabCadastro.Text = "Cadastro"
        Me.TabCadastro.UseVisualStyleBackColor = True
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(6, 108)
        Me.txtCategoria.MaxLength = 100
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(428, 20)
        Me.txtCategoria.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Categoria"
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(6, 53)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'CodigoIdProduto
        '
        Me.CodigoIdProduto.AutoSize = True
        Me.CodigoIdProduto.Location = New System.Drawing.Point(3, 37)
        Me.CodigoIdProduto.Name = "CodigoIdProduto"
        Me.CodigoIdProduto.Size = New System.Drawing.Size(40, 13)
        Me.CodigoIdProduto.TabIndex = 27
        Me.CodigoIdProduto.Text = "Codigo"
        '
        'TabMenu
        '
        Me.TabMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.btnSalvar, Me.ToolStripSeparator2, Me.btnExcluir})
        Me.TabMenu.Location = New System.Drawing.Point(3, 3)
        Me.TabMenu.Name = "TabMenu"
        Me.TabMenu.Size = New System.Drawing.Size(545, 25)
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
        'FrmCategoriaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 314)
        Me.Controls.Add(Me.TabGeral)
        Me.Name = "FrmCategoriaProduto"
        Me.Text = "Categoria Produto"
        Me.TabGeral.ResumeLayout(False)
        Me.TabPesquisa.ResumeLayout(False)
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCadastro.ResumeLayout(False)
        Me.TabCadastro.PerformLayout()
        Me.TabMenu.ResumeLayout(False)
        Me.TabMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabGeral As TabControl
    Friend WithEvents TabPesquisa As TabPage
    Friend WithEvents btnPesquisa As Button
    Friend WithEvents TabCadastro As TabPage
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents CodigoIdProduto As Label
    Friend WithEvents TabMenu As ToolStrip
    Friend WithEvents btnNovo As ToolStripButton
    Friend WithEvents btnSalvar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents grdLista As DataGridView
End Class
