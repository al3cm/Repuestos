﻿Imports Entidades
Imports Reglas_Negocio
Public Class frmClientes
    Dim objCliente As New Cliente
    Dim nCliente As New RNCliente
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If frmListarClientes.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objCliente = frmListarClientes.objCliente
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

    'Added 2014.03.22
    Private Sub frmClientes_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub


    Private Sub frmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ' LÓGICA PERMISOS -------------------------------------------------
            Me.Tag = RNPersonalSubMenu.ListarPersonalSubMenu(CType(Me.Tag, Personal_SubMenu).id_menu, CType(Me.Tag, Personal_SubMenu).id_submenu, CType(Me.Tag, Personal_SubMenu).id_personal)
            If Me.Tag Is Nothing Then
                MessageBox.Show("Error al asignar archivos, consulte con el Administrador del Sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    If MessageBox.Show("¿Desea modificar los datos del cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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

    Private Sub cbotipo_cliente_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbotipo_cliente.SelectedIndexChanged
        ' esta operación siempre generará excepción al iniciar el formulario por eso tiene un try sin messagebox
        Try
            If Me.cbotipo_cliente.SelectedValue = "J" Then
                Me.txtdni.Enabled = False
                Me.txtruc.Enabled = True
            ElseIf Me.cbotipo_cliente.SelectedValue = "N" Then
                Me.txtdni.Enabled = True
                Me.txtruc.Enabled = False
            Else
                Me.txtdni.Enabled = True
                Me.txtruc.Enabled = True
            End If

        Catch ex As Exception

        End Try

    End Sub

    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    Sub Grabar()
        Try

            If Valida() Then
                objCliente.razon_social = Me.txtrazon_social.Text.Trim
                objCliente.ruc = Me.txtruc.Text.Trim
                objCliente.dni = Me.txtdni.Text.Trim
                objCliente.direccion = Me.txtdireccion.Text.Trim
                objCliente.telefono = Me.txttelefono.Text.Trim
                objCliente.celular = Me.txtcelular.Text.Trim
                objCliente.estado = Me.cboEstado.SelectedValue
                objCliente.tipo_cliente = Me.cbotipo_cliente.SelectedValue

                If MessageBox.Show("¿Desea registrar los datos del cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objCliente = nCliente.Registrar(objCliente)
                    MessageBox.Show("Los datos se guardaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objCliente.id_cliente
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
            'Modified 2014.03.22
            nCliente.Modificar(New Cliente(CInt(Me.lblCodigo.Text), Me.txtrazon_social.Text.Trim, Me.txtruc.Text.Trim, Me.txtdni.Text.Trim, Me.txtdireccion.Text.Trim, Me.txttelefono.Text.Trim, Me.txtcelular.Text.Trim, Me.cboEstado.SelectedValue, Me.cbotipo_cliente.SelectedValue))
            MessageBox.Show("Los datos se actualizaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Si la modificación fue exitosa se actualiza al objeto temporal
            objCliente.id_cliente = Me.lblCodigo.Text
            objCliente.razon_social = Me.txtrazon_social.Text.Trim
            objCliente.ruc = Me.txtruc.Text.Trim
            objCliente.dni = Me.txtdni.Text.Trim
            objCliente.direccion = Me.txtdireccion.Text.Trim
            objCliente.telefono = Me.txttelefono.Text.Trim
            objCliente.celular = Me.txtcelular.Text.Trim
            objCliente.estado = Me.cboEstado.SelectedValue
            objCliente.tipo_cliente = Me.cbotipo_cliente.SelectedValue

        Catch ex As Exception
            Throw
        End Try
    End Sub

    Sub Eliminar()
        Try

            If MessageBox.Show("¿Desea eliminar los datos de este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nCliente.Eliminar(lblCodigo.Text)
                MessageBox.Show("Los datos se eliminaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Cargar()
        Try

            Me.lblCodigo.Text = objCliente.id_cliente
            Me.txtrazon_social.Text = objCliente.razon_social
            Me.txtruc.Text = objCliente.ruc
            Me.txtdni.Text = objCliente.dni
            Me.txtdireccion.Text = objCliente.direccion
            Me.txttelefono.Text = objCliente.telefono
            Me.txtcelular.Text = objCliente.celular
            Me.cboEstado.SelectedValue = objCliente.estado
            Me.cbotipo_cliente.SelectedValue = objCliente.tipo_cliente
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
        Me.txtdireccion.Enabled = Estado
        Me.txtruc.Enabled = Estado
        Me.txtdni.Enabled = Estado
        Me.txttelefono.Enabled = Estado
        Me.txtcelular.Enabled = Estado
        Me.cboEstado.Enabled = Estado
        Me.cbotipo_cliente.Enabled = Estado
    End Sub

    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        Me.lblCodigo.Visible = False
        Me.lblCodigo.Text = ""
        Me.txtrazon_social.Text = ""
        Me.txtruc.Text = ""
        Me.txtdni.Text = ""
        Me.cbotipo_cliente.SelectedValue = "0"
        Me.txtdireccion.Text = ""
        Me.txttelefono.Text = ""
        Me.txtcelular.Text = ""
        Me.cboEstado.SelectedValue = "H"
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

        Me.txtrazon_social.Focus()
    End Sub

    Sub LlenaCombos()
        Try
            Dim Tipo_Cliente As New DataTable

            Tipo_Cliente.Columns.Add("ID")
            Tipo_Cliente.Columns.Add("VALOR")
            Tipo_Cliente.Rows.Add("0", "Elija una opción")
            Tipo_Cliente.Rows.Add("J", "Juridica")
            Tipo_Cliente.Rows.Add("N", "Natural")
            Me.cbotipo_cliente.DataSource = Tipo_Cliente
            Me.cbotipo_cliente.ValueMember = "ID"
            Me.cbotipo_cliente.DisplayMember = "VALOR"
            Me.cbotipo_cliente.SelectedValue = "0"


            Dim Estado As New DataTable
            Estado.Columns.Add("ID")
            Estado.Columns.Add("VALOR")
            Estado.Rows.Add("H", "Habilitado")
            Estado.Rows.Add("D", "Deshabilitado")
            Me.cboEstado.DataSource = Estado
            Me.cboEstado.ValueMember = "ID"
            Me.cboEstado.DisplayMember = "VALOR"
            Me.cboEstado.SelectedValue = "H"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtrazon_social.KeyPress
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

    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txttelefono.KeyPress, txtcelular.KeyPress, txtdni.KeyPress, txtruc.KeyPress
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
            TextoError = TextoError & "- Debe ingresar una razón social." & vbCrLf
        End If
        If txtdni.Text = "" And txtdni.Enabled = True Then
            TextoError = TextoError & "- Debe ingresar un numero de dni." & vbCrLf
        End If
        If txtruc.Text = "" And txtruc.Enabled = True Then
            TextoError = TextoError & "- Debe ingresar un numero de ruc." & vbCrLf
        End If
        'If txtdni.Text = "" And txtdni.Enabled = True Then
        '    TextoError = TextoError & "- Debe ingresar un numero de ruc." & vbCrLf
        'Else
        '    TextoError = TextoError & "- Debe ingresar un numero de dni." & vbCrLf
        'End If
        ''If Me.txtruc.Text.Trim = "" Then
        ''    TextoError = TextoError & "- Debe ingresar un numero de ruc." & vbCrLf
        ''End If
        ''If Me.txtdni.Text.Trim = "" Then
        ''    TextoError = TextoError & "- Debe ingresar un DNI." & vbCrLf
        ''End If
        If Me.txtdireccion.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar una dirección." & vbCrLf
        End If
        'If Me.txttelefono.Text.Trim = "" Then
        '    TextoError = TextoError & "- Debe ingresar un telefóno." & vbCrLf
        'End If
        'If Me.txtcelular.Text.Trim = "" Then
        '    TextoError = TextoError & "- Debe ingresar un celular." & vbCrLf
        'End If
        If Me.cboEstado.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar un estado del cliente." & vbCrLf
        End If

        If Me.cbotipo_cliente.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar un tipo de cliente." & vbCrLf
        End If

        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function




  
End Class