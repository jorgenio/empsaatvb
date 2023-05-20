<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Arqueos
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnVerFacturas = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.dgComprobantes = New System.Windows.Forms.DataGrid()
        Me.Panel2.SuspendLayout()
        CType(Me.dgComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnVerFacturas)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 500)
        Me.Panel2.TabIndex = 6
        '
        'btnVerFacturas
        '
        Me.btnVerFacturas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerFacturas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVerFacturas.Location = New System.Drawing.Point(0, 0)
        Me.btnVerFacturas.Name = "btnVerFacturas"
        Me.btnVerFacturas.Size = New System.Drawing.Size(127, 50)
        Me.btnVerFacturas.TabIndex = 3
        Me.btnVerFacturas.Text = "Ver Arqueo"
        Me.btnVerFacturas.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.Location = New System.Drawing.Point(0, 456)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 40)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'dgComprobantes
        '
        Me.dgComprobantes.DataMember = ""
        Me.dgComprobantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgComprobantes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgComprobantes.Location = New System.Drawing.Point(131, 0)
        Me.dgComprobantes.Name = "dgComprobantes"
        Me.dgComprobantes.Size = New System.Drawing.Size(614, 500)
        Me.dgComprobantes.TabIndex = 7
        '
        'Frm_Arqueos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 500)
        Me.Controls.Add(Me.dgComprobantes)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_Arqueos"
        Me.Text = "Arqueos"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnVerFacturas As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents dgComprobantes As System.Windows.Forms.DataGrid
End Class
