Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class Frm_Principal

    Private Sub MenuFacturacion(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click, tsDeudas.Click
        Dim fBus As New Frm_Busquedas
        If fBus.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fDeu As New Frm_Deudas
            fDeu.ShowDialog()
        End If
    End Sub


    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Dim frmfactor As New Frm_Factores
        frmfactor.MdiParent = Me
        frmfactor.Show()
    End Sub

    Private Sub Frm_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim fLog As New Frm_Login
        If Frm_Login.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Obtener_Dosificacion()
            Obtener_Comprobante()
            lblFecha.Text = FormatDateTime(Date.Now, DateFormat.ShortDate)
            lblUsuario.Text = _Usuario
            Me.Opacity = 100%
        Else
            End
        End If
    End Sub

    Private Sub Obtener_Dosificacion()
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select * From Dosificacion Where Activado = 1"
        da.Fill(ds, "Dos")
        If ds.Tables("Dos").Rows.Count > 0 Then
            pNum_Autorizacion = ds.Tables("Dos").Rows(0).Item("Autorizacion")
            pFecha_Dosis_Inicial = ds.Tables("Dos").Rows(0).Item("Fec_Inicial")
            pFecha_Dosis_Final = ds.Tables("Dos").Rows(0).Item("Fec_Final")
            pLlave = ds.Tables("Dos").Rows(0).Item("Llave")
            If Date.Now > pFecha_Dosis_Final Then
                pTieneDosis = False
                MessageBox.Show("No tiene dosificación para nuevas facturas", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Else
                pTieneDosis = True
            End If
        End If
        ds.Tables("Dos").Clear()
    End Sub

    Private Sub Obtener_Comprobante()
        Dim db As New SqlConnection(cn)
        Dim da As New SqlDataAdapter("", db)
        Dim ds As New DataSet
        da.SelectCommand.CommandText = "Select * From Comprobantes Where Fecha = '" & FormatDateTime(Date.Now, DateFormat.ShortDate) & "'"
        da.Fill(ds, "Cbte")
        If ds.Tables("Cbte").Rows.Count > 0 Then
            pNum_Comprobante = ds.Tables("Cbte").Rows(0).Item("Comprobante")
            pFec_Pago = ds.Tables("Cbte").Rows(0).Item("Fecha")
        Else
            Dim fCrea As New Frm_Comprobantes
            fCrea.ShowDialog()
        End If
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolBarToolStripMenuItem.Click
        Dim fTras As New Frm_Transcripciones
        fTras.MdiParent = Me
        fTras.Show()
    End Sub

    Private Sub CáculosDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CáculosDeFacturasToolStripMenuItem.Click
        Dim fCal As New Frm_CalculoFacturas
        fCal.MdiParent = Me
        fCal.Show()
    End Sub


    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        Dim fBus As New Frm_Cliente_Busqueda
        If fBus.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fUsu As New Frm_Usuarios
            fUsu.MdiParent = Me
            fUsu.Show()
        End If
    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        Dim fAfi As New Frm_RegistroLey1886
        fAfi.MdiParent = Me
        fAfi.Show()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        Dim fPro As New Frm_Proformas
        fPro.MdiParent = Me
        fPro.Show()
    End Sub

    Private Sub ProcesoDeOrdenesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcesoDeOrdenesToolStripMenuItem.Click
        Dim fSer As New Frm_ProcesaOrdenes
        fSer.MdiParent = Me
        fSer.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Dim fLib As New Frm_Libretas_Lecturacion
        fLib.MdiParent = Me
        fLib.Show()
    End Sub

    Private Sub ListaDeCorteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListaDeCorteToolStripMenuItem.Click
        Dim fCorte As New Frm_Lista_Corte
        fCorte.MdiParent = Me
        fCorte.Show()
    End Sub

    Private Sub CuentasXCobrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasXCobrarToolStripMenuItem.Click
        Dim fCxC As New Frm_CuentasXcobrar
        fCxC.MdiParent = Me
        fCxC.Show()
    End Sub

    Private Sub DescuentosLey1886ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescuentosLey1886ToolStripMenuItem.Click
        Dim fLey1886 As New Frm_ReporteLey1886
        fLey1886.MdiParent = Me
        fLey1886.Show()
    End Sub

    Private Sub VentaDelServicioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaDelServicioToolStripMenuItem.Click
        Dim fVenta As New Frm_ReporteVenta
        fVenta.MdiParent = Me
        fVenta.Show()
    End Sub

    Private Sub LibrosDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibrosDeVentasToolStripMenuItem.Click
        Dim fLibIva As New Frm_ReporteLibrosIva
        fLibIva.MdiParent = Me
        fLibIva.Show()
    End Sub

    Private Sub ProformasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProformasToolStripMenuItem.Click
        Dim frepPro As New Frm_ProformasReporte
        frepPro.MdiParent = Me
        frepPro.Show()
    End Sub

    Private Sub DosificaciónDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosificaciónDeFacturasToolStripMenuItem.Click
        Dim fdos As New Frm_DosificacionFacturas
        fdos.MdiParent = Me
        fdos.Show()
    End Sub


    Private Sub ContabilizarLaVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContabilizarLaVentaToolStripMenuItem.Click

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusBarToolStripMenuItem.Click
        Dim fVeri As New Frm_VerificaLecturas
        fVeri.MdiParent = Me
        fVeri.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub MigrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MigrarToolStripMenuItem.Click
        Dim fMig As New Frm_Migrar
        fMig.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Dim fCli As New Frm_Cliente
        fCli.MdiParent = Me
        fCli.Show()
    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click, tsHistorico.Click
        Dim fBus As New Frm_Busquedas
        If fBus.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fDeu As New Frm_Historico
            fDeu.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click, tsServicios.Click
        Dim fBus As New Frm_Busquedas
        If fBus.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fDeu As New Frm_Servicios
            fDeu.ShowDialog()
        End If
    End Sub

    Private Sub RecalculoDeFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecalculoDeFacturasToolStripMenuItem.Click
        Dim fBus As New Frm_Busquedas
        If fBus.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fRec As New Frm_Recalculo_Facturas
            fRec.ShowDialog()
        End If
    End Sub

    Private Sub MaterialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaterialToolStripMenuItem.Click
        Dim fMat As New Frm_Material
        fMat.MdiParent = Me
        fMat.Show()
    End Sub

    Private Sub tsOtrasVentas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsOtrasVentas.Click
        Dim fOV As New Frm_Otras_Ventas
        fOV.ShowDialog()
    End Sub

    Private Sub MigrarFacturasLibrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MigrarFacturasLibrosToolStripMenuItem.Click
        Dim fMig As New Frm_Migrar_Libros
        fMig.ShowDialog()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim fUsu As New Frm_Ver_Usuarios
        fUsu.MdiParent = Me
        fUsu.Show()
    End Sub

    Private Sub VerificarFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerificarFacturasToolStripMenuItem.Click
        Dim fVer As New Frm_Verificar_Facturas
        fVer.ShowDialog()
    End Sub

    Private Sub AnularFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnularFacturasToolStripMenuItem.Click
        Dim fAnu As New Frm_Anular_Factura
        fAnu.ShowDialog()
    End Sub

    Private Sub PuntosCobranzasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuntosCobranzasToolStripMenuItem.Click
        Dim fPunto As New Frm_Punto
        fPunto.MdiParent = Me
        fPunto.Show()
    End Sub

    Private Sub CajeroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajeroToolStripMenuItem.Click
        Dim fdia As New Frm_RepDiarioDetalle
        fdia.MdiParent = Me
        fdia.Show()
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralToolStripMenuItem.Click
        Dim fRep As New Frm_RepDiario
        fRep.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ServiciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiciosToolStripMenuItem.Click
        Dim fSer As New Frm_Servicios_Lista
        fSer.MdiParent = Me
        fSer.Show()
    End Sub
End Class
