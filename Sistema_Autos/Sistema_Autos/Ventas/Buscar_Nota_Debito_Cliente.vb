Imports Reglas_Negocio
Imports Entidades
Public Class frmBuscar_Nota_Debito_Cliente
    Dim nNota_Debito_Cliente As New RNNota_Debito_Clientes
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objNota_Debito_Cliente As Nota_Debito_Clientes
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmBuscar_Nota_Debito_Cliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_cliente.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objNota_Debito_Cliente = CType(Me.lstListado_NDCliente.SelectedItems(0).Tag, Nota_Debito_Clientes)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub lstListado_NDCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstListado_NDCliente.KeyPress
        If Me.lstListado_NDCliente.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub
    Private Sub lstListado_NDCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstListado_NDCliente.SelectedIndexChanged
        If Me.lstListado_NDCliente.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub lstListado_NDCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstListado_NDCliente.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.lstListado_NDCliente.Items.Clear()
            Tabla = nNota_Debito_Cliente.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        Me.lstListado_NDCliente.Items.Clear()
        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objODC As New Nota_Debito_Clientes
            Item.Text = ("NC/ " & CStr(Fila.Item("nro_nota_debito")) & " - " & CStr(Fila.Item("serie_nota_debito")))
            Item.SubItems.Add("OV/ " & CStr(Fila.Item("numero_documento")) & " - " & CStr(Fila.Item("serie_documento")))
            Item.SubItems.Add(CStr(Fila.Item("razon_social")))
            Item.SubItems.Add(CStr(Fila.Item("total")))
            Item.SubItems.Add(CStr(Fila.Item("Moneda")))
            objODC.id_nota_debito = Fila.Item("id_nota_debito")
            objODC.nro_nota_debito = Fila.Item("nro_nota_debito")
            objODC.serie_nota_debito = Fila.Item("serie_nota_debito")
            objODC.total = Fila.Item("total")
            Item.Tag = objODC
            Me.lstListado_NDCliente.Items.Add(Item)
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstListado_NDCliente.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objODC As New Nota_Debito_Clientes
                Item.Text = ("NC/ " & CStr(Fila.Item("nro_nota_debito")) & " - " & CStr(Fila.Item("serie_nota_debito")))
                Item.SubItems.Add("OV/ " & CStr(Fila.Item("numero_documento")) & " - " & CStr(Fila.Item("serie_documento")))
                Item.SubItems.Add(CStr(Fila.Item("razon_social")))
                Item.SubItems.Add(CStr(Fila.Item("total")))
                Item.SubItems.Add(CStr(Fila.Item("Moneda")))
                objODC.id_nota_debito = Fila.Item("id_nota_debito")
                objODC.nro_nota_debito = Fila.Item("nro_nota_debito")
                objODC.serie_nota_debito = Fila.Item("serie_nota_debito")
                objODC.total = Fila.Item("total")
                Item.Tag = objODC
                Me.lstListado_NDCliente.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Filtrar() Handles txtbuscar_cliente.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("razon_social LIKE '%{0}%'", Me.txtbuscar_cliente.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False
    End Sub
    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_cliente.KeyPress
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