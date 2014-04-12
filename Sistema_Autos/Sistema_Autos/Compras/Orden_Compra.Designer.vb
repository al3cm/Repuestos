<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrden_Compra
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
        Me.lbIdentificador = New System.Windows.Forms.Label
        Me.lblOrden_Compra = New System.Windows.Forms.Label
        Me.gpbDatos = New System.Windows.Forms.GroupBox
        Me.Txtid_proveedor = New System.Windows.Forms.TextBox
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.chkigv = New System.Windows.Forms.CheckBox
        Me.cboTipoPago = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpfecha_emision = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboSucursal = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnFiltro_Proveedor = New System.Windows.Forms.Button
        Me.txtBuscar_proveedor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboUnidad = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtPrecio_Unitario = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.dtvListado_Productos = New System.Windows.Forms.DataGridView
        Me.ChId_Poducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chprecio_compra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chdescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtPrecio_bruto = New System.Windows.Forms.TextBox
        Me.txtMonto_descuento = New System.Windows.Forms.TextBox
        Me.txtPrecio_neto = New System.Windows.Forms.TextBox
        Me.txtigv = New System.Windows.Forms.TextBox
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.btnFiltro_Producto = New System.Windows.Forms.Button
        Me.TxtidProducto = New System.Windows.Forms.TextBox
        Me.LblProcetaje = New System.Windows.Forms.Label
        Me.Txtnumero_documento = New System.Windows.Forms.TextBox
        Me.Txtserie_documento = New System.Windows.Forms.TextBox
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnEliminarOrden = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.gpbDatos.SuspendLayout()
        CType(Me.dtvListado_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbIdentificador
        '
        Me.lbIdentificador.AutoSize = True
        Me.lbIdentificador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIdentificador.Location = New System.Drawing.Point(14, 97)
        Me.lbIdentificador.Name = "lbIdentificador"
        Me.lbIdentificador.Size = New System.Drawing.Size(271, 13)
        Me.lbIdentificador.TabIndex = 40
        Me.lbIdentificador.Text = " EMPRESA LALALLAAL - RUC: 104876565467"
        '
        'lblOrden_Compra
        '
        Me.lblOrden_Compra.AutoSize = True
        Me.lblOrden_Compra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrden_Compra.Location = New System.Drawing.Point(581, 99)
        Me.lblOrden_Compra.Name = "lblOrden_Compra"
        Me.lblOrden_Compra.Size = New System.Drawing.Size(128, 13)
        Me.lblOrden_Compra.TabIndex = 41
        Me.lblOrden_Compra.Text = "ORDEN DE COMPRA"
        '
        'gpbDatos
        '
        Me.gpbDatos.Controls.Add(Me.Txtid_proveedor)
        Me.gpbDatos.Controls.Add(Me.txtdescripcion)
        Me.gpbDatos.Controls.Add(Me.Label8)
        Me.gpbDatos.Controls.Add(Me.chkigv)
        Me.gpbDatos.Controls.Add(Me.cboTipoPago)
        Me.gpbDatos.Controls.Add(Me.Label7)
        Me.gpbDatos.Controls.Add(Me.dtpfecha_emision)
        Me.gpbDatos.Controls.Add(Me.Label6)
        Me.gpbDatos.Controls.Add(Me.cboMoneda)
        Me.gpbDatos.Controls.Add(Me.Label5)
        Me.gpbDatos.Controls.Add(Me.cboAlmacen)
        Me.gpbDatos.Controls.Add(Me.Label4)
        Me.gpbDatos.Controls.Add(Me.cboSucursal)
        Me.gpbDatos.Controls.Add(Me.Label3)
        Me.gpbDatos.Controls.Add(Me.TxtDireccion)
        Me.gpbDatos.Controls.Add(Me.Label2)
        Me.gpbDatos.Controls.Add(Me.btnFiltro_Proveedor)
        Me.gpbDatos.Controls.Add(Me.txtBuscar_proveedor)
        Me.gpbDatos.Controls.Add(Me.Label1)
        Me.gpbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbDatos.Location = New System.Drawing.Point(13, 151)
        Me.gpbDatos.Name = "gpbDatos"
        Me.gpbDatos.Size = New System.Drawing.Size(734, 134)
        Me.gpbDatos.TabIndex = 43
        Me.gpbDatos.TabStop = False
        Me.gpbDatos.Text = "Datos"
        '
        'Txtid_proveedor
        '
        Me.Txtid_proveedor.Location = New System.Drawing.Point(418, 74)
        Me.Txtid_proveedor.Name = "Txtid_proveedor"
        Me.Txtid_proveedor.Size = New System.Drawing.Size(35, 20)
        Me.Txtid_proveedor.TabIndex = 69
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(495, 53)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(228, 61)
        Me.txtdescripcion.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(415, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Descripción:"
        '
        'chkigv
        '
        Me.chkigv.AutoSize = True
        Me.chkigv.Checked = True
        Me.chkigv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkigv.Location = New System.Drawing.Point(302, 100)
        Me.chkigv.Name = "chkigv"
        Me.chkigv.Size = New System.Drawing.Size(92, 17)
        Me.chkigv.TabIndex = 15
        Me.chkigv.Text = "Incluye IGV"
        Me.chkigv.UseVisualStyleBackColor = True
        '
        'cboTipoPago
        '
        Me.cboTipoPago.FormattingEnabled = True
        Me.cboTipoPago.Location = New System.Drawing.Point(85, 95)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoPago.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Tipo Pago:"
        '
        'dtpfecha_emision
        '
        Me.dtpfecha_emision.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_emision.Location = New System.Drawing.Point(302, 71)
        Me.dtpfecha_emision.Name = "dtpfecha_emision"
        Me.dtpfecha_emision.Size = New System.Drawing.Size(92, 20)
        Me.dtpfecha_emision.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fec. Emisión:"
        '
        'cboMoneda
        '
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(85, 70)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(121, 21)
        Me.cboMoneda.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Moneda:"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(273, 45)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(121, 21)
        Me.cboAlmacen.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Almacen:"
        '
        'cboSucursal
        '
        Me.cboSucursal.FormattingEnabled = True
        Me.cboSucursal.Location = New System.Drawing.Point(85, 45)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Size = New System.Drawing.Size(121, 21)
        Me.cboSucursal.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sucursal:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(495, 19)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(228, 20)
        Me.TxtDireccion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dirección:"
        '
        'btnFiltro_Proveedor
        '
        Me.btnFiltro_Proveedor.Location = New System.Drawing.Point(399, 19)
        Me.btnFiltro_Proveedor.Name = "btnFiltro_Proveedor"
        Me.btnFiltro_Proveedor.Size = New System.Drawing.Size(23, 22)
        Me.btnFiltro_Proveedor.TabIndex = 2
        Me.btnFiltro_Proveedor.Text = "..."
        Me.btnFiltro_Proveedor.UseVisualStyleBackColor = True
        '
        'txtBuscar_proveedor
        '
        Me.txtBuscar_proveedor.Location = New System.Drawing.Point(85, 19)
        Me.txtBuscar_proveedor.Name = "txtBuscar_proveedor"
        Me.txtBuscar_proveedor.Size = New System.Drawing.Size(309, 20)
        Me.txtBuscar_proveedor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 307)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Producto:"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(30, 322)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(305, 20)
        Me.txtProducto.TabIndex = 45
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(375, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Unidad:"
        '
        'cboUnidad
        '
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Location = New System.Drawing.Point(370, 321)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(59, 21)
        Me.cboUnidad.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(445, 305)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(439, 321)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(71, 20)
        Me.txtCantidad.TabIndex = 49
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(517, 305)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Precio Unit:"
        '
        'txtPrecio_Unitario
        '
        Me.txtPrecio_Unitario.Location = New System.Drawing.Point(516, 321)
        Me.txtPrecio_Unitario.Name = "txtPrecio_Unitario"
        Me.txtPrecio_Unitario.Size = New System.Drawing.Size(79, 20)
        Me.txtPrecio_Unitario.TabIndex = 51
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(611, 305)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Descuento:"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(606, 321)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(79, 20)
        Me.txtDescuento.TabIndex = 53
        '
        'dtvListado_Productos
        '
        Me.dtvListado_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvListado_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChId_Poducto, Me.ChProducto, Me.ChCantidad, Me.ChUnidad, Me.Chprecio_compra, Me.Chdescuento, Me.ChTotal})
        Me.dtvListado_Productos.Location = New System.Drawing.Point(17, 358)
        Me.dtvListado_Productos.Name = "dtvListado_Productos"
        Me.dtvListado_Productos.Size = New System.Drawing.Size(678, 150)
        Me.dtvListado_Productos.TabIndex = 54
        '
        'ChId_Poducto
        '
        Me.ChId_Poducto.HeaderText = "Id_Poducto"
        Me.ChId_Poducto.Name = "ChId_Poducto"
        Me.ChId_Poducto.ReadOnly = True
        Me.ChId_Poducto.Visible = False
        '
        'ChProducto
        '
        Me.ChProducto.HeaderText = "Producto"
        Me.ChProducto.Name = "ChProducto"
        Me.ChProducto.ReadOnly = True
        '
        'ChCantidad
        '
        Me.ChCantidad.HeaderText = "Cantidad"
        Me.ChCantidad.Name = "ChCantidad"
        Me.ChCantidad.ReadOnly = True
        '
        'ChUnidad
        '
        Me.ChUnidad.HeaderText = "Unidad"
        Me.ChUnidad.Name = "ChUnidad"
        Me.ChUnidad.ReadOnly = True
        '
        'Chprecio_compra
        '
        Me.Chprecio_compra.HeaderText = "precio_compra"
        Me.Chprecio_compra.Name = "Chprecio_compra"
        Me.Chprecio_compra.ReadOnly = True
        '
        'Chdescuento
        '
        Me.Chdescuento.HeaderText = "descuento"
        Me.Chdescuento.Name = "Chdescuento"
        Me.Chdescuento.ReadOnly = True
        '
        'ChTotal
        '
        Me.ChTotal.HeaderText = "Total"
        Me.ChTotal.Name = "ChTotal"
        Me.ChTotal.ReadOnly = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(270, 514)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "PRECIO BRUTO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(379, 514)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "DESCUENTO"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(468, 514)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "PRECIO NETO"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(576, 514)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "IGV"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(633, 514)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "TOTAL"
        '
        'txtPrecio_bruto
        '
        Me.txtPrecio_bruto.Location = New System.Drawing.Point(287, 530)
        Me.txtPrecio_bruto.Name = "txtPrecio_bruto"
        Me.txtPrecio_bruto.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio_bruto.TabIndex = 62
        '
        'txtMonto_descuento
        '
        Me.txtMonto_descuento.Location = New System.Drawing.Point(385, 530)
        Me.txtMonto_descuento.Name = "txtMonto_descuento"
        Me.txtMonto_descuento.Size = New System.Drawing.Size(68, 20)
        Me.txtMonto_descuento.TabIndex = 63
        '
        'txtPrecio_neto
        '
        Me.txtPrecio_neto.Location = New System.Drawing.Point(478, 530)
        Me.txtPrecio_neto.Name = "txtPrecio_neto"
        Me.txtPrecio_neto.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio_neto.TabIndex = 64
        '
        'txtigv
        '
        Me.txtigv.Location = New System.Drawing.Point(565, 530)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(55, 20)
        Me.txtigv.TabIndex = 65
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(630, 530)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(65, 20)
        Me.TxtTotal.TabIndex = 66
        '
        'btnFiltro_Producto
        '
        Me.btnFiltro_Producto.Location = New System.Drawing.Point(341, 322)
        Me.btnFiltro_Producto.Name = "btnFiltro_Producto"
        Me.btnFiltro_Producto.Size = New System.Drawing.Size(23, 22)
        Me.btnFiltro_Producto.TabIndex = 67
        Me.btnFiltro_Producto.Text = "..."
        Me.btnFiltro_Producto.UseVisualStyleBackColor = True
        '
        'TxtidProducto
        '
        Me.TxtidProducto.Location = New System.Drawing.Point(701, 321)
        Me.TxtidProducto.Name = "TxtidProducto"
        Me.TxtidProducto.Size = New System.Drawing.Size(35, 20)
        Me.TxtidProducto.TabIndex = 68
        '
        'LblProcetaje
        '
        Me.LblProcetaje.AutoSize = True
        Me.LblProcetaje.Location = New System.Drawing.Point(687, 325)
        Me.LblProcetaje.Name = "LblProcetaje"
        Me.LblProcetaje.Size = New System.Drawing.Size(15, 13)
        Me.LblProcetaje.TabIndex = 69
        Me.LblProcetaje.Text = "%"
        '
        'Txtnumero_documento
        '
        Me.Txtnumero_documento.Location = New System.Drawing.Point(571, 117)
        Me.Txtnumero_documento.MaxLength = 3
        Me.Txtnumero_documento.Name = "Txtnumero_documento"
        Me.Txtnumero_documento.Size = New System.Drawing.Size(43, 20)
        Me.Txtnumero_documento.TabIndex = 72
        '
        'Txtserie_documento
        '
        Me.Txtserie_documento.Location = New System.Drawing.Point(617, 117)
        Me.Txtserie_documento.MaxLength = 7
        Me.Txtserie_documento.Name = "Txtserie_documento"
        Me.Txtserie_documento.Size = New System.Drawing.Size(95, 20)
        Me.Txtserie_documento.TabIndex = 73
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(584, 26)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(82, 13)
        Me.lblCodigo.TabIndex = 42
        Me.lblCodigo.Text = "Codigo_Compra"
        Me.lblCodigo.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(701, 404)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(46, 39)
        Me.btnEliminar.TabIndex = 56
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Sistema_Autos.My.Resources.Resources.mas
        Me.btnAgregar.Location = New System.Drawing.Point(701, 358)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(46, 40)
        Me.btnAgregar.TabIndex = 55
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.Sistema_Autos.My.Resources.Resources.excel
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(506, 12)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 55)
        Me.btnExportar.TabIndex = 39
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(584, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 33
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Sistema_Autos.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(425, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 55)
        Me.btnBuscar.TabIndex = 38
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminarOrden
        '
        Me.btnEliminarOrden.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.btnEliminarOrden.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminarOrden.Location = New System.Drawing.Point(344, 12)
        Me.btnEliminarOrden.Name = "btnEliminarOrden"
        Me.btnEliminarOrden.Size = New System.Drawing.Size(75, 55)
        Me.btnEliminarOrden.TabIndex = 37
        Me.btnEliminarOrden.Text = "Eliminar"
        Me.btnEliminarOrden.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarOrden.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.Sistema_Autos.My.Resources.Resources.modificar
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(263, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 55)
        Me.btnModificar.TabIndex = 36
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = Global.Sistema_Autos.My.Resources.Resources.guardar
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(182, 12)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 55)
        Me.btnGrabar.TabIndex = 35
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Sistema_Autos.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(101, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 55)
        Me.btnNuevo.TabIndex = 34
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmOrden_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(755, 562)
        Me.Controls.Add(Me.Txtserie_documento)
        Me.Controls.Add(Me.Txtnumero_documento)
        Me.Controls.Add(Me.LblProcetaje)
        Me.Controls.Add(Me.TxtidProducto)
        Me.Controls.Add(Me.btnFiltro_Producto)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.txtigv)
        Me.Controls.Add(Me.txtPrecio_neto)
        Me.Controls.Add(Me.txtMonto_descuento)
        Me.Controls.Add(Me.txtPrecio_bruto)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dtvListado_Productos)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPrecio_Unitario)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboUnidad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.gpbDatos)
        Me.Controls.Add(Me.lblOrden_Compra)
        Me.Controls.Add(Me.lbIdentificador)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminarOrden)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrden_Compra"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDEN DE COMPRA"
        Me.gpbDatos.ResumeLayout(False)
        Me.gpbDatos.PerformLayout()
        CType(Me.dtvListado_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminarOrden As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents lbIdentificador As System.Windows.Forms.Label
    Friend WithEvents lblOrden_Compra As System.Windows.Forms.Label
    Friend WithEvents gpbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents btnFiltro_Proveedor As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents chkigv As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_Unitario As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents dtvListado_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_bruto As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto_descuento As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio_neto As System.Windows.Forms.TextBox
    Friend WithEvents txtigv As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnFiltro_Producto As System.Windows.Forms.Button
    Friend WithEvents TxtidProducto As System.Windows.Forms.TextBox
    Friend WithEvents ChId_Poducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chprecio_compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chdescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblProcetaje As System.Windows.Forms.Label
    Friend WithEvents Txtnumero_documento As System.Windows.Forms.TextBox
    Friend WithEvents Txtserie_documento As System.Windows.Forms.TextBox
    Friend WithEvents Txtid_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
End Class
