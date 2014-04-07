Imports System.Data.SqlClient
Imports Entidades
Public Class RNDetalle_Caja
    Public Function ListarCaja() As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim da As New SqlDataAdapter("sp_ListarCaja", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Sub RegistrarDetalle_Caja(ByVal objDetalle_Caja As Detalle_Caja)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarDetalle_Caja", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_Caja", objDetalle_Caja.id_caja)
            .AddWithValue("@id_almacen", objDetalle_Caja.id_almacen)
            .AddWithValue("@descripcion", objDetalle_Caja.descripcion)
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
End Class
