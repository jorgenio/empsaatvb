<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ProformasReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ProformasReporte))
        Me.cboPeriodo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.BtnProcesar = New System.Windows.Forms.Button
        Me.Progreso = New System.Windows.Forms.ProgressBar
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Doc = New System.Drawing.Printing.PrintDocument
        Me.VerDoc = New System.Windows.Forms.PrintPreviewDialog
        Me.cboEmpresa = New System.Windows.Forms.ComboBox
        Me.chkEmpresa = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'cboPeriodo
        '
        Me.cboPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodo.FormattingEnabled = True
        Me.cboPeriodo.Location = New System.Drawing.Point(153, 78)
        Me.cboPeriodo.Name = "cboPeriodo"
        Me.cboPeriodo.Size = New System.Drawing.Size(182, 21)
        Me.cboPeriodo.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Periodo"
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
        Me.BtnProcesar.Text = "Procesar"
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
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(21, 312)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(107, 48)
        Me.btnImprimir.TabIndex = 32
        Me.btnImprimir.Text = "Imprimir"
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
        Me.VerDoc.Document = Me.Doc
        Me.VerDoc.Enabled = True
        Me.VerDoc.Icon = CType(resources.GetObject("VerDoc.Icon"), System.Drawing.Icon)
        Me.VerDoc.Name = "VerDoc"
        Me.VerDoc.Visible = False
        '
        'cboEmpresa
        '
        Me.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEmpresa.FormattingEnabled = True
        Me.cboEmpresa.Location = New System.Drawing.Point(21, 155)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(314, 21)
        Me.cboEmpresa.TabIndex = 33
        '
        'chkEmpresa
        '
        Me.chkEmpresa.AutoSize = True
        Me.chkEmpresa.Location = New System.Drawing.Point(21, 132)
        Me.chkEmpresa.Name = "chkEmpresa"
        Me.chkEmpresa.Size = New System.Drawing.Size(67, 17)
        Me.chkEmpresa.TabIndex = 34
        Me.chkEmpresa.Text = "Empresa"
        Me.chkEmpresa.UseVisualStyleBackColor = True
        '
        'Frm_ProformasReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 368)
        Me.Controls.Add(Me.chkEmpresa)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.cboPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.Progreso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_ProformasReporte"
        Me.Text = "Reporte Proformas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents VerDoc As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents cboEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents chkEmpresa As System.Windows.Forms.CheckBox
End Class
