Public Class EntradaEstoque

    Public Property idEntrada As UShort
    Public Property Funcionario As Funcionarios
    Public Property Fornecedor As String
    Public Property NotaFiscal As String
    Public Property DataEntrada As Date
    Public Property QuantidadeTotal As UShort
    Public Property ValorTotal As Decimal
    Public Property Observacao As String
    Public Property ListaEntradaProduto As List(Of EntradaProduto)

    Public Sub New()

        idEntrada = 0
        Funcionario = New Funcionarios()
        Fornecedor = ""
        NotaFiscal = ""
        DataEntrada = Now
        QuantidadeTotal = 0
        ValorTotal = 0
        Observacao = ""
        ListaEntradaProduto = New List(Of EntradaProduto)

    End Sub


End Class
