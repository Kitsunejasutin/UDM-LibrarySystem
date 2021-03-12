Public Class LogIn
    Private Function MarqueeText(ByVal Data As String)
        'How Marquee Moves
        Dim S1 As String = Data.Remove(0, 1)
        Dim S2 As String = Data(0)
        Return S1 & S2
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Makes the Text Transparent
        lblMar.Parent = pictureBox2
        lblMar.BackColor = Color.Transparent
        lblMar.BringToFront()
        lblMar.ForeColor = Color.White
        lblMar.Text = "UNIVERSIDAD DE MANILA NEWS AND UPDATES      "
        lblMar.Location = New Point(65, 20)
        'Starts The Marquee
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMar.Text = MarqueeText(lblMar.Text)
    End Sub

    Private Sub txtUsername_MouseEnter(sender As Object, e As EventArgs) Handles txtUsername.MouseEnter
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_MouseLeave(sender As Object, e As EventArgs) Handles txtUsername.MouseLeave
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtPassword_MouseEnter(sender As Object, e As EventArgs) Handles txtPassword.MouseEnter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtPassword.MouseLeave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Gray
        End If
    End Sub
End Class



