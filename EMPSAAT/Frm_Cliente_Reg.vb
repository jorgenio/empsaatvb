Imports System.Data.SqlClient

Public Class Frm_Cliente_Reg
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim edi As Boolean = False

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Esta seguro de cerrar sin grabar los datos?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            Dim txt As String
            Dim cmd As New SqlCommand
            If Len(txtCliente.Text) = 0 Then
                MessageBox.Show("No es válido el documento del cliente", "Por favor corrija", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If

            If Len(txtRazon.Text) = 0 Then
                MessageBox.Show("No es válido el nombre del cliente", "Por favor corrija", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If

            If edi = True Then
                txt = "UPDATE CLIENTE SET RAZON = '" & UCase(txtRazon.Text) & "', NIT = '" & txtNit.Text & "', NACIMIENTO = '" & FormatDateTime(dtNacimiento.Value, DateFormat.ShortDate) & "', TELEFONO = '" & txtTelefono.Text & "' WHERE CLIENTE = '" & txtCliente.Text & "'"
            Else
                txt = "INSERT INTO CLIENTE (CLIENTE, DOCUMENTO, RAZON, NIT, NACIMIENTO, TELEFONO) VALUES ('" & txtCliente.Text & "','" & txtDoc.Text & "','" & UCase(txtRazon.Text) & "','" & txtNit.Text & "','" & FormatDateTime(dtNacimiento.Value, DateFormat.ShortDate) & "','" & txtTelefono.Text & "')"
            End If
            db.Open()

            With cmd
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With
            pCliente = txtCliente.Text
            db.Close()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Frm_Cliente_Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ver_Registro(pCliente)
    End Sub

    Private Sub Ver_Registro(ByVal Cliente As String)
        da.SelectCommand.CommandText = "Select * From Cliente where Cliente = '" & Cliente & "'"
        da.Fill(ds, "Cli")
        If ds.Tables("Cli").Rows.Count > 0 Then
            txtDoc.Text = IIf(IsDBNull(ds.Tables("Cli").Rows(0).Item("Documento")), "", ds.Tables("Cli").Rows(0).Item("Documento"))
            txtCliente.Text = ds.Tables("Cli").Rows(0).Item("Cliente")
            txtRazon.Text = ds.Tables("Cli").Rows(0).Item("Razon")
            txtNit.Text = ds.Tables("Cli").Rows(0).Item("Nit")
            dtNacimiento.Value = ds.Tables("Cli").Rows(0).Item("Nacimiento")
            txtTelefono.Text = IIf(IsDBNull(ds.Tables("Cli").Rows(0).Item("Telefono")), "", ds.Tables("Cli").Rows(0).Item("Telefono"))
            txtCliente.ReadOnly = True
            edi = True
        Else
            dtNacimiento.Value = Date.Now
        End If
        ds.Tables("Cli").Clear()
    End Sub

    Private Sub txtCliente_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCliente.Validating
        Ver_Registro(txtCliente.Text)
    End Sub

    Private Sub txtRazon_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRazon.LostFocus
        txtRazon.Text = UCase(txtRazon.Text)
    End Sub
End Class