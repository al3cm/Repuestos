Public Class TipoDocumento
    Private mid_tipodocumento As String
    Private mautonumber As Integer
    Private mabreviatura As String
    Private mdescripcion As String

    Public Property id_tipodocumento() As String
        Get
            Return mid_tipodocumento
        End Get
        Set(ByVal value As String)
            mid_tipodocumento = value
        End Set
    End Property
    Public Property autonumber() As Integer
        Get
            Return mautonumber
        End Get
        Set(ByVal value As Integer)
            mautonumber = value
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
    Sub New(ByVal wid_tipodocumento As Integer, ByVal wabreviatura As String, ByVal wdescripcion As String)
        Me.id_tipodocumento = wid_tipodocumento
        Me.abreviatura = wabreviatura
        Me.descripcion = wdescripcion
    End Sub



End Class
