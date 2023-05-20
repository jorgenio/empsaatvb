Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Try
            _Usuario = txtUsuario.Text
            _Clave = TxtLlave.Text

            'cn = "Server=SERVIDOR2\DBEMPSAAT;Database=EMPSAAT;Uid=" & _Usuario & ";Pwd=" & _Clave
            cn = "Server=(LOCAL);Database=EMPSAAT;Uid=" & _Usuario & ";Pwd=" & _Clave
            Dim db As New SqlConnection(cn)

            db.Open()
            If db.State = ConnectionState.Open Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally

        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        End
    End Sub

End Class
