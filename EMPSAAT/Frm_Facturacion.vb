Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Facturacion
    Dim db As New SqlConnection(cn)
    Dim dUsu As New SqlDataAdapter("", db)
    Dim rUsu As New DataSet

    Dim cTex As String
    Dim tTab As New DataTable
    Dim tTaD As New DataTable

    Dim rMes As New DataSet
    Dim rCon As New DataSet

    Dim dMesano As Date
    Dim nLectura As Integer
    Dim cTipo As String
    Dim nConsumo As Integer
    Dim nImporte As Decimal
    Dim nAlcanta As Decimal
    Dim nRecargo As Decimal
    Dim nReposic As Decimal
    Dim nFormula As Decimal
    Dim nCargos1 As Decimal
    Dim nCargos2 As Decimal
    Dim nFactura As Decimal
    Dim nSuma As Decimal
    Dim cEstado As String
    Dim nNoFactu As Integer
    Dim dEstado(12) As String

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
    Dim nImp_Iva As Double
    Dim nImp_Ite As Double
    Dim cLiteral As String
    Dim cCodContr As String
    Dim hPeriodo(5) As Date
    Dim hConsumo(5) As Int64
    Dim hImporte(5) As Decimal
    Dim hPagos(5) As Date


    Private Sub Crear_Tabla()
        tTab.Columns.Clear()
        tTab.Rows.Clear()

        With tTab.Columns
            .Add("Mes/Año", Type.GetType("System.DateTime"))
            .Add("Lectura", Type.GetType("System.Int16"))
            .Add("Tipo", Type.GetType("System.String"))
            .Add("Consumo", Type.GetType("System.Int16"))
            .Add("Importe", Type.GetType("System.Decimal"))
            .Add("Alcanta", Type.GetType("System.Decimal"))
            .Add("Recargo", Type.GetType("System.Decimal"))
            .Add("Reposic", Type.GetType("System.Decimal"))
            .Add("Cargos1", Type.GetType("System.Decimal"))
            .Add("Cargos2", Type.GetType("System.Decimal"))
            .Add("Factura", Type.GetType("System.Decimal"))
            .Add("Suma", Type.GetType("System.Decimal"))
            .Add("Estado", Type.GetType("System.String"))
            .Add("NoFactura", Type.GetType("System.Int64"))
            .Add("Pago", Type.GetType("System.DateTime"))
        End With
    End Sub

    Private Sub Crear_Tabla_Debengado()
        tTaD.Columns.Clear()
        tTaD.Rows.Clear()
        With tTaD.Columns
            .Add("Mes/Año", Type.GetType("System.DateTime"))
            .Add("Lectura", Type.GetType("System.Int16"))
            .Add("Tipo", Type.GetType("System.String"))
            .Add("Consumo", Type.GetType("System.Int16"))
            .Add("Importe", Type.GetType("System.Decimal"))
            .Add("Alcanta", Type.GetType("System.Decimal"))
            .Add("Recargo", Type.GetType("System.Decimal"))
            .Add("Reposic", Type.GetType("System.Decimal"))
            .Add("Cargos1", Type.GetType("System.Decimal"))
            .Add("Cargos2", Type.GetType("System.Decimal"))
            .Add("Factura", Type.GetType("System.Decimal"))
            .Add("Suma", Type.GetType("System.Decimal"))
            .Add("Estado", Type.GetType("System.String"))
            .Add("NoFactura", Type.GetType("System.Int64"))
        End With
    End Sub

    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        cTex = ""
        Select Case CboTipo.SelectedItem
            Case "Nombre"
                cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Nombre Like '" & TxPaterno.Text & "%" & TxNombre.Text & "%'"
            Case "Abonado"
                cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Abonado = " & TxPaterno.Text
            Case "Dirección"
                cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Zona Like '%" & TxPaterno.Text & "%'"
            Case "NIT/CID"
                cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where NIT like '%" & TxPaterno.Text & "%'"
        End Select

        dUsu.SelectCommand.CommandText = cTex

        dUsu.Fill(rUsu, "Usuarios")
        DgUsuarios.DataSource = rUsu.Tables("Usuarios")
        Formatear_Tabla_Usuarios()
    End Sub

    Private Sub Formatear_Tabla_Usuarios()
        Dim dt As New DataGridTableStyle
        dt.MappingName = "Usuarios"

        Dim c1 As New DataGridTextBoxColumn
        c1.MappingName = "Abonado"
        c1.HeaderText = "Abonado"
        c1.ReadOnly = True
        c1.Width = 100
        dt.GridColumnStyles.Add(c1)

        Dim c2 As New DataGridTextBoxColumn
        c2.MappingName = "Nombre"
        c2.HeaderText = "Usuario"
        c2.ReadOnly = True
        c2.Width = 300
        dt.GridColumnStyles.Add(c2)

        Dim c3 As New DataGridTextBoxColumn
        c3.MappingName = "Zona"
        c3.HeaderText = "Zona"
        c3.ReadOnly = True
        c3.Width = 150
        dt.GridColumnStyles.Add(c3)

        Dim c4 As New DataGridTextBoxColumn
        c4.MappingName = "Calle"
        c4.HeaderText = "Calle"
        c4.ReadOnly = True
        c4.Width = 150
        dt.GridColumnStyles.Add(c4)

        Dim c5 As New DataGridTextBoxColumn
        c5.MappingName = "Descripcion"
        c5.HeaderText = "Categoria"
        c5.ReadOnly = True
        c5.Width = 100
        dt.GridColumnStyles.Add(c5)

        ' DgUsuarios.TableStyles.Clear()
        ' DgUsuarios.TableStyles.Add(dt)
    End Sub

    Private Sub CboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboTipo.SelectedIndexChanged
        TxPaterno.Clear()
        TxNombre.Clear()
        rUsu.Clear()
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 1
                'Dim nAbonado As Integer = DgUsuarios.Item(DgUsuarios.CurrentRowIndex, 0)
                Call Ver_Usuario(nAbonado)
                rdConRecargos.Checked = True
                Call Ver_Deudas(nAbonado)
                TabControl2.SelectTab(0)
            Case 2

        End Select
    End Sub

    Private Sub Ver_Usuario(ByVal Abonado As Integer)
        dUsu.SelectCommand.CommandText = "Select U.Abonado, U.Nombre, C.Descripcion, U.Nit, U.Ley1886, E.Descripcion, U.Zona, U.Calle From ((Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria) Inner Join Usuarios_Estado E On U.Estado = E.Estado) Where U.Abonado = " & Abonado
        dUsu.Fill(rUsu, "Usuario")

        If rUsu.Tables("Usuario").Rows.Count > 0 Then
            TxAbonado.Text = rUsu.Tables("Usuario").Rows(0).Item(0)
            TxUsuario.Text = IIf(IsDBNull(rUsu.Tables("Usuario").Rows(0).Item(1)), "", rUsu.Tables("Usuario").Rows(0).Item(1))
            TxCategoria.Text = IIf(IsDBNull(rUsu.Tables("Usuario").Rows(0).Item(2)), "", rUsu.Tables("Usuario").Rows(0).Item(2))
            TxNIT.Text = IIf(IsDBNull(rUsu.Tables("Usuario").Rows(0).Item(3)), 0, rUsu.Tables("Usuario").Rows(0).Item(3))
            CkLey1886.Checked = rUsu.Tables("Usuario").Rows(0).Item(4)
            TxCuenta.Text = IIf(IsDBNull(rUsu.Tables("Usuario").Rows(0).Item(5)), "", rUsu.Tables("Usuario").Rows(0).Item(5))
            TxZona.Text = IIf(IsDBNull(rUsu.Tables("Usuario").Rows(0).Item(6)), "", rUsu.Tables("Usuario").Rows(0).Item(6))
            TxCalle.Text = IIf(IsDBNull(rUsu.Tables("Usuario").Rows(0).Item(7)), "", rUsu.Tables("Usuario").Rows(0).Item(7))
        Else
            TxAbonado.Clear()
            TxUsuario.Clear()
            TxCategoria.Clear()
            TxNIT.Clear()
            TxCuenta.Clear()
            TxZona.Clear()
            TxCalle.Clear()
        End If
        rUsu.Tables("Usuario").Clear()
    End Sub

    Private Sub Ver_Historico(ByVal Abonado)
        Dim a As Integer
        Dim m As Integer
        Dim dMesano As Date
        Dim nLectura As Integer
        Dim cTipo As String
        Dim nConsumo As Integer
        Dim nImporte As Decimal
        Dim nAlcanta As Decimal
        Dim nRecargo As Decimal
        Dim nReposic As Decimal
        Dim nCargos1 As Decimal
        Dim nCargos2 As Decimal
        Dim nFactura As Decimal
        Dim cEstado As String
        Dim nNoFactu As Integer
        Dim dPago As Date

        Dim rMes As New DataSet

        Crear_Tabla()

        For a = 2003 To Year(Date.Now)
            Dim cGes As New SqlConnection(cn)
            Dim dMes As New SqlDataAdapter("", cGes)
            For m = 1 To 12
                dMes.SelectCommand.CommandText = "Select Emision, Lectura, Lec_Estimada, Con_m3, Imp_Total, Imp_Alcanta, Imp_Recargo, Imp_Rep, Imp_Car_1, Imp_Car_2, Imp_Factura, Num_Factura, Fec_Pago From Mes_" & Format(m, "00") & " where Abonado = " & Abonado
                rMes.Tables.Clear()
                dMes.Fill(rMes, "Facturas")

                If rMes.Tables(0).Rows.Count > 0 Then
                    dMesano = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(0)), "01/" & Trim(Str(m)) & "/" & Trim(Str(a)), rMes.Tables(0).Rows(0).Item(0))
                    nLectura = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(1)), 0, rMes.Tables(0).Rows(0).Item(1))
                    cTipo = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(2)), 0, rMes.Tables(0).Rows(0).Item(2))
                    nConsumo = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(3)), 0, rMes.Tables(0).Rows(0).Item(3))
                    nImporte = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(4)), 0, rMes.Tables(0).Rows(0).Item(4))
                    nAlcanta = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(5)), 0, rMes.Tables(0).Rows(0).Item(5))
                    nRecargo = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(6)), 0, rMes.Tables(0).Rows(0).Item(6))
                    nReposic = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(7)), 0, rMes.Tables(0).Rows(0).Item(7))
                    nCargos1 = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(8)), 0, rMes.Tables(0).Rows(0).Item(8))
                    nCargos2 = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(9)), 0, rMes.Tables(0).Rows(0).Item(9))
                    nFactura = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(10)), 0, rMes.Tables(0).Rows(0).Item(10))
                    nNoFactu = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(11)), 0, rMes.Tables(0).Rows(0).Item(11))
                    dPago = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(12)), CDate("01/01/1900"), rMes.Tables(0).Rows(0).Item(12))

                    'nSuma = nSuma + nFactura
                    cEstado = Ver_Estado_Factura(Ver_Clave_Factura(Abonado, m, a))
                    Dim nfila As DataRow = tTab.NewRow
                    nfila(0) = dMesano
                    nfila(1) = nLectura
                    nfila(2) = cTipo
                    nfila(3) = nConsumo
                    nfila(4) = nImporte
                    nfila(5) = nAlcanta
                    nfila(6) = nRecargo
                    nfila(7) = nReposic
                    nfila(8) = nCargos1
                    nfila(9) = nCargos2
                    nfila(10) = nFactura
                    'nfila(11) = nSuma
                    nfila(12) = cEstado
                    nfila(13) = nNoFactu
                    nfila(14) = dPago

                    tTab.Rows.Add(nfila)
                End If
            Next
        Next
        DgHisto.DataSource = tTab
    End Sub

    Private Sub Ver_Deudas(ByVal Abonado)
        Dim a As Integer
        Dim m As Integer

        Crear_Tabla()
        Crear_Tabla_Debengado()
        nSuma = 0
        For a = 2003 To 2007
            Dim cGes As New SqlConnection(cn)
            Dim dCon As New SqlDataAdapter("Select * From Control Where Abonado = " & Abonado, cGes)

            rCon.Tables.Clear()

            dCon.Fill(rCon, "Control")

            If rCon.Tables(0).Rows.Count > 0 Then
                For m = 1 To 12
                    If rCon.Tables(0).Rows(0).Item(m) = "0" Then
                        Añadir_Mes_Deuda(Abonado, a, m)
                    End If
                Next
            End If
        Next

        For a = 2008 To Year(Date.Now)
            Dim cGes As New SqlConnection(cn)
            Dim dCon As New SqlDataAdapter("Select * From Control Where Abonado = " & Abonado, cGes)

            rCon.Tables.Clear()

            dCon.Fill(rCon, "Control")

            If rCon.Tables(0).Rows.Count > 0 Then
                For m = 1 To 12
                    If Not IsDBNull(rCon.Tables(0).Rows(0).Item(m)) Then
                        If rCon.Tables(0).Rows(0).Item(m) = "0" Then
                            Añadir_Mes_Deuda_Debengado(Abonado, a, m)
                        End If
                    End If
                Next
            End If
        Next
        dgDeuA.DataSource = tTab
        'dgDeuX.DataSource = tTab
        dgDeuB.DataSource = tTaD
        'Call Formatear_Deuda_A()
        Timer1.Enabled = Ver_Otras_Deudas(Abonado)
    End Sub

    Function Ver_Otras_Deudas(ByVal Abonado) As Boolean
        Dim das As New DataSet
        Dim deu As New SqlDataAdapter("Select Sum(Costo) as Importe From Servicios_Solicitud Where Cobrado = False And Abonado = " & Abonado, db)
        deu.Fill(das, "OtrasDeudas")
        If das.Tables("OtrasDeudas").Rows.Count > 0 Then
            If IsDBNull(das.Tables("OtrasDeudas").Rows(0).Item("Importe")) Then
                Ver_Otras_Deudas = False
            Else
                If das.Tables("OtrasDeudas").Rows(0).Item("Importe") > 0 Then
                    Ver_Otras_Deudas = True
                Else
                    Ver_Otras_Deudas = False
                End If
            End If
        End If
    End Function

    Private Sub Añadir_Mes_Deuda(ByVal Abonado, ByVal Año, ByVal Mes)
        Dim cGes As New SqlConnection(cn)
        Dim dmes As New SqlDataAdapter("Select Emision, Lectura, Lec_Estimada, Con_m3, Imp_Total, Imp_Alcanta, Imp_Recargo, Imp_Rep, Imp_Car_1, Imp_Car_2, Imp_Factura, Num_Factura From Mes_" & Format(Mes, "00") & " where Abonado = " & Abonado, cGes)

        rMes.Tables.Clear()
        dmes.Fill(rMes, "Facturas")

        If rMes.Tables(0).Rows.Count > 0 Then
            dMesano = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(0)), "01/" & Trim(Str(Mes)) & "/" & Trim(Str(Año)), rMes.Tables(0).Rows(0).Item(0))
            nLectura = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(1)), 0, rMes.Tables(0).Rows(0).Item(1))
            cTipo = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(2)), 0, rMes.Tables(0).Rows(0).Item(2))
            nConsumo = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(3)), 0, rMes.Tables(0).Rows(0).Item(3))
            nImporte = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(4)), 0, rMes.Tables(0).Rows(0).Item(4))
            nAlcanta = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(5)), 0, rMes.Tables(0).Rows(0).Item(5))
            nReposic = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(7)), 0, rMes.Tables(0).Rows(0).Item(7))
            nCargos1 = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(8)), 0, rMes.Tables(0).Rows(0).Item(8))
            nCargos2 = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(9)), 0, rMes.Tables(0).Rows(0).Item(9))


            If rdConRecargos.Checked Then
                nRecargo = Recargos(Abonado, dMesano)
            End If
            If rdSinRecargos.Checked Then
                nRecargo = 0
            End If
            If rdRecargosAntes.Checked Then
                nRecargo = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(6)), 0, rMes.Tables(0).Rows(0).Item(6))
            End If

            'nFactura = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(10)), 0, rMes.Tables(0).Rows(0).Item(10))
            If nReposic > 0.59 Then
                nFormula = Math.Round((nReposic - 0.5), 2)
            Else
                nFormula = 0
            End If
            nReposic = Repone(nImporte + nAlcanta + nCargos1 + nCargos2 + nRecargo + nFormula) + nFormula
            nFactura = nImporte + nAlcanta + nCargos1 + nCargos2 + nRecargo + nReposic

            nNoFactu = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(11)), 0, rMes.Tables(0).Rows(0).Item(11))
            nSuma = nSuma + nFactura

            Dim nfila As DataRow = tTab.NewRow
            nfila(0) = dMesano
            nfila(1) = nLectura
            nfila(2) = IIf(cTipo, "Estimado", "Real")
            nfila(3) = nConsumo
            nfila(4) = nImporte
            nfila(5) = nAlcanta
            nfila(6) = nRecargo
            nfila(7) = nReposic
            nfila(8) = nCargos1
            nfila(9) = nCargos2
            nfila(10) = nFactura
            nfila(11) = nSuma
            nfila(12) = cEstado
            nfila(13) = nNoFactu

            tTab.Rows.Add(nfila)
        End If
    End Sub

    Private Sub Añadir_Mes_Deuda_Debengado(ByVal Abonado, ByVal Año, ByVal Mes)
        Dim cGes As New SqlConnection(cn)
        Dim dmes As New SqlDataAdapter("Select Emision, Lectura, Lec_Estimada, Con_m3, Imp_Total, Imp_Alcanta, Imp_Recargo, Imp_Rep, Imp_Car_1, Imp_Car_2, Imp_Factura, Num_Factura From Mes_" & Format(Mes, "00") & " where Abonado = " & Abonado, cGes)

        rMes.Tables.Clear()
        dmes.Fill(rMes, "Facturas")

        If rMes.Tables(0).Rows.Count > 0 Then
            dMesano = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(0)), "01/" & Trim(Str(Mes)) & "/" & Trim(Str(Año)), rMes.Tables(0).Rows(0).Item(0))
            nLectura = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(1)), 0, rMes.Tables(0).Rows(0).Item(1))
            cTipo = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(2)), 0, rMes.Tables(0).Rows(0).Item(2))
            nConsumo = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(3)), 0, rMes.Tables(0).Rows(0).Item(3))
            nImporte = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(4)), 0, rMes.Tables(0).Rows(0).Item(4))
            nAlcanta = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(5)), 0, rMes.Tables(0).Rows(0).Item(5))
            nRecargo = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(6)), 0, rMes.Tables(0).Rows(0).Item(6))
            nReposic = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(7)), 0, rMes.Tables(0).Rows(0).Item(7))
            nCargos1 = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(8)), 0, rMes.Tables(0).Rows(0).Item(8))
            nCargos2 = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(9)), 0, rMes.Tables(0).Rows(0).Item(9))
            nFactura = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(10)), 0, rMes.Tables(0).Rows(0).Item(10))
            nNoFactu = IIf(IsDBNull(rMes.Tables(0).Rows(0).Item(11)), 0, rMes.Tables(0).Rows(0).Item(11))
            nSuma = nSuma + nFactura

            Dim nfila As DataRow = tTaD.NewRow
            nfila(0) = dMesano
            nfila(1) = nLectura
            nfila(2) = IIf(cTipo, "Estimado", "Real")
            nfila(3) = nConsumo
            nfila(4) = nImporte
            nfila(5) = nAlcanta
            nfila(6) = nRecargo
            nfila(7) = nReposic
            nfila(8) = nCargos1
            nfila(9) = nCargos2
            nfila(10) = nFactura
            nfila(11) = nSuma
            nfila(12) = cEstado
            nfila(13) = nNoFactu

            tTaD.Rows.Add(nfila)
        End If
    End Sub

    Private Sub Formatear_Deuda_A()
        Dim dt As New DataGridTableStyle
        dt.MappingName = "tTaB"

        '.Add("Mes/Año", Type.GetType("System.DateTime"))
        Dim c1 As New DataGridTextBoxColumn
        c1.MappingName = "Mes/Año"
        c1.HeaderText = "Periodo"
        c1.ReadOnly = True
        c1.Format = "MM/yyyy"
        c1.Width = 100
        dt.GridColumnStyles.Add(c1)

        '.Add("Lectura", Type.GetType("System.Int16"))
        Dim c2 As New DataGridTextBoxColumn
        c2.MappingName = "Lectura"
        c2.HeaderText = "Lectura"
        c2.ReadOnly = True
        c2.Width = 50
        dt.GridColumnStyles.Add(c2)

        '.Add("Tipo", Type.GetType("System.String"))
        Dim c3 As New DataGridTextBoxColumn
        c3.MappingName = "Tipo"
        c3.HeaderText = "Tipo"
        c3.ReadOnly = True
        c3.Width = 30
        dt.GridColumnStyles.Add(c3)

        '.Add("Consumo", Type.GetType("System.Int16"))
        Dim c4 As New DataGridTextBoxColumn
        c4.MappingName = "Consumo"
        c4.HeaderText = "Consumo"
        c4.ReadOnly = True
        c4.Width = 60
        dt.GridColumnStyles.Add(c4)

        '.Add("Importe", Type.GetType("System.Decimal"))
        Dim c5 As New DataGridTextBoxColumn
        c5.MappingName = "Importe"
        c5.HeaderText = "Importe"
        c5.ReadOnly = True
        c5.Width = 80
        c5.Format = "#0.00"
        c5.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c5)

        '.Add("Alcanta", Type.GetType("System.Decimal"))
        Dim c6 As New DataGridTextBoxColumn
        c6.MappingName = "Alcanta"
        c6.HeaderText = "Alcant."
        c6.ReadOnly = True
        c6.Width = 60
        c6.Format = "#0.00"
        c6.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c6)

        '.Add("Recargo", Type.GetType("System.Decimal"))
        Dim c7 As New DataGridTextBoxColumn
        c7.MappingName = "Recargo"
        c7.HeaderText = "Recargo"
        c7.ReadOnly = True
        c7.Width = 60
        c7.Format = "#0.00"
        c7.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c7)

        '.Add("Reposic", Type.GetType("System.Decimal"))
        Dim c8 As New DataGridTextBoxColumn
        c8.MappingName = "Reposic"
        c8.HeaderText = "Rep."
        c8.ReadOnly = True
        c8.Width = 60
        c8.Format = "#0.00"
        c8.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c8)

        '.Add("Cargos1", Type.GetType("System.Decimal"))
        Dim c9 As New DataGridTextBoxColumn
        c9.MappingName = "Cargos1"
        c9.HeaderText = "Cargos1"
        c9.ReadOnly = True
        c9.Width = 100
        c9.Format = "#0.00"
        c9.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c9)

        '.Add("Cargos2", Type.GetType("System.Decimal"))
        Dim c10 As New DataGridTextBoxColumn
        c10.MappingName = "Cargos2"
        c10.HeaderText = "Cargos2"
        c10.ReadOnly = True
        c10.Width = 60
        c10.Format = "#0.00"
        c10.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c10)

        '.Add("Factura", Type.GetType("System.Decimal"))
        Dim c11 As New DataGridTextBoxColumn
        c11.MappingName = "Total"
        c11.HeaderText = "Total"
        c11.ReadOnly = True
        c11.Width = 80
        c11.Format = "#0.00"
        c11.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c11)

        '.Add("Suma", Type.GetType("System.Decimal"))
        Dim c12 As New DataGridTextBoxColumn
        c12.MappingName = "Suma"
        c12.HeaderText = "Suma"
        c12.ReadOnly = True
        c12.Width = 80
        c12.Format = "#0.00"
        c12.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c12)

        '.Add("Estado", Type.GetType("System.String"))
        Dim c13 As New DataGridTextBoxColumn
        c13.MappingName = "Estado"
        c13.HeaderText = "Estado"
        c13.ReadOnly = True
        c13.Width = 50
        c13.Alignment = HorizontalAlignment.Right
        dt.GridColumnStyles.Add(c13)

        '.Add("NoFactura", Type.GetType("System.Int64"))
        dgDeuA.TableStyles.Clear()
        dgDeuA.TableStyles.Add(dt)
        'DgUsuarios.TableStyles.Clear()
        'DgUsuarios.TableStyles.Add(dt)
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl2.SelectedIndexChanged
        Select Case TabControl2.SelectedIndex
            Case 0
                Call Ver_Deudas(TxAbonado.Text)
            Case 1
                Call Ver_Historico(TxAbonado.Text)
            Case 2
                Call Ver_Ordenes_Servicio(TxAbonado.Text)
        End Select
    End Sub

    Private Sub Ver_Ordenes_Servicio(ByVal Abonado)
        Dim dOrd As New SqlDataAdapter("Select S.NoSolicitud, S.Fecha, L.Descripcion, S.Costo, S.Nota, S.Fec_Atendido, E.Paterno & ' ' & E.Materno & ' ' & E.Nombre as Tecnico, NoLista From ((Servicios_Solicitud S Inner Join Servicios_Lista L On S.Servicio = L.Servicio) Left Join Emp_Empleados E On S.Empleado = E.Codigo) Where S.Abonado = " & Abonado & " Order By NoSolicitud", db)
        Dim rOrd As New DataSet
        dOrd.Fill(rOrd, "Ordenes")
        dgOrdenes.DataSource = rOrd.Tables(0)
        Formatea_Ordenes_Servicio()
    End Sub

    Private Sub Formatea_Ordenes_Servicio()
        Dim dt As New DataGridTableStyle
        dt.MappingName = "Ordenes"

        Dim c1 As New DataGridTextBoxColumn
        c1.MappingName = "NoSolicitud"
        c1.HeaderText = "Solicitud"
        c1.ReadOnly = True
        c1.Width = 100
        dt.GridColumnStyles.Add(c1)

        Dim c2 As New DataGridTextBoxColumn
        c2.MappingName = "Fecha"
        c2.HeaderText = "Fecha"
        c2.ReadOnly = True
        c2.Width = 100
        dt.GridColumnStyles.Add(c2)

        Dim c3 As New DataGridTextBoxColumn
        c3.MappingName = "Descripcion"
        c3.HeaderText = "Servicio"
        c3.ReadOnly = True
        c3.Width = 300
        dt.GridColumnStyles.Add(c3)

        Dim c4 As New DataGridTextBoxColumn
        c4.MappingName = "Costo"
        c4.HeaderText = "Costo"
        c4.ReadOnly = True
        c4.Format = "#0.00"
        c4.Alignment = HorizontalAlignment.Right
        c4.Width = 100
        dt.GridColumnStyles.Add(c4)

        Dim c5 As New DataGridTextBoxColumn
        c5.MappingName = "Nota"
        c5.HeaderText = "Nota"
        c5.ReadOnly = True
        c5.Width = 200
        dt.GridColumnStyles.Add(c5)

        Dim c6 As New DataGridTextBoxColumn
        c6.MappingName = "Fec_Atendido"
        c6.HeaderText = "Atendido"
        c6.ReadOnly = True
        c6.Width = 100
        dt.GridColumnStyles.Add(c6)

        Dim c7 As New DataGridTextBoxColumn
        c7.MappingName = "Tecnico"
        c7.HeaderText = "Técnico"
        c7.ReadOnly = True
        c7.Width = 200
        dt.GridColumnStyles.Add(c7)

        Dim c8 As New DataGridTextBoxColumn
        c8.MappingName = "NoLista"
        c8.HeaderText = "No Lista"
        c8.ReadOnly = True
        c8.Width = 50
        dt.GridColumnStyles.Add(c8)

        dgOrdenes.TableStyles.Clear()
        dgOrdenes.TableStyles.Add(dt)
    End Sub

    Private Sub Con_recargos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdConRecargos.CheckedChanged, rdRecargosAntes.CheckedChanged, rdSinRecargos.CheckedChanged
        If TxAbonado.Text <> "" Then
            Call Ver_Deudas(TxAbonado.Text)
        End If
    End Sub

    Private Sub NuevaOrden(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevaOrden.Click

        Panel7.Visible = True
        txtCosto.Text = ""
        txtNota.Text = ""

        BtnNuevaOrden.Enabled = False
        BtnImprimirOrden.Enabled = False
        btnAnularOrden.Enabled = False
        gbDireccion.Visible = False
        gbCambioNombre.Visible = False
        gbCategoria.Visible = False

    End Sub

    Private Sub cboServicios_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboServicios.SelectionChangeCommitted
        Dim nCodServ As Integer = cboServicios.SelectedValue
        Dim dCosto As New SqlDataAdapter("Select Costo From Servicios_Lista Where Servicio = " & nCodServ, db)
        Dim rCosto As New DataSet
        dCosto.Fill(rCosto, "Costo")

        If rCosto.Tables(0).Rows.Count > 0 Then
            txtCosto.Text = Format(rCosto.Tables(0).Rows(0).Item(0), "#0.00")
        Else
            txtCosto.Clear()
        End If

        gbDireccion.Visible = False
        gbCambioNombre.Visible = False
        gbCategoria.Visible = False
        If cboServicios.SelectedValue = 1001 Then
            If TxCuenta.Text <> "Sin Conexión" Then
                MessageBox.Show("No puede conectarse mas de una vez a este usuario", "Error en el la selección de servicio", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        ElseIf cboServicios.SelectedValue = 1002 Then
            If TxCuenta.Text = "Cuenta Normal" Then
                MessageBox.Show("El usuario actualmente tiene una cuenta " & TxCuenta.Text, "Tenga cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf cboServicios.SelectedValue = 1006 Then
            gbDireccion.Visible = True
        ElseIf cboServicios.SelectedValue = 1007 Then
            gbCambioNombre.Visible = True
        ElseIf cboServicios.SelectedValue = 1008 Then
            gbCategoria.Visible = True
        ElseIf cboServicios.SelectedValue = 1009 Then
            If TxCuenta.Text <> "Cuenta Normal" Then
                MessageBox.Show("El usuario actualmente tiene una cuenta " & TxCuenta.Text, "Tenga cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        ElseIf cboServicios.SelectedValue = 1010 Then
            If TxCuenta.Text <> "Cuenta Normal" Then
                MessageBox.Show("El usuario actualmente tiene una cuenta " & TxCuenta.Text, "Tenga cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BtnCancelarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarOrden.Click
        Panel7.Visible = False
        BtnNuevaOrden.Enabled = True
        BtnImprimirOrden.Enabled = True
        btnAnularOrden.Enabled = True
    End Sub

    Private Sub GrabarOrden(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabarOrden.Click


        Dim dNumOrd As New SqlDataAdapter("Select Max(NoSolicitud) From Servicios_Solicitud", db)
        Dim rNumOrd As New DataSet
        Dim nNumOrd As Integer
        Dim cText As String
        Dim txtRep As String
        Dim gOrden As New SqlCommand

        If cboServicios.SelectedValue = 1001 Then
            If TxCuenta.Text <> "Sin Conexión" Then
                MessageBox.Show("No puede conectarse mas de una vez a este usuario", "Error en el la selección de servicio", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub
            End If
        End If
        Try
            dNumOrd.Fill(rNumOrd, "Nosolicitud")

            If rNumOrd.Tables(0).Rows.Count > 0 Then
                nNumOrd = IIf(IsDBNull(rNumOrd.Tables(0).Rows(0).Item(0)), 0, rNumOrd.Tables(0).Rows(0).Item(0)) + 1
            Else
                nNumOrd = 1
            End If

            If cboServicios.SelectedValue = 1007 Then
                cText = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Nombre, Doc, NoDoc, Nit, Nacimiento) Values ('" & _
                    nNumOrd & "','" & _
                    TxAbonado.Text & "','" & _
                    Date.Now & "','" & _
                    cboServicios.SelectedValue & "','" & _
                    txtCosto.Text & "','" & _
                    txtNota.Text & "','" & _
                    Empleado & "','" & _
                    Txt_Nombre.Text & "','" & _
                    cbo_Doc.Text & "','" & _
                    txt_NoDoc.Text & "','" & _
                    txt_Nit.Text & "','" & _
                    Format(dt_Nacimiento.Value, "dd/MM/yyyy") & "')"
                txtRep = "Insert Into Servicios_Reporte (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Nombre, Doc, NoDoc, Nit, Nacimiento) Values ('" & _
                    nNumOrd & "','" & _
                    TxAbonado.Text & "','" & _
                    Date.Now & "','" & _
                    cboServicios.SelectedValue & "','" & _
                    txtCosto.Text & "','" & _
                    txtNota.Text & "','" & _
                    Empleado & "','" & _
                    Txt_Nombre.Text & "','" & _
                    cbo_Doc.Text & "','" & _
                    txt_NoDoc.Text & "','" & _
                    txt_Nit.Text & "','" & _
                    Format(dt_Nacimiento.Value, "dd/MM/yyyy") & "')"
            ElseIf cboServicios.SelectedValue = 1006 Then
                cText = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Ruta, Subruta, Zona, Calle, Numero, NoRuta) Values ('" & _
                        nNumOrd & "','" & _
                        TxAbonado.Text & "','" & _
                        Date.Now & "','" & _
                        cboServicios.SelectedValue & "','" & _
                        txtCosto.Text & "','" & _
                        txtNota.Text & "','" & _
                        Empleado & "','" & _
                        cbo_Ruta.Text & "','" & _
                        cbo_SubRuta.Text & "','" & _
                        cbo_Zona.Text & "','" & _
                        cbo_Calle.Text & "','" & _
                        txt_Numero.Text & "','" & _
                        txtNoRuta.Text & "')"
                txtRep = "Insert Into Servicios_reporte (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Ruta, Subruta, Zona, Calle, Numero, NoRuta) Values ('" & _
                        nNumOrd & "','" & _
                        TxAbonado.Text & "','" & _
                        Date.Now & "','" & _
                        cboServicios.SelectedValue & "','" & _
                        txtCosto.Text & "','" & _
                        txtNota.Text & "','" & _
                        Empleado & "','" & _
                        cbo_Ruta.Text & "','" & _
                        cbo_SubRuta.Text & "','" & _
                        cbo_Zona.Text & "','" & _
                        cbo_Calle.Text & "','" & _
                        txt_Numero.Text & "','" & _
                        txtNoRuta.Text & "')"

            ElseIf cboServicios.SelectedValue = 1008 Then
                cText = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Categoria, Desc_Categoria) Values ('" & _
                        nNumOrd & "','" & _
                        TxAbonado.Text & "','" & _
                        Date.Now & "','" & _
                        cboServicios.SelectedValue & "','" & _
                        txtCosto.Text & "','" & _
                        txtNota.Text & "','" & _
                        Empleado & "','" & _
                        cbo_Categoria.SelectedValue & "','" & _
                        cbo_Categoria.Text & "')"
                txtRep = "Insert Into Servicios_Reporte (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Categoria, Desc_Categoria) Values ('" & _
                        nNumOrd & "','" & _
                        TxAbonado.Text & "','" & _
                        Date.Now & "','" & _
                        cboServicios.SelectedValue & "','" & _
                        txtCosto.Text & "','" & _
                        txtNota.Text & "','" & _
                        Empleado & "','" & _
                        cbo_Categoria.SelectedValue & "','" & _
                        cbo_Categoria.Text & "')"
            Else
                cText = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado) Values ('" & _
                        nNumOrd & "','" & _
                        TxAbonado.Text & "','" & _
                        Date.Now & "','" & _
                        cboServicios.SelectedValue & "','" & _
                        txtCosto.Text & "','" & _
                        txtNota.Text & "','" & _
                        Empleado & "')"

                txtRep = "Insert Into Servicios_Reporte (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Rep) Values ('" & _
                        nNumOrd & "','" & _
                        TxAbonado.Text & "','" & _
                        Date.Now & "','" & _
                        cboServicios.SelectedValue & "','" & _
                        txtCosto.Text & "','" & _
                        txtNota.Text & "','" & _
                        Empleado & "'," & chkRep.Checked & ")"
            End If

            db.Open()
            With gOrden
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = cText
                .ExecuteNonQuery()
            End With

            If chkRep.Checked = True Then
                cText = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Atendido, Elaborado) Values ('" & _
                            (nNumOrd + 1) & "','" & TxAbonado.Text & "','" & _
                            Format(Date.Now, "dd/MM/yyyy") & "','3000','1','Reposición de Formulario',True,'" & _
                            Empleado & "')"
                With gOrden
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = cText
                    .ExecuteNonQuery()
                End With
            End If

            cText = "Delete * From Servicios_Reporte"
            With gOrden
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = cText
                .ExecuteNonQuery()
            End With

            'cText = "Insert Into Servicios_Reporte (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado) Values ('" & _
            '        nNumOrd & "','" & _
            '        TxAbonado.Text & "','" & _
            '        Date.Now & "','" & _
            '        cboServicios.SelectedValue & "','" & _
            '        txtCosto.Text & "','" & _
            '        txtNota.Text & "','" & _
            '        Empleado & "')"

            With gOrden
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = txtRep
                .ExecuteNonQuery()
            End With

            BtnNuevaOrden.Enabled = True
            BtnImprimirOrden.Enabled = True
            btnAnularOrden.Enabled = True
            Panel7.Visible = False

            Call Ver_Ordenes_Servicio(TxAbonado.Text)


            Dim fRep As New Frm_Reportes

            If cboServicios.SelectedValue = 1006 Then
                Dim pRep As New Rep_OrdenServicio_CambioDireccion
                fRep.crvRep.ReportSource = pRep
            ElseIf cboServicios.SelectedValue = 1007 Then
                Dim pRep As New Rep_OrdenServicio_CambioNombre
                fRep.crvRep.ReportSource = pRep
            ElseIf cboServicios.SelectedValue = 1008 Then
                Dim prep As New Rep_OrdenServicio_CambioCategoria
                fRep.crvRep.ReportSource = prep
            Else
                Dim pRep As New Rep_OrdenServicio
                fRep.crvRep.ReportSource = pRep
            End If

            fRep.ShowDialog()

        Catch x As Exception
            MessageBox.Show(x.Message, "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Frm_Facturacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        dUsu.SelectCommand.CommandText = "Select Servicio, Descripcion From Servicios_Lista Order By Descripcion"
        dUsu.Fill(rUsu, "Servicios")

        cboServicios.DataSource = rUsu.Tables("Servicios")
        cboServicios.DisplayMember = rUsu.Tables("Servicios").Columns("Descripcion").ColumnName
        cboServicios.ValueMember = rUsu.Tables("Servicios").Columns("Servicio").ColumnName

        dUsu.SelectCommand.CommandText = "Select Distinct Ruta From Usuarios"
        dUsu.Fill(rUsu, "Rutas")
        cbo_Ruta.DataSource = rUsu.Tables("Rutas")
        cbo_Ruta.DisplayMember = rUsu.Tables("Rutas").Columns(0).ColumnName
        cbo_Ruta.ValueMember = rUsu.Tables("Rutas").Columns(0).ColumnName

        dUsu.SelectCommand.CommandText = "Select Categoria, Descripcion From Usuarios_Categorias"
        dUsu.Fill(rUsu, "Categorias")
        cbo_Categoria.DataSource = rUsu.Tables("Categorias")
        cbo_Categoria.DisplayMember = rUsu.Tables("Categorias").Columns(1).ColumnName
        cbo_Categoria.ValueMember = rUsu.Tables("Categorias").Columns(0).ColumnName
        'Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnNuevaBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevaBusqueda.Click
        rUsu.Tables("Usuarios").Clear()
        TxPaterno.Clear()
        TxNombre.Clear()
        TxPaterno.Focus()
    End Sub

    Private Sub cbo_Ruta_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        dUsu.SelectCommand.CommandText = "Select Distinct Zona From Usuarios Where Ruta = " & cbo_Ruta.SelectedValue
        dUsu.Fill(rUsu, "Zonas")
        rUsu.Tables("Zonas").Clear()
        dUsu.Fill(rUsu, "Zonas")
        cbo_Zona.DataSource = rUsu.Tables("Zonas")
        cbo_Zona.DisplayMember = rUsu.Tables("Zonas").Columns(0).ColumnName
        cbo_Zona.ValueMember = rUsu.Tables("Zonas").Columns(0).ColumnName

        dUsu.SelectCommand.CommandText = "Select Distinct Calle From Usuarios Where Ruta = " & cbo_Ruta.SelectedValue
        dUsu.Fill(rUsu, "Calles")
        rUsu.Tables("Calles").Clear()
        dUsu.Fill(rUsu, "Calles")
        cbo_Calle.DataSource = rUsu.Tables("Calles")
        cbo_Calle.DisplayMember = rUsu.Tables("Calles").Columns(0).ColumnName
        cbo_Calle.ValueMember = rUsu.Tables("Calles").Columns(0).ColumnName

        dUsu.SelectCommand.CommandText = "Select Distinct SubRuta From Usuarios Where Ruta = " & cbo_Ruta.SelectedValue
        dUsu.Fill(rUsu, "SubRutas")
        rUsu.Tables("SubRutas").Clear()
        dUsu.Fill(rUsu, "SubRutas")
        cbo_SubRuta.DataSource = rUsu.Tables("SubRutas")
        cbo_SubRuta.DisplayMember = rUsu.Tables("SubRutas").Columns(0).ColumnName
        cbo_SubRuta.ValueMember = rUsu.Tables("SubRutas").Columns(0).ColumnName
    End Sub

    Private Sub dgDeuA_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDeuA.DoubleClick
        Dim i As Integer
        Dim TieneFacturas As Boolean = False
        If pNum_Comprobante = 0 Then
            MessageBox.Show("No se puede facturar", "No esta habilitado el numero de comprobante", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If
        If pTieneDosis = False Then
            MessageBox.Show("No tiene dosificación de facturas", "No se puede Facturar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        For i = 0 To tTab.Rows.Count - 1
            If IsDBNull(tTab.Rows(i).Item("Estado")) Then
                'dMesano = dgDeuA.Item(dgDeuA.CurrentRowIndex, 0)
                dMesano = tTab.Rows(i).Item("Mes/Año")
                nImp_Reca = tTab.Rows(i).Item("Recargo")
                nImp_Repo = tTab.Rows(i).Item("Reposic")
                nImp_Fact = tTab.Rows(i).Item("Factura")
                TieneFacturas = True
                Exit For
            End If
        Next
        If TieneFacturas = False Then
            Exit Sub
        End If

        Dim dgm As New SqlConnection(cn)
        Dim dam As New SqlDataAdapter("Select * From Mes_" & Format(Month(dMesano), "00") & " Where Abonado = " & TxAbonado.Text, dgm)
        Dim cmd As New SqlCommand
        Dim txt As String
        Dim dsm As New DataSet
        'Dim i As Integer
        dam.Fill(dsm, "Fac")


        xNombre = TxUsuario.Text
        cNit = TxNIT.Text
        cDireccion = TxZona.Text & "-" & TxCalle.Text
        nAbonado = TxAbonado.Text
        cCategoria = TxCategoria.Text
        Fec_Pago = pFec_Pago

        If dsm.Tables("Fac").Rows.Count > 0 Then
            'Aumenta e 1 al número de factura
            'pNum_Factura_Final = Obtener_Numero_Factura(pNum_Autorizacion)

            'nNum_Factura = pNum_Factura_Final
            nNum_Autorizacion = pNum_Autorizacion
            Fec_Emision = dsm.Tables("Fac").Rows(0).Item("Emision")
            cClave_Cate = dsm.Tables("Fac").Rows(0).Item("Categoria")
            nLec_Actu = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Lectura")), 0, dsm.Tables("Fac").Rows(0).Item("Lectura"))
            nCon_M3 = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Con_m3")), 0, dsm.Tables("Fac").Rows(0).Item("Con_m3"))
            nLec_Ante = (nLec_Actu - nCon_M3)
            nImp_Fijo = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Fijo")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Fijo"))
            nImp_Adic = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Adic")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Adic"))
            nImp_Tota = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Total")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Total"))
            nImp_Alca = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Alcanta")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Alcanta"))
            'nImp_Reca = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Recargo")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Recargo"))
            'nImp_Repo = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Rep")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Rep"))
            nImp_Ser1 = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Car_1")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Car_1"))
            nImp_Ser2 = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Car_2")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Car_2"))
            nImp_Ley1 = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Ley1886_1")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Ley1886_1"))
            nImp_Ley2 = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Ley1886_2")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Ley1886_2"))
            'nImp_Fact = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Factura")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Factura"))

            nImp_Iva = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Iva")), (nImp_Tota * 0.13), dsm.Tables("Fac").Rows(0).Item("Imp_Iva"))
            nImp_Iva = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_ite")), (nImp_Tota * 0.03), dsm.Tables("Fac").Rows(0).Item("Imp_Ite"))
            cLiteral = Literal(nImp_Fact, "M")
            Dim CodCon As New CodigoV7
            CodCon.NoAutorizacion = nNum_Autorizacion
            CodCon.NoFactura = nNum_Factura
            CodCon.NoNit = cNit
            CodCon.Fecha = Fec_Pago
            CodCon.Importe = nImp_Fact
            'CodCon.Llave = pLlave
            cCodContr = CodCon.Codigo

            dUsu.SelectCommand.CommandText = "Select Top 6 Emision From Factores Where Emision < #" & Format(Fec_Emision, "dd/MM/yyyy") & "# Order By Emision Desc"
            dUsu.Fill(rUsu, "Emisiones")
            For i = 0 To rUsu.Tables("Emisiones").Rows.Count - 1
                hPeriodo(i) = rUsu.Tables("Emisiones").Rows(i).Item("Emision")
            Next
            rUsu.Tables("Emisiones").Clear()
            For i = 0 To 5
                Dim hcon As New SqlConnection(cn)
                Dim hds As New SqlDataAdapter("Select Emision, Con_m3, Imp_Factura, Fec_Pago From Mes_" & Format(Month(hPeriodo(i)), "00") & " Where Abonado = " & nAbonado, hcon)
                hds.Fill(dsm, "His")
                If dsm.Tables("His").Rows.Count > 0 Then
                    hConsumo(i) = IIf(IsDBNull(dsm.Tables("His").Rows(0).Item("Con_m3")), 0, dsm.Tables("His").Rows(0).Item("Con_m3"))
                    hImporte(i) = IIf(IsDBNull(dsm.Tables("His").Rows(0).Item("Imp_Factura")), 0, dsm.Tables("His").Rows(0).Item("Imp_Factura"))
                    hPagos(i) = IIf(IsDBNull(dsm.Tables("His").Rows(0).Item("Fec_Pago")), Format(Date.Now, "dd/MM/yyyy"), dsm.Tables("His").Rows(0).Item("Fec_Pago"))
                End If
                dsm.Tables("His").Clear()
            Next

            'Fec_Emision = pFec_Pago
            'Imp.Print()
            'Exit Sub
            '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
            txt = "Update Mes_" & Format(Month(dMesano), "00") & " Set Fec_Pago = '" & Format(Fec_Pago, "dd/MM/yyyy") & "', Num_Factura = " & nNum_Factura & ", Num_Orden = " & nNum_Autorizacion & " Where Abonado = " & nAbonado
            dgm.Open()
            With cmd
                .Connection = dgm
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With

            Dim dDia As New SqlConnection(cn)
            dDia.Open()
            txt = "Insert Into Dia_" & Format(Month(Fec_Pago), "00") & " (Num_Factura, Num_Orden, Codigo_Control, Emision, Abonado, Nombre, Categoria, Lectura, Con_m3, Imp_Fijo, Imp_Adic, Imp_Total, Imp_alcanta, Imp_Rep, Imp_Car_1, IMp_Car_2, Imp_Recargo, Imp_Ley1886_1, Imp_Ley1886_2, Imp_Iva, Imp_Ite, IMp_Factura, Nit, Fec_Pago, Comprobante, Anulado, Cajero) Values ('" & _
            nNum_Factura & "','" & nNum_Autorizacion & "','" & cCodContr & "','" & Fec_Emision & "','" & nAbonado & "','" & xNombre & "','" & cClave_Cate & "','" & nLec_Actu & "','" & nCon_M3 & "','" & _
            nImp_Fijo & "','" & nImp_Adic & "','" & nImp_Tota & "','" & nImp_Alca & "','" & nImp_Repo & "','" & nImp_Ser1 & "','" & nImp_Ser2 & "','" & nImp_Reca & "','" & nImp_Ley1 & "','" & nImp_Ley2 & "','" & nImp_Iva & "','" & nImp_Ite & "','" & nImp_Fact & "','" & _
            cNit & "','" & Format(Fec_Pago, "dd/MM/yyyy") & "','" & pNum_Comprobante & "','V','" & Empleado & "')"
            With cmd
                .Connection = dDia
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With
            dDia.Close()

            txt = "Update Control Set " & Format(dMesano, "MMM") & " = '1' Where Abonado = " & nAbonado
            With cmd
                .Connection = dgm
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With
            dgm.Close()

            db.Open()
            txt = "Update Dosificacion SEt NoFinal = " & nNum_Factura & " Where Autorizacion = " & nNum_Autorizacion
            With cmd
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With
            db.Close()
            For i = 0 To tTab.Rows.Count - 1
                If tTab.Rows(i).Item("Mes/Año") = dMesano Then
                    tTab.Rows(i).Item("Estado") = "Pagado"
                End If
            Next

            Fec_Emision = pFec_Pago
            'Prev.Document = Imp
            'Prev.ShowDialog()
            Imp.Print()
        End If
    End Sub

    Private Sub Imp_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Imp.PrintPage
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
        Dim dfecfin As Date

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

        'e.Graphics.DrawString("1023807025", nFont, Brushes.Black, 450, 10)
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 460, 40)
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 460, 55)

        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, 165)
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, 180)
        e.Graphics.DrawString(cDireccion, sfont, Brushes.Black, 100, 195)
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, 210)
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 100, 245)
        dfecfin = Obtener_Fecha_Fin_Autorizacion(nNum_Autorizacion)

        If dMesano = CDate("04/07/2011") Then
            e.Graphics.DrawString("JUN2011", sfont, Brushes.Black, 450, 165)
        Else
            e.Graphics.DrawString(Format(dMesano, "MMMM - yyyy"), sfont, Brushes.Black, 450, 165)
        End If
        'e.Graphics.DrawString("MAR-ABR/2008", sfont, Brushes.Black, 450, 165)
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, 180)
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, 210)
        e.Graphics.DrawString(nLec_Ante, sfont, Brushes.Black, 400, 225)
        e.Graphics.DrawString(nLec_Actu, sfont, Brushes.Black, 500, 225)
        e.Graphics.DrawString(nCon_M3, sfont, Brushes.Black, 400, 240)

        'e.Graphics.DrawString("Importe Consumo Fijo", sfont, Brushes.Black, 150, 300)
        'e.Graphics.DrawString("Importe Consumo Adicional", sfont, Brushes.Black, 150, 320)
        'e.Graphics.DrawString("SUBTOTAL SERVICIO DE AGUA", nFont, Brushes.Black, 150, 340)
        'e.Graphics.DrawString("Importe Alcantarrillado", sfont, Brushes.Black, 150, 360)
        'e.Graphics.DrawString("Importe Recargos", sfont, Brushes.Black, 150, 380)
        'e.Graphics.DrawString("Importe Reposición Formulario", sfont, Brushes.Black, 150, 400)
        'e.Graphics.DrawString("IMPORTE TOTAL SERVICIOS", nFont, Brushes.Black, 150, 420)
        'e.Graphics.DrawString("Cargos 1 Servicio Agua Potable", sfont, Brushes.Black, 150, 440)
        'e.Graphics.DrawString("Cargos 2 Servicio Alcantarrillado", sfont, Brushes.Black, 150, 460)
        'e.Graphics.DrawString("(-) Descuento Ley 1886", sfont, Brushes.Black, 150, 480)

        e.Graphics.DrawString("Importe consumo Fijo", sfont, Brushes.Black, 120, 330)
        e.Graphics.DrawString("Importe consumo Excedente", sfont, Brushes.Black, 120, 342)
        e.Graphics.DrawString("SUBTOTAL SERVICIO DE AGUA", nFont, Brushes.Black, 120, 354)
        e.Graphics.DrawString("Alcantarrillado", sfont, Brushes.Black, 120, 366)
        e.Graphics.DrawString("Recargos", sfont, Brushes.Black, 120, 378)
        e.Graphics.DrawString("Rep. de formulario", sfont, Brushes.Black, 120, 390)
        e.Graphics.DrawString("TOTAL SERVICIOS", nFont, Brushes.Black, 120, 402)
        e.Graphics.DrawString("Cargo 1 Servicio de agua potable", sfont, Brushes.Black, 120, 414)
        e.Graphics.DrawString("Cargo 2 Servicio de Alcantarrillado", sfont, Brushes.Black, 120, 426)
        e.Graphics.DrawString("Descuento Ley 1886", sfont, Brushes.Black, 120, 438)

        e.Graphics.DrawString(Format(nImp_Fijo, "#0.00"), sfont, Brushes.Black, (520 - fijosize.Width), 330)
        e.Graphics.DrawString(Format(nImp_Adic, "#0.00"), sfont, Brushes.Black, (520 - adicsize.Width), 342)
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic, "#0.00"), nFont, Brushes.Black, (520 - totasize.Width), 354)
        e.Graphics.DrawString(Format(nImp_Alca, "#0.00"), sfont, Brushes.Black, (520 - alcasize.Width), 366)
        e.Graphics.DrawString(Format(nImp_Reca, "#0.00"), sfont, Brushes.Black, (520 - recasize.Width), 378)
        e.Graphics.DrawString(Format(nImp_Repo, "#0.00"), sfont, Brushes.Black, (520 - reposize.Width), 390)
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic + nImp_Alca + nImp_Reca + nImp_Repo, "#0.00"), nFont, Brushes.Black, (520 - tosesize.Width), 402)
        e.Graphics.DrawString(Format(nImp_Ser1, "#0.00"), sfont, Brushes.Black, (520 - ser1size.Width), 414)
        e.Graphics.DrawString(Format(nImp_Ser2, "#0.00"), sfont, Brushes.Black, (520 - ser2size.Width), 426)
        e.Graphics.DrawString(Format((nImp_Ley1 + nImp_Ley2), "#0.00"), sfont, Brushes.Black, (520 - ley1size.Width), 438)
        e.Graphics.DrawString(Format(nImp_Fact, "#0.00"), nFont, Brushes.Black, (520 - tofasize.Width), 518)
        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, 518)
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, 532)
        e.Graphics.DrawString(dfecfin, sfont, Brushes.Black, 450, 532)


        e.Graphics.DrawString(Format(hPeriodo(0), "MMM/yyyy"), sfont, Brushes.Black, 575, 400)
        e.Graphics.DrawString(Format(hPeriodo(1), "MMM/yyyy"), sfont, Brushes.Black, 575, 420)
        e.Graphics.DrawString(Format(hPeriodo(2), "MMM/yyyy"), sfont, Brushes.Black, 575, 440)
        e.Graphics.DrawString(Format(hPeriodo(3), "MMM/yyyy"), sfont, Brushes.Black, 575, 460)
        e.Graphics.DrawString(Format(hPeriodo(4), "MMM/yyyy"), sfont, Brushes.Black, 575, 480)
        e.Graphics.DrawString(Format(hPeriodo(5), "MMM/yyyy"), sfont, Brushes.Black, 575, 500)

        e.Graphics.DrawString(Format(hConsumo(0), "0000"), sfont, Brushes.Black, 640, 400)
        e.Graphics.DrawString(Format(hConsumo(1), "0000"), sfont, Brushes.Black, 640, 420)
        e.Graphics.DrawString(Format(hConsumo(2), "0000"), sfont, Brushes.Black, 640, 440)
        e.Graphics.DrawString(Format(hConsumo(3), "0000"), sfont, Brushes.Black, 640, 460)
        e.Graphics.DrawString(Format(hConsumo(4), "0000"), sfont, Brushes.Black, 640, 480)
        e.Graphics.DrawString(Format(hConsumo(5), "0000"), sfont, Brushes.Black, 640, 500)

        e.Graphics.DrawString(Format(hImporte(0), "#0.00"), sfont, Brushes.Black, 690, 400)
        e.Graphics.DrawString(Format(hImporte(1), "#0.00"), sfont, Brushes.Black, 690, 420)
        e.Graphics.DrawString(Format(hImporte(2), "#0.00"), sfont, Brushes.Black, 690, 440)
        e.Graphics.DrawString(Format(hImporte(3), "#0.00"), sfont, Brushes.Black, 690, 460)
        e.Graphics.DrawString(Format(hImporte(4), "#0.00"), sfont, Brushes.Black, 690, 480)
        e.Graphics.DrawString(Format(hImporte(5), "#0.00"), sfont, Brushes.Black, 690, 500)

        e.Graphics.DrawString(Format(hPagos(0), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 400)
        e.Graphics.DrawString(Format(hPagos(1), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 420)
        e.Graphics.DrawString(Format(hPagos(2), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 440)
        e.Graphics.DrawString(Format(hPagos(3), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 460)
        e.Graphics.DrawString(Format(hPagos(4), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 480)
        e.Graphics.DrawString(Format(hPagos(5), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 500)


        '------------ COPIA ------------
        'e.Graphics.DrawString("1023807025", nFont, Brushes.Black, 450, 555)
        e.Graphics.DrawString(nNum_Factura, nFont, Brushes.Black, 460, 688)
        e.Graphics.DrawString(nNum_Autorizacion, nFont, Brushes.Black, 460, 700)

        e.Graphics.DrawString(xNombre, sfont, Brushes.Black, 100, 820)
        e.Graphics.DrawString(cNit, sfont, Brushes.Black, 100, 835)
        e.Graphics.DrawString(cDireccion, sfont, Brushes.Black, 100, 850)
        e.Graphics.DrawString(nAbonado, sfont, Brushes.Black, 100, 865)
        e.Graphics.DrawString(cCategoria, sfont, Brushes.Black, 100, 880)

        If dMesano = CDate("04/07/2011") Then
            e.Graphics.DrawString("JUN2011", sfont, Brushes.Black, 450, 820)
        Else
            e.Graphics.DrawString(Format(dMesano, "MMMM - yyyy"), sfont, Brushes.Black, 450, 820)
        End If

        'e.Graphics.DrawString(Format("MAR-ABR/2008"), sfont, Brushes.Black, 450, 820)
        e.Graphics.DrawString(Format(Fec_Emision, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, 835)
        e.Graphics.DrawString(Format(Fec_Pago, "dd/MMM/yyyy"), sfont, Brushes.Black, 450, 865)
        e.Graphics.DrawString(nLec_Ante, sfont, Brushes.Black, 400, 880)
        e.Graphics.DrawString(nLec_Actu, sfont, Brushes.Black, 500, 880)
        e.Graphics.DrawString(nCon_M3, sfont, Brushes.Black, 400, 895)

        'e.Graphics.DrawString("Importe Consumo Fijo", sfont, Brushes.Black, 150, 300)
        'e.Graphics.DrawString("Importe Consumo Adicional", sfont, Brushes.Black, 150, 320)
        'e.Graphics.DrawString("SUBTOTAL SERVICIO DE AGUA", nFont, Brushes.Black, 150, 340)
        'e.Graphics.DrawString("Importe Alcantarrillado", sfont, Brushes.Black, 150, 360)
        'e.Graphics.DrawString("Importe Recargos", sfont, Brushes.Black, 150, 380)
        'e.Graphics.DrawString("Importe Reposición Formulario", sfont, Brushes.Black, 150, 400)
        'e.Graphics.DrawString("IMPORTE TOTAL SERVICIOS", nFont, Brushes.Black, 150, 420)
        'e.Graphics.DrawString("Cargos 1 Servicio Agua Potable", sfont, Brushes.Black, 150, 440)
        'e.Graphics.DrawString("Cargos 2 Servicio Alcantarrillado", sfont, Brushes.Black, 150, 460)
        'e.Graphics.DrawString("(-) Descuento Ley 1886", sfont, Brushes.Black, 150, 480)


        e.Graphics.DrawString("Importe consumo Fijo", sfont, Brushes.Black, 120, 975)
        e.Graphics.DrawString("Importe consumo Excedente", sfont, Brushes.Black, 120, 987)
        e.Graphics.DrawString("SUBTOTAL SERVICIO DE AGUA", nFont, Brushes.Black, 120, 999)
        e.Graphics.DrawString("Alcantarrillado", sfont, Brushes.Black, 120, 1011)
        e.Graphics.DrawString("Recargos", sfont, Brushes.Black, 120, 1023)
        e.Graphics.DrawString("Rep. de formulario", sfont, Brushes.Black, 120, 1035)
        e.Graphics.DrawString("TOTAL SERVICIOS", nFont, Brushes.Black, 120, 1047)
        e.Graphics.DrawString("Cargo 1 Servicio de agua potable", sfont, Brushes.Black, 120, 1059)
        e.Graphics.DrawString("Cargo 2 Servicio de Alcantarrillado", sfont, Brushes.Black, 120, 1071)
        e.Graphics.DrawString("Descuento Ley 1886", sfont, Brushes.Black, 120, 1083)

        e.Graphics.DrawString(Format(nImp_Fijo, "#0.00"), sfont, Brushes.Black, (520 - fijosize.Width), 975)
        e.Graphics.DrawString(Format(nImp_Adic, "#0.00"), sfont, Brushes.Black, (520 - adicsize.Width), 987)
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic, "#0.00"), nFont, Brushes.Black, (520 - totasize.Width), 999)
        e.Graphics.DrawString(Format(nImp_Alca, "#0.00"), sfont, Brushes.Black, (520 - alcasize.Width), 1011)
        e.Graphics.DrawString(Format(nImp_Reca, "#0.00"), sfont, Brushes.Black, (520 - recasize.Width), 1023)
        e.Graphics.DrawString(Format(nImp_Repo, "#0.00"), sfont, Brushes.Black, (520 - reposize.Width), 1035)
        e.Graphics.DrawString(Format(nImp_Fijo + nImp_Adic + nImp_Alca + nImp_Reca + nImp_Repo, "#0.00"), nFont, Brushes.Black, (520 - tosesize.Width), 1047)
        e.Graphics.DrawString(Format(nImp_Ser1, "#0.00"), sfont, Brushes.Black, (520 - ser1size.Width), 1059)
        e.Graphics.DrawString(Format(nImp_Ser2, "#0.00"), sfont, Brushes.Black, (520 - ser2size.Width), 1071)
        e.Graphics.DrawString(Format((nImp_Ley1 + nImp_Ley2), "#0.00"), sfont, Brushes.Black, (520 - ley1size.Width), 1083)
        e.Graphics.DrawString(Format(nImp_Fact, "#0.00"), nFont, Brushes.Black, (520 - tofasize.Width), 1163)

        e.Graphics.DrawString(cLiteral, sfont, Brushes.Black, 50, 1163)
        e.Graphics.DrawString(cCodContr, sfont, Brushes.Black, 150, 1181)
        e.Graphics.DrawString(dfecfin, sfont, Brushes.Black, 450, 1181)

        e.Graphics.DrawString(Format(hPeriodo(0), "MMM/yyyy"), sfont, Brushes.Black, 575, 1047)
        e.Graphics.DrawString(Format(hPeriodo(1), "MMM/yyyy"), sfont, Brushes.Black, 575, 1067)
        e.Graphics.DrawString(Format(hPeriodo(2), "MMM/yyyy"), sfont, Brushes.Black, 575, 1087)
        e.Graphics.DrawString(Format(hPeriodo(3), "MMM/yyyy"), sfont, Brushes.Black, 575, 1107)
        e.Graphics.DrawString(Format(hPeriodo(4), "MMM/yyyy"), sfont, Brushes.Black, 575, 1127)
        e.Graphics.DrawString(Format(hPeriodo(5), "MMM/yyyy"), sfont, Brushes.Black, 575, 1147)

        e.Graphics.DrawString(Format(hConsumo(0), "0000"), sfont, Brushes.Black, 640, 1047)
        e.Graphics.DrawString(Format(hConsumo(1), "0000"), sfont, Brushes.Black, 640, 1067)
        e.Graphics.DrawString(Format(hConsumo(2), "0000"), sfont, Brushes.Black, 640, 1087)
        e.Graphics.DrawString(Format(hConsumo(3), "0000"), sfont, Brushes.Black, 640, 1107)
        e.Graphics.DrawString(Format(hConsumo(4), "0000"), sfont, Brushes.Black, 640, 1127)
        e.Graphics.DrawString(Format(hConsumo(5), "0000"), sfont, Brushes.Black, 640, 1147)

        e.Graphics.DrawString(Format(hImporte(0), "#0.00"), sfont, Brushes.Black, 690, 1047)
        e.Graphics.DrawString(Format(hImporte(1), "#0.00"), sfont, Brushes.Black, 690, 1067)
        e.Graphics.DrawString(Format(hImporte(2), "#0.00"), sfont, Brushes.Black, 690, 1087)
        e.Graphics.DrawString(Format(hImporte(3), "#0.00"), sfont, Brushes.Black, 690, 1107)
        e.Graphics.DrawString(Format(hImporte(4), "#0.00"), sfont, Brushes.Black, 690, 1127)
        e.Graphics.DrawString(Format(hImporte(5), "#0.00"), sfont, Brushes.Black, 690, 1147)

        e.Graphics.DrawString(Format(hPagos(0), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 1047)
        e.Graphics.DrawString(Format(hPagos(1), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 1067)
        e.Graphics.DrawString(Format(hPagos(2), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 1087)
        e.Graphics.DrawString(Format(hPagos(3), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 1107)
        e.Graphics.DrawString(Format(hPagos(4), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 1127)
        e.Graphics.DrawString(Format(hPagos(5), "dd/MM/yyyy"), sfont, Brushes.Black, 740, 1147)

    End Sub

    Private Sub dgDeuB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDeuB.DoubleClick
        Dim i As Integer
        Dim TieneFacturas As Boolean = False
        If pNum_Comprobante = 0 Then
            MessageBox.Show("No se puede facturar", "No esta habilitado el numero de comprobante", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

        For i = 0 To tTaD.Rows.Count - 1
            If IsDBNull(tTaD.Rows(i).Item("Estado")) Then
                dMesano = tTaD.Rows(i).Item("Mes/Año")
                TieneFacturas = True
                Exit For
            End If
        Next

        If TieneFacturas = False Then
            Exit Sub
        End If

        Dim dgm As New SqlConnection(cn)
        Dim dam As New SqlDataAdapter("", dgm)
        If dMesano = CDate("04/07/2011") Then
            dam.SelectCommand.CommandText = "Select * From Mes_06 Where Abonado = " & TxAbonado.Text
        Else
            dam.SelectCommand.CommandText = "Select * From Mes_" & Format(Month(dMesano), "00") & " Where Abonado = " & TxAbonado.Text
        End If

        Dim cmd As New SqlCommand
        Dim txt As String
        Dim dsm As New DataSet
        'Dim i As Integer
        dam.Fill(dsm, "Fac")

        xNombre = TxUsuario.Text
        cNit = TxNIT.Text
        cDireccion = TxZona.Text & "-" & TxCalle.Text
        nAbonado = TxAbonado.Text
        cCategoria = TxCategoria.Text
        Fec_Pago = pFec_Pago

        If dsm.Tables("Fac").Rows.Count > 0 Then
            nNum_Factura = dsm.Tables("Fac").Rows(0).Item("Num_Factura")
            nNum_Autorizacion = dsm.Tables("Fac").Rows(0).Item("Num_Orden")
            Fec_Emision = dsm.Tables("Fac").Rows(0).Item("Emision")
            cClave_Cate = dsm.Tables("Fac").Rows(0).Item("Categoria")
            nLec_Actu = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Lectura")), 0, dsm.Tables("Fac").Rows(0).Item("Lectura"))
            nCon_M3 = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Con_m3")), 0, dsm.Tables("Fac").Rows(0).Item("Con_m3"))
            nLec_Ante = (nLec_Actu - nCon_M3)
            nImp_Fijo = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Fijo")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Fijo"))
            nImp_Adic = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Adic")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Adic"))
            nImp_Tota = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Total")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Total"))
            nImp_Alca = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Alcanta")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Alcanta"))
            nImp_Reca = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Recargo")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Recargo"))
            nImp_Repo = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Rep")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Rep"))
            nImp_Ser1 = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Car_1")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Car_1"))
            nImp_Ser2 = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Car_2")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Car_2"))
            nImp_Ley1 = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Ley1886_1")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Ley1886_1"))
            nImp_Ley2 = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Ley1886_2")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Ley1886_2"))
            nImp_Fact = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Factura")), 0, dsm.Tables("Fac").Rows(0).Item("Imp_Factura"))
            nImp_Iva = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_Iva")), (nImp_Tota * 0.13), dsm.Tables("Fac").Rows(0).Item("Imp_Iva"))
            nImp_Iva = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Imp_ite")), (nImp_Tota * 0.03), dsm.Tables("Fac").Rows(0).Item("Imp_Ite"))
            cLiteral = Literal(nImp_Fact, "M")
            'Dim CodCon As New Codigov7
            'CodCon.NoAutorizacion = nNum_Autorizacion
            'CodCon.NoFactura = nNum_Factura
            'CodCon.NoNit = cNit
            'CodCon.Fecha = Fec_Pago
            'CodCon.Importe = nImp_Fact
            'CodCon.Llave = pLlave
            'cCodContr = CodCon.Codigo
            'cCodContr = ObtenerCodigo(nNum_Autorizacion, nNum_Factura, cNit, Fec_Pago, nImp_Fact, pLlave)
            cCodContr = IIf(IsDBNull(dsm.Tables("Fac").Rows(0).Item("Codigo_Control")), " ", dsm.Tables("Fac").Rows(0).Item("Codigo_Control"))

            'nRecargo = Recargos(Val(TxAbonado.Text), dMesano)

            dUsu.SelectCommand.CommandText = "Select Top 6 Emision From Factores Where Emision < #" & Fec_Emision & "# Order By Emision Desc"
            dUsu.Fill(rUsu, "Emisiones")
            For i = 0 To rUsu.Tables("Emisiones").Rows.Count - 1
                hPeriodo(i) = rUsu.Tables("Emisiones").Rows(i).Item("Emision")
            Next
            rUsu.Tables("Emisiones").Clear()
            For i = 0 To 5
                Dim hcon As New SqlConnection(cn)
                Dim hds As New SqlDataAdapter("Select Emision, Con_m3, Imp_Factura, Fec_Pago From Mes_" & Format(Month(hPeriodo(i)), "00") & " Where Abonado = " & nAbonado, hcon)
                hds.Fill(dsm, "His")
                If dsm.Tables("His").Rows.Count > 0 Then
                    hConsumo(i) = IIf(IsDBNull(dsm.Tables("His").Rows(0).Item("Con_m3")), 0, dsm.Tables("His").Rows(0).Item("Con_m3"))
                    hImporte(i) = IIf(IsDBNull(dsm.Tables("His").Rows(0).Item("Imp_Factura")), 0, dsm.Tables("His").Rows(0).Item("Imp_Factura"))
                    hPagos(i) = IIf(IsDBNull(dsm.Tables("His").Rows(0).Item("Fec_Pago")), Format(Date.Now, "dd/MM/yyyy"), dsm.Tables("His").Rows(0).Item("Fec_Pago"))
                End If
                dsm.Tables("His").Clear()
            Next

            'Imp.Print()
            'Exit Sub
            '-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
            If dMesano = CDate("04/07/2011") Then
                txt = "Update Mes_06 Set Fec_Pago = '" & Format(Fec_Pago, "dd/MM/yyyy") & "', Num_Factura = " & nNum_Factura & ", Num_Orden = " & nNum_Autorizacion & " Where Abonado = " & nAbonado
            Else
                txt = "Update Mes_" & Format(Month(dMesano), "00") & " Set Fec_Pago = '" & Format(Fec_Pago, "dd/MM/yyyy") & "', Num_Factura = " & nNum_Factura & ", Num_Orden = " & nNum_Autorizacion & " Where Abonado = " & nAbonado
            End If

            dgm.Open()
            With cmd
                .Connection = dgm
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With

            Dim dDia As New SqlConnection(cn)
            dDia.Open()

            txt = "Insert Into Dia_" & Format(Month(Fec_Pago), "00") & " (Num_Factura, Num_Orden, Codigo_Control, Emision, Abonado, Nombre, Categoria, Lectura, Con_m3, Imp_Fijo, Imp_Adic, Imp_Total, Imp_alcanta, Imp_Rep, Imp_Car_1, IMp_Car_2, Imp_Recargo, Imp_Ley1886_1, Imp_Ley1886_2, Imp_Iva, Imp_Ite, IMp_Factura, Nit, Fec_Pago, Comprobante, Anulado, Cajero) Values ('" & _
            nNum_Factura & "','" & nNum_Autorizacion & "','" & cCodContr & "','" & Fec_Emision & "','" & nAbonado & "','" & xNombre & "','" & cClave_Cate & "','" & nLec_Actu & "','" & nCon_M3 & "','" & _
            nImp_Fijo & "','" & nImp_Adic & "','" & nImp_Tota & "','" & nImp_Alca & "','" & nImp_Repo & "','" & nImp_Ser1 & "','" & nImp_Ser2 & "','" & nImp_Reca & "','" & nImp_Ley1 & "','" & nImp_Ley2 & "','" & nImp_Iva & "','" & nImp_Ite & "','" & nImp_Fact & "','" & _
            cNit & "','" & Format(Fec_Pago, "dd/MM/yyyy") & "','" & pNum_Comprobante & "','V','" & Empleado & "')"
            With cmd
                .Connection = dDia
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With
            dDia.Close()

            If dMesano = CDate("04/07/2011") Then
                txt = "Update Control Set Jun = '1' Where Abonado = " & nAbonado
            Else
                txt = "Update Control Set " & Format(dMesano, "MMM") & " = '1' Where Abonado = " & nAbonado
            End If

            With cmd
                .Connection = dgm
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With

            dgm.Close()

            'db.Open()
            'If nRecargo > 0 Then
            '    txt = "Insert Into Recargos (Abonado, Pago, Emision, Importe) Values ('" & nAbonado & "','" & Format(Date.Now, "dd/MM/yyyy") & "','" & Format(dMesano, "dd/MM/yyyy") & "','" & nRecargo & "')"
            '    With cmd
            '        .Connection = db
            '        .CommandType = CommandType.Text
            '        .CommandText = txt
            '        .ExecuteNonQuery()
            '    End With
            'End If
            'db.Close()

            For i = 0 To tTaD.Rows.Count - 1
                If tTaD.Rows(i).Item("Mes/Año") = dMesano Then
                    tTaD.Rows(i).Item("Estado") = "Pagado"
                End If
            Next
            'Prev.Document = Imp
            'Prev.ShowDialog()
            Imp.Print()
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel8.Visible = Not Panel8.Visible
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'nAbonado = dgUsuarios.Item(dgUsuarios.CurrentRowIndex, 0)
        Dim frmRec As New Frm_Recalculo_Facturas
        'frmRec.MdiParent = Me
        frmRec.ShowDialog()
    End Sub

    Private Sub BtnImpDeudas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImpDeudas.Click
        Dim I As Integer
        Dim dEmi As Date
        Dim nLec As Double
        Dim cTip As String
        Dim nCon As Double
        Dim nImp As Double
        Dim nAlc As Double
        Dim nRec As Double
        Dim nRep As Double
        Dim nCa1 As Double
        Dim nCa2 As Double
        Dim nFac As Double
        Dim nNFa As Double
        Dim cEst As String
        Dim CMD As New SqlCommand
        Dim TXT As String

        db.Open()
        TXT = "Delete * from Kardex"
        With CMD
            .CommandText = TXT
            .CommandType = CommandType.Text
            .Connection = db
            .ExecuteNonQuery()
        End With

        For I = 0 To tTab.Rows.Count - 1
            dEmi = tTab.Rows(I).Item("Mes/Año")
            nLec = tTab.Rows(I).Item("Lectura")
            cTip = tTab.Rows(I).Item("Tipo")
            nCon = tTab.Rows(I).Item("Consumo")
            nImp = tTab.Rows(I).Item("Importe")
            nAlc = tTab.Rows(I).Item("Alcanta")
            nRec = tTab.Rows(I).Item("Recargo")
            nRep = tTab.Rows(I).Item("Reposic")
            nCa1 = tTab.Rows(I).Item("Cargos1")
            nCa2 = tTab.Rows(I).Item("Cargos2")
            nFac = tTab.Rows(I).Item("Factura")
            nNFa = tTab.Rows(I).Item("NoFactura")
            If IsDBNull(tTab.Rows(I).Item("Estado")) Then
                cEst = "Deuda"
            Else
                cEst = tTab.Rows(I).Item("Estado")
            End If

            TXT = "INSERT INTO KARDEX (ABONADO, EMISION, LECTURA, TIPO, CONSUMO, IMPORTE, ALCANTA, RECARGO, REPOSIC, CARGOS_1, CARGOS_2, FACTURA, NOFACTURA, ESTADO) VALUES ('" & _
            Val(TxAbonado.Text) & "','" & dEmi & "','" & nLec & "','" & _
            cTip & "','" & nCon & "','" & nImp & "','" & _
            nAlc & "','" & nRec & "','" & nRep & "','" & nCa1 & "','" & _
            nCa2 & "','" & nFac & "','" & nNFa & "','" & cEst & "')"

            With CMD
                .CommandText = TXT
                .CommandType = CommandType.Text
                .Connection = db
                .ExecuteNonQuery()
            End With
        Next

        For I = 0 To tTaD.Rows.Count - 1
            dEmi = tTaD.Rows(I).Item("Mes/Año")
            nLec = tTaD.Rows(I).Item("Lectura")
            cTip = tTaD.Rows(I).Item("Tipo")
            nCon = tTaD.Rows(I).Item("Consumo")
            nImp = tTaD.Rows(I).Item("Importe")
            nAlc = tTaD.Rows(I).Item("Alcanta")
            nRec = tTaD.Rows(I).Item("Recargo")
            nRep = tTaD.Rows(I).Item("Reposic")
            nCa1 = tTaD.Rows(I).Item("Cargos1")
            nCa2 = tTaD.Rows(I).Item("Cargos2")
            nFac = tTaD.Rows(I).Item("Factura")
            nNFa = tTaD.Rows(I).Item("NoFactura")
            If IsDBNull(tTaD.Rows(I).Item("Estado")) Then
                cEst = "Deuda"
            Else
                cEst = tTaD.Rows(I).Item("Estado")
            End If

            TXT = "INSERT INTO KARDEX (ABONADO, EMISION, LECTURA, TIPO, CONSUMO, IMPORTE, ALCANTA, RECARGO, REPOSIC, CARGOS_1, CARGOS_2, FACTURA, NOFACTURA, Estado) VALUES ('" & _
            Val(TxAbonado.Text) & "','" & dEmi & "','" & nLec & "','" & _
            cTip & "','" & nCon & "','" & nImp & "','" & _
            nAlc & "','" & nRec & "','" & nRep & "','" & nCa1 & "','" & _
            nCa2 & "','" & nFac & "','" & nNFa & "','" & cEst & "')"

            With CMD
                .CommandText = TXT
                .CommandType = CommandType.Text
                .Connection = db
                .ExecuteNonQuery()
            End With
        Next
        db.Close()
        Dim frep As New Frm_Reportes
        'Dim rep As New Rep_Kardex
        'frep.crvRep.ReportSource = rep
        frep.ShowDialog()
    End Sub

    Private Sub btnImprimeHistorico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimeHistorico.Click
        Dim I As Integer
        Dim dEmi As Date
        Dim nLec As Double
        Dim cTip As String
        Dim nCon As Double
        Dim nImp As Double
        Dim nAlc As Double
        Dim nRec As Double
        Dim nRep As Double
        Dim nCa1 As Double
        Dim nCa2 As Double
        Dim nFac As Double
        Dim nNFa As Double
        Dim cEst As String
        Dim dPag As Date
        Dim CMD As New SqlCommand
        Dim TXT As String

        db.Open()
        TXT = "Delete * from Kardex"
        With CMD
            .CommandText = TXT
            .CommandType = CommandType.Text
            .Connection = db
            .ExecuteNonQuery()
        End With

        For I = 0 To tTab.Rows.Count - 1
            dEmi = tTab.Rows(I).Item("Mes/Año")
            nLec = tTab.Rows(I).Item("Lectura")
            cTip = tTab.Rows(I).Item("Tipo")
            nCon = tTab.Rows(I).Item("Consumo")
            nImp = tTab.Rows(I).Item("Importe")
            nAlc = tTab.Rows(I).Item("Alcanta")
            nRec = tTab.Rows(I).Item("Recargo")
            nRep = tTab.Rows(I).Item("Reposic")
            nCa1 = tTab.Rows(I).Item("Cargos1")
            nCa2 = tTab.Rows(I).Item("Cargos2")
            nFac = tTab.Rows(I).Item("Factura")
            nNFa = tTab.Rows(I).Item("NoFactura")
            cEst = tTab.Rows(I).Item("Estado")
            dPag = tTab.Rows(I).Item("Pago")
            TXT = "INSERT INTO KARDEX (ABONADO, EMISION, LECTURA, TIPO, CONSUMO, IMPORTE, ALCANTA, RECARGO, REPOSIC, CARGOS_1, CARGOS_2, FACTURA, NOFACTURA, ESTADO, PAGO) VALUES ('" & _
            Val(TxAbonado.Text) & "','" & dEmi & "','" & nLec & "','" & _
            cTip & "','" & nCon & "','" & nImp & "','" & _
            nAlc & "','" & nRec & "','" & nRep & "','" & nCa1 & "','" & _
            nCa2 & "','" & nFac & "','" & nNFa & "','" & _
            cEst & "','" & dPag & "')"

            With CMD
                .CommandText = TXT
                .CommandType = CommandType.Text
                .Connection = db
                .ExecuteNonQuery()
            End With
        Next
        db.Close()
        Dim frep As New Frm_Reportes
        'Dim rep As New Rep_Kardex
        'frep.crvRep.ReportSource = rep
        frep.ShowDialog()
    End Sub

    Private Sub TxNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxNombre.KeyPress
        If e.KeyChar = Chr(13) Then
            cTex = ""
            Select Case CboTipo.SelectedItem
                Case "Nombre"
                    cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Nombre Like '" & TxPaterno.Text & "%" & TxNombre.Text & "%'"
                Case "Abonado"
                    cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Abonado = " & TxPaterno.Text
                Case "Dirección"
                    cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Zona Like '%" & TxPaterno.Text & "%'"
                Case "NIT/CID"
                    cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where NIT like '%" & TxPaterno.Text & "%'"
            End Select

            dUsu.SelectCommand.CommandText = cTex

            dUsu.Fill(rUsu, "Usuarios")
            DgUsuarios.DataSource = rUsu.Tables("Usuarios")
            Formatear_Tabla_Usuarios()
        End If
    End Sub

    Private Sub TxPaterno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxPaterno.KeyPress
        If e.KeyChar = Chr(13) Then
            If CboTipo.SelectedItem = "Nombre" Then
                TxNombre.Focus()
            Else
                cTex = ""
                Select Case CboTipo.SelectedItem
                    Case "Nombre"
                        cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Nombre Like '" & TxPaterno.Text & "%" & TxNombre.Text & "%'"
                    Case "Abonado"
                        cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Abonado = " & TxPaterno.Text
                    Case "Dirección"
                        cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where Zona Like '%" & TxPaterno.Text & "%'"
                    Case "NIT/CID"
                        cTex = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, C.Descripcion From Usuarios U Inner Join Usuarios_Categorias C On U.Categoria = C.Categoria Where NIT like '%" & TxPaterno.Text & "%'"
                End Select

                dUsu.SelectCommand.CommandText = cTex

                dUsu.Fill(rUsu, "Usuarios")
                DgUsuarios.DataSource = rUsu.Tables("Usuarios")
                Formatear_Tabla_Usuarios()
            End If
        End If
    End Sub

    Private Sub DgUsuarios_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        nAbonado = dgUsuarios.Item("Abonado", dgUsuarios.CurrentRow.Index).Value
        Dim fDeu As New Frm_Deudas
        fDeu.ShowDialog()
    End Sub

End Class