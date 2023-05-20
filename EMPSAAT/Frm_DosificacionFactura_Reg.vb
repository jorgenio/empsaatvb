Imports System.Data.SqlClient

Public Class Frm_DosificacionFactura_Reg
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Dim cmd As New SqlCommand
        Dim txt As String
        Try
            If MessageBox.Show("Esta seguro de grabar estos datos?" & Chr(13) & "¡Una vez grabados no se podrá corregir!", "Por favor verifique bien lo datos antes de proseguir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                db.Open()
                txt = "Update Dosificacion Set Activado = 0 Where Activado = 1"
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With

                txt = "Insert into Dosificacion (Autorizacion, LLave, NoInicial, NoFinal, Fec_Inicial, Fec_Final, Activado, Ley_453) Values ('" & _
                txtAutorizacion.Text & "','" & txtLlave.Text & "','" & txtNoInicial.Text & "','" & txtNoInicial.Text & "','" & _
                FormatDateTime(dtFechaInicial.Value, DateFormat.ShortDate) & "','" & FormatDateTime(dtFechaFinal.Value, DateFormat.ShortDate) & "',1,'" & txtLey453.Text & "')"
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
                db.Close()
                ds.Tables.Clear()
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        Catch x As Exception
            MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class