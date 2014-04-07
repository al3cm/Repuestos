<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarPersonal
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
        Me.txtDNI = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtApellidoMat = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtApellidoPat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstPersonal = New System.Windows.Forms.ListView
        Me.chId_Personal = New System.Windows.Forms.ColumnHeader
        Me.chNombres = New System.Windows.Forms.ColumnHeader
        Me.chApPaterno = New System.Windows.Forms.ColumnHeader
        Me.chApMaterno = New System.Windows.Forms.ColumnHeader
        Me.chDni = New System.Windows.Forms.ColumnHeader
        Me.chDireccion = New System.Windows.Forms.ColumnHeader
        Me.chTelefono = New System.Windows.Forms.ColumnHeader
        Me.chCargo = New System.Windows.Forms.ColumnHeader
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnAgregarPermisos = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtApellidoMat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtApellidoPat)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(678, 68)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(547, 28)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(111, 20)
        Me.txtDNI.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(515, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dni:"
        '
        'txtApellidoMat
        '
        Me.txtApellidoMat.Location = New System.Drawing.Point(328, 28)
        Me.txtApellidoMat.MaxLength = 50
        Me.txtApellidoMat.Name = "txtApellidoMat"
        Me.txtApellidoMat.Size = New System.Drawing.Size(177, 20)
        Me.txtApellidoMat.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ap. Materno:"
        '
        'txtApellidoPat
        '
        Me.txtApellidoPat.Location = New System.Drawing.Point(74, 28)
        Me.txtApellidoPat.MaxLength = 50
        Me.txtApellidoPat.Name = "txtApellidoPat"
        Me.txtApellidoPat.Size = New System.Drawing.Size(177, 20)
        Me.txtApellidoPat.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ap. Paterno:"
        '
        'lstPersonal
        '
        Me.lstPersonal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstPersonal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId_Personal, Me.chNombres, Me.chApPaterno, Me.chApMaterno, Me.chDni, Me.chDireccion, Me.chTelefono, Me.chCargo})
        Me.lstPersonal.FullRowSelect = True
        Me.lstPersonal.GridLines = True
        Me.lstPersonal.HideSelection = False
        Me.lstPersonal.Location = New System.Drawing.Point(12, 87)
        Me.lstPersonal.MultiSelect = False
        Me.lstPersonal.Name = "lstPersonal"
        Me.lstPersonal.Size = New System.Drawing.Size(679, 251)
        Me.lstPersonal.TabIndex = 1
        Me.lstPersonal.UseCompatibleStateImageBehavior = False
        Me.lstPersonal.View = System.Windows.Forms.View.Details
        '
        'chId_Personal
        '
        Me.chId_Personal.Text = "Código"
        Me.chId_Personal.Width = 45
        '
        'chNombres
        '
        Me.chNombres.Text = "Nombres"
        Me.chNombres.Width = 90
        '
        'chApPaterno
        '
        Me.chApPaterno.Text = "Ap. Paterno"
        Me.chApPaterno.Width = 90
        '
        'chApMaterno
        '
        Me.chApMaterno.Text = "Ap. Materno"
        Me.chApMaterno.Width = 90
        '
        'chDni
        '
        Me.chDni.Text = "Dni"
        '
        'chDireccion
        '
        Me.chDireccion.Text = "Direccion"
        Me.chDireccion.Width = 143
        '
        'chTelefono
        '
        Me.chTelefono.Text = "Teléfono"
        Me.chTelefono.Width = 65
        '
        'chCargo
        '
        Me.chCargo.Text = "Cargo"
        Me.chCargo.Width = 73
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(616, 344)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(535, 344)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnAgregarPermisos
        '
        Me.btnAgregarPermisos.Location = New System.Drawing.Point(414, 344)
        Me.btnAgregarPermisos.Name = "btnAgregarPermisos"
        Me.btnAgregarPermisos.Size = New System.Drawing.Size(115, 23)
        Me.btnAgregarPermisos.TabIndex = 2
        Me.btnAgregarPermisos.Text = "&Agregar Permisos"
        Me.btnAgregarPermisos.UseVisualStyleBackColor = True
        '
        'frmListarPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(703, 379)
        Me.Controls.Add(Me.btnAgregarPermisos)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lstPersonal)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListarPersonal"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DEL PERSONAL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPat As System.Windows.Forms.TextBox
    Friend WithEvents txtApellidoMat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstPersonal As System.Windows.Forms.ListView
    Friend WithEvents chId_Personal As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNombres As System.Windows.Forms.ColumnHeader
    Friend WithEvents chApPaterno As System.Windows.Forms.ColumnHeader
    Friend WithEvents chApMaterno As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDni As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDireccion As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTelefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCargo As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnAgregarPermisos As System.Windows.Forms.Button
End Class
