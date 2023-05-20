<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Migrar_Libros
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnVerFacturas = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.dtDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnVerFacturas)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 254)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 64)
        Me.Panel2.TabIndex = 6
        '
        'btnVerFacturas
        '
        Me.btnVerFacturas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerFacturas.Location = New System.Drawing.Point(3, 4)
        Me.btnVerFacturas.Name = "btnVerFacturas"
        Me.btnVerFacturas.Size = New System.Drawing.Size(90, 50)
        Me.btnVerFacturas.TabIndex = 3
        Me.btnVerFacturas.Text = "Empezar"
        Me.btnVerFacturas.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Location = New System.Drawing.Point(227, 7)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(90, 50)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Cancelar"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'dtDesde
        '
        Me.dtDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDesde.Location = New System.Drawing.Point(169, 98)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(123, 20)
        Me.dtDesde.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "DESDE FECHA"
        '
        'Frm_Migrar_Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 318)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtDesde)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Migrar_Libros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Migrar Libros Iva"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnVerFacturas As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
