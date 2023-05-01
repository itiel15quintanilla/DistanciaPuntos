Public Class Resultado
    Inherits Puntos
    Public Function Distancia() As Double
        Dim resultado As Double
        resultado = ((Math.Pow(XB - XA, 2)) + (Math.Pow(YB - YA, 2)))
        resultado = (Math.Sqrt(resultado))
        Return resultado
    End Function
End Class
