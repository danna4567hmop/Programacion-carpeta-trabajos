Public Class FrmRegistro
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        LblResultado.Text = "Nombre: " & TxtNombre.Text & " " & TxtApellido.Text &
                        " | Correo: " & txtCorreo.Text &
                        " | Teléfono: " & TxtTelefono.Text
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtNombre.Clear()
        TxtApellido.Clear()
        txtCorreo.Clear()
        TxtTelefono.Clear()
        LblResultado.Text = ""
        TxtNombre.Focus()
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblMostrarinfo_Click(sender As Object, e As EventArgs)

    End Sub
End Class
