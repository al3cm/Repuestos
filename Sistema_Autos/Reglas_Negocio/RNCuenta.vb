Imports System.Data.SqlClient
Imports Entidades
Public Class RNCuenta
    Public Function RegistrarCuenta(ByVal objCuenta As Cuenta) As Cuenta
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarCuenta", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_cuenta", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_compra", objCuenta.id_compra)
            .AddWithValue("@pago_inicial", objCuenta.pago_inicial)
            .AddWithValue("@monto_financiado", objCuenta.monto_financiado)
            .AddWithValue("@nro_cuotas", objCuenta.nro_cuotas)
            .AddWithValue("@deudad", objCuenta.deudad)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objCuenta.id_cuenta = CInt(cmd.Parameters.Item("@id_cuenta").Value)
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
        Return objCuenta
    End Function
    Sub PagarDeuda(ByVal objCuenta As Cuenta)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_PagarDeuda", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_cuenta", objCuenta.id_cuenta)
            .AddWithValue("@deudad", objCuenta.deudad)
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
    Sub EliminarCuenta(ByVal id_cuenta As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarCuenta", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_cuenta", id_cuenta)

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
    Public Function ListarDeuda(ByVal Id_Almacen As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarDeuda", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Almacen", Id_Almacen)
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
    Public Function ListarDeuda(ByVal Id_Almacen As Integer, ByVal Fecha_Ini As Date, ByVal Fecha_Fin As Date) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("ListarDeudaXFecha", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Almacen", Id_Almacen)
        cmd.Parameters.AddWithValue("@fecha_Ini", Fecha_Ini)
        cmd.Parameters.AddWithValue("@fecha_Fin", Fecha_Fin)
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
    Public Function ListarDeuda(ByVal Id_Almacen As Integer, ByVal Nombre As String) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("ListarDeudaXNombre", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Almacen", Id_Almacen)
        cmd.Parameters.AddWithValue("@nombre", Nombre)
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
    Public Function ListarDeuda(ByVal Id_Almacen As Integer, ByVal Fecha_Ini As Date, ByVal Fecha_Fin As Date, ByVal Nombre As String) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarDeudaXFechaYNombre", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Almacen", Id_Almacen)
        cmd.Parameters.AddWithValue("@fecha_Ini", Fecha_Ini)
        cmd.Parameters.AddWithValue("@fecha_Fin", Fecha_Fin)
        cmd.Parameters.AddWithValue("@nombre", Nombre)
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
End Class
