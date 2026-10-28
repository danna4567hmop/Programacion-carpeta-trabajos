Imports System.Drawing

Partial Public Class Form1
    Private Sub btnEvaluar_Click(sender As Object, e As EventArgs) Handles btnEvaluar.Click
        Dim nota As Double

        If Not Double.TryParse(txtNota.Text, nota) Then
            MessageBox.Show("Ingrese un valor numérico válido.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNota.Clear()
            txtNota.Focus()
            Return
        End If

        If nota < 0 OrElse nota > 100 Then
            MessageBox.Show("La nota debe estar entre 0 y 100.", "Rango inválido",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNota.Clear()
            txtNota.Focus()
            Return
        End If

        Dim color As Color
        Dim resultado As String = ObtenerCategoria(nota, color)

        lblResultado.Text = $"Categoría: {resultado}"
        lblResultado.BackColor = color

        lstCategorias.ClearSelected()
        Dim indice As Integer = lstCategorias.FindStringExact(resultado)
        If indice >= 0 Then
            lstCategorias.SelectedIndex = indice
        End If
    End Sub

    Private Function ObtenerCategoria(nota As Double, ByRef colorFondo As Color) As String
        If nota >= 90 Then
            colorFondo = Color.LightGreen
            Return "Excelente"
        ElseIf nota >= 80 Then
            colorFondo = Color.Empty
            Return "Muy bueno"
        ElseIf nota >= 70 Then
            colorFondo = Color.Empty
            Return "Bueno"
        ElseIf nota >= 60 Then
            colorFondo = Color.Empty
            Return "Regular"
        Else
            colorFondo = Color.LightCoral
            Return "Deficiente"
        End If
    End Function

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNota.Clear()
        lblResultado.Text = String.Empty
        lblResultado.BackColor = Color.Transparent
        lstCategorias.ClearSelected()
        txtNota.Focus()
    End Sub
End Class
