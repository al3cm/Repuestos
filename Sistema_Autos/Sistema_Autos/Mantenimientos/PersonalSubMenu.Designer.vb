<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalSubMenu
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
        Me.chkNuevo = New System.Windows.Forms.CheckBox
        Me.chkModificar = New System.Windows.Forms.CheckBox
        Me.chkEliminar = New System.Windows.Forms.CheckBox
        Me.chkBuscar = New System.Windows.Forms.CheckBox
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'chkNuevo
        '
        Me.chkNuevo.AutoSize = True
        Me.chkNuevo.Location = New System.Drawing.Point(12, 12)
        Me.chkNuevo.Name = "chkNuevo"
        Me.chkNuevo.Size = New System.Drawing.Size(58, 17)
        Me.chkNuevo.TabIndex = 0
        Me.chkNuevo.Text = "Grabar"
        Me.chkNuevo.UseVisualStyleBackColor = True
        '
        'chkModificar
        '
        Me.chkModificar.AutoSize = True
        Me.chkModificar.Location = New System.Drawing.Point(122, 12)
        Me.chkModificar.Name = "chkModificar"
        Me.chkModificar.Size = New System.Drawing.Size(69, 17)
        Me.chkModificar.TabIndex = 1
        Me.chkModificar.Text = "Modificar"
        Me.chkModificar.UseVisualStyleBackColor = True
        '
        'chkEliminar
        '
        Me.chkEliminar.AutoSize = True
        Me.chkEliminar.Location = New System.Drawing.Point(12, 47)
        Me.chkEliminar.Name = "chkEliminar"
        Me.chkEliminar.Size = New System.Drawing.Size(62, 17)
        Me.chkEliminar.TabIndex = 2
        Me.chkEliminar.Text = "Eliminar"
        Me.chkEliminar.UseVisualStyleBackColor = True
        '
        'chkBuscar
        '
        Me.chkBuscar.AutoSize = True
        Me.chkBuscar.Location = New System.Drawing.Point(122, 47)
        Me.chkBuscar.Name = "chkBuscar"
        Me.chkBuscar.Size = New System.Drawing.Size(59, 17)
        Me.chkBuscar.TabIndex = 3
        Me.chkBuscar.Text = "Buscar"
        Me.chkBuscar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(128, 81)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(47, 81)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'PersonalSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(215, 116)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.chkModificar)
        Me.Controls.Add(Me.chkBuscar)
        Me.Controls.Add(Me.chkEliminar)
        Me.Controls.Add(Me.chkNuevo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PersonalSubMenu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERMISOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkNuevo As System.Windows.Forms.CheckBox
    Friend WithEvents chkModificar As System.Windows.Forms.CheckBox
    Friend WithEvents chkEliminar As System.Windows.Forms.CheckBox
    Friend WithEvents chkBuscar As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
End Class
