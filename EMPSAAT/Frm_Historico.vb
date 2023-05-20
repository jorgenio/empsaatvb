Imports System.Data.SqlClient

Public Class Frm_Historico
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim i As Integer

    Private Sub Frm_Historico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select Abonado From Usuarios Where NODOC = '" & pCliente & "' Order by Abonado"
        da.Fill(ds, "Abo")
        cboAbonado.DataSource = ds.Tables("Abo")
        cboAbonado.DisplayMember = "Abonado"
        cboAbonado.ValueMember = "Abonado"
        cboAbonado.SelectedValue = nAbonado

        da.SelectCommand.CommandText = "Select * From Facturas Where Servicio = 1 And Abonado = 0 Order By Factura"
        da.Fill(ds, "Fac")
        dgFacturas.DataSource = ds.Tables("Fac")

        Ver_Abonado(cboAbonado.SelectedValue)
    End Sub

    Private Sub Ver_Abonado(ByVal Abonado As Integer)
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

        ds.Tables("Fac").Clear()
        da.SelectCommand.CommandText = "Select * From Facturas Where Servicio = 1 And Abonado = " & Abonado & " Order By Factura"
        da.Fill(ds, "Fac")
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnImprimirOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimirOrden.Click
        nAbonado = cboAbonado.SelectedValue
        Dim fImp As New Frm_HistoricoImprimir
        fImp.ShowDialog()
    End Sub

    Private Sub btnCorregirLectura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorregirLectura.Click
        pFactura = dgFacturas.Item("Factura", dgFacturas.CurrentRow.Index).Value
        Dim fCorr As New Frm_CorregirLectura
        If fCorr.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ds.Tables("Fac").Clear()
            da.SelectCommand.CommandText = "Select * From Facturas Where Servicio = 1 And Abonado = " & cboAbonado.SelectedValue & " Order By Factura"
            da.Fill(ds, "Fac")
        End If
    End Sub

    Private Sub cboAbonado_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAbonado.SelectionChangeCommitted
        Ver_Abonado(cboAbonado.SelectedValue)
    End Sub

    Private Sub btnCorregir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorregir.Click
        If MessageBox.Show("Esta seguro de corregir los datos del cliente?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            pCliente = ""
            Dim fCli As New Frm_Cliente_Reg
            If fCli.ShowDialog = Windows.Forms.DialogResult.OK Then
                For i = 0 To ds.Tables("Abo").Rows.Count - 1
                    Actualizar_datos(TxCliente.Text, pCliente, ds.Tables("Abo").Rows(i).Item("Abonado"))
                Next
                Eliminar_Cliente(TxCliente.Text)
                MessageBox.Show("Se ha actualizado los datos del cliente", "Atención", MessageBoxButtons.OK)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Eliminar_Cliente(ByVal Cliente As String)
        Try
            Dim cmd As New SqlCommand
            Dim txt As String

            txt = "delete cliente where cliente = '" & Cliente & "'"

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With
            db.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub


    Private Sub Actualizar_datos(ByVal ClienteAnterior As String, ByVal ClienteActual As String, ByVal Abonado As Integer)
        Try
            Dim cmd As New SqlCommand
            Dim txt As String

            txt = "Update Usuarios set NoDoc = '" & ClienteActual & "', cajero = '" & _Usuario & "' where Abonado = " & Abonado & " and NoDoc = '" & ClienteAnterior & "'"

            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With
            db.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

End Class