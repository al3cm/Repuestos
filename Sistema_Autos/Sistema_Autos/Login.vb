Imports Reglas_Negocio
Imports Entidades
Public Class frmLogin
    Public UsuarioActivo As Personal

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            If Valida() Then
                Dim DTLogin As DataTable = RNPersonal.Login(Me.txtuser.Text.Trim, Me.txtpassword.Text.Trim)
                If DTLogin.Rows.Count > 0 Then
                    If CStr(DTLogin.Rows(0).Item("estado")) = "A" Then
                        UsuarioActivo = New Personal
                        UsuarioActivo.id_personal = CInt(DTLogin.Rows(0).Item("id_personal"))
                        UsuarioActivo.nombres = CStr(DTLogin.Rows(0).Item("nombres"))
                        UsuarioActivo.ap_paterno = CStr(DTLogin.Rows(0).Item("ap_paterno"))
                        UsuarioActivo.ap_materno = CStr(DTLogin.Rows(0).Item("ap_materno"))
                        UsuarioActivo.estado = CStr(DTLogin.Rows(0).Item("estado"))
                        UsuarioActivo.cargo = CStr(DTLogin.Rows(0).Item("cargo"))
                        UsuarioActivo.usuario = CStr(DTLogin.Rows(0).Item("usuario"))
                        id_Vededor = UsuarioActivo.id_personal
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    ElseIf CStr(DTLogin.Rows(0).Item("estado")) = "V" Then
                        MessageBox.Show("No puede Iniciar Sesión con este usuario debido a que se encuentra de vacaciones, contactar al Administrador", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.txtpassword.Clear()
                        Me.txtuser.Focus()
                    Else
                        MessageBox.Show("No puede Iniciar Sesión con este usuario debido a que se encuentra cesado, contactar al Administrador", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.txtpassword.Clear()
                        Me.txtuser.Focus()
                    End If
                Else
                    MessageBox.Show("El usuario ingresado no existe o la contraseña es incorrecta", "Error al iniciar sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.txtpassword.Clear()
                    Me.txtuser.Focus()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub PresionaEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress, txtuser.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btnAceptar_Click(sender, e)
        End If
    End Sub
    Sub txtUsuario_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtuser.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Function Valida() As Boolean
        Dim TextoError As String = ""

        If Me.txtuser.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un usuario." & vbCrLf
        End If
        If Me.txtpassword.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un clave." & vbCrLf
        End If

        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.txtuser.Focus()
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtuser.Text = ""
        Me.txtpassword.Text = ""
        Me.txtuser.Focus()
    End Sub
End Class