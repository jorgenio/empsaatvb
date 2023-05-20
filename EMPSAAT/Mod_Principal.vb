Imports System.Data
Imports System.Data.SqlClient

Module Mod_Principal
    Public cn As String '= "Server=SERVIDORHP;Database=EMPSAAT;Uid=sa;Pwd=empsaat"
    Public _Usuario As String
    Public _Clave As String
    Public Empleado As Integer
    Public pTieneDosis As Boolean = False
    Public pFecha_Dosis_Final As Date
    Public pFecha_Dosis_Inicial As Date
    Public pNum_Autorizacion As Double
    Public pNum_Comprobante As Integer
    'Public pFec_Final As Date
    'Public PFec_Inicial As Date
    Public pLlave As String
    Public pFec_Pago As Date
    Public nAbonado As String
    Public nOrden As Integer
    Public nRep_Comprobante As Integer
    Public pFactura As Double
    Public pCliente As String
    Public _Proforma As Integer
    Public pMaterial As String
    Public _Servicio As Integer
    Public dEmision As Date
    Public pPunto As Integer = 1  '1 EMPSAAT
    Public pServicioLista As Integer
    Public pCuenta As String

    Function Exportar(ByVal Tabla As DataTable) As Boolean
        Try
            'Variables para manejar el Excel 
            Dim oXls As Object, oLibro As Object, Hoja As Object
            Dim i_Field As Integer, iRec As Long
            Dim Columna As Integer, Fila As Integer
            Dim i As Integer

            oXls = CreateObject("Excel.Application")
            oLibro = oXls.Workbooks.Add

            'Hace referencia a la hoja de Excel indicada 
            Hoja = oLibro.Worksheets(1)
            'Colocamos la aplicación Invisible 

            'cantidad de campos 
            i_Field = Tabla.Columns.Count
            iRec = Tabla.Rows.Count

            For Columna = 0 To i_Field - 1
                For Fila = 0 To iRec - 1
                    Hoja.Cells(Fila + 2, Columna + 1) = Tabla.Rows(Fila).Item(Columna)
                Next Fila
            Next Columna

            For i = 0 To Tabla.Columns.Count - 1
                Hoja.CellS(1, i + 1) = Tabla.Columns(i).ColumnName
            Next

            oXls.Selection.CurrentRegion.Columns.AutoFit()
            oXls.Selection.CurrentRegion.Rows.AutoFit()
            oXls.Visible = True : oXls.UserControl = True
            'Elimina las referencias del Excel 
            Hoja = Nothing
            oLibro = Nothing
            oXls = Nothing

            ' Se exporto con éxito 
            Exportar = True
        Catch ex As Exception
            'Error 
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Function


    Function Existe_Registro_Factura(ByVal Factura As Double, ByVal Autorizacion As Double) As Boolean
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select * From Libro Where Factura = " & Factura & " And Autorizacion = " & Autorizacion
        da.Fill(ds, "Lib")
        If ds.Tables("Lib").Rows.Count > 0 Then
            Existe_Registro_Factura = True
        Else
            Existe_Registro_Factura = False
        End If
        ds.Tables("Lib").Rows.Clear()
    End Function

    Function Razon_Social(ByVal Abonado As Double) As String
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select NoDoc From Usuarios Where Abonado = '" & Abonado & "'"
        da.Fill(ds, "Abo")
        If ds.Tables("Abo").Rows.Count > 0 Then
            da.SelectCommand.CommandText = "Select Razon From Cliente Where Cliente = '" & ds.Tables("Abo").Rows(0).Item("NoDoc") & "'"
            da.Fill(ds, "Clie")
            If ds.Tables("Clie").Rows.Count > 0 Then
                If IsDBNull(ds.Tables("Clie").Rows(0).Item("Razon")) Then
                    Razon_Social = ""
                Else
                    Razon_Social = ds.Tables("Clie").Rows(0).Item("Razon")
                End If
            End If
        End If
        ds.Tables("Abo").Clear()
        ds.Tables("Clie").Clear()
    End Function

    Function Nuevo_Numero_Factura(ByVal autorizacion As Double) As Double
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select Max(Factura) as Nro From Libro Where Autorizacion = '" & autorizacion & "'"
        da.Fill(ds, "Nro")
        If ds.Tables("Nro").Rows.Count > 0 Then
            If IsDBNull(ds.Tables("Nro").Rows(0).Item("Nro")) Then
                Nuevo_Numero_Factura = 1
            Else
                Nuevo_Numero_Factura = ds.Tables("Nro").Rows(0).Item("Nro") + 1
            End If
        End If
        ds.Tables("Nro").Clear()
    End Function

    Function Obtener_Numero_Autorizacion(ByVal Emision As Date, ByRef Fecha_inicial As Date, ByRef Fecha_final As Date, ByVal Llave As String) As Double
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = 1"
        da.Fill(ds, "NoFact")
        If ds.Tables("NoFact").Rows.Count > 0 Then
            Fecha_inicial = ds.Tables("NoFact").Rows(0).Item("Fec_Inicial")
            Fecha_final = ds.Tables("NoFact").Rows(0).Item("Fec_Final")
            Llave = ds.Tables("NoFact").Rows(0).Item("Llave")
            Obtener_Numero_Autorizacion = ds.Tables("NoFact").Rows(0).Item("Autorizacion")
        End If
    End Function

    Function Obtener_Fecha_Fin_Autorizacion(ByVal Autorizacion As Double) As Date
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select * From Dosificacion Where Autorizacion = '" & Autorizacion & "'"
        da.Fill(ds, "NoFact")
        If ds.Tables("NoFact").Rows.Count > 0 Then
            Obtener_Fecha_Fin_Autorizacion = ds.Tables("NoFact").Rows(0).Item("Fec_Final")
        Else
            Obtener_Fecha_Fin_Autorizacion = CDate("01/01/1900")
        End If
        ds.Tables("NOFact").Clear()
    End Function

    Function Leyenda_Ley_453_Autorizacion(ByVal Autorizacion As String) As String
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select * From Dosificacion Where Autorizacion = '" & Autorizacion & "'"
        da.Fill(ds, "Ley")
        If ds.Tables("Ley").Rows.Count > 0 Then
            Leyenda_Ley_453_Autorizacion = ds.Tables("Ley").Rows(0).Item("Ley_453")
        Else
            Leyenda_Ley_453_Autorizacion = ""
        End If
        ds.Tables("Ley").Clear()
    End Function

    'Function Obtener_Numero_Factura(ByVal Dosificacion As Double) As Double
    '    Dim db As New SqlConnection(cn)
    '    Dim da As New SqlDataAdapter("", db)
    '    Dim dss As New DataSet
    '    da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = True"
    '    da.Fill(dss, "NoFact")
    '    If dss.Tables("NoFact").Rows.Count > 0 Then
    '        Obtener_Numero_Factura = dss.Tables("NoFact").Rows(0).Item("NoFinal") + 1
    '    End If
    'End Function

    Function Numero_Comprobante(ByVal Fecha As Date) As Integer
        Dim Nro As Integer
        Dim txt As String
        Dim cmd As New SqlCommand
        Dim db As New SqlConnection(cn)
        Dim DA As New SqlDataAdapter("", db)
        Dim DSGEN As DataSet

        DA.SelectCommand.CommandText = "Select Comprobante From Comprobantes Where Fecha = #" & Format(Fecha, "MM/dd/yyyy") & "#"
        DA.Fill(DSGEN, "Comp")
        If dsGen.Tables("Comp").Rows.Count > 0 Then
            Nro = IIf(IsDBNull(dsGen.Tables("Comp").Rows(0).Item("Comprobante")), 0, dsGen.Tables("Comp").Rows(0).Item("Comprobante"))
        Else
            dsGen.Tables.Clear()
            DA.SelectCommand.CommandText = "Select Max(Comprobante) From Comprobantes Where Year(Fecha) = " & Year(Fecha)
            DA.Fill(DSGEN, "Comp")
            If dsGen.Tables("Comp").Rows.Count > 0 Then
                If Not IsDBNull(dsGen.Tables("Comp").Rows(0).Item(0)) Then
                    Nro = dsGen.Tables("Comp").Rows(0).Item(0) + 1
                Else
                    Nro = 1
                End If
                If MessageBox.Show("Desea Crear Comprobante Nro.=" & Str(Nro), "No existe comprobante para esta fecha", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                    txt = "Insert Into Comprobantes (Comprobante, Fecha) Values ('" & Nro & "','" & Format(Fecha, "dd/MM/yyyy") & "')"
                    db.Open()
                    With cmd
                        .Connection = db
                        .CommandType = CommandType.Text
                        .CommandText = txt
                        .ExecuteNonQuery()
                    End With
                    db.Close()
                Else
                    Nro = 0
                End If
            Else
                Nro = 0
            End If
        End If
        dsGen.Tables("Comp").Clear()
        pFec_Pago = Fecha
        Numero_Comprobante = Nro
    End Function

    Function Ver_Clave_Factura(ByVal Abonado As Integer, ByVal Mes As Integer, ByVal Año As Integer) As String
        Dim dGes As New SqlConnection(cn)
        Dim dEst As New SqlDataAdapter("", dGes)
        Dim rEst As New DataSet
        Dim cTex As String
        Dim Esta As String

        cTex = ""
        Select Case Mes
            Case 1
                cTex = "Select ene From Control Where Abonado = " & Abonado
            Case 2
                cTex = "Select feb From Control Where Abonado = " & Abonado
            Case 3
                cTex = "Select mar From Control Where Abonado = " & Abonado
            Case 4
                cTex = "Select abr From Control Where Abonado = " & Abonado
            Case 5
                cTex = "Select may From Control Where Abonado = " & Abonado
            Case 6
                cTex = "Select jun From Control Where Abonado = " & Abonado
            Case 7
                cTex = "Select jul From Control Where Abonado = " & Abonado
            Case 8
                cTex = "Select ago From Control Where Abonado = " & Abonado
            Case 9
                cTex = "Select sep From Control Where Abonado = " & Abonado
            Case 10
                cTex = "Select oct From Control Where Abonado = " & Abonado
            Case 11
                cTex = "Select nov From Control Where Abonado = " & Abonado
            Case 12
                cTex = "Select dic From Control Where Abonado = " & Abonado
        End Select
        dEst.SelectCommand.CommandText = cTex
        dEst.Fill(rEst, "Estado")
        If rEst.Tables(0).Rows.Count > 0 Then
            Esta = rEst.Tables(0).Rows(0).Item(0)
        Else
            Esta = "X"
        End If
        Ver_Clave_Factura = Esta
    End Function

    Function Ver_Estado_Factura(ByVal Clave As String) As String
        Dim DB As New SqlConnection(cn)
        Dim dEst As New SqlDataAdapter("Select Descripcion From Estado_Factura Where Estado = '" & Clave & "'", db)
        Dim rEst As New DataSet
        dEst.Fill(rEst, "Estado")

        If rEst.Tables(0).Rows.Count > 0 Then
            Ver_Estado_Factura = rEst.Tables(0).Rows(0).Item(0)
        Else
            Ver_Estado_Factura = "S/datos"
        End If
    End Function

    Function Recargos(ByVal Abonado As Integer, ByVal Emision As Date) As Decimal
        Dim db As New SqlConnection(cn)
        Dim dVen As New SqlDataAdapter("Select Vencimiento From Factores Where Emision = #" & Emision & "#", db)
        Dim fGes As New SqlConnection(cn)
        Dim dFac As New SqlDataAdapter("Select Categoria, Con_m3, Imp_Total, Imp_alcanta From Mes_" & Format(Month(Emision), "00") & " Where Abonado = " & Abonado, fGes)
        Dim cCategoria As String
        Dim nConsumo As Integer
        Dim nImporte As Decimal
        Dim dVencimiento As Date

        Dim rDat As New DataSet

        dVen.Fill(rDat, "Vencimiento")

        If rDat.Tables(0).Rows.Count > 0 Then
            dVencimiento = rDat.Tables(0).Rows(0).Item(0)
        Else
            dVencimiento = Date.Now
        End If

        rDat.Tables.Clear()

        If Date.Now > dVencimiento Then

            dFac.Fill(rDat, "Factura")
            If rDat.Tables(0).Rows.Count > 0 Then
                cCategoria = rDat.Tables(0).Rows(0).Item(0)
                nConsumo = rDat.Tables(0).Rows(0).Item(1)
                nImporte = rDat.Tables(0).Rows(0).Item(2) + rDat.Tables(0).Rows(0).Item(3)

                Select Case Left(cCategoria, 1)
                    Case "A"
                        If nConsumo >= 0 And nConsumo <= 6 Then
                            Recargos = Math.Round(nImporte * 0.2, 2)
                        ElseIf nConsumo >= 0 And nConsumo <= 20 Then
                            Recargos = Math.Round(nImporte * 0.1, 2)
                        Else
                            Recargos = Math.Round(nImporte * 0.05, 2)
                        End If
                    Case "B"
                        If nConsumo >= 0 And nConsumo <= 18 Then
                            Recargos = Math.Round(nImporte * 0.1, 2)
                        Else
                            Recargos = Math.Round(nImporte * 0.05, 2)
                        End If
                    Case "C"
                        If nConsumo >= 0 And nConsumo <= 14 Then
                            Recargos = Math.Round(nImporte * 0.1, 2)
                        Else
                            Recargos = Math.Round(nImporte * 0.05, 2)
                        End If
                    Case "D"
                        If nConsumo >= 0 And nConsumo <= 18 Then
                            Recargos = Math.Round(nImporte * 0.1, 2)
                        Else
                            Recargos = Math.Round(nImporte * 0.05, 2)
                        End If
                End Select
            Else
                Recargos = 0
            End If
        Else
            Recargos = 0
        End If
    End Function

    Function Repone(ByVal Importe As Decimal) As Decimal
        Dim nDiferencia As Double

        If IsDBNull(Importe) Then
            Repone = 0
        Else
            nDiferencia = Math.Round((Math.Round(Importe, 1) - Math.Round(Importe, 2)), 2)
            Select Case nDiferencia
                Case 0.01
                    Repone = 0.81
                Case 0.02
                    Repone = 0.82
                Case 0.03
                    Repone = 0.83
                Case 0.04
                    Repone = 0.84
                Case 0.05
                    Repone = 0.85
                Case -0.05
                    Repone = 0.85
                Case -0.04
                    Repone = 0.86
                Case -0.03
                    Repone = 0.87
                Case -0.02
                    Repone = 0.88
                Case -0.01
                    Repone = 0.89
                Case 0
                    Repone = 0.8
            End Select
        End If
    End Function

    Function Calculo_Consumo(ByVal Actual As Int64, ByVal Anterior As Int64) As Int64
        Dim consumo As Int64
        If Actual < Anterior Then
            If Anterior < 999 Then
                consumo = (1000 - Anterior) + Actual
            ElseIf Anterior < 9999 Then
                consumo = (10000 - Anterior) + Actual
            ElseIf Anterior < 99999 Then
                consumo = (100000 - Anterior) + Actual
            End If
        Else
            consumo = Actual - Anterior
        End If
        Calculo_Consumo = consumo
    End Function

    Function Duplica_Registro(ByVal Abonado As Int64, ByVal Periodo As Date) As Boolean
        Dim fGes As New SqlConnection(cn)
        Dim dReg As New SqlDataAdapter("Select Abonado From Mes_" & Format(Month(Periodo), "00") & " WHERE Abonado = " & Abonado, fGes)
        Dim rReg As New DataSet
        Dim lRes As Boolean
        Dim nAbo As Int64
        dReg.Fill(rReg, "Usuario")
        If rReg.Tables(0).Rows.Count > 0 Then
            nAbo = rReg.Tables(0).Rows(0).Item(0)
            If nAbo = Abonado Then
                lRes = True
            Else
                lRes = False
            End If
        End If
        Duplica_Registro = lRes
    End Function

    Function Duplica_Registro_Control(ByVal Abonado As Int64, ByVal Periodo As Date) As Boolean
        Dim fGes As New SqlConnection(cn)
        Dim dReg As New SqlDataAdapter("Select Abonado From Control WHERE Abonado = " & Abonado, fGes)
        Dim rReg As New DataSet
        Dim lRes As Boolean
        Dim nAbo As Int64
        dReg.Fill(rReg, "Usuario")
        If rReg.Tables(0).Rows.Count > 0 Then
            nAbo = rReg.Tables(0).Rows(0).Item(0)
            If nAbo = Abonado Then
                lRes = True
            Else
                lRes = False
            End If
        End If
        Duplica_Registro_Control = lRes
    End Function

    Function Grabar_Lectura_Consumo(ByVal Abonado As Int64, ByVal Lectura As Int64, ByVal Consumo As Integer, ByVal Estimado As Boolean, ByVal Categoria As String, ByVal Ley1886 As Boolean, ByVal ClaveFactura As String, ByVal Liberacion As String, ByVal Periodo As Date) As Boolean
        Dim dGes As New SqlConnection(cn)
        Dim dLec As New SqlDataAdapter("Select Abonado From Mes_" & Format(Month(Periodo), "00") & " Where Abonado = " & Abonado, dGes)
        Dim dCon As New SqlDataAdapter("Select Abonado From Control WHERE Abonado = " & Abonado, dGes)
        Dim dst As New DataSet

        Dim cmdLec As New SqlCommand
        Dim txt As String = ""

        dCon.Fill(dst, "Usuario")
        If dst.Tables(0).Rows.Count > 0 Then
            If dst.Tables(0).Rows(0).Item(0) = Abonado Then
                txt = "Update Control SET " & Format(Periodo, "MMM") & " = '" & ClaveFactura & "' Where Abonado = " & Abonado
            Else
                txt = "Insert INTO Control (Abonado, " & Format(Periodo, "MMM") & ") values ('" & Abonado & "','" & ClaveFactura & "')"
            End If
        Else
            txt = "Insert INTO Control (Abonado, " & Format(Periodo, "MMM") & ") values ('" & Abonado & "','" & ClaveFactura & "')"
        End If

        dGes.Open()
        With cmdLec
            .Connection = dGes
            .CommandType = CommandType.Text
            .CommandText = txt
            .ExecuteNonQuery()
        End With

        '--------- comprobar si tiene registro en la tabla -----------
        dst.Tables.Clear()
        dLec.Fill(dst, "Lectura")
        If dst.Tables(0).Rows.Count > 0 Then
            txt = "UPDATE Mes_" & Format(Month(Periodo), "00") & " Set Lectura = '" & Lectura & "', Con_M3 = '" & Consumo & "', Lec_Estimada = " & Estimado & ", Categoria = '" & Categoria & "', Ley_1886 = " & Ley1886 & ", Liberacion = '" & Liberacion & "' Where Abonado = " & Abonado
        Else
            txt = "INSERT INTO Mes_" & Format(Month(Periodo), "00") & " (Abonado, Emision, Lectura, Con_m3, Lec_Estimada, Categoria, Ley_1886, Liberacion) values ('" & Abonado & "','" & Periodo & "','" & Lectura & "','" & Consumo & "'," & Estimado & ",'" & Categoria & "'," & Ley1886 & ",'" & Liberacion & "')"
        End If

        '--------- graba registro de lectura ------------------------
        With cmdLec
            .Connection = dGes
            .CommandType = CommandType.Text
            .CommandText = txt
            .ExecuteNonQuery()
        End With
        dGes.Close()
        Grabar_Lectura_Consumo = True
    End Function

    Function Categoria_Clave(ByVal Categoria As String) As String
        Dim db As New SqlConnection(cn)
        Dim DA As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        DA.SelectCommand.CommandText = "Select Categoria From Usuarios_Categorias Where Descripcion = '" & Categoria & "'"
        ds.Tables.Clear()
        DA.Fill(ds, "Categoria_Clave")
        If ds.Tables("Categoria_Clave").Rows.Count > 0 Then
            Categoria_Clave = ds.Tables("Categoria_Clave").Rows(0).Item("Categoria")
        Else
            Categoria_Clave = "A1"
        End If
    End Function

    Function Categoria_Descripcion(ByVal Clave As String) As String
        Dim db As New SqlConnection(cn)
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter("", db)
        da.SelectCommand.CommandText = "Select Categoria From Usuarios_Categoria Where Descripcion = '" & Clave & "'"
        ds.Tables.Clear()
        da.Fill(ds, "Categoria_Descripcion")
        If ds.Tables(0).Rows.Count > 0 Then
            Categoria_Descripcion = ds.Tables("Categoria_Descripcion").Rows(0).Item("Descripcion")
        Else
            Categoria_Descripcion = "Domestico"
        End If
    End Function

    Function Obtener_Lectura_Anterior(ByVal Abonado As Int64, ByVal PeriodoActual As Date) As Int64
        Dim dges As New SqlConnection(cn)
        Dim dalec As New SqlDataAdapter("", dges)
        Dim dsLec As New DataSet

        If Month(PeriodoActual) = 1 Then
            dges.ConnectionString = cn
            dalec.SelectCommand.CommandText = "Select Lectura From Mes_12 Where Abonado = " & Abonado
        Else
            dges.ConnectionString = cn
            dalec.SelectCommand.CommandText = "Select Lectura From Mes_" & Format(Month(PeriodoActual) - 1, "00") & " Where Abonado = " & Abonado
        End If

        dalec.Fill(dsLec, "LecturaAnterior")
        If dsLec.Tables(0).Rows.Count > 0 Then
            Obtener_Lectura_Anterior = dsLec.Tables(0).Rows(0).Item(0)
        Else
            Obtener_Lectura_Anterior = obtener_Lectura_Inicial(Abonado)
        End If
    End Function

    Function obtener_Lectura_Inicial(ByVal Abonado As Int64) As Int64
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select Lect_Inicial From Usuarios Where Abonado = " & Abonado
        ds.Tables.Clear()
        da.Fill(ds, "Lectura_Inicial")
        If ds.Tables(0).Rows.Count > 0 Then
            obtener_Lectura_Inicial = ds.Tables(0).Rows(0).Item(0)
        Else
            obtener_Lectura_Inicial = 0
        End If
    End Function

    Function Duplica_Usuario(ByVal Abonado As Int64) As Boolean
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select Abonado From Usuarios Where Abonado = " & Abonado
        ds.Tables.Clear()
        da.Fill(ds, "Duplica_Usuario")
        If ds.Tables("Duplica_Usuario").Rows.Count > 0 Then
            If ds.Tables("Duplica_Usuario").Rows(0).Item("Abonado") = Abonado Then
                Duplica_Usuario = True
            Else
                Duplica_Usuario = False
            End If
        Else
            Duplica_Usuario = False
        End If
    End Function

    Function Obtener_Razon_Social(ByVal Abonado As Int64) As String
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select Abonado, Nombre From Usuarios Where Abonado = " & Abonado
        ds.Tables.Clear()
        da.Fill(ds, "RazonSocial")
        If ds.Tables("RazonSocial").Rows.Count > 0 Then
            If ds.Tables("RazonSocial").Rows(0).Item("Abonado") = Abonado Then
                Obtener_Razon_Social = ds.Tables("RazonSocial").Rows(0).Item("NOmbre")
            Else
                Obtener_Razon_Social = ""
            End If
        Else
            Obtener_Razon_Social = ""
        End If
    End Function

    Function Obtener_Cuenta_Servicio(ByVal Servicio As Integer) As Double
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select Cuenta From Servicios_Lista Where Servicio = " & Servicio
        ds.Tables.Clear()
        da.Fill(ds, "Cuenta")
        If ds.Tables("Cuenta").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("Cuenta").Rows(0).Item("Cuenta")) Then
                Obtener_Cuenta_Servicio = ds.Tables("Cuenta").Rows(0).Item("Cuenta")
            Else
                Obtener_Cuenta_Servicio = 0
            End If
        Else
            Obtener_Cuenta_Servicio = 0
        End If
    End Function
End Module
