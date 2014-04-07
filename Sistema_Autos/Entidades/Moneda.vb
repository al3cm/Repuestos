Public Class Moneda
    Private mid_moneda As Integer
    Private mdescripcion As String
    Private msimbolo As String

    Public Property id_moneda() As String
        Get
            Return mid_moneda
        End Get
        Set(ByVal value As String)
            mid_moneda = value
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

    Public Property simbolo() As String
        Get
            Return msimbolo
        End Get
        Set(ByVal value As String)
            msimbolo = value
        End Set
    End Property


    Sub New()

    End Sub

    Sub New(ByVal wid_moneda As Integer, ByVal wdescripcion As String, ByVal wsimbolo As String)
        Me.id_moneda = wid_moneda
        Me.descripcion = wdescripcion
        Me.simbolo = wsimbolo
    End Sub


End Class
