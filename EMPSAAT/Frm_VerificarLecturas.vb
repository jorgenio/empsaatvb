Public Class Frm_VerificaLecturas

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frep As New Frm_Reportes
        'Dim rLib As New Rep_VerificarLecturas
        'frep.crvRep.ReportSource = rLib
        frep.ShowDialog()
    End Sub

    Private Sub Frm_VerificaLecturas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class