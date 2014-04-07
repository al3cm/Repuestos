Imports System.Data.SqlClient
Imports Entidades
Public Class RNTipoDocumento
    Public Function Registrar(ByVal objTipoDocumento As TipoDocumento) As TipoDocumento
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarTipoDocumento", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_tipodocumento", objTipoDocumento.id_tipodocumento)
            .AddWithValue("@abreviatura", objTipoDocumento.abreviatura)
            .AddWithValue("@descripcion", objTipoDocumento.descripcion)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objTipoDocumento.id_tipodocumento = CInt(cmd.Parameters.Item("@id_tipodocumento").Value)
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
        Return objTipoDocumento
    End Function

    Sub Modificar(ByVal objTipoDocumento As TipoDocumento)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarTipoDocumento", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_tipodocumento", objTipoDocumento.id_tipodocumento)
            .AddWithValue("@abreviatura", objTipoDocumento.abreviatura)
            .AddWithValue("@descripcion", objTipoDocumento.descripcion)
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

    Sub Eliminar(ByVal id_tipodocumento As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarTipoDocumento", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_tipodocumento", id_tipodocumento)

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
        Dim da As New SqlDataAdapter("sp_ListarTipoDocumento", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function buscarid() As Integer
        Dim id As Integer
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_BuscarIdTipoDocumento", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_TipoDocumento", SqlDbType.TinyInt).Direction = ParameterDirection.Output
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            id = CInt(cmd.Parameters.Item("@id_TipoDocumento").Value)
        Catch ex As Exception
            Throw
        End Try
        Return id
    End Function
End Class
