Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_ReporteLibrosIva
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub Frm_ReporteLibrosIva_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'da.SelectCommand.CommandText = "Select Top 4 Emision From Factores Order By Emision Desc"
        'da.Fill(ds, "Periodos")
        'cboPeriodo.DataSource = ds.Tables("Periodos")
        'cboPeriodo.DisplayMember = ds.Tables("Periodos").Columns(0).ColumnName
        'cboPeriodo.ValueMember = ds.Tables("Periodos").Columns(0).ColumnName

        dtInicial.Value = Date.Now
        dtFinal.Value = Date.Now
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
        Dim i As Integer
        Dim txt As String
        Dim nNit As Double
        Dim nAbonado As Int64
        Dim nRazonSocial As String = ""
        Dim nNum_Factura As Double
        Dim nNum_Autorizacion As Double
        Dim nEmision As Date
        Dim nImp_Factura As Double
        Dim nImp_Ice As Double
        Dim nImp_Excentos As Double
        Dim nImp_TasaCero As Double
        Dim nImp_Subtotal As Double
        Dim nImp_Descuentos As Double
        Dim nImp_Neto As Double
        Dim nImp_Debito As Double
        Dim nEstado As String = ""
        Dim nCodigo_Control As String = ""

        Dim nImp_Neto_Suma As Double
        Dim nImp_Debito_Suma As Double
        Dim nNum_Validas As Integer
        Dim nNum_Anuladas As Integer
        Dim dFec_Ini As Date
        Dim dFec_Fin As Date

        Dim TXTNOM As String

        Try
            Progreso.Visible = True

            dFec_Ini = dtInicial.Value  '"01/" & CDate(cboPeriodo.SelectedValue).Month & "/" & CDate(cboPeriodo.SelectedValue).Year
            dFec_Fin = dtFinal.Value  'DateAdd(DateInterval.Day, -1, DateAdd(DateInterval.Month, 1, dFec_Ini))

            
            da.SelectCommand.CommandText = "SELECT * FROM LIBRO WHERE FECHA BETWEEN '" & FormatDateTime(dFec_Ini, DateFormat.ShortDate) & " 00:00:00' and '" & FormatDateTime(dFec_Fin, DateFormat.ShortDate) & " 23:59:59' ORDER BY FACTURA"
            da.Fill(ds, "Fac")


            Exportar(ds.Tables("Fac"))
            Exit Sub

            sfArchivos.ShowDialog()

            TXTNOM = sfArchivos.FileName

            FileOpen(1, TXTNOM, OpenMode.Output)

            For i = 0 To ds.Tables("Fac").Rows.Count - 1
                'nAbonado = IIf(IsDBNull(ds.Tables("Fac").Rows(i).Item("Abonado")), 0, ds.Tables("Fac").Rows(i).Item("Abonado"))
                nNit = IIf(IsDBNull(ds.Tables("Fac").Rows(i).Item("NIT")), 0, ds.Tables("Fac").Rows(i).Item("NIT"))
                nRazonSocial = ds.Tables("Fac").Rows(i).Item("RAZON")
                nNum_Factura = ds.Tables("Fac").Rows(i).Item("Factura")
                nNum_Autorizacion = ds.Tables("Fac").Rows(i).Item("Autorizacion")
                nCodigo_Control = ds.Tables("Fac").Rows(i).Item("Codigo_Control")
                nEmision = ds.Tables("Fac").Rows(i).Item("Fecha")
                nImp_Factura = ds.Tables("Fac").Rows(i).Item("Importe_Venta")
                nImp_Ice = ds.Tables("Fac").Rows(i).Item("ICE_IEHD_TASAS")
                nImp_Excentos = ds.Tables("Fac").Rows(i).Item("EXCENTAS")
                nImp_TasaCero = ds.Tables("Fac").Rows(i).Item("VENTAS_TASA_CERO")
                nImp_Subtotal = ds.Tables("Fac").Rows(i).Item("SUBTOTAL")
                nImp_Descuentos = ds.Tables("Fac").Rows(i).Item("DESCUENTOS")
                nImp_Neto = ds.Tables("Fac").Rows(i).Item("IMPORTE_PARA_DEBITO")
                nImp_Debito = ds.Tables("Fac").Rows(i).Item("DEBITO_FISCAL")
                nEstado = ds.Tables("Fac").Rows(i).Item("ESTADO")

                If nEstado = "V" Then
                    nImp_Neto_Suma += nImp_Neto
                    nImp_Debito_Suma += nImp_Debito
                    nNum_Validas += 1
                Else
                    nNum_Anuladas += 1
                End If

                'txt = nNit & "|" & nRazonSocial & "|" & nNum_Factura & "|" & nNum_Autorizacion & "|" & nEmision & "|" & nImp_Factura & "|" & nImp_Ice & "|" & nImp_Excentos & "|" & nImp_Neto & "|" & nImp_Debito & "|" & nEstado & "|" & nCodigo_Control
                'WriteLine(1, txt)

                txt = "3|" & i + 1 & "|" & nEmision & "|" & nNum_Factura & "|" & nNum_Autorizacion & "|" & nEstado & "|" & nNit & _
                    "|" & nRazonSocial & "|" & nImp_Factura & "|" & nImp_Ice & "|" & nImp_Excentos & "|" & nImp_Excentos & "|" & nImp_TasaCero & _
                    "|" & nImp_Subtotal & "|" & nImp_Descuentos & "|" & nImp_Neto & "|" & nImp_Debito & "|" & nCodigo_Control
                WriteLine(1, txt)

                Progreso.Value = Int((i / ds.Tables("Fac").Rows.Count) * 100)
                Progreso.Refresh()
            Next

            ds.Tables("Fac").Clear()
            
            ' Facturas Anteriores -----------------------------------------------------------------------------------------------------------------------------------------------
            'da.SelectCommand.CommandText = "Select U.Abonado, U.Nit, U.Nombre, F.Num_Factura, F.Num_Orden, " & _
            '"F.Fec_Pago as Emision, F.Imp_Factura, F.Imp_Iva, F.Valida, F.codigo_Control " & _
            '"From Usuarios U Inner Join Facturas F On U.Abonado = F.Abonado " & _
            '"WHERE Emision < '01/01/2008' And Fec_Pago Between '" & FormatDateTime(dFec_Ini, DateFormat.ShortDate) & "' and '" & FormatDateTime(dFec_Fin, DateFormat.ShortDate) & "' AND NUM_FACTURA > 0"

            'da.SelectCommand.CommandText = "SELECT * FROM VER_LIBROS_IVA WHERE Emision < '01/01/2008' And Fec_Pago Between '" & FormatDateTime(dFec_Ini, DateFormat.ShortDate) & " 00:00:00' and '" & FormatDateTime(dFec_Fin, DateFormat.ShortDate) & " 23:59:59' AND NUM_FACTURA > 0 ORDER BY NUM_FACTURA"


            'da.Fill(ds, "Fac")

            'For i = 0 To ds.Tables("Fac").Rows.Count - 1
            '    nAbonado = ds.Tables("Fac").Rows(i).Item("Abonado")
            '    nNit = ds.Tables("Fac").Rows(i).Item("NIT")
            '    nRazonSocial = ds.Tables("Fac").Rows(i).Item("Razon")
            '    nNum_Factura = ds.Tables("Fac").Rows(i).Item("Num_Factura")
            '    nNum_Autorizacion = ds.Tables("Fac").Rows(i).Item("Num_Orden")
            '    nCodigo_Control = ds.Tables("Fac").Rows(i).Item("Codigo_Control")
            '    nEmision = ds.Tables("Fac").Rows(i).Item("Emision")
            '    nImp_Factura = ds.Tables("Fac").Rows(i).Item("Imp_Factura")
            '    nImp_Ice = 0
            '    nImp_Excentos = 0
            '    nImp_Neto = ds.Tables("Fac").Rows(i).Item("Imp_Factura")
            '    nImp_Debito = ds.Tables("Fac").Rows(i).Item("Imp_Iva")
            '    nEstado = ds.Tables("Fac").Rows(i).Item("Valida")

            '    If nEstado = "V" Then
            '        nImp_Neto_Suma += nImp_Neto
            '        nImp_Debito_Suma += nImp_Debito
            '        nNum_Validas += 1
            '    Else
            '        nNum_Anuladas += 1
            '    End If

            '    'txt = nNit & "|" & nRazonSocial & "|" & nNum_Factura & "|" & nNum_Autorizacion & "|" & nEmision & "|" & nImp_Factura & "|" & nImp_Ice & "|" & nImp_Excentos & "|" & nImp_Neto & "|" & nImp_Debito & "|" & nEstado & "|" & nCodigo_Control
            '    'WriteLine(1, txt)

            '    txt = "3|" & i + 1 & "|" & nEmision & "|" & nNum_Factura & "|" & nNum_Autorizacion & "|" & nEstado & "|" & nNit & _
            '        "|" & nRazonSocial & "|" & nImp_Factura & "|0|0|0|" & nImp_Neto & "|0|" & nImp_Neto & "|" & nImp_Debito & "|" & nCodigo_Control
            '    WriteLine(1, txt)

            '    Progreso.Value = Int((i / ds.Tables("Fac").Rows.Count) * 100)
            '    Progreso.Refresh()
            'Next

            ds.Tables("Fac").Clear()

            Lista.Items.Add("Importe Sujeto a Impuesto  = " & Format(nImp_Neto_Suma, "#0.00"), True)
            Lista.Items.Add("Importe Debito Fiscal IVA  = " & Format(nImp_Debito_Suma, "#0.00"), True)
            Lista.Items.Add("Numero de Facturas Validas = " & Format(nNum_Validas, "####"), True)
            Lista.Items.Add("Numero de Facturas Anuladas = " & Format(nNum_Anuladas, "####"), True)

            Progreso.Visible = False
            MessageBox.Show("Proceso Terminado con éxito", "Fin del proceso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch x As Exception
            MessageBox.Show(x.Message & Chr(13) & " " & txt, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            FileClose(1)
        End Try
    End Sub


    Private Sub Verificar_Libros()
        Try
            Dim i As Integer
            Dim txt As String

            Dim cmd As New SqlCommand

            da.SelectCommand.CommandText = "select * from facturas where emision between '" & FormatDateTime(dtInicial.Value, DateFormat.ShortDate) & "' and '" & FormatDateTime(dtFinal.Value, DateFormat.ShortDate) & "' Order By Num_Factura"
            da.Fill(ds, "fa")

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.Text
            End With

            For i = 0 To ds.Tables("Fa").Rows.Count - 1
                txt = "update libro set importe_venta = '" & ds.Tables("FA").Rows(i).Item("imp_total") + ds.Tables("FA").Rows(i).Item("imp_alcanta") + ds.Tables("FA").Rows(i).Item("imp_rep") + ds.Tables("FA").Rows(i).Item("imp_car_1") + ds.Tables("FA").Rows(i).Item("imp_car_2") + ds.Tables("FA").Rows(i).Item("imp_recargo") + ds.Tables("FA").Rows(i).Item("imp_ley1886_1") + ds.Tables("FA").Rows(i).Item("imp_ley1886_2") & "', " & _
                    "excentas = '" & ds.Tables("FA").Rows(i).Item("imp_ley1886_1") + ds.Tables("FA").Rows(i).Item("imp_ley1886_2") & "', " & _
                    "subtotal = '" & ds.Tables("FA").Rows(i).Item("imp_total") + ds.Tables("FA").Rows(i).Item("imp_alcanta") + ds.Tables("FA").Rows(i).Item("imp_rep") + ds.Tables("FA").Rows(i).Item("imp_car_1") + ds.Tables("FA").Rows(i).Item("imp_car_2") + ds.Tables("FA").Rows(i).Item("imp_recargo") & "', " & _
                    "descuentos = '" & ds.Tables("FA").Rows(i).Item("imp_descuento") + ds.Tables("FA").Rows(i).Item("imp_DesAlcan") & "', " & _
                    "importe_para_debito = '" & ds.Tables("FA").Rows(i).Item("imp_total") + ds.Tables("FA").Rows(i).Item("imp_alcanta") + ds.Tables("FA").Rows(i).Item("imp_rep") + ds.Tables("FA").Rows(i).Item("imp_car_1") + ds.Tables("FA").Rows(i).Item("imp_car_2") + ds.Tables("FA").Rows(i).Item("imp_recargo") - ds.Tables("FA").Rows(i).Item("imp_descuento") - ds.Tables("FA").Rows(i).Item("Imp_desAlcan") & "' " & _
                    "where Factura = '" & ds.Tables("FA").Rows(i).Item("Num_Factura") & "' and Autorizacion = '" & ds.Tables("FA").Rows(i).Item("Num_Orden") & "'"
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next
            db.Close()
            MessageBox.Show("Proceso terminado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try

    End Sub
   
    Private Sub btnCorregir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorregir.Click
        Verificar_Libros()
    End Sub
End Class