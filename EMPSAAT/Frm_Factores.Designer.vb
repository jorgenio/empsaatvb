<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Factores
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Factores))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.dgFactores = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.dgFactores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BtnImprimir)
        Me.Panel2.Controls.Add(Me.BtnEditar)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.BtnNuevo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 512)
        Me.Panel2.TabIndex = 5
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnImprimir.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnImprimir.ImageIndex = 3
        Me.BtnImprimir.ImageList = Me.ImageList1
        Me.BtnImprimir.Location = New System.Drawing.Point(0, 124)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(127, 62)
        Me.BtnImprimir.TabIndex = 5
        Me.BtnImprimir.Text = "&Imprimir"
        Me.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Blue Disk 1.ico")
        Me.ImageList1.Images.SetKeyName(1, "Blue Disk 4.ico")
        Me.ImageList1.Images.SetKeyName(2, "Clipboard.ico")
        Me.ImageList1.Images.SetKeyName(3, "PRINT4.ICO")
        '
        'BtnEditar
        '
        Me.BtnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditar.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnEditar.Location = New System.Drawing.Point(0, 62)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(127, 62)
        Me.BtnEditar.TabIndex = 2
        Me.BtnEditar.Text = "&Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.Location = New System.Drawing.Point(0, 446)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 62)
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
        Me.BtnNuevo.Size = New System.Drawing.Size(127, 62)
        Me.BtnNuevo.TabIndex = 0
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'dgFactores
        '
        Me.dgFactores.AllowUserToAddRows = False
        Me.dgFactores.AllowUserToDeleteRows = False
        Me.dgFactores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFactores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFactores.Location = New System.Drawing.Point(131, 0)
        Me.dgFactores.Name = "dgFactores"
        Me.dgFactores.ReadOnly = True
        Me.dgFactores.Size = New System.Drawing.Size(621, 512)
        Me.dgFactores.TabIndex = 6
        '
        'Frm_Factores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 512)
        Me.Controls.Add(Me.dgFactores)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_Factores"
        Me.Text = "Factores de Cálculo"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgFactores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents dgFactores As System.Windows.Forms.DataGridView
End Class
