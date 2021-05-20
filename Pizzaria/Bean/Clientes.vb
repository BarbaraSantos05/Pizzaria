Public Class Clientes

    Public Property IdCliente As UShort
    Public Property Nome As String
    Public Property cpf As String
    Public Property email As String
    Public Property TelCelular As String
    Public Property TelResidencial As String
    Public Property Logradouro As String
    Public Property Numero As UShort
    Public Property Complemento As String
    Public Property Bairro As String
    Public Property Cep As String
    Public Property Ativo As Boolean

    Public Sub New()
        IdCliente = 0
        Nome = ""
        cpf = ""
        email = ""
        TelCelular = ""
        TelResidencial = ""
        Logradouro = ""
        Numero = 0
        Complemento = ""
        Bairro = ""
        Cep = ""
        Ativo = True
    End Sub
End Class
