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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtStock_Final = New System.Windows.Forms.TextBox
        Me.chProducto = New System.Windows.Forms.ColumnHeader
        Me.chUnidad = New System.Windows.Forms.ColumnHeader
        Me.lstProducto = New System.Windows.Forms.ListView
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView
        Me.Chid_kardex = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChRuc_DNI = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chPersona = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChStock_Inic = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChCant_Ing = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChCant_Sal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChStock_Fin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'chProducto
        '
        Me.chProducto.Text = "Producto"
        Me.chProducto.Width = 210
        '
        'chUnidad
        '
        Me.chUnidad.Text = "Unidad"
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
        'dgvMovimientos
        '
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Chid_kardex, Me.ChFecha, Me.ChMotivo, Me.ChDocumento, Me.ChRuc_DNI, Me.chPersona, Me.ChStock_Inic, Me.ChCant_Ing, Me.ChCant_Sal, Me.ChStock_Fin})
        Me.dgvMovimientos.Location = New System.Drawing.Point(299, 116)
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.Size = New System.Drawing.Size(540, 238)
        Me.dgvMovimientos.TabIndex = 82
        '
        'Chid_kardex
        '
        Me.Chid_kardex.HeaderText = "id_kardex"
        Me.Chid_kardex.Name = "Chid_kardex"
        Me.Chid_kardex.ReadOnly = True
        Me.Chid_kardex.Visible = False
        '
        'ChFecha
        '
        Me.ChFecha.HeaderText = "Fecha"
        Me.ChFecha.Name = "ChFecha"
        Me.ChFecha.ReadOnly = True
        '
        'ChMotivo
        '
        Me.ChMotivo.HeaderText = "Motivo"
        Me.ChMotivo.Name = "ChMotivo"
        '
        'ChDocumento
        '
        Me.ChDocumento.HeaderText = "Documento"
        Me.ChDocumento.Name = "ChDocumento"
        '
        'ChRuc_DNI
        '
        Me.ChRuc_DNI.HeaderText = "Ruc DNI"
        Me.ChRuc_DNI.Name = "ChRuc_DNI"
        Me.ChRuc_DNI.Visible = False
        '
        'chPersona
        '
        Me.chPersona.HeaderText = "Proveedor/Cliente"
        Me.chPersona.Name = "chPersona"
        '
        'ChStock_Inic
        '
        Me.ChStock_Inic.HeaderText = "Stock Inic"
        Me.ChStock_Inic.Name = "ChStock_Inic"
        '
        'ChCant_Ing
        '
        Me.ChCant_Ing.HeaderText = "Cant Ing"
        Me.ChCant_Ing.Name = "ChCant_Ing"
        '
        'ChCant_Sal
        '
        Me.ChCant_Sal.HeaderText = "Cant Sal"
        Me.ChCant_Sal.Name = "ChCant_Sal"
        '
        'ChStock_Fin
        '
        Me.ChStock_Fin.HeaderText = "Stock Fin"
        Me.ChStock_Fin.Name = "ChStock_Fin"
        '
        'frmMovimiento_Kardex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(846, 401)
        Me.Controls.Add(Me.dgvMovimientos)
        Me.Controls.Add(Me.txtStock_Final)
        Me.Controls.Add(Me.Label5)
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
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStock_Final As System.Windows.Forms.TextBox
    Friend WithEvents chProducto As System.Windows.Forms.ColumnHeader
    Friend WithEvents chUnidad As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstProducto As System.Windows.Forms.ListView
    Friend WithEvents dgvMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents Chid_kardex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChMotivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChRuc_DNI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chPersona As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChStock_Inic As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChCant_Ing As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChCant_Sal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChStock_Fin As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
