Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Recalculo_Facturas
    Dim db As New SqlConnection(cn)
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter("", db)

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Function Ver_Lectura_Actual(ByVal Abonado As Int64, ByVal Periodo As Date) As Int64
        da.SelectCommand.CommandText = "Select Lectura From Facturas Where Abonado = " & Abonado & " And Emision = '" & FormatDateTime(Periodo, DateFormat.ShortDate) & "'"
        da.Fill(ds, "LectActual")
        If ds.Tables("LectActual").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("LectActual").Rows(0).Item("Lectura")) Then
                Ver_Lectura_Actual = ds.Tables("LectActual").Rows(0).Item("Lectura")
            Else
                Ver_Lectura_Actual = 0
            End If
        Else
            Ver_Lectura_Actual = 0
        End If
        ds.Tables("LectActual").Clear()
    End Function

    Function Ver_Lectura_Anterior(ByVal Abonado As Int64, ByVal Periodo As Date) As Int64
        da.SelectCommand.CommandText = "Select Top 1 Lectura From Facturas Where Abonado = " & Abonado & " And Emision < '" & FormatDateTime(Periodo, DateFormat.ShortDate) & "' Order By Emision Desc"
        da.Fill(ds, "LectAnterior")
        If ds.Tables("LectAnterior").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("LectAnterior").Rows(0).Item("Lectura")) Then
                Ver_Lectura_Anterior = ds.Tables("LectAnterior").Rows(0).Item("Lectura")
            Else
                Ver_Lectura_Anterior = 0
            End If
        Else
            Ver_Lectura_Anterior = 0
        End If
        ds.Tables("LectAnterior").Clear()
    End Function

    Function Ver_Estimada(ByVal Abonado As Int64, ByVal Periodo As Date) As Boolean
        da.SelectCommand.CommandText = "Select Lec_Estimada From Facturas Where Abonado = " & Abonado & " And Emision = '" & FormatDateTime(Periodo, DateFormat.ShortDate) & "'"
        da.Fill(ds, "LectEst")
        If ds.Tables("LectEst").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("LectEst").Rows(0).Item("Lec_Estimada")) Then
                Ver_Estimada = ds.Tables("LectEst").Rows(0).Item("Lec_Estimada")
            Else
                Ver_Estimada = False
            End If
        Else
            Ver_Estimada = False
        End If
        ds.Tables("LectEst").Clear()
    End Function

    Function Comprobar_Factura_Pagada(ByVal Abonado As Int64, ByVal Periodo As Date) As String
        da.SelectCommand.CommandText = "Select Abonado, Fec_Pago From Facturas Where Abonado = " & Abonado & " And Emision = '" & FormatDateTime(Periodo, DateFormat.ShortDate) & "'"
        da.Fill(ds, "FacPag")
        If ds.Tables("FacPag").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("FacPag").Rows(0).Item("Fec_Pago")) Then
                Comprobar_Factura_Pagada = ds.Tables("FacPag").Rows(0).Item("Fec_Pago")
            Else
                Comprobar_Factura_Pagada = "X"
            End If
        Else
            Comprobar_Factura_Pagada = "X"
        End If
        ds.Tables("FecPag").Clear()
    End Function

    Function Comprobar_Numero_Factura(ByVal Abonado As Int64, ByVal Periodo As Date) As Double
        da.SelectCommand.CommandText = "Select Num_Factura From Facturas Where Abonado = " & Abonado & " And Emision = '" & FormatDateTime(Periodo, DateFormat.ShortDate) & "'"
        da.Fill(ds, "NoFactura")
        If ds.Tables("NoFactura").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("NoFactura").Rows(0).Item("Num_Factura")) Then
                Comprobar_Numero_Factura = ds.Tables("NoFactura").Rows(0).Item("Num_Factura")
            Else
                Comprobar_Numero_Factura = 0
            End If
        Else
            Comprobar_Numero_Factura = 0
        End If
        ds.Tables("NoFactura").Clear()
    End Function

    Function Comprobar_Si_Existe_Registro(ByVal Abonado As Int64, ByVal Periodo As Date) As Boolean
        da.SelectCommand.CommandText = "Select Abonado From Facturas Where Abonado = " & Abonado & " And Emision = '" & FormatDateTime(Periodo, DateFormat.ShortDate) & "'"
        da.Fill(ds, "Abonados")
        If ds.Tables("Abonados").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("Abonados").Rows(0).Item("Abonado")) Then
                Comprobar_Si_Existe_Registro = True
            Else
                Comprobar_Si_Existe_Registro = False
            End If
        Else
            Comprobar_Si_Existe_Registro = False
        End If
    End Function

    Function Suma_Ley1886(ByVal Periodo As Date) As Double
        Dim nTotal As Double
        da.SelectCommand.CommandText = "Select Sum(Imp_Ley1886_1) as L1, Sum(Imp_Ley1886_2) as L2 From Facturas Where Emision = '" & FormatDateTime(Periodo, DateFormat.ShortDate) & "'"
        da.Fill(ds, "Ley")
        If ds.Tables("Ley").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("Ley").Rows(0).Item("L1")) Then
                nTotal = nTotal + ds.Tables("Ley").Rows(0).Item("L1")
            End If
            If Not IsDBNull(ds.Tables("Ley").Rows(0).Item("L2")) Then
                nTotal = nTotal + ds.Tables("Ley").Rows(0).Item("L2")
            End If
        Else
            nTotal = 0
        End If
        Suma_Ley1886 = Math.Round(nTotal, 2)
        ds.Tables("Ley").Clear()
    End Function

    Private Sub Frm_Recalculo_Facturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select Abonado From Usuarios Where NODOC = '" & pCliente & "' And Abonado = " & nAbonado & " Order by Abonado"
        da.Fill(ds, "Abo")
        cboAbonado.DataSource = ds.Tables("Abo")
        cboAbonado.DisplayMember = "Abonado"
        cboAbonado.ValueMember = "Abonado"
        cboAbonado.SelectedValue = nAbonado

        da.SelectCommand.CommandText = "Select Emision From Factores Where Proceso = 2 Order by Emision Desc"
        da.Fill(ds, "Emis")
        cboPeriodo.DataSource = ds.Tables("Emis")
        cboPeriodo.ValueMember = "Emision"
        cboPeriodo.DisplayMember = "Emision"

        Ver_Usuarios(cboAbonado.SelectedValue)

    End Sub

    Private Sub Ver_Usuarios(ByVal Abonado As Integer)
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
        Ver_Registro_Lectura()
    End Sub

    Private Sub txtActual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtActual.TextChanged
        If IsNumeric(txtActual.Text) Then
            txtConsumo.Text = Calculo_Consumo(Val(txtActual.Text), Val(txtAnterior.Text))
            chkEstimado.Checked = False
        End If
    End Sub

    Private Sub txtPeriodo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnterior.KeyPress, txtConsumo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboPeriodo_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPeriodo.SelectionChangeCommitted
        Ver_Registro_Lectura()
    End Sub

    Private Sub Ver_Registro_Lectura()
        If ds.Tables("Emis").Rows.Count > 0 Then
            txtAnterior.Text = Ver_Lectura_Anterior(cboAbonado.SelectedValue, cboPeriodo.SelectedValue)
            txtActual.Text = Ver_Lectura_Actual(cboAbonado.SelectedValue, cboPeriodo.SelectedValue)
            chkEstimado.Checked = Ver_Estimada(cboAbonado.SelectedValue, cboPeriodo.SelectedValue)
        End If
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim cmd As New SqlCommand
        Dim xAbonado As SqlParameter
        Dim xEmision As SqlParameter
        Dim xLectura As SqlParameter
        Dim xCon_M3 As SqlParameter
        Dim xEstimada As SqlParameter
        Dim xSinFactura As SqlParameter
        Dim xSinRecargos As SqlParameter
        Dim nImpLey As Double
        Dim nImpIva As Double
        Dim nImpIte As Double

        Dim nFactura As Double
        Dim nAutorizacion As Double

        Dim xCod As New CodigoV7
        Dim txt As String

        Try
            If cboAbonado.SelectedValue = 4118 Then
                da.SelectCommand.CommandText = "Select Sum(Imp_Ley1886_1) as Imp1, Sum(Imp_Ley1886_2) as Imp2 From Facturas Where Servicio = 1 And emision ) '" & cboPeriodo.SelectedValue & "'"
                da.Fill(ds, "Ley")
                If ds.Tables("Ley").Rows.Count > 0 Then
                    If Not IsDBNull(ds.Tables("Ley").Rows(0).Item("Imp1")) Then
                        nImpLey = ds.Tables("Ley").Rows(0).Item("Imp1")
                    End If
                    If Not IsDBNull(ds.Tables("Ley").Rows(0).Item("Imp2")) Then
                        nImpLey = nImpLey + ds.Tables("Ley").Rows(0).Item("Imp2")
                    End If
                    nImpIva = Math.Round(nImpLey * 0.13, 2)
                    nImpIte = Math.Round(nImpLey * 0.03, 2)
                    Dim cCod As New CodigoV7

                End If
            Else
                db.Open()
                With cmd
                    .Connection = db
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Grabar_Consumo_NUEVO"
                    xAbonado = .Parameters.Add("@Abonado", SqlDbType.Int)
                    xEmision = .Parameters.Add("@Emision", SqlDbType.DateTime)
                    xLectura = .Parameters.Add("@Lectura", SqlDbType.Int)
                    xCon_M3 = .Parameters.Add("@Con_M3", SqlDbType.Int)
                    xEstimada = .Parameters.Add("@Estimado", SqlDbType.Bit)
                    xSinFactura = .Parameters.Add("@SinFactura", SqlDbType.Bit)
                    xSinRecargos = .Parameters.Add("@SinRecargos", SqlDbType.Bit)

                    xAbonado.Direction = ParameterDirection.Input
                    xEmision.Direction = ParameterDirection.Input
                    xLectura.Direction = ParameterDirection.Input
                    xCon_M3.Direction = ParameterDirection.Input
                    xEstimada.Direction = ParameterDirection.Input
                    xSinFactura.Direction = ParameterDirection.Input
                    xSinRecargos.Direction = ParameterDirection.Input
                    xAbonado.Value = cboAbonado.SelectedValue
                    xEmision.Value = cboPeriodo.SelectedValue
                    xLectura.Value = txtActual.Text
                    xCon_M3.Value = txtConsumo.Text
                    xEstimada.Value = IIf(chkEstimado.Checked, 1, 0)
                    xSinFactura.Value = IIf(ckSinFactura.Checked, 1, 0)
                    xSinRecargos.Value = IIf(chkSinRecargos.Checked, 1, 0)
                    .ExecuteNonQuery()
                End With

                da.SelectCommand.CommandText = "Select * From Facturas where Abonado = " & cboAbonado.SelectedValue & " And Emision = '" & cboPeriodo.SelectedValue & "' And servicio = 1"
                da.Fill(ds, "Fax")

                xCod.Fecha = ds.Tables("Fax").Rows(0).Item("Emision")
                xCod.Importe = ds.Tables("Fax").Rows(0).Item("Imp_Factura")
                xCod.NoNit = ds.Tables("Fax").Rows(0).Item("Nit")
                xCod.NoFactura = ds.Tables("Fax").Rows(0).Item("Num_Factura")
                xCod.NoAutorizacion = ds.Tables("Fax").Rows(0).Item("Num_Orden")
                xCod.Llave = Obtener_llave(ds.Tables("Fax").Rows(0).Item("Num_Orden"))

                txt = "Update Facturas Set Codigo_Control = '" & xCod.Codigo & "' Where Factura = " & ds.Tables("Fax").Rows(0).Item("Factura")
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With

                If ds.Tables("Fax").Rows.Count > 0 Then
                    nFactura = ds.Tables("Fax").Rows(0).Item("Num_Factura")
                    nAutorizacion = ds.Tables("Fax").Rows(0).Item("Num_Orden")

                    If Existe_Registro_Factura(nFactura, nAutorizacion) Then
                        txt = "UPDATE LIBRO SET FECHA = '" & ds.Tables("FaX").Rows(0).Item("Emision") & "'," & _
                            "NIT = '" & ds.Tables("FaX").Rows(0).Item("Nit") & "'," & _
                            "RAZON = '" & Razon_Social(ds.Tables("Fax").Rows(0).Item("Abonado")) & "'," & _
                            "IMPORTE_VENTA = '" & ds.Tables("Fax").Rows(0).Item("IMp_Factura") & "'," & _
                            "ICE_IEHD_TASAS = '0', EXCENTAS = '0', VENTAS_TASA_CERO = '0', " & _
                            "SUBTOTAL = '" & ds.Tables("Fax").Rows(0).Item("Imp_Factura") & "'," & _
                            "DESCUENTOS = '0'," & _
                            "IMPORTE_PARA_DEBITO = '" & ds.Tables("Fax").Rows(0).Item("Imp_Factura") & "'," & _
                            "DEBITO_FISCAL = '" & Math.Round((ds.Tables("Fax").Rows(0).Item("Imp_Factura") * 0.13), 2) & "'," & _
                            "CODIGO_CONTROL = '" & xCod.Codigo & "'," & _
                            "SERVICIO = '1', USUARIO = '" & _Usuario & "' " & _
                            "WHERE FACTURA = " & nFactura & " AND AUTORIZACION = " & nAutorizacion
                    Else
                        txt = "INSERT INTO LIBRO (ESPECIFICACION, FECHA, FACTURA, AUTORIZACION, ESTADO, NIT, RAZON, IMPORTE_VENTA, ICE_IEHD_TASAS, EXCENTAS, VENTAS_TASA_CERO, SUBTOTAL, DESCUENTOS, IMPORTE_PARA_DEBITO, DEBITO_FISCAL, CODIGO_CONTROL, SERVICIO, USUARIO, COMPROBANTE) VALUES (" & _
                            "'3','" & _
                            ds.Tables("Fax").Rows(0).Item("Emision") & "','" & _
                            nFactura & "','" & _
                            nAutorizacion & "'," & _
                            "'V','" & _
                            ds.Tables("Fax").Rows(0).Item("Nit") & "','" & _
                            Razon_Social(ds.Tables("Fax").Rows(0).Item("Abonado")) & "','" & _
                            ds.Tables("Fax").Rows(0).Item("IMp_Factura") & "'," & _
                            "'0'," & _
                            "'0'," & _
                            "'0','" & _
                            ds.Tables("Fax").Rows(0).Item("Imp_Factura") & "'," & _
                            "'0','" & _
                            ds.Tables("Fax").Rows(0).Item("Imp_Factura") & "','" & _
                            Math.Round((ds.Tables("Fax").Rows(0).Item("Imp_Factura") * 0.13), 2) & "','" & _
                            xCod.Codigo & "'," & _
                            "'1','" & _
                            _Usuario & "',1)"
                    End If

                    cmd.CommandText = txt
                    cmd.ExecuteNonQuery()
                    db.Close()
                End If
            End If
            MessageBox.Show("Se calculado la factura correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Function Obtener_llave(ByVal Autorizacion As Double) As String
        Dim cLlave As String
        da.SelectCommand.CommandText = "Select * From Dosificacion Where Autorizacion = " & Autorizacion
        da.Fill(ds, "Lla")
        If ds.Tables("LLa").Rows.Count > 0 Then
            cLlave = ds.Tables("Lla").Rows(0).Item("LLave")
        Else
            cLlave = ""
        End If
        Obtener_llave = cLlave
        ds.Tables("Lla").Clear()
    End Function

End Class