Imports Entidades
Imports Reglas_Negocio
Imports Microsoft.Office.Interop
Public Class frmIngreso_Kardex
    Dim nDetalle_Caja As New RNDetalle_Caja
    Dim nTipodocumento As New RNTipoDocumento
    Dim nUnidad As New RNUnidad
    Dim nCuenta As New RNCuenta
    Dim nFacturacion As New RNFacturacion
    Dim nProducto_Almacen As New RNProducto_Almacen
    Dim nProveedor As New RNProveedor
    Dim nOrden_Compra As New RNOrden_Compra
    Dim nKardex As New RNKardex
    Dim objKardex As New Kardex
    Dim objOrden_Compra As New Orden_Compra
    Dim objProveedor As New Proveedor
    Dim objProducto_Almacen As New Producto_Almacen
    Dim objFacturacion As New Facturacion
    Dim objCuenta As New Cuenta
    Dim objProducto As New Producto
    Dim Todos As Boolean = True
    Dim Tabla As DataTable
    Dim Tabla1 As DataTable
    Dim J As Integer = 0
    Private Sub frmIngreso_Kardex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
    Private Sub chkigv_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkigv.CheckedChanged
        Sumar()
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
    Private Sub btnBuscarOrden_Venta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarOrden_Venta.Click
        frmListar_Orden_Compra.accion = 1
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
            Grabar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            ' intentar generar el documento
            ' se adjunta un texto debajo del encabezado con la fecha actual del sistema
            ExportarDatosExcel(dtvListado_Productos, "Fecha:" + Now.Date())
        Catch ex As Exception
            'si el intento es fallido mostrar msgbox
            MessageBox.Show("No se puede Generar el Documento en Excel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub ExportarDatosExcel(ByVal DataGridView1 As DataGridView, ByVal titulo As String)

        Dim m_Excel As New Excel.Application
        m_Excel.Cursor = Excel.XlMousePointer.xlWait
        m_Excel.Visible = True
        Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        With objHojaExcel
            .Visible = Excel.XlSheetVisibility.xlSheetVisible
            .Activate()
            'Encabezado
            .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Range("A1:L1").Merge()
            .Range("A1:L1").Value = "Actualizar Precios"
            .Range("A1:L1").Font.Bold = True
            .Range("A1:L1").Font.Size = 16
            'Texto despues del encabezado
            .Range("A2:L2").Merge()
            .Range("A2:L2").Value = titulo
            .Range("A2:L2").Font.Bold = True
            .Range("A2:L2").Font.Size = 10
            'Espacio
            .Range("A3:L3").Merge()
            .Range("A3:L3").Value = ""
            .Range("A3:L3").Font.Bold = True
            .Range("A3:L3").Font.Size = 10
            'Estilos a titulos de la Tabla
            .Range("A4:P4").Font.Bold = True
            'Establecer tipo de Letra al Rango Determinado
            .Range("A1:P100").Font.Name = "Tahoma"
            'Los datos se registran a partir de la Columna A, Fila 4
            Const PrimeraLetra As Char = "A"
            Const PrimerNumero As Short = 4
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
            For Each reg As DataGridViewRow In DataGridView1.Rows
                LetraIzq = ""
                cod_LetraIzq = Asc(PrimeraLetra) - 1
                letra = PrimeraLetra
                cod_letra = Asc(PrimeraLetra) - 1
                For Each c As DataGridViewColumn In DataGridView1.Columns
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
            For Each c As DataGridViewColumn In DataGridView1.Columns
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
            objRango.Columns.AutoFit()
            objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        End With
        m_Excel.Cursor = Excel.XlMousePointer.xlDefault
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
            Dim financiado As Double
            financiado = Me.TxtTotal.Text - Me.txtinicial.Text
            Me.txtmonto_financiado.Text = financiado
            Me.txtnro_cuotas.Enabled = True
            Me.txtnro_cuotas.Focus()
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
                objFacturacion.id_caja = Me.cboCaja.SelectedValue
                objFacturacion.Id_Operacion = Me.TxtIdOrden.Text.ToString
                objFacturacion.id_almacen = Me.TxtIdAlmance.Text.ToString
                objFacturacion.id_tipodocumento = "001"
                objFacturacion.numero_documento = Me.Txtnumero_documento.Text.Trim
                objFacturacion.serie_documento = Me.txtserie_documento.Text.Trim
                objFacturacion.Tipo_movimiento = "S"
                objFacturacion.monto = Me.txtinicial.Text.Trim
                objFacturacion.fecha_movimiento = Me.dtpfecha_llegada.Value
                objKardex.fecha = Me.dtpfecha_llegada.Value
                objKardex.total = Me.txttotal.Text.Trim
                objKardex.subtotal = Me.txtPrecio_neto.Text.Trim
                objKardex.igv = Me.txtigv.Text.Trim
                objKardex.numero_documento = Me.Txtnumero_documento.Text.ToString
                objKardex.serie_documento = Me.txtserie_documento.Text.ToString
                objKardex.id_Compra = Me.TxtIdOrden.Text.Trim
                objKardex.Tipo_Pago = Me.cboTipoPago.SelectedValue
                objKardex.id_tipodocumento = Me.cbotipo_comprobante.SelectedValue
                objKardex.pago_inicial = Me.txtinicial.Text
                objKardex.id_almacen = Me.TxtIdAlmance.Text
                objOrden_Compra.id_compra = Me.TxtIdOrden.Text.Trim
                Dim Id_Producto As Integer
                Dim Cantidad As Double
                If Me.txtmonto_financiado.Text.Trim <> "" Then
                    objKardex.monto_financiado = Me.txtmonto_financiado.Text.Trim
                Else
                    objKardex.monto_financiado = 0.0
                End If
                If Me.txtnro_cuotas.Text.Trim <> "" Then
                    objKardex.nro_cuotas = Me.txtnro_cuotas.Text.Trim
                Else
                    objKardex.nro_cuotas = 0
                End If
                If Me.txtMonto_cuota.Text.Trim <> "" Then
                    objKardex.Monto_cuota = Me.txtMonto_cuota.Text.Trim
                Else
                    objKardex.Monto_cuota = 0.0
                End If
                objKardex.ruc_dni = Me.txtdocumento.Text
                objKardex.Nombre = Me.txtProveedor.Text
                objKardex.tipo = "C"
                If MessageBox.Show("¿Desea registrar los datos de este Kardex?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objFacturacion = nFacturacion.RegistrarFacturacion(objFacturacion)
                    objKardex.id_movimiento = objFacturacion.id_movimiento
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
                                objProducto_Almacen.id_almacen = Me.TxtIdAlmance.Text
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
                                Tabla = nOrden_Compra.ListarDetalle(objOrden_Compra.id_compra)
                                For Each Fila As DataRow In Tabla.Rows
                                    Id_Producto = Fila.Item("id_producto")
                                    Cantidad = Fila.Item("cantidad")
                                    If Id_Producto = objProducto_Almacen.id_producto And Cantidad <> objKardex.cantidad Then
                                        Todos = False
                                    End If
                                Next
                            End If
                            J = J + 1
                        Next
                        If Todos Then
                            objOrden_Compra.Estado = "2"
                            nOrden_Compra.AtenderCompra(objOrden_Compra)
                        Else
                            Tabla = nOrden_Compra.Listar(objOrden_Compra.id_compra)
                            For Each Fila As DataRow In Tabla.Rows
                                Dim total As Double = 0.0
                                Dim id_productos(J) As Integer
                                Dim cantidads(J) As Integer
                                Dim precios(J) As Double
                                Dim Descuentros(J) As Double
                                Dim Sub_Totas(J) As Double
                                objOrden_Compra.fecha_compra = Fila.Item("fecha_compra")
                                objOrden_Compra.id_compra = Fila.Item("id_compra")
                                objOrden_Compra.numero_documento = Fila.Item("numero_documento")
                                objOrden_Compra.serie_documento = Fila.Item("serie_documento")
                                objOrden_Compra.id_proveedor = Fila.Item("id_proveedor")
                                objOrden_Compra.Tipo_Pago = Fila.Item("tipo_pago")
                                objOrden_Compra.id_Moneda = Fila.Item("id_moneda")
                                objOrden_Compra.id_almacen = Fila.Item("id_almacen")
                                Tabla1 = nOrden_Compra.ListarDetalle(objOrden_Compra.id_compra)
                                For Each Fila1 As DataRow In Tabla1.Rows
                                    For i As Integer = 0 To Dgv.RowCount - 1
                                        If CInt(Dgv.Item(0, i).Value) = Fila1.Item("id_producto") Then
                                            id_productos(i) = Fila1.Item("id_producto")
                                            cantidads(i) = Fila1.Item("cantidad") - CInt(Dgv.Item(2, i).Value)
                                            precios(i) = Fila1.Item("precio_compra")
                                            Descuentros(i) = CDbl(Dgv.Item(5, i).Value)
                                            Sub_Totas(i) = cantidads(i) * precios(i) - Descuentros(i)
                                            total = total + Sub_Totas(i)
                                        End If
                                    Next
                                Next
                                If Me.chkigv.Checked Then
                                    objOrden_Compra.total = total
                                    objOrden_Compra.subtotal = total * 100 / 118
                                    objOrden_Compra.igv = total * 18 / 118
                                Else
                                    objOrden_Compra.total = total * 82 / 100
                                    objOrden_Compra.subtotal = total
                                    objOrden_Compra.igv = total * 18 / 100
                                End If
                                nOrden_Compra.ModificarCompra(objOrden_Compra)
                                nOrden_Compra.EleminarProducto_Almacen(objOrden_Compra.id_compra)
                                For i As Integer = 0 To Dgv.RowCount - 1
                                    If CInt(Dgv.Item(0, i).Value) <> 0 And cantidads(i) <> 0 Then
                                        objOrden_Compra.id_producto = id_productos(i)
                                        objOrden_Compra.cantidad = cantidads(i)
                                        objOrden_Compra.precio_compra = precios(i)
                                        objOrden_Compra.descuento = Descuentros(i)
                                        objOrden_Compra.Sub_Total = Sub_Totas(i)
                                        nOrden_Compra.RegistrarCompra_Producto(objOrden_Compra)
                                    End If
                                Next
                            Next
                            If cboTipoPago.SelectedValue = "C" Then
                                objCuenta.id_compra = Me.TxtIdOrden.Text
                                objCuenta.pago_inicial = Me.txtinicial.Text
                                objCuenta.monto_financiado = Me.txtmonto_financiado.Text
                                objCuenta.nro_cuotas = Me.txtnro_cuotas.Text
                                objCuenta.deudad = Me.txtmonto_financiado.Text
                                objCuenta = nCuenta.RegistrarCuenta(objCuenta)
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                    Dim TextoError As String
                    TextoError = "Serie: K/ " & Me.Txtnumero_documento.Text & " - " & Me.txtserie_documento.Text
                    MessageBox.Show("Los datos se guardaron satisfactoriamente" & vbCrLf & TextoError, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objKardex.id_Kardex
                    Me.btnGrabar.Enabled = False
                    Me.btnNuevo.Enabled = True
                    Me.btnExportar.Enabled = True
                    Habilitar(False)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarCompra()
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
            Tabla = nOrden_Compra.Listar(objOrden_Compra.id_compra)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Compra.numero_documento = Fila.Item("numero_documento")
                objOrden_Compra.serie_documento = Fila.Item("serie_documento")
                objOrden_Compra.fecha_compra = Fila.Item("fecha_compra")
                objOrden_Compra.Tipo_Pago = Fila.Item("tipo_pago")
                objOrden_Compra.id_proveedor = Fila.Item("id_proveedor")
                objOrden_Compra.id_almacen = Fila.Item("id_almacen")
            Next
            Me.TxtIdOrden.Text = objOrden_Compra.id_compra
            Me.TxtIdAlmance.Text = objOrden_Compra.id_almacen
            Me.txtOrden_Venta.Text = "OV/ " & objOrden_Compra.numero_documento & " - " & objOrden_Compra.serie_documento
            Me.dtpfecha_emision.Value = objOrden_Compra.fecha_compra
            Tabla = nProveedor.Listar(objOrden_Compra.id_proveedor)
            LlenaCombos(objOrden_Compra.id_almacen)
            Me.cboCaja.SelectedValue = 1
            For Each Fila As DataRow In Tabla.Rows
                objProveedor.ruc = Fila.Item("ruc")
                objProveedor.razon_social = Fila.Item("razon_social")
            Next
            Me.txtdocumento.Text = objProveedor.ruc
            Me.txtProveedor.Text = objProveedor.razon_social
            LlenarCombos()
            Me.cboTipoPago.Enabled = True
            Me.cboTipoPago.SelectedValue = objOrden_Compra.Tipo_Pago
            Me.txtPrecio_neto.Text = objOrden_Compra.subtotal
            Me.txtigv.Text = objOrden_Compra.igv
            Me.txttotal.Text = objOrden_Compra.total
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
            btnEliminar.Enabled = True
            Me.dtvListado_Productos.Enabled = True
            If objOrden_Compra.Tipo_Pago = "C" Then
                Me.txtinicial.Enabled = True
                Me.txtinicial.Focus()
            Else
                Me.txtinicial.Text = objOrden_Compra.total
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    
    Sub Habilitar(ByVal Estado As Boolean)
        Me.dtpfecha_llegada.Enabled = Estado
        Me.cbotipo_comprobante.Enabled = Estado
        Me.txtserie_documento.Enabled = Estado
        Me.Txtnumero_documento.Enabled = Estado
        Me.chkigv.Enabled = Estado
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
        Me.txttotal.Text = Format(Total, "##0.00")
        If Me.cboTipoPago.SelectedValue = "E" Then
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
        Me.lblCodigo.Visible = False
        Me.TxtIdOrden.Visible = False
        Me.TxtIdAlmance.Visible = False
        Me.cboTipoPago.Enabled = False
        Me.dtpfecha_emision.Enabled = False
        Me.dtvListado_Productos.Enabled = False
        Me.btnAgregar.Enabled = False
        Me.dtvListado_Productos.Enabled = False
        Me.txtProducto.Enabled = False
        Me.cboUnidad.Enabled = False
        Me.txtCantidad.Enabled = False
        Me.txtPrecio_Unitario.Enabled = False
        Me.txtDescuento.Enabled = False
        Me.TxtidProducto.Visible = False
        Me.LblProcetaje.Visible = False
        Me.txtOrden_Venta.Enabled = False
        Me.txtdocumento.Enabled = False
        Me.txtProveedor.Enabled = False
        Me.txtinicial.Enabled = False
        Me.txtmonto_financiado.Enabled = False
        Me.txtnro_cuotas.Enabled = False
        Me.txtMonto_cuota.Enabled = False
        Me.cboCaja.Enabled = False
        Me.lblCodigo.Text = ""
        Me.chkigv.Checked = True
        Me.cbotipo_comprobante.SelectedValue = "1"
        Me.cboTipoPago.SelectedValue = "0"
        Me.cboUnidad.SelectedValue = "0"
        Me.txtserie_documento.Text = ""
        Me.Txtnumero_documento.Text = ""
        Me.txtProducto.Text = ""
        Me.txtCantidad.Text = ""
        Me.txtPrecio_Unitario.Text = ""
        Me.txtDescuento.Text = ""
        Me.txtPrecio_Unitario.Text = ""
        Me.txtPrecio_bruto.Text = ""
        Me.txtMonto_descuento.Text = ""
        Me.txtPrecio_neto.Text = ""
        Me.txtigv.Text = ""
        Me.txttotal.Text = ""
        Me.txtOrden_Venta.Text = ""
        Me.txtdocumento.Text = ""
        Me.txtProveedor.Text = ""
        Me.txtinicial.Text = ""
        Me.txtmonto_financiado.Text = ""
        Me.txtnro_cuotas.Text = ""
        Me.txtMonto_cuota.Text = ""
        Me.dtpfecha_emision.Value = DateTime.Now()
        Me.dtpfecha_llegada.Value = DateTime.Now()
        Me.dtvListado_Productos.Rows.Clear()
        Me.btnNuevo.Enabled = True
        Me.btnGrabar.Tag = "Grabar"
        Me.btnGrabar.Enabled = True
        Me.btnExportar.Enabled = False
        Me.btnAgregar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.txtPrecio_bruto.Enabled = False
        Me.cboUnidad.Enabled = False
        Me.txtMonto_descuento.Enabled = False
        Me.txtPrecio_neto.Enabled = False
        Me.txtigv.Enabled = False
        Me.txttotal.Enabled = False

        ' LÓGICA PERMISOS -------------------------------------------------
        Dim Permiso As Personal_SubMenu = CType(Me.Tag, Personal_SubMenu)
        Me.btnGrabar.Visible = Permiso.nuevo

        Me.btnEliminar.Visible = Permiso.eliminar

        ' -----------------------------------------------------------------

        Me.Txtnumero_documento.Focus()
    End Sub
    Sub LlenaCombos()
        Try
            Dim Tipodocumento As DataTable = nTipodocumento.Listar
            Me.cbotipo_comprobante.ValueMember = "id_tipodocumento"
            Me.cbotipo_comprobante.DisplayMember = "descripcion"
            If Tipodocumento.Rows.Count > 0 Then
                Me.cbotipo_comprobante.DataSource = Tipodocumento
            Else
                Dim SinTipodocumento As New DataTable
                SinTipodocumento.Columns.Add("id_tipodocumento")
                SinTipodocumento.Columns.Add("descripcion")
                SinTipodocumento.Rows.Add("1", "No hay Documento registradas")
                Me.cbotipo_comprobante.DataSource = SinTipodocumento
                Me.cbotipo_comprobante.ValueMember = "id_tipodocumento"
                Me.cbotipo_comprobante.DisplayMember = "descripcion"
                Me.cbotipo_comprobante.SelectedValue = "1"
                Me.btnGrabar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
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
    Sub LlenarCombos()
        Dim TipoPago As New DataTable
        TipoPago.Columns.Add("ID")
        TipoPago.Columns.Add("VALOR")
        TipoPago.Rows.Add("0", "Elija una opción")
        TipoPago.Rows.Add("E", "EFECTIVO")
        TipoPago.Rows.Add("C", "CREDITO")
        Me.cboTipoPago.DataSource = TipoPago
        Me.cboTipoPago.ValueMember = "ID"
        Me.cboTipoPago.DisplayMember = "VALOR"
        Me.cboTipoPago.SelectedValue = "0"
    End Sub
    Sub LlenaUnidad(ByVal Id_Unidad As Integer)
        Dim Unidad As DataTable = nUnidad.Listar(Id_Unidad)
        Me.cboUnidad.ValueMember = "abreviatura"
        Me.cboUnidad.DisplayMember = "descripcion"
        Me.cboUnidad.DataSource = Unidad
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
        If Me.Txtnumero_documento.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Numero de Documento." & vbCrLf
        End If
        If Me.cbotipo_comprobante.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una tipo de comprobante." & vbCrLf
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
    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtnumero_documento.KeyPress, txtserie_documento.KeyPress
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