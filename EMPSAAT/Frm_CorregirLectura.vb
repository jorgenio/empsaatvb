Imports System.Data.SqlClient

Public Class Frm_CorregirLectura
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            txt = "UPDATE FACTURAS SET LECTURA = " & txtLectura.Text & " WHERE FACTURA = " & pFactura
            db.Open()
            With cmd
                .Connection = db
                .CommandText = txt
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Frm_CorregirLectura_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Facturas where Factura = " & pFactura
        da.Fill(ds, "Fac")
        If ds.Tables("Fac").Rows.Count > 0 Then
            txtEmision.Text = ds.Tables("Fac").Rows(0).Item("Emision")
            txtLectura.Text = ds.Tables("Fac").Rows(0).Item("Lectura")
        End If
    End Sub
End Class