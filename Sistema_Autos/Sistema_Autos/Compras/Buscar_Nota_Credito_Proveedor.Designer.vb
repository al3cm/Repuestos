﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscar_Nota_Credito_Proveedor
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
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.lstListado_NCProovedor = New System.Windows.Forms.ListView
        Me.chNota_Credito = New System.Windows.Forms.ColumnHeader
        Me.chProveedor = New System.Windows.Forms.ColumnHeader
        Me.chFechaEmision = New System.Windows.Forms.ColumnHeader
        Me.chImporte = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtbuscar_proveedor = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.chEstado = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(370, 323)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 42
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(451, 323)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 43
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lstListado_NCProovedor
        '
        Me.lstListado_NCProovedor.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNota_Credito, Me.chProveedor, Me.chFechaEmision, Me.chImporte, Me.chEstado})
        Me.lstListado_NCProovedor.FullRowSelect = True
        Me.lstListado_NCProovedor.GridLines = True
        Me.lstListado_NCProovedor.HideSelection = False
        Me.lstListado_NCProovedor.Location = New System.Drawing.Point(12, 84)
        Me.lstListado_NCProovedor.Name = "lstListado_NCProovedor"
        Me.lstListado_NCProovedor.Size = New System.Drawing.Size(514, 233)
        Me.lstListado_NCProovedor.TabIndex = 41
        Me.lstListado_NCProovedor.UseCompatibleStateImageBehavior = False
        Me.lstListado_NCProovedor.View = System.Windows.Forms.View.Details
        '
        'chNota_Credito
        '
        Me.chNota_Credito.Text = "Nota de Crédito"
        Me.chNota_Credito.Width = 90
        '
        'chProveedor
        '
        Me.chProveedor.Text = "Proveedor"
        Me.chProveedor.Width = 195
        '
        'chFechaEmision
        '
        Me.chFechaEmision.Text = "Fecha Emisión"
        Me.chFechaEmision.Width = 85
        '
        'chImporte
        '
        Me.chImporte.Text = "Importe"
        Me.chImporte.Width = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar_proveedor)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(433, 64)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'txtbuscar_proveedor
        '
        Me.txtbuscar_proveedor.Location = New System.Drawing.Point(84, 27)
        Me.txtbuscar_proveedor.Name = "txtbuscar_proveedor"
        Me.txtbuscar_proveedor.Size = New System.Drawing.Size(194, 20)
        Me.txtbuscar_proveedor.TabIndex = 1
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
        'btnSalir
        '
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(451, 22)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 44
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'chEstado
        '
        Me.chEstado.Text = "Estado"
        '
        'frmBuscar_Nota_Credito_Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(535, 352)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lstListado_NCProovedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBuscar_Nota_Credito_Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSCAR NOTA DE CREDITO PROVEEDOR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lstListado_NCProovedor As System.Windows.Forms.ListView
    Friend WithEvents chNota_Credito As System.Windows.Forms.ColumnHeader
    Friend WithEvents chProveedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFechaEmision As System.Windows.Forms.ColumnHeader
    Friend WithEvents chImporte As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbuscar_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chEstado As System.Windows.Forms.ColumnHeader
End Class
