Imports System.Data.SqlClient
Imports ThoughtWorks.QRCode
Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data

Public Class Frm_Imprimir_Factura_Otras_Ventas
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim i As Integer
    Dim f As Integer

    '----------- PARA EL CODIGO QR -------------------
    Private colorFondoQR As Integer = Color.FromArgb(255, 255, 255, 255).ToArgb
    Private colorQR As Integer = Color.FromArgb(255, 0, 0, 0).ToArgb

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        da.SelectCommand.CommandText = "Select * From Libro Where Factura = '" & pFactura & "' and Autorizacion = '" & pNum_Autorizacion & "'"
        da.Fill(ds, "Rep")
        If ds.Tables("Rep").Rows.Count > 0 Then
            da.SelectCommand.CommandText = "Select * From Libro_Detalle Where  Factura = '" & pFactura & "' and Autorizacion = '" & pNum_Autorizacion & "'"
            da.Fill(ds, "DET")
            i = 0
            f = 0
            VerDoc.Document = RepMedia
            VerDoc.ShowDialog()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub Rep_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Rep.PrintPage
        Dim fSub As New Font("Arial Narrow", 10, FontStyle.Bold)
        Dim fNor As New Font("Arial Narrow", 10, FontStyle.Regular)
        Dim fNor2 As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim Alim As New System.Drawing.StringFormat(StringFormatFlags.DirectionRightToLeft)
        Dim generarCodigoQR As QRCodeEncoder = New QRCodeEncoder
        Dim txtCodigoQr As String
        Dim X As Integer
        Dim cLey453 As String
        Dim dFecFin As Date

        generarCodigoQR.QRCodeEncodeMode = Codec.QRCodeEncoder.ENCODE_MODE.BYTE
        generarCodigoQR.QRCodeScale = Int32.Parse(6)
        generarCodigoQR.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H
        generarCodigoQR.QRCodeVersion = 0
        generarCodigoQR.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(colorFondoQR)
        generarCodigoQR.QRCodeForegroundColor = System.Drawing.Color.FromArgb(colorQR)

        txtCodigoQr = "1023807025|" & _
        ds.Tables("Rep").Rows(0).Item("Factura") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Autorizacion") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Fecha") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Importe_Venta") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Importe_Venta") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Codigo_Control") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Nit") & "|0.00|0.00|0.00|0.00"

        cLey453 = Leyenda_Ley_453_Autorizacion(ds.Tables("Rep").Rows(0).Item("Autorizacion"))
        dFecFin = Obtener_Fecha_Fin_Autorizacion(ds.Tables("Rep").Rows(0).Item("Autorizacion"))

        X = 30
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Factura"), fSub, Brushes.Black, 650, X)
        X += 15
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Autorizacion"), fSub, Brushes.Black, 650, X)

        X = 155
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Razon"), fNor, Brushes.Black, 100, X)
        X += 15
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Nit"), fNor, Brushes.Black, 100, X)
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Fecha"), fNor, Brushes.Black, 450, X)
        f = 0
        For i = 280 To 520 Step 15
            e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Total") / ds.Tables("Det").Rows(f).Item("Unitario"), fNor, Brushes.Black, 70, i, Alim)
            e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Descripcion"), fNor, Brushes.Black, 100, i)
            'e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Unitario"), fNor, Brushes.Black, 500, i, Alim)
            e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Total"), fNor, Brushes.Black, 540, i, Alim)
            f += 1
            If f = ds.Tables("Det").Rows.Count Then
                Exit For
            End If
        Next

        X = 415
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Importe_Venta"), fSub, Brushes.Black, 540, X, Alim)
        e.Graphics.DrawString(Literal(ds.Tables("Rep").Rows(0).Item("Importe_Venta"), "M"), fNor, Brushes.Black, 50, X)
        e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 580, 400, 75, 75)

        X += 20
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Codigo_Control"), fNor, Brushes.Black, 100, X)
        e.Graphics.DrawString(dFecFin, fNor, Brushes.Black, 450, X)
        X += 20
        e.Graphics.DrawString(_Usuario, fNor, Brushes.Black, 580, 515)
        e.Graphics.DrawString(Date.Now, fNor, Brushes.Black, 580, 530)
        X += 40
        e.Graphics.DrawString("LEY 453: " & cLey453, fNor2, Brushes.Black, 20, X)

        '--------------------------------------------------------------------------------------------------------------------------------
       

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("Esta seguro de cancelar la impresión?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub RepMedia_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles RepMedia.PrintPage
        Dim fSub As New Font("Arial Narrow", 8, FontStyle.Bold)
        Dim fNor As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim fNor2 As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim Alim As New System.Drawing.StringFormat(StringFormatFlags.DirectionRightToLeft)
        Dim generarCodigoQR As QRCodeEncoder = New QRCodeEncoder
        Dim txtCodigoQr As String
        Dim X As Integer
        Dim cLey453 As String
        Dim dFecFin As Date

        generarCodigoQR.QRCodeEncodeMode = Codec.QRCodeEncoder.ENCODE_MODE.BYTE
        generarCodigoQR.QRCodeScale = Int32.Parse(6)
        generarCodigoQR.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H
        generarCodigoQR.QRCodeVersion = 0
        generarCodigoQR.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(colorFondoQR)
        generarCodigoQR.QRCodeForegroundColor = System.Drawing.Color.FromArgb(colorQR)

        txtCodigoQr = "1023807025|" & _
        ds.Tables("Rep").Rows(0).Item("Factura") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Autorizacion") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Fecha") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Importe_Venta") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Importe_Venta") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Codigo_Control") & "|" & _
        ds.Tables("Rep").Rows(0).Item("Nit") & "|0.00|0.00|0.00|0.00"

        cLey453 = Leyenda_Ley_453_Autorizacion(ds.Tables("Rep").Rows(0).Item("Autorizacion"))
        dFecFin = Obtener_Fecha_Fin_Autorizacion(ds.Tables("Rep").Rows(0).Item("Autorizacion"))

        X = 25
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Factura"), fSub, Brushes.Black, 550, X)
        X += 15
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Autorizacion"), fSub, Brushes.Black, 550, X)

        X = 150
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Razon"), fNor, Brushes.Black, 100, X)
        X += 15
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Nit"), fNor, Brushes.Black, 100, X)
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Fecha"), fNor, Brushes.Black, 400, X)
        f = 0
        For i = 285 To 520 Step 15
            e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Total") / ds.Tables("Det").Rows(f).Item("Unitario"), fNor, Brushes.Black, 70, i, Alim)
            e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Descripcion"), fNor, Brushes.Black, 100, i)
            'e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Unitario"), fNor, Brushes.Black, 500, i, Alim)
            e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Total"), fNor, Brushes.Black, 440, i, Alim)
            f += 1
            If f = ds.Tables("Det").Rows.Count Then
                Exit For
            End If
        Next
        X = 415
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Importe_Venta"), fSub, Brushes.Black, 440, X, Alim)
        e.Graphics.DrawString(Literal(ds.Tables("Rep").Rows(0).Item("Importe_Venta"), "M"), fNor, Brushes.Black, 50, X)
        e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 580, 400, 75, 75)

        X += 20
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Codigo_Control"), fNor, Brushes.Black, 100, X)
        e.Graphics.DrawString(dFecFin, fNor, Brushes.Black, 450, X)
        X += 20
        e.Graphics.DrawString(_Usuario, fNor, Brushes.Black, 580, 515)
        e.Graphics.DrawString(Date.Now, fNor, Brushes.Black, 580, 530)
        X += 30
        e.Graphics.DrawString("LEY 453: " & cLey453, fNor2, Brushes.Black, 20, X)

        '--------------------------------------------------------------------------------------------------------------------------------
        X = 95
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Factura"), fSub, Brushes.Black, 750, X)
        X += 15
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Autorizacion"), fSub, Brushes.Black, 700, X)

        X += 50
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Razon"), fNor, Brushes.Black, 700, X)
        X += 15
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Nit"), fNor, Brushes.Black, 700, X)
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Fecha"), fNor, Brushes.Black, 750, X)
        'f = 0
        'For i = 820 To 940 Step 15
        '    e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Total") / ds.Tables("Det").Rows(f).Item("Unitario"), fNor, Brushes.Black, 70, i, Alim)
        '    e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Descripcion"), fNor, Brushes.Black, 100, i)
        '    'e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Unitario"), fNor, Brushes.Black, 500, i, Alim)
        '    e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Total"), fNor, Brushes.Black, 540, i, Alim)
        '    f += 1
        '    If f = ds.Tables("Det").Rows.Count Then
        '        Exit For
        '    End If
        'Next

        X = 400
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Importe_Venta"), fSub, Brushes.Black, 750, X, Alim)
        'e.Graphics.DrawString(Literal(ds.Tables("Rep").Rows(0).Item("Importe_Venta"), "M"), fNor, Brushes.Black, 50, X)
        'e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 700, 930, 75, 75)

        X += 20
        e.Graphics.DrawString(ds.Tables("Rep").Rows(0).Item("Codigo_Control"), fNor, Brushes.Black, 700, X)
        'e.Graphics.DrawString(dFecFin, fNor, Brushes.Black, 450, X)
        X += 20
        X += 40
        e.Graphics.DrawString(_Usuario, fNor, Brushes.Black, 700, 515)
        e.Graphics.DrawString(Date.Now, fNor, Brushes.Black, 700, 530)
    End Sub
End Class