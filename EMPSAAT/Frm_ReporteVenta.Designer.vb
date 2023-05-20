<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReporteVenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ReporteVenta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lista = New System.Windows.Forms.CheckedListBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Progreso = New System.Windows.Forms.ProgressBar()
        Me.CboPeriodo = New System.Windows.Forms.ComboBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Doc = New System.Drawing.Printing.PrintDocument()
        Me.VerDoc = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.btnDescuento = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Periodo"
        Me.Label1.Visible = False
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(18, 44)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(315, 199)
        Me.Lista.TabIndex = 19
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(252, 311)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(80, 48)
        Me.BtnSalir.TabIndex = 18
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Progreso
        '
        Me.Progreso.Location = New System.Drawing.Point(18, 262)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(315, 23)
        Me.Progreso.TabIndex = 16
        Me.Progreso.Visible = False
        '
        'CboPeriodo
        '
        Me.CboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboPeriodo.FormattingEnabled = True
        Me.CboPeriodo.Location = New System.Drawing.Point(154, 12)
        Me.CboPeriodo.Name = "CboPeriodo"
        Me.CboPeriodo.Size = New System.Drawing.Size(179, 21)
        Me.CboPeriodo.TabIndex = 23
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(12, 311)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(80, 48)
        Me.btnImprimir.TabIndex = 24
        Me.btnImprimir.Text = "Resumen"
        Me.btnImprimir.UseVisualStyleBackColor = True
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
        'btnDetalle
        '
        Me.btnDetalle.Location = New System.Drawing.Point(92, 311)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(80, 48)
        Me.btnDetalle.TabIndex = 25
        Me.btnDetalle.Text = "Detalle"
        Me.btnDetalle.UseVisualStyleBackColor = True
        '
        'btnDescuento
        '
        Me.btnDescuento.Location = New System.Drawing.Point(172, 311)
        Me.btnDescuento.Name = "btnDescuento"
        Me.btnDescuento.Size = New System.Drawing.Size(80, 48)
        Me.btnDescuento.TabIndex = 26
        Me.btnDescuento.Text = "Descuento"
        Me.btnDescuento.UseVisualStyleBackColor = True
        '
        'Frm_ReporteVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 372)
        Me.Controls.Add(Me.btnDescuento)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.CboPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Progreso)
        Me.Name = "Frm_ReporteVenta"
        Me.Text = "Reporte Venta del Servicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lista As System.Windows.Forms.CheckedListBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents CboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents VerDoc As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents btnDescuento As System.Windows.Forms.Button
End Class
