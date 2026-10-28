Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim horas As Double
        Dim pagoHora As Double

        If Not Double.TryParse(txtHoras.Text, horas) OrElse horas <= 0 Then
            MessageBox.Show("Las horas trabajadas deben ser un número mayor que cero.",
                            "Error de validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtHoras.Clear()
            txtHoras.Focus()
            Return
        End If

        If Not Double.TryParse(txtPagoHora.Text, pagoHora) OrElse pagoHora <= 0 Then
            MessageBox.Show("El pago por hora debe ser un número mayor que cero.",
                            "Error de validación",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtPagoHora.Clear()
            txtPagoHora.Focus()
            Return
        End If

        Dim salarioNormal As Double
        Dim salarioExtra As Double = 0

        If horas <= 40 Then
            salarioNormal = horas * pagoHora
        Else
            salarioNormal = 40 * pagoHora
            Dim horasExtras As Double = horas - 40
            salarioExtra = horasExtras * pagoHora * 1.5
        End If

        Dim salarioTotal As Double = salarioNormal + salarioExtra
        Dim nombre As String = If(String.IsNullOrWhiteSpace(txtNombre.Text), "Trabajador", txtNombre.Text.Trim())

        lblResultado.Text = $"Nombre: {nombre}{Environment.NewLine}" &
                            $"Salario normal: ₡{salarioNormal:N2}{Environment.NewLine}" &
                            $"Salario horas extras: ₡{salarioExtra:N2}{Environment.NewLine}" &
                            $"TOTAL A PAGAR: ₡{salarioTotal:N2}"
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNombre.Clear()
        txtHoras.Clear()
        txtPagoHora.Clear()
        lblResultado.Text = "Resultado"
        txtNombre.Focus()
    End Sub
End Class
