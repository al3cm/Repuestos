<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastos
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
        Me.cbocajas = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpfecha_pago = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txttipo_cambio = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbomoneda = New System.Windows.Forms.ComboBox
        Me.lblnombre = New System.Windows.Forms.Label
        Me.btnbuscar_cliente = New System.Windows.Forms.Button
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.rbProveedor = New System.Windows.Forms.RadioButton
        Me.rbOtros = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtsalida = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtnumero = New System.Windows.Forms.TextBox
        Me.cbotipo_documento = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dgvproceso = New System.Windows.Forms.DataGridView
        Me.chDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chNumero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chDebe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chHaber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chExonerado = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtImporte_total = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.cboForma_pago = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtobservaciones = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboresponsable = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvproceso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caja:"
        '
        'cbocajas
        '
        Me.cbocajas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocajas.FormattingEnabled = True
        Me.cbocajas.Location = New System.Drawing.Point(81, 14)
        Me.cbocajas.Name = "cbocajas"
        Me.cbocajas.Size = New System.Drawing.Size(183, 21)
        Me.cbocajas.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha de Pago:"
        '
        'dtpfecha_pago
        '
        Me.dtpfecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_pago.Location = New System.Drawing.Point(99, 88)
        Me.dtpfecha_pago.Name = "dtpfecha_pago"
        Me.dtpfecha_pago.Size = New System.Drawing.Size(91, 20)
        Me.dtpfecha_pago.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tipo de Cambio:"
        '
        'txttipo_cambio
        '
        Me.txttipo_cambio.Location = New System.Drawing.Point(298, 88)
        Me.txttipo_cambio.Name = "txttipo_cambio"
        Me.txttipo_cambio.Size = New System.Drawing.Size(100, 20)
        Me.txttipo_cambio.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(420, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Moneda:"
        '
        'cbomoneda
        '
        Me.cbomoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbomoneda.FormattingEnabled = True
        Me.cbomoneda.Location = New System.Drawing.Point(475, 87)
        Me.cbomoneda.Name = "cbomoneda"
        Me.cbomoneda.Size = New System.Drawing.Size(121, 21)
        Me.cbomoneda.TabIndex = 12
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Location = New System.Drawing.Point(20, 54)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(59, 13)
        Me.lblnombre.TabIndex = 2
        Me.lblnombre.Text = "Proveedor:"
        '
        'btnbuscar_cliente
        '
        Me.btnbuscar_cliente.Location = New System.Drawing.Point(299, 51)
        Me.btnbuscar_cliente.Name = "btnbuscar_cliente"
        Me.btnbuscar_cliente.Size = New System.Drawing.Size(24, 23)
        Me.btnbuscar_cliente.TabIndex = 4
        Me.btnbuscar_cliente.Text = "..."
        Me.btnbuscar_cliente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(81, 51)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(212, 20)
        Me.txtCliente.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rbProveedor)
        Me.GroupBox1.Controls.Add(Me.txtCliente)
        Me.GroupBox1.Controls.Add(Me.cbomoneda)
        Me.GroupBox1.Controls.Add(Me.rbOtros)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_cliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txttipo_cambio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbocajas)
        Me.GroupBox1.Controls.Add(Me.lblnombre)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_pago)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(524, 17)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 20)
        Me.TextBox1.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(475, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Número:"
        '
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.Checked = True
        Me.rbProveedor.Location = New System.Drawing.Point(381, 52)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(74, 17)
        Me.rbProveedor.TabIndex = 6
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'rbOtros
        '
        Me.rbOtros.AutoSize = True
        Me.rbOtros.Location = New System.Drawing.Point(489, 52)
        Me.rbOtros.Name = "rbOtros"
        Me.rbOtros.Size = New System.Drawing.Size(50, 17)
        Me.rbOtros.TabIndex = 5
        Me.rbOtros.Text = "Otros"
        Me.rbOtros.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtsalida)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtnumero)
        Me.GroupBox2.Controls.Add(Me.cbotipo_documento)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 140)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(609, 57)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(11, 30)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(244, 20)
        Me.TextBox3.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Descripción:"
        '
        'txtsalida
        '
        Me.txtsalida.Location = New System.Drawing.Point(489, 30)
        Me.txtsalida.Name = "txtsalida"
        Me.txtsalida.Size = New System.Drawing.Size(93, 20)
        Me.txtsalida.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(486, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Salida"
        '
        'txtnumero
        '
        Me.txtnumero.Location = New System.Drawing.Point(350, 30)
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Size = New System.Drawing.Size(100, 20)
        Me.txtnumero.TabIndex = 4
        '
        'cbotipo_documento
        '
        Me.cbotipo_documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipo_documento.FormattingEnabled = True
        Me.cbotipo_documento.Location = New System.Drawing.Point(289, 30)
        Me.cbotipo_documento.Name = "cbotipo_documento"
        Me.cbotipo_documento.Size = New System.Drawing.Size(54, 21)
        Me.cbotipo_documento.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(286, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Documento"
        '
        'dgvproceso
        '
        Me.dgvproceso.AllowUserToDeleteRows = False
        Me.dgvproceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproceso.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chDescripcion, Me.chDocumento, Me.chNumero, Me.chDebe, Me.chHaber, Me.chExonerado})
        Me.dgvproceso.Location = New System.Drawing.Point(5, 204)
        Me.dgvproceso.Name = "dgvproceso"
        Me.dgvproceso.ReadOnly = True
        Me.dgvproceso.Size = New System.Drawing.Size(609, 128)
        Me.dgvproceso.TabIndex = 2
        '
        'chDescripcion
        '
        Me.chDescripcion.HeaderText = "Descripcion"
        Me.chDescripcion.Name = "chDescripcion"
        Me.chDescripcion.ReadOnly = True
        Me.chDescripcion.Width = 160
        '
        'chDocumento
        '
        Me.chDocumento.HeaderText = "Doc."
        Me.chDocumento.Name = "chDocumento"
        Me.chDocumento.ReadOnly = True
        Me.chDocumento.Width = 50
        '
        'chNumero
        '
        Me.chNumero.HeaderText = "Número"
        Me.chNumero.Name = "chNumero"
        Me.chNumero.ReadOnly = True
        '
        'chDebe
        '
        Me.chDebe.HeaderText = "Debe"
        Me.chDebe.Name = "chDebe"
        Me.chDebe.ReadOnly = True
        Me.chDebe.Width = 80
        '
        'chHaber
        '
        Me.chHaber.HeaderText = "Haber"
        Me.chHaber.Name = "chHaber"
        Me.chHaber.ReadOnly = True
        Me.chHaber.Width = 80
        '
        'chExonerado
        '
        Me.chExonerado.HeaderText = "Exonerado"
        Me.chExonerado.Name = "chExonerado"
        Me.chExonerado.ReadOnly = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.btnEliminar.Location = New System.Drawing.Point(620, 250)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(46, 39)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Sistema_Autos.My.Resources.Resources.mas
        Me.btnAgregar.Location = New System.Drawing.Point(620, 204)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(46, 40)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(438, 342)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Importe Total:"
        '
        'txtImporte_total
        '
        Me.txtImporte_total.Location = New System.Drawing.Point(514, 337)
        Me.txtImporte_total.Name = "txtImporte_total"
        Me.txtImporte_total.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte_total.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboAlmacen)
        Me.GroupBox3.Controls.Add(Me.cboForma_pago)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtobservaciones)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.cboresponsable)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 360)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(609, 87)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'cboAlmacen
        '
        Me.cboAlmacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(434, 46)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(148, 21)
        Me.cboAlmacen.TabIndex = 7
        '
        'cboForma_pago
        '
        Me.cboForma_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboForma_pago.FormattingEnabled = True
        Me.cboForma_pago.Location = New System.Drawing.Point(434, 14)
        Me.cboForma_pago.Name = "cboForma_pago"
        Me.cboForma_pago.Size = New System.Drawing.Size(148, 21)
        Me.cboForma_pago.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(378, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Almacén:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(347, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(82, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Forma de Pago:"
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Location = New System.Drawing.Point(88, 42)
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Size = New System.Drawing.Size(239, 39)
        Me.txtobservaciones.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Observaciones:"
        '
        'cboresponsable
        '
        Me.cboresponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboresponsable.FormattingEnabled = True
        Me.cboresponsable.Location = New System.Drawing.Point(88, 14)
        Me.cboresponsable.Name = "cboresponsable"
        Me.cboresponsable.Size = New System.Drawing.Size(239, 21)
        Me.cboresponsable.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Responsable:"
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(468, 467)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Image = Global.Sistema_Autos.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(387, 467)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 55)
        Me.btnBuscar.TabIndex = 12
        Me.btnBuscar.Text = "&Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(306, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 55)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Eliminar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Image = Global.Sistema_Autos.My.Resources.Resources.modificar
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(225, 467)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 55)
        Me.btnModificar.TabIndex = 10
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnGrabar.Image = Global.Sistema_Autos.My.Resources.Resources.guardar
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(144, 467)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 55)
        Me.btnGrabar.TabIndex = 9
        Me.btnGrabar.Text = "&Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.Image = Global.Sistema_Autos.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(63, 467)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 55)
        Me.btnNuevo.TabIndex = 8
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'frmGastos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(669, 534)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtImporte_total)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvproceso)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmGastos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GASTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvproceso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbocajas As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_pago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttipo_cambio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbomoneda As System.Windows.Forms.ComboBox
    Friend WithEvents lblnombre As System.Windows.Forms.Label
    Friend WithEvents btnbuscar_cliente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbOtros As System.Windows.Forms.RadioButton
    Friend WithEvents rbProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbotipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents txtnumero As System.Windows.Forms.TextBox
    Friend WithEvents txtsalida As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgvproceso As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtImporte_total As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboresponsable As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtobservaciones As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboForma_pago As System.Windows.Forms.ComboBox
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents chDescripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chDebe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chHaber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chExonerado As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
