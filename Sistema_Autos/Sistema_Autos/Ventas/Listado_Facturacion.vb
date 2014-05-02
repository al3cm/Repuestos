Imports Reglas_Negocio
Imports Entidades
Public Class frmListado_Facturacion
    Dim nPersonal As New RNPersonal
    Dim nFacturacion As New RNFacturacion
    Dim Tabla As DataTable
    Public objFacturacion As New Facturacion
    Dim Cantidad As Integer
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmListado_Facturacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Cantidad = nPersonal.ContraAlmacen_Personal(id_Vededor)
            ActualizaLista()
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
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim fila As Integer
        fila = Me.DgvOrden_Compra.CurrentRow.Index
        If Me.DgvOrden_Compra.Item(16, fila).Value Then
            Me.objFacturacion.id_movimiento = Me.DgvOrden_Compra.Item(0, fila).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MessageBox.Show("Factura Anulado")
        End If
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub DgvOrden_Compra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DgvOrden_Compra.KeyPress
        If Me.DgvOrden_Compra.Rows.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub
    Private Sub DgvOrden_Compra_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvOrden_Compra.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.DgvOrden_Compra.Rows.Clear()
            If Cantidad <> 1 Then
                Tabla = nFacturacion.Listar
            Else
                Dim Tabla1 As DataTable
                Tabla1 = nPersonal.ListarAlmacen_Personal(id_Vededor)
                For Each Fila As DataRow In Tabla1.Rows
                    Tabla = nFacturacion.Listar(Fila.Item("id_almacen"))
                Next
            End If
            LlenaLista(Tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Consultar()
        Try
            Me.DgvOrden_Compra.Rows.Clear()
            If Cantidad <> 1 Then
                Tabla = nFacturacion.Listar(Me.dtpfecha_inicio.Value, Me.dtpfecha_fin.Value)
            Else
                Dim Tabla1 As DataTable
                Tabla1 = nPersonal.ListarAlmacen_Personal(id_Vededor)
                For Each Fila As DataRow In Tabla1.Rows
                    Tabla = nFacturacion.Listar(Me.dtpfecha_inicio.Value, Me.dtpfecha_fin.Value, Fila.Item("id_almacen"))
                Next
            End If
            LlenaLista(Tabla)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        Me.DgvOrden_Compra.Rows.Clear()
        For Each Fila As DataRow In Datos.Rows
            Dim objFACT As New Facturacion
            Dim objTIDO As New TipoDocumento
            Dim objORVE As New Orden_Venta
            Dim objCLIE As New Cliente
            Dim objPERS As New Personal
            Dim objDECA As New Detalle_Caja
            Dim objMONE As New Moneda
            Dim Documento As String
            Dim Venta As String
            Dim RucDni As String
            Dim Vendedor As String
            Dim Estado As Boolean
            Dim Factura As String
            objFACT.id_movimiento = Fila.Item("id_movimiento")
            objTIDO.abreviatura = Fila.Item("tipoDocumento")
            objFACT.numero_documento = Fila.Item("documento")
            objFACT.serie_documento = Fila.Item("serie")
            Documento = objTIDO.abreviatura & "/ " & objFACT.numero_documento & " - " & objFACT.serie_documento
            objORVE.id_venta = Fila.Item("id_venta")
            objORVE.numero_documento = Fila.Item("documentoventa")
            objORVE.serie_documento = Fila.Item("serieventa")
            Venta = "OV/ " & objORVE.numero_documento & " - " & objORVE.serie_documento
            objCLIE.id_cliente = Fila.Item("id_cliente")
            objCLIE.tipo_cliente = Fila.Item("tipo_cliente")
            If objCLIE.tipo_cliente = "N" Then
                RucDni = Fila.Item("dni")
            Else
                RucDni = Fila.Item("ruc")
            End If
            objCLIE.razon_social = Fila.Item("cliente")
            objCLIE.direccion = Fila.Item("direccion")
            objPERS.id_personal = Fila.Item("id_personal")
            objPERS.nombres = Fila.Item("nombres")
            objPERS.ap_paterno = Fila.Item("ap_paterno")
            objPERS.ap_materno = Fila.Item("ap_materno")
            Vendedor = objPERS.nombres & "  " & objPERS.ap_paterno & "  " & objPERS.ap_materno
            objDECA.id_caja = Fila.Item("id_caja")
            objDECA.descripcion = Fila.Item("detalleCaja")
            objFACT.fecha_movimiento = Fila.Item("fecha_movimiento")
            objMONE.id_moneda = Fila.Item("id_moneda")
            objMONE.descripcion = Fila.Item("moneda")
            objORVE.pago_inicial = Fila.Item("pago_inicial")
            Estado = Fila.Item("estado")
            If Estado Then
                Factura = "Factura Activa"
            Else
                Factura = "Factura Anulado"
            End If
            Me.DgvOrden_Compra.Rows.Add(objFACT.id_movimiento, Documento, objORVE.id_venta, Venta, objCLIE.id_cliente, RucDni, objCLIE.razon_social, objCLIE.direccion, objPERS.id_personal, Vendedor, objDECA.id_caja, objDECA.descripcion, objFACT.fecha_movimiento, objMONE.id_moneda, objMONE.descripcion, Format(objORVE.pago_inicial, "##0.00"), Estado, Factura)
        Next
    End Sub
End Class