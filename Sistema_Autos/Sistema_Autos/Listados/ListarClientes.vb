Imports Reglas_Negocio
Imports Entidades
Public Class frmListarClientes
    Dim nCliente As New RNCliente
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objCliente As Cliente
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmListarClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_razonsocial.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objCliente = CType(Me.lstClientes.SelectedItems(0).Tag, Cliente)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstClientes_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstClientes.KeyPress
        If Me.lstClientes.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub


    Private Sub lstClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstClientes.SelectedIndexChanged
        If Me.lstClientes.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub


    Private Sub lstClientes_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstClientes.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------

    Sub ActualizaLista()
        Try
            Me.lstClientes.Items.Clear()
            Tabla = RNCliente.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objC As New Cliente
            Item.Text = CStr(Fila.Item("id_cliente"))
            Item.SubItems.Add(CStr(Fila.Item("razon_social")))
            Item.SubItems.Add(CStr(Fila.Item("ruc")))
            Item.SubItems.Add(CStr(Fila.Item("dni")))
            Item.SubItems.Add(CStr(Fila.Item("direccion")))
            Item.SubItems.Add(CStr(Fila.Item("telefono")).Trim & "-" & CStr(Fila.Item("celular")).Trim)
            Item.SubItems.Add(CStr(Fila.Item("estado")))
            If Fila.Item("tipo_cliente") = "J" Then
                Item.SubItems.Add("Juridica")
            ElseIf Fila.Item("tipo_cliente") = "N" Then
                Item.SubItems.Add("Natural")
            End If
            objC.id_cliente = Fila.Item("id_cliente")
            objC.razon_social = Fila.Item("razon_social")
            objC.ruc = Fila.Item("ruc")
            objC.dni = Fila.Item("dni")
            objC.direccion = Fila.Item("direccion")
            objC.telefono = Fila.Item("telefono")
            objC.celular = Fila.Item("celular")
            objC.estado = Fila.Item("estado")
            objC.tipo_cliente = Fila.Item("tipo_cliente")
            Item.Tag = objC
            Me.lstClientes.Items.Add(Item)
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstClientes.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objC As New Cliente
                Item.Text = CStr(Fila.Item("id_cliente"))
                Item.SubItems.Add(CStr(Fila.Item("razon_social")))
                Item.SubItems.Add(CStr(Fila.Item("ruc")))
                Item.SubItems.Add(CStr(Fila.Item("dni")))
                Item.SubItems.Add(CStr(Fila.Item("direccion")))
                Item.SubItems.Add(CStr(Fila.Item("telefono")).Trim & "-" & CStr(Fila.Item("celular")).Trim)
                Item.SubItems.Add(CStr(Fila.Item("estado")))
                If Fila.Item("tipo_cliente") = "J" Then
                    Item.SubItems.Add("Juridica")
                ElseIf Fila.Item("tipo_cliente") = "N" Then
                    Item.SubItems.Add("Natural")
                End If
                objC.id_cliente = Fila.Item("id_cliente")
                objC.razon_social = Fila.Item("razon_social")
                objC.ruc = Fila.Item("ruc")
                objC.dni = Fila.Item("dni")
                objC.direccion = Fila.Item("direccion")
                objC.telefono = Fila.Item("telefono")
                objC.celular = Fila.Item("celular")
                objC.estado = Fila.Item("estado")
                objC.tipo_cliente = Fila.Item("tipo_cliente")
                Item.Tag = objC
                Me.lstClientes.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Filtrar() Handles txtbuscar_razonsocial.TextChanged, txtbuscar_ruc.TextChanged, txtbuscar_dni.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("razon_social LIKE '%{0}%' AND ruc LIKE '%{1}%' AND dni LIKE '%{2}%'", Me.txtbuscar_razonsocial.Text, Me.txtbuscar_ruc.Text, Me.txtbuscar_dni.Text)
        LlenaLista(Vista)
        'Added 2014.03.22
        Me.btnAceptar.Enabled = False
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_razonsocial.KeyPress
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

    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_ruc.KeyPress, txtbuscar_dni.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "#" Or e.KeyChar = "*" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class