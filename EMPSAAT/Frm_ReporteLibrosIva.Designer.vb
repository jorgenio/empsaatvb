<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReporteLibrosIva
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lista = New System.Windows.Forms.CheckedListBox()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnProcesar = New System.Windows.Forms.Button()
        Me.Progreso = New System.Windows.Forms.ProgressBar()
        Me.sfArchivos = New System.Windows.Forms.SaveFileDialog()
        Me.dtInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCorregir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 48)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(20, 90)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(315, 154)
        Me.Lista.TabIndex = 27
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(231, 312)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 48)
        Me.BtnSalir.TabIndex = 26
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Location = New System.Drawing.Point(20, 312)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(107, 48)
        Me.BtnProcesar.TabIndex = 25
        Me.BtnProcesar.Text = "Exportar"
        Me.BtnProcesar.UseVisualStyleBackColor = True
        '
        'Progreso
        '
        Me.Progreso.Location = New System.Drawing.Point(20, 263)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(315, 23)
        Me.Progreso.TabIndex = 24
        Me.Progreso.Visible = False
        '
        'dtInicial
        '
        Me.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicial.Location = New System.Drawing.Point(155, 19)
        Me.dtInicial.Name = "dtInicial"
        Me.dtInicial.Size = New System.Drawing.Size(123, 20)
        Me.dtInicial.TabIndex = 31
        '
        'dtFinal
        '
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFinal.Location = New System.Drawing.Point(155, 45)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(123, 20)
        Me.dtFinal.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Desde fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(76, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Hasta Fecha"
        '
        'btnCorregir
        '
        Me.btnCorregir.Location = New System.Drawing.Point(20, 292)
        Me.btnCorregir.Name = "btnCorregir"
        Me.btnCorregir.Size = New System.Drawing.Size(107, 20)
        Me.btnCorregir.TabIndex = 35
        Me.btnCorregir.Text = "Corregir Libro Iva"
        Me.btnCorregir.UseVisualStyleBackColor = True
        '
        'Frm_ReporteLibrosIva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 374)
        Me.Controls.Add(Me.btnCorregir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtFinal)
        Me.Controls.Add(Me.dtInicial)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.Progreso)
        Me.Name = "Frm_ReporteLibrosIva"
        Me.Text = "Reporte Libros IVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Lista As System.Windows.Forms.CheckedListBox
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents sfArchivos As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dtInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCorregir As System.Windows.Forms.Button
End Class
