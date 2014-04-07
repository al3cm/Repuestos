Imports Reglas_Negocio
Imports Entidades
Public Class frmListarMoneda
    Dim nMoneda As New RNMoneda
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objMoneda As Moneda


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmListarMoneda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtBuscar_moneda.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objMoneda = CType(Me.lstMoneda.SelectedItems(0).Tag, Moneda)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstMoneda_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstMoneda.KeyPress
        If Me.lstMoneda.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub


    Private Sub lstMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMoneda.SelectedIndexChanged
        If Me.lstMoneda.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub


    Private Sub lstMoneda_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMoneda.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    Sub ActualizaLista()
        Try
            Me.lstMoneda.Items.Clear()
            Tabla = nMoneda.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objMo As New Moneda
            Item.Text = CStr(Fila.Item("id_moneda"))
            Item.SubItems.Add(CStr(Fila.Item("descripcion")))
            Item.SubItems.Add(CStr(Fila.Item("simbolo")))
            objMo.id_moneda = Fila.Item("id_moneda")
            objMo.descripcion = Fila.Item("descripcion")
            objMo.simbolo = Fila.Item("simbolo")
            Item.Tag = objMo
            Me.lstMoneda.Items.Add(Item)
        Next
    End Sub

    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstMoneda.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objMo As New Moneda
                Item.Text = CStr(Fila.Item("id_moneda"))
                Item.SubItems.Add(CStr(Fila.Item("descripcion")))
                Item.SubItems.Add(CStr(Fila.Item("simbolo")))
                objMo.id_moneda = Fila.Item("id_moneda")
                objMo.descripcion = Fila.Item("descripcion")
                objMo.simbolo = Fila.Item("simbolo")
                Item.Tag = objMo
                Me.lstMoneda.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtBuscar_moneda.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("Descripcion LIKE '%{0}%'", Me.txtBuscar_moneda.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False 'Added 2014.03.24
    End Sub

    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscar_moneda.KeyPress
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