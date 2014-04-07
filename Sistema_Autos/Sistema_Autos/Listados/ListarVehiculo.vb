Imports Reglas_Negocio
Imports Entidades
Public Class frmListarVehiculo
    Dim nVehiculo As New RNVehiculo
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objVehiculo As Vehiculo
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmListarVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_cliente.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objVehiculo = CType(Me.lstVehiculos.SelectedItems(0).Tag, Vehiculo)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstVehiculos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstVehiculos.KeyPress
        If Me.lstVehiculos.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub lstVehiculos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVehiculos.SelectedIndexChanged
        If Me.lstVehiculos.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub lstVehiculos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstVehiculos.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------

    Sub ActualizaLista()
        Try
            Me.lstVehiculos.Items.Clear()
            Tabla = nVehiculo.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objV As New Vehiculo
            Item.Text = CStr(Fila.Item("id_vehiculo"))
            Item.SubItems.Add(CStr(Fila.Item("razon_social"))) 'Modified 2014.03.23
            Item.SubItems.Add(CStr(Fila.Item("placa")))
            Item.SubItems.Add(CStr(Fila.Item("id_marca")))
            Item.SubItems.Add(CStr(Fila.Item("modelo")))
            Item.SubItems.Add(CStr(Fila.Item("tipo_vehiculo")))
            objV.id_vehiculo = Fila.Item("id_vehiculo")
            objV.id_cliente = Fila.Item("id_cliente")
            objV.placa = Fila.Item("placa")
            objV.id_marca = Fila.Item("id_marca")
            objV.modelo = Fila.Item("modelo")
            objV.tipo_vehiculo = Fila.Item("tipo_vehiculo")
            Item.Tag = objV
            Me.lstVehiculos.Items.Add(Item)
        Next
    End Sub


    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstVehiculos.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objV As New Vehiculo
                Item.Text = CStr(Fila.Item("id_vehiculo"))
                Item.SubItems.Add(CStr(Fila.Item("razon_social"))) 'Modified 2014.03.23
                Item.SubItems.Add(CStr(Fila.Item("placa")))
                Item.SubItems.Add(CStr(Fila.Item("id_marca")))
                Item.SubItems.Add(CStr(Fila.Item("modelo")))
                Item.SubItems.Add(CStr(Fila.Item("tipo_vehiculo")))

                objV.id_vehiculo = Fila.Item("id_vehiculo")
                objV.id_cliente = Fila.Item("id_cliente")
                objV.placa = Fila.Item("placa")
                objV.id_marca = Fila.Item("id_marca")
                objV.modelo = Fila.Item("modelo")
                objV.tipo_vehiculo = Fila.Item("tipo_vehiculo")
                Item.Tag = objV
                Me.lstVehiculos.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtbuscar_cliente.TextChanged, txtbuscar_placa.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("id_cliente LIKE '%{0}%' AND placa LIKE '%{1}%'", Me.txtbuscar_cliente.Text, Me.txtbuscar_placa.Text)
        LlenaLista(Vista)
        'Added 2014.03.23
        Me.btnAceptar.Enabled = False
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_cliente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class