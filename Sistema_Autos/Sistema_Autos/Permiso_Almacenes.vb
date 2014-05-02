Imports Entidades
Imports Reglas_Negocio
Public Class frmPermiso_Almacenes
    Dim nSucursal As New RNSucursal
    Dim nAlmacen As New RNAlmacen
    Public objPersonal As New Personal
    Private Sub frmPermiso_Almacenes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Lipiar()
        LlenaCombos()
    End Sub
    Private Sub cboSucursal_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSucursal.SelectedIndexChanged
        lipiar()
        LlenaAlmacen()
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim fila As Integer
        Dim id_Almacen As Integer
        Dim Almacen As String
        fila = dtvListado_Almacen.SelectedRows.Count
        If fila > 0 Then
            For Each Seleccion As DataGridViewRow In dtvListado_Almacen.SelectedRows
                id_Almacen = Seleccion.Cells(0).Value
                Almacen = Seleccion.Cells(1).Value
                Me.dtvAlmacen_permitidos.Rows.Add(id_Almacen, Almacen)
                dtvListado_Almacen.Rows.Remove(Seleccion)
                dtvListado_Almacen.Refresh()
                Me.btnAgregar.Enabled = False
                Me.btnQuitar.Enabled = True
                Me.btnAceptar.Enabled = True
            Next
        Else
            MessageBox.Show("Para selecionar una fila hace click en la Fecha")
        End If
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        lipiar()
        LlenaAlmacen()
    End Sub
    Private Sub dtvAlmacen_permitidos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtvAlmacen_permitidos.DoubleClick
        btnAceptar_Click(sender, e)
    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Me.objPersonal.id_almacen = Me.dtvAlmacen_permitidos.Rows(0).Cells(0).Value
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
    '---------------------------------------------
    '-----------------FUNCIONALIDAD
    '---------------------------------------------
    
    '---------------------------------------------
    '-----------------INICIALIZAR
    '---------------------------------------------
    Sub lipiar()
        Me.dtvListado_Almacen.Rows.Clear()
        Me.dtvAlmacen_permitidos.Rows.Clear()
        Me.btnAgregar.Enabled = True
        Me.btnQuitar.Enabled = False
        Me.btnAceptar.Enabled = False
    End Sub
    Sub LlenaCombos()
        Try
            Dim Sucursales As DataTable = RNSucursal.Listar
            Me.cboSucursal.ValueMember = "id_sucursal"
            Me.cboSucursal.DisplayMember = "descripcion"
            Me.cboSucursal.DataSource = Sucursales
            Me.cboSucursal.SelectedValue = 1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub LlenaAlmacen()
        Dim id_Sucursal As Integer
        Dim id_Almacen As Integer
        Dim Almacen As String
        id_Sucursal = Me.cboSucursal.SelectedValue
        Dim Tabla As DataTable = nAlmacen.Listar(id_Sucursal)
        For Each Fila As DataRow In Tabla.Rows
            id_Almacen = Fila.Item("id_almacen")
            Almacen = Fila.Item("descripcion")
            Me.dtvListado_Almacen.Rows.Add(id_Almacen, Almacen)
        Next
    End Sub
End Class