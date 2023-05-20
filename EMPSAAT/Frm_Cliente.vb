Imports System.Data.SqlClient

Public Class Frm_Cliente
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Frm_Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Cliente"
        da.Fill(ds, "Cli")
        dgCliente.DataSource = ds.Tables("Cli")
    End Sub

    Private Sub Ver_Registros(ByVal Cliente As String)
        ds.Tables("Cli").Clear()
        da.SelectCommand.CommandText = "Select * From Cliente Where Cliente = '" & Cliente & "'"
        da.Fill(ds, "Cli")
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        pCliente = dgCliente.Item("Cliente", dgCliente.CurrentRow.Index).Value
        'pCliente = InputBox("Cliente", "Número de cliente")
        If Len(pCliente) > 0 Then
            Dim fReg As New Frm_Cliente_Reg
            If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
                Ver_Registros(pCliente)
            End If
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        pCliente = ""
        Dim fReg As New Frm_Cliente_Reg
        If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Ver_Registros(pCliente)
        End If
    End Sub

    Private Sub btnCorregir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim fCor As New Frm_Clientes_Migrar
        fCor.ShowDialog()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        pCliente = ""
        Dim fBus As New Frm_Cliente_Busqueda
        If fBus.ShowDialog = Windows.Forms.DialogResult.OK Then
            Ver_Registros(pCliente)
        End If
    End Sub
End Class