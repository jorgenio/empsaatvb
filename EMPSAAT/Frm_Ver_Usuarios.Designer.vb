<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Ver_Usuarios
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Panel5.SuspendLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.btnSalir)
        Me.Panel5.Controls.Add(Me.btnExportar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(112, 468)
        Me.Panel5.TabIndex = 4
        '
        'btnSalir
        '
        Me.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnSalir.Location = New System.Drawing.Point(0, 423)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(108, 41)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(2, 3)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(106, 41)
        Me.btnExportar.TabIndex = 1
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUsuarios.Location = New System.Drawing.Point(112, 0)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.Size = New System.Drawing.Size(578, 468)
        Me.dgUsuarios.TabIndex = 5
        '
        'Frm_Ver_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 468)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Ver_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Usuarios"
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
End Class
