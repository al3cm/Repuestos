﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNota_Credito_Proveedor
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
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtnro_documento = New System.Windows.Forms.TextBox
        Me.txtserie_documento = New System.Windows.Forms.TextBox
        Me.cbotipo_comprobante = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtKardex = New System.Windows.Forms.RadioButton
        Me.rbtDevolucion = New System.Windows.Forms.RadioButton
        Me.txtsaldo_pendiente = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpfecha_comprobante = New System.Windows.Forms.DateTimePicker
        Me.TxtIdOrden = New System.Windows.Forms.TextBox
        Me.cboMotivo = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpfecha_emision = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkigv = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnbuscar_registro_ventas = New System.Windows.Forms.Button
        Me.txt_documento = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtproveedor = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblProcetaje = New System.Windows.Forms.Label
        Me.txtDescuento = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtPrecio_Unitario = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboUnidad = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtProducto = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
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
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnEliminarOrden = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.dtvListado_Productos = New System.Windows.Forms.DataGridView
        Me.ChId_Poducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chprecio_compra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chdescuento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TxtidProducto = New System.Windows.Forms.TextBox
        Me.TxtRuc = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dtvListado_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(495, 19)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(82, 13)
        Me.lblCodigo.TabIndex = 58
        Me.lblCodigo.Text = "Codigo_Compra"
        Me.lblCodigo.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtnro_documento)
        Me.GroupBox1.Controls.Add(Me.txtserie_documento)
        Me.GroupBox1.Controls.Add(Me.cbotipo_comprobante)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(336, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 72)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        '
        'txtnro_documento
        '
        Me.txtnro_documento.Location = New System.Drawing.Point(140, 40)
        Me.txtnro_documento.MaxLength = 3
        Me.txtnro_documento.Name = "txtnro_documento"
        Me.txtnro_documento.Size = New System.Drawing.Size(43, 20)
        Me.txtnro_documento.TabIndex = 56
        '
        'txtserie_documento
        '
        Me.txtserie_documento.Location = New System.Drawing.Point(189, 40)
        Me.txtserie_documento.MaxLength = 7
        Me.txtserie_documento.Name = "txtserie_documento"
        Me.txtserie_documento.Size = New System.Drawing.Size(108, 20)
        Me.txtserie_documento.TabIndex = 55
        '
        'cbotipo_comprobante
        '
        Me.cbotipo_comprobante.FormattingEnabled = True
        Me.cbotipo_comprobante.Location = New System.Drawing.Point(17, 39)
        Me.cbotipo_comprobante.Name = "cbotipo_comprobante"
        Me.cbotipo_comprobante.Size = New System.Drawing.Size(117, 21)
        Me.cbotipo_comprobante.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "COMPROBANTE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtRuc)
        Me.GroupBox2.Controls.Add(Me.rbtKardex)
        Me.GroupBox2.Controls.Add(Me.rbtDevolucion)
        Me.GroupBox2.Controls.Add(Me.txtsaldo_pendiente)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtpfecha_comprobante)
        Me.GroupBox2.Controls.Add(Me.TxtIdOrden)
        Me.GroupBox2.Controls.Add(Me.cboMotivo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cboAlmacen)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtobservaciones)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dtpfecha_emision)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.chkigv)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnbuscar_registro_ventas)
        Me.GroupBox2.Controls.Add(Me.txt_documento)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboMoneda)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtproveedor)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(636, 222)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        '
        'rbtKardex
        '
        Me.rbtKardex.AutoSize = True
        Me.rbtKardex.Location = New System.Drawing.Point(484, 26)
        Me.rbtKardex.Name = "rbtKardex"
        Me.rbtKardex.Size = New System.Drawing.Size(123, 17)
        Me.rbtKardex.TabIndex = 84
        Me.rbtKardex.TabStop = True
        Me.rbtKardex.Text = "No Afecta al Kardex:"
        Me.rbtKardex.UseVisualStyleBackColor = True
        '
        'rbtDevolucion
        '
        Me.rbtDevolucion.AutoSize = True
        Me.rbtDevolucion.Location = New System.Drawing.Point(485, 49)
        Me.rbtDevolucion.Name = "rbtDevolucion"
        Me.rbtDevolucion.Size = New System.Drawing.Size(79, 17)
        Me.rbtDevolucion.TabIndex = 83
        Me.rbtDevolucion.TabStop = True
        Me.rbtDevolucion.Text = "Devolución"
        Me.rbtDevolucion.UseVisualStyleBackColor = True
        '
        'txtsaldo_pendiente
        '
        Me.txtsaldo_pendiente.Location = New System.Drawing.Point(279, 94)
        Me.txtsaldo_pendiente.Name = "txtsaldo_pendiente"
        Me.txtsaldo_pendiente.Size = New System.Drawing.Size(100, 20)
        Me.txtsaldo_pendiente.TabIndex = 82
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(191, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Saldo Pendiente:"
        '
        'dtpfecha_comprobante
        '
        Me.dtpfecha_comprobante.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_comprobante.Location = New System.Drawing.Point(265, 127)
        Me.dtpfecha_comprobante.Name = "dtpfecha_comprobante"
        Me.dtpfecha_comprobante.Size = New System.Drawing.Size(92, 20)
        Me.dtpfecha_comprobante.TabIndex = 80
        '
        'TxtIdOrden
        '
        Me.TxtIdOrden.Location = New System.Drawing.Point(386, 53)
        Me.TxtIdOrden.Name = "TxtIdOrden"
        Me.TxtIdOrden.Size = New System.Drawing.Size(66, 20)
        Me.TxtIdOrden.TabIndex = 79
        '
        'cboMotivo
        '
        Me.cboMotivo.FormattingEnabled = True
        Me.cboMotivo.Location = New System.Drawing.Point(486, 89)
        Me.cboMotivo.Name = "cboMotivo"
        Me.cboMotivo.Size = New System.Drawing.Size(121, 21)
        Me.cboMotivo.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(385, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Motivo de Traslado:"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(486, 130)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(121, 21)
        Me.cboAlmacen.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(383, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Enviar a Almcén de:"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(90, 164)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(517, 41)
        Me.txtobservaciones.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Observaciones:"
        '
        'dtpfecha_emision
        '
        Me.dtpfecha_emision.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_emision.Location = New System.Drawing.Point(282, 55)
        Me.dtpfecha_emision.Name = "dtpfecha_emision"
        Me.dtpfecha_emision.Size = New System.Drawing.Size(92, 20)
        Me.dtpfecha_emision.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(200, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Fecha Emisión:"
        '
        'chkigv
        '
        Me.chkigv.AutoSize = True
        Me.chkigv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkigv.Checked = True
        Me.chkigv.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkigv.Location = New System.Drawing.Point(25, 132)
        Me.chkigv.Name = "chkigv"
        Me.chkigv.Size = New System.Drawing.Size(84, 17)
        Me.chkigv.TabIndex = 13
        Me.chkigv.Text = "Incluye IGV:"
        Me.chkigv.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(134, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Fecha Compra:"
        '
        'btnbuscar_registro_ventas
        '
        Me.btnbuscar_registro_ventas.Location = New System.Drawing.Point(335, 20)
        Me.btnbuscar_registro_ventas.Name = "btnbuscar_registro_ventas"
        Me.btnbuscar_registro_ventas.Size = New System.Drawing.Size(30, 23)
        Me.btnbuscar_registro_ventas.TabIndex = 8
        Me.btnbuscar_registro_ventas.Text = "..."
        Me.btnbuscar_registro_ventas.UseVisualStyleBackColor = True
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(71, 54)
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(118, 20)
        Me.txt_documento.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Documento:"
        '
        'cboMoneda
        '
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(71, 90)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(118, 21)
        Me.cboMoneda.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Moneda:"
        '
        'txtproveedor
        '
        Me.txtproveedor.Location = New System.Drawing.Point(66, 22)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(263, 20)
        Me.txtproveedor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Proveedor:"
        '
        'LblProcetaje
        '
        Me.LblProcetaje.AutoSize = True
        Me.LblProcetaje.Location = New System.Drawing.Point(552, 391)
        Me.LblProcetaje.Name = "LblProcetaje"
        Me.LblProcetaje.Size = New System.Drawing.Size(15, 13)
        Me.LblProcetaje.TabIndex = 90
        Me.LblProcetaje.Text = "%"
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(501, 388)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(48, 20)
        Me.txtDescuento.TabIndex = 87
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(498, 370)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "Descto:"
        '
        'txtPrecio_Unitario
        '
        Me.txtPrecio_Unitario.Location = New System.Drawing.Point(428, 388)
        Me.txtPrecio_Unitario.Name = "txtPrecio_Unitario"
        Me.txtPrecio_Unitario.Size = New System.Drawing.Size(67, 20)
        Me.txtPrecio_Unitario.TabIndex = 85
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(425, 370)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Precio Unit:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(373, 388)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(44, 20)
        Me.txtCantidad.TabIndex = 83
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(367, 370)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Cantidad:"
        '
        'cboUnidad
        '
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Location = New System.Drawing.Point(280, 387)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(87, 21)
        Me.cboUnidad.TabIndex = 81
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(277, 371)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Unidad:"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(12, 388)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(262, 20)
        Me.txtProducto.TabIndex = 78
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 372)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 77
        Me.Label15.Text = "Producto:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(531, 542)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(65, 20)
        Me.TxtTotal.TabIndex = 108
        '
        'txtigv
        '
        Me.txtigv.Location = New System.Drawing.Point(466, 542)
        Me.txtigv.Name = "txtigv"
        Me.txtigv.Size = New System.Drawing.Size(55, 20)
        Me.txtigv.TabIndex = 106
        '
        'txtPrecio_neto
        '
        Me.txtPrecio_neto.Location = New System.Drawing.Point(379, 542)
        Me.txtPrecio_neto.Name = "txtPrecio_neto"
        Me.txtPrecio_neto.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio_neto.TabIndex = 104
        '
        'txtMonto_descuento
        '
        Me.txtMonto_descuento.Location = New System.Drawing.Point(286, 542)
        Me.txtMonto_descuento.Name = "txtMonto_descuento"
        Me.txtMonto_descuento.Size = New System.Drawing.Size(68, 20)
        Me.txtMonto_descuento.TabIndex = 102
        '
        'txtPrecio_bruto
        '
        Me.txtPrecio_bruto.Location = New System.Drawing.Point(188, 542)
        Me.txtPrecio_bruto.Name = "txtPrecio_bruto"
        Me.txtPrecio_bruto.Size = New System.Drawing.Size(68, 20)
        Me.txtPrecio_bruto.TabIndex = 100
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(539, 526)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 13)
        Me.Label18.TabIndex = 107
        Me.Label18.Text = "TOTAL"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(477, 526)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "IGV"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(369, 526)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 13)
        Me.Label19.TabIndex = 103
        Me.Label19.Text = "PRECIO NETO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(280, 526)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 13)
        Me.Label21.TabIndex = 101
        Me.Label21.Text = "DESCUENTO"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(171, 526)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(100, 13)
        Me.Label22.TabIndex = 99
        Me.Label22.Text = "PRECIO BRUTO"
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(602, 459)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(46, 39)
        Me.btnEliminar.TabIndex = 93
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Sistema_Autos.My.Resources.Resources.mas
        Me.btnAgregar.Location = New System.Drawing.Point(602, 413)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(46, 40)
        Me.btnAgregar.TabIndex = 92
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Sistema_Autos.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(417, 5)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 55)
        Me.btnImprimir.TabIndex = 59
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(498, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 52
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Sistema_Autos.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(336, 5)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 55)
        Me.btnBuscar.TabIndex = 57
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminarOrden
        '
        Me.btnEliminarOrden.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.btnEliminarOrden.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminarOrden.Location = New System.Drawing.Point(255, 5)
        Me.btnEliminarOrden.Name = "btnEliminarOrden"
        Me.btnEliminarOrden.Size = New System.Drawing.Size(75, 55)
        Me.btnEliminarOrden.TabIndex = 56
        Me.btnEliminarOrden.Text = "Eliminar"
        Me.btnEliminarOrden.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarOrden.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = Global.Sistema_Autos.My.Resources.Resources.modificar
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(174, 5)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 55)
        Me.btnModificar.TabIndex = 55
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = Global.Sistema_Autos.My.Resources.Resources.guardar
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(93, 5)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 55)
        Me.btnGrabar.TabIndex = 54
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Sistema_Autos.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(12, 5)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 55)
        Me.btnNuevo.TabIndex = 53
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'dtvListado_Productos
        '
        Me.dtvListado_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvListado_Productos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChId_Poducto, Me.ChProducto, Me.ChCantidad, Me.ChUnidad, Me.Chprecio_compra, Me.Chdescuento, Me.ChTotal})
        Me.dtvListado_Productos.Location = New System.Drawing.Point(12, 415)
        Me.dtvListado_Productos.Name = "dtvListado_Productos"
        Me.dtvListado_Productos.Size = New System.Drawing.Size(574, 99)
        Me.dtvListado_Productos.TabIndex = 109
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
        Me.TxtidProducto.Location = New System.Drawing.Point(573, 387)
        Me.TxtidProducto.Name = "TxtidProducto"
        Me.TxtidProducto.Size = New System.Drawing.Size(48, 20)
        Me.TxtidProducto.TabIndex = 110
        '
        'TxtRuc
        '
        Me.TxtRuc.Location = New System.Drawing.Point(382, 23)
        Me.TxtRuc.Name = "TxtRuc"
        Me.TxtRuc.Size = New System.Drawing.Size(66, 20)
        Me.TxtRuc.TabIndex = 95
        '
        'frmNota_Credito_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(665, 574)
        Me.Controls.Add(Me.TxtidProducto)
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
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.LblProcetaje)
        Me.Controls.Add(Me.txtDescuento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtPrecio_Unitario)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboUnidad)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
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
        Me.Name = "frmNota_Credito_Proveedor"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOTA DE CREDITO PROVEEDOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dtvListado_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminarOrden As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtnro_documento As System.Windows.Forms.TextBox
    Friend WithEvents txtserie_documento As System.Windows.Forms.TextBox
    Friend WithEvents cbotipo_comprobante As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_emision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkigv As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar_registro_ventas As System.Windows.Forms.Button
    Friend WithEvents txt_documento As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtproveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboMotivo As System.Windows.Forms.ComboBox
    Friend WithEvents LblProcetaje As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_Unitario As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
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
    Friend WithEvents TxtidProducto As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdOrden As System.Windows.Forms.TextBox
    Friend WithEvents dtpfecha_comprobante As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtsaldo_pendiente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbtKardex As System.Windows.Forms.RadioButton
    Friend WithEvents rbtDevolucion As System.Windows.Forms.RadioButton
    Friend WithEvents TxtRuc As System.Windows.Forms.TextBox
End Class
