Imports System.Data.SqlClient

Public Class Frm_Servicios_Lista_Reg
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim eDi As Boolean = False

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        If MessageBox.Show("Esta seguro de Cancelar", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            If eDi = True Then
                txt = "Update Servicios_Lista Set Descripcion = '" & txtDescripcion.Text & "', Costo = '" & Val(txtCosto.Text) & "', Clave = '" & cboClave.SelectedValue & "', Seccion = '" & cboSeccion.SelectedValue & "' Where Servicio = '" & txtServicio.Text & "'"
            Else
                txt = "INSERT INTO SERVICIOS_LISTA (Servicio, Descripcion, Costo, Seccion, Clave, Cuenta, Cajero) values ('" & _
                    txtServicio.Text & "','" & txtDescripcion.Text & "','" & txtCosto.Text & "','" & cboSeccion.SelectedValue & "','" & cboClave.SelectedValue & "','" & pCuenta & "','" & _Usuario & "')"
            End If

            db.Open()
            With cmd
                .Connection = db
                .CommandText = txt
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            db.Close()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Frm_Servicios_Lista_Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select Distinct Clave From Servicios_Lista Where cuenta = '" & pCuenta & "'"
        da.Fill(ds, "Cla")
        cboClave.DataSource = ds.Tables("Cla")
        cboClave.DisplayMember = "Clave"
        cboClave.ValueMember = "Clave"

        da.SelectCommand.CommandText = "Select Distinct Seccion From Servicios_Lista" ' Where cuenta = '" & pCuenta & "'"
        da.Fill(ds, "Sec")
        cboSeccion.DataSource = ds.Tables("Sec")
        cboSeccion.DisplayMember = "Seccion"
        cboSeccion.ValueMember = "Seccion"

        da.SelectCommand.CommandText = "Select * from Servicios_Lista Where Servicio = '" & pServicioLista & "'"
        da.Fill(ds, "Ser")
        If ds.Tables("Ser").Rows.Count > 0 Then
            txtServicio.Text = ds.Tables("Ser").Rows(0).Item("Servicio")
            txtDescripcion.Text = ds.Tables("Ser").Rows(0).Item("Descripcion")
            txtCosto.Text = ds.Tables("Ser").Rows(0).Item("Costo")
            cboClave.SelectedValue = ds.Tables("Ser").Rows(0).Item("Clave")
            cboSeccion.SelectedValue = ds.Tables("Ser").Rows(0).Item("Seccion")
            eDi = True
        Else
            txtServicio.Text = Nuevo_Servicio()
        End If
    End Sub

    Function Nuevo_Servicio() As Integer
        da.SelectCommand.CommandText = "select Max(Servicio) as Nro from Servicios_Lista"
        da.Fill(ds, "Nro")
        If ds.Tables("Nro").Rows.Count > 0 Then
            If Not IsDBNull(ds.Tables("Nro").Rows(0).Item("Nro")) Then
                Nuevo_Servicio = ds.Tables("Nro").Rows(0).Item("Nro") + 1
            Else
                Nuevo_Servicio = 3000
            End If
        End If
        ds.Tables("Nro").Clear()
    End Function

End Class