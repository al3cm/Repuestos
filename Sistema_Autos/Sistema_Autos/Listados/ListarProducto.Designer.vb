<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarProducto
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
        Me.txtbuscar_codigo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbuscar_nombre = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstProductos = New System.Windows.Forms.ListView
        Me.chId_codigo = New System.Windows.Forms.ColumnHeader
        Me.chNombre = New System.Windows.Forms.ColumnHeader
        Me.chCodigo_Producto = New System.Windows.Forms.ColumnHeader
        Me.chmodelo = New System.Windows.Forms.ColumnHeader
        Me.chprecio_compra = New System.Windows.Forms.ColumnHeader
        Me.chprecio_venta = New System.Windows.Forms.ColumnHeader
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar_codigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbuscar_nombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'txtbuscar_codigo
        '
        Me.txtbuscar_codigo.Location = New System.Drawing.Point(460, 32)
        Me.txtbuscar_codigo.Name = "txtbuscar_codigo"
        Me.txtbuscar_codigo.Size = New System.Drawing.Size(175, 20)
        Me.txtbuscar_codigo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(349, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código del producto:"
        '
        'txtbuscar_nombre
        '
        Me.txtbuscar_nombre.Location = New System.Drawing.Point(76, 32)
        Me.txtbuscar_nombre.Name = "txtbuscar_nombre"
        Me.txtbuscar_nombre.Size = New System.Drawing.Size(267, 20)
        Me.txtbuscar_nombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'lstProductos
        '
        Me.lstProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstProductos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId_codigo, Me.chNombre, Me.chCodigo_Producto, Me.chmodelo, Me.chprecio_compra, Me.chprecio_venta})
        Me.lstProductos.FullRowSelect = True
        Me.lstProductos.GridLines = True
        Me.lstProductos.HideSelection = False
        Me.lstProductos.Location = New System.Drawing.Point(13, 98)
        Me.lstProductos.Name = "lstProductos"
        Me.lstProductos.Size = New System.Drawing.Size(660, 322)
        Me.lstProductos.TabIndex = 1
        Me.lstProductos.UseCompatibleStateImageBehavior = False
        Me.lstProductos.View = System.Windows.Forms.View.Details
        '
        'chId_codigo
        '
        Me.chId_codigo.Text = "Código"
        Me.chId_codigo.Width = 50
        '
        'chNombre
        '
        Me.chNombre.Text = "Nombre"
        Me.chNombre.Width = 160
        '
        'chCodigo_Producto
        '
        Me.chCodigo_Producto.Text = "Código Producto"
        Me.chCodigo_Producto.Width = 130
        '
        'chmodelo
        '
        Me.chmodelo.Text = "Modelo"
        Me.chmodelo.Width = 130
        '
        'chprecio_compra
        '
        Me.chprecio_compra.Text = "Precio Compra"
        Me.chprecio_compra.Width = 90
        '
        'chprecio_venta
        '
        Me.chprecio_venta.Text = "Precio Venta"
        Me.chprecio_venta.Width = 90
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(518, 426)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(599, 426)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmListarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(685, 459)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lstProductos)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListarProducto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE PRODUCTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbuscar_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar_codigo As System.Windows.Forms.TextBox
    Friend WithEvents lstProductos As System.Windows.Forms.ListView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chId_codigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCodigo_Producto As System.Windows.Forms.ColumnHeader
    Friend WithEvents chmodelo As System.Windows.Forms.ColumnHeader
    Friend WithEvents chprecio_compra As System.Windows.Forms.ColumnHeader
    Friend WithEvents chprecio_venta As System.Windows.Forms.ColumnHeader
End Class
