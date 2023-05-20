<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Clientes_Migrar
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
        Me.btnMigrar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnCompletarNoDoc = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnMigrar
        '
        Me.btnMigrar.Location = New System.Drawing.Point(23, 108)
        Me.btnMigrar.Name = "btnMigrar"
        Me.btnMigrar.Size = New System.Drawing.Size(171, 56)
        Me.btnMigrar.TabIndex = 0
        Me.btnMigrar.Text = "(Paso 2) Migrar Datos"
        Me.btnMigrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(23, 181)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(171, 56)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cerrar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCompletarNoDoc
        '
        Me.btnCompletarNoDoc.Location = New System.Drawing.Point(23, 37)
        Me.btnCompletarNoDoc.Name = "btnCompletarNoDoc"
        Me.btnCompletarNoDoc.Size = New System.Drawing.Size(171, 54)
        Me.btnCompletarNoDoc.TabIndex = 2
        Me.btnCompletarNoDoc.Text = "(Paso 1) Completar NoDoc"
        Me.btnCompletarNoDoc.UseVisualStyleBackColor = True
        '
        'Frm_Clientes_Migrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCompletarNoDoc)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnMigrar)
        Me.Name = "Frm_Clientes_Migrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes_Migrar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMigrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCompletarNoDoc As System.Windows.Forms.Button
End Class
