Imports Reglas_Negocio
Imports Entidades
Public Class frmListado_Orden_Venta
    Dim nOrden_Venta As New RNOrden_Venta
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objOrden_Venta As Orden_Venta
    Public accion As Integer
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmListado_Orden_Venta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_proveedor.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objOrden_Venta = CType(Me.lstOrden_Venta.SelectedItems(0).Tag, Orden_Venta)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Filtrar()
    End Sub
    Private Sub lstOrden_Venta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstOrden_Venta.KeyPress
        If Me.lstOrden_Venta.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub lstOrden_Venta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstOrden_Venta.SelectedIndexChanged
        If Me.lstOrden_Venta.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub lstOrden_Venta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstOrden_Venta.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.lstOrden_Venta.Items.Clear()
            If accion = 1 Then
                Tabla = nOrden_Venta.Listar
            Else
                Tabla = nOrden_Venta.ListarTodos
            End If
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        Me.lstOrden_Venta.Items.Clear()
        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objODR As New Orden_Venta
            Item.Text = CStr(Fila.Item("razon_social"))
            Item.SubItems.Add("OV/ " & CStr(Fila.Item("numero_documento")) & " - " & CStr(Fila.Item("serie_documento")))
            Item.SubItems.Add(CStr(Fila.Item("fecha_emision")))
            Select Case CStr(Fila.Item("tipo_pago"))
                Case Is = "E"
                    Item.SubItems.Add("Efectivo")
                Case Is = "C"
                    Item.SubItems.Add("Credito")
                Case Is = "T"
                    Item.SubItems.Add("Tarjeta")
            End Select
            Item.SubItems.Add(CStr(Fila.Item("total")))
            Item.SubItems.Add(CStr(Fila.Item("Moneda")))
            Item.SubItems.Add(CStr(Fila.Item("nombres")) & "  " & CStr(Fila.Item("ap_paterno")) & "  " & CStr(Fila.Item("ap_materno")))
            objODR.id_venta = Fila.Item("id_venta")
            objODR.numero_documento = Fila.Item("numero_documento")
            objODR.fecha_emision = Fila.Item("fecha_emision")
            objODR.total = Fila.Item("total")
            Item.Tag = objODR
            Me.lstOrden_Venta.Items.Add(Item)
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstOrden_Venta.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objODR As New Orden_Venta
                Item.Text = CStr(Fila.Item("razon_social"))
                Item.SubItems.Add("OV/ " & CStr(Fila.Item("numero_documento")) & " - " & CStr(Fila.Item("serie_documento")))
                Item.SubItems.Add(CStr(Fila.Item("fecha_emision")))
                Select Case CStr(Fila.Item("tipo_pago"))
                    Case Is = "E"
                        Item.SubItems.Add("Efetivo")
                    Case Is = "C"
                        Item.SubItems.Add("Credito")
                    Case Is = "T"
                        Item.SubItems.Add("Tarjeta")
                End Select
                Item.SubItems.Add(CStr(Fila.Item("total")))
                Item.SubItems.Add(CStr(Fila.Item("Moneda")))
                Item.SubItems.Add(CStr(Fila.Item("nombres")) & "  " & CStr(Fila.Item("ap_paterno")) & "  " & CStr(Fila.Item("ap_materno")))
                objODR.id_venta = Fila.Item("id_venta")
                objODR.numero_documento = Fila.Item("numero_documento")
                objODR.fecha_emision = Fila.Item("fecha_emision")
                objODR.total = Fila.Item("total")
                Item.Tag = objODR
                Me.lstOrden_Venta.Items.Add(Item)
            Next
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Filtrar() Handles txtbuscar_proveedor.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("razon_social LIKE '%{0}%'", Me.txtbuscar_proveedor.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False 'Add 2014.03.26
    End Sub
    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_proveedor.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class
