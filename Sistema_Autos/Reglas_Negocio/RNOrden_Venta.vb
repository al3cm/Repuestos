Imports System.Data.SqlClient
Imports Entidades
Public Class RNOrden_Venta
    Public Function RegistrarVenta(ByVal objOrden_Venta As Orden_Venta) As Orden_Venta
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarVenta", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_Venta", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_almacen", objOrden_Venta.id_almacen)
            .AddWithValue("@id_personal", objOrden_Venta.id_personal)
            .AddWithValue("@id_cliente", objOrden_Venta.id_cliente)
            .AddWithValue("@fecha_emision", objOrden_Venta.fecha_emision)
            .AddWithValue("@id_tipodocumento", objOrden_Venta.id_tipodocumento)
            .AddWithValue("@total", objOrden_Venta.total)
            .AddWithValue("@subtotal", objOrden_Venta.subtotal)
            .AddWithValue("@igv", objOrden_Venta.igv)
            .AddWithValue("@id_moneda", objOrden_Venta.id_Moneda)
            .AddWithValue("@numero_documento", objOrden_Venta.numero_documento)
            .AddWithValue("@serie_documento", objOrden_Venta.serie_documento)
            .AddWithValue("@tipo_pago", objOrden_Venta.Tipo_Pago)
            .AddWithValue("@pago_inicial", objOrden_Venta.pago_inicial)
            .AddWithValue("@monto_financiado", objOrden_Venta.monto_financiado)
            .AddWithValue("@nro_cuotas", objOrden_Venta.nro_cuotas)
            .AddWithValue("@Monto_cuota", objOrden_Venta.Monto_cuota)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objOrden_Venta.id_venta = CInt(cmd.Parameters.Item("@id_Venta").Value)
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()

            cn = Nothing
        End Try
        Return objOrden_Venta
    End Function
    Public Function RegistrarVentaConCambion(ByVal objOrden_Venta As Orden_Venta) As Orden_Venta
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarVentaConCambion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_Venta", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_personal", objOrden_Venta.id_personal)
            .AddWithValue("@id_cliente", objOrden_Venta.id_cliente)
            .AddWithValue("@fecha_emision", objOrden_Venta.fecha_emision)
            .AddWithValue("@id_tipodocumento", objOrden_Venta.id_tipodocumento)
            .AddWithValue("@total", objOrden_Venta.total)
            .AddWithValue("@subtotal", objOrden_Venta.subtotal)
            .AddWithValue("@igv", objOrden_Venta.igv)
            .AddWithValue("@id_moneda", objOrden_Venta.id_Moneda)
            .AddWithValue("@numero_documento", objOrden_Venta.numero_documento)
            .AddWithValue("@serie_documento", objOrden_Venta.serie_documento)
            .AddWithValue("@tipo_pago", objOrden_Venta.Tipo_Pago)
            .AddWithValue("@pago_inicial", objOrden_Venta.pago_inicial)
            .AddWithValue("@monto_financiado", objOrden_Venta.monto_financiado)
            .AddWithValue("@nro_cuotas", objOrden_Venta.nro_cuotas)
            .AddWithValue("@Monto_cuota", objOrden_Venta.Monto_cuota)
            .AddWithValue("@tipo_cambio", objOrden_Venta.tipo_cambio)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objOrden_Venta.id_venta = CInt(cmd.Parameters.Item("@id_Venta").Value)
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()

            cn = Nothing
        End Try
        Return objOrden_Venta
    End Function
    Public Sub RegistrarVenta_Producto(ByVal objOrden_Venta As Orden_Venta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarVenta_Producto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_Venta", objOrden_Venta.id_venta)
            .AddWithValue("@id_producto", objOrden_Venta.id_producto)
            .AddWithValue("@cantidad", objOrden_Venta.cantidad)
            .AddWithValue("@precio_Venta", objOrden_Venta.precio_venta)
            .AddWithValue("@descuento", objOrden_Venta.descuento)
            .AddWithValue("@Sub_Total", objOrden_Venta.Sub_Total)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()

            cn = Nothing
        End Try
    End Sub
        Sub ModificarVenta(ByVal objOrden_Venta As Orden_Venta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarVenta", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_Venta", objOrden_Venta.id_venta)
            .AddWithValue("@id_almacen", objOrden_Venta.id_almacen)
            .AddWithValue("@id_personal", objOrden_Venta.id_personal)
            .AddWithValue("@id_cliente", objOrden_Venta.id_cliente)
            .AddWithValue("@fecha_emision", objOrden_Venta.fecha_emision)
            .AddWithValue("@id_tipodocumento", objOrden_Venta.id_tipodocumento)
            .AddWithValue("@total", objOrden_Venta.total)
            .AddWithValue("@subtotal", objOrden_Venta.subtotal)
            .AddWithValue("@igv", objOrden_Venta.igv)
            .AddWithValue("@id_moneda", objOrden_Venta.id_Moneda)
            .AddWithValue("@numero_documento", objOrden_Venta.numero_documento)
            .AddWithValue("@serie_documento", objOrden_Venta.serie_documento)
            .AddWithValue("@tipo_pago", objOrden_Venta.Tipo_Pago)
            .AddWithValue("@pago_inicial", objOrden_Venta.pago_inicial)
            .AddWithValue("@monto_financiado", objOrden_Venta.monto_financiado)
            .AddWithValue("@nro_cuotas", objOrden_Venta.nro_cuotas)
            .AddWithValue("@Monto_cuota", objOrden_Venta.Monto_cuota)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()

            cn = Nothing
        End Try
    End Sub
    Sub EleminarVenta_Producto(ByVal id_Venta As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarVenta_Producto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Venta", id_Venta)
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()

            cn = Nothing
        End Try
    End Sub
    Sub EleminarVenta(ByVal id_Venta As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarVenta", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Venta", id_Venta)

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()

            cn = Nothing
        End Try
    End Sub
    Sub AtenderVenta(ByVal objOrden_Venta As Orden_Venta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_AtenderVenta", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_venta", objOrden_Venta.id_venta)
            .AddWithValue("@estado", objOrden_Venta.Estado)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()

            cn = Nothing
        End Try
    End Sub
    Public Function Listar() As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim da As New SqlDataAdapter("sp_ListarVenta", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal Id_Venta As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaVentaXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Venta", Id_Venta)
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds)
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn = Nothing
        End Try
        Return ds
    End Function
    Public Function ListarDetalle(ByVal Id_Venta As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaDetalleVentaXVenta", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Venta", Id_Venta)
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds)
        Catch ex As Exception
            Throw ex
        Finally
            cmd.Dispose()
            cmd = Nothing
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Dispose()
            cn = Nothing
        End Try
        Return ds
    End Function
    Public Function buscarid() As Integer
        Dim id As Integer
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_BuscarIdVenta", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_Venta", SqlDbType.TinyInt).Direction = ParameterDirection.Output
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            id = CInt(cmd.Parameters.Item("@id_Venta").Value)
        Catch ex As Exception
            Throw
        End Try
        Return id
    End Function
End Class
