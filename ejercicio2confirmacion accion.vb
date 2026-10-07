Partial Public Class Form1
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta As DialogResult

        respuesta = MessageBox.Show("¿Desea salir del programa?", "Confirmar salida",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Me.Close() ' Cierra el formulario
        Else
            MessageBox.Show("El programa continuará en ejecución", "Información",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
