Imports System.Data.SqlClient

Public Class Frm_Rep_Otras_Ventas
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim i As Integer
    Dim f As Integer
    Dim nPagina As Integer

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Frm_Rep_Otras_Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Ver_Facturas()
    End Sub

    Private Sub Ver_Facturas()
        ds.Tables.Clear()
        da.SelectCommand.CommandText = "Select * From LIBRO Where ESTADO = 'V' And Comprobante = " & nRep_Comprobante & " And USUARIO = '" & _Usuario & "' AND SERVICIO = 2"
        da.Fill(ds, "Dia")
        da.SelectCommand.CommandText = "Select Sum(Importe_Venta) as Imp From LIBRO Where Comprobante = " & nRep_Comprobante & " And USUARIO = '" & _Usuario & "' And  ESTADO = 'V' AND SERVICIO = 2"
        da.Fill(ds, "Sbt")
        da.SelectCommand.CommandText = "Select Count(*) as Nro From LIBRO Where Comprobante = " & nRep_Comprobante & " And USUARIO = '" & _Usuario & "' And ESTADO = 'V' AND SERVICIO = 2"
        da.Fill(ds, "Nro")
        da.SelectCommand.CommandText = "Select Sum(Importe_Venta) as Imp From libro Where Comprobante = " & nRep_Comprobante & " And ESTADO = 'V' AND SERVICIO = 2"
        da.Fill(ds, "Tot")
        da.SelectCommand.CommandText = "Select Count(*) as Nro From libro Where Comprobante = " & nRep_Comprobante & " And ESTADO = 'V' AND SERVICIO = 2"
        da.Fill(ds, "TNro")
        da.SelectCommand.CommandText = "Select Sum(Debito_Fiscal) as Deb From libro Where Comprobante = " & nRep_Comprobante & " And ESTADO = 'V' AND SERVICIO = 2"
        da.Fill(ds, "Deb")

        dgOtrasVentas.DataSource = ds.Tables("Dia")
        TxtImporte.Text = IIf(IsDBNull(ds.Tables("Sbt").Rows(0).Item("Imp")), 0, ds.Tables("Sbt").Rows(0).Item("Imp"))
        txtNoFacturas.Text = IIf(IsDBNull(ds.Tables("Nro").Rows(0).Item("Nro")), 0, ds.Tables("Nro").Rows(0).Item("Nro"))
        TxtImpTotal.Text = IIf(IsDBNull(ds.Tables("Tot").Rows(0).Item("Imp")), 0, ds.Tables("Tot").Rows(0).Item("Imp"))
        txtNoTotFac.Text = IIf(IsDBNull(ds.Tables("TNro").Rows(0).Item("Nro")), 0, ds.Tables("TNro").Rows(0).Item("Nro"))
        txtDebito.Text = IIf(IsDBNull(ds.Tables("Deb").Rows(0).Item("Deb")), 0, ds.Tables("Deb").Rows(0).Item("Deb"))
        ds.Tables("Sbt").Clear()
        ds.Tables("Nro").Clear()
        ds.Tables("Tot").Clear()
        ds.Tables("TNro").Clear()
        ds.Tables("Deb").Clear()
    End Sub

    Private Sub AnularToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularToolStripMenuItem.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            Dim nFactura As String
            Dim nAutorizacion As String
            Dim xFactura As String
            Dim xAutorizacion As String
            Dim I As Integer

            nFactura = dgOtrasVentas.Item("Factura", dgOtrasVentas.CurrentRow.Index).Value
            nAutorizacion = dgOtrasVentas.Item("Autorizacion", dgOtrasVentas.CurrentRow.Index).Value

            If MessageBox.Show("Esta seguro de anular la factura?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                xFactura = InputBox("Número de factura:", "Número de Factura:", 0)
                xAutorizacion = InputBox("Número de Autorizacion:" & "Número de Autorización:", 0)

                If nFactura = xFactura Then
                    If nAutorizacion = xAutorizacion Then
                        txt = "UPDATE LIBRO SET ESTADO = 'A' WHERE FACTURA = '" & nFactura & "' AND AUTORIZACION = '" & nAutorizacion & "'"
                        db.Open()
                        With cmd
                            .Connection = db
                            .CommandText = txt
                            .CommandType = CommandType.Text
                            .ExecuteNonQuery()
                        End With

                        da.SelectCommand.CommandText = "SELECT * FROM LIBRO_DETALLE WHERE FACTURA = '" & nFactura & "' AND AUTORIZACION = '" & nAutorizacion & "'"
                        da.Fill(ds, "DET")
                        For I = 0 To ds.Tables("DET").Rows.Count - 1
                            txt = "UPDATE SERVICIOS_SOLICITUD SET COBRADO = 0, FACTURA = 0 WHERE FACTURA = '" & nFactura & "' AND NOSOLICITUD = '" & ds.Tables("DET").Rows(I).Item("MATERIAL") & "' AND COBRADO = '1'"
                            cmd.CommandText = txt
                            cmd.ExecuteNonQuery()
                        Next
                        ds.Tables("DET").Clear()
                        db.Close()
                        ds.Tables("Dia").Clear()
                        Ver_Facturas()

                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    
    Private Sub Rep_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Rep.PrintPage
        Dim tFon As New Font("Arial Narrow", 14, FontStyle.Bold)
        Dim sFon As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim nFon As New Font("Arial Narrow", 8, FontStyle.Bold)
        Dim mFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim Alim As New System.Drawing.StringFormat(StringFormatFlags.DirectionRightToLeft)

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("DETALLE FACTURAS OTRAS VENTAS", tFon, Brushes.Black, 270, 50)
        e.Graphics.DrawString("Correspondiente a la fecha:" & FormatDateTime(ds.Tables("Rep").Rows(0).Item("Fecha"), DateFormat.ShortDate), nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Comprobante: " & ds.Tables("Rep").Rows(0).Item("comprobante"), mFon, Brushes.Black, 650, 50)
        e.Graphics.DrawString("Página: " & nPagina, mFon, Brushes.Black, 650, 65)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 800, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 800, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 800, 40, 800, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 600, 40, 600, 95)

        e.Graphics.DrawString("NIT/CID", nFon, Brushes.Black, 90, 120, Alim)
        e.Graphics.DrawString("RAZON SOCIAL", nFon, Brushes.Black, 110, 120)
        e.Graphics.DrawString("FACTURA", nFon, Brushes.Black, 500, 120, Alim)
        e.Graphics.DrawString("AUTORIZACION", nFon, Brushes.Black, 600, 120, Alim)
        e.Graphics.DrawString("DEBITO FISCAL", nFon, Brushes.Black, 700, 120, Alim)
        e.Graphics.DrawString("TOTAL", nFon, Brushes.Black, 800, 120, Alim)
        e.Graphics.DrawLine(Pens.Black, 40, 120, 800, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 135, 800, 135)

        For i = 150 To 1035 Step 15
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("NIT"), sFon, Brushes.Black, 90, i, Alim)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("RAZON"), sFon, Brushes.Black, 110, i)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("FACTURA"), sFon, Brushes.Black, 500, i, Alim)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("AUTORIZACION"), sFon, Brushes.Black, 600, i, Alim)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("DEBITO_FISCAL"), sFon, Brushes.Black, 700, i, Alim)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("IMPORTE_VENTA"), sFon, Brushes.Black, 800, i, Alim)
            f += 1
            If f = ds.Tables("Rep").Rows.Count Then
                Exit For
            End If
        Next

        If f = ds.Tables("REP").Rows.Count Then

            '--- IMPRIMIR gran TOTAL DEL SERVICIO
            i += 15
            e.Graphics.DrawLine(Pens.Black, 50, i, 800, i)
            e.Graphics.DrawString("TOTAL GENERAL", nFon, Brushes.Black, 350, i)
            e.Graphics.DrawString(Format(Val(txtDebito.Text), "#0.00"), nFon, Brushes.Black, 700, i, Alim)
            e.Graphics.DrawString(Format(Val(TxtImpTotal.Text), "#0.00"), nFon, Brushes.Black, 800, i, Alim)

            nPagina = 1
            f = 0
            e.HasMorePages = False
        Else
            nPagina += 1
            e.HasMorePages = True
        End If
    End Sub

    Private Sub btnImprimirNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirNuevo.Click
        da.SelectCommand.CommandText = "Select * From LIBRO Where ESTADO = 'V' And Comprobante = " & nRep_Comprobante & " AND SERVICIO = 2"
        da.Fill(ds, "REP")
        If ds.Tables("REP").Rows.Count > 0 Then
            nPagina = 1
            i = 0
            f = 0
            VerRep.Document = Rep
            VerRep.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        da.SelectCommand.CommandText = "Select * From Ver_Otras_Ventas_Reporte Where Comprobante = " & nRep_Comprobante
        da.Fill(ds, "REP")
        If ds.Tables("REP").Rows.Count > 0 Then
            nPagina = 1
            i = 0
            f = 0
            VerRep.Document = RepCla
            VerRep.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub RepCla_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles RepCla.PrintPage
        Dim tFon As New Font("Arial Narrow", 14, FontStyle.Bold)
        Dim sFon As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim nFon As New Font("Arial Narrow", 8, FontStyle.Bold)
        Dim mFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim Alim As New System.Drawing.StringFormat(StringFormatFlags.DirectionRightToLeft)

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("OTRAS VENTAS CLASIFICADO", tFon, Brushes.Black, 270, 50)
        e.Graphics.DrawString("Correspondiente a la fecha:" & FormatDateTime(ds.Tables("Rep").Rows(0).Item("Fecha"), DateFormat.ShortDate), nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Comprobante: " & ds.Tables("Rep").Rows(0).Item("comprobante"), mFon, Brushes.Black, 650, 50)
        e.Graphics.DrawString("Página: " & nPagina, mFon, Brushes.Black, 650, 65)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 800, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 800, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 800, 40, 800, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 600, 40, 600, 95)

        e.Graphics.DrawString("DESCRIPCION", nFon, Brushes.Black, 90, 120)
        e.Graphics.DrawString("TOTAL", nFon, Brushes.Black, 800, 120, Alim)
        e.Graphics.DrawLine(Pens.Black, 40, 120, 800, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 135, 800, 135)

        For i = 140 To 1035 Step 15
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("DESCRIPCION"), sFon, Brushes.Black, 90, i)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("IMPORTE"), sFon, Brushes.Black, 800, i, Alim)
            f += 1
            If f = ds.Tables("Rep").Rows.Count Then
                Exit For
            End If
        Next

        If f = ds.Tables("REP").Rows.Count Then

            '--- IMPRIMIR gran TOTAL DEL SERVICIO
            i += 15
            e.Graphics.DrawLine(Pens.Black, 50, i, 800, i)
            e.Graphics.DrawString("TOTAL GENERAL", nFon, Brushes.Black, 350, i)
            e.Graphics.DrawString(Format(Val(TxtImpTotal.Text), "#0.00"), nFon, Brushes.Black, 800, i, Alim)

            nPagina = 1
            f = 0
            e.HasMorePages = False
        Else
            nPagina += 1
            e.HasMorePages = True
        End If
    End Sub
End Class