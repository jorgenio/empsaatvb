Imports System.Data.SqlClient

Public Class Frm_Proformas
    Dim db As New SqlConnection(cn)
    Dim daPro As New SqlDataAdapter("", db)
    Dim dtUsu As New DataTable
    Dim ds As New DataSet

    Private Sub Frm_Proformas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        daPro.SelectCommand.CommandText = "Select Proforma, RazonSocial From Proformas Order By Proforma"
        daPro.Fill(ds, "Proformas")
        dgProformas.DataSource = ds.Tables("Proformas")
    End Sub

    Private Sub VerLista()
        ds.Tables("Proformas").Clear()
        daPro.SelectCommand.CommandText = "Select Proforma, RazonSocial From Proformas Order By Proforma"
        daPro.Fill(ds, "Proformas")
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        _Proforma = Obtener_Numero_Proforma()
        Dim FNue As New Frm_Proformas_Nue
        If FNue.ShowDialog = Windows.Forms.DialogResult.OK Then
            VerLista()
        End If
    End Sub

    Function Obtener_Numero_Proforma() As Integer
        daPro.SelectCommand.CommandText = "Select max(Proforma) From Proformas"
        daPro.Fill(ds, "NoProforma")
        If ds.Tables("NoProforma").Rows.Count > 0 Then
            Obtener_Numero_Proforma = ds.Tables("NoProforma").Rows(0).Item(0) + 1
        Else
            Obtener_Numero_Proforma = 1
        End If
        ds.Tables("NoProforma").Clear()
    End Function

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        _Proforma = dgProformas.Item("Proforma", dgProformas.CurrentRow.Index).Value
        Dim fREg As New Frm_Proformas_Reg
        If fREg.ShowDialog = Windows.Forms.DialogResult.OK Then
            VerLista()
        End If
    End Sub

    Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
        Dim nPro As Integer = dgProformas.Item("Proforma", dgProformas.CurrentRow.Index).Value
        Dim cRas As String = dgProformas.Item("RazonSocial", dgProformas.CurrentRow.Index).Value
        Dim cmd As New SqlCommand
        Dim txt As String
        daPro.SelectCommand.CommandText = "Select Proforma, RazonSocial From Proformas Where Proforma = " & nPro
        daPro.Fill(ds, "ProformaElimina")
        If ds.Tables("ProformaElimina").Rows.Count > 0 Then
            If MessageBox.Show("Esta seguro de eliminar esta proforma " & Chr(13) & _
            "Numero Proforma = " & nPro & Chr(13) & _
            "Razón Social = " & cRas, "Tenga mucho cuidado por favor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Try
                    db.Open()
                    txt = "DELETE Proformas_Usuarios Where Proforma = " & nPro
                    With cmd
                        .Connection = db
                        .CommandType = CommandType.Text
                        .CommandText = txt
                        .ExecuteNonQuery()
                    End With

                    txt = "DELETE Proformas Where Proforma = " & nPro

                    With cmd
                        .Connection = db
                        .CommandType = CommandType.Text
                        .CommandText = txt
                        .ExecuteNonQuery()
                    End With
                    db.Close()
                    MessageBox.Show("Proceso terminado con éxito", "Se ha efectuado lo solicitado", MessageBoxButtons.OK)
                    ds.Tables("Proformas").Clear()
                    Call VerLista()
                Catch x As Exception
                    MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    If db.State = ConnectionState.Open Then db.Close()
                End Try
            End If
        End If

    End Sub

End Class