Option Strict On
Option Explicit On

Imports System.Globalization

Partial Public Class Form1
    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        ErrorProvider1.Clear()

        Dim datosCorrectos As Boolean = True
        Dim codigo As String = txtCodigo.Text.Trim()
        Dim nombre As String = txtNombre.Text.Trim()
        Dim precio As Double

        If String.IsNullOrWhiteSpace(codigo) Then
            ErrorProvider1.SetError(txtCodigo, "El código no puede estar vacío.")
            datosCorrectos = False
        End If

        If String.IsNullOrWhiteSpace(nombre) Then
            ErrorProvider1.SetError(txtNombre, "El nombre no puede estar vacío.")
            datosCorrectos = False
        End If

        If Not Double.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, precio) OrElse precio <= 0 Then
            ErrorProvider1.SetError(txtPrecio, "El precio debe ser mayor que cero.")
            datosCorrectos = False
        End If

        If Not datosCorrectos Then
            Return
        End If

        Dim miProducto As New Producto With {
            .codigo = codigo,
            .nombre = nombre,
            .precio = precio
        }

        Dim precioConIva As Double = miProducto.ObtenerPrecioConIVA()

        MessageBox.Show(
            $"Código: {miProducto.Codigo}{Environment.NewLine}" &
            $"Nombre: {miProducto.Nombre}{Environment.NewLine}" &
            $"Precio sin IVA: ₡{miProducto.Precio:N2}{Environment.NewLine}" &
            $"Precio con IVA (13%): ₡{precioConIva:N2}",
            "Datos del Producto",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information)
    End Sub
End Class
