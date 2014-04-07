<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFacturacion
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
        Me.btnAnular = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtserie_documento = New System.Windows.Forms.TextBox
        Me.txtnro_documento = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboTipo_Documento = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtOrden_Venta = New System.Windows.Forms.TextBox
        Me.btnBuscar_orden_venta = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TxtIdOrden = New System.Windows.Forms.TextBox
        Me.txtfinanciado = New System.Windows.Forms.TextBox
        Me.txtinicial = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.chkigv = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpfecha_emision = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboCaja = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboVendedor = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdireccion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtdocumento = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.txtigv = New System.Windows.Forms.TextBox
        Me.txtPrecio_neto = New System.Windows.Forms.TextBox
        Me.txtMonto_descuento = New System.Windows.Forms.TextBox
        Me.txtPrecio_bruto = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.dtvListado_Productos = New System.Windows.Forms.DataGridView
        Me.ChId_Poducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chprecio_compra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chdescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtvListado_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAnular
        '
        Me.btnAnular.Image = Global.Sistema_Autos.My.Resources.Resources.anular
        Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAnular.Location = New System.Drawing.Point(224, 12)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(75, 55)
        Me.btnAnular.TabIndex = 47
        Me.btnAnular.Text = "&Anular"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Sistema_Autos.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(392, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 55)
        Me.btnImprimir.TabIndex = 46
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(473, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 40
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(305, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 55)
        Me.btnEliminar.TabIndex = 44
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = Global.Sistema_Autos.My.Resources.Resources.guardar
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(143, 12)
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
        Me.btnNuevo.Location = New System.Drawing.Point(62, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 55)
        Me.btnNuevo.TabIndex = 41
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtserie_documento)
        Me.GroupBox1.Controls.Add(Me.txtnro_documento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboTipo_Documento)
        Me.GroupBox1.Location = New System.Drawing.Point(456, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 78)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        '
        'txtserie_documento
        '
        Me.txtserie_documento.Location = New System.Drawing.Point(154, 39)
        Me.txtserie_documento.Name = "txtserie_documento"
        Me.txtserie_documento.Size = New System.Drawing.Size(87, 20)
        Me.txtserie_documento.TabIndex = 3
        '
        'txtnro_documento
        '
        Me.txtnro_documento.Location = New System.Drawing.Point(102, 39)
        Me.txtnro_documento.MaxLength = 3
        Me.txtnro_documento.Name = "txtnro_documento"
        Me.txtnro_documento.Size = New System.Drawing.Size(46, 20)
        Me.txtnro_documento.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FACTURACION"
        '
        'cboTipo_Documento
        '
        Me.cboTipo_Documento.FormattingEnabled = True
        Me.cboTipo_Documento.Location = New System.Drawing.Point(6, 39)
        Me.cboTipo_Documento.Name = "cboTipo_Documento"
        Me.cboTipo_Documento.Size = New System.Drawing.Size(90, 21)
        Me.cboTipo_Documento.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 78)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Orden de Venta:"
        '
        'txtOrden_Venta
        '
        Me.txtOrden_Venta.Location = New System.Drawing.Point(94, 17)
        Me.txtOrden_Venta.Name = "txtOrden_Venta"
        Me.txtOrden_Venta.Size = New System.Drawing.Size(104, 20)
        Me.txtOrden_Venta.TabIndex = 52
        '
        'btnBuscar_orden_venta
        '
        Me.btnBuscar_orden_venta.Location = New System.Drawing.Point(202, 16)
        Me.btnBuscar_orden_venta.Name = "btnBuscar_orden_venta"
        Me.btnBuscar_orden_venta.Size = New System.Drawing.Size(26, 23)
        Me.btnBuscar_orden_venta.TabIndex = 53
        Me.btnBuscar_orden_venta.Text = "..."
        Me.btnBuscar_orden_venta.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtIdOrden)
        Me.GroupBox3.Controls.Add(Me.txtfinanciado)
        Me.GroupBox3.Controls.Add(Me.txtinicial)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.cboMoneda)
        Me.GroupBox3.Controls.Add(Me.chkigv)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.dtpfecha_emision)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.cboCaja)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cboVendedor)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtdireccion)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtCliente)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtdocumento)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cboAlmacen)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnBuscar_orden_venta)
        Me.GroupBox3.Controls.Add(Me.txtOrden_Venta)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(693, 205)
        Me.GroupBox3.TabIndex = 54
        Me.GroupBox3.TabStop = False
        '
        'TxtIdOrden
        '
        Me.TxtIdOrden.Location = New System.Drawing.Point(593, 139)
        Me.TxtIdOrden.Name = "TxtIdOrden"
        Me.TxtIdOrden.Size = New System.Drawing.Size(66, 20)
        Me.TxtIdOrden.TabIndex = 77
        '
        'txtfinanciado
        '
        Me.txtfinanciado.Location = New System.Drawing.Point(440, 169)
        Me.txtfinanciado.Name = "txtfinanciado"
        Me.txtfinanciado.Size = New System.Drawing.Size(100, 20)
        Me.txtfinanciado.TabIndex = 76
        '
        'txtinicial
        '
        Me.txtinicial.Location = New System.Drawing.Point(440, 139)
        Me.txtinicial.Name = "txtinicial"
        Me.txtinicial.Size = New System.Drawing.Size(100, 20)
        Me.txtinicial.TabIndex = 75
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(375, 178)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Financiado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(400, 147)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 73
        Me.Label12.Text = "Inicial:"
        '
        'cboMoneda
        '
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(440, 79)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(151, 21)
        Me.cboMoneda.TabIndex = 70
        '
        'chkigv
        '
        Me.chkigv.AutoSize = True
        Me.chkigv.Checked = True
        Me.chkigv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkigv.Location = New System.Drawing.Point(578, 52)
        Me.chkigv.Name = "chkigv"
        Me.chkigv.Size = New System.Drawing.Size(81, 17)
        Me.chkigv.TabIndex = 69
        Me.chkigv.Text = "Incluye IGV"
        Me.chkigv.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(388, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Moneda:"
        '
        'dtpfecha_emision
        '
        Me.dtpfecha_emision.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_emision.Location = New System.Drawing.Point(440, 50)
        Me.dtpfecha_emision.Name = "dtpfecha_emision"
        Me.dtpfecha_emision.Size = New System.Drawing.Size(116, 20)
        Me.dtpfecha_emision.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(358, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 13)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Fecha Emision:"
        '
        'cboCaja
        '
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(417, 16)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(242, 21)
        Me.cboCaja.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Caja:"
        '
        'cboVendedor
        '
        Me.cboVendedor.FormattingEnabled = True
        Me.cboVendedor.Location = New System.Drawing.Point(94, 169)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(244, 21)
        Me.cboVendedor.TabIndex = 63
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Vendedor:"
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(94, 140)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(244, 20)
        Me.txtdireccion.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Dirección:"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(94, 109)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(244, 20)
        Me.txtCliente.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Cliente:"
        '
        'txtdocumento
        '
        Me.txtdocumento.Location = New System.Drawing.Point(94, 80)
        Me.txtdocumento.Name = "txtdocumento"
        Me.txtdocumento.Size = New System.Drawing.Size(134, 20)
        Me.txtdocumento.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Ruc o DNI:"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(94, 50)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(244, 21)
        Me.cboAlmacen.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Almacen:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(640, 510)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(65, 20)
        Me.TxtTotal.TabIndex = 65
        '
        'txtigv
        '
        Me.txtigv.Location = New System.Drawing.Point(575, 510)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(55, 20)
        Me.txtigv.TabIndex = 63
        '
        'txtPrecio_neto
        '
        Me.txtPrecio_neto.Location = New System.Drawing.Point(488, 510)
        Me.txtPrecio_neto.Name = "txtPrecio_neto"
        Me.txtPrecio_neto.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio_neto.TabIndex = 61
        '
        'txtMonto_descuento
        '
        Me.txtMonto_descuento.Location = New System.Drawing.Point(395, 510)
        Me.txtMonto_descuento.Name = "txtMonto_descuento"
        Me.txtMonto_descuento.Size = New System.Drawing.Size(68, 20)
        Me.txtMonto_descuento.TabIndex = 59
        '
        'txtPrecio_bruto
        '
        Me.txtPrecio_bruto.Location = New System.Drawing.Point(297, 510)
        Me.txtPrecio_bruto.Name = "txtPrecio_bruto"
        Me.txtPrecio_bruto.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio_bruto.TabIndex = 57
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(648, 494)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "TOTAL"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(586, 494)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "IGV"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(478, 494)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "PRECIO NETO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(389, 494)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 13)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "DESCUENTO"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(280, 494)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 13)
        Me.Label22.TabIndex = 56
        Me.Label22.Text = "PRECIO BRUTO"
        '
        'dtvListado_Productos
        '
        Me.dtvListado_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvListado_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChId_Poducto, Me.ChProducto, Me.ChCantidad, Me.ChUnidad, Me.Chprecio_compra, Me.Chdescuento, Me.ChTotal})
        Me.dtvListado_Productos.Location = New System.Drawing.Point(13, 363)
        Me.dtvListado_Productos.Name = "dtvListado_Productos"
        Me.dtvListado_Productos.Size = New System.Drawing.Size(692, 116)
        Me.dtvListado_Productos.TabIndex = 79
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
        'frmFacturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(720, 537)
        Me.Controls.Add(Me.dtvListado_Productos)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.txtigv)
        Me.Controls.Add(Me.txtPrecio_neto)
        Me.Controls.Add(Me.txtMonto_descuento)
        Me.Controls.Add(Me.txtPrecio_bruto)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFacturacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURACION"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtvListado_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboTipo_Documento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnro_documento As System.Windows.Forms.TextBox
    Friend WithEvents txtserie_documento As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOrden_Venta As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar_orden_venta As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdocumento As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtdireccion As System.Windows.Forms.TextBox
    Friend WithEvents cboVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkigv As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtinicial As System.Windows.Forms.TextBox
    Friend WithEvents txtfinanciado As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtigv As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio_neto As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto_descuento As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio_bruto As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtvListado_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents ChId_Poducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chprecio_compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chdescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TxtIdOrden As System.Windows.Forms.TextBox
End Class
