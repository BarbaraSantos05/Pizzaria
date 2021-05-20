Public Class Pedido

    Public Property IdPedido As UShort
    Public Property DataPedido As String
    Public Property Funcionario As Funcionarios
    Public Property Cliente As Clientes
    Public Property Observacao As String
    Public Property ValorTotal As Decimal
    Public Property QuantidadeTotal As UShort
    Public Property IdPagamento As UShort
    Public Property LevarMaquininha As Boolean
    Public Property ListaPedidoPizza As List(Of PedidoPizza)
    Public Property ListaPedidoProduto As List(Of PedidoProduto)

    Public Sub New()
        IdPedido = 0
        DataPedido = ""
        Funcionario = New Funcionarios()
        Cliente = New Clientes()
        Observacao = ""
        ValorTotal = 0
        QuantidadeTotal = 0
        IdPagamento = 0
        LevarMaquininha = True
        ListaPedidoPizza = New List(Of PedidoPizza)
        ListaPedidoProduto = New List(Of PedidoProduto)
    End Sub

End Class
