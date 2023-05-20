Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_RegistroLey1886
    Dim db As New SqlConnection(cn)
    Dim daUsu As New SqlDataAdapter("", db)
    Dim Ds As New DataSet

    Private Sub Ver_Lista()
        'daUsu.SelectCommand.CommandText = "Select Abonado, Nombre, Zona, Calle, Doc, NoDoc, Nacimiento, No_Afi, Fec_Afi, D_I From Usuarios Where Ley1886 = 1 Order By Abonado"
        daUsu.SelectCommand.CommandText = "Select * From Ver_Ley1886_Afiliados Order By Abonado"
        daUsu.Fill(Ds, "Usuarios")
        dgUsu.DataSource = Ds.Tables("Usuarios")
        'Formatea_Tabla()
    End Sub

    Private Sub Formatea_Tabla()
        Dim dt As New DataGridTableStyle
        dt.MappingName = "Usuarios"

        Dim c1 As New DataGridTextBoxColumn
        c1.MappingName = "Abonado"
        c1.HeaderText = "Abonado"
        c1.ReadOnly = True
        c1.Width = 60
        dt.GridColumnStyles.Add(c1)

        Dim c2 As New DataGridTextBoxColumn
        c2.MappingName = "Nombre"
        c2.HeaderText = "Nombre ó Razón Social"
        c2.ReadOnly = True
        c2.Width = 250
        dt.GridColumnStyles.Add(c2)

        Dim c3 As New DataGridTextBoxColumn
        c3.MappingName = "Zona"
        c3.HeaderText = "Zona"
        c3.ReadOnly = True
        c3.Width = 150
        dt.GridColumnStyles.Add(c3)

        Dim c4 As New DataGridTextBoxColumn
        c4.MappingName = "Calle"
        c4.HeaderText = "Calle"
        c4.ReadOnly = True
        c4.Width = 150
        dt.GridColumnStyles.Add(c4)

        Dim c5 As New DataGridTextBoxColumn
        c5.MappingName = "Doc"
        c5.HeaderText = "Doc."
        c5.ReadOnly = True
        c5.Width = 30
        dt.GridColumnStyles.Add(c5)

        Dim c6 As New DataGridTextBoxColumn
        c6.MappingName = "Nodoc"
        c6.HeaderText = "No Doc."
        c6.ReadOnly = True
        c6.Width = 100
        dt.GridColumnStyles.Add(c6)

        Dim c7 As New DataGridTextBoxColumn
        c7.MappingName = "Nacimiento"
        c7.HeaderText = "Nacimiento"
        c7.ReadOnly = True
        c7.Width = 100
        dt.GridColumnStyles.Add(c7)

        Dim c8 As New DataGridTextBoxColumn
        c8.MappingName = "No_Afi"
        c8.HeaderText = "No. Afiliado"
        c8.ReadOnly = True
        c8.Width = 100
        dt.GridColumnStyles.Add(c8)

        Dim c9 As New DataGridTextBoxColumn
        c9.MappingName = "Fec_Afi"
        c9.HeaderText = "Afiliación"
        c9.ReadOnly = True
        c9.Width = 100
        dt.GridColumnStyles.Add(c9)

        Dim c10 As New DataGridTextBoxColumn
        c10.MappingName = "D_I"
        c10.HeaderText = "D / I"
        c10.ReadOnly = True
        c10.Width = 30
        dt.GridColumnStyles.Add(c10)

        dgUsu.TableStyles.Clear()
        dgUsu.TableStyles.Add(dt)
    End Sub

    Private Sub Frm_RegistroLey1886_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call Ver_Lista()
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        Dim fbus As New Frm_Busquedas
        If Frm_Busquedas.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fReg As New Frm_RegistroLey1886_Reg
            If fReg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Ver_Lista()
            End If
        End If

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub


    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click
        Dim txt As String
        Dim nAbonado As Integer = dgUsu.Item(dgUsu.CurrentRowIndex, 3)
        Dim cmdGra As New SqlCommand
        'daUsu.SelectCommand.CommandText = "Select Abonado, Nombre, Doc, NoDoc From Usuarios Where Abonado = '" & nAbonado & "'"
        daUsu.SelectCommand.CommandText = "Select * From Ver_Usuarios Where Abonado = '" & nAbonado & "'"
        daUsu.Fill(Ds, "QuitarLey1886")

        If Ds.Tables("QuitarLey1886").Rows.Count > 0 Then
            txt = "Quitar el beneficio al siguiente registro?" & _
                  "Abonado = " & Ds.Tables("QuitarLey1886").Rows(0).Item("Abonado") & _
                  "Nombre = " & Ds.Tables("QuitarLey1886").Rows(0).Item("razon") & _
                  "Documento = " & Ds.Tables("QuitarLey1886").Rows(0).Item("Documento") & " " & Ds.Tables("QuitarLey1886").Rows(0).Item("cliente")
            If MessageBox.Show(txt, "Esta seguro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Try
                    txt = "UPDATE USUARIOS Set Ley1886 = 0 Where Abonado = " & nAbonado
                    db.Open()
                    With cmdGra
                        .Connection = db
                        .CommandType = CommandType.Text
                        .CommandText = txt
                        .ExecuteNonQuery()
                    End With
                    db.Close()
                    Ds.Tables("Usuarios").Clear()
                    Call Ver_Lista()
                    MessageBox.Show("Se ha quitado el beneficio al usuario correctamente", "Proceso terminado con éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    If db.State = ConnectionState.Open Then db.Close()
                End Try
            End If
        End If

    End Sub

End Class