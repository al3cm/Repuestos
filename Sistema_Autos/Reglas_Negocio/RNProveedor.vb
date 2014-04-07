Imports System.Data.SqlClient
Imports Entidades
Public Class RNProveedor

    Public Function Registrar(ByVal objProveedor As Proveedor) As Proveedor
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarProveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_proveedor", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_ubigeo", objProveedor.id_ubigeo)
            .AddWithValue("@razon_social", objProveedor.razon_social)
            .AddWithValue("@ruc", objProveedor.ruc)
            .AddWithValue("@direccion", objProveedor.direccion)
            .AddWithValue("@telefono", objProveedor.telefono)
            .AddWithValue("@fax", objProveedor.fax)
            .AddWithValue("@contacto", objProveedor.contacto)
            .AddWithValue("@email", objProveedor.email)
            .AddWithValue("@descripcion", objProveedor.descripcion)
            If objProveedor.estado Then
                .AddWithValue("@estado", 1)
            Else
                .AddWithValue("@estado", 0)
            End If

        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objProveedor.id_proveedor = CInt(cmd.Parameters.Item("@id_proveedor").Value)
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
        Return objProveedor
    End Function

    Sub Modificar(ByVal objProveedor As Proveedor)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarProveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_proveedor", objProveedor.id_proveedor)
            .AddWithValue("@id_ubigeo", objProveedor.id_ubigeo)
            .AddWithValue("@razon_social", objProveedor.razon_social)
            .AddWithValue("@ruc", objProveedor.ruc)
            .AddWithValue("@direccion", objProveedor.direccion)
            .AddWithValue("@telefono", objProveedor.telefono)
            .AddWithValue("@fax", objProveedor.fax)
            .AddWithValue("@contacto", objProveedor.contacto)
            .AddWithValue("@email", objProveedor.email)
            .AddWithValue("@descripcion", objProveedor.descripcion)
            ' Added 2014.03.23
            If objProveedor.estado Then
                .AddWithValue("@estado", "1")
            Else
                .AddWithValue("@estado", "0")
            End If


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

    Sub Eliminar(ByVal id_proveedor As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarProveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor)

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
        Dim da As New SqlDataAdapter("sp_ListarProveedor", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal Id_Proveedor As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaProveedorXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Proveedor", Id_Proveedor)
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
