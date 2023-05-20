<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.DosificaciónDeFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MigrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.MaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PuntosCobranzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CáculosDeFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProcesoDeOrdenesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContabilizarLaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.RecalculoDeFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MigrarFacturasLibrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.VerificarFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripSeparator()
        Me.AnularFacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajeroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeCorteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentasXCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescuentosLey1886ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.VentaDelServicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibrosDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProformasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsDeudas = New System.Windows.Forms.ToolStripButton()
        Me.tsHistorico = New System.Windows.Forms.ToolStripButton()
        Me.tsServicios = New System.Windows.Forms.ToolStripButton()
        Me.tsOtrasVentas = New System.Windows.Forms.ToolStripButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ToolsMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(624, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(81, 20)
        Me.FileMenu.Text = "&Facturación"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NewToolStripMenuItem.Text = "&Deudas"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Image = CType(resources.GetObject("ToolStripMenuItem8.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem8.Text = "Historico"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem9.Text = "Servicios"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(152, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ExitToolStripMenuItem.Text = "&Salir"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator6, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.ToolStripMenuItem6, Me.DosificaciónDeFacturasToolStripMenuItem, Me.MigrarToolStripMenuItem, Me.ToolStripMenuItem10, Me.MaterialToolStripMenuItem, Me.PuntosCobranzasToolStripMenuItem, Me.ServiciosToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(67, 20)
        Me.EditMenu.Text = "&Registros"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(217, 22)
        Me.ToolStripMenuItem7.Text = "Clientes"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.UndoToolStripMenuItem.Text = "&Usuarios"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.RedoToolStripMenuItem.Text = "&Afiliación Ley 1886"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(214, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CutToolStripMenuItem.Text = "Proformas"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.CopyToolStripMenuItem.Text = "&Factores de Calculo"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(214, 6)
        '
        'DosificaciónDeFacturasToolStripMenuItem
        '
        Me.DosificaciónDeFacturasToolStripMenuItem.Name = "DosificaciónDeFacturasToolStripMenuItem"
        Me.DosificaciónDeFacturasToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.DosificaciónDeFacturasToolStripMenuItem.Text = "Dosificación de Facturas"
        '
        'MigrarToolStripMenuItem
        '
        Me.MigrarToolStripMenuItem.Name = "MigrarToolStripMenuItem"
        Me.MigrarToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.MigrarToolStripMenuItem.Text = "Migrar"
        Me.MigrarToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(214, 6)
        '
        'MaterialToolStripMenuItem
        '
        Me.MaterialToolStripMenuItem.Name = "MaterialToolStripMenuItem"
        Me.MaterialToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.MaterialToolStripMenuItem.Text = "Material"
        '
        'PuntosCobranzasToolStripMenuItem
        '
        Me.PuntosCobranzasToolStripMenuItem.Name = "PuntosCobranzasToolStripMenuItem"
        Me.PuntosCobranzasToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.PuntosCobranzasToolStripMenuItem.Text = "Puntos Cobranzas"
        Me.PuntosCobranzasToolStripMenuItem.Visible = False
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ServiciosToolStripMenuItem.Text = "Servicios Lista"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem, Me.ToolStripMenuItem2, Me.CáculosDeFacturasToolStripMenuItem, Me.ToolStripMenuItem3, Me.ProcesoDeOrdenesToolStripMenuItem, Me.ContabilizarLaVentaToolStripMenuItem, Me.ToolStripMenuItem11, Me.RecalculoDeFacturasToolStripMenuItem, Me.MigrarFacturasLibrosToolStripMenuItem, Me.ToolStripMenuItem12, Me.VerificarFacturasToolStripMenuItem, Me.ToolStripMenuItem13, Me.AnularFacturasToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(66, 20)
        Me.ViewMenu.Text = "&Procesos"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ToolBarToolStripMenuItem.Text = "Transcripcion de Lecturas"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.StatusBarToolStripMenuItem.Text = "Verificación de Lecturas"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(206, 6)
        '
        'CáculosDeFacturasToolStripMenuItem
        '
        Me.CáculosDeFacturasToolStripMenuItem.Name = "CáculosDeFacturasToolStripMenuItem"
        Me.CáculosDeFacturasToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.CáculosDeFacturasToolStripMenuItem.Text = "Cáculos de Facturas"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(206, 6)
        '
        'ProcesoDeOrdenesToolStripMenuItem
        '
        Me.ProcesoDeOrdenesToolStripMenuItem.Name = "ProcesoDeOrdenesToolStripMenuItem"
        Me.ProcesoDeOrdenesToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ProcesoDeOrdenesToolStripMenuItem.Text = "Proceso de Ordenes"
        '
        'ContabilizarLaVentaToolStripMenuItem
        '
        Me.ContabilizarLaVentaToolStripMenuItem.Name = "ContabilizarLaVentaToolStripMenuItem"
        Me.ContabilizarLaVentaToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ContabilizarLaVentaToolStripMenuItem.Text = "Contabilizar la Venta"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(206, 6)
        '
        'RecalculoDeFacturasToolStripMenuItem
        '
        Me.RecalculoDeFacturasToolStripMenuItem.Name = "RecalculoDeFacturasToolStripMenuItem"
        Me.RecalculoDeFacturasToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.RecalculoDeFacturasToolStripMenuItem.Text = "Recalculo de Facturas"
        '
        'MigrarFacturasLibrosToolStripMenuItem
        '
        Me.MigrarFacturasLibrosToolStripMenuItem.Name = "MigrarFacturasLibrosToolStripMenuItem"
        Me.MigrarFacturasLibrosToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.MigrarFacturasLibrosToolStripMenuItem.Text = "Migrar Facturas - Libros"
        Me.MigrarFacturasLibrosToolStripMenuItem.Visible = False
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(206, 6)
        '
        'VerificarFacturasToolStripMenuItem
        '
        Me.VerificarFacturasToolStripMenuItem.Name = "VerificarFacturasToolStripMenuItem"
        Me.VerificarFacturasToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.VerificarFacturasToolStripMenuItem.Text = "Verificar Facturas"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(206, 6)
        '
        'AnularFacturasToolStripMenuItem
        '
        Me.AnularFacturasToolStripMenuItem.Name = "AnularFacturasToolStripMenuItem"
        Me.AnularFacturasToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.AnularFacturasToolStripMenuItem.Text = "Anular Facturas"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.OptionsToolStripMenuItem, Me.ListaDeCorteToolStripMenuItem, Me.CuentasXCobrarToolStripMenuItem, Me.DescuentosLey1886ToolStripMenuItem, Me.ToolStripMenuItem4, Me.VentaDelServicioToolStripMenuItem, Me.LibrosDeVentasToolStripMenuItem, Me.ToolStripMenuItem5, Me.ProformasToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(65, 20)
        Me.ToolsMenu.Text = "Re&portes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CajeroToolStripMenuItem, Me.ToolStripSeparator1, Me.GeneralToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem1.Text = "Cobros Diarios"
        '
        'CajeroToolStripMenuItem
        '
        Me.CajeroToolStripMenuItem.Name = "CajeroToolStripMenuItem"
        Me.CajeroToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.CajeroToolStripMenuItem.Text = "Cajero"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(129, 6)
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.GeneralToolStripMenuItem.Text = "Por Puntos"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.OptionsToolStripMenuItem.Text = "Libretas Lecturacion"
        '
        'ListaDeCorteToolStripMenuItem
        '
        Me.ListaDeCorteToolStripMenuItem.Name = "ListaDeCorteToolStripMenuItem"
        Me.ListaDeCorteToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ListaDeCorteToolStripMenuItem.Text = "Lista de corte"
        '
        'CuentasXCobrarToolStripMenuItem
        '
        Me.CuentasXCobrarToolStripMenuItem.Name = "CuentasXCobrarToolStripMenuItem"
        Me.CuentasXCobrarToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.CuentasXCobrarToolStripMenuItem.Text = "Cuentas x Cobrar"
        '
        'DescuentosLey1886ToolStripMenuItem
        '
        Me.DescuentosLey1886ToolStripMenuItem.Name = "DescuentosLey1886ToolStripMenuItem"
        Me.DescuentosLey1886ToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DescuentosLey1886ToolStripMenuItem.Text = "Descuentos Ley 1886"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 6)
        '
        'VentaDelServicioToolStripMenuItem
        '
        Me.VentaDelServicioToolStripMenuItem.Name = "VentaDelServicioToolStripMenuItem"
        Me.VentaDelServicioToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.VentaDelServicioToolStripMenuItem.Text = "Venta del Servicio"
        '
        'LibrosDeVentasToolStripMenuItem
        '
        Me.LibrosDeVentasToolStripMenuItem.Name = "LibrosDeVentasToolStripMenuItem"
        Me.LibrosDeVentasToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LibrosDeVentasToolStripMenuItem.Text = "Libros de Ventas IVA"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(180, 6)
        '
        'ProformasToolStripMenuItem
        '
        Me.ProformasToolStripMenuItem.Name = "ProformasToolStripMenuItem"
        Me.ProformasToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ProformasToolStripMenuItem.Text = "Proformas"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.lblFecha, Me.ToolStripStatusLabel1, Me.lblUsuario})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 427)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(624, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(41, 17)
        Me.ToolStripStatusLabel.Text = "Fecha:"
        '
        'lblFecha
        '
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(70, 17)
        Me.lblFecha.Text = "....................."
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel1.Text = "Usuario:"
        '
        'lblUsuario
        '
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(121, 17)
        Me.lblUsuario.Text = "ToolStripStatusLabel2"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDeudas, Me.tsHistorico, Me.tsServicios, Me.tsOtrasVentas})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(624, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsDeudas
        '
        Me.tsDeudas.Image = CType(resources.GetObject("tsDeudas.Image"), System.Drawing.Image)
        Me.tsDeudas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDeudas.Name = "tsDeudas"
        Me.tsDeudas.Size = New System.Drawing.Size(66, 22)
        Me.tsDeudas.Text = "Deudas"
        '
        'tsHistorico
        '
        Me.tsHistorico.Image = CType(resources.GetObject("tsHistorico.Image"), System.Drawing.Image)
        Me.tsHistorico.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsHistorico.Name = "tsHistorico"
        Me.tsHistorico.Size = New System.Drawing.Size(75, 22)
        Me.tsHistorico.Text = "Historico"
        '
        'tsServicios
        '
        Me.tsServicios.Image = CType(resources.GetObject("tsServicios.Image"), System.Drawing.Image)
        Me.tsServicios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsServicios.Name = "tsServicios"
        Me.tsServicios.Size = New System.Drawing.Size(73, 22)
        Me.tsServicios.Text = "Servicios"
        '
        'tsOtrasVentas
        '
        Me.tsOtrasVentas.Image = CType(resources.GetObject("tsOtrasVentas.Image"), System.Drawing.Image)
        Me.tsOtrasVentas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsOtrasVentas.Name = "tsOtrasVentas"
        Me.tsOtrasVentas.Size = New System.Drawing.Size(93, 22)
        Me.tsOtrasVentas.Text = "Otras Ventas"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Money_Calculator.ico")
        Me.ImageList1.Images.SetKeyName(1, "Credit_Card.ico")
        Me.ImageList1.Images.SetKeyName(2, "payment.ico")
        Me.ImageList1.Images.SetKeyName(3, "Bank Check.ico")
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 449)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Frm_Principal"
        Me.Opacity = 0.0R
        Me.Text = "Facturación EMPSAAT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CáculosDeFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProcesoDeOrdenesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeCorteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasXCobrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescuentosLey1886ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VentaDelServicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LibrosDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProformasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DosificaciónDeFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContabilizarLaVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MigrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblFecha As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RecalculoDeFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsDeudas As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsHistorico As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsServicios As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MaterialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsOtrasVentas As System.Windows.Forms.ToolStripButton
    Friend WithEvents MigrarFacturasLibrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VerificarFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AnularFacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PuntosCobranzasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajeroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneralToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ServiciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
