Imports Entidades
Imports Reglas_Negocio
Public Class frmPersonal
    Dim objPersonal As New Personal
    Dim nPersonal As New RNPersonal
    Dim nAlmacen As New RNAlmacen
    Dim Tabla As DataTable
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If frmListarPersonal.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objPersonal = frmListarPersonal.objPersonal
            Cargar()
            Habilitar(False)
            btnGrabar.Enabled = False
            btnModificar.Tag = "Modificar"
            btnModificar.Text = "&Modificar"
            btnNuevo.Enabled = True
            btnEliminar.Enabled = True
            btnBuscar.Enabled = True
        End If
    End Sub
    Private Sub btnPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPermisos.Click
        If cboCargo.SelectedValue = "0" Then
            MessageBox.Show("Selecionar un Cargar")
        ElseIf cboCargo.SelectedValue = "A" Then
            MessageBox.Show("Los Admintradores tiene premiso a todos los Almacene")
        ElseIf frmPermiso_Almacenes.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objPersonal.id_almacen = frmPermiso_Almacenes.objPersonal.id_almacen
        End If
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmPersonal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub

    Private Sub frmPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' LÓGICA PERMISOS -------------------------------------------------
            Me.Tag = RNPersonalSubMenu.ListarPersonalSubMenu(CType(Me.Tag, Personal_SubMenu).id_menu, CType(Me.Tag, Personal_SubMenu).id_submenu, CType(Me.Tag, Personal_SubMenu).id_personal)
            If Me.Tag Is Nothing Then
                MessageBox.Show("Error al asignar archivos, consulte con el Administrador del Sstema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            ' -----------------------------------------------------------------
            LlenaCombos()
            Limpiar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click
        Try
            If Me.btnGrabar.Tag = "Grabar" Then
                Grabar()
            Else
                'Modified 2014.03.22
                If Valida() Then
                    If MessageBox.Show("¿Desea modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                        Modificar()
                        Habilitar(False)
                        btnGrabar.Tag = "Grabar"
                        btnGrabar.Enabled = False
                        btnModificar.Tag = "Modificar"
                        btnModificar.Text = "&Modificar"
                        btnNuevo.Enabled = True
                        btnEliminar.Enabled = True
                        btnBuscar.Enabled = True
                        ' LÓGICA PERMISOS -------------------------------------------------
                        If CType(Me.Tag, Personal_SubMenu).nuevo = False Then
                            Me.btnGrabar.Visible = False
                        End If
                        ' -----------------------------------------------------------------
                    End If
                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        Limpiar()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            If btnModificar.Tag = "Modificar" Then
                Habilitar(True)
                btnGrabar.Tag = "Modificar"
                btnGrabar.Enabled = True
                btnModificar.Tag = "Cancelar"
                btnModificar.Text = "&Cancelar"
                btnNuevo.Enabled = False
                btnEliminar.Enabled = False
                btnBuscar.Enabled = True
                ' LÓGICA PERMISOS -------------------------------------------------
                If CType(Me.Tag, Personal_SubMenu).nuevo = False Then
                    Me.btnGrabar.Visible = True
                End If
                ' -----------------------------------------------------------------
            Else
                Habilitar(False)
                btnGrabar.Tag = "Grabar"
                btnGrabar.Enabled = False
                btnModificar.Tag = "Modificar"
                btnModificar.Text = "&Modificar"
                btnNuevo.Enabled = True
                btnEliminar.Enabled = True
                btnBuscar.Enabled = True
                Cargar()
                ' LÓGICA PERMISOS -------------------------------------------------
                If CType(Me.Tag, Personal_SubMenu).nuevo = False Then
                    Me.btnGrabar.Visible = False
                End If
                ' -----------------------------------------------------------------

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Eliminar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    Sub Grabar()
        Try

            If Valida() Then
                objPersonal.nombres = Me.txtNombres.Text.Trim
                objPersonal.ap_paterno = Me.txtApellidoPat.Text.Trim
                objPersonal.ap_materno = Me.txtApellidoMat.Text.Trim
                objPersonal.dni = Me.txtDNI.Text.Trim
                objPersonal.cargo = Me.cboCargo.SelectedValue
                objPersonal.direccion = Me.txtDireccion.Text.Trim
                objPersonal.usuario = Me.txtUsuario.Text.Trim
                objPersonal.clave = Me.txtClave.Text.Trim
                objPersonal.estado = Me.cboEstado.SelectedValue
                If MessageBox.Show("¿Desea registrar los datos de esta persona?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    If Me.txtTelefono.Text = "" Then
                        If Me.txtCelular.Text = "" Then
                            objPersonal = nPersonal.RegistrarSinTelefonoYCelular(objPersonal)
                        Else
                            objPersonal.celular = Me.txtCelular.Text.Trim
                            objPersonal = nPersonal.RegistrarSinTelefono(objPersonal)
                        End If
                    Else
                        objPersonal.telefono = Me.txtTelefono.Text.Trim
                        If Me.txtCelular.Text = "" Then
                            objPersonal = nPersonal.RegistrarSinCelular(objPersonal)
                        Else
                            objPersonal.celular = Me.txtCelular.Text.Trim
                            objPersonal = nPersonal.Registrar(objPersonal)
                        End If
                    End If
                    If Me.cboCargo.SelectedValue <> "A" Then
                        nPersonal.RegistrarAlmacen_Personal(objPersonal)
                    Else
                        Tabla = nAlmacen.Listar
                        For Each Fila As DataRow In Tabla.Rows
                            objPersonal.id_almacen = Fila.Item("id_almacen")
                           nPersonal.RegistrarAlmacen_Personal(objPersonal)
                        Next
                    End If
                    MessageBox.Show("Los datos se guardaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objPersonal.id_personal
                    Me.lblCodigo.Visible = True
                    Me.btnGrabar.Enabled = False
                    Me.btnNuevo.Enabled = True
                    Me.btnModificar.Enabled = True
                    Me.btnEliminar.Enabled = True
                    Me.btnModificar.Tag = "Modificar"
                    Habilitar(False)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Modificar()
        Try
            objPersonal.id_personal = Me.lblCodigo.Text.Trim
            objPersonal.nombres = Me.txtNombres.Text.Trim
            objPersonal.ap_paterno = Me.txtApellidoPat.Text.Trim
            objPersonal.ap_materno = Me.txtApellidoMat.Text.Trim
            objPersonal.dni = Me.txtDNI.Text.Trim
            objPersonal.cargo = Me.cboCargo.SelectedValue
            objPersonal.direccion = Me.txtDireccion.Text.Trim
            objPersonal.usuario = Me.txtUsuario.Text.Trim
            objPersonal.clave = Me.txtClave.Text.Trim
            objPersonal.estado = Me.cboEstado.SelectedValue
            If Me.txtTelefono.Text = "" Then
                If Me.txtCelular.Text = "" Then
                    nPersonal.ModificarSinTelefonoYCelular(objPersonal)
                Else
                    objPersonal.celular = Me.txtCelular.Text.Trim
                    nPersonal.ModificarSinTelefono(objPersonal)
                End If
            Else
                objPersonal.telefono = Me.txtTelefono.Text.Trim
                If Me.txtCelular.Text = "" Then
                    nPersonal.ModificarSinCelular(objPersonal)
                Else
                    objPersonal.celular = Me.txtCelular.Text.Trim
                    nPersonal.Modificar(objPersonal)
                End If
            End If
            Dim Cantidad As Integer
            Cantidad = nPersonal.ContraAlmacen_Personal(objPersonal)
            If Me.cboCargo.SelectedValue <> "A" And Cantidad <> 0 Then
                nPersonal.EliminarAlmacen_Personal(objPersonal.id_personal)
                nPersonal.RegistrarAlmacen_Personal(objPersonal)
            ElseIf Cantidad <> 0 Then
                nPersonal.EliminarAlmacen_Personal(objPersonal.id_personal)
                Tabla = nAlmacen.Listar
                For Each Fila As DataRow In Tabla.Rows
                    objPersonal.id_almacen = Fila.Item("id_almacen")
                    nPersonal.RegistrarAlmacen_Personal(objPersonal)
                Next
            End If
            MessageBox.Show("Los datos se actualizaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Si la modificación fue exitosa se actualiza al objeto temporal
            objPersonal.id_personal = Me.lblCodigo.Text
            objPersonal.nombres = Me.txtNombres.Text.Trim
            objPersonal.ap_paterno = Me.txtApellidoPat.Text.Trim
            objPersonal.ap_materno = Me.txtApellidoMat.Text.Trim
            objPersonal.dni = Me.txtDNI.Text.Trim
            objPersonal.cargo = Me.cboCargo.SelectedValue
            objPersonal.direccion = Me.txtDireccion.Text.Trim
            objPersonal.telefono = Me.txtTelefono.Text.Trim
            objPersonal.celular = Me.txtCelular.Text.Trim
            objPersonal.usuario = Me.txtUsuario.Text.Trim
            objPersonal.clave = Me.txtClave.Text.Trim
            objPersonal.estado = Me.cboEstado.SelectedValue

        Catch ex As Exception
            Throw
        End Try
    End Sub
    Sub Eliminar()
        Try

            If MessageBox.Show("¿Desea eliminar los datos de esta persona?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nPersonal.Eliminar(lblCodigo.Text)
                MessageBox.Show("Los datos se eliminaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Cargar()
        Try
            Dim Tabla As DataTable
            Me.lblCodigo.Text = objPersonal.id_personal
            Me.txtNombres.Text = objPersonal.nombres
            Me.txtApellidoPat.Text = objPersonal.ap_paterno
            Me.txtApellidoMat.Text = objPersonal.ap_materno
            Me.txtDNI.Text = objPersonal.dni
            Me.cboCargo.SelectedValue = objPersonal.cargo
            Me.txtDireccion.Text = objPersonal.direccion
            Me.txtTelefono.Text = objPersonal.telefono
            Me.txtCelular.Text = objPersonal.celular
            Me.txtUsuario.Text = objPersonal.usuario
            Me.txtClave.Text = objPersonal.clave
            Me.txtClave2.Text = objPersonal.clave
            Me.cboEstado.SelectedValue = objPersonal.estado
            Me.lblCodigo.Visible = True
            Tabla = nPersonal.ListarAlmacen_Personal(objPersonal.id_personal)
            For Each Fila As DataRow In Tabla.Rows
                objPersonal.id_almacen = Fila.Item("id_almacen")
            Next
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnGrabar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Habilitar(ByVal Estado As Boolean)
        Me.lblCodigo.Enabled = Estado
        Me.txtNombres.Enabled = Estado
        Me.txtApellidoPat.Enabled = Estado
        Me.txtApellidoMat.Enabled = Estado
        Me.txtDNI.Enabled = Estado
        Me.cboCargo.Enabled = Estado
        Me.txtDireccion.Enabled = Estado
        Me.txtTelefono.Enabled = Estado
        Me.txtCelular.Enabled = Estado
        Me.cboEstado.Enabled = Estado
        Me.txtUsuario.Enabled = Estado
        Me.txtClave.Enabled = Estado
        Me.txtClave2.Enabled = Estado
        Me.btnPermisos.Enabled = Estado
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        Me.lblCodigo.Visible = False
        Me.lblCodigo.Text = ""
        Me.txtNombres.Text = ""
        Me.txtApellidoPat.Text = ""
        Me.txtApellidoMat.Text = ""
        Me.txtDNI.Text = ""
        Me.cboCargo.SelectedValue = "0"
        Me.txtDireccion.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtCelular.Text = ""
        Me.txtUsuario.Text = ""
        Me.txtClave.Text = ""
        Me.txtClave2.Text = ""
        Me.cboEstado.SelectedValue = "A"
        Me.btnNuevo.Enabled = True


        Me.btnGrabar.Tag = "Grabar"
        Me.btnGrabar.Enabled = True

        Me.btnModificar.Enabled = False

        Me.btnEliminar.Enabled = False

        ' LÓGICA PERMISOS -------------------------------------------------
        Dim Permiso As Personal_SubMenu = CType(Me.Tag, Personal_SubMenu)
        Me.btnGrabar.Visible = Permiso.nuevo
        Me.btnModificar.Visible = Permiso.modificar
        Me.btnEliminar.Visible = Permiso.eliminar
        Me.btnBuscar.Visible = Permiso.buscar
        ' -----------------------------------------------------------------

        Me.txtNombres.Focus()
    End Sub
    Sub LlenaCombos()
        Try
            Dim Cargo As New DataTable
            Cargo.Columns.Add("ID")
            Cargo.Columns.Add("VALOR")
            Cargo.Rows.Add("0", "Elija una opción")
            Cargo.Rows.Add("A", "Administrador")
            Cargo.Rows.Add("V", "Vendedor")
            Me.cboCargo.DataSource = Cargo
            Me.cboCargo.ValueMember = "ID"
            Me.cboCargo.DisplayMember = "VALOR"
            Me.cboCargo.SelectedValue = "0"

            Dim Estado As New DataTable
            Estado.Columns.Add("ID")
            Estado.Columns.Add("VALOR")
            Estado.Rows.Add("A", "Activo")
            Estado.Rows.Add("C", "Cesante")
            Estado.Rows.Add("V", "Vacaciones")
            Me.cboEstado.DataSource = Estado
            Me.cboEstado.ValueMember = "ID"
            Me.cboEstado.DisplayMember = "VALOR"
            Me.cboEstado.SelectedValue = "A"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress, txtApellidoPat.KeyPress, txtApellidoMat.KeyPress, txtUsuario.KeyPress
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

    Sub validaClave_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress, txtClave2.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress, txtCelular.KeyPress, txtDNI.KeyPress
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
    Function Valida() As Boolean
        Dim TextoError As String = ""
        If Me.txtNombres.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un nombre." & vbCrLf
        End If
        If Me.txtApellidoPat.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un apellido paterno." & vbCrLf
        End If
        If Me.txtDNI.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un DNI." & vbCrLf
        End If
        If Me.txtDireccion.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar una dirección." & vbCrLf
        End If
        If Me.cboCargo.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una cargo." & vbCrLf
        End If
        If Me.txtUsuario.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un usuario." & vbCrLf
        End If
        If Me.txtClave.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un clave." & vbCrLf
        End If
        If Me.txtClave2.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar dos veces la clave." & vbCrLf
        End If
        If Me.txtClave.Text.Trim <> Me.txtClave2.Text.Trim Then
            TextoError = TextoError & "- Las claves no coinciden." & vbCrLf
        End If
        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
End Class