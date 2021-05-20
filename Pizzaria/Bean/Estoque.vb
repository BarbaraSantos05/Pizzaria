Public Class Estoque

    Public Property Produto As Produtos
    Public Property qtdeEntrada As UShort
    Public Property qtdeSaida As UShort

    Public Sub New()

        Produto = New Produtos()
        qtdeEntrada = 0
        qtdeSaida = 0

    End Sub

End Class
