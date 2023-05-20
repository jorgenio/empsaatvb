Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_Libretas_Lecturacion
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim Proc As Integer
    Dim i As Integer
    Dim f As Integer
    Dim p As Integer
    Dim Ruta As Integer
    Dim SubRuta As Integer
    Dim cZona As String

    Private Sub Frm_Libretas_Lecturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select Top 1 Emision, Proceso From Factores Order by Emision Desc"
        da.Fill(ds, "Emision")
        If ds.Tables("Emision").Rows(0).Item("Proceso") <> 0 Then
            MessageBox.Show("Ya se imprimio las libretas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            BtnProcesar.Enabled = False
            btnImprimir2.Enabled = False
        End If
        TxtPeriodo.Text = Format(ds.Tables("Emision").Rows(0).Item("Emision"), "MMMM / yyyy")
        BtnProcesar.Focus()
    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
        Dim oRptLib As New Rep_Libretas
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        Dim cmd As New SqlCommand
        Dim xPeriodo As New SqlParameter
        Dim txt As String
        Try
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Rep_Libretas"
                xPeriodo = .Parameters.Add("@Emision", SqlDbType.DateTime)
                xPeriodo.Direction = ParameterDirection.Input
                xPeriodo.Value = TxtPeriodo.Text
                .ExecuteNonQuery()
            End With
            oConexInfo.ServerName = "SERVIDORHP"
            oConexInfo.DatabaseName = "EMPSAAT"
            oConexInfo.UserID = _Usuario
            oConexInfo.Password = _Clave

            oListaTablas = oRptLib.Database.Tables

            For Each oTabla In oListaTablas
                oTablaConexInfo = oTabla.LogOnInfo
                oTablaConexInfo.ConnectionInfo = oConexInfo
                oTabla.ApplyLogOnInfo(oTablaConexInfo)
            Next

            Dim fRep As New Frm_Reportes
            fRep.crvRep.ReportSource = oRptLib
            fRep.ShowDialog()
            If MessageBox.Show("Se ha imprimido correctamente las libretas", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                txt = "Update Factores Set Proceso = 1 Where Estado = 1"
                'db.Open()
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtPeriodo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
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

        e.Graphics.DrawString("LIBRETAS DE LECTURACION", tFon, Brushes.Black, 270, 50)
        e.Graphics.DrawString("Correspondiente al periodo:" & TxtPeriodo.Text, nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Ténico: __________________________", mFon, Brushes.Black, 600, 65)
        e.Graphics.DrawString("Página: " & p, mFon, Brushes.Black, 650, 50)
        e.Graphics.DrawString("RUTA " & Ruta, tFon, Brushes.Black, 650, 75)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 780, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 780, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 780, 40, 780, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        e.Graphics.DrawString("ABONADO", nFon, Brushes.Black, 40, 120)
        e.Graphics.DrawString("RAZON SOCIAL", nFon, Brushes.Black, 90, 120)
        e.Graphics.DrawString("DIRECCION", nFon, Brushes.Black, 340, 120)
        e.Graphics.DrawString("CAT", nFon, Brushes.Black, 550, 120)
        e.Graphics.DrawString("EST", nFon, Brushes.Black, 580, 120)
        e.Graphics.DrawString("ANTERIOR", nFon, Brushes.Black, 610, 120)
        e.Graphics.DrawString("LECTURA", nFon, Brushes.Black, 670, 120)
        e.Graphics.DrawString("NOTA", nFon, Brushes.Black, 730, 120)
        
        e.Graphics.DrawLine(Pens.Black, 40, 120, 780, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 135, 780, 135)

        For i = 150 To 1035 Step 20
            If Ruta <> ds.Tables("REP").Rows(f).Item("RUTA") Then
                Ruta = ds.Tables("REP").Rows(f).Item("RUTA")
                Exit For
            End If
            If SubRuta <> ds.Tables("REP").Rows(f).Item("SUBRUTA") Then
                i += 15
                e.Graphics.DrawString("SUB RUTA: " & ds.Tables("REP").Rows(f).Item("SUBRUTA"), nFon, Brushes.Black, 40, i)
                SubRuta = ds.Tables("REP").Rows(f).Item("SUBRUTA")
            Else
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("NUMRUTA"), mFon, Brushes.Black, 20, i)
                zTam = e.Graphics.MeasureString(ds.Tables("REP").Rows(f).Item("ABONADO"), sFon)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("ABONADO"), sFon, Brushes.Black, 80 - zTam.Width, i)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("RAZON"), sFon, Brushes.Black, 90, i)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("ZONA") & " " & ds.Tables("REP").Rows(f).Item("CALLE") & " " & ds.Tables("REP").Rows(f).Item("NUM"), mFon, Brushes.Black, 340, i)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("CATEGORIA"), sFon, Brushes.Black, 550, i)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("ESTADO"), sFon, Brushes.Black, 580, i)
                If IsDBNull(ds.Tables("REP").Rows(f).Item("LECTURA")) Then
                    zTam = e.Graphics.MeasureString("0", sFon)
                    e.Graphics.DrawString("0", sFon, Brushes.Black, 660 - zTam.Width, i)
                Else
                    zTam = e.Graphics.MeasureString(ds.Tables("REP").Rows(f).Item("LECTURA"), sFon)
                    e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("LECTURA"), sFon, Brushes.Black, 660 - zTam.Width, i)
                End If
                e.Graphics.DrawLine(Pens.Black, 670, i + 15, 780, i + 15)
                f += 1
                If f = ds.Tables("REP").Rows.Count Then
                    Exit For
                End If
            End If
        Next
        If f = ds.Tables("REP").Rows.Count Then
            f = 0
            p = 1
            Ruta = ds.Tables("Rep").Rows(f).Item("Ruta")
            SubRuta = ds.Tables("REP").Rows(f).Item("SubRuta")
            e.HasMorePages = False
        Else
            p += 1
            e.HasMorePages = True
        End If

    End Sub

    Private Sub btnImprimir2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir2.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
        
            da.SelectCommand.CommandText = "Select * From Ver_Libretas Order By Ruta, SubRuta, NumRuta, Razon"
            da.Fill(ds, "REP")
            If ds.Tables("REP").Rows.Count > 0 Then
                f = 0
                p = 1
                Ruta = ds.Tables("Rep").Rows(f).Item("Ruta")
                SubRuta = ds.Tables("REP").Rows(f).Item("SubRuta")
                VerDoc.Document = Doc
                VerDoc.ShowDialog()
            End If
            ds.Tables("REP").Clear()

            If MessageBox.Show("Se ha imprimido correctamente las libretas", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                txt = "Update Factores Set Proceso = 1 Where Estado = 1"
                db.Open()
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
                db.Close()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String

            da.SelectCommand.CommandText = "Select * From Ver_Libretas Order By Zona, Calle, Razon"
            da.Fill(ds, "REP")
            If ds.Tables("REP").Rows.Count > 0 Then
                f = 0
                p = 1
                cZona = ds.Tables("REP").Rows(f).Item("zona")
                VerDoc.Document = Lis
                VerDoc.ShowDialog()
            End If
            ds.Tables("REP").Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Lis_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Lis.PrintPage
        Dim tFon As New Font("Arial Narrow", 14, FontStyle.Bold)
        Dim sFon As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim nFon As New Font("Arial Narrow", 8, FontStyle.Bold)
        Dim mFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim zTam As System.Drawing.SizeF

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("LISTA DE USUARIOS", tFon, Brushes.Black, 310, 50)
        e.Graphics.DrawString("Correspondiente al periodo:" & TxtPeriodo.Text, nFon, Brushes.Black, 300, 75)

        'e.Graphics.DrawString("Ténico: __________________________", mFon, Brushes.Black, 600, 65)
        e.Graphics.DrawString("Página: " & p, mFon, Brushes.Black, 650, 50)
        'e.Graphics.DrawString("RUTA " & Ruta, tFon, Brushes.Black, 650, 75)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 780, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 780, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 780, 40, 780, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        e.Graphics.DrawString("ABONADO", nFon, Brushes.Black, 40, 120)
        e.Graphics.DrawString("RAZON SOCIAL", nFon, Brushes.Black, 90, 120)
        e.Graphics.DrawString("DIRECCION", nFon, Brushes.Black, 340, 120)
        e.Graphics.DrawString("CAT", nFon, Brushes.Black, 550, 120)
        e.Graphics.DrawString("EST", nFon, Brushes.Black, 580, 120)
        e.Graphics.DrawString("ANTERIOR", nFon, Brushes.Black, 610, 120)
        e.Graphics.DrawString("LECTURA", nFon, Brushes.Black, 670, 120)
        e.Graphics.DrawString("NOTA", nFon, Brushes.Black, 730, 120)

        e.Graphics.DrawLine(Pens.Black, 40, 120, 780, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 135, 780, 135)

        For i = 150 To 1035 Step 20
            If cZona <> ds.Tables("REP").Rows(f).Item("zona") Then
                cZona = ds.Tables("REP").Rows(f).Item("zona")
                Exit For
            End If
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("NUMRUTA"), mFon, Brushes.Black, 20, i)
                zTam = e.Graphics.MeasureString(ds.Tables("REP").Rows(f).Item("ABONADO"), sFon)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("ABONADO"), sFon, Brushes.Black, 80 - zTam.Width, i)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("RAZON"), sFon, Brushes.Black, 90, i)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("ZONA") & " " & ds.Tables("REP").Rows(f).Item("CALLE") & " " & ds.Tables("REP").Rows(f).Item("NUM"), mFon, Brushes.Black, 340, i)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("CATEGORIA"), sFon, Brushes.Black, 550, i)
                e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("ESTADO"), sFon, Brushes.Black, 580, i)
                If IsDBNull(ds.Tables("REP").Rows(f).Item("LECTURA")) Then
                    zTam = e.Graphics.MeasureString("0", sFon)
                    e.Graphics.DrawString("0", sFon, Brushes.Black, 660 - zTam.Width, i)
                Else
                    zTam = e.Graphics.MeasureString(ds.Tables("REP").Rows(f).Item("LECTURA"), sFon)
                    e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("LECTURA"), sFon, Brushes.Black, 660 - zTam.Width, i)
                End If
                e.Graphics.DrawLine(Pens.Black, 670, i + 15, 780, i + 15)
                f += 1
                If f = ds.Tables("REP").Rows.Count Then
                    Exit For
                End If

        Next
        If f = ds.Tables("REP").Rows.Count Then
            f = 0
            p = 1
            cZona = ds.Tables("REP").Rows(f).Item("zona")
            e.HasMorePages = False
        Else
            p += 1
            e.HasMorePages = True
        End If

    End Sub

    Private Sub btnRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuta.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            Dim nRuta As Integer

            nRuta = InputBox("Ruta", "Ruta", 0)

            da.SelectCommand.CommandText = "Select * From Ver_Libretas Where Ruta = " & nRuta & " Order By Ruta, SubRuta, NumRuta, Razon"
            da.Fill(ds, "REP")
            If ds.Tables("REP").Rows.Count > 0 Then
                f = 0
                p = 1
                Ruta = ds.Tables("Rep").Rows(f).Item("Ruta")
                SubRuta = ds.Tables("REP").Rows(f).Item("SubRuta")
                VerDoc.Document = Doc
                VerDoc.ShowDialog()
            End If
            ds.Tables("REP").Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub
End Class