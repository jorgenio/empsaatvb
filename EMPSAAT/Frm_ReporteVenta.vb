Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_ReporteVenta
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim F As Integer
    Dim I As Integer
    Dim sImp As Double
    Dim sAlc As Double
    Dim sRep As Double
    Dim sRec As Double
    Dim sCa1 As Double
    Dim sCa2 As Double
    Dim SLey As Double
    Dim STot As Double
    Dim SIva As Double
    Dim SIte As Double
    Dim sDes As Double
    Dim sDeA As Double
    Dim Sm3 As Integer
    Dim SNro As Integer

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Frm_ReporteVenta_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        da.SelectCommand.CommandText = "Select Top 36 Emision From Factores Order By Emision Desc"
        da.Fill(ds, "Periodos")
        CboPeriodo.DataSource = ds.Tables("Periodos")
        CboPeriodo.DisplayMember = ds.Tables("Periodos").Columns(0).ColumnName
        CboPeriodo.ValueMember = ds.Tables("Periodos").Columns(0).ColumnName
    End Sub

    'Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
    '    Dim cmd As New SqlCommand
    '    Dim txt As String
    '    Dim xEmision As SqlParameter
    '    Dim dEmision As Date

    '    Dim oRptDir As New Rep_Venta
    '    Dim oConexInfo As New ConnectionInfo
    '    Dim oListaTablas As Tables
    '    Dim oTabla As Table
    '    Dim oTablaConexInfo As TableLogOnInfo

    '    dEmision = CboPeriodo.SelectedValue
    '    Try
    '        db.Open()
    '        With cmd
    '            .Connection = db
    '            .CommandType = CommandType.StoredProcedure
    '            .CommandText = "Rep_Venta"
    '            xEmision = .Parameters.Add("@Emision", SqlDbType.DateTime)
    '            xEmision.Direction = ParameterDirection.Input
    '            xEmision.Value = dEmision
    '            .ExecuteNonQuery()
    '        End With

    '        oConexInfo.ServerName = "SERVIDORHP"
    '        oConexInfo.DatabaseName = "EMPSAAT"
    '        oConexInfo.UserID = _Usuario
    '        oConexInfo.Password = _Clave

    '        oListaTablas = oRptDir.Database.Tables

    '        For Each oTabla In oListaTablas
    '            oTablaConexInfo = oTabla.LogOnInfo
    '            oTablaConexInfo.ConnectionInfo = oConexInfo
    '            oTabla.ApplyLogOnInfo(oTablaConexInfo)
    '        Next

    '        Dim fRep As New Frm_Reportes
    '        fRep.crvRep.ReportSource = oRptDir
    '        fRep.ShowDialog()

    '        If MessageBox.Show("Cerrar Mes", "Por favor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    '            txt = "Update Factores Set Proceso = 3 Where Emision = '" & CboPeriodo.SelectedValue & "'"
    '            With cmd
    '                .Connection = db
    '                .CommandType = CommandType.Text
    '                .CommandText = txt
    '                .ExecuteNonQuery()
    '            End With
    '        End If
    '        db.Close()
    '        Progreso.Visible = False
    '        Lista.Items.Add("Proceso Terminado", True)
    '        Lista.Refresh()
    '    Catch x As Exception
    '        MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        If db.State = ConnectionState.Open Then db.Close()
    '    End Try
    'End Sub

    Private Sub Doc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Doc.PrintPage
        Dim tFon As New Font("Arial Narrow", 14, FontStyle.Bold)
        Dim sFon As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim nFon As New Font("Arial Narrow", 8, FontStyle.Bold)
        Dim mFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        'Dim zTam As System.Drawing.SizeF
        Dim Alim As New System.Drawing.StringFormat(StringFormatFlags.DirectionRightToLeft)

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("RESUMEN VENTA DE SERVICIOS", tFon, Brushes.Black, 270, 50)
        e.Graphics.DrawString("Correspondiente al periodo:" & FormatDateTime(FormatDateTime(ds.Tables("Rep").Rows(0).Item("EMISION"), DateFormat.ShortDate)), nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Fecha: " & FormatDateTime(Date.Now, DateFormat.ShortDate), mFon, Brushes.Black, 650, 65)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 790, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 790, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 790, 40, 790, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        e.Graphics.DrawString("CATEGORIA", nFon, Brushes.Black, 40, 120)
        e.Graphics.DrawString("NRO", nFon, Brushes.Black, 150, 120, Alim)
        e.Graphics.DrawString("M3", nFon, Brushes.Black, 190, 120, Alim)
        e.Graphics.DrawString("IMPORTE", nFon, Brushes.Black, 240, 120, Alim)
        e.Graphics.DrawString("ALCANTA", nFon, Brushes.Black, 290, 120, Alim)
        e.Graphics.DrawString("REPOS", nFon, Brushes.Black, 340, 120, Alim)
        e.Graphics.DrawString("RECARGO", nFon, Brushes.Black, 390, 120, Alim)
        e.Graphics.DrawString("CARGO 1", nFon, Brushes.Black, 440, 120, Alim)
        e.Graphics.DrawString("CARGO 2", nFon, Brushes.Black, 490, 120, Alim)
        e.Graphics.DrawString("DESCTO", nFon, Brushes.Black, 540, 120, Alim)
        e.Graphics.DrawString("DTOALC", nFon, Brushes.Black, 590, 120, Alim)
        e.Graphics.DrawString("TOTAL", nFon, Brushes.Black, 640, 120, Alim)
        e.Graphics.DrawString("LEY1886", nFon, Brushes.Black, 690, 120, Alim)
        e.Graphics.DrawString("IVA", nFon, Brushes.Black, 740, 120, Alim)
        e.Graphics.DrawString("ITE", nFon, Brushes.Black, 790, 120, Alim)
        e.Graphics.DrawLine(Pens.Black, 40, 120, 790, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 135, 790, 135)

        For i = 150 To 1035 Step 20
            e.Graphics.DrawString(ds.Tables("REP").Rows(F).Item("DESCRIPCION"), sFon, Brushes.Black, 40, I)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("NRO"), "00"), sFon, Brushes.Black, 150, I, Alim)
            SNro += ds.Tables("Rep").Rows(F).Item("Nro")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("CONSUMO"), "00"), sFon, Brushes.Black, 190, I, Alim)
            Sm3 += ds.Tables("Rep").Rows(F).Item("Consumo")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_TOTAL"), "#0.00"), sFon, Brushes.Black, 240, I, Alim)
            sImp += ds.Tables("REP").Rows(F).Item("IMP_TOTAL")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("ALCANTA"), "#0.00"), sFon, Brushes.Black, 290, I, Alim)
            sAlc += ds.Tables("REP").Rows(F).Item("ALCANTA")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_REP"), "#0.00"), sFon, Brushes.Black, 340, I, Alim)
            sRep += ds.Tables("REP").Rows(F).Item("IMP_REP")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_RECARGO"), "#0.00"), sFon, Brushes.Black, 390, I, Alim)
            sRec += ds.Tables("REP").Rows(F).Item("IMP_RECARGO")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_CAR1"), "#0.00"), sFon, Brushes.Black, 440, I, Alim)
            sCa1 += ds.Tables("REP").Rows(F).Item("IMP_CAR1")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_CAR2"), "#0.00"), sFon, Brushes.Black, 490, I, Alim)
            sCa2 += ds.Tables("REP").Rows(F).Item("IMP_CAR2")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("DESCUENTO"), "#0.00"), sFon, Brushes.Black, 540, I, Alim)
            sDes += ds.Tables("REP").Rows(F).Item("DESCUENTO")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("DESALCANTARILLADO"), "#0.00"), sFon, Brushes.Black, 590, I, Alim)
            sDeA += ds.Tables("REP").Rows(F).Item("DESALCANTARILLADO")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_FACTURA"), "#0.00"), sFon, Brushes.Black, 640, I, Alim)
            STot += ds.Tables("REP").Rows(F).Item("IMP_FACTURA")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("LEY1886"), "#0.00"), sFon, Brushes.Black, 690, I, Alim)
            SLey += ds.Tables("REP").Rows(F).Item("LEY1886")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_IVA"), "#0.00"), sFon, Brushes.Black, 740, I, Alim)
            SIva += ds.Tables("REP").Rows(F).Item("IMP_IVA")

            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_ITE"), "#0.00"), sFon, Brushes.Black, 790, I, Alim)
            SIte += ds.Tables("REP").Rows(F).Item("IMP_ITE")

            F += 1
            If F = ds.Tables("REP").Rows.Count Then
                I += 20
                e.Graphics.DrawString(Format(SNro, "#0"), nFon, Brushes.Black, 150, I, Alim)
                e.Graphics.DrawString(Format(Sm3, "#0"), nFon, Brushes.Black, 190, I, Alim)
                e.Graphics.DrawString(Format(sImp, "#0.00"), nFon, Brushes.Black, 240, I, Alim)
                e.Graphics.DrawString(Format(sAlc, "#0.00"), nFon, Brushes.Black, 290, I, Alim)
                e.Graphics.DrawString(Format(sRep, "#0.00"), nFon, Brushes.Black, 340, I, Alim)
                e.Graphics.DrawString(Format(sRec, "#0.00"), nFon, Brushes.Black, 390, I, Alim)
                e.Graphics.DrawString(Format(sCa1, "#0.00"), nFon, Brushes.Black, 440, I, Alim)
                e.Graphics.DrawString(Format(sCa2, "#0.00"), nFon, Brushes.Black, 490, I, Alim)
                e.Graphics.DrawString(Format(sDes, "#0.00"), nFon, Brushes.Black, 540, I, Alim)
                e.Graphics.DrawString(Format(sDeA, "#0.00"), nFon, Brushes.Black, 590, I, Alim)
                e.Graphics.DrawString(Format(STot, "#0.00"), nFon, Brushes.Black, 640, I, Alim)
                e.Graphics.DrawString(Format(SLey, "#0.00"), nFon, Brushes.Black, 690, I, Alim)
                e.Graphics.DrawString(Format(SIva, "#0.00"), nFon, Brushes.Black, 740, I, Alim)
                e.Graphics.DrawString(Format(SIte, "#0.00"), nFon, Brushes.Black, 790, I, Alim)

                Exit For
            End If
        Next

        If F = ds.Tables("REP").Rows.Count Then
            SNro = 0
            Sm3 = 0
            sImp = 0
            sAlc = 0
            sRep = 0
            sRec = 0
            sCa1 = 0
            sCa2 = 0
            SLey = 0
            STot = 0
            SIva = 0
            SIte = 0
            sDeA = 0
            sDes = 0
            F = 0
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            da.SelectCommand.CommandText = "SELECT * FROM VER_VENTA_MES WHERE EMISION = '" & CboPeriodo.SelectedValue & "' ORDER BY DESCRIPCION"
            da.Fill(ds, "REP")
            If ds.Tables("REP").Rows.Count > 0 Then
                sImp = 0
                sAlc = 0
                sRep = 0
                sRec = 0
                sCa1 = 0
                sCa2 = 0
                SLey = 0
                STot = 0
                SIva = 0
                SIte = 0
                F = 0
                VerDoc.Document = Doc
                VerDoc.ShowDialog()
            End If
            ds.Tables("REP").Clear()
            If MessageBox.Show("Cerrar Mes", "Por favor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                txt = "Update Factores Set Proceso = 3 Where Emision = '" & CboPeriodo.SelectedValue & "'"
                db.Open()
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
                db.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

   
    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Try
            da.SelectCommand.CommandText = "SELECT Facturas.Abonado, Cliente.Razon, Facturas.Emision, Usuarios_Categorias.Descripcion, Facturas.Con_m3, Facturas.Imp_Total, " & _
                    "Facturas.Imp_Alcanta, Facturas.Imp_Rep, Facturas.Imp_Recargo, Facturas.Imp_Car_1, Facturas.Imp_Car_2, (Facturas.Imp_Ley1886_1 + Facturas.Imp_Ley1886_2) AS Ley1886, Facturas.Imp_Descuento, Facturas.Imp_DesAlcan, Facturas.Imp_Factura, Facturas.Imp_Iva, Facturas.Imp_Ite " & _
                    "FROM Cliente Inner Join Usuarios On Cliente.Cliente = Usuarios.NoDoc " & _
                    "Inner Join Facturas On Usuarios.Abonado = Facturas.Abonado " & _
                    "INNER JOIN Usuarios_Categorias ON dbo.Facturas.Categoria = dbo.Usuarios_Categorias.Categoria  " & _
                    "WHERE Facturas.Servicio = 1 and Facturas.Valida = 'V' and Facturas.Emision = '" & CboPeriodo.SelectedValue & "' " & _
                    "ORDER BY Facturas.CATEGORIA, Facturas.Abonado"

            da.Fill(ds, "REP")
            If ds.Tables("REP").Rows.Count > 0 Then
                Exportar(ds.Tables("REP"))
            End If
            ds.Tables("REP").Clear()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub btnDescuento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescuento.Click
        Try
            da.SelectCommand.CommandText = "SELECT * FROM VER_RESUMEN_DESCUENTO WHERE EMISION = '" & CboPeriodo.SelectedValue & "'"
            da.Fill(ds, "DES")
            If ds.Tables("DES").Rows.Count > 0 Then
                Exportar(ds.Tables("DES"))
            Else
                MessageBox.Show("No se encontraron registros", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            ds.Tables("DES").Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class