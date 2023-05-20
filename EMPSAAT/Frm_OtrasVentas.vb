Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_OtrasVentas
    Dim db As New SqlConnection(cn)
    Dim daSer As New SqlDataAdapter("", db)
    Dim daFac As New SqlDataAdapter("", db)
    Dim dsTab As New DataSet

    Dim nNumAuto As Int64
    Dim cLlave As String
    Dim dLimite As Date
    Dim nNumFact As Int64
    Dim nNumInic As Int64
    Dim nNumCorr As Int64

    Dim nNum_Factura As Double
    Dim nNum_Autorizacion As Double
    Dim xNombre As String
    Dim cNit As Double
    Dim nAbonado As Double
    Dim Fec_Emision
    Dim Fec_Pago
    Dim nImp_Cargo_1 As Double
    Dim nImp_Cargo_2 As Double
    Dim nImp_Repos As Double
    Dim nImp_Factura As Double
    Dim cLiteral As String
    Dim cCodContr As String

    Private Sub Frm_OtrasVentas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DpFecha.Value = Date.Now
        Call Actualizar_Datos()
    End Sub

    Private Sub Actualizar_Datos()
        dsTab.Tables.Clear()
        daSer.SelectCommand.CommandText = "Select Abonado, Nombre From Usuarios Where Abonado In (Select Abonado From Servicios_Solicitud Where Costo > 0 And Estado = 0)"
        '"Select Distinct(S.Abonado) From Servicios_Solicitud S" ' On U.Abonado = S.Abonado) Where S.Costo > 0 And S.Cobrado = False" ' Inner Join Servicios_Lista L On S.Servicio = L.Servicio) Where S.Costo > 0 And S.Cobrado = False"
        dsTab.Clear()
        daSer.Fill(dsTab, "ServiciosXCobrar")
        DgServicios.DataSource = dsTab.Tables(0)
        Call Formatear_Tabla_Servicios_x_Cobrar()

        daFac.SelectCommand.CommandText = "Select * From Facturas_Otras_Ventas Where Fecha = '" & Format(DpFecha.Value, "MM/dd/yyyy") & "' Order By Numero_Correlativo"
        daFac.Fill(dsTab, "FacturasOtrasVentas")
        DgFacturas.DataSource = dsTab.Tables(1)
        Call Formatear_Tabla_Facturas()

        'dsTab.Tables(2).Clear()
        daFac.SelectCommand.CommandText = "Select Count(Numero_Factura) From Facturas_Otras_Ventas Where Fecha = '" & Format(DpFecha.Value, "MM/dd/yyyy") & "' And Estado = 'V'"
        daFac.Fill(dsTab, "NumFacValidas")
        TxtNoValidas.Text = dsTab.Tables(2).Rows(0).Item(0)

        'dsTab.Tables(3).Clear()
        daFac.SelectCommand.CommandText = "Select Count(Numero_Factura) From Facturas_Otras_Ventas Where Fecha = '" & Format(DpFecha.Value, "MM/dd/yyyy") & "' And Estado = 'A'"
        daFac.Fill(dsTab, "NumFacAnuladas")
        TxtNoAnuladas.Text = dsTab.Tables(3).Rows(0).Item(0)

        'dsTab.Tables(4).Clear()
        daFac.SelectCommand.CommandText = "Select Sum(Importe) From Facturas_Otras_Ventas Where Fecha = '" & Format(DpFecha.Value, "MM/dd/yyyy") & "' And Estado = 'V'"
        daFac.Fill(dsTab, "TotFacValidas")
        If dsTab.Tables(4).Rows.Count > 0 Then
            If Not IsDBNull(dsTab.Tables(4).Rows(0).Item(0)) Then
                TxtTotValidas.Text = Format(dsTab.Tables(4).Rows(0).Item(0), "#0.00")
            Else
                TxtTotValidas.Text = "0.00"
            End If
        Else
            TxtTotValidas.Text = "0.00"
        End If

        'dsTab.Tables(5).Clear()
        daFac.SelectCommand.CommandText = "Select Sum(Importe) From Facturas_Otras_Ventas Where Fecha = '" & Format(DpFecha.Value, "MM/dd/yyyy") & "' And Estado = 'A'"
        daFac.Fill(dsTab, "TotFacAnuladas")

        If dsTab.Tables(5).Rows.Count > 0 Then
            If Not IsDBNull(dsTab.Tables(5).Rows(0).Item(0)) Then
                TxtTotAnuladas.Text = Format(dsTab.Tables(5).Rows(0).Item(0), "#0.00")
            Else
                TxtTotAnuladas.Text = "0.00"
            End If
        Else
            TxtTotAnuladas.Text = "0.00"
        End If
    End Sub

    Private Sub Formatear_Tabla_Facturas()
        Dim dt As New DataGridTableStyle
        dt.MappingName = "FacturasOtrasVentas"

        Dim c1 As New DataGridTextBoxColumn
        c1.MappingName = "Numero_Autorizacion"
        c1.HeaderText = "Nro. Autorizacion"
        c1.ReadOnly = True
        c1.Alignment = HorizontalAlignment.Right
        c1.Width = 100
        dt.GridColumnStyles.Add(c1)

        Dim c2 As New DataGridTextBoxColumn
        c2.MappingName = "Numero_Factura"
        c2.HeaderText = "Nro. Factura"
        c2.ReadOnly = True
        c2.Alignment = HorizontalAlignment.Right
        c2.Width = 100
        dt.GridColumnStyles.Add(c2)

        Dim c3 As New DataGridTextBoxColumn
        c3.MappingName = "Codigo_Control"
        c3.HeaderText = "Cod. Control"
        c3.ReadOnly = True
        c3.Width = 100
        dt.GridColumnStyles.Add(c3)

        Dim c8 As New DataGridTextBoxColumn
        c8.MappingName = "Fecha"
        c8.HeaderText = "Fecha"
        c8.ReadOnly = True
        c8.Width = 100
        c8.Format = "dd/MMM/yyyy"
        dt.GridColumnStyles.Add(c8)

        Dim c4 As New DataGridTextBoxColumn
        c4.MappingName = "Abonado"
        c4.HeaderText = "Abonado"
        c4.ReadOnly = True
        c4.Width = 60
        dt.GridColumnStyles.Add(c4)

        Dim c5 As New DataGridTextBoxColumn
        c5.MappingName = "Nombre"
        c5.HeaderText = "Nombre"
        c5.ReadOnly = True
        c5.Width = 200
        dt.GridColumnStyles.Add(c5)

        Dim c6 As New DataGridTextBoxColumn
        c6.MappingName = "Nit"
        c6.HeaderText = "NIT / CI"
        c6.ReadOnly = True
        c6.Width = 60
        dt.GridColumnStyles.Add(c6)

        Dim c7 As New DataGridTextBoxColumn
        c7.MappingName = "Importe"
        c7.HeaderText = "Importe"
        c7.ReadOnly = True
        c7.Alignment = HorizontalAlignment.Right
        c7.Format = "#0.00"
        c7.Width = 60
        dt.GridColumnStyles.Add(c7)

        Dim c9 As New DataGridTextBoxColumn
        c9.MappingName = "Estado"
        c9.HeaderText = "Estado"
        c9.ReadOnly = True
        c9.Width = 60
        dt.GridColumnStyles.Add(c9)

        DgFacturas.TableStyles.Clear()
        DgFacturas.TableStyles.Add(dt)
    End Sub

    Private Sub Formatear_Tabla_Servicios_x_Cobrar()
        Dim dt As New DataGridTableStyle
        dt.MappingName = "ServiciosXCobrar"

        Dim c1 As New DataGridTextBoxColumn
        c1.MappingName = "Abonado"
        c1.HeaderText = "Abonado"
        c1.ReadOnly = True
        c1.Width = 60
        dt.GridColumnStyles.Add(c1)

        Dim c2 As New DataGridTextBoxColumn
        c2.MappingName = "Nombre"
        c2.HeaderText = "Usuario"
        c2.ReadOnly = True
        c2.Width = 600
        dt.GridColumnStyles.Add(c2)

        DgServicios.TableStyles.Clear()
        DgServicios.TableStyles.Add(dt)
    End Sub

    Private Sub Emitir_Factura(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEmitir.Click
        Dim nAbonado As Int64 = DgServicios.Item(DgServicios.CurrentRowIndex, 0)
        Panel4.Visible = True

        'Dim da As New sqlDataAdapter(
        daFac.SelectCommand.CommandText = "Select Abonado, Nombre, Nit, Zona, Calle From Usuarios Where Abonado = " & nAbonado
        daFac.Fill(dsTab, "Usuario")
        If dsTab.Tables("Usuario").Rows.Count > 0 Then
            TxtAbonado.Text = nAbonado
            TxtUsuario.Text = IIf(IsDBNull(dsTab.Tables("Usuario").Rows(0).Item("Nombre")), "", dsTab.Tables("Usuario").Rows(0).Item("Nombre"))
            TxtNit.Text = IIf(IsDBNull(dsTab.Tables("Usuario").Rows(0).Item("Nit")), 0, dsTab.Tables("Usuario").Rows(0).Item("Nit"))
            TxtDireccion.Text = IIf(IsDBNull(dsTab.Tables("Usuario").Rows(0).Item("Zona")), "", dsTab.Tables("Usuario").Rows(0).Item("Zona"))
        Else
            Exit Sub
        End If

        daFac.SelectCommand.CommandText = "Select S.NoSolicitud, S.Fecha, S.Servicio, L.Descripcion, S.Costo From (Servicios_Solicitud S Inner Join Servicios_Lista L On S.Servicio = L.Servicio) Where S.Abonado = " & nAbonado & " And S.Cobrado = 0 And S.Costo > 0 And S.Anulado = 0"
        daFac.Fill(dsTab, "Serv_Usua")
        dsTab.Tables("Serv_Usua").Clear()
        daFac.SelectCommand.CommandText = "Select S.NoSolicitud, S.Fecha, S.Servicio, L.Descripcion, S.Costo From (Servicios_Solicitud S Inner Join Servicios_Lista L On S.Servicio = L.Servicio) Where S.Abonado = " & nAbonado & " And S.Cobrado = 0 And S.Costo > 0 And S.Anulado = 0"
        daFac.Fill(dsTab, "Serv_Usua")

        dgDetalle.DataSource = dsTab.Tables("Serv_Usua")

        daFac.SelectCommand.CommandText = "Select Sum(Costo) as Total From Servicios_Solicitud Where Abonado = " & nAbonado & " And Cobrado = 0 And Costo > 0 And Anulado = 0"
        daFac.Fill(dsTab, "SumaTotal")
        If dsTab.Tables("SumaTotal").Rows.Count > 0 Then
            If Not IsDBNull(dsTab.Tables("SumaTotal").Rows(0).Item("Total")) Then
                txtTotal.Text = Format(dsTab.Tables("SumaTotal").Rows(0).Item("Total"), "#0.00")
            End If
        Else
            txtTotal.Clear()
        End If
        dsTab.Tables("SumaTotal").Clear()
        Call Formatear_Detalle_FActura()
    End Sub

    Private Sub Formatear_Detalle_FActura()
        Dim dt As New DataGridTableStyle
        dt.MappingName = "Serv_Usua"

        Dim c1 As New DataGridTextBoxColumn
        c1.MappingName = "NoSolicitud"
        c1.HeaderText = "Solicitud"
        c1.ReadOnly = True
        c1.Width = 60
        c1.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c1)

        Dim c2 As New DataGridTextBoxColumn
        c2.MappingName = "Fecha"
        c2.HeaderText = "Fecha"
        c2.Format = "dd/MM/yyyy"
        c2.ReadOnly = True
        c2.Width = 70
        dt.GridColumnStyles.Add(c2)

        Dim c3 As New DataGridTextBoxColumn
        c3.MappingName = "Servicio"
        c3.HeaderText = "Servicio"
        c3.ReadOnly = True
        c3.Width = 70
        dt.GridColumnStyles.Add(c3)

        Dim c4 As New DataGridTextBoxColumn
        c4.MappingName = "Descripcion"
        c4.HeaderText = "Servicio"
        c4.Alignment = HorizontalAlignment.Left
        c4.ReadOnly = True
        c4.Width = 250
        dt.GridColumnStyles.Add(c4)

        Dim c5 As New DataGridTextBoxColumn
        c5.MappingName = "Costo"
        c5.HeaderText = "Costo"
        c5.Format = "#0.00"
        c5.ReadOnly = True
        c5.Width = 70
        c5.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c5)

        dgDetalle.TableStyles.Clear()
        dgDetalle.TableStyles.Add(dt)
    End Sub


    Private Sub Imprimir_Detalle(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimirDetalle.Click
        Dim cmdImp As New SqlCommand
        Dim cTex As String
        db.Open()
        cTex = "Drop Table Rep_Facturas_Otras_Ventas"
        With cmdImp
            .Connection = db
            .CommandType = CommandType.Text
            .CommandText = cTex
            .ExecuteNonQuery()
        End With

        cTex = "Select * Into Rep_Facturas_Otras_Ventas From Facturas_Otras_Ventas Where Fecha = #" & Format(DpFecha.Value, "MM/dd/yyyy") & "#"
        With cmdImp
            .Connection = db
            .CommandType = CommandType.Text
            .CommandText = cTex
            .ExecuteNonQuery()
        End With
        Dim fRep As New Frm_Reportes
        'Dim cRep As New Rep_Diario_Facturas_Otras_Ventas
        'fRep.crvRep.ReportSource = cRep
        fRep.ShowDialog()
        db.Close()
    End Sub

    Private Sub Ver_Detalle(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVerDetalle.Click
        Call Actualizar_Datos()
    End Sub

    Private Sub Anular_Factura(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnularFactura.Click
        Dim aNumAutorizacion As Double = DgFacturas.Item(DgFacturas.CurrentRowIndex, 0)
        Dim aNumFactura As Double = DgFacturas.Item(DgFacturas.CurrentRowIndex, 1)
        Dim cTex As String = "UPDATE Facturas_Otras_Ventas Set Estado = 'A' Where Numero_Autorizacion = " & aNumAutorizacion & " And Numero_Factura = " & aNumFactura

        Dim cmdAnula As New SqlCommand
        db.Open()
        With cmdAnula
            .Connection = db
            .CommandType = CommandType.Text
            .CommandText = cTex
            .ExecuteNonQuery()
        End With
        cTex = "UPDATE Servicios_Solicitud Set Cobrado = False, Factura = 0 Where Factura = " & aNumFactura
        With cmdAnula
            .Connection = db
            .CommandType = CommandType.Text
            .CommandText = cTex
            .ExecuteNonQuery()
        End With
        db.Close()
        Call Actualizar_Datos()
        MessageBox.Show("Se ha anulado correctamente la Factura Nro. = " & aNumFactura, "Proceso terminado con exito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Grabar_Factura(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Dim dsF As New DataSet
        Dim nNumOrde As Double
        Dim nCodServ As Double
        Dim cDescrip As String
        Dim nImporte As Double

        '------------ Obtener numero de factura ------------------------

        If pNum_Autorizacion = 0 Then
            MessageBox.Show("No existe dosificación de facturas", "Debe registrar dosificacion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim daG As New SqlDataAdapter("Select NoFinal From Dosificacion Where Activado = True", db)
        daG.Fill(dsF, "Dosis")
        If dsF.Tables("Dosis").Rows.Count > 0 Then
            nNumFact = dsF.Tables("Dosis").Rows(0).Item("NoFinal") + 1
        Else
            MessageBox.Show("No existe dosificación de facturas", "Debe registrar dosificacion de facturas", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        daG.SelectCommand.CommandText = "Select Max(Numero_Correlativo) From Facturas_Otras_Ventas"
        dsF.Tables.Clear()
        daG.Fill(dsF, "NoCo")
        If dsF.Tables("NoCo").Rows.Count > 0 Then
            If IsDBNull(dsF.Tables("NoCo").Rows(0).Item(0)) Then
                nNumCorr = 1
            Else
                nNumCorr = dsF.Tables("NoCo").Rows(0).Item(0) + 1
            End If
        Else
            nNumCorr = 1
        End If

        '------------ Obtener datos de la factura ----------------------
        Dim nAbonado As Double = TxtAbonado.Text
        Dim nNit As Double = TxtNit.Text
        Dim cNombre As String = TxtUsuario.Text
        Dim CodigoControl As String
        Dim nLiteral As String = Literal(Val(txtTotal.Text), "M")
        Dim nTotal As Double = Val(txtTotal.Text)
        Dim nDebito As Decimal = (Val(txtTotal.Text) * 0.13)
        Dim nNeto As Decimal = (nTotal - nDebito)
        Dim CodCon As New CodigoV7

        CodCon.NoAutorizacion = pNum_Autorizacion
        CodCon.NoFactura = nNumFact
        CodCon.NoNit = nNit
        CodCon.Fecha = Format(Date.Now, "dd/MM/yyyy")
        CodCon.Importe = Val(txtTotal.Text)
        'CodCon.Llave = pLlave
        CodigoControl = CodCon.Codigo

        nNum_Factura = nNumFact
        nNum_Autorizacion = pNum_Autorizacion
        xNombre = TxtUsuario.Text
        cNit = Val(TxtNit.Text)
        nAbonado = TxtAbonado.Text
        Fec_Emision = Date.Now
        Fec_Pago = Date.Now
        nImp_Factura = nTotal
        cLiteral = nLiteral
        cCodContr = CodigoControl

        '= ObtenerCodigo(pNum_Autorizacion, nNumFact, nNit, Format(Date.Now, "dd/MM/yyyy"), Val(txtTotal.Text), pLlave)

        '------------ realizar nueva factura ---------------------------
        Dim CmdFact As New SqlCommand
        Dim i As Integer
        Dim text As String
        text = "Insert into Facturas_Otras_Ventas (Numero_Correlativo, Numero_Autorizacion, Numero_Factura, Codigo_Control, Abonado, Nombre, Nit, Fecha, Importe, Estado, Debito, Neto, Comprobante) values ("
        text = text & "'" & nNumCorr & "','" & pNum_Autorizacion & "','" & nNumFact & "','" & CodigoControl & "','" & nAbonado & "','" & cNombre & "','" & nNit & "','" & Format(Date.Now, "dd/MM/yyyy") & "','" & nTotal & "','V','" & nDebito & "','" & nNeto & "','" & pNum_Comprobante & "')"

        db.Open()
        With CmdFact
            .Connection = db
            .CommandType = CommandType.Text
            .CommandText = text
            .ExecuteNonQuery()
        End With

        text = "Update Dosificacion Set NoFinal = " & nNumFact & " Where Autorizacion = " & pNum_Autorizacion

        With CmdFact
            .Connection = db
            .CommandType = CommandType.Text
            .CommandText = text
            .ExecuteNonQuery()
        End With

        For i = 0 To dsTab.Tables("Serv_Usua").Rows.Count - 1
            nNumOrde = dgDetalle.Item(i, 0)
            nCodServ = dgDetalle.Item(i, 2)
            cDescrip = dgDetalle.Item(i, 3)
            nImporte = dgDetalle.Item(i, 4)

            text = "INSERT into Facturas_Otras_Ventas_Detalle (Numero_Correlativo, Cantidad, Servicio, Descripcion, Precio_Unitario, Precio_Total) Values ("
            text = text & "'" & nNumCorr & "','" & nNumOrde & "','" & nCodServ & "','" & cDescrip & "','" & nImporte & "','" & nImporte & "')"
            With CmdFact
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = text
                .ExecuteNonQuery()
            End With
            '------------ colocar bandera en orden de servicio -------------
            text = "UPDATE Servicios_Solicitud Set Cobrado = True, Factura = " & nNumFact & " Where NoSolicitud = " & nNumOrde
            With CmdFact
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = text
                .ExecuteNonQuery()
            End With

            If nCodServ < 2000 Then
                nImp_Cargo_1 = nImp_Cargo_1 + nImporte
            ElseIf nCodServ > 1999 And nCodServ < 3000 Then
                nImp_Cargo_2 = nImp_Cargo_2 + nImporte
            Else
                nImp_Repos = nImp_Repos + nImporte
            End If
        Next

        db.Close()

        Imp.Print()

        Call Actualizar_Datos()
        Panel4.Visible = False
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Panel4.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Imp_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Imp.PrintPage
        Dim sfont As New System.Drawing.Font("Arial Narrow", 9)
        Dim nFont As New Font("Arial Narrow", 10, FontStyle.Bold)
        Dim reposize As New System.Drawing.SizeF
        Dim ser1size As New System.Drawing.SizeF
        Dim ser2size As New System.Drawing.SizeF
        Dim tofasize As New System.Drawing.SizeF


        reposize = e.Graphics.MeasureString(Format(nImp_Repos, "#0.00"), sfont)
        ser1size = e.Graphics.MeasureString(Format(nImp_Cargo_1, "#0.00"), sfont)
        ser2size = e.Graphics.MeasureString(Format(nImp_Cargo_2, "#0.00"), sfont)
        tofasize = e.Graphics.MeasureString(Format(nImp_Factura, "#0.00"), nFont)

        'e.Graphics.DrawString("1023807025", nFont, Brushes.Black, 450, 10)
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 460, 40)
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 460, 55)

        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, 165)
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, 180)
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, 195)

        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, 180)
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, 210)

        e.Graphics.DrawString("Reposicion de Formulario", sfont, Brushes.Black, 120, 330)
        e.Graphics.DrawString("Servicios de Agua Potable", sfont, Brushes.Black, 120, 345)
        e.Graphics.DrawString("Servicios de Alcantarrillado", sfont, Brushes.Black, 120, 360)

        e.Graphics.DrawString(Format(nImp_Repos, "#0.00"), sfont, Brushes.Black, (520 - reposize.Width), 330)
        e.Graphics.DrawString(Format(nImp_Cargo_1, "#0.00"), sfont, Brushes.Black, (520 - ser1size.Width), 345)
        e.Graphics.DrawString(Format(nImp_Cargo_2, "#0.00"), sfont, Brushes.Black, (520 - ser2size.Width), 360)

        e.Graphics.DrawString(Format(nImp_Factura, "#0.00"), nFont, Brushes.Black, (520 - tofasize.Width), 518)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, 518)
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, 532)
        e.Graphics.DrawString(pFec_Final, sfont, Brushes.Black, 450, 532)



        '------------ COPIA ------------
        'e.Graphics.DrawString("1023807025", nFont, Brushes.Black, 450, 555)
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 460, 688)
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 460, 700)
        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, 820)
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, 835)
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, 865)
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, 835)
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, 865)


        e.Graphics.DrawString("Reposicion de Formulario", sfont, Brushes.Black, 120, 975)
        e.Graphics.DrawString("Servicios de Agua Potable", sfont, Brushes.Black, 120, 990)
        e.Graphics.DrawString("Servicios de Alcantarrillado", sfont, Brushes.Black, 120, 1005)

        e.Graphics.DrawString(Format(nImp_Repos, "#0.00"), sfont, Brushes.Black, (520 - reposize.Width), 975)
        e.Graphics.DrawString(Format(nImp_Cargo_1, "#0.00"), sfont, Brushes.Black, (520 - ser1size.Width), 990)
        e.Graphics.DrawString(Format(nImp_Cargo_2, "#0.00"), sfont, Brushes.Black, (520 - ser2size.Width), 1005)

        e.Graphics.DrawString(Format(nImp_Factura, "#0.00"), nFont, Brushes.Black, (550 - tofasize.Width), 1163)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, 1163)
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, 1181)
        e.Graphics.DrawString(pFec_Final, sfont, Brushes.Black, 450, 1181)
    End Sub

    Private Sub BtnAnularOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnularOrden.Click

    End Sub
End Class