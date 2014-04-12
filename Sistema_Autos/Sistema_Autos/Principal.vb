'ADD 2014.03.05
Imports Entidades
Imports Reglas_Negocio
Public Class frmPrincipal
    '============================================
    'ADD 2014.03.05
    Public UsuarioActivo As Personal
    'Confirmación de salida
    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("Desea Salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mdiPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            IniciaMenu() 'Inicia Menú
            IniciarSesionToolStripMenuItem_Click(sender, e) 'Invoca al Inicio de Sesión
            Me.Tag = Me.Text ' Added 2014.03.13
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'GESTION DE LA BARRA DE MENU
    Sub IniciaMenu()
        Me.UsuarioActivo = Nothing
        For Each elemento As ToolStripMenuItem In Me.mns_principal.Items
            elemento.Enabled = False
        Next
        AdministradorToolStripMenuItem.Enabled = True
        IniciarSesionToolStripMenuItem.Enabled = True
        TipoCambioToolStripMenuItem.Enabled = False
        CerrarSesionToolStripMenuItem.Enabled = False
        AcercaDeToolStripMenuItem.Enabled = True

    End Sub

    'Opciones de Menú
    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Sub CargaMenu(ByVal Usu As Personal)
        Try
            Dim Tabla As DataTable = RNPersonal.ListarAccesoUsuario(Usu.id_personal)
            Me.Text = CStr(Me.Tag) & " - " & Usu.usuario 'Modified 2014.03.13
            If Tabla.Rows.Count > 0 Then
                For Each Elemento As ToolStripMenuItem In Me.mns_principal.Items
                    If VerificaOpcionEnTabla(Elemento.Text, Tabla, "menu") IsNot Nothing Then
                        Elemento.Enabled = True
                    Else
                        Elemento.Enabled = False
                    End If

                    If Elemento.DropDownItems.Count > 0 Then
                        HabilitaOpciones(Elemento.DropDownItems, Tabla)
                    End If
                Next

            Else
                MessageBox.Show("No hay accesos registrados...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Function VerificaOpcionEnTabla(ByVal Texto As String, ByVal Tabla As DataTable, ByVal Criterio As String) As DataRow
        'Dim Encuentra As Boolean = False
        For Each Fila As DataRow In Tabla.Rows
            If Fila.Item(Criterio) = Texto And Fila.Item("estado") = True Then
                'Encuentra = True
                Return Fila
            End If
        Next
        Return Nothing
    End Function
    Sub HabilitaOpciones(ByVal Opciones As ToolStripItemCollection, ByVal Tabla As DataTable)
        For Each Item As ToolStripItem In Opciones
            If Item.GetType() Is GetType(ToolStripMenuItem) Then
                Dim Fila As DataRow = VerificaOpcionEnTabla(Item.Text, Tabla, "submenu")
                If Fila IsNot Nothing Then
                    Item.Enabled = True

                    ' LÓGICA PERMISOS -------------------------------------------------
                    Dim Permisos As New Personal_SubMenu
                    Permisos.id_personal = Fila.Item("id_personal")
                    Permisos.id_menu = Fila.Item("id_menu")
                    Permisos.id_submenu = Fila.Item("id_submenu")
                    Permisos.estado = Fila.Item("estado")
                    Permisos.nuevo = Fila.Item("nuevo")
                    Permisos.eliminar = Fila.Item("eliminar")
                    Permisos.buscar = Fila.Item("buscar")
                    Permisos.modificar = Fila.Item("modificar")
                    Item.Tag = Permisos

                    ' -----------------------------------------------------------------

                Else
                    Item.Enabled = False
                End If

                
                If CType(Item, ToolStripMenuItem).DropDownItems.Count > 0 Then
                    HabilitaOpciones(CType(Item, ToolStripMenuItem).DropDownItems, Tabla)
                End If
            End If
        Next
    End Sub
    '============================================

    '============================================
    '==============MENU ADMINISTRADOR============
    '============================================

    Private Sub IniciarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IniciarSesionToolStripMenuItem.Click
        Try

            ' Validar login 

            If frmLogin.ShowDialog = Windows.Forms.DialogResult.OK Then
                'Envio objecto usuario(Datos usuario Sistema)
                Me.UsuarioActivo = frmLogin.UsuarioActivo
                MessageBox.Show("Bienvenido(a) " & Me.UsuarioActivo.nombres & " " & Me.UsuarioActivo.ap_paterno, "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'CargaMenu()
                CargaMenu(Me.UsuarioActivo)
                'Habilita comando cerrar sesion
                'DesHabilita comando inicio sesion
                IniciarSesionToolStripMenuItem.Enabled = False
                CerrarSesionToolStripMenuItem.Enabled = True
                AcercaDeToolStripMenuItem.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TipoCambioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoCambioToolStripMenuItem.Click
        frmTipo_cambio.ShowDialog()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        If MessageBox.Show("Desea cerrar sesión?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            IniciaMenu()
        End If
    End Sub

    Private Sub CerrarSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarSistemaToolStripMenuItem.Click
        Me.Close()
    End Sub

    '============================================
    '=============MENU MANTENIMIENTOS============
    '============================================

    Private Sub PersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PersonalToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmPersonal.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmPersonal.ShowDialog()
    End Sub

    Private Sub AsignarPermisosPersonalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarPermisosPersonalToolStripMenuItem.Click
        frmListarPersonal.Tag = 1
        frmListarPersonal.ShowDialog()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click

        ' LÓGICA PERMISOS -------------------------------------------------
        frmClientes.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmClientes.ShowDialog()
    End Sub

    Private Sub LineaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LineaToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmLinea.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmLinea.ShowDialog()
    End Sub

    Private Sub MarcaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcaToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmMarca.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmMarca.ShowDialog()
    End Sub

    Private Sub ProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductoToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmProducto.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmProducto.ShowDialog()
    End Sub

    Private Sub ProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedorToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmProveedores.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmProveedores.ShowDialog()
    End Sub

    Private Sub UnidadToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadToolStripMenuItem1.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmUnidad.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmUnidad.ShowDialog()
    End Sub

    'VACIO_____________________________________________________
    Private Sub ActualizarPreciosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarPreciosToolStripMenuItem.Click
        frmActualizar_precios.Tag = CType(sender, ToolStripMenuItem).Tag
        frmActualizar_precios.ShowDialog()
    End Sub
    '__________________________________________________________

    Private Sub VehiculoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehiculoToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmVehiculo.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmVehiculo.ShowDialog()
    End Sub

    Private Sub MonedaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonedaToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmMoneda.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------

        frmMoneda.ShowDialog()
    End Sub

    Private Sub SucursalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SucursalToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmSucursal.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------

        frmSucursal.ShowDialog()
    End Sub

    Private Sub AlmacénToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlmacénToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmAlmacen.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------

        frmAlmacen.ShowDialog()
    End Sub

    'VACIO_____________________________________________________

    Private Sub PrecioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrecioToolStripMenuItem.Click

    End Sub
    '__________________________________________________________

    Private Sub ConceptosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConceptosToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmConcepto.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------

        frmConcepto.ShowDialog()
    End Sub

    Private Sub TipoDeDocumentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeDocumentoToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmTipoDocumento.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------

        frmTipoDocumento.ShowDialog()
    End Sub

    '============================================
    '=================MENU COMPRAS===============
    '============================================

    Private Sub OrdenDeCompraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDeCompraToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmOrden_Compra.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmOrden_Compra.ShowDialog()
    End Sub

    Private Sub NotaDeCréditoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDeCréditoToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmNota_Credito_Proveedor.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmNota_Credito_Proveedor.ShowDialog()
    End Sub

    Private Sub NotaDeDébitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDeDébitoToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmNota_Debito_Proveedor.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmNota_Debito_Proveedor.ShowDialog()
    End Sub

    '============================================
    '=================MENU VENTAS================
    '============================================

    Private Sub OrdenDeVentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdenDeVentaToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmOrden_Venta.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmOrden_Venta.ShowDialog()
    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturaciónToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmFacturacion.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmFacturacion.ShowDialog()
    End Sub

    Private Sub NotaDeCréditoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDeCréditoClienteToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmNota_Credito_Cliente.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmNota_Credito_Cliente.ShowDialog()
    End Sub

    Private Sub NotaDeDébitoClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDeDébitoClienteToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmNota_Debito_Clientes.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmNota_Debito_Clientes.ShowDialog()
    End Sub

    '============================================
    '==================MENU CAJA=================
    '============================================

    Private Sub CajayBancosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResumenDeCajaToolStripMenuItem.Click
        frmResumen_Caja.ShowDialog()
    End Sub

    Private Sub CuentasPorCobrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasPorCobrarToolStripMenuItem.Click
        frmCuentas_Cobrar.ShowDialog()
    End Sub

    Private Sub CuentasPorPagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CuentasPorPagarToolStripMenuItem.Click
        frmCuentas_Pagar.ShowDialog()
    End Sub

    Private Sub CanjeDeLetrasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CanjeDeLetrasToolStripMenuItem.Click
        frmCanje_Letras.ShowDialog()
    End Sub

    '============================================
    '==============MENU INVENTARIOS==============
    '============================================

    Private Sub IngresoAlKardexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresoAlKardexToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmIngreso_Kardex.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmIngreso_Kardex.ShowDialog()
    End Sub

    Private Sub MovimientoDeKardexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientoDeKardexToolStripMenuItem.Click
        frmMovimiento_Kardex.ShowDialog()
    End Sub

    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        frmStock.ShowDialog()
    End Sub

    '============================================
    '===============MENU REPORTES================
    '============================================

    Private Sub RegistroDeVentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroDeVentasToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmRegistros_Ventas.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmRegistros_Ventas.ShowDialog()
    End Sub

    
    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        ' LÓGICA PERMISOS -------------------------------------------------
        frmEmpresa.Tag = CType(sender, ToolStripMenuItem).Tag
        ' -----------------------------------------------------------------
        frmEmpresa.ShowDialog()
    End Sub

    Private Sub GastosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GastosToolStripMenuItem.Click
        frmGastos.ShowDialog()
    End Sub
End Class