Imports System.Data.SqlClient
Imports ThoughtWorks.QRCode
Imports ThoughtWorks.QRCode.Codec
Imports ThoughtWorks.QRCode.Codec.Data

Public Class Frm_Deudas
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim Fecha_Final As Date
    Dim i As Integer

    '----------- PARA EL CODIGO QR -------------------
    Private colorFondoQR As Integer = Color.FromArgb(255, 255, 255, 255).ToArgb
    Private colorQR As Integer = Color.FromArgb(255, 0, 0, 0).ToArgb


    Private Sub Frm_Deudas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'da.SelectCommand.CommandText = "Select U.Abonado, U.Nombre, C.Descripcion as Categoria, U.Nit, U.Ley1886, E.Descripcion as Estado, U.Zona, U.Calle, U.Num, U.Ruta, U.SubRuta, U.NumRuta From ((Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria) Inner Join Usuarios_Estado E On U.Estado = E.Estado) Where U.Abonado = " & nAbonado
        da.SelectCommand.CommandText = "Select Abonado From Usuarios Where NODOC = '" & pCliente & "' Order by Abonado"
        da.Fill(ds, "Abo")
        cboAbonado.DataSource = ds.Tables("Abo")
        cboAbonado.DisplayMember = "Abonado"
        cboAbonado.ValueMember = "Abonado"
        cboAbonado.SelectedValue = nAbonado

        Ver_Usuarios(cboAbonado.SelectedValue)

        If pTieneDosis = False Then
            btnFactServicios.Enabled = False
        End If
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

        da.SelectCommand.CommandText = "Select Factura, Emision, Lectura, Con_M3, Imp_Factura, Fec_Pago From Facturas Where Abonado = " & Abonado & " And Fec_Pago IS Null AND Imp_Factura > 0 And Codigo_Control <> '' And Servicio = '1' Order By Factura"
        da.Fill(ds, "Act")
        dgDeuda.DataSource = ds.Tables("Act")

        da.SelectCommand.CommandText = "Select L.NoSolicitud, L.Fecha, S.Descripcion, L.Costo From Servicios_Solicitud L Inner Join Servicios_Lista S On L.Servicio = S.Servicio Where L.Cobrado = 0 And L.Estado = '1' and L.Costo > 0 and L.Abonado = " & Abonado & " Order By L.NoSolicitud"
        da.Fill(ds, "Ser")
        dgServicios.DataSource = ds.Tables("Ser")

        Ver_Deudas_Actuales(cboAbonado.SelectedValue)

    End Sub

    Private Sub Ver_Deudas_Actuales(ByVal Abonado As Integer)
        Dim nDeudaServicios As Double
        Dim nDeudaConsumo As Double

        ds.Tables("Act").Clear()
        da.SelectCommand.CommandText = "Select Factura, Emision, Lectura, Con_M3, Imp_Factura, Fec_Pago From Facturas Where Abonado = " & Abonado & " And Fec_Pago IS Null AND Imp_Factura > 0 And Codigo_Control <> '' And Servicio = '1' Order By Factura"
        da.Fill(ds, "Act")
        'dgDeuda.DataSource = ds.Tables("Act")

        da.SelectCommand.CommandText = "Select Sum(Imp_Factura) as Total From Facturas Where Abonado = " & Abonado & " And Fec_Pago Is Null"
        da.Fill(ds, "Total")
        txtTotalAgua.Text = "0.00"

        If Not IsDBNull(ds.Tables("Total").Rows(0).Item("Total")) Then
            txtTotalAgua.Text = FormatNumber(ds.Tables("Total").Rows(0).Item("Total"), 2)
            nDeudaConsumo = ds.Tables("Total").Rows(0).Item("Total")
        End If

        txtTotalPagado.Text = "0.00"

        ds.Tables("Ser").Clear()
        da.SelectCommand.CommandText = "Select L.NoSolicitud, L.Fecha, S.Descripcion, L.Costo From Servicios_Solicitud L Inner Join Servicios_Lista S On L.Servicio = S.Servicio Where L.Cobrado = 0 And L.Estado = '1' and L.Costo > 0 and L.Abonado = " & Abonado & " Order By L.NoSolicitud"
        da.Fill(ds, "Ser")
        ''dgServicios.DataSource = ds.Tables("Ser")

        da.SelectCommand.CommandText = "Select Sum(Costo) as Imp From Servicios_Solicitud Where Cobrado = 0 And Estado = '1' and Costo > 0 and Abonado = " & Abonado
        da.Fill(ds, "TotSer")
        txtOtrosServicios.Text = "0.00"

        If Not IsDBNull(ds.Tables("TotSer").Rows(0).Item("Imp")) Then
            txtOtrosServicios.Text = FormatNumber(ds.Tables("TotSer").Rows(0).Item("Imp"), 2)
            nDeudaServicios = ds.Tables("TotSer").Rows(0).Item("Imp")
        End If

        txtTotalDeuda.Text = FormatNumber(nDeudaConsumo + nDeudaServicios, 2)
        ds.Tables("TotSer").Clear()
        ds.Tables("Total").Clear()
    End Sub

    Private Sub Cancelar_Facturas(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDeuda.CellDoubleClick
        Dim cmd As New SqlCommand
        Dim xFactura As New SqlParameter
        Dim xRespuesta As New SqlParameter
        Dim xEmpleado As New SqlParameter
        Dim xComprobante As New SqlParameter
        Dim xCajero As New SqlParameter
        Dim xPunto As New SqlParameter

        Dim nFactura As Double
        Dim nImporte As Double
        Dim nDebito As Double
        Dim dEmision As Date
        'Dim nNumFac As Double
        'Dim nNumAut As Double
        Dim cLlave As String
        Dim cCodCtr As String
        Dim txt As String
        Try
            dEmision = dgDeuda.Item("Emision", dgDeuda.CurrentRow.Index).Value
            nFactura = dgDeuda.Item("Factura", dgDeuda.CurrentRow.Index).Value
            nImporte = dgDeuda.Item("Imp_Factura", dgDeuda.CurrentRow.Index).Value
            nDebito = Math.Round((nImporte * 0.13), 2)
            db.Open()

            If dEmision < CDate("01/01/2008") Then
                da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = 1"
                da.Fill(ds, "Dos")
                If ds.Tables("Dos").Rows.Count > 0 Then
                    pNum_Autorizacion = ds.Tables("Dos").Rows(0).Item("Autorizacion")
                    cLlave = ds.Tables("Dos").Rows(0).Item("Llave")
                    pFactura = Nuevo_Numero_Factura(pNum_Autorizacion)

                    Dim xCod As New CodigoV7
                    xCod.Importe = nImporte
                    xCod.Llave = cLlave
                    xCod.NoAutorizacion = pNum_Autorizacion
                    xCod.NoFactura = pFactura
                    xCod.NoNit = TxNIT.Text
                    xCod.Fecha = pFec_Pago
                    cCodCtr = xCod.Codigo

                    txt = "INSERT INTO LIBRO (ESPECIFICACION, FECHA, FACTURA, AUTORIZACION, ESTADO, NIT, RAZON, IMPORTE_VENTA, ICE_IEHD_TASAS, EXCENTAS, " & _
                            "VENTAS_TASA_CERO, SUBTOTAL, DESCUENTOS, IMPORTE_PARA_DEBITO, DEBITO_FISCAL, CODIGO_CONTROL, SERVICIO, USUARIO, COMPROBANTE) VALUES ('" & _
                            "3','" & pFec_Pago & "','" & pFactura & "','" & pNum_Autorizacion & "','V','" & Val(TxNIT.Text) & "','" & TxUsuario.Text & "','" & _
                            nImporte & "','0','0','0','" & nImporte & "','" & _
                            "0','" & nImporte & "','" & nDebito & "','" & cCodCtr & "','1','" & UCase(_Usuario) & "','" & pNum_Comprobante & "')"

                    With cmd
                        .Connection = db
                        .CommandType = CommandType.Text
                        .CommandText = txt
                        .ExecuteNonQuery()
                    End With

                    txt = "UPDATE FACTURAS Set Num_Factura = '" & pFactura & "', Num_Orden = '" & pNum_Autorizacion & "', Fec_Pago = '" & pFec_Pago & "', Comprobante = '" & pNum_Comprobante & "', Codigo_Control = '" & cCodCtr & "', Cajero = user_name() Where Factura = " & nFactura
                    cmd.CommandText = txt
                    cmd.ExecuteNonQuery()
                    db.Close()

                    xRespuesta.Value = 1
                End If
            Else
                With cmd
                    .Connection = db
                    .CommandType = CommandType.StoredProcedure
                    .CommandText = "Cancelar_Factura"
                    xFactura = .Parameters.Add("@Factura", SqlDbType.Int)
                    xFactura.Direction = ParameterDirection.Input
                    xFactura.Value = nFactura
                    'xEmpleado = .Parameters.Add("@Empleado", SqlDbType.Int)
                    'xEmpleado.Direction = ParameterDirection.Input
                    'xEmpleado.Value = Empleado
                    xComprobante = .Parameters.Add("@Comprobante", SqlDbType.Int)
                    xComprobante.Direction = ParameterDirection.Input
                    xComprobante.Value = pNum_Comprobante
                    xRespuesta = .Parameters.Add("@Cancelado", SqlDbType.Int)
                    xRespuesta.Direction = ParameterDirection.Output
                    xCajero = .Parameters.Add("@Cajero", SqlDbType.NVarChar)
                    xCajero.Direction = ParameterDirection.Input
                    xCajero.Value = _Usuario
                    xPunto = .Parameters.Add("@Punto", SqlDbType.Int)
                    xPunto.Direction = ParameterDirection.Input
                    xPunto.Value = pPunto
                    .ExecuteNonQuery()
                End With
            End If

            If xRespuesta.Value = 1 Then
                da.SelectCommand.CommandText = "Select * From Ver_Facturas_Canceladas Where Factura = " & nFactura
                da.Fill(ds, "FImp")

                da.SelectCommand.CommandText = "Select Top 5 Emision, Con_m3, Lectura, Imp_Factura, Fec_Pago From Facturas Where Abonado = " & cboAbonado.SelectedValue & " And Factura < " & nFactura & " AND Imp_Factura > 0 Order By Factura Desc"
                da.Fill(ds, "FHis")

                'If dEmision > CDate("01/06/2016") Then
                'VerFac.Document = ImpFactMedia
                'VerFac.ShowDialog()
                ImpFactMedia.Print()
                'Else
                '    Imp.Print()
                'End If

                ds.Tables("FImp").Clear()
                ds.Tables("FHis").Clear()
                dgDeuda.Item("Fec_Pago", dgDeuda.CurrentRow.Index).Value = FormatDateTime(Date.Now, DateFormat.ShortDate)
                txtTotalPagado.Text = FormatNumber(Val(txtTotalPagado.Text) + nImporte, 2)
            End If
            If xRespuesta.Value = 0 Then
                MessageBox.Show("No se puede saltear pagos de las facturas", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
            If xRespuesta.Value = 2 Then
                MessageBox.Show("La factura ya esta cancelada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Imp_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim sfont As New System.Drawing.Font("Arial Narrow", 9)
        Dim nFont As New Font("Arial Narrow", 10, FontStyle.Bold)
        Dim fijosize As New System.Drawing.SizeF
        Dim adicsize As New System.Drawing.SizeF
        Dim totasize As New System.Drawing.SizeF
        Dim alcasize As New System.Drawing.SizeF
        Dim recasize As New System.Drawing.SizeF
        Dim reposize As New System.Drawing.SizeF
        Dim tosesize As New System.Drawing.SizeF
        Dim ser1size As New System.Drawing.SizeF
        Dim ser2size As New System.Drawing.SizeF
        Dim ley1size As New System.Drawing.SizeF
        Dim tofasize As New System.Drawing.SizeF

        '---------------------------------------
        Dim dMesAno As Date
        Dim nFactura As Double
        Dim nNum_Factura As Double
        Dim nNum_Autorizacion As Double
        Dim xNombre As String
        Dim cNit As Double
        Dim cDireccion As String
        Dim nAbonado As Double
        Dim cCategoria As String
        Dim cClave_Cate As String
        Dim Fec_Pago As Date
        Dim Fec_Emision As Date
        Dim nLec_Ante As Integer
        Dim nLec_Actu As Double
        Dim nCon_M3 As Integer
        Dim nImp_Fijo As Double
        Dim nImp_Adic As Double
        Dim nImp_Tota As Double
        Dim nImp_Alca As Double
        Dim nImp_Reca As Double
        Dim nImp_Repo As Double
        Dim nImp_Ser1 As Double
        Dim nImp_Ser2 As Double
        Dim nImp_Ley1 As Double
        Dim nImp_Ley2 As Double
        Dim nImp_Fact As Double
        Dim cLiteral As String
        Dim cCodContr As String
        Dim hPeriodo(5) As Date
        Dim hConsumo(5) As Int64
        Dim hImporte(5) As Decimal
        Dim hPagos(5) As Date
        Dim X, y As Integer
        Dim generarCodigoQR As QRCodeEncoder = New QRCodeEncoder
        Dim txtCodigoQr As String
        Dim dfecfin As Date

        generarCodigoQR.QRCodeEncodeMode = Codec.QRCodeEncoder.ENCODE_MODE.BYTE
        generarCodigoQR.QRCodeScale = Int32.Parse(6)
        generarCodigoQR.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H
        generarCodigoQR.QRCodeVersion = 0
        generarCodigoQR.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(colorFondoQR)
        generarCodigoQR.QRCodeForegroundColor = System.Drawing.Color.FromArgb(colorQR)

        '------------------------------------
        dMesAno = ds.Tables("FImp").Rows(0).Item("Emision")
        nNum_Factura = ds.Tables("FImp").Rows(0).Item("Num_Factura")
        nNum_Autorizacion = ds.Tables("FImp").Rows(0).Item("Num_Orden")
        xNombre = ds.Tables("FImp").Rows(0).Item("Razon")
        cNit = ds.Tables("FImp").Rows(0).Item("Nit")
        cDireccion = ds.Tables("FImp").Rows(0).Item("Zona") & " " & TxCalle.Text
        nAbonado = ds.Tables("FImp").Rows(0).Item("Abonado")
        cCategoria = ds.Tables("FImp").Rows(0).Item("Categoria")
        cClave_Cate = ds.Tables("FImp").Rows(0).Item("Categoria")
        Fec_Pago = ds.Tables("FImp").Rows(0).Item("Fec_Pago")
        Fec_Emision = ds.Tables("FImp").Rows(0).Item("Emision")
        If ds.Tables("Fhis").Rows.Count > 0 Then
            nLec_Ante = ds.Tables("Fhis").Rows(0).Item("Lectura")
        Else
            nLec_Ante = 0
        End If
        nLec_Actu = ds.Tables("FImp").Rows(0).Item("Lectura")
        nCon_M3 = ds.Tables("FImp").Rows(0).Item("Con_M3")
        nImp_Fijo = ds.Tables("FImp").Rows(0).Item("Imp_Fijo")
        nImp_Adic = ds.Tables("FImp").Rows(0).Item("Imp_Adic")
        nImp_Tota = ds.Tables("FImp").Rows(0).Item("Imp_Total")
        nImp_Alca = ds.Tables("FImp").Rows(0).Item("Imp_Alcanta")
        nImp_Reca = ds.Tables("FImp").Rows(0).Item("Imp_Recargo")
        nImp_Repo = ds.Tables("FImp").Rows(0).Item("Imp_Rep")
        nImp_Ser1 = ds.Tables("FImp").Rows(0).Item("Imp_Car_1")
        nImp_Ser2 = ds.Tables("FImp").Rows(0).Item("Imp_Car_2")
        nImp_Ley1 = ds.Tables("FImp").Rows(0).Item("Imp_Ley1886_1")
        nImp_Ley2 = ds.Tables("FImp").Rows(0).Item("Imp_Ley1886_2")
        nImp_Fact = ds.Tables("FImp").Rows(0).Item("Imp_Factura")
        nFactura = ds.Tables("FImp").Rows(0).Item("Factura")
        'nImp_Iva = ds.Tables("FImp").Rows(0).Item("Imp_Iva")
        'nImp_Ite = ds.Tables("FImp").Rows(0).Item("Imp_Ite")
        cLiteral = Literal(nImp_Fact, "M")
        cCodContr = ds.Tables("FImp").Rows(0).Item("Codigo_Control")
        dfecfin = Obtener_Fecha_Fin_Autorizacion(nNum_Autorizacion)
        '----------------------------

        txtCodigoQr = "1023807025|" & _
        nNum_Factura.ToString & "|" & nNum_Autorizacion.ToString & "|" & _
        ds.Tables("FImp").Rows(0).Item("Emision") & "|" & nImp_Fact.ToString & "|" & _
        nImp_Fact.ToString & "|" & cCodContr & "|" & cNit & "|0|0|0|0"

        fijosize = e.Graphics.MeasureString(Format(nImp_Fijo, "#0.00"), sfont)
        adicsize = e.Graphics.MeasureString(Format(nImp_Adic, "#0.00"), sfont)
        totasize = e.Graphics.MeasureString(Format(nImp_Fijo + nImp_Adic, "#0.00"), nFont)
        alcasize = e.Graphics.MeasureString(Format(nImp_Alca, "#0.00"), sfont)
        recasize = e.Graphics.MeasureString(Format(nImp_Reca, "#0.00"), sfont)
        reposize = e.Graphics.MeasureString(Format(nImp_Repo, "#0.00"), sfont)
        tosesize = e.Graphics.MeasureString(Format(nImp_Fijo + nImp_Adic + nImp_Alca + nImp_Reca + nImp_Repo, "#0.00"), nFont)
        ser1size = e.Graphics.MeasureString(Format(nImp_Ser1, "#0.00"), sfont)
        ser2size = e.Graphics.MeasureString(Format(nImp_Ser2, "#0.00"), sfont)
        ley1size = e.Graphics.MeasureString(Format(nImp_Ley1 + nImp_Ley2, "#0.00"), sfont)
        tofasize = e.Graphics.MeasureString(Format(nImp_Fact, "#0.00"), nFont)

        X = 30
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 460, X)
        X += 15
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 460, X)

        X = 155
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cDireccion, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, X)
        X += 32
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 100, X)

        X = 155
        If dMesAno = CDate("04/07/2011") Then
            e.Graphics.DrawString("JUN2011", sfont, Brushes.Black, 450, X)
        Else
            e.Graphics.DrawString(Format(dMesAno, "MMMM - yyyy"), sfont, Brushes.Black, 450, X)
        End If
        X += 16
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 32
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 16
        e.Graphics.DrawString(nLec_Ante, sfont, Brushes.Black, 400, X)
        e.Graphics.DrawString(nLec_Actu, sfont, Brushes.Black, 510, X)
        X += 16
        e.Graphics.DrawString(nCon_M3, sfont, Brushes.Black, 400, X)

        X = 325
        If nImp_Fijo > 0 Then
            e.Graphics.DrawString("Importe consumo Fijo", sfont, Brushes.Black, 150, X)
        End If

        If nImp_Adic > 0 Then
            X += 12
            e.Graphics.DrawString("Importe consumo Excedente", sfont, Brushes.Black, 150, X)
        End If

        X += 12
        e.Graphics.DrawString("SUBTOTAL SERVICIO DE AGUA", nFont, Brushes.Black, 150, X)
        If nImp_Alca > 0 Then
            X += 12
            e.Graphics.DrawString("Alcantarrillado", sfont, Brushes.Black, 150, X)
        End If
        If nImp_Reca > 0 Then
            X += 12
            e.Graphics.DrawString("Recargos", sfont, Brushes.Black, 150, X)
        End If
        If nImp_Repo Then
            X += 12
            e.Graphics.DrawString("Rep. de formulario", sfont, Brushes.Black, 150, X)
        End If

        X += 12
        e.Graphics.DrawString("TOTAL SERVICIOS", nFont, Brushes.Black, 150, X)
        If nImp_Ser1 > 0 Then
            X += 12
            e.Graphics.DrawString("Cargo 1 Servicio de agua potable", sfont, Brushes.Black, 150, X)
        End If
        If nImp_Ser2 > 0 Then
            X += 12
            e.Graphics.DrawString("Cargo 2 Servicio de Alcantarrillado", sfont, Brushes.Black, 150, X)
        End If
        If nImp_Ley1 > 0 Then
            X += 12
            e.Graphics.DrawString("Descuento Ley 1886", sfont, Brushes.Black, 150, X)
        End If

        X = 325

        If nImp_Fijo > 0 Then
            e.Graphics.DrawString(Format(nImp_Fijo, "#0.00"), sfont, Brushes.Black, (520 - fijosize.Width), X)
        End If
        If nImp_Adic > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Adic, "#0.00"), sfont, Brushes.Black, (520 - adicsize.Width), X)
        End If
        X += 12
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic, "#0.00"), nFont, Brushes.Black, (520 - totasize.Width), X)
        If nImp_Alca > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Alca, "#0.00"), sfont, Brushes.Black, (520 - alcasize.Width), X)
        End If
        If nImp_Reca Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Reca, "#0.00"), sfont, Brushes.Black, (520 - recasize.Width), X)
        End If
        If nImp_Repo Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Repo, "#0.00"), sfont, Brushes.Black, (520 - reposize.Width), X)
        End If

        X += 12
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic + nImp_Alca + nImp_Reca + nImp_Repo, "#0.00"), nFont, Brushes.Black, (520 - tosesize.Width), X)
        If nImp_Ser1 > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Ser1, "#0.00"), sfont, Brushes.Black, (520 - ser1size.Width), X)
        End If
        If nImp_Ser2 > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Ser2, "#0.00"), sfont, Brushes.Black, (520 - ser2size.Width), X)
        End If
        If nImp_Ley1 + nImp_Ley2 > 0 Then
            X += 12
            e.Graphics.DrawString(Format((nImp_Ley1 + nImp_Ley2), "#0.00"), sfont, Brushes.Black, (520 - ley1size.Width), X)
        End If

        X = 505
        e.Graphics.DrawString(Format(nImp_Fact, "#0.00"), nFont, Brushes.Black, (520 - tofasize.Width), X)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, X)
        X += 20
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawString(dfecfin, sfont, Brushes.Black, 450, X)
        X += 20
        e.Graphics.DrawString(nFactura, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 30, 400, 75, 75)

        For y = 0 To ds.Tables("FHis").Rows.Count - 1
            X = 330 + (20 * y)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Emision"), "MMM/yyyy"), sfont, Brushes.Black, 575, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Con_m3"), "0000"), sfont, Brushes.Black, 640, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Imp_Factura"), "#0.00"), sfont, Brushes.Black, 690, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Fec_Pago"), "dd/MM/yyyy"), sfont, Brushes.Black, 730, X)
        Next

        '------------ COPIA --------------------------------------------------------------------------
        X = 675
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 460, X)
        X += 15
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 460, X)

        X = 805
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cDireccion, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, X)
        X += 32
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 100, X)

        X = 805
        If dMesAno = CDate("04/07/2011") Then
            e.Graphics.DrawString("JUN2011", sfont, Brushes.Black, 450, X)
        Else
            e.Graphics.DrawString(Format(dMesAno, "MMMM - yyyy"), sfont, Brushes.Black, 450, X)
        End If
        X += 16
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 32
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 16
        e.Graphics.DrawString(nLec_Ante, sfont, Brushes.Black, 400, X)
        e.Graphics.DrawString(nLec_Actu, sfont, Brushes.Black, 510, X)
        X += 16
        e.Graphics.DrawString(nCon_M3, sfont, Brushes.Black, 400, X)

        X = 965
        If nImp_Fijo > 0 Then
            e.Graphics.DrawString("Importe consumo Fijo", sfont, Brushes.Black, 150, X)
        End If
        If nImp_Adic > 0 Then
            X += 12
            e.Graphics.DrawString("Importe consumo Excedente", sfont, Brushes.Black, 150, X)
        End If
        X += 12
        e.Graphics.DrawString("SUBTOTAL SERVICIO DE AGUA", nFont, Brushes.Black, 150, X)

        If nImp_Alca > 0 Then
            X += 12
            e.Graphics.DrawString("Alcantarrillado", sfont, Brushes.Black, 150, X)
        End If
        If nImp_Reca > 0 Then
            X += 12
            e.Graphics.DrawString("Recargos", sfont, Brushes.Black, 150, X)
        End If
        If nImp_Repo Then
            X += 12
            e.Graphics.DrawString("Rep. de formulario", sfont, Brushes.Black, 150, X)
        End If

        X += 12
        e.Graphics.DrawString("TOTAL SERVICIOS", nFont, Brushes.Black, 150, X)
        If nImp_Ser1 > 0 Then
            X += 12
            e.Graphics.DrawString("Cargo 1 Servicio de agua potable", sfont, Brushes.Black, 150, X)
        End If
        If nImp_Ser2 > 0 Then
            X += 12
            e.Graphics.DrawString("Cargo 2 Servicio de Alcantarrillado", sfont, Brushes.Black, 150, X)
        End If
        If nImp_Ley1 > 0 Then
            X += 12
            e.Graphics.DrawString("Descuento Ley 1886", sfont, Brushes.Black, 150, X)
        End If

        X = 965
        If nImp_Fijo > 0 Then
            e.Graphics.DrawString(Format(nImp_Fijo, "#0.00"), sfont, Brushes.Black, (520 - fijosize.Width), X)
        End If
        If nImp_Adic > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Adic, "#0.00"), sfont, Brushes.Black, (520 - adicsize.Width), X)
        End If
        X += 12
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic, "#0.00"), nFont, Brushes.Black, (520 - totasize.Width), X)
        If nImp_Alca > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Alca, "#0.00"), sfont, Brushes.Black, (520 - alcasize.Width), X)
        End If
        If nImp_Reca Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Reca, "#0.00"), sfont, Brushes.Black, (520 - recasize.Width), X)
        End If
        If nImp_Repo Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Repo, "#0.00"), sfont, Brushes.Black, (520 - reposize.Width), X)
        End If

        X += 12
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic + nImp_Alca + nImp_Reca + nImp_Repo, "#0.00"), nFont, Brushes.Black, (520 - tosesize.Width), X)
        If nImp_Ser1 > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Ser1, "#0.00"), sfont, Brushes.Black, (520 - ser1size.Width), X)
        End If
        If nImp_Ser2 > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Ser2, "#0.00"), sfont, Brushes.Black, (520 - ser2size.Width), X)
        End If
        If nImp_Ley1 + nImp_Ley2 > 0 Then
            X += 12
            e.Graphics.DrawString(Format((nImp_Ley1 + nImp_Ley2), "#0.00"), sfont, Brushes.Black, (520 - ley1size.Width), X)
        End If
        X = 1150
        e.Graphics.DrawString(Format(nImp_Fact, "#0.00"), nFont, Brushes.Black, (520 - tofasize.Width), X)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, X)
        X += 20
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawString(dfecfin, sfont, Brushes.Black, 450, X)
        X += 20
        e.Graphics.DrawString(nFactura, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 30, 1040, 75, 75)
        For y = 0 To ds.Tables("FHis").Rows.Count - 1
            X = 975 + (20 * y)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Emision"), "MMM/yyyy"), sfont, Brushes.Black, 575, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Con_m3"), "0000"), sfont, Brushes.Black, 640, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Imp_Factura"), "#0.00"), sfont, Brushes.Black, 690, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Fec_Pago"), "dd/MM/yyyy"), sfont, Brushes.Black, 740, X)
        Next

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub antes_facturar_servicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nAutorizacion As Int64
        Dim cLlave As String
        Dim dFecIni As Date
        Dim dFecFin As Date
        Dim nFactura As Integer
        Dim nImporte As Double
        Dim nIva As Double
        Dim nIte As Double
        Dim txt As String
        Dim cmd As New SqlCommand
        Dim cCat As String
        Try
            If Val(txtOtrosServicios.Text) > 0 Then
                cCat = Categoria_Clave(TxCategoria.Text)
                da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = 1"
                da.Fill(ds, "Dos")
                If ds.Tables("Dos").Rows.Count > 0 Then
                    nAutorizacion = ds.Tables("Dos").Rows(0).Item("Autorizacion")
                    nFactura = Nuevo_Numero_Factura(nAutorizacion)

                    cLlave = ds.Tables("Dos").Rows(0).Item("Llave")
                    dFecFin = ds.Tables("Dos").Rows(0).Item("Fec_Final")
                    Fecha_Final = ds.Tables("Dos").Rows(0).Item("Fec_Final")
                    dFecIni = ds.Tables("Dos").Rows(0).Item("Fec_Inicial")
                    nImporte = txtOtrosServicios.Text
                    nIva = Math.Round(nImporte * 0.13, 2)
                    nIte = Math.Round(nImporte * 0.03, 2)
                    If Date.Now >= dFecIni Then
                        If Date.Now <= dFecFin Then
                            Dim codcon As New CodigoV7
                            codcon.Fecha = Date.Now
                            codcon.Importe = nImporte
                            codcon.NoAutorizacion = nAutorizacion
                            codcon.NoFactura = nFactura
                            codcon.Llave = cLlave
                            codcon.NoNit = TxNIT.Text

                            txt = "Insert Into Facturas (Abonado, Num_Factura, Num_Orden, Emision, Categoria, Lectura, Con_m3, Lec_Estimada, Imp_Fijo, " & _
                            "Imp_Adic, Imp_Total, Imp_Alcanta, Imp_Rep, Imp_car_1, Imp_Car_2, Imp_Recargo, Imp_Ley1886_1, Imp_Ley1886_2, Imp_factura, " & _
                            "Imp_Iva, Imp_Ite, Nit, Codigo_Control, Valida, Comprobante, Servicio, Fec_Pago, Empleado, Cajero) values ('" & _
                            cboAbonado.SelectedValue & "','" & _
                            nFactura & "','" & _
                            nAutorizacion & "','" & _
                            FormatDateTime(pFec_Pago, DateFormat.ShortDate) & "','" & _
                            cCat & "',0,0,0,0,0,0,0,0,0,0,0,0,0," & _
                            nImporte & "," & _
                            nIva & "," & _
                            nIte & ",'" & _
                            TxNIT.Text & "','" & _
                            codcon.Codigo & "','V','" & _
                            pNum_Comprobante & "','2','" & FormatDateTime(Date.Now, DateFormat.ShortDate) & "','" & Empleado & "',user_name())"

                            db.Open()
                            With cmd
                                .Connection = db
                                .CommandType = CommandType.Text
                                .CommandText = txt
                                .ExecuteNonQuery()
                            End With

                            da.SelectCommand.CommandText = "Select Factura From Facturas Where Num_Factura = " & nFactura & " And Num_Orden = " & nAutorizacion
                            da.Fill(ds, "NumFac")

                            txt = "Update Servicios_Solicitud Set cobrado = 1, Factura = " & ds.Tables("NumFac").Rows(0).Item("Factura") & " where Abonado = " & cboAbonado.SelectedValue & " And Estado = '1' And Cobrado = '0'"
                            With cmd
                                .Connection = db
                                .CommandType = CommandType.Text
                                .CommandText = txt
                                .ExecuteNonQuery()
                            End With

                            da.SelectCommand.CommandText = "Select U.Abonado, U.Nombre, U.Nit, U.Zona, U.Calle, U.Medidor, " & _
                            "F.Factura, F.Num_Factura, F.Num_Orden, F.Emision, F.Fec_pago, F.Imp_Factura, F.Codigo_Control, " & _
                            "C.Descripcion as Categoria, " & _
                            "S.Servicio, S.Costo, Z.Descripcion " & _
                            "From ((((Usuarios U Inner Join Facturas F On U.Abonado = F.Abonado) " & _
                            "Inner Join Usuarios_Categorias C On C.Categoria = U.Categoria) " & _
                            "Inner Join Servicios_Solicitud S On S.Factura = F.Factura) " & _
                            "Inner Join Servicios_Lista Z On S.Servicio = Z.Servicio) " & _
                            "WHERE S.Costo > 0 And F.Factura = " & ds.Tables("NumFac").Rows(0).Item("Factura")

                            da.Fill(ds, "FRep")
                            'ImpMat.Print()
                            VerFacMat.ShowDialog()
                            ds.Tables("Ser").Clear()
                            ds.Tables("Act").Clear()
                            ds.Tables("NumFac").Clear()
                            ds.Tables("FRep").Clear()
                            Call Ver_Deudas_Actuales(cboAbonado.SelectedValue)
                        End If
                    Else
                        MessageBox.Show("No tiene dosificación", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub ImpMat_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles ImpMat.PrintPage
        Dim sfont As New System.Drawing.Font("Arial Narrow", 9)
        Dim nFont As New Font("Arial Narrow", 10, FontStyle.Bold)
        Dim costosize As New System.Drawing.SizeF
        Dim TofaSize As New System.Drawing.SizeF
        '---------------------------------------
        Dim dMesAno As Date
        Dim nFactura As Double
        Dim nNum_Factura As Double
        Dim nNum_Autorizacion As Double
        Dim xNombre As String
        Dim cNit As Double
        Dim cDireccion As String
        Dim nAbonado As Double
        Dim cCategoria As String
        Dim Fec_Pago As Date
        Dim Fec_Emision As Date
        Dim cLiteral As String
        Dim cCodContr As String
        Dim X, y, i As Integer
        Dim nImp_Fac As Double
        Dim nImp_Cos As Double
        
        Dim generarCodigoQR As QRCodeEncoder = New QRCodeEncoder
        Dim txtCodigoQr As String

        generarCodigoQR.QRCodeEncodeMode = Codec.QRCodeEncoder.ENCODE_MODE.BYTE
        generarCodigoQR.QRCodeScale = Int32.Parse(6)
        generarCodigoQR.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H
        generarCodigoQR.QRCodeVersion = 0
        generarCodigoQR.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(colorFondoQR)
        generarCodigoQR.QRCodeForegroundColor = System.Drawing.Color.FromArgb(colorQR)

        '------------------------------------
        dMesAno = ds.Tables("FREp").Rows(0).Item("Emision")
        nNum_Factura = ds.Tables("FRep").Rows(0).Item("Num_Factura")
        nNum_Autorizacion = ds.Tables("FRep").Rows(0).Item("Num_Orden")
        xNombre = TxUsuario.Text  'ds.Tables("FRep").Rows(0).Item("Razon")
        cNit = TxNIT.Text  'ds.Tables("FRep").Rows(0).Item("Nit")
        cDireccion = TxZona.Text  'ds.Tables("FRep").Rows(0).Item("Zona")
        nAbonado = cboAbonado.SelectedValue  'ds.Tables("FRep").Rows(0).Item("Abonado")
        cCategoria = TxCategoria.Text  'ds.Tables("FRep").Rows(0).Item("Categoria")
        Fec_Pago = ds.Tables("FRep").Rows(0).Item("Fec_Pago")
        Fec_Emision = ds.Tables("FRep").Rows(0).Item("Emision")
        nImp_Fac = ds.Tables("Frep").Rows(0).Item("Imp_Factura")
        cLiteral = Literal(nImp_Fac, "M")
        cCodContr = ds.Tables("FRep").Rows(0).Item("Codigo_Control")
        nFactura = ds.Tables("Frep").Rows(0).Item("Factura")
        '----------------------------

        txtCodigoQr = "1023807025|" & _
        nNum_Factura.ToString & "|" & nNum_Autorizacion.ToString & "|" & _
        ds.Tables("Frep").Rows(0).Item("Emision") & "|" & nImp_Fac.ToString & "|" & _
        nImp_Fac.ToString & "|" & cCodContr & "|" & cNit & "|0|0|0|0"


        TofaSize = e.Graphics.MeasureString(Format(nImp_Fac, "#0.00"), nFont)

        X = 30
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 460, X)
        X += 15
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 460, X)

        X = 160
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cDireccion, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, X)
        X += 32
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 100, X)

        X = 150
        e.Graphics.DrawString(Format(dMesAno, "MMMM - yyyy"), sfont, Brushes.Black, 450, X)
        X += 16
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 32
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)

        '--------------------detalle-------------------------
        X = 315
        For i = 0 To ds.Tables("Frep").Rows.Count - 1
            X += 12
            nImp_Cos = ds.Tables("Frep").Rows(i).Item("Costo")
            costosize = e.Graphics.MeasureString(FormatNumber(nImp_Cos, 2), sfont)
            e.Graphics.DrawString(ds.Tables("Frep").Rows(i).Item("Descripcion"), sfont, Brushes.Black, 150, X)
            e.Graphics.DrawString(FormatNumber(nImp_Cos, 2), sfont, Brushes.Black, (520 - costosize.Width), X)
        Next
        '-------------------- fin detalle --------------------
        X = 508
        e.Graphics.DrawString(Format(nImp_Fac, "#0.00"), nFont, Brushes.Black, (520 - TofaSize.Width), X)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, X)
        X += 20
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawString(Fecha_Final, sfont, Brushes.Black, 450, X)
        X += 20
        e.Graphics.DrawString(nFactura, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 30, 400, 75, 75)

        '------------ COPIA ------------
        X = 675
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 460, X)
        X += 15
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 460, X)

        X = 805
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cDireccion, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, X)
        X += 32
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 100, X)

        X = 805
        e.Graphics.DrawString(Format(dMesAno, "MMMM - yyyy"), sfont, Brushes.Black, 450, X)
        X += 16
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 32
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)


        '----------------- Detalle ----------------------
        X = 960
        For i = 0 To ds.Tables("Frep").Rows.Count - 1
            X += 12
            nImp_Cos = ds.Tables("Frep").Rows(i).Item("Costo")
            costosize = e.Graphics.MeasureString(FormatNumber(nImp_Cos, 2), sfont)
            e.Graphics.DrawString(ds.Tables("Frep").Rows(i).Item("Descripcion"), sfont, Brushes.Black, 150, X)
            e.Graphics.DrawString(FormatNumber(nImp_Cos, 2), sfont, Brushes.Black, (520 - costosize.Width), X)
        Next
        '---------------- fin detalle -------------------
        X = 1150
        e.Graphics.DrawString(Format(nImp_Fac, "#0.00"), nFont, Brushes.Black, (520 - TofaSize.Width), X)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, X)
        X += 20
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawString(Fecha_Final, sfont, Brushes.Black, 450, X)
        X += 20
        e.Graphics.DrawString(nFactura, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 30, 1040, 75, 75)
    End Sub

    Private Sub cboAbonado_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAbonado.SelectionChangeCommitted
        ds.Tables("Act").Clear()
        Ver_Usuarios(cboAbonado.SelectedValue)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        da.SelectCommand.CommandText = "Select * From Ver_Facturas_Materiales Where Factura = 814583"
        da.Fill(ds, "FRep")
        'ImpMat.Print()
        VerFacMat.ShowDialog()
        ds.Tables("FREP").Clear()
    End Sub

    Private Sub btnFactServicios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFactServicios.Click

        Dim cLlave As String
        Dim dFecIni As Date
        Dim dFecFin As Date
        Dim nImporte As Double
        Dim nIte As Double
        Dim txt As String
        Dim cmd As New SqlCommand
        Dim cCat As String
        Dim nIce_Iehd_tasas As Double
        Dim nExcentos As Double
        Dim nVentas_Tasa_Cero As Double
        Dim nSubtotal As Double
        Dim nDescuento As Double
        Dim nImporte_Para_Debito As Double
        Dim nDebito As Double
        Dim cCodigoControl As String

        Try
            If Total_Otros_Servicios(cboAbonado.SelectedValue) > 0 Then
                cCat = Categoria_Clave(TxCategoria.Text)
                da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = 1"
                da.Fill(ds, "Dos")
                If ds.Tables("Dos").Rows.Count > 0 Then

                    pNum_Autorizacion = ds.Tables("Dos").Rows(0).Item("Autorizacion")
                    pFactura = Nuevo_Numero_Factura(pNum_Autorizacion)

                    cLlave = ds.Tables("Dos").Rows(0).Item("Llave")
                    dFecFin = ds.Tables("Dos").Rows(0).Item("Fec_Final")
                    Fecha_Final = ds.Tables("Dos").Rows(0).Item("Fec_Final")
                    dFecIni = ds.Tables("Dos").Rows(0).Item("Fec_Inicial")
                    nImporte = Total_Otros_Servicios(cboAbonado.SelectedValue)
                    nIce_Iehd_tasas = 0
                    nExcentos = 0
                    nVentas_Tasa_Cero = 0
                    nSubtotal = nImporte - nIce_Iehd_tasas - nExcentos - nVentas_Tasa_Cero
                    nDescuento = 0
                    nImporte_Para_Debito = nSubtotal - nDescuento

                    nDebito = Math.Round(nImporte * 0.13, 2)
                    nIte = Math.Round(nImporte * 0.03, 2)
                    If Date.Now >= dFecIni Then
                        If Date.Now <= dFecFin Then
                            Dim codcon As New CodigoV7
                            codcon.Fecha = pFec_Pago
                            codcon.Importe = nImporte_Para_Debito
                            codcon.NoAutorizacion = pNum_Autorizacion
                            codcon.NoFactura = pFactura
                            codcon.Llave = cLlave
                            codcon.NoNit = Val(TxNIT.Text)
                            cCodigoControl = codcon.Codigo

                            txt = "INSERT INTO LIBRO (ESPECIFICACION, FECHA, FACTURA, AUTORIZACION, ESTADO, NIT, RAZON, IMPORTE_VENTA, ICE_IEHD_TASAS, EXCENTAS, " & _
                            "VENTAS_TASA_CERO, SUBTOTAL, DESCUENTOS, IMPORTE_PARA_DEBITO, DEBITO_FISCAL, CODIGO_CONTROL, SERVICIO, USUARIO, COMPROBANTE) VALUES ('" & _
                            "3','" & pFec_Pago & "','" & pFactura & "','" & pNum_Autorizacion & "','V','" & Val(TxNIT.Text) & "','" & TxUsuario.Text & "','" & _
                            nImporte & "','" & nIce_Iehd_tasas & "','" & nExcentos & "','" & nVentas_Tasa_Cero & "','" & nSubtotal & "','" & _
                            nDescuento & "','" & nImporte_Para_Debito & "','" & nDebito & "','" & cCodigoControl & "','2','" & UCase(_Usuario) & "','" & pNum_Comprobante & "')"

                            db.Open()
                            With cmd
                                .Connection = db
                                .CommandType = CommandType.Text
                                .CommandText = txt
                                .ExecuteNonQuery()
                            End With

                            For i = 0 To dgServicios.RowCount - 1
                                If dgServicios.Item("COSTO", i).Value > 0 Then
                                    txt = "INSERT INTO LIBRO_DETALLE (FACTURA, AUTORIZACION, MATERIAL, DESCRIPCION, UNIDAD, UNITARIO, TOTAL, ENTREGA) VALUES ('" & _
                                        pFactura & "','" & pNum_Autorizacion & "','" & dgServicios.Item("NoSolicitud", i).Value & "','" & dgServicios.Item("DESCRIPCION", i).Value & "','" & _
                                        "SER','" & dgServicios.Item("COSTO", i).Value & "','" & dgServicios.Item("COSTO", i).Value & "','0')"
                                    cmd.CommandText = txt
                                    cmd.ExecuteNonQuery()
                                End If
                            Next
                            'db.Close()

                            '"Select Sum(Costo) as Imp From Servicios_Solicitud Where Cobrado = 0 And Estado = '1' and Costo > 0 and Abonado = " & Abonado
                            txt = "UPDATE SERVICIOS_SOLICITUD SET COBRADO = 1, FACTURA = " & pFactura & " WHERE COBRADO = 0 AND ESTADO = '1' AND COSTO > 0 AND ABONADO = " & cboAbonado.SelectedValue
                            cmd.CommandText = txt
                            cmd.ExecuteNonQuery()
                            db.Close()

                            Dim fRep As New Frm_Imprimir_Factura_Otras_Ventas
                            If fRep.ShowDialog = Windows.Forms.DialogResult.OK Then

                            End If

                            Call Ver_Deudas_Actuales(cboAbonado.SelectedValue)
                        End If
                    Else
                        MessageBox.Show("No tiene dosificación", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                End If
                ds.Tables("Dos").Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub ImpFac10002514_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles ImpFac10002514.PrintPage

        Dim sfont As New System.Drawing.Font("Arial Narrow", 9)
        Dim nFont As New Font("Arial Narrow", 10, FontStyle.Bold)
        Dim fijosize As New System.Drawing.SizeF
        Dim adicsize As New System.Drawing.SizeF
        Dim totasize As New System.Drawing.SizeF
        Dim alcasize As New System.Drawing.SizeF
        Dim recasize As New System.Drawing.SizeF
        Dim reposize As New System.Drawing.SizeF
        Dim tosesize As New System.Drawing.SizeF
        Dim ser1size As New System.Drawing.SizeF
        Dim ser2size As New System.Drawing.SizeF
        Dim ley1size As New System.Drawing.SizeF
        Dim tofasize As New System.Drawing.SizeF

        '---------------------------------------
        Dim dMesAno As Date
        Dim nFactura As Double
        Dim nNum_Factura As Double
        Dim nNum_Autorizacion As Double
        Dim xNombre As String
        Dim cNit As Double
        Dim cDireccion As String
        Dim nAbonado As Double
        Dim cCategoria As String
        Dim cClave_Cate As String
        Dim Fec_Pago As Date
        Dim Fec_Emision As Date
        Dim nLec_Ante As Integer
        Dim nLec_Actu As Double
        Dim nCon_M3 As Integer
        Dim nImp_Fijo As Double
        Dim nImp_Adic As Double
        Dim nImp_Tota As Double
        Dim nImp_Alca As Double
        Dim nImp_Reca As Double
        Dim nImp_Repo As Double
        Dim nImp_Ser1 As Double
        Dim nImp_Ser2 As Double
        Dim nImp_Ley1 As Double
        Dim nImp_Ley2 As Double
        Dim nImp_Fact As Double
        Dim cLiteral As String
        Dim cCodContr As String
        Dim hPeriodo(5) As Date
        Dim hConsumo(5) As Int64
        Dim hImporte(5) As Decimal
        Dim hPagos(5) As Date
        Dim X, y As Integer
        Dim generarCodigoQR As QRCodeEncoder = New QRCodeEncoder
        Dim txtCodigoQr As String
        Dim cLey453 As String
        Dim dFecFin As Date


        generarCodigoQR.QRCodeEncodeMode = Codec.QRCodeEncoder.ENCODE_MODE.BYTE
        generarCodigoQR.QRCodeScale = Int32.Parse(6)
        generarCodigoQR.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H
        generarCodigoQR.QRCodeVersion = 0
        generarCodigoQR.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(colorFondoQR)
        generarCodigoQR.QRCodeForegroundColor = System.Drawing.Color.FromArgb(colorQR)

        '------------------------------------
        dMesAno = ds.Tables("FImp").Rows(0).Item("Emision")
        nNum_Factura = ds.Tables("FImp").Rows(0).Item("Num_Factura")
        nNum_Autorizacion = ds.Tables("FImp").Rows(0).Item("Num_Orden")
        xNombre = ds.Tables("FImp").Rows(0).Item("Razon")
        cNit = ds.Tables("FImp").Rows(0).Item("Nit")
        cDireccion = ds.Tables("FImp").Rows(0).Item("Zona") & " " & TxCalle.Text
        nAbonado = ds.Tables("FImp").Rows(0).Item("Abonado")
        cCategoria = ds.Tables("FImp").Rows(0).Item("Categoria")
        cClave_Cate = ds.Tables("FImp").Rows(0).Item("Categoria")
        Fec_Pago = ds.Tables("FImp").Rows(0).Item("Fec_Pago")
        Fec_Emision = ds.Tables("FImp").Rows(0).Item("Emision")
        If ds.Tables("Fhis").Rows.Count > 0 Then
            nLec_Ante = ds.Tables("Fhis").Rows(0).Item("Lectura")
        Else
            nLec_Ante = 0
        End If
        nLec_Actu = ds.Tables("FImp").Rows(0).Item("Lectura")
        nCon_M3 = ds.Tables("FImp").Rows(0).Item("Con_M3")
        nImp_Fijo = ds.Tables("FImp").Rows(0).Item("Imp_Fijo")
        nImp_Adic = ds.Tables("FImp").Rows(0).Item("Imp_Adic")
        nImp_Tota = ds.Tables("FImp").Rows(0).Item("Imp_Total")
        nImp_Alca = ds.Tables("FImp").Rows(0).Item("Imp_Alcanta")
        nImp_Reca = ds.Tables("FImp").Rows(0).Item("Imp_Recargo")
        nImp_Repo = ds.Tables("FImp").Rows(0).Item("Imp_Rep")
        nImp_Ser1 = ds.Tables("FImp").Rows(0).Item("Imp_Car_1")
        nImp_Ser2 = ds.Tables("FImp").Rows(0).Item("Imp_Car_2")
        nImp_Ley1 = ds.Tables("FImp").Rows(0).Item("Imp_Ley1886_1")
        nImp_Ley2 = ds.Tables("FImp").Rows(0).Item("Imp_Ley1886_2")
        nImp_Fact = ds.Tables("FImp").Rows(0).Item("Imp_Factura")
        nFactura = ds.Tables("FImp").Rows(0).Item("Factura")
        'nImp_Iva = ds.Tables("FImp").Rows(0).Item("Imp_Iva")
        'nImp_Ite = ds.Tables("FImp").Rows(0).Item("Imp_Ite")
        cLiteral = Literal(nImp_Fact, "M")
        cCodContr = ds.Tables("FImp").Rows(0).Item("Codigo_Control")
        cLey453 = Leyenda_Ley_453_Autorizacion(nNum_Autorizacion)
        dFecFin = Obtener_Fecha_Fin_Autorizacion(nNum_Autorizacion)
        '----------------------------

        txtCodigoQr = "1023807025|" & _
        nNum_Factura.ToString & "|" & nNum_Autorizacion.ToString & "|" & _
        ds.Tables("FImp").Rows(0).Item("Emision") & "|" & nImp_Fact.ToString & "|" & _
        nImp_Fact.ToString & "|" & cCodContr & "|" & cNit & "|0|0|0|0"

        fijosize = e.Graphics.MeasureString(Format(nImp_Fijo, "#0.00"), sfont)
        adicsize = e.Graphics.MeasureString(Format(nImp_Adic, "#0.00"), sfont)
        totasize = e.Graphics.MeasureString(Format(nImp_Fijo + nImp_Adic, "#0.00"), nFont)
        alcasize = e.Graphics.MeasureString(Format(nImp_Alca, "#0.00"), sfont)
        recasize = e.Graphics.MeasureString(Format(nImp_Reca, "#0.00"), sfont)
        reposize = e.Graphics.MeasureString(Format(nImp_Repo, "#0.00"), sfont)
        tosesize = e.Graphics.MeasureString(Format(nImp_Fijo + nImp_Adic + nImp_Alca + nImp_Reca + nImp_Repo, "#0.00"), nFont)
        ser1size = e.Graphics.MeasureString(Format(nImp_Ser1, "#0.00"), sfont)
        ser2size = e.Graphics.MeasureString(Format(nImp_Ser2, "#0.00"), sfont)
        ley1size = e.Graphics.MeasureString(Format(nImp_Ley1 + nImp_Ley2, "#0.00"), sfont)
        tofasize = e.Graphics.MeasureString(Format(nImp_Fact, "#0.00"), nFont)

        X = 20
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 650, X)
        X += 15
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 650, X)

        X = 145
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cDireccion, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, X)
        X += 32
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 100, X)

        X = 145
        If dMesAno = CDate("04/07/2011") Then
            e.Graphics.DrawString("JUN2011", sfont, Brushes.Black, 450, X)
        Else
            e.Graphics.DrawString(Format(dMesAno, "MMMM - yyyy"), sfont, Brushes.Black, 450, X)
        End If
        X += 16
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 32
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 16
        e.Graphics.DrawString(nLec_Ante, sfont, Brushes.Black, 400, X)
        e.Graphics.DrawString(nLec_Actu, sfont, Brushes.Black, 510, X)
        X += 16
        e.Graphics.DrawString(nCon_M3, sfont, Brushes.Black, 400, X)

        X = 270
        If nImp_Fijo > 0 Then
            e.Graphics.DrawString("Importe consumo Fijo", sfont, Brushes.Black, 100, X)
        End If

        If nImp_Adic > 0 Then
            X += 12
            e.Graphics.DrawString("Importe consumo Excedente", sfont, Brushes.Black, 100, X)
        End If

        X += 12
        e.Graphics.DrawString("SUBTOTAL SERVICIO DE AGUA", nFont, Brushes.Black, 100, X)
        If nImp_Alca > 0 Then
            X += 12
            e.Graphics.DrawString("Alcantarrillado", sfont, Brushes.Black, 100, X)
        End If
        If nImp_Reca > 0 Then
            X += 12
            e.Graphics.DrawString("Recargos", sfont, Brushes.Black, 100, X)
        End If
        If nImp_Repo Then
            X += 12
            e.Graphics.DrawString("Rep. de formulario", sfont, Brushes.Black, 100, X)
        End If

        X += 12
        e.Graphics.DrawString("TOTAL SERVICIOS", nFont, Brushes.Black, 100, X)
        If nImp_Ser1 > 0 Then
            X += 12
            e.Graphics.DrawString("Cargo 1 Servicio de agua potable", sfont, Brushes.Black, 100, X)
        End If
        If nImp_Ser2 > 0 Then
            X += 12
            e.Graphics.DrawString("Cargo 2 Servicio de Alcantarrillado", sfont, Brushes.Black, 100, X)
        End If
        If nImp_Ley1 > 0 Then
            X += 12
            e.Graphics.DrawString("Descuento Ley 1886", sfont, Brushes.Black, 100, X)
        End If

        X = 270

        If nImp_Fijo > 0 Then
            e.Graphics.DrawString(Format(nImp_Fijo, "#0.00"), sfont, Brushes.Black, (540 - fijosize.Width), X)
        End If
        If nImp_Adic > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Adic, "#0.00"), sfont, Brushes.Black, (540 - adicsize.Width), X)
        End If
        X += 12
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic, "#0.00"), nFont, Brushes.Black, (540 - totasize.Width), X)
        If nImp_Alca > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Alca, "#0.00"), sfont, Brushes.Black, (540 - alcasize.Width), X)
        End If
        If nImp_Reca Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Reca, "#0.00"), sfont, Brushes.Black, (540 - recasize.Width), X)
        End If
        If nImp_Repo Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Repo, "#0.00"), sfont, Brushes.Black, (540 - reposize.Width), X)
        End If

        X += 12
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic + nImp_Alca + nImp_Reca + nImp_Repo, "#0.00"), nFont, Brushes.Black, (540 - tosesize.Width), X)
        If nImp_Ser1 > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Ser1, "#0.00"), sfont, Brushes.Black, (540 - ser1size.Width), X)
        End If
        If nImp_Ser2 > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Ser2, "#0.00"), sfont, Brushes.Black, (540 - ser2size.Width), X)
        End If
        If nImp_Ley1 + nImp_Ley2 > 0 Then
            X += 12
            e.Graphics.DrawString(Format((nImp_Ley1 + nImp_Ley2), "#0.00"), sfont, Brushes.Black, (540 - ley1size.Width), X)
        End If

        X = 410
        e.Graphics.DrawString(Format(nImp_Fact, "#0.00"), nFont, Brushes.Black, (540 - tofasize.Width), X)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, X)
        X += 20
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 100, X)
        e.Graphics.DrawString(dFecFin, sfont, Brushes.Black, 450, X)
        X += 20
        e.Graphics.DrawString(nFactura, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 700, 380, 75, 75)
        X += 40
        e.Graphics.DrawString("LEY 453: " & cLey453, sfont, Brushes.Black, 50, X)

        For y = 0 To ds.Tables("FHis").Rows.Count - 1
            X = 145 + (20 * y)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Emision"), "MMM/yyyy"), sfont, Brushes.Black, 575, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Con_m3"), "0000"), sfont, Brushes.Black, 640, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Imp_Factura"), "#0.00"), sfont, Brushes.Black, 690, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Fec_Pago"), "dd/MM/yyyy"), sfont, Brushes.Black, 730, X)
        Next

        '------------ COPIA --------------------------------------------------------------------------
        X = 565
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 650, X)
        X += 15
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 650, X)

        X = 695
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(cDireccion, sfont, Brushes.Black, 100, X)
        X += 16
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, X)
        X += 32
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 100, X)

        X = 695
        If dMesAno = CDate("04/07/2011") Then
            e.Graphics.DrawString("JUN2011", sfont, Brushes.Black, 450, X)
        Else
            e.Graphics.DrawString(Format(dMesAno, "MMMM - yyyy"), sfont, Brushes.Black, 450, X)
        End If
        X += 16
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 32
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 16
        e.Graphics.DrawString(nLec_Ante, sfont, Brushes.Black, 400, X)
        e.Graphics.DrawString(nLec_Actu, sfont, Brushes.Black, 510, X)
        X += 16
        e.Graphics.DrawString(nCon_M3, sfont, Brushes.Black, 400, X)

        X = 820
        If nImp_Fijo > 0 Then
            e.Graphics.DrawString("Importe consumo Fijo", sfont, Brushes.Black, 100, X)
        End If
        If nImp_Adic > 0 Then
            X += 12
            e.Graphics.DrawString("Importe consumo Excedente", sfont, Brushes.Black, 100, X)
        End If
        X += 12
        e.Graphics.DrawString("SUBTOTAL SERVICIO DE AGUA", nFont, Brushes.Black, 100, X)

        If nImp_Alca > 0 Then
            X += 12
            e.Graphics.DrawString("Alcantarrillado", sfont, Brushes.Black, 100, X)
        End If
        If nImp_Reca > 0 Then
            X += 12
            e.Graphics.DrawString("Recargos", sfont, Brushes.Black, 100, X)
        End If
        If nImp_Repo Then
            X += 12
            e.Graphics.DrawString("Rep. de formulario", sfont, Brushes.Black, 100, X)
        End If

        X += 12
        e.Graphics.DrawString("TOTAL SERVICIOS", nFont, Brushes.Black, 100, X)
        If nImp_Ser1 > 0 Then
            X += 12
            e.Graphics.DrawString("Cargo 1 Servicio de agua potable", sfont, Brushes.Black, 100, X)
        End If
        If nImp_Ser2 > 0 Then
            X += 12
            e.Graphics.DrawString("Cargo 2 Servicio de Alcantarrillado", sfont, Brushes.Black, 100, X)
        End If
        If nImp_Ley1 > 0 Then
            X += 12
            e.Graphics.DrawString("Descuento Ley 1886", sfont, Brushes.Black, 100, X)
        End If

        X = 820
        If nImp_Fijo > 0 Then
            e.Graphics.DrawString(Format(nImp_Fijo, "#0.00"), sfont, Brushes.Black, (540 - fijosize.Width), X)
        End If
        If nImp_Adic > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Adic, "#0.00"), sfont, Brushes.Black, (540 - adicsize.Width), X)
        End If
        X += 12
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic, "#0.00"), nFont, Brushes.Black, (540 - totasize.Width), X)
        If nImp_Alca > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Alca, "#0.00"), sfont, Brushes.Black, (540 - alcasize.Width), X)
        End If
        If nImp_Reca Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Reca, "#0.00"), sfont, Brushes.Black, (540 - recasize.Width), X)
        End If
        If nImp_Repo Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Repo, "#0.00"), sfont, Brushes.Black, (540 - reposize.Width), X)
        End If

        X += 12
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic + nImp_Alca + nImp_Reca + nImp_Repo, "#0.00"), nFont, Brushes.Black, (540 - tosesize.Width), X)
        If nImp_Ser1 > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Ser1, "#0.00"), sfont, Brushes.Black, (540 - ser1size.Width), X)
        End If
        If nImp_Ser2 > 0 Then
            X += 12
            e.Graphics.DrawString(Format(nImp_Ser2, "#0.00"), sfont, Brushes.Black, (540 - ser2size.Width), X)
        End If
        If nImp_Ley1 + nImp_Ley2 > 0 Then
            X += 12
            e.Graphics.DrawString(Format((nImp_Ley1 + nImp_Ley2), "#0.00"), sfont, Brushes.Black, (540 - ley1size.Width), X)
        End If

        X = 960
        e.Graphics.DrawString(Format(nImp_Fact, "#0.00"), nFont, Brushes.Black, (540 - tofasize.Width), X)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, X)
        X += 20
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawString(dFecFin, sfont, Brushes.Black, 450, X)
        X += 20
        e.Graphics.DrawString(nFactura, sfont, Brushes.Black, 150, X)
        X += 40
        e.Graphics.DrawString("LEY 453: " & cLey453, sfont, Brushes.Black, 50, X)

        e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 700, 930, 75, 75)

        For y = 0 To ds.Tables("FHis").Rows.Count - 1
            X = 700 + (20 * y)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Emision"), "MMM/yyyy"), sfont, Brushes.Black, 575, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Con_m3"), "0000"), sfont, Brushes.Black, 640, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Imp_Factura"), "#0.00"), sfont, Brushes.Black, 690, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Fec_Pago"), "dd/MM/yyyy"), sfont, Brushes.Black, 740, X)
        Next

    End Sub

    Function Total_Otros_Servicios(ByVal Abonado As Double) As Double
        da.SelectCommand.CommandText = "Select Sum(Costo) as Imp From Servicios_Solicitud Where Cobrado = 0 And Estado = '1' and Costo > 0 and Abonado = " & Abonado
        da.Fill(ds, "TotSer")
        txtOtrosServicios.Text = "0.00"

        If Not IsDBNull(ds.Tables("TotSer").Rows(0).Item("Imp")) Then
            Total_Otros_Servicios = ds.Tables("TotSer").Rows(0).Item("Imp")
        Else
            Total_Otros_Servicios = 0
        End If
        ds.Tables("TotSer").Clear()
    End Function

    Private Sub ImpFactMedia_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles ImpFactMedia.PrintPage
        Dim sfont As New System.Drawing.Font("Arial Narrow", 8)
        Dim nFont As New Font("Arial Narrow", 10, FontStyle.Bold)
        Dim fijosize As New System.Drawing.SizeF
        Dim adicsize As New System.Drawing.SizeF
        Dim totasize As New System.Drawing.SizeF
        Dim alcasize As New System.Drawing.SizeF
        Dim recasize As New System.Drawing.SizeF
        Dim reposize As New System.Drawing.SizeF
        Dim tosesize As New System.Drawing.SizeF
        Dim ser1size As New System.Drawing.SizeF
        Dim ser2size As New System.Drawing.SizeF
        Dim ley1size As New System.Drawing.SizeF
        Dim tofasize As New System.Drawing.SizeF
        Dim Alim As New System.Drawing.StringFormat(StringFormatFlags.DirectionRightToLeft)

        '---------------------------------------
        Dim dMesAno As Date
        Dim nFactura As Double
        Dim nNum_Factura As Double
        Dim nNum_Autorizacion As Double
        Dim xNombre As String
        Dim cNit As Double
        Dim cDireccion As String
        Dim nAbonado As Double
        Dim cCategoria As String
        Dim cClave_Cate As String
        Dim Fec_Pago As Date
        Dim Fec_Emision As Date
        Dim nLec_Ante As Integer
        Dim nLec_Actu As Double
        Dim nCon_M3 As Integer
        Dim nImp_Fijo As Double
        Dim nImp_Adic As Double
        Dim nImp_Tota As Double
        Dim nImp_Alca As Double
        Dim nImp_Reca As Double
        Dim nImp_Repo As Double
        Dim nImp_Ser1 As Double
        Dim nImp_Ser2 As Double
        Dim nImp_Ley1 As Double
        Dim nImp_Ley2 As Double
        Dim nImp_Fact As Double
        Dim cLiteral As String
        Dim cCodContr As String
        Dim hPeriodo(5) As Date
        Dim hConsumo(5) As Int64
        Dim hImporte(5) As Decimal
        Dim hPagos(5) As Date
        Dim X, y As Integer
        Dim generarCodigoQR As QRCodeEncoder = New QRCodeEncoder
        Dim txtCodigoQr As String
        Dim cLey453 As String
        Dim dFecFin As Date
        Dim EspacioLey As New System.Drawing.RectangleF(40, 500, 600, 45)
        Dim nImp_Descuento As Double
        Dim nImp_AlcanDesc As Double

        generarCodigoQR.QRCodeEncodeMode = Codec.QRCodeEncoder.ENCODE_MODE.BYTE
        generarCodigoQR.QRCodeScale = Int32.Parse(6)
        generarCodigoQR.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H
        generarCodigoQR.QRCodeVersion = 0
        generarCodigoQR.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(colorFondoQR)
        generarCodigoQR.QRCodeForegroundColor = System.Drawing.Color.FromArgb(colorQR)

        '------------------------------------
        dMesAno = ds.Tables("FImp").Rows(0).Item("Emision")
        nNum_Factura = ds.Tables("FImp").Rows(0).Item("Num_Factura")
        nNum_Autorizacion = ds.Tables("FImp").Rows(0).Item("Num_Orden")
        xNombre = ds.Tables("FImp").Rows(0).Item("Razon")
        cNit = ds.Tables("FImp").Rows(0).Item("Nit")
        cDireccion = ds.Tables("FImp").Rows(0).Item("Zona") & " " & TxCalle.Text
        nAbonado = ds.Tables("FImp").Rows(0).Item("Abonado")
        cCategoria = ds.Tables("FImp").Rows(0).Item("Categoria")
        cClave_Cate = ds.Tables("FImp").Rows(0).Item("Categoria")
        Fec_Pago = ds.Tables("FImp").Rows(0).Item("Fec_Pago")
        Fec_Emision = ds.Tables("FImp").Rows(0).Item("Emision")
        If ds.Tables("Fhis").Rows.Count > 0 Then
            nLec_Ante = ds.Tables("Fhis").Rows(0).Item("Lectura")
        Else
            nLec_Ante = 0
        End If
        nLec_Actu = ds.Tables("FImp").Rows(0).Item("Lectura")
        nCon_M3 = ds.Tables("FImp").Rows(0).Item("Con_M3")
        nImp_Fijo = ds.Tables("FImp").Rows(0).Item("Imp_Fijo")
        nImp_Adic = ds.Tables("FImp").Rows(0).Item("Imp_Adic")
        nImp_Tota = ds.Tables("FImp").Rows(0).Item("Imp_Total")
        nImp_Alca = ds.Tables("FImp").Rows(0).Item("Imp_Alcanta")
        nImp_Reca = ds.Tables("FImp").Rows(0).Item("Imp_Recargo")
        nImp_Repo = ds.Tables("FImp").Rows(0).Item("Imp_Rep")
        nImp_Ser1 = ds.Tables("FImp").Rows(0).Item("Imp_Car_1")
        nImp_Ser2 = ds.Tables("FImp").Rows(0).Item("Imp_Car_2")
        nImp_Ley1 = ds.Tables("FImp").Rows(0).Item("Imp_Ley1886_1")
        nImp_Ley2 = ds.Tables("FImp").Rows(0).Item("Imp_Ley1886_2")
        nImp_Fact = ds.Tables("FImp").Rows(0).Item("Imp_Factura")
        nFactura = ds.Tables("FImp").Rows(0).Item("Factura")
        nImp_Descuento = ds.Tables("FImp").Rows(0).Item("Imp_Descuento")
        nImp_AlcanDesc = ds.Tables("FImp").Rows(0).Item("Imp_DesAlcan")
        cLiteral = Literal(nImp_Fact, "M")
        cCodContr = ds.Tables("FImp").Rows(0).Item("Codigo_Control")
        cLey453 = Leyenda_Ley_453_Autorizacion(nNum_Autorizacion)
        dFecFin = Obtener_Fecha_Fin_Autorizacion(nNum_Autorizacion)
        '----------------------------

        txtCodigoQr = "1023807025|" & _
        nNum_Factura.ToString & "|" & nNum_Autorizacion.ToString & "|" & _
        ds.Tables("FImp").Rows(0).Item("Emision") & "|" & nImp_Fact.ToString & "|" & _
        nImp_Fact.ToString & "|" & cCodContr & "|" & cNit & "|0|0|0|0"

        X = 25
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 550, X)
        X += 15
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 550, X)

        X = 150
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, X)
        X += 15
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, X)
        X += 15
        e.Graphics.DrawString(cDireccion, sfont, Brushes.Black, 100, X)
        X += 15
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, X)
        X += 30
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 100, X)

        X = 150
        If dMesAno = CDate("04/07/2011") Then
            e.Graphics.DrawString("JUN2011", sfont, Brushes.Black, 400, X)
        Else
            e.Graphics.DrawString(Format(dMesAno, "MMMM - yyyy"), sfont, Brushes.Black, 380, X)
        End If
        X += 16
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 380, X)
        X += 32
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 380, X)
        X += 16
        e.Graphics.DrawString(nLec_Ante, sfont, Brushes.Black, 350, X)
        e.Graphics.DrawString(nLec_Actu, sfont, Brushes.Black, 430, X)
        X += 16
        e.Graphics.DrawString(nCon_M3, sfont, Brushes.Black, 350, X)

        X = 285
        If nImp_Fijo > 0 Then
            e.Graphics.DrawString("Importe consumo Fijo", sfont, Brushes.Black, 50, X)
            e.Graphics.DrawString(Format(nImp_Fijo, "#0.00"), sfont, Brushes.Black, 440, X, Alim)
        End If

        If nImp_Adic > 0 Then
            X += 12
            e.Graphics.DrawString("Importe consumo Excedente", sfont, Brushes.Black, 50, X)
            e.Graphics.DrawString(Format(nImp_Adic, "#0.00"), sfont, Brushes.Black, 440, X, Alim)
        End If

        X += 12
        e.Graphics.DrawString("SUBTOTAL SERVICIO DE AGUA", nFont, Brushes.Black, 50, X)
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic, "#0.00"), nFont, Brushes.Black, 440, X, Alim)

        If nImp_Alca > 0 Then
            X += 12
            e.Graphics.DrawString("Alcantarrillado", sfont, Brushes.Black, 50, X)
            e.Graphics.DrawString(Format(nImp_Alca, "#0.00"), sfont, Brushes.Black, 440, X, Alim)
        End If

        If nImp_Reca > 0 Then
            X += 12
            e.Graphics.DrawString("Recargos", sfont, Brushes.Black, 50, X)
            e.Graphics.DrawString(Format(nImp_Reca, "#0.00"), sfont, Brushes.Black, 440, X, Alim)
        End If

        If nImp_Repo Then
            X += 12
            e.Graphics.DrawString("Rep. de formulario", sfont, Brushes.Black, 50, X)
            e.Graphics.DrawString(Format(nImp_Repo, "#0.00"), sfont, Brushes.Black, 440, X, Alim)
        End If

        X += 12
        e.Graphics.DrawString("TOTAL SERVICIOS", nFont, Brushes.Black, 50, X)
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic + nImp_Alca + nImp_Reca + nImp_Repo, "#0.00"), nFont, Brushes.Black, 440, X, Alim)

        If nImp_Ser1 > 0 Then
            X += 12
            e.Graphics.DrawString("Cargo 1 Servicio de agua potable", sfont, Brushes.Black, 50, X)
            e.Graphics.DrawString(Format(nImp_Ser1, "#0.00"), sfont, Brushes.Black, 440, X, Alim)
        End If

        If nImp_Ser2 > 0 Then
            X += 12
            e.Graphics.DrawString("Cargo 2 Servicio de Alcantarrillado", sfont, Brushes.Black, 50, X)
            e.Graphics.DrawString(Format(nImp_Ser2, "#0.00"), sfont, Brushes.Black, 440, X, Alim)
        End If

        If nImp_Ley1 > 0 Then
            X += 12
            e.Graphics.DrawString("MENOS: Descuento Ley 1886", sfont, Brushes.Black, 50, X)
            e.Graphics.DrawString(Format((nImp_Ley1 + nImp_Ley2), "#0.00"), sfont, Brushes.Black, 440, X, Alim)
        End If

        If nImp_Descuento > 0 Then
            X += 12
            e.Graphics.DrawString("DESCUENTO 50% D.S. 4206 - Consumo", sfont, Brushes.Black, 50, X)
            e.Graphics.DrawString(Format(nImp_Descuento, "#0.00"), sfont, Brushes.Black, 440, X, Alim)
        End If

        If nImp_AlcanDesc > 0 Then
            X += 12
            e.Graphics.DrawString("DESCUENTO 50% D.S. 4206 - Alcantarrillado", sfont, Brushes.Black, 50, X)
            e.Graphics.DrawString(Format(nImp_AlcanDesc, "#0.00"), sfont, Brushes.Black, 440, X, Alim)
        End If

        If nImp_Descuento > 0 Then
            X += 12
            e.Graphics.DrawString("Ley No 1294 de 1 de abril de 2020", sfont, Brushes.Black, 30, X)
        End If
        X = 415
        e.Graphics.DrawString(Format(nImp_Fact, "#0.00"), nFont, Brushes.Black, 440, X, Alim)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, X)
        X += 20
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawString(dFecFin, sfont, Brushes.Black, 400, X)
        X += 20
        e.Graphics.DrawString(nFactura, sfont, Brushes.Black, 400, X)
        e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 580, 400, 75, 75)
        e.Graphics.DrawString(_Usuario, sfont, Brushes.Black, 580, 515)
        e.Graphics.DrawString(Date.Now, sfont, Brushes.Black, 580, 530)
        X += 40

        e.Graphics.DrawString("LEY 453: " & cLey453, sfont, Brushes.Black, EspacioLey)

        For y = 0 To ds.Tables("FHis").Rows.Count - 1
            X = 155 + (20 * y)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Emision"), "MMM/yyyy"), sfont, Brushes.Black, 475, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Con_m3"), "0000"), sfont, Brushes.Black, 520, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Imp_Factura"), "#0.00"), sfont, Brushes.Black, 560, X)
            e.Graphics.DrawString(Format(ds.Tables("FHis").Rows(y).Item("Fec_Pago"), "dd/MM/yyyy"), sfont, Brushes.Black, 610, X)
        Next

            '----------- copia -------------

        X = 95
        e.Graphics.DrawString(nNum_Factura, sfont, Brushes.Black, 750, X)
        X += 10
        e.Graphics.DrawString(nNum_Autorizacion, sfont, Brushes.Black, 700, X)

        X += 50
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 700, X)
        X += 10
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 720, X)
        X += 15
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 750, X)
        X += 15
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 750, X)

        X += 30
        If dMesAno = CDate("04/07/2011") Then
            e.Graphics.DrawString("JUN2011", sfont, Brushes.Black, 750, X)
        Else
            e.Graphics.DrawString(Format(dMesAno, "MMMM - yyyy"), sfont, Brushes.Black, 750, X)
        End If
        X += 15
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 750, X)
        X += 30
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 750, X)
        X += 35
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic, "#0.00"), sfont, Brushes.Black, 790, X, Alim)
        X += 12
        e.Graphics.DrawString(Format(nImp_Alca, "#0.00"), sfont, Brushes.Black, 790, X, Alim)
        X += 12
        e.Graphics.DrawString(Format(nImp_Reca, "#0.00"), sfont, Brushes.Black, 790, X, Alim)
        X += 12
        e.Graphics.DrawString(Format(nImp_Repo, "#0.00"), sfont, Brushes.Black, 790, X, Alim)
        X += 12
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic + nImp_Alca + nImp_Reca + nImp_Repo, "#0.00"), nFont, Brushes.Black, 790, X, Alim)
        X += 12
        e.Graphics.DrawString(Format((nImp_Ley1 + nImp_Ley2), "#0.00"), sfont, Brushes.Black, 790, X, Alim)
        X += 12
        e.Graphics.DrawString(Format((nImp_Descuento), "#0.00"), sfont, Brushes.Black, 790, X, Alim)
        X += 12
        e.Graphics.DrawString(Format((nImp_AlcanDesc), "#0.00"), sfont, Brushes.Black, 790, X, Alim)
        X += 15
        e.Graphics.DrawString(Format(nImp_Fact, "#0.00"), nFont, Brushes.Black, 790, X, Alim)

        e.Graphics.DrawString(_Usuario, sfont, Brushes.Black, 700, 450)
        e.Graphics.DrawString(Date.Now, sfont, Brushes.Black, 700, 465)
    End Sub


    Private Sub ImpFactMatMed_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles ImpFactMatMed.PrintPage
        Dim sfont As New System.Drawing.Font("Arial Narrow", 8)
        Dim nFont As New Font("Arial Narrow", 10, FontStyle.Bold)
        Dim costosize As New System.Drawing.SizeF
        Dim TofaSize As New System.Drawing.SizeF
        '---------------------------------------
        Dim dMesAno As Date
        Dim nFactura As Double
        Dim nNum_Factura As Double
        Dim nNum_Autorizacion As Double
        Dim xNombre As String
        Dim cNit As Double
        Dim cDireccion As String
        Dim nAbonado As Double
        Dim cCategoria As String
        Dim Fec_Pago As Date
        Dim Fec_Emision As Date
        Dim cLiteral As String
        Dim cCodContr As String
        Dim X, y, i As Integer
        Dim nImp_Fac As Double
        Dim nImp_Cos As Double

        Dim generarCodigoQR As QRCodeEncoder = New QRCodeEncoder
        Dim txtCodigoQr As String

        generarCodigoQR.QRCodeEncodeMode = Codec.QRCodeEncoder.ENCODE_MODE.BYTE
        generarCodigoQR.QRCodeScale = Int32.Parse(6)
        generarCodigoQR.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H
        generarCodigoQR.QRCodeVersion = 0
        generarCodigoQR.QRCodeBackgroundColor = System.Drawing.Color.FromArgb(colorFondoQR)
        generarCodigoQR.QRCodeForegroundColor = System.Drawing.Color.FromArgb(colorQR)

        '------------------------------------
        dMesAno = ds.Tables("FREp").Rows(0).Item("Emision")
        nNum_Factura = ds.Tables("FRep").Rows(0).Item("Num_Factura")
        nNum_Autorizacion = ds.Tables("FRep").Rows(0).Item("Num_Orden")
        xNombre = TxUsuario.Text  'ds.Tables("FRep").Rows(0).Item("Razon")
        cNit = TxNIT.Text  'ds.Tables("FRep").Rows(0).Item("Nit")
        cDireccion = TxZona.Text  'ds.Tables("FRep").Rows(0).Item("Zona")
        nAbonado = cboAbonado.SelectedValue  'ds.Tables("FRep").Rows(0).Item("Abonado")
        cCategoria = TxCategoria.Text  'ds.Tables("FRep").Rows(0).Item("Categoria")
        Fec_Pago = ds.Tables("FRep").Rows(0).Item("Fec_Pago")
        Fec_Emision = ds.Tables("FRep").Rows(0).Item("Emision")
        nImp_Fac = ds.Tables("Frep").Rows(0).Item("Imp_Factura")
        cLiteral = Literal(nImp_Fac, "M")
        cCodContr = ds.Tables("FRep").Rows(0).Item("Codigo_Control")
        nFactura = ds.Tables("Frep").Rows(0).Item("Factura")
        '----------------------------

        txtCodigoQr = "1023807025|" & _
        nNum_Factura.ToString & "|" & nNum_Autorizacion.ToString & "|" & _
        ds.Tables("Frep").Rows(0).Item("Emision") & "|" & nImp_Fac.ToString & "|" & _
        nImp_Fac.ToString & "|" & cCodContr & "|" & cNit & "|0|0|0|0"


        TofaSize = e.Graphics.MeasureString(Format(nImp_Fac, "#0.00"), nFont)

        X = 25
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 550, X)
        X += 15
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 550, X)

        X = 150
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, X)
        X += 15
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, X)
        X += 15
        e.Graphics.DrawString(cDireccion, sfont, Brushes.Black, 100, X)
        X += 15
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, X)
        X += 30
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 100, X)

        X = 150
        e.Graphics.DrawString(Format(dMesAno, "MMMM - yyyy"), sfont, Brushes.Black, 450, X)
        X += 15
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)
        X += 30
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, X)

        '--------------------detalle-------------------------
        X = 285
        For i = 0 To ds.Tables("Frep").Rows.Count - 1
            X += 12
            nImp_Cos = ds.Tables("Frep").Rows(i).Item("Costo")
            costosize = e.Graphics.MeasureString(FormatNumber(nImp_Cos, 2), sfont)
            e.Graphics.DrawString(ds.Tables("Frep").Rows(i).Item("Descripcion"), sfont, Brushes.Black, 150, X)
            e.Graphics.DrawString(FormatNumber(nImp_Cos, 2), sfont, Brushes.Black, (400 - costosize.Width), X)
        Next
        '-------------------- fin detalle --------------------
        X = 420
        e.Graphics.DrawString(Format(nImp_Fac, "#0.00"), nFont, Brushes.Black, (400 - TofaSize.Width), X)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, X)
        X += 20
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, X)
        e.Graphics.DrawString(Fecha_Final, sfont, Brushes.Black, 450, X)
        X += 20
        e.Graphics.DrawString(nFactura, sfont, Brushes.Black, 400, X)
        e.Graphics.DrawImage(generarCodigoQR.Encode(txtCodigoQr), 580, 400, 75, 75)
        X += 30
        'e.Graphics.DrawString(cley453, sfont, Brushes.Black, 50, X)
        e.Graphics.DrawString(_Usuario, sfont, Brushes.Black, 580, 510)
        e.Graphics.DrawString(Date.Now, sfont, Brushes.Black, 580, 530)

        '---------------------- copia ----------------------
        X = 95
        e.Graphics.DrawString(nNum_Factura, sfont, Brushes.Black, 750, X)
        X += 10
        e.Graphics.DrawString(nNum_Autorizacion, sfont, Brushes.Black, 700, X)

        X += 50
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 700, X)
        X += 10
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 720, X)
        X += 15
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 750, X)
        X += 15
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 750, X)

        X += 30
        e.Graphics.DrawString(Format(dMesAno, "MMMM - yyyy"), sfont, Brushes.Black, 750, X)
        X += 15
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 750, X)
        X += 30
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 750, X)

        X += 35
        e.Graphics.DrawString(FormatNumber(nImp_Cos, 2), sfont, Brushes.Black, (790 - costosize.Width), X)
        X = 400
        e.Graphics.DrawString(Format(nImp_Fac, "#0.00"), nFont, Brushes.Black, (790 - TofaSize.Width), X)
        e.Graphics.DrawString(_Usuario, sfont, Brushes.Black, 700, 450)
        e.Graphics.DrawString(Date.Now, sfont, Brushes.Black, 700, 465)
    End Sub

End Class