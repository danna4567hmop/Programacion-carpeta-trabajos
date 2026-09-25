<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Lblnombre = New Label()
        lblApellido = New Label()
        LblCorreo = New Label()
        LblTelefono = New Label()
        LblResultado = New Label()
        TxtNombre = New TextBox()
        TxtApellido = New TextBox()
        TxtCorreo = New TextBox()
        TxtTelefono = New TextBox()
        BtnMostrar = New Button()
        BtnLimpiar = New Button()
        BtnSalir = New Button()
        LblMostrarinfo = New Label()
        SuspendLayout()
        ' 
        ' Lblnombre
        ' 
        Lblnombre.AutoSize = True
        Lblnombre.Location = New Point(28, 16)
        Lblnombre.Name = "Lblnombre"
        Lblnombre.Size = New Size(67, 20)
        Lblnombre.TabIndex = 0
        Lblnombre.Text = "Nombre:"
        ' 
        ' lblApellido
        ' 
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(26, 65)
        lblApellido.Name = "lblApellido"
        lblApellido.Size = New Size(69, 20)
        lblApellido.TabIndex = 1
        lblApellido.Text = "Apellido:"
        ' 
        ' LblCorreo
        ' 
        LblCorreo.AutoSize = True
        LblCorreo.Location = New Point(23, 119)
        LblCorreo.Name = "LblCorreo"
        LblCorreo.Size = New Size(57, 20)
        LblCorreo.TabIndex = 2
        LblCorreo.Text = "Correo:"
        ' 
        ' LblTelefono
        ' 
        LblTelefono.AutoSize = True
        LblTelefono.Location = New Point(23, 181)
        LblTelefono.Name = "LblTelefono"
        LblTelefono.Size = New Size(70, 20)
        LblTelefono.TabIndex = 3
        LblTelefono.Text = "Telefono:"
        ' 
        ' LblResultado
        ' 
        LblResultado.AutoSize = True
        LblResultado.Location = New Point(433, 288)
        LblResultado.Name = "LblResultado"
        LblResultado.Size = New Size(17, 20)
        LblResultado.TabIndex = 4
        LblResultado.Text = "  "
        ' 
        ' TxtNombre
        ' 
        TxtNombre.Location = New Point(118, 13)
        TxtNombre.Name = "TxtNombre"
        TxtNombre.Size = New Size(125, 27)
        TxtNombre.TabIndex = 5
        ' 
        ' TxtApellido
        ' 
        TxtApellido.Location = New Point(118, 62)
        TxtApellido.Name = "TxtApellido"
        TxtApellido.Size = New Size(125, 27)
        TxtApellido.TabIndex = 6
        ' 
        ' TxtCorreo
        ' 
        TxtCorreo.Location = New Point(118, 116)
        TxtCorreo.Name = "TxtCorreo"
        TxtCorreo.Size = New Size(125, 27)
        TxtCorreo.TabIndex = 7
        ' 
        ' TxtTelefono
        ' 
        TxtTelefono.Location = New Point(118, 177)
        TxtTelefono.Name = "TxtTelefono"
        TxtTelefono.Size = New Size(125, 27)
        TxtTelefono.TabIndex = 8
        ' 
        ' BtnMostrar
        ' 
        BtnMostrar.Location = New Point(551, 177)
        BtnMostrar.Name = "BtnMostrar"
        BtnMostrar.Size = New Size(94, 29)
        BtnMostrar.TabIndex = 9
        BtnMostrar.Text = "Mostrar"
        BtnMostrar.UseVisualStyleBackColor = True
        ' 
        ' BtnLimpiar
        ' 
        BtnLimpiar.Location = New Point(423, 177)
        BtnLimpiar.Name = "BtnLimpiar"
        BtnLimpiar.Size = New Size(94, 29)
        BtnLimpiar.TabIndex = 10
        BtnLimpiar.Text = "Limpiar"
        BtnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' BtnSalir
        ' 
        BtnSalir.Location = New Point(283, 177)
        BtnSalir.Name = "BtnSalir"
        BtnSalir.Size = New Size(94, 29)
        BtnSalir.TabIndex = 11
        BtnSalir.Text = "Salir"
        BtnSalir.UseVisualStyleBackColor = True
        ' 
        ' LblMostrarinfo
        ' 
        LblMostrarinfo.AutoSize = True
        LblMostrarinfo.Location = New Point(118, 267)
        LblMostrarinfo.Name = "LblMostrarinfo"
        LblMostrarinfo.Size = New Size(26, 20)
        LblMostrarinfo.TabIndex = 12
        LblMostrarinfo.Text = "  ..."
        ' 
        ' FrmRegistro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 616)
        Controls.Add(LblMostrarinfo)
        Controls.Add(BtnSalir)
        Controls.Add(BtnLimpiar)
        Controls.Add(BtnMostrar)
        Controls.Add(TxtTelefono)
        Controls.Add(TxtCorreo)
        Controls.Add(TxtApellido)
        Controls.Add(TxtNombre)
        Controls.Add(LblResultado)
        Controls.Add(LblTelefono)
        Controls.Add(LblCorreo)
        Controls.Add(lblApellido)
        Controls.Add(Lblnombre)
        Name = "FrmRegistro"
        Text = "Formulario de Registro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Lblnombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents LblCorreo As Label
    Friend WithEvents LblTelefono As Label
    Friend WithEvents LblResultado As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LblMostrarinfo As Label

End Class
