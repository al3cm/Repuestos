<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarProveedores
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
        Me.txtbuscar_ruc = New System.Windows.Forms.TextBox
        Me.txtbuscar_proveedor = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstProveedores = New System.Windows.Forms.ListView
        Me.chIdProveedor = New System.Windows.Forms.ColumnHeader
        Me.chProveedor = New System.Windows.Forms.ColumnHeader
        Me.chRuc = New System.Windows.Forms.ColumnHeader
        Me.chDireccion = New System.Windows.Forms.ColumnHeader
        Me.chTelefono = New System.Windows.Forms.ColumnHeader
        Me.chFax = New System.Windows.Forms.ColumnHeader
        Me.chEmail = New System.Windows.Forms.ColumnHeader
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar_ruc)
        Me.GroupBox1.Controls.Add(Me.txtbuscar_proveedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'txtbuscar_ruc
        '
        Me.txtbuscar_ruc.Location = New System.Drawing.Point(349, 32)
        Me.txtbuscar_ruc.MaxLength = 11
        Me.txtbuscar_ruc.Name = "txtbuscar_ruc"
        Me.txtbuscar_ruc.Size = New System.Drawing.Size(146, 20)
        Me.txtbuscar_ruc.TabIndex = 3
        '
        'txtbuscar_proveedor
        '
        Me.txtbuscar_proveedor.Location = New System.Drawing.Point(67, 32)
        Me.txtbuscar_proveedor.MaxLength = 100
        Me.txtbuscar_proveedor.Name = "txtbuscar_proveedor"
        Me.txtbuscar_proveedor.Size = New System.Drawing.Size(222, 20)
        Me.txtbuscar_proveedor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ruc:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Proveedor:"
        '
        'lstProveedores
        '
        Me.lstProveedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstProveedores.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chIdProveedor, Me.chProveedor, Me.chRuc, Me.chDireccion, Me.chTelefono, Me.chFax, Me.chEmail})
        Me.lstProveedores.FullRowSelect = True
        Me.lstProveedores.GridLines = True
        Me.lstProveedores.HideSelection = False
        Me.lstProveedores.Location = New System.Drawing.Point(10, 101)
        Me.lstProveedores.MultiSelect = False
        Me.lstProveedores.Name = "lstProveedores"
        Me.lstProveedores.Size = New System.Drawing.Size(542, 295)
        Me.lstProveedores.TabIndex = 1
        Me.lstProveedores.UseCompatibleStateImageBehavior = False
        Me.lstProveedores.View = System.Windows.Forms.View.Details
        '
        'chIdProveedor
        '
        Me.chIdProveedor.Text = "Codigo"
        Me.chIdProveedor.Width = 45
        '
        'chProveedor
        '
        Me.chProveedor.Text = "Proveedor"
        Me.chProveedor.Width = 112
        '
        'chRuc
        '
        Me.chRuc.Text = "Ruc"
        Me.chRuc.Width = 70
        '
        'chDireccion
        '
        Me.chDireccion.Text = "Dirección"
        Me.chDireccion.Width = 80
        '
        'chTelefono
        '
        Me.chTelefono.Text = "Teléfono"
        Me.chTelefono.Width = 65
        '
        'chFax
        '
        Me.chFax.Text = "Fax"
        Me.chFax.Width = 65
        '
        'chEmail
        '
        Me.chEmail.Text = "Email"
        Me.chEmail.Width = 95
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(396, 402)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(477, 402)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmListarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(565, 437)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lstProveedores)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListarProveedores"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE PROVEEDORES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents txtbuscar_ruc As System.Windows.Forms.TextBox
    Friend WithEvents lstProveedores As System.Windows.Forms.ListView
    Friend WithEvents chIdProveedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents chProveedor As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRuc As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDireccion As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTelefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents chFax As System.Windows.Forms.ColumnHeader
    Friend WithEvents chEmail As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
