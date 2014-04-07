Imports System.Data.SqlClient
Imports Entidades
Public Class RNEmpresa
    Public Function Registrar(ByVal objEmpresa As Empresa) As Empresa
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarEmpresa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_empresa", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@ruc", objEmpresa.ruc)
            .AddWithValue("@razon_social", objEmpresa.razon_social)
            .AddWithValue("@direccion", objEmpresa.direccion)
            .AddWithValue("@telefono", objEmpresa.telefono)
           
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objEmpresa.id_empresa = CInt(cmd.Parameters.Item("@id_empresa").Value)
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
        Return objEmpresa
    End Function

    Sub Modificar(ByVal objEmpresa As Empresa)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarEmpresa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_empresa", objEmpresa.id_empresa)
            .AddWithValue("@ruc", objEmpresa.ruc)
            .AddWithValue("@razon_social", objEmpresa.razon_social)
            .AddWithValue("@direccion", objEmpresa.direccion)
            .AddWithValue("@telefono", objEmpresa.telefono)
            
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

    Sub Eliminar(ByVal id_empresa As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarEmpresa", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_empresa", id_empresa)

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
        Dim da As New SqlDataAdapter("sp_ListarEmpresa", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
End Class
