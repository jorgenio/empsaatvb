<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNit = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtRazon = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.dgUsu = New System.Windows.Forms.DataGridView()
        Me.btnCorregir = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.BtnEditar)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 501)
        Me.Panel2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.Location = New System.Drawing.Point(0, 82)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Imprimir Inscripción"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEditar.Location = New System.Drawing.Point(0, 41)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(127, 41)
        Me.BtnEditar.TabIndex = 2
        Me.BtnEditar.Text = "&Editar Registro"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.Location = New System.Drawing.Point(0, 457)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 40)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnNuevo.Location = New System.Drawing.Point(0, 0)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(127, 41)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "&Nuevo Registro"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCorregir)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtNit)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.txtRazon)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(131, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 102)
        Me.Panel1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Teléfono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(271, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cliente"
        '
        'txtNit
        '
        Me.txtNit.Location = New System.Drawing.Point(297, 16)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.ReadOnly = True
        Me.txtNit.Size = New System.Drawing.Size(145, 20)
        Me.txtNit.TabIndex = 3
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(67, 69)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(136, 20)
        Me.txtTelefono.TabIndex = 2
        '
        'txtRazon
        '
        Me.txtRazon.Location = New System.Drawing.Point(67, 43)
        Me.txtRazon.Name = "txtRazon"
        Me.txtRazon.ReadOnly = True
        Me.txtRazon.Size = New System.Drawing.Size(375, 20)
        Me.txtRazon.TabIndex = 1
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(67, 17)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(136, 20)
        Me.txtCliente.TabIndex = 0
        '
        'dgUsu
        '
        Me.dgUsu.AllowUserToAddRows = False
        Me.dgUsu.AllowUserToDeleteRows = False
        Me.dgUsu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgUsu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUsu.Location = New System.Drawing.Point(131, 102)
        Me.dgUsu.Name = "dgUsu"
        Me.dgUsu.ReadOnly = True
        Me.dgUsu.Size = New System.Drawing.Size(553, 399)
        Me.dgUsu.TabIndex = 8
        '
        'btnCorregir
        '
        Me.btnCorregir.Location = New System.Drawing.Point(448, 12)
        Me.btnCorregir.Name = "btnCorregir"
        Me.btnCorregir.Size = New System.Drawing.Size(93, 51)
        Me.btnCorregir.TabIndex = 8
        Me.btnCorregir.Text = "Corregir datos del Cliente"
        Me.btnCorregir.UseVisualStyleBackColor = True
        '
        'Frm_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 501)
        Me.Controls.Add(Me.dgUsu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgUsu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNit As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtRazon As System.Windows.Forms.TextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents dgUsu As System.Windows.Forms.DataGridView
    Friend WithEvents btnCorregir As System.Windows.Forms.Button
End Class
