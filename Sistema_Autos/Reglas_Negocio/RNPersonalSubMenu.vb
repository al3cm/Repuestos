Imports System.Data.SqlClient
Imports Entidades
Public Class RNPersonalSubMenu
    Shared Sub ModificarPermisos(ByVal objPermisos As Entidades.Personal_SubMenu)
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim cmd As New SqlCommand("sp_ModificarPersonalSubMenu", cn)
        cmd.CommandType = CommandType.StoredProcedure
        With cmd.Parameters
            .AddWithValue("@id_menu", objPermisos.id_menu)
            .AddWithValue("@id_submenu", objPermisos.id_submenu)
            .AddWithValue("@id_personal", objPermisos.id_personal)
            .AddWithValue("@estado", objPermisos.estado)
            .AddWithValue("@nuevo", objPermisos.nuevo)
            .AddWithValue("@eliminar", objPermisos.eliminar)
            .AddWithValue("@modificar", objPermisos.modificar)
            .AddWithValue("@buscar", objPermisos.buscar)
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

    Shared Function ListarPersonalSubMenu(ByVal id_menu As Integer, ByVal id_submenu As Integer, ByVal id_personal As Integer) As Personal_SubMenu
        Dim ds As New DataTable
        Dim cn As New SqlConnection(My.Settings.conexion)
        Dim da As New SqlDataAdapter("sp_ListarPersonalSubMenu", cn)
        Dim Permiso As New Personal_SubMenu
        Try
            da.SelectCommand.Parameters.Add("id_menu", SqlDbType.SmallInt)
            da.SelectCommand.Parameters("id_menu").Value = id_menu
            da.SelectCommand.Parameters.Add("id_submenu", SqlDbType.SmallInt)
            da.SelectCommand.Parameters("id_submenu").Value = id_submenu
            da.SelectCommand.Parameters.Add("id_personal", SqlDbType.SmallInt)
            da.SelectCommand.Parameters("id_personal").Value = id_personal
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds)

            If ds.Rows.Count > 0 Then
                Permiso.id_menu = ds.Rows(0).Item("id_menu")
                Permiso.id_submenu = ds.Rows(0).Item("id_submenu")
                Permiso.id_personal = ds.Rows(0).Item("id_personal")
                Permiso.estado = ds.Rows(0).Item("estado")
                Permiso.nuevo = ds.Rows(0).Item("nuevo")
                Permiso.modificar = ds.Rows(0).Item("modificar")
                Permiso.eliminar = ds.Rows(0).Item("eliminar")
                Permiso.buscar = ds.Rows(0).Item("buscar")

                Return Permiso


            End If

        Catch ex As Exception
            Throw
        End Try
        Return Nothing
    End Function
End Class
