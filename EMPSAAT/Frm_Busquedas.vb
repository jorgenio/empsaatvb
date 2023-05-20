Imports System.Data.SqlClient

Public Class Frm_Busquedas
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim txt As String

    Private Sub txtPaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPaterno.KeyPress
        If e.KeyChar = Chr(13) Then
            If cboTipo.SelectedItem = "Nombre" Then
                TxtNombre.Focus()
            Else
                Buscar_Registros()
            End If
        End If
    End Sub

    Private Sub Buscar_Registros()
        Try
            txt = ""
            Select Case cboTipo.SelectedItem
                Case "Nombre"
                    'txt = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Nombre Like '" & txtPaterno.Text & "%" & txtNombre.Text & "%'"
                    txt = "Select * From Ver_Usuarios Where Razon Like '" & txtPaterno.Text & "%" & txtNombre.Text & "%'"
                Case "Abonado"
                    'txt = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Abonado = " & txtPaterno.Text
                    txt = "Select * From Ver_Usuarios Where Abonado = '" & txtPaterno.Text & "'"
                Case "Zona"
                    'txt = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Zona Like '%" & txtPaterno.Text & "%'"
                    txt = "Select * From Ver_Usuarios Zona Like '%" & txtPaterno.Text & "%'"
                Case "Medidor"
                    'txt = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Medidor like '%" & txtPaterno.Text & "%'"
                    txt = "Select * From Ver_Usuarios Where Medidor like '%" & txtPaterno.Text & "%'"
            End Select
            da.SelectCommand.CommandText = txt
            ds.Tables("Usuarios").Clear()
            da.Fill(ds, "Usuarios")
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = Chr(13) Then
            Buscar_Registros()
        End If
    End Sub

    Private Sub Frm_Busquedas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Ver_Usuarios Where Cliente = '0' Order By Razon"
        '"Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria"
        da.Fill(ds, "Usuarios")
        dgUsuarios.DataSource = ds.Tables("Usuarios")
        cboTipo.SelectedItem = "Nombre"
    End Sub

    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        ds.Tables("Usuarios").Clear()
        txtPaterno.Focus()
    End Sub

    Private Sub dgUsuarios_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgUsuarios.CellDoubleClick
        nAbonado = dgUsuarios.Item("Abonado", dgUsuarios.CurrentRow.Index).Value
        pCliente = dgUsuarios.Item("Cliente", dgUsuarios.CurrentRow.Index).Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nAbonado = dgUsuarios.Item("Abonado", dgUsuarios.CurrentRow.Index).Value
        pCliente = dgUsuarios.Item("Cliente", dgUsuarios.CurrentRow.Index).Value
        Dim fSer As New Frm_Servicios
        fSer.Show()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nAbonado = dgUsuarios.Item("Abonado", dgUsuarios.CurrentRow.Index).Value
        pCliente = dgUsuarios.Item("Cliente", dgUsuarios.CurrentRow.Index).Value
        Dim fHis As New Frm_Historico
        fHis.ShowDialog()
    End Sub

    Private Sub btnDeuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        pCliente = dgUsuarios.Item("Cliente", dgUsuarios.CurrentRow.Index).Value
        nAbonado = dgUsuarios.Item("Abonado", dgUsuarios.CurrentRow.Index).Value
        Dim fDeu As New Frm_Deudas
        fDeu.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtPaterno.Clear()
        txtNombre.Clear()
        ds.Tables("Usuarios").Clear()
        txtPaterno.Focus()
    End Sub

    Private Sub btnRecalculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        nAbonado = dgUsuarios.Item("Abonado", dgUsuarios.CurrentRow.Index).Value
        pCliente = dgUsuarios.Item("Cliente", dgUsuarios.CurrentRow.Index).Value
        Dim fRec As New Frm_Recalculo_Facturas
        fRec.ShowDialog()
    End Sub

    Private Sub txtPaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaterno.TextChanged
        Buscar_Registros()
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        Buscar_Registros()
    End Sub

    
   

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        nAbonado = dgUsuarios.Item("Abonado", dgUsuarios.CurrentRow.Index).Value
        pCliente = dgUsuarios.Item("Cliente", dgUsuarios.CurrentRow.Index).Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class