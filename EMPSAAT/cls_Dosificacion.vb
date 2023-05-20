Imports System.Data.SqlClient

Public Class cls_Dosificacion
    Private xAutorizacion As Int64
    Private xLlave As String
    Private xFecInicial As Date
    Private xFecFinal As Date
    Private xEmision As Date

    ReadOnly Property Autorizacion() As Int64
        Get
            Return xAutorizacion
        End Get
    End Property

    ReadOnly Property Llave() As String
        Get
            Return xLlave
        End Get
    End Property

    Property Emision() As Date
        Get
            Return xEmision
        End Get
        Set(ByVal value As Date)
            xEmision = value
        End Set
    End Property

    ReadOnly Property Dosificacion() As Boolean
        Get
            Return Obtener_Dosificacion(xEmision)
        End Get
    End Property

    Private Function Obtener_Dosificacion(ByVal fecha As Date) As Boolean
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        Dim re As Boolean = False

        da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = 1"
        da.Fill(ds, "Dos")

        If ds.Tables("Dos").Rows.Count > 0 Then
            If fecha >= ds.Tables("Dos").Rows(0).Item("Fec_Inicial") Then
                If fecha <= ds.Tables("Dos").Rows(0).Item("Fec_Final") Then
                    xAutorizacion = ds.Tables("Dos").Rows(0).Item("Autorizacion")
                    xLlave = ds.Tables("Dos").Rows(0).Item("Llave")
                    re = True
                End If
            End If
        End If
        Obtener_Dosificacion = re
    End Function
End Class
