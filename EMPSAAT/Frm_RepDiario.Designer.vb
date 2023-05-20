<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RepDiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_RepDiario))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnOtrasVentas = New System.Windows.Forms.Button()
        Me.btnVerFacturas = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.btnCrearComprobante = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFecha = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPunto = New System.Windows.Forms.ComboBox()
        Me.VerDoc = New System.Windows.Forms.PrintPreviewDialog()
        Me.Doc = New System.Drawing.Printing.PrintDocument()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnOtrasVentas)
        Me.Panel2.Controls.Add(Me.btnVerFacturas)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 248)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(334, 64)
        Me.Panel2.TabIndex = 5
        '
        'btnOtrasVentas
        '
        Me.btnOtrasVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOtrasVentas.Location = New System.Drawing.Point(118, 4)
        Me.btnOtrasVentas.Name = "btnOtrasVentas"
        Me.btnOtrasVentas.Size = New System.Drawing.Size(90, 50)
        Me.btnOtrasVentas.TabIndex = 8
        Me.btnOtrasVentas.Text = "Otras Ventas"
        Me.btnOtrasVentas.UseVisualStyleBackColor = True
        '
        'btnVerFacturas
        '
        Me.btnVerFacturas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerFacturas.Location = New System.Drawing.Point(10, 4)
        Me.btnVerFacturas.Name = "btnVerFacturas"
        Me.btnVerFacturas.Size = New System.Drawing.Size(90, 50)
        Me.btnVerFacturas.TabIndex = 3
        Me.btnVerFacturas.Text = "Mensualidades"
        Me.btnVerFacturas.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Location = New System.Drawing.Point(230, 4)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(90, 50)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "&Cerrar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'btnCrearComprobante
        '
        Me.btnCrearComprobante.Enabled = False
        Me.btnCrearComprobante.Location = New System.Drawing.Point(149, 152)
        Me.btnCrearComprobante.Name = "btnCrearComprobante"
        Me.btnCrearComprobante.Size = New System.Drawing.Size(124, 26)
        Me.btnCrearComprobante.TabIndex = 7
        Me.btnCrearComprobante.Text = "Crear Comprobante"
        Me.btnCrearComprobante.UseVisualStyleBackColor = True
        Me.btnCrearComprobante.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cboPunto)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.cboFecha)
        Me.Panel3.Controls.Add(Me.btnCrearComprobante)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(334, 248)
        Me.Panel3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "FECHA:"
        '
        'cboFecha
        '
        Me.cboFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFecha.FormattingEnabled = True
        Me.cboFecha.Location = New System.Drawing.Point(66, 125)
        Me.cboFecha.Name = "cboFecha"
        Me.cboFecha.Size = New System.Drawing.Size(159, 21)
        Me.cboFecha.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "PUNTO"
        '
        'cboPunto
        '
        Me.cboPunto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPunto.FormattingEnabled = True
        Me.cboPunto.Location = New System.Drawing.Point(66, 81)
        Me.cboPunto.Name = "cboPunto"
        Me.cboPunto.Size = New System.Drawing.Size(257, 21)
        Me.cboPunto.TabIndex = 10
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
        'Doc
        '
        '
        'Frm_RepDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_RepDiario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Diario"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnVerFacturas As System.Windows.Forms.Button
    Friend WithEvents btnCrearComprobante As System.Windows.Forms.Button
    Friend WithEvents btnOtrasVentas As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboFecha As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPunto As System.Windows.Forms.ComboBox
    Friend WithEvents VerDoc As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Doc As System.Drawing.Printing.PrintDocument
End Class
