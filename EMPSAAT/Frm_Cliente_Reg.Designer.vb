<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Cliente_Reg
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
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.txtRazon = New System.Windows.Forms.TextBox
        Me.txtNit = New System.Windows.Forms.TextBox
        Me.dtNacimiento = New System.Windows.Forms.DateTimePicker
        Me.txtTelefono = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDoc = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGrabar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 330)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 88)
        Me.Panel1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(261, 29)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 37)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Location = New System.Drawing.Point(85, 29)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(110, 37)
        Me.btnGrabar.TabIndex = 0
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(169, 42)
        Me.txtCliente.MaxLength = 15
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(124, 20)
        Me.txtCliente.TabIndex = 1
        '
        'txtRazon
        '
        Me.txtRazon.Location = New System.Drawing.Point(111, 94)
        Me.txtRazon.MaxLength = 80
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.Size = New System.Drawing.Size(317, 20)
        Me.txtRazon.TabIndex = 2
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(111, 147)
        Me.txtNit.MaxLength = 15
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(123, 20)
        Me.txtNit.TabIndex = 3
        '
        'dtNacimiento
        '
        Me.dtNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtNacimiento.Location = New System.Drawing.Point(110, 195)
        Me.dtNacimiento.Name = "dtNacimiento"
        Me.dtNacimiento.Size = New System.Drawing.Size(124, 20)
        Me.dtNacimiento.TabIndex = 4
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(110, 250)
        Me.txtTelefono.MaxLength = 30
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Nacimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(39, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Teléfono"
        '
        'txtDoc
        '
        Me.txtDoc.Location = New System.Drawing.Point(110, 43)
        Me.txtDoc.MaxLength = 3
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.Size = New System.Drawing.Size(53, 20)
        Me.txtDoc.TabIndex = 11
        '
        'Frm_Cliente_Reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDoc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.dtNacimiento)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.txtRazon)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Cliente_Reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Cliente"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtRazon As System.Windows.Forms.TextBox
    Friend WithEvents txtNit As System.Windows.Forms.TextBox
    Friend WithEvents dtNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtDoc As System.Windows.Forms.TextBox
End Class
