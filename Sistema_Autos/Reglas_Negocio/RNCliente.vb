Imports System.Data.SqlClient
Imports Entidades
Public Class RNCliente
    Public Function Registrar(ByVal objCliente As Cliente) As Cliente
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarCliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_cliente", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@razon_social", objCliente.razon_social)
            .AddWithValue("@ruc", objCliente.ruc)
            .AddWithValue("@dni", objCliente.dni)
            .AddWithValue("@direccion", objCliente.direccion)
            .AddWithValue("@telefono", objCliente.telefono)
            .AddWithValue("@celular", objCliente.celular)
            .AddWithValue("@estado", objCliente.estado)
            .AddWithValue("@tipo_cliente", objCliente.tipo_cliente)
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objCliente.id_cliente = CInt(cmd.Parameters.Item("@id_cliente").Value)
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
        Return objCliente
    End Function

    Sub Modificar(ByVal objCliente As Cliente)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarCliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_cliente", objCliente.id_cliente)
            .AddWithValue("@razon_social", objCliente.razon_social)
            .AddWithValue("@ruc", objCliente.ruc)
            .AddWithValue("@dni", objCliente.dni)
            .AddWithValue("@direccion", objCliente.direccion)
            .AddWithValue("@telefono", objCliente.telefono)
            .AddWithValue("@celular", objCliente.celular)
            .AddWithValue("@estado", objCliente.estado)
            .AddWithValue("@tipo_cliente", objCliente.tipo_cliente)
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

    Sub Eliminar(ByVal id_cliente As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarCliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_cliente", id_cliente)

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
        Dim da As New SqlDataAdapter("sp_ListarCliente", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal Id_Cliente As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaClienteXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Cliente", Id_Cliente)
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
