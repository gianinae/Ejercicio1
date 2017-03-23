<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtImprimir = New System.Windows.Forms.TextBox()
        Me.btnResultado = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtImprimir
        '
        Me.txtImprimir.Location = New System.Drawing.Point(12, 12)
        Me.txtImprimir.Multiline = True
        Me.txtImprimir.Name = "txtImprimir"
        Me.txtImprimir.Size = New System.Drawing.Size(100, 114)
        Me.txtImprimir.TabIndex = 0
        '
        'btnResultado
        '
        Me.btnResultado.Location = New System.Drawing.Point(137, 57)
        Me.btnResultado.Name = "btnResultado"
        Me.btnResultado.Size = New System.Drawing.Size(75, 23)
        Me.btnResultado.TabIndex = 1
        Me.btnResultado.Text = "Resultado"
        Me.btnResultado.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(12, 132)
        Me.txtResultado.Multiline = True
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 117)
        Me.txtResultado.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnResultado)
        Me.Controls.Add(Me.txtImprimir)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtImprimir As TextBox
    Friend WithEvents btnResultado As Button
    Friend WithEvents txtResultado As TextBox
End Class
