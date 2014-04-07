Public Class Empresa
    Private mid_empresa As Integer
    Private mruc As String
    Private mrazon_social As String
    Private mdireccion As String
    Private mtelefono As String

    Public Property id_empresa() As String
        Get
            Return mid_empresa
        End Get
        Set(ByVal value As String)
            mid_empresa = value
        End Set
    End Property
    Public Property ruc() As String
        Get
            Return mruc
        End Get
        Set(ByVal value As String)
            mruc = value
        End Set
    End Property
    Public Property razon_social() As String
        Get
            Return mrazon_social
        End Get
        Set(ByVal value As String)
            mrazon_social = value
        End Set
    End Property
    Public Property direccion() As String
        Get
            Return mdireccion
        End Get
        Set(ByVal value As String)
            mdireccion = value
        End Set
    End Property
    Public Property telefono() As String
        Get
            Return mtelefono
        End Get
        Set(ByVal value As String)
            mtelefono = value
        End Set
    End Property
    Sub New()

    End Sub
    Sub New(ByVal wid_empresa As Integer, ByVal wruc As String, ByVal wrazon_social As String, ByVal wdireccion As String, ByVal wtelefono As String)
        Me.id_empresa = wid_empresa
        Me.ruc = wruc
        Me.razon_social = wrazon_social
        Me.direccion = wdireccion
        Me.telefono = wtelefono
    End Sub
    Sub New(ByVal wruc As String, ByVal wrazon_social As String, ByVal wdireccion As String, ByVal wtelefono As String)
        Me.ruc = wruc
        Me.razon_social = wrazon_social
        Me.direccion = wdireccion
        Me.telefono = wtelefono
    End Sub
End Class
