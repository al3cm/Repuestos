Public Class Cliente
    Private mid_cliente As Integer
    Private mrazon_social As String
    Private mruc As String
    Private mdni As String
    Private mdireccion As String
    Private mtelefono As String
    Private mcelular As String
    Private mestado As String
    Private mtipo_cliente As String
    Public Property id_cliente() As String
        Get
            Return mid_cliente
        End Get
        Set(ByVal value As String)
            mid_cliente = value
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
    Public Property ruc() As String
        Get
            Return mruc
        End Get
        Set(ByVal value As String)
            mruc = value
        End Set
    End Property
    Public Property dni() As String
        Get
            Return mdni
        End Get
        Set(ByVal value As String)
            mdni = value
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
    Public Property celular() As String
        Get
            Return mcelular
        End Get
        Set(ByVal value As String)
            mcelular = value
        End Set
    End Property
    Public Property estado() As String
        Get
            Return mestado
        End Get
        Set(ByVal value As String)
            mestado = value
        End Set
    End Property
    Public Property tipo_cliente() As String
        Get
            Return mtipo_cliente
        End Get
        Set(ByVal value As String)
            mtipo_cliente = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByVal wid_cliente As Integer, ByVal wrazon_social As String, ByVal wruc As String, ByVal wdni As String, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wcelular As String, ByVal westado As String, ByVal wtipo_cliente As String)
        Me.id_cliente = wid_cliente
        Me.razon_social = wrazon_social
        Me.ruc = wruc
        Me.dni = wdni
        Me.direccion = wdireccion
        Me.telefono = wtelefono
        Me.celular = wcelular
        Me.estado = westado
        Me.tipo_cliente = wtipo_cliente
    End Sub

    Sub New(ByVal wrazon_social As String, ByVal wruc As String, ByVal wdni As String, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wcelular As String, ByVal westado As Boolean, ByVal wtipo_cliente As String)
        Me.razon_social = wrazon_social
        Me.ruc = wruc
        Me.dni = wdni
        Me.direccion = wdireccion
        Me.telefono = wtelefono
        Me.celular = wcelular
        Me.estado = westado
        Me.tipo_cliente = wtipo_cliente
    End Sub



End Class
