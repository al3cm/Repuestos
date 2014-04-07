Imports Reglas_Negocio
Imports Entidades
Public Class frmListarProveedores
    Dim nProveedor As New RNProveedor
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objProveedor As Proveedor
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmListarProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_proveedor.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objProveedor = CType(Me.lstProveedores.SelectedItems(0).Tag, Proveedor)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstProveedores_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstProveedores.KeyPress
        If Me.lstProveedores.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub lstProveedores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProveedores.SelectedIndexChanged
        If Me.lstProveedores.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub


    Private Sub lstProveedores_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProveedores.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------

    Sub ActualizaLista()
        Try
            Me.lstProveedores.Items.Clear()
            Tabla = nProveedor.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objPRO As New Proveedor
            Item.Text = CStr(Fila.Item("id_proveedor"))
            ' Item.SubItems.Add(CStr(Fila.Item("id_ubigeo")))
            Item.SubItems.Add(CStr(Fila.Item("razon_social")))
            Item.SubItems.Add(CStr(Fila.Item("ruc")))
            Item.SubItems.Add(CStr(Fila.Item("direccion")))
            Item.SubItems.Add(CStr(Fila.Item("telefono")))
            Item.SubItems.Add(CStr(Fila.Item("fax")))
            Item.SubItems.Add(CStr(Fila.Item("email")))
            'Item.SubItems.Add(CStr(Fila.Item("contacto")))
            'Item.SubItems.Add(CStr(Fila.Item("descripcion")))
            'Item.SubItems.Add(CStr(Fila.Item("estado")))
            objPRO.id_proveedor = Fila.Item("id_proveedor")
            objPRO.id_ubigeo = Fila.Item("id_ubigeo")
            objPRO.razon_social = Fila.Item("razon_social")
            objPRO.ruc = Fila.Item("ruc")
            objPRO.direccion = Fila.Item("direccion")
            objPRO.telefono = Fila.Item("telefono")
            objPRO.fax = Fila.Item("fax")
            objPRO.contacto = Fila.Item("contacto")
            objPRO.email = Fila.Item("email")
            objPRO.descripcion = Fila.Item("descripcion")
            objPRO.estado = Fila.Item("estado")
            Item.Tag = objPRO
            Me.lstProveedores.Items.Add(Item)
        Next
    End Sub

    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstProveedores.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objPRO As New Proveedor
                Item.Text = CStr(Fila.Item("id_proveedor"))
                ' Item.SubItems.Add(CStr(Fila.Item("id_ubigeo")))
                Item.SubItems.Add(CStr(Fila.Item("razon_social")))
                Item.SubItems.Add(CStr(Fila.Item("ruc")))
                Item.SubItems.Add(CStr(Fila.Item("direccion")))
                Item.SubItems.Add(CStr(Fila.Item("telefono")))
                Item.SubItems.Add(CStr(Fila.Item("fax")))
                Item.SubItems.Add(CStr(Fila.Item("email")))
                'Item.SubItems.Add(CStr(Fila.Item("contacto")))
                'Item.SubItems.Add(CStr(Fila.Item("descripcion")))
                'Item.SubItems.Add(CStr(Fila.Item("estado")))
                objPRO.id_proveedor = Fila.Item("id_proveedor")
                objPRO.id_ubigeo = Fila.Item("id_ubigeo")
                objPRO.razon_social = Fila.Item("razon_social")
                objPRO.ruc = Fila.Item("ruc")
                objPRO.direccion = Fila.Item("direccion")
                objPRO.telefono = Fila.Item("telefono")
                objPRO.fax = Fila.Item("fax")
                objPRO.contacto = Fila.Item("contacto")
                objPRO.email = Fila.Item("email")
                objPRO.descripcion = Fila.Item("descripcion")
                objPRO.estado = Fila.Item("estado")
                Item.Tag = objPRO
                Me.lstProveedores.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtbuscar_proveedor.TextChanged, txtbuscar_ruc.TextAlignChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("razon_social LIKE '%{0}%' AND ruc LIKE '%{1}%'", Me.txtbuscar_proveedor.Text, Me.txtbuscar_ruc.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_proveedor.KeyPress
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

    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_ruc.KeyPress
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