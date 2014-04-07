<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarVehiculo
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
        Me.txtbuscar_cliente = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbuscar_placa = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstVehiculos = New System.Windows.Forms.ListView
        Me.chId_vehiculo = New System.Windows.Forms.ColumnHeader
        Me.ch_Cliente = New System.Windows.Forms.ColumnHeader
        Me.chPlaca = New System.Windows.Forms.ColumnHeader
        Me.chTipo = New System.Windows.Forms.ColumnHeader
        Me.chMarca = New System.Windows.Forms.ColumnHeader
        Me.chModelo = New System.Windows.Forms.ColumnHeader
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar_cliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbuscar_placa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'txtbuscar_cliente
        '
        Me.txtbuscar_cliente.Location = New System.Drawing.Point(54, 28)
        Me.txtbuscar_cliente.MaxLength = 100
        Me.txtbuscar_cliente.Name = "txtbuscar_cliente"
        Me.txtbuscar_cliente.Size = New System.Drawing.Size(228, 20)
        Me.txtbuscar_cliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cliente:"
        '
        'txtbuscar_placa
        '
        Me.txtbuscar_placa.Location = New System.Drawing.Point(335, 28)
        Me.txtbuscar_placa.MaxLength = 8
        Me.txtbuscar_placa.Name = "txtbuscar_placa"
        Me.txtbuscar_placa.Size = New System.Drawing.Size(160, 20)
        Me.txtbuscar_placa.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Placa:"
        '
        'lstVehiculos
        '
        Me.lstVehiculos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstVehiculos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId_vehiculo, Me.ch_Cliente, Me.chPlaca, Me.chTipo, Me.chMarca, Me.chModelo})
        Me.lstVehiculos.FullRowSelect = True
        Me.lstVehiculos.GridLines = True
        Me.lstVehiculos.HideSelection = False
        Me.lstVehiculos.Location = New System.Drawing.Point(13, 89)
        Me.lstVehiculos.MultiSelect = False
        Me.lstVehiculos.Name = "lstVehiculos"
        Me.lstVehiculos.Size = New System.Drawing.Size(533, 242)
        Me.lstVehiculos.TabIndex = 1
        Me.lstVehiculos.UseCompatibleStateImageBehavior = False
        Me.lstVehiculos.View = System.Windows.Forms.View.Details
        '
        'chId_vehiculo
        '
        Me.chId_vehiculo.Text = "Código"
        Me.chId_vehiculo.Width = 45
        '
        'ch_Cliente
        '
        Me.ch_Cliente.Text = "Cliente"
        Me.ch_Cliente.Width = 140
        '
        'chPlaca
        '
        Me.chPlaca.Text = "Placa"
        Me.chPlaca.Width = 80
        '
        'chTipo
        '
        Me.chTipo.Text = "Tipo de Vehiculo"
        Me.chTipo.Width = 100
        '
        'chMarca
        '
        Me.chMarca.Text = "Marca"
        Me.chMarca.Width = 80
        '
        'chModelo
        '
        Me.chModelo.Text = "Modelo"
        Me.chModelo.Width = 80
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(391, 335)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(472, 335)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmListarVehiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(556, 365)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lstVehiculos)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListarVehiculo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE VEHICULOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar_placa As System.Windows.Forms.TextBox
    Friend WithEvents txtbuscar_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstVehiculos As System.Windows.Forms.ListView
    Friend WithEvents chId_vehiculo As System.Windows.Forms.ColumnHeader
    Friend WithEvents ch_Cliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents chPlaca As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTipo As System.Windows.Forms.ColumnHeader
    Friend WithEvents chMarca As System.Windows.Forms.ColumnHeader
    Friend WithEvents chModelo As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
