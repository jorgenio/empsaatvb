Imports System.Data.SqlClient

Public Class Frm_Clientes_Migrar
    Dim DB As New SqlConnection(cn)
    Dim DA As New SqlDataAdapter("", DB)
    Dim DS As New DataSet
    Dim I As Integer
    Dim txt As String

    Private Sub btnMigrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMigrar.Click
        Try
            'Dim txt As String
            Dim cmd As New SqlCommand
            Dim xDoc As Integer

            xDoc = -100000
            DB.Open()
            cmd.Connection = DB
            cmd.CommandType = CommandType.Text

            DA.SelectCommand.CommandText = "SELECT * FROM USUARIOS ORDER BY ABONADO"
            DA.Fill(DS, "USU")
            For I = 0 To DS.Tables("USU").Rows.Count - 1
                'If Len(DS.Tables("USU").Rows(I).Item("NODOC")) > 0 Then
                xDoc -= 1
                'If Not Existe_Cliente(DS.Tables("USU").Rows(I).Item("NODOC")) Then
                txt = "INSERT INTO CLIENTE (CLIENTE, DOCUMENTO, RAZON, NIT, NACIMIENTO, EMPLEADO) VALUES ('" & _
                xDoc & "','" & _
                DS.Tables("USU").Rows(I).Item("DOC") & "','" & _
                DS.Tables("USU").Rows(I).Item("NOMBRE") & "','" & _
                DS.Tables("USU").Rows(I).Item("NIT") & "','" & _
                DS.Tables("USU").Rows(I).Item("NACIMIENTO") & "','MIGRACION')"

                ' DS.Tables("USU").Rows(I).Item("NODOC") & "','" & _
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()

                txt = "Update USUARIOS set NoDoc = '" & xDoc & "' Where Abonado = '" & DS.Tables("USU").Rows(I).Item("ABONADO") & "'"
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
                'End If
                'End If
            Next

            MessageBox.Show("proceso terminado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & " " & txt, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If DB.State = ConnectionState.Open Then DB.Close()
        End Try
    End Sub

    Function Existe_Cliente(ByVal Cliente As String) As Boolean
        DA.SelectCommand.CommandText = "Select * From Cliente Where Cliente = '" & Cliente & "'"
        DA.Fill(DS, "EXI")
        If DS.Tables("EXI").Rows.Count > 0 Then
            Existe_Cliente = True
        Else
            Existe_Cliente = False
        End If
        DS.Tables("EXI").Clear()
    End Function

    Private Sub Frm_Clientes_Migrar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DA.SelectCommand.CommandText = "Select * From Usuarios Where len(NoDoc) = 0"
        DA.Fill(DS, "NoDoc")
        If DS.Tables("NoDoc").Rows.Count > 0 Then
            btnCompletarNoDoc.Enabled = True
        Else
            btnCompletarNoDoc.Enabled = False
        End If
        DS.Tables("NoDoc").Clear()
    End Sub

    Private Sub btnCompletarNoDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompletarNoDoc.Click
        Try
            Dim txt As String
            Dim cmd As New SqlCommand
            DB.Open()
            cmd.Connection = DB
            cmd.CommandType = CommandType.Text


            DA.SelectCommand.CommandText = "Select * From Usuarios Where Len(NoDoc) = 0"
            DA.Fill(DS, "USU")
            For I = 0 To DS.Tables("USU").Rows.Count - 1
                txt = "UPDATE USUARIOS SET NODOC = '" & I * -1 & "', DOC = 'INV' WHERE ABONADO = " & DS.Tables("USU").Rows(I).Item("ABONADO")
                cmd.CommandText = txt
                cmd.ExecuteNonQuery()
            Next
            DS.Tables("USU").Clear()
            btnCompletarNoDoc.Enabled = False

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If DB.State = ConnectionState.Open Then DB.Close()
        End Try
    End Sub

    'Function Nuevo_Documento() As Integer
    '    DA.SelectCommand.CommandText = "Select Min(NoDoc) as NDoc From Usuarios"
    '    DA.Fill(DS, "NDoc")
    '    If DS.Tables("NDoc").Rows.Count > 0 Then
    '        If Not IsDBNull(DS.Tables("NDoc").Rows(0).Item("NDoc")) Then
    '            Nuevo_Documento = Val(DS.Tables("NDoc").Rows(0).Item("NDoc")) - 1
    '        End If
    '    Else
    '        Nuevo_Documento = -1
    '    End If
    '    DS.Tables("NDoc").Clear()
    'End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class