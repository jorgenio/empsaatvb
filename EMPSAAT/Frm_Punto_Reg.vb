Imports System.Data.SqlClient

Public Class Frm_Punto_Reg
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim Edi As Boolean = False

    Private Sub Frm_Punto_Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Punto Where Punto = " & pPunto
        da.Fill(ds, "Pto")
        If ds.Tables("Pto").Rows.Count > 0 Then
            txtPunto.Text = ds.Tables("Pto").Rows(0).Item("Punto")
            txtDescripcion.Text = ds.Tables("Pto").Rows(0).Item("Descripcion")
            Edi = True
        Else
            txtPunto.Text = Nuevo_PUnto()
        End If
    End Sub

    Function Nuevo_PUnto() As Integer
        da.SelectCommand.CommandText = "Select max(Punto) as Pto from Punto"
        da.Fill(ds, "Nro")
        If Not IsDBNull(ds.Tables("Nro").Rows(0).Item("Pto")) Then
            Nuevo_PUnto = ds.Tables("Nro").Rows(0).Item("Pto") + 1
        Else
            Nuevo_PUnto = 1
        End If
        ds.Tables("Nro").Clear()
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            If Edi = False Then
                txt = "insert into Punto (Punto, Descripcion) values ('" & txtPunto.Text & "','" & txtDescripcion.Text & "')"
            Else
                txt = "Update Punto set Descripcion = '" & txtDescripcion.Text & "' Where Punto = " & txtPunto.Text
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
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub
End Class