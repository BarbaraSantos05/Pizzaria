Public Class Pizza

    Public Property IdPizza As UShort
    Public Property Nome As String
    Public Property Valor As Decimal
    Public Property Ativo As Boolean
    Public Property IdTamanhoPizza As UShort

    Public Sub New()
        IdPizza = 0
        Nome = ""
        Valor = 0
        Ativo = True
        IdTamanhoPizza = 0
    End Sub

End Class