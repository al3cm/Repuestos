Public Class Linea
    Private mid_linea As Integer
    Private mdescripcion As String
    Public Property id_linea() As String
        Get
            Return mid_linea
        End Get
        Set(ByVal value As String)
            mid_linea = value
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

    Sub New()

    End Sub
    Public Sub New(ByVal wid_linea As Integer, ByVal wdescripcion As String)
        Me.id_linea = wid_linea
        Me.descripcion = wdescripcion
    End Sub


End Class
