Imports Reglas_Negocio
Imports Entidades
Public Class frmBuscar_Nota_Credito_Cliente
    Dim nNota_Credito_Cliente As New RNNota_Credito_Cliente
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objNota_Credito_Cliente As Nota_Credito_Cliente
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmBuscar_Nota_Credito_Cliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        Me.objNota_Credito_Cliente = CType(Me.lstListado_NCCliente.SelectedItems(0).Tag, Nota_Credito_Cliente)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub lstListado_NCCliente_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstListado_NCCliente.KeyPress
        If Me.lstListado_NCCliente.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub
    Private Sub lstListado_NCCliente_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstListado_NCCliente.SelectedIndexChanged
        If Me.lstListado_NCCliente.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub lstListado_NCCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstListado_NCCliente.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.lstListado_NCCliente.Items.Clear()
            Tabla = nNota_Credito_Cliente.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        Me.lstListado_NCCliente.Items.Clear()
        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objOCC As New Nota_Credito_Cliente
            Item.Text = ("NC/ " & CStr(Fila.Item("nro_nota_credito")) & " - " & CStr(Fila.Item("serie_nota_credito")))
            Item.SubItems.Add("OV/ " & CStr(Fila.Item("numero_documento")) & " - " & CStr(Fila.Item("serie_documento")))
            Item.SubItems.Add(CStr(Fila.Item("razon_social")))
            Item.SubItems.Add(CStr(Fila.Item("total")))
            Item.SubItems.Add(CStr(Fila.Item("Moneda")))
            objOCC.id_nota_credito = Fila.Item("id_nota_credito")
            objOCC.nro_nota_credito = Fila.Item("nro_nota_credito")
            objOCC.serie_nota_credito = Fila.Item("serie_nota_credito")
            objOCC.total = Fila.Item("total")
            Item.Tag = objOCC
            Me.lstListado_NCCliente.Items.Add(Item)
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstListado_NCCliente.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objOCC As New Nota_Credito_Cliente
                Item.Text = ("NC/ " & CStr(Fila.Item("nro_nota_credito")) & " - " & CStr(Fila.Item("serie_nota_credito")))
                Item.SubItems.Add("OV/ " & CStr(Fila.Item("numero_documento")) & " - " & CStr(Fila.Item("serie_documento")))
                Item.SubItems.Add(CStr(Fila.Item("razon_social")))
                Item.SubItems.Add(CStr(Fila.Item("total")))
                Item.SubItems.Add(CStr(Fila.Item("Moneda")))
                objOCC.id_nota_credito = Fila.Item("id_nota_credito")
                objOCC.nro_nota_credito = Fila.Item("nro_nota_credito")
                objOCC.serie_nota_credito = Fila.Item("serie_nota_credito")
                objOCC.total = Fila.Item("total")
                Item.Tag = objOCC
                Me.lstListado_NCCliente.Items.Add(Item)
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