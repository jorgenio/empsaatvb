Imports System.Data.SqlClient

Public Class Frm_Migrar_Libros
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim i As Int64

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnVerFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFacturas.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String

            txt = "INSERT INTO LIBRO (ESPECIFICACION, FECHA, FACTURA, AUTORIZACION, ESTADO, NIT, RAZON, IMPORTE_VENTA, ICE_IEHD_TASAS, EXCENTAS, VENTAS_TASA_CERO, SUBTOTAL, DESCUENTOS, IMPORTE_PARA_DEBITO, DEBITO_FISCAL, CODIGO_CONTROL, SERVICIO, USUARIO, COMPROBANTE) " & _
                "SELECT '3', Emision,Num_Factura,Num_Orden,Valida,Nit,Razon,IMp_Factura,'0','0','0',Imp_Factura,'0',Imp_Factura,Imp_Factura,Codigo_Control,'1',USER_NAME(), COMPROBANTE " & _
                "FROM VER_LIBROS_IVA WHERE EMISION >= '" & FormatDateTime(dtDesde.Value, DateFormat.ShortDate) & "' AND NOT CODIGO_CONTROL IS NULL"
            db.Open()
            With cmd
                .Connection = db
                .CommandText = txt
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            db.Close()

            MessageBox.Show("Proceso Terminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

End Class