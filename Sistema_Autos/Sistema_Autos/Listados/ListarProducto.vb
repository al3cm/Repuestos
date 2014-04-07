Imports Reglas_Negocio
Imports Entidades
Public Class frmListarProducto
    Dim nProducto As New RNProducto
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objProducto As Producto
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmListarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_nombre.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objProducto = CType(Me.lstProductos.SelectedItems(0).Tag, Producto)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstProductos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstProductos.KeyPress
        If Me.lstProductos.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub


    Private Sub lstProductos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProductos.SelectedIndexChanged
        If Me.lstProductos.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub


    Private Sub lstProductos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstProductos.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------

    Sub ActualizaLista()
        Try
            Me.lstProductos.Items.Clear()
            Tabla = nProducto.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objPROD As New Producto
            Item.Text = CStr(Fila.Item("id_producto"))
            ' Item.SubItems.Add(CStr(Fila.Item("id_marca")))
            'Item.SubItems.Add(CStr(Fila.Item("id_unidad")))
            'Item.SubItems.Add(CStr(Fila.Item("id_linea")))
            Item.SubItems.Add(CStr(Fila.Item("nombre_producto")))
            Item.SubItems.Add(CStr(Fila.Item("codigo_producto")))
            Item.SubItems.Add(CStr(Fila.Item("modelo_producto")))
            ' Item.SubItems.Add(CStr(Fila.Item("numero_comprobante")))
            'Item.SubItems.Add(Fila.Item("stock"))
            Item.SubItems.Add(Fila.Item("precio_compra"))
            Item.SubItems.Add(Fila.Item("precio_venta"))
            ' Item.SubItems.Add(CStr(Fila.Item("descripcion")))
            objPROD.id_producto = Fila.Item("id_producto")
            objPROD.id_marca = Fila.Item("id_marca")
            objPROD.id_linea = Fila.Item("id_linea")
            objPROD.id_unidad = Fila.Item("id_unidad")
            objPROD.nombre_producto = Fila.Item("nombre_producto")
            objPROD.codigo_producto = Fila.Item("codigo_producto")
            objPROD.modelo_producto = Fila.Item("modelo_producto")
            objPROD.numero_comprobante = Fila.Item("numero_comprobante")
            objPROD.estado = Fila.Item("estado")
            objPROD.precio_venta = Fila.Item("precio_venta")
            objPROD.precio_compra = Fila.Item("precio_compra")
            objPROD.descripcion = Fila.Item("descripcion")
            objPROD.arrImage = Fila.Item("imagen")
            Item.Tag = objPROD
            Me.lstProductos.Items.Add(Item)
        Next
    End Sub

    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstProductos.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objPROD As New Producto
                Item.Text = CStr(Fila.Item("id_producto"))
                ' Item.SubItems.Add(CStr(Fila.Item("id_marca")))
                'Item.SubItems.Add(CStr(Fila.Item("id_unidad")))
                'Item.SubItems.Add(CStr(Fila.Item("id_linea")))
                Item.SubItems.Add(CStr(Fila.Item("nombre_producto")))
                Item.SubItems.Add(CStr(Fila.Item("codigo_producto")))
                Item.SubItems.Add(CStr(Fila.Item("modelo_producto")))
                ' Item.SubItems.Add(CStr(Fila.Item("numero_comprobante")))
                'Item.SubItems.Add(Fila.Item("stock"))
                Item.SubItems.Add(Fila.Item("precio_compra"))
                Item.SubItems.Add(Fila.Item("precio_venta"))
                ' Item.SubItems.Add(CStr(Fila.Item("descripcion")))
                objPROD.id_producto = Fila.Item("id_producto")
                objPROD.id_marca = Fila.Item("id_marca")
                objPROD.id_linea = Fila.Item("id_linea")
                objPROD.id_unidad = Fila.Item("id_unidad")
                objPROD.nombre_producto = Fila.Item("nombre_producto")
                objPROD.codigo_producto = Fila.Item("codigo_producto")
                objPROD.modelo_producto = Fila.Item("modelo_producto")
                objPROD.numero_comprobante = Fila.Item("numero_comprobante")
                objPROD.estado = Fila.Item("estado")
                objPROD.precio_venta = Fila.Item("precio_venta")
                objPROD.precio_compra = Fila.Item("precio_compra")
                objPROD.descripcion = Fila.Item("descripcion")
                Item.Tag = objPROD
                Me.lstProductos.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtbuscar_nombre.TextChanged, txtbuscar_codigo.TextAlignChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("nombre_producto LIKE '%{0}%' AND codigo_producto LIKE '%{1}%'", Me.txtbuscar_nombre.Text, Me.txtbuscar_codigo.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False   'Added 2014.03.22
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_nombre.KeyPress
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

    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_codigo.KeyPress
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