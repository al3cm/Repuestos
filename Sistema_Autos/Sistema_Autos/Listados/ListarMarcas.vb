Imports Reglas_Negocio
Imports Entidades
Public Class frmListarMarcas
    Dim nMarca As New RNMarca
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objMarca As Marca

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmListarMarcas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaMarca()
            Me.txtbuscar_marca.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objMarca = CType(Me.lstMarcas.SelectedItems(0).Tag, Marca)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstMarcas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstMarcas.KeyPress
        If Me.lstMarcas.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub lstMarcas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMarcas.SelectedIndexChanged
        If Me.lstMarcas.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub


    Private Sub lstMarcas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMarcas.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    Sub ActualizaMarca()
        Try
            Me.lstMarcas.Items.Clear()
            Tabla = RNMarca.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objM As New Marca
            Item.Text = CStr(Fila.Item("id_marca"))
            Item.SubItems.Add(CStr(Fila.Item("descripcion")))
            objM.id_marca = Fila.Item("id_marca")
            objM.descripcion = Fila.Item("descripcion")
            Item.Tag = objM
            Me.lstMarcas.Items.Add(Item)
        Next
    End Sub

    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstMarcas.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objM As New Marca
                Item.Text = CStr(Fila.Item("id_marca"))
                Item.SubItems.Add(CStr(Fila.Item("descripcion")))
                objM.id_marca = Fila.Item("id_marca")
                objM.descripcion = Fila.Item("descripcion")
                Item.Tag = objM
                Me.lstMarcas.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtbuscar_marca.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("descripcion LIKE '%{0}%'", Me.txtbuscar_marca.Text)
        LlenaLista(Vista)
        'Added 2014.03.22
        Me.btnAceptar.Enabled = False
    End Sub

    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_marca.KeyPress
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