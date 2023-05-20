Imports System.Data.SqlClient

Public Class Frm_Punto
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Frm_Punto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Punto"
        da.Fill(ds, "Punto")
        dgPunto.DataSource = ds.Tables("Punto")
    End Sub

    Private Sub Ver_Registros()
        ds.Tables("Punto").Clear()
        da.SelectCommand.CommandText = "Select * From Punto"
        da.Fill(ds, "Punto")
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        pPunto = 0
        Dim fReg As New Frm_Punto_Reg
        If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Ver_Registros()
        End If
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        pPunto = dgPunto.Item("Punto", dgPunto.CurrentRow.Index).Value
        Dim fReg As New Frm_Punto_Reg
        If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Ver_Registros()
        End If
    End Sub
End Class