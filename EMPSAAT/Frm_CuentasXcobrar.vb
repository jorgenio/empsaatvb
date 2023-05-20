Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_CuentasXcobrar
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim cmd As New SqlCommand
    Dim nPag As Integer
    Dim f As Integer
    Dim i As Integer
    Dim cCat As String
    Dim dEmi As Date

    Dim sImp As Double
    Dim sAlc As Double
    Dim sRep As Double
    Dim sRec As Double
    Dim sCa1 As Double
    Dim sCa2 As Double
    Dim sTot As Double
    Dim sDes As Double
    Dim sDAl As Double

    Dim cImp As Double
    Dim cAlc As Double
    Dim cRep As Double
    Dim cRec As Double
    Dim cCa1 As Double
    Dim cCa2 As Double
    Dim cTot As Double
    Dim cDes As Double
    Dim cDAl As Double

    Dim tImp As Double
    Dim tAlc As Double
    Dim tRep As Double
    Dim tRec As Double
    Dim tCa1 As Double
    Dim tCa2 As Double
    Dim tTot As Double
    Dim tDes As Double
    Dim tDAl As Double

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Imp_Resumen(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpResumen.Click
        Dim oRptDir As New Rep_Cuentas_X_Cobrar2
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        Dim cmd As New SqlCommand
        Dim xFec As New SqlParameter

        Try
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rep_cuentas_x_cobrar"
                xFec = .Parameters.Add("@FECHA", SqlDbType.DateTime)
                xFec.Direction = ParameterDirection.Input
                xFec.Value = Fecha.Value
                .ExecuteNonQuery()
            End With

            oConexInfo.ServerName = "SERVIDORHP"
            oConexInfo.DatabaseName = "EMPSAAT"
            oConexInfo.UserID = _Usuario
            oConexInfo.Password = _Clave

            oListaTablas = oRptDir.Database.Tables

            For Each oTabla In oListaTablas
                oTablaConexInfo = oTabla.LogOnInfo
                oTablaConexInfo.ConnectionInfo = oConexInfo
                oTabla.ApplyLogOnInfo(oTablaConexInfo)
            Next

            Dim fRep As New Frm_Reportes
            fRep.crvRep.ReportSource = oRptDir
            fRep.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Frm_CuentasXcobrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fecha.MaxDate = Date.Now
        Fecha.Value = Date.Now
    End Sub


    Private Sub ImpDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpDetalle.Click
        Dim oRptDir As New Rep_Cuentas_X_Cobrar2Detalle
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        Dim Cmd As New SqlCommand
        Dim xFec As New SqlParameter
        Try
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "rep_cuentas_x_cobrar"
                xFec = .Parameters.Add("@FECHA", SqlDbType.DateTime)
                xFec.Direction = ParameterDirection.Input
                xFec.Value = Fecha.Value
                .ExecuteNonQuery()
            End With

            oConexInfo.ServerName = "SERVIDORHP"
            oConexInfo.DatabaseName = "EMPSAAT"
            oConexInfo.UserID = _Usuario
            oConexInfo.Password = _Clave

            oListaTablas = oRptDir.Database.Tables

            For Each oTabla In oListaTablas
                oTablaConexInfo = oTabla.LogOnInfo
                oTablaConexInfo.ConnectionInfo = oConexInfo
                oTabla.ApplyLogOnInfo(oTablaConexInfo)
            Next

            Dim fRep As New Frm_Reportes
            fRep.crvRep.ReportSource = oRptDir
            fRep.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub ImprimirResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirResumen.Click
        Try
            da.SelectCommand.CommandText = "SELECT CATEGORIA, EMISION, COUNT(ABONADO) AS NRO, SUM(IMP_TOTAL) AS IMP_TOTAL, SUM(IMP_ALCANTA) AS IMP_ALCANTA, SUM(IMP_REP) AS IMP_REP, SUM(IMP_RECARGO) AS IMP_RECARGO, SUM(IMP_CAR_1) AS IMP_CAR_1, SUM(IMP_CAR_2) AS IMP_CAR_2, SUM(IMP_DESCUENTO) AS IMP_DESCUENTO, SUM(IMP_DESALCAN) AS IMP_DESALCAN, SUM(IMP_FACTURA) AS IMP_FACTURA FROM VER_FACTURAS_CANCELADAS WHERE  ((Fec_Pago IS Null OR fec_pago > '" & FormatDateTime(Fecha.Value, DateFormat.ShortDate) & " 23:59:59') and not emision >  '" & FormatDateTime(Fecha.Value, DateFormat.ShortDate) & "') AND Imp_Factura > 0 And Servicio = '1' GROUP BY CATEGORIA, EMISION ORDER BY CATEGORIA, EMISION"
            da.Fill(ds, "REP")
            If ds.Tables("REP").Rows.Count > 0 Then
                sImp = 0
                sAlc = 0
                sRep = 0
                sRec = 0
                sCa1 = 0
                sCa2 = 0
                sTot = 0
                tImp = 0
                tAlc = 0
                tRep = 0
                tRec = 0
                tCa1 = 0
                tCa2 = 0
                tTot = 0
                tDes = 0
                tDAl = 0

                f = 0
                nPag = 1
                cCat = ""
                VerDoc.Document = DocR
                VerDoc.ShowDialog()
            End If
            ds.Tables("REP").Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub DocR_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles DocR.PrintPage
        Dim tFon As New Font("Arial Narrow", 14, FontStyle.Bold)
        Dim sFon As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim nFon As New Font("Arial Narrow", 8, FontStyle.Bold)
        Dim mFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim Alim As New System.Drawing.StringFormat(StringFormatFlags.DirectionRightToLeft)

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("CUENTAS X COBRAR RESUMEN", tFon, Brushes.Black, 270, 50)
        e.Graphics.DrawString("A la fecha de:" & FormatDateTime(Fecha.Value, DateFormat.ShortDate), nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Página: " & nPag, mFon, Brushes.Black, 650, 65)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 790, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 790, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 790, 40, 790, 95)
        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        e.Graphics.DrawString("PERIODO", nFon, Brushes.Black, 40, 120)
        e.Graphics.DrawString("NRO", nFon, Brushes.Black, 160, 120, Alim)
        e.Graphics.DrawString("IMPORTE", nFon, Brushes.Black, 230, 120, Alim)
        e.Graphics.DrawString("ALCANTA", nFon, Brushes.Black, 300, 120, Alim)
        e.Graphics.DrawString("REPOS", nFon, Brushes.Black, 370, 120, Alim)
        e.Graphics.DrawString("RECARGO", nFon, Brushes.Black, 440, 120, Alim)
        e.Graphics.DrawString("CARGO 1", nFon, Brushes.Black, 510, 120, Alim)
        e.Graphics.DrawString("CARGO 2", nFon, Brushes.Black, 580, 120, Alim)
        e.Graphics.DrawString("DESCTO", nFon, Brushes.Black, 650, 120, Alim)
        e.Graphics.DrawString("DESCAL", nFon, Brushes.Black, 720, 120, Alim)
        e.Graphics.DrawString("TOTAL", nFon, Brushes.Black, 790, 120, Alim)
        e.Graphics.DrawLine(Pens.Black, 40, 120, 790, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 135, 790, 135)

        For i = 150 To 1035 Step 15
            If cCat <> ds.Tables("REP").Rows(f).Item("CATEGORIA") Then
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("CATEGORIA"), nFon, Brushes.Black, 40, i)
                cCat = ds.Tables("REP").Rows(f).Item("CATEGORIA")
            Else
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("EMISION"), sFon, Brushes.Black, 40, i)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("NRO"), sFon, Brushes.Black, 160, i, Alim)
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_TOTAL"), "#0.00"), sFon, Brushes.Black, 230, i, Alim)
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_ALCANTA"), "#0.00"), sFon, Brushes.Black, 300, i, Alim)
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_REP"), "#0.00"), sFon, Brushes.Black, 370, i, Alim)
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_RECARGO"), "#0.00"), sFon, Brushes.Black, 440, i, Alim)
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_CAR_1"), "#0.00"), sFon, Brushes.Black, 510, i, Alim)
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_CAR_2"), "#0.00"), sFon, Brushes.Black, 580, i, Alim)
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_DESCUENTO"), "#0.00"), sFon, Brushes.Black, 650, i, Alim)
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_DESALCAN"), "#0.00"), sFon, Brushes.Black, 720, i, Alim)
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_FACTURA"), "#0.00"), sFon, Brushes.Black, 790, i, Alim)

                sImp += ds.Tables("REP").Rows(f).Item("IMP_TOTAL")
                sAlc += ds.Tables("REP").Rows(f).Item("IMP_ALCANTA")
                sRep += ds.Tables("REP").Rows(f).Item("IMP_REP")
                sRec += ds.Tables("REP").Rows(f).Item("IMP_RECARGO")
                sCa1 += ds.Tables("REP").Rows(f).Item("IMP_CAR_1")
                sCa2 += ds.Tables("REP").Rows(f).Item("IMP_CAR_2")
                sTot += ds.Tables("REP").Rows(f).Item("IMP_FACTURA")
                sDes += ds.Tables("REP").Rows(f).Item("IMP_DESCUENTO")
                sDAl += ds.Tables("REP").Rows(f).Item("IMP_DESALCAN")

                tImp += ds.Tables("REP").Rows(f).Item("IMP_TOTAL")
                tAlc += ds.Tables("REP").Rows(f).Item("IMP_ALCANTA")
                tRep += ds.Tables("REP").Rows(f).Item("IMP_REP")
                tRec += ds.Tables("REP").Rows(f).Item("IMP_RECARGO")
                tCa1 += ds.Tables("REP").Rows(f).Item("IMP_CAR_1")
                tCa2 += ds.Tables("REP").Rows(f).Item("IMP_CAR_2")
                tTot += ds.Tables("REP").Rows(f).Item("IMP_FACTURA")
                tDes += ds.Tables("REP").Rows(f).Item("IMP_DESCUENTO")
                tDAl += ds.Tables("REP").Rows(f).Item("IMP_DESALCAN")
                f += 1
            End If

            If f = ds.Tables("REP").Rows.Count Then
                Exit For
            Else
                If ds.Tables("REP").Rows(f).Item("CATEGORIA") <> cCat Then
                    i += 15
                    e.Graphics.DrawLine(Pens.Black, 40, i, 790, i)
                    e.Graphics.DrawString(Format(sImp, "#0.00"), sFon, Brushes.Black, 230, i, Alim)
                    e.Graphics.DrawString(Format(sAlc, "#0.00"), sFon, Brushes.Black, 300, i, Alim)
                    e.Graphics.DrawString(Format(sRep, "#0.00"), sFon, Brushes.Black, 370, i, Alim)
                    e.Graphics.DrawString(Format(sRec, "#0.00"), sFon, Brushes.Black, 440, i, Alim)
                    e.Graphics.DrawString(Format(sCa1, "#0.00"), sFon, Brushes.Black, 510, i, Alim)
                    e.Graphics.DrawString(Format(sCa2, "#0.00"), sFon, Brushes.Black, 580, i, Alim)
                    e.Graphics.DrawString(Format(sDes, "#0.00"), sFon, Brushes.Black, 650, i, Alim)
                    e.Graphics.DrawString(Format(sDAl, "#0.00"), sFon, Brushes.Black, 720, i, Alim)
                    e.Graphics.DrawString(Format(sTot, "#0.00"), sFon, Brushes.Black, 790, i, Alim)

                    sImp = 0
                    sAlc = 0
                    sRep = 0
                    sRec = 0
                    sCa1 = 0
                    sCa2 = 0
                    sTot = 0
                    sDes = 0
                    sDAl = 0
                End If
            End If
        Next

        If f = ds.Tables("REP").Rows.Count Then
            i += 15
            e.Graphics.DrawLine(Pens.Black, 40, i, 790, i)
            e.Graphics.DrawString(Format(sImp, "#0.00"), sFon, Brushes.Black, 230, i, Alim)
            e.Graphics.DrawString(Format(sAlc, "#0.00"), sFon, Brushes.Black, 300, i, Alim)
            e.Graphics.DrawString(Format(sRep, "#0.00"), sFon, Brushes.Black, 370, i, Alim)
            e.Graphics.DrawString(Format(sRec, "#0.00"), sFon, Brushes.Black, 440, i, Alim)
            e.Graphics.DrawString(Format(sCa1, "#0.00"), sFon, Brushes.Black, 510, i, Alim)
            e.Graphics.DrawString(Format(sCa2, "#0.00"), sFon, Brushes.Black, 580, i, Alim)
            e.Graphics.DrawString(Format(sDes, "#0.00"), sFon, Brushes.Black, 650, i, Alim)
            e.Graphics.DrawString(Format(sDAl, "#0.00"), sFon, Brushes.Black, 720, i, Alim)
            e.Graphics.DrawString(Format(sTot, "#0.00"), sFon, Brushes.Black, 790, i, Alim)

            sImp = 0
            sAlc = 0
            sRep = 0
            sRec = 0
            sCa1 = 0
            sCa2 = 0
            sTot = 0
            sDes = 0
            sDAl = 0

            i += 15
            e.Graphics.DrawLine(Pens.Black, 40, i, 790, i)
            e.Graphics.DrawString(Format(tImp, "#0.00"), nFon, Brushes.Black, 230, i, Alim)
            e.Graphics.DrawString(Format(tAlc, "#0.00"), nFon, Brushes.Black, 300, i, Alim)
            e.Graphics.DrawString(Format(tRep, "#0.00"), nFon, Brushes.Black, 370, i, Alim)
            e.Graphics.DrawString(Format(tRec, "#0.00"), nFon, Brushes.Black, 440, i, Alim)
            e.Graphics.DrawString(Format(tCa1, "#0.00"), nFon, Brushes.Black, 510, i, Alim)
            e.Graphics.DrawString(Format(tCa2, "#0.00"), nFon, Brushes.Black, 580, i, Alim)
            e.Graphics.DrawString(Format(tDes, "#0.00"), nFon, Brushes.Black, 650, i, Alim)
            e.Graphics.DrawString(Format(tDAl, "#0.00"), nFon, Brushes.Black, 720, i, Alim)
            e.Graphics.DrawString(Format(tTot, "#0.00"), nFon, Brushes.Black, 790, i, Alim)
            tImp = 0
            tAlc = 0
            tRep = 0
            tRec = 0
            tCa1 = 0
            tCa2 = 0
            tTot = 0
            tDes = 0
            tDAl = 0
            f = 0
            nPag = 1
            cCat = ""
            e.HasMorePages = False
        Else
            nPag += 1
            e.HasMorePages = True
        End If
    End Sub

    Private Sub DocD_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles DocD.PrintPage
        Dim tFon As New Font("Arial Narrow", 14, FontStyle.Bold)
        Dim sFon As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim nFon As New Font("Arial Narrow", 8, FontStyle.Bold)
        Dim mFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim Alim As New System.Drawing.StringFormat(StringFormatFlags.DirectionRightToLeft)

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("CUENTAS X COBRAR RESUMEN", tFon, Brushes.Black, 270, 50)
        e.Graphics.DrawString("A la fecha de:" & FormatDateTime(Fecha.Value, DateFormat.ShortDate), nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Página: " & nPag, mFon, Brushes.Black, 650, 65)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 790, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 790, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 790, 40, 790, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        e.Graphics.DrawString("ABNDO", nFon, Brushes.Black, 40, 120)
        e.Graphics.DrawString("RAZON SOCIAL", nFon, Brushes.Black, 90, 120)
        e.Graphics.DrawString("IMPORTE", nFon, Brushes.Black, 390, 120, Alim)
        e.Graphics.DrawString("ALCANTA", nFon, Brushes.Black, 440, 120, Alim)
        e.Graphics.DrawString("REPOS", nFon, Brushes.Black, 490, 120, Alim)
        e.Graphics.DrawString("RECARGO", nFon, Brushes.Black, 540, 120, Alim)
        e.Graphics.DrawString("CARGO 1", nFon, Brushes.Black, 590, 120, Alim)
        e.Graphics.DrawString("CARGO 2", nFon, Brushes.Black, 640, 120, Alim)
        e.Graphics.DrawString("DESCTO", nFon, Brushes.Black, 690, 120, Alim)
        e.Graphics.DrawString("DESCAL", nFon, Brushes.Black, 740, 120, Alim)
        e.Graphics.DrawString("TOTAL", nFon, Brushes.Black, 790, 120, Alim)
        e.Graphics.DrawLine(Pens.Black, 40, 120, 790, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 135, 790, 135)

        For i = 135 To 1050 Step 12
            If cCat <> ds.Tables("REP").Rows(f).Item("CATEGORIA") Then
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("CATEGORIA"), nFon, Brushes.Black, 40, i)
                cCat = ds.Tables("REP").Rows(f).Item("CATEGORIA")
                i += 15
            End If

            If dEmi <> ds.Tables("REP").Rows(f).Item("EMISION") Then
                e.Graphics.DrawString("PERIODO: " & FormatDateTime(ds.Tables("REP").Rows(f).Item("EMISION"), DateFormat.ShortDate), nFon, Brushes.Black, 40, i)
                dEmi = ds.Tables("REP").Rows(f).Item("EMISION")
                i += 15
            End If

            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("ABONADO"), sFon, Brushes.Black, 70, i, Alim)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("RAZON"), sFon, Brushes.Black, 90, i)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_TOTAL"), "#0.00"), sFon, Brushes.Black, 390, i, Alim)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_ALCANTA"), "#0.00"), sFon, Brushes.Black, 440, i, Alim)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_REP"), "#0.00"), sFon, Brushes.Black, 490, i, Alim)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_RECARGO"), "#0.00"), sFon, Brushes.Black, 540, i, Alim)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_CAR_1"), "#0.00"), sFon, Brushes.Black, 590, i, Alim)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_CAR_2"), "#0.00"), sFon, Brushes.Black, 640, i, Alim)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_DESCUENTO"), "#0.00"), sFon, Brushes.Black, 690, i, Alim)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_DESALCAN"), "#0.00"), sFon, Brushes.Black, 740, i, Alim)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_FACTURA"), "#0.00"), sFon, Brushes.Black, 790, i, Alim)

            sImp += ds.Tables("REP").Rows(f).Item("IMP_TOTAL")
            sAlc += ds.Tables("REP").Rows(f).Item("IMP_ALCANTA")
            sRep += ds.Tables("REP").Rows(f).Item("IMP_REP")
            sRec += ds.Tables("REP").Rows(f).Item("IMP_RECARGO")
            sCa1 += ds.Tables("REP").Rows(f).Item("IMP_CAR_1")
            sCa2 += ds.Tables("REP").Rows(f).Item("IMP_CAR_2")
            sTot += ds.Tables("REP").Rows(f).Item("IMP_FACTURA")
            sDes += ds.Tables("REP").Rows(f).Item("IMP_DESCUENTO")
            sDAl += ds.Tables("REP").Rows(f).Item("IMP_DESALCAN")

            cImp += ds.Tables("REP").Rows(f).Item("IMP_TOTAL")
            cAlc += ds.Tables("REP").Rows(f).Item("IMP_ALCANTA")
            cRep += ds.Tables("REP").Rows(f).Item("IMP_REP")
            cRec += ds.Tables("REP").Rows(f).Item("IMP_RECARGO")
            cCa1 += ds.Tables("REP").Rows(f).Item("IMP_CAR_1")
            cCa2 += ds.Tables("REP").Rows(f).Item("IMP_CAR_2")
            cTot += ds.Tables("REP").Rows(f).Item("IMP_FACTURA")
            cDes += ds.Tables("REP").Rows(f).Item("IMP_DESCUENTO")
            cDAl += ds.Tables("REP").Rows(f).Item("IMP_DESALCAN")

            tImp += ds.Tables("REP").Rows(f).Item("IMP_TOTAL")
            tAlc += ds.Tables("REP").Rows(f).Item("IMP_ALCANTA")
            tRep += ds.Tables("REP").Rows(f).Item("IMP_REP")
            tRec += ds.Tables("REP").Rows(f).Item("IMP_RECARGO")
            tCa1 += ds.Tables("REP").Rows(f).Item("IMP_CAR_1")
            tCa2 += ds.Tables("REP").Rows(f).Item("IMP_CAR_2")
            tTot += ds.Tables("REP").Rows(f).Item("IMP_FACTURA")
            tDes += ds.Tables("REP").Rows(f).Item("IMP_DESCUENTO")
            tDAl += ds.Tables("REP").Rows(f).Item("IMP_DESALCAN")

            f += 1

            If f = ds.Tables("REP").Rows.Count Then
                Exit For
            End If

            If dEmi <> ds.Tables("REP").Rows(f).Item("EMISION") Then
                i += 15
                e.Graphics.DrawLine(Pens.Black, 40, i, 790, i)
                e.Graphics.DrawString("SUB TOTAL PARA EL PERIODO: " & dEmi, sFon, Brushes.Black, 40, i)
                e.Graphics.DrawString(Format(sImp, "#0.00"), sFon, Brushes.Black, 390, i, Alim)
                e.Graphics.DrawString(Format(sAlc, "#0.00"), sFon, Brushes.Black, 440, i, Alim)
                e.Graphics.DrawString(Format(sRep, "#0.00"), sFon, Brushes.Black, 490, i, Alim)
                e.Graphics.DrawString(Format(sRec, "#0.00"), sFon, Brushes.Black, 540, i, Alim)
                e.Graphics.DrawString(Format(sCa1, "#0.00"), sFon, Brushes.Black, 590, i, Alim)
                e.Graphics.DrawString(Format(sCa2, "#0.00"), sFon, Brushes.Black, 640, i, Alim)
                e.Graphics.DrawString(Format(sDes, "#0.00"), sFon, Brushes.Black, 690, i, Alim)
                e.Graphics.DrawString(Format(sDAl, "#0.00"), sFon, Brushes.Black, 740, i, Alim)
                e.Graphics.DrawString(Format(sTot, "#0.00"), sFon, Brushes.Black, 790, i, Alim)

                sImp = 0
                sAlc = 0
                sRep = 0
                sRec = 0
                sCa1 = 0
                sCa2 = 0
                sTot = 0
                sDes = 0
                sDAl = 0
            End If

            If cCat <> ds.Tables("REP").Rows(f).Item("CATEGORIA") Then
                i += 15
                e.Graphics.DrawLine(Pens.Black, 40, i, 790, i)
                e.Graphics.DrawString("TOTAL PARA LA CATEGORIA: " & cCat, sFon, Brushes.Black, 40, i)
                e.Graphics.DrawString(Format(cImp, "#0.00"), sFon, Brushes.Black, 390, i, Alim)
                e.Graphics.DrawString(Format(cAlc, "#0.00"), sFon, Brushes.Black, 440, i, Alim)
                e.Graphics.DrawString(Format(cRep, "#0.00"), sFon, Brushes.Black, 490, i, Alim)
                e.Graphics.DrawString(Format(cRec, "#0.00"), sFon, Brushes.Black, 540, i, Alim)
                e.Graphics.DrawString(Format(cCa1, "#0.00"), sFon, Brushes.Black, 590, i, Alim)
                e.Graphics.DrawString(Format(cCa2, "#0.00"), sFon, Brushes.Black, 640, i, Alim)
                e.Graphics.DrawString(Format(cDes, "#0.00"), sFon, Brushes.Black, 690, i, Alim)
                e.Graphics.DrawString(Format(cDAl, "#0.00"), sFon, Brushes.Black, 740, i, Alim)
                e.Graphics.DrawString(Format(cTot, "#0.00"), sFon, Brushes.Black, 790, i, Alim)

                cImp = 0
                cAlc = 0
                cRep = 0
                cRec = 0
                cCa1 = 0
                cCa2 = 0
                cTot = 0
                cDes = 0
                cDAl = 0
            End If

        Next

        If f = ds.Tables("REP").Rows.Count Then

            i += 15
            e.Graphics.DrawLine(Pens.Black, 40, i, 790, i)
            e.Graphics.DrawString("SUB TOTAL PARA EL PERIODO: " & dEmi, sFon, Brushes.Black, 40, i)
            e.Graphics.DrawString(Format(sImp, "#0.00"), sFon, Brushes.Black, 390, i, Alim)
            e.Graphics.DrawString(Format(sAlc, "#0.00"), sFon, Brushes.Black, 440, i, Alim)
            e.Graphics.DrawString(Format(sRep, "#0.00"), sFon, Brushes.Black, 490, i, Alim)
            e.Graphics.DrawString(Format(sRec, "#0.00"), sFon, Brushes.Black, 540, i, Alim)
            e.Graphics.DrawString(Format(sCa1, "#0.00"), sFon, Brushes.Black, 590, i, Alim)
            e.Graphics.DrawString(Format(sCa2, "#0.00"), sFon, Brushes.Black, 640, i, Alim)
            e.Graphics.DrawString(Format(sDes, "#0.00"), sFon, Brushes.Black, 690, i, Alim)
            e.Graphics.DrawString(Format(sDAl, "#0.00"), sFon, Brushes.Black, 740, i, Alim)
            e.Graphics.DrawString(Format(sTot, "#0.00"), sFon, Brushes.Black, 790, i, Alim)

            sImp = 0
            sAlc = 0
            sRep = 0
            sRec = 0
            sCa1 = 0
            sCa2 = 0
            sTot = 0
            sDes = 0
            sDAl = 0

            i += 15
            e.Graphics.DrawLine(Pens.Black, 40, i, 790, i)
            e.Graphics.DrawString("TOTAL PARA LA CATEGORIA: " & cCat, nFon, Brushes.Black, 40, i)
            e.Graphics.DrawString(Format(cImp, "#0.00"), sFon, Brushes.Black, 390, i, Alim)
            e.Graphics.DrawString(Format(cAlc, "#0.00"), sFon, Brushes.Black, 440, i, Alim)
            e.Graphics.DrawString(Format(cRep, "#0.00"), sFon, Brushes.Black, 490, i, Alim)
            e.Graphics.DrawString(Format(cRec, "#0.00"), sFon, Brushes.Black, 540, i, Alim)
            e.Graphics.DrawString(Format(cCa1, "#0.00"), sFon, Brushes.Black, 590, i, Alim)
            e.Graphics.DrawString(Format(cCa2, "#0.00"), sFon, Brushes.Black, 640, i, Alim)
            e.Graphics.DrawString(Format(cDes, "#0.00"), sFon, Brushes.Black, 690, i, Alim)
            e.Graphics.DrawString(Format(cDAl, "#0.00"), sFon, Brushes.Black, 740, i, Alim)
            e.Graphics.DrawString(Format(cTot, "#0.00"), sFon, Brushes.Black, 790, i, Alim)


            cImp = 0
            cAlc = 0
            cRep = 0
            cRec = 0
            cCa1 = 0
            cCa2 = 0
            cTot = 0
            cDes = 0
            cDAl = 0
            i += 15

            e.Graphics.DrawLine(Pens.Black, 40, i, 790, i)
            e.Graphics.DrawString("T O T A L    G E N E R A L: ", nFon, Brushes.Black, 40, i)
            e.Graphics.DrawString(Format(tImp, "#0.00"), sFon, Brushes.Black, 390, i, Alim)
            e.Graphics.DrawString(Format(tAlc, "#0.00"), sFon, Brushes.Black, 440, i, Alim)
            e.Graphics.DrawString(Format(tRep, "#0.00"), sFon, Brushes.Black, 490, i, Alim)
            e.Graphics.DrawString(Format(tRec, "#0.00"), sFon, Brushes.Black, 540, i, Alim)
            e.Graphics.DrawString(Format(tCa1, "#0.00"), sFon, Brushes.Black, 590, i, Alim)
            e.Graphics.DrawString(Format(tCa2, "#0.00"), sFon, Brushes.Black, 640, i, Alim)
            e.Graphics.DrawString(Format(tDes, "#0.00"), sFon, Brushes.Black, 690, i, Alim)
            e.Graphics.DrawString(Format(tDAl, "#0.00"), sFon, Brushes.Black, 740, i, Alim)
            e.Graphics.DrawString(Format(tTot, "#0.00"), sFon, Brushes.Black, 790, i, Alim)

            i += 15
            e.Graphics.DrawLine(Pens.Black, 40, i, 790, i)

            tImp = 0
            tAlc = 0
            tRep = 0
            tRec = 0
            tCa1 = 0
            tCa2 = 0
            tTot = 0
            tDes = 0
            tDAl = 0

            f = 0
            nPag = 1
            cCat = ""
            dEmi = Date.Now
            e.HasMorePages = False
        Else
            nPag += 1
            e.HasMorePages = True
        End If

    End Sub

    
    Private Sub btnImprimirDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirDetalle.Click
        Try
            da.SelectCommand.CommandText = "SELECT * FROM VER_FACTURAS_CANCELADAS WHERE ((Fec_Pago IS Null OR fec_pago > '" & FormatDateTime(Fecha.Value, DateFormat.ShortDate) & " 23:59:59') and not emision >  '" & FormatDateTime(Fecha.Value, DateFormat.ShortDate) & "') AND Imp_Factura > 0 And Servicio = '1' ORDER BY CATEGORIA, EMISION, ABONADO"
            'da.SelectCommand.CommandText = "SELECT CATEGORIA, EMISION, COUNT(ABONADO) AS NRO, SUM(IMP_TOTAL) AS IMP_TOTAL, SUM(IMP_ALCANTA) AS IMP_ALCANTA, SUM(IMP_REP) AS IMP_REP, SUM(IMP_RECARGO) AS IMP_RECARGO, SUM(IMP_CAR_1) AS IMP_CAR_1, SUM(IMP_CAR_2) AS IMP_CAR_2, SUM(IMP_FACTURA) AS IMP_FACTURA FROM VER_FACTURAS_CANCELADAS WHERE Fec_Pago IS Null OR fec_pago > '" & FormatDateTime(Fecha.Value, DateFormat.ShortDate) & " 23:59:59' AND Imp_Factura > 0 And Servicio = '1' and not emision > '" & FormatDateTime(Fecha.Value, DateFormat.ShortDate) & "' GROUP BY CATEGORIA, EMISION ORDER BY CATEGORIA, EMISION"
            da.Fill(ds, "REP")
            If ds.Tables("REP").Rows.Count > 0 Then
                sImp = 0
                sAlc = 0
                sRep = 0
                sRec = 0
                sCa1 = 0
                sCa2 = 0
                sTot = 0
                tImp = 0
                tAlc = 0
                tRep = 0
                tRec = 0
                tCa1 = 0
                tCa2 = 0
                tTot = 0

                f = 0
                nPag = 1
                cCat = "" 'ds.Tables("REP").Rows(f).Item("CATEGORIA")
                dEmi = Date.Now ' ds.Tables("REP").Rows(f).Item("EMISION")
                VerDoc.Document = DocD
                VerDoc.ShowDialog()
            End If
            ds.Tables("REP").Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub
End Class