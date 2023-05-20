Imports System.Data.SqlClient

Public Class Frm_Verificar_Facturas
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim i As Integer

    Private Sub Frm_Verificar_Facturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select Top 3 * From Factores Order By Emision Desc"
        da.Fill(ds, "Emi")
        cboEmision.DataSource = ds.Tables("Emi")
        cboEmision.DisplayMember = "Emision"
        cboEmision.ValueMember = "Emision"

    End Sub

   
    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String

            da.SelectCommand.CommandText = "SELECT f.Abonado, f.Imp_Factura, f.Imp_Iva, F.Codigo_Control, F.Num_Factura, F.Num_Orden, L.Importe_Para_Debito FROM FACTURAS f inner join Libro l On F.Num_Factura = L.Factura and F.Num_Orden = L.Autorizacion WHERE f.Imp_Factura <> L.Importe_Para_Debito and f.Emision = '" & cboEmision.SelectedValue & "'"
            da.Fill(ds, "Fac")

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.Text
            End With

            For i = 0 To ds.Tables("Fac").Rows.Count - 1
                txt = "UPDATE LIBRO SET IMPORTE_VENTA = '" & ds.Tables("Fac").Rows(i).Item("Imp_Factura") & "'," & _
                           "ICE_IEHD_TASAS = '0', EXCENTAS = '0', VENTAS_TASA_CERO = '0', " & _
                           "SUBTOTAL = '" & ds.Tables("Fac").Rows(i).Item("Imp_Factura") & "'," & _
                           "DESCUENTOS = '0'," & _
                           "IMPORTE_PARA_DEBITO = '" & ds.Tables("Fac").Rows(i).Item("Imp_Factura") & "'," & _
                           "DEBITO_FISCAL = '" & Math.Round((ds.Tables("Fac").Rows(i).Item("Imp_Factura") * 0.13), 2) & "'," & _
                           "CODIGO_CONTROL = '" & ds.Tables("Fac").Rows(i).Item("Codigo_Control") & "'," & _
                           "SERVICIO = '1', USUARIO = '" & _Usuario & "' " & _
                           "WHERE FACTURA = " & ds.Tables("Fac").Rows(i).Item("Num_Factura") & " AND AUTORIZACION = " & ds.Tables("Fac").Rows(i).Item("Num_Orden")
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next
            db.Close()
            MessageBox.Show("Se han corregido " & ds.Tables("Fac").Rows.Count & " registros", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class