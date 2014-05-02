<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPermiso_Almacenes
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboSucursal = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.btnSalir = New System.Windows.Forms.Button
        Me.dtvListado_Almacen = New System.Windows.Forms.DataGridView
        Me.ChId_Almacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ChAlmacen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.dtvAlmacen_permitidos = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAceptar = New System.Windows.Forms.Button
        CType(Me.dtvListado_Almacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtvAlmacen_permitidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(275, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PERMISO DE ACCESO A ALMACENES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sucursal:"
        '
        'cboSucursal
        '
        Me.cboSucursal.FormattingEnabled = True
        Me.cboSucursal.Location = New System.Drawing.Point(18, 58)
        Me.cboSucursal.Name = "cboSucursal"
        Me.cboSucursal.Size = New System.Drawing.Size(146, 21)
        Me.cboSucursal.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Listado de Almacenes:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Almacenes Permitidos:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Image = Global.Sistema_Autos.My.Resources.Resources.derecha
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(170, 133)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(50, 40)
        Me.btnAgregar.TabIndex = 76
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Image = Global.Sistema_Autos.My.Resources.Resources.izquierda
        Me.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnQuitar.Location = New System.Drawing.Point(170, 179)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(50, 40)
        Me.btnQuitar.TabIndex = 75
        Me.btnQuitar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Image = Global.Sistema_Autos.My.Resources.Resources.salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(311, 12)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 55)
        Me.btnSalir.TabIndex = 79
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dtvListado_Almacen
        '
        Me.dtvListado_Almacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvListado_Almacen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ChId_Almacen, Me.ChAlmacen})
        Me.dtvListado_Almacen.Location = New System.Drawing.Point(15, 108)
        Me.dtvListado_Almacen.Name = "dtvListado_Almacen"
        Me.dtvListado_Almacen.Size = New System.Drawing.Size(149, 149)
        Me.dtvListado_Almacen.TabIndex = 80
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
        'dtvAlmacen_permitidos
        '
        Me.dtvAlmacen_permitidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvAlmacen_permitidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dtvAlmacen_permitidos.Location = New System.Drawing.Point(237, 108)
        Me.dtvAlmacen_permitidos.Name = "dtvAlmacen_permitidos"
        Me.dtvAlmacen_permitidos.Size = New System.Drawing.Size(149, 149)
        Me.dtvAlmacen_permitidos.TabIndex = 81
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id_Almacen"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Almacen"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(161, 263)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 82
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmPermiso_Almacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(398, 287)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.dtvAlmacen_permitidos)
        Me.Controls.Add(Me.dtvListado_Almacen)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboSucursal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPermiso_Almacenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERMISO ALMACENES"
        CType(Me.dtvListado_Almacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtvAlmacen_permitidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents dtvListado_Almacen As System.Windows.Forms.DataGridView
    Friend WithEvents ChId_Almacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChAlmacen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtvAlmacen_permitidos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
