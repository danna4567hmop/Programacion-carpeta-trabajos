Partial Class Form1
    Public Sub New()
        InitializeComponent()
        AddHandler btnSeleccionar.Click, AddressOf btnSeleccionar_Click
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs)
        Dim opcion As Integer

        ' Validar que sea un número
        If Not Integer.TryParse(txtOpcion.Text, opcion) Then
            MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOpcion.Clear()
            txtOpcion.Focus()
            Exit Sub
        End If

        Select Case opcion
            Case 1
                MessageBox.Show("Usted eligió la opción 1", "Opción 1", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Usted eligió la opción 2", "Opción 2", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 3
                MessageBox.Show("Usted eligió la opción 3", "Opción 3", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Else
                MessageBox.Show("Ingrese solo 1, 2 o 3", "Rango inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Select

        txtOpcion.Clear()
        txtOpcion.Focus()
    End Sub
End Class
