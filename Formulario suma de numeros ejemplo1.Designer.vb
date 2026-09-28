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
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.btnsumar = New System.Windows.Forms.Button()
        Me.lblresultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(12, 24)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 22)
        Me.txtnum1.TabIndex = 0
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(12, 75)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 22)
        Me.txtnum2.TabIndex = 1
        '
        'btnsumar
        '
        Me.btnsumar.Location = New System.Drawing.Point(12, 137)
        Me.btnsumar.Name = "btnsumar"
        Me.btnsumar.Size = New System.Drawing.Size(100, 41)
        Me.btnsumar.TabIndex = 2
        Me.btnsumar.Text = "sumar"
        Me.btnsumar.UseVisualStyleBackColor = True
        '
        'lblresultado
        '
        Me.lblresultado.AutoSize = True
        Me.lblresultado.Location = New System.Drawing.Point(29, 207)
        Me.lblresultado.Name = "lblresultado"
        Me.lblresultado.Size = New System.Drawing.Size(63, 16)
        Me.lblresultado.TabIndex = 3
        Me.lblresultado.Text = "resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblresultado)
        Me.Controls.Add(Me.btnsumar)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents btnsumar As Button
    Friend WithEvents lblresultado As Label
End Class
