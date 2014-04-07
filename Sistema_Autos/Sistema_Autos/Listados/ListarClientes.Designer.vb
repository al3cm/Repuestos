<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarClientes
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
        Me.txtbuscar_dni = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtbuscar_ruc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbuscar_razonsocial = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstClientes = New System.Windows.Forms.ListView
        Me.chId_Cliente = New System.Windows.Forms.ColumnHeader
        Me.chRazon_social = New System.Windows.Forms.ColumnHeader
        Me.chRuc = New System.Windows.Forms.ColumnHeader
        Me.chDni = New System.Windows.Forms.ColumnHeader
        Me.chDireccion = New System.Windows.Forms.ColumnHeader
        Me.chTelefono = New System.Windows.Forms.ColumnHeader
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar_dni)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtbuscar_ruc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtbuscar_razonsocial)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'txtbuscar_dni
        '
        Me.txtbuscar_dni.Location = New System.Drawing.Point(496, 28)
        Me.txtbuscar_dni.MaxLength = 8
        Me.txtbuscar_dni.Name = "txtbuscar_dni"
        Me.txtbuscar_dni.Size = New System.Drawing.Size(124, 20)
        Me.txtbuscar_dni.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dni:"
        '
        'txtbuscar_ruc
        '
        Me.txtbuscar_ruc.Location = New System.Drawing.Point(319, 28)
        Me.txtbuscar_ruc.MaxLength = 11
        Me.txtbuscar_ruc.Name = "txtbuscar_ruc"
        Me.txtbuscar_ruc.Size = New System.Drawing.Size(124, 20)
        Me.txtbuscar_ruc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ruc:"
        '
        'txtbuscar_razonsocial
        '
        Me.txtbuscar_razonsocial.Location = New System.Drawing.Point(80, 28)
        Me.txtbuscar_razonsocial.MaxLength = 100
        Me.txtbuscar_razonsocial.Name = "txtbuscar_razonsocial"
        Me.txtbuscar_razonsocial.Size = New System.Drawing.Size(187, 20)
        Me.txtbuscar_razonsocial.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Razón Social:"
        '
        'lstClientes
        '
        Me.lstClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstClientes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId_Cliente, Me.chRazon_social, Me.chRuc, Me.chDni, Me.chDireccion, Me.chTelefono})
        Me.lstClientes.FullRowSelect = True
        Me.lstClientes.GridLines = True
        Me.lstClientes.HideSelection = False
        Me.lstClientes.Location = New System.Drawing.Point(13, 99)
        Me.lstClientes.MultiSelect = False
        Me.lstClientes.Name = "lstClientes"
        Me.lstClientes.Size = New System.Drawing.Size(640, 313)
        Me.lstClientes.TabIndex = 1
        Me.lstClientes.UseCompatibleStateImageBehavior = False
        Me.lstClientes.View = System.Windows.Forms.View.Details
        '
        'chId_Cliente
        '
        Me.chId_Cliente.Text = "Código"
        Me.chId_Cliente.Width = 50
        '
        'chRazon_social
        '
        Me.chRazon_social.Text = "Razón Social"
        Me.chRazon_social.Width = 150
        '
        'chRuc
        '
        Me.chRuc.Text = "Ruc"
        Me.chRuc.Width = 80
        '
        'chDni
        '
        Me.chDni.Text = "Dni"
        Me.chDni.Width = 80
        '
        'chDireccion
        '
        Me.chDireccion.Text = "Dirección"
        Me.chDireccion.Width = 190
        '
        'chTelefono
        '
        Me.chTelefono.Text = "Teléfono"
        Me.chTelefono.Width = 80
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(498, 422)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Location = New System.Drawing.Point(579, 422)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmListarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(665, 457)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lstClientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListarClientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE CLIENTES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar_razonsocial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar_ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbuscar_dni As System.Windows.Forms.TextBox
    Friend WithEvents lstClientes As System.Windows.Forms.ListView
    Friend WithEvents chId_Cliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRazon_social As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRuc As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDni As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDireccion As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTelefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
