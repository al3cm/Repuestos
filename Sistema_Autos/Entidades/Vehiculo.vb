Public Class Vehiculo
    Private mid_vehiculo As Integer
    Private mid_cliente As Integer
    Private mid_marca As Integer
    Private mplaca As String
    Private mmodelo As String
    Private mtipo_vehiculo As String
    Public Property id_vehiculo() As String
        Get
            Return mid_vehiculo
        End Get
        Set(ByVal value As String)
            mid_vehiculo = value
        End Set
    End Property
    Public Property id_cliente() As String
        Get
            Return mid_cliente
        End Get
        Set(ByVal value As String)
            mid_cliente = value
        End Set
    End Property
    Public Property id_marca() As String
        Get
            Return mid_marca
        End Get
        Set(ByVal value As String)
            mid_marca = value
        End Set
    End Property
    Public Property placa() As String
        Get
            Return mplaca
        End Get
        Set(ByVal value As String)
            mplaca = value
        End Set
    End Property
    Public Property modelo() As String
        Get
            Return mmodelo
        End Get
        Set(ByVal value As String)
            mmodelo = value
        End Set
    End Property
    Public Property tipo_vehiculo() As String
        Get
            Return mtipo_vehiculo
        End Get
        Set(ByVal value As String)
            mtipo_vehiculo = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(ByVal wid_vehiculo As Integer, ByVal wid_cliente As Integer, ByVal wid_marca As Integer, ByVal wplaca As String, ByVal wmodelo As String, ByVal wtipo_vehiculo As String)
        Me.id_vehiculo = wid_vehiculo
        Me.id_cliente = wid_cliente
        Me.id_marca = wid_marca
        Me.modelo = wmodelo
        Me.placa = wplaca
        Me.tipo_vehiculo = wtipo_vehiculo
    End Sub
    Sub New(ByVal wid_cliente As Integer, ByVal wid_marca As Integer, ByVal wplaca As String, ByVal wmodelo As String, ByVal wtipo_vehiculo As String)
        Me.id_cliente = wid_cliente
        Me.id_marca = wid_marca
        Me.modelo = wmodelo
        Me.placa = wplaca
        Me.tipo_vehiculo = wtipo_vehiculo
    End Sub




End Class
