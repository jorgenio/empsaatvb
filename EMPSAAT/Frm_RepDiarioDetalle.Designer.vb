<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_RepDiarioDetalle
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_RepDiarioDetalle))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImprimirNuevo = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoTotFac = New System.Windows.Forms.TextBox()
        Me.TxtImpTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoFacturas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.dgFacturas = New System.Windows.Forms.DataGridView()
        Me.cmAnular = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsAnular = New System.Windows.Forms.ToolStripMenuItem()
        Me.Doc = New System.Drawing.Printing.PrintDocument()
        Me.VerDoc = New System.Windows.Forms.PrintPreviewDialog()
        Me.cboFecha = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmAnular.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnImprimirNuevo)
        Me.Panel1.Controls.Add(Me.btnImprimir)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNoTotFac)
        Me.Panel1.Controls.Add(Me.TxtImpTotal)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNoFacturas)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtImporte)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 311)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 84)
        Me.Panel1.TabIndex = 10
        '
        'btnImprimirNuevo
        '
        Me.btnImprimirNuevo.Location = New System.Drawing.Point(530, 17)
        Me.btnImprimirNuevo.Name = "btnImprimirNuevo"
        Me.btnImprimirNuevo.Size = New System.Drawing.Size(84, 51)
        Me.btnImprimirNuevo.TabIndex = 15
        Me.btnImprimirNuevo.Text = "Imprimir"
        Me.btnImprimirNuevo.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(530, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(84, 51)
        Me.btnImprimir.TabIndex = 14
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(631, 17)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(84, 51)
        Me.btnCerrar.TabIndex = 13
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Nro. General"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(283, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total General"
        '
        'txtNoTotFac
        '
        Me.txtNoTotFac.Location = New System.Drawing.Point(144, 49)
        Me.txtNoTotFac.Name = "txtNoTotFac"
        Me.txtNoTotFac.Size = New System.Drawing.Size(119, 20)
        Me.txtNoTotFac.TabIndex = 10
        Me.txtNoTotFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtImpTotal
        '
        Me.TxtImpTotal.Location = New System.Drawing.Point(382, 49)
        Me.TxtImpTotal.Name = "TxtImpTotal"
        Me.TxtImpTotal.Size = New System.Drawing.Size(118, 20)
        Me.TxtImpTotal.TabIndex = 9
        Me.TxtImpTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nro. de Facturas"
        '
        'txtNoFacturas
        '
        Me.txtNoFacturas.Location = New System.Drawing.Point(144, 16)
        Me.txtNoFacturas.Name = "txtNoFacturas"
        Me.txtNoFacturas.Size = New System.Drawing.Size(120, 20)
        Me.txtNoFacturas.TabIndex = 4
        Me.txtNoFacturas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Facturado"
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(380, 16)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(121, 20)
        Me.TxtImporte.TabIndex = 2
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgFacturas
        '
        Me.dgFacturas.AllowUserToAddRows = False
        Me.dgFacturas.AllowUserToDeleteRows = False
        Me.dgFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFacturas.ContextMenuStrip = Me.cmAnular
        Me.dgFacturas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFacturas.Location = New System.Drawing.Point(0, 54)
        Me.dgFacturas.Name = "dgFacturas"
        Me.dgFacturas.ReadOnly = True
        Me.dgFacturas.Size = New System.Drawing.Size(722, 257)
        Me.dgFacturas.TabIndex = 11
        '
        'cmAnular
        '
        Me.cmAnular.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsAnular})
        Me.cmAnular.Name = "ContextMenuStrip1"
        Me.cmAnular.Size = New System.Drawing.Size(110, 26)
        '
        'tsAnular
        '
        Me.tsAnular.Name = "tsAnular"
        Me.tsAnular.Size = New System.Drawing.Size(109, 22)
        Me.tsAnular.Text = "Anular"
        '
        'Doc
        '
        '
        'VerDoc
        '
        Me.VerDoc.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.VerDoc.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.VerDoc.ClientSize = New System.Drawing.Size(400, 300)
        Me.VerDoc.Document = Me.Doc
        Me.VerDoc.Enabled = True
        Me.VerDoc.Icon = CType(resources.GetObject("VerDoc.Icon"), System.Drawing.Icon)
        Me.VerDoc.Name = "VerDoc"
        Me.VerDoc.Visible = False
        '
        'cboFecha
        '
        Me.cboFecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFecha.FormattingEnabled = True
        Me.cboFecha.Location = New System.Drawing.Point(83, 16)
        Me.cboFecha.Name = "cboFecha"
        Me.cboFecha.Size = New System.Drawing.Size(164, 21)
        Me.cboFecha.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Fecha"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cboFecha)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(722, 54)
        Me.Panel2.TabIndex = 12
        '
        'Frm_RepDiarioDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 395)
        Me.Controls.Add(Me.dgFacturas)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Frm_RepDiarioDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Diario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmAnular.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoTotFac As System.Windows.Forms.TextBox
    Friend WithEvents TxtImpTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoFacturas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents dgFacturas As System.Windows.Forms.DataGridView
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Doc As System.Drawing.Printing.PrintDocument
    Friend WithEvents VerDoc As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents btnImprimirNuevo As System.Windows.Forms.Button
    Friend WithEvents cmAnular As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsAnular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboFecha As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
