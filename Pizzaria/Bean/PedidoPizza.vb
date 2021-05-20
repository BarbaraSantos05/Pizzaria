Public Class PedidoPizza

    Public Property IdPedidoPizza As UShort
    Public Property IdPedido As UShort
    Public Property Pizza As Pizza
    Public Property Quantidade As UShort
    Public Property Valor As Decimal


    Public Sub New()
        IdPedidoPizza = 0
        IdPedido = 0
        Pizza = New Pizza()
        Quantidade = 0
        Valor = 0
    End Sub

End Class
