Public Class Puntos
    Private _XA As Double
    Private _YA As Double
    Private _XB As Double
    Private _YB As Double

    Public Property XA As Double
        Get
            Return _XA
        End Get
        Set(value As Double)
            _XA = value
        End Set
    End Property

    Public Property YA As Double
        Get
            Return _YA
        End Get
        Set(value As Double)
            _YA = value
        End Set
    End Property

    Public Property XB As Double
        Get
            Return _XB
        End Get
        Set(value As Double)
            _XB = value
        End Set
    End Property

    Public Property YB As Double
        Get
            Return _YB
        End Get
        Set(value As Double)
            _YB = value
        End Set
    End Property
End Class
