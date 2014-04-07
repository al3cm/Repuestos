Public Class Personal_SubMenu

    Private m_id_menu As Integer
    Public Property id_menu() As Integer
        Get
            Return m_id_menu
        End Get
        Set(ByVal value As Integer)
            m_id_menu = value
        End Set
    End Property


    Private m_id_submenu As Integer
    Public Property id_submenu() As Integer
        Get
            Return m_id_submenu
        End Get
        Set(ByVal value As Integer)
            m_id_submenu = value
        End Set
    End Property


    Private m_id_personal As Integer
    Public Property id_personal() As Integer
        Get
            Return m_id_personal
        End Get
        Set(ByVal value As Integer)
            m_id_personal = value
        End Set
    End Property


    Private m_estado As Boolean
    Public Property estado() As Boolean
        Get
            Return m_estado
        End Get
        Set(ByVal value As Boolean)
            m_estado = value
        End Set
    End Property


    Private m_nuevo As Boolean
    Public Property nuevo() As Boolean
        Get
            Return m_nuevo
        End Get
        Set(ByVal value As Boolean)
            m_nuevo = value
        End Set
    End Property


    Private m_eliminar As Boolean
    Public Property eliminar() As Boolean
        Get
            Return m_eliminar
        End Get
        Set(ByVal value As Boolean)
            m_eliminar = value
        End Set
    End Property


    Private m_modificar As Boolean
    Public Property modificar() As Boolean
        Get
            Return m_modificar
        End Get
        Set(ByVal value As Boolean)
            m_modificar = value
        End Set
    End Property


    Private m_buscar As Boolean
    Public Property buscar() As Boolean
        Get
            Return m_buscar
        End Get
        Set(ByVal value As Boolean)
            m_buscar = value
        End Set
    End Property

    Sub New()

    End Sub
End Class
