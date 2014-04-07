Imports System.Data.SqlClient
Imports Entidades
Public Class RNFacturacion
    Public Function buscarid(ByVal Serie As String, ByVal Domnento As Integer) As Integer
        Dim id As Integer
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_BuscarIdMovimiento", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_Movimiento", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_tipodocumento", Domnento)
            .AddWithValue("@numero_documento", Serie)
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            id = CInt(cmd.Parameters.Item("@id_Movimiento").Value)
        Catch ex As Exception
            Throw
        End Try
        Return id
    End Function
End Class
