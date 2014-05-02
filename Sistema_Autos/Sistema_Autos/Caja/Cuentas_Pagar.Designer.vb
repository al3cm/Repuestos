<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuentas_Pagar
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
        Me.txtfiltro_proveedor = New System.Windows.Forms.TextBox
        Me.btnSalir = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.btnExportar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.chbuscar_fechas = New System.Windows.Forms.CheckBox
        Me.dtpfecha_desde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpfecha_hasta = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.chProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chFecha_Emision = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfiltro_proveedor)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chbuscar_fechas)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_desde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_hasta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 100)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'txtfiltro_proveedor
        '
        Me.txtfiltro_proveedor.Location = New System.Drawing.Point(315, 22)
        Me.txtfiltro_proveedor.Name = "txtfiltro_proveedor"
        Me.txtfiltro_proveedor.Size = New System.Drawing.Size(184, 20)
        Me.txtfiltro_proveedor.TabIndex = 8
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(744, 21)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 51
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Proveedor:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Sistema_Autos.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(667, 21)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 55)
        Me.btnImprimir.TabIndex = 52
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.Sistema_Autos.My.Resources.Resources.consultar
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(505, 21)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 55)
        Me.btnConsultar.TabIndex = 49
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'cboAlmacen
        '
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(68, 19)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(165, 21)
        Me.cboAlmacen.TabIndex = 1
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.Sistema_Autos.My.Resources.Resources.excel
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(586, 21)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 55)
        Me.btnExportar.TabIndex = 50
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.UseVisualStyleBackColor = True
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
        'dtpfecha_desde
        '
        Me.dtpfecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_desde.Location = New System.Drawing.Point(176, 60)
        Me.dtpfecha_desde.Name = "dtpfecha_desde"
        Me.dtpfecha_desde.Size = New System.Drawing.Size(90, 20)
        Me.dtpfecha_desde.TabIndex = 4
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
        'dtpfecha_hasta
        '
        Me.dtpfecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_hasta.Location = New System.Drawing.Point(329, 60)
        Me.dtpfecha_hasta.Name = "dtpfecha_hasta"
        Me.dtpfecha_hasta.Size = New System.Drawing.Size(90, 20)
        Me.dtpfecha_hasta.TabIndex = 5
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.chProveedor, Me.chComprobante, Me.chFecha_Emision, Me.chImporte, Me.chMoneda, Me.chAlmacen})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(828, 287)
        Me.DataGridView1.TabIndex = 55
        '
        'chProveedor
        '
        Me.chProveedor.HeaderText = "Proveedor"
        Me.chProveedor.Name = "chProveedor"
        Me.chProveedor.ReadOnly = True
        Me.chProveedor.Width = 170
        '
        'chComprobante
        '
        Me.chComprobante.HeaderText = "Comprobante"
        Me.chComprobante.Name = "chComprobante"
        Me.chComprobante.ReadOnly = True
        '
        'chFecha_Emision
        '
        Me.chFecha_Emision.HeaderText = "Fecha_Emis"
        Me.chFecha_Emision.Name = "chFecha_Emision"
        Me.chFecha_Emision.ReadOnly = True
        Me.chFecha_Emision.Width = 80
        '
        'chImporte
        '
        Me.chImporte.HeaderText = "Importe"
        Me.chImporte.Name = "chImporte"
        Me.chImporte.ReadOnly = True
        Me.chImporte.Width = 80
        '
        'chMoneda
        '
        Me.chMoneda.HeaderText = "Moneda"
        Me.chMoneda.Name = "chMoneda"
        Me.chMoneda.ReadOnly = True
        Me.chMoneda.Width = 80
        '
        'chAlmacen
        '
        Me.chAlmacen.HeaderText = "Almacén"
        Me.chAlmacen.Name = "chAlmacen"
        Me.chAlmacen.ReadOnly = True
        Me.chAlmacen.Width = 120
        '
        'frmCuentas_Pagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(872, 434)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCuentas_Pagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTAS POR PAGAR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents chbuscar_fechas As System.Windows.Forms.CheckBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtpfecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents chProveedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chComprobante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chFecha_Emision As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
