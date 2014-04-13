Imports Reglas_Negocio
Imports Entidades
Public Class frmResumen_Caja
    Dim nDetalle_Caja As New RNDetalle_Caja
    Dim id_almacenLogin As Integer
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    Sub LlenaCombos(ByVal Id_Almacen As Integer)
        Try
            Dim Caja As DataTable = nDetalle_Caja.Listar(Id_Almacen)
            Me.cboCuenta.ValueMember = "id_caja"
            Me.cboCuenta.DisplayMember = "descripcion"
            Me.cboCuenta.DataSource = Caja
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmResumen_Caja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            id_almacenLogin = RNPersonal.ListarPersonalAlmacen(CType(Me.Tag, Personal_SubMenu).id_personal)
            If id_almacenLogin = 0 Then
                MessageBox.Show("Debe asignar al personal logeado un almacen, consultar con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
            LlenaCombos(id_almacenLogin)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            LlenaLista(RNFacturacion.resumenCaja(Me.dtpfecha_desde.Value.Date, dtpfecha_hasta.Value.Date, cboCuenta.SelectedValue, id_almacenLogin))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub LlenaLista(ByVal Datos As DataTable)
        Me.lstListaVentas.Items.Clear()
        For Each Fila As DataRow In Datos.Rows
            Dim Item As New ListViewItem
            Dim objMov As New Facturacion
            Item.Text = CStr(Fila.Item("detalleCaja"))

            Item.SubItems.Add(CStr(Fila.Item("cliente")))
            Item.SubItems.Add(CStr(Fila.Item("documento")))
            Item.SubItems.Add(CStr(Fila.Item("moneda")))
            Item.SubItems.Add(Format(Fila.Item("monto"), "## ##0.00"))
            Item.SubItems.Add(CStr(Fila.Item("sucursal")))
            Item.SubItems.Add(CStr(Fila.Item("fecha_movimiento")))

            Me.lstListaVentas.Items.Add(Item)
        Next
    End Sub
End Class