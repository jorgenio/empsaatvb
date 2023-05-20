Imports System.Data.SqlClient

Public Class Frm_Factores_Reg
    Dim db As New SqlConnection(cn)
    Dim da As New SqlDataAdapter("", db)
    Dim ds As New DataSet
    Dim Edi As Boolean = False

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Dim ctex As String
        Dim cmd As New SqlCommand

        db.Open()

        With cmd
            .Connection = db
            .CommandType = CommandType.Text
        End With

        If Edi = True Then
            ctex = "UPDATE Factores SET " & _
              "Do_00_06 = '" & Do00_06.Text & "', " & _
              "Do_07_15 = '" & Do07_15.Text & "', " & _
              "Do_16_25 = '" & Do16_25.Text & "', " & _
              "Do_26_35 = '" & Do26_35.Text & "', " & _
              "Do_36_Mas = '" & Do36_Mas.Text & "', " & _
              "Co_00_15 = '" & Co00_15.Text & "', " & _
              "Co_16_25 = '" & Co16_25.Text & "', " & _
              "Co_26_Mas = '" & Co26_Mas.Text & "', " & _
              "In_00_15 = '" & In00_15.Text & "', " & _
              "In_16_25 = '" & In16_25.Text & "', " & _
              "In_26_Mas = '" & In26_Mas.Text & "', " & _
              "Ins_00_15 = '" & Is00_15.Text & "', " & _
              "Ins_16_25 = '" & Is16_25.Text & "', " & _
              "Ins_26_Mas = '" & Is26_Mas.Text & "', " & _
              "Alcantarrillado = '" & Alcanta.Text & "', " & _
              "Auto_Adic = '" & txtAutoabastecimiento.Text & "', " & _
              "Do_Descuento = '" & Val(txtDescuento.Text) & "', " & _
              "Iva = '" & Iva.Text & "', " & _
              "It = '" & It.Text & "', " & _
              "Reposicion = '" & RepForm.Text & "', " & _
              "Formulario = '" & Formula.Text & "', " & _
              "Vencimiento = '" & Format(fVence.Value, "dd/MM/yyyy") & "', " & _
              "Ley1886 = '" & Ley1886.Text & "' " & _
              "WHERE Emision = '" & fEmision.Value & "'"
            cmd.CommandText = ctex
            cmd.ExecuteNonQuery()
        Else
            ctex = "UPDATE Factores Set Estado = 0 Where Estado = 1"
            cmd.CommandText = ctex
            cmd.ExecuteNonQuery()

            ctex = "Insert into Factores (Emision, " & _
                "Do_00_06, Do_07_15, Do_16_25, Do_26_35, Do_36_Mas, " & _
                "Co_00_15, Co_16_25, Co_26_Mas, " & _
                "In_00_15, In_16_25, In_26_Mas, " & _
                "Ins_00_15, Ins_16_25, Ins_26_Mas, " & _
                "Alcantarrillado, Iva, It, Reposicion, Formulario, Estado, Vencimiento, Ley1886, Proceso, Auto_Adic, Do_Descuento) Values (" & _
                    "'" & Format(fEmision.Value, "dd/MM/yyyy") & "'," & _
                    "'" & Do00_06.Text & "'," & _
                    "'" & Do07_15.Text & "'," & _
                    "'" & Do16_25.Text & "'," & _
                    "'" & Do26_35.Text & "'," & _
                    "'" & Do36_Mas.Text & "'," & _
                    "'" & Co00_15.Text & "'," & _
                    "'" & Co16_25.Text & "'," & _
                    "'" & Co26_Mas.Text & "'," & _
                    "'" & In00_15.Text & "'," & _
                    "'" & In16_25.Text & "'," & _
                    "'" & In26_Mas.Text & "'," & _
                    "'" & Is00_15.Text & "'," & _
                    "'" & Is16_25.Text & "'," & _
                    "'" & Is26_Mas.Text & "'," & _
                    "'" & Alcanta.Text & "'," & _
                    "'" & Iva.Text & "'," & _
                    "'" & It.Text & "'," & _
                    "'" & RepForm.Text & "'," & _
                    "'" & Formula.Text & "',1," & _
                    "'" & Format(fVence.Value, "dd/MM/yyyy") & "'," & _
                    "'" & Ley1886.Text & "','0','" & txtAutoabastecimiento.Text & "','" & Val(txtDescuento.Text) & "')"
            cmd.CommandText = ctex
            cmd.ExecuteNonQuery()
        End If
        db.Close()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Frm_Factores_Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        da.SelectCommand.CommandText = "Select * From Factores Where Emision = '" & Format(dEmision, "dd/MM/yyyy") & "'"
        da.Fill(ds, "Emi")
        If ds.Tables("Emi").Rows.Count > 0 Then
            Do00_06.Text = ds.Tables("Emi").Rows(0).Item("Do_00_06")
            Do07_15.Text = ds.Tables("Emi").Rows(0).Item("Do_07_15")
            Do16_25.Text = ds.Tables("Emi").Rows(0).Item("Do_16_25")
            Do26_35.Text = ds.Tables("Emi").Rows(0).Item("Do_26_35")
            Do36_Mas.Text = ds.Tables("Emi").Rows(0).Item("Do_36_Mas")
            In00_15.Text = ds.Tables("Emi").Rows(0).Item("In_00_15")
            In16_25.Text = ds.Tables("Emi").Rows(0).Item("In_16_25")
            In26_Mas.Text = ds.Tables("Emi").Rows(0).Item("In_26_Mas")
            Co00_15.Text = ds.Tables("Emi").Rows(0).Item("Co_00_15")
            Co16_25.Text = ds.Tables("Emi").Rows(0).Item("Co_16_25")
            Co26_Mas.Text = ds.Tables("Emi").Rows(0).Item("Co_26_Mas")
            Is00_15.Text = ds.Tables("Emi").Rows(0).Item("In_00_15")
            Is16_25.Text = ds.Tables("Emi").Rows(0).Item("In_16_25")
            Is26_Mas.Text = ds.Tables("Emi").Rows(0).Item("In_26_Mas")
            Alcanta.Text = ds.Tables("Emi").Rows(0).Item("Alcantarrillado")
            Iva.Text = ds.Tables("Emi").Rows(0).Item("Iva")
            It.Text = ds.Tables("Emi").Rows(0).Item("It")
            RepForm.Text = ds.Tables("Emi").Rows(0).Item("Reposicion")
            Formula.Text = ds.Tables("Emi").Rows(0).Item("Formulario")
            fVence.Value = ds.Tables("Emi").Rows(0).Item("Vencimiento")
            Ley1886.Text = ds.Tables("Emi").Rows(0).Item("Ley1886")
            fEmision.Value = ds.Tables("Emi").Rows(0).Item("Emision")
            fEmision.MaxDate = ds.Tables("Emi").Rows(0).Item("Emision")
            fEmision.MinDate = ds.Tables("Emi").Rows(0).Item("Emision")
            txtAutoabastecimiento.Text = ds.Tables("Emi").Rows(0).Item("Auto_Adic")
            txtDescuento.Text = ds.Tables("Emi").Rows(0).Item("Do_Descuento")
            Edi = True
        Else
            da.SelectCommand.CommandText = "SELECT TOP 1 * FROM FACTORES ORDER BY EMISION DESC"
            da.Fill(ds, "Emi")
            If ds.Tables("Emi").Rows.Count > 0 Then
                Do00_06.Text = ds.Tables("Emi").Rows(0).Item("do_00_06")
                Do07_15.Text = ds.Tables("Emi").Rows(0).Item("do_07_15")
                Do16_25.Text = ds.Tables("Emi").Rows(0).Item("Do_16_25")
                Do26_35.Text = ds.Tables("Emi").Rows(0).Item("Do_26_35")
                Do36_Mas.Text = ds.Tables("Emi").Rows(0).Item("Do_36_Mas")
                In00_15.Text = ds.Tables("Emi").Rows(0).Item("In_00_15")
                In16_25.Text = ds.Tables("Emi").Rows(0).Item("In_16_25")
                In26_Mas.Text = ds.Tables("Emi").Rows(0).Item("In_26_Mas")
                Co00_15.Text = ds.Tables("Emi").Rows(0).Item("Co_00_15")
                Co16_25.Text = ds.Tables("Emi").Rows(0).Item("Co_16_25")
                Co26_Mas.Text = ds.Tables("Emi").Rows(0).Item("Co_26_Mas")
                Is00_15.Text = ds.Tables("Emi").Rows(0).Item("In_00_15")
                Is16_25.Text = ds.Tables("Emi").Rows(0).Item("In_16_25")
                Is26_Mas.Text = ds.Tables("Emi").Rows(0).Item("In_26_Mas")
                Alcanta.Text = ds.Tables("Emi").Rows(0).Item("Alcantarrillado")
                Iva.Text = ds.Tables("Emi").Rows(0).Item("Iva")
                It.Text = ds.Tables("Emi").Rows(0).Item("It")
                RepForm.Text = ds.Tables("Emi").Rows(0).Item("Reposicion")
                Formula.Text = ds.Tables("Emi").Rows(0).Item("Formulario")
                fVence.Value = ds.Tables("Emi").Rows(0).Item("Vencimiento")
                Ley1886.Text = ds.Tables("Emi").Rows(0).Item("Ley1886")
                txtAutoabastecimiento.Text = ds.Tables("Emi").Rows(0).Item("Auto_Adic")
                txtDescuento.Text = ds.Tables("Emi").Rows(0).Item("Do_Descuento")
                fEmision.Value = dEmision
                fEmision.MinDate = dEmision
                fVence.MinDate = dEmision
            End If
        End If
        ds.Tables("Emi").Clear()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class