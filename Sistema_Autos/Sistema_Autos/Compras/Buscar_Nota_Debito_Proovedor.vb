Imports Reglas_Negocio
Imports Entidades
Public Class frmBuscar_Nota_Debito_Proovedor
    Dim nNota_Debito_Proovedor As New RNNota_Debito_Proveedor
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objNota_Debito_Proovedor As Nota_Debito_Proveedor
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmBuscar_Nota_Debito_Proovedor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
        Me.objNota_Debito_Proovedor = CType(Me.lstListado_NDProovedor.SelectedItems(0).Tag, Nota_Debito_Proveedor)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    Private Sub lstListado_NDProovedor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstListado_NDProovedor.KeyPress
        If Me.lstListado_NDProovedor.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub
    Private Sub lstListado_NDProovedor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstListado_NDProovedor.SelectedIndexChanged
        If Me.lstListado_NDProovedor.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub
    Private Sub lstListado_NDProovedor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstListado_NDProovedor.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------
    Sub ActualizaLista()
        Try
            Me.lstListado_NDProovedor.Items.Clear()
            Tabla = nNota_Debito_Proovedor.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub LlenaLista(ByVal Datos As DataTable)
        Me.lstListado_NDProovedor.Items.Clear()
        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objODP As New Nota_Debito_Proveedor
            Item.Text = ("ND/ " & CStr(Fila.Item("nro_nota_debito")) & " - " & CStr(Fila.Item("serie_nota_debito")))
            Item.SubItems.Add(CStr(Fila.Item("razon_social")))
            Item.SubItems.Add(CStr(Fila.Item("fecha_emision")))
            Item.SubItems.Add(CStr(Fila.Item("total")))
            objODP.id_nota_debito = Fila.Item("id_nota_debito")
            objODP.nro_nota_debito = Fila.Item("nro_nota_debito")
            objODP.serie_nota_debito = Fila.Item("serie_nota_debito")
            objODP.fecha_emision = Fila.Item("fecha_emision")
            objODP.total = Fila.Item("total")
            Item.Tag = objODP
            Me.lstListado_NDProovedor.Items.Add(Item)
        Next
    End Sub
    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstListado_NDProovedor.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objODP As New Nota_Debito_Proveedor
                Item.Text = ("ND/ " & CStr(Fila.Item("nro_nota_debito")) & " - " & CStr(Fila.Item("serie_nota_debito")))
                Item.SubItems.Add(CStr(Fila.Item("razon_social")))
                Item.SubItems.Add(CStr(Fila.Item("fecha_emision")))
                Item.SubItems.Add(CStr(Fila.Item("total")))
                objODP.id_nota_debito = Fila.Item("id_nota_debito")
                objODP.nro_nota_debito = Fila.Item("nro_nota_debito")
                objODP.serie_nota_debito = Fila.Item("serie_nota_debito")
                objODP.fecha_emision = Fila.Item("fecha_emision")
                objODP.total = Fila.Item("total")
                Item.Tag = objODP
                Me.lstListado_NDProovedor.Items.Add(Item)
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