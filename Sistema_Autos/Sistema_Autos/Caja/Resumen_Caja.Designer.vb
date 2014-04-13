<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumen_Caja
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
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.cboCuenta = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpfecha_hasta = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpfecha_desde = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstListaVentas = New System.Windows.Forms.ListView
        Me.chCuenta = New System.Windows.Forms.ColumnHeader
        Me.chCliente = New System.Windows.Forms.ColumnHeader
        Me.chDocumento = New System.Windows.Forms.ColumnHeader
        Me.chMoneda = New System.Windows.Forms.ColumnHeader
        Me.chMonto = New System.Windows.Forms.ColumnHeader
        Me.chSucursal = New System.Windows.Forms.ColumnHeader
        Me.chFecha = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.cboCuenta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_hasta)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_desde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(748, 83)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(667, 17)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 47
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = Global.Sistema_Autos.My.Resources.Resources.imprimir
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnImprimir.Location = New System.Drawing.Point(590, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 55)
        Me.btnImprimir.TabIndex = 48
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.Sistema_Autos.My.Resources.Resources.excel
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(509, 17)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 55)
        Me.btnExportar.TabIndex = 40
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.Sistema_Autos.My.Resources.Resources.consultar
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(428, 17)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 55)
        Me.btnConsultar.TabIndex = 39
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'cboCuenta
        '
        Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(224, 35)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(198, 21)
        Me.cboCuenta.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cuenta:"
        '
        'dtpfecha_hasta
        '
        Me.dtpfecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_hasta.Location = New System.Drawing.Point(117, 35)
        Me.dtpfecha_hasta.Name = "dtpfecha_hasta"
        Me.dtpfecha_hasta.Size = New System.Drawing.Size(94, 20)
        Me.dtpfecha_hasta.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hasta:"
        '
        'dtpfecha_desde
        '
        Me.dtpfecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_desde.Location = New System.Drawing.Point(7, 35)
        Me.dtpfecha_desde.Name = "dtpfecha_desde"
        Me.dtpfecha_desde.Size = New System.Drawing.Size(94, 20)
        Me.dtpfecha_desde.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'lstListaVentas
        '
        Me.lstListaVentas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCuenta, Me.chCliente, Me.chDocumento, Me.chMoneda, Me.chMonto, Me.chSucursal, Me.chFecha})
        Me.lstListaVentas.FullRowSelect = True
        Me.lstListaVentas.GridLines = True
        Me.lstListaVentas.HideSelection = False
        Me.lstListaVentas.Location = New System.Drawing.Point(5, 94)
        Me.lstListaVentas.Name = "lstListaVentas"
        Me.lstListaVentas.Size = New System.Drawing.Size(748, 320)
        Me.lstListaVentas.TabIndex = 1
        Me.lstListaVentas.UseCompatibleStateImageBehavior = False
        Me.lstListaVentas.View = System.Windows.Forms.View.Details
        '
        'chCuenta
        '
        Me.chCuenta.Text = "Cuenta"
        Me.chCuenta.Width = 130
        '
        'chCliente
        '
        Me.chCliente.Text = "Cliente"
        Me.chCliente.Width = 130
        '
        'chDocumento
        '
        Me.chDocumento.Text = "Documento"
        Me.chDocumento.Width = 90
        '
        'chMoneda
        '
        Me.chMoneda.Text = "Moneda"
        '
        'chMonto
        '
        Me.chMonto.Text = "Monto"
        Me.chMonto.Width = 70
        '
        'chSucursal
        '
        Me.chSucursal.Text = "Sucursal"
        Me.chSucursal.Width = 120
        '
        'chFecha
        '
        Me.chFecha.Text = "Fecha"
        Me.chFecha.Width = 70
        '
        'frmResumen_Caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(761, 438)
        Me.Controls.Add(Me.lstListaVentas)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmResumen_Caja"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RESUMEN DE CAJA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpfecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lstListaVentas As System.Windows.Forms.ListView
    Friend WithEvents chCuenta As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDocumento As System.Windows.Forms.ColumnHeader
    Friend WithEvents chMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents chMonto As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSucursal As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFecha As System.Windows.Forms.ColumnHeader
End Class
