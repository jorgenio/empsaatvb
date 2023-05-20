Imports System.Data
Imports System.Data.SqlClient

Public Class Frm_Usuarios_Reg
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim txt As String

    Private Sub Frm_Usuarios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        da.SelectCommand.CommandText = "Select Distinct Ruta From Usuarios Order by Ruta"
        da.Fill(ds, "Ruta")
        cboRuta.DataSource = ds.Tables("Ruta")
        cboRuta.DisplayMember = "Ruta"
        cboRuta.ValueMember = "Ruta"

        da.SelectCommand.CommandText = "Select Distinct SubRuta From Usuarios Where Ruta = " & cboRuta.SelectedValue & " Order by SuBRuta"
        da.Fill(ds, "SRuta")
        cboSubRuta.DataSource = ds.Tables("SRuta")
        cboSubRuta.DisplayMember = "SubRuta"
        cboSubRuta.ValueMember = "SubRuta"

        da.SelectCommand.CommandText = "Select Distinct Zona From Usuarios Order By Zona"
        da.Fill(ds, "Zonas")
        CboZona.DataSource = ds.Tables("Zonas")
        CboZona.DisplayMember = "Zona"
        CboZona.ValueMember = "Zona"

        da.SelectCommand.CommandText = "Select Distinct Calle From Usuarios Where Zona = '" & CboZona.SelectedValue & "' Order by Calle"
        da.Fill(ds, "Calles")
        CboCalle.DataSource = ds.Tables("Calles")
        CboCalle.DisplayMember = "Calle"
        CboCalle.ValueMember = "Calle"

        da.SelectCommand.CommandText = "Select Liberacion, Descripcion From Usuarios_Liberacion"
        da.Fill(ds, "Liberacion")
        CboLiberacion.DataSource = ds.Tables("Liberacion")
        CboLiberacion.DisplayMember = "Descripcion"
        CboLiberacion.ValueMember = "Liberacion"

        da.SelectCommand.CommandText = "Select Categoria, Descripcion From Usuarios_Categorias Order By Descripcion"
        da.Fill(ds, "Categorias")
        CboCategoria.DataSource = ds.Tables("Categorias")
        CboCategoria.DisplayMember = "Descripcion"
        CboCategoria.ValueMember = "Categoria"

        da.SelectCommand.CommandText = "Select * From Usuarios Where Abonado = " & nAbonado
        da.Fill(ds, "Usu")
        If ds.Tables("Usu").Rows.Count > 0 Then
            TxtAbonado.Text = ds.Tables("Usu").Rows(0).Item("Abonado")
            cboRuta.SelectedValue = ds.Tables("Usu").Rows(0).Item("Ruta")
            cboSubRuta.Text = ds.Tables("Usu").Rows(0).Item("SubRuta")
            txtNumRuta.Text = ds.Tables("Usu").Rows(0).Item("NumRuta")
            CboZona.Text = ds.Tables("Usu").Rows(0).Item("Zona")
            CboCalle.Text = ds.Tables("Usu").Rows(0).Item("Calle")
            TxtNumero.Text = ds.Tables("Usu").Rows(0).Item("Num")

            TxtMedidor.Text = ds.Tables("Usu").Rows(0).Item("Medidor")
            CboLiberacion.SelectedValue = ds.Tables("Usu").Rows(0).Item("Liberacion")
            TxtConsFijo.Text = ds.Tables("Usu").Rows(0).Item("ConsFijo")
            txtLectura.Text = ds.Tables("Usu").Rows(0).Item("Lect_Inicial")
            CboCategoria.SelectedValue = ds.Tables("Usu").Rows(0).Item("Categoria")
        Else
            TxtAbonado.Text = Nuevo_Abonado()
        End If
    End Sub

    Function Nuevo_Abonado() As Integer
        da.SelectCommand.CommandText = "Select Max(Abonado) as Nro From Usuarios"
        da.Fill(ds, "Nro")
        If Not IsDBNull(ds.Tables("Nro").Rows(0).Item("Nro")) Then
            Nuevo_Abonado = ds.Tables("Nro").Rows(0).Item("Nro") + 1
        Else
            Nuevo_Abonado = 2
        End If
        ds.Tables("Nro").Clear()
    End Function

    Private Sub BtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrabar.Click
        Dim cmdGra As New SqlCommand
        Dim xAbonado As New SqlParameter
        Try
            If Duplica_Usuario(TxtAbonado.Text) Then
                txt = "Update Usuarios Set Zona = '" & CboZona.Text & "', Calle = '" & CboCalle.Text & "', Num = '" & TxtNumero.Text & "', Medidor = '" & TxtMedidor.Text & "', Liberacion = '" & CboLiberacion.SelectedValue & "', ConsFijo = '" & TxtConsFijo.Text & "', Categoria = '" & CboCategoria.SelectedValue & "', RUTA = '" & Val(cboRuta.Text) & "', SUBRUTA = '" & Val(cboSubRuta.Text) & "', NUMRUTA = '" & Val(txtNumRuta.Text) & "' Where Abonado = " & TxtAbonado.Text
                'txt = "Update Usuarios Set Zona = '" & CboZona.Text & "', Calle = '" & CboCalle.Text & "', Num = '" & TxtNumero.Text & "', Ruta = '" & cboRuta.Text & "', SubRuta = '" & cboSubRuta.Text & "', NumRuta = '" & txtNumRuta.Text & "' Where Abonado = " & TxtAbonado.Text
            Else
                txt = "INSERT INTO USUARIOS (NODOC, NOMBRE, ABONADO, ZONA, CALLE, NUM, MEDIDOR, LIBERACION, CONSFIJO, ESTADO, CATEGORIA, FEC_INS, LEY1886, LECT_INICIAL, FEC_AFI, NO_AFI, Ruta, SUBRUTA, NUMRUTA, D_I) VALUES ('" & _
                pCliente & "','" & _
                TxtAbonado.Text & "','" & _
                TxtAbonado.Text & "','" & _
                CboZona.SelectedValue & "','" & _
                CboCalle.SelectedValue & "','" & _
                TxtNumero.Text & "','" & _
                TxtMedidor.Text & "','" & _
                CboLiberacion.SelectedValue & "','" & _
                TxtConsFijo.Text & "','X','" & _
                CboCategoria.SelectedValue & "','" & _
                FormatDateTime(Date.Now, DateFormat.ShortDate) & "','0','" & _
                txtLectura.Text & "','" & FormatDateTime(Date.Now, DateFormat.ShortDate) & "','0','" & _
                cboRuta.Text & "','" & _
                cboSubRuta.Text & "','" & _
                txtNumRuta.Text & "','D')"
            End If
            db.Open()
            With cmdGra
                .Connection = db
                .CommandType = CommandType.Text
                .CommandText = txt
                .ExecuteNonQuery()
            End With

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch x As Exception
            MessageBox.Show("Error al grabar datos " & x.Message, "Por favor revice los datos a grabar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Finally
            If db.State = ConnectionState.Open Then
                db.Close()
            End If
        End Try
    End Sub

    Private Sub CboZona_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboZona.SelectionChangeCommitted
        da.SelectCommand.CommandText = "Select Distinct Calle From Usuarios Where Zona = '" & CboZona.SelectedValue & "'"
        ds.Tables("Calles").Clear()
        da.Fill(ds, "Calles")
        CboCalle.DataSource = ds.Tables("Calles")
        CboCalle.DisplayMember = ds.Tables("Calles").Columns("Calle").ColumnName
        CboCalle.ValueMember = ds.Tables("Calles").Columns("Calle").ColumnName
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TxtAbonado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAbonado.KeyPress
        e.Handled = True
    End Sub

    Private Sub cboRuta_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRuta.SelectionChangeCommitted
        ds.Tables("SRuta").Clear()
        da.SelectCommand.CommandText = "Select Distinct subRuta From Usuarios Where Ruta = " & cboRuta.SelectedValue & " Order by subRuta"
        da.Fill(ds, "SRuta")
        ds.Tables("Zonas").Clear()
        da.SelectCommand.CommandText = "Select Distinct Zona From usuarios Where Ruta = " & cboRuta.SelectedValue & " Order by Zona"
        da.Fill(ds, "Zonas")
        ds.Tables("Calles").Clear()
        da.SelectCommand.CommandText = "Select Distinct Calle From Usuarios Where Ruta = " & cboRuta.SelectedValue & " Order By Calle"
        da.Fill(ds, "Calles")
    End Sub

    Private Sub cboSubRuta_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSubRuta.SelectionChangeCommitted
        ds.Tables("Zonas").Clear()
        da.SelectCommand.CommandText = "Select Distinct Zona From usuarios Where Ruta = " & cboRuta.SelectedValue & " And SubRuta = " & cboSubRuta.SelectedValue & " Order by Zona"
        da.Fill(ds, "Zonas")
        ds.Tables("Calles").Clear()
        da.SelectCommand.CommandText = "Select Distinct Calle From Usuarios Where Ruta = " & cboRuta.SelectedValue & " And SubRuta = " & cboSubRuta.SelectedValue & " Order by Calle"
        da.Fill(ds, "Calles")
    End Sub

    Private Sub CboZona_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboZona.SelectedIndexChanged

    End Sub

    Private Sub cboRuta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRuta.SelectedIndexChanged

    End Sub
End Class