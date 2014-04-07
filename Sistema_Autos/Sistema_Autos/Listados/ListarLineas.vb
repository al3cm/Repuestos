Imports Reglas_Negocio
Imports Entidades
Public Class frmListarLineas
    Dim nLinea As New RNLinea
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objLinea As Linea


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmListarLineas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_linea.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objLinea = CType(Me.lstlineas.SelectedItems(0).Tag, Linea)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub lstlineas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstlineas.KeyPress
        If Me.lstlineas.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub

    Private Sub lstlineas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstlineas.SelectedIndexChanged
        If Me.lstlineas.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub lstlineas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstlineas.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    Sub ActualizaLista()
        Try
            Me.lstlineas.Items.Clear()
            Tabla = RNLinea.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objL As New Linea
            Item.Text = CStr(Fila.Item("id_linea"))
            Item.SubItems.Add(CStr(Fila.Item("descripcion")))
            objL.id_linea = Fila.Item("id_linea")
            objL.descripcion = Fila.Item("descripcion")
            Item.Tag = objL
            Me.lstlineas.Items.Add(Item)
        Next
    End Sub

    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstlineas.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objL As New Linea
                Item.Text = CStr(Fila.Item("id_linea"))
                Item.SubItems.Add(CStr(Fila.Item("descripcion")))
                objL.id_linea = Fila.Item("id_linea")
                objL.descripcion = Fila.Item("descripcion")
                Item.Tag = objL
                Me.lstlineas.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtbuscar_linea.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("descripcion LIKE '%{0}%'", Me.txtbuscar_linea.Text)
        LlenaLista(Vista)
        'Added 2014.03.22
        Me.btnAceptar.Enabled = False
    End Sub

    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_linea.KeyPress
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