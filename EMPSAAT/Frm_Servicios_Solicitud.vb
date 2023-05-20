Imports System.Data.SqlClient

Public Class Frm_Servicios_Solicitud
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub Frm_Servicios_Solicitud_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select Servicio, Descripcion From Servicios_Lista Order By Descripcion"
        da.Fill(ds, "Servicios")

        cboServicios.DataSource = ds.Tables("Servicios")
        cboServicios.DisplayMember = "Descripcion"
        cboServicios.ValueMember = "Servicio"

        da.SelectCommand.CommandText = "Select Distinct Ruta From Usuarios Order By Ruta"
        da.Fill(ds, "Rutas")
        cbo_Ruta.DataSource = ds.Tables("Rutas")
        cbo_Ruta.DisplayMember = "Ruta"
        cbo_Ruta.ValueMember = "Ruta"

        da.SelectCommand.CommandText = "Select Categoria, Descripcion From Usuarios_Categorias"
        da.Fill(ds, "Categorias")
        cbo_Categoria.DataSource = ds.Tables("Categorias")
        cbo_Categoria.DisplayMember = "Descripcion"
        cbo_Categoria.ValueMember = "Categoria"

        da.SelectCommand.CommandText = "Select Distinct Zona From Usuarios"
        da.Fill(ds, "Zonas")
        cbo_Zona.DataSource = ds.Tables("Zonas")
        cbo_Zona.DisplayMember = "Zona"
        cbo_Zona.ValueMember = "Zona"

        da.SelectCommand.CommandText = "Select Distinct Calle From Usuarios"
        da.Fill(ds, "Calles")
        cbo_Calle.DataSource = ds.Tables("Calles")
        cbo_Calle.DisplayMember = "Calle"
        cbo_Calle.ValueMember = "Calle"

        da.SelectCommand.CommandText = "Select Distinct SubRuta From Usuarios"
        da.Fill(ds, "SubRutas")
        cbo_SubRuta.DataSource = ds.Tables("SubRutas")
        cbo_SubRuta.DisplayMember = "SubRuta"
        cbo_SubRuta.ValueMember = "SubRuta"

    End Sub

    Private Sub cboServicios_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboServicios.SelectionChangeCommitted
        txtCosto.Text = Costo_Servicio(cboServicios.SelectedValue)

        gbDireccion.Visible = False
        gbCambioNombre.Visible = False
        gbCategoria.Visible = False
        If cboServicios.SelectedValue = 1001 Then
        ElseIf cboServicios.SelectedValue = 1002 Then
        ElseIf cboServicios.SelectedValue = 1006 Then
            gbDireccion.Visible = True
        ElseIf cboServicios.SelectedValue = 1007 Then
            gbCambioNombre.Visible = True
        ElseIf cboServicios.SelectedValue = 1008 Then
            gbCategoria.Visible = True
        ElseIf cboServicios.SelectedValue = 1009 Then
            'If TxCuenta.Text <> "Cuenta Normal" Then
            'MessageBox.Show("El usuario actualmente tiene una cuenta " & TxCuenta.Text, "Tenga cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
        ElseIf cboServicios.SelectedValue = 1010 Then
            'If TxCuenta.Text <> "Cuenta Normal" Then
            '    MessageBox.Show("El usuario actualmente tiene una cuenta " & TxCuenta.Text, "Tenga cuidado", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
        End If
    End Sub

    Function Costo_Servicio(ByVal Servicio As Integer) As Double
        Dim nCodServ As Integer = cboServicios.SelectedValue
        da.SelectCommand.CommandText = "Select Costo From Servicios_Lista Where Servicio = " & nCodServ
        da.Fill(ds, "Costo")

        If ds.Tables("Costo").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("Costo").Rows(0).Item("Costo")) Then
                Costo_Servicio = ds.Tables("Costo").Rows(0).Item("Costo")
            Else
                Costo_Servicio = 0
            End If
        Else
            Costo_Servicio = 0
        End If
        ds.Tables("Costo").Clear()
    End Function

    Private Sub BtnCancelarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarOrden.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BtnGrabarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabarOrden.Click
        Dim nNumOrd As Integer
        Dim cText As String
        Dim cmd As New SqlCommand

        Try
            nNumOrd = Numero_Orden()
            nOrden = nNumOrd
            If cboServicios.SelectedValue = 1007 Then
                cText = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, " & _
                "Costo, Nota, Elaborado, Nombre, Doc, NoDoc, Nit, " & _
                "Estado, Cobrado, Factura, Formulario) Values ('" & _
                    nNumOrd & "','" & _
                    nAbonado & "','" & _
                    FormatDateTime(Date.Now, DateFormat.ShortDate) & "','" & _
                    cboServicios.SelectedValue & "','" & _
                    txtCosto.Text & "','" & _
                    txtNota.Text & "','" & _
                    Empleado & "','" & _
                    Txt_Nombre.Text & "','" & _
                    cbo_Doc.Text & "','" & _
                    txt_NoDoc.Text & "','" & _
                    txt_Nit.Text & "'," & _
                    "'0','0','0'," & _
                    IIf(chkRep.Checked, 1, 0) & ")"
            ElseIf cboServicios.SelectedValue = 1006 Then
                cText = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Ruta, Subruta, Zona, Calle, Numero, NoRuta, Estado, Cobrado, Factura, Formulario) Values ('" & _
                        nNumOrd & "','" & _
                        nAbonado & "','" & _
                        FormatDateTime(Date.Now, DateFormat.ShortDate) & "','" & _
                        cboServicios.SelectedValue & "','" & _
                        txtCosto.Text & "','" & _
                        txtNota.Text & "','" & _
                        Empleado & "','" & _
                        cbo_Ruta.Text & "','" & _
                        cbo_SubRuta.Text & "','" & _
                        cbo_Zona.Text & "','" & _
                        cbo_Calle.Text & "','" & _
                        txt_Numero.Text & "','" & _
                        txtNoRuta.Text & "','0','0','0'," & _
                        IIf(chkRep.Checked, 1, 0) & ")"
            ElseIf cboServicios.SelectedValue = 1008 Then
                cText = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Categoria, Desc_Categoria, Estado, Cobrado, Factura, Formulario) Values ('" & _
                        nNumOrd & "','" & _
                        nAbonado & "','" & _
                        FormatDateTime(Date.Now, DateFormat.ShortDate) & "','" & _
                        cboServicios.SelectedValue & "','" & _
                        txtCosto.Text & "','" & _
                        txtNota.Text & "','" & _
                        Empleado & "','" & _
                        cbo_Categoria.SelectedValue & "','" & _
                        cbo_Categoria.Text & "','0','0','0'," & _
                        IIf(chkRep.Checked, 1, 0) & ")"
            Else
                cText = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Estado, Cobrado, Factura, Formulario) Values ('" & _
                        nNumOrd & "','" & _
                        nAbonado & "','" & _
                        FormatDateTime(Date.Now, DateFormat.ShortDate) & "','" & _
                        cboServicios.SelectedValue & "','" & _
                        txtCosto.Text & "','" & _
                        txtNota.Text & "','" & _
                        Empleado & "','0','0','0'," & _
                        IIf(chkRep.Checked, 1, 0) & ")"
            End If

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = cText
                .ExecuteNonQuery()
            End With

            If chkRep.Checked = True Then
                cText = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Estado, Elaborado, Cobrado, Factura, Formulario) Values ('" & _
                            (nNumOrd + 1) & "','" & nAbonado & "','" & _
                            Format(Date.Now, "dd/MM/yyyy") & "','3000','1','Reposición de Formulario',1,'" & _
                            Empleado & "','0','0',1)"
                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = cText
                    .ExecuteNonQuery()
                End With
            End If

            
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch x As Exception
            MessageBox.Show(x.Message, "Vuelva a intentar", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Function Numero_Orden() As Double
        da.SelectCommand.CommandText = "Select Max(NoSolicitud) as Nro From Servicios_Solicitud"
        da.Fill(ds, "Nro")
        Numero_Orden = ds.Tables("Nro").Rows(0).Item("Nro") + 1
        ds.Tables("Nro").Clear()
    End Function

    Private Sub cbo_Ruta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_Ruta.SelectionChangeCommitted
        ds.Tables("Zonas").Clear()
        da.SelectCommand.CommandText = "Select Distinct Zona From Usuarios Where Ruta = " & cbo_Ruta.SelectedValue
        da.Fill(ds, "Zonas")

        ds.Tables("Calles").Clear()
        da.SelectCommand.CommandText = "Select Distinct Calle From Usuarios Where Ruta = " & cbo_Ruta.SelectedValue
        da.Fill(ds, "Calles")

        ds.Tables("SubRutas").Clear()
        da.SelectCommand.CommandText = "Select Distinct SubRuta From Usuarios Where Ruta = " & cbo_Ruta.SelectedValue
        da.Fill(ds, "SubRutas")
    End Sub

    Private Sub txt_NoDoc_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_NoDoc.LostFocus
        If Buscar_Cliente(txt_NoDoc.Text) = False Then
            MessageBox.Show("No es válido el cliente registrado", "Por favor corrija", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            txt_NoDoc.Focus()
        End If
    End Sub

    Function Buscar_Cliente(ByVal Cliente As String) As Boolean
        da.SelectCommand.CommandText = "Select * From Cliente Where Cliente = '" & Cliente & "'"
        da.Fill(ds, "NCli")
        If ds.Tables("NCli").Rows.Count > 0 Then
            Txt_Nombre.Text = ds.Tables("NCli").Rows(0).Item("Razon")
            txt_Nit.Text = ds.Tables("NCli").Rows(0).Item("Nit")
            Buscar_Cliente = True
        Else
            Txt_Nombre.Clear()
            txt_Nit.Clear()
            Buscar_Cliente = False
        End If
        ds.Tables("NCli").Clear()
    End Function
    
End Class