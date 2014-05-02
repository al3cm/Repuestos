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
            Me.lstListaVentas.Items.Clear()
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
            Item.SubItems.Add(CStr(Fila.Item("tipoDocumento")) & "/" & CStr(Fila.Item("documento")) & "-" & CStr(Fila.Item("serie")))
           

            Item.SubItems.Add(CStr(Fila.Item("moneda")))
            Item.SubItems.Add(Format(Fila.Item("monto"), "## ##0.00"))
            Item.SubItems.Add(CStr(Fila.Item("sucursal")))
            Item.SubItems.Add(CStr(Fila.Item("fecha_movimiento")))

            Me.lstListaVentas.Items.Add(Item)
        Next
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            Dim xla As New Microsoft.Office.Interop.Excel.Application()
            xla.Visible = True

            Dim wb As Microsoft.Office.Interop.Excel.Workbook = xla.Workbooks.Add(Microsoft.Office.Interop.Excel.XlSheetType.xlWorksheet)

            Dim ws As Microsoft.Office.Interop.Excel.Worksheet = DirectCast(xla.ActiveSheet, Microsoft.Office.Interop.Excel.Worksheet)

            Dim i As Integer = 1
            Dim j As Integer = 1
            Dim jj As Integer = lstListaVentas.Columns.Count

            For rr = 0 To lstListaVentas.Columns.Count - 1
                ws.Cells(i, j) = lstListaVentas.Columns(rr).Text
                j = j + 1
            Next
            i = 2
            j = 1
            For Each comp As ListViewItem In lstListaVentas.Items
                ws.Cells(i, j) = comp.Text.ToString()
                For Each drv As ListViewItem.ListViewSubItem In comp.SubItems
                    ws.Cells(i, j) = drv.Text.ToString()
                    j += 1
                Next
                j = 1
                i += 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class