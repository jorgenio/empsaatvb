Imports System.Data.SqlClient

Public Class Frm_Material
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub Frm_Material_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Material"
        da.Fill(ds, "Mat")
        dgMaterial.DataSource = ds.Tables("Mat")
    End Sub

    Private Sub Ver_Material()
        ds.Tables("Mat").Clear()
        da.SelectCommand.CommandText = "Select * From Material"
        da.Fill(ds, "Mat")
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        pMaterial = ""
        Dim fReg As New Frm_Material_Reg
        If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Ver_Material()
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        pMaterial = dgMaterial.Item("Material", dgMaterial.CurrentRow.Index).Value
        Dim fReg As New Frm_Material_Reg
        If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Ver_Material()
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class