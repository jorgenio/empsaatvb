Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_Lista_Corte
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim nPag As Integer
    Dim f As Integer
    Dim i As Integer
    Dim nRuta As Integer
    Dim nSubRuta As Integer

    Private Sub Frm_Lista_Corte_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        da.SelectCommand.CommandText = "Select Distinct NoLista From Servicios_Solicitud Where NoLista > 0 Order by NoLista Desc"
        da.Fill(ds, "Lista")
        cboNumero.DataSource = ds.Tables("Lista")
        cboNumero.DisplayMember = "NoLISTA"
        cboNumero.ValueMember = "NoLISTA"

        da.SelectCommand.CommandText = "Select L.NoSolicitud, L.Abonado, U.Nombre, U.Zona, U.Calle, L.Pagado, L.Nota From Servicios_Solicitud L Inner Join Usuarios U On L.Abonado = U.Abonado Where NoLista = " & cboNumero.SelectedValue
        da.Fill(ds, "Registros")
        ds.Tables("Registros").Clear()
        da.Fill(ds, "Registros")
        dgLista.DataSource = ds.Tables("Registros")
    End Sub

    Private Sub Ver_Registros(ByVal Lista As Integer)
        da.SelectCommand.CommandText = "Select L.NoSolicitud, L.Abonado, U.Nombre, U.Zona, U.Calle, L.Pagado, L.Nota From Servicios_Solicitud L Inner Join Usuarios U On L.Abonado = U.Abonado Where NoLista = " & cboNumero.SelectedValue
        da.Fill(ds, "Registros")
        ds.Tables("Registros").Clear()
        da.Fill(ds, "Registros")
    End Sub

    Private Sub cboNumero_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNumero.SelectionChangeCommitted
        Ver_Registros(cboNumero.SelectedValue)
    End Sub

    Private Sub BtnNuevaLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevaLista.Click
        Dim fReg As New Frm_Lista_Corte_Reg
        If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
            ds.Tables("Lista").Clear()
            da.SelectCommand.CommandText = "Select Distinct NoLista From Servicios_Solicitud Where NoLista > 0 Order by NoLista Desc"
            da.Fill(ds, "Lista")
            Ver_Registros(cboNumero.SelectedValue)
        End If
        'Dim nNuevaLista As Integer
        'Dim txt As String
        'Dim cmd As New SqlCommand
        'Dim NoCorrelativo As Integer

        'Dim j As Integer

        'Try
        '    da.SelectCommand.CommandText = "Select Max(NoLista) AS Nro From Servicios_Solicitud"
        '    da.Fill(ds, "NroLista")
        '    If ds.Tables("NroLista").Rows.Count > 0 Then
        '        If IsDBNull(ds.Tables("NroLista").Rows(0).Item("Nro")) Then
        '            nNuevaLista = 1
        '        Else
        '            nNuevaLista = ds.Tables("NroLista").Rows(0).Item("Nro") + 1
        '        End If
        '    End If
        '    ds.Tables("NroLista").Clear()

        '    da.SelectCommand.CommandText = "Select Max(NoSolicitud) as Nro From Servicios_Solicitud"
        '    da.Fill(ds, "NroOrden")
        '    If ds.Tables("NroOrden").Rows.Count > 0 Then
        '        If IsDBNull(ds.Tables("NroOrden").Rows(0).Item("Nro")) Then
        '            NoCorrelativo = 0
        '        Else
        '            NoCorrelativo = ds.Tables("NroOrden").Rows(0).Item("Nro")
        '        End If
        '    End If
        '    ds.Tables("NroOrden").Clear()

        '    db.Open()
        '    Progreso.Visible = True
        '    da.SelectCommand.CommandText = "SELECT U.ABONADO, COUNT(*) AS Nro FROM FACTURAS F inner join USUARIOS U ON F.ABONADO = U.ABONADO WHERE FEC_PAGO IS NULL AND ESTADO = 'N' GROUP BY u.ABONADO HAVING COUNT(*) > 2"
        '    da.Fill(ds, "Deu")
        '    For j = 0 To ds.Tables("Deu").Rows.Count - 1
        '        NoCorrelativo += 1
        '        txt = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Nombre, Doc, NoDoc, Nit, Nacimiento, Estado, Cobrado, Factura, Formulario, NoLista) Values ('" & _
        '            NoCorrelativo & "','" & _
        '            ds.Tables("Deu").Rows(j).Item("Abonado") & "','" & _
        '            FormatDateTime(Date.Now, DateFormat.ShortDate) & "','" & _
        '            1010 & "','" & _
        '            0 & "','" & _
        '            ds.Tables("Deu").Rows(j).Item("Nro") & "','" & _
        '            Empleado & "','','','','','',0,0,0,0,'" & nNuevaLista & "')"

        '        With cmd
        '            .Connection = db
        '            .CommandType = CommandType.Text
        '            .CommandText = txt
        '            .ExecuteNonQuery()
        '        End With

        '        Progreso.Value = Int((j / ds.Tables("Deu").Rows.Count) * 100)
        '        Progreso.Refresh()
        '    Next j

        '    db.Close()
        '    ds.Tables.Clear()
        '    Call Ver_Lista()
        '    Progreso.Visible = False
        '    MessageBox.Show("Se ha elaborado la nueva lista satisfactoriamente", "Proceso Terminado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        'Catch x As Exception
        '    MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally
        '    If db.State = ConnectionState.Open Then db.Close()
        'End Try
    End Sub

    Private Sub BtnVerLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerLista.Click
        Dim dst As New DataSet
        Dim j As Integer
        Dim noMeses As Integer
        Dim nAbonado As Int64
        Dim txt As String
        Dim cmd As New SqlCommand

        Try
            db.Open()

            txt = "UPDATE Servicios_Solicitud SET Pagado = '2' Where Pagado = '1' And NoLista = " & cboNumero.SelectedValue

            With cmd
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With

            'Progreso.Visible = True
            da.SelectCommand.CommandText = "Select Abonado, Pagado, NoLista From Servicios_solicitud Where NoLista = " & cboNumero.SelectedValue & " AND Pagado Is Null"
            da.Fill(ds, "Actualiza")
            For j = 0 To ds.Tables("Actualiza").Rows.Count - 1
                noMeses = 0
                nAbonado = ds.Tables("Actualiza").Rows(j).Item("Abonado")

                da.SelectCommand.CommandText = "Select count(*) as Nro From Facturas Where Abonado = " & ds.Tables("Actualiza").Rows(j).Item("Abonado") & " And Fec_Pago Is Null"
                da.Fill(ds, "Deu")
                If ds.Tables("Deu").Rows.Count > 0 Then
                    If ds.Tables("Deu").Rows(0).Item("Nro") Then
                        noMeses = ds.Tables("Deu").Rows(0).Item("Nro")
                    End If
                End If
                ds.Tables("Deu").Clear()

                If noMeses < 3 Then
                    txt = "UPDATE Servicios_Solicitud SET Pagado = 1 Where Abonado = " & nAbonado & " And NoLista = " & cboNumero.SelectedValue
                    With cmd
                        .Connection = db
                        .CommandType = CommandType.Text
                        .CommandText = txt
                        .ExecuteNonQuery()
                    End With
                Else
                    txt = "UPDATE Servicios_Solicitud Set Nota = '" & noMeses.ToString & "' Where Abonado = " & nAbonado & " And NoLista = " & cboNumero.SelectedValue
                    With cmd
                        .Connection = db
                        .CommandType = CommandType.Text
                        .CommandText = txt
                        .ExecuteNonQuery()
                    End With
                End If

                'Progreso.Value = Int((j / ds.Tables("Actualiza").Rows.Count) * 100)
                'Progreso.Refresh()
            Next j
            'Progreso.Visible = False
            MessageBox.Show("Proceso terminado con éxito", "Proceso terminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            db.Close()
            ds.Tables("Deu").Clear()
            ds.Tables("Actualiza").Clear()
            Ver_Registros(cboNumero.SelectedValue)
        Catch x As Exception
            MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub BtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimir.Click
        Dim oRptDir As New Rep_Lista_Corte
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        Dim cmd As New SqlCommand
        Dim xNumero As SqlParameter

        Try
            oConexInfo.ServerName = "SERVIDORHP"
            oConexInfo.DatabaseName = "EMPSAAT"
            oConexInfo.UserID = _Usuario
            oConexInfo.Password = _Clave

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Rep_ListaCorte"
                xNumero = .Parameters.Add("@Numero", SqlDbType.Int)
                xNumero.Direction = ParameterDirection.Input
                xNumero.Value = cboNumero.SelectedValue
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
        Dim sFon As New Font("Arial Narrow", 8, FontStyle.Regular)
        Dim nFon As New Font("Arial Narrow", 8, FontStyle.Bold)
        Dim mFon As New Font("Arial Narrow", 7, FontStyle.Regular)
        Dim zTam As System.Drawing.SizeF

        e.Graphics.DrawString("EMPRESA MUNICIPAL DE SERVICIOS", mFon, Brushes.Black, 70, 50)
        e.Graphics.DrawString("AGUA POTABLE Y ALCANTARRILADO TUPIZA", mFon, Brushes.Black, 50, 65)
        e.Graphics.DrawString("TUPIZA - BOLIVIA", mFon, Brushes.Black, 90, 80)

        e.Graphics.DrawString("LISTA DE CORTE", tFon, Brushes.Black, 320, 50)
        e.Graphics.DrawString("Correspondiente a la fecha:" & FormatDateTime(ds.Tables("Rep").Rows(0).Item("Fecha"), DateFormat.ShortDate), nFon, Brushes.Black, 300, 75)

        e.Graphics.DrawString("Lista: " & ds.Tables("Rep").Rows(0).Item("NoLista"), mFon, Brushes.Black, 650, 50)
        e.Graphics.DrawString("Página: " & nPag, mFon, Brushes.Black, 650, 65)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 780, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 780, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 780, 40, 780, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)

        e.Graphics.DrawString("ABONADO", nFon, Brushes.Black, 40, 120)
        e.Graphics.DrawString("RAZON SOCIAL", nFon, Brushes.Black, 110, 120)
        e.Graphics.DrawString("DIRECCION", nFon, Brushes.Black, 340, 120)
        e.Graphics.DrawString("DEUDA", nFon, Brushes.Black, 590, 120)
        e.Graphics.DrawString("CORTE", nFon, Brushes.Black, 640, 120)
        e.Graphics.DrawString("NOTA", nFon, Brushes.Black, 720, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 120, 780, 120)
        e.Graphics.DrawLine(Pens.Black, 40, 135, 780, 135)

        For i = 150 To 1035 Step 20
            If nRuta <> ds.Tables("REP").Rows(f).Item("RUTA") Then
                e.Graphics.DrawString("RUTA: " & ds.Tables("REP").Rows(f).Item("RUTA"), nFon, Brushes.Black, 40, i)
                nRuta = ds.Tables("REP").Rows(f).Item("RUTA")
                i += 15
            End If
            If nSubRuta <> ds.Tables("REP").Rows(f).Item("SUBRUTA") Then
                e.Graphics.DrawString("SUB RUTA: " & ds.Tables("REP").Rows(f).Item("SUBRUTA"), nFon, Brushes.Black, 40, i)
                nSubRuta = ds.Tables("REP").Rows(f).Item("SUBRUTA")
                i += 15
            End If
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("NUMRUTA"), mFon, Brushes.Black, 40, i)
            zTam = e.Graphics.MeasureString(ds.Tables("REP").Rows(f).Item("ABONADO"), sFon)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("Abonado"), sFon, Brushes.Black, 100 - zTam.Width, i)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("RAZON"), sFon, Brushes.Black, 110, i)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("ZONA") & " " & ds.Tables("REP").Rows(f).Item("CALLE"), sFon, Brushes.Black, 340, i)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("NOSOLICITUD"), mFon, Brushes.Black, 570, i)
            zTam = e.Graphics.MeasureString(ds.Tables("REP").Rows(f).Item("NOTA"), sFon)
            e.Graphics.DrawString(ds.Tables("REP").Rows(f).Item("NOTA"), sFon, Brushes.Black, 630 - zTam.Width, i)
            If Not IsDBNull(ds.Tables("REP").Rows(f).Item("PAGADO")) Then e.Graphics.DrawString(IIf(ds.Tables("REP").Rows(f).Item("PAGADO") = "", "", "PAGADO"), sFon, Brushes.Black, 600, i)
            e.Graphics.DrawLine(Pens.Black, 610, i + 20, 780, i + 20)
            f += 1
            If f = ds.Tables("REP").Rows.Count Then
                Exit For
            End If

            If nRuta <> ds.Tables("REP").Rows(f).Item("RUTA") Then
                Exit For
            End If
        Next

        If f = ds.Tables("REP").Rows.Count Then
            f = 0
            nPag = 1
            e.HasMorePages = False
        Else
            nPag += 1
            e.HasMorePages = True
        End If

    End Sub

    Private Sub btnImprimirListaNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirListaNuevo.Click
        da.SelectCommand.CommandText = "Select * From Ver_Orden_Servicio Where NoLista = " & cboNumero.SelectedValue & " Order By Ruta, SubRuta, NumRuta"
        da.Fill(ds, "REP")
        If ds.Tables("REP").Rows.Count > 0 Then
            f = 0
            nPag = 1
            nRuta = -1
            nSubRuta = -1
            VerDoc.Document = Doc
            VerDoc.ShowDialog()
        End If
        ds.Tables("REP").Clear()
    End Sub
End Class