<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Material_Reg
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
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGrabar = New System.Windows.Forms.Button()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.chkDisponible = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudUnitario = New System.Windows.Forms.NumericUpDown()
        Me.chkEntrega = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.nudUnitario, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 1
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
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(110, 49)
        Me.txtMaterial.MaxLength = 15
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(100, 20)
        Me.txtMaterial.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(110, 93)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(307, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(110, 138)
        Me.txtUnidad.MaxLength = 5
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidad.TabIndex = 4
        '
        'chkDisponible
        '
        Me.chkDisponible.AutoSize = True
        Me.chkDisponible.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDisponible.Location = New System.Drawing.Point(111, 240)
        Me.chkDisponible.Name = "chkDisponible"
        Me.chkDisponible.Size = New System.Drawing.Size(84, 20)
        Me.chkDisponible.TabIndex = 6
        Me.chkDisponible.Text = "Disponible"
        Me.chkDisponible.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Descripción"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Unidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Precio Unitario"
        '
        'nudUnitario
        '
        Me.nudUnitario.DecimalPlaces = 2
        Me.nudUnitario.Location = New System.Drawing.Point(111, 193)
        Me.nudUnitario.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.nudUnitario.Name = "nudUnitario"
        Me.nudUnitario.Size = New System.Drawing.Size(99, 20)
        Me.nudUnitario.TabIndex = 11
        Me.nudUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkEntrega
        '
        Me.chkEntrega.AutoSize = True
        Me.chkEntrega.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEntrega.Location = New System.Drawing.Point(110, 277)
        Me.chkEntrega.Name = "chkEntrega"
        Me.chkEntrega.Size = New System.Drawing.Size(68, 20)
        Me.chkEntrega.TabIndex = 12
        Me.chkEntrega.Text = "Entrega"
        Me.chkEntrega.UseVisualStyleBackColor = True
        '
        'Frm_Material_Reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 418)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkEntrega)
        Me.Controls.Add(Me.nudUnitario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkDisponible)
        Me.Controls.Add(Me.txtUnidad)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtMaterial)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Material_Reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Material"
        Me.Panel1.ResumeLayout(False)
        CType(Me.nudUnitario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents chkDisponible As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nudUnitario As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkEntrega As System.Windows.Forms.CheckBox
End Class
