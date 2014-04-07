<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCanje_Letras
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnbuscar_cliente = New System.Windows.Forms.Button
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboVendedor = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtnro_canje = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtpFecha_Canje = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtvCuentasxcobrar = New System.Windows.Forms.DataGridView
        Me.chComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chFecha_Emision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chSaldo_Pendiente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dgvDoc_canjeados = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dudias_inicial = New System.Windows.Forms.DomainUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.dddias_final = New System.Windows.Forms.DomainUpDown
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtcuotas = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.btnProcesar = New System.Windows.Forms.Button
        Me.chdias = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chFecha_vencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chMonto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chLetra = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnEliminarOrden = New System.Windows.Forms.Button
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnDerecha = New System.Windows.Forms.Button
        Me.btnIzquierda = New System.Windows.Forms.Button
        CType(Me.dtvCuentasxcobrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDoc_canjeados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CANJE DE LETRAS POR COBRAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cliente:"
        '
        'btnbuscar_cliente
        '
        Me.btnbuscar_cliente.Location = New System.Drawing.Point(331, 73)
        Me.btnbuscar_cliente.Name = "btnbuscar_cliente"
        Me.btnbuscar_cliente.Size = New System.Drawing.Size(24, 23)
        Me.btnbuscar_cliente.TabIndex = 10
        Me.btnbuscar_cliente.Text = "..."
        Me.btnbuscar_cliente.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(67, 74)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(258, 20)
        Me.txtCliente.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Vendedor:"
        '
        'cboVendedor
        '
        Me.cboVendedor.FormattingEnabled = True
        Me.cboVendedor.Location = New System.Drawing.Point(454, 75)
        Me.cboVendedor.Name = "cboVendedor"
        Me.cboVendedor.Size = New System.Drawing.Size(217, 21)
        Me.cboVendedor.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(461, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Nro. Canje:"
        '
        'txtnro_canje
        '
        Me.txtnro_canje.Location = New System.Drawing.Point(527, 109)
        Me.txtnro_canje.Name = "txtnro_canje"
        Me.txtnro_canje.Size = New System.Drawing.Size(141, 20)
        Me.txtnro_canje.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Fecha Canje:"
        '
        'dtpFecha_Canje
        '
        Me.dtpFecha_Canje.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha_Canje.Location = New System.Drawing.Point(94, 107)
        Me.dtpFecha_Canje.Name = "dtpFecha_Canje"
        Me.dtpFecha_Canje.Size = New System.Drawing.Size(92, 20)
        Me.dtpFecha_Canje.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(467, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Documentos por Canjear:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Cuentas por Cobrar:"
        '
        'dtvCuentasxcobrar
        '
        Me.dtvCuentasxcobrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvCuentasxcobrar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chComprobante, Me.chFecha_Emision, Me.chSaldo_Pendiente, Me.chMoneda})
        Me.dtvCuentasxcobrar.Location = New System.Drawing.Point(15, 172)
        Me.dtvCuentasxcobrar.Name = "dtvCuentasxcobrar"
        Me.dtvCuentasxcobrar.Size = New System.Drawing.Size(393, 163)
        Me.dtvCuentasxcobrar.TabIndex = 75
        '
        'chComprobante
        '
        Me.chComprobante.HeaderText = "Comprobante"
        Me.chComprobante.Name = "chComprobante"
        Me.chComprobante.Width = 90
        '
        'chFecha_Emision
        '
        Me.chFecha_Emision.HeaderText = "Fch Emisión"
        Me.chFecha_Emision.Name = "chFecha_Emision"
        '
        'chSaldo_Pendiente
        '
        Me.chSaldo_Pendiente.HeaderText = "Saldo Pend."
        Me.chSaldo_Pendiente.Name = "chSaldo_Pendiente"
        Me.chSaldo_Pendiente.Width = 80
        '
        'chMoneda
        '
        Me.chMoneda.HeaderText = "Moneda"
        Me.chMoneda.Name = "chMoneda"
        Me.chMoneda.Width = 80
        '
        'dgvDoc_canjeados
        '
        Me.dgvDoc_canjeados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDoc_canjeados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.chImporte})
        Me.dgvDoc_canjeados.Location = New System.Drawing.Point(470, 172)
        Me.dgvDoc_canjeados.Name = "dgvDoc_canjeados"
        Me.dgvDoc_canjeados.Size = New System.Drawing.Size(393, 163)
        Me.dgvDoc_canjeados.TabIndex = 76
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "NroComprob."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Saldo Pend."
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Moneda"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'chImporte
        '
        Me.chImporte.HeaderText = "Importe"
        Me.chImporte.Name = "chImporte"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(788, 341)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 77
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chdias, Me.chFecha_vencimiento, Me.chMonto, Me.chLetra})
        Me.DataGridView1.Location = New System.Drawing.Point(215, 434)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(453, 121)
        Me.DataGridView1.TabIndex = 78
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnProcesar)
        Me.GroupBox1.Controls.Add(Me.txtMonto)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtcuotas)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.dddias_final)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dudias_inicial)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(215, 343)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 85)
        Me.GroupBox1.TabIndex = 79
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Inicial:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(70, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Días:"
        '
        'dudias_inicial
        '
        Me.dudias_inicial.Location = New System.Drawing.Point(110, 20)
        Me.dudias_inicial.Name = "dudias_inicial"
        Me.dudias_inicial.Size = New System.Drawing.Size(66, 20)
        Me.dudias_inicial.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Letras:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(70, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Días:"
        '
        'dddias_final
        '
        Me.dddias_final.Location = New System.Drawing.Point(110, 48)
        Me.dddias_final.Name = "dddias_final"
        Me.dddias_final.Size = New System.Drawing.Size(66, 20)
        Me.dddias_final.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(202, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Cuotas:"
        '
        'txtcuotas
        '
        Me.txtcuotas.Location = New System.Drawing.Point(251, 20)
        Me.txtcuotas.Name = "txtcuotas"
        Me.txtcuotas.Size = New System.Drawing.Size(67, 20)
        Me.txtcuotas.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(205, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Monto:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(250, 52)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(68, 20)
        Me.txtMonto.TabIndex = 9
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(351, 36)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(75, 23)
        Me.btnProcesar.TabIndex = 80
        Me.btnProcesar.Text = "PROCESAR"
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'chdias
        '
        Me.chdias.HeaderText = "Dias"
        Me.chdias.Name = "chdias"
        '
        'chFecha_vencimiento
        '
        Me.chFecha_vencimiento.HeaderText = "Fecha Venc."
        Me.chFecha_vencimiento.Name = "chFecha_vencimiento"
        '
        'chMonto
        '
        Me.chMonto.HeaderText = "Monto"
        Me.chMonto.Name = "chMonto"
        '
        'chLetra
        '
        Me.chLetra.HeaderText = "Letra"
        Me.chLetra.Name = "chLetra"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(212, 112)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Moneda:"
        '
        'cboMoneda
        '
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(267, 108)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(121, 21)
        Me.cboMoneda.TabIndex = 81
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = Global.Sistema_Autos.My.Resources.Resources.nuevo
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(469, 9)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 55)
        Me.btnNuevo.TabIndex = 86
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(793, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 83
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Sistema_Autos.My.Resources.Resources.buscar
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBuscar.Location = New System.Drawing.Point(712, 9)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 55)
        Me.btnBuscar.TabIndex = 85
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminarOrden
        '
        Me.btnEliminarOrden.Image = Global.Sistema_Autos.My.Resources.Resources.eliminar
        Me.btnEliminarOrden.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminarOrden.Location = New System.Drawing.Point(631, 9)
        Me.btnEliminarOrden.Name = "btnEliminarOrden"
        Me.btnEliminarOrden.Size = New System.Drawing.Size(75, 55)
        Me.btnEliminarOrden.TabIndex = 84
        Me.btnEliminarOrden.Text = "Eliminar"
        Me.btnEliminarOrden.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminarOrden.UseVisualStyleBackColor = True
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = Global.Sistema_Autos.My.Resources.Resources.guardar
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(550, 9)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 55)
        Me.btnGrabar.TabIndex = 82
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnDerecha
        '
        Me.btnDerecha.Image = Global.Sistema_Autos.My.Resources.Resources.derecha
        Me.btnDerecha.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnDerecha.Location = New System.Drawing.Point(414, 213)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(50, 40)
        Me.btnDerecha.TabIndex = 74
        Me.btnDerecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDerecha.UseVisualStyleBackColor = True
        '
        'btnIzquierda
        '
        Me.btnIzquierda.Image = Global.Sistema_Autos.My.Resources.Resources.izquierda
        Me.btnIzquierda.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIzquierda.Location = New System.Drawing.Point(414, 259)
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(50, 40)
        Me.btnIzquierda.TabIndex = 73
        Me.btnIzquierda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIzquierda.UseVisualStyleBackColor = True
        '
        'frmCanje_Letras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(880, 578)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminarOrden)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.cboMoneda)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dgvDoc_canjeados)
        Me.Controls.Add(Me.dtvCuentasxcobrar)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.btnIzquierda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFecha_Canje)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtnro_canje)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboVendedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnbuscar_cliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCanje_Letras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CANJE DE LETRAS POR COBRAR"
        CType(Me.dtvCuentasxcobrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDoc_canjeados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar_cliente As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboVendedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnro_canje As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha_Canje As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDerecha As System.Windows.Forms.Button
    Friend WithEvents btnIzquierda As System.Windows.Forms.Button
    Friend WithEvents dtvCuentasxcobrar As System.Windows.Forms.DataGridView
    Friend WithEvents chComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chFecha_Emision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chSaldo_Pendiente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvDoc_canjeados As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dudias_inicial As System.Windows.Forms.DomainUpDown
    Friend WithEvents dddias_final As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents chdias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chFecha_vencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chMonto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chLetra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnEliminarOrden As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
End Class
