Public Class Form1

    Private Sub btnMostrarDia_Click(sender As Object, e As EventArgs) Handles btnMostrarDia.Click
        Dim dia As Integer

        ' Validar que sea un número
        If Not Integer.TryParse(txtDia.Text, dia) Then
            MessageBox.Show("Debe ingresar un número válido", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDia.Clear()
            txtDia.Focus()
            Exit Sub
        End If

        ' Mostrar el día correspondiente
        Select Case dia
            Case 1
                MessageBox.Show("Lunes", "Día de la semana",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Martes", "Día de la semana",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 3
                MessageBox.Show("Miércoles", "Día de la semana",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 4
                MessageBox.Show("Jueves", "Día de la semana",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 5
                MessageBox.Show("Viernes", "Día de la semana",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 6
                MessageBox.Show("Sábado", "Día de la semana",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 7
                MessageBox.Show("Domingo", "Día de la semana",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Else
                MessageBox.Show("Error: el número debe estar entre 1 y 7", "Error de rango",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select

        ' Limpiar la caja
        txtDia.Clear()
        txtDia.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializaciones adicionales (sin AddHandler para btnMostrarDia)
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim respuesta As DialogResult
        respuesta = MessageBox.Show("¿Realmente desea salir?", "Confirmar salida",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If respuesta = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class