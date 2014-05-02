Imports System.Data.SqlClient
Imports Entidades
Public Class RNAlmacen
    Public Function Registrar(ByVal objAlmacen As Almacen) As Almacen
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarAlmacen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_almacen", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_sucursal", objAlmacen.id_sucursal)
            .AddWithValue("@descripcion", objAlmacen.descripcion)
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objAlmacen.id_almacen = CInt(cmd.Parameters.Item("@id_almacen").Value)
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
        Return objAlmacen
    End Function

    Sub Modificar(ByVal objAlmacen As Almacen)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarAlmacen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_almacen", objAlmacen.id_almacen)
            .AddWithValue("@id_sucursal", objAlmacen.id_sucursal)
            .AddWithValue("@descripcion", objAlmacen.descripcion)
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

    Sub Eliminar(ByVal id_almacen As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarAlmacen", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_almacen", id_almacen)

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
        Dim da As New SqlDataAdapter("sp_ListarAlmacen", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal objAlmacen As Almacen) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarAlmacenXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_almacen ", objAlmacen.id_almacen)
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
    Public Function Listar(ByVal Id_sucursal As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarAlmacenXSucursal", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_sucursal ", Id_sucursal)
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
