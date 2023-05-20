Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Transcripciones
    Dim db As New SqlConnection(cn)
    'Private dvw As DataView
    'Private WithEvents cmr As CurrencyManager
    Dim Proc As Integer
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim txt As String
    Dim cmd As New SqlCommand
    Dim dEmi As Date
    Dim J, S As Integer
    Dim f As Integer

    Private Sub Ver_Actual(ByVal i As Integer)
        txtProm.Clear()
        ds.Tables("His").Clear()
        da.SelectCommand.CommandText = "Select Top 3 Factura, Emision, Lectura, Con_m3 From Facturas Where Abonado = " & Val(TxAbonado.Text) & " and Servicio = 1 And Emision <> '" & dEmi & "' Order By Factura Desc"
        da.Fill(ds, "His")
        If ds.Tables("His").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("His").Rows(0).Item("Lectura")) Then
                TxAnterior.Text = ds.Tables("His").Rows(0).Item("Lectura")
                For J = 0 To ds.Tables("His").Rows.Count - 1
                    S += ds.Tables("His").Rows(J).Item("Con_M3")
                Next
                txtProm.Text = Math.Round((S / J), 0)
                S = 0
            Else
                TxAnterior.Text = 0
            End If
        Else
            TxAnterior.Text = 0
        End If

        da.SelectCommand.CommandText = "Select Lectura, Lec_Estimada, Imp_Factura, Fec_Pago From Facturas Where Abonado = " & Val(TxAbonado.Text) & " And Emision = '" & dEmi & "' AND SERVICIO = 1"
        da.Fill(ds, "Actual")
        If ds.Tables("Actual").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("Actual").Rows(0).Item("Lectura")) Then
                chkEstimado.Checked = ds.Tables("Actual").Rows(0).Item("Lec_Estimada")
                If ds.Tables("Actual").Rows(0).Item("Imp_Factura") = 0 Then
                    chkSinFactura.Checked = True
                Else
                    chkSinFactura.Checked = False
                End If
                If IsDBNull(ds.Tables("Actual").Rows(0).Item("Fec_Pago")) Then
                    BtnGrabar.Enabled = True
                Else
                    BtnGrabar.Enabled = False
                End If
                TxActual.Text = ds.Tables("Actual").Rows(0).Item("Lectura")
            Else
                TxActual.Clear()
                chkEstimado.Checked = False
                chkSinFactura.Checked = False
            End If
        Else
            TxActual.Clear()
            chkEstimado.Checked = False
            chkSinFactura.Checked = False
        End If
        ds.Tables("Actual").Clear()
    End Sub

    Private Sub Ver_Registro(ByVal Fila As Integer)
        Try
            TxAbonado.Text = ds.Tables("Usu").Rows(Fila).Item("Abonado")
        TxUsuario.Text = ds.Tables("Usu").Rows(Fila).Item("Razon")
        TxNIT.Text = ds.Tables("Usu").Rows(Fila).Item("Nit")
        TxCategoria.Text = ds.Tables("Usu").Rows(Fila).Item("Categoria")
        TxCuenta.Text = ds.Tables("Usu").Rows(Fila).Item("Estado")
        TxZona.Text = ds.Tables("Usu").Rows(Fila).Item("Zona")
        TxCalle.Text = ds.Tables("Usu").Rows(Fila).Item("Calle")
        TxSubRuta.Text = ds.Tables("Usu").Rows(Fila).Item("SubRuta")
        TxNoRuta.Text = ds.Tables("Usu").Rows(Fila).Item("NumRuta")
        ChkLey1886.Checked = ds.Tables("Usu").Rows(Fila).Item("Ley1886")
        TxLiberacion.Text = ds.Tables("Usu").Rows(Fila).Item("Liberacion")
            Ver_Actual(Fila)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK)
        End Try
    End Sub


    'Private Sub Enlazar_datos()
    '    TxAbonado.DataBindings.Add("Text", dvw, "Abonado")
    '    TxUsuario.DataBindings.Add("Text", dvw, "Razon")
    '    TxCategoria.DataBindings.Add("Text", dvw, "Categoria")
    '    TxNIT.DataBindings.Add("Text", dvw, "Nit")
    '    TxCuenta.DataBindings.Add("Text", dvw, "Estado")
    '    TxZona.DataBindings.Add("Text", dvw, "Zona"
    '    TxCalle.DataBindings.Add("Text", dvw, "Calle")
    '    TxSubRuta.DataBindings.Add("Text", dvw, "SubRuta")
    '    TxNoRuta.DataBindings.Add("Text", dvw, "NumRuta")
    '    ChkLey1886.DataBindings.Add("Checked", dvw, "Ley1886")
    '    TxLiberacion.DataBindings.Add("Text", dvw, "Liberacion")
    '    cmr = Me.BindingContext(dvw)
    'End Sub

    'Private Sub Quitar_Enlace()
    '    TxAbonado.DataBindings.Clear()
    '    TxUsuario.DataBindings.Clear()
    '    TxCategoria.DataBindings.Clear()
    '    TxNIT.DataBindings.Clear()
    '    TxCuenta.DataBindings.Clear()
    '    TxZona.DataBindings.Clear()
    '    TxCalle.DataBindings.Clear()
    '    TxSubRuta.DataBindings.Clear()
    '    TxNoRuta.DataBindings.Clear()
    '    ChkLey1886.DataBindings.Clear()
    '    TxLiberacion.DataBindings.Clear()
    '    TxAnterior.DataBindings.Clear()
    'End Sub

    Private Sub MostrarPosicion(ByVal sender As Object, ByVal e As System.EventArgs)
        LblPosicion.Text = f + 1 & " de " & ds.Tables("Usu").Rows.Count - 1
    End Sub

    Private Sub Frm_Transcripciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select Distinct Ruta From Usuarios Order By Ruta"
        da.Fill(ds, "Ruta")
        CboRuta.DataSource = ds.Tables("Ruta")
        CboRuta.ValueMember = "Ruta"
        CboRuta.DisplayMember = "Ruta"
        da.SelectCommand.CommandText = "Select Emision, Proceso From Factores Where Estado = 1"
        da.Fill(ds, "Emi")
        If ds.Tables("Emi").Rows.Count > 0 Then
            dEmi = ds.Tables("Emi").Rows(0).Item("Emision")
            Proc = ds.Tables("Emi").Rows(0).Item("Proceso")
            TxPeriodo.Text = Format(dEmi, "MMMM/yyyy")
        End If
        da.SelectCommand.CommandText = "Select Top 3 Emision, Lectura, Con_m3 From Facturas Where Abonado = 0 And Servicio = 1 Order By Factura Desc"
        da.Fill(ds, "His")
        dgHis.DataSource = ds.Tables("His")


        'ds.Tables("Usu").Clear()
        da.SelectCommand.CommandText = "Select * From Ver_Usuarios Where Ruta = " & CboRuta.SelectedValue & " And Estado = 'Cuenta Normal' And ConsFijo < 1  Order By Ruta, SubRuta, NumRuta"
        da.Fill(ds, "Usu")

        If Proc <> 1 Then
            CboRuta.Enabled = False
            MessageBox.Show("No se puede transcribir Lecturas", "El periodo no esta habilitado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            BtnGrabar.Enabled = False
            TxActual.ReadOnly = True
            Exit Sub
        End If
    End Sub

    Private Sub Seleccionar_Registros(ByVal Ruta As Integer)
        ds.Tables("Usu").Clear()
        da.SelectCommand.CommandText = "Select * From Ver_Usuarios Where Ruta = " & Ruta & " And Estado = 'Cuenta Normal' And ConsFijo < 1  Order By Ruta, SubRuta, NumRuta"
        da.Fill(ds, "Usu")
        f = 0
        If ds.Tables("Usu").Rows.Count > 0 Then
            Ver_Registro(f)
        End If
    End Sub

    Private Sub Cargar_Datos(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboRuta.SelectionChangeCommitted
        Seleccionar_Registros(CboRuta.SelectedValue)
    End Sub

    Private Sub Navegar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdelante.Click, BtnAtras.Click
        Select Case sender.tag
            Case "1"
                If f < ds.Tables("Usu").Rows.Count Then
                    f += 1
                End If
            Case "2"
                If f > 0 Then
                    f -= 1
                End If
        End Select
        TxConsumo.Clear()
        Ver_Registro(f)
        Ver_Actual(f)
        TxActual.Focus()
    End Sub

    Private Sub TxActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxActual.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnGrabar.Focus()
        Else
            chkEstimado.Checked = False
        End If
    End Sub

    Private Sub TxAnterior_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxAnterior.KeyPress, TxAnterior.KeyPress, TxConsumo.KeyPress, TxPeriodo.KeyPress
        e.Handled = True
    End Sub

    Private Sub ActualizaLectura(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxActual.TextChanged
        If IsNumeric(TxActual.Text) Then TxConsumo.Text = Calculo_Consumo(Val(TxActual.Text), Val(TxAnterior.Text))
    End Sub


    Private Sub rdbReal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chkEstimado.Checked Then
            TxActual.Text = Val(TxAnterior.Text) + Val(txtProm.Text)
            chkSinFactura.Checked = False
            BtnGrabar.Focus()
        Else
            TxActual.Focus()
            TxConsumo.Clear()
            TxActual.SelectAll()
        End If
    End Sub

    Private Sub chkSinFactura_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSinFactura.CheckedChanged
        If chkSinFactura.Checked Then
            TxActual.Text = TxAnterior.Text
            BtnGrabar.Focus()
        Else
            TxActual.Clear()
            TxConsumo.Clear()
        End If
    End Sub

    Private Sub Grabar_Lectura(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Call Grabar_Lectura_Tabla()
        If f < ds.Tables("usu").Rows.Count Then
            f += 1
            Ver_Registro(f)
            TxActual.Focus()
        End If
        'BtnAdelante.Focus()
    End Sub

    Private Sub Grabar_Lectura_Tabla()
        Dim cmd As New SqlCommand
        Dim xCod As New SqlParameter
        Dim xLec As New SqlParameter
        Dim xCon As New SqlParameter
        Dim xEst As New SqlParameter
        Dim xSin As New SqlParameter
        Dim xEmi As New SqlParameter
        Dim xSRe As New SqlParameter

        If IsNumeric(TxActual.Text) Then
            TxConsumo.Text = Calculo_Consumo(Val(TxActual.Text), Val(TxAnterior.Text))
        Else
            MessageBox.Show("Lectura Actual en Blanco, Debe dar una lectura actual", "No se puede grabar los datos", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading)
            TxActual.Focus()
            TxActual.SelectAll()
            Exit Sub
        End If

        If TxCuenta.Text <> "Cuenta Normal" Then
            chkSinFactura.Checked = True
        End If

        Try
            '--------- calcular facturas ----------------
            'txt = "Update FACTURAS Set Lectura = '" & Val(TxActual.Text) & "', Con_m3 = '" & Val(TxConsumo.Text) & "', Estimado = " & chkEstimado.Checked & " Where Abonado = " & TxAbonado.Text
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "Grabar_Consumo_Nuevo"
                xCod = .Parameters.Add("@Abonado", SqlDbType.Int)
                xLec = .Parameters.Add("@Lectura", SqlDbType.Int)
                xCon = .Parameters.Add("@Con_M3", SqlDbType.Int)
                xEst = .Parameters.Add("@Estimado", SqlDbType.Bit)
                xSin = .Parameters.Add("@SinFactura", SqlDbType.Bit)
                xEmi = .Parameters.Add("@Emision", SqlDbType.DateTime)
                xSRe = .Parameters.Add("@SinRecargos", SqlDbType.Bit)
                xCod.Value = TxAbonado.Text
                xLec.Value = TxActual.Text
                xCon.Value = TxConsumo.Text
                xEst.Value = IIf(chkEstimado.Checked, 1, 0)
                xSin.Value = IIf(chkSinFactura.Checked, 1, 0)
                xEmi.Value = dEmi
                xSRe.Value = 0
                .ExecuteNonQuery()
            End With
            db.Close()
        Catch x As Exception
            MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Buscar_Abonado(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim nAbonado As Integer
            Dim r As Integer
            nAbonado = InputBox("Abonado a Buscar", "Buscando Abonado", "", 100, 100)
            If Len(nAbonado) > 0 Then
                For r = 0 To ds.Tables("Usu").Rows.Count - 1
                    If ds.Tables("Usu").Rows(r).Item("Abonado") = Val(nAbonado) Then
                        f = r
                        Ver_Registro(f)
                        Exit For
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End Try
    End Sub

    Private Sub TxActual_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxActual.Validated
        If Val(TxConsumo.Text) > (Val(txtProm.Text) * 2) Then
            Errores.SetError(TxConsumo, "Consumo superior al promedio de consumo")
        Else
            Errores.SetError(TxConsumo, "")
        End If
    End Sub

    Private Sub btnModificaLectura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificaLectura.Click
        'txtLecturaAnterior.Text = txtLec1.Text
        If ds.Tables("His").Rows.Count > 0 Then
            txtPeriodoAntes.Text = ds.Tables("His").Rows(0).Item("Emision")
            txtLecturaAnterior.Text = ds.Tables("His").Rows(0).Item("Lectura")
            pnLecturaAnterior.Visible = True
            txtLecturaAnterior.Focus()
        End If
    End Sub

    Private Sub btnCancelarLecturaAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarLecturaAnterior.Click
        pnLecturaAnterior.Visible = False
    End Sub

    Private Sub btnGrabarLecturaAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarLecturaAnterior.Click
        If IsNumeric(txtLecturaAnterior.Text) Then
            Try
                txt = "Update facturas Set Lectura = '" & Val(txtLecturaAnterior.Text) & "' Where Factura = " & ds.Tables("His").Rows(0).Item("Factura")
                db.Open()
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
                db.Close()
                Ver_Registro(f)
            Catch x As Exception
                MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If db.State = ConnectionState.Open Then db.Close()
            End Try
            'txtLec1.Text = txtLecturaAnterior.Text
            TxAnterior.Text = txtLecturaAnterior.Text
            pnLecturaAnterior.Visible = False
        End If
    End Sub

    Private Sub chkEstimado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEstimado.CheckedChanged
        If chkEstimado.Checked Then
            TxActual.Text = Val(TxAnterior.Text) + Val(txtProm.Text)
        Else
            TxActual.Clear()
        End If
    End Sub

    
End Class