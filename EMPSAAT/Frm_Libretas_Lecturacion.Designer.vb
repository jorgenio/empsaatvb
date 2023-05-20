<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Libretas_Lecturacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Libretas_Lecturacion))
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnProcesar = New System.Windows.Forms.Button()
        Me.TxtPeriodo = New System.Windows.Forms.TextBox()
        Me.Lista = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Progreso = New System.Windows.Forms.ProgressBar()
        Me.btnImprimir2 = New System.Windows.Forms.Button()
        Me.Doc = New System.Drawing.Printing.PrintDocument()
        Me.VerDoc = New System.Windows.Forms.PrintPreviewDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Lis = New System.Drawing.Printing.PrintDocument()
        Me.btnRuta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(221, 320)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(111, 46)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Location = New System.Drawing.Point(18, 320)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(111, 46)
        Me.BtnProcesar.TabIndex = 3
        Me.BtnProcesar.Text = "Imprimir"
        Me.BtnProcesar.UseVisualStyleBackColor = True
        '
        'TxtPeriodo
        '
        Me.TxtPeriodo.Location = New System.Drawing.Point(90, 13)
        Me.TxtPeriodo.Name = "TxtPeriodo"
        Me.TxtPeriodo.Size = New System.Drawing.Size(244, 20)
        Me.TxtPeriodo.TabIndex = 10
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(20, 43)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(315, 199)
        Me.Lista.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Periodo"
        '
        'Progreso
        '
        Me.Progreso.Location = New System.Drawing.Point(20, 261)
        Me.Progreso.Name = "Progreso"
        Me.Progreso.Size = New System.Drawing.Size(315, 23)
        Me.Progreso.TabIndex = 7
        '
        'btnImprimir2
        '
        Me.btnImprimir2.Location = New System.Drawing.Point(18, 320)
        Me.btnImprimir2.Name = "btnImprimir2"
        Me.btnImprimir2.Size = New System.Drawing.Size(111, 46)
        Me.btnImprimir2.TabIndex = 11
        Me.btnImprimir2.Text = "Imprimir"
        Me.btnImprimir2.UseVisualStyleBackColor = True
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
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(135, 303)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 36)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Lista"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Lis
        '
        '
        'btnRuta
        '
        Me.btnRuta.Location = New System.Drawing.Point(135, 345)
        Me.btnRuta.Name = "btnRuta"
        Me.btnRuta.Size = New System.Drawing.Size(80, 36)
        Me.btnRuta.TabIndex = 13
        Me.btnRuta.Text = "Imp. Ruta"
        Me.btnRuta.UseVisualStyleBackColor = True
        '
        'Frm_Libretas_Lecturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(353, 382)
        Me.Controls.Add(Me.btnRuta)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnImprimir2)
        Me.Controls.Add(Me.TxtPeriodo)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Progreso)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.BtnSalir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Libretas_Lecturacion"
        Me.Text = "Libretas Lecturacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents TxtPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents Lista As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Progreso As System.Windows.Forms.ProgressBar
    Friend WithEvents btnImprimir2 As System.Windows.Forms.Button
    Friend WithEvents Doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents VerDoc As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Lis As System.Drawing.Printing.PrintDocument
    Friend WithEvents btnRuta As System.Windows.Forms.Button
End Class
