Imports System.Data.SqlClient
Imports Entidades
Public Class RNNota_Debito_Proveedor
    Public Function RegistrarNota_Debito_Proveedor(ByVal objNota_Debito_Proveedor As Nota_Debito_Proveedor) As Nota_Debito_Proveedor
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarNota_Debito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_nota_Debito", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_compra", objNota_Debito_Proveedor.id_compra)
            .AddWithValue("@nro_nota_Debito", objNota_Debito_Proveedor.nro_nota_Debito)
            .AddWithValue("@serie_nota_Debito", objNota_Debito_Proveedor.serie_nota_Debito)
            .AddWithValue("@fecha_emision", objNota_Debito_Proveedor.fecha_emision)
            .AddWithValue("@Motivo", objNota_Debito_Proveedor.Motivo)
            .AddWithValue("@total", objNota_Debito_Proveedor.total)
            .AddWithValue("@subtotal", objNota_Debito_Proveedor.subtotal)
            .AddWithValue("@igv", objNota_Debito_Proveedor.igv)
            .AddWithValue("@Saldo_Pendiente", objNota_Debito_Proveedor.Saldo_Pendiente)
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objNota_Debito_Proveedor.id_nota_Debito = CInt(cmd.Parameters.Item("@id_nota_Debito").Value)
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
        Return objNota_Debito_Proveedor
    End Function
    Public Sub RegistrarDetalle_Nota_Debito_Proveedor(ByVal objNota_Debito_Proveedor As Nota_Debito_Proveedor)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarDetalle_Nota_Debito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_nota_Debito", objNota_Debito_Proveedor.id_nota_Debito)
            .AddWithValue("@id_producto", objNota_Debito_Proveedor.id_producto)
            .AddWithValue("@cantidad", objNota_Debito_Proveedor.cantidad)
            .AddWithValue("@precio_compra", objNota_Debito_Proveedor.precio_compra)
            .AddWithValue("@descuento", objNota_Debito_Proveedor.descuento)
            .AddWithValue("@Sub_Total", objNota_Debito_Proveedor.Sub_Total)
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
    Sub ModificarNota_Debito_Proveedor(ByVal objNota_Debito_Proveedor As Nota_Debito_Proveedor)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarNota_Debito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_nota_Debito", objNota_Debito_Proveedor.id_nota_debito)
            .AddWithValue("@id_compra", objNota_Debito_Proveedor.id_compra)
            .AddWithValue("@nro_nota_Debito", objNota_Debito_Proveedor.nro_nota_Debito)
            .AddWithValue("@serie_nota_Debito", objNota_Debito_Proveedor.serie_nota_Debito)
            .AddWithValue("@fecha_emision", objNota_Debito_Proveedor.fecha_emision)
            .AddWithValue("@Motivo", objNota_Debito_Proveedor.Motivo)
            .AddWithValue("@total", objNota_Debito_Proveedor.total)
            .AddWithValue("@subtotal", objNota_Debito_Proveedor.subtotal)
            .AddWithValue("@igv", objNota_Debito_Proveedor.igv)
            .AddWithValue("@Saldo_Pendiente", objNota_Debito_Proveedor.Saldo_Pendiente)
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
    Sub EleminarDetalle_Nota_Debito_Proveedor(ByVal id_Nota_Debito_Proveedor As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarDetalle_Nota_Debito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_nota_Debito", id_Nota_Debito_Proveedor)
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
    Sub EleminarNota_Debito_Proveedor(ByVal id_Nota_Debito_Proveedor As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarNota_Debito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@@id_nota_Debito", id_Nota_Debito_Proveedor)
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
        Dim da As New SqlDataAdapter("sp_ListarNota_Debito_Proveedor", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal Id_Nota_Debito_Proveedor As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaNota_Debito_ProveedorXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Nota_Debito", Id_Nota_Debito_Proveedor)
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
    Public Function ListarDetalle(ByVal Id_Nota_Debito_Proveedor As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListaDetalleNota_Debito_ProveedorXNota_Debito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Nota_Debito", Id_Nota_Debito_Proveedor)
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
        Dim cmd As New SqlCommand("sp_BuscarIdNota_Debito_Proveedor", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_Nota_Debito", SqlDbType.TinyInt).Direction = ParameterDirection.Output
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            id = CInt(cmd.Parameters.Item("@id_Nota_Debito").Value)
        Catch ex As Exception
            Throw
        End Try
        Return id
    End Function
End Class
