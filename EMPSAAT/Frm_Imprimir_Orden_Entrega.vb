Imports System.Data.SqlClient
Imports ThoughtWorks.QRCode
Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data


Public Class Frm_Imprimir_Orden_Entrega
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim i As Integer
    Dim f As Integer

    '----------- PARA EL CODIGO QR -------------------
    Private colorFondoQR As Integer = Color.FromArgb(255, 255, 255, 255).ToArgb
    Private colorQR As Integer = Color.FromArgb(255, 0, 0, 0).ToArgb

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        If MessageBox.Show("Esta seguro de cancelar la impresión?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        da.SelectCommand.CommandText = "Select * From Libro Where Factura = '" & pFactura & "' and Autorizacion = '" & pNum_Autorizacion & "'"
        da.Fill(ds, "Rep")
        If ds.Tables("Rep").Rows.Count > 0 Then
            da.SelectCommand.CommandText = "Select * From Libro_Detalle Where  Factura = '" & pFactura & "' and Autorizacion = '" & pNum_Autorizacion & "' And Entrega = 1"
            da.Fill(ds, "DET")
            i = 0
            f = 0
            VerDoc.Document = Rep
            VerDoc.ShowDialog()
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    
    Private Sub Rep_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Rep.PrintPage
        Dim fSub As New Font("Arial Narrow", 10, FontStyle.Bold)
        Dim fNor As New Font("Arial Narrow", 10, FontStyle.Regular)
        Dim mFon As New Font("Arial Narrow", 8, FontStyle.Regular)

        Dim Alim As New System.Drawing.StringFormat(StringFormatFlags.DirectionRightToLeft)

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("ORDEN DE ENTREGA", fSub, Brushes.Black, 340, 50)


        e.Graphics.DrawString("Factura: " & ds.Tables("Rep").Rows(0).Item("Factura"), fSub, Brushes.Black, 600, 50)
        e.Graphics.DrawString("Autorización: " & ds.Tables("Rep").Rows(0).Item("Autorizacion"), fSub, Brushes.Black, 600, 65)
        e.Graphics.DrawString("Fecha: " & ds.Tables("Rep").Rows(0).Item("Fecha"), fNor, Brushes.Black, 600, 80)


        e.Graphics.DrawLine(Pens.Black, 40, 40, 780, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 780, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 780, 40, 780, 95)

        e.Graphics.DrawLine(Pens.Black, 270, 40, 270, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        

        e.Graphics.DrawString("NIT: " & ds.Tables("Rep").Rows(0).Item("Nit"), fNor, Brushes.Black, 100, 100)
        e.Graphics.DrawString("CLIENTE: " & ds.Tables("Rep").Rows(0).Item("Razon"), fNor, Brushes.Black, 100, 115)


        e.Graphics.DrawString("CANTIDAD", fNor, Brushes.Black, 110, 140, Alim)
        e.Graphics.DrawString("UNIDAD", fSub, Brushes.Black, 130, 140)
        e.Graphics.DrawString("DESCRIPCION", fSub, Brushes.Black, 200, 140)

        e.Graphics.DrawLine(Pens.Black, 50, 140, 780, 140)
        e.Graphics.DrawLine(Pens.Black, 50, 155, 780, 155)
        For i = 155 To 400 Step 15
            e.Graphics.DrawString(Math.Round(ds.Tables("Det").Rows(f).Item("Total") / ds.Tables("Det").Rows(f).Item("Unitario"), 2), fNor, Brushes.Black, 110, i, Alim)
            e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Unidad"), fNor, Brushes.Black, 130, i)
            e.Graphics.DrawString(ds.Tables("Det").Rows(f).Item("Descripcion"), fNor, Brushes.Black, 200, i)
            f += 1
            If f = ds.Tables("Det").Rows.Count Then
                Exit For
            End If
        Next
        i += 15
        e.Graphics.DrawLine(Pens.Black, 50, i, 780, i)

    End Sub

    
End Class