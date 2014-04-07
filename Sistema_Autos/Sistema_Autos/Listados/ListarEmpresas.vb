Imports Reglas_Negocio
Imports Entidades
Public Class frmListarEmpresas
    Dim nEmpresa As New RNEmpresa
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objEmpresa As Empresa
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub frmListarEmpresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.btnAceptar.Enabled = False
            ActualizaLista()
            Me.txtfiltro_razon_social.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objEmpresa = CType(Me.lstEmpresas.SelectedItems(0).Tag, Empresa)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub


    Private Sub lstEmpresas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstEmpresas.KeyPress
        If Me.lstEmpresas.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub


    Private Sub lstEmpresas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEmpresas.SelectedIndexChanged
        If Me.lstEmpresas.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
        Else
            Me.btnAceptar.Enabled = False
        End If
    End Sub

    Private Sub lstEmpresas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEmpresas.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub

    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------

    Sub ActualizaLista()
        Try
            Me.lstEmpresas.Items.Clear()
            Tabla = RNEmpresa.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objE As New Empresa
            Item.Text = CStr(Fila.Item("id_empresa"))
            Item.SubItems.Add(CStr(Fila.Item("ruc")))
            Item.SubItems.Add(CStr(Fila.Item("razon_social")))
            Item.SubItems.Add(CStr(Fila.Item("direccion")))
            Item.SubItems.Add(CStr(Fila.Item("telefono")).Trim)
            objE.id_empresa = Fila.Item("id_empresa")
            objE.ruc = Fila.Item("ruc")
            objE.razon_social = Fila.Item("razon_social")
            objE.direccion = Fila.Item("direccion")
            objE.telefono = Fila.Item("telefono")
            Item.Tag = objE
            Me.lstEmpresas.Items.Add(Item)
        Next
    End Sub

    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstEmpresas.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objE As New Empresa
                Item.Text = CStr(Fila.Item("id_empresa"))
                Item.SubItems.Add(CStr(Fila.Item("ruc")))
                Item.SubItems.Add(CStr(Fila.Item("razon_social")))
                Item.SubItems.Add(CStr(Fila.Item("direccion")))
                Item.SubItems.Add(CStr(Fila.Item("telefono")).Trim)
                objE.id_empresa = Fila.Item("id_empresa")
                objE.razon_social = Fila.Item("razon_social")
                objE.ruc = Fila.Item("ruc")
                objE.direccion = Fila.Item("direccion")
                objE.telefono = Fila.Item("telefono")
                Item.Tag = objE
                Me.lstEmpresas.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtfiltro_razon_social.TextChanged, txtfiltro_ruc.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("razon_social LIKE '%{0}%' AND ruc LIKE '%{1}%' ", Me.txtfiltro_razon_social.Text, Me.txtfiltro_ruc.Text)
        LlenaLista(Vista)
        'Added 2014.03.22
        Me.btnAceptar.Enabled = False
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfiltro_razon_social.KeyPress
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
    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtfiltro_ruc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "#" Or e.KeyChar = "*" Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class