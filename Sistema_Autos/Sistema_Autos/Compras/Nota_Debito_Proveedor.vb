Imports Entidades
Imports Reglas_Negocio
Public Class frmNota_Debito_Proveedor
    Dim nTipodocumento As New RNTipoDocumento
    Dim nAlmacen As New RNAlmacen
    Dim nMoneda As New RNMoneda
    Dim nUnidad As New RNUnidad
    Dim nTipo_Cambio As New RNTipo_cambio
    Dim nProducto_Almacen As New RNProducto_Almacen
    Dim nKardex As New RNKardex
    Dim nProveedor As New RNProveedor
    Dim nOrden_Compra As New RNOrden_Compra
    Dim nNota_Debito_Proveedor As New RNNota_Debito_Proveedor
    Dim objNota_Debito_Proveedor As New Nota_Debito_Proveedor
    Dim objOrden_Compra As New Orden_Compra
    Dim objProveedor As New Proveedor
    Dim objKardex As New Kardex
    Dim objProducto_Almacen As New Producto_Almacen
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmNota_Debito_Proveedor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub

    Private Sub frmNota_Debito_Proveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Tag = RNPersonalSubMenu.ListarPersonalSubMenu(CType(Me.Tag, Personal_SubMenu).id_menu, CType(Me.Tag, Personal_SubMenu).id_submenu, CType(Me.Tag, Personal_SubMenu).id_personal)
            If Me.Tag Is Nothing Then
                MessageBox.Show("Error al asignar archivos, consulte con el Administrador del Sstema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            Limpiar()
            LlenaCombos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub dtvListado_Productos_DoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtvListado_Productos.DoubleClick
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
   
    Private Sub btnbuscar_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_proveedor.Click
        If frmListar_Orden_Compra.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.objOrden_Compra = frmListar_Orden_Compra.objOrden_Compra
            CargarCompra()
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
                        If CType(Me.Tag, Personal_SubMenu).nuevo = False Then
                            Me.btnGrabar.Visible = False
                        End If
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
                If CType(Me.Tag, Personal_SubMenu).nuevo = False Then
                    Me.btnGrabar.Visible = True
                End If
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
                If CType(Me.Tag, Personal_SubMenu).nuevo = False Then
                    Me.btnGrabar.Visible = False
                End If
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
        If frmBuscar_Nota_Debito_Proovedor.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.objNota_Debito_Proveedor = frmBuscar_Nota_Debito_Proovedor.objNota_Debito_Proovedor
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

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

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
                objNota_Debito_Proveedor.fecha_emision = Me.dtpfecha_emision.Value
                objNota_Debito_Proveedor.total = Me.TxtTotal.Text.Trim
                objNota_Debito_Proveedor.subtotal = Me.txtPrecio_neto.Text.Trim
                objNota_Debito_Proveedor.igv = Me.txtigv.Text.Trim
                objNota_Debito_Proveedor.serie_nota_debito = Me.txtserie_documento.Text.ToString
                objNota_Debito_Proveedor.nro_nota_debito = Me.txtnro_documento.Text.ToString
                objNota_Debito_Proveedor.id_compra = Me.TxtIdOrden.Text.ToString
                objNota_Debito_Proveedor.Motivo = Me.cboMotivo.SelectedValue
                objNota_Debito_Proveedor.id_tipodocumento = Me.cbotipo_documento.SelectedValue
                objNota_Debito_Proveedor.Saldo_Pendiente = Me.txtsaldo_pendiente.Text.ToString
                objKardex.fecha = Me.dtpfecha_emision.Value
                objKardex.numero_documento = Me.txtnro_documento.Text
                objKardex.serie_documento = Me.txtserie_documento.Text
                objKardex.id_tipodocumento = Me.cbotipo_documento.SelectedValue
                objKardex.tipo = "E"
                If MessageBox.Show("¿Desea registrar los datos de este Nota de Debito?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objNota_Debito_Proveedor = nNota_Debito_Proveedor.RegistrarNota_Debito_Proveedor(objNota_Debito_Proveedor)
                    Dim Dgv As DataGridView
                    Dgv = Me.dtvListado_Productos
                    Try
                        For i As Integer = 0 To Dgv.RowCount - 1
                            objNota_Debito_Proveedor.id_producto = CInt(Dgv.Item(0, i).Value)
                            objNota_Debito_Proveedor.cantidad = CInt(Dgv.Item(2, i).Value)
                            objNota_Debito_Proveedor.precio_compra = CDbl(Dgv.Item(4, i).Value)
                            objNota_Debito_Proveedor.descuento = CDbl(Dgv.Item(5, i).Value)
                            objNota_Debito_Proveedor.Sub_Total = CDbl(Dgv.Item(6, i).Value)
                            If objNota_Debito_Proveedor.id_producto <> 0 Then
                                nNota_Debito_Proveedor.RegistrarDetalle_Nota_Debito_Proveedor(objNota_Debito_Proveedor)
                                If Me.rbtDevolucion.Checked Then
                                    Dim Tabla As DataTable
                                    objKardex.id_producto = objNota_Debito_Proveedor.id_producto
                                    objKardex.cantidad = objNota_Debito_Proveedor.cantidad
                                    objKardex.precio = objNota_Debito_Proveedor.precio_compra
                                    objKardex.Descuentro = objNota_Debito_Proveedor.descuento
                                    objKardex.total = objNota_Debito_Proveedor.Sub_Total
                                    objKardex.id_almacen = Me.cboAlmacen.SelectedValue
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
                                    objProducto_Almacen.stock = objKardex.stock + objKardex.cantidad
                                    nProducto_Almacen.AutorizaStock(objProducto_Almacen)
                                End If
                            End If
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                    Dim TextoError As String
                    TextoError = "Serie: ND/ " & Me.txtnro_documento.Text & " - " & Me.txtserie_documento.Text
                    MessageBox.Show("Los datos se guardaron satisfactoriamente" & vbCrLf & TextoError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objOrden_Compra.id_compra
                    Me.btnGrabar.Enabled = False
                    Me.btnNuevo.Enabled = True
                    Me.btnModificar.Enabled = True
                    Me.btnImprimir.Enabled = True
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
            objNota_Debito_Proveedor.fecha_emision = Me.dtpfecha_emision.Value
            objNota_Debito_Proveedor.total = Me.TxtTotal.Text.Trim
            objNota_Debito_Proveedor.subtotal = Me.txtPrecio_neto.Text.Trim
            objNota_Debito_Proveedor.igv = Me.txtigv.Text.Trim
            objNota_Debito_Proveedor.serie_nota_debito = Me.txtserie_documento.Text.ToString
            objNota_Debito_Proveedor.nro_nota_debito = Me.txtnro_documento.Text.ToString
            objNota_Debito_Proveedor.id_compra = Me.TxtIdOrden.Text.ToString
            objNota_Debito_Proveedor.Motivo = Me.cboMotivo.SelectedValue
            objNota_Debito_Proveedor.id_tipodocumento = Me.cbotipo_documento.SelectedValue
            objNota_Debito_Proveedor.Saldo_Pendiente = Me.txtsaldo_pendiente.Text.ToString
            nNota_Debito_Proveedor.ModificarNota_Debito_Proveedor(objNota_Debito_Proveedor)
            Dim Dgv As DataGridView
            Dgv = Me.dtvListado_Productos
            nNota_Debito_Proveedor.EleminarDetalle_Nota_Debito_Proveedor(objNota_Debito_Proveedor.id_nota_debito)
            Try
                For i As Integer = 0 To Dgv.RowCount - 1
                    objNota_Debito_Proveedor.id_producto = CInt(Dgv.Item(0, i).Value)
                    objNota_Debito_Proveedor.cantidad = CInt(Dgv.Item(2, i).Value)
                    objNota_Debito_Proveedor.precio_compra = CDbl(Dgv.Item(4, i).Value)
                    objNota_Debito_Proveedor.descuento = CDbl(Dgv.Item(5, i).Value)
                    objNota_Debito_Proveedor.Sub_Total = CDbl(Dgv.Item(6, i).Value)
                    If objNota_Debito_Proveedor.id_producto <> 0 Then
                        nNota_Debito_Proveedor.RegistrarDetalle_Nota_Debito_Proveedor(objNota_Debito_Proveedor)
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
            If MessageBox.Show("¿Desea eliminar los datos de este Orden de Compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nNota_Debito_Proveedor.EleminarNota_Debito_Proveedor(lblCodigo.Text)
                nNota_Debito_Proveedor.EleminarDetalle_Nota_Debito_Proveedor(lblCodigo.Text)
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
            Tabla = nNota_Debito_Proveedor.Listar(objNota_Debito_Proveedor.id_nota_debito)
            For Each Fila As DataRow In Tabla.Rows
                objNota_Debito_Proveedor.id_compra = Fila.Item("id_compra")
                objNota_Debito_Proveedor.fecha_emision = Fila.Item("fecha_emision")
                objNota_Debito_Proveedor.total = Fila.Item("total")
                objNota_Debito_Proveedor.subtotal = Fila.Item("subtotal")
                objNota_Debito_Proveedor.igv = Fila.Item("igv")
                objNota_Debito_Proveedor.nro_nota_debito = Fila.Item("nro_nota_Debito")
                objNota_Debito_Proveedor.serie_nota_debito = Fila.Item("serie_nota_Debito")
                objNota_Debito_Proveedor.id_nota_debito = Fila.Item("id_nota_Debito")
                objNota_Debito_Proveedor.Motivo = Fila.Item("Motivo")
                objNota_Debito_Proveedor.Saldo_Pendiente = Fila.Item("saldo_pendiente")
            Next
            Me.lblCodigo.Text = objNota_Debito_Proveedor.id_nota_debito
            Me.txtserie_documento.Text = objNota_Debito_Proveedor.serie_nota_debito
            Me.txtnro_documento.Text = objNota_Debito_Proveedor.nro_nota_debito
            Me.TxtIdOrden.Text = objNota_Debito_Proveedor.id_compra
            Me.dtpfecha_emision.Value = objNota_Debito_Proveedor.fecha_emision
            Me.txtPrecio_neto.Text = objNota_Debito_Proveedor.subtotal
            Me.txtigv.Text = objNota_Debito_Proveedor.igv
            Me.TxtTotal.Text = objNota_Debito_Proveedor.total
            Me.cboMotivo.SelectedValue = objNota_Debito_Proveedor.Motivo
            Me.txtsaldo_pendiente.Text = objNota_Debito_Proveedor.Saldo_Pendiente
            Tabla = nOrden_Compra.Listar(objNota_Debito_Proveedor.id_compra)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Compra.id_Moneda = Fila.Item("id_moneda")
                objOrden_Compra.id_almacen = Fila.Item("id_almacen")
                objOrden_Compra.fecha_compra = Fila.Item("fecha_compra")
                objOrden_Compra.id_proveedor = Fila.Item("id_proveedor")
                objOrden_Compra.numero_documento = Fila.Item("numero_documento")
                objOrden_Compra.serie_documento = Fila.Item("serie_documento")
            Next
            Me.txt_documento.Text = "OC/ " & objOrden_Compra.numero_documento & " - " & objOrden_Compra.serie_documento
            LlenarMoneda()
            Me.cboMoneda.SelectedValue = objOrden_Compra.id_Moneda
            Me.cboAlmacen.SelectedValue = objOrden_Compra.id_almacen
            Tabla = nProveedor.Listar(objOrden_Compra.id_proveedor)
            For Each Fila As DataRow In Tabla.Rows
                objProveedor.razon_social = Fila.Item("razon_social")
            Next
            Me.txtproveedor.Text = objProveedor.razon_social
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
            If suma = objOrden_Compra.total Then
                Me.chkigv.Checked = True
            Else
                Me.chkigv.Checked = False
            End If
            btnModificar.Enabled = True
            btnImprimir.Enabled = True
            btnEliminarOrden.Enabled = True
            btnGrabar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarCompra()
        Try
            Dim Tabla As DataTable
            Dim Id_Producto As Integer
            Dim Producto As String
            Dim Cantidad As Integer
            Dim Unidad As String
            Dim costo As Double
            Dim Descuento As Double
            Dim Total As Double
            Tabla = nOrden_Compra.Listar(objOrden_Compra.id_compra)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Compra.numero_documento = Fila.Item("numero_documento")
                objOrden_Compra.serie_documento = Fila.Item("serie_documento")
                objOrden_Compra.fecha_compra = Fila.Item("fecha_compra")
                objOrden_Compra.id_proveedor = Fila.Item("id_proveedor")
                objOrden_Compra.id_compra = Fila.Item("id_compra")
                objOrden_Compra.total = Fila.Item("Total")
            Next
            Me.TxtIdOrden.Text = objOrden_Compra.id_compra
            Me.txt_documento.Text = "OV/ " & objOrden_Compra.numero_documento & " - " & objOrden_Compra.serie_documento
            Me.txtsaldo_pendiente.Text = objOrden_Compra.total
            Tabla = nProveedor.Listar(objOrden_Compra.id_proveedor)
            For Each Fila As DataRow In Tabla.Rows
                objProveedor.ruc = Fila.Item("ruc")
                objProveedor.razon_social = Fila.Item("razon_social")
            Next
            Me.txtproveedor.Text = objProveedor.razon_social
            LlenarMoneda()
            Me.cboMoneda.SelectedValue = objOrden_Compra.id_compra
            Me.txtPrecio_neto.Text = objOrden_Compra.subtotal
            Me.txtigv.Text = objOrden_Compra.igv
            Me.TxtTotal.Text = objOrden_Compra.total
            Tabla = nOrden_Compra.ListarDetalle(objOrden_Compra.id_compra)
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
            Next
            btnEliminar.Enabled = True
            Me.dtvListado_Productos.Enabled = True
            Sumar()
            Me.txtsaldo_pendiente.Enabled = True
            Me.txtsaldo_pendiente.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Habilitar(ByVal Estado As Boolean)
        Me.cboAlmacen.Enabled = Estado
        Me.dtpfecha_emision.Enabled = Estado
        Me.chkigv.Enabled = Estado
        Me.cboMotivo.Enabled = Estado
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
        Me.txtPrecio_neto.Text = Format(Neto, "##0.00")
        Me.txtigv.Text = Format(Igv, "##0.00")
        Me.TxtTotal.Text = Format(Total, "##0.00")
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        BuscarSerie()
        objOrden_Compra.tipo_cambio = 0.0
        Dim Tabla As DataTable
        Tabla = nTipo_Cambio.Listar()
        For Each Fila As DataRow In Tabla.Rows
            objOrden_Compra.tipo_cambio = Fila.Item("cambio_venta")
        Next
        Me.txttipo_cambio.Text = objOrden_Compra.tipo_cambio
        Me.txttipo_cambio.Enabled = False
        Me.lblCodigo.Visible = False
        Me.TxtIdOrden.Visible = False
        Me.txtProducto.Enabled = False
        Me.cboUnidad.Enabled = False
        Me.cboMoneda.Enabled = False
        Me.txtnro_documento.Enabled = False
        Me.txtCantidad.Enabled = False
        Me.txtPrecio_Unitario.Enabled = False
        Me.txtDescuento.Enabled = False
        Me.TxtidProducto.Visible = False
        txt_documento.Enabled = False
        Me.LblProcetaje.Visible = False
        Me.txtserie_documento.Enabled = False
        Me.txtserie_documento.Enabled = False
        Me.dtvListado_Productos.Enabled = False
        Me.txtsaldo_pendiente.Enabled = False
        Me.txtproveedor.Enabled = False
        Me.rbtKardex.Checked = True
        Me.btnAgregar.Enabled = False
        Me.lblCodigo.Text = ""
        Me.txtproveedor.Text = ""
        Me.cboMotivo.SelectedValue = "C"
        Me.cboAlmacen.SelectedValue = "1"
        Me.cboUnidad.SelectedValue = "0"
        Me.cboMoneda.SelectedValue = "0"
        Me.txtProducto.Text = ""
        Me.txt_documento.Text = ""
        Me.txtCantidad.Text = ""
        Me.txtPrecio_Unitario.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtPrecio_Unitario.Text = ""
        Me.txtsaldo_pendiente.Text = ""
        Me.txtPrecio_neto.Text = ""
        Me.txtigv.Text = ""
        Me.TxtTotal.Text = ""
        Me.dtpfecha_emision.Value = DateTime.Now()
        Me.dtvListado_Productos.Rows.Clear()
        Me.btnNuevo.Enabled = True
        Me.btnGrabar.Tag = "Grabar"
        Me.btnGrabar.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnImprimir.Enabled = False
        Me.btnEliminarOrden.Enabled = False
        Me.btnAgregar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.cboUnidad.Enabled = False
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
        Me.txtserie_documento.Focus()
    End Sub
    Sub LlenaCombos()
        Try
            Dim Almacen As DataTable = nAlmacen.Listar
            Me.cboAlmacen.ValueMember = "id_almacen"
            Me.cboAlmacen.DisplayMember = "descripcion"
            If Almacen.Rows.Count > 0 Then
                Me.cboAlmacen.DataSource = Almacen
            Else
                Dim SinAlmacen As New DataTable
                SinAlmacen.Columns.Add("id_almacen")
                SinAlmacen.Columns.Add("descripcion")
                SinAlmacen.Rows.Add("1", "No hay Almacen registradas")
                Me.cboAlmacen.DataSource = SinAlmacen
                Me.cboAlmacen.ValueMember = "id_almacen"
                Me.cboAlmacen.DisplayMember = "descripcion"
                Me.cboAlmacen.SelectedValue = "1"
                Me.btnGrabar.Enabled = False
            End If
            Dim Tipodocumento As DataTable = nTipodocumento.Listar
            Me.cbotipo_documento.ValueMember = "id_tipodocumento"
            Me.cbotipo_documento.DisplayMember = "descripcion"
            If Tipodocumento.Rows.Count > 0 Then
                Me.cbotipo_documento.DataSource = Tipodocumento
            Else
                Dim SinTipodocumento As New DataTable
                SinTipodocumento.Columns.Add("id_tipodocumento")
                SinTipodocumento.Columns.Add("descripcion")
                SinTipodocumento.Rows.Add("1", "No hay Documento registradas")
                Me.cbotipo_documento.DataSource = SinTipodocumento
                Me.cbotipo_documento.ValueMember = "id_tipodocumento"
                Me.cbotipo_documento.DisplayMember = "descripcion"
                Me.cbotipo_documento.SelectedValue = "1"
                Me.btnGrabar.Enabled = False
            End If
            Dim Motivo As New DataTable
            Motivo.Columns.Add("ID")
            Motivo.Columns.Add("VALOR")
            Motivo.Rows.Add("C", "Compra")
            Motivo.Rows.Add("V", "Venta")
            Motivo.Rows.Add("S", "servicio tecnico")
            Motivo.Rows.Add("D", "devolución")
            Motivo.Rows.Add("T", "Traslado")
            Me.cboMotivo.DataSource = Motivo
            Me.cboMotivo.ValueMember = "ID"
            Me.cboMotivo.DisplayMember = "VALOR"
            Me.cboMotivo.SelectedValue = "C"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub LlenarMoneda()
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
        id_Compra = nNota_Debito_Proveedor.buscarid
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
        Me.txtnro_documento.Text = Domnento
        Me.txtserie_documento.Text = serie
    End Sub
    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Function Valida() As Boolean
        Dim TextoError As String = ""
        If Me.txtserie_documento.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Numero de Documento." & vbCrLf
        End If
        If Me.txtserie_documento.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Serie de Documento." & vbCrLf
        End If
        If Me.txt_documento.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar una order de Compra." & vbCrLf
        End If
        If Me.cboAlmacen.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar un Almacen." & vbCrLf
        End If
        If Me.cboMoneda.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una Monoda." & vbCrLf
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
End Class