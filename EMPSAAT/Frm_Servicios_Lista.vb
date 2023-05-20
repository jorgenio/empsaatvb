Imports System.Data.SqlClient

Public Class Frm_Servicios_Lista
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Frm_Servicios_Lista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select Distinct Cuenta From Servicios_Lista"
        da.Fill(ds, "Cue")
        cboCuenta.DataSource = ds.Tables("Cue")
        cboCuenta.DisplayMember = "Cuenta"
        cboCuenta.ValueMember = "Cuenta"

        da.SelectCommand.CommandText = "Select * from Servicios_Lista Where Cuenta = '" & cboCuenta.SelectedValue & "'"
        da.Fill(ds, "Ser")
        dgMaterial.DataSource = ds.Tables("Ser")

    End Sub

    Private Sub Ver_Registros()
        ds.Tables("Ser").Clear()
        da.SelectCommand.CommandText = "Select * from Servicios_Lista Where Cuenta = '" & cboCuenta.SelectedValue & "'"
        da.Fill(ds, "Ser")
    End Sub


    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        pCuenta = cboCuenta.SelectedValue
        pServicioLista = 0
        Dim fReg As New Frm_Servicios_Lista_Reg
        If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Ver_Registros()
        End If
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        pCuenta = cboCuenta.SelectedValue
        pServicioLista = dgMaterial.Item("Servicio", dgMaterial.CurrentRow.Index).Value
        Dim fReg As New Frm_Servicios_Lista_Reg
        If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Ver_Registros()
        End If
    End Sub

    Private Sub cboCuenta_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCuenta.SelectionChangeCommitted
        Ver_Registros()
    End Sub
End Class