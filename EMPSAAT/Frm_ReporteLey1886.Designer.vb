<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ReporteLey1886
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ReporteLey1886))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnProcesar = New System.Windows.Forms.Button()
        Me.Progreso = New System.Windows.Forms.ProgressBar()
        Me.cboPeriodo = New System.Windows.Forms.ComboBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Doc = New System.Drawing.Printing.PrintDocument()
        Me.VerDoc = New System.Windows.Forms.PrintPreviewDialog()
        Me.btnTxt = New System.Windows.Forms.Button()
        Me.Arch = New System.Windows.Forms.SaveFileDialog()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lista = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Periodo"
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(229, 311)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(104, 48)
        Me.BtnSalir.TabIndex = 18
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Location = New System.Drawing.Point(18, 311)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(107, 48)
        Me.BtnProcesar.TabIndex = 17
        Me.BtnProcesar.Text = "Procesar"
        Me.BtnProcesar.UseVisualStyleBackColor = True
        '
        'Progreso
        '
        Me.Progreso.Location = New System.Drawing.Point(18, 262)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(315, 23)
        Me.Progreso.TabIndex = 16
        Me.Progreso.Visible = False
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(150, 14)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(182, 21)
        Me.cboPeriodo.TabIndex = 23
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(18, 311)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(107, 48)
        Me.btnImprimir.TabIndex = 24
        Me.btnImprimir.Text = "ARCHIVO PDF"
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
        'btnTxt
        '
        Me.btnTxt.Location = New System.Drawing.Point(131, 311)
        Me.btnTxt.Name = "btnTxt"
        Me.btnTxt.Size = New System.Drawing.Size(92, 48)
        Me.btnTxt.TabIndex = 25
        Me.btnTxt.Text = "ARCHIVO TXT"
        Me.btnTxt.UseVisualStyleBackColor = True
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(154, 48)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(177, 20)
        Me.txtOrden.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "No Orden Frm 200"
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(18, 89)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(315, 154)
        Me.Lista.TabIndex = 19
        '
        'Frm_ReporteLey1886
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 372)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.btnTxt)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.Progreso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_ReporteLey1886"
        Me.Text = "Reporte Ley 1886"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents VerDoc As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnTxt As System.Windows.Forms.Button
    Friend WithEvents Arch As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Lista As System.Windows.Forms.CheckedListBox
End Class
