<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Historico
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
        Me.dgFacturas = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnCorregirLectura = New System.Windows.Forms.Button()
        Me.BtnImprimirOrden = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevaOrden = New System.Windows.Forms.Button()
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
        Me.btnCorregir = New System.Windows.Forms.Button()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgFacturas
        '
        Me.dgFacturas.AllowUserToAddRows = False
        Me.dgFacturas.AllowUserToDeleteRows = False
        Me.dgFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFacturas.Location = New System.Drawing.Point(131, 100)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.ReadOnly = True
        Me.dgFacturas.Size = New System.Drawing.Size(603, 312)
        Me.dgFacturas.TabIndex = 7
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel6.Controls.Add(Me.btnCorregirLectura)
        Me.Panel6.Controls.Add(Me.BtnImprimirOrden)
        Me.Panel6.Controls.Add(Me.btnSalir)
        Me.Panel6.Controls.Add(Me.BtnNuevaOrden)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 100)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(131, 312)
        Me.Panel6.TabIndex = 6
        '
        'btnCorregirLectura
        '
        Me.btnCorregirLectura.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCorregirLectura.Location = New System.Drawing.Point(0, 82)
        Me.btnCorregirLectura.Name = "btnCorregirLectura"
        Me.btnCorregirLectura.Size = New System.Drawing.Size(127, 41)
        Me.btnCorregirLectura.TabIndex = 3
        Me.btnCorregirLectura.Text = "Corregir Lectura"
        Me.btnCorregirLectura.UseVisualStyleBackColor = True
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
        Me.btnSalir.Location = New System.Drawing.Point(0, 267)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnCorregir)
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
        Me.Panel3.Size = New System.Drawing.Size(734, 100)
        Me.Panel3.TabIndex = 5
        '
        'cboAbonado
        '
        Me.cboAbonado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAbonado.FormattingEnabled = True
        Me.cboAbonado.Location = New System.Drawing.Point(119, 32)
        Me.cboAbonado.Name = "cboAbonado"
        Me.cboAbonado.Size = New System.Drawing.Size(100, 21)
        Me.cboAbonado.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(458, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Cliente"
        '
        'TxCliente
        '
        Me.TxCliente.Location = New System.Drawing.Point(506, 6)
        Me.TxCliente.Name = "TxCliente"
        Me.TxCliente.ReadOnly = True
        Me.TxCliente.Size = New System.Drawing.Size(215, 20)
        Me.TxCliente.TabIndex = 23
        '
        'txtNoRuta
        '
        Me.txtNoRuta.Location = New System.Drawing.Point(672, 69)
        Me.txtNoRuta.Name = "txtNoRuta"
        Me.txtNoRuta.ReadOnly = True
        Me.txtNoRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtNoRuta.TabIndex = 22
        '
        'txtSubRuta
        '
        Me.txtSubRuta.Location = New System.Drawing.Point(672, 48)
        Me.txtSubRuta.Name = "txtSubRuta"
        Me.txtSubRuta.ReadOnly = True
        Me.txtSubRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtSubRuta.TabIndex = 21
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(672, 27)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(49, 20)
        Me.txtRuta.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(225, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "NIT/CID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(457, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Calle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(457, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Zona"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(457, 31)
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
        Me.CkLey1886.Location = New System.Drawing.Point(373, 61)
        Me.CkLey1886.Name = "CkLey1886"
        Me.CkLey1886.Size = New System.Drawing.Size(78, 17)
        Me.CkLey1886.TabIndex = 10
        Me.CkLey1886.Text = "Ley 1886"
        Me.CkLey1886.UseVisualStyleBackColor = True
        '
        'TxCalle
        '
        Me.TxCalle.Location = New System.Drawing.Point(506, 70)
        Me.TxCalle.Name = "TxCalle"
        Me.TxCalle.ReadOnly = True
        Me.TxCalle.Size = New System.Drawing.Size(161, 20)
        Me.TxCalle.TabIndex = 9
        '
        'TxZona
        '
        Me.TxZona.Location = New System.Drawing.Point(506, 49)
        Me.TxZona.Name = "TxZona"
        Me.TxZona.ReadOnly = True
        Me.TxZona.Size = New System.Drawing.Size(161, 20)
        Me.TxZona.TabIndex = 8
        '
        'TxCuenta
        '
        Me.TxCuenta.Location = New System.Drawing.Point(506, 28)
        Me.TxCuenta.Name = "TxCuenta"
        Me.TxCuenta.ReadOnly = True
        Me.TxCuenta.Size = New System.Drawing.Size(162, 20)
        Me.TxCuenta.TabIndex = 7
        '
        'TxNIT
        '
        Me.TxNIT.Location = New System.Drawing.Point(287, 32)
        Me.TxNIT.Name = "TxNIT"
        Me.TxNIT.ReadOnly = True
        Me.TxNIT.Size = New System.Drawing.Size(164, 20)
        Me.TxNIT.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Categoria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Usuario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Abonado"
        '
        'TxCategoria
        '
        Me.TxCategoria.Location = New System.Drawing.Point(119, 58)
        Me.TxCategoria.Name = "TxCategoria"
        Me.TxCategoria.ReadOnly = True
        Me.TxCategoria.Size = New System.Drawing.Size(236, 20)
        Me.TxCategoria.TabIndex = 2
        '
        'TxUsuario
        '
        Me.TxUsuario.Location = New System.Drawing.Point(119, 6)
        Me.TxUsuario.Name = "TxUsuario"
        Me.TxUsuario.ReadOnly = True
        Me.TxUsuario.Size = New System.Drawing.Size(332, 20)
        Me.TxUsuario.TabIndex = 1
        '
        'btnCorregir
        '
        Me.btnCorregir.Location = New System.Drawing.Point(3, 9)
        Me.btnCorregir.Name = "btnCorregir"
        Me.btnCorregir.Size = New System.Drawing.Size(51, 65)
        Me.btnCorregir.TabIndex = 26
        Me.btnCorregir.Text = "Corregir"
        Me.btnCorregir.UseVisualStyleBackColor = True
        '
        'Frm_Historico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 412)
        Me.Controls.Add(Me.dgFacturas)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Frm_Historico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historico"
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BtnImprimirOrden As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevaOrden As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
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
    Friend WithEvents btnCorregirLectura As System.Windows.Forms.Button
    Friend WithEvents TxCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtNoRuta As System.Windows.Forms.TextBox
    Friend WithEvents txtSubRuta As System.Windows.Forms.TextBox
    Friend WithEvents txtRuta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboAbonado As System.Windows.Forms.ComboBox
    Friend WithEvents btnCorregir As System.Windows.Forms.Button
End Class
