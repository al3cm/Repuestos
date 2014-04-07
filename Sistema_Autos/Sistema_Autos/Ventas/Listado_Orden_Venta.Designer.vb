<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListado_Orden_Venta
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
        Me.lstOrden_Venta = New System.Windows.Forms.ListView
        Me.chCliente = New System.Windows.Forms.ColumnHeader
        Me.chOrden = New System.Windows.Forms.ColumnHeader
        Me.chFecha_Emision = New System.Windows.Forms.ColumnHeader
        Me.chTipo_Pago = New System.Windows.Forms.ColumnHeader
        Me.chImporte = New System.Windows.Forms.ColumnHeader
        Me.chMoneda = New System.Windows.Forms.ColumnHeader
        Me.chVendedor = New System.Windows.Forms.ColumnHeader
        Me.txtbuscar_proveedor = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpfecha_fin = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpfecha_inicio = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(620, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 29
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(539, 348)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 27
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(620, 348)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 28
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(466, 53)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 26
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'lstOrden_Venta
        '
        Me.lstOrden_Venta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCliente, Me.chOrden, Me.chFecha_Emision, Me.chTipo_Pago, Me.chImporte, Me.chMoneda, Me.chVendedor})
        Me.lstOrden_Venta.FullRowSelect = True
        Me.lstOrden_Venta.GridLines = True
        Me.lstOrden_Venta.HideSelection = False
        Me.lstOrden_Venta.Location = New System.Drawing.Point(25, 94)
        Me.lstOrden_Venta.Name = "lstOrden_Venta"
        Me.lstOrden_Venta.Size = New System.Drawing.Size(670, 248)
        Me.lstOrden_Venta.TabIndex = 25
        Me.lstOrden_Venta.UseCompatibleStateImageBehavior = False
        Me.lstOrden_Venta.View = System.Windows.Forms.View.Details
        '
        'chCliente
        '
        Me.chCliente.Text = "Cliente"
        Me.chCliente.Width = 170
        '
        'chOrden
        '
        Me.chOrden.Text = "Orden"
        Me.chOrden.Width = 70
        '
        'chFecha_Emision
        '
        Me.chFecha_Emision.Text = "Fecha Emision"
        Me.chFecha_Emision.Width = 90
        '
        'chTipo_Pago
        '
        Me.chTipo_Pago.Text = "Tipo_Pago"
        Me.chTipo_Pago.Width = 80
        '
        'chImporte
        '
        Me.chImporte.Text = "Importe"
        '
        'chMoneda
        '
        Me.chMoneda.Text = "Moneda"
        '
        'chVendedor
        '
        Me.chVendedor.Text = "Vendedor"
        Me.chVendedor.Width = 140
        '
        'txtbuscar_proveedor
        '
        Me.txtbuscar_proveedor.Location = New System.Drawing.Point(93, 55)
        Me.txtbuscar_proveedor.Name = "txtbuscar_proveedor"
        Me.txtbuscar_proveedor.Size = New System.Drawing.Size(367, 20)
        Me.txtbuscar_proveedor.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Cliente:"
        '
        'dtpfecha_fin
        '
        Me.dtpfecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_fin.Location = New System.Drawing.Point(270, 20)
        Me.dtpfecha_fin.Name = "dtpfecha_fin"
        Me.dtpfecha_fin.Size = New System.Drawing.Size(94, 20)
        Me.dtpfecha_fin.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Fecha Fin:"
        '
        'dtpfecha_inicio
        '
        Me.dtpfecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_inicio.Location = New System.Drawing.Point(93, 21)
        Me.dtpfecha_inicio.Name = "dtpfecha_inicio"
        Me.dtpfecha_inicio.Size = New System.Drawing.Size(94, 20)
        Me.dtpfecha_inicio.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Fecha Inicio:"
        '
        'frmListado_Orden_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(712, 383)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.lstOrden_Venta)
        Me.Controls.Add(Me.txtbuscar_proveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpfecha_fin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpfecha_inicio)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListado_Orden_Venta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE ORDEN DE VENTA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents lstOrden_Venta As System.Windows.Forms.ListView
    Friend WithEvents chCliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents chOrden As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFecha_Emision As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTipo_Pago As System.Windows.Forms.ColumnHeader
    Friend WithEvents chImporte As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtbuscar_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents chVendedor As System.Windows.Forms.ColumnHeader
End Class
