Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Frm_Usuarios
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim txt As String

    Private Sub Frm_Usuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        da.SelectCommand.CommandText = "Select * From Cliente Where Cliente = '" & pCliente & "'"
        da.Fill(ds, "Cli")
        If ds.Tables("Cli").Rows.Count > 0 Then
            txtCliente.Text = ds.Tables("Cli").Rows(0).Item("Cliente")
            txtRazon.Text = ds.Tables("Cli").Rows(0).Item("Razon")
            txtNit.Text = ds.Tables("Cli").Rows(0).Item("Nit")
            txtTelefono.Text = IIf(IsDBNull(ds.Tables("Cli").Rows(0).Item("Telefono")), "", ds.Tables("Cli").Rows(0).Item("Telefono"))
            Ver_Datos(pCliente)
        End If
    End Sub

    'Private Sub Formatea_Tabla()
    '    Dim dt As New DataGridTableStyle
    '    dt.MappingName = "Usuarios"

    '    Dim c1 As New DataGridTextBoxColumn
    '    c1.MappingName = "Abonado"
    '    c1.HeaderText = "Abonado"
    '    c1.ReadOnly = True
    '    c1.Width = 100
    '    dt.GridColumnStyles.Add(c1)

    '    Dim c2 As New DataGridTextBoxColumn
    '    c2.MappingName = "Nombre"
    '    c2.HeaderText = "Nombre ó Razón Social"
    '    c2.ReadOnly = True
    '    c2.Width = 250
    '    dt.GridColumnStyles.Add(c2)

    '    Dim c3 As New DataGridTextBoxColumn
    '    c3.MappingName = "Zona"
    '    c3.HeaderText = "Zona"
    '    c3.ReadOnly = True
    '    c3.Width = 150
    '    dt.GridColumnStyles.Add(c3)

    '    Dim c4 As New DataGridTextBoxColumn
    '    c4.MappingName = "Calle"
    '    c4.HeaderText = "Calle"
    '    c4.ReadOnly = True
    '    c4.Width = 150
    '    dt.GridColumnStyles.Add(c4)

    '    Dim c5 As New DataGridTextBoxColumn
    '    c5.MappingName = "Num"
    '    c5.HeaderText = "Nro."
    '    c5.ReadOnly = True
    '    c5.Width = 50
    '    dt.GridColumnStyles.Add(c5)

    '    dgUsu.TableStyles.Clear()
    '    dgUsu.TableStyles.Add(dt)
    'End Sub

    Private Sub Ver_Datos(ByVal Cliente As String)
        da.SelectCommand.CommandText = "Select * From Ver_Usuarios Where Cliente = '" & Cliente & "' Order By Abonado"
        da.Fill(ds, "Usuarios")
        dgUsu.DataSource = ds.Tables("Usuarios")
    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        nAbonado = 0
        pCliente = txtCliente.Text
        Dim fReg As New Frm_Usuarios_Reg
        If fReg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ds.Tables("Usuarios").Clear()
            Ver_Datos(txtCliente.Text)
        End If
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim oRptReg As New Rep_RegistroUsuario
        Dim oConexInfo As New ConnectionInfo
        Dim oListaTablas As Tables
        Dim oTabla As Table
        Dim oTablaConexInfo As TableLogOnInfo
        Dim cmdGra As New SqlCommand
        Dim xAbonado As New SqlParameter
        Dim zAbonado As Integer
        'zAbonado = Val(dgUsu.Item(dgUsu.CurrentRow.Index, 0))
        Try


            db.Open()

            With cmdGra
                .Connection = db
                .CommandType = CommandType.StoredProcedure
                .CommandText = "RepRegistroUsuarios"
                xAbonado = cmdGra.Parameters.Add("@Abonado", SqlDbType.Int)
                xAbonado.Direction = ParameterDirection.Input
                xAbonado.Value = zAbonado
                .ExecuteNonQuery()
            End With

            oConexInfo.ServerName = "SERVIDORHP"
            oConexInfo.DatabaseName = "EMPSAAT"
            oConexInfo.UserID = _Usuario
            oConexInfo.Password = _Clave

            oListaTablas = oRptReg.Database.Tables

            For Each oTabla In oListaTablas
                oTablaConexInfo = oTabla.LogOnInfo
                oTablaConexInfo.ConnectionInfo = oConexInfo
                oTabla.ApplyLogOnInfo(oTablaConexInfo)
            Next

            Dim fRep As New Frm_Reportes
            fRep.crvRep.ReportSource = oRptReg
            fRep.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

    Private Sub BtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditar.Click
        nAbonado = dgUsu.Item("Abonado", dgUsu.CurrentRow.Index).Value
        pCliente = txtCliente.Text
        Dim fReg As New Frm_Usuarios_Reg
        If fReg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ds.Tables("Usuarios").Clear()
            Ver_Datos(txtCliente.Text)
        End If
    End Sub

    Private Sub btnCorregir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCorregir.Click
        If MessageBox.Show("Esta seguro de corregir los datos del CLIENTE", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim fReg As New Frm_Cliente_Reg
            Dim ClienteAntes As String
            pCliente = ""
            ClienteAntes = txtCliente.Text
            If fReg.ShowDialog = Windows.Forms.DialogResult.OK Then
                Corregir_Registro(pCliente, ClienteAntes)
                Me.Close()
            End If
        End If
    End Sub


    Private Sub Corregir_Registro(ByVal ClienteValido As String, ByVal ClienteNulo As String)
        Try
            Dim txt As String
            Dim cmd As New SqlCommand

            txt = "Update Usuarios Set NoDoc = '" & ClienteValido & "' WHERE NoDoc = '" & ClienteNulo & "'"
            db.Open()
            With cmd
                .Connection = db
                .CommandText = txt
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With

            txt = "DELETE CLIENTE WHERE CLIENTE = '" & ClienteNulo & "'"
            cmd.CommandText = txt
            cmd.ExecuteNonQuery()

            db.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub
End Class