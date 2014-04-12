Imports System.Data.SqlClient
Imports Entidades
Public Class RNPrecio
    Public Sub RegistrarPrecio(ByVal objPrecio As Precio)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarPrecio", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_producto", objPrecio.id_producto)
            .AddWithValue("@id_almacen", objPrecio.id_almacen)
            .AddWithValue("@precio_compra", objPrecio.precio_compra)
            .AddWithValue("@precio_venta", objPrecio.precio_venta)
            .AddWithValue("@precio_trajecta", objPrecio.precio_trajecta)
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
    Public Sub ModificarPrecio(ByVal objPrecio As Precio)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarPrecio", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_producto", objPrecio.id_producto)
            .AddWithValue("@id_almacen", objPrecio.id_almacen)
            .AddWithValue("@precio_compra", objPrecio.precio_compra)
            .AddWithValue("@precio_venta", objPrecio.precio_venta)
            .AddWithValue("@precio_trajecta", objPrecio.precio_trajecta)
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
