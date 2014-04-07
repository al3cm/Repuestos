Imports Entidades
Imports Reglas_Negocio
Public Class frmVehiculo
    Dim objVehiculo As New Vehiculo
    Dim nVehiculo As New RNVehiculo


    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------

    Private Sub frmVehiculo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub
    Private Sub frmVehiculo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    'Sub LlenaCombos()
    '    Try
    '        Dim Clientes As DataTable = RNCliente.Listar
    '        Me.cboCliente.ValueMember = "id_cliente"
    '        Me.cboCliente.DisplayMember = "razon_social"
    '        If Clientes.Rows.Count > 0 Then
    '            Me.cboCliente.DataSource = Clientes
    '        Else
    '            Clientes.Rows.Add("0", "No hay clientes registrados")
    '            Me.cboCliente.DataSource = Clientes
    '            Me.cboCliente.SelectedValue = "0"
    '            Me.btnGrabar.Enabled = False
    '        End If
    '    Catch ex As Exception
    '         MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If frmListarVehiculo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objVehiculo = frmListarVehiculo.objVehiculo
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
                'Modified 2014.03.23
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
                objVehiculo.id_cliente = Me.cboCliente.SelectedValue
                objVehiculo.placa = Me.txtPlaca.Text.Trim
                objVehiculo.id_marca = Me.cboMarca.SelectedValue
                ' objVehiculo.marca = Me.cboMarca.SelectedValue
                objVehiculo.modelo = Me.txtModelo.Text.Trim
                objVehiculo.tipo_vehiculo = Me.cbotipo_vehiculo.SelectedValue

                If MessageBox.Show("¿Desea registrar los datos de este vehiculo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objVehiculo = nVehiculo.Registrar(objVehiculo)
                    MessageBox.Show("Los datos se guardaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objVehiculo.id_vehiculo
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
            'Modified 2014.03.23



            nVehiculo.Modificar(New Vehiculo(CInt(Me.lblCodigo.Text), CInt(Me.cboCliente.SelectedValue), CInt(Me.cboMarca.SelectedValue), Me.txtPlaca.Text.Trim, Me.txtModelo.Text.Trim, Me.cbotipo_vehiculo.SelectedValue))
            MessageBox.Show("Los datos se actualizaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            objVehiculo.id_vehiculo = Me.lblCodigo.Text
            objVehiculo.id_cliente = Me.cboCliente.SelectedValue
            objVehiculo.id_marca = Me.cboMarca.SelectedValue
            'objVehiculo.marca = Me.cboMarca.SelectedValue
            objVehiculo.placa = Me.txtPlaca.Text.Trim
            objVehiculo.modelo = Me.txtModelo.Text.Trim
            objVehiculo.tipo_vehiculo = Me.cbotipo_vehiculo.SelectedValue

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Eliminar()
        Try

            If MessageBox.Show("¿Desea eliminar los datos de este vehiculo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nVehiculo.Eliminar(lblCodigo.Text)
                MessageBox.Show("Los datos se eliminaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Cargar()
        Try

            Me.lblCodigo.Text = objVehiculo.id_vehiculo
            Me.cboCliente.SelectedValue = objVehiculo.id_cliente
            Me.txtPlaca.Text = objVehiculo.placa
            Me.cboMarca.SelectedValue = objVehiculo.id_marca
            'Me.cboMarca.SelectedValue = objVehiculo.marca
            Me.txtModelo.Text = objVehiculo.modelo
            Me.cbotipo_vehiculo.SelectedValue = objVehiculo.tipo_vehiculo
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
        Me.cboMarca.Enabled = Estado
        Me.txtModelo.Enabled = Estado
        Me.txtPlaca.Enabled = Estado
        Me.cbotipo_vehiculo.Enabled = Estado
        Me.cboCliente.Enabled = Estado
    End Sub

    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        Me.lblCodigo.Visible = False
        Me.lblCodigo.Text = ""
        'Me.txtMarca.Text = ""
        Me.txtModelo.Text = ""
        Me.txtPlaca.Text = ""
        'Me.cboSucursal.SelectedValue = ""
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

        Me.cboCliente.Focus()
    End Sub

    Sub LlenaCombos()
        Try
            Dim Tipo_Vehiculo As New DataTable

            Tipo_Vehiculo.Columns.Add("ID")
            Tipo_Vehiculo.Columns.Add("VALOR")
            Tipo_Vehiculo.Rows.Add("0", "Elija una opción")
            Tipo_Vehiculo.Rows.Add("GAS", "GAS")
            Tipo_Vehiculo.Rows.Add("GASO", "GASOLINA")
            Tipo_Vehiculo.Rows.Add("PETRO", "PETROLEO")
            Me.cbotipo_vehiculo.DataSource = Tipo_Vehiculo
            Me.cbotipo_vehiculo.ValueMember = "ID"
            Me.cbotipo_vehiculo.DisplayMember = "VALOR"
            Me.cbotipo_vehiculo.SelectedValue = "0"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            Dim Clientes As DataTable = RNCliente.Listar
            Me.cboCliente.ValueMember = "id_cliente"
            Me.cboCliente.DisplayMember = "razon_social"
            If Clientes.Rows.Count > 0 Then
                Me.cboCliente.DataSource = Clientes
            Else
                Clientes.Rows.Add("0", "No hay clientes registrados")
                Me.cboCliente.DataSource = Clientes
                Me.cboCliente.SelectedValue = "0"
                Me.btnGrabar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            Dim Marcas As DataTable = RNMarca.Listar
            Me.cboMarca.ValueMember = "id_marca"
            Me.cboMarca.DisplayMember = "descripcion"
            If Marcas.Rows.Count > 0 Then
                Me.cboMarca.DataSource = Marcas
            Else
                Marcas.Rows.Add("0", "No hay marcas registradas")
                Me.cboMarca.DataSource = Marcas
                Me.cboMarca.SelectedValue = "0"
                Me.btnGrabar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Function Valida() As Boolean
        Dim TextoError As String = ""
        If Me.cboMarca.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una marca." & vbCrLf
        End If
        If Me.txtModelo.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un modelo." & vbCrLf
        End If
        If Me.txtPlaca.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar una placa." & vbCrLf
        End If
        If Me.cbotipo_vehiculo.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar un tipo de vehiculo." & vbCrLf
        End If
        If Me.cboCliente.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar un cliente." & vbCrLf
        End If
        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function
End Class