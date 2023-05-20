<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Proformas_Nue
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxtProforma = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Nota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Razón Social"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Proforma"
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(98, 76)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(521, 20)
        Me.TxtNota.TabIndex = 11
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Location = New System.Drawing.Point(98, 44)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(522, 20)
        Me.TxtRazonSocial.TabIndex = 10
        '
        'TxtProforma
        '
        Me.TxtProforma.Location = New System.Drawing.Point(98, 12)
        Me.TxtProforma.Name = "TxtProforma"
        Me.TxtProforma.ReadOnly = True
        Me.TxtProforma.Size = New System.Drawing.Size(76, 20)
        Me.TxtProforma.TabIndex = 9
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnCancelar.Location = New System.Drawing.Point(343, 133)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(127, 40)
        Me.BtnCancelar.TabIndex = 15
        Me.BtnCancelar.Text = "Cerrar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAceptar.Location = New System.Drawing.Point(190, 133)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(127, 40)
        Me.btnAceptar.TabIndex = 16
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Frm_Proformas_Nue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNota)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.TxtProforma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Proformas_Nue"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Proforma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNota As System.Windows.Forms.TextBox
    Friend WithEvents TxtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents TxtProforma As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
