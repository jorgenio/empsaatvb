Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Arqueos
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub Frm_Arqueos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Comprobantes Where Contabilizado = False"
        da.Fill(ds, "Comp")
        dgComprobantes.DataSource = ds.Tables("Comp")
    End Sub

    Private Sub btnVerFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFacturas.Click

    End Sub
End Class