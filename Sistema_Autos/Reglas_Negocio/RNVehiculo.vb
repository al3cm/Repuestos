Imports System.Data.SqlClient
Imports Entidades
Public Class RNVehiculo
    Public Function Registrar(ByVal objVehiculo As Vehiculo) As Vehiculo
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarVehiculo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_vehiculo", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_cliente", objVehiculo.id_cliente)
            .AddWithValue("@placa", objVehiculo.placa)
            .AddWithValue("@id_marca", objVehiculo.id_marca)
            .AddWithValue("@modelo", objVehiculo.modelo)
            .AddWithValue("@tipo_vehiculo", objVehiculo.tipo_vehiculo)
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objVehiculo.id_vehiculo = CInt(cmd.Parameters.Item("@id_vehiculo").Value)
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
        Return objVehiculo
    End Function

    Sub Modificar(ByVal objVehiculo As Vehiculo)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarVehiculo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_vehiculo", objVehiculo.id_vehiculo)
            .AddWithValue("@id_cliente", objVehiculo.id_cliente)
            .AddWithValue("@placa", objVehiculo.placa)
            .AddWithValue("@id_marca", objVehiculo.id_marca)
            .AddWithValue("@modelo", objVehiculo.modelo)
            .AddWithValue("@tipo_vehiculo", objVehiculo.tipo_vehiculo)
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

    Sub Eliminar(ByVal id_vehiculo As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarVehiculo", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_vehiculo", id_vehiculo)

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
        Dim da As New SqlDataAdapter("sp_ListarVehiculo", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
End Class
