<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MdiPizzaria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCadPizza = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCadProdutos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCadFuncionarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCadClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCadPagamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCategoriaProduto = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEntradaProdutos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaídaProdutos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPedido = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPedidos = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.mnuEstoque = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastro, Me.EstToolStripMenuItem, Me.mnuPedido})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'mnuCadastro
        '
        Me.mnuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadPizza, Me.mnuCadProdutos, Me.mnuCadFuncionarios, Me.mnuCadClientes, Me.mnuCadPagamentos, Me.mnuCategoriaProduto})
        Me.mnuCadastro.Name = "mnuCadastro"
        Me.mnuCadastro.Size = New System.Drawing.Size(66, 20)
        Me.mnuCadastro.Text = "Cadastro"
        '
        'mnuCadPizza
        '
        Me.mnuCadPizza.Name = "mnuCadPizza"
        Me.mnuCadPizza.Size = New System.Drawing.Size(171, 22)
        Me.mnuCadPizza.Text = "Pizza"
        '
        'mnuCadProdutos
        '
        Me.mnuCadProdutos.Name = "mnuCadProdutos"
        Me.mnuCadProdutos.Size = New System.Drawing.Size(171, 22)
        Me.mnuCadProdutos.Text = "Produtos"
        '
        'mnuCadFuncionarios
        '
        Me.mnuCadFuncionarios.Name = "mnuCadFuncionarios"
        Me.mnuCadFuncionarios.Size = New System.Drawing.Size(171, 22)
        Me.mnuCadFuncionarios.Text = "Funcionarios"
        '
        'mnuCadClientes
        '
        Me.mnuCadClientes.Name = "mnuCadClientes"
        Me.mnuCadClientes.Size = New System.Drawing.Size(171, 22)
        Me.mnuCadClientes.Text = "Clientes"
        '
        'mnuCadPagamentos
        '
        Me.mnuCadPagamentos.Name = "mnuCadPagamentos"
        Me.mnuCadPagamentos.Size = New System.Drawing.Size(171, 22)
        Me.mnuCadPagamentos.Text = "Pagamentos"
        '
        'mnuCategoriaProduto
        '
        Me.mnuCategoriaProduto.Name = "mnuCategoriaProduto"
        Me.mnuCategoriaProduto.Size = New System.Drawing.Size(171, 22)
        Me.mnuCategoriaProduto.Text = "Categoria Produto"
        '
        'EstToolStripMenuItem
        '
        Me.EstToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEntradaProdutos, Me.mnuSaídaProdutos, Me.mnuEstoque})
        Me.EstToolStripMenuItem.Name = "EstToolStripMenuItem"
        Me.EstToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EstToolStripMenuItem.Text = "Estoque"
        '
        'mnuEntradaProdutos
        '
        Me.mnuEntradaProdutos.Name = "mnuEntradaProdutos"
        Me.mnuEntradaProdutos.Size = New System.Drawing.Size(180, 22)
        Me.mnuEntradaProdutos.Text = "Entrada Produtos"
        '
        'mnuSaídaProdutos
        '
        Me.mnuSaídaProdutos.Name = "mnuSaídaProdutos"
        Me.mnuSaídaProdutos.Size = New System.Drawing.Size(180, 22)
        Me.mnuSaídaProdutos.Text = "Saída Produtos"
        '
        'mnuPedido
        '
        Me.mnuPedido.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPedidos})
        Me.mnuPedido.Name = "mnuPedido"
        Me.mnuPedido.Size = New System.Drawing.Size(61, 20)
        Me.mnuPedido.Text = "Pedidos"
        '
        'mnuPedidos
        '
        Me.mnuPedidos.Name = "mnuPedidos"
        Me.mnuPedidos.Size = New System.Drawing.Size(116, 22)
        Me.mnuPedidos.Text = "Pedidos"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 539)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1284, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'mnuEstoque
        '
        Me.mnuEstoque.Name = "mnuEstoque"
        Me.mnuEstoque.Size = New System.Drawing.Size(180, 22)
        Me.mnuEstoque.Text = "Estoque"
        '
        'MdiPizzaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Pizzaria.My.Resources.Resources.pizzadem
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1284, 561)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MdiPizzaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MdiPizzaria"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuCadastro As ToolStripMenuItem
    Friend WithEvents mnuCadPizza As ToolStripMenuItem
    Friend WithEvents mnuCadProdutos As ToolStripMenuItem
    Friend WithEvents mnuCadFuncionarios As ToolStripMenuItem
    Friend WithEvents mnuCadClientes As ToolStripMenuItem
    Friend WithEvents mnuCadPagamentos As ToolStripMenuItem
    Friend WithEvents mnuPedido As ToolStripMenuItem
    Friend WithEvents mnuPedidos As ToolStripMenuItem
    Friend WithEvents mnuCategoriaProduto As ToolStripMenuItem
    Friend WithEvents EstToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuEntradaProdutos As ToolStripMenuItem
    Friend WithEvents mnuSaídaProdutos As ToolStripMenuItem
    Friend WithEvents mnuEstoque As ToolStripMenuItem
End Class
