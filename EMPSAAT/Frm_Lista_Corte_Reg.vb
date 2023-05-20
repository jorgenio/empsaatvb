Imports System.Data.SqlClient

Public Class Frm_Lista_Corte_Reg
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub Frm_Lista_Corte_Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select Distinct Ruta From Usuarios Order By Ruta"
        da.Fill(ds, "Rut")
        cboRuta.DataSource = ds.Tables("Rut")
        cboRuta.DisplayMember = "Ruta"
        cboRuta.ValueMember = "Ruta"

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim nNuevaLista As Integer
        Dim txt As String
        Dim cmd As New SqlCommand
        Dim NoCorrelativo As Integer

        Dim j As Integer

        Try
            da.SelectCommand.CommandText = "Select Max(NoLista) AS Nro From Servicios_Solicitud"
            da.Fill(ds, "NroLista")
            If ds.Tables("NroLista").Rows.Count > 0 Then
                If IsDBNull(ds.Tables("NroLista").Rows(0).Item("Nro")) Then
                    nNuevaLista = 1
                Else
                    nNuevaLista = ds.Tables("NroLista").Rows(0).Item("Nro") + 1
                End If
            End If
            ds.Tables("NroLista").Clear()

            da.SelectCommand.CommandText = "Select Max(NoSolicitud) as Nro From Servicios_Solicitud"
            da.Fill(ds, "NroOrden")
            If ds.Tables("NroOrden").Rows.Count > 0 Then
                If IsDBNull(ds.Tables("NroOrden").Rows(0).Item("Nro")) Then
                    NoCorrelativo = 0
                Else
                    NoCorrelativo = ds.Tables("NroOrden").Rows(0).Item("Nro")
                End If
            End If
            ds.Tables("NroOrden").Clear()

            db.Open()

            da.SelectCommand.CommandText = "SELECT U.ABONADO, COUNT(*) AS Nro FROM FACTURAS F inner join USUARIOS U ON F.ABONADO = U.ABONADO WHERE FEC_PAGO IS NULL AND ESTADO = 'N' AND RUTA = " & cboRuta.SelectedValue & " GROUP BY u.ABONADO HAVING COUNT(*) > 2"
            da.Fill(ds, "Deu")
            For j = 0 To ds.Tables("Deu").Rows.Count - 1
                NoCorrelativo += 1
                txt = "Insert Into Servicios_Solicitud (NoSolicitud, Abonado, Fecha, Servicio, Costo, Nota, Elaborado, Nombre, Doc, NoDoc, Nit, Nacimiento, Estado, Cobrado, Factura, Formulario, NoLista) Values ('" & _
                    NoCorrelativo & "','" & _
                    ds.Tables("Deu").Rows(j).Item("Abonado") & "','" & _
                    FormatDateTime(Date.Now, DateFormat.ShortDate) & "','" & _
                    1010 & "','" & _
                    0 & "','" & _
                    ds.Tables("Deu").Rows(j).Item("Nro") & "','" & _
                    Empleado & "','','','','','',0,0,0,0,'" & nNuevaLista & "')"

                With cmd
                    .Connection = db
                    .CommandType = CommandType.Text
                    .CommandText = txt
                    .ExecuteNonQuery()
                End With

            Next j

            db.Close()
            ds.Tables.Clear()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch x As Exception
            MessageBox.Show(x.Message, x.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class