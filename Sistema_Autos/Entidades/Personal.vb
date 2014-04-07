Public Class Personal
    Private mid_personal As Integer
    Private mid_almacen As Integer
    Private mid_sucursal As Integer
    Private mnombres As String
    Private map_paterno As String
    Private map_materno As String
    Private mdni As String
    Private mdireccion As String
    Private mtelefono As String
    Private mcelular As String
    Private mestado As String
    Private mcargo As String
    Private musuario As String
    Private mclave As String
    Public Property id_personal() As Integer
        Get
            Return mid_personal
        End Get
        Set(ByVal value As Integer)
            mid_personal = value
        End Set
    End Property
    Public Property id_almacen() As Integer
        Get
            Return mid_almacen
        End Get
        Set(ByVal value As Integer)
            mid_almacen = value
        End Set
    End Property
    Public Property id_sucursal() As Integer
        Get
            Return mid_sucursal
        End Get
        Set(ByVal value As Integer)
            mid_sucursal = value
        End Set
    End Property
    Public Property nombres() As String
        Get
            Return mnombres
        End Get
        Set(ByVal value As String)
            mnombres = value
        End Set
    End Property
    Public Property ap_paterno() As String
        Get
            Return map_paterno
        End Get
        Set(ByVal value As String)
            map_paterno = value
        End Set
    End Property
    Public Property ap_materno() As String
        Get
            Return map_materno
        End Get
        Set(ByVal value As String)
            map_materno = value
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
    Public Property cargo() As String
        Get
            Return mcargo
        End Get
        Set(ByVal value As String)
            mcargo = value
        End Set
    End Property
    Public Property clave() As String
        Get
            Return mclave
        End Get
        Set(ByVal value As String)
            mclave = value
        End Set
    End Property
    Public Property usuario() As String
        Get
            Return musuario
        End Get
        Set(ByVal value As String)
            musuario = value
        End Set
    End Property

    Sub New()

    End Sub

    Public Sub New(ByVal wid_personal As Integer, ByVal wnombres As String, ByVal wap_paterno As String, ByVal wap_materno As String, ByVal wdni As String, ByVal wdireccion As String, ByVal wtelefono As String, ByVal wcelular As String, ByVal westado As String, ByVal wcargo As String, ByVal wusuario As String, ByVal wclave As String)
        Me.id_personal = wid_personal
        Me.nombres = wnombres
        Me.ap_paterno = wap_paterno
        Me.ap_materno = wap_materno
        Me.dni = wdni
        Me.direccion = wdireccion
        Me.telefono = wtelefono
        Me.celular = wcelular
        Me.estado = westado
        Me.cargo = wcargo
        Me.usuario = wusuario
        Me.clave = wclave
    End Sub
    Public Sub New(ByVal wid_personal As Integer, ByVal wusuario As String, ByVal wclave As String)
        Me.id_personal = wid_personal
        Me.usuario = wusuario
        Me.clave = wclave
    End Sub
End Class
