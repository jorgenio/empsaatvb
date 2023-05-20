<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CuentasXcobrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_CuentasXcobrar))
        Me.Lista = New System.Windows.Forms.CheckedListBox
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.Progreso = New System.Windows.Forms.ProgressBar
        Me.ImpDetalle = New System.Windows.Forms.Button
        Me.Fecha = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnImpResumen = New System.Windows.Forms.Button
        Me.btnImprimirResumen = New System.Windows.Forms.Button
        Me.DocR = New System.Drawing.Printing.PrintDocument
        Me.VerDoc = New System.Windows.Forms.PrintPreviewDialog
        Me.DocD = New System.Drawing.Printing.PrintDocument
        Me.btnImprimirDetalle = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(19, 44)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(315, 199)
        Me.Lista.TabIndex = 11
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(230, 303)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 56)
        Me.BtnSalir.TabIndex = 9
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Progreso
        '
        Me.Progreso.Location = New System.Drawing.Point(19, 262)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(315, 23)
        Me.Progreso.TabIndex = 7
        Me.Progreso.Visible = False
        '
        'ImpDetalle
        '
        Me.ImpDetalle.Location = New System.Drawing.Point(123, 303)
        Me.ImpDetalle.Name = "ImpDetalle"
        Me.ImpDetalle.Size = New System.Drawing.Size(92, 57)
        Me.ImpDetalle.TabIndex = 13
        Me.ImpDetalle.Text = "Imp. Detalle"
        Me.ImpDetalle.UseVisualStyleBackColor = True
        '
        'Fecha
        '
        Me.Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha.Location = New System.Drawing.Point(156, 13)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(139, 20)
        Me.Fecha.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "A la fecha de..."
        '
        'btnImpResumen
        '
        Me.btnImpResumen.Location = New System.Drawing.Point(12, 303)
        Me.btnImpResumen.Name = "btnImpResumen"
        Me.btnImpResumen.Size = New System.Drawing.Size(91, 56)
        Me.btnImpResumen.TabIndex = 16
        Me.btnImpResumen.Text = "Imp. Resumen"
        Me.btnImpResumen.UseVisualStyleBackColor = True
        '
        'btnImprimirResumen
        '
        Me.btnImprimirResumen.Location = New System.Drawing.Point(12, 303)
        Me.btnImprimirResumen.Name = "btnImprimirResumen"
        Me.btnImprimirResumen.Size = New System.Drawing.Size(91, 56)
        Me.btnImprimirResumen.TabIndex = 17
        Me.btnImprimirResumen.Text = "Imp. Resumen"
        Me.btnImprimirResumen.UseVisualStyleBackColor = True
        '
        'DocR
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
        'DocD
        '
        '
        'btnImprimirDetalle
        '
        Me.btnImprimirDetalle.Location = New System.Drawing.Point(123, 303)
        Me.btnImprimirDetalle.Name = "btnImprimirDetalle"
        Me.btnImprimirDetalle.Size = New System.Drawing.Size(92, 57)
        Me.btnImprimirDetalle.TabIndex = 18
        Me.btnImprimirDetalle.Text = "Imp. Detalle"
        Me.btnImprimirDetalle.UseVisualStyleBackColor = True
        '
        'Frm_CuentasXcobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 372)
        Me.Controls.Add(Me.btnImprimirDetalle)
        Me.Controls.Add(Me.btnImprimirResumen)
        Me.Controls.Add(Me.btnImpResumen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.ImpDetalle)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Progreso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_CuentasXcobrar"
        Me.Text = "Cuentas X cobrar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lista As System.Windows.Forms.CheckedListBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents ImpDetalle As System.Windows.Forms.Button
    Friend WithEvents Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImpResumen As System.Windows.Forms.Button
    Friend WithEvents btnImprimirResumen As System.Windows.Forms.Button
    Friend WithEvents DocR As System.Drawing.Printing.PrintDocument
    Friend WithEvents VerDoc As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents DocD As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnImprimirDetalle As System.Windows.Forms.Button
End Class
