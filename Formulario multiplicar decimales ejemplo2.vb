
Public Class Form1

    Private Sub btnMultiplicar_Click(sender As Object, e As EventArgs) Handles btnmultiplicar.Click
        ' Tomar los valores
        Dim t1 As String = txtnum1.Text
        Dim t2 As String = txtnum2.Text

        ' Variables para decimales
        Dim n1 As Decimal
        Dim n2 As Decimal

        ' Validar primer número
        If Not Decimal.TryParse(t1, n1) Then
            MessageBox.Show("Escribe un número válido en el primer recuadro")
            txtnum1.Clear()
            txtnum1.Focus()
            Exit Sub
        End If

        ' Validar segundo número
        If Not Decimal.TryParse(t2, n2) Then
            MessageBox.Show("Escribe un número válido en el segundo recuadro")
            txtnum2.Clear()
            txtnum2.Focus()
            Exit Sub
        End If

        ' Multiplicar y mostrar
        Dim producto As Decimal = n1 * n2
        lblresultado.Text = "El producto es: " & producto
    End Sub

End Class