Public Class eusuario
    Private usuario As String
    Private contrasena As String
    Private roll As String
    Public Property _usuario
        Get
            Return usuario
        End Get
        Set(value)
            usuario = value
        End Set
    End Property
    Public Property _contrasena
        Get
            Return contrasena
        End Get
        Set(value)
            contrasena = value
        End Set
    End Property
    Public Property _roll
        Get
            Return roll
        End Get
        Set(value)
            roll = value
        End Set
    End Property
    Public Sub New()

    End Sub



End Class
