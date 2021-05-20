<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCadFuncionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCadFuncionarios))
        Me.TabGeral = New System.Windows.Forms.TabControl()
        Me.TabPesquisa = New System.Windows.Forms.TabPage()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.grdLista = New System.Windows.Forms.DataGridView()
        Me.TabCadastro = New System.Windows.Forms.TabPage()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkAtivo = New System.Windows.Forms.CheckBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.btnNovo = New System.Windows.Forms.ToolStripButton()
        Me.btnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.TabGeral.SuspendLayout()
        Me.TabPesquisa.SuspendLayout()
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCadastro.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGeral
        '
        Me.TabGeral.Controls.Add(Me.TabPesquisa)
        Me.TabGeral.Controls.Add(Me.TabCadastro)
        Me.TabGeral.Location = New System.Drawing.Point(10, 9)
        Me.TabGeral.Name = "TabGeral"
        Me.TabGeral.SelectedIndex = 0
        Me.TabGeral.Size = New System.Drawing.Size(612, 274)
        Me.TabGeral.TabIndex = 0
        '
        'TabPesquisa
        '
        Me.TabPesquisa.Controls.Add(Me.btnPesquisar)
        Me.TabPesquisa.Controls.Add(Me.grdLista)
        Me.TabPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.TabPesquisa.Name = "TabPesquisa"
        Me.TabPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPesquisa.Size = New System.Drawing.Size(604, 248)
        Me.TabPesquisa.TabIndex = 0
        Me.TabPesquisa.Text = "Pesquisa"
        Me.TabPesquisa.UseVisualStyleBackColor = True
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(493, 10)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(96, 26)
        Me.btnPesquisar.TabIndex = 0
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'grdLista
        '
        Me.grdLista.AllowUserToAddRows = False
        Me.grdLista.AllowUserToDeleteRows = False
        Me.grdLista.AllowUserToResizeRows = False
        Me.grdLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdLista.Location = New System.Drawing.Point(6, 42)
        Me.grdLista.Name = "grdLista"
        Me.grdLista.RowHeadersVisible = False
        Me.grdLista.Size = New System.Drawing.Size(592, 198)
        Me.grdLista.TabIndex = 0
        '
        'TabCadastro
        '
        Me.TabCadastro.Controls.Add(Me.txtSalario)
        Me.TabCadastro.Controls.Add(Me.Label2)
        Me.TabCadastro.Controls.Add(Me.chkAtivo)
        Me.TabCadastro.Controls.Add(Me.txtCargo)
        Me.TabCadastro.Controls.Add(Me.txtNome)
        Me.TabCadastro.Controls.Add(Me.txtCodigo)
        Me.TabCadastro.Controls.Add(Me.Label4)
        Me.TabCadastro.Controls.Add(Me.Label3)
        Me.TabCadastro.Controls.Add(Me.Label1)
        Me.TabCadastro.Controls.Add(Me.ToolStrip)
        Me.TabCadastro.Location = New System.Drawing.Point(4, 22)
        Me.TabCadastro.Name = "TabCadastro"
        Me.TabCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCadastro.Size = New System.Drawing.Size(604, 248)
        Me.TabCadastro.TabIndex = 1
        Me.TabCadastro.Text = "Cadastro Funcionarios"
        Me.TabCadastro.UseVisualStyleBackColor = True
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(129, 119)
        Me.txtSalario.MaxLength = 6
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(100, 20)
        Me.txtSalario.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Salario"
        '
        'chkAtivo
        '
        Me.chkAtivo.AutoSize = True
        Me.chkAtivo.Location = New System.Drawing.Point(9, 155)
        Me.chkAtivo.Name = "chkAtivo"
        Me.chkAtivo.Size = New System.Drawing.Size(50, 17)
        Me.chkAtivo.TabIndex = 4
        Me.chkAtivo.Text = "Ativo"
        Me.chkAtivo.UseVisualStyleBackColor = True
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(9, 119)
        Me.txtCargo.MaxLength = 100
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(100, 20)
        Me.txtCargo.TabIndex = 2
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(129, 69)
        Me.txtNome.MaxLength = 100
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(433, 20)
        Me.txtNome.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(8, 69)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(101, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(126, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Cargo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Código"
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNovo, Me.btnSalvar, Me.ToolStripSeparator1, Me.btnExcluir})
        Me.ToolStrip.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(598, 25)
        Me.ToolStrip.TabIndex = 8
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
        'FrmCadFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 283)
        Me.Controls.Add(Me.TabGeral)
        Me.Name = "FrmCadFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastrar Funcionarios"
        Me.TabGeral.ResumeLayout(False)
        Me.TabPesquisa.ResumeLayout(False)
        CType(Me.grdLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCadastro.ResumeLayout(False)
        Me.TabCadastro.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabGeral As TabControl
    Friend WithEvents TabPesquisa As TabPage
    Friend WithEvents TabCadastro As TabPage
    Friend WithEvents grdLista As DataGridView
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents btnNovo As ToolStripButton
    Friend WithEvents btnSalvar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnExcluir As ToolStripButton
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkAtivo As CheckBox
    Friend WithEvents txtCargo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
End Class
