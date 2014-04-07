Imports Entidades
Imports Reglas_Negocio
Public Class frmFacturacion
    Dim nTipoDocumento As New RNTipoDocumento
    Dim nCaja As New RNCaja
    Dim nMoneda As New RNMoneda
    Dim nAlmacen As New RNAlmacen
    Dim nPersonal As New RNPersonal
    Dim nClientes As New RNCliente
    Dim nOrden_Venta As New RNOrden_Venta
    Dim nFacturacion As New RNFacturacion
    Dim objFacturacion As New Facturacion
    Dim objOrden_Venta As New Orden_Venta
    Dim objClientes As New Cliente
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
            LlenaCombos()
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
            BuscarSerie(texto, Me.cboTipo_Documento.SelectedValue)
        End If
    End Sub
    Private Sub btnBuscar_orden_venta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_orden_venta.Click
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
            If Me.btnGrabar.Tag = "Grabar" Then
                Grabar()
            Else
                'Modified 2014.03.25
                'REVISAR SI CONTINÚA LÓGICA DE MODIFICACIÓN DEBIDO A QUE NO HAY BOTÓN MODIFICAR
                If Valida() Then
                    If MessageBox.Show("¿Desea modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        Modificar()
                        Habilitar(False)
                        btnGrabar.Tag = "Grabar"
                        btnGrabar.Enabled = False
                        btnEliminar.Tag = "Eliminar"
                        btnEliminar.Text = "&Eliminar"
                        btnNuevo.Enabled = True
                        btnAnular.Enabled = True
                        btnImprimir.Enabled = True
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

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        Try
            Eliminar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            If btnEliminar.Tag = "Eliminar" Then
                Habilitar(True)
                btnGrabar.Tag = "Eliminar"
                btnGrabar.Enabled = True
                btnEliminar.Tag = "Eliminar"
                btnEliminar.Text = "&Eliminar"
                btnNuevo.Enabled = False
                btnAnular.Enabled = False
                btnImprimir.Enabled = False
            Else
                Habilitar(False)
                btnGrabar.Tag = "Grabar"
                btnGrabar.Enabled = False
                btnEliminar.Tag = "Modificar"
                btnEliminar.Text = "&Modificar"
                btnNuevo.Enabled = True
                btnAnular.Enabled = True
                btnImprimir.Enabled = True
                Cargar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
                'objOrden_Venta.fecha_emision = Me.dtpFecha.Value
                'objOrden_Venta.total = Me.TxtTotal.Text.Trim
                'objOrden_Venta.subtotal = Me.txtPrecio_neto.Text.Trim
                'objOrden_Venta.igv = Me.txtigv.Text.Trim
                'objOrden_Venta.numero_documento = Me.Txtnumero_documento.Text.ToString
                'objOrden_Venta.serie_documento = Me.Txtserie_documento.Text.ToString
                'objOrden_Venta.id_cliente = Me.Txtid_Cliente.Text.Trim
                'objOrden_Venta.Tipo_Pago = Me.cboTipoPago.SelectedValue
                'objOrden_Venta.pago_inicial = Me.txtinicial.Text.Trim
                'objOrden_Venta.id_tipodocumento = Me.cboTipo_documento.SelectedValue
                'objOrden_Venta.id_Moneda = Me.cboMoneda.SelectedValue
                'objOrden_Venta.id_sucursal = Me.cboSucursal.SelectedValue
                'objOrden_Venta.id_almacen = Me.cboAlmacen.SelectedValue
                'objOrden_Venta.id_personal = Me.cboVendedor.SelectedValue
                'objOrden_Venta.monto_financiado = Me.txtmonto_financiado.Text.Trim
                'objOrden_Venta.nro_cuotas = Me.txtnro_cuotas.Text.Trim
                'objOrden_Venta.Monto_cuota = Me.txtMonto_cuota.Text.Trim
                If MessageBox.Show("¿Desea registrar los datos de este Orden de Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'objOrden_Venta = nOrden_Venta.RegistrarVenta(objOrden_Venta)
                    'Dim Dgv As DataGridView
                    'Dgv = Me.dtvListado_Productos
                    Try
                        'For i As Integer = 0 To Dgv.RowCount - 1
                        'objOrden_Venta.id_producto = CInt(Dgv.Item(0, i).Value)
                        'objOrden_Venta.cantidad = CInt(Dgv.Item(2, i).Value)
                        'objOrden_Venta.precio_venta = CDbl(Dgv.Item(4, i).Value)
                        'objOrden_Venta.descuento = CDbl(Dgv.Item(5, i).Value)
                        'objOrden_Venta.Sub_Total = CDbl(Dgv.Item(6, i).Value)
                        'If objOrden_Venta.id_producto <> 0 Then
                        'nOrden_Venta.RegistrarVenta_Producto(objOrden_Venta)
                        'End If
                        'Next
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                    'Dim TextoError As String
                    'TextoError = "Serie: OV/ " & Me.Txtnumero_documento.Text & " - " & Me.Txtserie_documento.Text
                    'MessageBox.Show("Los datos se guardaron satisfactoriamente" & vbCrLf & TextoError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Me.lblCodigo.Text = objOrden_Venta.id_venta
                    Me.btnGrabar.Enabled = False
                    Me.btnNuevo.Enabled = True
                    Me.btnAnular.Enabled = True
                    Me.btnEliminar.Enabled = True
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
                'objOrden_Venta.id_venta = Me.lblCodigo.Text
                'objOrden_Venta.total = Me.TxtTotal.Text.Trim
                'objOrden_Venta.subtotal = Me.txtPrecio_neto.Text.Trim
                'objOrden_Venta.igv = Me.txtigv.Text.Trim
                'objOrden_Venta.numero_documento = Me.Txtnumero_documento.Text.ToString
                'objOrden_Venta.serie_documento = Me.Txtserie_documento.Text.ToString
                'objOrden_Venta.id_cliente = Me.Txtid_Cliente.Text.Trim
                'objOrden_Venta.Tipo_Pago = Me.cboTipoPago.SelectedValue
                'objOrden_Venta.pago_inicial = Me.txtinicial.Text.Trim
                'objOrden_Venta.id_sucursal = Me.cboSucursal.SelectedValue
                'objOrden_Venta.id_Moneda = Me.cboMoneda.SelectedValue
                'objOrden_Venta.id_almacen = Me.cboAlmacen.SelectedValue
                'objOrden_Venta.id_personal = Me.cboVendedor.SelectedValue
                'objOrden_Venta.monto_financiado = Me.txtmonto_financiado.Text.Trim
                'objOrden_Venta.nro_cuotas = Me.txtnro_cuotas.Text.Trim
                'objOrden_Venta.Monto_cuota = Me.txtMonto_cuota.Text.Trim
                If MessageBox.Show("¿Desea modificar los datos de este Orden de Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'nOrden_Venta.ModificarVenta(objOrden_Venta)
                    'Dim Dgv As DataGridView
                    'Dgv = Me.dtvListado_Productos
                    'nOrden_Venta.EleminarVenta_Producto(objOrden_Venta.id_venta)
                    Try
                        'For i As Integer = 0 To Dgv.RowCount - 1
                        'objOrden_Venta.id_producto = CInt(Dgv.Item(0, i).Value)
                        'objOrden_Venta.cantidad = CInt(Dgv.Item(2, i).Value)
                        'objOrden_Venta.precio_venta = CDbl(Dgv.Item(4, i).Value)
                        'objOrden_Venta.descuento = CDbl(Dgv.Item(5, i).Value)
                        'objOrden_Venta.Sub_Total = CDbl(Dgv.Item(6, i).Value)
                        'If objOrden_Venta.id_producto <> 0 Then
                        'nOrden_Venta.RegistrarVenta_Producto(objOrden_Venta)
                        'End If
                        'Next
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
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
            If MessageBox.Show("¿Desea eliminar los datos de este Orden de Venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'nOrden_Venta.EleminarVenta(lblCodigo.Text)
                'nOrden_Venta.EleminarVenta_Producto(lblCodigo.Text)
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
            'Dim Id_Producto As Integer
            'Dim Producto As String
            'Dim Cantidad As Integer
            'Dim Unidad As String
            'Dim costo As Double
            'Dim Descuento As Double
            'Dim Total As Double
            'Dim ToDescuento As Double
            'Dim suma As Double
            'Tabla = nOrden_Venta.Listar(objOrden_Venta.id_venta)
            For Each Fila As DataRow In Tabla.Rows
                'objOrden_Venta.id_venta = Fila.Item("id_Venta")
                'objOrden_Venta.fecha_emision = Fila.Item("fecha_emision")
                'objOrden_Venta.total = Fila.Item("total")
                'objOrden_Venta.subtotal = Fila.Item("subtotal")
                'objOrden_Venta.igv = Fila.Item("igv")
                'objOrden_Venta.numero_documento = Fila.Item("numero_documento")
                'objOrden_Venta.serie_documento = Fila.Item("serie_documento")
                'objOrden_Venta.id_Moneda = Fila.Item("id_moneda")
                'objOrden_Venta.id_cliente = Fila.Item("id_cliente")
                'objOrden_Venta.id_almacen = Fila.Item("id_almacen")
                'objOrden_Venta.id_sucursal = Fila.Item("id_sucursal")
                'objOrden_Venta.Tipo_Pago = Fila.Item("tipo_pago")
                'objOrden_Venta.pago_inicial = Fila.Item("pago_inicial")
                'objOrden_Venta.id_personal = Fila.Item("id_personal")
                'objOrden_Venta.monto_financiado = Fila.Item("monto_financiado")
                'objOrden_Venta.nro_cuotas = Fila.Item("nro_cuotas")
                'objOrden_Venta.Monto_cuota = Fila.Item("Monto_cuota")
            Next
            'Me.lblCodigo.Text = objOrden_Venta.id_venta
            'Me.Txtnumero_documento.Text = objOrden_Venta.numero_documento
            'Me.Txtserie_documento.Text = objOrden_Venta.serie_documento
            'Me.cboMoneda.SelectedValue = objOrden_Venta.id_Moneda
            'Me.cboTipoPago.SelectedValue = objOrden_Venta.Tipo_Pago
            'Me.dtpFecha.Value = objOrden_Venta.fecha_emision
            'Me.Txtid_Cliente.Text = objOrden_Venta.id_cliente
            'Me.txtPrecio_neto.Text = objOrden_Venta.subtotal
            'Me.txtigv.Text = objOrden_Venta.igv
            'Me.TxtTotal.Text = objOrden_Venta.total
            'Me.txtinicial.Text = objOrden_Venta.pago_inicial
            'Me.cboTipo_documento.SelectedValue = objOrden_Venta.id_sucursal
            'Me.cboAlmacen.SelectedValue = objOrden_Venta.id_almacen
            If objOrden_Venta.monto_financiado <> 0.0 Then
                'Me.txtmonto_financiado.Text = objOrden_Venta.monto_financiado
            End If
            If objOrden_Venta.nro_cuotas <> 0 Then
                'Me.txtnro_cuotas.Text = objOrden_Venta.nro_cuotas
            End If
            If objOrden_Venta.Monto_cuota <> 0.0 Then
                'Me.txtMonto_cuota.Text = objOrden_Venta.Monto_cuota
            End If
            'Tabla = nClientes.Listar(objOrden_Venta.id_cliente)
            For Each Fila As DataRow In Tabla.Rows
                'objClientes.razon_social = Fila.Item("razon_social")
                'objClientes.direccion = Fila.Item("direccion")
                'objClientes.tipo_cliente = Fila.Item("tipo_cliente")
                'objClientes.dni = Fila.Item("dni")
                'objClientes.ruc = Fila.Item("ruc")
            Next
            'LenarDocumento()
            'Dim TipoDocumento As DataTable = nTipoDocumento.Listar()
            'If objClientes.tipo_cliente = "N" Then
            'Me.txtdocumento.Text = objClientes.dni
            'If TipoDocumento.Rows.Count > 0 Then
            'Me.cboTipo_Documento.SelectedValue = "2"
            'End If
            'Else
            'Me.txtdocumento.Text = objClientes.dni
            'If TipoDocumento.Rows.Count > 0 Then
            'Me.cboTipo_Documento.SelectedValue = "1"
            'End If
            'Me.txtdocumento.Text = objClientes.ruc
            'End If
            'LenarPersonal()
            'Me.cboVendedor.SelectedValue = objOrden_Venta.id_personal
            'Me.txtCliente.Text = objClientes.razon_social
            'Me.txtdireccion.Text = objClientes.direccion
            'Tabla = nOrden_Venta.ListarDetalle(objOrden_Venta.id_venta)
            'ToDescuento = 0.0
            'suma = 0.0
            'Me.dtvListado_Productos.Rows.Clear()
            'For Each Fila As DataRow In Tabla.Rows
            'Id_Producto = Fila.Item("id_producto")
            'Producto = Fila.Item("nombre_producto")
            'Cantidad = Fila.Item("cantidad")
            'Unidad = Fila.Item("abreviatura")
            'costo = Fila.Item("precio_Venta")
            'Descuento = Fila.Item("descuento")
            'Total = Fila.Item("Sub_Total")
            'Me.dtvListado_Productos.Rows.Add(Id_Producto, Producto, Cantidad, Unidad, costo, Descuento, Total)
            'ToDescuento = ToDescuento + Descuento
            'suma = suma + Total
            'Next
            'Me.txtMonto_descuento.Text = ToDescuento
            'Me.txtPrecio_bruto.Text = objOrden_Venta.total + ToDescuento
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
                objOrden_Venta.id_sucursal = Fila.Item("id_sucursal")
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
            Me.txtinicial.Text = objOrden_Venta.pago_inicial
            Me.txtfinanciado.Text = objOrden_Venta.monto_financiado
            Me.txtPrecio_neto.Text = objOrden_Venta.subtotal
            Me.txtigv.Text = objOrden_Venta.igv
            Me.TxtTotal.Text = objOrden_Venta.total
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
                    Me.cboTipo_Documento.SelectedValue = "2"
                End If
            Else
                Me.txtdocumento.Text = objClientes.ruc
                If TipoDocumento.Rows.Count > 0 Then
                    Me.cboTipo_Documento.SelectedValue = "1"
                End If
            End If
            Me.txtCliente.Text = objClientes.razon_social
            Me.txtdireccion.Text = objClientes.direccion
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
                Me.dtvListado_Productos.Rows.Add(Id_Producto, Producto, Cantidad, Unidad, costo, Descuento, Total)
                ToDescuento = ToDescuento + Descuento
                suma = suma + Total
            Next
            Me.txtMonto_descuento.Text = ToDescuento
            Me.txtPrecio_bruto.Text = objOrden_Venta.total + ToDescuento
            Me.txtnro_documento.Enabled = True
            Me.txtnro_documento.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Habilitar(ByVal Estado As Boolean)
        Me.cboCaja.Enabled = Estado
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
        Me.txtOrden_Venta.Enabled = False
        Me.cboAlmacen.Enabled = False
        Me.dtpfecha_emision.Enabled = False
        Me.cboMoneda.Enabled = False
        Me.txtfinanciado.Enabled = False
        Me.dtvListado_Productos.Enabled = False
        Me.txtserie_documento.Enabled = False
        Me.txtdocumento.Enabled = False
        Me.cboTipo_Documento.Enabled = False
        Me.cboVendedor.Enabled = False
        Me.txtCliente.Text = ""
        Me.txtdireccion.Text = ""
        Me.TxtIdOrden.Text = ""
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
        Me.txtPrecio_bruto.Enabled = False
        Me.txtinicial.Enabled = False
        Me.txtMonto_descuento.Enabled = False
        Me.txtPrecio_neto.Enabled = False
        Me.txtigv.Enabled = False
        Me.TxtTotal.Enabled = False
        Me.txtnro_documento.Enabled = False

        ' LÓGICA PERMISOS -------------------------------------------------
        Dim Permiso As Personal_SubMenu = CType(Me.Tag, Personal_SubMenu)
        Me.btnGrabar.Visible = Permiso.nuevo

        Me.btnEliminar.Visible = Permiso.eliminar
        ' -----------------------------------------------------------------
        Me.cboCaja.Focus()
    End Sub
    Sub LlenaCombos()
        'Try
        '    Dim Caja As DataTable = nCaja.Listar
        '    Me.cboCaja.ValueMember = "id_caja"
        '    Me.cboCaja.DisplayMember = "fecha"
        '    If Caja.Rows.Count > 0 Then
        'Me.cboCaja.DataSource = Caja
        '    Else
        'Dim SinCaja As New DataTable
        'SinCaja.Columns.Add("id_caja")
        'SinCaja.Columns.Add("fecha")
        'SinCaja.Rows.Add("0", "No hay Caja registradas")
        'Me.cboMoneda.DataSource = SinCaja
        'Me.cboMoneda.ValueMember = "id_caja"
        'Me.cboMoneda.DisplayMember = "fecha"
        'Me.cboMoneda.SelectedValue = "0"
        'Me.btnGrabar.Enabled = False
        '    End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
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
            Me.cboVendedor.DisplayMember = "nombres"
            Me.cboVendedor.DataSource = Personal
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub BuscarSerie(ByVal Serie As String, ByVal Domnento As Integer)
        Dim NumDomento As String
        Dim NumSerie As Integer
        NumSerie = nFacturacion.buscarid(Serie, Domnento)
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
        If Me.txtserie_documento.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Serie de Documento." & vbCrLf
        End If
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
    