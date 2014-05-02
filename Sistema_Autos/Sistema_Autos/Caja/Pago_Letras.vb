Imports Entidades
Imports Reglas_Negocio
Public Class frmPago_Letras
    Dim nDetalle_Caja As New RNDetalle_Caja
    Dim nTipo_Cambio As New RNTipo_cambio
    Dim nTipoDocumento As New RNTipoDocumento
    'Dim nSucursal As New RNSucursal
    Dim nMoneda As New RNMoneda
    'Dim nUnidad As New RNUnidad
    'Dim nProducto_Almacen As New RNProducto_Almacen
    'Dim nAlmacen As New RNAlmacen
    'Dim nClientes As New RNCliente
    Dim nOrden_Venta As New RNOrden_Venta
    Dim nCodigo_Facturacion As New RNCodigo_Facturacion
    Dim nFacturacion As New RNFacturacion
    Dim nPersonal As New RNPersonal
    Dim nLetras As New RNLetras
    Dim objLetras As New Letras
    Dim objPersonal As New Personal
    Dim objFacturacion As New Facturacion
    Dim objCodigo_Facturacion As New Codigo_Facturacion
    Dim objOrden_Venta As New Orden_Venta
    Dim objClientes As New Cliente
    'Dim objAlmacen As New Almacen
    'Dim objProducto_Almacen As New Producto_Almacen
    'Dim objProducto As New Producto
    Dim Tabla As DataTable
    Private Sub frmPago_Letras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            LlenaCombos()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnbuscar_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar_cliente.Click
        If frmListarClientes.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objClientes = frmListarClientes.objCliente
            CargarLetras()
        End If
    End Sub
    Private Sub dgvCliente_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCliente.CellContentDoubleClick
        If Me.TxtMonto.Text = "" Then
            MessageBox.Show("Escribe Por Favor el monto de mora X Cada dia Atrasado")
            Me.TxtMonto.Focus()
        Else
            Dim DGV As DataGridView
            Dim id_detalle As Integer
            Dim letra As String
            Dim id_letra As Integer
            Dim id_almacen As Integer
            Dim id_moneda As Integer
            Dim Moneda As String
            Dim num_letra As Integer
            Dim fecha_vencimiento As Date
            Dim monto As Double
            Dim dias As Integer
            Dim interes As Double
            Dim Iotal As Double
            Dim Pago As Double
            DGV = Me.dgvCliente
            id_letra = DGV.Item(0, e.RowIndex).Value
            id_almacen = DGV.Item(4, e.RowIndex).Value
            id_moneda = DGV.Item(5, e.RowIndex).Value
            Moneda = DGV.Item(7, e.RowIndex).Value
            objFacturacion.id_tipodocumento = DGV.Item(10, e.RowIndex).Value
            objOrden_Venta.id_venta = DGV.Item(11, e.RowIndex).Value
            Tabla = nLetras.CargarDetalle(id_letra)
            Me.dgvPago_cuotas.Rows.Clear()
            For Each Fila As DataRow In Tabla.Rows
                id_detalle = Fila.Item("id_detalle_letras")
                letra = BuscarSerie(id_detalle)
                num_letra = Fila.Item("num_letra")
                fecha_vencimiento = Fila.Item("fecha_vencimiento")
                monto = Fila.Item("monto")
                If Fila.Item("total") Is DBNull.Value Then
                    Pago = 0.0
                Else
                    Pago = Fila.Item("total")
                End If
                If Fila.Item("fecha") Is DBNull.Value Then
                    dias = DateDiff(DateInterval.Day, fecha_vencimiento, DateTimePicker1.Value)
                Else
                    dias = DateDiff(DateInterval.Day, fecha_vencimiento, Fila.Item("fecha"))
                End If
                If dias < 0 Then
                    dias = 0
                End If
                interes = dias * Me.TxtMonto.Text
                Iotal = monto + interes
                Me.dgvPago_cuotas.Rows.Add(letra, num_letra, Format(monto, "##0.00"), fecha_vencimiento, Moneda, Format(interes, "##0.00"), dias, Format(Iotal, "##0.00"), Format(Pago, "##0.00"), id_letra, id_detalle)
            Next
            Dim chk As New DataGridViewCheckBoxColumn()
            Me.dgvPago_cuotas.Columns.Add(chk)
            chk.HeaderText = "Saldo Cancelar"
            chk.Name = "chk"
            Me.cboMoneda.SelectedValue = id_moneda
            Me.cboMoneda.Enabled = False
            LlenaCombos(id_almacen)
            Me.cboCaja.SelectedValue = 1
            objLetras.id_almacen = id_almacen
        End If
    End Sub
    Private Sub dgvPago_cuotas_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvPago_cuotas.CellMouseClick
        If e.ColumnIndex = 11 Then
            If Me.dgvPago_cuotas(11, e.RowIndex).Value() = False Then
                Dim sinpago As Double
                sinpago = Me.dgvPago_cuotas(8, e.RowIndex).Value()
                If sinpago = 0.0 Then
                    Me.dgvPago_cuotas(11, e.RowIndex).Value = True
                End If
            Else
                Me.dgvPago_cuotas(11, e.RowIndex).Value = False
            End If
        End If
        CargarPago()
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
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
       
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If frmDocumentos_canjeados.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objLetras = frmDocumentos_canjeados.ObjLetras
            Cargar()
        End If
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
                If MessageBox.Show("¿Desea registrar los datos de este Letra de Cambión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Dim Cantidad As Integer
                    objFacturacion.id_caja = Me.cboCaja.SelectedValue
                    objFacturacion.id_almacen = objLetras.id_almacen
                    objFacturacion.Tipo_movimiento = "E"
                    objFacturacion.monto = Me.TextBox1.Text
                    objFacturacion.fecha_movimiento = Me.DateTimePicker1.Value
                    objLetras.id_personal = id_Vededor
                    objLetras.id_caja = Me.cboCaja.SelectedValue
                    objLetras.fecha = Me.DateTimePicker1.Value
                    objLetras.tipo_cambio = Me.txttipo_cambio.Text
                    objLetras.observaciones = Me.TextBox2.Text
                    objLetras.tipo_pago = Me.cboFormaPago.SelectedValue
                    Dim Dgv As DataGridView
                    Dgv = Me.dgvPago_cuotas
                    Try
                        For i As Integer = 0 To Dgv.RowCount - 1
                            If CBool(Dgv.Item(11, i).Value) Then
                                objFacturacion.numero_documento = Microsoft.VisualBasic.Left(CStr(Dgv.Item(0, i).Value), 3)
                                objFacturacion.serie_documento = Microsoft.VisualBasic.Right(CStr(Dgv.Item(0, i).Value), 7)
                                objLetras.total = CDbl(Dgv.Item(7, i).Value)
                                objLetras.num_letra = CInt(Dgv.Item(1, i).Value)
                                objLetras.id_letras = CInt(Dgv.Item(9, i).Value)
                                objLetras.id_Detalle = CInt(Dgv.Item(10, i).Value)
                                objLetras = nLetras.RegistrarPagosLetras(objLetras)
                                objFacturacion.Id_Operacion = objLetras.id_pagos_letras
                                objFacturacion = nFacturacion.RegistrarFacturacion(objFacturacion)
                                nLetras.EleminarDetalleXID(objLetras.id_Detalle)
                            End If
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                    Cantidad = nLetras.ContraLetra(objLetras.id_letras)
                    If Cantidad = 0 Then
                        nLetras.Eleminar(objLetras.id_letras)
                        Tabla = nOrden_Venta.Listar(objOrden_Venta.id_venta)
                        For Each Fila As DataRow In Tabla.Rows
                            objOrden_Venta.id_almacen = Fila.Item("id_almacen")
                            objOrden_Venta.id_personal = Fila.Item("id_personal")
                            objOrden_Venta.id_cliente = Fila.Item("id_cliente")
                            objOrden_Venta.fecha_emision = Fila.Item("fecha_emision")
                            objOrden_Venta.id_tipodocumento = Fila.Item("id_tipodocumento")
                            objOrden_Venta.total = Fila.Item("total")
                            objOrden_Venta.subtotal = Fila.Item("subtotal")
                            objOrden_Venta.igv = Fila.Item("igv")
                            objOrden_Venta.id_Moneda = Fila.Item("id_Moneda")
                            objOrden_Venta.numero_documento = Fila.Item("numero_documento")
                            objOrden_Venta.serie_documento = Fila.Item("serie_documento")
                            objOrden_Venta.Tipo_Pago = Fila.Item("Tipo_Pago")
                            objOrden_Venta.pago_inicial = Fila.Item("pago_inicial")
                            objOrden_Venta.monto_financiado = Fila.Item("monto_financiado")
                            objOrden_Venta.nro_cuotas = Fila.Item("nro_cuotas")
                            objOrden_Venta.Monto_cuota = Fila.Item("monto_cuota")
                        Next
                        objOrden_Venta.Tipo_Pago = "P"
                        nOrden_Venta.ModificarVenta(objOrden_Venta)
                    End If
                    MessageBox.Show("Los datos se guardaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.btnGrabar.Enabled = False
                    Me.btnNuevo.Enabled = True
                    Habilitar(False)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Cargar()
        Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarLetras()
        Dim id_venta As Integer
        Dim id_letra As Integer
        Dim TipoDocumento As String
        Dim fecha_emision As Date
        Dim saldo As Double
        Dim monto_financiado As Double
        Dim id_almacen As Integer
        Dim id_moneda As Integer
        Dim Moneda As String
        Dim coprobrante As String
        Dim nro_cuotas As Integer
        Dim id_tipo As String
        Dim numero_documento As String
        Dim serie_documento As String
        Dim Order As String
        Me.txtcliente.Text = objClientes.razon_social
        Me.dgvCliente.Enabled = True
        Tabla = nLetras.CargarLetras(objClientes.id_cliente)
        For Each Fila As DataRow In Tabla.Rows
            id_venta = Fila.Item("id_venta")
            id_letra = Fila.Item("id_letras")
            TipoDocumento = Fila.Item("TipoDocumento")
            fecha_emision = Fila.Item("fecha_emision")
            saldo = Fila.Item("saldo")
            coprobrante = Fila.Item("coprobrante")
            monto_financiado = Fila.Item("monto_financiado")
            id_almacen = Fila.Item("id_almacen")
            id_moneda = Fila.Item("id_moneda")
            Moneda = Fila.Item("Moneda")
            nro_cuotas = Fila.Item("nro_cuotas")
            id_tipo = Fila.Item("id_tipodocumento")
            numero_documento = Fila.Item("numero_documento")
            serie_documento = Fila.Item("serie_documento")
            Order = "OC/ " & numero_documento & " " & serie_documento
            Me.dgvCliente.Rows.Add(id_letra, coprobrante, fecha_emision, Format(saldo, "##0.00"), id_almacen, id_moneda, Format(monto_financiado, "##0.00"), Moneda, nro_cuotas, Order, id_tipo, id_venta)
        Next
        'Tabla = nCodigo_Facturacion.Listar(id_almacen)
        'For Each Fila As DataRow In Tabla.Rows
        '    objCodigo_Facturacion.id_Codigo = Fila.Item("id_Codigo")
        'Next
        'BuscarSerie(objCodigo_Facturacion.id_Codigo, Me.cboTipo_Documento.SelectedValue)
    End Sub
    Sub Habilitar(ByVal Estado As Boolean)
        Me.TxtMonto.Enabled = Estado
        Me.cboCaja.Enabled = Estado
        Me.DateTimePicker1.Enabled = Estado
        Me.TextBox2.Enabled = Estado
        Me.btnbuscar_cliente.Enabled = Estado
        Me.cboFormaPago.Enabled = Estado
        Me.cboMoneda.Enabled = Estado
    End Sub
    Sub CargarPago()
        Dim Dgv As DataGridView
        Dgv = Me.dgvPago_cuotas
        Dim total As Double
        total = 0.0
        Try
            For i As Integer = 0 To Dgv.RowCount - 1
                If CBool(Dgv.Item(10, i).Value) Then
                    total = total + CDbl(Dgv.Item(7, i).Value)
                End If
            Next
            If total = 0.0 Then
                Me.TextBox1.Text = ""
                btnGrabar.Enabled = False
            Else
                Me.TextBox1.Text = Format(total, "##0.00")
                btnGrabar.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        Me.txtcliente.Enabled = False
        Me.txttipo_cambio.Enabled = False
        Me.dgvCliente.Enabled = False
        Me.TextBox1.Enabled = False
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.txtcliente.Text = ""
        Me.TxtMonto.Text = ""
        Me.cboMoneda.SelectedValue = "1"
        Me.cboCaja.SelectedValue = "1"
        Me.cboFormaPago.SelectedValue = "0"
        Me.DateTimePicker1.Value = DateTime.Now()
        Me.dgvCliente.Rows.Clear()
        Me.dgvPago_cuotas.Rows.Clear()
        Tabla = nTipo_Cambio.Listar()
        For Each Fila As DataRow In Tabla.Rows
            Me.txttipo_cambio.Text = Format(Fila.Item("cambio_empresa"), "##0.00")
        Next
        Tabla = nPersonal.Listar(id_Vededor)
        For Each Fila As DataRow In Tabla.Rows
            objPersonal.nombres = Fila.Item("nombres")
            objPersonal.ap_paterno = Fila.Item("ap_paterno")
            objPersonal.ap_materno = Fila.Item("ap_materno")
        Next
        Me.lblvendedor.Text = objPersonal.nombres & " " & objPersonal.ap_paterno & " " & objPersonal.ap_materno
        Me.btnNuevo.Enabled = True
        Me.btnGrabar.Enabled = False
        Me.TxtMonto.Focus()
    End Sub
    Sub LlenaCombos()
        Try
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
            TipoPago.Rows.Add("T", "TARJETA")
            Me.cboFormaPago.DataSource = TipoPago
            Me.cboFormaPago.ValueMember = "ID"
            Me.cboFormaPago.DisplayMember = "VALOR"
            Me.cboFormaPago.SelectedValue = "0"
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
        'Me.txtserie_documento.Text = NumDomento
    End Sub
    Function BuscarSerie(ByVal NumSerie As Integer) As String
        Dim NumDomento As String
        If NumSerie < 10 Then
            NumDomento = "L/0000000" & NumSerie.ToString
        ElseIf NumSerie < 100 Then
            NumDomento = "L/000000" & NumSerie.ToString
        ElseIf NumSerie < 1000 Then
            NumDomento = "L/00000" & NumSerie.ToString
        ElseIf NumSerie < 10000 Then
            NumDomento = "L/0000" & NumSerie.ToString
        ElseIf NumSerie < 100000 Then
            NumDomento = "L/000" & NumSerie.ToString
        ElseIf NumSerie < 1000000 Then
            NumDomento = "L/00" & NumSerie.ToString
        ElseIf NumSerie < 10000000 Then
            NumDomento = "L/0" & NumSerie.ToString
        Else
            NumDomento = "L/" & NumSerie.ToString
        End If
        Return NumDomento
    End Function
    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Function Valida() As Boolean
        Dim TextoError As String = ""
        If Me.txtCliente.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Clientes." & vbCrLf
        End If
        If Me.TextBox2.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar una Observaciones:." & vbCrLf
        End If
        If Me.txttipo_cambio.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Tipo cambion Ir a Menu Admintrador Sub Meni Tipo de Cambión:." & vbCrLf
        End If
        If Me.cboMoneda.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una Monoda." & vbCrLf
        End If
        If Me.cboFormaPago.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una Froma de Pago." & vbCrLf
        End If
        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
End Class