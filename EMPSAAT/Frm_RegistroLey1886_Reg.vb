Imports System.Data.SqlClient

Public Class Frm_RegistroLey1886_Reg
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet

    Private Sub Frm_RegistroLey1886_Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From ver_usuarios Where Abonado = " & nAbonado
        da.Fill(ds, "Abo")
        If ds.Tables("Abo").Rows.Count > 0 Then
            Ver_Abonado()
        End If
    End Sub

    Private Sub Ver_Abonado()
        TxtAbonado.Text = ds.Tables("Abo").Rows(0).Item("Abonado")
        TxtNombre.Text = IIf(IsDBNull(ds.Tables(("Abo")).Rows(0).Item("Razon")), "", ds.Tables(("Abo")).Rows(0).Item("Razon"))
        TxtZona.Text = IIf(IsDBNull(ds.Tables(("Abo")).Rows(0).Item("Zona")), "", ds.Tables(("Abo")).Rows(0).Item("Zona"))
        TxtCalle.Text = IIf(IsDBNull(ds.Tables(("Abo")).Rows(0).Item("Calle")), "", ds.Tables(("Abo")).Rows(0).Item("Calle"))
        TxtCategoria.Text = IIf(IsDBNull(ds.Tables(("Abo")).Rows(0).Item("Categoria")), "", ds.Tables(("Abo")).Rows(0).Item("Categoria"))
        txtDocumento.Text = IIf(IsDBNull(ds.Tables(("Abo")).Rows(0).Item("Documento")), "", ds.Tables(("Abo")).Rows(0).Item("Documento"))
        TxtNoDoc.Text = IIf(IsDBNull(ds.Tables(("Abo")).Rows(0).Item("cliente")), "", ds.Tables(("Abo")).Rows(0).Item("Cliente"))
        txtNacimiento.Text = IIf(IsDBNull(ds.Tables(("Abo")).Rows(0).Item("Nacimiento")), Date.Now, ds.Tables(("Abo")).Rows(0).Item("Nacimiento"))
        If IsDBNull(ds.Tables(("Abo")).Rows(0).Item("D_I")) Then
            CobD_I.Text = "Directo"
        Else
            CobD_I.Text = IIf(ds.Tables(("Abo")).Rows(0).Item("D_I") = "I", "Indirecto", "Directo")
        End If
        BtnGrabar.Enabled = True
        If ds.Tables(("Abo")).Rows(0).Item("Ley1886") Then
            MessageBox.Show("Este registro ya tiene el beneficio", "No se puede registrar dos veces al mismo usuario", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ds.Tables(("Abo")).Clear()
            BtnGrabar.Enabled = False
            Exit Sub
        End If
        txtEdad.Text = DateDiff(DateInterval.Year, CDate(txtNacimiento.Text), Date.Now)
        ds.Tables(("Abo")).Clear()
        BtnGrabar.Enabled = True
    End Sub

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Try
            Dim cmd As New SqlCommand
            Dim txt As String
            Dim cmdGra As New SqlCommand
            Dim xAbonado As New SqlParameter
            Dim nNo As Integer

            '--------- validar categoria
            If TxtCategoria.Text <> "Doméstico" Then
                MessageBox.Show("Para ser beneficiario debe pertenecer a la categoria Doméstico", "No puede ser beneficiarios de la Ley 1886", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '--------- Validad Documento
            If txtDocumento.Text = "" Then
                MessageBox.Show("Debe registrar el tipo de documento presentado para su afiliación", "Error en el registro de documento", MessageBoxButtons.OK)
                Exit Sub
            End If
            '--------- Validar No de documento
            If TxtNoDoc.Text = "" Then
                MessageBox.Show("Debe dar el numero de documento del usuario", "Error en el Nro. de Documento", MessageBoxButtons.OK)
                Exit Sub
            End If

            '--------- Validar la edad del usuario
            Dim Edad As Integer = DateDiff(DateInterval.Year, CDate(txtNacimiento.Text), Date.Now)
            If Edad < 60 Then
                MessageBox.Show("El usuario es menor de 60 años", "Error en la Edad del usuario", MessageBoxButtons.OK)
                Exit Sub
            End If

            '--------- Validar Directo Indirecto
            If CobD_I.Text <> "Directo" Then
                If CobD_I.Text <> "Indirecto" Then
                    MessageBox.Show("Debe registrar el tipo de consumo Directo ó Indirecto", "Error en el Tipo de consumidor", MessageBoxButtons.OK)
                    Exit Sub
                End If
            End If


            nNo = numero_Afiliacion()

            txt = "UPDATE USUARIOS Set Ley1886 = 1, Fec_Afi = '" & Format(Date.Now, "dd/MM/yyyy") & "', D_I = '" & IIf(CobD_I.Text = "Indirecto", "I", "D") & "', No_Afi = '" & nNo & "' Where Abonado = " & TxtAbonado.Text

            db.Open()
            With cmdGra
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Function Numero_Afiliacion() As Integer
        da.SelectCommand.CommandText = "Select Count(Abonado) From Usuarios Where Ley1886 = 1"
        da.Fill(ds, "NoRegistro")

        If ds.Tables("NoRegistro").Rows.Count > 0 Then
            Numero_Afiliacion = ds.Tables("NoRegistro").Rows(0).Item(0) + 1
        Else
            Numero_Afiliacion = 1
        End If
        ds.Tables("NoRegistro").Clear()
    End Function

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class