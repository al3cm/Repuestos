Imports System.Data.SqlClient
Imports Entidades
Public Class RNLetras
    Public Function CargarClientes(ByVal Id_cliente As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarCargarClientes", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_cliente", Id_cliente)
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
    Public Function CargarLetras(ByVal Id_cliente As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarCargarLetras", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_cliente", Id_cliente)
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
    Public Function CargarDetalle(ByVal Id_Letras As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarCargarDetalleLetras", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_letras", Id_Letras)
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
    Public Function Registrar(ByVal objLetras As Letras) As Letras
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarLetras", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_letras", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_venta", objLetras.id_venta)
            .AddWithValue("@coprobrante", objLetras.coprobrante)
            .AddWithValue("@fecha_emision", objLetras.fecha_emision)
            .AddWithValue("@tasa", objLetras.tasa)
            .AddWithValue("@saldo", objLetras.saldo)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objLetras.id_letras = CInt(cmd.Parameters.Item("@id_letras").Value)
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
        Return objLetras
    End Function
    Public Function RegistrarDetalle(ByVal objLetras As Letras) As Letras
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarDetalle_Letras", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_deralle_letras", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_letras", objLetras.id_letras)
            .AddWithValue("@num_letra", objLetras.num_letra)
            .AddWithValue("@dias", objLetras.dias)
            .AddWithValue("@fecha_vencimiento", objLetras.fecha_vencimiento)
            .AddWithValue("@monto", objLetras.monto)
            .AddWithValue("@descripcion", objLetras.descripcion)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objLetras.id_Detalle = CInt(cmd.Parameters.Item("@id_deralle_letras").Value)
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
        Return objLetras
    End Function
    Public Function RegistrarPagosLetras(ByVal objLetras As Letras) As Letras
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarPagos_Letras", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_pagos_letras", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_detalle_letras", objLetras.id_Detalle)
            .AddWithValue("@id_personal", objLetras.id_personal)
            .AddWithValue("@fecha", objLetras.fecha)
            .AddWithValue("@tipo_cambio", objLetras.tipo_cambio)
            .AddWithValue("@total", objLetras.total)
            .AddWithValue("@observaciones", objLetras.observaciones)
            .AddWithValue("@tipo_pago", objLetras.tipo_pago)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objLetras.id_pagos_letras = CInt(cmd.Parameters.Item("@id_pagos_letras").Value)
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
        Return objLetras
    End Function
    Public Sub RegistrarDetallePagosLetras(ByVal objLetras As Letras)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarDetalle_Pagos_Letras", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_detalle_letras", objLetras.id_Detalle)
            .AddWithValue("@id_pagos_letras", objLetras.id_pagos_letras)
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

    Sub Eleminar(ByVal Id_letras As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarLetras", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_letras", Id_letras)

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
    Sub EleminarDetalle(ByVal Id_letras As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarDetalle_Letras", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_letras", Id_letras)

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
    Sub EleminarDetalleXID(ByVal id_Detalle As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarDetalle_LetrasXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_detalle_letras", id_Detalle)

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
        Dim da As New SqlDataAdapter("sp_ListarLetras", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal Id_Letras As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarLetrasXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Letras", Id_Letras)
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
    Public Function ListarDetalle(ByVal Id_Letras As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarDetalleLetras", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Letras", Id_Letras)
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
    Public Function ListarCuenta(ByVal Id_Almacen As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarCuenta", cn)
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
    Public Function ListarCuenta(ByVal Id_Almacen As Integer, ByVal Fecha_Ini As Date, ByVal Fecha_Fin As Date) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarCuentaXFecha", cn)
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
    Public Function ListarCuenta(ByVal Id_Almacen As Integer, ByVal Nombre As String) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("ListarCuentaXNombre", cn)
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
    Public Function ListarCuenta(ByVal Id_Almacen As Integer, ByVal Fecha_Ini As Date, ByVal Fecha_Fin As Date, ByVal Nombre As String) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarCuentaXFechaYNombre", cn)
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
    Public Function buscarid() As Integer
        Dim id As Integer
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_BuscarIdLetra", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@Letra", SqlDbType.TinyInt).Direction = ParameterDirection.Output
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            id = CInt(cmd.Parameters.Item("@Letra").Value)
        Catch ex As Exception
            Throw
        End Try
        Return id
    End Function
    Public Function ContraLetra(ByVal Id_letras As Integer) As Integer
        Dim id As Integer
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ContraLetra", cn)
        cmd.Parameters.AddWithValue("@id_letras", Id_letras)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@Letra", SqlDbType.TinyInt).Direction = ParameterDirection.Output
        End With
        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            id = CInt(cmd.Parameters.Item("@Letra").Value)
        Catch ex As Exception
            Throw
        End Try
        Return id
    End Function
End Class
