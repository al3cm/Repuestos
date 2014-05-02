<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPago_Letras
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnbuscar_cliente = New System.Windows.Forms.Button
        Me.txtcliente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblvendedor = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgvCliente = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chid_almacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChId_Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chInicial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChMoneda1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chLetras = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chOrden_venta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChId_Tipo_Documento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChId_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvPago_cuotas = New System.Windows.Forms.DataGridView
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cboFormaPago = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txttipo_cambio = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboCaja = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtMonto = New System.Windows.Forms.TextBox
        Me.ChLetra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chMonto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chFecha_Venc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chInteres = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chTiempo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chPago = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id_Detalle = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPago_cuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(274, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAGOS DE LETRAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbuscar_cliente)
        Me.GroupBox1.Controls.Add(Me.txtcliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 47)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnbuscar_cliente
        '
        Me.btnbuscar_cliente.Location = New System.Drawing.Point(304, 15)
        Me.btnbuscar_cliente.Name = "btnbuscar_cliente"
        Me.btnbuscar_cliente.Size = New System.Drawing.Size(24, 23)
        Me.btnbuscar_cliente.TabIndex = 9
        Me.btnbuscar_cliente.Text = "..."
        Me.btnbuscar_cliente.UseVisualStyleBackColor = True
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(64, 17)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(234, 20)
        Me.txtcliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 289)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Vendedor:"
        '
        'lblvendedor
        '
        Me.lblvendedor.AutoSize = True
        Me.lblvendedor.Location = New System.Drawing.Point(91, 296)
        Me.lblvendedor.Name = "lblvendedor"
        Me.lblvendedor.Size = New System.Drawing.Size(39, 13)
        Me.lblvendedor.TabIndex = 3
        Me.lblvendedor.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cuotas"
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.chComprobante, Me.chFecha, Me.chImporte, Me.Chid_almacen, Me.ChId_Moneda, Me.chInicial, Me.ChMoneda1, Me.chLetras, Me.chOrden_venta, Me.ChId_Tipo_Documento, Me.ChId_Venta})
        Me.dgvCliente.Location = New System.Drawing.Point(3, 96)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.Size = New System.Drawing.Size(640, 130)
        Me.dgvCliente.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "id_Letra"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'chComprobante
        '
        Me.chComprobante.HeaderText = "Comprobante"
        Me.chComprobante.Name = "chComprobante"
        Me.chComprobante.ReadOnly = True
        '
        'chFecha
        '
        Me.chFecha.HeaderText = "Fecha"
        Me.chFecha.Name = "chFecha"
        Me.chFecha.ReadOnly = True
        Me.chFecha.Width = 80
        '
        'chImporte
        '
        Me.chImporte.HeaderText = "Importe"
        Me.chImporte.Name = "chImporte"
        Me.chImporte.ReadOnly = True
        Me.chImporte.Width = 80
        '
        'Chid_almacen
        '
        Me.Chid_almacen.HeaderText = "id almacen"
        Me.Chid_almacen.Name = "Chid_almacen"
        Me.Chid_almacen.ReadOnly = True
        Me.Chid_almacen.Visible = False
        '
        'ChId_Moneda
        '
        Me.ChId_Moneda.HeaderText = "Id Moneda"
        Me.ChId_Moneda.Name = "ChId_Moneda"
        Me.ChId_Moneda.ReadOnly = True
        Me.ChId_Moneda.Visible = False
        '
        'chInicial
        '
        Me.chInicial.HeaderText = "Inicial"
        Me.chInicial.Name = "chInicial"
        Me.chInicial.ReadOnly = True
        Me.chInicial.Width = 80
        '
        'ChMoneda1
        '
        Me.ChMoneda1.HeaderText = "Moneda"
        Me.ChMoneda1.Name = "ChMoneda1"
        Me.ChMoneda1.ReadOnly = True
        Me.ChMoneda1.Visible = False
        '
        'chLetras
        '
        Me.chLetras.HeaderText = "Letras"
        Me.chLetras.Name = "chLetras"
        Me.chLetras.ReadOnly = True
        Me.chLetras.Width = 70
        '
        'chOrden_venta
        '
        Me.chOrden_venta.HeaderText = "Orden Venta"
        Me.chOrden_venta.Name = "chOrden_venta"
        Me.chOrden_venta.ReadOnly = True
        Me.chOrden_venta.Width = 80
        '
        'ChId_Tipo_Documento
        '
        Me.ChId_Tipo_Documento.HeaderText = "Id Tipo Documento"
        Me.ChId_Tipo_Documento.Name = "ChId_Tipo_Documento"
        Me.ChId_Tipo_Documento.ReadOnly = True
        Me.ChId_Tipo_Documento.Visible = False
        '
        'ChId_Venta
        '
        Me.ChId_Venta.HeaderText = "Id Venta"
        Me.ChId_Venta.Name = "ChId_Venta"
        Me.ChId_Venta.ReadOnly = True
        Me.ChId_Venta.Visible = False
        '
        'dgvPago_cuotas
        '
        Me.dgvPago_cuotas.AllowUserToAddRows = False
        Me.dgvPago_cuotas.AllowUserToDeleteRows = False
        Me.dgvPago_cuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPago_cuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChLetra, Me.chNumero, Me.chMonto, Me.chFecha_Venc, Me.chMoneda, Me.chInteres, Me.chTiempo, Me.chSaldo, Me.chPago, Me.Id, Me.Id_Detalle})
        Me.dgvPago_cuotas.Location = New System.Drawing.Point(3, 246)
        Me.dgvPago_cuotas.Name = "dgvPago_cuotas"
        Me.dgvPago_cuotas.ReadOnly = True
        Me.dgvPago_cuotas.Size = New System.Drawing.Size(640, 162)
        Me.dgvPago_cuotas.TabIndex = 7
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(855, 26)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 36
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Sistema_Autos.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(774, 26)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 55)
        Me.btnBuscar.TabIndex = 35
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = Global.Sistema_Autos.My.Resources.Resources.guardar
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(612, 26)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 55)
        Me.btnGrabar.TabIndex = 34
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Sistema_Autos.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(531, 26)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 55)
        Me.btnNuevo.TabIndex = 33
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboFormaPago)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txttipo_cambio)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboMoneda)
        Me.GroupBox2.Controls.Add(Me.lblvendedor)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cboCaja)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(649, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 321)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'cboFormaPago
        '
        Me.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.Location = New System.Drawing.Point(93, 261)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Size = New System.Drawing.Size(130, 21)
        Me.cboFormaPago.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Forma de Pago:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(93, 127)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(159, 47)
        Me.TextBox2.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Observaciones:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(94, 188)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 188)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Importe:"
        '
        'txttipo_cambio
        '
        Me.txttipo_cambio.Location = New System.Drawing.Point(94, 224)
        Me.txttipo_cambio.Name = "txttipo_cambio"
        Me.txttipo_cambio.Size = New System.Drawing.Size(100, 20)
        Me.txttipo_cambio.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Tipo Cambio:"
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(93, 96)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(121, 21)
        Me.cboMoneda.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Moneda:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(94, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(99, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Fecha:"
        '
        'cboCaja
        '
        Me.cboCaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(93, 61)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(184, 21)
        Me.cboCaja.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Caja:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Sistema_Autos.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(693, 26)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 55)
        Me.btnImprimir.TabIndex = 77
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(347, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 13)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Monto X Dias Atrasado"
        '
        'TxtMonto
        '
        Me.TxtMonto.Location = New System.Drawing.Point(461, 60)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(64, 20)
        Me.TxtMonto.TabIndex = 79
        '
        'ChLetra
        '
        Me.ChLetra.HeaderText = "Letra"
        Me.ChLetra.Name = "ChLetra"
        Me.ChLetra.ReadOnly = True
        '
        'chNumero
        '
        Me.chNumero.HeaderText = "Número"
        Me.chNumero.Name = "chNumero"
        Me.chNumero.ReadOnly = True
        Me.chNumero.Width = 50
        '
        'chMonto
        '
        Me.chMonto.HeaderText = "Monto"
        Me.chMonto.Name = "chMonto"
        Me.chMonto.ReadOnly = True
        Me.chMonto.Width = 70
        '
        'chFecha_Venc
        '
        Me.chFecha_Venc.HeaderText = "Fecha Venc"
        Me.chFecha_Venc.Name = "chFecha_Venc"
        Me.chFecha_Venc.ReadOnly = True
        Me.chFecha_Venc.Width = 80
        '
        'chMoneda
        '
        Me.chMoneda.HeaderText = "Moneda"
        Me.chMoneda.Name = "chMoneda"
        Me.chMoneda.ReadOnly = True
        Me.chMoneda.Width = 70
        '
        'chInteres
        '
        Me.chInteres.HeaderText = "Interes"
        Me.chInteres.Name = "chInteres"
        Me.chInteres.ReadOnly = True
        Me.chInteres.Width = 50
        '
        'chTiempo
        '
        Me.chTiempo.HeaderText = "Tiempo"
        Me.chTiempo.Name = "chTiempo"
        Me.chTiempo.ReadOnly = True
        Me.chTiempo.Width = 50
        '
        'chSaldo
        '
        Me.chSaldo.HeaderText = "Saldo"
        Me.chSaldo.Name = "chSaldo"
        Me.chSaldo.ReadOnly = True
        Me.chSaldo.Width = 50
        '
        'chPago
        '
        Me.chPago.HeaderText = "Pago"
        Me.chPago.Name = "chPago"
        Me.chPago.ReadOnly = True
        Me.chPago.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.chPago.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.chPago.Width = 50
        '
        'Id
        '
        Me.Id.HeaderText = "Id_Letras"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Id_Detalle
        '
        Me.Id_Detalle.HeaderText = "Id_Detalle"
        Me.Id_Detalle.Name = "Id_Detalle"
        Me.Id_Detalle.ReadOnly = True
        Me.Id_Detalle.Visible = False
        '
        'frmPago_Letras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(967, 417)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.dgvPago_cuotas)
        Me.Controls.Add(Me.dgvCliente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPago_Letras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGO DE LETRAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPago_cuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents btnbuscar_cliente As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblvendedor As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPago_cuotas As System.Windows.Forms.DataGridView
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txttipo_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chid_almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChId_Moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChMoneda1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chLetras As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chOrden_venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChId_Tipo_Documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChId_Venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChLetra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chMonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chFecha_Venc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chInteres As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chTiempo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chSaldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chPago As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id_Detalle As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
