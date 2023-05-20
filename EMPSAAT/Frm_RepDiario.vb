Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_RepDiario
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


    Private Sub Frm_RepDiario_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        da.SelectCommand.CommandText = "Select * From Punto"
        da.Fill(ds, "Pto")
        cboPunto.DataSource = ds.Tables("Pto")
        cboPunto.DisplayMember = "Descripcion"
        cboPunto.ValueMember = "Punto"
        ver_Comprobantes()
    End Sub

    Private Sub ver_Comprobantes()
        da.SelectCommand.CommandText = "Select * From Comprobantes Where Contabilizado = 0 Order By Comprobante Desc"
        da.Fill(ds, "Cbte")
        cboFecha.DataSource = ds.Tables("Cbte")
        cboFecha.DisplayMember = "Fecha"
        cboFecha.ValueMember = "Comprobante"
    End Sub

    Private Sub VerFacturas(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerFacturas.Click
        da.SelectCommand.CommandText = "Select * From Ver_Facturas_Canceladas Where Comprobante = " & cboFecha.SelectedValue & " and Punto = '" & cboPunto.SelectedValue & "' Order By Servicio, Categoria, Abonado"
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
            VerDoc.Document = Doc
            VerDoc.ShowDialog()
        Else
            MessageBox.Show("No se encontro el registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        ds.Tables("Rep").Clear()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnCrearComprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearComprobante.Click
        Dim fCrear As New Frm_Comprobantes
        If fCrear.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Ver_Comprobantes()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtrasVentas.Click
        nRep_Comprobante = cboFecha.SelectedValue
        Dim fRep As New Frm_Rep_Otras_Ventas
        fRep.ShowDialog()
        Me.Close()
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
        e.Graphics.DrawString("Punto: " & cboPunto.Text, mFon, Brushes.Black, 650, 80)

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
End Class