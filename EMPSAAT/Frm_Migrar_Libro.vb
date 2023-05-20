Imports System.Data.SqlClient

Public Class Frm_Migrar_Libro
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim i As Integer
    Dim txt As String

    Private Sub Frm_Migrar_Libro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Dosificacion Order By Autorizacion Desc"
        da.Fill(ds, "Aut")
        cboAutorizacion.DataSource = ds.Tables("Aut")
        cboAutorizacion.DisplayMember = "Autorizacion"
        cboAutorizacion.ValueMember = "Autorizacion"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cmd As New SqlCommand

            da.SelectCommand.CommandText = "Select * From Facturas Where Num_Orden = '" & cboAutorizacion.SelectedValue & "' Order By Num_Factura"
            da.Fill(ds, "Fac")

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.Text
            End With

            For i = 0 To ds.Tables("Fac").Rows.Count - 1

                txt = "INSERT INTO LIBRO (ESPECIFICACION, FECHA, FACTURA, AUTORIZACION, ESTADO, NIT, RAZON, IMPORTE_VENTA, ICE_IEHD_TASAS, EXCENTAS, VENTAS_TASA_CERO, SUBTOTAL, DESCUENTOS, IMPORTE_PARA_DEBITO, DEBITO_FISCAL, CODIGO_CONTROL, SERVICIO, USUARIO) VALUES (" & _
                                   "'3','" & _
                                   ds.Tables("Fac").Rows(i).Item("Emision") & "','" & _
                                   ds.Tables("Fac").Rows(i).Item("Num_Factura") & "','" & _
                                   ds.Tables("Fac").Rows(i).Item("Num_Orden") & "','" & _
                                   "V','" & _
                                   ds.Tables("Fac").Rows(i).Item("Nit") & "','" & _
                                   Razon_Social(ds.Tables("Fac").Rows(i).Item("Abonado")) & "','" & _
                                   ds.Tables("Fac").Rows(i).Item("IMp_Factura") & "','" & _
                                   "0','" & _
                                   "0','" & _
                                   "0','" & _
                                   ds.Tables("Fac").Rows(i).Item("Imp_Factura") & "','" & _
                                   "0','" & _
                                   ds.Tables("Fac").Rows(i).Item("Imp_Factura") & "','" & _
                                   Math.Round((ds.Tables("Fac").Rows(i).Item("Imp_Factura") * 0.13), 2) & "','" & _
                                   ds.Tables("Fac").Rows(i).Item("Codigo_Control") & "','" & _
                                   "1','" & _
                                   _Usuario & "')"

                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next

            MessageBox.Show("Proceso Terminado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(txt, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub
End Class