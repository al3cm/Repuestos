Imports System.Data.SqlClient
Imports Entidades
Public Class RNProducto_Almacen
    Public Function ContraProducto_Almacen(ByVal objProducto_Almacen As Producto_Almacen) As Integer
        Dim Cantidad As Integer
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ContraProducto_Almacen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@Cantidad", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_producto", objProducto_Almacen.id_producto)
            .AddWithValue("@id_almacen", objProducto_Almacen.id_almacen)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            Cantidad = CInt(cmd.Parameters.Item("@Cantidad").Value)
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
        Return Cantidad
    End Function
    Public Sub RegistrarProducto_Almacen(ByVal objProducto_Almacen As Producto_Almacen)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarProducto_Almacen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_producto", objProducto_Almacen.id_producto)
            .AddWithValue("@id_almacen", objProducto_Almacen.id_almacen)
            .AddWithValue("@descripcion", objProducto_Almacen.descripcion)
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
    Public Sub ModificarProducto_Almacen(ByVal objProducto_Almacen As Producto_Almacen)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarProducto_Almacen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_producto", objProducto_Almacen.id_almacen)
            .AddWithValue("@id_almacen", objProducto_Almacen.id_almacen)
            .AddWithValue("@descripcion", objProducto_Almacen.descripcion)
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
    Public Function Listar(ByVal objProducto_Almacen As Producto_Almacen) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarProducto_Almacen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_producto", objProducto_Almacen.id_producto)
        cmd.Parameters.AddWithValue("@id_almacen", objProducto_Almacen.id_almacen)
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
    Public Sub AutorizaStock(ByVal objProducto_Almacen As Producto_Almacen)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_AutorizaStock", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_producto", objProducto_Almacen.id_producto)
            .AddWithValue("@id_almacen", objProducto_Almacen.id_almacen)
            .AddWithValue("@stock", objProducto_Almacen.stock)
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
End Class
