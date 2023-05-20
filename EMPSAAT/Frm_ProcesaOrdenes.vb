Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_ProcesaOrdenes
    Dim db As New SqlConnection(cn)
    Dim daOrden As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Frm_ProcesaOrdenes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Ver_Lista()
    End Sub

    Private Sub Ver_Lista()
        'daOrden.SelectCommand.CommandText = "Select S.NoSolicitud, S.Fecha, U.Abonado, U.Nombre, L.Descripcion, S.Costo From ((Servicios_Solicitud S Inner Join Usuarios U On S.Abonado = U.Abonado) Inner Join Servicios_Lista L On L.Servicio = S.Servicio) Where S.Estado = '0'"
        daOrden.SelectCommand.CommandText = "Select NoSolicitud, Fecha, Abonado, Razon, DescServicio, Costo From Ver_Orden_Servicio Where Estado = '0'"
        daOrden.Fill(ds, "Servicios")
        dgServicios.DataSource = ds.Tables("Servicios")
        Formatea_Lista()
        daOrden.SelectCommand.CommandText = "Select Codigo, (Paterno + ' ' + Materno + ' ' + Nombre) as Empleado From Emp_empleados Order By Paterno"
        daOrden.Fill(ds, "Empleados")
        cboEmpleado.DataSource = ds.Tables("Empleados")
        cboEmpleado.DisplayMember = ds.Tables("Empleados").Columns(1).ColumnName
        cboEmpleado.ValueMember = ds.Tables("Empleados").Columns("Codigo").ColumnName
    End Sub

    Private Sub Formatea_Lista()
        Dim dts As New DataGridTableStyle
        dts.MappingName = "Servicios"

        Dim c1 As New DataGridTextBoxColumn
        c1.MappingName = "NoSolicitud"
        c1.HeaderText = "Solicitud"
        c1.ReadOnly = True
        c1.Width = 60
        c1.Alignment = HorizontalAlignment.Center
        dts.GridColumnStyles.Add(c1)

        Dim c2 As New DataGridTextBoxColumn
        c2.MappingName = "Fecha"
        c2.HeaderText = "Fecha"
        c2.ReadOnly = True
        c2.Width = 100
        c2.Format = "dd/MM/yyyy"
        c2.Alignment = HorizontalAlignment.Center
        dts.GridColumnStyles.Add(c2)

        Dim c3 As New DataGridTextBoxColumn
        c3.MappingName = "Abonado"
        c3.HeaderText = "Abonado"
        c3.ReadOnly = True
        c3.Width = 60
        c3.Alignment = HorizontalAlignment.Center
        dts.GridColumnStyles.Add(c3)

        Dim c4 As New DataGridTextBoxColumn
        c4.MappingName = "Razon"
        c4.HeaderText = "Razón Social"
        c4.ReadOnly = True
        c4.Width = 250
        dts.GridColumnStyles.Add(c4)

        Dim c5 As New DataGridTextBoxColumn
        c5.MappingName = "DescServicio"
        c5.HeaderText = "Servicio"
        c5.ReadOnly = True
        c5.Width = 200
        dts.GridColumnStyles.Add(c5)

        Dim c6 As New DataGridTextBoxColumn
        c6.MappingName = "Costo"
        c6.HeaderText = "Costo"
        c6.ReadOnly = True
        c6.Width = 60
        c6.Format = "#0.00"
        c6.Alignment = HorizontalAlignment.Center
        dts.GridColumnStyles.Add(c6)

        dgServicios.TableStyles.Clear()
        dgServicios.TableStyles.Add(dts)
    End Sub

    Private Sub BtnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProcesar.Click
        Dim nNoSol As Integer = dgServicios.Item(dgServicios.CurrentRowIndex, 0)
        'daOrden.SelectCommand.CommandText = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, U.Estado, S.NoSolicitud, S.Fecha, S.Costo, S.Nota, S.Servicio, L.Descripcion, S.Ruta, S.SubRuta, S.NoRuta, S.Zona AS N_ZONA, S.Calle AS N_CALLE, S.Numero, S.Categoria, S.Desc_Categoria, S.Nombre as N_Nombre, S.Doc, S.NoDoc, S.Nit, S.Nacimiento From (Servicios_Solicitud S Inner Join Usuarios U On U.Abonado = S.Abonado) Inner Join Servicios_Lista L On S.Servicio = L.Servicio Where S.NoSolicitud = " & nNoSol
        daOrden.SelectCommand.CommandText = "Select * From Ver_Orden_Servicio Where NoSolicitud = " & nNoSol
        daOrden.Fill(ds, "ServProc")
        If ds.Tables("ServProc").Rows.Count > 0 Then
            TxtAbonado.Text = ds.Tables("ServProc").Rows(0).Item("Abonado")
            txtUsuario.Text = ds.Tables("ServProc").Rows(0).Item("Razon")
            txtZona.Text = ds.Tables("ServProc").Rows(0).Item("Zona")
            txtCalle.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("Calle")), "", ds.Tables("ServProc").Rows(0).Item("Calle"))
            txtEstado.Text = ds.Tables("ServProc").Rows(0).Item("Estado_Cuenta")
            txtNoSolicitud.Text = ds.Tables("ServProc").Rows(0).Item("NoSolicitud")
            txtFechaSolicitud.Text = Format(ds.Tables("ServProc").Rows(0).Item("Fecha"), "dd/MMM/yyyy")
            txtServicio.Text = ds.Tables("ServProc").Rows(0).Item("DescServicio")
            If IsDBNull(ds.Tables("ServProc").Rows(0).Item("Costo")) Then
                txtCosto.Text = ""
            Else
                txtCosto.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("Costo")), 0, Format(ds.Tables("ServProc").Rows(0).Item("Costo"), "#0.00"))
            End If
            txtNota.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("Nota")), "", ds.Tables("ServProc").Rows(0).Item("Nota"))
            txtCodServicio.Text = ds.Tables("ServProc").Rows(0).Item("Servicio")
            dtFecha.Value = Date.Now
            Panel1.Visible = True
            gbDireccion.Visible = False
            gbRazonSocial.Visible = False
            gbCategoria.Visible = False
            txt_LectInicial.Visible = False
            lblInicial.Visible = False
            If ds.Tables("ServProc").Rows(0).Item("Servicio") = 1001 Then
                txt_LectInicial.Visible = True
                lblInicial.Visible = True
                gbDireccion.Visible = True
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("Ruta")) Then
                    cbo_Ruta.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("Ruta")), 0, ds.Tables("ServProc").Rows(0).Item("Ruta"))
                End If
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("SubRuta")) Then
                    cbo_SubRuta.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("SubRuta")), 0, ds.Tables("ServProc").Rows(0).Item("SubRuta"))
                End If
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("Zona")) Then
                    cbo_Zona.Text = ds.Tables("ServProc").Rows(0).Item("Zona")
                End If
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("Calle")) Then
                    cbo_Calle.Text = ds.Tables("ServProc").Rows(0).Item("Calle")
                End If
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("NNumero")) Then
                    txtNumero.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("Numero")), "", ds.Tables("ServProc").Rows(0).Item("Numero"))
                End If
            ElseIf ds.Tables("ServProc").Rows(0).Item("Servicio") = 1006 Then
                gbDireccion.Visible = True
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("NRuta")) Then
                    cbo_Ruta.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("NRuta")), 0, ds.Tables("ServProc").Rows(0).Item("NRuta"))
                End If
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("NSubRuta")) Then
                    cbo_SubRuta.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("NSubRuta")), 0, ds.Tables("ServProc").Rows(0).Item("NSubRuta"))
                End If
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("NNoRuta")) Then
                    txt_NumRuta.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("NNoRuta")), 0, ds.Tables("ServProc").Rows(0).Item("NNoRuta"))
                End If
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("nZona")) Then
                    cbo_Zona.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("nZona")), "", ds.Tables("ServProc").Rows(0).Item("NZona"))
                End If
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("nCalle")) Then
                    cbo_Calle.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("nCalle")), "", ds.Tables("ServProc").Rows(0).Item("NCalle"))
                End If
                If Not IsDBNull(ds.Tables("ServProc").Rows(0).Item("nNumero")) Then
                    txtNumero.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("nNumero")), "", ds.Tables("ServProc").Rows(0).Item("nNumero"))
                End If
            ElseIf ds.Tables("ServProc").Rows(0).Item("Servicio") = 1007 Then
                gbRazonSocial.Visible = True
                txt_RazonSocial.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("NNOMBRE")), "", ds.Tables("ServProc").Rows(0).Item("NNOMBRE"))
                txt_Doc.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("NDoc")), "", ds.Tables("ServProc").Rows(0).Item("NDoc"))
                txt_NoDoc.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("NNoDoc")), "", ds.Tables("ServProc").Rows(0).Item("NNoDoc"))
                txt_Nit.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("NNit")), "", ds.Tables("ServProc").Rows(0).Item("NNit"))
                txt_Nacimiento.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("NNacimiento")), "", ds.Tables("ServProc").Rows(0).Item("NNacimiento"))
            ElseIf ds.Tables("ServProc").Rows(0).Item("Servicio") = 1008 Then
                gbCategoria.Visible = True
                txt_Categoria.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("Desc_Categoria")), "", ds.Tables("ServProc").Rows(0).Item("Desc_Categoria"))
                txt_CodCategoria.Text = IIf(IsDBNull(ds.Tables("ServProc").Rows(0).Item("Categoria")), "", ds.Tables("ServProc").Rows(0).Item("Categoria"))
            End If
        End If
        ds.Tables("ServProc").Clear()
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Dim cmd As New SqlCommand
        Dim txt As String
        ' Validar procesos
        Select Case Val(txtCodServicio.Text)
            Case 1001
                If txtEstado.Text <> "X" Then
                    MessageBox.Show("No se puede Conectar mas de una vez al usuario", "No se puede procesar la orden de servicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Case 1002
                If txtEstado.Text = "N" Or txtEstado.Text = "X" Then
                    MessageBox.Show("No sepuede reconectar este registro, Verifique el estado actual de usuario", "No se puede procesar la orden de servicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Case 1009 To 1010
                If txtEstado.Text <> "N" Then
                    MessageBox.Show("No sepuede reconectar este registro, Verifique el estado actual de usuario", "No se puede procesar la orden de servicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            Case 1011
        End Select

        Try
            txt = "UPDATE Servicios_Solicitud Set Estado = '1', Fec_Atendido = '" & Format(dtFecha.Value, "dd/MM/yyyy") & "', Fec_Sistema = '" & Format(Date.Now, "dd/MM/yyyy") & "', Empleado = '" & cboEmpleado.SelectedValue & "' Where NoSolicitud = " & txtNoSolicitud.Text
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With
            If Val(txtCodServicio.Text) = 1001 Then
                txt = "Update Usuarios Set Estado = 'N', Fec_Con = '" & Format(dtFecha.Value, "dd/MM/yyyy") & "', Lect_Inicial = '" & Val(txt_LectInicial.Text) & "' Where Abonado = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
                txt = "Update Usuarios Set Ruta = '" & Val(cbo_Ruta.Text) & "', SubRuta = '" & Val(cbo_SubRuta.Text) & "', NumRuta = '" & Val(txt_NumRuta.Text) & "', Zona = '" & cbo_Zona.Text & "', Calle = '" & cbo_Calle.Text & "', Num = '" & Val(txtNumero.Text) & "' Where Abonado = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
                'txt = "GRABAR_FACTURA"

            ElseIf Val(txtCodServicio.Text) = 1002 Then
                txt = "Update Usuarios Set EStado = 'N', Fec_Rec = '" & Format(dtFecha.Value, "dd/MM/yyyy") & "' Where Abonado = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
            ElseIf Val(txtCodServicio.Text) = 1006 Then
                txt = "Update Usuarios Set Ruta = '" & Val(cbo_Ruta.Text) & "', SubRuta = '" & Val(cbo_SubRuta.Text) & "', NumRuta = '" & Val(txt_NumRuta.Text) & "', Zona = '" & cbo_Zona.Text & "', Calle = '" & cbo_Calle.Text & "', Num = '" & Val(txtNumero.Text) & "' Where Abonado = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
            ElseIf Val(txtCodServicio.Text) = 1007 Then
                'txt = "Update Usuarios Set Nombre = '" & txt_RazonSocial.Text & "', Nit = '" & txt_Nit.Text & "', Doc = '" & txt_Doc.Text & "', NoDoc = '" & txt_NoDoc.Text & "', Nacimiento = '" & txt_Nacimiento.Text & "' Where Abonado = " & TxtAbonado.Text
                txt = "Update Usuarios Set NoDoc = '" & txt_NoDoc.Text & "' WHERE ABONADO = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
            ElseIf Val(txtCodServicio.Text) = 1008 Then
                txt = "Update Usuarios Set Categoria = '" & txt_CodCategoria.Text & "' Where Abonado = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
            ElseIf Val(txtCodServicio.Text) = 1009 Then
                txt = "Update Usuarios Set EStado = 'S', Fec_Cor = '" & Format(dtFecha.Value, "dd/MM/yyyy") & "' Where Abonado = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
            ElseIf Val(txtCodServicio.Text) = 1010 Then
                txt = "Update Usuarios Set EStado = 'D', Fec_Cor = '" & Format(dtFecha.Value, "dd/MM/yyyy") & "' Where Abonado = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
            ElseIf Val(txtCodServicio.Text) = 1011 Then
                txt = "Update Usuarios Set EStado = 'R', Fec_Cor = '" & Format(dtFecha.Value, "dd/MM/yyyy") & "' Where Abonado = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
            ElseIf Val(txtCodServicio.Text) = 1013 Then
                txt = "Update Usuarios Set EStado = 'N', Fec_Rec = '" & Format(dtFecha.Value, "dd/MM/yyyy") & "' Where Abonado = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
            ElseIf Val(txtCodServicio.Text) = 1014 Then
                txt = "Update Usuarios Set EStado = 'N', Fec_Rec = '" & Format(dtFecha.Value, "dd/MM/yyyy") & "' Where Abonado = " & TxtAbonado.Text
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
            End If
            db.Close()
            Panel1.Visible = False
            ds.Tables("Servicios").Clear()
            ds.Tables("Empleados").Clear()
            Call Ver_Lista()
        Catch x As Exception
            MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub BtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAnular.Click
        Dim nNoSol As Integer = dgServicios.Item(dgServicios.CurrentRowIndex, 0)
        Dim nAbo As String
        Dim nUsu As String
        Dim nSer As String
        Dim txt As String
        Dim cmd As New SqlCommand
        daOrden.SelectCommand.CommandText = "Select U.Abonado, U.Nombre, U.Zona, U.Calle, U.Estado, S.NoSolicitud, S.Fecha, S.Costo, S.Nota, S.Servicio, L.Descripcion, S.Ruta, S.SubRuta, S.Zona AS N_ZONA, S.Calle AS N_CALLE, S.Numero, S.Categoria, S.Desc_Categoria, S.Nombre as N_Nombre, S.Doc, S.NoDoc, S.Nit, S.Nacimiento From (Servicios_Solicitud S Inner Join Usuarios U On U.Abonado = S.Abonado) Inner Join Servicios_Lista L On S.Servicio = L.Servicio Where S.NoSolicitud = " & nNoSol
        daOrden.Fill(ds, "ServAnula")
        If ds.Tables("ServANULA").Rows.Count > 0 Then
            nAbo = ds.Tables("ServAnula").Rows(0).Item("Abonado")
            nUsu = ds.Tables("ServAnula").Rows(0).Item("Nombre")
            nSer = ds.Tables("ServAnula").Rows(0).Item("Descripcion")
            If MessageBox.Show("Esta seguro de Anula la Orden No. " & nNoSol & " Abonado " & nAbo & " Usuario " & nUsu & " Servicio " & nSer, "Por favor tenga cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                txt = "UPDATE Servicios_Solicitud Set Estado = 2, Cobrado = 1, Nota = 'Anulado en Fecha " & Format(Date.Now, "dd/MM/yyyy") & "', Fec_Sistema = '" & Format(Date.Now, "dd/MM/yyyy") & "' Where NoSolicitud = " & nNoSol
                db.Open()
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With
                db.Close()
                MessageBox.Show("Se ha anulado la orden correctamente", "Proceso terminado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ds.Tables("Servicios").Clear()
                ds.Tables("Empleados").Clear()
                Call Ver_Lista()
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Panel1.Visible = False
    End Sub
End Class