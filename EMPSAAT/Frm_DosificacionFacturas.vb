Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_DosificacionFacturas
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub Ver_Lista()
        ds.Tables("Dosis").Clear()
        da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = 1 Order By Autorizacion"
        da.Fill(ds, "Dosis")
    End Sub

    Private Sub Frm_DosificacionFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'da.SelectCommand.CommandText = "Select * From Servicio"
        'da.Fill(ds, "Ser")
        'cboServicio.DataSource = ds.Tables("Ser")
        'cboServicio.DisplayMember = "Descripcion"
        'cboServicio.ValueMember = "Servicio"

        da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = 1 Order By Autorizacion"
        da.Fill(ds, "Dosis")
        dgLista.DataSource = ds.Tables("Dosis")
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        '_Servicio = cboServicio.SelectedValue
        Dim fReg As New Frm_DosificacionFactura_Reg
        fReg.ShowDialog()
        Ver_Lista()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub cboServicio_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        Ver_Lista()
    End Sub
End Class