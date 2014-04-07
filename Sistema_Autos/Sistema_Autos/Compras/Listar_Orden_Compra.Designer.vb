<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListar_Orden_Compra
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
        Me.dtpfecha_inicio = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpfecha_fin = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtbuscar_proveedor = New System.Windows.Forms.TextBox
        Me.lstOrden_Compra = New System.Windows.Forms.ListView
        Me.chProveedor = New System.Windows.Forms.ColumnHeader
        Me.chOrden = New System.Windows.Forms.ColumnHeader
        Me.chFecha_Emision = New System.Windows.Forms.ColumnHeader
        Me.chMoneda = New System.Windows.Forms.ColumnHeader
        Me.chImporte = New System.Windows.Forms.ColumnHeader
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
        '
        'dtpfecha_inicio
        '
        Me.dtpfecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_inicio.Location = New System.Drawing.Point(80, 22)
        Me.dtpfecha_inicio.Name = "dtpfecha_inicio"
        Me.dtpfecha_inicio.Size = New System.Drawing.Size(94, 20)
        Me.dtpfecha_inicio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha Fin:"
        '
        'dtpfecha_fin
        '
        Me.dtpfecha_fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfecha_fin.Location = New System.Drawing.Point(257, 22)
        Me.dtpfecha_fin.Name = "dtpfecha_fin"
        Me.dtpfecha_fin.Size = New System.Drawing.Size(94, 20)
        Me.dtpfecha_fin.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Proveedor:"
        '
        'txtbuscar_proveedor
        '
        Me.txtbuscar_proveedor.Location = New System.Drawing.Point(80, 56)
        Me.txtbuscar_proveedor.Name = "txtbuscar_proveedor"
        Me.txtbuscar_proveedor.Size = New System.Drawing.Size(271, 20)
        Me.txtbuscar_proveedor.TabIndex = 5
        '
        'lstOrden_Compra
        '
        Me.lstOrden_Compra.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chProveedor, Me.chOrden, Me.chFecha_Emision, Me.chMoneda, Me.chImporte})
        Me.lstOrden_Compra.FullRowSelect = True
        Me.lstOrden_Compra.GridLines = True
        Me.lstOrden_Compra.HideSelection = False
        Me.lstOrden_Compra.Location = New System.Drawing.Point(12, 95)
        Me.lstOrden_Compra.Name = "lstOrden_Compra"
        Me.lstOrden_Compra.Size = New System.Drawing.Size(513, 248)
        Me.lstOrden_Compra.TabIndex = 6
        Me.lstOrden_Compra.UseCompatibleStateImageBehavior = False
        Me.lstOrden_Compra.View = System.Windows.Forms.View.Details
        '
        'chProveedor
        '
        Me.chProveedor.Text = "Proveedor"
        Me.chProveedor.Width = 180
        '
        'chOrden
        '
        Me.chOrden.Text = "Orden"
        Me.chOrden.Width = 46
        '
        'chFecha_Emision
        '
        Me.chFecha_Emision.Text = "Fecha Emision"
        Me.chFecha_Emision.Width = 90
        '
        'chMoneda
        '
        Me.chMoneda.Text = "Moneda"
        '
        'chImporte
        '
        Me.chImporte.Text = "Importe"
        Me.chImporte.Width = 85
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(369, 54)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.btnConsultar.TabIndex = 7
        Me.btnConsultar.Text = "&Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(369, 349)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(450, 349)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(450, 25)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmListar_Orden_Compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(537, 377)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.lstOrden_Compra)
        Me.Controls.Add(Me.txtbuscar_proveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpfecha_fin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpfecha_inicio)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListar_Orden_Compra"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE ORDENES DE COMPRA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfecha_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents lstOrden_Compra As System.Windows.Forms.ListView
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents chProveedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents chOrden As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFecha_Emision As System.Windows.Forms.ColumnHeader
    Friend WithEvents chMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents chImporte As System.Windows.Forms.ColumnHeader
End Class
