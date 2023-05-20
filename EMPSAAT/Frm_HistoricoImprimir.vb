Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_HistoricoImprimir
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim f As Integer
    Dim i As Integer
    Dim p As Integer
    Dim s As Double

    Private Sub Frm_HistoricoImprimir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'da.SelectCommand.CommandText = "Select Emision From Facturas where abonado = " & nAbonado & " and Servicio = 1 Order By Emision"
        da.SelectCommand.CommandText = "Select Emision From Factores Order By Emision desc"
        da.Fill(ds, "Emi")
        cboAl.DataSource = ds.Tables("Emi")
        cboAl.DisplayMember = "Emision"
        cboAl.ValueMember = "Emision"

        'da.SelectCommand.CommandText = "Select Emision From Facturas where abonado = " & nAbonado & " and Servicio = 1 Order By Emision"
        da.SelectCommand.CommandText = "Select Emision From factores Order by Emision"
        da.Fill(ds, "Del")
        cboDel.DataSource = ds.Tables("Del")
        cboDel.DisplayMember = "Emsion"
        cboDel.ValueMember = "Emision"
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim oRptDir As New Rep_Kardexhistorico
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        Dim cmd As New SqlCommand
        Dim xAbonado As SqlParameter
        Dim xInicio As SqlParameter
        Dim xFinal As SqlParameter

        Try
            oConexInfo.ServerName = "SERVIDORHP"
            oConexInfo.DatabaseName = "EMPSAAT"
            oConexInfo.UserID = _Usuario
            oConexInfo.Password = _Clave

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Rep_KardexHistorico"
                xAbonado = .Parameters.Add("@Abonado", SqlDbType.Int)
                xInicio = .Parameters.Add("@Inicial", SqlDbType.DateTime)
                xFinal = .Parameters.Add("@Final", SqlDbType.DateTime)
                xAbonado.Direction = ParameterDirection.Input
                xInicio.Direction = ParameterDirection.Input
                xFinal.Direction = ParameterDirection.Input
                xAbonado.Value = nAbonado
                xInicio.Value = cboDel.SelectedValue
                xFinal.Value = cboAl.SelectedValue
                .ExecuteNonQuery()
            End With

            oListaTablas = oRptDir.Database.Tables

            For Each oTabla In oListaTablas
                oTablaConexInfo = oTabla.LogOnInfo
                oTablaConexInfo.ConnectionInfo = oConexInfo
                oTabla.ApplyLogOnInfo(oTablaConexInfo)
            Next

            Dim fRep As New Frm_Reportes
            fRep.crvRep.ReportSource = oRptDir
            fRep.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub btnImprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        da.SelectCommand.CommandText = "Select * From Ver_Facturas_Historico Where Abonado = " & nAbonado & " And Emision between '" & cboDel.SelectedValue & "' and '" & cboAl.SelectedValue & "' AND SERVICIO = 1 Order By Emision"
        da.Fill(ds, "Rep")
        da.SelectCommand.CommandText = "Select * From Ver_Facturas_Canceladas Where Abonado = " & nAbonado & " And Emision between '" & cboDel.SelectedValue & "' and '" & cboAl.SelectedValue & "' AND SERVICIO = 1 Order By Emision"
        da.Fill(ds, "Rep")
        If ds.Tables("Rep").Rows.Count > 0 Then
            f = 0
            p = 1
            s = 0
            VerDoc.Document = Doc
            VerDoc.ShowDialog()
        End If
        Me.Close()
    End Sub

    Private Sub Doc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Doc.PrintPage
        Dim tFon As New Font("Arial Narrow", 14, FontStyle.Bold)
        Dim sFon As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim nFon As New Font("Arial Narrow", 8, FontStyle.Bold)
        Dim mFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim zTam As System.Drawing.SizeF

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("KARDEX DE ABONADO", tFon, Brushes.Black, 300, 50)
        e.Graphics.DrawString("Correspondiente a la fecha:" & FormatDateTime(Date.Now, DateFormat.ShortDate), nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Página: " & p, mFon, Brushes.Black, 650, 65)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 780, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 780, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 780, 40, 780, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        e.Graphics.DrawString("ABONADO", nFon, Brushes.Black, 40, 120)
        e.Graphics.DrawString("RAZON SOCIAL", nFon, Brushes.Black, 40, 135)
        e.Graphics.DrawString("DIRECCION", nFon, Brushes.Black, 40, 150)
        e.Graphics.DrawString("CATEGORIA", nFon, Brushes.Black, 500, 120)
        e.Graphics.DrawString("ESTADO", nFon, Brushes.Black, 500, 135)
        e.Graphics.DrawString("MEDIDOR", nFon, Brushes.Black, 500, 150)


        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("ABONADO"), sFon, Brushes.Black, 130, 120)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("RAZON"), sFon, Brushes.Black, 130, 135)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("ZONA") & " " & ds.Tables("REP").Rows(0).Item("CALLE") & " " & ds.Tables("REP").Rows(0).Item("NUM"), sFon, Brushes.Black, 130, 150)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("CATEGORIA"), sFon, Brushes.Black, 570, 120)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("ESTADO"), sFon, Brushes.Black, 570, 135)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("MEDIDOR"), sFon, Brushes.Black, 570, 150)

        e.Graphics.DrawString("EMISION", nFon, Brushes.Black, 40, 170)
        e.Graphics.DrawString("LECTURA", nFon, Brushes.Black, 100, 170)
        e.Graphics.DrawString("CON_M3", nFon, Brushes.Black, 160, 170)
        e.Graphics.DrawString("IMPORTE", nFon, Brushes.Black, 220, 170)
        e.Graphics.DrawString("ALCANTA", nFon, Brushes.Black, 280, 170)
        e.Graphics.DrawString("REPOS", nFon, Brushes.Black, 360, 170)
        e.Graphics.DrawString("RECARGO", nFon, Brushes.Black, 410, 170)
        e.Graphics.DrawString("CARGO 1", nFon, Brushes.Black, 490, 170)
        e.Graphics.DrawString("CARGO 2", nFon, Brushes.Black, 570, 170)
        e.Graphics.DrawString("TOTAL", nFon, Brushes.Black, 650, 170)
        e.Graphics.DrawString("PAGO", nFon, Brushes.Black, 730, 170)
        e.Graphics.DrawLine(Pens.Black, 40, 170, 780, 170)
        e.Graphics.DrawLine(Pens.Black, 40, 185, 780, 185)

        For i = 185 To 1035 Step 15
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("EMISION"), sFon, Brushes.Black, 40, i)
            zTam = e.Graphics.MeasureString(ds.Tables("REP").Rows(f).Item("LECTURA"), sFon)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("LECTURA"), sFon, Brushes.Black, 140 - zTam.Width, i)
            zTam = e.Graphics.MeasureString(ds.Tables("REP").Rows(f).Item("CON_M3"), sFon)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("CON_M3"), sFon, Brushes.Black, 190 - zTam.Width, i)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(f).Item("IMP_TOTAL"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_TOTAL"), "#0.00"), sFon, Brushes.Black, 260 - zTam.Width, i)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(f).Item("IMP_ALCANTA"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_ALCANTA"), "#0.00"), sFon, Brushes.Black, 330 - zTam.Width, i)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(f).Item("IMP_REP"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_REP"), "#0.00"), sFon, Brushes.Black, 390 - zTam.Width, i)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(f).Item("IMP_RECARGO"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_RECARGO"), "#0.00"), sFon, Brushes.Black, 460 - zTam.Width, i)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(f).Item("IMP_CAR_1"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_CAR_1"), "#0.00"), sFon, Brushes.Black, 540 - zTam.Width, i)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(f).Item("IMP_CAR_2"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_CAR_2"), "#0.00"), sFon, Brushes.Black, 620 - zTam.Width, i)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(f).Item("IMP_FACTURA"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_FACTURA"), "#0.00"), sFon, Brushes.Black, 690 - zTam.Width, i)
            s += ds.Tables("REP").Rows(f).Item("IMP_FACTURA")
            If Not IsDBNull(ds.Tables("REP").Rows(f).Item("FEC_PAGO")) Then
                e.Graphics.DrawString(FormatDateTime(ds.Tables("REP").Rows(f).Item("FEC_PAGO"), DateFormat.ShortDate), sFon, Brushes.Black, 720, i)
            End If
            f += 1
            If f = ds.Tables("REP").Rows.Count Then
                i += 15
                e.Graphics.DrawLine(Pens.Black, 40, i, 780, i)
                zTam = e.Graphics.MeasureString(Format(s, "#0.00"), nFon)
                e.Graphics.DrawString(Format(s, "#0.00"), nFon, Brushes.Black, 690 - zTam.Width, i)
                Exit For
            End If
        Next

        If f = ds.Tables("REP").Rows.Count Then
            f = 0
            p = 1
            s = 0
            e.HasMorePages = False
        Else
            p += 1
            e.HasMorePages = True
        End If
    End Sub

    
End Class