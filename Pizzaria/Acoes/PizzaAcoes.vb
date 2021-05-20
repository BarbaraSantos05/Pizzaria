Imports MySql.Data.MySqlClient
Imports Pizzaria.ClassesGenerica

Public Class PizzaAcoes

    Public Function Salvar(ByRef con As Connection, ByVal pizza As Pizza) As Boolean

        Try

            con.Command.Parameters.Clear()         'Limpa todos os parâmetros

            If pizza.IdPizza = 0 Then              'Se o id for = 0 ( ainda não existe), vai salvar. Se for diferente, vai alterar     

                con.Command.CommandText = "Insert Into tbPizza (" +
                "idPizza, nome, valor, ativo" +                                         'Insere no banco
                ") Values (" +
                "@idPizza" +
                ", @nome" +
                ", @valor" +
                ", @ativo" +
                ")"

            Else

                con.Command.CommandText = "Update tbPizza Set " +                       'Alterar as infos no banco
                " nome=@nome, valor=@valor, ativo=@ativo" +
                " Where idPizza=@idPizza"

            End If

            con.InserirParametroNoCamando(pizza.IdPizza, "@idPizza", DbType.UInt16)         'Parâmetros : objeto, nome e o tipo dele.
            con.InserirParametroNoCamando(pizza.Nome, "@nome", DbType.String)
            con.InserirParametroNoCamando(pizza.Valor, "@valor", DbType.Decimal)
            con.InserirParametroNoCamando(pizza.Ativo, "@ativo", DbType.Boolean)

            con.Command.ExecuteNonQuery()                        'Verifica se salvou/Alterou

            Return True                                          'Confirma

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Lista(ByRef con As Connection) As List(Of Pizza)         'Lista todos os parametros quando vai pesquisar.

        Try

            Dim listaPizza = New List(Of Pizza)                                        'Lista de um objeto Pizza                                

            con.Command.Parameters.Clear()                                              'Limpa os parâmetros             

            con.Command.CommandText = "Select idPizza, nome, valor, ativo" +            'Seleciona da tabela Pizza.
                " From tbPizza" +
                " Order by nome"

            Dim dt = con.ExecutaComandoDataTable                                        'Pega as informações do banco de traz para o formulário

            If dt.Rows.Count > 0 Then

                For i As Short = 0 To dt.Rows.Count - 1

                    Dim pizza = New Pizza                                      'Instancia um objeto

                    pizza.IdPizza = dt.Rows(i).Item("idPizza")                  'Cada Atributo vai recer o parâmetro que estava guardado no banco   
                    pizza.Nome = dt.Rows(i).Item("nome")
                    pizza.Valor = dt.Rows(i).Item("valor")
                    pizza.Ativo = dt.Rows(i).Item("ativo")

                    listaPizza.Add(pizza)                                        'Vai adicionar os parâmetros na lista de Pizza

                Next

            End If

            Return listaPizza                                                     'Retorna a lista

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Detalhe(ByRef con As Connection, ByVal idPizza As UShort) As Pizza       'Funcao que irá mostrar todos os dados que estão salvos quando clicar na pizza da lista


        Try

            Dim pizza = New Pizza                                       'Instancia o objeto

            con.Command.Parameters.Clear()                               'Limpa os parâmetros       

            con.Command.CommandText = "Select idPizza, nome, valor, ativo" +            'Seleciona os parâmetros da tabela Pizza
                " From tbPizza" +                                                       'Onde o idPizza for igual ao idPizza do banco
                " Where idPizza=@idPizza"

            con.InserirParametroNoCamando(idPizza, "idPizza", DbType.UInt16)

            Dim dt = con.ExecutaComandoDataTable                                  'Pega as informações do banco de traz para o formulário

            If dt.Rows.Count = 1 Then

                pizza.IdPizza = dt.Rows(0).Item("idPizza")
                pizza.Nome = dt.Rows(0).Item("nome")                           'Cada Atributo vai recer o parâmetro que estava guardado no banco  
                pizza.Valor = dt.Rows(0).Item("valor")
                pizza.Ativo = dt.Rows(0).Item("ativo")

            End If

            Return pizza

        Catch ex As Exception
            Throw
        End Try

    End Function

    Public Function Excluir(ByRef con As Connection, ByVal idPizza As UShort) As Boolean

        Try

            con.Command.Parameters.Clear()                        'Limpa os parâmetros

            con.Command.CommandText = "Delete From tbPizza" +               'Deleta da tabela Pizza onde o idPizza selecionado for igual ao idPizza no banco
                " Where idPizza=@idPizza"

            con.InserirParametroNoCamando(idPizza, "idPizza", DbType.UInt16)

            con.Command.ExecuteNonQuery()

            Return True

        Catch ex As Exception
            Throw
        End Try

    End Function


    Public Sub PreencheComboPizza(ByRef combo As ComboBox)          'Usado para preencher automaticamente uma combo em um formulario e trazer todas as informações

        Dim con = New Connection                                     'Instancia uma conexão   

        Try

            combo.Items.Clear()                             'Limpa os itens
            combo.Items.Add("")                             'Primeira linha vazia            

            con.OpenConnection()                                'Abre conexão
            Dim listaPizza = Lista(con)                         'Chama a ação de lista     
            con.CloseConnection()                               'Chama conexão

            If listaPizza.Count > 0 Then                            'Se a lista de Pizza tiver mais de um valor

                For i As UShort = 0 To listaPizza.Count - 1

                    Dim item = New Item(listaPizza(i).IdPizza, listaPizza(i).Nome)          'Cada linha vai receber o Id e o Nome correspondente

                    combo.Items.Add(item)                                                    'Vai add na combo

                Next
            End If

        Catch ex As Exception
            con.CloseConnection()
            Throw
        End Try

    End Sub

End Class
