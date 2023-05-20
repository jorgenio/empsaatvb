<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DosificacionFacturas
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.dgLista = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 461)
        Me.Panel2.TabIndex = 5
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.Location = New System.Drawing.Point(0, 417)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 40)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(127, 41)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "Nueva"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'dgLista
        '
        Me.dgLista.AllowUserToAddRows = False
        Me.dgLista.AllowUserToDeleteRows = False
        Me.dgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLista.Location = New System.Drawing.Point(131, 0)
        Me.dgLista.Name = "dgLista"
        Me.dgLista.ReadOnly = True
        Me.dgLista.Size = New System.Drawing.Size(647, 461)
        Me.dgLista.TabIndex = 6
        '
        'Frm_DosificacionFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 461)
        Me.Controls.Add(Me.dgLista)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_DosificacionFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dosificación de Facturas"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents dgLista As System.Windows.Forms.DataGridView
End Class
