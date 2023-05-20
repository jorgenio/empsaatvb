<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Reportes
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
        Me.crvRep = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'crvRep
        '
        Me.crvRep.ActiveViewIndex = -1
        Me.crvRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvRep.DisplayGroupTree = False
        Me.crvRep.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvRep.Location = New System.Drawing.Point(0, 0)
        Me.crvRep.Name = "crvRep"
        Me.crvRep.SelectionFormula = ""
        Me.crvRep.Size = New System.Drawing.Size(721, 358)
        Me.crvRep.TabIndex = 0
        Me.crvRep.ViewTimeSelectionFormula = ""
        '
        'Frm_Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 358)
        Me.Controls.Add(Me.crvRep)
        Me.Name = "Frm_Reportes"
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvRep As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
