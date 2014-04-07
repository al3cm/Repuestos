Imports System.Data.SqlClient
Imports Entidades
Public Class RNNota_Credito_Cliente
    Public Function RegistrarNota_Credito_Cliente(ByVal objNota_Credito_Cliente As Nota_Credito_Cliente) As Nota_Credito_Cliente
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarNota_Credito_Cliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_nota_credito", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@nro_nota_credito", objNota_Credito_Cliente.nro_nota_credito)
            .AddWithValue("@serie_nota_credito", objNota_Credito_Cliente.serie_nota_credito)
            .AddWithValue("@fecha_emision", objNota_Credito_Cliente.fecha_emision)
            .AddWithValue("@total", objNota_Credito_Cliente.total)
            .AddWithValue("@subtotal", objNota_Credito_Cliente.subtotal)
            .AddWithValue("@igv", objNota_Credito_Cliente.igv)
            .AddWithValue("@Saldo_Pendiente", objNota_Credito_Cliente.Saldo_Pendiente)
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objNota_Credito_Cliente.id_nota_credito = CInt(cmd.Parameters.Item("@id_nota_credito").Value)
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
        Return objNota_Credito_Cliente
    End Function
    Public Sub RegistrarDetalle_Nota_Credito_Cliente(ByVal objNota_Credito_Cliente As Nota_Credito_Cliente)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarDetalle_Nota_Credito_Cliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_nota_credito", objNota_Credito_Cliente.id_nota_credito)
            .AddWithValue("@id_venta", objNota_Credito_Cliente.id_venta)
            .AddWithValue("@id_producto", objNota_Credito_Cliente.id_producto)
            .AddWithValue("@cantidad", objNota_Credito_Cliente.cantidad)
            .AddWithValue("@precio_venta", objNota_Credito_Cliente.precio_venta)
            .AddWithValue("@descuento", objNota_Credito_Cliente.descuento)
            .AddWithValue("@Sub_Total", objNota_Credito_Cliente.Sub_Total)
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
    Sub ModificarNota_Credito_Cliente(ByVal objNota_Credito_Cliente As Nota_Credito_Cliente)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarNota_Credito_Cliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_nota_credito", objNota_Credito_Cliente.id_nota_credito)
            .AddWithValue("@nro_nota_credito", objNota_Credito_Cliente.nro_nota_credito)
            .AddWithValue("@serie_nota_credito", objNota_Credito_Cliente.serie_nota_credito)
            .AddWithValue("@fecha_emision", objNota_Credito_Cliente.fecha_emision)
            .AddWithValue("@total", objNota_Credito_Cliente.total)
            .AddWithValue("@subtotal", objNota_Credito_Cliente.subtotal)
            .AddWithValue("@igv", objNota_Credito_Cliente.igv)
            .AddWithValue("@Saldo_Pendiente", objNota_Credito_Cliente.Saldo_Pendiente)
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
    Sub EleminarDetalle_Nota_Credito_Cliente(ByVal id_Nota_Credito_Cliente As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarDetalle_Nota_Credito_Cliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_nota_credito", id_Nota_Credito_Cliente)
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
    Sub EleminarNota_Credito_Cliente(ByVal id_Nota_Credito_Cliente As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarNota_Credito_Cliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@@id_nota_credito", id_Nota_Credito_Cliente)
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
        Dim da As New SqlDataAdapter("sp_ListarNota_Credito_Cliente", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal Id_Nota_Credito_Cliente As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaNota_Credito_ClienteXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Nota_Credito", Id_Nota_Credito_Cliente)
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
    Public Function ListarDetalle(ByVal Id_Nota_Credito_Cliente As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaDetalleNota_Credito_ClienteXNota_Credito_Cliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Nota_Credito", Id_Nota_Credito_Cliente)
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
    Public Function buscarid() As Integer
        Dim id As Integer
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_BuscarIdNota_Credito_Cliente", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_Nota_Credito", SqlDbType.TinyInt).Direction = ParameterDirection.Output
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            id = CInt(cmd.Parameters.Item("@id_Nota_Credito").Value)
        Catch ex As Exception
            Throw
        End Try
        Return id
    End Function
End Class
