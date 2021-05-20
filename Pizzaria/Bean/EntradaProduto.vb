Public Class EntradaProduto

    Public Property IdEntradaProduto As UShort
    Public Property IdEntrada As UShort
    Public Property Produto As Produtos
    Public Property Quantidade As UShort
    Public Property Valor As Decimal
    Public Property DataValidade As String

    Public Sub New()

        IdEntradaProduto = 0
        IdEntrada = 0
        Produto = New Produtos()
        Quantidade = 0
        Valor = 0
        DataValidade = ""
    End Sub

End Class
