Imports System
Imports System.Windows.Forms

Partial Public Class Form1
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If cboServicios.SelectedIndex = -1 Then
            lblSeleccion.Text = "Seleccione un servicio."
            Return
        End If

        lblSeleccion.Text = "Servicio seleccionado: " & cboServicios.SelectedItem.ToString()
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        cboServicios.SelectedIndex = -1
        lblSeleccion.Text = "Servicio seleccionado:"
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
