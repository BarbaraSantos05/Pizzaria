<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstoque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdEstoque = New System.Windows.Forms.DataGridView()
        Me.Entrada = New System.Windows.Forms.Button()
        Me.Saida = New System.Windows.Forms.Button()
        Me.EntradaSaida = New System.Windows.Forms.Button()
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdEstoque
        '
        Me.grdEstoque.AllowUserToAddRows = False
        Me.grdEstoque.AllowUserToDeleteRows = False
        Me.grdEstoque.AllowUserToResizeRows = False
        Me.grdEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdEstoque.Location = New System.Drawing.Point(12, 12)
        Me.grdEstoque.Name = "grdEstoque"
        Me.grdEstoque.RowHeadersVisible = False
        Me.grdEstoque.Size = New System.Drawing.Size(452, 358)
        Me.grdEstoque.TabIndex = 0
        '
        'Entrada
        '
        Me.Entrada.Location = New System.Drawing.Point(12, 387)
        Me.Entrada.Name = "Entrada"
        Me.Entrada.Size = New System.Drawing.Size(107, 42)
        Me.Entrada.TabIndex = 1
        Me.Entrada.Text = "Entradas"
        Me.Entrada.UseVisualStyleBackColor = True
        '
        'Saida
        '
        Me.Saida.Location = New System.Drawing.Point(191, 387)
        Me.Saida.Name = "Saida"
        Me.Saida.Size = New System.Drawing.Size(107, 42)
        Me.Saida.TabIndex = 2
        Me.Saida.Text = "Saidas"
        Me.Saida.UseVisualStyleBackColor = True
        '
        'EntradaSaida
        '
        Me.EntradaSaida.Location = New System.Drawing.Point(357, 387)
        Me.EntradaSaida.Name = "EntradaSaida"
        Me.EntradaSaida.Size = New System.Drawing.Size(107, 42)
        Me.EntradaSaida.TabIndex = 3
        Me.EntradaSaida.Text = "Entradas e Saidas"
        Me.EntradaSaida.UseVisualStyleBackColor = True
        '
        'FrmEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 450)
        Me.Controls.Add(Me.EntradaSaida)
        Me.Controls.Add(Me.Saida)
        Me.Controls.Add(Me.Entrada)
        Me.Controls.Add(Me.grdEstoque)
        Me.Name = "FrmEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEstoque"
        CType(Me.grdEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdEstoque As DataGridView
    Friend WithEvents Entrada As Button
    Friend WithEvents Saida As Button
    Friend WithEvents EntradaSaida As Button
End Class
