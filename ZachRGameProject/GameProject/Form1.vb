Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim number As Integer

        Randomize()
        ' The program will generate a number from 0 to 50
        number = Int(Rnd() * 6) + 1

        TextBox1.Text = number
        If number = 1 Then
            Label4.Text = "O"
            Label1.Text = " "
            Label2.Text = " "
            Label3.Text = " "
            Label5.Text = " "
            Label6.Text = " "
            Label7.Text = " "
        ElseIf number = 2 Then
            Label4.Text = " "
            Label1.Text = " "
            Label2.Text = " "
            Label3.Text = "O"
            Label5.Text = "O"
            Label6.Text = " "
            Label7.Text = " "
        ElseIf number = 3 Then
            Label4.Text = "O"
            Label1.Text = " "
            Label2.Text = " "
            Label3.Text = "O"
            Label5.Text = "O"
            Label6.Text = " "
            Label7.Text = " "
        ElseIf number = 4 Then
            Label4.Text = " "
            Label1.Text = "O"
            Label2.Text = " "
            Label3.Text = "O"
            Label5.Text = "O"
            Label6.Text = " "
            Label7.Text = "O"
        ElseIf number = 5 Then
            Label4.Text = "O"
            Label1.Text = "O"
            Label2.Text = " "
            Label3.Text = "O"
            Label5.Text = "O"
            Label6.Text = " "
            Label7.Text = "O"
        ElseIf number = 6 Then
            Label4.Text = "O"
            Label1.Text = "O"
            Label2.Text = "O"
            Label3.Text = "O"
            Label5.Text = "O"
            Label6.Text = "O"
            Label7.Text = "O"
        End If

    End Sub
End Class
