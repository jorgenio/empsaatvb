<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CalculoFacturas
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
        Me.Progre = New System.Windows.Forms.ProgressBar()
        Me.BtnProcesar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lista = New System.Windows.Forms.CheckedListBox()
        Me.TxtPeriodo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Progre
        '
        Me.Progre.Location = New System.Drawing.Point(18, 259)
        Me.Progre.Name = "Progre"
        Me.Progre.Size = New System.Drawing.Size(315, 23)
        Me.Progre.TabIndex = 0
        '
        'BtnProcesar
        '
        Me.BtnProcesar.Location = New System.Drawing.Point(18, 308)
        Me.BtnProcesar.Name = "BtnProcesar"
        Me.BtnProcesar.Size = New System.Drawing.Size(92, 48)
        Me.BtnProcesar.TabIndex = 1
        Me.BtnProcesar.Text = "Procesar"
        Me.BtnProcesar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(239, 308)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(94, 48)
        Me.BtnSalir.TabIndex = 2
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Periodo"
        '
        'Lista
        '
        Me.Lista.FormattingEnabled = True
        Me.Lista.Location = New System.Drawing.Point(18, 41)
        Me.Lista.Name = "Lista"
        Me.Lista.Size = New System.Drawing.Size(315, 199)
        Me.Lista.TabIndex = 5
        '
        'TxtPeriodo
        '
        Me.TxtPeriodo.Location = New System.Drawing.Point(88, 11)
        Me.TxtPeriodo.Name = "TxtPeriodo"
        Me.TxtPeriodo.ReadOnly = True
        Me.TxtPeriodo.Size = New System.Drawing.Size(244, 20)
        Me.TxtPeriodo.TabIndex = 6
        '
        'Frm_CalculoFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 372)
        Me.ControlBox = False
        Me.Controls.Add(Me.TxtPeriodo)
        Me.Controls.Add(Me.Lista)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnProcesar)
        Me.Controls.Add(Me.Progre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_CalculoFacturas"
        Me.Text = "Calculo de Facturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Progre As System.Windows.Forms.ProgressBar
    Friend WithEvents BtnProcesar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lista As System.Windows.Forms.CheckedListBox
    Friend WithEvents TxtPeriodo As System.Windows.Forms.TextBox
End Class
