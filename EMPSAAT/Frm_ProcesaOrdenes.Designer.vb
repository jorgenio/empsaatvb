<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ProcesaOrdenes
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnAnular = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.BtnProcesar = New System.Windows.Forms.Button
        Me.dgServicios = New System.Windows.Forms.DataGrid
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.gbCategoria = New System.Windows.Forms.GroupBox
        Me.txt_CodCategoria = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txt_Categoria = New System.Windows.Forms.TextBox
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnGrabar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblInicial = New System.Windows.Forms.Label
        Me.txt_LectInicial = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboEmpleado = New System.Windows.Forms.ComboBox
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCodServicio = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNota = New System.Windows.Forms.TextBox
        Me.txtCosto = New System.Windows.Forms.TextBox
        Me.txtServicio = New System.Windows.Forms.TextBox
        Me.txtFechaSolicitud = New System.Windows.Forms.TextBox
        Me.txtNoSolicitud = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtEstado = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCalle = New System.Windows.Forms.TextBox
        Me.txtZona = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.TxtAbonado = New System.Windows.Forms.TextBox
        Me.gbRazonSocial = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txt_Nacimiento = New System.Windows.Forms.TextBox
        Me.txt_Nit = New System.Windows.Forms.TextBox
        Me.txt_NoDoc = New System.Windows.Forms.TextBox
        Me.txt_Doc = New System.Windows.Forms.TextBox
        Me.txt_RazonSocial = New System.Windows.Forms.TextBox
        Me.gbDireccion = New System.Windows.Forms.GroupBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txt_NumRuta = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.cbo_Calle = New System.Windows.Forms.ComboBox
        Me.cbo_Zona = New System.Windows.Forms.ComboBox
        Me.cbo_SubRuta = New System.Windows.Forms.ComboBox
        Me.cbo_Ruta = New System.Windows.Forms.ComboBox
        Me.Panel2.SuspendLayout()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.gbCategoria.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbRazonSocial.SuspendLayout()
        Me.gbDireccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BtnAnular)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.BtnProcesar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 539)
        Me.Panel2.TabIndex = 6
        '
        'BtnAnular
        '
        Me.BtnAnular.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAnular.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAnular.Location = New System.Drawing.Point(0, 41)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(127, 41)
        Me.BtnAnular.TabIndex = 2
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.Location = New System.Drawing.Point(0, 495)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 40)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProcesar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnProcesar.Location = New System.Drawing.Point(0, 0)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(127, 41)
        Me.BtnProcesar.TabIndex = 0
        Me.BtnProcesar.Text = "Procesar"
        Me.BtnProcesar.UseVisualStyleBackColor = True
        '
        'dgServicios
        '
        Me.dgServicios.DataMember = ""
        Me.dgServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgServicios.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgServicios.Location = New System.Drawing.Point(131, 0)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.Size = New System.Drawing.Size(541, 539)
        Me.dgServicios.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbCategoria)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.BtnGrabar)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.gbRazonSocial)
        Me.Panel1.Controls.Add(Me.gbDireccion)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(131, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 539)
        Me.Panel1.TabIndex = 8
        Me.Panel1.Visible = False
        '
        'gbCategoria
        '
        Me.gbCategoria.BackColor = System.Drawing.Color.LightSalmon
        Me.gbCategoria.Controls.Add(Me.txt_CodCategoria)
        Me.gbCategoria.Controls.Add(Me.Label21)
        Me.gbCategoria.Controls.Add(Me.txt_Categoria)
        Me.gbCategoria.Location = New System.Drawing.Point(19, 352)
        Me.gbCategoria.Name = "gbCategoria"
        Me.gbCategoria.Size = New System.Drawing.Size(518, 75)
        Me.gbCategoria.TabIndex = 18
        Me.gbCategoria.TabStop = False
        Me.gbCategoria.Text = "Nueva Categoria"
        '
        'txt_CodCategoria
        '
        Me.txt_CodCategoria.Location = New System.Drawing.Point(399, 30)
        Me.txt_CodCategoria.Name = "txt_CodCategoria"
        Me.txt_CodCategoria.Size = New System.Drawing.Size(88, 20)
        Me.txt_CodCategoria.TabIndex = 19
        Me.txt_CodCategoria.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(16, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 16)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Categoría"
        '
        'txt_Categoria
        '
        Me.txt_Categoria.Location = New System.Drawing.Point(78, 29)
        Me.txt_Categoria.Name = "txt_Categoria"
        Me.txt_Categoria.Size = New System.Drawing.Size(408, 20)
        Me.txt_Categoria.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCancelar.Location = New System.Drawing.Point(302, 486)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(127, 41)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnGrabar.Location = New System.Drawing.Point(143, 486)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(127, 41)
        Me.BtnGrabar.TabIndex = 14
        Me.BtnGrabar.Text = "Aceptar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblInicial)
        Me.GroupBox3.Controls.Add(Me.txt_LectInicial)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cboEmpleado)
        Me.GroupBox3.Controls.Add(Me.dtFecha)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 237)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(518, 82)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Atención del Servicio"
        '
        'lblInicial
        '
        Me.lblInicial.AutoSize = True
        Me.lblInicial.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInicial.Location = New System.Drawing.Point(244, 22)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(129, 16)
        Me.lblInicial.TabIndex = 16
        Me.lblInicial.Text = "Lectura Inicial Medidor"
        '
        'txt_LectInicial
        '
        Me.txt_LectInicial.Location = New System.Drawing.Point(379, 21)
        Me.txt_LectInicial.Name = "txt_LectInicial"
        Me.txt_LectInicial.Size = New System.Drawing.Size(108, 20)
        Me.txt_LectInicial.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Empleado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Fecha Atención"
        '
        'cboEmpleado
        '
        Me.cboEmpleado.FormattingEnabled = True
        Me.cboEmpleado.Location = New System.Drawing.Point(102, 45)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(385, 21)
        Me.cboEmpleado.TabIndex = 12
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(102, 19)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(125, 20)
        Me.dtFecha.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCodServicio)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNota)
        Me.GroupBox2.Controls.Add(Me.txtCosto)
        Me.GroupBox2.Controls.Add(Me.txtServicio)
        Me.GroupBox2.Controls.Add(Me.txtFechaSolicitud)
        Me.GroupBox2.Controls.Add(Me.txtNoSolicitud)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 134)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(517, 96)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Servicio Solicitado"
        '
        'txtCodServicio
        '
        Me.txtCodServicio.Location = New System.Drawing.Point(398, 67)
        Me.txtCodServicio.Name = "txtCodServicio"
        Me.txtCodServicio.Size = New System.Drawing.Size(94, 20)
        Me.txtCodServicio.TabIndex = 15
        Me.txtCodServicio.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Nota"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(364, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Costo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Servicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(187, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Solicitud"
        '
        'txtNota
        '
        Me.txtNota.Location = New System.Drawing.Point(78, 67)
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(414, 20)
        Me.txtNota.TabIndex = 4
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(409, 14)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(83, 20)
        Me.txtCosto.TabIndex = 3
        Me.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtServicio
        '
        Me.txtServicio.Location = New System.Drawing.Point(78, 41)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.Size = New System.Drawing.Size(414, 20)
        Me.txtServicio.TabIndex = 2
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(233, 15)
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(125, 20)
        Me.txtFechaSolicitud.TabIndex = 1
        '
        'txtNoSolicitud
        '
        Me.txtNoSolicitud.Location = New System.Drawing.Point(78, 15)
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.Size = New System.Drawing.Size(92, 20)
        Me.txtNoSolicitud.TabIndex = 0
        Me.txtNoSolicitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCalle)
        Me.GroupBox1.Controls.Add(Me.txtZona)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.TxtAbonado)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.GroupBox1.Location = New System.Drawing.Point(21, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 125)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Usuario"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(449, 18)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(46, 20)
        Me.txtEstado.TabIndex = 13
        Me.txtEstado.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Calle"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Zona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Abonado"
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(79, 94)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(415, 20)
        Me.txtCalle.TabIndex = 8
        '
        'txtZona
        '
        Me.txtZona.Location = New System.Drawing.Point(79, 68)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(416, 20)
        Me.txtZona.TabIndex = 7
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(79, 42)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(417, 20)
        Me.txtUsuario.TabIndex = 6
        '
        'TxtAbonado
        '
        Me.TxtAbonado.Location = New System.Drawing.Point(79, 17)
        Me.TxtAbonado.Name = "TxtAbonado"
        Me.TxtAbonado.Size = New System.Drawing.Size(124, 20)
        Me.TxtAbonado.TabIndex = 5
        Me.TxtAbonado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbRazonSocial
        '
        Me.gbRazonSocial.BackColor = System.Drawing.Color.SkyBlue
        Me.gbRazonSocial.Controls.Add(Me.Label20)
        Me.gbRazonSocial.Controls.Add(Me.Label19)
        Me.gbRazonSocial.Controls.Add(Me.Label18)
        Me.gbRazonSocial.Controls.Add(Me.Label17)
        Me.gbRazonSocial.Controls.Add(Me.txt_Nacimiento)
        Me.gbRazonSocial.Controls.Add(Me.txt_Nit)
        Me.gbRazonSocial.Controls.Add(Me.txt_NoDoc)
        Me.gbRazonSocial.Controls.Add(Me.txt_Doc)
        Me.gbRazonSocial.Controls.Add(Me.txt_RazonSocial)
        Me.gbRazonSocial.Location = New System.Drawing.Point(19, 337)
        Me.gbRazonSocial.Name = "gbRazonSocial"
        Me.gbRazonSocial.Size = New System.Drawing.Size(516, 133)
        Me.gbRazonSocial.TabIndex = 17
        Me.gbRazonSocial.TabStop = False
        Me.gbRazonSocial.Text = "Nuevo Nombre ó Razón Social"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(67, 16)
        Me.Label20.TabIndex = 17
        Me.Label20.Text = "Nacimiento"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 68)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 16)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "NIT / CID"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 16)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Documento"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 16)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Razón Social"
        '
        'txt_Nacimiento
        '
        Me.txt_Nacimiento.Location = New System.Drawing.Point(90, 96)
        Me.txt_Nacimiento.Name = "txt_Nacimiento"
        Me.txt_Nacimiento.Size = New System.Drawing.Size(125, 20)
        Me.txt_Nacimiento.TabIndex = 4
        '
        'txt_Nit
        '
        Me.txt_Nit.Location = New System.Drawing.Point(90, 70)
        Me.txt_Nit.Name = "txt_Nit"
        Me.txt_Nit.Size = New System.Drawing.Size(124, 20)
        Me.txt_Nit.TabIndex = 3
        '
        'txt_NoDoc
        '
        Me.txt_NoDoc.Location = New System.Drawing.Point(177, 46)
        Me.txt_NoDoc.Name = "txt_NoDoc"
        Me.txt_NoDoc.Size = New System.Drawing.Size(147, 20)
        Me.txt_NoDoc.TabIndex = 2
        '
        'txt_Doc
        '
        Me.txt_Doc.Location = New System.Drawing.Point(89, 46)
        Me.txt_Doc.Name = "txt_Doc"
        Me.txt_Doc.Size = New System.Drawing.Size(82, 20)
        Me.txt_Doc.TabIndex = 1
        '
        'txt_RazonSocial
        '
        Me.txt_RazonSocial.Location = New System.Drawing.Point(90, 22)
        Me.txt_RazonSocial.Name = "txt_RazonSocial"
        Me.txt_RazonSocial.Size = New System.Drawing.Size(396, 20)
        Me.txt_RazonSocial.TabIndex = 0
        '
        'gbDireccion
        '
        Me.gbDireccion.BackColor = System.Drawing.Color.Moccasin
        Me.gbDireccion.Controls.Add(Me.Label22)
        Me.gbDireccion.Controls.Add(Me.txt_NumRuta)
        Me.gbDireccion.Controls.Add(Me.Label16)
        Me.gbDireccion.Controls.Add(Me.Label15)
        Me.gbDireccion.Controls.Add(Me.Label14)
        Me.gbDireccion.Controls.Add(Me.Label13)
        Me.gbDireccion.Controls.Add(Me.Label12)
        Me.gbDireccion.Controls.Add(Me.txtNumero)
        Me.gbDireccion.Controls.Add(Me.cbo_Calle)
        Me.gbDireccion.Controls.Add(Me.cbo_Zona)
        Me.gbDireccion.Controls.Add(Me.cbo_SubRuta)
        Me.gbDireccion.Controls.Add(Me.cbo_Ruta)
        Me.gbDireccion.Location = New System.Drawing.Point(20, 324)
        Me.gbDireccion.Name = "gbDireccion"
        Me.gbDireccion.Size = New System.Drawing.Size(517, 163)
        Me.gbDireccion.TabIndex = 16
        Me.gbDireccion.TabStop = False
        Me.gbDireccion.Text = "Ubicación del Usuario"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(200, 49)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 16)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Num Ruta"
        '
        'txt_NumRuta
        '
        Me.txt_NumRuta.Location = New System.Drawing.Point(266, 48)
        Me.txt_NumRuta.Name = "txt_NumRuta"
        Me.txt_NumRuta.Size = New System.Drawing.Size(101, 20)
        Me.txt_NumRuta.TabIndex = 17
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(21, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 16)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Número"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(21, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 16)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Calle"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(21, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 16)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Zona"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 16)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Sub Ruta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Ruta"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(79, 128)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(98, 20)
        Me.txtNumero.TabIndex = 4
        '
        'cbo_Calle
        '
        Me.cbo_Calle.FormattingEnabled = True
        Me.cbo_Calle.Location = New System.Drawing.Point(78, 101)
        Me.cbo_Calle.Name = "cbo_Calle"
        Me.cbo_Calle.Size = New System.Drawing.Size(408, 21)
        Me.cbo_Calle.TabIndex = 3
        '
        'cbo_Zona
        '
        Me.cbo_Zona.FormattingEnabled = True
        Me.cbo_Zona.Location = New System.Drawing.Point(78, 74)
        Me.cbo_Zona.Name = "cbo_Zona"
        Me.cbo_Zona.Size = New System.Drawing.Size(408, 21)
        Me.cbo_Zona.TabIndex = 2
        '
        'cbo_SubRuta
        '
        Me.cbo_SubRuta.FormattingEnabled = True
        Me.cbo_SubRuta.Location = New System.Drawing.Point(79, 47)
        Me.cbo_SubRuta.Name = "cbo_SubRuta"
        Me.cbo_SubRuta.Size = New System.Drawing.Size(96, 21)
        Me.cbo_SubRuta.TabIndex = 1
        '
        'cbo_Ruta
        '
        Me.cbo_Ruta.FormattingEnabled = True
        Me.cbo_Ruta.Location = New System.Drawing.Point(79, 20)
        Me.cbo_Ruta.Name = "cbo_Ruta"
        Me.cbo_Ruta.Size = New System.Drawing.Size(96, 21)
        Me.cbo_Ruta.TabIndex = 0
        '
        'Frm_ProcesaOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 539)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgServicios)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_ProcesaOrdenes"
        Me.Text = "Procesar Ordenes"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.gbCategoria.ResumeLayout(False)
        Me.gbCategoria.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbRazonSocial.ResumeLayout(False)
        Me.gbRazonSocial.PerformLayout()
        Me.gbDireccion.ResumeLayout(False)
        Me.gbDireccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnAnular As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents dgServicios As System.Windows.Forms.DataGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtServicio As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents txtZona As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtAbonado As System.Windows.Forms.TextBox
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents cboEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gbDireccion As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Calle As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Zona As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_SubRuta As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_Ruta As System.Windows.Forms.ComboBox
    Friend WithEvents gbRazonSocial As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Nacimiento As System.Windows.Forms.TextBox
    Friend WithEvents txt_Nit As System.Windows.Forms.TextBox
    Friend WithEvents txt_NoDoc As System.Windows.Forms.TextBox
    Friend WithEvents txt_Doc As System.Windows.Forms.TextBox
    Friend WithEvents txt_RazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents gbCategoria As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txt_Categoria As System.Windows.Forms.TextBox
    Friend WithEvents txtCodServicio As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_NumRuta As System.Windows.Forms.TextBox
    Friend WithEvents txt_CodCategoria As System.Windows.Forms.TextBox
    Friend WithEvents lblInicial As System.Windows.Forms.Label
    Friend WithEvents txt_LectInicial As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
End Class
