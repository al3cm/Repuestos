<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscar_Nota_Debito_Cliente
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtbuscar_cliente = New System.Windows.Forms.TextBox
        Me.lstListado_NDCliente = New System.Windows.Forms.ListView
        Me.chNota_Debito = New System.Windows.Forms.ColumnHeader
        Me.chDocumento = New System.Windows.Forms.ColumnHeader
        Me.chCliente = New System.Windows.Forms.ColumnHeader
        Me.chMonto = New System.Windows.Forms.ColumnHeader
        Me.chMoneda = New System.Windows.Forms.ColumnHeader
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar_cliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(427, 60)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'txtbuscar_cliente
        '
        Me.txtbuscar_cliente.Location = New System.Drawing.Point(64, 24)
        Me.txtbuscar_cliente.Name = "txtbuscar_cliente"
        Me.txtbuscar_cliente.Size = New System.Drawing.Size(169, 20)
        Me.txtbuscar_cliente.TabIndex = 1
        '
        'lstListado_NDCliente
        '
        Me.lstListado_NDCliente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNota_Debito, Me.chDocumento, Me.chCliente, Me.chMonto, Me.chMoneda})
        Me.lstListado_NDCliente.FullRowSelect = True
        Me.lstListado_NDCliente.GridLines = True
        Me.lstListado_NDCliente.HideSelection = False
        Me.lstListado_NDCliente.Location = New System.Drawing.Point(13, 80)
        Me.lstListado_NDCliente.Name = "lstListado_NDCliente"
        Me.lstListado_NDCliente.Size = New System.Drawing.Size(508, 259)
        Me.lstListado_NDCliente.TabIndex = 1
        Me.lstListado_NDCliente.UseCompatibleStateImageBehavior = False
        Me.lstListado_NDCliente.View = System.Windows.Forms.View.Details
        '
        'chNota_Debito
        '
        Me.chNota_Debito.Text = "Nota Debito"
        Me.chNota_Debito.Width = 90
        '
        'chDocumento
        '
        Me.chDocumento.Text = "Documento"
        Me.chDocumento.Width = 80
        '
        'chCliente
        '
        Me.chCliente.Text = "Cliente"
        Me.chCliente.Width = 190
        '
        'chMonto
        '
        Me.chMonto.Text = "Monto"
        Me.chMonto.Width = 70
        '
        'chMoneda
        '
        Me.chMoneda.Text = "Moneda"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(365, 345)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 30
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(446, 345)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 31
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(446, 19)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 32
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmBuscar_Nota_Debito_Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(535, 389)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lstListado_NDCliente)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBuscar_Nota_Debito_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR DE NOTA DE DEBITO CLIENTE"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar_cliente As System.Windows.Forms.TextBox
    Friend WithEvents lstListado_NDCliente As System.Windows.Forms.ListView
    Friend WithEvents chNota_Debito As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDocumento As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents chMonto As System.Windows.Forms.ColumnHeader
    Friend WithEvents chMoneda As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
