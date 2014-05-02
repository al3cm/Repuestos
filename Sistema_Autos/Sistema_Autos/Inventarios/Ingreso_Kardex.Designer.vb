<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngreso_Kardex
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
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.txttotal = New System.Windows.Forms.TextBox
        Me.txtigv = New System.Windows.Forms.TextBox
        Me.txtPrecio_neto = New System.Windows.Forms.TextBox
        Me.txtMonto_descuento = New System.Windows.Forms.TextBox
        Me.txtPrecio_bruto = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPrecio_Unitario = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboUnidad = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.gpbDatos = New System.Windows.Forms.GroupBox
        Me.TxtIdAlmance = New System.Windows.Forms.TextBox
        Me.cboTipoPago = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtIdOrden = New System.Windows.Forms.TextBox
        Me.txtMonto_cuota = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtmonto_financiado = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtnro_cuotas = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtinicial = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtProveedor = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtdocumento = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtOrden_Venta = New System.Windows.Forms.TextBox
        Me.dtpfecha_llegada = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkigv = New System.Windows.Forms.CheckBox
        Me.dtpfecha_emision = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnBuscarOrden_Venta = New System.Windows.Forms.Button
        Me.Label20 = New System.Windows.Forms.Label
        Me.cbotipo_comprobante = New System.Windows.Forms.ComboBox
        Me.txtserie_documento = New System.Windows.Forms.TextBox
        Me.Txtnumero_documento = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtvListado_Productos = New System.Windows.Forms.DataGridView
        Me.ChId_Poducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chprecio_compra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chdescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TxtidProducto = New System.Windows.Forms.TextBox
        Me.LblProcetaje = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.cboCaja = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.gpbDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dtvListado_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.Sistema_Autos.My.Resources.Resources.excel
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(172, 20)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 55)
        Me.btnExportar.TabIndex = 46
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(253, 20)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 40
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = Global.Sistema_Autos.My.Resources.Resources.guardar
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(91, 20)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 55)
        Me.btnGrabar.TabIndex = 42
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Sistema_Autos.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(10, 20)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 55)
        Me.btnNuevo.TabIndex = 41
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(670, 438)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(65, 20)
        Me.txttotal.TabIndex = 89
        '
        'txtigv
        '
        Me.txtigv.Location = New System.Drawing.Point(605, 438)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(55, 20)
        Me.txtigv.TabIndex = 88
        '
        'txtPrecio_neto
        '
        Me.txtPrecio_neto.Location = New System.Drawing.Point(518, 438)
        Me.txtPrecio_neto.Name = "txtPrecio_neto"
        Me.txtPrecio_neto.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio_neto.TabIndex = 87
        '
        'txtMonto_descuento
        '
        Me.txtMonto_descuento.Location = New System.Drawing.Point(425, 438)
        Me.txtMonto_descuento.Name = "txtMonto_descuento"
        Me.txtMonto_descuento.Size = New System.Drawing.Size(68, 20)
        Me.txtMonto_descuento.TabIndex = 86
        '
        'txtPrecio_bruto
        '
        Me.txtPrecio_bruto.Location = New System.Drawing.Point(327, 438)
        Me.txtPrecio_bruto.Name = "txtPrecio_bruto"
        Me.txtPrecio_bruto.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio_bruto.TabIndex = 85
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(676, 422)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 84
        Me.Label18.Text = "TOTAL"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(617, 422)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "IGV"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(508, 422)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "PRECIO NETO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(419, 422)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "DESCUENTO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(310, 422)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "PRECIO BRUTO"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(748, 301)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(46, 39)
        Me.btnEliminar.TabIndex = 79
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Sistema_Autos.My.Resources.Resources.mas
        Me.btnAgregar.Location = New System.Drawing.Point(748, 255)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(46, 40)
        Me.btnAgregar.TabIndex = 78
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(571, 230)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(79, 20)
        Me.txtDescuento.TabIndex = 76
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(576, 214)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Descuento:"
        '
        'txtPrecio_Unitario
        '
        Me.txtPrecio_Unitario.Location = New System.Drawing.Point(481, 230)
        Me.txtPrecio_Unitario.Name = "txtPrecio_Unitario"
        Me.txtPrecio_Unitario.Size = New System.Drawing.Size(79, 20)
        Me.txtPrecio_Unitario.TabIndex = 74
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(482, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Precio Unit:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(403, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Cantidad:"
        '
        'cboUnidad
        '
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Location = New System.Drawing.Point(328, 230)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(59, 21)
        Me.cboUnidad.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(333, 214)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Unidad:"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(12, 229)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(305, 20)
        Me.txtProducto.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Producto:"
        '
        'gpbDatos
        '
        Me.gpbDatos.Controls.Add(Me.cboCaja)
        Me.gpbDatos.Controls.Add(Me.TxtIdAlmance)
        Me.gpbDatos.Controls.Add(Me.cboTipoPago)
        Me.gpbDatos.Controls.Add(Me.Label3)
        Me.gpbDatos.Controls.Add(Me.Label8)
        Me.gpbDatos.Controls.Add(Me.TxtIdOrden)
        Me.gpbDatos.Controls.Add(Me.txtMonto_cuota)
        Me.gpbDatos.Controls.Add(Me.Label26)
        Me.gpbDatos.Controls.Add(Me.txtmonto_financiado)
        Me.gpbDatos.Controls.Add(Me.Label25)
        Me.gpbDatos.Controls.Add(Me.txtnro_cuotas)
        Me.gpbDatos.Controls.Add(Me.Label24)
        Me.gpbDatos.Controls.Add(Me.txtinicial)
        Me.gpbDatos.Controls.Add(Me.Label23)
        Me.gpbDatos.Controls.Add(Me.txtProveedor)
        Me.gpbDatos.Controls.Add(Me.Label5)
        Me.gpbDatos.Controls.Add(Me.txtdocumento)
        Me.gpbDatos.Controls.Add(Me.Label4)
        Me.gpbDatos.Controls.Add(Me.Label2)
        Me.gpbDatos.Controls.Add(Me.txtOrden_Venta)
        Me.gpbDatos.Controls.Add(Me.dtpfecha_llegada)
        Me.gpbDatos.Controls.Add(Me.Label7)
        Me.gpbDatos.Controls.Add(Me.chkigv)
        Me.gpbDatos.Controls.Add(Me.dtpfecha_emision)
        Me.gpbDatos.Controls.Add(Me.Label6)
        Me.gpbDatos.Controls.Add(Me.btnBuscarOrden_Venta)
        Me.gpbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbDatos.Location = New System.Drawing.Point(12, 84)
        Me.gpbDatos.Name = "gpbDatos"
        Me.gpbDatos.Size = New System.Drawing.Size(788, 122)
        Me.gpbDatos.TabIndex = 92
        Me.gpbDatos.TabStop = False
        Me.gpbDatos.Text = "Datos"
        '
        'TxtIdAlmance
        '
        Me.TxtIdAlmance.Location = New System.Drawing.Point(20, 100)
        Me.TxtIdAlmance.Name = "TxtIdAlmance"
        Me.TxtIdAlmance.Size = New System.Drawing.Size(66, 20)
        Me.TxtIdAlmance.TabIndex = 104
        '
        'cboTipoPago
        '
        Me.cboTipoPago.FormattingEnabled = True
        Me.cboTipoPago.Location = New System.Drawing.Point(391, 80)
        Me.cboTipoPago.Name = "cboTipoPago"
        Me.cboTipoPago.Size = New System.Drawing.Size(121, 21)
        Me.cboTipoPago.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(298, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Tipo de Pago:"
        '
        'TxtIdOrden
        '
        Me.TxtIdOrden.Location = New System.Drawing.Point(114, 100)
        Me.TxtIdOrden.Name = "TxtIdOrden"
        Me.TxtIdOrden.Size = New System.Drawing.Size(66, 20)
        Me.TxtIdOrden.TabIndex = 78
        '
        'txtMonto_cuota
        '
        Me.txtMonto_cuota.Location = New System.Drawing.Point(607, 82)
        Me.txtMonto_cuota.Name = "txtMonto_cuota"
        Me.txtMonto_cuota.Size = New System.Drawing.Size(65, 20)
        Me.txtMonto_cuota.TabIndex = 69
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(518, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(83, 13)
        Me.Label26.TabIndex = 68
        Me.Label26.Text = "Monto Cuota:"
        '
        'txtmonto_financiado
        '
        Me.txtmonto_financiado.Location = New System.Drawing.Point(717, 30)
        Me.txtmonto_financiado.Name = "txtmonto_financiado"
        Me.txtmonto_financiado.Size = New System.Drawing.Size(65, 20)
        Me.txtmonto_financiado.TabIndex = 65
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(604, 33)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(112, 13)
        Me.Label25.TabIndex = 64
        Me.Label25.Text = "Monto Financiado:"
        '
        'txtnro_cuotas
        '
        Me.txtnro_cuotas.Location = New System.Drawing.Point(539, 54)
        Me.txtnro_cuotas.Name = "txtnro_cuotas"
        Me.txtnro_cuotas.Size = New System.Drawing.Size(30, 20)
        Me.txtnro_cuotas.TabIndex = 67
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(490, 57)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(50, 13)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "Cuotas:"
        '
        'txtinicial
        '
        Me.txtinicial.Location = New System.Drawing.Point(539, 26)
        Me.txtinicial.Name = "txtinicial"
        Me.txtinicial.Size = New System.Drawing.Size(60, 20)
        Me.txtinicial.TabIndex = 63
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(489, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 62
        Me.Label23.Text = "Inicial:"
        '
        'txtProveedor
        '
        Me.txtProveedor.Location = New System.Drawing.Point(92, 81)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(175, 20)
        Me.txtProveedor.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Proveedor:"
        '
        'txtdocumento
        '
        Me.txtdocumento.Location = New System.Drawing.Point(57, 54)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.Size = New System.Drawing.Size(210, 20)
        Me.txtdocumento.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Ruc:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Orden de Compra:"
        '
        'txtOrden_Venta
        '
        Me.txtOrden_Venta.Location = New System.Drawing.Point(123, 26)
        Me.txtOrden_Venta.Name = "txtOrden_Venta"
        Me.txtOrden_Venta.Size = New System.Drawing.Size(144, 20)
        Me.txtOrden_Venta.TabIndex = 54
        '
        'dtpfecha_llegada
        '
        Me.dtpfecha_llegada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_llegada.Location = New System.Drawing.Point(391, 54)
        Me.dtpfecha_llegada.Name = "dtpfecha_llegada"
        Me.dtpfecha_llegada.Size = New System.Drawing.Size(93, 20)
        Me.dtpfecha_llegada.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Fec. Llegada:"
        '
        'chkigv
        '
        Me.chkigv.AutoSize = True
        Me.chkigv.Checked = True
        Me.chkigv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkigv.Location = New System.Drawing.Point(293, 100)
        Me.chkigv.Name = "chkigv"
        Me.chkigv.Size = New System.Drawing.Size(92, 17)
        Me.chkigv.TabIndex = 15
        Me.chkigv.Text = "Incluye IGV"
        Me.chkigv.UseVisualStyleBackColor = True
        '
        'dtpfecha_emision
        '
        Me.dtpfecha_emision.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_emision.Location = New System.Drawing.Point(391, 27)
        Me.dtpfecha_emision.Name = "dtpfecha_emision"
        Me.dtpfecha_emision.Size = New System.Drawing.Size(92, 20)
        Me.dtpfecha_emision.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fec. Emisión:"
        '
        'btnBuscarOrden_Venta
        '
        Me.btnBuscarOrden_Venta.Location = New System.Drawing.Point(273, 25)
        Me.btnBuscarOrden_Venta.Name = "btnBuscarOrden_Venta"
        Me.btnBuscarOrden_Venta.Size = New System.Drawing.Size(23, 22)
        Me.btnBuscarOrden_Venta.TabIndex = 2
        Me.btnBuscarOrden_Venta.Text = "..."
        Me.btnBuscarOrden_Venta.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 11)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 20)
        Me.Label20.TabIndex = 93
        Me.Label20.Text = "COMPROBANTE"
        '
        'cbotipo_comprobante
        '
        Me.cbotipo_comprobante.FormattingEnabled = True
        Me.cbotipo_comprobante.Location = New System.Drawing.Point(11, 31)
        Me.cbotipo_comprobante.Name = "cbotipo_comprobante"
        Me.cbotipo_comprobante.Size = New System.Drawing.Size(134, 21)
        Me.cbotipo_comprobante.TabIndex = 94
        '
        'txtserie_documento
        '
        Me.txtserie_documento.Location = New System.Drawing.Point(185, 31)
        Me.txtserie_documento.MaxLength = 7
        Me.txtserie_documento.Multiline = True
        Me.txtserie_documento.Name = "txtserie_documento"
        Me.txtserie_documento.Size = New System.Drawing.Size(102, 21)
        Me.txtserie_documento.TabIndex = 95
        '
        'Txtnumero_documento
        '
        Me.Txtnumero_documento.Location = New System.Drawing.Point(150, 31)
        Me.Txtnumero_documento.MaxLength = 3
        Me.Txtnumero_documento.Multiline = True
        Me.Txtnumero_documento.Name = "Txtnumero_documento"
        Me.Txtnumero_documento.Size = New System.Drawing.Size(33, 21)
        Me.Txtnumero_documento.TabIndex = 96
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Txtnumero_documento)
        Me.GroupBox1.Controls.Add(Me.cbotipo_comprobante)
        Me.GroupBox1.Controls.Add(Me.txtserie_documento)
        Me.GroupBox1.Location = New System.Drawing.Point(341, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 58)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        '
        'dtvListado_Productos
        '
        Me.dtvListado_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvListado_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChId_Poducto, Me.ChProducto, Me.ChCantidad, Me.ChUnidad, Me.Chprecio_compra, Me.Chdescuento, Me.ChTotal})
        Me.dtvListado_Productos.Location = New System.Drawing.Point(10, 255)
        Me.dtvListado_Productos.Name = "dtvListado_Productos"
        Me.dtvListado_Productos.Size = New System.Drawing.Size(725, 150)
        Me.dtvListado_Productos.TabIndex = 98
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
        'TxtidProducto
        '
        Me.TxtidProducto.Location = New System.Drawing.Point(748, 372)
        Me.TxtidProducto.Name = "TxtidProducto"
        Me.TxtidProducto.Size = New System.Drawing.Size(46, 20)
        Me.TxtidProducto.TabIndex = 99
        '
        'LblProcetaje
        '
        Me.LblProcetaje.AutoSize = True
        Me.LblProcetaje.Location = New System.Drawing.Point(656, 233)
        Me.LblProcetaje.Name = "LblProcetaje"
        Me.LblProcetaje.Size = New System.Drawing.Size(15, 13)
        Me.LblProcetaje.TabIndex = 100
        Me.LblProcetaje.Text = "%"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(7, 421)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(79, 13)
        Me.lblCodigo.TabIndex = 102
        Me.lblCodigo.Text = "Codigo_Kardex"
        Me.lblCodigo.Visible = False
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(403, 231)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(61, 20)
        Me.txtCantidad.TabIndex = 103
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(639, 57)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(143, 21)
        Me.cboCaja.TabIndex = 105
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(590, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Caja:"
        '
        'frmIngreso_Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(809, 470)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.LblProcetaje)
        Me.Controls.Add(Me.TxtidProducto)
        Me.Controls.Add(Me.dtvListado_Productos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gpbDatos)
        Me.Controls.Add(Me.txttotal)
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
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPrecio_Unitario)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboUnidad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIngreso_Kardex"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INGRESO AL KARDEX"
        Me.gpbDatos.ResumeLayout(False)
        Me.gpbDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dtvListado_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents txtigv As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio_neto As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto_descuento As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio_bruto As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_Unitario As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gpbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents chkigv As System.Windows.Forms.CheckBox
    Friend WithEvents dtpfecha_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnBuscarOrden_Venta As System.Windows.Forms.Button
    Friend WithEvents dtpfecha_llegada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cbotipo_comprobante As System.Windows.Forms.ComboBox
    Friend WithEvents txtserie_documento As System.Windows.Forms.TextBox
    Friend WithEvents Txtnumero_documento As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOrden_Venta As System.Windows.Forms.TextBox
    Friend WithEvents txtdocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMonto_cuota As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtmonto_financiado As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtnro_cuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtinicial As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents TxtIdOrden As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtvListado_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents ChId_Poducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chprecio_compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chdescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtidProducto As System.Windows.Forms.TextBox
    Friend WithEvents LblProcetaje As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdAlmance As System.Windows.Forms.TextBox
    Friend WithEvents cboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
