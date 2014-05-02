Imports Entidades
Imports Reglas_Negocio
Public Class frmCanje_Letras
    'Dim nTipo_Cambio As New RNTipo_cambio
    'Dim nTipoDocumento As New RNTipoDocumento
    'Dim nSucursal As New RNSucursal
    Dim nMoneda As New RNMoneda
    'Dim nUnidad As New RNUnidad
    'Dim nProducto_Almacen As New RNProducto_Almacen
    'Dim nAlmacen As New RNAlmacen
    Dim nPersonal As New RNPersonal
    Dim nClientes As New RNCliente
    Dim nOrden_Venta As New RNOrden_Venta
    Dim nLetras As New RNLetras
    Dim objLetras As New Letras
    Dim objOrden_Venta As New Orden_Venta
    Dim objClientes As New Cliente
    'Dim objPersonal As New Personal
    'Dim objAlmacen As New Almacen
    'Dim objProducto_Almacen As New Producto_Almacen
    'Dim objProducto As New Producto
    Dim Tabla As DataTable
    Private Sub frmCanje_Letras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            CargarClientes()
        End If
    End Sub
    Private Sub btnDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDerecha.Click
        Dim fila As Integer
        Dim Documento As String
        Dim fecha_emision As Date
        Dim monto_financiado As Double
        Dim id_moneda As Integer
        Dim Moneda As String
        Dim id_venta As Integer
        fila = dtvCuentasxcobrar.SelectedRows.Count()
        If fila > 0 Then
            For Each Seleccion As DataGridViewRow In dtvCuentasxcobrar.SelectedRows
                Documento = Seleccion.Cells(0).Value
                fecha_emision = Seleccion.Cells(1).Value
                monto_financiado = Seleccion.Cells(2).Value
                id_moneda = Seleccion.Cells(3).Value
                Moneda = Seleccion.Cells(4).Value
                id_venta = Seleccion.Cells(5).Value
                Me.dgvDoc_canjeados.Rows.Add(Documento, fecha_emision, Moneda, Format(monto_financiado, "##0.00"), id_venta)
                dtvCuentasxcobrar.Rows.Remove(Seleccion)
                dtvCuentasxcobrar.Refresh()
            Next
            Me.cboMoneda.SelectedValue = id_moneda
            Me.cboMoneda.Enabled = False
            Me.btnDerecha.Enabled = False
            Me.btnIzquierda.Enabled = True
            Me.btnAceptar.Enabled = True
            Me.dtvCuentasxcobrar.Enabled = False
            Me.dgvDoc_canjeados.Enabled = True
            Me.btnbuscar_cliente.Enabled = False
        Else
            MessageBox.Show("Para selecionar una fila hace click en la Fecha")
        End If
    End Sub

    Private Sub btnIzquierda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIzquierda.Click
        Me.dgvDoc_canjeados.Rows.Clear()
        CargarClientes()
        Me.cboMoneda.Enabled = True
        Me.btnDerecha.Enabled = True
        Me.btnIzquierda.Enabled = False
        Me.btnAceptar.Enabled = False
        Me.dtvCuentasxcobrar.Enabled = True
        Me.dgvDoc_canjeados.Enabled = False
        Me.btnbuscar_cliente.Enabled = True
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

    Private Sub btnEliminarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminarOrden.Click
        Try
            Eliminar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If frmDocumentos_canjeados.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objLetras = frmDocumentos_canjeados.ObjLetras
            Habilitar(False)
            Cargar()
            Me.btnEliminarOrden.Enabled = True
        End If
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim id_venta As Integer
        Me.dudias_inicial.Enabled = True
        Me.dddias_final.Enabled = True
        Me.dudias_inicial.Text = 0
        Me.dddias_final.Value = 30
        id_venta = Me.dgvDoc_canjeados.Rows(0).Cells(4).Value
        Tabla = nOrden_Venta.Listar(id_venta)
        For Each Fila As DataRow In Tabla.Rows
            Me.txtcuotas.Text = Fila.Item("nro_cuotas")
            Me.txtMonto.Text = Format((Fila.Item("monto_cuota") * (1 + TxtTasa.Text / 100)), "##0.00")
        Next
        Me.btnProcesar.Enabled = True
        Me.TxtTasa.Enabled = False
        Me.btnIzquierda.Enabled = False
        Me.btnAceptar.Enabled = False
        Me.dgvDoc_canjeados.Enabled = False
    End Sub
    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Dim Num_Letra As Integer
        Dim Dias As Integer
        Dim Fecha_Vecimiento As Date
        Dim Letra As String
        Dim cuota As Double
        For Num_Letra = 1 To Me.txtcuotas.Text
            If Num_Letra = 1 Then
                Dias = Me.dudias_inicial.Value + Me.dddias_final.Value
            Else
                Dias = Me.dddias_final.Value
            End If
            Fecha_Vecimiento = DateAdd("d", Me.dudias_inicial.Value + Me.dddias_final.Value * Num_Letra, Me.dtpFecha_Canje.Value)
            Letra = "Letra " & Num_Letra
            cuota = Me.txtMonto.Text
            Me.DataGridView1.Rows.Add(Num_Letra, Dias, Fecha_Vecimiento, Format(cuota, "##0.00"), Letra)
        Next
        Me.dtpFecha_Canje.Enabled = False
        Me.dudias_inicial.Enabled = False
        Me.dddias_final.Enabled = False
        Me.txtcuotas.Enabled = False
        Me.txtMonto.Enabled = False
        Me.btnProcesar.Enabled = False
        Me.btnGrabar.Enabled = True
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    Sub Grabar()
        Try
            If Valida() Then
                If MessageBox.Show("¿Desea registrar los datos de este Letra de Cambión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objLetras.fecha_emision = Me.dtpFecha_Canje.Value
                    objLetras.tasa = Me.TxtTasa.Text.Trim
                    Dim Dgv As DataGridView
                    Dgv = Me.dgvDoc_canjeados
                    Try
                        For i As Integer = 0 To Dgv.RowCount - 1
                            objLetras.coprobrante = CStr(Dgv.Item(0, i).Value)
                            objLetras.saldo = CDbl(Dgv.Item(3, i).Value)
                            objLetras.id_venta = CInt(Dgv.Item(4, i).Value)
                            If objLetras.id_venta <> 0 Then
                                nLetras.Registrar(objLetras)
                            End If
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                    Dgv = Me.DataGridView1
                    Try
                        For i As Integer = 0 To Dgv.RowCount - 1
                            objLetras.num_letra = CInt(Dgv.Item(0, i).Value)
                            objLetras.dias = CInt(Dgv.Item(1, i).Value)
                            objLetras.fecha_vencimiento = CDate(Dgv.Item(2, i).Value)
                            objLetras.monto = CDbl(Dgv.Item(3, i).Value)
                            objLetras.descripcion = CStr(Dgv.Item(4, i).Value)
                            If objLetras.num_letra <> 0 Then
                                nLetras.RegistrarDetalle(objLetras)
                            End If
                        Next
                    Catch ex As Exception
                        MsgBox(ex.Message.ToString)
                    End Try
                    objOrden_Venta.id_venta = objLetras.id_venta
                    objOrden_Venta.Estado = "3"
                    nOrden_Venta.AtenderVenta(objOrden_Venta)
                    MessageBox.Show("Los datos se guardaron satisfactoriamente" & vbCrLf & Me.txtnro_canje.Text, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objLetras.id_letras
                    Me.btnGrabar.Enabled = False
                    Me.btnNuevo.Enabled = True
                    Me.btnEliminarOrden.Enabled = True
                    Habilitar(False)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Eliminar()
        Try
            If MessageBox.Show("¿Desea eliminar los datos de este Letra de Cambión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nLetras.Eleminar(Me.lblCodigo.Text)
                nLetras.EleminarDetalle(Me.lblCodigo.Text)
                objOrden_Venta.id_venta = objLetras.id_venta
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
            Me.lblCodigo.Text = objLetras.id_letras
            Dim numero_documento As String
            Dim serie_documento As String
            Dim fecha_emision As Date
            Dim monto_financiado As Double
            Dim TipoDocumento As String
            Dim id_moneda As Integer
            Dim Moneda As String
            Dim Documento As String
            Dim id_venta As Integer
            Dim X As Integer
            Dim DiasIni As Integer
            Dim DiasFin As Integer
            Tabla = nLetras.Listar(objLetras.id_letras)
            For Each Fila As DataRow In Tabla.Rows
                objLetras.id_letras = Fila.Item("id_letras")
                objLetras.id_venta = Fila.Item("id_venta")
                objLetras.coprobrante = Fila.Item("coprobrante")
                objLetras.fecha_emision = Fila.Item("fecha_emision")
                objLetras.tasa = Fila.Item("tasa")
                objLetras.saldo = Fila.Item("saldo")
            Next
            Dim serie As String
            If objLetras.id_letras < 10 Then
                serie = "0000000" & objLetras.id_letras.ToString
            ElseIf objLetras.id_letras < 100 Then
                serie = "000000" & objLetras.id_letras.ToString
            ElseIf objLetras.id_letras < 1000 Then
                serie = "00000" & objLetras.id_letras.ToString
            ElseIf objLetras.id_letras < 10000 Then
                serie = "0000" & objLetras.id_letras.ToString
            ElseIf objLetras.id_letras < 100000 Then
                serie = "000" & objLetras.id_letras.ToString
            ElseIf objLetras.id_letras < 1000000 Then
                serie = "00" & objLetras.id_letras.ToString
            ElseIf objLetras.id_letras < 10000000 Then
                serie = "0" & objLetras.id_letras.ToString
            Else
                serie = objLetras.id_letras.ToString
            End If
            Me.txtnro_canje.Text = "LC/ " & serie
            Me.dtpFecha_Canje.Value = objLetras.fecha_emision
            Me.TxtTasa.Text = objLetras.tasa
            Tabla = nOrden_Venta.Listar(objLetras.id_venta)
            For Each Fila As DataRow In Tabla.Rows
                objOrden_Venta.id_cliente = Fila.Item("id_cliente")
                objOrden_Venta.id_Moneda = Fila.Item("id_Moneda")
            Next
            Me.cboMoneda.SelectedValue = objOrden_Venta.id_Moneda
            Tabla = nClientes.Listar(objOrden_Venta.id_cliente)
            For Each Fila As DataRow In Tabla.Rows
                objClientes.id_cliente = Fila.Item("id_cliente")
                objClientes.razon_social = Fila.Item("razon_social")
            Next
            Me.txtCliente.Text = objClientes.razon_social
            Tabla = nLetras.CargarClientes(objClientes.id_cliente)
            For Each Fila As DataRow In Tabla.Rows
                numero_documento = Fila.Item("numero_documento")
                serie_documento = Fila.Item("serie_documento")
                fecha_emision = Fila.Item("fecha_emision")
                monto_financiado = Fila.Item("monto_financiado")
                TipoDocumento = Fila.Item("TipoDocumento")
                id_moneda = Fila.Item("id_moneda")
                Moneda = Fila.Item("Moneda")
                id_venta = Fila.Item("id_venta")
                Documento = TipoDocumento & "/ " & numero_documento & " - " & serie_documento
                If objLetras.coprobrante = Documento Then
                    Me.dgvDoc_canjeados.Rows.Add(Documento, fecha_emision, Moneda, Format(objLetras.saldo, "##0.00"), id_venta)
                Else
                    Me.dtvCuentasxcobrar.Rows.Add(Documento, fecha_emision, Format(monto_financiado, "##0.00"), id_moneda, Moneda, id_venta)
                End If
            Next
            Tabla = nLetras.ListarDetalle(objClientes.id_cliente)
            X = 1
            For Each Fila As DataRow In Tabla.Rows
                objLetras.id_letras = Fila.Item("id_letras")
                objLetras.num_letra = Fila.Item("num_letra")
                objLetras.dias = Fila.Item("dias")
                objLetras.fecha_vencimiento = Fila.Item("fecha_vencimiento")
                objLetras.monto = Fila.Item("monto")
                objLetras.descripcion = Fila.Item("descripcion")
                If X = 1 Then
                    DiasIni = objLetras.dias
                ElseIf X = 2 Then
                    DiasFin = DiasIni - objLetras.dias
                    Me.txtMonto.Text = Format(objLetras.monto, "##0.00")
                    Me.dddias_final.Value = objLetras.dias
                    If DiasFin = 0 Then
                        Me.dudias_inicial.Text = 0
                    Else
                        Me.dudias_inicial.Value = DiasFin
                    End If
                End If
                Me.DataGridView1.Rows.Add(objLetras.num_letra, objLetras.dias, objLetras.fecha_vencimiento, Format(objLetras.monto, "##0.00"), objLetras.descripcion)
                X = X + 1
            Next
            Me.txtcuotas.Text = X
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarClientes()
        Try
            Dim numero_documento As String
            Dim serie_documento As String
            Dim fecha_emision As Date
            Dim monto_financiado As Double
            Dim TipoDocumento As String
            Dim id_moneda As Integer
            Dim Moneda As String
            Dim Documento As String
            Dim id_venta As Integer
            Me.txtCliente.Text = objClientes.razon_social
            Me.dtvCuentasxcobrar.Enabled = True
            Me.btnDerecha.Enabled = True
            Tabla = nLetras.CargarClientes(objClientes.id_cliente)
            For Each Fila As DataRow In Tabla.Rows
                numero_documento = Fila.Item("numero_documento")
                serie_documento = Fila.Item("serie_documento")
                fecha_emision = Fila.Item("fecha_emision")
                monto_financiado = Fila.Item("monto_financiado")
                TipoDocumento = Fila.Item("TipoDocumento")
                id_moneda = Fila.Item("id_moneda")
                Moneda = Fila.Item("Moneda")
                id_venta = Fila.Item("id_venta")
                Documento = TipoDocumento & "/ " & numero_documento & " - " & serie_documento
                Me.dtvCuentasxcobrar.Rows.Add(Documento, fecha_emision, Format(monto_financiado, "##0.00"), id_moneda, Moneda, id_venta)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Habilitar(ByVal Estado As Boolean)
        Me.TxtTasa.Enabled = Estado
        Me.cboMoneda.Enabled = Estado
        Me.dtpFecha_Canje.Enabled = Estado
        Me.dtvCuentasxcobrar.Enabled = Estado
        Me.btnbuscar_cliente.Enabled = Estado
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        BuscarSerie()
        Me.txtCliente.Enabled = False
        Me.cboVendedor.Enabled = False
        Me.txtnro_canje.Enabled = False
        Me.btnDerecha.Enabled = False
        Me.btnIzquierda.Enabled = False
        Me.dtvCuentasxcobrar.Enabled = False
        Me.dgvDoc_canjeados.Enabled = False
        Me.btnAceptar.Enabled = False
        Me.DataGridView1.Enabled = False
        Me.btnProcesar.Enabled = False
        Me.lblCodigo.Visible = False
        Me.txtcuotas.Enabled = False
        Me.txtMonto.Enabled = False
        Me.dudias_inicial.Enabled = False
        Me.dddias_final.Enabled = False
        Me.lblCodigo.Text = ""
        Me.txtCliente.Text = ""
        Me.txtcuotas.Text = ""
        Me.txtMonto.Text = ""
        Me.dudias_inicial.Text = ""
        Me.dddias_final.Text = ""
        TxtTasa.Text = "0.0"
        Me.cboVendedor.SelectedValue = id_Vededor
        Me.cboMoneda.SelectedValue = "1"
        Me.dtpFecha_Canje.Value = DateTime.Now()
        Me.dtvCuentasxcobrar.Rows.Clear()
        Me.dgvDoc_canjeados.Rows.Clear()
        Me.DataGridView1.Rows.Clear()
        Me.btnNuevo.Enabled = True
        Me.btnGrabar.Enabled = False
        Me.btnEliminarOrden.Enabled = False
        Me.TxtTasa.Focus()
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
            Dim Personal As DataTable = nPersonal.Listar()
            Me.cboVendedor.ValueMember = "id_personal"
            Me.cboVendedor.DisplayMember = "NombreCompleto"
            Me.cboVendedor.DataSource = Personal
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub BuscarSerie()
        Dim id_Letra As Integer
        Dim serie As String
        id_Letra = nLetras.buscarid()
        If id_Letra < 10 Then
            serie = "0000000" & id_Letra.ToString
        ElseIf id_Letra < 100 Then
            serie = "000000" & id_Letra.ToString
        ElseIf id_Letra < 1000 Then
            serie = "00000" & id_Letra.ToString
        ElseIf id_Letra < 10000 Then
            serie = "0000" & id_Letra.ToString
        ElseIf id_Letra < 100000 Then
            serie = "000" & id_Letra.ToString
        ElseIf id_Letra < 1000000 Then
            serie = "00" & id_Letra.ToString
        ElseIf id_Letra < 10000000 Then
            serie = "0" & id_Letra.ToString
        Else
            serie = id_Letra.ToString
        End If
        Me.txtnro_canje.Text = "LC/ " & serie
    End Sub
    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Function Valida() As Boolean
        Dim TextoError As String = ""
        If Me.txtCliente.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Clientes." & vbCrLf
        End If
        If Me.TxtTasa.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar una Tasa de Interes." & vbCrLf
        End If
        If Me.cboMoneda.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una Monoda." & vbCrLf
        End If
        
        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTasa.KeyPress
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