<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarPersonalSubMenu
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
        Me.lstSubMenu = New System.Windows.Forms.ListView
        Me.chHabilitar = New System.Windows.Forms.ColumnHeader
        Me.chMenu = New System.Windows.Forms.ColumnHeader
        Me.chSubMenu = New System.Windows.Forms.ColumnHeader
        Me.chNuevo = New System.Windows.Forms.ColumnHeader
        Me.chEliminar = New System.Windows.Forms.ColumnHeader
        Me.chModificar = New System.Windows.Forms.ColumnHeader
        Me.chBuscar = New System.Windows.Forms.ColumnHeader
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblUsuario = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lstSubMenu
        '
        Me.lstSubMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstSubMenu.CheckBoxes = True
        Me.lstSubMenu.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chHabilitar, Me.chMenu, Me.chSubMenu, Me.chNuevo, Me.chEliminar, Me.chModificar, Me.chBuscar})
        Me.lstSubMenu.FullRowSelect = True
        Me.lstSubMenu.GridLines = True
        Me.lstSubMenu.HideSelection = False
        Me.lstSubMenu.Location = New System.Drawing.Point(12, 34)
        Me.lstSubMenu.MultiSelect = False
        Me.lstSubMenu.Name = "lstSubMenu"
        Me.lstSubMenu.Size = New System.Drawing.Size(673, 413)
        Me.lstSubMenu.TabIndex = 2
        Me.lstSubMenu.UseCompatibleStateImageBehavior = False
        Me.lstSubMenu.View = System.Windows.Forms.View.Details
        '
        'chHabilitar
        '
        Me.chHabilitar.Text = "Habilitar"
        Me.chHabilitar.Width = 57
        '
        'chMenu
        '
        Me.chMenu.Text = "Menú"
        Me.chMenu.Width = 154
        '
        'chSubMenu
        '
        Me.chSubMenu.Text = "Sub Menú"
        Me.chSubMenu.Width = 202
        '
        'chNuevo
        '
        Me.chNuevo.Text = "Nuevo"
        Me.chNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chNuevo.Width = 57
        '
        'chEliminar
        '
        Me.chEliminar.Text = "Eliminar"
        Me.chEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chEliminar.Width = 58
        '
        'chModificar
        '
        Me.chModificar.Text = "Modificar"
        Me.chModificar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chBuscar
        '
        Me.chBuscar.Text = "Buscar"
        Me.chBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.chBuscar.Width = 57
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre de Usuario:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(116, 9)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuario"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(610, 453)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "&Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(529, 453)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "&Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'ListarPersonalSubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(697, 485)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstSubMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListarPersonalSubMenu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LISTADO DE SUBMENÚ POR PERSONAL"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSubMenu As System.Windows.Forms.ListView
    Friend WithEvents chMenu As System.Windows.Forms.ColumnHeader
    Friend WithEvents chSubMenu As System.Windows.Forms.ColumnHeader
    Friend WithEvents chNuevo As System.Windows.Forms.ColumnHeader
    Friend WithEvents chEliminar As System.Windows.Forms.ColumnHeader
    Friend WithEvents chModificar As System.Windows.Forms.ColumnHeader
    Friend WithEvents chBuscar As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents chHabilitar As System.Windows.Forms.ColumnHeader
End Class
