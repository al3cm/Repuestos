Imports Reglas_Negocio
Imports Entidades
Public Class ListarPersonalSubMenu
    Public usuario As String
    Public id_personal As String
    Dim Tabla As DataTable
    Dim Flag As Boolean ' False al inicio, True si ya se llenó la lista
    Private Sub ListarPersonalSubMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.lblUsuario.Focus()
            Me.btnModificar.Enabled = False
            Me.lblUsuario.Text = usuario
            LlenaLista()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim frmAsignarPermisos As New PersonalSubMenu
            frmAsignarPermisos.Permisos = CType(Me.lstSubMenu.SelectedItems(0).Tag, Entidades.Personal_SubMenu)

            If frmAsignarPermisos.ShowDialog = Windows.Forms.DialogResult.OK Then
                LlenaLista()
            End If
            lstPersonal_SelectedIndexChanged(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub lstPersonal_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lstSubMenu.ItemChecked

        If Flag = False Then
            If e.Item.Checked = True Then
                Me.lstSubMenu.Items(e.Item.Index).ForeColor = Color.Black
            Else
                Me.lstSubMenu.Items(e.Item.Index).ForeColor = Color.Gray
            End If
            Dim temp As Entidades.Personal_SubMenu = CType(Me.lstSubMenu.Items(e.Item.Index).Tag, Entidades.Personal_SubMenu)
            temp.estado = e.Item.Checked
            Me.lstSubMenu.Items(e.Item.Index).Tag = temp
            RNPersonalSubMenu.ModificarPermisos(CType(Me.lstSubMenu.Items(e.Item.Index).Tag, Entidades.Personal_SubMenu))

        End If


    End Sub

    Private Sub lstPersonal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstSubMenu.KeyPress
        If Me.lstSubMenu.SelectedItems.Count > 0 And e.KeyChar = ChrW(Keys.Enter) Then
            btnModificar_Click(sender, e)
        End If
    End Sub


    Private Sub lstPersonal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSubMenu.SelectedIndexChanged

        If Me.lstSubMenu.SelectedItems.Count > 0 Then
            If CType(Me.lstSubMenu.SelectedItems(0).Tag, Entidades.Personal_SubMenu).estado = True Then
                Me.btnModificar.Enabled = True
            Else
                Me.btnModificar.Enabled = False
            End If
        Else
            Me.btnModificar.Enabled = False
        End If

    End Sub

    '---------------------------------------------
    '-----------------MANEJO DE LISTVIEW
    '---------------------------------------------


    Sub LlenaLista()
        Flag = True
        Me.lstSubMenu.Items.Clear()
        Tabla = RNPersonal.ListarAccesoUsuario(id_personal)
        For Each Fila As DataRow In Tabla.Rows
            Dim Item As New ListViewItem
            Dim objP As New Personal_SubMenu
            'Item.Text = CStr(Fila.Item("id_personal"))
            Item.SubItems.Add(CStr(Fila.Item("menu")))
            Item.SubItems.Add(CStr(Fila.Item("submenu")))
            If Fila.Item("nuevo") = True Then
                Item.SubItems.Add("SI")
            Else
                Item.SubItems.Add("NO")
            End If
            If Fila.Item("eliminar") = True Then
                Item.SubItems.Add("SI")
            Else
                Item.SubItems.Add("NO")
            End If
            If Fila.Item("modificar") = True Then
                Item.SubItems.Add("SI")
            Else
                Item.SubItems.Add("NO")
            End If
            If Fila.Item("buscar") = True Then
                Item.SubItems.Add("SI")
            Else
                Item.SubItems.Add("NO")
            End If
            If Fila.Item("estado") = True Then
                Item.Checked = True

            Else
                Item.ForeColor = Color.Gray
                Item.Checked = False
            End If

            objP.id_personal = Fila.Item("id_personal")
            objP.id_menu = Fila.Item("id_menu")
            objP.id_submenu = Fila.Item("id_submenu")
            objP.estado = Fila.Item("estado")
            objP.nuevo = Fila.Item("nuevo")
            objP.eliminar = Fila.Item("eliminar")
            objP.modificar = Fila.Item("modificar")
            objP.buscar = Fila.Item("buscar")
            Item.Tag = objP
            Me.lstSubMenu.Items.Add(Item)
        Next
        Flag = False
    End Sub


 
End Class