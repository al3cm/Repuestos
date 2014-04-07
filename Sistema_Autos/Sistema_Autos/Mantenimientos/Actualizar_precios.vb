Imports Entidades
Imports Reglas_Negocio
Imports Microsoft.Office.Interop
Public Class frmActualizar_precios
    Dim objProducto As New Producto
    Dim Vista As DataView
    Dim Tabla As DataTable
    Dim nProducto As New RNProducto
    
    Private Sub frmActualizar_precios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tag = RNPersonalSubMenu.ListarPersonalSubMenu(CType(Me.Tag, Personal_SubMenu).id_menu, CType(Me.Tag, Personal_SubMenu).id_submenu, CType(Me.Tag, Personal_SubMenu).id_personal)
            If Me.Tag Is Nothing Then
                MessageBox.Show("Error al asignar archivos, consulte con el Administrador del Sstema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            Me.btnGrabar.Enabled = False
            'Limpiar()
            'LlenaCombos()
            ActualizaLista()
            Me.txtfiltro_producto.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Consultar()
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        'Modificar()
    End Sub
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        'Exportar()
    End Sub

    Private Sub dgvProducto_DoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProducto.DoubleClick
        Dim DGV As DataGridView
        Dim Id_Producto As Integer
        Dim Producto As String
        Dim Costo As Double
        Dim Precio As Double
        DGV = Me.dgvProducto
        Id_Producto = DGV.Item(0, e.RowIndex).Value
        Producto = DGV.Item(1, e.RowIndex).Value
        Costo = DGV.Item(6, e.RowIndex).Value
        Precio = DGV.Item(7, e.RowIndex).Value
        Me.TxtidProducto.Text = Producto
        Me.txtCosto.Text = Costo
        Me.txtPrecio.Text = Precio
        Me.btnGrabar.Enabled = True
        DGV.Rows.Remove(DGV.CurrentRow)
        DGV.Refresh()
    End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.dgvProducto.Rows.Clear()
            Tabla = nProducto.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        Me.dgvProducto.Rows.Clear()
        For Each Fila As DataRow In Datos.Rows
            Dim objPROD As New Producto
            objPROD.id_producto = Fila.Item("id_producto")
            objPROD.nombre_producto = Fila.Item("nombre_producto")
            objPROD.codigo_producto = Fila.Item("codigo_producto")
            objPROD.id_unidad = Fila.Item("id_unidad")
            objPROD.id_marca = Fila.Item("id_marca")
            objPROD.id_linea = Fila.Item("id_linea")
            objPROD.precio_compra = Fila.Item("precio_compra")
            objPROD.precio_venta = Fila.Item("precio_venta")
            Me.dgvProducto.Rows.Add(objPROD.id_producto, objPROD.nombre_producto, objPROD.codigo_producto, objPROD.id_unidad, objPROD.id_marca, objPROD.id_linea, objPROD.precio_compra, objPROD.precio_venta)
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.dgvProducto.Rows.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim objPROD As New Producto
                objPROD.id_producto = Fila.Item("id_producto")
                objPROD.nombre_producto = Fila.Item("nombre_producto")
                objPROD.codigo_producto = Fila.Item("codigo_producto")
                objPROD.id_unidad = Fila.Item("id_unidad")
                objPROD.id_marca = Fila.Item("id_marca")
                objPROD.id_linea = Fila.Item("id_linea")
                objPROD.precio_compra = Fila.Item("precio_compra")
                objPROD.precio_venta = Fila.Item("precio_venta")
                Me.dgvProducto.Rows.Add(objPROD.id_producto, objPROD.nombre_producto, objPROD.codigo_producto, objPROD.id_unidad, objPROD.id_marca, objPROD.id_linea, objPROD.precio_compra, objPROD.precio_venta)
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Filtrar() Handles txtfiltro_producto.TextChanged, txtCodigo.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("nombre_producto LIKE '%{0}%' AND codigo_producto LIKE '%{1}%'", Me.txtfiltro_producto.Text, Me.txtCodigo.Text)
        LlenaLista(Vista)
    End Sub
    Private Sub Consultar() Handles cboLinea.SelectedValueChanged, cboMarca.SelectedValueChanged, cboUnidad.SelectedValueChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("id_marca = '{0}' AND id_marca '{1}'  AND id_unidad '{2}'", cboLinea.SelectedValue, cboMarca.SelectedValue, cboUnidad.SelectedValue)
        LlenaLista(Vista)
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------

End Class