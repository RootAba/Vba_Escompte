Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim temps As Integer = CInt(TextBox1.Text)
        ' 20 cents par minute et une taxe de 15%
        Dim coutT As Double = (temps * 0.2) + ((15 * (temps * 0.2)) / 100)
        Dim coutTotal As Double

        Label3.Text = "Coût brut :" & coutT & "$"

        'Si de 8p.m à 6 a.m
        If (btn1.Checked) Then

            coutT -= (50 * coutT) / 100

            ' temps superieur à 60 mn
            If (temps > 60) Then
                coutTotal = coutT - ((20 * coutT) / 100)

            Else
                coutTotal = coutT

            End If

            Label2.Text = "Le cout totale de l'appel est :" & coutTotal & "$"

            'si 6 a.m à 8 p.m
        ElseIf (btn2.Checked) Then
            If (temps > 60) Then
                coutTotal = coutT - ((20 * coutT) / 100)

            Else
                coutTotal = coutT

            End If

            Label2.Text = "Le cout totale de l'appel est :" & coutTotal & "$"

        End If

    End Sub


End Class
