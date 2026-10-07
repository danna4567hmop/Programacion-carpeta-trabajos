Public Class Form1

    Public Sub New()
        InitializeComponent()
        AddHandler btnMostrar.Click, AddressOf btnMostrar_Click
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs)
        Dim numero As Integer

        If Not Integer.TryParse(txtNumero.Text, numero) Then
            MessageBox.Show("El valor ingresado no es un número", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNumero.Clear()
            txtNumero.Focus()
            Exit Sub
        End If

        Select Case numero
            Case 1
                MessageBox.Show("Usted ingresó el número 1", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Usted ingresó el número 2", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 3
                MessageBox.Show("Usted ingresó el número 3", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 4
                MessageBox.Show("Usted ingresó el número 4", "Mensaje",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Else
                MessageBox.Show("El número no está en el rango de 1 a 4", "Error de rango",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select

        txtNumero.Clear()
        txtNumero.Focus()
    End Sub

End Class