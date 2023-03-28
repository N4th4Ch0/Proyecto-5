Public Class Form1

    Dim edad As Integer


    Private Sub lbl1_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub

    Private Sub cmdCompro_Click(sender As Object, e As EventArgs) Handles cmdCompro.Click
        Dim edad As Integer '= Convert.ToInt32(txtEdad.Text)
        'Convert.ToInt32 nos sirve para convertir la informacion del txtEdad aun valor entero

        edad = txtEdad.Text

        If edad >= 18 Then

            lblRespuesta1.Text = "Eres una persona mayor de edad"
            lblRespuesta2.Text = " "

        Else

            lblRespuesta2.Text = "No eres mayor de edad"
            lblRespuesta1.Text = " "

        End If

        ' lblNoDato.Text = "No introdujo ningun dato"

    End Sub

    Private Sub cmdResset_Click(sender As Object, e As EventArgs) Handles cmdResset.Click

        lblRespuesta2.Text = " "
        lblRespuesta1.Text = " "
        txtEdad.Text = " "

    End Sub
End Class
