Imports System.Windows.Forms

Public Class MdiPizzaria

    Public Property FuncionarioLogado As Funcionarios

    Private Sub mnuCadPizza_Click(sender As Object, e As EventArgs) Handles mnuCadPizza.Click

        FrmCadPizza.Show()
        FrmCadPizza.MdiParent = Me
        FrmCadPizza.Focus()

    End Sub

    Private Sub mnuCadProdutos_Click(sender As Object, e As EventArgs) Handles mnuCadProdutos.Click

        FrmCadProdutos.Show()
        FrmCadProdutos.MdiParent = Me
        FrmCadProdutos.Focus()

    End Sub

    Private Sub mnuCadFuncionarios_Click(sender As Object, e As EventArgs) Handles mnuCadFuncionarios.Click

        FrmCadFuncionarios.Show()
        FrmCadFuncionarios.MdiParent = Me
        FrmCadFuncionarios.Focus()

    End Sub

    Private Sub mnuCadClientes_Click(sender As Object, e As EventArgs) Handles mnuCadClientes.Click

        FrmCadClientes.Show()
        FrmCadClientes.MdiParent = Me
        FrmCadClientes.Focus()

    End Sub



    Private Sub mnuCadPagamentos_Click_1(sender As Object, e As EventArgs) Handles mnuCadPagamentos.Click

        FrmCadPagamentos.Show()
        FrmCadPagamentos.MdiParent = Me
        FrmCadPagamentos.Focus()

    End Sub

    Private Sub mnuPedidos_Click(sender As Object, e As EventArgs) Handles mnuPedidos.Click

        FrmPedidos.Show()
        FrmPedidos.MdiParent = Me
        FrmPedidos.Focus()

    End Sub

    Private Sub mnuCategoriaProduto_Load(sender As Object, e As EventArgs) Handles mnuCategoriaProduto.Click

        FrmCategoriaProduto.Show()
        FrmCategoriaProduto.MdiParent = Me
        FrmCategoriaProduto.Focus()

    End Sub

    Private Sub mnuEntradaProdutos_Click(sender As Object, e As EventArgs) Handles mnuEntradaProdutos.Click

        FrmEntradaProduto.Show()
        FrmEntradaProduto.MdiParent = Me
        FrmEntradaProduto.Focus()

    End Sub

    Private Sub mnuSaídaProdutos_Click(sender As Object, e As EventArgs) Handles mnuSaídaProdutos.Click

        FrmSaidaProduto.Show()
        FrmSaidaProduto.MdiParent = Me
        FrmSaidaProduto.Focus()

    End Sub

    Private Sub mnuEstoque_Click(sender As Object, e As EventArgs) Handles mnuEstoque.Click

        FrmEstoque.Show()
        FrmEstoque.MdiParent = Me
        FrmEstoque.Focus()

    End Sub
End Class
