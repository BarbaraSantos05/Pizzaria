Public Class SaidaProduto

    Public Property IdSaidaProduto As UShort
    Public Property IdSaida As UShort
    Public Property Produto As Produtos
    Public Property Valor As Decimal
    Public Property Quantidade As UShort


    Public Sub New()

        IdSaidaProduto = 0
        IdSaida = 0
        Produto = New Produtos()
        Valor = 0
        Quantidade = 0
    End Sub
End Class
