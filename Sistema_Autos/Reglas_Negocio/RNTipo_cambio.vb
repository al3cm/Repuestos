Imports System.Data.SqlClient
Imports Entidades
Public Class RNTipo_cambio
    Public Function RegistrarTipo_cambio(ByVal objTipo_cambio As Tipo_cambio) As Tipo_cambio
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarTipo_Cambio", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_tipo_cambio", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@cambio_venta", objTipo_cambio.cambio_venta)
            .AddWithValue("@cambio_compra", objTipo_cambio.cambio_compra)
            .AddWithValue("@cambio_empresa", objTipo_cambio.cambio_empresa)
            .AddWithValue("@fecha_inicio", objTipo_cambio.fecha_inicio)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objTipo_cambio.id_tipo_cambio = CInt(cmd.Parameters.Item("@id_tipo_cambio").Value)
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
        Return objTipo_cambio
    End Function
    Sub EleminarTipo_Cambio(ByVal objTipo_cambio As Tipo_cambio)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarTipo_Cambio", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_tipo_cambio", objTipo_cambio.id_tipo_cambio)
        cmd.Parameters.AddWithValue("@fecha_fin", objTipo_cambio.fecha_fin)
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
        Dim da As New SqlDataAdapter("sp_LitarTipo_Cambio", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
End Class
