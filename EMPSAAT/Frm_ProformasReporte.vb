Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_ProformasReporte
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim I As Integer
    Dim F As Integer
    Dim P As Integer
    Dim T As Double

    Private Sub Frm_ProformasReporte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        da.SelectCommand.CommandText = "Select Top 6 Emision From Factores Order By Emision Desc"
        da.Fill(ds, "Periodos")
        cboPeriodo.DataSource = ds.Tables("Periodos")
        cboPeriodo.DisplayMember = "EMISION"
        cboPeriodo.ValueMember = "EMISION"

        da.SelectCommand.CommandText = "Select * From Proformas Order By RazonSocial"
        da.Fill(ds, "Pro")
        cboEmpresa.DataSource = ds.Tables("Pro")
        cboEmpresa.DisplayMember = "RazonSocial"
        cboEmpresa.ValueMember = "Proforma"
    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
        Dim cmd As New SqlCommand
        Dim xPeriodo As New SqlParameter
        Try
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "REP_PROFORMAS"
                xPeriodo = .Parameters.Add("@Emision", SqlDbType.DateTime)
                xPeriodo.Direction = ParameterDirection.Input
                xPeriodo.Value = cboPeriodo.SelectedValue
                .ExecuteNonQuery()
            End With

            Dim oRptDir As New Rep_Proformas
            Dim oConexInfo As New ConnectionInfo
            Dim oListaTablas As Tables
            Dim oTabla As Table
            Dim oTablaConexInfo As TableLogOnInfo


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

        e.Graphics.DrawString("P R O F O R M A", tFon, Brushes.Black, 300, 40)
        e.Graphics.DrawString("Correspondiente al periodo: " & Format(ds.Tables("Rep").Rows(0).Item("EMISION"), "MMM/yyyy"), nFon, Brushes.Black, 300, 65)
        e.Graphics.DrawString("Fecha de emisión: " & FormatDateTime(ds.Tables("Rep").Rows(0).Item("EMISION"), DateFormat.ShortDate), nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Impresión: " & FormatDateTime(Date.Now, DateFormat.ShortDate), mFon, Brushes.Black, 650, 50)
        e.Graphics.DrawString("Vencimiento: " & ds.Tables("Rep").Rows(0).Item("Vencimiento"), mFon, Brushes.Black, 650, 65)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 780, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 780, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 780, 40, 780, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        e.Graphics.DrawString("RAZON SOCIAL: " & ds.Tables("REP").Rows(F).Item("RazonSocial"), nFon, Brushes.Black, 40, 100)

        e.Graphics.DrawString("ABONADO", nFon, Brushes.Black, 40, 120)
        e.Graphics.DrawString("RAZON SOCIAL", nFon, Brushes.Black, 90, 120)
        e.Graphics.DrawString("FACTURA", nFon, Brushes.Black, 360, 120)
        e.Graphics.DrawString("AUTORIZACION", nFon, Brushes.Black, 400, 120)
        e.Graphics.DrawString("CONTROL", nFon, Brushes.Black, 470, 120)
        e.Graphics.DrawString("CON_M3", nFon, Brushes.Black, 530, 120)
        e.Graphics.DrawString("IMPORTE", nFon, Brushes.Black, 570, 120)
        e.Graphics.DrawString("SERVICIOS", nFon, Brushes.Black, 620, 120)
        e.Graphics.DrawString("RECARGOS", nFon, Brushes.Black, 680, 120)
        e.Graphics.DrawString("TOTAL", nFon, Brushes.Black, 740, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 120, 780, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 135, 780, 135)

        For I = 140 To 1030 Step 13
            e.Graphics.DrawString(ds.Tables("REP").Rows(F).Item("ABONADO"), sFon, Brushes.Black, 40, I)
            e.Graphics.DrawString(ds.Tables("REP").Rows(F).Item("RAZON"), sFon, Brushes.Black, 90, I)
            e.Graphics.DrawString(ds.Tables("REP").Rows(F).Item("NUM_FACTURA"), sFon, Brushes.Black, 360, I)
            e.Graphics.DrawString(ds.Tables("REP").Rows(F).Item("NUM_ORDEN"), sFon, Brushes.Black, 400, I)
            e.Graphics.DrawString(IIf(IsDBNull(ds.Tables("REP").Rows(F).Item("CODIGO_CONTROL")), "", ds.Tables("REP").Rows(F).Item("CODIGO_CONTROL")), sFon, Brushes.Black, 470, I)

            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(F).Item("CON_M3"), "#0.00"), sFon)
            e.Graphics.DrawString(ds.Tables("REP").Rows(F).Item("CON_M3"), sFon, Brushes.Black, 570 - zTam.Width, I)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(F).Item("IMP_TOTAL"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_TOTAL"), "#0.00"), sFon, Brushes.Black, 610 - zTam.Width, I)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(F).Item("IMP_SERVICIOS"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_SERVICIOS"), "#0.00"), sFon, Brushes.Black, 670 - zTam.Width, I)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(F).Item("IMP_RECARGO"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_RECARGO"), "#0.00"), sFon, Brushes.Black, 730 - zTam.Width, I)
            zTam = e.Graphics.MeasureString(Format(ds.Tables("REP").Rows(F).Item("IMP_FACTURA"), "#0.00"), sFon)
            e.Graphics.DrawString(Format(ds.Tables("REP").Rows(F).Item("IMP_FACTURA"), "#0.00"), sFon, Brushes.Black, 780 - zTam.Width, I)

            T += ds.Tables("REP").Rows(F).Item("IMP_FACTURA")
            F += 1
            If F = ds.Tables("REP").Rows.Count Then
                I += 15
                zTam = e.Graphics.MeasureString(Format(T, "#0.00"), nFon)
                e.Graphics.DrawString(Format(T, "#0.00"), nFon, Brushes.Black, 780 - zTam.Width, I)
                T = 0
                P = 0
                Exit For
            Else
                If P <> ds.Tables("REP").Rows(F).Item("PROFORMA") Then
                    I += 15
                    zTam = e.Graphics.MeasureString(Format(T, "#0.00"), nFon)
                    e.Graphics.DrawString(Format(T, "#0.00"), nFon, Brushes.Black, 780 - zTam.Width, I)
                    T = 0
                    P = ds.Tables("REP").Rows(F).Item("PROFORMA")
                    Exit For
                End If
            End If
        Next

        If F = ds.Tables("REP").Rows.Count Then
            F = 0
            T = 0
            P = 0
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            If chkEmpresa.Checked Then
                da.SelectCommand.CommandText = "SELECT * FROM VER_PROFORMAS WHERE EMISION = '" & cboPeriodo.SelectedValue & "' AND PROFORMA = '" & cboEmpresa.SelectedValue & "' ORDER BY PROFORMA, ABONADO"
            Else
                da.SelectCommand.CommandText = "SELECT * FROM VER_PROFORMAS WHERE EMISION = '" & cboPeriodo.SelectedValue & "' ORDER BY PROFORMA, ABONADO"
            End If

            da.Fill(ds, "REP")
            If ds.Tables("REP").Rows.Count > 0 Then
                F = 0
                P = ds.Tables("REP").Rows(F).Item("PROFORMA")
                T = 0
                VerDoc.ShowDialog()
            End If
            ds.Tables("REP").Clear()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub chkEmpresa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEmpresa.CheckedChanged
        cboEmpresa.Visible = chkEmpresa.Checked
    End Sub
End Class