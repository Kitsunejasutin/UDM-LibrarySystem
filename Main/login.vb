Imports MySql.Data.MySqlClient

Public Class login
    Private Function MarqueeText(ByVal Data As String)
        Dim S1 As String = Data.Remove(0, 1)
        Dim S2 As String = Data(0)
        Return S1 & S2
    End Function
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' test connection
        openCon()
        MsgBox("Connection Established!")
        con.Close()

        ' transparent marquee
        lblMar.Parent = PictureBox4
        lblMar.BackColor = Color.Transparent
        lblMar.BringToFront()
        lblMar.Location = New Point(20, 20)

        'start timer
        Timer1.Start()

    End Sub



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblMar.Text = MarqueeText(lblMar.Text)
    End Sub

    Private Sub txtID_Enter(sender As Object, e As EventArgs) Handles txtID.Enter

        'clear the textbox when the textbox gets clicked
        Dim username As String = txtID.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If username.Trim().ToLower() = "student number" Or username.Trim() = "" Then

            'clear the textbox
            txtID.Text = ""
            'change the textbox color
            txtID.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtID_Leave(sender As Object, e As EventArgs) Handles txtID.Leave

        'when the user leave the textbox
        Dim username As String = txtID.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If username.Trim().ToLower() = "student number" Or username.Trim() = "" Then

            'set the value back to username
            txtID.Text = "student number"
            'change the textbox color
            txtID.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub txtPass_Enter(sender As Object, e As EventArgs) Handles txtPass.Enter

        'clear the textbox when the textbox gets clicked
        Dim password As String = txtPass.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If password.Trim().ToLower() = "password" Or password.Trim() = "" Then

            'clear the textbox
            txtPass.Text = ""
            'change the textbox color
            txtPass.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtPass_Leave(sender As Object, e As EventArgs) Handles txtPass.Leave

        'when the user leave the textbox
        Dim password As String = txtPass.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If password.Trim().ToLower() = "password" Or password.Trim() = "" Then

            'set the value back to username
            txtPass.Text = "password"
            'change the textbox color
            txtPass.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conn As New Connection
        Dim adapter As New MySqlDataAdapter
        Dim table As New DataTable
        Dim command As New MySqlCommand
        Dim studentid As String = txtID.Text
        Dim password As String = txtPass.Text

        command.CommandText = "SELECT * FROM `students` WHERE `Studentid`= @studid AND `Password`= @password"
        command.Connection = conn.getConnection
        command.Parameters.Add("@studid", MySqlDbType.VarChar).Value = studentid
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password

        If txtID.Text.Trim() = "" Or txtID.Text.Trim().ToLower() = "student number" Then

            MsgBox("Enter a Username")

        ElseIf txtPass.Text.Trim() = "" Or txtPass.Text.Trim().ToLower() = "password" Then

            MsgBox("Enter Password")

        Else

            adapter.SelectCommand = command
            adapter.Fill(table)

            If table.Rows.Count > 0 Then

                MsgBox("Welcome User")
            Else
                MsgBox("Student ID or Password didn't match on the database")

            End If

        End If

    End Sub

    Private Sub txtSignup_Click(sender As Object, e As EventArgs) Handles txtSignup.Click
        SignUp.Show()
    End Sub

    Private Sub txtForgot_Click(sender As Object, e As EventArgs) Handles txtForgot.Click
        forgot.Show()
    End Sub
End Class