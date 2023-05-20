Imports System.Data.SqlClient

Public Class Frm_Material_Reg
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim Edi As Boolean = False

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            If Edi = True Then
                txt = "UPDATE MATERIAL SET DESCRIPCION = '" & txtDescripcion.Text & "', UNIDAD = '" & txtUnidad.Text & "', UNITARIO = '" & nudUnitario.Value & "', DISPONIBLE = " & IIf(chkDisponible.Checked, 1, 0) & ", ENTREGA = " & IIf(chkEntrega.Checked, 1, 0) & " WHERE MATERIAL = '" & txtMaterial.Text & "'"
            Else
                txt = "INSERT INTO MATERIAL (MATERIAL, DESCRIPCION, UNIDAD, UNITARIO, DISPONIBLE, ENTREGA) VALUES ('" & txtMaterial.Text & "','" & txtDescripcion.Text & "','" & txtUnidad.Text & "','" & nudUnitario.Value & "'," & IIf(chkDisponible.Checked, 1, 0) & "," & IIf(chkEntrega.Checked, 1, 0) & ")"
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

    Private Sub Frm_Material_Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Material Where Material = '" & pMaterial & "'"
        da.Fill(ds, "Mat")
        If ds.Tables("Mat").Rows.Count > 0 Then
            txtMaterial.Text = ds.Tables("Mat").Rows(0).Item("Material")
            txtDescripcion.Text = ds.Tables("Mat").Rows(0).Item("Descripcion")
            txtUnidad.Text = ds.Tables("Mat").Rows(0).Item("Unidad")
            nudUnitario.Value = ds.Tables("Mat").Rows(0).Item("Unitario")
            chkDisponible.Checked = ds.Tables("Mat").Rows(0).Item("Disponible")
            chkEntrega.Checked = IIf(IsDBNull(ds.Tables("Mat").Rows(0).Item("Entrega")), False, ds.Tables("Mat").Rows(0).Item("Entrega"))
            Edi = True
            txtMaterial.ReadOnly = True
        End If
    End Sub
End Class