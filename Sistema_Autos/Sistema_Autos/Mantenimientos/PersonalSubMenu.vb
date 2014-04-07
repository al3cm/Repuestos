Imports Entidades
Imports Reglas_Negocio
Public Class PersonalSubMenu
    Public Permisos As Entidades.Personal_SubMenu

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Permisos.nuevo = Me.chkNuevo.Checked
            Permisos.modificar = Me.chkModificar.Checked
            Permisos.eliminar = Me.chkEliminar.Checked
            Permisos.buscar = Me.chkBuscar.Checked
            RNPersonalSubMenu.ModificarPermisos(Permisos)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PersonalSubMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.chkNuevo.Checked = Permisos.nuevo
            Me.chkModificar.Checked = Permisos.modificar
            Me.chkEliminar.Checked = Permisos.eliminar
            Me.chkBuscar.Checked = Permisos.buscar
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class