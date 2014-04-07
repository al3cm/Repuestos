Public Class Proveedor
    Private mid_proveedor As Integer
    Private mid_ubigeo As String
    Private mrazon_social As String
    Private mruc As String
    Private mdireccion As String
    Private mtelefono As String
    Private mfax As String
    Private mcontacto As String
    Private memail As String
    Private mdescripcion As String
    Private mestado As Boolean
    Public Property id_proveedor() As String
        Get
            Return mid_proveedor
        End Get
        Set(ByVal value As String)
            mid_proveedor = value
        End Set
    End Property
    Public Property id_ubigeo() As String
        Get
            Return mid_ubigeo
        End Get
        Set(ByVal value As String)
            mid_ubigeo = value
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
    Public Property fax() As String
        Get
            Return mfax
        End Get
        Set(ByVal value As String)
            mfax = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return memail
        End Get
        Set(ByVal value As String)
            memail = value
        End Set
    End Property
    Public Property contacto() As String
        Get
            Return mcontacto
        End Get
        Set(ByVal value As String)
            mcontacto = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return mdescripcion
        End Get
        Set(ByVal value As String)
            mdescripcion = value
        End Set
    End Property
    Public Property estado() As Boolean
        Get
            Return mestado
        End Get
        Set(ByVal value As Boolean)
            mestado = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByVal wid_proveedor As Integer, ByVal wid_ubigeo As Integer, ByVal wrazon_social As String, ByVal wruc As String, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wfax As String, ByVal wcontacto As String, ByVal wemail As String, ByVal wdescripcion As String, ByVal westado As Boolean)
        Me.id_proveedor = wid_proveedor
        Me.id_ubigeo = id_ubigeo
        Me.razon_social = wrazon_social
        Me.ruc = wruc
        Me.direccion = wdireccion
        Me.telefono = wtelefono
        Me.fax = wfax
        Me.contacto = wcontacto
        Me.email = wemail
        Me.descripcion = wdescripcion
        Me.estado = westado
    End Sub

    Sub New(ByVal wid_ubigeo As Integer, ByVal wrazon_social As String, ByVal wruc As String, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wfax As String, ByVal wcontacto As String, ByVal wemail As String, ByVal wdescripcion As String, ByVal westado As Boolean)
        Me.id_ubigeo = id_ubigeo
        Me.razon_social = wrazon_social
        Me.ruc = wruc
        Me.direccion = wdireccion
        Me.telefono = wtelefono
        Me.fax = wfax
        Me.contacto = wcontacto
        Me.email = wemail
        Me.descripcion = wdescripcion
        Me.estado = westado
    End Sub

 



End Class
