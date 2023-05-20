<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Recalculo_Facturas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxCliente = New System.Windows.Forms.TextBox
        Me.cboAbonado = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNoRuta = New System.Windows.Forms.TextBox
        Me.txtSubRuta = New System.Windows.Forms.TextBox
        Me.txtRuta = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CkLey1886 = New System.Windows.Forms.CheckBox
        Me.TxCalle = New System.Windows.Forms.TextBox
        Me.TxZona = New System.Windows.Forms.TextBox
        Me.TxCuenta = New System.Windows.Forms.TextBox
        Me.TxNIT = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxCategoria = New System.Windows.Forms.TextBox
        Me.TxUsuario = New System.Windows.Forms.TextBox
        Me.txtAnterior = New System.Windows.Forms.TextBox
        Me.txtActual = New System.Windows.Forms.TextBox
        Me.txtConsumo = New System.Windows.Forms.TextBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ckSinFactura = New System.Windows.Forms.CheckBox
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.chkEstimado = New System.Windows.Forms.CheckBox
        Me.chkSinRecargos = New System.Windows.Forms.CheckBox
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.TxCliente)
        Me.Panel3.Controls.Add(Me.cboAbonado)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtNoRuta)
        Me.Panel3.Controls.Add(Me.txtSubRuta)
        Me.Panel3.Controls.Add(Me.txtRuta)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.CkLey1886)
        Me.Panel3.Controls.Add(Me.TxCalle)
        Me.Panel3.Controls.Add(Me.TxZona)
        Me.Panel3.Controls.Add(Me.TxCuenta)
        Me.Panel3.Controls.Add(Me.TxNIT)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.TxCategoria)
        Me.Panel3.Controls.Add(Me.TxUsuario)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(668, 102)
        Me.Panel3.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(414, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Cliente"
        '
        'TxCliente
        '
        Me.TxCliente.Location = New System.Drawing.Point(476, 9)
        Me.TxCliente.Name = "TxCliente"
        Me.TxCliente.ReadOnly = True
        Me.TxCliente.Size = New System.Drawing.Size(194, 20)
        Me.TxCliente.TabIndex = 39
        '
        'cboAbonado
        '
        Me.cboAbonado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAbonado.FormattingEnabled = True
        Me.cboAbonado.Location = New System.Drawing.Point(76, 38)
        Me.cboAbonado.Name = "cboAbonado"
        Me.cboAbonado.Size = New System.Drawing.Size(121, 21)
        Me.cboAbonado.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Nit"
        '
        'txtNoRuta
        '
        Me.txtNoRuta.Location = New System.Drawing.Point(621, 72)
        Me.txtNoRuta.Name = "txtNoRuta"
        Me.txtNoRuta.ReadOnly = True
        Me.txtNoRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtNoRuta.TabIndex = 36
        '
        'txtSubRuta
        '
        Me.txtSubRuta.Location = New System.Drawing.Point(621, 51)
        Me.txtSubRuta.Name = "txtSubRuta"
        Me.txtSubRuta.ReadOnly = True
        Me.txtSubRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtSubRuta.TabIndex = 35
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(621, 30)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtRuta.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(414, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Calle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(414, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Zona"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(414, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Cuenta"
        '
        'CkLey1886
        '
        Me.CkLey1886.AutoSize = True
        Me.CkLey1886.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkLey1886.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkLey1886.Location = New System.Drawing.Point(329, 69)
        Me.CkLey1886.Name = "CkLey1886"
        Me.CkLey1886.Size = New System.Drawing.Size(78, 17)
        Me.CkLey1886.TabIndex = 30
        Me.CkLey1886.Text = "Ley 1886"
        Me.CkLey1886.UseVisualStyleBackColor = True
        '
        'TxCalle
        '
        Me.TxCalle.Location = New System.Drawing.Point(477, 73)
        Me.TxCalle.Name = "TxCalle"
        Me.TxCalle.ReadOnly = True
        Me.TxCalle.Size = New System.Drawing.Size(138, 20)
        Me.TxCalle.TabIndex = 29
        '
        'TxZona
        '
        Me.TxZona.Location = New System.Drawing.Point(477, 51)
        Me.TxZona.Name = "TxZona"
        Me.TxZona.ReadOnly = True
        Me.TxZona.Size = New System.Drawing.Size(138, 20)
        Me.TxZona.TabIndex = 28
        '
        'TxCuenta
        '
        Me.TxCuenta.Location = New System.Drawing.Point(477, 30)
        Me.TxCuenta.Name = "TxCuenta"
        Me.TxCuenta.ReadOnly = True
        Me.TxCuenta.Size = New System.Drawing.Size(138, 20)
        Me.TxCuenta.TabIndex = 27
        '
        'TxNIT
        '
        Me.TxNIT.Location = New System.Drawing.Point(243, 38)
        Me.TxNIT.Name = "TxNIT"
        Me.TxNIT.ReadOnly = True
        Me.TxNIT.Size = New System.Drawing.Size(164, 20)
        Me.TxNIT.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-3, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Usuario"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-3, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Abonado"
        '
        'TxCategoria
        '
        Me.TxCategoria.Location = New System.Drawing.Point(76, 67)
        Me.TxCategoria.Name = "TxCategoria"
        Me.TxCategoria.ReadOnly = True
        Me.TxCategoria.Size = New System.Drawing.Size(247, 20)
        Me.TxCategoria.TabIndex = 22
        '
        'TxUsuario
        '
        Me.TxUsuario.Location = New System.Drawing.Point(75, 7)
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.ReadOnly = True
        Me.TxUsuario.Size = New System.Drawing.Size(332, 20)
        Me.TxUsuario.TabIndex = 21
        '
        'txtAnterior
        '
        Me.txtAnterior.Location = New System.Drawing.Point(303, 202)
        Me.txtAnterior.Name = "txtAnterior"
        Me.txtAnterior.Size = New System.Drawing.Size(100, 20)
        Me.txtAnterior.TabIndex = 3
        Me.txtAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtActual
        '
        Me.txtActual.Location = New System.Drawing.Point(305, 235)
        Me.txtActual.Name = "txtActual"
        Me.txtActual.Size = New System.Drawing.Size(97, 20)
        Me.txtActual.TabIndex = 4
        Me.txtActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtConsumo
        '
        Me.txtConsumo.Location = New System.Drawing.Point(303, 267)
        Me.txtConsumo.Name = "txtConsumo"
        Me.txtConsumo.Size = New System.Drawing.Size(99, 20)
        Me.txtConsumo.TabIndex = 5
        Me.txtConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(469, 361)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(163, 55)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(469, 307)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(163, 47)
        Me.btnGrabar.TabIndex = 10
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(149, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Periodo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(149, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Lectura Anterior"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(149, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Lectura Actual"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(149, 267)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Consumo"
        '
        'ckSinFactura
        '
        Me.ckSinFactura.AutoSize = True
        Me.ckSinFactura.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckSinFactura.ForeColor = System.Drawing.Color.Red
        Me.ckSinFactura.Location = New System.Drawing.Point(198, 381)
        Me.ckSinFactura.Name = "ckSinFactura"
        Me.ckSinFactura.Size = New System.Drawing.Size(97, 24)
        Me.ckSinFactura.TabIndex = 15
        Me.ckSinFactura.Text = "Sin Factura"
        Me.ckSinFactura.UseVisualStyleBackColor = True
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(303, 163)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(143, 21)
        Me.cboPeriodo.TabIndex = 18
        '
        'chkEstimado
        '
        Me.chkEstimado.AutoSize = True
        Me.chkEstimado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstimado.Location = New System.Drawing.Point(197, 353)
        Me.chkEstimado.Name = "chkEstimado"
        Me.chkEstimado.Size = New System.Drawing.Size(76, 20)
        Me.chkEstimado.TabIndex = 19
        Me.chkEstimado.Text = "Estimado"
        Me.chkEstimado.UseVisualStyleBackColor = True
        '
        'chkSinRecargos
        '
        Me.chkSinRecargos.AutoSize = True
        Me.chkSinRecargos.Location = New System.Drawing.Point(303, 307)
        Me.chkSinRecargos.Name = "chkSinRecargos"
        Me.chkSinRecargos.Size = New System.Drawing.Size(90, 17)
        Me.chkSinRecargos.TabIndex = 20
        Me.chkSinRecargos.Text = "Sin Recargos"
        Me.chkSinRecargos.UseVisualStyleBackColor = True
        '
        'Frm_Recalculo_Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 446)
        Me.Controls.Add(Me.chkSinRecargos)
        Me.Controls.Add(Me.chkEstimado)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.ckSinFactura)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtConsumo)
        Me.Controls.Add(Me.txtActual)
        Me.Controls.Add(Me.txtAnterior)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_Recalculo_Facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recalculo de facturas"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtAnterior As System.Windows.Forms.TextBox
    Friend WithEvents txtActual As System.Windows.Forms.TextBox
    Friend WithEvents txtConsumo As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ckSinFactura As System.Windows.Forms.CheckBox
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents chkEstimado As System.Windows.Forms.CheckBox
    Friend WithEvents chkSinRecargos As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxCliente As System.Windows.Forms.TextBox
    Friend WithEvents cboAbonado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoRuta As System.Windows.Forms.TextBox
    Friend WithEvents txtSubRuta As System.Windows.Forms.TextBox
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CkLey1886 As System.Windows.Forms.CheckBox
    Friend WithEvents TxCalle As System.Windows.Forms.TextBox
    Friend WithEvents TxZona As System.Windows.Forms.TextBox
    Friend WithEvents TxCuenta As System.Windows.Forms.TextBox
    Friend WithEvents TxNIT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TxUsuario As System.Windows.Forms.TextBox
End Class
