Imports Entidades
Imports Reglas_Negocio
Public Class frmAlmacen
    Dim objPersonal As New Personal
    Dim objCodigo_Facturacion As New Codigo_Facturacion
    Dim objPrecio As New Precio
    Dim objProducto_Almacen As New Producto_Almacen
    Dim objDetalle_Caja As New Detalle_Caja
    Dim objAlmacen As New Almacen
    Dim nAlmacen As New RNAlmacen
    Dim nDetalle_Caja As New RNDetalle_Caja
    Dim nProducto_Almacen As New RNProducto_Almacen
    Dim nPrecio As New RNPrecio
    Dim nCodigo_Facturacion As New RNCodigo_Facturacion
    Dim nPersonal As New RNPersonal
    Dim nProducto As New RNProducto
    Dim Tabla As DataTable
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmAlmacen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub

    Private Sub frmAlmacen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            Dim Sucursales As DataTable = RNSucursal.Listar
            Me.cboSucursal.ValueMember = "id_sucursal"
            Me.cboSucursal.DisplayMember = "descripcion"
            If Sucursales.Rows.Count > 0 Then
                Me.cboSucursal.DataSource = Sucursales
            Else
                Sucursales.Rows.Add("0", "No hay sucursales registradas")
                Me.cboSucursal.DataSource = Sucursales
                Me.cboSucursal.SelectedValue = "0"
                Me.btnGrabar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If frmListarAlmacen.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objAlmacen = frmListarAlmacen.objAlmacen
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
                If nCodigo_Facturacion.Contra(Me.TxtCodigo.Text.ToString) = 0 Then
                    objAlmacen.id_sucursal = Me.cboSucursal.SelectedValue
                    objAlmacen.descripcion = Me.txtdescripcion.Text.Trim
                    If MessageBox.Show("¿Desea registrar los datos de este almacen?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        objAlmacen = nAlmacen.Registrar(objAlmacen)
                        Tabla = nDetalle_Caja.ListarCaja
                        For Each Fila As DataRow In Tabla.Rows
                            objDetalle_Caja.id_caja = Fila.Item("id_caja")
                            objDetalle_Caja.caja = Fila.Item("nombre_caja")
                            objDetalle_Caja.id_almacen = objAlmacen.id_almacen
                            objDetalle_Caja.descripcion = objDetalle_Caja.caja & " " & objAlmacen.descripcion
                            nDetalle_Caja.RegistrarDetalle_Caja(objDetalle_Caja)
                        Next
                        Tabla = nProducto.Listar
                        For Each Fila As DataRow In Tabla.Rows
                            objProducto_Almacen.id_almacen = objAlmacen.id_almacen
                            objProducto_Almacen.id_producto = Fila.Item("id_producto")
                            objProducto_Almacen.descripcion = "El producto " & Fila.Item("nombre_producto") & " esta en Almacen " & objAlmacen.descripcion
                            nProducto_Almacen.RegistrarProducto_Almacen(objProducto_Almacen)
                            objPrecio.id_producto = Fila.Item("id_producto")
                            objPrecio.id_almacen = objAlmacen.id_almacen
                            objPrecio.precio_compra = Fila.Item("precio_compra")
                            objPrecio.precio_venta = Fila.Item("precio_venta")
                            objPrecio.precio_trajecta = objPrecio.precio_venta * Cambio_Trajecta
                            nPrecio.RegistrarPrecio(objPrecio)
                        Next
                        objCodigo_Facturacion.id_Codigo = Me.TxtCodigo.Text.ToString
                        objCodigo_Facturacion.id_almacen = objAlmacen.id_almacen
                        nCodigo_Facturacion.Registrar(objCodigo_Facturacion)
                        MessageBox.Show("Los datos se guardaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.lblCodigo.Text = objAlmacen.id_almacen
                        Me.lblCodigo.Visible = True
                        Me.btnGrabar.Enabled = False
                        Me.btnNuevo.Enabled = True
                        Me.btnModificar.Enabled = True
                        Me.btnEliminar.Enabled = True
                        Me.btnModificar.Tag = "Modificar"
                        Habilitar(False)
                    End If
                Else
                    MessageBox.Show("El Codigo de Facturacion Ya esta Reguitada.")
                End If
                Tabla = nPersonal.Listar()
                For Each Fila As DataRow In Tabla.Rows
                    objPersonal.cargo = Fila.Item("cargo")
                    If objPersonal.cargo = "A" Then
                        objPersonal.id_personal = Fila.Item("id_personal")
                        objPersonal.id_almacen = objAlmacen.id_almacen
                        nPersonal.RegistrarAlmacen_Personal(objPersonal)
                    End If
                Next
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Modificar()
        Try
            'Modified 2014.03.24
            nAlmacen.Modificar(New Almacen(CInt(Me.lblCodigo.Text), CInt(Me.cboSucursal.SelectedValue), Me.txtdescripcion.Text.Trim))
            Tabla = nDetalle_Caja.ListarCaja
            For Each Fila As DataRow In Tabla.Rows
                objDetalle_Caja.id_caja = Fila.Item("id_caja")
                objDetalle_Caja.caja = Fila.Item("nombre_caja")
                objDetalle_Caja.id_almacen = Me.lblCodigo.Text
                objDetalle_Caja.descripcion = objDetalle_Caja.caja & " " & Me.txtdescripcion.Text.Trim
                nDetalle_Caja.ModificarDetalle_Caja(objDetalle_Caja)
            Next
            Tabla = nProducto.Listar
            For Each Fila As DataRow In Tabla.Rows
                objProducto_Almacen.id_almacen = Me.lblCodigo.Text
                objProducto_Almacen.id_producto = Fila.Item("id_producto")
                objProducto_Almacen.descripcion = "El producto " & Fila.Item("nombre_producto") & " esta en Almacen " & Me.txtdescripcion.Text.Trim
                nProducto_Almacen.ModificarProducto_Almacen(objProducto_Almacen)
            Next
            If nCodigo_Facturacion.Contra(Me.TxtCodigo.Text.ToString) = 0 Then
                objCodigo_Facturacion.id_Codigo = Me.TxtCodigo.Text.ToString
                objCodigo_Facturacion.id_almacen = Me.lblCodigo.Text
                nCodigo_Facturacion.Registrar(objCodigo_Facturacion)
            End If
            MessageBox.Show("Los datos se actualizaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Si la modificación fue exitosa se actualiza al objeto temporal

            objAlmacen.id_almacen = Me.lblCodigo.Text
            objAlmacen.id_sucursal = Me.cboSucursal.SelectedValue
            objAlmacen.descripcion = Me.txtdescripcion.Text.Trim

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub Eliminar()
        Try

            If MessageBox.Show("¿Desea eliminar los datos de este almacen?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nDetalle_Caja.Eliminar(lblCodigo.Text)
                nProducto_Almacen.Eliminar(lblCodigo.Text)
                nPrecio.Eliminar(lblCodigo.Text)
                nAlmacen.Eliminar(lblCodigo.Text)
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
            Me.lblCodigo.Text = objAlmacen.id_almacen
            Me.cboSucursal.SelectedValue = objAlmacen.id_sucursal
            Me.txtdescripcion.Text = objAlmacen.descripcion
            Me.lblCodigo.Visible = True
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            btnGrabar.Enabled = False
            Tabla = nCodigo_Facturacion.Listar(objAlmacen.id_almacen)
            For Each Fila As DataRow In Tabla.Rows
                Me.TxtCodigo.Text = Fila.Item("id_Codigo")
                TxtCodigo.Enabled = False
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Habilitar(ByVal Estado As Boolean)
        Me.lblCodigo.Enabled = Estado
        Me.txtdescripcion.Enabled = Estado
        Me.cboSucursal.Enabled = Estado
        Me.TxtCodigo.Enabled = Estado
    End Sub

    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        Me.lblCodigo.Visible = False
        Me.lblCodigo.Text = ""
        Me.txtdescripcion.Text = ""
        Me.TxtCodigo.Text = ""
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

        Me.cboSucursal.Focus()
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Sub validaTexto_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdescripcion.KeyPress
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
    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
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
        If Me.txtdescripcion.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar una descripcion." & vbCrLf
        End If
        If Me.cboSucursal.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una sucursal." & vbCrLf
        End If
        If Me.TxtCodigo.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un Codigo de Facturacion." & vbCrLf
        End If
        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function

End Class