Public Class Unidad
    Private mid_unidad As Integer
    Private mabreviatura As String
    Private mdescripcion As String

    Public Property id_unidad() As String
        Get
            Return mid_unidad
        End Get
        Set(ByVal value As String)
            mid_unidad = value
        End Set
    End Property
    Public Property abreviatura() As String
        Get
            Return mabreviatura
        End Get
        Set(ByVal value As String)
            mabreviatura = value
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

    Sub New(ByVal wid_unidad As Integer, ByVal wabreviatura As String, ByVal wdescripcion As String)
        Me.id_unidad = wid_unidad
        Me.abreviatura = wabreviatura
        Me.descripcion = wdescripcion
    End Sub
End Class
