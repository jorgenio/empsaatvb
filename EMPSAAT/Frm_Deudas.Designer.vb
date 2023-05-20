<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Deudas
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
        Dim Imp As System.Drawing.Printing.PrintDocument
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Deudas))
        Me.dgDeuB = New System.Windows.Forms.DataGrid()
        Me.dgDeuA = New System.Windows.Forms.DataGrid()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rdRecargosAntes = New System.Windows.Forms.RadioButton()
        Me.rdSinRecargos = New System.Windows.Forms.RadioButton()
        Me.rdConRecargos = New System.Windows.Forms.RadioButton()
        Me.BtnImpDeudas = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxCliente = New System.Windows.Forms.TextBox()
        Me.cboAbonado = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNoRuta = New System.Windows.Forms.TextBox()
        Me.txtSubRuta = New System.Windows.Forms.TextBox()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CkLey1886 = New System.Windows.Forms.CheckBox()
        Me.TxCalle = New System.Windows.Forms.TextBox()
        Me.TxZona = New System.Windows.Forms.TextBox()
        Me.TxCuenta = New System.Windows.Forms.TextBox()
        Me.TxNIT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxCategoria = New System.Windows.Forms.TextBox()
        Me.TxUsuario = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFactServicios = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.VerFac = New System.Windows.Forms.PrintPreviewDialog()
        Me.dgServicios = New System.Windows.Forms.DataGridView()
        Me.dgDeuda = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTotalDeuda = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOtrosServicios = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalPagado = New System.Windows.Forms.TextBox()
        Me.txtTotalAgua = New System.Windows.Forms.TextBox()
        Me.ImpMat = New System.Drawing.Printing.PrintDocument()
        Me.VerFacMat = New System.Windows.Forms.PrintPreviewDialog()
        Me.ImpFac10002514 = New System.Drawing.Printing.PrintDocument()
        Me.ImpFactMedia = New System.Drawing.Printing.PrintDocument()
        Me.ImpFactMatMed = New System.Drawing.Printing.PrintDocument()
        Imp = New System.Drawing.Printing.PrintDocument()
        CType(Me.dgDeuB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDeuA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDeuda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.TxCliente)
        Me.Panel3.Controls.Add(Me.cboAbonado)
        Me.Panel3.Controls.Add(Me.Label11)
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
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.TxCategoria)
        Me.Panel3.Controls.Add(Me.TxUsuario)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(706, 103)
        Me.Panel3.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(432, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Cliente"
        '
        'TxCliente
        '
        Me.TxCliente.Location = New System.Drawing.Point(494, 9)
        Me.TxCliente.Name = "TxCliente"
        Me.TxCliente.ReadOnly = True
        Me.TxCliente.Size = New System.Drawing.Size(194, 20)
        Me.TxCliente.TabIndex = 19
        '
        'cboAbonado
        '
        Me.cboAbonado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAbonado.FormattingEnabled = True
        Me.cboAbonado.Location = New System.Drawing.Point(94, 38)
        Me.cboAbonado.Name = "cboAbonado"
        Me.cboAbonado.Size = New System.Drawing.Size(121, 21)
        Me.cboAbonado.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(221, 41)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Nit"
        '
        'txtNoRuta
        '
        Me.txtNoRuta.Location = New System.Drawing.Point(639, 72)
        Me.txtNoRuta.Name = "txtNoRuta"
        Me.txtNoRuta.ReadOnly = True
        Me.txtNoRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtNoRuta.TabIndex = 16
        '
        'txtSubRuta
        '
        Me.txtSubRuta.Location = New System.Drawing.Point(639, 51)
        Me.txtSubRuta.Name = "txtSubRuta"
        Me.txtSubRuta.ReadOnly = True
        Me.txtSubRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtSubRuta.TabIndex = 15
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(639, 30)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtRuta.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(432, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Calle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(432, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Zona"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(432, 33)
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
        Me.CkLey1886.Location = New System.Drawing.Point(347, 69)
        Me.CkLey1886.Name = "CkLey1886"
        Me.CkLey1886.Size = New System.Drawing.Size(78, 17)
        Me.CkLey1886.TabIndex = 10
        Me.CkLey1886.Text = "Ley 1886"
        Me.CkLey1886.UseVisualStyleBackColor = True
        '
        'TxCalle
        '
        Me.TxCalle.Location = New System.Drawing.Point(495, 73)
        Me.TxCalle.Name = "TxCalle"
        Me.TxCalle.ReadOnly = True
        Me.TxCalle.Size = New System.Drawing.Size(138, 20)
        Me.TxCalle.TabIndex = 9
        '
        'TxZona
        '
        Me.TxZona.Location = New System.Drawing.Point(495, 51)
        Me.TxZona.Name = "TxZona"
        Me.TxZona.ReadOnly = True
        Me.TxZona.Size = New System.Drawing.Size(138, 20)
        Me.TxZona.TabIndex = 8
        '
        'TxCuenta
        '
        Me.TxCuenta.Location = New System.Drawing.Point(495, 30)
        Me.TxCuenta.Name = "TxCuenta"
        Me.TxCuenta.ReadOnly = True
        Me.TxCuenta.Size = New System.Drawing.Size(138, 20)
        Me.TxCuenta.TabIndex = 7
        '
        'TxNIT
        '
        Me.TxNIT.Location = New System.Drawing.Point(261, 38)
        Me.TxNIT.Name = "TxNIT"
        Me.TxNIT.ReadOnly = True
        Me.TxNIT.Size = New System.Drawing.Size(164, 20)
        Me.TxNIT.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Abonado"
        '
        'TxCategoria
        '
        Me.TxCategoria.Location = New System.Drawing.Point(94, 67)
        Me.TxCategoria.Name = "TxCategoria"
        Me.TxCategoria.ReadOnly = True
        Me.TxCategoria.Size = New System.Drawing.Size(247, 20)
        Me.TxCategoria.TabIndex = 2
        '
        'TxUsuario
        '
        Me.TxUsuario.Location = New System.Drawing.Point(93, 7)
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.ReadOnly = True
        Me.TxUsuario.Size = New System.Drawing.Size(332, 20)
        Me.TxUsuario.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 103)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(117, 301)
        Me.Panel1.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.btnFactServicios)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(117, 256)
        Me.Panel5.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Imprimir Kardex"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnFactServicios
        '
        Me.btnFactServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnFactServicios.Location = New System.Drawing.Point(3, 50)
        Me.btnFactServicios.Name = "btnFactServicios"
        Me.btnFactServicios.Size = New System.Drawing.Size(104, 41)
        Me.btnFactServicios.TabIndex = 0
        Me.btnFactServicios.Text = "Facturar Servicios"
        Me.btnFactServicios.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.Location = New System.Drawing.Point(0, 256)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(113, 41)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Imp
        '
        AddHandler Imp.PrintPage, AddressOf Me.Imp_PrintPage
        '
        'VerFac
        '
        Me.VerFac.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.VerFac.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.VerFac.ClientSize = New System.Drawing.Size(400, 300)
        Me.VerFac.Document = Imp
        Me.VerFac.Enabled = True
        Me.VerFac.Icon = CType(resources.GetObject("VerFac.Icon"), System.Drawing.Icon)
        Me.VerFac.Name = "VerFac"
        Me.VerFac.Visible = False
        '
        'dgServicios
        '
        Me.dgServicios.AllowUserToAddRows = False
        Me.dgServicios.AllowUserToDeleteRows = False
        Me.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServicios.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgServicios.Location = New System.Drawing.Point(117, 103)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.ReadOnly = True
        Me.dgServicios.Size = New System.Drawing.Size(589, 83)
        Me.dgServicios.TabIndex = 8
        '
        'dgDeuda
        '
        Me.dgDeuda.AllowUserToAddRows = False
        Me.dgDeuda.AllowUserToDeleteRows = False
        Me.dgDeuda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgDeuda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDeuda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDeuda.Location = New System.Drawing.Point(117, 186)
        Me.dgDeuda.MultiSelect = False
        Me.dgDeuda.Name = "dgDeuda"
        Me.dgDeuda.ReadOnly = True
        Me.dgDeuda.Size = New System.Drawing.Size(589, 163)
        Me.dgDeuda.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtTotalDeuda)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtOtrosServicios)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtTotalPagado)
        Me.Panel2.Controls.Add(Me.txtTotalAgua)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(117, 349)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(589, 55)
        Me.Panel2.TabIndex = 10
        '
        'txtTotalDeuda
        '
        Me.txtTotalDeuda.Location = New System.Drawing.Point(461, 7)
        Me.txtTotalDeuda.Name = "txtTotalDeuda"
        Me.txtTotalDeuda.ReadOnly = True
        Me.txtTotalDeuda.Size = New System.Drawing.Size(112, 20)
        Me.txtTotalDeuda.TabIndex = 7
        Me.txtTotalDeuda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(366, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Deuda Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 16)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Total Deuda Otros Servicios"
        '
        'txtOtrosServicios
        '
        Me.txtOtrosServicios.Location = New System.Drawing.Point(173, 29)
        Me.txtOtrosServicios.Name = "txtOtrosServicios"
        Me.txtOtrosServicios.ReadOnly = True
        Me.txtOtrosServicios.Size = New System.Drawing.Size(112, 20)
        Me.txtOtrosServicios.TabIndex = 4
        Me.txtOtrosServicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(366, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Total Facturado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Deuda Agua Potable"
        '
        'txtTotalPagado
        '
        Me.txtTotalPagado.Location = New System.Drawing.Point(461, 32)
        Me.txtTotalPagado.Name = "txtTotalPagado"
        Me.txtTotalPagado.ReadOnly = True
        Me.txtTotalPagado.Size = New System.Drawing.Size(112, 20)
        Me.txtTotalPagado.TabIndex = 1
        Me.txtTotalPagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalAgua
        '
        Me.txtTotalAgua.Location = New System.Drawing.Point(173, 6)
        Me.txtTotalAgua.Name = "txtTotalAgua"
        Me.txtTotalAgua.ReadOnly = True
        Me.txtTotalAgua.Size = New System.Drawing.Size(112, 20)
        Me.txtTotalAgua.TabIndex = 0
        Me.txtTotalAgua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ImpMat
        '
        '
        'VerFacMat
        '
        Me.VerFacMat.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.VerFacMat.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.VerFacMat.ClientSize = New System.Drawing.Size(400, 300)
        Me.VerFacMat.Document = Me.ImpMat
        Me.VerFacMat.Enabled = True
        Me.VerFacMat.Icon = CType(resources.GetObject("VerFacMat.Icon"), System.Drawing.Icon)
        Me.VerFacMat.Name = "VerFacMat"
        Me.VerFacMat.Visible = False
        '
        'ImpFac10002514
        '
        '
        'ImpFactMedia
        '
        '
        'ImpFactMatMed
        '
        '
        'Frm_Deudas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 404)
        Me.Controls.Add(Me.dgDeuda)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgServicios)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Frm_Deudas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deudas"
        CType(Me.dgDeuB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDeuA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDeuda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgDeuB As System.Windows.Forms.DataGrid
    Friend WithEvents dgDeuA As System.Windows.Forms.DataGrid
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rdRecargosAntes As System.Windows.Forms.RadioButton
    Friend WithEvents rdSinRecargos As System.Windows.Forms.RadioButton
    Friend WithEvents rdConRecargos As System.Windows.Forms.RadioButton
    Friend WithEvents BtnImpDeudas As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxCategoria As System.Windows.Forms.TextBox
    Friend WithEvents TxUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VerFac As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents dgServicios As System.Windows.Forms.DataGridView
    Friend WithEvents dgDeuda As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtTotalPagado As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAgua As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtOtrosServicios As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDeuda As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnFactServicios As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImpMat As System.Drawing.Printing.PrintDocument
    Friend WithEvents VerFacMat As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents txtNoRuta As System.Windows.Forms.TextBox
    Friend WithEvents txtSubRuta As System.Windows.Forms.TextBox
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboAbonado As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxCliente As System.Windows.Forms.TextBox
    Friend WithEvents ImpFac10002514 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ImpFactMedia As System.Drawing.Printing.PrintDocument
    Friend WithEvents ImpFactMatMed As System.Drawing.Printing.PrintDocument
End Class
