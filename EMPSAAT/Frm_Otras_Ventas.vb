Imports System.Data.SqlClient

Public Class Frm_Otras_Ventas
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim i As Integer

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("Esta seguro de Cancelar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            Dim nImporte As Double
            Dim nIce_Iehd_tasas As Double
            Dim nExcentos As Double
            Dim nVentas_Tasa_Cero As Double
            Dim nSubtotal As Double
            Dim nDescuento As Double
            Dim nImporte_Para_Debito As Double
            Dim nDebito As Double
            Dim cCodigoControl As String
            Dim V7CodCon As New CodigoV7
            Dim lTieneEntrega As Boolean = False
            Dim cLlave As String
            Dim dFecFin As Date
            Dim dFecIni As Date
            Dim nIte As Double

            da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = 1"
            da.Fill(ds, "Dos")
            If ds.Tables("Dos").Rows.Count > 0 Then

                pNum_Autorizacion = ds.Tables("Dos").Rows(0).Item("Autorizacion")
                pFactura = Nuevo_Numero_Factura(pNum_Autorizacion)
                cLlave = ds.Tables("Dos").Rows(0).Item("Llave")
                dFecFin = ds.Tables("Dos").Rows(0).Item("Fec_Final")
                dFecIni = ds.Tables("Dos").Rows(0).Item("Fec_Inicial")
                nImporte = Val(txtTotal.Text)
                nIce_Iehd_tasas = 0
                nExcentos = 0
                nVentas_Tasa_Cero = 0
                nSubtotal = nImporte - nIce_Iehd_tasas - nExcentos - nVentas_Tasa_Cero
                nDescuento = 0
                nImporte_Para_Debito = nSubtotal - nDescuento

                nDebito = Math.Round(nImporte * 0.13, 2)
                nIte = Math.Round(nImporte * 0.03, 2)
                If Date.Now >= dFecIni Then
                    If Date.Now <= dFecFin Then
                        pFactura = Nuevo_Numero_Factura(pNum_Autorizacion)
                        V7CodCon.NoAutorizacion = pNum_Autorizacion
                        V7CodCon.Llave = pLlave
                        V7CodCon.Fecha = pFec_Pago
                        V7CodCon.Importe = nImporte
                        V7CodCon.NoFactura = pFactura
                        V7CodCon.NoNit = txtNit.Text

                        cCodigoControl = V7CodCon.Codigo

                        txt = "INSERT INTO LIBRO (ESPECIFICACION, FECHA, FACTURA, AUTORIZACION, ESTADO, NIT, RAZON, IMPORTE_VENTA, ICE_IEHD_TASAS, EXCENTAS, " & _
                            "VENTAS_TASA_CERO, SUBTOTAL, DESCUENTOS, IMPORTE_PARA_DEBITO, DEBITO_FISCAL, CODIGO_CONTROL, SERVICIO, USUARIO, COMPROBANTE) VALUES ('" & _
                        "3','" & pFec_Pago & "','" & pFactura & "','" & pNum_Autorizacion & "','V','" & Val(txtNit.Text) & "','" & txtRazon.Text & "','" & _
                        nImporte & "','" & nIce_Iehd_tasas & "','" & nExcentos & "','" & nVentas_Tasa_Cero & "','" & nSubtotal & "','" & _
                        nDescuento & "','" & nImporte_Para_Debito & "','" & nDebito & "','" & cCodigoControl & "','2','" & UCase(_Usuario) & "','" & pNum_Comprobante & "')"

                        db.Open()
                        With cmd
                            .Connection = db
                            .CommandType = CommandType.Text
                            .CommandText = txt
                            .ExecuteNonQuery()
                        End With

                        For i = 0 To dgMaterial.RowCount - 1
                            If dgMaterial.Item("TOTAL", i).Value > 0 Then
                                txt = "INSERT INTO LIBRO_DETALLE (FACTURA, AUTORIZACION, MATERIAL, DESCRIPCION, UNIDAD, UNITARIO, TOTAL, ENTREGA) VALUES ('" & _
                                    pFactura & "','" & pNum_Autorizacion & "','" & dgMaterial.Item("MATERIAL", i).Value & "','" & dgMaterial.Item("DESCRIPCION", i).Value & "','" & _
                                    dgMaterial.Item("UNIDAD", i).Value & "','" & dgMaterial.Item("UNITARIO", i).Value & "','" & dgMaterial.Item("TOTAL", i).Value & "'," & _
                                    IIf(dgMaterial.Item("ENTREGA", i).Value, 1, 0) & ")"
                                If dgMaterial.Item("Entrega", i).Value Then lTieneEntrega = True
                                cmd.CommandText = txt
                                cmd.ExecuteNonQuery()
                            End If
                        Next
                        db.Close()

                        Dim fRep As New Frm_Imprimir_Factura_Otras_Ventas
                        If fRep.ShowDialog = Windows.Forms.DialogResult.OK Then

                        End If

                        If lTieneEntrega = True Then
                            Dim fEnt As New Frm_Imprimir_Orden_Entrega
                            fEnt.ShowDialog()
                        End If

                        Me.Close()
                    End If

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub Frm_Otras_Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fBus As New Frm_Cliente_Busqueda
        If fBus.ShowDialog = Windows.Forms.DialogResult.OK Then
            da.SelectCommand.CommandText = "Select * From Cliente Where Cliente = '" & pCliente & "'"
            da.Fill(ds, "Cli")
            If ds.Tables("Cli").Rows.Count > 0 Then
                txtCliente.Text = ds.Tables("Cli").Rows(0).Item("Cliente")
                txtRazon.Text = ds.Tables("Cli").Rows(0).Item("Razon")
                txtNit.Text = ds.Tables("Cli").Rows(0).Item("Nit")
                dgMaterial.Rows.Add(10)
            Else
                btnGrabar.Enabled = False
            End If
        End If
    End Sub

    Private Sub Encontrar_Material(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        pMaterial = ""
        Dim fBus As New Frm_Material_Lista
        If fBus.ShowDialog = Windows.Forms.DialogResult.OK Then
            Buscar_Material(pMaterial, dgMaterial.CurrentRow.Index)
        End If
    End Sub

    Private Sub Buscar_Material(ByVal Material As String, ByVal fila As Integer)
        da.SelectCommand.CommandText = "Select * From Material Where Material = '" & Material & "'"
        da.Fill(ds, "Mat")
        If ds.Tables("Mat").Rows.Count > 0 Then
            dgMaterial.Item("Material", fila).Value = ds.Tables("Mat").Rows(0).Item("Material")
            dgMaterial.Item("Descripcion", fila).Value = ds.Tables("Mat").Rows(0).Item("Descripcion")
            dgMaterial.Item("Unidad", fila).Value = ds.Tables("Mat").Rows(0).Item("Unidad")
            dgMaterial.Item("Unitario", fila).Value = ds.Tables("Mat").Rows(0).Item("Unitario")
            dgMaterial.Item("Entrega", fila).Value = ds.Tables("Mat").Rows(0).Item("Entrega")
            Importe_Total(fila)
        End If
        ds.Tables("Mat").Clear()
    End Sub

    Private Sub Importe_Total(ByVal nFila)
        dgMaterial.Item("Total", nFila).Value = Math.Round(dgMaterial.Item("Cantidad", nFila).Value * dgMaterial.Item("Unitario", nFila).Value, 2)
        txtTotal.Text = Format(Sumar_Total, "#0.00")
    End Sub

    Function Sumar_Total() As Double
        Dim i As Integer
        Dim s As Double
        For i = 0 To dgMaterial.RowCount - 1
            s += dgMaterial.Item("Total", i).Value
        Next
        Sumar_Total = s
    End Function

    Private Sub dgMaterial_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgMaterial.CellEndEdit
        Importe_Total(dgMaterial.CurrentRow.Index)
    End Sub
End Class