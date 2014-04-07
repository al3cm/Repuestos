<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscar_Nota_Debito_Proovedor
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
        Me.txtbuscar_proveedor = New System.Windows.Forms.TextBox
        Me.lstListado_NDProovedor = New System.Windows.Forms.ListView
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.chNota_Credito = New System.Windows.Forms.ColumnHeader
        Me.chProveedor = New System.Windows.Forms.ColumnHeader
        Me.chFechaEmision = New System.Windows.Forms.ColumnHeader
        Me.chImporte = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar_proveedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor:"
        '
        'txtbuscar_proveedor
        '
        Me.txtbuscar_proveedor.Location = New System.Drawing.Point(84, 27)
        Me.txtbuscar_proveedor.Name = "txtbuscar_proveedor"
        Me.txtbuscar_proveedor.Size = New System.Drawing.Size(194, 20)
        Me.txtbuscar_proveedor.TabIndex = 1
        '
        'lstListado_NDProovedor
        '
        Me.lstListado_NDProovedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNota_Credito, Me.chProveedor, Me.chFechaEmision, Me.chImporte})
        Me.lstListado_NDProovedor.FullRowSelect = True
        Me.lstListado_NDProovedor.GridLines = True
        Me.lstListado_NDProovedor.HideSelection = False
        Me.lstListado_NDProovedor.Location = New System.Drawing.Point(13, 84)
        Me.lstListado_NDProovedor.Name = "lstListado_NDProovedor"
        Me.lstListado_NDProovedor.Size = New System.Drawing.Size(514, 233)
        Me.lstListado_NDProovedor.TabIndex = 1
        Me.lstListado_NDProovedor.UseCompatibleStateImageBehavior = False
        Me.lstListado_NDProovedor.View = System.Windows.Forms.View.Details
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(371, 323)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 37
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(452, 323)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 38
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(452, 22)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 39
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'chNota_Credito
        '
        Me.chNota_Credito.Text = "Nota de Crédito"
        Me.chNota_Credito.Width = 90
        '
        'chProveedor
        '
        Me.chProveedor.Text = "Proveedor"
        Me.chProveedor.Width = 200
        '
        'chFechaEmision
        '
        Me.chFechaEmision.Text = "Fecha Emisión"
        Me.chFechaEmision.Width = 90
        '
        'chImporte
        '
        Me.chImporte.Text = "Importe"
        Me.chImporte.Width = 90
        '
        'frmBuscar_Nota_Debito_Proovedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(542, 366)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lstListado_NDProovedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBuscar_Nota_Debito_Proovedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR NOTA DE DEBITO PROVEEDOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents lstListado_NDProovedor As System.Windows.Forms.ListView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents chNota_Credito As System.Windows.Forms.ColumnHeader
    Friend WithEvents chProveedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFechaEmision As System.Windows.Forms.ColumnHeader
    Friend WithEvents chImporte As System.Windows.Forms.ColumnHeader
End Class
