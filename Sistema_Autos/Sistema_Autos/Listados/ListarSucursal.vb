Imports Reglas_Negocio
Imports Entidades
Public Class frmListarSucursal
    Dim nSucursal As New RNSucursal
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objSucursal As Sucursal
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmListarSucursal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_sucursal.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objSucursal = CType(Me.lstSucursal.SelectedItems(0).Tag, Sucursal)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstSucursal_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstSucursal.KeyPress
        If Me.lstSucursal.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub


    Private Sub lstSucursal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSucursal.SelectedIndexChanged
        If Me.lstSucursal.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub


    Private Sub lstSucursal_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSucursal.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------

    Sub ActualizaLista()
        Try
            Me.lstSucursal.Items.Clear()
            Tabla = RNSucursal.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objS As New Sucursal
            Item.Text = CStr(Fila.Item("id_sucursal"))
            Item.SubItems.Add(CStr(Fila.Item("descripcion")))
            Item.SubItems.Add(CStr(Fila.Item("direccion")))
            Item.SubItems.Add(CStr(Fila.Item("telefono")).Trim)
            objS.id_sucursal = Fila.Item("id_sucursal")
            objS.descripcion = Fila.Item("descripcion")
            objS.direccion = Fila.Item("direccion")
            objS.telefono = Fila.Item("telefono")
            Item.Tag = objS
            Me.lstSucursal.Items.Add(Item)
        Next
    End Sub

    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstSucursal.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objS As New Sucursal
                Item.Text = CStr(Fila.Item("id_sucursal"))
                Item.SubItems.Add(CStr(Fila.Item("descripcion")))
                Item.SubItems.Add(CStr(Fila.Item("direccion")))
                Item.SubItems.Add(CStr(Fila.Item("telefono")).Trim)
                objS.id_sucursal = Fila.Item("id_sucursal")
                objS.descripcion = Fila.Item("descripcion")
                objS.direccion = Fila.Item("direccion")
                objS.telefono = Fila.Item("telefono")
                Item.Tag = objS
                Me.lstSucursal.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtbuscar_sucursal.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("Descripcion LIKE '%{0}%' ", Me.txtbuscar_sucursal.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False 'Added 2014.03.24
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_sucursal.KeyPress
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