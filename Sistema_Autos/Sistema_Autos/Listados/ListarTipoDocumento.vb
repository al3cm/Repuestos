Imports Reglas_Negocio
Imports Entidades
Public Class frmListarTipoDocumento
    Dim nTipoDocumento As New RNTipoDocumento
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objTipoDocumento As TipoDocumento
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmListarTipoDocumento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_tipodocumento.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objTipoDocumento = CType(Me.lstTipoDocumento.SelectedItems(0).Tag, TipoDocumento)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstTipoDocumento_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstTipoDocumento.KeyPress
        If Me.lstTipoDocumento.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub


    Private Sub lstTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTipoDocumento.SelectedIndexChanged
        If Me.lstTipoDocumento.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub


    Private Sub lstTipoDocumento_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstTipoDocumento.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------

    Sub ActualizaLista()
        Try
            Me.lstTipoDocumento.Items.Clear()
            Tabla = nTipoDocumento.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objTD As New TipoDocumento
            Item.Text = CStr(Fila.Item("id_tipodocumento"))
            Item.SubItems.Add(CStr(Fila.Item("abreviatura")))
            Item.SubItems.Add(CStr(Fila.Item("descripcion")))

            objTD.id_tipodocumento = Fila.Item("id_tipodocumento")
            objTD.abreviatura = Fila.Item("abreviatura")
            objTD.descripcion = Fila.Item("descripcion")

            Item.Tag = objTD
            Me.lstTipoDocumento.Items.Add(Item)
        Next
    End Sub

    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstTipoDocumento.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objTP As New TipoDocumento
                Item.Text = CStr(Fila.Item("id_tipodocumento"))
                Item.SubItems.Add(CStr(Fila.Item("abreviatura")))
                Item.SubItems.Add(CStr(Fila.Item("descripcion")))

                objTP.id_tipodocumento = Fila.Item("id_tipodocumento")
                objTP.abreviatura = Fila.Item("abreviatura")
                objTP.descripcion = Fila.Item("descripcion")
                Item.Tag = objTP

                Me.lstTipoDocumento.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtbuscar_tipodocumento.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("Descripcion LIKE '%{0}%'", Me.txtbuscar_tipodocumento.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False ' Added 2014.03.24
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_tipodocumento.KeyPress
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
