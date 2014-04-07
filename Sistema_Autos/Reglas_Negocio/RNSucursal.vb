Imports System.Data.SqlClient
Imports Entidades
Public Class RNSucursal
    Public Function Registrar(ByVal objSucursal As Sucursal) As Sucursal
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarSucursal", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_sucursal", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@descripcion", objSucursal.descripcion)
            .AddWithValue("@direccion", objSucursal.direccion)
            .AddWithValue("@telefono", objSucursal.telefono)

          
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objSucursal.id_sucursal = CInt(cmd.Parameters.Item("@id_sucursal").Value)
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
        Return objSucursal
    End Function

    Sub Modificar(ByVal objSucursal As Sucursal)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarSucursal", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_sucursal", objSucursal.id_sucursal)
            .AddWithValue("@descripcion", objSucursal.descripcion)
            .AddWithValue("@direccion", objSucursal.direccion)
            .AddWithValue("@telefono", objSucursal.telefono)
     
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

    Sub Eliminar(ByVal id_sucursal As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarSucursal", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal)

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

    Public Shared Function Listar() As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim da As New SqlDataAdapter("sp_ListarSucursal", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
End Class
