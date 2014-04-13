Imports System.Data.SqlClient
Imports Entidades
Public Class RNFacturacion
    Public Function RegistrarFacturacion(ByVal objFacturacion As Facturacion) As Facturacion
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarMovimiento", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_movimiento", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_caja", objFacturacion.id_caja)
            .AddWithValue("@id_operacion", objFacturacion.Id_Operacion)
            .AddWithValue("@id_almacen", objFacturacion.id_almacen)
            .AddWithValue("@id_tipodocumento", objFacturacion.id_tipodocumento)
            .AddWithValue("@numero_documento", objFacturacion.numero_documento)
            .AddWithValue("@serie_documento", objFacturacion.serie_documento)
            .AddWithValue("@tipo_movimiento", objFacturacion.Tipo_movimiento)
            .AddWithValue("@monto", objFacturacion.monto)
            .AddWithValue("@fecha_movimiento", objFacturacion.fecha_movimiento)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objFacturacion.id_movimiento = CInt(cmd.Parameters.Item("@id_movimiento").Value)
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
        Return objFacturacion
    End Function
    Public Function RegistrarFacturacionConCambion(ByVal objFacturacion As Facturacion) As Facturacion
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarMovimientoConCambion", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_movimiento", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@id_caja", objFacturacion.id_caja)
            .AddWithValue("@id_operacion", objFacturacion.Id_Operacion)
            .AddWithValue("@id_almacen", objFacturacion.id_almacen)
            .AddWithValue("@id_tipodocumento", objFacturacion.id_tipodocumento)
            .AddWithValue("@numero_documento", objFacturacion.numero_documento)
            .AddWithValue("@serie_documento", objFacturacion.serie_documento)
            .AddWithValue("@tipo_movimiento", objFacturacion.Tipo_movimiento)
            .AddWithValue("@monto", objFacturacion.monto)
            .AddWithValue("@fecha_movimiento", objFacturacion.fecha_movimiento)
            .AddWithValue("@tipo_cambio", objFacturacion.tipo_cambio)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objFacturacion.id_movimiento = CInt(cmd.Parameters.Item("@id_movimiento").Value)
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
        Return objFacturacion
    End Function
    Sub ModificarFacturacion(ByVal objFacturacion As Facturacion)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarMovimiento", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_movimiento", objFacturacion.id_movimiento)
            .AddWithValue("@id_caja", objFacturacion.id_caja)
            .AddWithValue("@id_operacion", objFacturacion.Id_Operacion)
            .AddWithValue("@id_almacen", objFacturacion.id_almacen)
            .AddWithValue("@id_tipodocumento", objFacturacion.id_tipodocumento)
            .AddWithValue("@numero_documento", objFacturacion.numero_documento)
            .AddWithValue("@serie_documento", objFacturacion.serie_documento)
            .AddWithValue("@monto", objFacturacion.monto)
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
    Sub EleminarFacturacion(ByVal id_Facturacion As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarMovimiento", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_movimiento", id_Facturacion)

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

    Shared Function resumenCaja(ByVal fechaIni As Date, ByVal fechaFin As Date, ByVal id_Caja As Integer, ByVal id_Almacen As Integer) As DataTable

        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim da As New SqlDataAdapter("sp_ResumenCaja", cn)

        Try
            da.SelectCommand.Parameters.Add("fechaIni", SqlDbType.SmallDateTime)
            da.SelectCommand.Parameters("fechaIni").Value = fechaIni
            da.SelectCommand.Parameters.Add("fechaFin", SqlDbType.SmallDateTime)
            da.SelectCommand.Parameters("fechaFin").Value = fechaFin
            da.SelectCommand.Parameters.Add("id_caja", SqlDbType.SmallInt)
            da.SelectCommand.Parameters("id_caja").Value = id_Caja
            da.SelectCommand.Parameters.Add("id_almacen", SqlDbType.SmallInt)
            da.SelectCommand.Parameters("id_almacen").Value = id_Almacen

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
End Class
