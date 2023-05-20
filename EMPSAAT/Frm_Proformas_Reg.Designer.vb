<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Proformas_Reg
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
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxtProforma = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.dgUsuarios)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.TxtNota)
        Me.Panel1.Controls.Add(Me.TxtRazonSocial)
        Me.Panel1.Controls.Add(Me.TxtProforma)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(634, 468)
        Me.Panel1.TabIndex = 8
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEliminar.Location = New System.Drawing.Point(152, 416)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(127, 40)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar Registro"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNuevo.Location = New System.Drawing.Point(19, 416)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(127, 40)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Añadir Registro"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Location = New System.Drawing.Point(19, 136)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.Size = New System.Drawing.Size(601, 259)
        Me.dgUsuarios.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Razón Social"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Proforma"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCancelar.Location = New System.Drawing.Point(493, 416)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(127, 40)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cerrar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(99, 92)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.ReadOnly = True
        Me.TxtNota.Size = New System.Drawing.Size(521, 20)
        Me.TxtNota.TabIndex = 2
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(99, 60)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.ReadOnly = True
        Me.TxtRazonSocial.Size = New System.Drawing.Size(522, 20)
        Me.TxtRazonSocial.TabIndex = 1
        '
        'TxtProforma
        '
        Me.TxtProforma.Location = New System.Drawing.Point(99, 28)
        Me.TxtProforma.Name = "TxtProforma"
        Me.TxtProforma.ReadOnly = True
        Me.TxtProforma.Size = New System.Drawing.Size(76, 20)
        Me.TxtProforma.TabIndex = 0
        '
        'Frm_Proformas_Reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 468)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Proformas_Reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Proforma"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents TxtNota As System.Windows.Forms.TextBox
    Friend WithEvents TxtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents TxtProforma As System.Windows.Forms.TextBox
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
