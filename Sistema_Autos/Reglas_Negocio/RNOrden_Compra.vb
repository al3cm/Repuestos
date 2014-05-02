Imports System.Data.SqlClient
Imports Entidades
Public Class RNOrden_Compra
    Public Function RegistrarCompra(ByVal objOrden_Compra As Orden_Compra) As Orden_Compra
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarCompra", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_compra", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@fecha_compra", objOrden_Compra.fecha_compra)
            .AddWithValue("@total", objOrden_Compra.total)
            .AddWithValue("@subtotal", objOrden_Compra.subtotal)
            .AddWithValue("@igv", objOrden_Compra.igv)
            .AddWithValue("@id_moneda", objOrden_Compra.id_Moneda)
            .AddWithValue("@numero_documento", objOrden_Compra.numero_documento)
            .AddWithValue("@serie_documento", objOrden_Compra.serie_documento)
            .AddWithValue("@id_proveedor", objOrden_Compra.id_proveedor)
            .AddWithValue("@id_almacen", objOrden_Compra.id_almacen)
            .AddWithValue("@tipo_pago", objOrden_Compra.Tipo_Pago)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objOrden_Compra.id_compra = CInt(cmd.Parameters.Item("@id_compra").Value)
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
        Return objOrden_Compra
    End Function
    Public Function RegistrarCompraConCambion(ByVal objOrden_Compra As Orden_Compra) As Orden_Compra
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarCompraConCambion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_compra", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@fecha_compra", objOrden_Compra.fecha_compra)
            .AddWithValue("@total", objOrden_Compra.total)
            .AddWithValue("@subtotal", objOrden_Compra.subtotal)
            .AddWithValue("@igv", objOrden_Compra.igv)
            .AddWithValue("@id_moneda", objOrden_Compra.id_Moneda)
            .AddWithValue("@numero_documento", objOrden_Compra.numero_documento)
            .AddWithValue("@serie_documento", objOrden_Compra.serie_documento)
            .AddWithValue("@id_proveedor", objOrden_Compra.id_proveedor)
            .AddWithValue("@id_almacen", objOrden_Compra.id_almacen)
            .AddWithValue("@tipo_pago", objOrden_Compra.Tipo_Pago)
            .AddWithValue("@tipo_cambio", objOrden_Compra.tipo_cambio)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objOrden_Compra.id_compra = CInt(cmd.Parameters.Item("@id_compra").Value)
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
        Return objOrden_Compra
    End Function
    Public Sub RegistrarCompra_Producto(ByVal objOrden_Compra As Orden_Compra)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarCompra_Producto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_compra", objOrden_Compra.id_compra)
            .AddWithValue("@id_producto", objOrden_Compra.id_producto)
            .AddWithValue("@cantidad", objOrden_Compra.cantidad)
            .AddWithValue("@precio_compra", objOrden_Compra.precio_compra)
            .AddWithValue("@descuento", objOrden_Compra.descuento)
            .AddWithValue("@Sub_Total", objOrden_Compra.Sub_Total)
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
    
    Sub ModificarCompra(ByVal objOrden_Compra As Orden_Compra)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarCompra", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_compra", objOrden_Compra.id_compra)
            .AddWithValue("@fecha_compra", objOrden_Compra.fecha_compra)
            .AddWithValue("@total", objOrden_Compra.total)
            .AddWithValue("@subtotal", objOrden_Compra.subtotal)
            .AddWithValue("@igv", objOrden_Compra.igv)
            .AddWithValue("@id_moneda", objOrden_Compra.id_Moneda)
            .AddWithValue("@numero_documento", objOrden_Compra.numero_documento)
            .AddWithValue("@serie_documento", objOrden_Compra.serie_documento)
            .AddWithValue("@id_proveedor", objOrden_Compra.id_proveedor)
            .AddWithValue("@id_almacen", objOrden_Compra.id_almacen)
            .AddWithValue("@tipo_pago", objOrden_Compra.Tipo_Pago)
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
    Sub EleminarProducto_Almacen(ByVal id_Compra As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarCompra_Producto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_compra", id_Compra)

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
    Sub EleminarCompra(ByVal id_Compra As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarCompra", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_compra", id_Compra)

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
    Sub AtenderCompra(ByVal objOrden_Compra As Orden_Compra)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_AtenderCompra", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_compra", objOrden_Compra.id_compra)
            .AddWithValue("@estado", objOrden_Compra.Estado)
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
        Dim da As New SqlDataAdapter("sp_ListarCompra", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function ListarTodos() As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim da As New SqlDataAdapter("sp_ListarTodosCompra", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal Id_Compra As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaCompraXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Compra", Id_Compra)
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
    Public Function ListarDetalle(ByVal Id_Compra As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaDetalleCompraXCompra", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Compra", Id_Compra)
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
        Dim cmd As New SqlCommand("sp_BuscarIdCompra", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_Compra", SqlDbType.TinyInt).Direction = ParameterDirection.Output
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            id = CInt(cmd.Parameters.Item("@id_Compra").Value)
        Catch ex As Exception
            Throw
        End Try
        Return id
    End Function
End Class
