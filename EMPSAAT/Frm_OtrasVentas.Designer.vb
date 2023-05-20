<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_OtrasVentas
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnGrabar = New System.Windows.Forms.Button
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dgDetalle = New System.Windows.Forms.DataGrid
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.TxtNit = New System.Windows.Forms.TextBox
        Me.TxtUsuario = New System.Windows.Forms.TextBox
        Me.TxtAbonado = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnAnularOrden = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.BtnEmitir = New System.Windows.Forms.Button
        Me.DgServicios = New System.Windows.Forms.DataGrid
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtTotAnuladas = New System.Windows.Forms.TextBox
        Me.TxtTotValidas = New System.Windows.Forms.TextBox
        Me.TxtNoAnuladas = New System.Windows.Forms.TextBox
        Me.TxtNoValidas = New System.Windows.Forms.TextBox
        Me.DgFacturas = New System.Windows.Forms.DataGrid
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.DpFecha = New System.Windows.Forms.DateTimePicker
        Me.BtnAnularFactura = New System.Windows.Forms.Button
        Me.BtnVerDetalle = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.BtnImprimirDetalle = New System.Windows.Forms.Button
        Me.Imp = New System.Drawing.Printing.PrintDocument
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(768, 501)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.DgServicios)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(760, 475)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Servicios por Cobrar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.dgDetalle)
        Me.Panel4.Controls.Add(Me.TxtDireccion)
        Me.Panel4.Controls.Add(Me.TxtNit)
        Me.Panel4.Controls.Add(Me.TxtUsuario)
        Me.Panel4.Controls.Add(Me.TxtAbonado)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(134, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(623, 469)
        Me.Panel4.TabIndex = 6
        Me.Panel4.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.BtnCancelar)
        Me.GroupBox1.Controls.Add(Me.BtnGrabar)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 366)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(623, 103)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(417, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Importe Total"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(298, 53)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(123, 44)
        Me.BtnCancelar.TabIndex = 2
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Location = New System.Drawing.Point(166, 53)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(126, 44)
        Me.BtnGrabar.TabIndex = 1
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtTotal.Location = New System.Drawing.Point(501, 12)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(116, 20)
        Me.txtTotal.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(334, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "NIT / CI"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Dirección"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Abonado"
        '
        'dgDetalle
        '
        Me.dgDetalle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDetalle.DataMember = ""
        Me.dgDetalle.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetalle.Location = New System.Drawing.Point(6, 104)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.ReadOnly = True
        Me.dgDetalle.Size = New System.Drawing.Size(612, 260)
        Me.dgDetalle.TabIndex = 4
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(71, 64)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(487, 20)
        Me.TxtDireccion.TabIndex = 3
        '
        'TxtNit
        '
        Me.TxtNit.Location = New System.Drawing.Point(396, 13)
        Me.TxtNit.Name = "TxtNit"
        Me.TxtNit.Size = New System.Drawing.Size(162, 20)
        Me.TxtNit.TabIndex = 2
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(71, 38)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(487, 20)
        Me.TxtUsuario.TabIndex = 1
        '
        'TxtAbonado
        '
        Me.TxtAbonado.Location = New System.Drawing.Point(72, 13)
        Me.TxtAbonado.Name = "TxtAbonado"
        Me.TxtAbonado.Size = New System.Drawing.Size(132, 20)
        Me.TxtAbonado.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BtnAnularOrden)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.BtnEmitir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 469)
        Me.Panel2.TabIndex = 5
        '
        'BtnAnularOrden
        '
        Me.BtnAnularOrden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnularOrden.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAnularOrden.Location = New System.Drawing.Point(0, 41)
        Me.BtnAnularOrden.Name = "BtnAnularOrden"
        Me.BtnAnularOrden.Size = New System.Drawing.Size(127, 41)
        Me.BtnAnularOrden.TabIndex = 2
        Me.BtnAnularOrden.Text = "Anular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orden"
        Me.BtnAnularOrden.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.Location = New System.Drawing.Point(0, 425)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 40)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEmitir
        '
        Me.BtnEmitir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEmitir.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEmitir.Location = New System.Drawing.Point(0, 0)
        Me.BtnEmitir.Name = "BtnEmitir"
        Me.BtnEmitir.Size = New System.Drawing.Size(127, 41)
        Me.BtnEmitir.TabIndex = 0
        Me.BtnEmitir.Text = "&Emitir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Factura"
        Me.BtnEmitir.UseVisualStyleBackColor = True
        '
        'DgServicios
        '
        Me.DgServicios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgServicios.DataMember = ""
        Me.DgServicios.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgServicios.Location = New System.Drawing.Point(140, 6)
        Me.DgServicios.Name = "DgServicios"
        Me.DgServicios.Size = New System.Drawing.Size(614, 464)
        Me.DgServicios.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel1)
        Me.TabPage3.Controls.Add(Me.DgFacturas)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(760, 475)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Detalle de Facturas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtTotAnuladas)
        Me.Panel1.Controls.Add(Me.TxtTotValidas)
        Me.Panel1.Controls.Add(Me.TxtNoAnuladas)
        Me.Panel1.Controls.Add(Me.TxtNoValidas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(131, 396)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(629, 79)
        Me.Panel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(260, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Importe Facturas Anuladas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Importe Facturas Válidas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Facturas Anuladas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Facturas Válidas"
        '
        'TxtTotAnuladas
        '
        Me.TxtTotAnuladas.Location = New System.Drawing.Point(404, 45)
        Me.TxtTotAnuladas.Name = "TxtTotAnuladas"
        Me.TxtTotAnuladas.Size = New System.Drawing.Size(110, 20)
        Me.TxtTotAnuladas.TabIndex = 3
        Me.TxtTotAnuladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotAnuladas.UseWaitCursor = True
        '
        'TxtTotValidas
        '
        Me.TxtTotValidas.Location = New System.Drawing.Point(404, 19)
        Me.TxtTotValidas.Name = "TxtTotValidas"
        Me.TxtTotValidas.Size = New System.Drawing.Size(110, 20)
        Me.TxtTotValidas.TabIndex = 2
        Me.TxtTotValidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTotValidas.UseWaitCursor = True
        '
        'TxtNoAnuladas
        '
        Me.TxtNoAnuladas.Location = New System.Drawing.Point(140, 45)
        Me.TxtNoAnuladas.Name = "TxtNoAnuladas"
        Me.TxtNoAnuladas.Size = New System.Drawing.Size(73, 20)
        Me.TxtNoAnuladas.TabIndex = 1
        Me.TxtNoAnuladas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNoValidas
        '
        Me.TxtNoValidas.Location = New System.Drawing.Point(140, 19)
        Me.TxtNoValidas.Name = "TxtNoValidas"
        Me.TxtNoValidas.Size = New System.Drawing.Size(73, 20)
        Me.TxtNoValidas.TabIndex = 0
        Me.TxtNoValidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DgFacturas
        '
        Me.DgFacturas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgFacturas.DataMember = ""
        Me.DgFacturas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DgFacturas.Location = New System.Drawing.Point(137, 3)
        Me.DgFacturas.Name = "DgFacturas"
        Me.DgFacturas.Size = New System.Drawing.Size(615, 387)
        Me.DgFacturas.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.DpFecha)
        Me.Panel3.Controls.Add(Me.BtnAnularFactura)
        Me.Panel3.Controls.Add(Me.BtnVerDetalle)
        Me.Panel3.Controls.Add(Me.Button5)
        Me.Panel3.Controls.Add(Me.BtnImprimirDetalle)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(131, 475)
        Me.Panel3.TabIndex = 6
        '
        'DpFecha
        '
        Me.DpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DpFecha.Location = New System.Drawing.Point(3, 94)
        Me.DpFecha.Name = "DpFecha"
        Me.DpFecha.Size = New System.Drawing.Size(121, 20)
        Me.DpFecha.TabIndex = 4
        '
        'BtnAnularFactura
        '
        Me.BtnAnularFactura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnularFactura.Location = New System.Drawing.Point(0, 47)
        Me.BtnAnularFactura.Name = "BtnAnularFactura"
        Me.BtnAnularFactura.Size = New System.Drawing.Size(127, 41)
        Me.BtnAnularFactura.TabIndex = 3
        Me.BtnAnularFactura.Text = "Anular" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Factura"
        Me.BtnAnularFactura.UseVisualStyleBackColor = True
        '
        'BtnVerDetalle
        '
        Me.BtnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVerDetalle.Location = New System.Drawing.Point(0, 120)
        Me.BtnVerDetalle.Name = "BtnVerDetalle"
        Me.BtnVerDetalle.Size = New System.Drawing.Size(127, 41)
        Me.BtnVerDetalle.TabIndex = 2
        Me.BtnVerDetalle.Text = "Ver Detalle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Facturas"
        Me.BtnVerDetalle.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Button5.Location = New System.Drawing.Point(0, 431)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 40)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "&Salir"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BtnImprimirDetalle
        '
        Me.BtnImprimirDetalle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImprimirDetalle.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnImprimirDetalle.Location = New System.Drawing.Point(0, 0)
        Me.BtnImprimirDetalle.Name = "BtnImprimirDetalle"
        Me.BtnImprimirDetalle.Size = New System.Drawing.Size(127, 41)
        Me.BtnImprimirDetalle.TabIndex = 0
        Me.BtnImprimirDetalle.Text = "&Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Detalle"
        Me.BtnImprimirDetalle.UseVisualStyleBackColor = True
        '
        'Imp
        '
        '
        'Frm_OtrasVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 501)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Frm_OtrasVentas"
        Me.Text = "Otras Ventas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents DgServicios As System.Windows.Forms.DataGrid
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnAnularOrden As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnEmitir As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents BtnVerDetalle As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents BtnImprimirDetalle As System.Windows.Forms.Button
    Friend WithEvents DgFacturas As System.Windows.Forms.DataGrid
    Friend WithEvents BtnAnularFactura As System.Windows.Forms.Button
    Friend WithEvents DpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtTotValidas As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoAnuladas As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoValidas As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTotAnuladas As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGrid
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtNit As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtAbonado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Imp As System.Drawing.Printing.PrintDocument
End Class
