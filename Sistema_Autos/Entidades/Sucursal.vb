Public Class Sucursal
    Private mid_sucursal As Integer
    Private mdescripcion As String
    Private mdireccion As String
    Private mtelefono As String

    Public Property id_sucursal() As String
        Get
            Return mid_sucursal
        End Get
        Set(ByVal value As String)
            mid_sucursal = value
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


    Sub New(ByVal wid_sucursal As Integer, ByVal wdescripcion As String, ByVal wdireccion As String, ByVal wtelefono As String)
        Me.id_sucursal = wid_sucursal
        Me.descripcion = wdescripcion
        Me.direccion = wdireccion
        Me.telefono = wtelefono
    End Sub

End Class
