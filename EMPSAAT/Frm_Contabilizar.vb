Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Frm_Contabilizar
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Registrar_Factura_Efectivas(ByVal Comprobante As Integer)
        Dim nImpE As Double
        Dim nAlcE As Double
        Dim nRepE As Double
        Dim nRecE As Double
        Dim nCarE As Double
        Dim nLeyE As Double
        Dim nTotE As Double
        Dim nIvaE As Double

        Dim cmd As New SqlCommand
        Dim txt As String
        Dim xComprobante As SqlParameter

        db.Open()
        With cmd
            .Connection = db
            .CommandType = CommandType.StoredProcedure
            .CommandText = txt
            xComprobante = .Parameters.Add("@Comprobante", SqlDbType.Int)
            xComprobante.Direction = ParameterDirection.Input
            xComprobante.Value = Comprobante
            da.SelectCommand = cmd
            da.Fill(ds, "EFE")
        End With

        If ds.Tables("EFE").Rows.Count > 0 Then
            nImpE = ds.Tables("EFE").Rows(0).Item("IMP_TOTAL")
            nAlcE = ds.Tables("EFE").Rows(0).Item("IMP_ALCANTA")
            nRepE = ds.Tables("EFE").Rows(0).Item("IMP_REPOSICION")
            nRecE = ds.Tables("EFE").Rows(0).Item("IMP_RECARGO")
            nCarE = ds.Tables("EFE").Rows(0).Item("IMP_CARGO")
            nLeyE = ds.Tables("EFE").Rows(0).Item("IMP_LEY1886")
            nTotE = nImpE + nAlcE + nRepE + nRecE + nCarE
            nIvaE = Math.Round((nTotE * 0.87), 2)
        End If
        ds.Tables("EFE").Clear()

    End Sub
End Class