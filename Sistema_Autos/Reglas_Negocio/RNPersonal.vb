Imports System.Data.SqlClient
Imports Entidades
Public Class RNPersonal
    Public Function Registrar(ByVal objPersonal As Personal) As Personal
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_RegistrarPersonal", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .Add("@id_personal", SqlDbType.TinyInt).Direction = ParameterDirection.Output
            .AddWithValue("@nombres", objPersonal.nombres)
            .AddWithValue("@ap_paterno", objPersonal.ap_paterno)
            .AddWithValue("@ap_materno", objPersonal.ap_materno)
            .AddWithValue("@dni", objPersonal.dni)
            .AddWithValue("@direccion", objPersonal.direccion)
            .AddWithValue("@telefono", objPersonal.telefono)
            .AddWithValue("@celular", objPersonal.celular)
            .AddWithValue("@estado", objPersonal.estado)
            .AddWithValue("@cargo", objPersonal.cargo)
            .AddWithValue("@usuario", objPersonal.usuario)
            .AddWithValue("@clave", objPersonal.clave)
        End With

        Try
            cn.Open()
            cmd.ExecuteNonQuery()
            objPersonal.id_personal = CInt(cmd.Parameters.Item("@id_personal").Value)
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
        Return objPersonal
    End Function

    Sub Modificar(ByVal objPersonal As Personal)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarPersonal", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_personal", objPersonal.id_personal)
            .AddWithValue("@nombres", objPersonal.nombres)
            .AddWithValue("@ap_paterno", objPersonal.ap_paterno)
            .AddWithValue("@ap_materno", objPersonal.ap_materno)
            .AddWithValue("@dni", objPersonal.dni)
            .AddWithValue("@direccion", objPersonal.direccion)
            .AddWithValue("@telefono", objPersonal.telefono)
            .AddWithValue("@celular", objPersonal.celular)
            .AddWithValue("@estado", objPersonal.estado)
            .AddWithValue("@cargo", objPersonal.cargo)
            .AddWithValue("@usuario", objPersonal.usuario)
            .AddWithValue("@clave", objPersonal.clave)
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
    Sub Eliminar(ByVal id_personal As String)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_EliminarPersonal", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_personal", id_personal)

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
        Dim da As New SqlDataAdapter("sp_ListarPersonal", cn)
        Try
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    Public Function Listar(ByVal Id_Personal As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ListarPersonalXID", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Personal", Id_Personal)
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


    'ADD: 2014.03.04
    Shared Function Login(ByVal usuario As String, ByVal clave As String) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim da As New SqlDataAdapter("sp_LoginUsuario", cn)

        Try
            da.SelectCommand.Parameters.Add("usuario", SqlDbType.VarChar)
            da.SelectCommand.Parameters("usuario").Value = usuario
            da.SelectCommand.Parameters.Add("clave", SqlDbType.VarChar)
            da.SelectCommand.Parameters("clave").Value = clave
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function
    'ADD: 2014.03.05

    Shared Function ListarAccesoUsuario(ByVal id_personal As Integer) As DataTable
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim da As New SqlDataAdapter("sp_ListarAccesoUsuario", cn)

        Try
            da.SelectCommand.Parameters.Add("id_personal", SqlDbType.SmallInt)
            da.SelectCommand.Parameters("id_personal").Value = id_personal

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds)
        Catch ex As Exception
            Throw
        End Try
        Return ds
    End Function

    'ADD: 2014.04.12

    Shared Function ListarPersonalAlmacen(ByVal id_personal As Integer) As Integer
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim da As New SqlDataAdapter("sp_ListarPersonalAlmacen", cn)

        Try
            da.SelectCommand.Parameters.Add("id_personal", SqlDbType.SmallInt)
            da.SelectCommand.Parameters("id_personal").Value = id_personal

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds)

            If ds.Rows.Count > 0 Then
                Return CInt(ds.Rows(0).Item("id_almacen"))
            Else
                Return 0
            End If

        Catch ex As Exception
            Throw
        End Try
        Return 0
    End Function
End Class
