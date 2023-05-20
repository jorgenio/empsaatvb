Imports System.Data.SqlClient

Public Class Frm_Material_Lista
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        pMaterial = ""
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            pMaterial = dgMaterial.Item("Material", dgMaterial.CurrentRow.Index).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Frm_Material_Lista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Material Where Disponible = 1 Order by Descripcion"
        da.Fill(ds, "Mat")
        dgMaterial.DataSource = ds.Tables("Mat")
    End Sub
End Class