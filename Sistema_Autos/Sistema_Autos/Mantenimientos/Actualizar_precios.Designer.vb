<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizar_precios
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
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.cboMarca = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboLinea = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtfiltro_producto = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboAlmacen = New System.Windows.Forms.ComboBox
        Me.btnGrabar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnExportar = New System.Windows.Forms.Button
        Me.dgvProducto = New System.Windows.Forms.DataGridView
        Me.ChId_Poducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChProducto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChId_Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChId_Linea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChLinea = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChId_Marca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChMarca = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChStock = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChCosto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CHPrecioTrajecta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.cboMarca)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboLinea)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtfiltro_producto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboAlmacen)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 89)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(333, 54)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 56
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'cboMarca
        '
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(442, 21)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(134, 21)
        Me.cboMarca.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(396, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Marca:"
        '
        'cboLinea
        '
        Me.cboLinea.FormattingEnabled = True
        Me.cboLinea.Location = New System.Drawing.Point(246, 22)
        Me.cboLinea.Name = "cboLinea"
        Me.cboLinea.Size = New System.Drawing.Size(134, 21)
        Me.cboLinea.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Línea:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Almacén:"
        '
        'txtfiltro_producto
        '
        Me.txtfiltro_producto.Location = New System.Drawing.Point(73, 56)
        Me.txtfiltro_producto.Name = "txtfiltro_producto"
        Me.txtfiltro_producto.Size = New System.Drawing.Size(233, 20)
        Me.txtfiltro_producto.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto:"
        '
        'cboAlmacen
        '
        Me.cboAlmacen.FormattingEnabled = True
        Me.cboAlmacen.Location = New System.Drawing.Point(73, 21)
        Me.cboAlmacen.Name = "cboAlmacen"
        Me.cboAlmacen.Size = New System.Drawing.Size(121, 21)
        Me.cboAlmacen.TabIndex = 0
        '
        'btnGrabar
        '
        Me.btnGrabar.Image = Global.Sistema_Autos.My.Resources.Resources.guardar
        Me.btnGrabar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGrabar.Location = New System.Drawing.Point(637, 18)
        Me.btnGrabar.Name = "btnGrabar"
        Me.btnGrabar.Size = New System.Drawing.Size(75, 55)
        Me.btnGrabar.TabIndex = 37
        Me.btnGrabar.Text = "Grabar"
        Me.btnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGrabar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(637, 140)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 50
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Image = Global.Sistema_Autos.My.Resources.Resources.excel
        Me.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExportar.Location = New System.Drawing.Point(637, 79)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(75, 55)
        Me.btnExportar.TabIndex = 49
        Me.btnExportar.Text = "&Exportar"
        Me.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'dgvProducto
        '
        Me.dgvProducto.AllowUserToDeleteRows = False
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChId_Poducto, Me.ChProducto, Me.ChId_Almacen, Me.ChAlmacen, Me.ChId_Linea, Me.ChLinea, Me.ChId_Marca, Me.ChMarca, Me.ChStock, Me.ChCosto, Me.ChPrecio, Me.CHPrecioTrajecta})
        Me.dgvProducto.Location = New System.Drawing.Point(13, 108)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = True
        Me.dgvProducto.Size = New System.Drawing.Size(619, 285)
        Me.dgvProducto.TabIndex = 71
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
        'ChId_Almacen
        '
        Me.ChId_Almacen.HeaderText = "Id_Almacen"
        Me.ChId_Almacen.Name = "ChId_Almacen"
        Me.ChId_Almacen.ReadOnly = True
        Me.ChId_Almacen.Visible = False
        '
        'ChAlmacen
        '
        Me.ChAlmacen.HeaderText = "Almacen"
        Me.ChAlmacen.Name = "ChAlmacen"
        Me.ChAlmacen.ReadOnly = True
        '
        'ChId_Linea
        '
        Me.ChId_Linea.HeaderText = "Id_Linea"
        Me.ChId_Linea.Name = "ChId_Linea"
        Me.ChId_Linea.ReadOnly = True
        Me.ChId_Linea.Visible = False
        '
        'ChLinea
        '
        Me.ChLinea.HeaderText = "Linea"
        Me.ChLinea.Name = "ChLinea"
        Me.ChLinea.ReadOnly = True
        '
        'ChId_Marca
        '
        Me.ChId_Marca.HeaderText = "Id_Marca"
        Me.ChId_Marca.Name = "ChId_Marca"
        Me.ChId_Marca.ReadOnly = True
        Me.ChId_Marca.Visible = False
        '
        'ChMarca
        '
        Me.ChMarca.HeaderText = "Marca"
        Me.ChMarca.Name = "ChMarca"
        Me.ChMarca.ReadOnly = True
        '
        'ChStock
        '
        Me.ChStock.HeaderText = "Stock"
        Me.ChStock.Name = "ChStock"
        Me.ChStock.ReadOnly = True
        '
        'ChCosto
        '
        Me.ChCosto.HeaderText = "Costo (S/.)"
        Me.ChCosto.Name = "ChCosto"
        Me.ChCosto.ReadOnly = True
        '
        'ChPrecio
        '
        Me.ChPrecio.HeaderText = "Precio (S/.)"
        Me.ChPrecio.Name = "ChPrecio"
        Me.ChPrecio.ReadOnly = True
        '
        'CHPrecioTrajecta
        '
        Me.CHPrecioTrajecta.HeaderText = "Precio Tarjeta (S/.)"
        Me.CHPrecioTrajecta.Name = "CHPrecioTrajecta"
        Me.CHPrecioTrajecta.ReadOnly = True
        '
        'frmActualizar_precios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(716, 405)
        Me.Controls.Add(Me.dgvProducto)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnGrabar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmActualizar_precios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACTUALIZAR PRECIOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboAlmacen As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro_producto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboLinea As System.Windows.Forms.ComboBox
    Friend WithEvents cboMarca As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnGrabar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents ChId_Poducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChId_Almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChId_Linea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChLinea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChId_Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChMarca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChStock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChCosto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHPrecioTrajecta As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
