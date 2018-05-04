Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Text = Int(Rnd() * 10)
        Label2.Text = Int(Rnd() * 10)
        Label3.Text = Int(Rnd() * 10)
        Dim rgb11, rgb1, rgb2, rgb22, rgb3, rgb33, rgb1f, rgb2f, rgb3f As Integer
        rgb11 = Int(Rnd() * 125)
        rgb22 = Int(Rnd() * 125)
        rgb33 = Int(Rnd() * 125)
        rgb1 = Int(Rnd() * 125)
        rgb2 = Int(Rnd() * 125)
        rgb3 = Int(Rnd() * 125)
        rgb1f = rgb1 + rgb11
        rgb3f = rgb3 + rgb33
        rgb2f = rgb2 + rgb22
        Me.BackColor = Color.FromArgb(rgb1f, rgb2f, rgb3f)
        If (Label1.Text = 7) Or (Label2.Text = 7) Or (Label3.Text = 7) Then
            MsgBox("Lucky 7.")
        End If
    End Sub

    Private Sub Command2_Click()
        End
    End Sub

End Class
