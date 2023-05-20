Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Factores
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub Frm_Factores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        da.SelectCommand.CommandText = "Select Top 12 * From Factores Order by Emision Desc"
        da.Fill(ds, "Fac")
        DgFactores.DataSource = ds.Tables("Fac")
    End Sub

    Private Sub Ver_Registros()
        ds.Tables("Fac").Clear()
        da.SelectCommand.CommandText = "Select Top 12 * From Factores Order by Emision Desc"
        da.Fill(ds, "Fac")
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        da.SelectCommand.CommandText = "Select Emision From Factores Where Estado = 1"
        da.Fill(ds, "Ufa")
        If Not IsDBNull(ds.Tables("Ufa").Rows(0).Item("Emision")) Then
            dEmision = DateAdd(DateInterval.Month, 1, ds.Tables("Ufa").Rows(0).Item("Emision"))
            Dim fReg As New Frm_Factores_Reg
            If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
                Ver_Registros()
            End If
        End If
        ds.Tables("UFa").Clear()
    End Sub

    Private Sub Editar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        da.SelectCommand.CommandText = "Select Emision From Factores Where Estado = 1"
        da.Fill(ds, "Ufa")
        If ds.Tables("Ufa").Rows.Count > 0 Then
            dEmision = ds.Tables("Ufa").Rows(0).Item("Emision")
            dEmision = dgFactores.Item("Emision", dgFactores.CurrentRow.Index).Value
            Dim fReg As New Frm_Factores_Reg
            If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
                Ver_Registros()
            End If
        End If
        ds.Tables("Ufa").Clear()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class