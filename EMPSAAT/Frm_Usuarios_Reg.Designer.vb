<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Usuarios_Reg
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtNumRuta = New System.Windows.Forms.TextBox
        Me.cboSubRuta = New System.Windows.Forms.ComboBox
        Me.cboRuta = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtNumero = New System.Windows.Forms.TextBox
        Me.CboCalle = New System.Windows.Forms.ComboBox
        Me.CboZona = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtLectura = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.CboCategoria = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtConsFijo = New System.Windows.Forms.TextBox
        Me.CboLiberacion = New System.Windows.Forms.ComboBox
        Me.TxtMedidor = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.BtnGrabar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtAbonado = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtAbonado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 437)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtNumRuta)
        Me.GroupBox2.Controls.Add(Me.cboSubRuta)
        Me.GroupBox2.Controls.Add(Me.cboRuta)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtNumero)
        Me.GroupBox2.Controls.Add(Me.CboCalle)
        Me.GroupBox2.Controls.Add(Me.CboZona)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 149)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(344, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(60, 16)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Num Ruta"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(194, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 16)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "SubRuta"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 16)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Ruta"
        '
        'txtNumRuta
        '
        Me.txtNumRuta.Location = New System.Drawing.Point(410, 18)
        Me.txtNumRuta.Name = "txtNumRuta"
        Me.txtNumRuta.Size = New System.Drawing.Size(65, 20)
        Me.txtNumRuta.TabIndex = 32
        '
        'cboSubRuta
        '
        Me.cboSubRuta.FormattingEnabled = True
        Me.cboSubRuta.Location = New System.Drawing.Point(255, 17)
        Me.cboSubRuta.Name = "cboSubRuta"
        Me.cboSubRuta.Size = New System.Drawing.Size(83, 21)
        Me.cboSubRuta.TabIndex = 31
        '
        'cboRuta
        '
        Me.cboRuta.FormattingEnabled = True
        Me.cboRuta.Location = New System.Drawing.Point(99, 17)
        Me.cboRuta.Name = "cboRuta"
        Me.cboRuta.Size = New System.Drawing.Size(84, 21)
        Me.cboRuta.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Numero"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Calle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Zona"
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(99, 117)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(63, 20)
        Me.TxtNumero.TabIndex = 8
        '
        'CboCalle
        '
        Me.CboCalle.FormattingEnabled = True
        Me.CboCalle.Location = New System.Drawing.Point(99, 87)
        Me.CboCalle.Name = "CboCalle"
        Me.CboCalle.Size = New System.Drawing.Size(376, 21)
        Me.CboCalle.TabIndex = 7
        '
        'CboZona
        '
        Me.CboZona.FormattingEnabled = True
        Me.CboZona.Location = New System.Drawing.Point(99, 55)
        Me.CboZona.Name = "CboZona"
        Me.CboZona.Size = New System.Drawing.Size(376, 21)
        Me.CboZona.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtLectura)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.CboCategoria)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtConsFijo)
        Me.GroupBox1.Controls.Add(Me.CboLiberacion)
        Me.GroupBox1.Controls.Add(Me.TxtMedidor)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 200)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 159)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Consumo Fijo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(286, 90)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Lectura Inicial"
        '
        'txtLectura
        '
        Me.txtLectura.Location = New System.Drawing.Point(375, 89)
        Me.txtLectura.Name = "txtLectura"
        Me.txtLectura.Size = New System.Drawing.Size(100, 20)
        Me.txtLectura.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Categoria"
        '
        'CboCategoria
        '
        Me.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCategoria.FormattingEnabled = True
        Me.CboCategoria.Location = New System.Drawing.Point(101, 124)
        Me.CboCategoria.Name = "CboCategoria"
        Me.CboCategoria.Size = New System.Drawing.Size(374, 21)
        Me.CboCategoria.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Liberacion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "No. Medidor"
        '
        'TxtConsFijo
        '
        Me.TxtConsFijo.Location = New System.Drawing.Point(113, 88)
        Me.TxtConsFijo.Name = "TxtConsFijo"
        Me.TxtConsFijo.Size = New System.Drawing.Size(118, 20)
        Me.TxtConsFijo.TabIndex = 11
        '
        'CboLiberacion
        '
        Me.CboLiberacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboLiberacion.FormattingEnabled = True
        Me.CboLiberacion.Location = New System.Drawing.Point(99, 51)
        Me.CboLiberacion.Name = "CboLiberacion"
        Me.CboLiberacion.Size = New System.Drawing.Size(376, 21)
        Me.CboLiberacion.TabIndex = 10
        '
        'TxtMedidor
        '
        Me.TxtMedidor.Location = New System.Drawing.Point(99, 19)
        Me.TxtMedidor.Name = "TxtMedidor"
        Me.TxtMedidor.Size = New System.Drawing.Size(125, 20)
        Me.TxtMedidor.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Controls.Add(Me.BtnGrabar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 364)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(542, 73)
        Me.Panel2.TabIndex = 36
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(295, 23)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(112, 38)
        Me.BtnCancelar.TabIndex = 13
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Location = New System.Drawing.Point(133, 23)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(113, 38)
        Me.BtnGrabar.TabIndex = 12
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Abonado"
        '
        'TxtAbonado
        '
        Me.TxtAbonado.Location = New System.Drawing.Point(119, 19)
        Me.TxtAbonado.Name = "TxtAbonado"
        Me.TxtAbonado.ReadOnly = True
        Me.TxtAbonado.Size = New System.Drawing.Size(93, 20)
        Me.TxtAbonado.TabIndex = 0
        '
        'Frm_Usuarios_Reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Usuarios_Reg"
        Me.Text = "Registro Usuarios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TxtMedidor As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumero As System.Windows.Forms.TextBox
    Friend WithEvents CboCalle As System.Windows.Forms.ComboBox
    Friend WithEvents CboZona As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAbonado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents TxtConsFijo As System.Windows.Forms.TextBox
    Friend WithEvents CboLiberacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtLectura As System.Windows.Forms.TextBox
    Friend WithEvents txtNumRuta As System.Windows.Forms.TextBox
    Friend WithEvents cboSubRuta As System.Windows.Forms.ComboBox
    Friend WithEvents cboRuta As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
