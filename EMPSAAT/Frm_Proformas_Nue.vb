Imports System.Data.SqlClient

Public Class Frm_Proformas_Nue
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim edi As Boolean

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String

            If edi = True Then
                txt = "UPDATE PROFORMAS SET RAZONSOCIAL = '" & TxtRazonSocial.Text & "', NOTA = '" & TxtNota.Text & "' WHERE PROFORMA = " & TxtProforma.Text
            Else
                txt = "INSERT INTO PROFORMAS (PROFORMA, RAZONSOCIAL, OBSERVACIONES) VALUES ('" & TxtProforma.Text & "','" & TxtRazonSocial.Text & "','" & TxtNota.Text & "')"
            End If
            db.Open()
            With cmd
                .Connection = db
                .CommandText = txt
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            db.Close()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Frm_Proformas_Nue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Proformas Where Proforma = " & _Proforma
        da.Fill(ds, "Pro")
        If ds.Tables("Pro").Rows.Count > 0 Then
            TxtProforma.Text = ds.Tables("Pro").Rows(0).Item("Proforma")
            TxtRazonSocial.Text = ds.Tables("Pro").Rows(0).Item("RazonSocial")
            TxtNota.Text = ds.Tables("Pro").Rows(0).Item("OBSERVACIONES")
            edi = True
        Else
            TxtProforma.Text = _Proforma
            edi = False
        End If
    End Sub
End Class