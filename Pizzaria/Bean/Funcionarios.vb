Public Class Funcionarios
    Public Property IdFuncionario As UShort
    Public Property Nome As String
    Public Property Cargo As String
    Public Property Salario As Double
    Public Property Ativo As Boolean

    Public Sub New()
        IdFuncionario = 0
        Nome = ""
        Cargo = ""
        Salario = 0
        Ativo = True
    End Sub

End Class
