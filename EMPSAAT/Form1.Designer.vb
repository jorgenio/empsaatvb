<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConsumoAguaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OtrasVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FactoresDeCálculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CálculoDeFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturaciónToolStripMenuItem, Me.RegistrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(670, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsumoAguaToolStripMenuItem, Me.OtrasVentasToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.FacturaciónToolStripMenuItem.Text = "Facturación"
        '
        'ConsumoAguaToolStripMenuItem
        '
        Me.ConsumoAguaToolStripMenuItem.Name = "ConsumoAguaToolStripMenuItem"
        Me.ConsumoAguaToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ConsumoAguaToolStripMenuItem.Text = "Consumo Agua"
        '
        'OtrasVentasToolStripMenuItem
        '
        Me.OtrasVentasToolStripMenuItem.Name = "OtrasVentasToolStripMenuItem"
        Me.OtrasVentasToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OtrasVentasToolStripMenuItem.Text = "Otras Ventas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(154, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FactoresDeCálculoToolStripMenuItem, Me.CálculoDeFacturasToolStripMenuItem})
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'FactoresDeCálculoToolStripMenuItem
        '
        Me.FactoresDeCálculoToolStripMenuItem.Name = "FactoresDeCálculoToolStripMenuItem"
        Me.FactoresDeCálculoToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.FactoresDeCálculoToolStripMenuItem.Text = "Factores de Cálculo"
        '
        'CálculoDeFacturasToolStripMenuItem
        '
        Me.CálculoDeFacturasToolStripMenuItem.Name = "CálculoDeFacturasToolStripMenuItem"
        Me.CálculoDeFacturasToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.CálculoDeFacturasToolStripMenuItem.Text = "Cálculo de Facturas"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 458)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FacturaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsumoAguaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtrasVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FactoresDeCálculoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CálculoDeFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
