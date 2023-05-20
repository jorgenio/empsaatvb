<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DosificacionFactura_Reg
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
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoInicial = New System.Windows.Forms.TextBox()
        Me.dtFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.txtLlave = New System.Windows.Forms.TextBox()
        Me.txtAutorizacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLey453 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Location = New System.Drawing.Point(354, 301)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(131, 37)
        Me.BtnCancelar.TabIndex = 23
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Location = New System.Drawing.Point(120, 301)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(131, 37)
        Me.BtnGrabar.TabIndex = 16
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "No Factura Inicial"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Fecha Vencimiento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Llave"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "No. Autorización"
        '
        'txtNoInicial
        '
        Me.txtNoInicial.Location = New System.Drawing.Point(191, 196)
        Me.txtNoInicial.Name = "txtNoInicial"
        Me.txtNoInicial.Size = New System.Drawing.Size(114, 20)
        Me.txtNoInicial.TabIndex = 17
        '
        'dtFechaFinal
        '
        Me.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFinal.Location = New System.Drawing.Point(191, 161)
        Me.dtFechaFinal.Name = "dtFechaFinal"
        Me.dtFechaFinal.Size = New System.Drawing.Size(114, 20)
        Me.dtFechaFinal.TabIndex = 15
        '
        'dtFechaInicial
        '
        Me.dtFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicial.Location = New System.Drawing.Point(192, 130)
        Me.dtFechaInicial.Name = "dtFechaInicial"
        Me.dtFechaInicial.Size = New System.Drawing.Size(113, 20)
        Me.dtFechaInicial.TabIndex = 14
        Me.dtFechaInicial.Value = New Date(2007, 12, 11, 0, 0, 0, 0)
        '
        'txtLlave
        '
        Me.txtLlave.Location = New System.Drawing.Point(192, 76)
        Me.txtLlave.MaxLength = 250
        Me.txtLlave.Multiline = True
        Me.txtLlave.Name = "txtLlave"
        Me.txtLlave.Size = New System.Drawing.Size(348, 38)
        Me.txtLlave.TabIndex = 13
        '
        'txtAutorizacion
        '
        Me.txtAutorizacion.Location = New System.Drawing.Point(191, 47)
        Me.txtAutorizacion.MaxLength = 50
        Me.txtAutorizacion.Name = "txtAutorizacion"
        Me.txtAutorizacion.Size = New System.Drawing.Size(349, 20)
        Me.txtAutorizacion.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(58, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Ley 453"
        '
        'txtLey453
        '
        Me.txtLey453.Location = New System.Drawing.Point(192, 233)
        Me.txtLey453.MaxLength = 250
        Me.txtLey453.Multiline = True
        Me.txtLey453.Name = "txtLey453"
        Me.txtLey453.Size = New System.Drawing.Size(349, 39)
        Me.txtLey453.TabIndex = 25
        '
        'Frm_DosificacionFactura_Reg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 354)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtLey453)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoInicial)
        Me.Controls.Add(Me.dtFechaFinal)
        Me.Controls.Add(Me.dtFechaInicial)
        Me.Controls.Add(Me.txtLlave)
        Me.Controls.Add(Me.txtAutorizacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_DosificacionFactura_Reg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Dosificación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnGrabar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoInicial As System.Windows.Forms.TextBox
    Friend WithEvents dtFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtLlave As System.Windows.Forms.TextBox
    Friend WithEvents txtAutorizacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLey453 As System.Windows.Forms.TextBox
End Class
