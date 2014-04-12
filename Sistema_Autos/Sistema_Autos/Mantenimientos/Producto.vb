Imports Entidades
Imports Reglas_Negocio
Imports System.Drawing.Imaging
Imports System.IO
Public Class frmProducto
    Dim objPrecio As New Precio
    Dim objProducto_Almacen As New Producto_Almacen
    Dim objProducto As New Producto
    Dim nProducto As New RNProducto
    Dim nProducto_Almacen As New RNProducto_Almacen
    Dim nAlmacen As New RNAlmacen
    Dim nPrecio As New RNPrecio
    Dim Tabla As DataTable
    'imagen
    'Public RUTA As String
    'Public x As String
    'Public destino As String
    'Public BorraFoto As String
    'Public opro As String
    '---------------------------------------------
    '-----------------EVENTOS
    '---------------------------------------------
    Private Sub frmProducto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Limpiar()
    End Sub

    Private Sub frmProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Try
            Dim Unidades As DataTable = RNUnidad.Listar
            Me.cboUnidad.ValueMember = "id_unidad"
            Me.cboUnidad.DisplayMember = "abreviatura"
            If Unidades.Rows.Count > 0 Then
                Me.cboUnidad.DataSource = Unidades
            Else
                Unidades.Rows.Add("0", "No hay unidades registradas")
                Me.cboUnidad.DataSource = Unidades
                Me.cboUnidad.SelectedValue = "0"
                Me.btnGrabar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Try
            Dim Lineas As DataTable = RNLinea.Listar
            Me.cboLinea.ValueMember = "id_linea"
            Me.cboLinea.DisplayMember = "descripcion"
            If Lineas.Rows.Count > 0 Then
                Me.cboLinea.DataSource = Lineas
            Else
                Lineas.Rows.Add("0", "No hay lineas registradas")
                Me.cboLinea.DataSource = Lineas
                Me.cboLinea.SelectedValue = "0"
                Me.btnGrabar.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If frmListarProducto.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.objProducto = frmListarProducto.objProducto
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
                If Valida() Then
                    If MessageBox.Show("¿Desea modificar los datos de este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
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
                objProducto.id_marca = Me.cboMarca.SelectedValue
                objProducto.id_linea = Me.cboLinea.SelectedValue
                objProducto.id_unidad = Me.cboUnidad.SelectedValue
                objProducto.nombre_producto = Me.txtNombre_producto.Text.Trim
                objProducto.codigo_producto = Me.txtCodigo_producto.Text.Trim
                objProducto.modelo_producto = Me.txtmodelo_producto.Text.Trim
                objProducto.numero_comprobante = Me.txtComprobante.Text.Trim
                objProducto.precio_compra = Me.txtPrecio_compra.Text.Trim
                objProducto.precio_venta = Me.txtPrecio_venta.Text.Trim
                objProducto.descripcion = Me.txtdescripcion.Text.Trim
                objProducto.estado = Me.chkestado_producto.Checked
                'imagen
                'If rbFoto.Checked = True Then
                '    destino = x
                'Else
                '    RUTA = OPF.SafeFileName.ToString()
                '    pbProducto.ImageLocation = RUTA
                '    Dim pic As New Bitmap(RUTA)
                '    destino = "C:\Users\Ing. Dennis Estela Z\Documents\Javi\300314\270314\Proyecto VS\Sistema_Autos\Fotos\productos\\"
                '    pic.Save(destino)
                '    pbProducto.SizeMode = PictureBoxSizeMode.Zoom
                'End If
                'Imagen
                If MessageBox.Show("¿Desea registrar los datos de este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    objProducto = nProducto.Registrar(objProducto)
                    Tabla = nAlmacen.Listar
                    For Each Fila As DataRow In Tabla.Rows
                        objProducto_Almacen.id_almacen = Fila.Item("id_almacen")
                        objProducto_Almacen.id_producto = objProducto.id_producto
                        objProducto_Almacen.descripcion = "El producto " & objProducto.nombre_producto & " esta en Almacen " & Fila.Item("descripcion")
                        nProducto_Almacen.RegistrarProducto_Almacen(objProducto_Almacen)
                        objPrecio.id_producto = objProducto.id_producto
                        objPrecio.id_almacen = Fila.Item("id_almacen")
                        objPrecio.precio_compra = objProducto.precio_compra
                        objPrecio.precio_venta = objProducto.precio_venta
                        objPrecio.precio_trajecta = objPrecio.precio_venta * Cambio_Trajecta
                        nPrecio.RegistrarPrecio(objPrecio)
                    Next
                    MessageBox.Show("Los datos se guardaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.lblCodigo.Text = objProducto.id_producto
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

            Dim objTemporal As Producto = objProducto
            objTemporal.id_producto = Me.lblCodigo.Text
            objTemporal.id_marca = Me.cboMarca.SelectedValue
            objTemporal.id_linea = Me.cboLinea.SelectedValue
            objTemporal.id_unidad = Me.cboUnidad.SelectedValue
            objTemporal.nombre_producto = Me.txtNombre_producto.Text.Trim
            objTemporal.codigo_producto = Me.txtCodigo_producto.Text.Trim
            objTemporal.modelo_producto = Me.txtmodelo_producto.Text.Trim
            objTemporal.numero_comprobante = Me.txtComprobante.Text.Trim
            objTemporal.descripcion = Me.txtdescripcion.Text.Trim
            objTemporal.estado = Me.chkestado_producto.Checked
            objTemporal.precio_compra = Me.txtPrecio_compra.Text
            objTemporal.precio_venta = Me.txtPrecio_venta.Text
            'If rbFoto.Checked Then
            '    objTemporal.foto = x
            '    System.IO.File.Delete(BorraFoto)
            'Else
            '    If OPF.SafeFileName.ToString <> "" Then
            '        RUTA = OPF.SafeFileName.ToString()
            '        pbProducto.ImageLocation = RUTA
            '        Dim pic As New Bitmap(RUTA)
            '        destino = "C:\Users\Ing. Dennis Estela Z\Documents\Javi\300314\270314\Proyecto VS\Sistema_Autos\Fotos\productos\\"
            '        pic.Save(destino)
            '        objTemporal.foto = destino
            '        If BorraFoto <> "C:\Users\Ing. Dennis Estela Z\Documents\Javi\300314\270314\Proyecto VS\Sistema_Autos\Fotos\productos\\" Then
            '            System.IO.File.Delete(BorraFoto)
            '        End If
            '        pbProducto.SizeMode = PictureBoxSizeMode.Zoom
            '    Else
            '        objTemporal.foto = BorraFoto
            '    End If
            'End If

            nProducto.Modificar(objTemporal)
            For Each Fila As DataRow In Tabla.Rows
                objProducto_Almacen.id_almacen = Fila.Item("id_almacen")
                objProducto_Almacen.id_producto = objProducto.id_producto
                objProducto_Almacen.descripcion = "El producto " & objProducto.nombre_producto & " esta en Almacen " & Fila.Item("descripcion")
                nProducto_Almacen.ModificarProducto_Almacen(objProducto_Almacen)
            Next
            MessageBox.Show("Los datos se actualizaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Si la modificación fue exitosa se actualiza al objeto temporal

            objProducto.id_producto = Me.lblCodigo.Text
            objProducto.id_marca = Me.cboMarca.SelectedValue
            objProducto.id_linea = Me.cboLinea.SelectedValue
            objProducto.id_unidad = Me.cboUnidad.SelectedValue
            objProducto.nombre_producto = Me.txtNombre_producto.Text.Trim
            objProducto.codigo_producto = Me.txtCodigo_producto.Text.Trim
            objProducto.modelo_producto = Me.txtmodelo_producto.Text.Trim
            objProducto.numero_comprobante = Me.txtComprobante.Text.Trim
            objProducto.descripcion = Me.txtdescripcion.Text.Trim
            objProducto.estado = Me.chkestado_producto.Checked
            objProducto.precio_compra = Me.txtPrecio_compra.Text
            objProducto.precio_venta = Me.txtPrecio_venta.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Cargar()
        Try

            Me.lblCodigo.Text = objProducto.id_producto
            Me.cboLinea.SelectedValue = objProducto.id_linea
            Me.cboMarca.SelectedValue = objProducto.id_marca
            Me.cboUnidad.SelectedValue = objProducto.id_unidad
            Me.txtNombre_producto.Text = objProducto.nombre_producto
            Me.txtCodigo_producto.Text = objProducto.codigo_producto
            Me.txtmodelo_producto.Text = objProducto.modelo_producto
            Me.txtComprobante.Text = objProducto.numero_comprobante
            Me.txtdescripcion.Text = objProducto.descripcion
            Me.chkestado_producto.Checked = objProducto.estado
            Me.txtPrecio_compra.Text = objProducto.precio_compra
            Me.txtPrecio_venta.Text = objProducto.precio_venta
            Dim picturesByte As New MemoryStream(objProducto.arrImage)
            pbProducto.Image = Image.FromStream(picturesByte)

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
        Me.cboLinea.Enabled = Estado
        Me.cboMarca.Enabled = Estado
        Me.cboUnidad.Enabled = Estado
        Me.txtNombre_producto.Enabled = Estado
        Me.txtCodigo_producto.Enabled = Estado
        Me.txtmodelo_producto.Enabled = Estado
        Me.txtComprobante.Enabled = Estado
        Me.txtPrecio_venta.Enabled = Estado
        Me.txtPrecio_compra.Enabled = Estado
        Me.txtdescripcion.Enabled = Estado
        Me.chkestado_producto.Enabled = Estado
    End Sub

    Sub Eliminar()
        Try

            If MessageBox.Show("¿Desea eliminar los datos de este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                nProducto.Eliminar(lblCodigo.Text)
                MessageBox.Show("Los datos se eliminaron satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Limpiar()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub Limpiar()
        Habilitar(True)
        Me.lblCodigo.Visible = False
        Me.lblCodigo.Text = ""
        Me.txtNombre_producto.Text = ""
        Me.txtCodigo_producto.Text = ""
        Me.txtPrecio_compra.Text = ""
        Me.txtPrecio_venta.Text = ""
        Me.txtmodelo_producto.Text = ""
        Me.txtComprobante.Text = ""
        Me.txtdescripcion.Text = ""
        Me.pbProducto.Image = Nothing
        Me.lblRutaImagen.Text = ""
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

        Me.txtNombre_producto.Focus()
    End Sub

    '---------------------------------------------
    '-----------------VALIDACIONES
    '---------------------------------------------
    Private Sub validaNumero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio_compra.KeyPress, txtPrecio_venta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "#" Or e.KeyChar = "*" Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Function Valida() As Boolean
        Dim TextoError As String = ""
        If Me.txtNombre_producto.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un nombre de un producto." & vbCrLf
        End If
        If Me.txtCodigo_producto.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar el codigo del producto." & vbCrLf
        End If
        If Me.txtmodelo_producto.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar un modelo de producto." & vbCrLf
        End If
        If Me.txtPrecio_compra.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar el precio de compra del producto." & vbCrLf
        End If
        If Me.txtPrecio_venta.Text.Trim = "" Then
            TextoError = TextoError & "- Debe ingresar el precio de venta del producto." & vbCrLf
        End If
        'If Me.txtfax.Text.Trim = "" Then
        '    TextoError = TextoError & "- Debe ingresar un fax." & vbCrLf
        'End If
        If Me.cboLinea.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una linea del producto." & vbCrLf
        End If
        If Me.cboMarca.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una marca del producto." & vbCrLf
        End If
        If Me.cboUnidad.SelectedValue = "0" Then
            TextoError = TextoError & "- Debe seleccionar una unidad del producto." & vbCrLf
        End If
        If TextoError <> "" Then
            MessageBox.Show("Faltan completar datos: " & vbCrLf & TextoError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Return True
        End If
    End Function


    'Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
    '    rbFoto.Checked = False
    '    Me.OPF.Filter = "Imagenes (jpg)|*.jpg"
    '    If OPF.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '        RUTA = OPF.FileName.ToString()
    '        pbProducto.ImageLocation = RUTA
    '    End If
    'End Sub

    'Private Sub rbFoto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFoto.CheckedChanged
    '    x = "C:\Users\Ing. Dennis Estela Z\Documents\Javi\300314\270314\Proyecto VS\Sistema_Autos\Sin Foto.jpg"
    '    pbProducto.ImageLocation = x.ToString
    'End Sub

    Private Sub btnExaminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExaminar.Click
        Dim fd As New OpenFileDialog
        fd.Filter = "*.bmp;*.gif;*.jpg;*.png|*.bmp;*.gif;*.jpg;*.png"
        fd.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        fd.Title = "seleccionar la imagen que se guardará en la base de datos"
        fd.RestoreDirectory = True

        If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblRutaImagen.Text = fd.FileName

            objProducto.RutaImagen = fd.FileName
            Dim fsImage As FileStream
            fsImage = New FileStream(objProducto.RutaImagen, FileMode.Open)
            Me.pbProducto.Image = Image.FromStream(fsImage)
            Dim ms As New MemoryStream
            Me.pbProducto.Image.Save(ms, Me.pbProducto.Image.RawFormat)
            objProducto.arrImage = ms.GetBuffer
            btnGrabar.Enabled = True
            pbProducto.Image = Image.FromStream(ms)
        Else

            pbProducto.Image = Nothing
            'btnGrabar.Enabled = False
        End If
    End Sub
End Class