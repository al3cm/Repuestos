Imports Reglas_Negocio
Imports Entidades
Public Class frmListarAlmacen
    Dim nAlmacen As New RNAlmacen
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objAlmacen As Almacen
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmListarAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_almacen.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objAlmacen = CType(Me.lstAlmacen.SelectedItems(0).Tag, Almacen)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstAlmacen_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstAlmacen.KeyPress
        If Me.lstAlmacen.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub


    Private Sub lstAlmacen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAlmacen.SelectedIndexChanged
        If Me.lstAlmacen.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub


    Private Sub lstAlmacen_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAlmacen.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------

    Sub ActualizaLista()
        Try
            Me.lstAlmacen.Items.Clear()
            Tabla = nAlmacen.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objAL As New Almacen
            Item.Text = CStr(Fila.Item("id_almacen"))
            Item.SubItems.Add(CStr(Fila.Item("sucursal"))) 'Modified 2014.03.24
            Item.SubItems.Add(CStr(Fila.Item("descripcion")))

            objAL.id_almacen = Fila.Item("id_almacen")
            objAL.id_sucursal = Fila.Item("id_sucursal")
            objAL.descripcion = Fila.Item("descripcion")
            Item.Tag = objAL
            Me.lstAlmacen.Items.Add(Item)
        Next
    End Sub


    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstAlmacen.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objAL As New Almacen
                Item.Text = CStr(Fila.Item("id_almacen"))
                Item.SubItems.Add(CStr(Fila.Item("sucursal"))) 'Modified 2014.03.24
                Item.SubItems.Add(CStr(Fila.Item("descripcion")))
                objAL.id_almacen = Fila.Item("id_almacen")
                objAL.id_sucursal = Fila.Item("id_sucursal")
                objAL.descripcion = Fila.Item("descripcion")
                Item.Tag = objAL
                Me.lstAlmacen.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtbuscar_almacen.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("descripcion LIKE '%{0}%' ", Me.txtbuscar_almacen.Text)
        LlenaLista(Vista)
        Me.btnAceptar.Enabled = False 'Added 2014.03.24s
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_almacen.KeyPress
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