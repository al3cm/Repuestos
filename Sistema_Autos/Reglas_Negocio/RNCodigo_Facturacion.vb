Imports System.Data.SqlClient
Imports Entidades
Public Class RNCodigo_Facturacion
    Sub Registrar(ByVal objCodigo_Facturacion As Codigo_Facturacion)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarCodigo_Facturacion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_Codigo", objCodigo_Facturacion.id_Codigo)
            .AddWithValue("@id_almacen", objCodigo_Facturacion.id_almacen)
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
    Sub Eliminar(ByVal id_Codigo As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarCodigo_Facturacion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Codigo", id_Codigo)

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
    Public Function Listar(ByVal id_almacen As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarCodigo_Facturacion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_almacen ", id_almacen)
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
    Public Function Contra(ByVal id_Codigo As String) As Integer
        Dim Cantidad As Integer
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ContraCodigo_Facturacion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@Cantidad", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_Codigo", id_Codigo)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            Cantidad = CInt(cmd.Parameters.Item("@Cantidad").Value)
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
        Return Cantidad
    End Function
End Class
