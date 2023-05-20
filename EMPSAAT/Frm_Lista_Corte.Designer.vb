<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Lista_Corte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Lista_Corte))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnImprimirListaNuevo = New System.Windows.Forms.Button
        Me.BtnImprimir = New System.Windows.Forms.Button
        Me.BtnVerLista = New System.Windows.Forms.Button
        Me.BtnSalir = New System.Windows.Forms.Button
        Me.BtnNuevaLista = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboNumero = New System.Windows.Forms.ComboBox
        Me.Doc = New System.Drawing.Printing.PrintDocument
        Me.VerDoc = New System.Windows.Forms.PrintPreviewDialog
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.dgLista = New System.Windows.Forms.DataGridView
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnImprimirListaNuevo)
        Me.Panel2.Controls.Add(Me.BtnImprimir)
        Me.Panel2.Controls.Add(Me.BtnVerLista)
        Me.Panel2.Controls.Add(Me.BtnSalir)
        Me.Panel2.Controls.Add(Me.BtnNuevaLista)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(131, 497)
        Me.Panel2.TabIndex = 5
        '
        'btnImprimirListaNuevo
        '
        Me.btnImprimirListaNuevo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnImprimirListaNuevo.Location = New System.Drawing.Point(0, 123)
        Me.btnImprimirListaNuevo.Name = "btnImprimirListaNuevo"
        Me.btnImprimirListaNuevo.Size = New System.Drawing.Size(127, 41)
        Me.btnImprimirListaNuevo.TabIndex = 4
        Me.btnImprimirListaNuevo.Text = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lista"
        Me.btnImprimirListaNuevo.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnImprimir.Location = New System.Drawing.Point(0, 82)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(127, 41)
        Me.BtnImprimir.TabIndex = 3
        Me.BtnImprimir.Text = "Imprimir" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lista"
        Me.BtnImprimir.UseVisualStyleBackColor = True
        Me.BtnImprimir.Visible = False
        '
        'BtnVerLista
        '
        Me.BtnVerLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnVerLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVerLista.Location = New System.Drawing.Point(0, 41)
        Me.BtnVerLista.Name = "BtnVerLista"
        Me.BtnVerLista.Size = New System.Drawing.Size(127, 41)
        Me.BtnVerLista.TabIndex = 2
        Me.BtnVerLista.Text = "Actualizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la Lista"
        Me.BtnVerLista.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.Location = New System.Drawing.Point(0, 453)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(127, 40)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "&Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnNuevaLista
        '
        Me.BtnNuevaLista.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNuevaLista.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnNuevaLista.Location = New System.Drawing.Point(0, 0)
        Me.BtnNuevaLista.Name = "BtnNuevaLista"
        Me.BtnNuevaLista.Size = New System.Drawing.Size(127, 41)
        Me.BtnNuevaLista.TabIndex = 0
        Me.BtnNuevaLista.Text = "&Nueva Lista" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Corte"
        Me.BtnNuevaLista.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgLista)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(131, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(579, 497)
        Me.Panel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lista Número"
        '
        'cboNumero
        '
        Me.cboNumero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNumero.FormattingEnabled = True
        Me.cboNumero.Location = New System.Drawing.Point(234, 10)
        Me.cboNumero.Name = "cboNumero"
        Me.cboNumero.Size = New System.Drawing.Size(93, 21)
        Me.cboNumero.TabIndex = 1
        '
        'Doc
        '
        '
        'VerDoc
        '
        Me.VerDoc.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.VerDoc.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.VerDoc.ClientSize = New System.Drawing.Size(400, 300)
        Me.VerDoc.Enabled = True
        Me.VerDoc.Icon = CType(resources.GetObject("VerDoc.Icon"), System.Drawing.Icon)
        Me.VerDoc.Name = "VerDoc"
        Me.VerDoc.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cboNumero)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(579, 56)
        Me.Panel3.TabIndex = 3
        '
        'dgLista
        '
        Me.dgLista.AllowUserToAddRows = False
        Me.dgLista.AllowUserToDeleteRows = False
        Me.dgLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgLista.Location = New System.Drawing.Point(0, 56)
        Me.dgLista.Name = "dgLista"
        Me.dgLista.ReadOnly = True
        Me.dgLista.Size = New System.Drawing.Size(579, 441)
        Me.dgLista.TabIndex = 4
        '
        'Frm_Lista_Corte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 497)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Frm_Lista_Corte"
        Me.Text = "Listas de Corte"
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnVerLista As System.Windows.Forms.Button
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents BtnNuevaLista As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboNumero As System.Windows.Forms.ComboBox
    Friend WithEvents BtnImprimir As System.Windows.Forms.Button
    Friend WithEvents Doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents VerDoc As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnImprimirListaNuevo As System.Windows.Forms.Button
    Friend WithEvents dgLista As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
