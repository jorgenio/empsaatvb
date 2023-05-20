<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Servicios_Lista_Reg
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.txtServicio = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.cboClave = New System.Windows.Forms.ComboBox()
        Me.cboSeccion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnCancelar)
        Me.Panel2.Controls.Add(Me.BtnGrabar)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 280)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(509, 73)
        Me.Panel2.TabIndex = 37
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(295, 23)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(112, 38)
        Me.BtnCancelar.TabIndex = 13
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Location = New System.Drawing.Point(133, 23)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(113, 38)
        Me.BtnGrabar.TabIndex = 12
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'txtServicio
        '
        Me.txtServicio.Location = New System.Drawing.Point(123, 48)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.ReadOnly = True
        Me.txtServicio.Size = New System.Drawing.Size(100, 20)
        Me.txtServicio.TabIndex = 38
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(123, 85)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(330, 20)
        Me.txtDescripcion.TabIndex = 39
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(123, 122)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(100, 20)
        Me.txtCosto.TabIndex = 40
        '
        'cboClave
        '
        Me.cboClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClave.FormattingEnabled = True
        Me.cboClave.Location = New System.Drawing.Point(123, 159)
        Me.cboClave.Name = "cboClave"
        Me.cboClave.Size = New System.Drawing.Size(100, 21)
        Me.cboClave.TabIndex = 42
        '
        'cboSeccion
        '
        Me.cboSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSeccion.FormattingEnabled = True
        Me.cboSeccion.Location = New System.Drawing.Point(123, 197)
        Me.cboSeccion.Name = "cboSeccion"
        Me.cboSeccion.Size = New System.Drawing.Size(100, 21)
        Me.cboSeccion.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Servicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Descripcion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Costo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Clave"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Seccion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(268, 13)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "[1 = Agua potable] [2 = Alacantarrillado] [3 = Materiales]"
        '
        'Frm_Servicios_Lista_Reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 353)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSeccion)
        Me.Controls.Add(Me.cboClave)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtServicio)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Servicios_Lista_Reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtServicio As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCosto As System.Windows.Forms.TextBox
    Friend WithEvents cboClave As System.Windows.Forms.ComboBox
    Friend WithEvents cboSeccion As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
