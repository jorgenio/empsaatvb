<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Transcripciones
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnLecturaAnterior = New System.Windows.Forms.Panel()
        Me.txtPeriodoAntes = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtLecturaAnterior = New System.Windows.Forms.TextBox()
        Me.btnCancelarLecturaAnterior = New System.Windows.Forms.Button()
        Me.btnGrabarLecturaAnterior = New System.Windows.Forms.Button()
        Me.btnModificaLectura = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxLiberacion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblPosicion = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtProm = New System.Windows.Forms.TextBox()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.BtnAdelante = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgHis = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxPeriodo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkSinFactura = New System.Windows.Forms.CheckBox()
        Me.chkEstimado = New System.Windows.Forms.CheckBox()
        Me.TxConsumo = New System.Windows.Forms.TextBox()
        Me.TxActual = New System.Windows.Forms.TextBox()
        Me.TxAnterior = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ChkLey1886 = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxNoRuta = New System.Windows.Forms.TextBox()
        Me.TxSubRuta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboRuta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxCalle = New System.Windows.Forms.TextBox()
        Me.TxZona = New System.Windows.Forms.TextBox()
        Me.TxCuenta = New System.Windows.Forms.TextBox()
        Me.TxNIT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxCategoria = New System.Windows.Forms.TextBox()
        Me.TxUsuario = New System.Windows.Forms.TextBox()
        Me.TxAbonado = New System.Windows.Forms.TextBox()
        Me.Errores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnLecturaAnterior.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgHis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.pnLecturaAnterior)
        Me.Panel1.Controls.Add(Me.btnModificaLectura)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.TxLiberacion)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.LblPosicion)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.BtnAtras)
        Me.Panel1.Controls.Add(Me.BtnAdelante)
        Me.Panel1.Controls.Add(Me.BtnGrabar)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TxPeriodo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TxConsumo)
        Me.Panel1.Controls.Add(Me.TxActual)
        Me.Panel1.Controls.Add(Me.TxAnterior)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(4, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 496)
        Me.Panel1.TabIndex = 0
        '
        'pnLecturaAnterior
        '
        Me.pnLecturaAnterior.BackColor = System.Drawing.Color.Moccasin
        Me.pnLecturaAnterior.Controls.Add(Me.txtPeriodoAntes)
        Me.pnLecturaAnterior.Controls.Add(Me.Label19)
        Me.pnLecturaAnterior.Controls.Add(Me.Label18)
        Me.pnLecturaAnterior.Controls.Add(Me.txtLecturaAnterior)
        Me.pnLecturaAnterior.Controls.Add(Me.btnCancelarLecturaAnterior)
        Me.pnLecturaAnterior.Controls.Add(Me.btnGrabarLecturaAnterior)
        Me.pnLecturaAnterior.Location = New System.Drawing.Point(388, 97)
        Me.pnLecturaAnterior.Name = "pnLecturaAnterior"
        Me.pnLecturaAnterior.Size = New System.Drawing.Size(409, 367)
        Me.pnLecturaAnterior.TabIndex = 25
        Me.pnLecturaAnterior.Visible = False
        '
        'txtPeriodoAntes
        '
        Me.txtPeriodoAntes.Location = New System.Drawing.Point(189, 103)
        Me.txtPeriodoAntes.Name = "txtPeriodoAntes"
        Me.txtPeriodoAntes.ReadOnly = True
        Me.txtPeriodoAntes.Size = New System.Drawing.Size(124, 20)
        Me.txtPeriodoAntes.TabIndex = 5
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(87, 106)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 13)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Periodo Anterior"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(87, 150)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(82, 13)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Lectura Anterior"
        '
        'txtLecturaAnterior
        '
        Me.txtLecturaAnterior.Location = New System.Drawing.Point(189, 145)
        Me.txtLecturaAnterior.Name = "txtLecturaAnterior"
        Me.txtLecturaAnterior.Size = New System.Drawing.Size(125, 20)
        Me.txtLecturaAnterior.TabIndex = 2
        '
        'btnCancelarLecturaAnterior
        '
        Me.btnCancelarLecturaAnterior.Location = New System.Drawing.Point(222, 257)
        Me.btnCancelarLecturaAnterior.Name = "btnCancelarLecturaAnterior"
        Me.btnCancelarLecturaAnterior.Size = New System.Drawing.Size(117, 39)
        Me.btnCancelarLecturaAnterior.TabIndex = 1
        Me.btnCancelarLecturaAnterior.Text = "Cancelar"
        Me.btnCancelarLecturaAnterior.UseVisualStyleBackColor = True
        '
        'btnGrabarLecturaAnterior
        '
        Me.btnGrabarLecturaAnterior.Location = New System.Drawing.Point(78, 257)
        Me.btnGrabarLecturaAnterior.Name = "btnGrabarLecturaAnterior"
        Me.btnGrabarLecturaAnterior.Size = New System.Drawing.Size(117, 39)
        Me.btnGrabarLecturaAnterior.TabIndex = 0
        Me.btnGrabarLecturaAnterior.Text = "Grabar"
        Me.btnGrabarLecturaAnterior.UseVisualStyleBackColor = True
        '
        'btnModificaLectura
        '
        Me.btnModificaLectura.BackColor = System.Drawing.Color.LightSalmon
        Me.btnModificaLectura.Location = New System.Drawing.Point(416, 408)
        Me.btnModificaLectura.Name = "btnModificaLectura"
        Me.btnModificaLectura.Size = New System.Drawing.Size(98, 42)
        Me.btnModificaLectura.TabIndex = 24
        Me.btnModificaLectura.Text = "Modificar Lectura Anterior"
        Me.btnModificaLectura.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(142, 95)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Liberacion"
        Me.Label17.Visible = False
        '
        'TxLiberacion
        '
        Me.TxLiberacion.Location = New System.Drawing.Point(221, 92)
        Me.TxLiberacion.Name = "TxLiberacion"
        Me.TxLiberacion.ReadOnly = True
        Me.TxLiberacion.Size = New System.Drawing.Size(127, 20)
        Me.TxLiberacion.TabIndex = 22
        Me.TxLiberacion.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 42)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Buscar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Abonado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblPosicion
        '
        Me.LblPosicion.AutoSize = True
        Me.LblPosicion.Location = New System.Drawing.Point(183, 451)
        Me.LblPosicion.Name = "LblPosicion"
        Me.LblPosicion.Size = New System.Drawing.Size(16, 13)
        Me.LblPosicion.TabIndex = 20
        Me.LblPosicion.Text = "..."
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtProm)
        Me.GroupBox2.Location = New System.Drawing.Point(388, 261)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 60)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(190, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Promedio de Consumo [3 meses]"
        '
        'txtProm
        '
        Me.txtProm.Location = New System.Drawing.Point(238, 19)
        Me.txtProm.Name = "txtProm"
        Me.txtProm.Size = New System.Drawing.Size(101, 20)
        Me.txtProm.TabIndex = 0
        Me.txtProm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(112, 411)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(60, 37)
        Me.BtnAtras.TabIndex = 18
        Me.BtnAtras.Tag = "2"
        Me.BtnAtras.Text = "<"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'BtnAdelante
        '
        Me.BtnAdelante.Location = New System.Drawing.Point(292, 411)
        Me.BtnAdelante.Name = "BtnAdelante"
        Me.BtnAdelante.Size = New System.Drawing.Size(58, 37)
        Me.BtnAdelante.TabIndex = 6
        Me.BtnAdelante.Tag = "1"
        Me.BtnAdelante.Text = ">"
        Me.BtnAdelante.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Location = New System.Drawing.Point(178, 411)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(108, 37)
        Me.BtnGrabar.TabIndex = 5
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dgHis)
        Me.Panel2.Location = New System.Drawing.Point(388, 109)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 146)
        Me.Panel2.TabIndex = 15
        '
        'dgHis
        '
        Me.dgHis.AllowUserToAddRows = False
        Me.dgHis.AllowUserToDeleteRows = False
        Me.dgHis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgHis.Location = New System.Drawing.Point(0, 0)
        Me.dgHis.Name = "dgHis"
        Me.dgHis.ReadOnly = True
        Me.dgHis.Size = New System.Drawing.Size(391, 142)
        Me.dgHis.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(108, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "PERIODO"
        '
        'TxPeriodo
        '
        Me.TxPeriodo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxPeriodo.Location = New System.Drawing.Point(228, 128)
        Me.TxPeriodo.Name = "TxPeriodo"
        Me.TxPeriodo.Size = New System.Drawing.Size(121, 20)
        Me.TxPeriodo.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(108, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Cubos de Consumo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(108, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Lectura Actual"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(108, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Lectura Anterior"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkSinFactura)
        Me.GroupBox1.Controls.Add(Me.chkEstimado)
        Me.GroupBox1.Location = New System.Drawing.Point(169, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 87)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'chkSinFactura
        '
        Me.chkSinFactura.AutoSize = True
        Me.chkSinFactura.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSinFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSinFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkSinFactura.Location = New System.Drawing.Point(17, 50)
        Me.chkSinFactura.Name = "chkSinFactura"
        Me.chkSinFactura.Size = New System.Drawing.Size(121, 24)
        Me.chkSinFactura.TabIndex = 9
        Me.chkSinFactura.Text = "Sin Factura"
        Me.chkSinFactura.UseVisualStyleBackColor = True
        '
        'chkEstimado
        '
        Me.chkEstimado.AutoSize = True
        Me.chkEstimado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkEstimado.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEstimado.Location = New System.Drawing.Point(62, 19)
        Me.chkEstimado.Name = "chkEstimado"
        Me.chkEstimado.Size = New System.Drawing.Size(76, 20)
        Me.chkEstimado.TabIndex = 0
        Me.chkEstimado.Text = "Estimado"
        Me.chkEstimado.UseVisualStyleBackColor = True
        '
        'TxConsumo
        '
        Me.TxConsumo.BackColor = System.Drawing.SystemColors.Control
        Me.TxConsumo.Location = New System.Drawing.Point(228, 239)
        Me.TxConsumo.Name = "TxConsumo"
        Me.TxConsumo.ReadOnly = True
        Me.TxConsumo.Size = New System.Drawing.Size(121, 20)
        Me.TxConsumo.TabIndex = 16
        Me.TxConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxActual
        '
        Me.TxActual.Location = New System.Drawing.Point(228, 202)
        Me.TxActual.Name = "TxActual"
        Me.TxActual.Size = New System.Drawing.Size(121, 20)
        Me.TxActual.TabIndex = 4
        Me.TxActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxAnterior
        '
        Me.TxAnterior.BackColor = System.Drawing.SystemColors.Info
        Me.TxAnterior.Location = New System.Drawing.Point(231, 165)
        Me.TxAnterior.Name = "TxAnterior"
        Me.TxAnterior.ReadOnly = True
        Me.TxAnterior.Size = New System.Drawing.Size(121, 20)
        Me.TxAnterior.TabIndex = 3
        Me.TxAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.ChkLey1886)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.TxNoRuta)
        Me.Panel3.Controls.Add(Me.TxSubRuta)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.CboRuta)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TxCalle)
        Me.Panel3.Controls.Add(Me.TxZona)
        Me.Panel3.Controls.Add(Me.TxCuenta)
        Me.Panel3.Controls.Add(Me.TxNIT)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TxCategoria)
        Me.Panel3.Controls.Add(Me.TxUsuario)
        Me.Panel3.Controls.Add(Me.TxAbonado)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 86)
        Me.Panel3.TabIndex = 2
        '
        'ChkLey1886
        '
        Me.ChkLey1886.AutoSize = True
        Me.ChkLey1886.Checked = True
        Me.ChkLey1886.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkLey1886.Enabled = False
        Me.ChkLey1886.Location = New System.Drawing.Point(442, 54)
        Me.ChkLey1886.Name = "ChkLey1886"
        Me.ChkLey1886.Size = New System.Drawing.Size(70, 17)
        Me.ChkLey1886.TabIndex = 23
        Me.ChkLey1886.Text = "Ley 1886"
        Me.ChkLey1886.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(444, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 13)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "Ley 1886"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(9, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "NoRuta"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(9, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 13)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "SubRuta"
        '
        'TxNoRuta
        '
        Me.TxNoRuta.Location = New System.Drawing.Point(71, 55)
        Me.TxNoRuta.Name = "TxNoRuta"
        Me.TxNoRuta.ReadOnly = True
        Me.TxNoRuta.Size = New System.Drawing.Size(59, 20)
        Me.TxNoRuta.TabIndex = 18
        '
        'TxSubRuta
        '
        Me.TxSubRuta.Location = New System.Drawing.Point(71, 30)
        Me.TxSubRuta.Name = "TxSubRuta"
        Me.TxSubRuta.ReadOnly = True
        Me.TxSubRuta.Size = New System.Drawing.Size(59, 20)
        Me.TxSubRuta.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "RUTA"
        '
        'CboRuta
        '
        Me.CboRuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboRuta.FormattingEnabled = True
        Me.CboRuta.Location = New System.Drawing.Point(71, 3)
        Me.CboRuta.Name = "CboRuta"
        Me.CboRuta.Size = New System.Drawing.Size(59, 21)
        Me.CboRuta.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(325, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "NIT/CID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(556, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Calle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(556, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Zona"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(556, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cuenta"
        '
        'TxCalle
        '
        Me.TxCalle.Location = New System.Drawing.Point(619, 55)
        Me.TxCalle.Name = "TxCalle"
        Me.TxCalle.ReadOnly = True
        Me.TxCalle.Size = New System.Drawing.Size(161, 20)
        Me.TxCalle.TabIndex = 9
        '
        'TxZona
        '
        Me.TxZona.Location = New System.Drawing.Point(619, 30)
        Me.TxZona.Name = "TxZona"
        Me.TxZona.ReadOnly = True
        Me.TxZona.Size = New System.Drawing.Size(161, 20)
        Me.TxZona.TabIndex = 8
        '
        'TxCuenta
        '
        Me.TxCuenta.Location = New System.Drawing.Point(619, 4)
        Me.TxCuenta.Name = "TxCuenta"
        Me.TxCuenta.ReadOnly = True
        Me.TxCuenta.Size = New System.Drawing.Size(162, 20)
        Me.TxCuenta.TabIndex = 7
        '
        'TxNIT
        '
        Me.TxNIT.Location = New System.Drawing.Point(386, 4)
        Me.TxNIT.Name = "TxNIT"
        Me.TxNIT.ReadOnly = True
        Me.TxNIT.Size = New System.Drawing.Size(164, 20)
        Me.TxNIT.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Abonado"
        '
        'TxCategoria
        '
        Me.TxCategoria.Location = New System.Drawing.Point(219, 55)
        Me.TxCategoria.Name = "TxCategoria"
        Me.TxCategoria.ReadOnly = True
        Me.TxCategoria.Size = New System.Drawing.Size(212, 20)
        Me.TxCategoria.TabIndex = 2
        '
        'TxUsuario
        '
        Me.TxUsuario.Location = New System.Drawing.Point(219, 29)
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.ReadOnly = True
        Me.TxUsuario.Size = New System.Drawing.Size(332, 20)
        Me.TxUsuario.TabIndex = 1
        '
        'TxAbonado
        '
        Me.TxAbonado.Location = New System.Drawing.Point(219, 3)
        Me.TxAbonado.Name = "TxAbonado"
        Me.TxAbonado.ReadOnly = True
        Me.TxAbonado.Size = New System.Drawing.Size(100, 20)
        Me.TxAbonado.TabIndex = 0
        '
        'Errores
        '
        Me.Errores.BlinkRate = 300
        Me.Errores.ContainerControl = Me
        '
        'Frm_Transcripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 512)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Transcripciones"
        Me.Text = "Transcripción de lecturas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnLecturaAnterior.ResumeLayout(False)
        Me.pnLecturaAnterior.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgHis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxCalle As System.Windows.Forms.TextBox
    Friend WithEvents TxZona As System.Windows.Forms.TextBox
    Friend WithEvents TxCuenta As System.Windows.Forms.TextBox
    Friend WithEvents TxNIT As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TxUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxAbonado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboRuta As System.Windows.Forms.ComboBox
    Friend WithEvents TxConsumo As System.Windows.Forms.TextBox
    Friend WithEvents TxActual As System.Windows.Forms.TextBox
    Friend WithEvents TxAnterior As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BtnAtras As System.Windows.Forms.Button
    Friend WithEvents BtnAdelante As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents Errores As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProm As System.Windows.Forms.TextBox
    Friend WithEvents LblPosicion As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxNoRuta As System.Windows.Forms.TextBox
    Friend WithEvents TxSubRuta As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ChkLey1886 As System.Windows.Forms.CheckBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxLiberacion As System.Windows.Forms.TextBox
    Friend WithEvents btnModificaLectura As System.Windows.Forms.Button
    Friend WithEvents pnLecturaAnterior As System.Windows.Forms.Panel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtLecturaAnterior As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelarLecturaAnterior As System.Windows.Forms.Button
    Friend WithEvents btnGrabarLecturaAnterior As System.Windows.Forms.Button
    Friend WithEvents dgHis As System.Windows.Forms.DataGridView
    Friend WithEvents chkEstimado As System.Windows.Forms.CheckBox
    Friend WithEvents chkSinFactura As System.Windows.Forms.CheckBox
    Friend WithEvents txtPeriodoAntes As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
