<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Servicios_Solicitud
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.gbCambioNombre = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_Nit = New System.Windows.Forms.TextBox
        Me.txt_NoDoc = New System.Windows.Forms.TextBox
        Me.cbo_Doc = New System.Windows.Forms.ComboBox
        Me.Txt_Nombre = New System.Windows.Forms.TextBox
        Me.gbCategoria = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cbo_Categoria = New System.Windows.Forms.ComboBox
        Me.chkRep = New System.Windows.Forms.CheckBox
        Me.gbDireccion = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtNoRuta = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txt_Numero = New System.Windows.Forms.TextBox
        Me.cbo_Calle = New System.Windows.Forms.ComboBox
        Me.cbo_Zona = New System.Windows.Forms.ComboBox
        Me.cbo_SubRuta = New System.Windows.Forms.ComboBox
        Me.cbo_Ruta = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnCancelarOrden = New System.Windows.Forms.Button
        Me.BtnGrabarOrden = New System.Windows.Forms.Button
        Me.txtNota = New System.Windows.Forms.TextBox
        Me.txtCosto = New System.Windows.Forms.TextBox
        Me.cboServicios = New System.Windows.Forms.ComboBox
        Me.Panel7.SuspendLayout()
        Me.gbCambioNombre.SuspendLayout()
        Me.gbCategoria.SuspendLayout()
        Me.gbDireccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.gbCambioNombre)
        Me.Panel7.Controls.Add(Me.gbCategoria)
        Me.Panel7.Controls.Add(Me.chkRep)
        Me.Panel7.Controls.Add(Me.gbDireccion)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.BtnCancelarOrden)
        Me.Panel7.Controls.Add(Me.BtnGrabarOrden)
        Me.Panel7.Controls.Add(Me.txtNota)
        Me.Panel7.Controls.Add(Me.txtCosto)
        Me.Panel7.Controls.Add(Me.cboServicios)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(642, 394)
        Me.Panel7.TabIndex = 5
        '
        'gbCambioNombre
        '
        Me.gbCambioNombre.Controls.Add(Me.Label14)
        Me.gbCambioNombre.Controls.Add(Me.Label12)
        Me.gbCambioNombre.Controls.Add(Me.Label11)
        Me.gbCambioNombre.Controls.Add(Me.txt_Nit)
        Me.gbCambioNombre.Controls.Add(Me.txt_NoDoc)
        Me.gbCambioNombre.Controls.Add(Me.cbo_Doc)
        Me.gbCambioNombre.Controls.Add(Me.Txt_Nombre)
        Me.gbCambioNombre.Location = New System.Drawing.Point(23, 172)
        Me.gbCambioNombre.Name = "gbCambioNombre"
        Me.gbCambioNombre.Size = New System.Drawing.Size(598, 130)
        Me.gbCambioNombre.TabIndex = 8
        Me.gbCambioNombre.TabStop = False
        Me.gbCambioNombre.Text = "Cambio de nombre"
        Me.gbCambioNombre.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(19, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "NIT / CID"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(19, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Documento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Razon Social"
        '
        'txt_Nit
        '
        Me.txt_Nit.Location = New System.Drawing.Point(138, 74)
        Me.txt_Nit.Name = "txt_Nit"
        Me.txt_Nit.Size = New System.Drawing.Size(124, 20)
        Me.txt_Nit.TabIndex = 4
        '
        'txt_NoDoc
        '
        Me.txt_NoDoc.Location = New System.Drawing.Point(232, 14)
        Me.txt_NoDoc.Name = "txt_NoDoc"
        Me.txt_NoDoc.Size = New System.Drawing.Size(168, 20)
        Me.txt_NoDoc.TabIndex = 2
        '
        'cbo_Doc
        '
        Me.cbo_Doc.FormattingEnabled = True
        Me.cbo_Doc.Items.AddRange(New Object() {"CID", "RUN", "LSM", "PAS", "NIT"})
        Me.cbo_Doc.Location = New System.Drawing.Point(138, 14)
        Me.cbo_Doc.Name = "cbo_Doc"
        Me.cbo_Doc.Size = New System.Drawing.Size(88, 21)
        Me.cbo_Doc.TabIndex = 1
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(135, 40)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.ReadOnly = True
        Me.Txt_Nombre.Size = New System.Drawing.Size(441, 20)
        Me.Txt_Nombre.TabIndex = 0
        '
        'gbCategoria
        '
        Me.gbCategoria.Controls.Add(Me.Label20)
        Me.gbCategoria.Controls.Add(Me.cbo_Categoria)
        Me.gbCategoria.Location = New System.Drawing.Point(22, 186)
        Me.gbCategoria.Name = "gbCategoria"
        Me.gbCategoria.Size = New System.Drawing.Size(596, 135)
        Me.gbCategoria.TabIndex = 12
        Me.gbCategoria.TabStop = False
        Me.gbCategoria.Text = "Cambio Categoria"
        Me.gbCategoria.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(17, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(102, 13)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "Nueva Categoria"
        '
        'cbo_Categoria
        '
        Me.cbo_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Categoria.FormattingEnabled = True
        Me.cbo_Categoria.Location = New System.Drawing.Point(134, 56)
        Me.cbo_Categoria.Name = "cbo_Categoria"
        Me.cbo_Categoria.Size = New System.Drawing.Size(437, 21)
        Me.cbo_Categoria.TabIndex = 0
        '
        'chkRep
        '
        Me.chkRep.AutoSize = True
        Me.chkRep.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRep.Checked = True
        Me.chkRep.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRep.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRep.Location = New System.Drawing.Point(45, 138)
        Me.chkRep.Name = "chkRep"
        Me.chkRep.Size = New System.Drawing.Size(163, 20)
        Me.chkRep.TabIndex = 11
        Me.chkRep.Text = "Reposición de Formulario"
        Me.chkRep.UseVisualStyleBackColor = True
        '
        'gbDireccion
        '
        Me.gbDireccion.Controls.Add(Me.Label22)
        Me.gbDireccion.Controls.Add(Me.txtNoRuta)
        Me.gbDireccion.Controls.Add(Me.Label19)
        Me.gbDireccion.Controls.Add(Me.Label18)
        Me.gbDireccion.Controls.Add(Me.Label17)
        Me.gbDireccion.Controls.Add(Me.Label16)
        Me.gbDireccion.Controls.Add(Me.Label15)
        Me.gbDireccion.Controls.Add(Me.txt_Numero)
        Me.gbDireccion.Controls.Add(Me.cbo_Calle)
        Me.gbDireccion.Controls.Add(Me.cbo_Zona)
        Me.gbDireccion.Controls.Add(Me.cbo_SubRuta)
        Me.gbDireccion.Controls.Add(Me.cbo_Ruta)
        Me.gbDireccion.Location = New System.Drawing.Point(26, 185)
        Me.gbDireccion.Name = "gbDireccion"
        Me.gbDireccion.Size = New System.Drawing.Size(586, 137)
        Me.gbDireccion.TabIndex = 9
        Me.gbDireccion.TabStop = False
        Me.gbDireccion.Text = "Cambio de Dirección"
        Me.gbDireccion.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(405, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 12
        Me.Label22.Text = "Numero"
        '
        'txtNoRuta
        '
        Me.txtNoRuta.Location = New System.Drawing.Point(465, 17)
        Me.txtNoRuta.Name = "txtNoRuta"
        Me.txtNoRuta.Size = New System.Drawing.Size(52, 20)
        Me.txtNoRuta.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 111)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 13)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Nro. Vivienda"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(9, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Calle"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(9, 49)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Zona"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(255, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(60, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Sub Ruta"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Ruta"
        '
        'txt_Numero
        '
        Me.txt_Numero.Location = New System.Drawing.Point(131, 108)
        Me.txt_Numero.Name = "txt_Numero"
        Me.txt_Numero.Size = New System.Drawing.Size(116, 20)
        Me.txt_Numero.TabIndex = 4
        '
        'cbo_Calle
        '
        Me.cbo_Calle.FormattingEnabled = True
        Me.cbo_Calle.Location = New System.Drawing.Point(131, 75)
        Me.cbo_Calle.Name = "cbo_Calle"
        Me.cbo_Calle.Size = New System.Drawing.Size(441, 21)
        Me.cbo_Calle.TabIndex = 3
        '
        'cbo_Zona
        '
        Me.cbo_Zona.FormattingEnabled = True
        Me.cbo_Zona.Location = New System.Drawing.Point(132, 47)
        Me.cbo_Zona.Name = "cbo_Zona"
        Me.cbo_Zona.Size = New System.Drawing.Size(440, 21)
        Me.cbo_Zona.TabIndex = 2
        '
        'cbo_SubRuta
        '
        Me.cbo_SubRuta.FormattingEnabled = True
        Me.cbo_SubRuta.Location = New System.Drawing.Point(321, 18)
        Me.cbo_SubRuta.Name = "cbo_SubRuta"
        Me.cbo_SubRuta.Size = New System.Drawing.Size(69, 21)
        Me.cbo_SubRuta.TabIndex = 1
        '
        'cbo_Ruta
        '
        Me.cbo_Ruta.FormattingEnabled = True
        Me.cbo_Ruta.Location = New System.Drawing.Point(131, 19)
        Me.cbo_Ruta.Name = "cbo_Ruta"
        Me.cbo_Ruta.Size = New System.Drawing.Size(118, 21)
        Me.cbo_Ruta.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(42, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Nota Adicional"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Costo del Servicio"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(42, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Servicio Solicitado"
        '
        'BtnCancelarOrden
        '
        Me.BtnCancelarOrden.Location = New System.Drawing.Point(363, 328)
        Me.BtnCancelarOrden.Name = "BtnCancelarOrden"
        Me.BtnCancelarOrden.Size = New System.Drawing.Size(127, 41)
        Me.BtnCancelarOrden.TabIndex = 4
        Me.BtnCancelarOrden.Text = "Cancelar"
        Me.BtnCancelarOrden.UseVisualStyleBackColor = True
        '
        'BtnGrabarOrden
        '
        Me.BtnGrabarOrden.Location = New System.Drawing.Point(198, 328)
        Me.BtnGrabarOrden.Name = "BtnGrabarOrden"
        Me.BtnGrabarOrden.Size = New System.Drawing.Size(127, 41)
        Me.BtnGrabarOrden.TabIndex = 3
        Me.BtnGrabarOrden.Text = "Grabar"
        Me.BtnGrabarOrden.UseVisualStyleBackColor = True
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(161, 86)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(441, 46)
        Me.txtNota.TabIndex = 2
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(161, 60)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.ReadOnly = True
        Me.txtCosto.Size = New System.Drawing.Size(118, 20)
        Me.txtCosto.TabIndex = 1
        '
        'cboServicios
        '
        Me.cboServicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServicios.FormattingEnabled = True
        Me.cboServicios.Location = New System.Drawing.Point(161, 30)
        Me.cboServicios.Name = "cboServicios"
        Me.cboServicios.Size = New System.Drawing.Size(444, 21)
        Me.cboServicios.TabIndex = 0
        '
        'Frm_Servicios_Solicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 394)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_Servicios_Solicitud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Servicio"
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.gbCambioNombre.ResumeLayout(False)
        Me.gbCambioNombre.PerformLayout()
        Me.gbCategoria.ResumeLayout(False)
        Me.gbCategoria.PerformLayout()
        Me.gbDireccion.ResumeLayout(False)
        Me.gbDireccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents chkRep As System.Windows.Forms.CheckBox
    Friend WithEvents gbDireccion As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtNoRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_Numero As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Calle As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Zona As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_SubRuta As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Ruta As System.Windows.Forms.ComboBox
    Friend WithEvents gbCambioNombre As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Nit As System.Windows.Forms.TextBox
    Friend WithEvents txt_NoDoc As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Doc As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelarOrden As System.Windows.Forms.Button
    Friend WithEvents BtnGrabarOrden As System.Windows.Forms.Button
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents cboServicios As System.Windows.Forms.ComboBox
    Friend WithEvents gbCategoria As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbo_Categoria As System.Windows.Forms.ComboBox
End Class
