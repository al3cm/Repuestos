Imports Entidades
Imports Reglas_Negocio
Imports Microsoft.Office.Interop
Public Class frmStock
    Dim objProducto_Almacen As New Producto_Almacen
    Dim Vista As DataView
    Dim Tabla As DataTable
    Dim nProducto_Almacen As New RNProducto_Almacen
    Dim nAlmacen As New RNAlmacen
    Dim nPersonal As New RNPersonal
    Dim Total As Double
    Dim Cantidad As Integer
    Private Sub frmStock_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cantidad = nPersonal.ContraAlmacen_Personal(id_Vededor)
            LlenaCombos()
            Limpiar()
            Me.txtProducto.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboAlmacen_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboAlmacen.SelectedValueChanged
        ActualizaLista()
    End Sub

    Private Sub cboLinea_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLinea.SelectedValueChanged
        ActualizaLista()
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Exportar()
    End Sub
    Sub ActualizaLista()
        Try
            Me.lstListadoStock.Items.Clear()
            If cboLinea.SelectedValue = 0 Then
                Tabla = nProducto_Almacen.ListarAlmacen(Me.cboAlmacen.SelectedValue)
            Else
                Tabla = nProducto_Almacen.Listar(Me.cboAlmacen.SelectedValue, Me.cboLinea.SelectedValue)
            End If
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        Total = 0.0
        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objPROD As New Producto
            Dim objUNID As New Unidad
            Dim objLINE As New Linea
            Dim objMARC As New Marca
            Dim objPREC As New Precio
            Item.Text = CStr(Fila.Item("nombre_producto"))
            Item.SubItems.Add(CStr(Fila.Item("codigo_producto")))
            Item.SubItems.Add(CStr(Fila.Item("Unidad")))
            Item.SubItems.Add(CStr(Fila.Item("Marca")))
            Item.SubItems.Add(CStr(Fila.Item("stock")))
            Item.SubItems.Add(CStr(Fila.Item("precio_compra")))
            Item.SubItems.Add(CStr(Fila.Item("precio_venta")))
            objPROD.id_producto = Fila.Item("id_producto")
            objPROD.nombre_producto = Fila.Item("nombre_producto")
            objPROD.codigo_producto = Fila.Item("codigo_producto")
            objUNID.id_unidad = Fila.Item("id_unidad")
            objUNID.abreviatura = Fila.Item("Unidad")
            objPROD.id_linea = Fila.Item("id_linea")
            objLINE.descripcion = Fila.Item("Linea")
            objPROD.id_marca = Fila.Item("id_marca")
            objMARC.descripcion = Fila.Item("Marca")
            objProducto_Almacen.stock = Fila.Item("stock")
            objPREC.precio_compra = Fila.Item("precio_compra")
            objPREC.precio_venta = Fila.Item("precio_venta")
            objPREC.precio_trajecta = Fila.Item("precio_trajecta")
            Item.Tag = objPROD
            Total = Total + objPREC.precio_venta
            Me.lstListadoStock.Items.Add(Item)
        Next
        Me.txtTotal.Text = Total
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstListadoStock.Items.Clear()
            Total = 0.0
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objPROD As New Producto
                Dim objUNID As New Unidad
                Dim objLINE As New Linea
                Dim objMARC As New Marca
                Dim objPREC As New Precio
                Item.Text = CStr(Fila.Item("nombre_producto"))
                Item.SubItems.Add(CStr(Fila.Item("codigo_producto")))
                Item.SubItems.Add(CStr(Fila.Item("Unidad")))
                Item.SubItems.Add(CStr(Fila.Item("Marca")))
                Item.SubItems.Add(CStr(Fila.Item("stock")))
                Item.SubItems.Add(CStr(Fila.Item("precio_compra")))
                Item.SubItems.Add(CStr(Fila.Item("precio_venta")))
                objPROD.id_producto = Fila.Item("id_producto")
                objPROD.nombre_producto = Fila.Item("nombre_producto")
                objPROD.codigo_producto = Fila.Item("codigo_producto")
                objUNID.id_unidad = Fila.Item("id_unidad")
                objUNID.abreviatura = Fila.Item("Unidad")
                objPROD.id_linea = Fila.Item("id_linea")
                objLINE.descripcion = Fila.Item("Linea")
                objPROD.id_marca = Fila.Item("id_marca")
                objMARC.descripcion = Fila.Item("Marca")
                objProducto_Almacen.stock = Fila.Item("stock")
                objPREC.precio_compra = Fila.Item("precio_compra")
                objPREC.precio_venta = Fila.Item("precio_venta")
                objPREC.precio_trajecta = Fila.Item("precio_trajecta")
                Item.Tag = objPROD
                Total = Total + objPREC.precio_venta
                Me.lstListadoStock.Items.Add(Item)
            Next
            Me.txtTotal.Text = Total
        Catch ex As Exception
            Me.txtTotal.Text = ""
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Filtrar() Handles txtProducto.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("nombre_producto LIKE '%{0}%'", Me.txtProducto.Text)
        LlenaLista(Vista)
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    Sub Exportar()
        Try
            Dim xla As New Microsoft.Office.Interop.Excel.Application()
            xla.Visible = True

            Dim wb As Microsoft.Office.Interop.Excel.Workbook = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet)

            Dim ws As Microsoft.Office.Interop.Excel.Worksheet = DirectCast(xla.ActiveSheet, Microsoft.Office.Interop.Excel.Worksheet)

            Dim i As Integer = 1
            Dim j As Integer = 1
            Dim jj As Integer = lstListadoStock.Columns.Count

            For rr = 0 To lstListadoStock.Columns.Count - 1
                ws.Cells(i, j) = lstListadoStock.Columns(rr).Text
                j = j + 1
            Next
            i = 2
            j = 1
            For Each comp As ListViewItem In lstListadoStock.Items
                ws.Cells(i, j) = comp.Text.ToString()
                For Each drv As ListViewItem.ListViewSubItem In comp.SubItems
                    ws.Cells(i, j) = drv.Text.ToString()
                    j += 1
                Next
                j = 1
                i += 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        If Cantidad = 1 Then
            Tabla = nPersonal.ListarAlmacen_Personal(id_Vededor)
            For Each Fila As DataRow In Tabla.Rows
                Me.cboAlmacen.SelectedValue = Fila.Item("id_almacen")
                Me.cboAlmacen.Enabled = False
            Next
        Else
            Me.cboAlmacen.SelectedValue = "1"
            Me.cboAlmacen.Enabled = True
        End If
    End Sub
    Sub LlenaCombos()
        Try
            Dim Almacen As DataTable = nAlmacen.Listar()
            Me.cboAlmacen.ValueMember = "id_almacen"
            Me.cboAlmacen.DisplayMember = "descripcion"
            If Almacen.Rows.Count > 0 Then
                Me.cboAlmacen.DataSource = Almacen
            Else
                Dim SinAlmacen As New DataTable
                SinAlmacen.Columns.Add("id_almacen")
                SinAlmacen.Columns.Add("descripcion")
                SinAlmacen.Rows.Add("1", "No hay Almacenes registradas")
                Me.cboAlmacen.DataSource = SinAlmacen
                Me.cboAlmacen.ValueMember = "id_almacen"
                Me.cboAlmacen.DisplayMember = "descripcion"
                Me.cboAlmacen.SelectedValue = "1"
            End If
            Dim Linea As New DataTable
            Linea.Columns.Add("id_Linea")
            Linea.Columns.Add("descripcion")
            Linea.Rows.Add("0", "Todas Las Lineas")
            Me.cboLinea.ValueMember = "id_Linea"
            Me.cboLinea.DisplayMember = "descripcion"
            Dim ConLinea As DataTable = RNLinea.Listar
            If ConLinea.Rows.Count > 0 Then
                For Each Fila As DataRow In ConLinea.Rows
                    Linea.Rows.Add(Fila.Item("id_Linea"), Fila.Item("descripcion"))
                    Me.cboLinea.DataSource = Linea
                Next
            Else
                Dim SinLinea As New DataTable
                SinLinea.Columns.Add("id_Linea")
                SinLinea.Columns.Add("descripcion")
                SinLinea.Rows.Add("0", "No hay Linea registradas")
                Me.cboLinea.DataSource = SinLinea
                Me.cboLinea.ValueMember = "id_Linea"
                Me.cboLinea.DisplayMember = "descripcion"
                Me.cboLinea.SelectedValue = "0"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class