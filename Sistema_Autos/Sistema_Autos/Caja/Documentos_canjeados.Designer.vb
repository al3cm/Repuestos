<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentos_canjeados
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtbuscar_razonsocial = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.lstBuscar_canje = New System.Windows.Forms.ListView
        Me.chNro_canje = New System.Windows.Forms.ColumnHeader
        Me.chCliente = New System.Windows.Forms.ColumnHeader
        Me.chTotal = New System.Windows.Forms.ColumnHeader
        Me.chMoneda = New System.Windows.Forms.ColumnHeader
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CANJE DE DOCUMENTOS POR COBRAR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbuscar_razonsocial)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 69)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar por:"
        '
        'txtbuscar_razonsocial
        '
        Me.txtbuscar_razonsocial.Location = New System.Drawing.Point(80, 28)
        Me.txtbuscar_razonsocial.MaxLength = 100
        Me.txtbuscar_razonsocial.Name = "txtbuscar_razonsocial"
        Me.txtbuscar_razonsocial.Size = New System.Drawing.Size(283, 20)
        Me.txtbuscar_razonsocial.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Razón Social:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(305, 409)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(386, 409)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lstBuscar_canje
        '
        Me.lstBuscar_canje.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNro_canje, Me.chCliente, Me.chTotal, Me.chMoneda})
        Me.lstBuscar_canje.FullRowSelect = True
        Me.lstBuscar_canje.GridLines = True
        Me.lstBuscar_canje.HideSelection = False
        Me.lstBuscar_canje.Location = New System.Drawing.Point(17, 136)
        Me.lstBuscar_canje.Name = "lstBuscar_canje"
        Me.lstBuscar_canje.Size = New System.Drawing.Size(444, 267)
        Me.lstBuscar_canje.TabIndex = 6
        Me.lstBuscar_canje.UseCompatibleStateImageBehavior = False
        Me.lstBuscar_canje.View = System.Windows.Forms.View.Details
        '
        'chNro_canje
        '
        Me.chNro_canje.Text = "Nro Canje"
        Me.chNro_canje.Width = 80
        '
        'chCliente
        '
        Me.chCliente.Text = "Cliente"
        Me.chCliente.Width = 200
        '
        'chTotal
        '
        Me.chTotal.Text = "Total"
        Me.chTotal.Width = 80
        '
        'chMoneda
        '
        Me.chMoneda.Text = "Moneda"
        Me.chMoneda.Width = 80
        '
        'frmDocumentos_canjeados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(474, 444)
        Me.Controls.Add(Me.lstBuscar_canje)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDocumentos_canjeados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DOCUMENTOS CANJEADOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbuscar_razonsocial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lstBuscar_canje As System.Windows.Forms.ListView
    Friend WithEvents chNro_canje As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCliente As System.Windows.Forms.ColumnHeader
    Friend WithEvents chTotal As System.Windows.Forms.ColumnHeader
    Friend WithEvents chMoneda As System.Windows.Forms.ColumnHeader
End Class
