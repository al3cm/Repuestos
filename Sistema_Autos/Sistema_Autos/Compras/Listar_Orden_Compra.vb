Imports Reglas_Negocio
Imports Entidades
Public Class frmListar_Orden_Compra
    Dim nOrden_Compra As New RNOrden_Compra
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objOrden_Compra As Orden_Compra
    Public accion As Integer
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmListar_Orden_Compra_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_proveedor.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objOrden_Compra = CType(Me.lstOrden_Compra.SelectedItems(0).Tag, Orden_Compra)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Consultar()
    End Sub

    Private Sub lstOrden_Compra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstOrden_Compra.KeyPress
        If Me.lstOrden_Compra.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub
    Private Sub lstOrden_Compra_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstOrden_Compra.SelectedIndexChanged
        If Me.lstOrden_Compra.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub lstOrden_Compra_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstOrden_Compra.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.lstOrden_Compra.Items.Clear()
            If accion = 1 Then
                Tabla = nOrden_Compra.Listar
            Else
                Tabla = nOrden_Compra.ListarTodos
            End If
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)
        Me.lstOrden_Compra.Items.Clear()
        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objODR As New Orden_Compra
            Item.Text = CStr(Fila.Item("razon_social"))
            Item.SubItems.Add("OC/ " & CStr(Fila.Item("numero_documento")) & " - " & CStr(Fila.Item("serie_documento")))
            Item.SubItems.Add(CStr(Fila.Item("fecha_compra")))
            Item.SubItems.Add(CStr(Fila.Item("Moneda")))
            Item.SubItems.Add(CStr(Fila.Item("total")))
            objODR.id_compra = Fila.Item("id_compra")
            objODR.numero_documento = Fila.Item("numero_documento")
            objODR.fecha_compra = Fila.Item("fecha_compra")
            objODR.total = Fila.Item("total")
            Item.Tag = objODR
            Me.lstOrden_Compra.Items.Add(Item)
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstOrden_Compra.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objODR As New Orden_Compra
                Item.Text = CStr(Fila.Item("razon_social"))
                Item.SubItems.Add("OC/ " & CStr(Fila.Item("numero_documento")) & " - " & CStr(Fila.Item("serie_documento")))
                Item.SubItems.Add(CStr(Fila.Item("fecha_compra")))
                Item.SubItems.Add(CStr(Fila.Item("Moneda")))
                Item.SubItems.Add(CStr(Fila.Item("total")))
                objODR.id_compra = Fila.Item("id_compra")
                objODR.numero_documento = Fila.Item("numero_documento")
                objODR.fecha_compra = Fila.Item("fecha_compra")
                objODR.total = Fila.Item("total")
                Item.Tag = objODR
                Me.lstOrden_Compra.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Filtrar() Handles txtbuscar_proveedor.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("razon_social LIKE '%{0}%'", Me.txtbuscar_proveedor.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False 'Added 2014.03.26
    End Sub
    Private Sub Consultar() Handles dtpfecha_inicio.ValueChanged, dtpfecha_fin.ValueChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("fecha_compra BETWEEN '{0}' AND '{1}'", Me.dtpfecha_inicio.Value, dtpfecha_fin.Value)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False
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

