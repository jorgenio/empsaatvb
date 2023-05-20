Imports System.Data.SqlClient

Public Class Frm_Anular_Factura

    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnVerFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFacturas.Click

        Try
            Dim nFac As Double
            Dim dEmi As Date
            Dim txt As String
            Dim nAbo As Integer
            Dim lFactura As Double
            Dim lAutorizacion As Double

            da.SelectCommand.CommandText = "Select * From Facturas Where Num_Factura = '" & txtFactura.Text & "' and Num_Orden = '" & txtAutorizacion.Text & "'"
            da.Fill(ds, "Fac")

            If ds.Tables("Fac").Rows.Count > 0 Then

                nFac = ds.Tables("FAc").Rows(0).Item("FActura")
                nAbo = ds.Tables("Fac").Rows(0).Item("Abonado")
                dEmi = ds.Tables("Fac").Rows(0).Item("Emision")
                lFactura = ds.Tables("Fac").Rows(0).Item("Num_Factura")
                lAutorizacion = ds.Tables("Fac").Rows(0).Item("Num_ORDEN")

                If ds.Tables("Fac").Rows(0).Item("Fec_Pago").ToString <> "" And ds.Tables("Fac").Rows(0).Item("Comprobante") > 1 Then

                    If MessageBox.Show("Esta seguro de anular la factura del ABONADO = " & nAbo, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        Dim cmd As New SqlCommand
                        Dim xFactura As New SqlParameter
                        Dim xEmision As New SqlParameter
                        Dim xFactura_numero As New SqlParameter
                        Dim xAutorizacion As New SqlParameter

                        db.Open()
                        With cmd
                            .Connection = db
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "ANULAR_FACTURA"
                            xFactura = .Parameters.Add("@Factura", SqlDbType.Real)
                            xEmision = .Parameters.Add("@Emision", SqlDbType.DateTime)
                            xFactura_numero = .Parameters.Add("@Factura_Numero", SqlDbType.Real)
                            xAutorizacion = .Parameters.Add("@Autorizacion", SqlDbType.Real)
                            xFactura.Direction = ParameterDirection.Input
                            xEmision.Direction = ParameterDirection.Input
                            xFactura_numero.Direction = ParameterDirection.Input
                            xAutorizacion.Direction = ParameterDirection.Input
                            xFactura.Value = nFac
                            xEmision.Value = dEmi
                            xFactura_numero.Value = lFactura
                            xAutorizacion.Value = lAutorizacion
                            .ExecuteNonQuery()
                        End With
                        db.Close()

                        MessageBox.Show("Se ha anulado correctamente la factura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Me.Close()
                    End If
                Else
                    MessageBox.Show("La factura no esta CANCELADA", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("No se ha encontrado el registro solicitado", "Atención", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Hand)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub
End Class