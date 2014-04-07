Imports System.Data.SqlClient
Imports Entidades
Public Class RNUbigeo
    Public Shared Function Listar() As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim da As New SqlDataAdapter("sp_ListarUbigeo", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Shared Function Listar(ByVal id_Ubigeueo As String) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim distritro As String = Mid(id_Ubigeueo, 3, 2)
        Dim Provicia As String
        Dim Depatamento As String
        If distritro = "00" Then
            Depatamento = Mid(id_Ubigeueo, 1, 2)
            Dim cmd As New SqlCommand("sp_ListarProvicia", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Depatamento", Depatamento)
            Try
                cn.Open()
                cmd.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds)
            Catch ex As Exception
                Throw
            End Try
        Else
            Provicia = Mid(id_Ubigeueo, 1, 4)
            Dim cmd As New SqlCommand("sp_ListarDistritro", cn)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@Provicia", Provicia)
            Try
                cn.Open()
                cmd.ExecuteNonQuery()
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(ds)
            Catch ex As Exception
                Throw
            End Try
        End If
        Return ds
    End Function
End Class
