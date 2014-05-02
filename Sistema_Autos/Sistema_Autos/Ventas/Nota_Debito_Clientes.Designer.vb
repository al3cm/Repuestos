<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNota_Debito_Clientes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtnro_documento = New System.Windows.Forms.TextBox
        Me.txtserie_documento = New System.Windows.Forms.TextBox
        Me.cbotipo_documento = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnEliminarOrden = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboMotivo = New System.Windows.Forms.ComboBox
        Me.chkigv = New System.Windows.Forms.CheckBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtIdOrden = New System.Windows.Forms.TextBox
        Me.rbtKardex = New System.Windows.Forms.RadioButton
        Me.rbtDevolucion = New System.Windows.Forms.RadioButton
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpfecha_emision = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtsaldo_pendiente = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnbuscar_registro_ventas = New System.Windows.Forms.Button
        Me.txt_documento = New System.Windows.Forms.TextBox
        Me.txttipo_documento = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtcliente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPrecio_Unitario = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboUnidad = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.txtigv = New System.Windows.Forms.TextBox
        Me.txtPrecio_neto = New System.Windows.Forms.TextBox
        Me.txtMonto_descuento = New System.Windows.Forms.TextBox
        Me.txtPrecio_bruto = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtidProducto = New System.Windows.Forms.TextBox
        Me.LblProcetaje = New System.Windows.Forms.Label
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtvListado_Productos = New System.Windows.Forms.DataGridView
        Me.ChId_Poducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chprecio_compra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chdescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnModificar = New System.Windows.Forms.Button
        Me.TxtDni = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtvListado_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnro_documento)
        Me.GroupBox1.Controls.Add(Me.txtserie_documento)
        Me.GroupBox1.Controls.Add(Me.cbotipo_documento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(406, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtnro_documento
        '
        Me.txtnro_documento.Location = New System.Drawing.Point(116, 39)
        Me.txtnro_documento.Name = "txtnro_documento"
        Me.txtnro_documento.Size = New System.Drawing.Size(29, 20)
        Me.txtnro_documento.TabIndex = 3
        '
        'txtserie_documento
        '
        Me.txtserie_documento.Location = New System.Drawing.Point(150, 39)
        Me.txtserie_documento.Name = "txtserie_documento"
        Me.txtserie_documento.Size = New System.Drawing.Size(66, 20)
        Me.txtserie_documento.TabIndex = 2
        '
        'cbotipo_documento
        '
        Me.cbotipo_documento.FormattingEnabled = True
        Me.cbotipo_documento.Location = New System.Drawing.Point(17, 39)
        Me.cbotipo_documento.Name = "cbotipo_documento"
        Me.cbotipo_documento.Size = New System.Drawing.Size(93, 21)
        Me.cbotipo_documento.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "COMPROBANTE"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(495, 26)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(82, 13)
        Me.lblCodigo.TabIndex = 74
        Me.lblCodigo.Text = "Codigo_Compra"
        Me.lblCodigo.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Sistema_Autos.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(417, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 55)
        Me.btnImprimir.TabIndex = 75
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(498, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 69
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Sistema_Autos.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(336, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 55)
        Me.btnBuscar.TabIndex = 73
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminarOrden
        '
        Me.btnEliminarOrden.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.btnEliminarOrden.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminarOrden.Location = New System.Drawing.Point(255, 12)
        Me.btnEliminarOrden.Name = "btnEliminarOrden"
        Me.btnEliminarOrden.Size = New System.Drawing.Size(75, 55)
        Me.btnEliminarOrden.TabIndex = 72
        Me.btnEliminarOrden.Text = "Eliminar"
        Me.btnEliminarOrden.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarOrden.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = Global.Sistema_Autos.My.Resources.Resources.guardar
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(93, 12)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 55)
        Me.btnGrabar.TabIndex = 71
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Sistema_Autos.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(12, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 55)
        Me.btnNuevo.TabIndex = 70
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtDni)
        Me.GroupBox2.Controls.Add(Me.cboMotivo)
        Me.GroupBox2.Controls.Add(Me.chkigv)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.cboAlmacen)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.TxtIdOrden)
        Me.GroupBox2.Controls.Add(Me.rbtKardex)
        Me.GroupBox2.Controls.Add(Me.rbtDevolucion)
        Me.GroupBox2.Controls.Add(Me.txtobservaciones)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpfecha_emision)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtsaldo_pendiente)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnbuscar_registro_ventas)
        Me.GroupBox2.Controls.Add(Me.txt_documento)
        Me.GroupBox2.Controls.Add(Me.txttipo_documento)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboMoneda)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtcliente)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(617, 172)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cboMotivo
        '
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Location = New System.Drawing.Point(66, 87)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(121, 21)
        Me.cboMotivo.TabIndex = 92
        '
        'chkigv
        '
        Me.chkigv.AutoSize = True
        Me.chkigv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkigv.Checked = True
        Me.chkigv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkigv.Location = New System.Drawing.Point(216, 90)
        Me.chkigv.Name = "chkigv"
        Me.chkigv.Size = New System.Drawing.Size(84, 17)
        Me.chkigv.TabIndex = 85
        Me.chkigv.Text = "Incluye IGV:"
        Me.chkigv.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(18, 95)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 13)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = "Motivo:"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(373, 83)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(121, 21)
        Me.cboAlmacen.TabIndex = 84
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(308, 89)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 13)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "Almacén de:"
        '
        'TxtIdOrden
        '
        Me.TxtIdOrden.Location = New System.Drawing.Point(524, 88)
        Me.TxtIdOrden.Name = "TxtIdOrden"
        Me.TxtIdOrden.Size = New System.Drawing.Size(66, 20)
        Me.TxtIdOrden.TabIndex = 82
        '
        'rbtKardex
        '
        Me.rbtKardex.AutoSize = True
        Me.rbtKardex.Location = New System.Drawing.Point(505, 25)
        Me.rbtKardex.Name = "rbtKardex"
        Me.rbtKardex.Size = New System.Drawing.Size(103, 17)
        Me.rbtKardex.TabIndex = 13
        Me.rbtKardex.TabStop = True
        Me.rbtKardex.Text = "Afecta al Kardex"
        Me.rbtKardex.UseVisualStyleBackColor = True
        '
        'rbtDevolucion
        '
        Me.rbtDevolucion.AutoSize = True
        Me.rbtDevolucion.Location = New System.Drawing.Point(505, 58)
        Me.rbtDevolucion.Name = "rbtDevolucion"
        Me.rbtDevolucion.Size = New System.Drawing.Size(79, 17)
        Me.rbtDevolucion.TabIndex = 16
        Me.rbtDevolucion.TabStop = True
        Me.rbtDevolucion.Text = "Devolución"
        Me.rbtDevolucion.UseVisualStyleBackColor = True
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(349, 116)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(259, 41)
        Me.txtobservaciones.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(262, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Observaciones:"
        '
        'dtpfecha_emision
        '
        Me.dtpfecha_emision.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_emision.Location = New System.Drawing.Point(115, 125)
        Me.dtpfecha_emision.Name = "dtpfecha_emision"
        Me.dtpfecha_emision.Size = New System.Drawing.Size(92, 20)
        Me.dtpfecha_emision.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Fecha Emisión:"
        '
        'txtsaldo_pendiente
        '
        Me.txtsaldo_pendiente.Location = New System.Drawing.Point(394, 57)
        Me.txtsaldo_pendiente.Name = "txtsaldo_pendiente"
        Me.txtsaldo_pendiente.Size = New System.Drawing.Size(100, 20)
        Me.txtsaldo_pendiente.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Saldo Pendiente:"
        '
        'btnbuscar_registro_ventas
        '
        Me.btnbuscar_registro_ventas.Location = New System.Drawing.Point(303, 22)
        Me.btnbuscar_registro_ventas.Name = "btnbuscar_registro_ventas"
        Me.btnbuscar_registro_ventas.Size = New System.Drawing.Size(30, 23)
        Me.btnbuscar_registro_ventas.TabIndex = 6
        Me.btnbuscar_registro_ventas.Text = "..."
        Me.btnbuscar_registro_ventas.UseVisualStyleBackColor = True
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(144, 57)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(118, 20)
        Me.txt_documento.TabIndex = 5
        '
        'txttipo_documento
        '
        Me.txttipo_documento.Location = New System.Drawing.Point(77, 57)
        Me.txttipo_documento.Name = "txttipo_documento"
        Me.txttipo_documento.Size = New System.Drawing.Size(61, 20)
        Me.txttipo_documento.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Documento:"
        '
        'cboMoneda
        '
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(394, 22)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(100, 21)
        Me.cboMoneda.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(345, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Moneda:"
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(66, 22)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(228, 20)
        Me.txtcliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente:"
        '
        'txtPrecio_Unitario
        '
        Me.txtPrecio_Unitario.Location = New System.Drawing.Point(469, 347)
        Me.txtPrecio_Unitario.Name = "txtPrecio_Unitario"
        Me.txtPrecio_Unitario.Size = New System.Drawing.Size(79, 20)
        Me.txtPrecio_Unitario.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(470, 331)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Precio Unit:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(392, 347)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(71, 20)
        Me.txtCantidad.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(398, 331)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Cantidad:"
        '
        'cboUnidad
        '
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Location = New System.Drawing.Point(323, 347)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(59, 21)
        Me.cboUnidad.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(328, 331)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Unidad:"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(12, 347)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(305, 20)
        Me.txtProducto.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Producto:"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(583, 419)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(46, 39)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Sistema_Autos.My.Resources.Resources.mas
        Me.btnAgregar.Location = New System.Drawing.Point(583, 373)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(46, 40)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(513, 520)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(65, 20)
        Me.TxtTotal.TabIndex = 23
        '
        'txtigv
        '
        Me.txtigv.Location = New System.Drawing.Point(448, 520)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(55, 20)
        Me.txtigv.TabIndex = 21
        '
        'txtPrecio_neto
        '
        Me.txtPrecio_neto.Location = New System.Drawing.Point(361, 520)
        Me.txtPrecio_neto.Name = "txtPrecio_neto"
        Me.txtPrecio_neto.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio_neto.TabIndex = 19
        '
        'txtMonto_descuento
        '
        Me.txtMonto_descuento.Location = New System.Drawing.Point(268, 520)
        Me.txtMonto_descuento.Name = "txtMonto_descuento"
        Me.txtMonto_descuento.Size = New System.Drawing.Size(68, 20)
        Me.txtMonto_descuento.TabIndex = 17
        '
        'txtPrecio_bruto
        '
        Me.txtPrecio_bruto.Location = New System.Drawing.Point(170, 520)
        Me.txtPrecio_bruto.Name = "txtPrecio_bruto"
        Me.txtPrecio_bruto.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio_bruto.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(516, 504)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "TOTAL"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(459, 504)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "IGV"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(351, 504)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "PRECIO NETO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(262, 504)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "DESCUENTO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(153, 504)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "PRECIO BRUTO"
        '
        'TxtidProducto
        '
        Me.TxtidProducto.Location = New System.Drawing.Point(583, 464)
        Me.TxtidProducto.Name = "TxtidProducto"
        Me.TxtidProducto.Size = New System.Drawing.Size(48, 20)
        Me.TxtidProducto.TabIndex = 112
        '
        'LblProcetaje
        '
        Me.LblProcetaje.AutoSize = True
        Me.LblProcetaje.Location = New System.Drawing.Point(605, 351)
        Me.LblProcetaje.Name = "LblProcetaje"
        Me.LblProcetaje.Size = New System.Drawing.Size(15, 13)
        Me.LblProcetaje.TabIndex = 115
        Me.LblProcetaje.Text = "%"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(554, 348)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(48, 20)
        Me.txtDescuento.TabIndex = 114
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(551, 330)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 113
        Me.Label13.Text = "Descto:"
        '
        'dtvListado_Productos
        '
        Me.dtvListado_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvListado_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChId_Poducto, Me.ChProducto, Me.ChCantidad, Me.ChUnidad, Me.Chprecio_compra, Me.Chdescuento, Me.ChTotal})
        Me.dtvListado_Productos.Location = New System.Drawing.Point(12, 374)
        Me.dtvListado_Productos.Name = "dtvListado_Productos"
        Me.dtvListado_Productos.Size = New System.Drawing.Size(565, 110)
        Me.dtvListado_Productos.TabIndex = 116
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
        'btnModificar
        '
        Me.btnModificar.Image = Global.Sistema_Autos.My.Resources.Resources.modificar
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(174, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 55)
        Me.btnModificar.TabIndex = 117
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(196, 151)
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(66, 20)
        Me.TxtDni.TabIndex = 93
        '
        'frmNota_Debito_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(638, 560)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.dtvListado_Productos)
        Me.Controls.Add(Me.LblProcetaje)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtidProducto)
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
        Me.Controls.Add(Me.txtPrecio_Unitario)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboUnidad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminarOrden)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.lblCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNota_Debito_Clientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOTA DE DEBITO PARA CLIENTES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtvListado_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnro_documento As System.Windows.Forms.TextBox
    Friend WithEvents txtserie_documento As System.Windows.Forms.TextBox
    Friend WithEvents cbotipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminarOrden As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtKardex As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDevolucion As System.Windows.Forms.RadioButton
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtsaldo_pendiente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar_registro_ventas As System.Windows.Forms.Button
    Friend WithEvents txt_documento As System.Windows.Forms.TextBox
    Friend WithEvents txttipo_documento As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_Unitario As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtigv As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio_neto As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto_descuento As System.Windows.Forms.TextBox
    Friend WithEvents txtPrecio_bruto As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtIdOrden As System.Windows.Forms.TextBox
    Friend WithEvents TxtidProducto As System.Windows.Forms.TextBox
    Friend WithEvents LblProcetaje As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtvListado_Productos As System.Windows.Forms.DataGridView
    Friend WithEvents ChId_Poducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chprecio_compra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chdescuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents chkigv As System.Windows.Forms.CheckBox
    Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtDni As System.Windows.Forms.TextBox
End Class
