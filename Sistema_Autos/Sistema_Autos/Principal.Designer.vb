<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mns_principal = New System.Windows.Forms.MenuStrip
        Me.AdministradorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IniciarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TipoCambioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.CerrarSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignarPermisosPersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LineaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MarcaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnidadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ActualizarPreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VehiculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MonedaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SucursalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AlmacénToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrecioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConceptosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TipoDeDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenDeCompraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotaDeCréditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotaDeDébitoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrdenDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotaDeCréditoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotaDeDébitoClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResumenDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CuentasPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CuentasPorPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CanjeDeLetrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InventariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IngresoAlKardexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovimientoDeKardexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistroDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalcToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GastosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mns_principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'mns_principal
        '
        Me.mns_principal.BackColor = System.Drawing.SystemColors.Control
        Me.mns_principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministradorToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.ComprasToolStripMenuItem, Me.VentasToolStripMenuItem, Me.CajaToolStripMenuItem, Me.InventariosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.mns_principal.Location = New System.Drawing.Point(0, 0)
        Me.mns_principal.Name = "mns_principal"
        Me.mns_principal.Size = New System.Drawing.Size(903, 24)
        Me.mns_principal.TabIndex = 0
        Me.mns_principal.Text = "Menu_Principal"
        '
        'AdministradorToolStripMenuItem
        '
        Me.AdministradorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IniciarSesionToolStripMenuItem, Me.TipoCambioToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.CerrarSesionToolStripMenuItem, Me.ToolStripSeparator1, Me.CerrarSistemaToolStripMenuItem})
        Me.AdministradorToolStripMenuItem.Name = "AdministradorToolStripMenuItem"
        Me.AdministradorToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.AdministradorToolStripMenuItem.Text = "Administrador"
        '
        'IniciarSesionToolStripMenuItem
        '
        Me.IniciarSesionToolStripMenuItem.Name = "IniciarSesionToolStripMenuItem"
        Me.IniciarSesionToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.IniciarSesionToolStripMenuItem.Text = "Iniciar Sesión"
        '
        'TipoCambioToolStripMenuItem
        '
        Me.TipoCambioToolStripMenuItem.Name = "TipoCambioToolStripMenuItem"
        Me.TipoCambioToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.TipoCambioToolStripMenuItem.Text = "Tipo de Cambio"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(156, 6)
        '
        'CerrarSistemaToolStripMenuItem
        '
        Me.CerrarSistemaToolStripMenuItem.Name = "CerrarSistemaToolStripMenuItem"
        Me.CerrarSistemaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CerrarSistemaToolStripMenuItem.Text = "Cerrar Sistema"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalToolStripMenuItem, Me.AsignarPermisosPersonalToolStripMenuItem, Me.ToolStripSeparator2, Me.ClienteToolStripMenuItem, Me.LineaToolStripMenuItem, Me.MarcaToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.ProveedorToolStripMenuItem, Me.UnidadToolStripMenuItem1, Me.ActualizarPreciosToolStripMenuItem, Me.VehiculoToolStripMenuItem, Me.MonedaToolStripMenuItem, Me.SucursalToolStripMenuItem, Me.AlmacénToolStripMenuItem, Me.PrecioToolStripMenuItem, Me.ConceptosToolStripMenuItem, Me.TipoDeDocumentoToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'AsignarPermisosPersonalToolStripMenuItem
        '
        Me.AsignarPermisosPersonalToolStripMenuItem.Name = "AsignarPermisosPersonalToolStripMenuItem"
        Me.AsignarPermisosPersonalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AsignarPermisosPersonalToolStripMenuItem.Text = "Asignar Permisos"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClienteToolStripMenuItem.Text = "Clientes"
        '
        'LineaToolStripMenuItem
        '
        Me.LineaToolStripMenuItem.Name = "LineaToolStripMenuItem"
        Me.LineaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LineaToolStripMenuItem.Text = "Línea"
        '
        'MarcaToolStripMenuItem
        '
        Me.MarcaToolStripMenuItem.Name = "MarcaToolStripMenuItem"
        Me.MarcaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarcaToolStripMenuItem.Text = "Marca"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'ProveedorToolStripMenuItem
        '
        Me.ProveedorToolStripMenuItem.Name = "ProveedorToolStripMenuItem"
        Me.ProveedorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProveedorToolStripMenuItem.Text = "Proveedor"
        '
        'UnidadToolStripMenuItem1
        '
        Me.UnidadToolStripMenuItem1.Name = "UnidadToolStripMenuItem1"
        Me.UnidadToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.UnidadToolStripMenuItem1.Text = "Unidad"
        '
        'ActualizarPreciosToolStripMenuItem
        '
        Me.ActualizarPreciosToolStripMenuItem.Name = "ActualizarPreciosToolStripMenuItem"
        Me.ActualizarPreciosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ActualizarPreciosToolStripMenuItem.Text = "Actualizar Precios"
        '
        'VehiculoToolStripMenuItem
        '
        Me.VehiculoToolStripMenuItem.Name = "VehiculoToolStripMenuItem"
        Me.VehiculoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VehiculoToolStripMenuItem.Text = "Vehículo"
        '
        'MonedaToolStripMenuItem
        '
        Me.MonedaToolStripMenuItem.Name = "MonedaToolStripMenuItem"
        Me.MonedaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MonedaToolStripMenuItem.Text = "Moneda"
        '
        'SucursalToolStripMenuItem
        '
        Me.SucursalToolStripMenuItem.Name = "SucursalToolStripMenuItem"
        Me.SucursalToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SucursalToolStripMenuItem.Text = "Sucursal"
        '
        'AlmacénToolStripMenuItem
        '
        Me.AlmacénToolStripMenuItem.Name = "AlmacénToolStripMenuItem"
        Me.AlmacénToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AlmacénToolStripMenuItem.Text = "Almacén"
        '
        'PrecioToolStripMenuItem
        '
        Me.PrecioToolStripMenuItem.Name = "PrecioToolStripMenuItem"
        Me.PrecioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrecioToolStripMenuItem.Text = "Precio"
        '
        'ConceptosToolStripMenuItem
        '
        Me.ConceptosToolStripMenuItem.Name = "ConceptosToolStripMenuItem"
        Me.ConceptosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConceptosToolStripMenuItem.Text = "Conceptos"
        '
        'TipoDeDocumentoToolStripMenuItem
        '
        Me.TipoDeDocumentoToolStripMenuItem.Name = "TipoDeDocumentoToolStripMenuItem"
        Me.TipoDeDocumentoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TipoDeDocumentoToolStripMenuItem.Text = "Tipo de Documento"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenDeCompraToolStripMenuItem, Me.NotaDeCréditoToolStripMenuItem, Me.NotaDeDébitoToolStripMenuItem})
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ComprasToolStripMenuItem.Text = "Compras"
        '
        'OrdenDeCompraToolStripMenuItem
        '
        Me.OrdenDeCompraToolStripMenuItem.Name = "OrdenDeCompraToolStripMenuItem"
        Me.OrdenDeCompraToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.OrdenDeCompraToolStripMenuItem.Text = "Orden de Compra"
        '
        'NotaDeCréditoToolStripMenuItem
        '
        Me.NotaDeCréditoToolStripMenuItem.Name = "NotaDeCréditoToolStripMenuItem"
        Me.NotaDeCréditoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.NotaDeCréditoToolStripMenuItem.Text = "Nota de Crédito Proveedor"
        '
        'NotaDeDébitoToolStripMenuItem
        '
        Me.NotaDeDébitoToolStripMenuItem.Name = "NotaDeDébitoToolStripMenuItem"
        Me.NotaDeDébitoToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.NotaDeDébitoToolStripMenuItem.Text = "Nota de Débito Proveedor"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrdenDeVentaToolStripMenuItem, Me.FacturaciónToolStripMenuItem, Me.NotaDeCréditoClienteToolStripMenuItem, Me.NotaDeDébitoClienteToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'OrdenDeVentaToolStripMenuItem
        '
        Me.OrdenDeVentaToolStripMenuItem.Name = "OrdenDeVentaToolStripMenuItem"
        Me.OrdenDeVentaToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.OrdenDeVentaToolStripMenuItem.Text = "Orden de Venta"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.FacturaciónToolStripMenuItem.Text = "Facturación"
        '
        'NotaDeCréditoClienteToolStripMenuItem
        '
        Me.NotaDeCréditoClienteToolStripMenuItem.Name = "NotaDeCréditoClienteToolStripMenuItem"
        Me.NotaDeCréditoClienteToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.NotaDeCréditoClienteToolStripMenuItem.Text = "Nota de Crédito Cliente"
        '
        'NotaDeDébitoClienteToolStripMenuItem
        '
        Me.NotaDeDébitoClienteToolStripMenuItem.Name = "NotaDeDébitoClienteToolStripMenuItem"
        Me.NotaDeDébitoClienteToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.NotaDeDébitoClienteToolStripMenuItem.Text = "Nota de Débito Cliente"
        '
        'CajaToolStripMenuItem
        '
        Me.CajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResumenDeCajaToolStripMenuItem, Me.CuentasPorCobrarToolStripMenuItem, Me.CuentasPorPagarToolStripMenuItem, Me.CanjeDeLetrasToolStripMenuItem, Me.GastosToolStripMenuItem})
        Me.CajaToolStripMenuItem.Name = "CajaToolStripMenuItem"
        Me.CajaToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.CajaToolStripMenuItem.Text = "Caja"
        '
        'ResumenDeCajaToolStripMenuItem
        '
        Me.ResumenDeCajaToolStripMenuItem.Name = "ResumenDeCajaToolStripMenuItem"
        Me.ResumenDeCajaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ResumenDeCajaToolStripMenuItem.Text = "Resumen de Caja"
        '
        'CuentasPorCobrarToolStripMenuItem
        '
        Me.CuentasPorCobrarToolStripMenuItem.Name = "CuentasPorCobrarToolStripMenuItem"
        Me.CuentasPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CuentasPorCobrarToolStripMenuItem.Text = "Cuentas por Cobrar"
        '
        'CuentasPorPagarToolStripMenuItem
        '
        Me.CuentasPorPagarToolStripMenuItem.Name = "CuentasPorPagarToolStripMenuItem"
        Me.CuentasPorPagarToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CuentasPorPagarToolStripMenuItem.Text = "Cuentas por Pagar"
        '
        'CanjeDeLetrasToolStripMenuItem
        '
        Me.CanjeDeLetrasToolStripMenuItem.Name = "CanjeDeLetrasToolStripMenuItem"
        Me.CanjeDeLetrasToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CanjeDeLetrasToolStripMenuItem.Text = "Canje de Letras"
        '
        'InventariosToolStripMenuItem
        '
        Me.InventariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoAlKardexToolStripMenuItem, Me.MovimientoDeKardexToolStripMenuItem, Me.StockToolStripMenuItem})
        Me.InventariosToolStripMenuItem.Name = "InventariosToolStripMenuItem"
        Me.InventariosToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.InventariosToolStripMenuItem.Text = "Inventarios"
        '
        'IngresoAlKardexToolStripMenuItem
        '
        Me.IngresoAlKardexToolStripMenuItem.Name = "IngresoAlKardexToolStripMenuItem"
        Me.IngresoAlKardexToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.IngresoAlKardexToolStripMenuItem.Text = "Ingreso al Kardex"
        '
        'MovimientoDeKardexToolStripMenuItem
        '
        Me.MovimientoDeKardexToolStripMenuItem.Name = "MovimientoDeKardexToolStripMenuItem"
        Me.MovimientoDeKardexToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.MovimientoDeKardexToolStripMenuItem.Text = "Movimiento de Kardex"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeVentasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'RegistroDeVentasToolStripMenuItem
        '
        Me.RegistroDeVentasToolStripMenuItem.Name = "RegistroDeVentasToolStripMenuItem"
        Me.RegistroDeVentasToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.RegistroDeVentasToolStripMenuItem.Text = "Registro de Ventas"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalcToolStripMenuItem, Me.ExcelToolStripMenuItem, Me.WordToolStripMenuItem})
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'CalcToolStripMenuItem
        '
        Me.CalcToolStripMenuItem.Name = "CalcToolStripMenuItem"
        Me.CalcToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CalcToolStripMenuItem.Text = "Calc"
        '
        'ExcelToolStripMenuItem
        '
        Me.ExcelToolStripMenuItem.Name = "ExcelToolStripMenuItem"
        Me.ExcelToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExcelToolStripMenuItem.Text = "Excel"
        '
        'WordToolStripMenuItem
        '
        Me.WordToolStripMenuItem.Name = "WordToolStripMenuItem"
        Me.WordToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.WordToolStripMenuItem.Text = "Word"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'GastosToolStripMenuItem
        '
        Me.GastosToolStripMenuItem.Name = "GastosToolStripMenuItem"
        Me.GastosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.GastosToolStripMenuItem.Text = "Gastos"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(903, 461)
        Me.Controls.Add(Me.mns_principal)
        Me.MainMenuStrip = Me.mns_principal
        Me.Name = "frmPrincipal"
        Me.Tag = "SISTEMA DE VENTAS DE REPUESTOS DE AUTOS"
        Me.Text = "SISTEMA DE VENTAS DE REPUESTOS DE AUTOS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mns_principal.ResumeLayout(False)
        Me.mns_principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mns_principal As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministradorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LineaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarcaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenDeCompraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrdenDeVentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoAlKardexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResumenDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnidadToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActualizarPreciosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VehiculoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonedaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SucursalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlmacénToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrecioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConceptosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IniciarSesionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoDeDocumentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaDeCréditoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaDeDébitoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaDeCréditoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotaDeDébitoClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasPorCobrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasPorPagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CanjeDeLetrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoCambioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarPermisosPersonalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MovimientoDeKardexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalcToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GastosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
