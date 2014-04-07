Imports System.Data.SqlClient
Imports Entidades
Public Class RNProducto
    Public Function Registrar(ByVal objProducto As Producto) As Producto
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarProducto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_producto", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_marca", objProducto.id_marca)
            .AddWithValue("@id_linea", objProducto.id_linea)
            .AddWithValue("@id_unidad", objProducto.id_unidad)
            .AddWithValue("@nombre_producto", objProducto.nombre_producto)
            .AddWithValue("@codigo_producto", objProducto.codigo_producto)
            .AddWithValue("@modelo_producto", objProducto.modelo_producto)
            .AddWithValue("@numero_comprobante", objProducto.numero_comprobante)
            .AddWithValue("@precio_compra", objProducto.precio_compra)
            .AddWithValue("@precio_venta", objProducto.precio_venta)
            .AddWithValue("@estado", objProducto.estado)
            .AddWithValue("@imagen", objProducto.arrImage)
            .AddWithValue("@descripcion", objProducto.descripcion)
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objProducto.id_producto = CInt(cmd.Parameters.Item("@id_producto").Value)
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
        Return objProducto
    End Function

    Sub Modificar(ByVal objProducto As Producto)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarProducto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_producto", objProducto.id_producto)
            .AddWithValue("@id_marca", objProducto.id_marca)
            .AddWithValue("@id_linea", objProducto.id_linea)
            .AddWithValue("@id_unidad", objProducto.id_unidad)
            .AddWithValue("@nombre_producto", objProducto.nombre_producto)
            .AddWithValue("@codigo_producto", objProducto.codigo_producto)
            .AddWithValue("@modelo_producto", objProducto.modelo_producto)
            .AddWithValue("@numero_comprobante", objProducto.numero_comprobante)
            ' Added 2014.03.23 ---------------------------
            If objProducto.estado Then
                .AddWithValue("@estado", "1")
            Else
                .AddWithValue("@estado", "0")
            End If
            '---------------------------------------------

            .AddWithValue("@descripcion", objProducto.descripcion)
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

    Sub Eliminar(ByVal id_producto As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarProducto", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_producto", id_producto)

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
        Dim da As New SqlDataAdapter("sp_ListarProducto", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function

    Public Function Listar(ByVal Id_Producto As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaProductoXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_producto", Id_Producto)
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
End Class
