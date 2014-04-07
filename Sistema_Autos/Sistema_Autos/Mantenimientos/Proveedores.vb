'alejandro
Imports Entidades
Imports Reglas_Negocio
Public Class frmProveedores
    Dim objProveedor As New Proveedor
    Dim nProveedor As New RNProveedor


    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------

    Private Sub frmProveedores_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub
    Private Sub frmProveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Sub LlenaCombos()
        Try
            Dim Ubigeos As DataTable = RNUbigeo.Listar
            Me.cboubigeo.ValueMember = "id_ubigeo"
            Me.cboubigeo.DisplayMember = "Descripcion"
            Me.cboubigeo.DataSource = Ubigeos
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub cboubigeo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboubigeo.SelectedIndexChanged
        If Me.cboubigeo.SelectedValue <> "" Then
            Me.CboProvician.Enabled = True
            Try
                Dim Ubigeos As DataTable = RNUbigeo.Listar(cboubigeo.SelectedValue)
                Me.CboProvician.ValueMember = "id_ubigeo"
                Me.CboProvician.DisplayMember = "Descripcion"
                Me.CboProvician.DataSource = Ubigeos
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub CboProvician_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboProvician.SelectedIndexChanged
        If Me.CboProvician.SelectedValue <> "" Then
            Me.CboDistritro.Enabled = True
            Try
                Dim Ubigeos As DataTable = RNUbigeo.Listar(CboProvician.SelectedValue)
                Me.CboDistritro.ValueMember = "id_ubigeo"
                Me.CboDistritro.DisplayMember = "Descripcion"
                Me.CboDistritro.DataSource = Ubigeos
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If frmListarProveedores.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objProveedor = frmListarProveedores.objProveedor
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


    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
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
                btnBuscar.Enabled = False
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
                objProveedor.id_ubigeo = Me.CboDistritro.SelectedValue
                objProveedor.razon_social = Me.txtrazon_social.Text.Trim
                objProveedor.ruc = Me.txtruc.Text.Trim
                objProveedor.direccion = Me.txtdireccion.Text.Trim
                objProveedor.telefono = Me.txttelefono.Text.Trim
                objProveedor.fax = Me.txtfax.Text.Trim
                objProveedor.contacto = Me.txtcontacto.Text.Trim
                objProveedor.email = Me.txtemail.Text.Trim
                objProveedor.descripcion = Me.txtdescripcion.Text.Trim
                ''ME FALTA EL CHKESTADO :D
                objProveedor.estado = Me.chkestado_proveedor.Checked
                If MessageBox.Show("¿Desea registrar los datos de este proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objProveedor = nProveedor.Registrar(objProveedor)
                    MessageBox.Show("Los datos se guardaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objProveedor.id_proveedor
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

            'temporal creado para evitar equivocarse al enviar un constructor
            Dim objTemporal As Proveedor = objProveedor
            objTemporal.id_proveedor = Me.lblCodigo.Text
            objTemporal.id_ubigeo = Me.CboDistritro.SelectedValue
            objTemporal.razon_social = Me.txtrazon_social.Text.Trim
            objTemporal.ruc = Me.txtruc.Text.Trim
            objTemporal.direccion = Me.txtdireccion.Text.Trim
            objTemporal.telefono = Me.txttelefono.Text.Trim
            objTemporal.fax = Me.txtfax.Text.Trim
            objTemporal.contacto = Me.txtcontacto.Text.Trim
            objTemporal.email = Me.txtemail.Text.Trim
            objTemporal.descripcion = Me.txtdescripcion.Text.Trim
            objTemporal.estado = Me.chkestado_proveedor.Checked



            nProveedor.Modificar(objTemporal)
            MessageBox.Show("Los datos se actualizaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Si la modificación fue exitosa se actualiza al objeto temporal del formulario

            objProveedor.id_proveedor = Me.lblCodigo.Text
            objProveedor.id_ubigeo = Me.CboDistritro.SelectedValue
            objProveedor.razon_social = Me.txtrazon_social.Text.Trim
            objProveedor.ruc = Me.txtruc.Text.Trim
            objProveedor.direccion = Me.txtdireccion.Text.Trim
            objProveedor.telefono = Me.txttelefono.Text.Trim
            objProveedor.fax = Me.txtfax.Text.Trim
            objProveedor.contacto = Me.txtcontacto.Text.Trim
            objProveedor.email = Me.txtemail.Text.Trim
            objProveedor.descripcion = Me.txtdescripcion.Text.Trim
            objProveedor.estado = Me.chkestado_proveedor.Checked


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Eliminar()
        Try

            If MessageBox.Show("¿Desea eliminar los datos de este almacen?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nProveedor.Eliminar(lblCodigo.Text)
                MessageBox.Show("Los datos se eliminaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Cargar()
        Try
            Me.lblCodigo.Text = objProveedor.id_proveedor
            'Added 2014.03.23 ------------------------------------------
            Me.cboubigeo.SelectedValue = objProveedor.id_ubigeo.ToString.Substring(0, 2) & "0000"
            Me.CboProvician.SelectedValue = objProveedor.id_ubigeo.ToString.Substring(0, 4) & "00"
            Me.CboDistritro.SelectedValue = objProveedor.id_ubigeo.ToString
            '-----------------------------------------------------------
            Me.txtrazon_social.Text = objProveedor.razon_social
            Me.txtruc.Text = objProveedor.ruc
            Me.txtdireccion.Text = objProveedor.direccion
            Me.txttelefono.Text = objProveedor.telefono
            Me.txtfax.Text = objProveedor.fax
            Me.txtcontacto.Text = objProveedor.contacto
            Me.txtemail.Text = objProveedor.email
            Me.txtdescripcion.Text = objProveedor.descripcion
            Me.chkestado_proveedor.Checked = objProveedor.estado
            Me.lblCodigo.Visible = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnGrabar.Enabled = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Habilitar(ByVal Estado As Boolean)
        Me.lblCodigo.Enabled = Estado
        Me.txtrazon_social.Enabled = Estado
        Me.txtruc.Enabled = Estado
        Me.txtdireccion.Enabled = Estado
        Me.txttelefono.Enabled = Estado
        Me.txtfax.Enabled = Estado
        Me.txtcontacto.Enabled = Estado
        Me.txtemail.Enabled = Estado
        Me.txtdescripcion.Enabled = Estado
        Me.chkestado_proveedor.Enabled = Estado
        Me.cboubigeo.Enabled = Estado
        'Added 2014.03.22
        Me.CboDistritro.Enabled = Estado
        Me.CboProvician.Enabled = Estado
    End Sub

    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        Me.lblCodigo.Visible = False
        Me.lblCodigo.Text = ""
        Me.txtdescripcion.Text = ""
        Me.txtrazon_social.Text = ""
        Me.txtruc.Text = ""
        Me.txtdireccion.Text = ""
        Me.txttelefono.Text = ""
        Me.txtfax.Text = ""
        Me.txtcontacto.Text = ""
        Me.txtemail.Text = ""
        Me.btnNuevo.Enabled = True
        Me.btnGrabar.Tag = "Grabar"
        Me.btnGrabar.Enabled = True
        Me.btnModificar.Enabled = False
        Me.btnEliminar.Enabled = False
        Me.cboubigeo.SelectedValue = "010000" 'Added 2014.03.23
        Me.CboProvician.Enabled = False
        Me.CboDistritro.Enabled = False

        ' LÓGICA PERMISOS -------------------------------------------------
        Dim Permiso As Personal_SubMenu = CType(Me.Tag, Personal_SubMenu)
        Me.btnGrabar.Visible = Permiso.nuevo
        Me.btnModificar.Visible = Permiso.modificar
        Me.btnEliminar.Visible = Permiso.eliminar
        Me.btnBuscar.Visible = Permiso.buscar
        ' -----------------------------------------------------------------

        Me.txtrazon_social.Focus()
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress, txtrazon_social.KeyPress, txtcontacto.KeyPress
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

    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress, txtfax.KeyPress, txtruc.KeyPress
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
        If Me.txtrazon_social.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar una razon social." & vbCrLf
        End If
        If Me.txtruc.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un ruc." & vbCrLf
        End If
        If Me.txtdireccion.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar una direccion." & vbCrLf
        End If
        If Me.txttelefono.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un telefono." & vbCrLf
        End If
        'If Me.txtfax.Text.Trim = "" Then
        '    TextoError = TextoError & "- Debe ingresar un fax." & vbCrLf
        'End If
        If Me.txtcontacto.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un contacto." & vbCrLf
        End If
        If Me.txtemail.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un email." & vbCrLf
        End If
        'If Me.txtdescripcion.Text.Trim = "" Then
        '    TextoError = TextoError & "- Debe ingresar una descripcion." & vbCrLf
        'End If
        If Me.cboubigeo.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una sucursal." & vbCrLf
        End If
        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
End Class