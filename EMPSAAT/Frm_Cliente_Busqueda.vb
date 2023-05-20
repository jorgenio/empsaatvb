Imports System.Data.SqlClient

Public Class Frm_Cliente_Busqueda
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub Frm_Busqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboTipo.Items.Add("Cliente")
        cboTipo.Items.Add("Nombre")
        cboTipo.SelectedItem = "Nombre"
        da.SelectCommand.CommandText = "Select * From Cliente Where cliente = '" & txtUno.Text & "'"
        da.Fill(ds, "Cli")
        dgCliente.DataSource = ds.Tables("Cli")
        Buscar_Registros()
        txtUno.Focus()
    End Sub

    Private Sub Buscar_Registros()
        ds.Tables("Cli").Clear()
        If cboTipo.SelectedItem = "Cliente" Then da.SelectCommand.CommandText = "Select * From Cliente Where cliente = '" & txtUno.Text & "'"
        If cboTipo.SelectedItem = "Nombre" Then da.SelectCommand.CommandText = "Select * From Cliente Where Razon Like '%" & txtUno.Text & "%" & txtDos.Text & "%'"
        da.Fill(ds, "Cli")
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        pCliente = dgCliente.Item("Cliente", dgCliente.CurrentRow.Index).Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txtUno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUno.KeyPress
        If e.KeyChar = Chr(13) Then
            txtDos.Focus()
        End If
    End Sub

    Private Sub txtUno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUno.TextChanged
        ds.Tables("Cli").Clear()
        Buscar_Registros()
    End Sub

    Private Sub txtDos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDos.KeyPress
        If e.KeyChar = Chr(13) Then
            Buscar_Registros()
            btnAceptar.Focus()
        End If
    End Sub

    Private Sub txtDos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDos.TextChanged
        ds.Tables("Cli").Clear()
        Buscar_Registros()
    End Sub
End Class