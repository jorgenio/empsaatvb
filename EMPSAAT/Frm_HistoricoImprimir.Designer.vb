<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_HistoricoImprimir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_HistoricoImprimir))
        Me.cboDel = New System.Windows.Forms.ComboBox()
        Me.cboAl = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.VerDoc = New System.Windows.Forms.PrintPreviewDialog()
        Me.Doc = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'cboDel
        '
        Me.cboDel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDel.FormattingEnabled = True
        Me.cboDel.Location = New System.Drawing.Point(113, 53)
        Me.cboDel.Name = "cboDel"
        Me.cboDel.Size = New System.Drawing.Size(116, 21)
        Me.cboDel.TabIndex = 0
        '
        'cboAl
        '
        Me.cboAl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAl.FormattingEnabled = True
        Me.cboAl.Location = New System.Drawing.Point(113, 97)
        Me.cboAl.Name = "cboAl"
        Me.cboAl.Size = New System.Drawing.Size(115, 21)
        Me.cboAl.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(153, 191)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 36)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Del"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Al"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(41, 191)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(94, 36)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
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
        'Doc
        '
        '
        'Frm_HistoricoImprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.cboAl)
        Me.Controls.Add(Me.cboDel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Frm_HistoricoImprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Kardex Historico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboDel As System.Windows.Forms.ComboBox
    Friend WithEvents cboAl As System.Windows.Forms.ComboBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents VerDoc As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Doc As System.Drawing.Printing.PrintDocument
End Class
