<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Migrar
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
        Me.btnFacturas = New System.Windows.Forms.Button
        Me.btnOtrasVentas = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnServicios = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.BtnVerificarPagos = New System.Windows.Forms.Button
        Me.btnFacAnteriores = New System.Windows.Forms.Button
        Me.btnDosificacion = New System.Windows.Forms.Button
        Me.btnRecargosAntes = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnFacturas
        '
        Me.btnFacturas.Location = New System.Drawing.Point(176, 26)
        Me.btnFacturas.Name = "btnFacturas"
        Me.btnFacturas.Size = New System.Drawing.Size(96, 60)
        Me.btnFacturas.TabIndex = 0
        Me.btnFacturas.Text = "Facturas"
        Me.btnFacturas.UseVisualStyleBackColor = True
        '
        'btnOtrasVentas
        '
        Me.btnOtrasVentas.Location = New System.Drawing.Point(177, 110)
        Me.btnOtrasVentas.Name = "btnOtrasVentas"
        Me.btnOtrasVentas.Size = New System.Drawing.Size(95, 55)
        Me.btnOtrasVentas.TabIndex = 1
        Me.btnOtrasVentas.Text = "Otras Ventas"
        Me.btnOtrasVentas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(46, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 60)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Usuarios"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnServicios
        '
        Me.btnServicios.Location = New System.Drawing.Point(46, 110)
        Me.btnServicios.Name = "btnServicios"
        Me.btnServicios.Size = New System.Drawing.Size(96, 55)
        Me.btnServicios.TabIndex = 3
        Me.btnServicios.Text = "Servicios"
        Me.btnServicios.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(46, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 55)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Comprobantes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnVerificarPagos
        '
        Me.BtnVerificarPagos.Location = New System.Drawing.Point(177, 187)
        Me.BtnVerificarPagos.Name = "BtnVerificarPagos"
        Me.BtnVerificarPagos.Size = New System.Drawing.Size(94, 54)
        Me.BtnVerificarPagos.TabIndex = 5
        Me.BtnVerificarPagos.Text = "Verificar Pagos"
        Me.BtnVerificarPagos.UseVisualStyleBackColor = True
        '
        'btnFacAnteriores
        '
        Me.btnFacAnteriores.Location = New System.Drawing.Point(284, 28)
        Me.btnFacAnteriores.Name = "btnFacAnteriores"
        Me.btnFacAnteriores.Size = New System.Drawing.Size(106, 57)
        Me.btnFacAnteriores.TabIndex = 6
        Me.btnFacAnteriores.Text = "Facturas Anteriores"
        Me.btnFacAnteriores.UseVisualStyleBackColor = True
        '
        'btnDosificacion
        '
        Me.btnDosificacion.Location = New System.Drawing.Point(285, 113)
        Me.btnDosificacion.Name = "btnDosificacion"
        Me.btnDosificacion.Size = New System.Drawing.Size(104, 51)
        Me.btnDosificacion.TabIndex = 7
        Me.btnDosificacion.Text = "Dosificacion"
        Me.btnDosificacion.UseVisualStyleBackColor = True
        '
        'btnRecargosAntes
        '
        Me.btnRecargosAntes.Location = New System.Drawing.Point(292, 191)
        Me.btnRecargosAntes.Name = "btnRecargosAntes"
        Me.btnRecargosAntes.Size = New System.Drawing.Size(96, 49)
        Me.btnRecargosAntes.TabIndex = 8
        Me.btnRecargosAntes.Text = "Recargos Anteriores"
        Me.btnRecargosAntes.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(402, 26)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 59)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Proformas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Frm_Migrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 262)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnRecargosAntes)
        Me.Controls.Add(Me.btnDosificacion)
        Me.Controls.Add(Me.btnFacAnteriores)
        Me.Controls.Add(Me.BtnVerificarPagos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnServicios)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnOtrasVentas)
        Me.Controls.Add(Me.btnFacturas)
        Me.Name = "Frm_Migrar"
        Me.Text = "Frm_Migrar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFacturas As System.Windows.Forms.Button
    Friend WithEvents btnOtrasVentas As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnServicios As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnVerificarPagos As System.Windows.Forms.Button
    Friend WithEvents btnFacAnteriores As System.Windows.Forms.Button
    Friend WithEvents btnDosificacion As System.Windows.Forms.Button
    Friend WithEvents btnRecargosAntes As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
