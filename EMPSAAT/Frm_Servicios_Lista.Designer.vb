<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Servicios_Lista
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
        Me.dgMaterial = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboCuenta = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgMaterial
        '
        Me.dgMaterial.AllowUserToAddRows = False
        Me.dgMaterial.AllowUserToDeleteRows = False
        Me.dgMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMaterial.Location = New System.Drawing.Point(121, 65)
        Me.dgMaterial.Name = "dgMaterial"
        Me.dgMaterial.ReadOnly = True
        Me.dgMaterial.Size = New System.Drawing.Size(563, 397)
        Me.dgMaterial.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(121, 462)
        Me.Panel1.TabIndex = 3
        '
        'btnCerrar
        '
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCerrar.Location = New System.Drawing.Point(0, 415)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(121, 47)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditar.Location = New System.Drawing.Point(0, 47)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(121, 47)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(121, 47)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cboCuenta)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(121, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(563, 65)
        Me.Panel2.TabIndex = 5
        '
        'cboCuenta
        '
        Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(104, 23)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(420, 21)
        Me.cboCuenta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CUENTA"
        '
        'Frm_Servicios_Lista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 462)
        Me.Controls.Add(Me.dgMaterial)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Servicios_Lista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios_Lista"
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgMaterial As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
End Class
