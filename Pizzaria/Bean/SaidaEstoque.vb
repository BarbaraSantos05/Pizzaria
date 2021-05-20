Public Class SaidaEstoque


    Public Property IdSaida As UShort
    Public Property idPedido As UShort
    Public Property idFuncionario As UShort
    Public Property Nome As String
    Public Property DataSaida As Date
    Public Property QuantidadeTotal As UShort
    Public Property ValorTotal As Decimal
    Public Property Observacao As String
    Public Property ListaSaidaProduto As List(Of SaidaProduto)

    Public Sub New()

        IdSaida = 0
        idPedido = 0
        idFuncionario = 0
        Nome = ""
        DataSaida = Now
        QuantidadeTotal = 0
        ValorTotal = 0
        Observacao = ""
        ListaSaidaProduto = New List(Of SaidaProduto)
    End Sub

End Class
