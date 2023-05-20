<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Rep_Otras_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Rep_Otras_Ventas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDebito = New System.Windows.Forms.TextBox()
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
        Me.dgOtrasVentas = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerRep = New System.Windows.Forms.PrintPreviewDialog()
        Me.Rep = New System.Drawing.Printing.PrintDocument()
        Me.RepCla = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        CType(Me.dgOtrasVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtDebito)
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
        Me.Panel1.Location = New System.Drawing.Point(0, 303)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(718, 84)
        Me.Panel1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(283, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Debito Fiscal"
        '
        'txtDebito
        '
        Me.txtDebito.Location = New System.Drawing.Point(380, 57)
        Me.txtDebito.Name = "txtDebito"
        Me.txtDebito.ReadOnly = True
        Me.txtDebito.Size = New System.Drawing.Size(121, 20)
        Me.txtDebito.TabIndex = 16
        Me.txtDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnImprimirNuevo
        '
        Me.btnImprimirNuevo.Location = New System.Drawing.Point(530, 5)
        Me.btnImprimirNuevo.Name = "btnImprimirNuevo"
        Me.btnImprimirNuevo.Size = New System.Drawing.Size(84, 35)
        Me.btnImprimirNuevo.TabIndex = 15
        Me.btnImprimirNuevo.Text = "Imprimir detalle"
        Me.btnImprimirNuevo.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(530, 43)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(84, 35)
        Me.btnImprimir.TabIndex = 14
        Me.btnImprimir.Text = "Imprimir Clasificado"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(620, 5)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(91, 72)
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
        Me.Label3.Location = New System.Drawing.Point(283, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total General"
        '
        'txtNoTotFac
        '
        Me.txtNoTotFac.Location = New System.Drawing.Point(144, 49)
        Me.txtNoTotFac.Name = "txtNoTotFac"
        Me.txtNoTotFac.ReadOnly = True
        Me.txtNoTotFac.Size = New System.Drawing.Size(119, 20)
        Me.txtNoTotFac.TabIndex = 10
        Me.txtNoTotFac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtImpTotal
        '
        Me.TxtImpTotal.Location = New System.Drawing.Point(380, 36)
        Me.TxtImpTotal.Name = "TxtImpTotal"
        Me.TxtImpTotal.ReadOnly = True
        Me.TxtImpTotal.Size = New System.Drawing.Size(121, 20)
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
        Me.txtNoFacturas.ReadOnly = True
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
        Me.TxtImporte.ReadOnly = True
        Me.TxtImporte.Size = New System.Drawing.Size(121, 20)
        Me.TxtImporte.TabIndex = 2
        Me.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dgOtrasVentas
        '
        Me.dgOtrasVentas.AllowUserToAddRows = False
        Me.dgOtrasVentas.AllowUserToDeleteRows = False
        Me.dgOtrasVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOtrasVentas.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgOtrasVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOtrasVentas.Location = New System.Drawing.Point(0, 0)
        Me.dgOtrasVentas.Name = "dgOtrasVentas"
        Me.dgOtrasVentas.ReadOnly = True
        Me.dgOtrasVentas.Size = New System.Drawing.Size(718, 303)
        Me.dgOtrasVentas.TabIndex = 12
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnularToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 26)
        '
        'AnularToolStripMenuItem
        '
        Me.AnularToolStripMenuItem.Name = "AnularToolStripMenuItem"
        Me.AnularToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AnularToolStripMenuItem.Text = "Anular"
        '
        'VerRep
        '
        Me.VerRep.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.VerRep.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.VerRep.ClientSize = New System.Drawing.Size(400, 300)
        Me.VerRep.Enabled = True
        Me.VerRep.Icon = CType(resources.GetObject("VerRep.Icon"), System.Drawing.Icon)
        Me.VerRep.Name = "VerRep"
        Me.VerRep.Visible = False
        '
        'Rep
        '
        '
        'RepCla
        '
        '
        'Frm_Rep_Otras_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 387)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgOtrasVentas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frm_Rep_Otras_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas Otras Ventas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgOtrasVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnImprimirNuevo As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoTotFac As System.Windows.Forms.TextBox
    Friend WithEvents TxtImpTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoFacturas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtImporte As System.Windows.Forms.TextBox
    Friend WithEvents dgOtrasVentas As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AnularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerRep As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Rep As System.Drawing.Printing.PrintDocument
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDebito As System.Windows.Forms.TextBox
    Friend WithEvents RepCla As System.Drawing.Printing.PrintDocument
End Class
