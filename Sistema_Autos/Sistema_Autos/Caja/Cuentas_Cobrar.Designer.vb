<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentas_Cobrar
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
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpfecha_desde = New System.Windows.Forms.DateTimePicker
        Me.dtpfecha_hasta = New System.Windows.Forms.DateTimePicker
        Me.chbuscar_fechas = New System.Windows.Forms.CheckBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtfiltro_cliente = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.chCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chFechaEmision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chDiasTranscurridos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chFechaVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chDias_atraso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Almacén:"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(68, 19)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(167, 21)
        Me.cboAlmacen.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(287, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hasta:"
        '
        'dtpfecha_desde
        '
        Me.dtpfecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_desde.Location = New System.Drawing.Point(176, 60)
        Me.dtpfecha_desde.Name = "dtpfecha_desde"
        Me.dtpfecha_desde.Size = New System.Drawing.Size(90, 20)
        Me.dtpfecha_desde.TabIndex = 4
        '
        'dtpfecha_hasta
        '
        Me.dtpfecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_hasta.Location = New System.Drawing.Point(329, 60)
        Me.dtpfecha_hasta.Name = "dtpfecha_hasta"
        Me.dtpfecha_hasta.Size = New System.Drawing.Size(90, 20)
        Me.dtpfecha_hasta.TabIndex = 5
        '
        'chbuscar_fechas
        '
        Me.chbuscar_fechas.AutoSize = True
        Me.chbuscar_fechas.Location = New System.Drawing.Point(14, 62)
        Me.chbuscar_fechas.Name = "chbuscar_fechas"
        Me.chbuscar_fechas.Size = New System.Drawing.Size(115, 17)
        Me.chbuscar_fechas.TabIndex = 6
        Me.chbuscar_fechas.Text = "Buscar por Fechas"
        Me.chbuscar_fechas.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(773, 22)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 51
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Sistema_Autos.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(696, 22)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 55)
        Me.btnImprimir.TabIndex = 52
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.Sistema_Autos.My.Resources.Resources.excel
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(615, 22)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 55)
        Me.btnExportar.TabIndex = 50
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.Sistema_Autos.My.Resources.Resources.consultar
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(534, 22)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 55)
        Me.btnConsultar.TabIndex = 49
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfiltro_cliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.chbuscar_fechas)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_desde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_hasta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(864, 100)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'txtfiltro_cliente
        '
        Me.txtfiltro_cliente.Location = New System.Drawing.Point(300, 19)
        Me.txtfiltro_cliente.Name = "txtfiltro_cliente"
        Me.txtfiltro_cliente.Size = New System.Drawing.Size(203, 20)
        Me.txtfiltro_cliente.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Cliente:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chCliente, Me.chComprobante, Me.chFechaEmision, Me.chDiasTranscurridos, Me.chFechaVencimiento, Me.chDias_atraso, Me.chImporte, Me.chMoneda, Me.chVendedor, Me.chDireccion})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(864, 272)
        Me.DataGridView1.TabIndex = 54
        '
        'chCliente
        '
        Me.chCliente.HeaderText = "Cliente"
        Me.chCliente.Name = "chCliente"
        Me.chCliente.ReadOnly = True
        Me.chCliente.Width = 140
        '
        'chComprobante
        '
        Me.chComprobante.HeaderText = "Comprobante"
        Me.chComprobante.Name = "chComprobante"
        Me.chComprobante.ReadOnly = True
        Me.chComprobante.Width = 80
        '
        'chFechaEmision
        '
        Me.chFechaEmision.HeaderText = "Fecha_Emis"
        Me.chFechaEmision.Name = "chFechaEmision"
        Me.chFechaEmision.ReadOnly = True
        Me.chFechaEmision.Width = 80
        '
        'chDiasTranscurridos
        '
        Me.chDiasTranscurridos.HeaderText = "Dias_Trans"
        Me.chDiasTranscurridos.Name = "chDiasTranscurridos"
        Me.chDiasTranscurridos.ReadOnly = True
        Me.chDiasTranscurridos.Width = 70
        '
        'chFechaVencimiento
        '
        Me.chFechaVencimiento.HeaderText = "Fecha_Venc"
        Me.chFechaVencimiento.Name = "chFechaVencimiento"
        Me.chFechaVencimiento.ReadOnly = True
        Me.chFechaVencimiento.Width = 80
        '
        'chDias_atraso
        '
        Me.chDias_atraso.HeaderText = "Dias_atraso"
        Me.chDias_atraso.Name = "chDias_atraso"
        Me.chDias_atraso.ReadOnly = True
        Me.chDias_atraso.Width = 70
        '
        'chImporte
        '
        Me.chImporte.HeaderText = "Importe"
        Me.chImporte.Name = "chImporte"
        Me.chImporte.ReadOnly = True
        Me.chImporte.Width = 70
        '
        'chMoneda
        '
        Me.chMoneda.HeaderText = "Moneda"
        Me.chMoneda.Name = "chMoneda"
        Me.chMoneda.ReadOnly = True
        Me.chMoneda.Width = 70
        '
        'chVendedor
        '
        Me.chVendedor.HeaderText = "Vendedor"
        Me.chVendedor.Name = "chVendedor"
        Me.chVendedor.ReadOnly = True
        Me.chVendedor.Width = 140
        '
        'chDireccion
        '
        Me.chDireccion.HeaderText = "Dirección"
        Me.chDireccion.Name = "chDireccion"
        Me.chDireccion.ReadOnly = True
        Me.chDireccion.Width = 150
        '
        'frmCuentas_Cobrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(889, 431)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCuentas_Cobrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTAS POR COBRAR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents chbuscar_fechas As System.Windows.Forms.CheckBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents chCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chFechaEmision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chDiasTranscurridos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chFechaVencimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chDias_atraso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chVendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro_cliente As System.Windows.Forms.TextBox
End Class
