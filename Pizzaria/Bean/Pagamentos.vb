Public Class Pagamentos

    Public Property IdPagamento As UShort
    Public Property Descricao As String
    Public Property Ativo As Boolean
    Public Property TemMaquininha As Boolean

    Public Sub New()
        IdPagamento = 0
        Descricao = ""
        Ativo = True
        TemMaquininha = True
    End Sub

End Class
