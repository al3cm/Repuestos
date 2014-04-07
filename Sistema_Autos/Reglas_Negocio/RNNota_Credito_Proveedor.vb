Imports System.Data.SqlClient
Imports Entidades
Public Class RNNota_Credito_Proveedor
    Public Function RegistrarNota_Credito_Proveedor(ByVal objNota_Credito_Proveedor As Nota_Credito_Proveedor) As Nota_Credito_Proveedor
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarNota_Credito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_nota_credito", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@nro_nota_credito", objNota_Credito_Proveedor.nro_nota_credito)
            .AddWithValue("@serie_nota_credito", objNota_Credito_Proveedor.serie_nota_credito)
            .AddWithValue("@fecha_emision", objNota_Credito_Proveedor.fecha_emision)
            .AddWithValue("@Motivo", objNota_Credito_Proveedor.Motivo)
            .AddWithValue("@total", objNota_Credito_Proveedor.total)
            .AddWithValue("@subtotal", objNota_Credito_Proveedor.subtotal)
            .AddWithValue("@igv", objNota_Credito_Proveedor.igv)
            .AddWithValue("@Saldo_Pendiente", objNota_Credito_Proveedor.Saldo_Pendiente)
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objNota_Credito_Proveedor.id_nota_credito = CInt(cmd.Parameters.Item("@id_nota_credito").Value)
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
        Return objNota_Credito_Proveedor
    End Function
    Public Sub RegistrarDetalle_Nota_Credito_Proveedor(ByVal objNota_Credito_Proveedor As Nota_Credito_Proveedor)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarDetalle_Nota_Credito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_nota_credito", objNota_Credito_Proveedor.id_nota_credito)
            .AddWithValue("@id_compra", objNota_Credito_Proveedor.id_compra)
            .AddWithValue("@id_producto", objNota_Credito_Proveedor.id_producto)
            .AddWithValue("@cantidad", objNota_Credito_Proveedor.cantidad)
            .AddWithValue("@precio_compra", objNota_Credito_Proveedor.precio_compra)
            .AddWithValue("@descuento", objNota_Credito_Proveedor.descuento)
            .AddWithValue("@Sub_Total", objNota_Credito_Proveedor.Sub_Total)
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
    Sub ModificarNota_Credito_Proveedor(ByVal objNota_Credito_Proveedor As Nota_Credito_Proveedor)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarNota_Credito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_nota_credito", objNota_Credito_Proveedor.id_nota_credito)
            .AddWithValue("@nro_nota_credito", objNota_Credito_Proveedor.nro_nota_credito)
            .AddWithValue("@serie_nota_credito", objNota_Credito_Proveedor.serie_nota_credito)
            .AddWithValue("@fecha_emision", objNota_Credito_Proveedor.fecha_emision)
            .AddWithValue("@Motivo", objNota_Credito_Proveedor.Motivo)
            .AddWithValue("@total", objNota_Credito_Proveedor.total)
            .AddWithValue("@subtotal", objNota_Credito_Proveedor.subtotal)
            .AddWithValue("@igv", objNota_Credito_Proveedor.igv)
            .AddWithValue("@Saldo_Pendiente", objNota_Credito_Proveedor.Saldo_Pendiente)
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
    Sub EleminarDetalle_Nota_Credito_Proveedor(ByVal id_Nota_Credito_Proveedor As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarDetalle_Nota_Credito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_nota_credito", id_Nota_Credito_Proveedor)
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
    Sub EleminarNota_Credito_Proveedor(ByVal id_Nota_Credito_Proveedor As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarNota_Credito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@@id_nota_credito", id_Nota_Credito_Proveedor)
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
        Dim da As New SqlDataAdapter("sp_ListarNota_Credito_Proveedor", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal Id_Nota_Credito_Proveedor As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaNota_Credito_ProveedorXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Nota_Credito", Id_Nota_Credito_Proveedor)
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
    Public Function ListarDetalle(ByVal Id_Nota_Credito_Proveedor As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaDetalleNota_Credito_ProveedorXNota_Credito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Nota_Credito", Id_Nota_Credito_Proveedor)
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
        Dim cmd As New SqlCommand("sp_BuscarIdNota_Credito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_nota_credito", SqlDbType.TinyInt).Direction = ParameterDirection.Output
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            id = CInt(cmd.Parameters.Item("@id_nota_credito").Value)
        Catch ex As Exception
            Throw
        End Try
        Return id
    End Function
End Class
