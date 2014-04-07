<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovimiento_Kardex
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
        Me.dtpfecha_desde = New System.Windows.Forms.DateTimePicker
        Me.dtpfecha_hasta = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFiltro_producto = New System.Windows.Forms.TextBox
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.lstProducto = New System.Windows.Forms.ListView
        Me.chProducto = New System.Windows.Forms.ColumnHeader
        Me.chUnidad = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstMovimientos = New System.Windows.Forms.ListView
        Me.chFecha = New System.Windows.Forms.ColumnHeader
        Me.chMotivo = New System.Windows.Forms.ColumnHeader
        Me.chDocumento = New System.Windows.Forms.ColumnHeader
        Me.chPersona = New System.Windows.Forms.ColumnHeader
        Me.chStockInicial = New System.Windows.Forms.ColumnHeader
        Me.chCantidad_ingreso = New System.Windows.Forms.ColumnHeader
        Me.chCantidad_Salida = New System.Windows.Forms.ColumnHeader
        Me.chStock_Final = New System.Windows.Forms.ColumnHeader
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtStock_Final = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasta:"
        '
        'dtpfecha_desde
        '
        Me.dtpfecha_desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_desde.Location = New System.Drawing.Point(62, 19)
        Me.dtpfecha_desde.Name = "dtpfecha_desde"
        Me.dtpfecha_desde.Size = New System.Drawing.Size(85, 20)
        Me.dtpfecha_desde.TabIndex = 2
        '
        'dtpfecha_hasta
        '
        Me.dtpfecha_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_hasta.Location = New System.Drawing.Point(207, 19)
        Me.dtpfecha_hasta.Name = "dtpfecha_hasta"
        Me.dtpfecha_hasta.Size = New System.Drawing.Size(85, 20)
        Me.dtpfecha_hasta.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Almacén:"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(62, 58)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(230, 21)
        Me.cboAlmacen.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(315, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Filtro:"
        '
        'txtFiltro_producto
        '
        Me.txtFiltro_producto.Location = New System.Drawing.Point(353, 58)
        Me.txtFiltro_producto.Name = "txtFiltro_producto"
        Me.txtFiltro_producto.Size = New System.Drawing.Size(208, 20)
        Me.txtFiltro_producto.TabIndex = 7
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.Sistema_Autos.My.Resources.Resources.consultar
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnConsultar.Location = New System.Drawing.Point(582, 35)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 55)
        Me.btnConsultar.TabIndex = 52
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(759, 18)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 51
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.Sistema_Autos.My.Resources.Resources.excel
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(682, 18)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 55)
        Me.btnExportar.TabIndex = 50
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'lstProducto
        '
        Me.lstProducto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chProducto, Me.chUnidad})
        Me.lstProducto.FullRowSelect = True
        Me.lstProducto.GridLines = True
        Me.lstProducto.HideSelection = False
        Me.lstProducto.Location = New System.Drawing.Point(13, 116)
        Me.lstProducto.Name = "lstProducto"
        Me.lstProducto.Size = New System.Drawing.Size(280, 238)
        Me.lstProducto.TabIndex = 53
        Me.lstProducto.UseCompatibleStateImageBehavior = False
        Me.lstProducto.View = System.Windows.Forms.View.Details
        '
        'chProducto
        '
        Me.chProducto.Text = "Producto"
        Me.chProducto.Width = 210
        '
        'chUnidad
        '
        Me.chUnidad.Text = "Unidad"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpfecha_desde)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpfecha_hasta)
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Controls.Add(Me.txtFiltro_producto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(663, 97)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'lstMovimientos
        '
        Me.lstMovimientos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFecha, Me.chMotivo, Me.chDocumento, Me.chPersona, Me.chStockInicial, Me.chCantidad_ingreso, Me.chCantidad_Salida, Me.chStock_Final})
        Me.lstMovimientos.FullRowSelect = True
        Me.lstMovimientos.GridLines = True
        Me.lstMovimientos.HideSelection = False
        Me.lstMovimientos.Location = New System.Drawing.Point(299, 116)
        Me.lstMovimientos.Name = "lstMovimientos"
        Me.lstMovimientos.Size = New System.Drawing.Size(540, 238)
        Me.lstMovimientos.TabIndex = 55
        Me.lstMovimientos.UseCompatibleStateImageBehavior = False
        Me.lstMovimientos.View = System.Windows.Forms.View.Details
        '
        'chFecha
        '
        Me.chFecha.Text = "Fecha"
        Me.chFecha.Width = 55
        '
        'chMotivo
        '
        Me.chMotivo.Text = "Motivo"
        '
        'chDocumento
        '
        Me.chDocumento.Text = "Documento"
        Me.chDocumento.Width = 70
        '
        'chPersona
        '
        Me.chPersona.Text = "Proveedor/Cliente"
        Me.chPersona.Width = 110
        '
        'chStockInicial
        '
        Me.chStockInicial.Text = "Stock Inic"
        '
        'chCantidad_ingreso
        '
        Me.chCantidad_ingreso.Text = "Cant Ing"
        '
        'chCantidad_Salida
        '
        Me.chCantidad_Salida.Text = "Cant Sal"
        '
        'chStock_Final
        '
        Me.chStock_Final.Text = "Stock Fin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(660, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Stock Fisico Final:"
        '
        'txtStock_Final
        '
        Me.txtStock_Final.Location = New System.Drawing.Point(759, 369)
        Me.txtStock_Final.Name = "txtStock_Final"
        Me.txtStock_Final.Size = New System.Drawing.Size(80, 20)
        Me.txtStock_Final.TabIndex = 57
        '
        'frmMovimiento_Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(846, 401)
        Me.Controls.Add(Me.txtStock_Final)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstMovimientos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lstProducto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnExportar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovimiento_Kardex"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOVIMIENTO DE KARDEX"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfecha_hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFiltro_producto As System.Windows.Forms.TextBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents lstProducto As System.Windows.Forms.ListView
    Friend WithEvents chProducto As System.Windows.Forms.ColumnHeader
    Friend WithEvents chUnidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstMovimientos As System.Windows.Forms.ListView
    Friend WithEvents chFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents chMotivo As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDocumento As System.Windows.Forms.ColumnHeader
    Friend WithEvents chPersona As System.Windows.Forms.ColumnHeader
    Friend WithEvents chStockInicial As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCantidad_ingreso As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCantidad_Salida As System.Windows.Forms.ColumnHeader
    Friend WithEvents chStock_Final As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStock_Final As System.Windows.Forms.TextBox
End Class
