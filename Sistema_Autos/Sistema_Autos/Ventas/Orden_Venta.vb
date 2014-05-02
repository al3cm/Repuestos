Imports Entidades
Imports Reglas_Negocio
Public Class frmOrden_Venta
    Dim nTipo_Cambio As New RNTipo_cambio
    Dim nTipoDocumento As New RNTipoDocumento
    Dim nSucursal As New RNSucursal
    Dim nMoneda As New RNMoneda
    Dim nUnidad As New RNUnidad
    Dim nProducto_Almacen As New RNProducto_Almacen
    Dim nAlmacen As New RNAlmacen
    Dim nPersonal As New RNPersonal
    Dim nClientes As New RNCliente
    Dim nOrden_Venta As New RNOrden_Venta
    Dim objOrden_Venta As New Orden_Venta
    Dim objClientes As New Cliente
    Dim objPersonal As New Personal
    Dim objAlmacen As New Almacen
    Dim objProducto_Almacen As New Producto_Almacen
    Dim objProducto As New Producto
    Dim Cantidad As Integer
    Dim Tabla As DataTable
    Private Sub frmOrden_Venta_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub
    Private Sub frmOrden_Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' LÓGICA PERMISOS -------------------------------------------------
            Me.Tag = RNPersonalSubMenu.ListarPersonalSubMenu(CType(Me.Tag, Personal_SubMenu).id_menu, CType(Me.Tag, Personal_SubMenu).id_submenu, CType(Me.Tag, Personal_SubMenu).id_personal)
            If Me.Tag Is Nothing Then
                MessageBox.Show("Error al asignar archivos, consulte con el Administrador del Sstema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            ' -----------------------------------------------------------------
            Cantidad = nPersonal.ContraAlmacen_Personal(id_Vededor)
            LlenaCombos()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub cboSucursal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSucursal.SelectedIndexChanged
        If Cantidad <> 1 Then
            Me.cboAlmacen.Enabled = True
        End If
        LlenaAlmacen()
    End Sub
    Private Sub cboTipoPago_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipoPago.SelectedIndexChanged
        Try
            If (Me.cboTipoPago.SelectedValue = "C") And (Me.TxtTotal.Text <> "") And (Me.TxtTotal.Text <> "0.0") Then
                Me.txtinicial.Enabled = True
                Me.txtinicial.Focus()
            End If
        Catch ex As Exception
        End Try
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
    Private Sub btnbuscar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_cliente.Click
        If frmListarClientes.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim Tipo As String
            Me.objClientes = frmListarClientes.objCliente
            Me.txtCliente.Text = objClientes.razon_social
            Me.txtdireccion.Text = objClientes.direccion
            Me.Txtid_Cliente.Text = objClientes.id_cliente
            Tipo = objClientes.tipo_cliente
            LenarDocumento()
            Dim TipoDocumento As DataTable = nTipoDocumento.Listar()
            If Tipo = "N" Then
                Me.txtdocumento.Text = objClientes.dni
                If TipoDocumento.Rows.Count > 0 Then
                    Me.cboTipo_documento.SelectedValue = "002" 'Modified 2014.04.12
                End If
                ' Me.cboTipo_documento.Enabled = False 'Added 2014.04.12 por revisar
            Else
                Me.txtdocumento.Text = objClientes.dni
                If TipoDocumento.Rows.Count > 0 Then
                    Me.cboTipo_documento.SelectedValue = "001" 'Modified 2014.04.12
                End If
                Me.txtdocumento.Text = objClientes.ruc
                'Me.cboTipo_documento.Enabled = True 'Added 2014.04.12 por revisar
            End If
            LenarPersonal()
            Me.cboVendedor.SelectedValue = id_Vededor
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
            If Me.cboTipoPago.SelectedValue = "T" Then
                Me.txtPrecio_Unitario.Text = Format(objProducto.precio_venta * Cambio_Trajecta, "##0.00")
            Else
                Me.txtPrecio_Unitario.Text = objProducto.precio_venta
            End If
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
        frmListado_Orden_Venta.accion = 1
        If frmListado_Orden_Venta.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.objOrden_Venta = frmListado_Orden_Venta.objOrden_Venta
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
        Dim Stock As Integer
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
                        TextoError = "- Producto Ya Ingresado"
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
        objProducto_Almacen.id_producto = Id_Producto
        objProducto_Almacen.id_almacen = Me.cboAlmacen.SelectedValue
        Tabla = nProducto_Almacen.Listar(objProducto_Almacen)
        For Each Fila As DataRow In Tabla.Rows
            Stock = Fila.Item("stock")
        Next
        If Stock < Cantidad Then
            estado = False
            TextoError = "- NO TIENE EN STOCK"
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
    Private Sub txtinicial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtinicial.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Val(Me.txtinicial.Text) < Val(Me.TxtTotal.Text) Then
                Dim financiado As Double
                financiado = Me.TxtTotal.Text - Me.txtinicial.Text
                Me.txtmonto_financiado.Text = Format(financiado, "##0.00")
                Me.txtnro_cuotas.Enabled = True
                Me.txtnro_cuotas.Focus()
            Else
                MessageBox.Show("El Monto Inicial deber ser menor al Total")
                Me.txtinicial.Text = ""
                Me.txtinicial.Focus()
            End If
        End If
    End Sub
    Private Sub txtnro_cuotas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnro_cuotas.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim cuota As Double
            cuota = Me.txtmonto_financiado.Text / Me.txtnro_cuotas.Text
            Me.txtMonto_cuota.Text = Format(cuota, "##0.00")
        End If
    End Sub

    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    Sub Grabar()
        Try
            If Valida() Then
                objOrden_Venta.fecha_emision = Me.dtpFecha.Value
                objOrden_Venta.total = Me.TxtTotal.Text.Trim
                objOrden_Venta.subtotal = Me.txtPrecio_neto.Text.Trim
                objOrden_Venta.igv = Me.txtigv.Text.Trim
                objOrden_Venta.numero_documento = Me.Txtnumero_documento.Text.ToString
                objOrden_Venta.serie_documento = Me.Txtserie_documento.Text.ToString
                objOrden_Venta.id_cliente = Me.Txtid_Cliente.Text.Trim
                objOrden_Venta.Tipo_Pago = Me.cboTipoPago.SelectedValue
                objOrden_Venta.pago_inicial = Me.txtinicial.Text.Trim
                objOrden_Venta.id_tipodocumento = Me.cboTipo_documento.SelectedValue
                objOrden_Venta.id_Moneda = Me.cboMoneda.SelectedValue
                objOrden_Venta.id_sucursal = Me.cboSucursal.SelectedValue
                objOrden_Venta.id_almacen = Me.cboAlmacen.SelectedValue
                objOrden_Venta.id_personal = Me.cboVendedor.SelectedValue
                If Me.txtmonto_financiado.Text.Trim <> "" Then
                    objOrden_Venta.monto_financiado = Me.txtmonto_financiado.Text.Trim
                Else
                    objOrden_Venta.monto_financiado = 0.0
                End If
                If Me.txtnro_cuotas.Text.Trim <> "" Then
                    objOrden_Venta.nro_cuotas = Me.txtnro_cuotas.Text.Trim
                Else
                    objOrden_Venta.nro_cuotas = 0
                End If
                If Me.txtMonto_cuota.Text.Trim <> "" Then
                    objOrden_Venta.Monto_cuota = Me.txtMonto_cuota.Text.Trim
                Else
                    objOrden_Venta.Monto_cuota = 0.0
                End If
                If MessageBox.Show("¿Desea registrar los datos de este Orden de Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If Me.cboMoneda.SelectedValue = "1" Then
                        objOrden_Venta = nOrden_Venta.RegistrarVenta(objOrden_Venta)
                    Else
                        objOrden_Venta.tipo_cambio = 0.0
                        Dim Tabla As DataTable
                        Tabla = nTipo_Cambio.Listar()
                        For Each Fila As DataRow In Tabla.Rows
                            objOrden_Venta.tipo_cambio = Fila.Item("cambio_empresa")
                        Next
                        objOrden_Venta = nOrden_Venta.RegistrarVentaConCambion(objOrden_Venta)
                    End If
                    Dim Dgv As DataGridView
                    Dgv = Me.dtvListado_Productos
                    Try
                        For i As Integer = 0 To Dgv.RowCount - 1
                            objOrden_Venta.id_producto = CInt(Dgv.Item(0, i).Value)
                            objOrden_Venta.cantidad = CInt(Dgv.Item(2, i).Value)
                            objOrden_Venta.precio_venta = CDbl(Dgv.Item(4, i).Value)
                            objOrden_Venta.descuento = CDbl(Dgv.Item(5, i).Value)
                            objOrden_Venta.Sub_Total = CDbl(Dgv.Item(6, i).Value)
                            If objOrden_Venta.id_producto <> 0 Then
                                nOrden_Venta.RegistrarVenta_Producto(objOrden_Venta)
                            End If
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                    Dim TextoError As String
                    TextoError = "Serie: OV/ " & Me.Txtnumero_documento.Text & " - " & Me.Txtserie_documento.Text
                    MessageBox.Show("Los datos se guardaron satisfactoriamente" & vbCrLf & TextoError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objOrden_Venta.id_venta
                    Me.btnGrabar.Enabled = False
                    Me.btnNuevo.Enabled = True
                    Me.btnModificar.Enabled = True
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
            'Modified 2014.03.26
            objOrden_Venta.id_venta = Me.lblCodigo.Text
            objOrden_Venta.fecha_emision = Me.dtpFecha.Value
            objOrden_Venta.total = Me.TxtTotal.Text.Trim
            objOrden_Venta.subtotal = Me.txtPrecio_neto.Text.Trim
            objOrden_Venta.igv = Me.txtigv.Text.Trim
            objOrden_Venta.numero_documento = Me.Txtnumero_documento.Text.ToString
            objOrden_Venta.serie_documento = Me.Txtserie_documento.Text.ToString
            objOrden_Venta.id_cliente = Me.Txtid_Cliente.Text.Trim
            objOrden_Venta.Tipo_Pago = Me.cboTipoPago.SelectedValue
            objOrden_Venta.pago_inicial = Me.txtinicial.Text.Trim
            objOrden_Venta.id_tipodocumento = Me.cboTipo_documento.SelectedValue
            objOrden_Venta.id_sucursal = Me.cboSucursal.SelectedValue
            objOrden_Venta.id_Moneda = Me.cboMoneda.SelectedValue
            objOrden_Venta.id_almacen = Me.cboAlmacen.SelectedValue
            objOrden_Venta.id_personal = Me.cboVendedor.SelectedValue
            If Me.txtmonto_financiado.Text.Trim <> "" Then
                objOrden_Venta.monto_financiado = Me.txtmonto_financiado.Text.Trim
            Else
                objOrden_Venta.monto_financiado = 0.0
            End If
            If Me.txtnro_cuotas.Text.Trim <> "" Then
                objOrden_Venta.nro_cuotas = Me.txtnro_cuotas.Text.Trim
            Else
                objOrden_Venta.nro_cuotas = 0
            End If
            If Me.txtMonto_cuota.Text.Trim <> "" Then
                objOrden_Venta.Monto_cuota = Me.txtMonto_cuota.Text.Trim
            Else
                objOrden_Venta.Monto_cuota = 0.0
            End If
            nOrden_Venta.ModificarVenta(objOrden_Venta)
            Dim Dgv As DataGridView
            Dgv = Me.dtvListado_Productos
            nOrden_Venta.EleminarVenta_Producto(objOrden_Venta.id_venta)
            Try
                For i As Integer = 0 To Dgv.RowCount - 1
                    objOrden_Venta.id_producto = CInt(Dgv.Item(0, i).Value)
                    objOrden_Venta.cantidad = CInt(Dgv.Item(2, i).Value)
                    objOrden_Venta.precio_venta = CDbl(Dgv.Item(4, i).Value)
                    objOrden_Venta.descuento = CDbl(Dgv.Item(5, i).Value)
                    objOrden_Venta.Sub_Total = CDbl(Dgv.Item(6, i).Value)
                    If objOrden_Venta.id_producto <> 0 Then
                        nOrden_Venta.RegistrarVenta_Producto(objOrden_Venta)
                    End If
                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
            MessageBox.Show("Los datos se actualizaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Eliminar()
        Try
            If MessageBox.Show("¿Desea eliminar los datos de este Orden de Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nOrden_Venta.EleminarVenta(lblCodigo.Text)
                nOrden_Venta.EleminarVenta_Producto(lblCodigo.Text)
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
            Tabla = nOrden_Venta.Listar(objOrden_Venta.id_venta)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Venta.id_venta = Fila.Item("id_Venta")
                objOrden_Venta.fecha_emision = Fila.Item("fecha_emision")
                objOrden_Venta.total = Fila.Item("total")
                objOrden_Venta.subtotal = Fila.Item("subtotal")
                objOrden_Venta.igv = Fila.Item("igv")
                objOrden_Venta.numero_documento = Fila.Item("numero_documento")
                objOrden_Venta.serie_documento = Fila.Item("serie_documento")
                objOrden_Venta.id_Moneda = Fila.Item("id_moneda")
                objOrden_Venta.id_cliente = Fila.Item("id_cliente")
                objOrden_Venta.Tipo_Pago = Fila.Item("tipo_pago")
                objOrden_Venta.pago_inicial = Fila.Item("pago_inicial")
                objOrden_Venta.id_personal = Fila.Item("id_personal")
                objOrden_Venta.monto_financiado = Fila.Item("monto_financiado")
                objOrden_Venta.nro_cuotas = Fila.Item("nro_cuotas")
                objOrden_Venta.Monto_cuota = Fila.Item("Monto_cuota")
                objOrden_Venta.id_almacen = Fila.Item("id_almacen")
            Next
            Me.lblCodigo.Text = objOrden_Venta.id_venta
            Me.Txtnumero_documento.Text = objOrden_Venta.numero_documento
            Me.Txtserie_documento.Text = objOrden_Venta.serie_documento
            Me.cboMoneda.SelectedValue = objOrden_Venta.id_Moneda
            Me.cboTipoPago.SelectedValue = objOrden_Venta.Tipo_Pago
            Me.dtpFecha.Value = objOrden_Venta.fecha_emision
            Me.Txtid_Cliente.Text = objOrden_Venta.id_cliente
            Me.txtPrecio_neto.Text = objOrden_Venta.subtotal
            Me.txtigv.Text = objOrden_Venta.igv
            Me.TxtTotal.Text = objOrden_Venta.total
            Me.txtinicial.Text = objOrden_Venta.pago_inicial
            objAlmacen.id_almacen = objOrden_Venta.id_almacen
            Tabla = nAlmacen.Listar(objAlmacen)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Venta.id_sucursal = Fila.Item("id_sucursal")
            Next
            Me.cboSucursal.SelectedValue = objOrden_Venta.id_sucursal ' Modified 2014.04.12
            LlenaAlmacen()
            Me.cboAlmacen.SelectedValue = objOrden_Venta.id_almacen
            If objOrden_Venta.monto_financiado <> 0.0 Then
                Me.txtmonto_financiado.Text = objOrden_Venta.monto_financiado
            End If
            If objOrden_Venta.nro_cuotas <> 0 Then
                Me.txtnro_cuotas.Text = objOrden_Venta.nro_cuotas
            End If
            If objOrden_Venta.Monto_cuota <> 0.0 Then
                Me.txtMonto_cuota.Text = objOrden_Venta.Monto_cuota
            End If
            Tabla = nClientes.Listar(objOrden_Venta.id_cliente)
            For Each Fila As DataRow In Tabla.Rows
                objClientes.razon_social = Fila.Item("razon_social")
                objClientes.direccion = Fila.Item("direccion")
                objClientes.tipo_cliente = Fila.Item("tipo_cliente")
                objClientes.dni = Fila.Item("dni")
                objClientes.ruc = Fila.Item("ruc")
            Next
            LenarDocumento()
            Dim TipoDocumento As DataTable = nTipoDocumento.Listar()
            If objClientes.tipo_cliente = "N" Then
                Me.txtdocumento.Text = objClientes.dni
                If TipoDocumento.Rows.Count > 0 Then
                    Me.cboTipo_documento.SelectedValue = "002" 'Modified 2014.04.12
                End If

                ' Me.cboTipo_documento.Enabled = False 'Added 2014.04.12 por revisar
            Else
                'Me.txtdocumento.Text = objClientes.ruc
                If TipoDocumento.Rows.Count > 0 Then
                    Me.cboTipo_documento.SelectedValue = "001" 'Modified 2014.04.12
                End If
                Me.txtdocumento.Text = objClientes.dni
                ' Me.cboTipo_documento.Enabled = True 'Added 2014.04.12 ' por revisar
            End If
            LenarPersonal()
            Me.cboVendedor.SelectedValue = objOrden_Venta.id_personal
            Me.txtCliente.Text = objClientes.razon_social
            Me.txtdireccion.Text = objClientes.direccion
            Tabla = nOrden_Venta.ListarDetalle(objOrden_Venta.id_venta)
            ToDescuento = 0.0
            suma = 0.0
            Me.dtvListado_Productos.Rows.Clear()
            For Each Fila As DataRow In Tabla.Rows
                Id_Producto = Fila.Item("id_producto")
                Producto = Fila.Item("nombre_producto")
                Cantidad = Fila.Item("cantidad")
                Unidad = Fila.Item("abreviatura")
                costo = Fila.Item("precio_Venta")
                Descuento = Fila.Item("descuento")
                Total = Fila.Item("Sub_Total")
                Me.dtvListado_Productos.Rows.Add(Id_Producto, Producto, Cantidad, Unidad, costo, Descuento, Total)
                ToDescuento = ToDescuento + Descuento
                suma = suma + Total
            Next
            Me.txtMonto_descuento.Text = ToDescuento
            Me.txtPrecio_bruto.Text = objOrden_Venta.total + ToDescuento
            btnModificar.Enabled = True
            btnEliminarOrden.Enabled = True
            btnGrabar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Habilitar(ByVal Estado As Boolean)
        Me.txtNotas.Enabled = Estado
        Me.cboMoneda.Enabled = Estado
        Me.cboTipoPago.Enabled = Estado
        If Cantidad <> 1 Then
            Me.cboSucursal.Enabled = Estado
            Me.cboAlmacen.Enabled = Estado
        End If
        Me.btnAgregar.Enabled = Estado
        Me.dtvListado_Productos.Enabled = Estado
        Me.btnFiltro_Producto.Enabled = Estado
        Me.dtpFecha.Enabled = Estado
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
        Total = sumar
        Igv = sumar * 18 / 118
        Neto = Total - Igv
        Bruto = Neto + Descuento
        Me.txtPrecio_bruto.Text = Format(Bruto, "##0.00")
        Me.txtPrecio_neto.Text = Format(Neto, "##0.00")
        Me.txtMonto_descuento.Text = Format(Descuento, "##0.00")
        Me.txtigv.Text = Format(Igv, "##0.00")
        Me.TxtTotal.Text = Format(Total, "##0.00")
        If Me.cboTipoPago.SelectedValue <> "C" Then
            Me.txtinicial.Text = Format(Total, "##0.00")
            Me.txtmonto_financiado.Text = 0.0
            Me.txtnro_cuotas.Text = 0
            Me.txtMonto_cuota.Text = 0.0
        Else
            Me.txtinicial.Enabled = True
            Me.txtinicial.Focus()
        End If
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        BuscarSerie()
        If Cantidad = 1 Then
            Me.cboAlmacen.Enabled = False
            Me.cboSucursal.Enabled = False
        End If
        Me.txtCliente.Enabled = False
        Me.txtdireccion.Enabled = False
        Me.txtProducto.Enabled = False
        Me.cboUnidad.Enabled = False
        Me.txtCantidad.Enabled = False
        Me.txtPrecio_Unitario.Enabled = False
        Me.txtDescuento.Enabled = False
        Me.Txtid_Cliente.Visible = False
        Me.LblProcetaje.Visible = False
        Me.Txtid_Cliente.Visible = False
        Me.TxtidProducto.Visible = False
        Me.Txtnumero_documento.Enabled = False
        Me.Txtserie_documento.Enabled = False
        Me.txtdocumento.Enabled = False
        Me.cboTipo_documento.Enabled = False
        Me.cboVendedor.Enabled = False
        Me.txtsubtotal.Enabled = False
        Me.lblCodigo.Visible = False
        Me.lblCodigo.Text = ""
        Me.txtCliente.Text = ""
        Me.txtdireccion.Text = ""
        Me.Txtid_Cliente.Text = ""
        Me.txtdocumento.Text = ""
        Me.cboTipo_documento.SelectedValue = "1"
        Me.cboVendedor.SelectedValue = id_Vededor
        Me.cboMoneda.SelectedValue = "1"
        Me.cboTipoPago.SelectedValue = "0"
        Me.cboUnidad.SelectedValue = "0"
        If Cantidad = 1 Then
            Tabla = nPersonal.ListarAlmacen_Personal(id_Vededor)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Venta.id_almacen = Fila.Item("id_almacen")
                objAlmacen.id_almacen = Fila.Item("id_almacen")
            Next
            Tabla = nAlmacen.Listar(objAlmacen)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Venta.id_sucursal = Fila.Item("id_sucursal")
            Next
            Me.cboSucursal.SelectedValue = objOrden_Venta.id_sucursal
            Me.cboAlmacen.SelectedValue = objOrden_Venta.id_almacen
        Else
            Me.cboAlmacen.SelectedValue = "1"
            Me.cboSucursal.SelectedValue = "1"
        End If
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
        Me.txtinicial.Text = ""
        Me.txtmonto_financiado.Text = ""
        Me.txtnro_cuotas.Text = ""
        Me.txtMonto_cuota.Text = ""
        Me.txtNotas.Text = ""
        Me.dtpFecha.Value = DateTime.Now()
        Me.dtvListado_Productos.Rows.Clear()
        Me.btnNuevo.Enabled = True
        Me.btnGrabar.Tag = "Grabar"
        Me.btnGrabar.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnEliminarOrden.Enabled = False
        Me.btnAgregar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.txtPrecio_bruto.Enabled = False
        Me.txtinicial.Enabled = False
        Me.txtmonto_financiado.Enabled = False
        Me.txtnro_cuotas.Enabled = False
        Me.txtMonto_cuota.Enabled = False
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

        Me.txtdocumento.Focus()
    End Sub
    Sub LlenaCombos()
        Try
            Dim Sucursales As DataTable = RNSucursal.Listar
            Me.cboSucursal.ValueMember = "id_sucursal"
            Me.cboSucursal.DisplayMember = "descripcion"
            Me.cboSucursal.DataSource = Sucursales
            If Cantidad = 1 Then
                Tabla = nPersonal.ListarAlmacen_Personal(id_Vededor)
                For Each Fila As DataRow In Tabla.Rows
                    objOrden_Venta.id_almacen = Fila.Item("id_almacen")
                Next
                Tabla = nAlmacen.Listar(objOrden_Venta.id_almacen)
                For Each Fila As DataRow In Tabla.Rows
                    objOrden_Venta.id_sucursal = Fila.Item("id_sucursal")
                Next
                Me.cboSucursal.SelectedValue = objOrden_Venta.id_sucursal
            Else
                Me.cboSucursal.SelectedValue = "1"
            End If
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
            TipoPago.Rows.Add("E", "EFECTIVO")
            TipoPago.Rows.Add("C", "CREDITO")
            TipoPago.Rows.Add("T", "TARJETA")
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
            Me.btnAgregar.Enabled = False
        End If
    End Sub
    Sub LenarDocumento()
        Dim TipoDocumento As DataTable = nTipoDocumento.Listar()
        Me.cboTipo_documento.ValueMember = "id_tipodocumento"
        Me.cboTipo_documento.DisplayMember = "descripcion"
        If TipoDocumento.Rows.Count > 0 Then
            Me.cboTipo_documento.DataSource = TipoDocumento
        Else
            Dim SinTipoDocumento As New DataTable
            SinTipoDocumento.Columns.Add("id_tipodocumento")
            SinTipoDocumento.Columns.Add("descripcion")
            SinTipoDocumento.Rows.Add("0", "No hay Tipo de Documento registradas")
            Me.cboTipo_documento.DataSource = SinTipoDocumento
            Me.cboTipo_documento.ValueMember = "id_tipodocumento"
            Me.cboTipo_documento.DisplayMember = "descripcion"
            Me.cboTipo_documento.SelectedValue = "0"
            Me.btnGrabar.Enabled = False
        End If
    End Sub
    Sub LenarPersonal()
        Dim Personal As DataTable = nPersonal.Listar()
        Me.cboVendedor.ValueMember = "id_personal"
        Me.cboVendedor.DisplayMember = "NombreCompleto"
        Me.cboVendedor.DataSource = Personal
    End Sub
    Sub LlenaUnidad(ByVal Id_Unidad As Integer)
        Dim Unidad As DataTable = nUnidad.Listar(Id_Unidad)
        Me.cboUnidad.ValueMember = "abreviatura"
        Me.cboUnidad.DisplayMember = "descripcion"
        Me.cboUnidad.DataSource = Unidad
    End Sub
    Sub BuscarSerie()
        Dim id_Venta As Integer
        Dim NumDomento As Integer
        Dim NumSerie As Integer
        Dim Domnento As String
        Dim serie As String
        id_Venta = nOrden_Venta.buscarid
        NumDomento = id_Venta / 10000000 + 1
        NumSerie = id_Venta Mod 10000000
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
        If Me.txtCliente.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Clientes." & vbCrLf
        End If
        If Me.cboTipo_documento.SelectedValue = "0" Then
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
        If Me.txtinicial.Text.Trim = "" Then
            TextoError = TextoError & "- Debe seleccionar un Pago Inicial." & vbCrLf
        End If
        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
End Class