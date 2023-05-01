Public Class Form1
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim puntos As New Resultado()
        puntos.XA = TextBoxXA.Text
        puntos.YA = TextBoxYA.Text
        puntos.XB = TextBoxXB.Text
        puntos.YB = TextBoxYB.Text

        TxtResultado.Text = puntos.Distancia()
    End Sub
End Class
