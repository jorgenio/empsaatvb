Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports iTextSharp.pdfa

Public Class Frm_ReporteLey1886
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Dim f As Integer
    Dim p As Integer
    Dim i As Integer
    Dim sD As Integer
    Dim sI As Integer
    Dim nD As Double
    Dim nI As Double

    Private Sub Frm_ReporteLey1886_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        da.SelectCommand.CommandText = "Select Top 12 Emision From Factores Order By Emision Desc"
        da.Fill(ds, "Periodos")
        cboPeriodo.DataSource = ds.Tables("Periodos")
        cboPeriodo.DisplayMember = ds.Tables("Periodos").Columns(0).ColumnName
        cboPeriodo.ValueMember = ds.Tables("Periodos").Columns(0).ColumnName
    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
        Dim cmd As New SqlCommand
        Dim xEmision As SqlParameter
        Dim dEmision As Date

        Dim oRptDir As New Rep_Ley1886
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo

        dEmision = cboPeriodo.SelectedValue
        Try
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Rep_Ley1886"
                xEmision = .Parameters.Add("@Emision", SqlDbType.DateTime)
                xEmision.Direction = ParameterDirection.Input
                xEmision.Value = dEmision
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

            db.Close()
            Progreso.Visible = False
            Lista.Items.Add("Proceso Terminado", True)
            Lista.Refresh()

        Catch x As Exception
            MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try

        '-------------------
        'da.SelectCommand.CommandText = "Select r.Num_Factura, r.Num_Orden, U.Nombre, U.Doc, U.NoDoc, U.Nacimiento, r.Con_m3, U.D_I, (r.Imp_Ley1886_1 + r.Imp_Ley1886_2) as Ley_1886, r.Imp_Factura, r.Codigo_Control From Rep_Ley1886 r Inner Join Usuarios U On r.Abonado = u.Abonado"
        'da.Fill(ds, "Benefici")

        'FileOpen(1, "C:\benefici.txt", OpenMode.Output)

        'For i = 0 To ds.Tables("Benefici").Rows.Count - 1
        '    txt = ds.Tables("Benefici").Rows(i).Item("Num_Factura") & _
        '    "|" & ds.Tables("Benefici").Rows(i).Item("Num_Orden") & _
        '    "|" & ds.Tables("Benefici").Rows(i).Item("Nombre") & _
        '    "|" & ds.Tables("Benefici").Rows(i).Item("Doc") & _
        '    "|" & ds.Tables("Benefici").Rows(i).Item("NoDoc") & _
        '    "|" & ds.Tables("Benefici").Rows(i).Item("Nacimiento") & _
        '    "|" & ds.Tables("Benefici").Rows(i).Item("Con_m3") & _
        '    "|" & IIf(ds.Tables("Benefici").Rows(i).Item("D_I") = "D", ds.Tables("Benefici").Rows(i).Item("Ley_1886"), 0) & _
        '    "|" & IIf(ds.Tables("Benefici").Rows(i).Item("D_I") = "I", ds.Tables("Benefici").Rows(i).Item("Ley_1886"), 0) & _
        '    "|" & ds.Tables("Benefici").Rows(i).Item("Codigo_Control")
        '    WriteLine(1, txt)
        'Next
        'FileClose(1)
        'Catch x As Exception
        '    MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally
        '    If db.State = ConnectionState.Open Then db.Close()
        'End Try
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Doc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Doc.PrintPage
        Dim tFon As New Font("Arial Narrow", 14, FontStyle.Bold)
        Dim sFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim nFon As New Font("Arial Narrow", 7, FontStyle.Bold)
        Dim mFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim zTam As System.Drawing.SizeF

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("BENEFICIARIOS LEY 1886", tFon, Brushes.Black, 290, 50)
        e.Graphics.DrawString("Correspondiente a la fecha:" & FormatDateTime(ds.Tables("Rep").Rows(0).Item("Emision"), DateFormat.ShortDate), nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Página: " & p, mFon, Brushes.Black, 650, 65)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 780, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 780, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 780, 40, 780, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        e.Graphics.DrawString("FACTURA", nFon, Brushes.Black, 40, 120)
        e.Graphics.DrawString("AUTORIZACION", nFon, Brushes.Black, 90, 120)
        e.Graphics.DrawString("RAZON SOCIAL", nFon, Brushes.Black, 160, 120)
        e.Graphics.DrawString("DOCUMENTO", nFon, Brushes.Black, 370, 120)
        e.Graphics.DrawString("NACIMIENTO", nFon, Brushes.Black, 430, 120)
        e.Graphics.DrawString("CONSUMO", nFon, Brushes.Black, 490, 120)
        e.Graphics.DrawString("DIRECTO", nFon, Brushes.Black, 550, 120)
        e.Graphics.DrawString("INDIRECTO", nFon, Brushes.Black, 610, 120)
        e.Graphics.DrawString("IMPORTE", nFon, Brushes.Black, 670, 120)
        e.Graphics.DrawString("CONTROL", nFon, Brushes.Black, 730, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 120, 780, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 135, 780, 135)

        For i = 150 To 1035 Step 15
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("NUM_FACTURA"), sFon, Brushes.Black, 40, i)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("NUM_ORDEN"), sFon, Brushes.Black, 90, i)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("RAZON"), sFon, Brushes.Black, 160, i)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("DOCUMENTO") & " " & ds.Tables("REP").Rows(f).Item("CLIENTE"), sFon, Brushes.Black, 370, i)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("NACIMIENTO"), sFon, Brushes.Black, 430, i)

            zTam = e.Graphics.MeasureString(ds.Tables("REP").Rows(f).Item("CON_M3"), sFon)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("CON_M3"), sFon, Brushes.Black, 530 - zTam.Width, i)

            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(f).Item("IMP_LEY1886"), "#0.00"), sFon)
            If ds.Tables("REP").Rows(f).Item("D_I") = "D" Then
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_LEY1886"), "#0.00"), sFon, Brushes.Black, 590 - zTam.Width, i)
                nD += ds.Tables("rep").Rows(f).Item("IMP_LEY1886")
                sD += 1
            Else
                e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_LEY1886"), "#0.00"), sFon, Brushes.Black, 650 - zTam.Width, i)
                nI += ds.Tables("REP").Rows(f).Item("IMP_LEY1886")
                sI += 1
            End If

            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(f).Item("IMP_IMPORTE"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(f).Item("IMP_IMPORTE"), "#0.00"), sFon, Brushes.Black, 710 - zTam.Width, i)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("CODIGO_CONTROL"), sFon, Brushes.Black, 730, i)
            f += 1
            If f = ds.Tables("REP").Rows.Count Then
                zTam = e.Graphics.MeasureString(Format(nD, "#0.00"), nFon)
                e.Graphics.DrawString(Format(nD, "#0.00"), nFon, Brushes.Black, 590 - zTam.Width, i + 15)
                zTam = e.Graphics.MeasureString(Format(nI, "#0.00"), nFon)
                e.Graphics.DrawString(Format(nI, "#0.00"), nFon, Brushes.Black, 650 - zTam.Width, i + 15)
                e.Graphics.DrawString(sD, nFon, Brushes.Black, 570, i + 30)
                e.Graphics.DrawString(sI, nFon, Brushes.Black, 630, i + 30)
                Exit For
            End If
        Next

        If f = ds.Tables("REP").Rows.Count Then
            nD = 0
            sD = 0
            nI = 0
            sI = 0
            f = 0
            p = 1

            e.HasMorePages = False
        Else
            p += 1
            e.HasMorePages = True
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim TXT As String
        Dim cArch As String

        da.SelectCommand.CommandText = "SELECT RAZON, DOCUMENTO, CLIENTE, NACIMIENTO, NUM_FACTURA, NUM_ORDEN, CODIGO_CONTROL, CON_M3, IMP_LEY1886, IMP_FACTURA, EMISION, D_I FROM VER_FACTURA_LEY1886 WHERE EMISION = '" & cboPeriodo.SelectedValue & "' ORDER BY D_I, NUM_FACTURA"
        da.Fill(ds, "REP")
        If ds.Tables("REP").Rows.Count > 0 Then
            'f = 0
            'p = 1
            'VerDoc.Document = Doc
            'VerDoc.ShowDialog()
            ''Exportar(ds.Tables("REP"))

            If Arch.ShowDialog = Windows.Forms.DialogResult.OK Then
                cArch = Arch.FileName
            Else
                Exit Sub
            End If

            FileOpen(1, cArch, OpenMode.Output)

            For i = 0 To ds.Tables("Rep").Rows.Count - 1
                TXT = ds.Tables("rep").Rows(i).Item("Razon") & _
                "|" & ds.Tables("rep").Rows(i).Item("Documento") & _
                "|" & ds.Tables("rep").Rows(i).Item("cliente") & _
                "|" & ds.Tables("rep").Rows(i).Item("nacimiento") & _
                "|" & ds.Tables("rep").Rows(i).Item("num_factura") & _
                "|" & ds.Tables("rep").Rows(i).Item("num_orden") & _
                "|" & ds.Tables("rep").Rows(i).Item("codigo_control") & _
                "|" & ds.Tables("rep").Rows(i).Item("Con_m3") & _
                "|" & IIf(ds.Tables("rep").Rows(i).Item("D_I") = "D", Math.Round(ds.Tables("rep").Rows(i).Item("Imp_Ley1886"), 2), 0) & _
                "|" & IIf(ds.Tables("rep").Rows(i).Item("D_I") = "I", Math.Round(ds.Tables("rep").Rows(i).Item("Imp_Ley1886"), 2), 0) & _
                "|" & Math.Round(ds.Tables("rep").Rows(i).Item("Imp_Factura"), 2) & "~"
                WriteLine(1, TXT)
            Next
            FileClose(1)

            ds.Tables("rep").Clear()

            MessageBox.Show("Proceso terminado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    
    Private Sub btnTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTxt.Click
        Dim TXT As String
        Dim cArch As String
        Dim nCant_Directo As Integer
        Dim nCant_Indirecto As Integer
        Dim nImp_Directo As Double
        Dim nImp_Indirecto As Double

        If Len(txtOrden.Text) = 0 Then
            MessageBox.Show("Debe registrar el Nro de Orden Formulario 200 (iva) para Proceder", "Error No se puede Seguir", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        da.SelectCommand.CommandText = "SELECT * FROM VER_FACTURA_LEY1886 WHERE EMISION = '" & cboPeriodo.SelectedValue & "' ORDER BY D_I, NUM_FACTURA"
        da.Fill(ds, "REP")
        If ds.Tables("REP").Rows.Count > 0 Then
            MessageBox.Show("Registre ahora el archivo CONTROL.TXT", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If Arch.ShowDialog = Windows.Forms.DialogResult.OK Then
                cArch = Arch.FileName
            Else
                Exit Sub
            End If


            da.SelectCommand.CommandText = "Select Count(*) as Nro, Sum(Imp_Ley1886) as Imp_Ley1886 From VER_FACTURA_LEY1886 WHERE EMISION = '" & cboPeriodo.SelectedValue & "' and D_I = 'D'"
            da.Fill(ds, "DIR")

            If ds.Tables("DIR").Rows.Count > 0 Then
                nCant_Directo = IIf(IsDBNull(ds.Tables("DIR").Rows(0).Item("Nro")), 0, ds.Tables("DIR").Rows(0).Item("Nro"))
                nImp_Directo = IIf(IsDBNull(ds.Tables("DIR").Rows(0).Item("IMP_LEY1886")), 0, ds.Tables("DIR").Rows(0).Item("IMP_LEY1886"))
            End If
            ds.Tables("DIR").Clear()

            da.SelectCommand.CommandText = "Select Count(*) as Nro, Sum(Imp_Ley1886) as Imp_Ley1886 From VER_FACTURA_LEY1886 WHERE EMISION = '" & cboPeriodo.SelectedValue & "' and D_I = 'I'"
            da.Fill(ds, "DIR")

            If ds.Tables("DIR").Rows.Count > 0 Then
                nCant_Indirecto = IIf(IsDBNull(ds.Tables("DIR").Rows(0).Item("Nro")), 0, ds.Tables("DIR").Rows(0).Item("Nro"))
                nImp_Indirecto = IIf(IsDBNull(ds.Tables("DIR").Rows(0).Item("IMP_LEY1886")), 0, ds.Tables("DIR").Rows(0).Item("IMP_LEY1886"))
            End If
            ds.Tables("DIR").Clear()

            da.SelectCommand.CommandText = "Select * From Facturas Where Abonado = 4118 and emision = '" & cboPeriodo.SelectedValue & "'"
            da.Fill(ds, "Fac")


            FileOpen(1, cArch, OpenMode.Output)

            If ds.Tables("Fac").Rows.Count > 0 Then
                TXT = ds.Tables("Fac").Rows(0).Item("Num_Factura") & _
                    "|" & ds.Tables("Fac").Rows(0).Item("Num_Orden") & _
                    "|1023807025|200|" & txtOrden.Text & _
                    "|" & Month(ds.Tables("Fac").Rows(0).Item("Emision")) & _
                    "|" & Year(ds.Tables("Fac").Rows(0).Item("Emision")) & _
                    "|" & ds.Tables("Fac").Rows(0).Item("Imp_factura") & _
                    "|1|" & nCant_Directo & "|" & nCant_Indirecto & _
                    "|" & nCant_Directo + nCant_Indirecto & _
                    "|" & nImp_Directo & "|" & nImp_Indirecto & _
                    "|" & nImp_Directo + nImp_Indirecto & _
                    "|" & ds.Tables("Fac").Rows(0).Item("codigo_control") & "~"
                WriteLine(1, TXT)
            End If
            FileClose(1)


            MessageBox.Show("Registre ahora el archivo BENEFICI.TXT", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If Arch.ShowDialog = Windows.Forms.DialogResult.OK Then
                cArch = Arch.FileName
            Else
                Exit Sub
            End If

            FileOpen(1, cArch, OpenMode.Output)
            For i = 0 To ds.Tables("Rep").Rows.Count - 1
                TXT = ds.Tables("rep").Rows(i).Item("Num_Factura") & _
                "|" & ds.Tables("rep").Rows(i).Item("Num_Orden") & _
                "|" & ds.Tables("rep").Rows(i).Item("RAZON") & _
                "|" & ds.Tables("rep").Rows(i).Item("documento") & _
                "|" & ds.Tables("rep").Rows(i).Item("cliente") & _
                "|" & ds.Tables("rep").Rows(i).Item("nacimiento") & _
                "|" & ds.Tables("rep").Rows(i).Item("con_m3") & _
                "|" & IIf(ds.Tables("rep").Rows(i).Item("D_I") = "D", Math.Round(ds.Tables("rep").Rows(i).Item("Imp_Ley1886"), 2), 0) & _
                "|" & IIf(ds.Tables("rep").Rows(i).Item("D_I") = "I", Math.Round(ds.Tables("rep").Rows(i).Item("Imp_Ley1886"), 2), 0) & _
                "|" & Math.Round(ds.Tables("rep").Rows(i).Item("Imp_Factura"), 2) & _
                "|" & ds.Tables("rep").Rows(i).Item("codigo_control") & "~"
                WriteLine(1, TXT)
            Next
            FileClose(1)

            ds.Tables("rep").Clear()

            MessageBox.Show("Proceso terminado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class