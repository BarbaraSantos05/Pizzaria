Imports Pizzaria.ClassesGenerica

Public Class Produtos

    Public Property IdProduto As UShort
    Public Property Descricao As String
    Public Property Valor As Decimal
    Public Property Ativo As Boolean
    Public Property IdCategoriaProduto As UShort

    Public Sub New()

        IdProduto = 0
        Descricao = ""
        Valor = 0
        Ativo = True
        IdCategoriaProduto = 0

    End Sub

End Class
