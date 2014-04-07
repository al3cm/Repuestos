Imports Reglas_Negocio
Imports Entidades
Public Class frmBuscar_Nota_Credito_Proveedor
    Dim nNota_Credito_Proveedor As New RNNota_Credito_Proveedor
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objNota_Credito_Proveedor As Nota_Credito_Proveedor
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmBuscar_Nota_Credito_Proveedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objNota_Credito_Proveedor = CType(Me.lstListado_NCProovedor.SelectedItems(0).Tag, Nota_Credito_Proveedor)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub lstListado_NCProovedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstListado_NCProovedor.KeyPress
        If Me.lstListado_NCProovedor.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub
    Private Sub lstListado_NCProovedor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstListado_NCProovedor.SelectedIndexChanged
        If Me.lstListado_NCProovedor.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub lstListado_NCProovedor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstListado_NCProovedor.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.lstListado_NCProovedor.Items.Clear()
            Tabla = nNota_Credito_Proveedor.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        Me.lstListado_NCProovedor.Items.Clear()
        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objOCP As New Nota_Credito_Proveedor
            Item.Text = ("NC/ " & CStr(Fila.Item("nro_nota_credito")) & " - " & CStr(Fila.Item("serie_nota_credito")))
            Item.SubItems.Add(CStr(Fila.Item("razon_social")))
            Item.SubItems.Add(CStr(Fila.Item("fecha_emision")))
            Item.SubItems.Add(CStr(Fila.Item("total")))
            Item.SubItems.Add(CStr(Fila.Item("estado")))
            objOCP.id_nota_credito = Fila.Item("id_nota_credito")
            objOCP.nro_nota_credito = Fila.Item("nro_nota_credito")
            objOCP.serie_nota_credito = Fila.Item("serie_nota_credito")
            objOCP.fecha_emision = Fila.Item("fecha_emision")
            objOCP.total = Fila.Item("total")
            Item.Tag = objOCP
            Me.lstListado_NCProovedor.Items.Add(Item)
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstListado_NCProovedor.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objOCP As New Nota_Credito_Proveedor
                Item.Text = ("NC/ " & CStr(Fila.Item("nro_nota_credito")) & " - " & CStr(Fila.Item("serie_nota_credito")))
                Item.SubItems.Add(CStr(Fila.Item("razon_social")))
                Item.SubItems.Add(CStr(Fila.Item("fecha_emision")))
                Item.SubItems.Add(CStr(Fila.Item("total")))
                Item.SubItems.Add(CStr(Fila.Item("estado")))
                objOCP.id_nota_credito = Fila.Item("id_nota_credito")
                objOCP.nro_nota_credito = Fila.Item("nro_nota_credito")
                objOCP.serie_nota_credito = Fila.Item("serie_nota_credito")
                objOCP.fecha_emision = Fila.Item("fecha_emision")
                objOCP.total = Fila.Item("total")
                Item.Tag = objOCP
                Me.lstListado_NCProovedor.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Filtrar() Handles txtbuscar_proveedor.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("razon_social LIKE '%{0}%'", Me.txtbuscar_proveedor.Text)
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