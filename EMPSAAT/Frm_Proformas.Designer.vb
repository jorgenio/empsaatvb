<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Proformas
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.nmeControl = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AgregaRegistro = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminaRegistro = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgProformas = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.nmeControl.SuspendLayout()
        CType(Me.dgProformas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BtnEliminar)
        Me.Panel2.Controls.Add(Me.BtnEditar)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 462)
        Me.Panel2.TabIndex = 5
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEliminar.Location = New System.Drawing.Point(0, 82)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(127, 41)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEditar.Location = New System.Drawing.Point(0, 41)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(127, 41)
        Me.BtnEditar.TabIndex = 2
        Me.BtnEditar.Text = "Editar Abonados"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.Location = New System.Drawing.Point(0, 418)
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
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'nmeControl
        '
        Me.nmeControl.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregaRegistro, Me.EliminaRegistro})
        Me.nmeControl.Name = "nmeControl"
        Me.nmeControl.Size = New System.Drawing.Size(164, 48)
        '
        'AgregaRegistro
        '
        Me.AgregaRegistro.Name = "AgregaRegistro"
        Me.AgregaRegistro.Size = New System.Drawing.Size(163, 22)
        Me.AgregaRegistro.Text = "Añadir Registro"
        '
        'EliminaRegistro
        '
        Me.EliminaRegistro.Name = "EliminaRegistro"
        Me.EliminaRegistro.Size = New System.Drawing.Size(163, 22)
        Me.EliminaRegistro.Text = "Eliminar Registro"
        '
        'dgProformas
        '
        Me.dgProformas.AllowUserToAddRows = False
        Me.dgProformas.AllowUserToDeleteRows = False
        Me.dgProformas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgProformas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProformas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProformas.Location = New System.Drawing.Point(131, 0)
        Me.dgProformas.Name = "dgProformas"
        Me.dgProformas.ReadOnly = True
        Me.dgProformas.Size = New System.Drawing.Size(553, 462)
        Me.dgProformas.TabIndex = 6
        '
        'Frm_Proformas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.dgProformas)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_Proformas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proformas"
        Me.Panel2.ResumeLayout(False)
        Me.nmeControl.ResumeLayout(False)
        CType(Me.dgProformas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents nmeControl As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AgregaRegistro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminaRegistro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgProformas As System.Windows.Forms.DataGridView
End Class
