Public Class Form1

    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnsumar.Click
        ' Tomar los valores que escribe el usuario
        Dim t1 As String = txtnum1.Text
        Dim t2 As String = txtnum2.Text

        ' Declarar variables para los números
        Dim n1 As Integer
        Dim n2 As Integer

        ' Validar primer número
        If Not Integer.TryParse(t1, n1) Then
            MessageBox.Show("Escribe un número válido en el primer recuadro")
            txtnum1.Clear()
            txtnum1.Focus()
            Exit Sub
        End If

        ' Validar segundo número
        If Not Integer.TryParse(t2, n2) Then
            MessageBox.Show("Escribe un número válido en el segundo recuadro")
            txtnum2.Clear()
            txtnum2.Focus()
            Exit Sub
        End If

        ' Sumar y mostrar resultado
        Dim suma As Integer = n1 + n2
        lblresultado.Text = "La suma es: " & suma
    End Sub

End Class
