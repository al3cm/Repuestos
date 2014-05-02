<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListado_Facturacion
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
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.dtpfecha_fin = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpfecha_inicio = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.DgvOrden_Compra = New System.Windows.Forms.DataGridView
        Me.ChId_Documento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChId_Orden_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ch_Orden_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ch_Id_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChRuc_Dni = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChCliente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChId_Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChVendedor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChId_Caja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChCaja = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChId_Moneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChMoneda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChInicial = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChEstado_Factura = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DgvOrden_Compra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(450, 22)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(807, 337)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 27
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(888, 337)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 28
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.Sistema_Autos.My.Resources.Resources.consultar
        Me.btnConsultar.Location = New System.Drawing.Point(369, 20)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 57)
        Me.btnConsultar.TabIndex = 26
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dtpfecha_fin
        '
        Me.dtpfecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_fin.Location = New System.Drawing.Point(269, 38)
        Me.dtpfecha_fin.Name = "dtpfecha_fin"
        Me.dtpfecha_fin.Size = New System.Drawing.Size(94, 20)
        Me.dtpfecha_fin.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Fecha Fin:"
        '
        'dtpfecha_inicio
        '
        Me.dtpfecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_inicio.Location = New System.Drawing.Point(92, 38)
        Me.dtpfecha_inicio.Name = "dtpfecha_inicio"
        Me.dtpfecha_inicio.Size = New System.Drawing.Size(94, 20)
        Me.dtpfecha_inicio.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Fecha Inicio:"
        '
        'DgvOrden_Compra
        '
        Me.DgvOrden_Compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOrden_Compra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChId_Documento, Me.ChDocumento, Me.ChId_Orden_Venta, Me.Ch_Orden_Venta, Me.Ch_Id_Cliente, Me.ChRuc_Dni, Me.ChCliente, Me.ChDireccion, Me.ChId_Vendedor, Me.ChVendedor, Me.ChId_Caja, Me.ChCaja, Me.ChFecha, Me.ChId_Moneda, Me.ChMoneda, Me.ChInicial, Me.ChEstado, Me.ChEstado_Factura})
        Me.DgvOrden_Compra.Location = New System.Drawing.Point(12, 83)
        Me.DgvOrden_Compra.Name = "DgvOrden_Compra"
        Me.DgvOrden_Compra.Size = New System.Drawing.Size(951, 248)
        Me.DgvOrden_Compra.TabIndex = 30
        '
        'ChId_Documento
        '
        Me.ChId_Documento.HeaderText = "Id Documento"
        Me.ChId_Documento.Name = "ChId_Documento"
        Me.ChId_Documento.Visible = False
        '
        'ChDocumento
        '
        Me.ChDocumento.HeaderText = "Documento"
        Me.ChDocumento.Name = "ChDocumento"
        '
        'ChId_Orden_Venta
        '
        Me.ChId_Orden_Venta.HeaderText = "Id Orden Venta"
        Me.ChId_Orden_Venta.Name = "ChId_Orden_Venta"
        Me.ChId_Orden_Venta.Visible = False
        '
        'Ch_Orden_Venta
        '
        Me.Ch_Orden_Venta.HeaderText = "Orden Venta"
        Me.Ch_Orden_Venta.Name = "Ch_Orden_Venta"
        '
        'Ch_Id_Cliente
        '
        Me.Ch_Id_Cliente.HeaderText = "Id Cliente"
        Me.Ch_Id_Cliente.Name = "Ch_Id_Cliente"
        Me.Ch_Id_Cliente.Visible = False
        '
        'ChRuc_Dni
        '
        Me.ChRuc_Dni.HeaderText = "Ruc o Dni"
        Me.ChRuc_Dni.Name = "ChRuc_Dni"
        '
        'ChCliente
        '
        Me.ChCliente.HeaderText = "Cliente"
        Me.ChCliente.Name = "ChCliente"
        '
        'ChDireccion
        '
        Me.ChDireccion.HeaderText = "Direccion"
        Me.ChDireccion.Name = "ChDireccion"
        '
        'ChId_Vendedor
        '
        Me.ChId_Vendedor.HeaderText = "Id Vendedor"
        Me.ChId_Vendedor.Name = "ChId_Vendedor"
        Me.ChId_Vendedor.Visible = False
        '
        'ChVendedor
        '
        Me.ChVendedor.HeaderText = "Vendedor"
        Me.ChVendedor.Name = "ChVendedor"
        '
        'ChId_Caja
        '
        Me.ChId_Caja.HeaderText = "Id Caja"
        Me.ChId_Caja.Name = "ChId_Caja"
        Me.ChId_Caja.Visible = False
        '
        'ChCaja
        '
        Me.ChCaja.HeaderText = "Caja"
        Me.ChCaja.Name = "ChCaja"
        '
        'ChFecha
        '
        Me.ChFecha.HeaderText = "Fecha"
        Me.ChFecha.Name = "ChFecha"
        '
        'ChId_Moneda
        '
        Me.ChId_Moneda.HeaderText = "Id Moneda"
        Me.ChId_Moneda.Name = "ChId_Moneda"
        Me.ChId_Moneda.Visible = False
        '
        'ChMoneda
        '
        Me.ChMoneda.HeaderText = "Moneda"
        Me.ChMoneda.Name = "ChMoneda"
        '
        'ChInicial
        '
        Me.ChInicial.HeaderText = "Inicial"
        Me.ChInicial.Name = "ChInicial"
        '
        'ChEstado
        '
        Me.ChEstado.HeaderText = "Estado"
        Me.ChEstado.Name = "ChEstado"
        Me.ChEstado.Visible = False
        '
        'ChEstado_Factura
        '
        Me.ChEstado_Factura.HeaderText = "Estado Factura"
        Me.ChEstado_Factura.Name = "ChEstado_Factura"
        '
        'frmListado_Facturacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(975, 375)
        Me.Controls.Add(Me.DgvOrden_Compra)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dtpfecha_fin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpfecha_inicio)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmListado_Facturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE FACTURACION"
        CType(Me.DgvOrden_Compra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents dtpfecha_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgvOrden_Compra As System.Windows.Forms.DataGridView
    Friend WithEvents ChId_Documento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChId_Orden_Venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ch_Orden_Venta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ch_Id_Cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChRuc_Dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChCliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChDireccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChId_Vendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChVendedor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChId_Caja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChCaja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChId_Moneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChMoneda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChInicial As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChEstado_Factura As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
