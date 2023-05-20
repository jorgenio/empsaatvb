<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cliente_Busqueda
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtUno = New System.Windows.Forms.TextBox
        Me.txtDos = New System.Windows.Forms.TextBox
        Me.cboTipo = New System.Windows.Forms.ComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.dgCliente = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtUno)
        Me.Panel1.Controls.Add(Me.txtDos)
        Me.Panel1.Controls.Add(Me.cboTipo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 51)
        Me.Panel1.TabIndex = 0
        '
        'txtUno
        '
        Me.txtUno.Location = New System.Drawing.Point(166, 16)
        Me.txtUno.Name = "txtUno"
        Me.txtUno.Size = New System.Drawing.Size(201, 20)
        Me.txtUno.TabIndex = 1
        '
        'txtDos
        '
        Me.txtDos.Location = New System.Drawing.Point(375, 16)
        Me.txtDos.Name = "txtDos"
        Me.txtDos.Size = New System.Drawing.Size(197, 20)
        Me.txtDos.TabIndex = 2
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(18, 16)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(142, 21)
        Me.cboTipo.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.btnAceptar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 344)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(584, 58)
        Me.Panel2.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(328, 16)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(109, 30)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(166, 16)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(109, 30)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'dgCliente
        '
        Me.dgCliente.AllowUserToAddRows = False
        Me.dgCliente.AllowUserToDeleteRows = False
        Me.dgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCliente.Location = New System.Drawing.Point(0, 51)
        Me.dgCliente.Name = "dgCliente"
        Me.dgCliente.ReadOnly = True
        Me.dgCliente.Size = New System.Drawing.Size(584, 293)
        Me.dgCliente.TabIndex = 2
        '
        'Frm_Cliente_Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgCliente)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Cliente_Busqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtUno As System.Windows.Forms.TextBox
    Friend WithEvents txtDos As System.Windows.Forms.TextBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgCliente As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
