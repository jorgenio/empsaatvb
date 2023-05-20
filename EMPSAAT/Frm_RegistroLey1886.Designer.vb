<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RegistroLey1886
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
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.dgUsu = New System.Windows.Forms.DataGrid()
        Me.Errores = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.dgUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BtnQuitar)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 503)
        Me.Panel2.TabIndex = 6
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuitar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnQuitar.Location = New System.Drawing.Point(0, 41)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(127, 41)
        Me.BtnQuitar.TabIndex = 2
        Me.BtnQuitar.Text = "&Quitar Afiliación"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.Location = New System.Drawing.Point(0, 459)
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
        Me.BtnNuevo.Text = "&Nueva Afiliación"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'dgUsu
        '
        Me.dgUsu.DataMember = ""
        Me.dgUsu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUsu.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgUsu.Location = New System.Drawing.Point(131, 0)
        Me.dgUsu.Name = "dgUsu"
        Me.dgUsu.ReadOnly = True
        Me.dgUsu.Size = New System.Drawing.Size(668, 503)
        Me.dgUsu.TabIndex = 7
        '
        'Errores
        '
        Me.Errores.ContainerControl = Me
        '
        'Frm_RegistroLey1886
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 503)
        Me.Controls.Add(Me.dgUsu)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_RegistroLey1886"
        Me.Text = "Registro Ley 1886"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgUsu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Errores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnQuitar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents dgUsu As System.Windows.Forms.DataGrid
    Friend WithEvents Errores As System.Windows.Forms.ErrorProvider
End Class
