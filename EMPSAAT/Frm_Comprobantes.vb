Imports System.Data.SqlClient

Public Class Frm_Comprobantes
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim nCbte As Integer
    Dim nNro As Integer
    Dim dFecIn As Date
    Dim dFecUl As Date
    Dim dFecha As Date

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Frm_Comprobantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' obtener la ultima fecha de los comprobantes

        da.SelectCommand.CommandText = "Select Max(comprobante) as Cbte From comprobantes"
        da.Fill(ds, "Cbte")
        If IsDBNull(ds.Tables("Cbte").Rows(0).Item("Cbte")) Then
            nCbte = 1
        Else
            nCbte = ds.Tables("Cbte").Rows(0).Item("Cbte") + 1
        End If
        dFecha = Date.Now

        '-------------------------------------------------------------------------
        da.SelectCommand.CommandText = "Select Max(Fecha) as Fec From Comprobantes"
        da.Fill(ds, "Fec")
        dFecIn = DateAdd(DateInterval.Day, 1, ds.Tables("Fec").Rows(0).Item("Fec"))
        If Year(dFecIn) < Year(Date.Now) Then
            nNro = 1
        Else
            da.SelectCommand.CommandText = "Select Numero From Comprobantes where Fecha in (Select Max(Fecha) From Comprobantes)"
            'da.SelectCommand.CommandText = "Select Max(Numero) as Nro From Comprobantes"
            da.Fill(ds, "Nro")
            If IsDBNull(ds.Tables("Nro").Rows(0).Item("NUMERO")) Then
                nNro = 1
            Else
                nNro = ds.Tables("Nro").Rows(0).Item("NUMERO") + 1
            End If
        End If
        txtNumero.Text = nNro
        txtFecha.Text = FormatDateTime(dFecha, DateFormat.ShortDate)
    End Sub

    Private Sub btnCrear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrear.Click
        Dim cmd As New SqlCommand
        Try
            db.Open()
            With cmd
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Comprobantes (Comprobante, Numero, Fecha, Contabilizado) Values ('" & nCbte & "','" & nNro & "','" & FormatDateTime(dFecha, DateFormat.ShortDate) & "',0)"
                .ExecuteNonQuery()
            End With
            pNum_Comprobante = nCbte
            pFec_Pago = dFecha
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub
End Class