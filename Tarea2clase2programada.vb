Public Class Form1

    Private Sub btnEvaluar_Click(sender As Object, e As EventArgs) Handles btnEvaluar.Click
        Dim n1 As Double
        Dim n2 As Double

        If Double.TryParse(txtNumero1.Text, n1) AndAlso
           Double.TryParse(txtNumero2.Text, n2) Then

            If n1 > n2 Then
                MessageBox.Show("El mayor es: " & n1, "Resultado")
            ElseIf n2 > n1 Then
                MessageBox.Show("El mayor es: " & n2, "Resultado")
            Else
                MessageBox.Show("Son iguales", "Resultado")
            End If
        Else
            MessageBox.Show("Escribe números válidos")
        End If
    End Sub

    Private Sub listBoxColores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBoxColores.SelectedIndexChanged
        If listBoxColores.SelectedItem Is Nothing Then Exit Sub

        Select Case listBoxColores.SelectedItem.ToString()
            Case "Rojo"
                Me.BackColor = Color.LightCoral
            Case "Verde"
                Me.BackColor = Color.LightGreen
            Case "Azul"
                Me.BackColor = Color.LightBlue
        End Select
    End Sub

    Private Sub cambiarColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cambiarColorToolStripMenuItem.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If
    End Sub

End Class
