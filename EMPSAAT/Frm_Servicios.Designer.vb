<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Servicios
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Servicios))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboAbonado = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxCliente = New System.Windows.Forms.TextBox()
        Me.txtNoRuta = New System.Windows.Forms.TextBox()
        Me.txtSubRuta = New System.Windows.Forms.TextBox()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnImprimirOrden = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevaOrden = New System.Windows.Forms.Button()
        Me.dgServicios = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Doc = New System.Drawing.Printing.PrintDocument()
        Me.VerDoc = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cboAbonado)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.TxCliente)
        Me.Panel3.Controls.Add(Me.txtNoRuta)
        Me.Panel3.Controls.Add(Me.txtSubRuta)
        Me.Panel3.Controls.Add(Me.txtRuta)
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
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(734, 112)
        Me.Panel3.TabIndex = 1
        '
        'cboAbonado
        '
        Me.cboAbonado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAbonado.FormattingEnabled = True
        Me.cboAbonado.Location = New System.Drawing.Point(93, 39)
        Me.cboAbonado.Name = "cboAbonado"
        Me.cboAbonado.Size = New System.Drawing.Size(100, 21)
        Me.cboAbonado.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(443, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Cliente"
        '
        'TxCliente
        '
        Me.TxCliente.Location = New System.Drawing.Point(504, 13)
        Me.TxCliente.Name = "TxCliente"
        Me.TxCliente.ReadOnly = True
        Me.TxCliente.Size = New System.Drawing.Size(215, 20)
        Me.TxCliente.TabIndex = 43
        '
        'txtNoRuta
        '
        Me.txtNoRuta.Location = New System.Drawing.Point(670, 76)
        Me.txtNoRuta.Name = "txtNoRuta"
        Me.txtNoRuta.ReadOnly = True
        Me.txtNoRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtNoRuta.TabIndex = 42
        '
        'txtSubRuta
        '
        Me.txtSubRuta.Location = New System.Drawing.Point(670, 55)
        Me.txtSubRuta.Name = "txtSubRuta"
        Me.txtSubRuta.ReadOnly = True
        Me.txtSubRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtSubRuta.TabIndex = 41
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(670, 34)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtRuta.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(199, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "NIT/CID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(442, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Calle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(442, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Zona"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(442, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Cuenta"
        '
        'CkLey1886
        '
        Me.CkLey1886.AutoSize = True
        Me.CkLey1886.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CkLey1886.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkLey1886.Location = New System.Drawing.Point(347, 68)
        Me.CkLey1886.Name = "CkLey1886"
        Me.CkLey1886.Size = New System.Drawing.Size(78, 17)
        Me.CkLey1886.TabIndex = 35
        Me.CkLey1886.Text = "Ley 1886"
        Me.CkLey1886.UseVisualStyleBackColor = True
        '
        'TxCalle
        '
        Me.TxCalle.Location = New System.Drawing.Point(504, 77)
        Me.TxCalle.Name = "TxCalle"
        Me.TxCalle.ReadOnly = True
        Me.TxCalle.Size = New System.Drawing.Size(161, 20)
        Me.TxCalle.TabIndex = 34
        '
        'TxZona
        '
        Me.TxZona.Location = New System.Drawing.Point(504, 56)
        Me.TxZona.Name = "TxZona"
        Me.TxZona.ReadOnly = True
        Me.TxZona.Size = New System.Drawing.Size(161, 20)
        Me.TxZona.TabIndex = 33
        '
        'TxCuenta
        '
        Me.TxCuenta.Location = New System.Drawing.Point(504, 35)
        Me.TxCuenta.Name = "TxCuenta"
        Me.TxCuenta.ReadOnly = True
        Me.TxCuenta.Size = New System.Drawing.Size(162, 20)
        Me.TxCuenta.TabIndex = 32
        '
        'TxNIT
        '
        Me.TxNIT.Location = New System.Drawing.Point(261, 39)
        Me.TxNIT.Name = "TxNIT"
        Me.TxNIT.ReadOnly = True
        Me.TxNIT.Size = New System.Drawing.Size(164, 20)
        Me.TxNIT.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Abonado"
        '
        'TxCategoria
        '
        Me.TxCategoria.Location = New System.Drawing.Point(93, 65)
        Me.TxCategoria.Name = "TxCategoria"
        Me.TxCategoria.ReadOnly = True
        Me.TxCategoria.Size = New System.Drawing.Size(236, 20)
        Me.TxCategoria.TabIndex = 27
        '
        'TxUsuario
        '
        Me.TxUsuario.Location = New System.Drawing.Point(93, 13)
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.ReadOnly = True
        Me.TxUsuario.Size = New System.Drawing.Size(332, 20)
        Me.TxUsuario.TabIndex = 26
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.BtnImprimirOrden)
        Me.Panel6.Controls.Add(Me.btnSalir)
        Me.Panel6.Controls.Add(Me.BtnNuevaOrden)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 112)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(131, 300)
        Me.Panel6.TabIndex = 3
        '
        'BtnImprimirOrden
        '
        Me.BtnImprimirOrden.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnImprimirOrden.Location = New System.Drawing.Point(0, 41)
        Me.BtnImprimirOrden.Name = "BtnImprimirOrden"
        Me.BtnImprimirOrden.Size = New System.Drawing.Size(127, 41)
        Me.BtnImprimirOrden.TabIndex = 2
        Me.BtnImprimirOrden.Text = "Imprimir"
        Me.BtnImprimirOrden.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.Location = New System.Drawing.Point(0, 255)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(127, 41)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
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
        'dgServicios
        '
        Me.dgServicios.AllowUserToAddRows = False
        Me.dgServicios.AllowUserToDeleteRows = False
        Me.dgServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServicios.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgServicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgServicios.Location = New System.Drawing.Point(131, 112)
        Me.dgServicios.Name = "dgServicios"
        Me.dgServicios.ReadOnly = True
        Me.dgServicios.Size = New System.Drawing.Size(603, 300)
        Me.dgServicios.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnularToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 26)
        '
        'AnularToolStripMenuItem
        '
        Me.AnularToolStripMenuItem.Name = "AnularToolStripMenuItem"
        Me.AnularToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AnularToolStripMenuItem.Text = "Quitar Importe"
        '
        'Doc
        '
        '
        'VerDoc
        '
        Me.VerDoc.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.VerDoc.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.VerDoc.ClientSize = New System.Drawing.Size(400, 300)
        Me.VerDoc.Enabled = True
        Me.VerDoc.Icon = CType(resources.GetObject("VerDoc.Icon"), System.Drawing.Icon)
        Me.VerDoc.Name = "VerDoc"
        Me.VerDoc.Visible = False
        '
        'Frm_Servicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 412)
        Me.Controls.Add(Me.dgServicios)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Frm_Servicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.dgServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BtnImprimirOrden As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevaOrden As System.Windows.Forms.Button
    Friend WithEvents dgServicios As System.Windows.Forms.DataGridView
    Friend WithEvents cboAbonado As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtNoRuta As System.Windows.Forms.TextBox
    Friend WithEvents txtSubRuta As System.Windows.Forms.TextBox
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
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
    Friend WithEvents Doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents VerDoc As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AnularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
