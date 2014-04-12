Imports Entidades
Imports Reglas_Negocio
Imports Microsoft.Office.Interop
Public Class frmOrden_Compra
    Dim nTipo_Cambio As New RNTipo_cambio
    Dim nSucursal As New RNSucursal
    Dim nMoneda As New RNMoneda
    Dim nAlmacen As New RNAlmacen
    Dim nUnidad As New RNUnidad
    Dim nProducto_almacen As New RNProducto_Almacen
    Dim nProveedor As New RNProveedor
    Dim nOrden_Compra As New RNOrden_Compra
    Dim objOrden_Compra As New Orden_Compra
    Dim objProveedor As New Proveedor
    Dim objProducto_almacen As New Producto_Almacen
    Dim objProducto As New Producto
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmOrden_Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' LÓGICA PERMISOS -------------------------------------------------
            Me.Tag = RNPersonalSubMenu.ListarPersonalSubMenu(CType(Me.Tag, Personal_SubMenu).id_menu, CType(Me.Tag, Personal_SubMenu).id_submenu, CType(Me.Tag, Personal_SubMenu).id_personal)
            If Me.Tag Is Nothing Then
                MessageBox.Show("Error al asignar archivos, consulte con el Administrador del Sstema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            ' -----------------------------------------------------------------

            Limpiar()
            LlenaCombos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboSucursal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSucursal.SelectedIndexChanged
        Me.cboAlmacen.Enabled = True
        LlenaAlmacen()
    End Sub
    Private Sub chkigv_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkigv.CheckedChanged
        Sumar()
    End Sub
    Private Sub dtvListado_Productos_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtvListado_Productos.CellContentDoubleClick
        Dim DGV As DataGridView
        Dim Id_Producto As Integer
        Dim Producto As String
        Dim Catidad As Double
        Dim Costo As Double
        Dim Descuento As Double
        Dim Procetaje As Double
        Dim Unidad As String
        Dim id_unidad As Integer
        DGV = Me.dtvListado_Productos
        Id_Producto = DGV.Item(0, e.RowIndex).Value
        Producto = DGV.Item(1, e.RowIndex).Value
        Catidad = DGV.Item(2, e.RowIndex).Value
        Unidad = DGV.Item(3, e.RowIndex).Value
        Costo = DGV.Item(4, e.RowIndex).Value
        Descuento = DGV.Item(5, e.RowIndex).Value
        Procetaje = Descuento * 100 / (Catidad * Costo)
        Me.TxtidProducto.Text = Id_Producto
        Me.txtProducto.Text = Producto
        Me.txtCantidad.Enabled = True
        Me.txtCantidad.Text = Catidad
        Me.txtPrecio_Unitario.Enabled = True
        Me.txtPrecio_Unitario.Text = Costo
        Me.LblProcetaje.Visible = True
        Me.txtDescuento.Enabled = True
        Me.txtDescuento.Text = Procetaje
        Me.cboUnidad.Enabled = True
        id_unidad = nUnidad.BuscarIdUnidad(Unidad)
        LlenaUnidad(id_unidad)
        Me.btnAgregar.Enabled = True
        DGV.Rows.Remove(DGV.CurrentRow)
        DGV.Refresh()
        Sumar()
    End Sub
    Private Sub btnFiltro_Proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro_Proveedor.Click
        If frmListarProveedores.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objProveedor = frmListarProveedores.objProveedor
            Me.txtBuscar_proveedor.Text = objProveedor.razon_social
            Me.TxtDireccion.Text = objProveedor.direccion
            Me.Txtid_proveedor.Text = objProveedor.id_proveedor
        End If
    End Sub

    Private Sub btnFiltro_Producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro_Producto.Click
        If Me.cboTipoPago.SelectedValue = "0" Then
            MessageBox.Show("Selecionar un tipo de Pago")
        ElseIf frmListarProducto.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objProducto = frmListarProducto.objProducto
            Me.txtProducto.Text = objProducto.nombre_producto
            Me.cboUnidad.Enabled = True
            Me.txtCantidad.Enabled = True
            Me.TxtidProducto.Text = objProducto.id_producto
            Me.txtCantidad.Text = "0"
            Me.txtPrecio_Unitario.Enabled = True
            Me.txtPrecio_Unitario.Text = objProducto.precio_compra
            Me.txtDescuento.Enabled = True
            Me.txtDescuento.Text = "0"
            Me.btnAgregar.Enabled = True
            Me.LblProcetaje.Visible = True
            LlenaUnidad(objProducto.id_unidad)
        End If
    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            If Me.btnGrabar.Tag = "Grabar" Then
                Grabar()
            Else
                'Modified 2014.03.25
                If Valida() Then
                    If MessageBox.Show("¿Desea modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        Modificar()
                        Habilitar(False)
                        btnGrabar.Tag = "Grabar"
                        btnGrabar.Enabled = False
                        btnModificar.Tag = "Modificar"
                        btnModificar.Text = "&Modificar"
                        btnNuevo.Enabled = True
                        btnEliminarOrden.Enabled = True
                        btnBuscar.Enabled = True
                        ' LÓGICA PERMISOS -------------------------------------------------
                        If CType(Me.Tag, Personal_SubMenu).nuevo = False Then
                            Me.btnGrabar.Visible = False
                        End If
                        ' -----------------------------------------------------------------
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If btnModificar.Tag = "Modificar" Then
                Habilitar(True)
                btnGrabar.Tag = "Modificar"
                btnGrabar.Enabled = True
                btnModificar.Tag = "Cancelar"
                btnModificar.Text = "&Cancelar"
                btnNuevo.Enabled = False
                btnEliminarOrden.Enabled = False
                btnBuscar.Enabled = False
                ' LÓGICA PERMISOS -------------------------------------------------
                If CType(Me.Tag, Personal_SubMenu).nuevo = False Then
                    Me.btnGrabar.Visible = True
                End If
                ' -----------------------------------------------------------------


            Else
                Habilitar(False)
                btnGrabar.Tag = "Grabar"
                btnGrabar.Enabled = False
                btnModificar.Tag = "Modificar"
                btnModificar.Text = "&Modificar"
                btnNuevo.Enabled = True
                btnEliminarOrden.Enabled = True
                btnBuscar.Enabled = True
                Cargar()
                ' LÓGICA PERMISOS -------------------------------------------------
                If CType(Me.Tag, Personal_SubMenu).nuevo = False Then
                    Me.btnGrabar.Visible = False
                End If
                ' -----------------------------------------------------------------

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarOrden.Click
        Try
            Eliminar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If frmListar_Orden_Compra.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objOrden_Compra = frmListar_Orden_Compra.objOrden_Compra
            Cargar()
            Habilitar(False)
            btnGrabar.Enabled = False
            btnModificar.Tag = "Modificar"
            btnModificar.Text = "&Modificar"
            btnNuevo.Enabled = True
            btnEliminarOrden.Enabled = True
            btnBuscar.Enabled = True
        End If
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Exportar()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim Id_Producto As Integer
        Dim Producto As String
        Dim Cantidad As Integer
        Dim Unidad As String
        Dim costo As Double
        Dim Procetaje As Double
        Dim Descuento As Double
        Dim Total As Double
        Dim estado As Boolean
        Dim TextoError As String = ""
        estado = True
        Id_Producto = Me.TxtidProducto.Text
        Producto = Me.txtProducto.Text
        Cantidad = Me.txtCantidad.Text
        Unidad = Me.cboUnidad.SelectedValue
        costo = Me.txtPrecio_Unitario.Text
        Procetaje = Me.txtDescuento.Text
        Descuento = Cantidad * costo * Procetaje / 100
        Total = Cantidad * costo - Descuento
        If Cantidad = 0 Then
            estado = False
            TextoError = "- Debe ingresar una Cantidad"
        Else
            Dim Dgv As DataGridView
            Dgv = Me.dtvListado_Productos
            Try
                For i As Integer = 0 To Dgv.RowCount - 1
                    If Id_Producto = CDbl(Dgv.Item(0, i).Value) Then
                        estado = False
                        TextoError = "- Producto Ya Igresado"
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        If estado Then
            Me.dtvListado_Productos.Rows.Add(Id_Producto, Producto, Cantidad, Unidad, costo, Descuento, Total)
            Me.TxtidProducto.Text = ""
            Me.txtProducto.Text = ""
            Me.txtCantidad.Text = ""
            Me.cboUnidad.SelectedValue = "0"
            Me.txtPrecio_Unitario.Text = ""
            Me.txtDescuento.Text = ""
            Me.txtCantidad.Enabled = False
            Me.cboUnidad.Enabled = False
            Me.txtPrecio_Unitario.Enabled = False
            Me.txtDescuento.Enabled = False
            Me.btnAgregar.Enabled = False
            Me.btnEliminar.Enabled = True
            Sumar()
        Else
            MessageBox.Show(TextoError)
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim DGV As DataGridView
        DGV = Me.dtvListado_Productos
        DGV.Rows.Remove(DGV.CurrentRow)
        DGV.Refresh()
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    Sub Grabar()
        Try
            If Valida() Then
                objOrden_Compra.fecha_compra = Me.dtpfecha_emision.Value
                objOrden_Compra.total = Me.TxtTotal.Text.Trim
                objOrden_Compra.subtotal = Me.txtPrecio_neto.Text.Trim
                objOrden_Compra.igv = Me.txtigv.Text.Trim
                objOrden_Compra.numero_documento = Me.Txtnumero_documento.Text.ToString
                objOrden_Compra.serie_documento = Me.Txtserie_documento.Text.ToString
                objOrden_Compra.id_proveedor = Me.Txtid_proveedor.Text.Trim
                objOrden_Compra.Tipo_Pago = Me.cboTipoPago.SelectedValue
                objOrden_Compra.id_sucursal = Me.cboSucursal.SelectedValue
                objOrden_Compra.id_Moneda = Me.cboMoneda.SelectedValue
                objOrden_Compra.id_almacen = Me.cboAlmacen.SelectedValue
                If MessageBox.Show("¿Desea registrar los datos de este Orden de Compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If Me.cboMoneda.SelectedValue = "1" Then
                        objOrden_Compra = nOrden_Compra.RegistrarCompra(objOrden_Compra)
                    Else
                        objOrden_Compra.tipo_cambio = 0.0
                        Dim Tabla As DataTable
                        Tabla = nTipo_Cambio.Listar()
                        For Each Fila As DataRow In Tabla.Rows
                            objOrden_Compra.tipo_cambio = Fila.Item("cambio_venta")
                        Next
                        objOrden_Compra = nOrden_Compra.RegistrarCompraConCambion(objOrden_Compra)
                    End If
                    Dim Dgv As DataGridView
                    'Dim Cantidad As Integer
                    Dgv = Me.dtvListado_Productos
                    Try
                        For i As Integer = 0 To Dgv.RowCount - 1
                            objOrden_Compra.id_producto = CInt(Dgv.Item(0, i).Value)
                            objOrden_Compra.cantidad = CInt(Dgv.Item(2, i).Value)
                            objOrden_Compra.precio_compra = CDbl(Dgv.Item(4, i).Value)
                            objOrden_Compra.descuento = CDbl(Dgv.Item(5, i).Value)
                            objOrden_Compra.Sub_Total = CDbl(Dgv.Item(6, i).Value)
                            If objOrden_Compra.id_producto <> 0 Then
                                nOrden_Compra.RegistrarCompra_Producto(objOrden_Compra)
                                objProducto_almacen.id_almacen = Me.cboAlmacen.SelectedValue
                                objProducto_almacen.id_producto = objOrden_Compra.id_producto
                                'Cantidad = nProducto_almacen.ContraProducto_Almacen(objProducto_almacen)
                                'If Cantidad = 0 Then
                                '    objProducto_almacen.descripcion = "el Producto " & (Dgv.Item(1, i).Value) & " Esta en almance " & Me.cboAlmacen.Text
                                '    nProducto_almacen.RegistrarProducto_Almacen(objProducto_almacen)
                                'End If
                            End If
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                    Dim TextoError As String
                    TextoError = "Serie: OC/ " & Me.Txtnumero_documento.Text & " - " & Me.Txtserie_documento.Text
                    MessageBox.Show("Los datos se guardaron satisfactoriamente" & vbCrLf & TextoError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objOrden_Compra.id_compra
                    Me.btnGrabar.Enabled = False
                    Me.btnNuevo.Enabled = True
                    Me.btnModificar.Enabled = True
                    Me.btnExportar.Enabled = True
                    Me.btnEliminarOrden.Enabled = True
                    Me.btnModificar.Tag = "Modificar"
                    Habilitar(False)
                End If
                End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Modificar()
        Try
            objOrden_Compra.fecha_compra = Me.dtpfecha_emision.Value
            objOrden_Compra.id_compra = Me.lblCodigo.Text
            objOrden_Compra.total = Me.TxtTotal.Text.Trim
            objOrden_Compra.subtotal = Me.txtPrecio_neto.Text.Trim
            objOrden_Compra.igv = Me.txtigv.Text.Trim
            objOrden_Compra.numero_documento = Me.Txtnumero_documento.Text.ToString
            objOrden_Compra.serie_documento = Me.Txtserie_documento.Text.ToString
            objOrden_Compra.id_proveedor = Me.Txtid_proveedor.Text.Trim
            objOrden_Compra.Tipo_Pago = Me.cboTipoPago.SelectedValue
            objOrden_Compra.id_sucursal = Me.cboSucursal.SelectedValue
            objOrden_Compra.id_Moneda = Me.cboMoneda.SelectedValue
            objOrden_Compra.id_almacen = Me.cboAlmacen.SelectedValue
            nOrden_Compra.ModificarCompra(objOrden_Compra)
            Dim Dgv As DataGridView
            Dim Cantidad As Integer
            Dgv = Me.dtvListado_Productos
            nOrden_Compra.EleminarProducto_Almacen(objOrden_Compra.id_compra)
            Try
                For i As Integer = 0 To Dgv.RowCount - 1
                    objOrden_Compra.id_producto = CInt(Dgv.Item(0, i).Value)
                    objOrden_Compra.cantidad = CInt(Dgv.Item(2, i).Value)
                    objOrden_Compra.precio_compra = CDbl(Dgv.Item(4, i).Value)
                    objOrden_Compra.descuento = CDbl(Dgv.Item(5, i).Value)
                    objOrden_Compra.Sub_Total = CDbl(Dgv.Item(6, i).Value)
                    If objOrden_Compra.id_producto <> 0 Then
                        nOrden_Compra.RegistrarCompra_Producto(objOrden_Compra)
                        objProducto_almacen.id_almacen = Me.cboAlmacen.SelectedValue
                        objProducto_almacen.id_producto = objOrden_Compra.id_producto
                        Cantidad = nProducto_almacen.ContraProducto_Almacen(objProducto_almacen)
                        If Cantidad = 0 Then
                            objProducto_almacen.descripcion = "el Producto " & (Dgv.Item(1, i).Value) & "Esta en almance " & Me.cboAlmacen.Text
                            nProducto_almacen.RegistrarProducto_Almacen(objProducto_almacen)
                        End If
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            MessageBox.Show("Los datos se actualizaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btnNuevo.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Eliminar()
        Try
            If MessageBox.Show("¿Desea eliminar los datos de este Orden de Compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nOrden_Compra.EleminarCompra(lblCodigo.Text)
                nOrden_Compra.EleminarProducto_Almacen(lblCodigo.Text)
                MessageBox.Show("Los datos se eliminaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Cargar()
        Try
            Dim Tabla As DataTable
            Dim Id_Producto As Integer
            Dim Producto As String
            Dim Cantidad As Integer
            Dim Unidad As String
            Dim costo As Double
            Dim Descuento As Double
            Dim Total As Double
            Dim ToDescuento As Double
            Dim suma As Double
            Tabla = nOrden_Compra.Listar(objOrden_Compra.id_compra)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Compra.id_compra = Fila.Item("id_compra")
                objOrden_Compra.fecha_compra = Fila.Item("fecha_compra")
                objOrden_Compra.total = Fila.Item("total")
                objOrden_Compra.subtotal = Fila.Item("subtotal")
                objOrden_Compra.igv = Fila.Item("igv")
                objOrden_Compra.numero_documento = Fila.Item("numero_documento")
                objOrden_Compra.serie_documento = Fila.Item("serie_documento")
                objOrden_Compra.id_Moneda = Fila.Item("id_moneda")
                objOrden_Compra.id_proveedor = Fila.Item("id_proveedor")
                objOrden_Compra.id_almacen = Fila.Item("id_almacen")
                objOrden_Compra.Tipo_Pago = Fila.Item("tipo_pago")
            Next
            Me.lblCodigo.Text = objOrden_Compra.id_compra
            Me.Txtnumero_documento.Text = objOrden_Compra.numero_documento
            Me.Txtserie_documento.Text = objOrden_Compra.serie_documento
            Me.cboMoneda.SelectedValue = objOrden_Compra.id_Moneda
            Me.cboTipoPago.SelectedValue = objOrden_Compra.Tipo_Pago
            Me.dtpfecha_emision.Value = objOrden_Compra.fecha_compra
            Me.Txtid_proveedor.Text = objOrden_Compra.id_proveedor
            Me.txtPrecio_neto.Text = objOrden_Compra.subtotal
            Me.txtigv.Text = objOrden_Compra.igv
            Me.TxtTotal.Text = objOrden_Compra.total
            Tabla = nAlmacen.Listar(objOrden_Compra.id_almacen)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Compra.id_sucursal = Fila.Item("id_sucursal")
            Next
            Me.cboSucursal.SelectedValue = objOrden_Compra.id_sucursal
            LlenaAlmacen()
            Me.cboAlmacen.SelectedValue = objOrden_Compra.id_almacen
            Tabla = nProveedor.Listar(objOrden_Compra.id_proveedor)
            For Each Fila As DataRow In Tabla.Rows
                objProveedor.razon_social = Fila.Item("razon_social")
                objProveedor.direccion = Fila.Item("direccion")
            Next
            Me.txtBuscar_proveedor.Text = objProveedor.razon_social
            Me.TxtDireccion.Text = objProveedor.direccion
            Tabla = nOrden_Compra.ListarDetalle(objOrden_Compra.id_compra)
            ToDescuento = 0.0
            suma = 0.0
            Me.dtvListado_Productos.Rows.Clear()
            For Each Fila As DataRow In Tabla.Rows
                Id_Producto = Fila.Item("id_producto")
                Producto = Fila.Item("nombre_producto")
                Cantidad = Fila.Item("cantidad")
                Unidad = Fila.Item("abreviatura")
                costo = Fila.Item("precio_compra")
                Descuento = Fila.Item("descuento")
                Total = Fila.Item("Sub_Total")
                Me.dtvListado_Productos.Rows.Add(Id_Producto, Producto, Cantidad, Unidad, costo, Descuento, Total)
                ToDescuento = ToDescuento + Descuento
                suma = suma + Total
            Next
            Me.txtMonto_descuento.Text = ToDescuento
            Me.txtPrecio_bruto.Text = objOrden_Compra.total + ToDescuento
            If suma = objOrden_Compra.total Then
                Me.chkigv.Checked = True
            Else
                Me.chkigv.Checked = False
            End If
            btnModificar.Enabled = True
            btnExportar.Enabled = True
            btnEliminarOrden.Enabled = True
            btnGrabar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Exportar()
        Dim m_Excel As New Excel.Application
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            'Encabezado
            .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("A1:L1").Merge()
            .Range("A1:L1").Value = "Orden de Compra"
            .Range("A1:L1").Font.Bold = True
            .Range("A1:L1").Font.Size = 16
            'Texto despues del encabezado
            .Range("A2").Value = "Serie:"
            .Range("B2:D2").Merge()
            .Range("B2:D2").Value = Me.Txtnumero_documento.Text & " - " & Me.Txtserie_documento.Text
            .Range("F2").Value = "Fecha:"
            .Range("G2:H2").Merge()
            .Range("G2:H2").Value = Me.dtpfecha_emision.Value
            .Range("J2").Value = "Moneda:"
            .Range("K2:L2").Merge()
            .Range("K2:L2").Value = Me.cboMoneda.Text
            .Range("A2:L2").Font.Bold = True
            .Range("A2:L2").Font.Size = 10
            .Range("A3").Value = "Proveedor:"
            .Range("B3:F3").Merge()
            .Range("B3:F3").Value = Me.txtBuscar_proveedor.Text
            .Range("H3").Value = "Dirección:"
            .Range("I3:L3").Merge()
            .Range("I3:L3").Value = Me.TxtDireccion.Text
            .Range("A3:L3").Font.Bold = True
            .Range("A3:L3").Font.Size = 10
            .Range("A4").Value = "Sucursal:"
            .Range("B4:E4").Merge()
            .Range("B4:E4").Value = Me.cboSucursal.Text
            .Range("H4").Value = "Almacen:"
            .Range("I4:L4").Merge()
            .Range("I4:L4").Value = Me.cboAlmacen.Text
            .Range("A4:L4").Font.Bold = True
            .Range("A4:L4").Font.Size = 10
            'Espacio
            .Range("A5:L5").Merge()
            .Range("A5:L5").Value = ""
            .Range("A5:L5").Font.Bold = True
            .Range("A5:L5").Font.Size = 10
            'Estilos a titulos de la Tabla
            .Range("A6:P6").Font.Bold = True
            'Establecer tipo de Letra al Rango Determinado
            .Range("A1:P100").Font.Name = "Tahoma"
            'Los datos se registran a partir de la Columna A, Fila 4
            Const PrimeraLetra As Char = "A"
            Const PrimerNumero As Short = 6
            Dim letra As Char
            Dim UltimaLetra As Char
            Dim Numero As Integer
            Dim UltimoNumero As Integer
            Dim cod_letra As Byte = Asc(PrimeraLetra) - 1
            Dim sepDec As String = Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
            Dim sepFil As String = Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
            Dim strColumna As String = ""
            Dim LetraIzq As String = ""
            Dim cod_LetraIzq As Byte = Asc(PrimeraLetra) - 1
            letra = PrimeraLetra
            Numero = PrimerNumero
            Dim objCelda As Excel.Range
            For Each c As DataGridViewColumn In dtvListado_Productos.Columns
                If c.Visible Then
                    If letra = "Z" Then
                        letra = PrimeraLetra
                        cod_letra = Asc(PrimeraLetra)
                        cod_LetraIzq += 1
                        LetraIzq = Chr(cod_LetraIzq)
                    Else
                        cod_letra += 1
                        letra = Chr(cod_letra)
                    End If
                    strColumna = LetraIzq + letra + Numero.ToString
                    objCelda = .Range(strColumna, Type.Missing)
                    objCelda.Value = c.HeaderText
                    objCelda.EntireColumn.Font.Size = 10
                    'Establece un formato a los numeros por default
                    'objcelda.entirecolumn.numberformat = c.defaultCellStyle.Format
                    If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
                        objCelda.EntireColumn.NumberFormat = "#" + sepFil + "0" + sepDec + "00"
                    End If
                End If
            Next
            Dim objRangoEncab As Excel.Range = .Range(PrimeraLetra + Numero.ToString, LetraIzq + letra + Numero.ToString)
            objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
            UltimaLetra = letra
            Dim UltimaLetraIzq As String = LetraIzq
            'Cargar Datos del DataGridView
            Dim i As Integer = Numero + 1
            For Each reg As DataGridViewRow In dtvListado_Productos.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(PrimeraLetra) - 1
                letra = PrimeraLetra
                cod_letra = Asc(PrimeraLetra) - 1
                For Each c As DataGridViewColumn In dtvListado_Productos.Columns
                    If c.Visible Then
                        If letra = "Z" Then
                            letra = PrimeraLetra
                            cod_letra = Asc(PrimeraLetra)
                            cod_LetraIzq += 1
                            LetraIzq = Asc(cod_LetraIzq)
                        Else
                            cod_letra += 1
                            letra = Chr(cod_letra)
                        End If
                        strColumna = LetraIzq + letra
                        'Aqui se realiza la carga de datos
                        .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
                    End If
                Next
                Dim objRangoReg As Excel.Range = .Range(PrimeraLetra + i.ToString, strColumna + i.ToString)
                objRangoReg.Rows.BorderAround()
                objRangoReg.Select()
                i += 1
            Next
            UltimoNumero = i
            LetraIzq = ""
            cod_LetraIzq = Asc("A")
            cod_letra = Asc(PrimeraLetra)
            letra = PrimeraLetra
            For Each c As DataGridViewColumn In dtvListado_Productos.Columns
                If c.Visible Then
                    objCelda = .Range(LetraIzq + letra + PrimerNumero.ToString, LetraIzq + letra + (UltimoNumero - 1).ToString)
                    objCelda.BorderAround()
                    If letra = "Z" Then
                        letra = PrimeraLetra
                        cod_letra = Asc(PrimeraLetra)
                        LetraIzq = Chr(cod_LetraIzq)
                        cod_LetraIzq += 1
                    Else
                        cod_letra += 1
                        letra = Chr(cod_letra)
                    End If
                End If
            Next
            ' Dibujar el border exterior grueso de la tabla 
            Dim objRango As Excel.Range = .Range(PrimeraLetra + PrimerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
            objRango.Select()
            UltimoNumero = UltimoNumero + 1
            .Range("C" + UltimoNumero.ToString).Value = "PRECIO BRUTO"
            .Range("D" + UltimoNumero.ToString).Value = Me.txtPrecio_bruto.Text
            .Range("E" + UltimoNumero.ToString).Value = "DESCUENTO"
            .Range("F" + UltimoNumero.ToString).Value = Me.txtMonto_descuento.Text
            .Range("G" + UltimoNumero.ToString).Value = "PRECIO NETO"
            .Range("H" + UltimoNumero.ToString).Value = Me.txtPrecio_neto.Text
            .Range("I" + UltimoNumero.ToString).Value = "IGV"
            .Range("J" + UltimoNumero.ToString).Value = Me.txtigv.Text
            .Range("K" + UltimoNumero.ToString).Value = "TOTAL"
            .Range("L" + UltimoNumero.ToString).Value = Me.TxtTotal.Text
            objRango.Columns.AutoFit()
            objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With
        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub
    Sub Habilitar(ByVal Estado As Boolean)
        Me.lblCodigo.Enabled = Estado
        Me.txtdescripcion.Enabled = Estado
        Me.cboSucursal.Enabled = Estado
        Me.cboAlmacen.Enabled = Estado
        Me.cboMoneda.Enabled = Estado
        Me.cboTipoPago.Enabled = Estado
        Me.dtpfecha_emision.Enabled = Estado
        Me.dtvListado_Productos.Enabled = Estado
        Me.chkigv.Enabled = Estado
        Me.btnAgregar.Enabled = Estado
        Me.dtvListado_Productos.Enabled = Estado
        Me.btnFiltro_Producto.Enabled = Estado
    End Sub
    Sub Sumar()
        Dim total As Double
        Dim Descuento As Double
        Dim Dgv As DataGridView
        Dgv = Me.dtvListado_Productos
        total = 0.0
        Descuento = 0.0
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                total = total + CDbl(Dgv.Item(6, i).Value)
                Descuento = Descuento + CDbl(Dgv.Item(5, i).Value)
            Next
            LenarTotal(total, Descuento)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    Sub LenarTotal(ByVal sumar As Double, ByVal Descuento As Double)
        Dim Bruto As Double
        Dim Neto As Double
        Dim Igv As Double
        Dim Total As Double
        If Me.chkigv.Checked Then
            Total = sumar
            Igv = sumar * 18 / 118
            Neto = Total - Igv
        Else
            Neto = sumar
            Igv = Neto * 18 / 100
            Total = Neto + Igv
        End If
        Bruto = Neto + Descuento
        Me.txtPrecio_bruto.Text = Format(Bruto, "##0.00")
        Me.txtPrecio_neto.Text = Format(Neto, "##0.00")
        Me.txtMonto_descuento.Text = Format(Descuento, "##0.00")
        Me.txtigv.Text = Format(Igv, "##0.00")
        Me.TxtTotal.Text = Format(Total, "##0.00")
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        BuscarSerie()
        Me.lblCodigo.Visible = False
        Me.txtBuscar_proveedor.Enabled = False
        Me.TxtDireccion.Enabled = False
        Me.txtProducto.Enabled = False
        Me.cboUnidad.Enabled = False
        Me.txtCantidad.Enabled = False
        Me.txtPrecio_Unitario.Enabled = False
        Me.txtDescuento.Enabled = False
        Me.TxtidProducto.Visible = False
        Me.LblProcetaje.Visible = False
        Me.Txtid_proveedor.Visible = False
        Me.Txtnumero_documento.Enabled = False
        Me.Txtserie_documento.Enabled = False
        Me.lblCodigo.Text = ""
        Me.txtdescripcion.Text = ""
        Me.txtBuscar_proveedor.Text = ""
        Me.TxtDireccion.Text = ""
        Me.Txtid_proveedor.Text = ""
        Me.chkigv.Checked = True
        Me.cboMoneda.SelectedValue = "1"
        Me.cboTipoPago.SelectedValue = "0"
        Me.cboUnidad.SelectedValue = "0"
        Me.txtProducto.Text = ""
        Me.txtCantidad.Text = ""
        Me.txtPrecio_Unitario.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtPrecio_Unitario.Text = ""
        Me.txtPrecio_bruto.Text = ""
        Me.txtMonto_descuento.Text = ""
        Me.txtPrecio_neto.Text = ""
        Me.txtigv.Text = ""
        Me.TxtTotal.Text = ""
        Me.dtpfecha_emision.Value = DateTime.Now()
        Me.dtvListado_Productos.Rows.Clear()
        Me.btnNuevo.Enabled = True
        Me.btnGrabar.Tag = "Grabar"
        Me.btnGrabar.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnExportar.Enabled = False
        Me.btnEliminarOrden.Enabled = False
        Me.btnAgregar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.txtPrecio_bruto.Enabled = False
        Me.cboUnidad.Enabled = False
        Me.txtMonto_descuento.Enabled = False
        Me.txtPrecio_neto.Enabled = False
        Me.txtigv.Enabled = False
        Me.TxtTotal.Enabled = False
        ' LÓGICA PERMISOS -------------------------------------------------
        Dim Permiso As Personal_SubMenu = CType(Me.Tag, Personal_SubMenu)
        Me.btnGrabar.Visible = Permiso.nuevo
        Me.btnModificar.Visible = Permiso.modificar
        Me.btnEliminar.Visible = Permiso.eliminar
        Me.btnBuscar.Visible = Permiso.buscar
        ' -----------------------------------------------------------------
        Me.Txtnumero_documento.Focus()
    End Sub
    Sub LlenaCombos()
        Try
            Dim Sucursales As DataTable = RNSucursal.Listar
            Me.cboSucursal.ValueMember = "id_sucursal"
            Me.cboSucursal.DisplayMember = "descripcion"
            Me.cboSucursal.DataSource = Sucursales
            Me.cboSucursal.SelectedValue = 1
            Dim id_Sucursal As Integer
            id_Sucursal = Me.cboSucursal.SelectedValue
            LlenaAlmacen()
            Dim Moneda As DataTable = nMoneda.Listar
            Me.cboMoneda.ValueMember = "id_moneda"
            Me.cboMoneda.DisplayMember = "descripcion"
            If Moneda.Rows.Count > 0 Then
                Me.cboMoneda.DataSource = Moneda
            Else
                Dim SinMoneda As New DataTable
                SinMoneda.Columns.Add("id_moneda")
                SinMoneda.Columns.Add("descripcion")
                SinMoneda.Rows.Add("1", "No hay Monedas registradas")
                Me.cboMoneda.DataSource = SinMoneda
                Me.cboMoneda.ValueMember = "id_moneda"
                Me.cboMoneda.DisplayMember = "descripcion"
                Me.cboMoneda.SelectedValue = "1"
                Me.btnGrabar.Enabled = False
            End If
            Dim TipoPago As New DataTable
            TipoPago.Columns.Add("ID")
            TipoPago.Columns.Add("VALOR")
            TipoPago.Rows.Add("0", "Elija una opción")
            TipoPago.Rows.Add("E", "Efetivo")
            TipoPago.Rows.Add("C", "Credito")
            Me.cboTipoPago.DataSource = TipoPago
            Me.cboTipoPago.ValueMember = "ID"
            Me.cboTipoPago.DisplayMember = "VALOR"
            Me.cboTipoPago.SelectedValue = "0"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub LlenaAlmacen()
        Dim id_Sucursal As Integer
        id_Sucursal = Me.cboSucursal.SelectedValue
        Dim Almacen As DataTable = nAlmacen.Listar(id_Sucursal)
        Me.cboAlmacen.ValueMember = "id_almacen"
        Me.cboAlmacen.DisplayMember = "descripcion"
        If Almacen.Rows.Count > 0 Then
            Me.cboAlmacen.DataSource = Almacen
        Else
            Dim SinAlmacen As New DataTable
            SinAlmacen.Columns.Add("id_almacen")
            SinAlmacen.Columns.Add("descripcion")
            SinAlmacen.Rows.Add("0", "No hay Almacenes registradas")
            Me.cboAlmacen.DataSource = SinAlmacen
            Me.cboAlmacen.ValueMember = "id_almacen"
            Me.cboAlmacen.DisplayMember = "descripcion"
            Me.cboAlmacen.SelectedValue = "0"
            Me.btnGrabar.Enabled = False
        End If
    End Sub
    Sub LlenaUnidad(ByVal Id_Unidad As Integer)
        Dim Unidad As DataTable = nUnidad.Listar(Id_Unidad)
        Me.cboUnidad.ValueMember = "abreviatura"
        Me.cboUnidad.DisplayMember = "descripcion"
        Me.cboUnidad.DataSource = Unidad
    End Sub
    Sub BuscarSerie()
        Dim id_Compra As Integer
        Dim NumDomento As Integer
        Dim NumSerie As Integer
        Dim Domnento As String
        Dim serie As String
        id_Compra = nOrden_Compra.buscarid
        NumDomento = id_Compra / 10000000 + 1
        NumSerie = id_Compra Mod 10000000
        NumSerie = NumSerie + NumDomento - 1
        If NumDomento < 10 Then
            Domnento = "00" & NumDomento.ToString
        ElseIf NumDomento < 100 Then
            Domnento = "0" & NumDomento.ToString
        Else
            Domnento = NumDomento.ToString
        End If
        If NumSerie < 10 Then
            serie = "000000" & NumSerie.ToString
        ElseIf NumSerie < 100 Then
            serie = "00000" & NumSerie.ToString
        ElseIf NumSerie < 1000 Then
            serie = "0000" & NumSerie.ToString
        ElseIf NumSerie < 10000 Then
            serie = "000" & NumSerie.ToString
        ElseIf NumSerie < 100000 Then
            serie = "00" & NumSerie.ToString
        ElseIf NumSerie < 1000000 Then
            serie = "0" & NumSerie.ToString
        Else
            serie = NumSerie.ToString
        End If
        Me.Txtnumero_documento.Text = Domnento
        Me.Txtserie_documento.Text = serie
    End Sub
    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Function Valida() As Boolean
        Dim TextoError As String = ""
        If Me.Txtnumero_documento.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Numero de Documento." & vbCrLf
        End If
        If Me.Txtserie_documento.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Serie de Documento." & vbCrLf
        End If
        If Me.txtBuscar_proveedor.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un proveedor." & vbCrLf
        End If
        If Me.cboSucursal.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una sucursal." & vbCrLf
        End If
        If Me.cboAlmacen.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar un Almacen." & vbCrLf
        End If
        If Me.cboMoneda.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una Monoda." & vbCrLf
        End If
        If Me.cboTipoPago.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe ingresar un Tipo de Pago." & vbCrLf
        End If
        If Me.TxtTotal.Text.Trim = "0.0" Or Me.TxtTotal.Text.Trim = "" Then
            TextoError = TextoError & "- Debe seleccionar un Producto." & vbCrLf
        End If
        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtnumero_documento.KeyPress, Txtserie_documento.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "#" Or e.KeyChar = "*" Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class