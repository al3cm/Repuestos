Imports Reglas_Negocio
Imports Entidades
Public Class frmListarPersonal
    Dim nPersonal As New RNPersonal
    Dim Vista As DataView
    Dim Tabla As DataTable
    Public objPersonal As Personal
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmListarPersonal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.btnAgregarPermisos.Visible = True
        Me.btnAceptar.Visible = True
        Dim ubicacion As Point
        ubicacion.X = 414
        ubicacion.Y = 344
        Me.btnAgregarPermisos.Location = ubicacion
        Me.Tag = 0
        Me.btnCancelar.Text = "&Cancelar"
    End Sub



    Private Sub frmListarPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Added 2014.03.22
            If Me.Tag <> 1 Then
                Me.btnAgregarPermisos.Visible = False
                Me.btnAceptar.Visible = True
            Else
                Me.btnAgregarPermisos.Visible = True
                Me.btnAceptar.Visible = False
                Dim ubicacion As Point
                ubicacion.X = 495
                ubicacion.Y = 344
                Me.btnAgregarPermisos.Location = ubicacion
                Me.btnCancelar.Text = "Cerrar"
            End If
            '------------------
            Me.btnAceptar.Enabled = False
            Me.btnAgregarPermisos.Enabled = False 'Added 2014.03.13
            ActualizaLista()
            Me.txtApellidoPat.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objPersonal = CType(Me.lstPersonal.SelectedItems(0).Tag, Personal)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub lstPersonal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstPersonal.KeyPress
        If Me.Tag <> 1 Then 'Added 2014.03.22
            If Me.lstPersonal.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
                btnAceptar_Click(sender, e)
            End If
        Else
            If Me.lstPersonal.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
                btnAgregarPermisos_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub lstPersonal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstPersonal.SelectedIndexChanged

        If Me.lstPersonal.SelectedItems.Count > 0 Then
            Me.btnAceptar.Enabled = True
            Me.btnAgregarPermisos.Enabled = True 'Added 2014.03.13
        Else
            Me.btnAceptar.Enabled = False
            Me.btnAgregarPermisos.Enabled = False 'Added 2014.03.13
        End If

    End Sub
    Private Sub lstPersonal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPersonal.DoubleClick
        If Me.Tag <> 1 Then 'Added 2014.03.22
            btnAceptar_Click(sender, e)
        Else
            btnAgregarPermisos_Click(sender, e)
        End If

    End Sub
    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------

    Sub ActualizaLista()
        Try
            Me.lstPersonal.Items.Clear()
            Tabla = nPersonal.Listar
            LlenaLista(Tabla)
            Vista = Tabla.DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)

        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objP As New Personal
            Item.Text = CStr(Fila.Item("id_personal"))
            Item.SubItems.Add(CStr(Fila.Item("nombres")))
            Item.SubItems.Add(CStr(Fila.Item("ap_paterno")))
            Item.SubItems.Add(CStr(Fila.Item("ap_materno")))
            Item.SubItems.Add(CStr(Fila.Item("dni")))
            Item.SubItems.Add(CStr(Fila.Item("direccion")))
            If Fila.Item("telefono") Is DBNull.Value Then
                If Fila.Item("celular") Is DBNull.Value Then
                    Item.SubItems.Add("Sin Telefono")
                Else
                    Item.SubItems.Add(CStr(Fila.Item("celular")).Trim)
                End If
            Else
                If Fila.Item("celular") Is DBNull.Value Then
                    Item.SubItems.Add(CStr(Fila.Item("telefono")).Trim)
                Else
                    Item.SubItems.Add(CStr(Fila.Item("telefono")).Trim & "-" & CStr(Fila.Item("celular")).Trim)
                End If
            End If
            If Fila.Item("cargo") = "A" Then
                Item.SubItems.Add("Administrador")
            ElseIf Fila.Item("cargo") = "V" Then
                Item.SubItems.Add("Vendedor")
            End If
            objP.id_personal = Fila.Item("id_personal")
            objP.nombres = Fila.Item("nombres")
            objP.ap_paterno = Fila.Item("ap_paterno")
            objP.ap_materno = Fila.Item("ap_materno")
            objP.dni = Fila.Item("dni")
            objP.direccion = Fila.Item("direccion")
            If Fila.Item("telefono") Is DBNull.Value Then
                If Fila.Item("celular") Is DBNull.Value Then
                Else
                    objP.celular = Fila.Item("celular")
                End If
            Else
                If Fila.Item("celular") Is DBNull.Value Then
                    objP.telefono = Fila.Item("telefono")
                Else
                    objP.telefono = Fila.Item("telefono")
                    objP.celular = Fila.Item("celular")
                End If
            End If
            objP.estado = Fila.Item("estado")
            objP.cargo = Fila.Item("cargo")
            objP.usuario = Fila.Item("usuario")
            objP.clave = Fila.Item("clave")
            Item.Tag = objP
            Me.lstPersonal.Items.Add(Item)
        Next
    End Sub


    Sub LlenaLista(ByVal Datos As DataView)
        Try
            Me.lstPersonal.Items.Clear()
            For Each Fila As DataRowView In Datos.Item(0).DataView
                Dim Item As New ListViewItem
                Dim objP As New Personal
                Item.Text = CStr(Fila.Item("id_personal"))
                Item.SubItems.Add(CStr(Fila.Item("nombres")))
                Item.SubItems.Add(CStr(Fila.Item("ap_paterno")))
                Item.SubItems.Add(CStr(Fila.Item("ap_materno")))
                Item.SubItems.Add(CStr(Fila.Item("dni")))
                Item.SubItems.Add(CStr(Fila.Item("direccion")))
                If Fila.Item("telefono") Is DBNull.Value Then
                    If Fila.Item("celular") Is DBNull.Value Then
                        Item.SubItems.Add("Sin Telefono")
                    Else
                        Item.SubItems.Add(CStr(Fila.Item("celular")).Trim)
                    End If
                Else
                    If Fila.Item("celular") Is DBNull.Value Then
                        Item.SubItems.Add(CStr(Fila.Item("telefono")).Trim)
                    Else
                        Item.SubItems.Add(CStr(Fila.Item("telefono")).Trim & "-" & CStr(Fila.Item("celular")).Trim)
                    End If
                End If
                If Fila.Item("cargo") = "A" Then
                    Item.SubItems.Add("Administrador")
                ElseIf Fila.Item("cargo") = "V" Then
                    Item.SubItems.Add("Vendedor")
                End If
                objP.id_personal = Fila.Item("id_personal")
                objP.nombres = Fila.Item("nombres")
                objP.ap_paterno = Fila.Item("ap_paterno")
                objP.ap_materno = Fila.Item("ap_materno")
                objP.dni = Fila.Item("dni")
                objP.direccion = Fila.Item("direccion")
                If Fila.Item("telefono") Is DBNull.Value Then
                    If Fila.Item("celular") Is DBNull.Value Then
                    Else
                        objP.celular = Fila.Item("celular")
                    End If
                Else
                    If Fila.Item("celular") Is DBNull.Value Then
                        objP.telefono = Fila.Item("telefono")
                    Else
                        objP.telefono = Fila.Item("telefono")
                        objP.celular = Fila.Item("celular")
                    End If
                End If
                objP.estado = Fila.Item("estado")
                objP.cargo = Fila.Item("cargo")
                objP.usuario = Fila.Item("usuario")
                objP.clave = Fila.Item("clave")
                Item.Tag = objP

                Me.lstPersonal.Items.Add(Item)
            Next
        Catch ex As Exception
            '   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Filtrar() Handles txtApellidoPat.TextChanged, txtApellidoMat.TextChanged, txtDNI.TextChanged
        Vista = Tabla.DefaultView
        Vista.RowFilter = String.Format("ap_paterno LIKE '%{0}%' AND ap_materno LIKE '%{1}%' AND dni LIKE '%{2}%'", Me.txtApellidoPat.Text, Me.txtApellidoMat.Text, Me.txtDNI.Text)
        LlenaLista(Vista)
        'Added 2014.03.22
        Me.btnAgregarPermisos.Enabled = False
        Me.btnAceptar.Enabled = False
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoPat.KeyPress, txtApellidoMat.KeyPress
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


    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
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

    'Added 2014.03.13
    Private Sub btnAgregarPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPermisos.Click
        Try
            Dim frmListarPersonalSubMenu As New ListarPersonalSubMenu
            Me.objPersonal = CType(Me.lstPersonal.SelectedItems(0).Tag, Personal)
            frmListarPersonalSubMenu.id_personal = Me.objPersonal.id_personal
            frmListarPersonalSubMenu.usuario = Me.objPersonal.usuario
            frmListarPersonalSubMenu.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class