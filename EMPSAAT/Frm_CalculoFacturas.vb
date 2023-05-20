Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_CalculoFacturas
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim dEmi As Date
    Dim i As Integer

    Private Sub Frm_CalculoFacturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Factores Where Estado = 1 and Proceso = 1"
        da.Fill(ds, "Factores")
        If ds.Tables("Factores").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("Factores").Rows(0).Item("Emision")) Then
                TxtPeriodo.Text = Format(ds.Tables("Factores").Rows(0).Item("Emision"), "MMMM / yyyy")
                dEmi = ds.Tables("Factores").Rows(0).Item("Emision")
            End If
        Else
            BtnProcesar.Enabled = False
        End If
    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
        Lista.Items.Add("CALCULANDO IMPORTES FIJOS")
        Facturas_Consumo_Fijo()
        Lista.Items.Add("VERIFICANDO LECTURAS FALTANTES")
        If Verificar_Lecturas_Faltantes(dEmi) Then
            Facturas_Recalculo()
            Lista.Items.Add("CALCULANDO RECARGOS")
            Registrar_Recargos()
            Lista.Items.Add("REGISTRANDO CODIGO DE CONTROL")
            Calcular_Codigo_Control()
        End If
    End Sub

    Function Verificar_Lecturas_Faltantes(ByVal eMISION As Date) As Boolean
        Try
            da.SelectCommand.CommandText = "SELECT ABONADO FROM USUARIOS WHERE ESTADO = 'N' AND ABONADO NOT IN (SELECT ABONADO FROM FACTURAS WHERE EMISION = '" & FormatDateTime(eMISION, DateFormat.ShortDate) & "' AND SERVICIO = 1)"
            da.Fill(ds, "Fal")
            If ds.Tables("Fal").Rows.Count > 0 Then
                For i = 0 To ds.Tables("Fal").Rows.Count - 1
                    Lista.Items.Add(ds.Tables("Fal").Rows(i).Item("Abonado") & ".. Falta Lectura")
                Next
                Verificar_Lecturas_Faltantes = False
            Else
                Verificar_Lecturas_Faltantes = True
            End If
            ds.Tables("Fal").Clear()
            Verificar_Lecturas_Faltantes = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Function


    Private Sub Calcular_Codigo_Control()
        Dim nAutorizacion As Double
        Dim nFactura As Double
        Dim nRegistro As Double
        Dim cLlave As String
        Dim dFecIni As Date
        Dim dFecFin As Date
        Dim cCodigo_Control As String
        Dim cmd As New SqlCommand
        Dim txt As String
        Dim Edi As Boolean = False

        Try
            If Verificar_Lecturas() Then
                da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = 1"
                da.Fill(ds, "Dos")
                If ds.Tables("Dos").Rows.Count > 0 Then

                    nAutorizacion = ds.Tables("Dos").Rows(0).Item("Autorizacion")
                    cLlave = ds.Tables("Dos").Rows(0).Item("Llave")
                    dFecIni = ds.Tables("Dos").Rows(0).Item("Fec_Inicial")
                    dFecFin = ds.Tables("Dos").Rows(0).Item("Fec_Final")

                    Lista.Items.Add("Calculo de importes de facturas", True)

                    Lista.Refresh()

                    db.Open()
                    '-------------- calculo --------------------
                    da.SelectCommand.CommandText = "Select * From Facturas Where Emision = '" & dEmi & "' And Servicio = 1 And Imp_Factura > 0"

                    da.Fill(ds, "Fac")
                    For i = 0 To ds.Tables("Fac").Rows.Count - 1
                        If ds.Tables("Fac").Rows(i).Item("Num_Factura") <> 0 Then
                            nFactura = ds.Tables("Fac").Rows(i).Item("Num_Factura")
                            If nAutorizacion <> ds.Tables("Fac").Rows(i).Item("Num_Orden") Then
                                MessageBox.Show("El número de Autorización registrado en las facturas NO esta vigente. No se puede continuar....", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            End If
                            Edi = True
                        Else
                            nFactura = Nuevo_Numero_Factura(nAutorizacion)
                            Edi = False
                        End If

                        nRegistro = ds.Tables("Fac").Rows(i).Item("Factura")
                        nAbonado = ds.Tables("Fac").Rows(i).Item("Abonado")
                        Dim CodCon As New CodigoV7
                        CodCon.NoAutorizacion = nAutorizacion  'ds.Tables("Fac").Rows(i).Item("Num_Orden")
                        CodCon.NoFactura = nFactura  'ds.Tables("Fac").Rows(i).Item("Num_Factura")
                        CodCon.NoNit = ds.Tables("Fac").Rows(i).Item("Nit")
                        CodCon.Fecha = ds.Tables("Fac").Rows(i).Item("Emision")
                        CodCon.Importe = ds.Tables("Fac").Rows(i).Item("Imp_Factura")
                        CodCon.Llave = cLlave
                        cCodigo_Control = CodCon.Codigo


                        If Existe_Registro_Factura(nFactura, nAutorizacion) Then
                            txt = "UPDATE LIBRO SET FECHA = '" & ds.Tables("Fac").Rows(i).Item("Emision") & "'," & _
                                "NIT = '" & ds.Tables("Fac").Rows(i).Item("Nit") & "'," & _
                                "RAZON = '" & Razon_Social(ds.Tables("Fac").Rows(i).Item("Abonado")) & "'," & _
                                "IMPORTE_VENTA = '" & ds.Tables("Fac").Rows(i).Item("IMp_Factura") + ds.Tables("Fac").Rows(i).Item("Imp_Descuento") + ds.Tables("Fac").Rows(i).Item("Imp_DesAlcan") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_1") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_2") & "'," & _
                                "ICE_IEHD_TASAS = '0', EXCENTAS = '0', VENTAS_TASA_CERO = '0', " & _
                                "SUBTOTAL = '" & ds.Tables("Fac").Rows(i).Item("Imp_Factura") + ds.Tables("Fac").Rows(i).Item("Imp_Descuento") + ds.Tables("Fac").Rows(i).Item("Imp_DesAlcan") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_1") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_2") & "'," & _
                                "DESCUENTOS = '" & ds.Tables("Fac").Rows(i).Item("Imp_Descuento") + ds.Tables("Fac").Rows(i).Item("Imp_DesAlcan") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_1") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_2") & "'," & _
                                "IMPORTE_PARA_DEBITO = '" & ds.Tables("Fac").Rows(i).Item("Imp_Factura") & "'," & _
                                "DEBITO_FISCAL = '" & Math.Round((ds.Tables("Fac").Rows(i).Item("Imp_Factura") * 0.13), 2) & "'," & _
                                "CODIGO_CONTROL = '" & cCodigo_Control & "'," & _
                                "SERVICIO = '1', USUARIO = '" & _Usuario & "' " & _
                                "WHERE FACTURA = " & nFactura & " AND AUTORIZACION = " & nAutorizacion
                        Else
                            txt = "INSERT INTO LIBRO (ESPECIFICACION, FECHA, FACTURA, AUTORIZACION, ESTADO, NIT, RAZON, IMPORTE_VENTA, ICE_IEHD_TASAS, EXCENTAS, VENTAS_TASA_CERO, SUBTOTAL, DESCUENTOS, IMPORTE_PARA_DEBITO, DEBITO_FISCAL, CODIGO_CONTROL, SERVICIO, USUARIO, COMPROBANTE) VALUES (" & _
                                "'3','" & _
                                ds.Tables("Fac").Rows(i).Item("Emision") & "','" & _
                                nFactura & "','" & _
                                nAutorizacion & "'," & _
                                "'V','" & _
                                ds.Tables("Fac").Rows(i).Item("Nit") & "','" & _
                                Razon_Social(ds.Tables("Fac").Rows(i).Item("Abonado")) & "','" & _
                                ds.Tables("Fac").Rows(i).Item("IMp_Factura") + ds.Tables("Fac").Rows(i).Item("Imp_Descuento") + ds.Tables("Fac").Rows(i).Item("Imp_DesAlcan") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_1") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_2") & "'," & _
                                "'0','0','0','" & _
                                ds.Tables("Fac").Rows(i).Item("Imp_Factura") + ds.Tables("Fac").Rows(i).Item("Imp_Descuento") + ds.Tables("Fac").Rows(i).Item("Imp_DesAlcan") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_1") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_2") & "','" & _
                                ds.Tables("Fac").Rows(i).Item("Imp_Descuento") + ds.Tables("Fac").Rows(i).Item("Imp_DesAlcan") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_1") + ds.Tables("Fac").Rows(i).Item("Imp_Ley1886_2") & "','" & _
                                ds.Tables("Fac").Rows(i).Item("Imp_Factura") & "','" & _
                                Math.Round((ds.Tables("Fac").Rows(i).Item("Imp_Factura") * 0.13), 2) & "','" & _
                                cCodigo_Control & "'," & _
                                "'1','" & _
                                _Usuario & "',1)"
                        End If

                        With cmd
                            .Connection = db
                            .CommandType = CommandType.Text
                            .CommandText = txt
                            .ExecuteNonQuery()
                        End With

                        txt = "Update Facturas Set Num_Factura = '" & nFactura & "', Num_Orden = '" & nAutorizacion & "', Codigo_Control = '" & cCodigo_Control & "' Where Factura = " & nRegistro
                        cmd.CommandText = txt
                        cmd.ExecuteNonQuery()

                        Progre.Value = (i / ds.Tables("Fac").Rows.Count) * 100
                        Progre.Refresh()
                    Next

                    txt = "Update Factores Set Proceso = 2 Where Emision = '" & dEmi & "'"
                    With cmd
                        .Connection = db
                        .CommandType = CommandType.Text
                        .CommandText = txt
                        .ExecuteNonQuery()
                    End With

                    Lista.Items.Add("Dosificacion de facturas actualizado", True)
                    Lista.Refresh()
                    Progre.Visible = False
                    Lista.Items.Add("Proceso CODIGO DE CONTROL Terminado", True)
                    BtnProcesar.Enabled = False
                End If
            Else
                MessageBox.Show("Falta trascribir lecturas, Verifique para continuar", "Atención... Proceso interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Lista.Items.Add("Proceso Interrumpido", False)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Function Verificar_Lecturas() As Boolean
        Dim Correcto As Boolean
        da.SelectCommand.CommandText = "Select Abonado, Nombre From Usuarios Where Abonado Not In (Select Abonado From Facturas Where Emision = '" & FormatDateTime(dEmi, DateFormat.ShortDate) & "') And Estado = 'N' AND CONSFIJO = 0"
        da.Fill(ds, "SinLec")
        If ds.Tables("SinLec").Rows.Count > 0 Then
            For i = 0 To ds.Tables("SinLec").Rows.Count - 1
                Lista.Items.Add(ds.Tables("Sinlec").Rows(i).Item("Abonado") & " " & ds.Tables("SinLec").Rows(i).Item("Nombre"))
            Next
            Correcto = False
        Else
            Correcto = True
        End If
        Verificar_Lecturas = True
    End Function

    Private Sub Registrar_Recargos()
        Dim cmd As New SqlCommand
        Dim xAbonado As New SqlParameter
        Dim xEmision As New SqlParameter
        Dim dEmisionAntes As Date
        Dim dVencimiento As Date

        Try
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "GRABAR_RECARGO"
                xAbonado = .Parameters.Add("@Abonado", SqlDbType.Int)
                xAbonado.Direction = ParameterDirection.Input
                xEmision = .Parameters.Add("@Emision", SqlDbType.DateTime)
                xEmision.Direction = ParameterDirection.Input
            End With

            da.SelectCommand.CommandText = "Select Top 1 Emision, Vencimiento From Factores Where Proceso = 3 Order By Emision Desc"
            da.Fill(ds, "EmiAnt")

            If Not IsDBNull(ds.Tables("EmiAnt").Rows(0).Item("Emision")) Then
                dEmisionAntes = ds.Tables("EmiAnt").Rows(0).Item("Emision")
                dVencimiento = ds.Tables("EmiAnt").Rows(0).Item("Vencimiento")
            End If


            da.SelectCommand.CommandText = "Select * From Facturas Where Servicio = 1 And Emision = '" & dEmisionAntes & "' And (Fec_Pago Is Null or Fec_Pago > '" & Format(dVencimiento, "dd/MM/yyyy") & "') Order by Abonado"

            'da.SelectCommand.CommandText = "Select * From Facturas Where Emision = '" & dEmi & "' And Servicio = 1 And Imp_Factura > 0"
            da.Fill(ds, "Rec")
           
            For i = 0 To ds.Tables("Rec").Rows.Count - 1
                nAbonado = ds.Tables("Rec").Rows(i).Item("Abonado")
                With cmd
                    .Connection = db
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "GRABAR_RECARGO"
                    xAbonado.Value = ds.Tables("Rec").Rows(i).Item("Abonado")
                    xEmision.Value = dEmi
                    .ExecuteNonQuery()
                    Progre.Value = (i / ds.Tables("Rec").Rows.Count) * 100
                    Progre.Refresh()
                End With
            Next
            Lista.Items.Add("Recargos...... procesado {" & ds.Tables("rec").Rows.Count & "}", True)
            ds.Tables("Rec").Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " Abonado " & nAbonado, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub


    Private Sub Facturas_Recalculo()
        Dim cmd As New SqlCommand
        Dim xAbonado As New SqlParameter
        Dim xLectura As New SqlParameter
        Dim xCon_m3 As New SqlParameter
        Dim xEstimado As New SqlParameter
        Dim xSinFactura As New SqlParameter
        Dim xEmision As New SqlParameter
        Dim xSinRecargo As New SqlParameter

        Try
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "GRABAR_CONSUMO_NUEVO"
                xAbonado = .Parameters.Add("@Abonado", SqlDbType.Int)
                xAbonado.Direction = ParameterDirection.Input
                xLectura = .Parameters.Add("@Lectura", SqlDbType.Int)
                xLectura.Direction = ParameterDirection.Input
                xCon_m3 = .Parameters.Add("@Con_M3", SqlDbType.Int)
                xCon_m3.Direction = ParameterDirection.Input
                xEstimado = .Parameters.Add("@Estimado", SqlDbType.Bit)
                xEstimado.Direction = ParameterDirection.Input
                xSinFactura = .Parameters.Add("@SinFactura", SqlDbType.Bit)
                xSinFactura.Direction = ParameterDirection.Input
                xEmision = .Parameters.Add("@Emision", SqlDbType.DateTime)
                xEmision.Direction = ParameterDirection.Input
                xSinRecargo = .Parameters.Add("@SinRecargos", SqlDbType.Bit)
                xSinRecargo.Direction = ParameterDirection.Input
            End With


            da.SelectCommand.CommandText = "Select * From Facturas Where Emision = '" & dEmi & "' And Servicio = 1 And Imp_Factura > 0"
            da.Fill(ds, "Recal")
            For i = 0 To ds.Tables("Recal").Rows.Count - 1
                nAbonado = ds.Tables("ReCal").Rows(i).Item("Abonado")
                With cmd
                    .Connection = db
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "GRABAR_CONSUMO_NUEVO"
                    xAbonado.Value = ds.Tables("Recal").Rows(i).Item("Abonado")
                    xLectura.Value = ds.Tables("Recal").Rows(i).Item("Lectura")
                    xCon_m3.Value = ds.Tables("Recal").Rows(i).Item("Con_m3")
                    xEstimado.Value = ds.Tables("Recal").Rows(i).Item("Lec_Estimada")
                    xSinFactura.Value = 0
                    xEmision.Value = dEmi
                    xSinRecargo.Value = 0
                    .ExecuteNonQuery()
                    Progre.Value = (i / ds.Tables("RECAL").Rows.Count) * 100
                    Progre.Refresh()
                End With
            Next
            Lista.Items.Add("Recalculos", True)
        Catch ex As Exception
            MessageBox.Show(ex.Message & " Abonado " & nAbonado, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Facturas_Consumo_Fijo()
        Dim cmd As New SqlCommand
        Dim xAbonado As New SqlParameter
        Dim xLectura As New SqlParameter
        Dim xCon_m3 As New SqlParameter
        Dim xEstimado As New SqlParameter
        Dim xSinFactura As New SqlParameter
        Dim xEmision As New SqlParameter
        Dim xSinRecargo As New SqlParameter

        Try
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "GRABAR_CONSUMO_NUEVO"
                xAbonado = .Parameters.Add("@Abonado", SqlDbType.Int)
                xAbonado.Direction = ParameterDirection.Input
                xLectura = .Parameters.Add("@Lectura", SqlDbType.Int)
                xLectura.Direction = ParameterDirection.Input
                xCon_m3 = .Parameters.Add("@Con_M3", SqlDbType.Int)
                xCon_m3.Direction = ParameterDirection.Input
                xEstimado = .Parameters.Add("@Estimado", SqlDbType.Bit)
                xEstimado.Direction = ParameterDirection.Input
                xSinFactura = .Parameters.Add("@SinFactura", SqlDbType.Bit)
                xSinFactura.Direction = ParameterDirection.Input
                xEmision = .Parameters.Add("@Emision", SqlDbType.DateTime)
                xEmision.Direction = ParameterDirection.Input
                xSinRecargo = .Parameters.Add("@SinRecargos", SqlDbType.Bit)
                xSinRecargo.Direction = ParameterDirection.Input
            End With

            da.SelectCommand.CommandText = "Select * From Usuarios Where Consfijo > 0 And Estado = 'N'"
            da.Fill(ds, "ConFijo")
            For i = 0 To ds.Tables("ConFijo").Rows.Count - 1
                With cmd
                    .Connection = db
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "GRABAR_CONSUMO_NUEVO"
                    xAbonado.Value = ds.Tables("ConFijo").Rows(i).Item("Abonado")
                    xLectura.Value = ds.Tables("ConFijo").Rows(i).Item("ConsFijo")
                    xCon_m3.Value = ds.Tables("ConFijo").Rows(i).Item("ConsFijo")
                    xEstimado.Value = 0
                    xSinFactura.Value = 0
                    xEmision.Value = dEmi
                    xSinRecargo.Value = 0
                    .ExecuteNonQuery()
                End With
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Function comprobar_Lectura(ByVal abonado As Int64, ByVal estado As String, ByVal cLecIni As Int64, ByVal ConsumoFijo As Int64, ByVal Periodo As Date, ByVal Categoria As String, ByVal Liberacion As String, ByVal lLey1886 As Boolean) As Boolean
        Dim dges As New SqlConnection(cn)
        Dim dMes As New SqlDataAdapter("Select Abonado From Mes_" & Format(Month(Periodo), "00") & " Where Abonado = " & abonado, dges)
        Dim dst As New DataSet
        dMes.Fill(dst, "Abonado")
        If estado = "N" Then
            If dst.Tables(0).Rows.Count > 0 Then
                comprobar_Lectura = True
            Else
                If ConsumoFijo > 0 Then
                    Grabar_Lectura_Consumo(abonado, 0, ConsumoFijo, False, Categoria, False, "0", Liberacion, Periodo)
                    comprobar_Lectura = False
                Else
                    comprobar_Lectura = False
                End If
            End If
        Else
            Grabar_Lectura_Consumo(abonado, Obtener_Lectura_Anterior(abonado, Periodo), 0, False, Categoria, False, "X", Liberacion, Periodo)
            comprobar_Lectura = True
        End If
    End Function

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class