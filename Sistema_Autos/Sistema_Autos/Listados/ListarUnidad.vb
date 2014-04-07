Imports Reglas_Negocio
Imports Entidades
Public Class frmListarUnidad
    Dim nUnidad As New RNUnidad
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objUnidad As Unidad
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmListarUnidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtbuscar_unidades.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objUnidad = CType(Me.lstUnidades.SelectedItems(0).Tag, Unidad)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstUnidades_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstUnidades.KeyPress
        If Me.lstUnidades.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub


    Private Sub lstUnidades_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUnidades.SelectedIndexChanged
        If Me.lstUnidades.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub


    Private Sub lstUnidades_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstUnidades.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------

    Sub ActualizaLista()
        Try
            Me.lstUnidades.Items.Clear()
            Tabla = RNUnidad.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objU As New Unidad
            Item.Text = CStr(Fila.Item("id_unidad"))
            Item.SubItems.Add(CStr(Fila.Item("abreviatura")))
            Item.SubItems.Add(CStr(Fila.Item("descripcion")))

            objU.id_unidad = Fila.Item("id_unidad")
            objU.abreviatura = Fila.Item("abreviatura")
            objU.descripcion = Fila.Item("descripcion")

            Item.Tag = objU
            Me.lstUnidades.Items.Add(Item)
        Next
    End Sub

    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstUnidades.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objU As New Unidad
                Item.Text = CStr(Fila.Item("id_unidad"))
                Item.SubItems.Add(CStr(Fila.Item("abreviatura")))
                Item.SubItems.Add(CStr(Fila.Item("descripcion")))

                objU.id_unidad = Fila.Item("id_unidad")
                objU.abreviatura = Fila.Item("abreviatura")
                objU.descripcion = Fila.Item("descripcion")
                Item.Tag = objU

                Me.lstUnidades.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtbuscar_unidades.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("Descripcion LIKE '%{0}%'", Me.txtbuscar_unidades.Text)
        LlenaLista(Vista)
        'Added 2014.03.23
        Me.btnAceptar.Enabled = False
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtbuscar_unidades.KeyPress
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