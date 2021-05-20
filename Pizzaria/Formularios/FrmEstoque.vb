Imports Pizzaria.ClassesGenerica

Public Class FrmEstoque

    Dim _funcoes As New Funcoes(Me)

    Private Sub FrmEstoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _funcoes.AtribuirEventos(Me)
        Try
            Call ConfiguraGrid()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub ConfiguraGrid()

        Try
            With grdEstoque

                .RowCount = 0
                .ColumnCount = 0

                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())

                .Columns(0).Name = "idProduto"
                .Columns(1).Name = "descricao"
                .Columns(2).Name = "Entrada"
                .Columns(3).Name = "Saida"
                .Columns(4).Name = "Saldo"

                .Columns("idProduto").HeaderText = "Codigo"
                .Columns("descricao").HeaderText = "Produto"
                .Columns("Entrada").HeaderText = "Entrada"
                .Columns("Saida").HeaderText = "Saida"
                .Columns("Saldo").HeaderText = "Saldo"

                .Columns("idProduto").Width = 60
                .Columns("descricao").Width = 160
                .Columns("Entrada").Width = 80
                .Columns("Saida").Width = 80
                .Columns("Saldo").Width = 70

                .Columns("idProduto").ReadOnly = True
                .Columns("descricao").ReadOnly = True
                .Columns("Entrada").ReadOnly = True
                .Columns("Saida").ReadOnly = True
                .Columns("Saldo").ReadOnly = True

                .Columns("idProduto").Visible = True
                .Columns("descricao").Visible = True
                .Columns("Entrada").Visible = True
                .Columns("Saida").Visible = True
                .Columns("Saldo").Visible = True

            End With
        Catch ex As Exception
            Throw
        End Try

    End Sub


    Private Sub ConfiguraGridEntrada()
        Try

            With grdEstoque

                .RowCount = 0
                .ColumnCount = 0

                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())

                .Columns(0).Name = "idProduto"
                .Columns(1).Name = "descricao"
                .Columns(2).Name = "Entrada"

                .Columns("idProduto").HeaderText = "Codigo"
                .Columns("descricao").HeaderText = "Produto"
                .Columns("Entrada").HeaderText = "Entrada"

                .Columns("idProduto").Width = 60
                .Columns("descricao").Width = 310
                .Columns("Entrada").Width = 80

                .Columns("idProduto").ReadOnly = True
                .Columns("descricao").ReadOnly = True
                .Columns("Entrada").ReadOnly = True

                .Columns("idProduto").Visible = True
                .Columns("descricao").Visible = True
                .Columns("Entrada").Visible = True

            End With
        Catch ex As Exception
            Throw
        End Try

    End Sub


    Private Sub ConfiguraGridSaida()
        Try

            With grdEstoque

                .RowCount = 0
                .ColumnCount = 0

                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())
                .Columns.Add(New DataGridViewTextBoxColumn())

                .Columns(0).Name = "idProduto"
                .Columns(1).Name = "descricao"
                .Columns(2).Name = "Saida"

                .Columns("idProduto").HeaderText = "Codigo"
                .Columns("descricao").HeaderText = "Produto"
                .Columns("Saida").HeaderText = "Saida"

                .Columns("idProduto").Width = 60
                .Columns("descricao").Width = 310
                .Columns("Saida").Width = 80

                .Columns("idProduto").ReadOnly = True
                .Columns("descricao").ReadOnly = True
                .Columns("Saida").ReadOnly = True

                .Columns("idProduto").Visible = True
                .Columns("descricao").Visible = True
                .Columns("Saida").Visible = True

            End With
        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub EntradaSaida_Click(sender As Object, e As EventArgs) Handles EntradaSaida.Click

        Call ConfiguraGrid()

        Dim con = New Connection

        Try
            With grdEstoque

                Dim EstoqueAcoes = New EstoqueAcoes

                con.OpenConnection()
                Dim lista = EstoqueAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("idProduto", i).Value = lista(i).Produto.IdProduto
                        .Item("descricao", i).Value = lista(i).Produto.Descricao
                        .Item("Entrada", i).Value = lista(i).qtdeEntrada
                        .Item("Saida", i).Value = lista(i).qtdeSaida
                        .Item("Saldo", i).Value = lista(i).qtdeEntrada - lista(i).qtdeSaida

                    Next

                End If
            End With

        Catch ex As Exception

            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [Entrada_Click]: " + ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Entrada_Click(sender As Object, e As EventArgs) Handles Entrada.Click

        Call ConfiguraGridEntrada()

        Dim con = New Connection


        Try
            With grdEstoque

                Dim EstoqueAcoes = New EstoqueAcoes

                con.OpenConnection()
                Dim lista = EstoqueAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("idProduto", i).Value = lista(i).Produto.IdProduto
                        .Item("descricao", i).Value = lista(i).Produto.Descricao
                        .Item("Entrada", i).Value = lista(i).qtdeEntrada

                    Next

                End If
            End With

        Catch ex As Exception

            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [Entrada_Click]: " + ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub Saida_Click(sender As Object, e As EventArgs) Handles Saida.Click

        Call ConfiguraGridSaida()

        Dim con = New Connection


        Try
            With grdEstoque

                Dim EstoqueAcoes = New EstoqueAcoes

                con.OpenConnection()
                Dim lista = EstoqueAcoes.Lista(con)
                con.CloseConnection()

                If lista.Count > 0 Then

                    For i As Short = 0 To lista.Count - 1

                        .Rows.Add()

                        .Item("idProduto", i).Value = lista(i).Produto.IdProduto
                        .Item("descricao", i).Value = lista(i).Produto.Descricao
                        .Item("Saida", i).Value = lista(i).qtdeSaida

                    Next

                End If
            End With

        Catch ex As Exception

            Try
                con.CloseConnection()
            Catch ex1 As Exception
            End Try

            MsgBox("Houve um erro ao tentar executar o método [Entrada_Click]: " + ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

End Class