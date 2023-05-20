Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_Servicios
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim nTipo As Integer

    Private Sub Frm_Servicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select Abonado From Usuarios Where NODOC = '" & pCliente & "' Order by Abonado"
        da.Fill(ds, "Abo")
        cboAbonado.DataSource = ds.Tables("Abo")
        cboAbonado.DisplayMember = "Abonado"
        cboAbonado.ValueMember = "Abonado"
        cboAbonado.SelectedValue = nAbonado

        da.SelectCommand.CommandText = "Select S.NoSolicitud, S.Fecha, L.Descripcion, S.Costo, S.Nota, S.Fec_Atendido, E.Paterno, E.Materno, E.Nombre, S.NoLista From ((Servicios_Solicitud S Inner Join Servicios_Lista L On S.Servicio = L.Servicio) Left Join Emp_Empleados E On S.Empleado = E.Codigo) Where S.Abonado = " & nAbonado & " And Estado <> 2 Order By NoSolicitud"
        da.Fill(ds, "Ser")
        Ver_Abonado(cboAbonado.SelectedValue)
        dgServicios.DataSource = ds.Tables("Ser")
    End Sub

    Private Sub Ver_Abonado(ByVal Abonado As Integer)
        da.SelectCommand.CommandText = "Select * From Ver_Usuarios Where Abonado = '" & Abonado & "'"
        da.Fill(ds, "Usuario")
        TxCliente.Text = ds.Tables("Usuario").Rows(0).Item("Cliente")
        TxUsuario.Text = IIf(IsDBNull(ds.Tables("Usuario").Rows(0).Item("Razon")), "", ds.Tables("Usuario").Rows(0).Item("Razon"))
        TxCategoria.Text = IIf(IsDBNull(ds.Tables("Usuario").Rows(0).Item("Categoria")), "", ds.Tables("Usuario").Rows(0).Item("Categoria"))
        TxNIT.Text = IIf(IsDBNull(ds.Tables("Usuario").Rows(0).Item("Nit")), 0, ds.Tables("Usuario").Rows(0).Item("Nit"))
        CkLey1886.Checked = ds.Tables("Usuario").Rows(0).Item("Ley1886")
        TxCuenta.Text = IIf(IsDBNull(ds.Tables("Usuario").Rows(0).Item("Estado")), "", ds.Tables("Usuario").Rows(0).Item("Estado"))
        TxZona.Text = IIf(IsDBNull(ds.Tables("Usuario").Rows(0).Item("Zona")), "", ds.Tables("Usuario").Rows(0).Item("Zona"))
        TxCalle.Text = IIf(IsDBNull(ds.Tables("Usuario").Rows(0).Item("Calle")), "", ds.Tables("Usuario").Rows(0).Item("Calle")) & " " & IIf(IsDBNull(ds.Tables("Usuario").Rows(0).Item("Num")), "", ds.Tables("Usuario").Rows(0).Item("Num"))
        txtRuta.Text = ds.Tables("Usuario").Rows(0).Item("Ruta")
        txtSubRuta.Text = ds.Tables("Usuario").Rows(0).Item("SubRuta")
        txtNoRuta.Text = ds.Tables("Usuario").Rows(0).Item("NumRuta")
        ds.Tables("Usuario").Clear()

        Ver_Servicios(Abonado)
    End Sub

    Private Sub Ver_Servicios(ByVal Abonado As Integer)
        ds.Tables("Ser").Clear()
        da.SelectCommand.CommandText = "Select S.NoSolicitud, S.Fecha, L.Descripcion, S.Costo, S.Nota, S.Fec_Atendido, E.Paterno, E.Materno, E.Nombre, NoLista From ((Servicios_Solicitud S Inner Join Servicios_Lista L On S.Servicio = L.Servicio) Left Join Emp_Empleados E On S.Empleado = E.Codigo) Where S.Abonado = " & Abonado & " And Estado <> 2 Order By NoSolicitud"
        da.Fill(ds, "Ser")
    End Sub

    Private Sub BtnNuevaOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevaOrden.Click
        Dim fSerSol As New Frm_Servicios_Solicitud
        If fSerSol.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call Ver_Servicios(cboAbonado.SelectedValue)
            Imprimir_Orden_Nuevo(nOrden)
            'Imprimir_Orden(nOrden)
        End If
    End Sub

    Private Sub Imprimir_Orden(ByVal Numero As Integer)
        Dim nServicio As Integer
        da.SelectCommand.CommandText = "Select Servicio From Servicios_Solicitud Where NoSolicitud = " & Numero
        da.Fill(ds, "Nro")
        If ds.Tables("Nro").Rows.Count > 0 Then
            nServicio = ds.Tables("Nro").Rows(0).Item("Servicio")
        End If
        If nServicio = 1006 Then
            Call Orden_Direccion(Numero)
        ElseIf nServicio = 1007 Then
            Call Orden_CambioNombre(Numero)
        ElseIf nServicio = 1008 Then
            Call Orden_Categoria(Numero)
        Else
            Call Orden_Servicio(Numero)
        End If
        ds.Tables("Nro").Clear()
    End Sub

    Private Sub Orden_Direccion(ByVal _Orden As Integer)
        Dim oRptDir As New Rep_OrdenServicio_CambioDireccion
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        Dim cmd As New SqlCommand
        Dim xOrden As SqlParameter

        Try
            oConexInfo.ServerName = "SERVIDORHP"
            oConexInfo.DatabaseName = "EMPSAAT"
            oConexInfo.UserID = _Usuario
            oConexInfo.Password = _Clave

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "RepOrdenServicio"
                xOrden = .Parameters.Add("@Orden", SqlDbType.Int)
                xOrden.Direction = ParameterDirection.Input
                xOrden.Value = _Orden
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

    Private Sub Orden_CambioNombre(ByVal _Orden As Integer)
        Dim oRptDir As New Rep_OrdenServicio_CambioNombre
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        Dim cmd As New SqlCommand
        Dim xOrden As SqlParameter

        Try
            oConexInfo.ServerName = "SERVIDORHP"
            oConexInfo.DatabaseName = "EMPSAAT"
            oConexInfo.UserID = _Usuario
            oConexInfo.Password = _Clave

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "RepOrdenServicio"
                xOrden = .Parameters.Add("@Orden", SqlDbType.Int)
                xOrden.Direction = ParameterDirection.Input
                xOrden.Value = _Orden
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

    Private Sub Orden_Categoria(ByVal _Orden As Integer)
        Dim oRptDir As New Rep_OrdenServicio_CambioCategoria
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        Dim cmd As New SqlCommand
        Dim xOrden As SqlParameter

        Try
            oConexInfo.ServerName = "SERVIDORHP"
            oConexInfo.DatabaseName = "EMPSAAT"
            oConexInfo.UserID = _Usuario
            oConexInfo.Password = _Clave

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "RepOrdenServicio"
                xOrden = .Parameters.Add("@Orden", SqlDbType.Int)
                xOrden.Direction = ParameterDirection.Input
                xOrden.Value = _Orden
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

    Private Sub Orden_Servicio(ByVal _Orden As Integer)
        Dim oRptDir As New Rep_OrdenServicio
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        Dim cmd As New SqlCommand
        Dim xOrden As SqlParameter

        Try
            oConexInfo.ServerName = "SERVIDORHP"
            oConexInfo.DatabaseName = "EMPSAAT"
            oConexInfo.UserID = _Usuario
            oConexInfo.Password = _Clave

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "RepOrdenServicio"
                xOrden = .Parameters.Add("@Orden", SqlDbType.Int)
                xOrden.Direction = ParameterDirection.Input
                xOrden.Value = _Orden
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

    Private Sub BtnImprimirOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimirOrden.Click
        nOrden = dgServicios.Item("NoSolicitud", dgServicios.CurrentRow.Index).Value
        Imprimir_Orden_Nuevo(nOrden)
    End Sub

    Private Sub Imprimir_Orden_Nuevo(ByVal nOrden As Integer)
        da.SelectCommand.CommandText = "Select * From VER_ORDEN_SERVICIO where NoSolicitud = " & nOrden
        da.Fill(ds, "REP")
        If ds.Tables("REP").Rows.Count > 0 Then
            VerDoc.Document = Doc
            VerDoc.ShowDialog()
        End If
        ds.Tables("REP").Clear()
    End Sub


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
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

        e.Graphics.DrawString("ORDEN DE SERVICIO", tFon, Brushes.Black, 300, 50)

        e.Graphics.DrawString("Numero: " & ds.Tables("Rep").Rows(0).Item("NoSolicitud"), mFon, Brushes.Black, 650, 50)
        e.Graphics.DrawString("Fecha: " & ds.Tables("Rep").Rows(0).Item("Fecha"), mFon, Brushes.Black, 650, 65)

        e.Graphics.DrawLine(Pens.Black, 40, 40, 780, 40)
        e.Graphics.DrawLine(Pens.Black, 40, 95, 780, 95)
        e.Graphics.DrawLine(Pens.Black, 40, 40, 40, 95)
        e.Graphics.DrawLine(Pens.Black, 780, 40, 780, 95)

        e.Graphics.DrawLine(Pens.Black, 240, 40, 240, 95)
        e.Graphics.DrawLine(Pens.Black, 580, 40, 580, 95)
        e.Graphics.DrawLine(Pens.Black, 130, 385, 490, 385)
        e.Graphics.DrawLine(Pens.Black, 130, 405, 490, 405)
        e.Graphics.DrawLine(Pens.Black, 130, 425, 490, 425)
        e.Graphics.DrawLine(Pens.Black, 50, 445, 490, 445)
        e.Graphics.DrawLine(Pens.Black, 50, 465, 490, 465)
        e.Graphics.DrawLine(Pens.Black, 50, 485, 490, 485)
        e.Graphics.DrawLine(Pens.Black, 50, 505, 490, 505)
        e.Graphics.DrawLine(Pens.Black, 50, 525, 490, 525)
        e.Graphics.DrawLine(Pens.Black, 50, 545, 490, 545)

        'horizonales
        e.Graphics.DrawLine(Pens.Black, 40, 110, 780, 110)
        e.Graphics.DrawLine(Pens.Black, 40, 225, 780, 225)
        e.Graphics.DrawLine(Pens.Black, 40, 355, 780, 355)
        e.Graphics.DrawLine(Pens.Black, 40, 1000, 780, 1000)
        e.Graphics.DrawLine(Pens.Black, 510, 180, 770, 180)
        e.Graphics.DrawLine(Pens.Black, 510, 195, 770, 195)
        e.Graphics.DrawLine(Pens.Black, 510, 210, 770, 210)
        'Verticales
        e.Graphics.DrawLine(Pens.Black, 40, 110, 40, 1000)
        e.Graphics.DrawLine(Pens.Black, 780, 110, 780, 1000)
        e.Graphics.DrawLine(Pens.Black, 500, 110, 500, 1000)

        e.Graphics.DrawString("ABONADO : ", nFon, Brushes.Black, 50, 120)
        e.Graphics.DrawString("RAZON SOCIAL: ", nFon, Brushes.Black, 50, 135)
        e.Graphics.DrawString("ZONA: ", nFon, Brushes.Black, 50, 150)
        e.Graphics.DrawString("CALLE: ", nFon, Brushes.Black, 50, 165)
        e.Graphics.DrawString("RUTA: ", nFon, Brushes.Black, 50, 180)
        e.Graphics.DrawString("SUBRUTA: ", nFon, Brushes.Black, 50, 195)
        e.Graphics.DrawString("NUM RUTA: ", nFon, Brushes.Black, 50, 210)

        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("ABONADO"), sFon, Brushes.Black, 150, 120)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("RAZON"), sFon, Brushes.Black, 150, 135)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("ZONA"), sFon, Brushes.Black, 150, 150)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("CALLE"), sFon, Brushes.Black, 150, 165)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("RUTA"), sFon, Brushes.Black, 150, 180)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("SUBRUTA"), sFon, Brushes.Black, 150, 195)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("NUMRUTA"), sFon, Brushes.Black, 150, 210)

        e.Graphics.DrawString("Firma", sFon, Brushes.Black, 510, 180)
        e.Graphics.DrawString("Nombre", sFon, Brushes.Black, 510, 195)
        e.Graphics.DrawString("Tel. Cel", sFon, Brushes.Black, 510, 210)

        e.Graphics.DrawString("CODIGO: ", nFon, Brushes.Black, 50, 240)
        e.Graphics.DrawString("SERVICIO: ", nFon, Brushes.Black, 50, 255)
        e.Graphics.DrawString("COSTO: ", nFon, Brushes.Black, 50, 270)
        e.Graphics.DrawString("NOTA: ", nFon, Brushes.Black, 50, 295)

        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("SERVICIO"), sFon, Brushes.Black, 150, 240)
        e.Graphics.DrawString(UCase(ds.Tables("REP").Rows(0).Item("DESCSERVICIO")), nFon, Brushes.Black, 150, 255)
        e.Graphics.DrawString(FormatNumber(ds.Tables("REP").Rows(0).Item("COSTO"), 2), sFon, Brushes.Black, 150, 270)
        e.Graphics.DrawString(ds.Tables("REP").Rows(0).Item("NOTA"), sFon, Brushes.Black, 150, 285)

        e.Graphics.DrawString("INSTRUCCION GERENCIA", nFon, Brushes.Black, 510, 240)
        e.Graphics.DrawString("SR.: ____________________________", nFon, Brushes.Black, 510, 255)
        e.Graphics.DrawString("De la seccion: _____________________________", sFon, Brushes.Black, 510, 270)
        e.Graphics.DrawString("Efectuar el servicio solicitado", sFon, Brushes.Black, 510, 295)
        e.Graphics.DrawString("y presentar el informe respectivo", sFon, Brushes.Black, 510, 310)
        e.Graphics.DrawString("GERENTE GENERAL", sFon, Brushes.Black, 650, 340)

        e.Graphics.DrawString("INFORME DE EJECUCION DEL SERVICIO", nFon, Brushes.Black, 50, 355)
        e.Graphics.DrawString("Fecha de Atención:", nFon, Brushes.Black, 50, 370)
        e.Graphics.DrawString("Hora de Atencion:", nFon, Brushes.Black, 50, 385)
        e.Graphics.DrawString("Informe:", nFon, Brushes.Black, 50, 405)

        If ds.Tables("REP").Rows(0).Item("SERVICIO") = 1006 Then 'Traslado de medidor
            e.Graphics.DrawString("NUEVA DIRECCION: ", nFon, Brushes.Black, 50, 560)
            e.Graphics.DrawString("Zona:" & ds.Tables("Rep").Rows(0).Item("NZona"), sFon, Brushes.Black, 60, 575)
            e.Graphics.DrawString("Dirección: " & ds.Tables("Rep").Rows(0).Item("NCalle") & " " & ds.Tables("Rep").Rows(0).Item("NNumero"), sFon, Brushes.Black, 60, 590)
        ElseIf ds.Tables("REP").Rows(0).Item("SERVICIO") = 1007 Then 'CAMBIO NOMBRE
            e.Graphics.DrawString("NUEVA RAZON SOCIAL", nFon, Brushes.Black, 50, 560)
            e.Graphics.DrawString("Nueva razón social:" & ds.Tables("Rep").Rows(0).Item("NNOMBRE"), sFon, Brushes.Black, 60, 575)
            e.Graphics.DrawString("Tipo de documento:" & ds.Tables("Rep").Rows(0).Item("NDoc"), sFon, Brushes.Black, 60, 590)
            e.Graphics.DrawString("Nro. de documento:" & ds.Tables("Rep").Rows(0).Item("NNoDoc"), sFon, Brushes.Black, 60, 605)
        ElseIf ds.Tables("Rep").Rows(0).Item("SERVICIO") = 1008 Then ' CAMBIO DE CATEGORIA
            e.Graphics.DrawString("NUEVA CATEGORIA", nFon, Brushes.Black, 50, 560)
            e.Graphics.DrawString("Categoría:" & ds.Tables("Rep").Rows(0).Item("Desc_Categoria"), sFon, Brushes.Black, 60, 575)
        Else
            ' todos las solicitudes normales
            e.Graphics.DrawString("MATERIAL UTILIZADO", nFon, Brushes.Black, 50, 560)
            e.Graphics.DrawString("Cantidad", sFon, Brushes.Black, 50, 575)
            e.Graphics.DrawString("Unidad", sFon, Brushes.Black, 150, 575)
            e.Graphics.DrawString("Descripcion", sFon, Brushes.Black, 200, 575)
            e.Graphics.DrawLine(Pens.Black, 50, 590, 490, 590)
            e.Graphics.DrawLine(Pens.Black, 129, 590, 129, 790)
            e.Graphics.DrawLine(Pens.Black, 199, 590, 199, 790)
            e.Graphics.DrawLine(Pens.Black, 50, 790, 490, 790)
        End If


        e.Graphics.DrawString("Firma del técnico", sFon, Brushes.Black, 50, 900)
        e.Graphics.DrawString("Nombre del técnico:", sFon, Brushes.Black, 50, 920)
        e.Graphics.DrawLine(Pens.Black, 120, 915, 490, 915)
        e.Graphics.DrawLine(Pens.Black, 120, 935, 490, 935)

        e.Graphics.DrawString("PROCESO EN BASE DE DATOS", nFon, Brushes.Black, 510, 355)
        e.Graphics.DrawString("Fecha de proceso:", sFon, Brushes.Black, 510, 375)
        e.Graphics.DrawString("Firma", sFon, Brushes.Black, 510, 600)
        e.Graphics.DrawString("Nombre", sFon, Brushes.Black, 510, 620)

        e.Graphics.DrawLine(Pens.Black, 550, 390, 770, 390)
        e.Graphics.DrawLine(Pens.Black, 550, 620, 770, 620)
        e.Graphics.DrawLine(Pens.Black, 500, 640, 780, 640)

        e.Graphics.DrawString("COBRADO", nFon, Brushes.Black, 510, 665)
        e.Graphics.DrawString("Fecha", sFon, Brushes.Black, 510, 685)
        e.Graphics.DrawString("Factura", sFon, Brushes.Black, 510, 705)
        e.Graphics.DrawString("Firma", sFon, Brushes.Black, 510, 900)
        e.Graphics.DrawString("Nombre", sFon, Brushes.Black, 510, 920)
        e.Graphics.DrawLine(Pens.Black, 550, 705, 770, 705)
        e.Graphics.DrawLine(Pens.Black, 550, 725, 770, 725)
        e.Graphics.DrawLine(Pens.Black, 550, 915, 770, 915)
        e.Graphics.DrawLine(Pens.Black, 550, 935, 770, 935)

    End Sub

    Private Sub QuitarImporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularToolStripMenuItem.Click
        Try
            Dim nSolicitud As Integer
            Dim txt As String
            Dim cmd As New SqlCommand
            nSolicitud = dgServicios.Item("NoSolicitud", dgServicios.CurrentRow.Index).Value
            If MessageBox.Show("Esta seguro de quitar el importe a la Orden de Servicio No " & nSolicitud, "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                txt = "UPDATE SERVICIOS_SOLICITUD SET COSTO = 0, NOTA = NOTA + ' [COSTO QUITADO X " & _Usuario & "]' WHERE NOSOLICITUD = " & nSolicitud
                db.Open()
                With cmd
                    .Connection = db
                    .CommandText = txt
                    .CommandType = CommandType.Text
                    .ExecuteNonQuery()
                End With
                db.Close()
                Ver_Servicios(cboAbonado.SelectedValue)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub
End Class