Imports Entidades
Imports Reglas_Negocio
Public Class frmFacturacion
    Dim nTipoDocumento As New RNTipoDocumento
    Dim nMoneda As New RNMoneda
    Dim nAlmacen As New RNAlmacen
    Dim nPersonal As New RNPersonal
    Dim nCodigo_Facturacion As New RNCodigo_Facturacion
    Dim nProducto_Almacen As New RNProducto_Almacen
    Dim nKardex As New RNKardex
    Dim nDetalle_Caja As New RNDetalle_Caja
    Dim nClientes As New RNCliente
    Dim nOrden_Venta As New RNOrden_Venta
    Dim nFacturacion As New RNFacturacion
    Dim objFacturacion As New Facturacion
    Dim objOrden_Venta As New Orden_Venta
    Dim objClientes As New Cliente
    Dim objDetalle_Caja As New Detalle_Caja
    Dim objKardex As New Kardex
    Dim objProducto_Almacen As New Producto_Almacen
    Dim objCodigo_Facturacion As New Codigo_Facturacion
    Dim Tabla As DataTable
    Dim Tabla1 As DataTable
    Private Sub frmFacturacion_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub
    Private Sub frmFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' LÓGICA PERMISOS -------------------------------------------------
            Me.Tag = RNPersonalSubMenu.ListarPersonalSubMenu(CType(Me.Tag, Personal_SubMenu).id_menu, CType(Me.Tag, Personal_SubMenu).id_submenu, CType(Me.Tag, Personal_SubMenu).id_personal)
            If Me.Tag Is Nothing Then
                MessageBox.Show("Error al asignar archivos, consulte con el Administrador del Sstema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            ' -----------------------------------------------------------------

            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtnro_documento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnro_documento.KeyPress
        Dim texto As String
        Dim logitud As Integer
        texto = Me.txtnro_documento.Text.ToString
        logitud = Len(texto)
        If logitud = 3 Then
            Me.txtnro_documento.Enabled = False

        End If
    End Sub
    Private Sub btnBuscar_orden_venta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_orden_venta.Click
        frmListado_Orden_Venta.accion = 1
        If frmListado_Orden_Venta.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.objOrden_Venta = frmListado_Orden_Venta.objOrden_Venta
            CargarVenta()
        End If
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            Grabar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Try
            Eliminar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            EliminarTotal()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If frmListado_Facturacion.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objFacturacion = frmListado_Facturacion.objFacturacion
            Cargar()
            Habilitar(False)
            btnGrabar.Enabled = False
            btnEliminar.Tag = "Eliminar"
            btnEliminar.Text = "&Eliminar"
            btnNuevo.Enabled = True
            btnAnular.Enabled = True
            btnBuscar.Enabled = True
        End If
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------

    Sub Grabar()
        Try
            If Valida() Then
                objFacturacion.id_caja = Me.cboCaja.SelectedValue
                objFacturacion.Id_Operacion = Me.TxtIdOrden.Text.Trim
                objFacturacion.id_almacen = Me.cboAlmacen.SelectedValue
                objFacturacion.id_tipodocumento = Me.cboTipo_Documento.SelectedValue
                objFacturacion.numero_documento = Me.txtnro_documento.Text.ToString
                objFacturacion.serie_documento = Me.txtserie_documento.Text.ToString
                objFacturacion.Tipo_movimiento = "E"
                objFacturacion.monto = Me.txtfinanciado.Text.Trim
                objFacturacion.fecha_movimiento = Me.dtpfecha_emision.Value
                If MessageBox.Show("¿Desea registrar los datos de este Orden de Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objFacturacion = nFacturacion.RegistrarFacturacion(objFacturacion)
                    objKardex.id_movimiento = objFacturacion.id_movimiento
                    objKardex.fecha = Me.dtpfecha_emision.Value
                    objKardex.total = Me.TxtTotal.Text.Trim
                    objKardex.subtotal = Me.txtPrecio_neto.Text.Trim
                    objKardex.igv = Me.txtigv.Text.Trim
                    objKardex.numero_documento = Me.txtnro_documento.Text.ToString
                    objKardex.serie_documento = Me.txtserie_documento.Text.ToString
                    objKardex.id_compra = Me.TxtIdOrden.Text.Trim
                    objKardex.Tipo_Pago = Me.TxtTipo_pago.Text.Trim
                    objKardex.id_tipodocumento = Me.cboTipo_Documento.SelectedValue
                    objKardex.pago_inicial = Me.txtinicial.Text
                    objKardex.id_almacen = Me.cboAlmacen.SelectedValue
                    objKardex.monto_financiado = Me.txtfinanciado.Text.Trim
                    objKardex.nro_cuotas = Me.txtnro_cuotas.Text.Trim
                    objKardex.Monto_cuota = Me.txtMonto_cuota.Text.Trim
                    objKardex.ruc_dni = Me.txtdocumento.Text
                    objKardex.Nombre = Me.txtCliente.Text
                    objKardex.tipo = "V"
                    Dim Dgv As DataGridView
                    Dgv = Me.dtvListado_Productos
                    Try
                        For i As Integer = 0 To Dgv.RowCount - 1
                            objKardex.id_producto = CInt(Dgv.Item(0, i).Value)
                            objKardex.cantidad = CInt(Dgv.Item(2, i).Value)
                            objKardex.precio = CDbl(Dgv.Item(4, i).Value)
                            objKardex.Descuentro = CDbl(Dgv.Item(5, i).Value)
                            objKardex.Sub_Total = CDbl(Dgv.Item(6, i).Value)
                            If objKardex.id_producto <> 0 Then
                                objProducto_Almacen.id_almacen = Me.cboAlmacen.SelectedValue
                                objProducto_Almacen.id_producto = objKardex.id_producto
                                Tabla = nProducto_Almacen.Listar(objProducto_Almacen)
                                For Each Fila As DataRow In Tabla.Rows
                                    objProducto_Almacen.id_producto = Fila.Item("id_producto")
                                    objProducto_Almacen.id_almacen = Fila.Item("id_almacen")
                                    objProducto_Almacen.stock = Fila.Item("stock")
                                    objProducto_Almacen.descripcion = Fila.Item("descripcion")
                                Next
                                objKardex.stock = objProducto_Almacen.stock
                                objKardex = nKardex.RegistrarKardex(objKardex)
                                objProducto_Almacen.stock = objKardex.stock - objKardex.cantidad
                                nProducto_Almacen.AutorizaStock(objProducto_Almacen)
                            End If
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                    objOrden_Venta.id_venta = Me.TxtIdOrden.Text.Trim
                    objOrden_Venta.Estado = "2"
                    nOrden_Venta.AtenderVenta(objOrden_Venta)
                    Dim TextoError As String
                    Dim abreviatura As String = ""
                    Tabla = nTipoDocumento.Listar(Me.cboTipo_Documento.SelectedValue)
                    For Each Fila As DataRow In Tabla.Rows
                        abreviatura = Fila.Item("abreviatura")
                    Next
                    TextoError = "Serie: " & abreviatura & "/ " & Me.txtnro_documento.Text & " - " & Me.txtserie_documento.Text
                    MessageBox.Show("Los datos se guardaron satisfactoriamente" & vbCrLf & TextoError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objFacturacion.id_movimiento
                    Me.btnGrabar.Enabled = False
                    Me.btnNuevo.Enabled = True
                    Me.btnAnular.Enabled = True
                    Me.btnEliminar.Enabled = True
                    Me.btnBuscar.Enabled = True
                    Me.btnEliminar.Tag = "Eliminar"
                    Habilitar(False)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Modificar()
        Try
            If Valida() Then
                objFacturacion.id_movimiento = Me.lblCodigo.Text
                objFacturacion.id_caja = Me.cboCaja.SelectedValue
                objFacturacion.Id_Operacion = Me.TxtIdOrden.Text.Trim
                objFacturacion.id_almacen = Me.cboAlmacen.SelectedValue
                objFacturacion.id_tipodocumento = Me.cboTipo_Documento.SelectedValue
                objFacturacion.numero_documento = Me.txtnro_documento.Text.ToString
                objFacturacion.serie_documento = Me.txtserie_documento.Text.ToString
                objFacturacion.Tipo_movimiento = "E"
                objFacturacion.monto = Me.TxtTotal.Text.Trim
                objFacturacion.fecha_movimiento = Me.dtpfecha_emision.Value
                If MessageBox.Show("¿Desea modificar los datos de este Orden de Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    nFacturacion.ModificarFacturacion(objFacturacion)
                    objOrden_Venta.id_venta = Me.TxtIdOrden.Text.Trim
                    objOrden_Venta.Estado = "2"
                    nOrden_Venta.AtenderVenta(objOrden_Venta)
                    MessageBox.Show("Los datos se actualizaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.btnNuevo.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Eliminar()
        Try
            If MessageBox.Show("¿Desea anular los datos de este Orden de Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nFacturacion.EleminarFacturacion(lblCodigo.Text)
                objOrden_Venta.id_venta = Me.TxtIdOrden.Text.Trim
                objOrden_Venta.Estado = "1"
                nOrden_Venta.AtenderVenta(objOrden_Venta)
                MessageBox.Show("Los datos se eliminaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub EliminarTotal()
        Try
            If MessageBox.Show("¿Desea Eliminar los datos de este Orden de Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nFacturacion.EleminarFacturacionTotal(lblCodigo.Text)
                objOrden_Venta.id_venta = Me.TxtIdOrden.Text.Trim
                objOrden_Venta.Estado = "1"
                nOrden_Venta.AtenderVenta(objOrden_Venta)
                MessageBox.Show("Los datos se eliminaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Cargar()
        Try
            Dim Id_Producto As Integer
            Dim Producto As String
            Dim Cantidad As Integer
            Dim Unidad As String
            Dim costo As Double
            Dim Descuento As Double
            Dim Total As Double
            Dim ToDescuento As Double
            Dim suma As Double
            Tabla = nFacturacion.Listar(objFacturacion)
            For Each Fila As DataRow In Tabla.Rows
                objFacturacion.id_movimiento = Fila.Item("id_movimiento")
                objFacturacion.Id_Operacion = Fila.Item("id_operacion")
                objFacturacion.fecha_movimiento = Fila.Item("fecha_movimiento")
                objFacturacion.id_caja = Fila.Item("id_caja")
                objFacturacion.id_almacen = Fila.Item("id_almacen")
                objFacturacion.id_tipodocumento = Fila.Item("id_tipodocumento")
                objFacturacion.numero_documento = Fila.Item("numero_documento")
                objFacturacion.serie_documento = Fila.Item("serie_documento")
            Next
            Me.lblCodigo.Text = objFacturacion.id_movimiento
            Me.TxtIdOrden.Text = objFacturacion.Id_Operacion
            Me.dtpfecha_emision.Value = objFacturacion.fecha_movimiento
            LlenaCombos(objFacturacion.id_almacen)
            Me.cboCaja.SelectedValue = objFacturacion.id_caja
            LenarDocumento()
            Me.cboTipo_Documento.SelectedValue = objFacturacion.id_tipodocumento
            Me.txtnro_documento.Text = objFacturacion.numero_documento
            Me.txtserie_documento.Text = objFacturacion.serie_documento
            Tabla = nOrden_Venta.Listar(objFacturacion.Id_Operacion)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Venta.id_venta = Fila.Item("id_Venta")
                objOrden_Venta.total = Fila.Item("total")
                objOrden_Venta.subtotal = Fila.Item("subtotal")
                objOrden_Venta.igv = Fila.Item("igv")
                objOrden_Venta.id_Moneda = Fila.Item("id_moneda")
                objOrden_Venta.id_cliente = Fila.Item("id_cliente")
                objOrden_Venta.id_almacen = Fila.Item("id_almacen")
                objOrden_Venta.Tipo_Pago = Fila.Item("tipo_pago")
                objOrden_Venta.pago_inicial = Fila.Item("pago_inicial")
                objOrden_Venta.id_personal = Fila.Item("id_personal")
                objOrden_Venta.monto_financiado = Fila.Item("monto_financiado")
                objOrden_Venta.nro_cuotas = Fila.Item("nro_cuotas")
                objOrden_Venta.Monto_cuota = Fila.Item("Monto_cuota")
                objOrden_Venta.numero_documento = Fila.Item("numero_documento")
                objOrden_Venta.serie_documento = Fila.Item("serie_documento")
            Next
            Me.TxtIdOrden.Text = objOrden_Venta.id_venta
            objOrden_Venta.Estado = "1"
            nOrden_Venta.AtenderVenta(objOrden_Venta)
            Me.txtOrden_Venta.Text = "OV/ " & objOrden_Venta.numero_documento & "-" & objOrden_Venta.serie_documento
            Me.txtinicial.Text = objOrden_Venta.pago_inicial
            Me.txtfinanciado.Text = objOrden_Venta.monto_financiado
            Me.txtPrecio_neto.Text = objOrden_Venta.subtotal
            Me.txtigv.Text = objOrden_Venta.igv
            Me.TxtTotal.Text = objOrden_Venta.total
            Me.TxtTipo_pago.Text = objOrden_Venta.Tipo_Pago
            Me.txtnro_cuotas.Text = objOrden_Venta.nro_cuotas
            Me.txtMonto_cuota.Text = objOrden_Venta.Monto_cuota
            LlenarCombos()
            Me.cboMoneda.SelectedValue = objOrden_Venta.id_Moneda
            Me.cboVendedor.SelectedValue = objOrden_Venta.id_personal
            Tabla = nClientes.Listar(objOrden_Venta.id_cliente)
            For Each Fila As DataRow In Tabla.Rows
                objClientes.razon_social = Fila.Item("razon_social")
                objClientes.direccion = Fila.Item("direccion")
                objClientes.tipo_cliente = Fila.Item("tipo_cliente")
                objClientes.dni = Fila.Item("dni")
                objClientes.ruc = Fila.Item("ruc")
            Next
            If objClientes.tipo_cliente = "N" Then
                Me.txtdocumento.Text = objClientes.dni
            Else
                Me.txtdocumento.Text = objClientes.ruc
            End If
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
                objProducto_Almacen.id_almacen = objFacturacion.id_almacen
                objProducto_Almacen.id_producto = Id_Producto
                Tabla1 = nProducto_Almacen.Listar(objProducto_Almacen)
                For Each Fila1 As DataRow In Tabla1.Rows
                    objProducto_Almacen.id_producto = Fila1.Item("id_producto")
                    objProducto_Almacen.id_almacen = Fila1.Item("id_almacen")
                    objProducto_Almacen.stock = Fila1.Item("stock")
                    objProducto_Almacen.descripcion = Fila1.Item("descripcion")
                Next
                objKardex.stock = objProducto_Almacen.stock
                nKardex.EleminarKardex(objFacturacion.id_movimiento)
                objProducto_Almacen.stock = objKardex.stock - Cantidad
                nProducto_Almacen.AutorizaStock(objProducto_Almacen)
                ToDescuento = ToDescuento + Descuento
                suma = suma + Total
            Next
            Me.txtMonto_descuento.Text = ToDescuento
            Me.txtPrecio_bruto.Text = objOrden_Venta.total + ToDescuento
            btnAnular.Enabled = True
            btnEliminar.Enabled = True
            btnGrabar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarVenta()
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
                objOrden_Venta.id_almacen = Fila.Item("id_almacen")
                objOrden_Venta.Tipo_Pago = Fila.Item("tipo_pago")
                objOrden_Venta.pago_inicial = Fila.Item("pago_inicial")
                objOrden_Venta.id_personal = Fila.Item("id_personal")
                objOrden_Venta.monto_financiado = Fila.Item("monto_financiado")
                objOrden_Venta.nro_cuotas = Fila.Item("nro_cuotas")
                objOrden_Venta.Monto_cuota = Fila.Item("Monto_cuota")
            Next
            Me.TxtIdOrden.Text = objOrden_Venta.id_venta
            Me.txtOrden_Venta.Text = "OV/ " & objOrden_Venta.numero_documento & "-" & objOrden_Venta.serie_documento
            Me.dtpfecha_emision.Value = objOrden_Venta.fecha_emision
            Me.txtinicial.Text = Format(objOrden_Venta.pago_inicial, "##0.00")
            Me.txtfinanciado.Text = Format(objOrden_Venta.monto_financiado, "##0.00")
            Me.txtPrecio_neto.Text = Format(objOrden_Venta.subtotal, "##0.00")
            Me.txtigv.Text = Format(objOrden_Venta.igv, "##0.00")
            Me.TxtTotal.Text = Format(objOrden_Venta.total, "##0.00")
            Me.TxtTipo_pago.Text = objOrden_Venta.Tipo_Pago
            Me.txtnro_cuotas.Text = objOrden_Venta.nro_cuotas
            Me.txtMonto_cuota.Text = Format(objOrden_Venta.Monto_cuota, "##0.00")
            'Added 2014.04.11-------------------------------------------
            Me.txtserie_documento.Text = objOrden_Venta.serie_documento
            Me.txtnro_documento.Text = objOrden_Venta.numero_documento
            '-----------------------------------------------------------
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
                    Me.cboTipo_Documento.SelectedValue = "002"
                End If
            Else
                Me.txtdocumento.Text = objClientes.ruc
                If TipoDocumento.Rows.Count > 0 Then
                    Me.cboTipo_Documento.SelectedValue = "001"
                End If
            End If
            Tabla = nCodigo_Facturacion.Listar(objOrden_Venta.id_almacen)
            For Each Fila As DataRow In Tabla.Rows
                objCodigo_Facturacion.id_Codigo = Fila.Item("id_Codigo")
            Next
            Me.txtnro_documento.Text = objCodigo_Facturacion.id_Codigo
            BuscarSerie(objCodigo_Facturacion.id_Codigo, Me.cboTipo_Documento.SelectedValue)
            Me.txtCliente.Text = objClientes.razon_social
            Me.txtdireccion.Text = objClientes.direccion
            'Added 2014.04.12
            LlenaCombos(objOrden_Venta.id_almacen, objOrden_Venta.Tipo_Pago)
            LlenaCombos(objOrden_Venta.id_almacen)
            Me.cboCaja.SelectedValue = 1
            LlenarCombos()
            Me.cboMoneda.SelectedValue = objOrden_Venta.id_Moneda
            Me.cboAlmacen.SelectedValue = objOrden_Venta.id_almacen
            Me.cboVendedor.SelectedValue = objOrden_Venta.id_personal
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
                Me.dtvListado_Productos.Rows.Add(Id_Producto, Producto, Cantidad, Unidad, Format(costo, "##0.00"), Format(Descuento, "##0.00"), Format(Total, "##0.00"))
                ToDescuento = ToDescuento + Descuento
                suma = suma + Total
            Next
            Me.txtMonto_descuento.Text = ToDescuento
            Me.txtPrecio_bruto.Text = objOrden_Venta.total + ToDescuento
            Me.txtnro_documento.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Habilitar(ByVal Estado As Boolean)
        Me.cboCaja.Enabled = Estado
        Me.dtpfecha_emision.Enabled = Estado
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
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        Me.txtCliente.Enabled = False
        Me.txtdireccion.Enabled = False
        Me.TxtIdOrden.Visible = False
        Me.TxtTipo_pago.Visible = False
        Me.txtOrden_Venta.Enabled = False
        Me.cboAlmacen.Enabled = False
        Me.cboMoneda.Enabled = False
        Me.txtfinanciado.Enabled = False
        Me.dtvListado_Productos.Enabled = False
        Me.txtserie_documento.Enabled = False
        Me.txtdocumento.Enabled = False
        Me.cboTipo_Documento.Enabled = False
        Me.cboVendedor.Enabled = False
        Me.txtnro_cuotas.Enabled = False
        Me.txtMonto_cuota.Enabled = False
        Me.txtnro_documento.Enabled = False
        Me.txtCliente.Text = ""
        Me.txtdireccion.Text = ""
        Me.TxtIdOrden.Text = ""
        Me.TxtTipo_pago.Text = ""
        Me.txtnro_cuotas.Text = ""
        Me.txtMonto_cuota.Text = ""
        Me.cboTipo_Documento.SelectedValue = "1"
        Me.cboCaja.SelectedValue = "1"
        Me.cboVendedor.SelectedValue = "0"
        Me.cboAlmacen.SelectedValue = "0"
        Me.cboMoneda.SelectedValue = "0"
        Me.txtnro_documento.Text = ""
        Me.txtserie_documento.Text = ""
        Me.txtOrden_Venta.Text = ""
        Me.txtfinanciado.Text = ""
        Me.txtdocumento.Text = ""
        Me.txtPrecio_bruto.Text = ""
        Me.txtMonto_descuento.Text = ""
        Me.txtPrecio_neto.Text = ""
        Me.txtigv.Text = ""
        Me.TxtTotal.Text = ""
        Me.txtinicial.Text = ""
        Me.dtpfecha_emision.Value = DateTime.Now()
        Me.dtvListado_Productos.Rows.Clear()
        Me.btnNuevo.Enabled = True
        Me.btnGrabar.Tag = "Grabar"
        Me.btnGrabar.Enabled = True
        Me.btnEliminar.Enabled = False
        Me.btnAnular.Enabled = False
        Me.btnBuscar.Enabled = True
        Me.btnImprimir.Enabled = False
        Me.btnSalir.Enabled = True
        Me.txtPrecio_bruto.Enabled = False
        Me.txtinicial.Enabled = False
        Me.txtMonto_descuento.Enabled = False
        Me.txtPrecio_neto.Enabled = False
        Me.txtigv.Enabled = False
        Me.TxtTotal.Enabled = False


        ' LÓGICA PERMISOS -------------------------------------------------
        Dim Permiso As Personal_SubMenu = CType(Me.Tag, Personal_SubMenu)
        Me.btnGrabar.Visible = Permiso.nuevo

        Me.btnEliminar.Visible = Permiso.eliminar
        ' -----------------------------------------------------------------
        Me.cboCaja.Focus()
    End Sub
    Sub LlenaCombos(ByVal Id_Almacen As Integer)
        Try
            Dim Caja As DataTable = nDetalle_Caja.Listar(Id_Almacen)
            Me.cboCaja.ValueMember = "id_caja"
            Me.cboCaja.DisplayMember = "descripcion"
            Me.cboCaja.DataSource = Caja
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    'Added 2014.04.12
    Sub LlenaCombos(ByVal Id_Almacen As Integer, ByVal Tipo_Pago As String)
        Try
            Dim Caja As DataTable = nDetalle_Caja.Listar(Id_Almacen, Tipo_Pago)
            Me.cboCaja.DataSource = Caja
            Me.cboCaja.ValueMember = "id_caja"
            Me.cboCaja.DisplayMember = "descripcion"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
            SinTipoDocumento.Rows.Add("1", "No hay Tipo de Documento registradas")
            Me.cboTipo_documento.DataSource = SinTipoDocumento
            Me.cboTipo_documento.ValueMember = "id_tipodocumento"
            Me.cboTipo_documento.DisplayMember = "descripcion"
            Me.cboTipo_Documento.SelectedValue = "1"
            Me.btnGrabar.Enabled = False
        End If
    End Sub
    Sub LlenarCombos()
        Try
            Dim Almancen As DataTable = nAlmacen.Listar
            Me.cboAlmacen.ValueMember = "id_almacen"
            Me.cboAlmacen.DisplayMember = "descripcion"
            If Almancen.Rows.Count > 0 Then
                Me.cboAlmacen.DataSource = Almancen
            Else
                Dim SinAlmancen As New DataTable
                SinAlmancen.Columns.Add("id_almacen")
                SinAlmancen.Columns.Add("descripcion")
                SinAlmancen.Rows.Add("0", "No hay Almancen registradas")
                Me.cboAlmacen.DataSource = SinAlmancen
                Me.cboAlmacen.ValueMember = "id_almacen"
                Me.cboAlmacen.DisplayMember = "descripcion"
                Me.cboAlmacen.SelectedValue = "0"
                Me.btnGrabar.Enabled = False
            End If
            Dim Moneda As DataTable = nMoneda.Listar
            Me.cboMoneda.ValueMember = "id_moneda"
            Me.cboMoneda.DisplayMember = "descripcion"
            If Moneda.Rows.Count > 0 Then
                Me.cboMoneda.DataSource = Moneda
            Else
                Dim SinMoneda As New DataTable
                SinMoneda.Columns.Add("id_moneda")
                SinMoneda.Columns.Add("descripcion")
                SinMoneda.Rows.Add("0", "No hay Moneda registradas")
                Me.cboMoneda.DataSource = SinMoneda
                Me.cboMoneda.ValueMember = "id_moneda"
                Me.cboMoneda.DisplayMember = "descripcion"
                Me.cboMoneda.SelectedValue = "0"
                Me.btnGrabar.Enabled = False
            End If
            Dim Personal As DataTable = nPersonal.Listar()
            Me.cboVendedor.ValueMember = "id_personal"
            Me.cboVendedor.DisplayMember = "NombreCompleto"
            Me.cboVendedor.DataSource = Personal
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub BuscarSerie(ByVal Serie As String, ByVal Domnento As String)
        Dim NumDomento As String
        Dim NumSerie As Integer
        Dim SerieActaul As Integer
        Tabla = nFacturacion.buscarid(Serie, Domnento)
        NumSerie = 1
        For Each Fila As DataRow In Tabla.Rows
            SerieActaul = Fila.Item("serie")
            If NumSerie = SerieActaul Then
                NumSerie = NumSerie + 1
            End If
        Next
        If NumSerie < 10 Then
            NumDomento = "000000" & NumSerie.ToString
        ElseIf NumSerie < 100 Then
            NumDomento = "00000" & NumSerie.ToString
        ElseIf NumSerie < 1000 Then
            NumDomento = "0000" & NumSerie.ToString
        ElseIf NumSerie < 10000 Then
            NumDomento = "000" & NumSerie.ToString
        ElseIf NumSerie < 100000 Then
            NumDomento = "00" & NumSerie.ToString
        ElseIf NumSerie < 1000000 Then
            NumDomento = "0" & NumSerie.ToString
        Else
            NumDomento = NumSerie.ToString
        End If
        Me.txtserie_documento.Text = NumDomento
    End Sub
    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Function Valida() As Boolean
        Dim TextoError As String = ""
        'If Me.Txtnumero_documento.Text.Trim = "" Then
        'TextoError = TextoError & "- Debe ingresar un Numero de Documento." & vbCrLf
        'End If
        'If Me.txtserie_documento.Text.Trim = "" Then
        '    TextoError = TextoError & "- Debe ingresar un Serie de Documento." & vbCrLf
        'End If
        If Me.txtCliente.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Clientes." & vbCrLf
        End If
        If Me.cboTipo_Documento.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una sucursal." & vbCrLf
        End If
        If Me.cboAlmacen.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar un Almacen." & vbCrLf
        End If
        If Me.cboMoneda.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una Monoda." & vbCrLf
        End If
        'If Me.cboTipoPago.SelectedValue = "0" Then
        'TextoError = TextoError & "- Debe ingresar un Tipo de Pago." & vbCrLf
        'End If
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
    