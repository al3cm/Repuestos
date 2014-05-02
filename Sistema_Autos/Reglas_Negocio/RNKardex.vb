Imports System.Data.SqlClient
Imports Entidades
Public Class RNKardex
    Public Function RegistrarKardex(ByVal objKardex As Kardex) As Kardex
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarKardex", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_kardex", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@fecha", objKardex.fecha)
            .AddWithValue("@nro_documento", objKardex.numero_documento)
            .AddWithValue("@serie_documento", objKardex.serie_documento)
            .AddWithValue("@id_tipodocumento", objKardex.id_tipodocumento)
            .AddWithValue("@id_producto", objKardex.id_producto)
            .AddWithValue("@id_almacen", objKardex.id_almacen)
            .AddWithValue("@id_movimiento", objKardex.id_movimiento)
            .AddWithValue("@stock", objKardex.stock)
            .AddWithValue("@cantidad", objKardex.cantidad)
            .AddWithValue("@precio", objKardex.precio)
            .AddWithValue("@descuento", objKardex.Descuentro)
            .AddWithValue("@tipo", objKardex.tipo)
            .AddWithValue("@total", objKardex.total)
            .AddWithValue("@ruc_dni", objKardex.ruc_dni)
            .AddWithValue("@Nombre", objKardex.Nombre)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objKardex.id_Kardex = CInt(cmd.Parameters.Item("@id_Kardex").Value)
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
        Return objKardex
    End Function
    Sub ModificarKardex(ByVal objKardex As Kardex)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarKardex", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_Kardex", objKardex.id_kardex)
            .AddWithValue("@fecha", objKardex.fecha)
            .AddWithValue("@nro_documento", objKardex.numero_documento)
            .AddWithValue("@serie_documento", objKardex.serie_documento)
            .AddWithValue("@id_tipodocumento", objKardex.id_tipodocumento)
            .AddWithValue("@id_producto", objKardex.id_producto)
            .AddWithValue("@id_almacen", objKardex.id_almacen)
            .AddWithValue("@id_sucursal", objKardex.id_sucursal)
            .AddWithValue("@id_movimiento", objKardex.id_movimiento)
            .AddWithValue("@stock", objKardex.stock)
            .AddWithValue("@cantidad", objKardex.cantidad)
            .AddWithValue("@precio", objKardex.precio)
            .AddWithValue("@descuento", objKardex.Descuentro)
            .AddWithValue("@tipo", objKardex.tipo)
            .AddWithValue("@total", objKardex.total)
            .AddWithValue("@ruc_dni", objKardex.ruc_dni)
            .AddWithValue("@Nombre", objKardex.Nombre)
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
    Sub EleminarKardex(ByVal id_movimiento As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarKardex", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_movimiento", id_movimiento)

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
        Dim da As New SqlDataAdapter("sp_ListarKardex", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal Id_Kardex As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaKardexXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Kardex", Id_Kardex)
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
    Public Function Listar(ByVal Id_almacen As Integer, ByVal Id_producto As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListakardexXAlmacen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_almacen", Id_almacen)
        cmd.Parameters.AddWithValue("@id_producto", Id_producto)
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
    Public Function Listar(ByVal Id_almacen As Integer, ByVal Id_producto As Integer, ByVal Fecha_Ini As Date, ByVal Fecha_Fin As Date) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListakardexXAlmacenYFecha", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_almacen", Id_almacen)
        cmd.Parameters.AddWithValue("@id_producto", Id_producto)
        cmd.Parameters.AddWithValue("@fechaIni", Fecha_Ini)
        cmd.Parameters.AddWithValue("@fechaFin", Fecha_Fin)
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
