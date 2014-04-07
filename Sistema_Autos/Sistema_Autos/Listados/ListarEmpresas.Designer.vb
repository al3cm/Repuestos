<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarEmpresas
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
        Me.txtfiltro_ruc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtfiltro_razon_social = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstEmpresas = New System.Windows.Forms.ListView
        Me.chCodigo = New System.Windows.Forms.ColumnHeader
        Me.chRazonSocial = New System.Windows.Forms.ColumnHeader
        Me.chRuc = New System.Windows.Forms.ColumnHeader
        Me.chDireccion = New System.Windows.Forms.ColumnHeader
        Me.chTelefono = New System.Windows.Forms.ColumnHeader
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtfiltro_ruc)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtfiltro_razon_social)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 71)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'txtfiltro_ruc
        '
        Me.txtfiltro_ruc.Location = New System.Drawing.Point(313, 26)
        Me.txtfiltro_ruc.Name = "txtfiltro_ruc"
        Me.txtfiltro_ruc.Size = New System.Drawing.Size(131, 20)
        Me.txtfiltro_ruc.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RUC:"
        '
        'txtfiltro_razon_social
        '
        Me.txtfiltro_razon_social.Location = New System.Drawing.Point(85, 26)
        Me.txtfiltro_razon_social.Name = "txtfiltro_razon_social"
        Me.txtfiltro_razon_social.Size = New System.Drawing.Size(174, 20)
        Me.txtfiltro_razon_social.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Razón Social:"
        '
        'lstEmpresas
        '
        Me.lstEmpresas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstEmpresas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chCodigo, Me.chRazonSocial, Me.chRuc, Me.chDireccion, Me.chTelefono})
        Me.lstEmpresas.FullRowSelect = True
        Me.lstEmpresas.GridLines = True
        Me.lstEmpresas.HideSelection = False
        Me.lstEmpresas.Location = New System.Drawing.Point(12, 90)
        Me.lstEmpresas.Name = "lstEmpresas"
        Me.lstEmpresas.Size = New System.Drawing.Size(468, 247)
        Me.lstEmpresas.TabIndex = 1
        Me.lstEmpresas.UseCompatibleStateImageBehavior = False
        Me.lstEmpresas.View = System.Windows.Forms.View.Details
        '
        'chCodigo
        '
        Me.chCodigo.Text = "Código"
        Me.chCodigo.Width = 55
        '
        'chRazonSocial
        '
        Me.chRazonSocial.Text = "Razón Social"
        Me.chRazonSocial.Width = 120
        '
        'chRuc
        '
        Me.chRuc.Text = "RUC"
        Me.chRuc.Width = 80
        '
        'chDireccion
        '
        Me.chDireccion.Text = "Dirección"
        Me.chDireccion.Width = 140
        '
        'chTelefono
        '
        Me.chTelefono.Text = "Teléfono"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(325, 343)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(406, 343)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'frmListarEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(492, 375)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lstEmpresas)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmListarEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE EMPRESAS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtfiltro_ruc As System.Windows.Forms.TextBox
    Friend WithEvents lstEmpresas As System.Windows.Forms.ListView
    Friend WithEvents chCodigo As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRazonSocial As System.Windows.Forms.ColumnHeader
    Friend WithEvents chRuc As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDireccion As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTelefono As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
