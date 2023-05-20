Imports System.Data.SqlClient

Public Class Frm_Proformas_Reg
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub VER_REGISTROS()
        ds.Tables("usupro").Clear()
        da.SelectCommand.CommandText = "Select * From Ver_Usuarios Where Abonado In (Select Abonado From Proformas_Usuarios Where Proforma = " & TxtProforma.Text & ")"
        da.Fill(ds, "UsuPro")
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            Dim fBus As New Frm_Busquedas
            If fBus.ShowDialog = Windows.Forms.DialogResult.OK Then
                txt = "INSERT INTO PROFORMAS_USUARIOS (PROFORMA, ABONADO, CAJERO) VALUES ('" & _
                    TxtProforma.Text & "','" & nAbonado & "','" & _Usuario & "')"
                db.Open()
                With cmd
                    .Connection = db
                    .CommandText = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
                db.Close()
            End If
            VER_REGISTROS()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Frm_Proformas_Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "SELECT * FROM PROFORMAS WHERE PROFORMA = " & _Proforma
        da.Fill(ds, "PRO")
        If ds.Tables("PRO").Rows.Count > 0 Then
            TxtProforma.Text = ds.Tables("Pro").Rows(0).Item("Proforma")
            TxtRazonSocial.Text = IIf(IsDBNull(ds.Tables("Pro").Rows(0).Item("RazonSocial")), "", ds.Tables("Pro").Rows(0).Item("RazonSocial"))
            TxtNota.Text = IIf(IsDBNull(ds.Tables("Pro").Rows(0).Item("Observaciones")), "", ds.Tables("Pro").Rows(0).Item("Observaciones"))

            da.SelectCommand.CommandText = "Select * From Ver_Usuarios Where Abonado In (Select Abonado From Proformas_Usuarios Where Proforma = " & TxtProforma.Text & ")"
            da.Fill(ds, "UsuPro")
            dgUsuarios.DataSource = ds.Tables("UsuPro")
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            nAbonado = dgUsuarios.Item("Abonado", dgUsuarios.CurrentRow.Index).Value

            If MessageBox.Show("Esta seguro de quitar abonado " & nAbonado, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                txt = "DELETE PROFORMAS_USUARIOS WHERE PROFORMA = " & TxtProforma.Text & " AND ABONADO = " & nAbonado
                db.Open()
                With cmd
                    .Connection = db
                    .CommandText = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
                db.Close()
            End If
            VER_REGISTROS()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub
End Class