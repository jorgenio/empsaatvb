Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_RepDiarioDetalle
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim nPag As Integer
    Dim f As Integer
    Dim i As Integer
    Dim nSer As Integer
    Dim cCat As String
    Dim nImpTotal As Double
    Dim nImpAlcan As Double
    Dim nImpRepos As Double
    Dim nImpRecar As Double
    Dim nImpCar_1 As Double
    Dim nImpCar_2 As Double
    Dim nImpFactu As Double
    Dim nImpDescu As Double
    Dim nImpDesAl As Double

    Dim nsImpTotal As Double
    Dim nsImpAlcan As Double
    Dim nsImpRepos As Double
    Dim nsImpRecar As Double
    Dim nsImpCar_1 As Double
    Dim nsImpCar_2 As Double
    Dim nsImpFactu As Double
    Dim nsImpDescu As Double
    Dim nsImpDesAl As Double

    Dim gImpTotal As Double
    Dim gImpAlcan As Double
    Dim gImpRepos As Double
    Dim gImpRecar As Double
    Dim gImpCar_1 As Double
    Dim gImpCar_2 As Double
    Dim gImpFactu As Double
    Dim gImpDescu As Double
    Dim gImpDesAl As Double

    Private Sub Cerrar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Frm_RepDiarioDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Comprobantes Where Contabilizado = 0 Order By Comprobante Desc"
        da.Fill(ds, "Cbte")
        cboFecha.DataSource = ds.Tables("Cbte")
        cboFecha.DisplayMember = "Fecha"
        cboFecha.ValueMember = "Comprobante"
        Ver_Facturas()
    End Sub

    Private Sub Ver_Facturas()
        ds.Tables.Clear()

        da.SelectCommand.CommandText = "Select F.Factura, U.Abonado, U.Nombre, F.Emision, F.Num_Factura, F.Num_Orden, F.Imp_Factura, F.Servicio From Facturas F Inner Join Usuarios U On F.Abonado = U.Abonado Where F.Valida = 'V' And F.Comprobante = " & cboFecha.SelectedValue & " And F.Cajero = '" & _Usuario & "'"
        da.Fill(ds, "Dia")
        da.SelectCommand.CommandText = "Select Sum(Imp_Factura) as Imp From Facturas Where Comprobante = " & cboFecha.SelectedValue & " And Cajero = '" & _Usuario & "' And  Valida = 'V'"
        da.Fill(ds, "Sbt")
        da.SelectCommand.CommandText = "Select Count(*) as Nro From Facturas Where Comprobante = " & cboFecha.SelectedValue & " And Cajero = '" & _Usuario & "' And Valida = 'V'"
        da.Fill(ds, "Nro")
        da.SelectCommand.CommandText = "Select Sum(Imp_Factura) as Imp From Facturas Where Comprobante = " & cboFecha.SelectedValue & " And Valida = 'V'"
        da.Fill(ds, "Tot")
        da.SelectCommand.CommandText = "Select Count(*) as Nro From Facturas Where Comprobante = " & cboFecha.SelectedValue & " And Valida = 'V'"
        da.Fill(ds, "TNro")

        dgFacturas.DataSource = ds.Tables("Dia")
        TxtImporte.Text = IIf(IsDBNull(ds.Tables("Sbt").Rows(0).Item("Imp")), 0, ds.Tables("Sbt").Rows(0).Item("Imp"))
        txtNoFacturas.Text = IIf(IsDBNull(ds.Tables("Nro").Rows(0).Item("Nro")), 0, ds.Tables("Nro").Rows(0).Item("Nro"))
        TxtImpTotal.Text = IIf(IsDBNull(ds.Tables("Tot").Rows(0).Item("Imp")), 0, ds.Tables("Tot").Rows(0).Item("Imp"))
        txtNoTotFac.Text = IIf(IsDBNull(ds.Tables("TNro").Rows(0).Item("Nro")), 0, ds.Tables("TNro").Rows(0).Item("Nro"))
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Dim oRptDir As New Rep_Diario
        'Dim oConexInfo As New ConnectionInfo
        'Dim oListaTablas As Tables
        'Dim oTabla As Table
        'Dim oTablaConexInfo As TableLogOnInfo
        'Dim cmd As New SqlCommand
        'Dim xComprobante As SqlParameter

        'Try
        '    oConexInfo.ServerName = "SERVIDORHP"
        '    oConexInfo.DatabaseName = "EMPSAAT"
        '    oConexInfo.UserID = _Usuario
        '    oConexInfo.Password = _Clave

        '    db.Open()
        '    With cmd
        '        .Connection = db
        '        .CommandType = CommandType.StoredProcedure
        '        .CommandText = "Rep_Diario"
        '        xComprobante = .Parameters.Add("@Comprobante", SqlDbType.Int)
        '        xComprobante.Direction = ParameterDirection.Input
        '        xComprobante.Value = nRep_Comprobante
        '        .ExecuteNonQuery()
        '    End With

        '    oListaTablas = oRptDir.Database.Tables

        '    For Each oTabla In oListaTablas
        '        oTablaConexInfo = oTabla.LogOnInfo
        '        oTablaConexInfo.ConnectionInfo = oConexInfo
        '        oTabla.ApplyLogOnInfo(oTablaConexInfo)
        '    Next

        '    Dim fRep As New Frm_Reportes
        '    fRep.crvRep.ReportSource = oRptDir
        '    fRep.ShowDialog()
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        'Finally
        '    If db.State = ConnectionState.Open Then db.Close()
        'End Try
    End Sub


    Private Sub Doc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Doc.PrintPage
        Dim tFon As New Font("Arial Narrow", 14, FontStyle.Bold)
        Dim sFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim nFon As New Font("Arial Narrow", 7, FontStyle.Bold)
        Dim mFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim Alim As New System.Drawing.StringFormat(StringFormatFlags.DirectionRightToLeft)

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("DETALLE DE FACTURAS COBRADAS", tFon, Brushes.Black, 270, 50)
        e.Graphics.DrawString("Correspondiente a la fecha:" & FormatDateTime(ds.Tables("Rep").Rows(0).Item("Fecha"), DateFormat.ShortDate), nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Comprobante: " & ds.Tables("Rep").Rows(0).Item("Numero"), mFon, Brushes.Black, 650, 50)
        e.Graphics.DrawString("Página: " & nPag, mFon, Brushes.Black, 650, 65)
        e.Graphics.DrawString("Cajero: " & _Usuario, mFon, Brushes.Black, 650, 80)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 780, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 780, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 780, 40, 780, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        e.Graphics.DrawString("ABNDO", nFon, Brushes.Black, 60, 120, Alim)
        e.Graphics.DrawString("RAZON SOCIAL", nFon, Brushes.Black, 70, 120)
        e.Graphics.DrawString("FACTURA", nFon, Brushes.Black, 270, 120, Alim)
        e.Graphics.DrawString("MES", nFon, Brushes.Black, 310, 120, Alim)
        e.Graphics.DrawString("M3", nFon, Brushes.Black, 340, 120, Alim)
        e.Graphics.DrawString("IMPORTE", nFon, Brushes.Black, 390, 120, Alim)
        e.Graphics.DrawString("ALCANTA", nFon, Brushes.Black, 440, 120, Alim)
        e.Graphics.DrawString("REPOS", nFon, Brushes.Black, 490, 120, Alim)
        e.Graphics.DrawString("RECARGO", nFon, Brushes.Black, 540, 120, Alim)
        e.Graphics.DrawString("CARGO 1", nFon, Brushes.Black, 590, 120, Alim)
        e.Graphics.DrawString("CARGO 2", nFon, Brushes.Black, 640, 120, Alim)
        e.Graphics.DrawString("DESCTO", nFon, Brushes.Black, 690, 120, Alim)
        e.Graphics.DrawString("DES ALC", nFon, Brushes.Black, 750, 120, Alim)
        e.Graphics.DrawString("TOTAL", nFon, Brushes.Black, 790, 120, Alim)
        e.Graphics.DrawLine(Pens.Black, 30, 120, 790, 120)
        e.Graphics.DrawLine(Pens.Black, 30, 135, 790, 135)

        For i = 150 To 1035 Step 15
            If nSer <> ds.Tables("REP").Rows(f).Item("SERVICIO") Then
                nSer = ds.Tables("REP").Rows(f).Item("SERVICIO")
                If nSer = 1 Then
                    e.Graphics.DrawString("CONSUMO DE AGUA POTABLE", nFon, Brushes.Black, 40, i)
                Else
                    e.Graphics.DrawString("OTRAS VENTAS", nFon, Brushes.Black, 40, i)
                End If
            Else
                If cCat <> ds.Tables("REP").Rows(f).Item("CATEGORIA") Then
                    cCat = ds.Tables("REP").Rows(f).Item("CATEGORIA")
                    e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("CATEGORIA"), nFon, Brushes.Black, 50, i)
                Else
                    e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("ABONADO"), sFon, Brushes.Black, 60, i, Alim)
                    e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("RAZON"), sFon, Brushes.Black, 70, i)
                    e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("Num_Factura"), sFon, Brushes.Black, 270, i, Alim)
                    e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("EMISION"), "MMM/yy"), mFon, Brushes.Black, 310, i, Alim)
                    e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("CON_M3"), sFon, Brushes.Black, 340, i, Alim)
                    e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_TOTAL"), "#0.00"), sFon, Brushes.Black, 390, i, Alim)
                    e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_ALCANTA"), "#0.00"), sFon, Brushes.Black, 440, i, Alim)
                    e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_REP"), "#0.00"), sFon, Brushes.Black, 490, i, Alim)
                    e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_RECARGO"), "#0.00"), sFon, Brushes.Black, 540, i, Alim)
                    e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_CAR_1"), "#0.00"), sFon, Brushes.Black, 590, i, Alim)
                    e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_CAR_2"), "#0.00"), sFon, Brushes.Black, 640, i, Alim)
                    e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_DESCUENTO"), "#0.00"), sFon, Brushes.Black, 690, i, Alim)
                    e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_DESALCAN"), "#0.00"), sFon, Brushes.Black, 740, i, Alim)
                    e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_FACTURA"), "#0.00"), sFon, Brushes.Black, 790, i, Alim)

                    '--- sumar importe ---
                    nImpTotal += ds.Tables("REP").Rows(f).Item("IMP_TOTAL")
                    nImpAlcan += ds.Tables("REP").Rows(f).Item("IMP_ALCANTA")
                    nImpRepos += ds.Tables("REP").Rows(f).Item("IMP_REP")
                    nImpRecar += ds.Tables("REP").Rows(f).Item("IMP_RECARGO")
                    nImpCar_1 += ds.Tables("REP").Rows(f).Item("IMP_CAR_1")
                    nImpCar_2 += ds.Tables("REP").Rows(f).Item("IMP_CAR_2")
                    nImpFactu += ds.Tables("REP").Rows(f).Item("IMP_FACTURA")
                    nImpDescu += ds.Tables("REP").Rows(f).Item("Imp_Descuento")
                    nImpDesAl += ds.Tables("REP").Rows(f).Item("Imp_DesAlcan")

                    '------- SUMAR TOTALES 
                    nsImpTotal += ds.Tables("REP").Rows(f).Item("IMP_TOTAL")
                    nsImpAlcan += ds.Tables("REP").Rows(f).Item("IMP_ALCANTA")
                    nsImpRepos += ds.Tables("REP").Rows(f).Item("IMP_REP")
                    nsImpRecar += ds.Tables("REP").Rows(f).Item("IMP_RECARGO")
                    nsImpCar_1 += ds.Tables("REP").Rows(f).Item("IMP_CAR_1")
                    nsImpCar_2 += ds.Tables("REP").Rows(f).Item("IMP_CAR_2")
                    nsImpFactu += ds.Tables("REP").Rows(f).Item("IMP_FACTURA")
                    nsImpDescu += ds.Tables("REP").Rows(f).Item("IMP_DESCUENTO")
                    nsImpDesAl += ds.Tables("REP").Rows(f).Item("IMP_DESALCAN")

                    '------- SUMAR gran TOTALES 
                    gImpTotal += ds.Tables("REP").Rows(f).Item("IMP_TOTAL")
                    gImpAlcan += ds.Tables("REP").Rows(f).Item("IMP_ALCANTA")
                    gImpRepos += ds.Tables("REP").Rows(f).Item("IMP_REP")
                    gImpRecar += ds.Tables("REP").Rows(f).Item("IMP_RECARGO")
                    gImpCar_1 += ds.Tables("REP").Rows(f).Item("IMP_CAR_1")
                    gImpCar_2 += ds.Tables("REP").Rows(f).Item("IMP_CAR_2")
                    gImpFactu += ds.Tables("REP").Rows(f).Item("IMP_FACTURA")
                    gImpDescu += ds.Tables("REP").Rows(f).Item("IMP_DESCUENTO")
                    gImpDesAl += ds.Tables("REP").Rows(f).Item("IMP_DESALCAN")


                    f += 1
                    If f = ds.Tables("REP").Rows.Count Then
                        Exit For
                    End If

                    If ds.Tables("REP").Rows(f).Item("CATEGORIA") <> cCat Then
                        '--- IMPRIMIR TOTAL DE LA CATEGORIA
                        i += 15
                        e.Graphics.DrawString("SUBTOTAL DE CATEGORIA: " & cCat, nFon, Brushes.Black, 70, i)
                        e.Graphics.DrawString(Format(nImpTotal, "#0.00"), nFon, Brushes.Black, 390, i, Alim)
                        e.Graphics.DrawString(Format(nImpAlcan, "#0.00"), nFon, Brushes.Black, 440, i, Alim)
                        e.Graphics.DrawString(Format(nImpRepos, "#0.00"), nFon, Brushes.Black, 490, i, Alim)
                        e.Graphics.DrawString(Format(nImpRecar, "#0.00"), nFon, Brushes.Black, 540, i, Alim)
                        e.Graphics.DrawString(Format(nImpCar_1, "#0.00"), nFon, Brushes.Black, 590, i, Alim)
                        e.Graphics.DrawString(Format(nImpCar_2, "#0.00"), nFon, Brushes.Black, 640, i, Alim)
                        e.Graphics.DrawString(Format(nImpDescu, "#0.00"), nFon, Brushes.Black, 690, i, Alim)
                        e.Graphics.DrawString(Format(nImpDesAl, "#0.00"), nFon, Brushes.Black, 740, i, Alim)
                        e.Graphics.DrawString(Format(nImpFactu, "#0.00"), nFon, Brushes.Black, 790, i, Alim)
                        '------------------
                        nImpTotal = 0
                        nImpAlcan = 0
                        nImpRepos = 0
                        nImpRecar = 0
                        nImpCar_1 = 0
                        nImpCar_2 = 0
                        nImpFactu = 0
                        nImpDescu = 0
                        nImpDesAl = 0
                    End If


                    If nSer <> ds.Tables("REP").Rows(f).Item("SERVICIO") Then
                        '--- IMPRIMIR TOTAL DEL SERVICIO

                        i += 15
                        e.Graphics.DrawLine(Pens.Black, 340, i, 790, i)
                        e.Graphics.DrawString("SUBTOTAL DEL SERVICIO: " & nSer, nFon, Brushes.Black, 70, i)
                        e.Graphics.DrawString(Format(nsImpTotal, "#0.00"), nFon, Brushes.Black, 390, i, Alim)
                        e.Graphics.DrawString(Format(nsImpAlcan, "#0.00"), nFon, Brushes.Black, 440, i, Alim)
                        e.Graphics.DrawString(Format(nsImpRepos, "#0.00"), nFon, Brushes.Black, 490, i, Alim)
                        e.Graphics.DrawString(Format(nsImpRecar, "#0.00"), nFon, Brushes.Black, 540, i, Alim)
                        e.Graphics.DrawString(Format(nsImpCar_1, "#0.00"), nFon, Brushes.Black, 590, i, Alim)
                        e.Graphics.DrawString(Format(nsImpCar_2, "#0.00"), nFon, Brushes.Black, 640, i, Alim)
                        e.Graphics.DrawString(Format(nsImpDescu, "#0.00"), nFon, Brushes.Black, 690, i, Alim)
                        e.Graphics.DrawString(Format(nsImpDesAl, "#0.00"), nFon, Brushes.Black, 740, i, Alim)
                        e.Graphics.DrawString(Format(nsImpFactu, "#0.00"), nFon, Brushes.Black, 790, i, Alim)
                        '------------------

                        nsImpTotal = 0
                        nsImpAlcan = 0
                        nsImpRepos = 0
                        nsImpRecar = 0
                        nsImpCar_1 = 0
                        nsImpCar_2 = 0
                        nsImpFactu = 0
                        nsImpDescu = 0
                        nsImpDesAl = 0
                    End If

                End If
            End If
        Next

        If f = ds.Tables("REP").Rows.Count Then

            '--- IMPRIMIR TOTAL DE LA CATEGORIA
            i += 15
            e.Graphics.DrawString("SUBTOTAL DE CATEGORIA: " & cCat, nFon, Brushes.Black, 70, i)
            e.Graphics.DrawString(Format(nImpTotal, "#0.00"), nFon, Brushes.Black, 390, i, Alim)
            e.Graphics.DrawString(Format(nImpAlcan, "#0.00"), nFon, Brushes.Black, 440, i, Alim)
            e.Graphics.DrawString(Format(nImpRepos, "#0.00"), nFon, Brushes.Black, 490, i, Alim)
            e.Graphics.DrawString(Format(nImpRecar, "#0.00"), nFon, Brushes.Black, 540, i, Alim)
            e.Graphics.DrawString(Format(nImpCar_1, "#0.00"), nFon, Brushes.Black, 590, i, Alim)
            e.Graphics.DrawString(Format(nImpCar_2, "#0.00"), nFon, Brushes.Black, 640, i, Alim)
            e.Graphics.DrawString(Format(nImpDescu, "#0.00"), nFon, Brushes.Black, 690, i, Alim)
            e.Graphics.DrawString(Format(nImpDesAl, "#0.00"), nFon, Brushes.Black, 740, i, Alim)
            e.Graphics.DrawString(Format(nImpFactu, "#0.00"), nFon, Brushes.Black, 790, i, Alim)
            '------------------
            nImpTotal = 0
            nImpAlcan = 0
            nImpRepos = 0
            nImpRecar = 0
            nImpCar_1 = 0
            nImpCar_2 = 0
            nImpFactu = 0
            nImpDescu = 0
            nImpDesAl = 0

            '--- IMPRIMIR TOTAL DEL SERVICIO
            i += 15
            e.Graphics.DrawLine(Pens.Black, 340, i, 790, i)
            e.Graphics.DrawString("SUBTOTAL DEL SERVICIO: " & nSer, nFon, Brushes.Black, 70, i)
            e.Graphics.DrawString(Format(nsImpTotal, "#0.00"), nFon, Brushes.Black, 390, i, Alim)
            e.Graphics.DrawString(Format(nsImpAlcan, "#0.00"), nFon, Brushes.Black, 440, i, Alim)
            e.Graphics.DrawString(Format(nsImpRepos, "#0.00"), nFon, Brushes.Black, 490, i, Alim)
            e.Graphics.DrawString(Format(nsImpRecar, "#0.00"), nFon, Brushes.Black, 540, i, Alim)
            e.Graphics.DrawString(Format(nsImpCar_1, "#0.00"), nFon, Brushes.Black, 590, i, Alim)
            e.Graphics.DrawString(Format(nsImpCar_2, "#0.00"), nFon, Brushes.Black, 640, i, Alim)
            e.Graphics.DrawString(Format(nsImpDescu, "#0.00"), nFon, Brushes.Black, 690, i, Alim)
            e.Graphics.DrawString(Format(nsImpDesAl, "#0.00"), nFon, Brushes.Black, 740, i, Alim)
            e.Graphics.DrawString(Format(nsImpFactu, "#0.00"), nFon, Brushes.Black, 790, i, Alim)
            nsImpTotal = 0
            nsImpAlcan = 0
            nsImpRepos = 0
            nsImpRecar = 0
            nsImpCar_1 = 0
            nsImpCar_2 = 0
            nsImpFactu = 0
            nsImpDescu = 0
            nsImpDesAl = 0
            nSer = 0
            '--- IMPRIMIR gran TOTAL DEL SERVICIO
            i += 15
            e.Graphics.DrawLine(Pens.Blue, 340, i, 790, i)
            e.Graphics.DrawString("TOTAL GENERAL................", nFon, Brushes.Black, 70, i)
            e.Graphics.DrawString(Format(gImpTotal, "#0.00"), nFon, Brushes.Black, 390, i, Alim)
            e.Graphics.DrawString(Format(gImpAlcan, "#0.00"), nFon, Brushes.Black, 440, i, Alim)
            e.Graphics.DrawString(Format(gImpRepos, "#0.00"), nFon, Brushes.Black, 490, i, Alim)
            e.Graphics.DrawString(Format(gImpRecar, "#0.00"), nFon, Brushes.Black, 540, i, Alim)
            e.Graphics.DrawString(Format(gImpCar_1, "#0.00"), nFon, Brushes.Black, 590, i, Alim)
            e.Graphics.DrawString(Format(gImpCar_2, "#0.00"), nFon, Brushes.Black, 640, i, Alim)
            e.Graphics.DrawString(Format(gImpDescu, "#0.00"), nFon, Brushes.Black, 690, i, Alim)
            e.Graphics.DrawString(Format(gImpDesAl, "#0.00"), nFon, Brushes.Black, 740, i, Alim)
            e.Graphics.DrawString(Format(gImpFactu, "#0.00"), nFon, Brushes.Black, 790, i, Alim)

            gImpTotal = 0
            gImpAlcan = 0
            gImpRepos = 0
            gImpRecar = 0
            gImpCar_1 = 0
            gImpCar_2 = 0
            gImpFactu = 0
            gImpDescu = 0
            gImpDesAl = 0

            cCat = ""
            nPag = 1
            f = 0
            e.HasMorePages = False
        Else
            nPag += 1
            e.HasMorePages = True
        End If
    End Sub

    Private Sub btnImprimirNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirNuevo.Click
        da.SelectCommand.CommandText = "Select * From Ver_Facturas_Canceladas Where Comprobante = " & cboFecha.SelectedValue & " and CAJERO = '" & _Usuario & "' Order By Servicio, Categoria, Abonado"
        da.Fill(ds, "Rep")
        If ds.Tables("Rep").Rows.Count > 0 Then
            nImpTotal = 0
            nImpAlcan = 0
            nImpRepos = 0
            nImpRecar = 0
            nImpCar_1 = 0
            nImpCar_2 = 0
            nImpFactu = 0
            nImpDescu = 0
            nImpDesAl = 0

            nsImpTotal = 0
            nsImpAlcan = 0
            nsImpRepos = 0
            nsImpRecar = 0
            nsImpCar_1 = 0
            nsImpCar_2 = 0
            nsImpFactu = 0
            nsImpDescu = 0
            nsImpDesAl = 0

            gImpTotal = 0
            gImpAlcan = 0
            gImpRepos = 0
            gImpRecar = 0
            gImpCar_1 = 0
            gImpCar_2 = 0
            gImpFactu = 0
            gImpDescu = 0
            gImpDesAl = 0

            f = 0
            nPag = 1
            nSer = 0
            cCat = ""
            VerDoc.ShowDialog()
        End If
        ds.Tables("Rep").Clear()
    End Sub


    Private Sub tsAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAnular.Click
        'Dim nFac As Double
        'Dim nSer As Integer
        'Dim dEmi As Date
        'Dim txt As String
        'Dim nAbo As Integer
        'Dim lFactura As Double
        'Dim lAutorizacion As Double
        'Try
        '    nFac = dgFacturas.Item("Factura", dgFacturas.CurrentRow.Index).Value
        '    nSer = dgFacturas.Item("Servicio", dgFacturas.CurrentRow.Index).Value
        '    nAbo = dgFacturas.Item("Abonado", dgFacturas.CurrentRow.Index).Value
        '    dEmi = dgFacturas.Item("Emision", dgFacturas.CurrentRow.Index).Value
        '    lFactura = dgFacturas.Item("Num_Factura", dgFacturas.CurrentRow.Index).Value
        '    lAutorizacion = dgFacturas.Item("Num_Orden", dgFacturas.CurrentRow.Index).Value

        '    If MessageBox.Show("Esta seguro de anular la factura Nro " & nFac, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
        '        'If dEmi < CDate("01/01/2008") Then
        '        '    txt = "Update Facturas Set Fec_Pago = Null, Comprobante = 1, Num_Factura = 0, Num_Orden = 0 Where Factura = " & nFac
        '        'Else
        '        '    txt = "Update Facturas Set Fec_Pago = NUll, Comprobante = 1 Where Factura = " & nFac
        '        'End If

        '        'db.Open()
        '        'With cmd
        '        '    .CommandText = txt
        '        '    .CommandType = CommandType.Text
        '        '    .Connection = db
        '        '    .ExecuteNonQuery()
        '        'End With

        '        'If dEmi < CDate("01/01/2008") Then
        '        '    txt = "UPDATE LIBRO SET ESTADO = 'A' WHERE FACTURA = '" & lFactura & "' AND AUTORIZACION = '" & lAutorizacion & "'"
        '        '    cmd.CommandText = txt
        '        '    cmd.ExecuteNonQuery()
        '        'End If

        '        Dim cmd As New SqlCommand
        '        Dim xFactura As New SqlParameter
        '        Dim xEmision As New SqlParameter
        '        Dim xFactura_numero As New SqlParameter
        '        Dim xAutorizacion As New SqlParameter

        '        db.Open()
        '        With cmd
        '            .Connection = db
        '            .CommandType = CommandType.StoredProcedure
        '            .CommandText = "ANULAR_FACTURA"
        '            xFactura = .Parameters.Add("@Factura", SqlDbType.Real)
        '            xEmision = .Parameters.Add("@Emision", SqlDbType.DateTime)
        '            xFactura_numero = .Parameters.Add("@Factura_Numero", SqlDbType.Real)
        '            xAutorizacion = .Parameters.Add("@Autorizacion", SqlDbType.Real)
        '            xFactura.Direction = ParameterDirection.Input
        '            xEmision.Direction = ParameterDirection.Input
        '            xFactura_numero.Direction = ParameterDirection.Input
        '            xAutorizacion.Direction = ParameterDirection.Input
        '            xFactura.Value = nFac
        '            xEmision.Value = dEmi
        '            xFactura_numero.Value = lFactura
        '            xAutorizacion.Value = lAutorizacion
        '            .ExecuteNonQuery()
        '        End With
        '        db.Close()
        '        Ver_Facturas()
        '        MessageBox.Show("Se ha anulado correctamente la factura", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        'Finally
        '    If db.State = ConnectionState.Open Then db.Close()
        'End Try
    End Sub

    Private Sub cboFecha_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFecha.SelectionChangeCommitted
        Ver_Facturas()
    End Sub
End Class