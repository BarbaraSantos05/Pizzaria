Public Class PedidoProduto

    Public Property IdPedidoProduto As UShort
    Public Property IdPedido As UShort
    Public Property Produto As Produtos
    Public Property Quantidade As UShort
    Public Property Valor As Decimal

    Public Sub New()

        IdPedidoProduto = 0
        Produto = New Produtos
        Quantidade = 0
        Valor = 0
    End Sub

End Class
