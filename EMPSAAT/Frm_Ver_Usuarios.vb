Imports System.Data.SqlClient

Public Class Frm_Ver_Usuarios
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Frm_Ver_Usuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Ver_Usuarios Order By Abonado"
        da.Fill(ds, "Usu")
        dgUsuarios.DataSource = ds.Tables("Usu")
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Exportar(ds.Tables("Usu"))
    End Sub
End Class