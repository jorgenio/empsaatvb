<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Busquedas
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.cboTipo)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtPaterno)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(734, 44)
        Me.Panel1.TabIndex = 0
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Items.AddRange(New Object() {"Abonado", "Nombre", "Medidor", "Zona"})
        Me.cboTipo.Location = New System.Drawing.Point(3, 11)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(118, 21)
        Me.cboTipo.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(413, 12)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(263, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(682, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(49, 39)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPaterno
        '
        Me.txtPaterno.Location = New System.Drawing.Point(144, 12)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(263, 20)
        Me.txtPaterno.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.btnAceptar)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 360)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(734, 52)
        Me.Panel2.TabIndex = 1
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(220, 6)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(124, 40)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(413, 6)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(124, 40)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Cancelar"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUsuarios.Location = New System.Drawing.Point(0, 44)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.Size = New System.Drawing.Size(734, 316)
        Me.dgUsuarios.TabIndex = 2
        '
        'Frm_Busquedas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 412)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Busquedas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busquedas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtPaterno As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
