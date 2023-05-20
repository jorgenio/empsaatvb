<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Facturacion
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Facturacion))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.dgUsuarios = New System.Windows.Forms.DataGridView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnNuevaBusqueda = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.BtnBuscar = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TxPaterno = New System.Windows.Forms.TextBox
        Me.CboTipo = New System.Windows.Forms.ComboBox
        Me.TxNombre = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.dgDeuB = New System.Windows.Forms.DataGrid
        Me.dgDeuA = New System.Windows.Forms.DataGrid
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.rdRecargosAntes = New System.Windows.Forms.RadioButton
        Me.rdSinRecargos = New System.Windows.Forms.RadioButton
        Me.rdConRecargos = New System.Windows.Forms.RadioButton
        Me.BtnImpDeudas = New System.Windows.Forms.Button
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.DgHisto = New System.Windows.Forms.DataGrid
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.btnImprimeHistorico = New System.Windows.Forms.Button
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.chkRep = New System.Windows.Forms.CheckBox
        Me.gbCambioNombre = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_Nit = New System.Windows.Forms.TextBox
        Me.dt_Nacimiento = New System.Windows.Forms.DateTimePicker
        Me.txt_NoDoc = New System.Windows.Forms.TextBox
        Me.cbo_Doc = New System.Windows.Forms.ComboBox
        Me.Txt_Nombre = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnCancelarOrden = New System.Windows.Forms.Button
        Me.BtnGrabarOrden = New System.Windows.Forms.Button
        Me.txtNota = New System.Windows.Forms.TextBox
        Me.txtCosto = New System.Windows.Forms.TextBox
        Me.cboServicios = New System.Windows.Forms.ComboBox
        Me.dgOrdenes = New System.Windows.Forms.DataGrid
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.BtnImprimirOrden = New System.Windows.Forms.Button
        Me.btnAnularOrden = New System.Windows.Forms.Button
        Me.BtnNuevaOrden = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxCategoria = New System.Windows.Forms.TextBox
        Me.TxUsuario = New System.Windows.Forms.TextBox
        Me.TxAbonado = New System.Windows.Forms.TextBox
        Me.Imp = New System.Drawing.Printing.PrintDocument
        Me.Prev = New System.Windows.Forms.PrintPreviewDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gbCategoria = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cbo_Categoria = New System.Windows.Forms.ComboBox
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
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgDeuB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDeuA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.DgHisto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.gbCambioNombre.SuspendLayout()
        CType(Me.dgOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.gbCategoria.SuspendLayout()
        Me.gbDireccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(708, 537)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgUsuarios)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(700, 511)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Busqueda de Usuarios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUsuarios.Location = New System.Drawing.Point(134, 51)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.Size = New System.Drawing.Size(563, 457)
        Me.dgUsuarios.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.BtnNuevaBusqueda)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.BtnBuscar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(3, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 457)
        Me.Panel2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1, 144)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 58)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Recalculo de Factura"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnNuevaBusqueda
        '
        Me.BtnNuevaBusqueda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevaBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnNuevaBusqueda.Location = New System.Drawing.Point(0, 41)
        Me.BtnNuevaBusqueda.Name = "BtnNuevaBusqueda"
        Me.BtnNuevaBusqueda.Size = New System.Drawing.Size(127, 41)
        Me.BtnNuevaBusqueda.TabIndex = 2
        Me.BtnNuevaBusqueda.Text = "Nueva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Busqueda"
        Me.BtnNuevaBusqueda.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.Location = New System.Drawing.Point(0, 413)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 40)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuscar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnBuscar.Location = New System.Drawing.Point(0, 0)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(127, 41)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "&Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TxPaterno)
        Me.Panel1.Controls.Add(Me.CboTipo)
        Me.Panel1.Controls.Add(Me.TxNombre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 48)
        Me.Panel1.TabIndex = 3
        '
        'TxPaterno
        '
        Me.TxPaterno.Location = New System.Drawing.Point(135, 15)
        Me.TxPaterno.Name = "TxPaterno"
        Me.TxPaterno.Size = New System.Drawing.Size(226, 20)
        Me.TxPaterno.TabIndex = 0
        '
        'CboTipo
        '
        Me.CboTipo.FormattingEnabled = True
        Me.CboTipo.Items.AddRange(New Object() {"Nombre", "Abonado", "Dirección", "NIT/CID"})
        Me.CboTipo.Location = New System.Drawing.Point(6, 15)
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.Size = New System.Drawing.Size(123, 21)
        Me.CboTipo.TabIndex = 2
        Me.CboTipo.Text = "Nombre"
        '
        'TxNombre
        '
        Me.TxNombre.Location = New System.Drawing.Point(367, 15)
        Me.TxNombre.Name = "TxNombre"
        Me.TxNombre.Size = New System.Drawing.Size(226, 20)
        Me.TxNombre.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TabControl2)
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(700, 511)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(3, 89)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(694, 419)
        Me.TabControl2.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgDeuB)
        Me.TabPage3.Controls.Add(Me.dgDeuA)
        Me.TabPage3.Controls.Add(Me.Panel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(686, 393)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Deudas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgDeuB
        '
        Me.dgDeuB.AlternatingBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dgDeuB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDeuB.BackColor = System.Drawing.Color.White
        Me.dgDeuB.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dgDeuB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgDeuB.CaptionBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dgDeuB.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDeuB.CaptionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDeuB.CaptionText = "Facturas Actuales"
        Me.dgDeuB.DataMember = ""
        Me.dgDeuB.FlatMode = True
        Me.dgDeuB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDeuB.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDeuB.GridLineColor = System.Drawing.Color.Peru
        Me.dgDeuB.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgDeuB.HeaderBackColor = System.Drawing.Color.Maroon
        Me.dgDeuB.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDeuB.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dgDeuB.LinkColor = System.Drawing.Color.Maroon
        Me.dgDeuB.Location = New System.Drawing.Point(140, 179)
        Me.dgDeuB.Name = "dgDeuB"
        Me.dgDeuB.ParentRowsBackColor = System.Drawing.Color.BurlyWood
        Me.dgDeuB.ParentRowsForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDeuB.ReadOnly = True
        Me.dgDeuB.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDeuB.SelectionForeColor = System.Drawing.Color.GhostWhite
        Me.dgDeuB.Size = New System.Drawing.Size(540, 192)
        Me.dgDeuB.TabIndex = 3
        '
        'dgDeuA
        '
        Me.dgDeuA.AlternatingBackColor = System.Drawing.Color.White
        Me.dgDeuA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDeuA.BackColor = System.Drawing.Color.White
        Me.dgDeuA.BackgroundColor = System.Drawing.Color.Ivory
        Me.dgDeuA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgDeuA.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDeuA.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDeuA.CaptionForeColor = System.Drawing.Color.Lavender
        Me.dgDeuA.CaptionText = "Facturas Anteriores"
        Me.dgDeuA.DataMember = ""
        Me.dgDeuA.FlatMode = True
        Me.dgDeuA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDeuA.ForeColor = System.Drawing.Color.Black
        Me.dgDeuA.GridLineColor = System.Drawing.Color.Wheat
        Me.dgDeuA.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.dgDeuA.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDeuA.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDeuA.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDeuA.Location = New System.Drawing.Point(138, 5)
        Me.dgDeuA.Name = "dgDeuA"
        Me.dgDeuA.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.dgDeuA.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgDeuA.ReadOnly = True
        Me.dgDeuA.SelectionBackColor = System.Drawing.Color.Wheat
        Me.dgDeuA.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDeuA.Size = New System.Drawing.Size(542, 168)
        Me.dgDeuA.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.rdRecargosAntes)
        Me.Panel4.Controls.Add(Me.rdSinRecargos)
        Me.Panel4.Controls.Add(Me.rdConRecargos)
        Me.Panel4.Controls.Add(Me.BtnImpDeudas)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(131, 387)
        Me.Panel4.TabIndex = 1
        '
        'rdRecargosAntes
        '
        Me.rdRecargosAntes.AutoSize = True
        Me.rdRecargosAntes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rdRecargosAntes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rdRecargosAntes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdRecargosAntes.FlatAppearance.BorderSize = 2
        Me.rdRecargosAntes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdRecargosAntes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdRecargosAntes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.rdRecargosAntes.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdRecargosAntes.Location = New System.Drawing.Point(34, 111)
        Me.rdRecargosAntes.Name = "rdRecargosAntes"
        Me.rdRecargosAntes.Size = New System.Drawing.Size(71, 30)
        Me.rdRecargosAntes.TabIndex = 5
        Me.rdRecargosAntes.Text = "Recargos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Anteriores"
        Me.rdRecargosAntes.UseVisualStyleBackColor = True
        '
        'rdSinRecargos
        '
        Me.rdSinRecargos.AutoSize = True
        Me.rdSinRecargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rdSinRecargos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rdSinRecargos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdSinRecargos.FlatAppearance.BorderSize = 2
        Me.rdSinRecargos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdSinRecargos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdSinRecargos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.rdSinRecargos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdSinRecargos.Location = New System.Drawing.Point(17, 80)
        Me.rdSinRecargos.Name = "rdSinRecargos"
        Me.rdSinRecargos.Size = New System.Drawing.Size(88, 17)
        Me.rdSinRecargos.TabIndex = 4
        Me.rdSinRecargos.Text = "Sin Recargos"
        Me.rdSinRecargos.UseVisualStyleBackColor = True
        '
        'rdConRecargos
        '
        Me.rdConRecargos.AutoSize = True
        Me.rdConRecargos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.rdConRecargos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rdConRecargos.Checked = True
        Me.rdConRecargos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rdConRecargos.FlatAppearance.BorderSize = 2
        Me.rdConRecargos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdConRecargos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.rdConRecargos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.rdConRecargos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rdConRecargos.Location = New System.Drawing.Point(13, 49)
        Me.rdConRecargos.Name = "rdConRecargos"
        Me.rdConRecargos.Size = New System.Drawing.Size(92, 17)
        Me.rdConRecargos.TabIndex = 3
        Me.rdConRecargos.TabStop = True
        Me.rdConRecargos.Text = "Con Recargos"
        Me.rdConRecargos.UseVisualStyleBackColor = True
        '
        'BtnImpDeudas
        '
        Me.BtnImpDeudas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnImpDeudas.Location = New System.Drawing.Point(0, 0)
        Me.BtnImpDeudas.Name = "BtnImpDeudas"
        Me.BtnImpDeudas.Size = New System.Drawing.Size(127, 41)
        Me.BtnImpDeudas.TabIndex = 0
        Me.BtnImpDeudas.Text = "Imprimir Kardex"
        Me.BtnImpDeudas.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DgHisto)
        Me.TabPage4.Controls.Add(Me.Panel5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(686, 393)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Historico"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DgHisto
        '
        Me.DgHisto.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.DgHisto.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DgHisto.BackgroundColor = System.Drawing.Color.LightGray
        Me.DgHisto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgHisto.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.DgHisto.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DgHisto.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.DgHisto.DataMember = ""
        Me.DgHisto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgHisto.FlatMode = True
        Me.DgHisto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DgHisto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DgHisto.GridLineColor = System.Drawing.Color.Gainsboro
        Me.DgHisto.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DgHisto.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DgHisto.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DgHisto.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgHisto.LinkColor = System.Drawing.Color.Teal
        Me.DgHisto.Location = New System.Drawing.Point(134, 3)
        Me.DgHisto.Name = "DgHisto"
        Me.DgHisto.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DgHisto.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DgHisto.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.DgHisto.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.DgHisto.Size = New System.Drawing.Size(549, 387)
        Me.DgHisto.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.btnImprimeHistorico)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(131, 387)
        Me.Panel5.TabIndex = 2
        '
        'btnImprimeHistorico
        '
        Me.btnImprimeHistorico.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImprimeHistorico.Location = New System.Drawing.Point(0, 0)
        Me.btnImprimeHistorico.Name = "btnImprimeHistorico"
        Me.btnImprimeHistorico.Size = New System.Drawing.Size(127, 41)
        Me.btnImprimeHistorico.TabIndex = 0
        Me.btnImprimeHistorico.Text = "Imprimir Kardex"
        Me.btnImprimeHistorico.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Panel7)
        Me.TabPage5.Controls.Add(Me.dgOrdenes)
        Me.TabPage5.Controls.Add(Me.Panel6)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(686, 393)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Ordenes Servicio"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.gbDireccion)
        Me.Panel7.Controls.Add(Me.gbCategoria)
        Me.Panel7.Controls.Add(Me.chkRep)
        Me.Panel7.Controls.Add(Me.gbCambioNombre)
        Me.Panel7.Controls.Add(Me.Label10)
        Me.Panel7.Controls.Add(Me.Label9)
        Me.Panel7.Controls.Add(Me.Label8)
        Me.Panel7.Controls.Add(Me.BtnCancelarOrden)
        Me.Panel7.Controls.Add(Me.BtnGrabarOrden)
        Me.Panel7.Controls.Add(Me.txtNota)
        Me.Panel7.Controls.Add(Me.txtCosto)
        Me.Panel7.Controls.Add(Me.cboServicios)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(134, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(549, 387)
        Me.Panel7.TabIndex = 4
        Me.Panel7.Visible = False
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
        'gbCambioNombre
        '
        Me.gbCambioNombre.Controls.Add(Me.Label14)
        Me.gbCambioNombre.Controls.Add(Me.Label13)
        Me.gbCambioNombre.Controls.Add(Me.Label12)
        Me.gbCambioNombre.Controls.Add(Me.Label11)
        Me.gbCambioNombre.Controls.Add(Me.txt_Nit)
        Me.gbCambioNombre.Controls.Add(Me.dt_Nacimiento)
        Me.gbCambioNombre.Controls.Add(Me.txt_NoDoc)
        Me.gbCambioNombre.Controls.Add(Me.cbo_Doc)
        Me.gbCambioNombre.Controls.Add(Me.Txt_Nombre)
        Me.gbCambioNombre.Location = New System.Drawing.Point(24, 156)
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
        Me.Label14.Location = New System.Drawing.Point(18, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "NIT / CID"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 76)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Nacimiento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Documento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Razon Social"
        '
        'txt_Nit
        '
        Me.txt_Nit.Location = New System.Drawing.Point(138, 98)
        Me.txt_Nit.Name = "txt_Nit"
        Me.txt_Nit.Size = New System.Drawing.Size(124, 20)
        Me.txt_Nit.TabIndex = 4
        '
        'dt_Nacimiento
        '
        Me.dt_Nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_Nacimiento.Location = New System.Drawing.Point(138, 72)
        Me.dt_Nacimiento.Name = "dt_Nacimiento"
        Me.dt_Nacimiento.Size = New System.Drawing.Size(125, 20)
        Me.dt_Nacimiento.TabIndex = 3
        '
        'txt_NoDoc
        '
        Me.txt_NoDoc.Location = New System.Drawing.Point(232, 46)
        Me.txt_NoDoc.Name = "txt_NoDoc"
        Me.txt_NoDoc.Size = New System.Drawing.Size(168, 20)
        Me.txt_NoDoc.TabIndex = 2
        '
        'cbo_Doc
        '
        Me.cbo_Doc.FormattingEnabled = True
        Me.cbo_Doc.Items.AddRange(New Object() {"CID", "RUN", "LSM", "PAS", "NIT"})
        Me.cbo_Doc.Location = New System.Drawing.Point(138, 45)
        Me.cbo_Doc.Name = "cbo_Doc"
        Me.cbo_Doc.Size = New System.Drawing.Size(88, 21)
        Me.cbo_Doc.TabIndex = 1
        '
        'Txt_Nombre
        '
        Me.Txt_Nombre.Location = New System.Drawing.Point(137, 19)
        Me.Txt_Nombre.Name = "Txt_Nombre"
        Me.Txt_Nombre.Size = New System.Drawing.Size(441, 20)
        Me.Txt_Nombre.TabIndex = 0
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
        Me.BtnCancelarOrden.Location = New System.Drawing.Point(377, 336)
        Me.BtnCancelarOrden.Name = "BtnCancelarOrden"
        Me.BtnCancelarOrden.Size = New System.Drawing.Size(127, 41)
        Me.BtnCancelarOrden.TabIndex = 4
        Me.BtnCancelarOrden.Text = "Cancelar"
        Me.BtnCancelarOrden.UseVisualStyleBackColor = True
        '
        'BtnGrabarOrden
        '
        Me.BtnGrabarOrden.Location = New System.Drawing.Point(212, 336)
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
        Me.txtCosto.Size = New System.Drawing.Size(118, 20)
        Me.txtCosto.TabIndex = 1
        '
        'cboServicios
        '
        Me.cboServicios.FormattingEnabled = True
        Me.cboServicios.Location = New System.Drawing.Point(161, 30)
        Me.cboServicios.Name = "cboServicios"
        Me.cboServicios.Size = New System.Drawing.Size(444, 21)
        Me.cboServicios.TabIndex = 0
        '
        'dgOrdenes
        '
        Me.dgOrdenes.AlternatingBackColor = System.Drawing.Color.White
        Me.dgOrdenes.BackColor = System.Drawing.Color.White
        Me.dgOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgOrdenes.CaptionBackColor = System.Drawing.Color.Teal
        Me.dgOrdenes.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgOrdenes.CaptionForeColor = System.Drawing.Color.White
        Me.dgOrdenes.DataMember = ""
        Me.dgOrdenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOrdenes.FlatMode = True
        Me.dgOrdenes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgOrdenes.ForeColor = System.Drawing.Color.Black
        Me.dgOrdenes.GridLineColor = System.Drawing.Color.Silver
        Me.dgOrdenes.HeaderBackColor = System.Drawing.Color.Black
        Me.dgOrdenes.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgOrdenes.HeaderForeColor = System.Drawing.Color.White
        Me.dgOrdenes.LinkColor = System.Drawing.Color.Purple
        Me.dgOrdenes.Location = New System.Drawing.Point(134, 3)
        Me.dgOrdenes.Name = "dgOrdenes"
        Me.dgOrdenes.ParentRowsBackColor = System.Drawing.Color.Gray
        Me.dgOrdenes.ParentRowsForeColor = System.Drawing.Color.White
        Me.dgOrdenes.SelectionBackColor = System.Drawing.Color.Maroon
        Me.dgOrdenes.SelectionForeColor = System.Drawing.Color.White
        Me.dgOrdenes.Size = New System.Drawing.Size(549, 387)
        Me.dgOrdenes.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.BtnImprimirOrden)
        Me.Panel6.Controls.Add(Me.btnAnularOrden)
        Me.Panel6.Controls.Add(Me.BtnNuevaOrden)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(131, 387)
        Me.Panel6.TabIndex = 2
        '
        'BtnImprimirOrden
        '
        Me.BtnImprimirOrden.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnImprimirOrden.Location = New System.Drawing.Point(0, 41)
        Me.BtnImprimirOrden.Name = "BtnImprimirOrden"
        Me.BtnImprimirOrden.Size = New System.Drawing.Size(127, 41)
        Me.BtnImprimirOrden.TabIndex = 2
        Me.BtnImprimirOrden.Text = "Imprimir"
        Me.BtnImprimirOrden.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImprimirOrden.UseVisualStyleBackColor = True
        '
        'btnAnularOrden
        '
        Me.btnAnularOrden.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnAnularOrden.Location = New System.Drawing.Point(0, 342)
        Me.btnAnularOrden.Name = "btnAnularOrden"
        Me.btnAnularOrden.Size = New System.Drawing.Size(127, 41)
        Me.btnAnularOrden.TabIndex = 1
        Me.btnAnularOrden.Text = "Anular Orden"
        Me.btnAnularOrden.UseVisualStyleBackColor = True
        '
        'BtnNuevaOrden
        '
        Me.BtnNuevaOrden.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnNuevaOrden.Location = New System.Drawing.Point(0, 0)
        Me.BtnNuevaOrden.Name = "BtnNuevaOrden"
        Me.BtnNuevaOrden.Size = New System.Drawing.Size(127, 41)
        Me.BtnNuevaOrden.TabIndex = 0
        Me.BtnNuevaOrden.Text = "Nueva"
        Me.BtnNuevaOrden.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Label7)
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
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TxCategoria)
        Me.Panel3.Controls.Add(Me.TxUsuario)
        Me.Panel3.Controls.Add(Me.TxAbonado)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(694, 86)
        Me.Panel3.TabIndex = 0
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.MistyRose
        Me.Panel8.Controls.Add(Me.Label21)
        Me.Panel8.Location = New System.Drawing.Point(533, 7)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(230, 65)
        Me.Panel8.TabIndex = 15
        Me.Panel8.Visible = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(19, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(191, 20)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "El usuario tiene otras deudas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(200, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "NIT/CID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(431, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Calle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(431, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Zona"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(431, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Cuenta"
        '
        'CkLey1886
        '
        Me.CkLey1886.AutoSize = True
        Me.CkLey1886.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkLey1886.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkLey1886.Location = New System.Drawing.Point(347, 58)
        Me.CkLey1886.Name = "CkLey1886"
        Me.CkLey1886.Size = New System.Drawing.Size(78, 17)
        Me.CkLey1886.TabIndex = 10
        Me.CkLey1886.Text = "Ley 1886"
        Me.CkLey1886.UseVisualStyleBackColor = True
        '
        'TxCalle
        '
        Me.TxCalle.Location = New System.Drawing.Point(494, 55)
        Me.TxCalle.Name = "TxCalle"
        Me.TxCalle.Size = New System.Drawing.Size(161, 20)
        Me.TxCalle.TabIndex = 9
        '
        'TxZona
        '
        Me.TxZona.Location = New System.Drawing.Point(494, 30)
        Me.TxZona.Name = "TxZona"
        Me.TxZona.Size = New System.Drawing.Size(161, 20)
        Me.TxZona.TabIndex = 8
        '
        'TxCuenta
        '
        Me.TxCuenta.Location = New System.Drawing.Point(494, 4)
        Me.TxCuenta.Name = "TxCuenta"
        Me.TxCuenta.Size = New System.Drawing.Size(162, 20)
        Me.TxCuenta.TabIndex = 7
        '
        'TxNIT
        '
        Me.TxNIT.Location = New System.Drawing.Point(261, 4)
        Me.TxNIT.Name = "TxNIT"
        Me.TxNIT.Size = New System.Drawing.Size(164, 20)
        Me.TxNIT.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Abonado"
        '
        'TxCategoria
        '
        Me.TxCategoria.Location = New System.Drawing.Point(94, 55)
        Me.TxCategoria.Name = "TxCategoria"
        Me.TxCategoria.Size = New System.Drawing.Size(236, 20)
        Me.TxCategoria.TabIndex = 2
        '
        'TxUsuario
        '
        Me.TxUsuario.Location = New System.Drawing.Point(94, 29)
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.Size = New System.Drawing.Size(332, 20)
        Me.TxUsuario.TabIndex = 1
        '
        'TxAbonado
        '
        Me.TxAbonado.Location = New System.Drawing.Point(94, 3)
        Me.TxAbonado.Name = "TxAbonado"
        Me.TxAbonado.Size = New System.Drawing.Size(100, 20)
        Me.TxAbonado.TabIndex = 0
        '
        'Imp
        '
        '
        'Prev
        '
        Me.Prev.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.Prev.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.Prev.ClientSize = New System.Drawing.Size(400, 300)
        Me.Prev.Enabled = True
        Me.Prev.Icon = CType(resources.GetObject("Prev.Icon"), System.Drawing.Icon)
        Me.Prev.Name = "Prev"
        Me.Prev.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 400
        '
        'gbCategoria
        '
        Me.gbCategoria.Controls.Add(Me.Label20)
        Me.gbCategoria.Controls.Add(Me.cbo_Categoria)
        Me.gbCategoria.Location = New System.Drawing.Point(28, 15)
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
        Me.cbo_Categoria.FormattingEnabled = True
        Me.cbo_Categoria.Location = New System.Drawing.Point(134, 56)
        Me.cbo_Categoria.Name = "cbo_Categoria"
        Me.cbo_Categoria.Size = New System.Drawing.Size(437, 21)
        Me.cbo_Categoria.TabIndex = 0
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
        Me.gbDireccion.Location = New System.Drawing.Point(24, 260)
        Me.gbDireccion.Name = "gbDireccion"
        Me.gbDireccion.Size = New System.Drawing.Size(586, 137)
        Me.gbDireccion.TabIndex = 13
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
        'Frm_Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnSalir
        Me.ClientSize = New System.Drawing.Size(708, 537)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Frm_Facturacion"
        Me.Text = "Facturación"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgDeuB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDeuA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DgHisto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.gbCambioNombre.ResumeLayout(False)
        Me.gbCambioNombre.PerformLayout()
        CType(Me.dgOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.gbCategoria.ResumeLayout(False)
        Me.gbCategoria.PerformLayout()
        Me.gbDireccion.ResumeLayout(False)
        Me.gbDireccion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents TxNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents BtnNuevaBusqueda As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TxUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxAbonado As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CkLey1886 As System.Windows.Forms.CheckBox
    Friend WithEvents TxCalle As System.Windows.Forms.TextBox
    Friend WithEvents TxZona As System.Windows.Forms.TextBox
    Friend WithEvents TxCuenta As System.Windows.Forms.TextBox
    Friend WithEvents TxNIT As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents BtnImpDeudas As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rdConRecargos As System.Windows.Forms.RadioButton
    Friend WithEvents rdRecargosAntes As System.Windows.Forms.RadioButton
    Friend WithEvents rdSinRecargos As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnImprimeHistorico As System.Windows.Forms.Button
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents btnAnularOrden As System.Windows.Forms.Button
    Friend WithEvents BtnNuevaOrden As System.Windows.Forms.Button
    Friend WithEvents dgDeuB As System.Windows.Forms.DataGrid
    Friend WithEvents dgDeuA As System.Windows.Forms.DataGrid
    Friend WithEvents DgHisto As System.Windows.Forms.DataGrid
    Friend WithEvents dgOrdenes As System.Windows.Forms.DataGrid
    Friend WithEvents BtnImprimirOrden As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelarOrden As System.Windows.Forms.Button
    Friend WithEvents BtnGrabarOrden As System.Windows.Forms.Button
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents cboServicios As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbCambioNombre As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Nit As System.Windows.Forms.TextBox
    Friend WithEvents dt_Nacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_NoDoc As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Doc As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Imp As System.Drawing.Printing.PrintDocument
    Friend WithEvents Prev As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents chkRep As System.Windows.Forms.CheckBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents gbCategoria As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbo_Categoria As System.Windows.Forms.ComboBox
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

End Class
