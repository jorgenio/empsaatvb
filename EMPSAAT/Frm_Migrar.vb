Imports System.Data.SqlClient

Public Class Frm_Migrar
    Dim cDa As String = "Provider=Microsoft.Jet.OleDb.4.0;data source=\\Servidor\Agua\EMPSAAT"
    Dim dbf As OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim db As New SqlConnection(cn)
    Dim cmd As SqlCommand
    Dim txt As String
    Dim nf As Integer
    Dim nO As Double

    Private Sub btnFacturas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturas.Click
        Dim i As Integer
        For i = 2008 To 2011
            dbf = New OleDb.OleDbConnection(cDa & Trim(Str(i)) & ".mdb")
            MigrarMeses()
        Next
    End Sub

    Private Sub MigrarMeses()
        Dim j, k As Integer
        Dim da As New OleDb.OleDbDataAdapter("", dbf)
        Try
            db.Open()
            cmd = New SqlCommand
            cmd.Connection = db
            cmd.CommandType = CommandType.Text

            For j = 1 To 12
                'da.SelectCommand.CommandText = "Select F.Abonado, F.Num_Factura, F.Num_Orden, F.Emision, F.Categoria, F.Lectura, F.Con_m3, " & _
                '"F.Lec_Estimada, F.Emp_Fijo, F.Imp_Adic, F.Imp_Total, F.Imp_Alcanta, F.Imp_Rep, F.Imp_Recargo, F.Imp_Ley1886_1, F.Imp_Ley1886_2, " & _
                '"F.Imp_Factura, F.Imp_Iva, F.Imp_Ite, F.Nit, F.codigo_Control, F. Mes_" & Format(j, "00") & " F Inner Join Control C On F.Abonado = C.Abonado"
                da.SelectCommand.CommandText = "Select * From Mes_" & Format(j, "00") & " Where Imp_Factura > 0"
                da.Fill(ds, "Fac")
                For k = 0 To ds.Tables("Fac").Rows.Count - 1
                    txt = "Insert Into Facturas (Abonado, Num_Factura, Num_Orden, Emision, Categoria, Lectura, Con_m3, Lec_Estimada, Imp_Fijo, Imp_Adic, " & _
                    "Imp_Total, Imp_Alcanta, Imp_Rep, Imp_Recargo, Imp_Car_1, Imp_Car_2, Imp_Ley1886_1, Imp_Ley1886_2, Imp_Factura, Imp_Iva, Imp_Ite, " & _
                    "Nit, Codigo_Control, Alfa_No, Fec_Pago, Valida, Comprobante, Servicio, Empleado) Values ('" & _
                    ds.Tables("Fac").Rows(k).Item("Abonado") & "','" & _
                    ds.Tables("Fac").Rows(k).Item("Num_Factura") & "','" & _
                    ds.Tables("Fac").Rows(k).Item("Num_Orden") & "','" & _
                    ds.Tables("Fac").Rows(k).Item("Emision") & "','" & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Categoria")), "A1", ds.Tables("Fac").Rows(k).Item("Categoria")) & "','" & _
                    ds.Tables("Fac").Rows(k).Item("Lectura") & "','" & _
                    ds.Tables("Fac").Rows(k).Item("Con_m3") & "','" & _
                    IIf(ds.Tables("Fac").Rows(k).Item("Lec_Estimada"), 1, 0) & "'," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Fijo") & "," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Adic") & "," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Total") & "," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Alcanta") & "," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Rep") & "," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Recargo") & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Car_1")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Car_1")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Car_2")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Car_2")) & "," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Ley1886_1") & "," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Ley1886_2") & "," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Factura") & "," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Iva") & "," & _
                    ds.Tables("Fac").Rows(k).Item("Imp_Ite") & ",'" & _
                    ds.Tables("Fac").Rows(k).Item("Nit") & "','" & _
                    ds.Tables("Fac").Rows(k).Item("Codigo_Control") & "','" & _
                    ds.Tables("Fac").Rows(k).Item("Alfa_No") & "','" & _
                    ds.Tables("Fac").Rows(k).Item("Fec_Pago") & "','V','" & _
                    Numero_Comprobante(ds.Tables("Fac").Rows(k).Item("Fec_Pago").ToString) & "','1','0')"
                    cmd.CommandText = txt
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("Fac").Clear()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Function Numero_Comprobante(ByVal Fecha As String) As Integer
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        Dim nNo As Integer
        Dim FEC As Date
        If IsDate(Fecha) Then
            FEC = Fecha
            da.SelectCommand.CommandText = "Select * From ComprobanteS Where Fecha = '" & FormatDateTime(FEC, DateFormat.ShortDate) & "'"
            da.Fill(ds, "CNo")
            If ds.Tables("Cno").Rows.Count > 0 Then
                nNo = ds.Tables("CNo").Rows(0).Item("Comprobante")
            Else
                nNo = 1
            End If
            ds.Tables("Cno").Clear()
        Else
            nNo = 1
        End If
        Numero_Comprobante = nNo
    End Function

    Private Sub btnOtrasVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOtrasVentas.Click
        dbf = New OleDb.OleDbConnection(cDa & ".mdb")
        Dim da As New OleDb.OleDbDataAdapter("", dbf)
        Dim ds As New DataSet
        Dim i As Integer
        Dim cmd As New SqlCommand
        Try
            db.Open()
            cmd.Connection = db
            cmd.CommandType = CommandType.Text

            da.SelectCommand.CommandText = "Select * From Facturas_Otras_Ventas"
            da.Fill(ds, "Otr")
            For i = 0 To ds.Tables("Otr").Rows.Count - 1
                txt = "Insert Into Facturas (Abonado, Num_Factura, Num_Orden, Emision, Categoria, Imp_Factura, Imp_Iva, Imp_Ite, Nit, Codigo_Control, Fec_Pago, Valida, Comprobante, Servicio, Empleado, " & _
                "Lectura, Con_m3, Lec_estimada, Imp_Fijo, Imp_Adic, Imp_Total, Imp_Alcanta, Imp_Rep, Imp_Car_1, Imp_Car_2, Imp_Recargo, Imp_Ley1886_1, Imp_Ley1886_2) Values ('" & _
                ds.Tables("Otr").Rows(i).Item("Abonado") & "','" & _
                ds.Tables("Otr").Rows(i).Item("Numero_Factura") & "','" & _
                ds.Tables("Otr").Rows(i).Item("Numero_Autorizacion") & "','" & _
                ds.Tables("Otr").Rows(i).Item("Fecha") & "','A1'," & _
                ds.Tables("Otr").Rows(i).Item("Importe") & "," & _
                ds.Tables("Otr").Rows(i).Item("Debito") & "," & _
                Math.Round(ds.Tables("Otr").Rows(i).Item("Importe") * 0.03, 2) & ",'" & _
                ds.Tables("Otr").Rows(i).Item("Nit") & "','" & _
                ds.Tables("Otr").Rows(i).Item("Codigo_Control") & "','" & _
                ds.Tables("Otr").Rows(i).Item("Fecha") & "','" & _
                ds.Tables("Otr").Rows(i).Item("Estado") & "','" & _
                Numero_Comprobante(ds.Tables("Otr").Rows(i).Item("Fecha")) & "','2','0'," & _
                "'0','0',0,0,0,0,0,0,0,0,0,0,0)"
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next
            ds.Tables("Otr").Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & _
                            ds.Tables("Otr").Rows(i).Item("Numero_Factura"), ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Migrar_Usuarios(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dbf = New OleDb.OleDbConnection(cDa & ".mdb")
        Dim da As New OleDb.OleDbDataAdapter("", dbf)
        Dim ds As New DataSet
        Dim i As Integer
        Dim cmd As New SqlCommand
        Try
            db.Open()
            cmd.Connection = db
            cmd.CommandType = CommandType.Text

            da.SelectCommand.CommandText = "Select * From Usuarios where abonado > 13361"
            da.Fill(ds, "Usu")
            For i = 0 To ds.Tables("Usu").Rows.Count - 1
                txt = "Insert Into Usuarios (Abonado, Nombre, Nit, Medidor, Zona, Calle, Num, Ruta, SubRuta, NumRuta, " & _
                "Categoria, Ley1886, No_Afi, Fec_Afi, D_I, Fec_Sol, Fec_Ins, Fec_Con, Fec_Cor, Fec_Rec, Estado, " & _
                "Nota, Lect_Inicial, Doc, NoDoc, Nacimiento, Liberacion, ConsFijo) Values ('" & _
                ds.Tables("Usu").Rows(i).Item("Abonado") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Nombre") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Nit") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Medidor") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Zona") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Calle") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Num") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Ruta") & "','" & _
                ds.Tables("Usu").Rows(i).Item("SubRuta") & "','" & _
                ds.Tables("Usu").Rows(i).Item("NumRuta") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Categoria") & "','" & _
                IIf(ds.Tables("Usu").Rows(i).Item("Ley1886"), 1, 0) & "','" & _
                ds.Tables("Usu").Rows(i).Item("No_Afi") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Fec_Afi") & "','" & _
                ds.Tables("Usu").Rows(i).Item("D_I") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Fec_Sol") & "','" & _
                FormatDateTime((ds.Tables("Usu").Rows(i).Item("Fec_Ins")), DateFormat.ShortDate) & "','" & _
                ds.Tables("Usu").Rows(i).Item("Fec_Con") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Fec_Cor") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Fec_Rec") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Estado") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Nota") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Lect_Inicial") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Doc") & "','" & _
                ds.Tables("Usu").Rows(i).Item("NoDoc") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Nacimiento") & "','" & _
                ds.Tables("Usu").Rows(i).Item("Liberacion") & "','" & _
                ds.Tables("Usu").Rows(i).Item("ConsFijo") & "')"
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next
            ds.Tables("Usu").Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & _
                            ds.Tables("Usu").Rows(i).Item("Abonado"), ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub btnServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnServicios.Click
        dbf = New OleDb.OleDbConnection(cDa & ".mdb")
        Dim da As New OleDb.OleDbDataAdapter("", dbf)
        Dim ds As New DataSet
        Dim i As Integer
        Dim cmd As New SqlCommand
        Try
            db.Open()
            cmd.Connection = db
            cmd.CommandType = CommandType.Text

            da.SelectCommand.CommandText = "Select * From Servicios_Solicitud Where NoSolicitud > 69632 Order by NoSolicitud"
            da.Fill(ds, "Ser")
            For i = 0 To ds.Tables("Ser").Rows.Count - 1
                txt = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Cobrado, Factura, Estado, Fec_Atendido, Fec_Sistema, Empleado, Elaborado, NoLista, Pagado, Nombre, Doc, NoDoc, Nit, Nacimiento, Ruta, SubRuta, Zona, Calle, Numero, Categoria, DesC_Categoria, NoRuta, Formulario) Values ('" & _
                ds.Tables("Ser").Rows(i).Item("NoSolicitud") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Abonado") & "','" & _
                Format(ds.Tables("Ser").Rows(i).Item("Fecha"), "dd/MM/yyyy") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Servicio") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Costo") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Nota") & "','" & _
                IIf(ds.Tables("Ser").Rows(i).Item("Cobrado"), 1, 0) & "','" & _
                ds.Tables("Ser").Rows(i).Item("Factura") & "','" & _
                IIf(ds.Tables("Ser").Rows(i).Item("Anulado"), "2", IIf(ds.Tables("Ser").Rows(i).Item("Atendido"), "1", "0")) & "','" & _
                ds.Tables("Ser").Rows(i).Item("Fec_Atendido") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Fec_Sistema") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Empleado") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Elaborado") & "','" & _
                ds.Tables("Ser").Rows(i).Item("NoLista") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Pagado") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Nombre") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Doc") & "','" & _
                ds.Tables("Ser").Rows(i).Item("NoDoc") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Nit") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Nacimiento") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Ruta") & "','" & _
                ds.Tables("Ser").Rows(i).Item("SubRuta") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Zona") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Calle") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Numero") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Categoria") & "','" & _
                ds.Tables("Ser").Rows(i).Item("Desc_Categoria") & "','" & _
                ds.Tables("Ser").Rows(i).Item("NoRuta") & "','0')"
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next
            ds.Tables("Ser").Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & _
                            ds.Tables("Ser").Rows(i).Item("NoSolicitud"), ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Comprobantes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dbf = New OleDb.OleDbConnection(cDa & ".mdb")
        Dim da As New OleDb.OleDbDataAdapter("", dbf)
        Dim ds As New DataSet
        Dim i As Integer
        Dim cmd As New SqlCommand
        Try
            db.Open()
            cmd.Connection = db
            cmd.CommandType = CommandType.Text

            da.SelectCommand.CommandText = "Select * From Comprobantes Order By Comprobante"
            da.Fill(ds, "Cbte")
            For i = 0 To ds.Tables("Cbte").Rows.Count - 1
                txt = "Insert Into Comprobantes (Comprobante, Numero, Fecha) Values ('" & _
                ds.Tables("Cbte").Rows(i).Item("Comprobante") + 1 & "','" & _
                ds.Tables("Cbte").Rows(i).Item("Comprobante") & "','" & _
                ds.Tables("Cbte").Rows(i).Item("Fecha") & "')"
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next
            ds.Tables("Cbte").Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & _
                            ds.Tables("Cbte").Rows(i).Item("Comprobante"), ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub BtnVerificarPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerificarPagos.Click
        Dim i As Integer
        For i = 2002 To 2011
            dbf = New OleDb.OleDbConnection(cDa & Trim(Str(i)) & ".mdb")
            Verificar_meses()
            dbf.Dispose()
        Next
    End Sub

    Private Sub Verificar_meses()
        Dim j, k As Integer
        Dim cmd As New OleDb.OleDbCommand
        Dim da As New OleDb.OleDbDataAdapter("", dbf)
        Try
            dbf.Open()
            cmd.Connection = dbf
            cmd.CommandType = CommandType.Text

            For j = 1 To 12
                da.SelectCommand.CommandText = "Select * From Mes_" & Format(j, "00") & " Where Imp_Factura > 0 And Fec_Pago Is Null"
                da.Fill(ds, "Fac")
                For k = 0 To ds.Tables("Fac").Rows.Count - 1
                    Select Case j
                        Case 1
                            da.SelectCommand.CommandText = "Select Ene as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 2
                            da.SelectCommand.CommandText = "Select Feb as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 3
                            da.SelectCommand.CommandText = "Select Mar as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 4
                            da.SelectCommand.CommandText = "Select Abr as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 5
                            da.SelectCommand.CommandText = "Select May as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 6
                            da.SelectCommand.CommandText = "Select Jun as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 7
                            da.SelectCommand.CommandText = "Select Jul as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 8
                            da.SelectCommand.CommandText = "Select Ago as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 9
                            da.SelectCommand.CommandText = "Select Sep as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 10
                            da.SelectCommand.CommandText = "Select Oct as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 11
                            da.SelectCommand.CommandText = "Select Nov as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        Case 12
                            da.SelectCommand.CommandText = "Select Dic as Pago From Control Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                    End Select
                    da.Fill(ds, "Pag")
                    If ds.Tables("Pag").Rows(0).Item("Pago") = "1" Then
                        txt = "update mes_" & Format(j, "00") & " Set Fec_Pago = '" & ds.Tables("Fac").Rows(k).Item("Emision") & "' Where Abonado = " & ds.Tables("Fac").Rows(k).Item("Abonado")
                        cmd.CommandText = txt
                        cmd.ExecuteNonQuery()
                    End If
                    ds.Tables("Pag").Clear()
                Next
                ds.Tables("Fac").Clear()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If dbf.State = ConnectionState.Open Then dbf.Close()
        End Try
    End Sub

    Private Sub btnFacAnteriores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacAnteriores.Click
        Dim i As Integer
        nf = -1
        nO = 1
        For i = 2002 To 2007
            dbf = New OleDb.OleDbConnection(cDa & Trim(Str(i)) & ".mdb")
            MigrarMesesAntes()
        Next
    End Sub

    Private Sub MigrarMesesAntes()
        Dim xF As Integer
        Dim xO As Double
        Dim j, k As Integer
        Dim da As New OleDb.OleDbDataAdapter("", dbf)
        Try
            db.Open()
            cmd = New SqlCommand
            cmd.Connection = db
            cmd.CommandType = CommandType.Text

            For j = 1 To 12
                da.SelectCommand.CommandText = "Select * From Mes_" & Format(j, "00") & " Where Imp_Factura > 0"
                da.Fill(ds, "Fac")
                For k = 0 To ds.Tables("Fac").Rows.Count - 1
                    If ds.Tables("Fac").Rows(k).Item("Num_Factura") = 0 Then
                        nf = nf - 1
                        xF = nf
                    Else
                        xF = ds.Tables("Fac").Rows(k).Item("Num_Factura")
                    End If

                    xO = ds.Tables("Fac").Rows(k).Item("Num_Orden")
                    txt = "Insert Into Facturas (Abonado, Num_Factura, Num_Orden, Emision, Categoria, Lectura, Con_m3, Lec_Estimada, Imp_Fijo, Imp_Adic, " & _
                    "Imp_Total, Imp_Alcanta, Imp_Rep, Imp_Recargo, Imp_Car_1, Imp_Car_2, Imp_Ley1886_1, Imp_Ley1886_2, Imp_Factura, Imp_Iva, Imp_Ite, " & _
                    "Nit, Codigo_Control, Alfa_No, Fec_Pago, Valida, Comprobante, Servicio, Empleado) Values ('" & _
                    ds.Tables("Fac").Rows(k).Item("Abonado") & "','" & _
                    xF & "','" & _
                    xO & "','" & _
                    ds.Tables("Fac").Rows(k).Item("Emision") & "','" & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Categoria")), "A1", ds.Tables("Fac").Rows(k).Item("Categoria")) & "','" & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Lectura")), 0, ds.Tables("Fac").Rows(k).Item("Lectura")) & "','" & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Con_m3")), 0, ds.Tables("Fac").Rows(k).Item("Con_m3")) & "','" & _
                    IIf(ds.Tables("Fac").Rows(k).Item("Lec_Estimada"), 1, 0) & "'," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Fijo")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Fijo")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Adic")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Adic")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Total")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Total")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Alcanta")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Alcanta")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Rep")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Rep")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Recargo")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Recargo")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Car_1")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Car_1")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Car_2")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Car_2")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Ley1886_1")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Ley1886_1")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Ley1886_2")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Ley1886_2")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Factura")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Factura")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Iva")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Iva")) & "," & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Imp_Ite")), 0, ds.Tables("Fac").Rows(k).Item("Imp_Ite")) & ",'" & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Nit")), 0, ds.Tables("Fac").Rows(k).Item("Nit")) & "','" & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Codigo_Control")), "-", ds.Tables("Fac").Rows(k).Item("Nit")) & "','" & _
                    IIf(IsDBNull(ds.Tables("Fac").Rows(k).Item("Alfa_No")), ".", ds.Tables("Fac").Rows(k).Item("Alfa_No")) & "','" & _
                    ds.Tables("Fac").Rows(k).Item("Fec_Pago") & "','V','" & _
                    Numero_Comprobante(ds.Tables("Fac").Rows(k).Item("Fec_Pago").ToString) & "','1','0')"
                    cmd.CommandText = txt
                    cmd.ExecuteNonQuery()
                Next
                ds.Tables("Fac").Clear()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & _
                            "No Factura " & ds.Tables("Fac").Rows(k).Item("Num_Factura") & Chr(13) & _
                            "No Autorizacion " & ds.Tables("Fac").Rows(k).Item("Num_Orden") & Chr(13) & _
                            "Abonado " & ds.Tables("Fac").Rows(k).Item("Abonado"), ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub btnDosificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDosificacion.Click
        dbf = New OleDb.OleDbConnection(cDa & ".mdb")
        Dim da As New OleDb.OleDbDataAdapter("", dbf)
        Dim ds As New DataSet
        Dim i As Integer
        Dim cmd As New SqlCommand
        Try
            db.Open()
            cmd.Connection = db
            cmd.CommandType = CommandType.Text

            da.SelectCommand.CommandText = "Select * From Dosificacion"
            da.Fill(ds, "Dos")
            For i = 0 To ds.Tables("Dos").Rows.Count - 1
                txt = "Insert Into Dosificacion (Autorizacion, Llave, NoInicial, NoFinal, Fec_Inicial, Fec_Final, Activado) Values ('" & _
                ds.Tables("Dos").Rows(i).Item("Autorizacion") & "','" & _
                ds.Tables("Dos").Rows(i).Item("Llave") & "','" & _
                ds.Tables("Dos").Rows(i).Item("NoInicial") & "','" & _
                ds.Tables("Dos").Rows(i).Item("NoFinal") & "','" & _
                ds.Tables("Dos").Rows(i).Item("Fec_Inicial") & "','" & _
                ds.Tables("Dos").Rows(i).Item("Fec_Final") & "','" & _
                IIf(ds.Tables("Dos").Rows(i).Item("Activado"), 1, 0) & "')"
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next
            ds.Tables("Dos").Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & _
                            ds.Tables("Dos").Rows(i).Item("Autorizacion"), ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub btnRecargosAntes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecargosAntes.Click
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        Dim txt As String
        Dim cmd As New SqlCommand
        Dim i As Integer
        Dim nCon As Integer
        Dim cCat As String
        Dim nImp As Double
        Dim nAlc As Double
        Dim nCa1 As Double
        Dim nCa2 As Double
        Dim nRec As Double
        Dim nRep As Double
        Dim nFac As Double

        Try
            db.Open()
            cmd.Connection = db
            cmd.CommandType = CommandType.Text
            da.SelectCommand.CommandText = "Select * From Facturas Where Fec_Pago is Null And Servicio = '1' and Emision < '01/01/2008'"
            da.Fill(ds, "Fac")
            For i = 0 To ds.Tables("Fac").Rows.Count - 1
                nCon = ds.Tables("Fac").Rows(i).Item("Con_M3")
                cCat = ds.Tables("Fac").Rows(i).Item("Categoria")
                nImp = ds.Tables("Fac").Rows(i).Item("Imp_Total")
                nAlc = ds.Tables("Fac").Rows(i).Item("Imp_Alcanta")
                nCa1 = ds.Tables("Fac").Rows(i).Item("Imp_Car_1")
                nCa2 = ds.Tables("Fac").Rows(i).Item("Imp_Car_2")
                nRec = Imp_Recargo(nCon, cCat, (nImp + nAlc))
                nRep = Repone((nImp + nAlc + nCa1 + nCa2 + nRec))
                nFac = Math.Round(nImp + nAlc + nCa1 + nCa2 + nRec + nRep, 1)
                txt = "Update Facturas Set Imp_Recargo = " & nRec & ", Imp_Rep = " & nRep & ", Imp_Factura = " & nFac & _
                " Where Factura = " & ds.Tables("Fac").Rows(i).Item("Factura")
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Function Imp_Recargo(ByVal nconsumo As Integer, ByVal cCategoria As String, ByVal nImporte As Double) As Double
        Dim Recargos As Double
        Select Case cCategoria
            Case "A1"
                If nconsumo >= 0 And nconsumo <= 6 Then
                    Recargos = Math.Round(nImporte * 0.2, 2)
                ElseIf nconsumo >= 0 And nconsumo <= 20 Then
                    Recargos = Math.Round(nImporte * 0.1, 2)
                Else
                    Recargos = Math.Round(nImporte * 0.05, 2)
                End If
            Case "B1" To "B3"
                If nconsumo >= 0 And nconsumo <= 18 Then
                    Recargos = Math.Round(nImporte * 0.1, 2)
                Else
                    Recargos = Math.Round(nImporte * 0.05, 2)
                End If
            Case "C1" To "C3"
                If nconsumo >= 0 And nconsumo <= 14 Then
                    Recargos = Math.Round(nImporte * 0.1, 2)
                Else
                    Recargos = Math.Round(nImporte * 0.05, 2)
                End If
            Case "D1" To "D3"
                If nconsumo >= 0 And nconsumo <= 18 Then
                    Recargos = Math.Round(nImporte * 0.1, 2)
                Else
                    Recargos = Math.Round(nImporte * 0.05, 2)
                End If
        End Select
        Imp_Recargo = Recargos
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        dbf = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;data source=C:\red_server\empsaat.mdb")
        Dim da As New OleDb.OleDbDataAdapter("", dbf)
        Dim ds As New DataSet
        Dim i As Integer
        Dim cmd As New SqlCommand
        Try
            db.Open()
            cmd.Connection = db
            cmd.CommandType = CommandType.Text

            da.SelectCommand.CommandText = "Select * From Proformas_Usuarios"
            da.Fill(ds, "Pro")
            For i = 0 To ds.Tables("Pro").Rows.Count - 1
                txt = "Insert Into Proformas_usuarios (Proforma, Abonado) Values ('" & _
                ds.Tables("Pro").Rows(i).Item("Proforma") & "','" & _
                ds.Tables("Pro").Rows(i).Item("Abonado") & "')"
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next
            ds.Tables("Pro").Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message & Chr(13) & _
                            ds.Tables("Pro").Rows(i).Item("pROFORMA"), ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub
End Class