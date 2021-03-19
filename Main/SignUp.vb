Imports MySql.Data.MySqlClient
Public Class SignUp
    Dim gender As String
    Private Sub Sign_up_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.Hide()
    End Sub

    Private Sub txtCont_Enter(sender As Object, e As EventArgs) Handles txtCont.Enter

        'clear the textbox when the textbox gets clicked
        Dim cont As String = txtCont.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If cont.Trim().ToLower() = "09xx-xxxx-xxx" Or cont.Trim() = "" Then

            'clear the textbox
            txtCont.Text = ""
            'change the textbox color
            txtCont.ForeColor = Color.Black

        End If
    End Sub

    Private Sub txtCont_Leave(sender As Object, e As EventArgs) Handles txtCont.Leave

        'when the user leave the textbox
        Dim cont As String = txtCont.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If cont.Trim().ToLower() = "09xx-xxxx-xxx" Or cont.Trim() = "" Then

            'set the value back to username
            txtCont.Text = "09xx-xxxx-xxx"
            'change the textbox color
            txtCont.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub txtEmail_Leave(sender As Object, e As EventArgs) Handles txtEmail.Leave

        'when the user leave the textbox
        Dim email As String = txtEmail.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If email.Trim().ToLower() = "example@yahoo.com" Or email.Trim() = "" Then

            'set the value back to username
            txtEmail.Text = "example@yahoo.com"
            'change the textbox color
            txtEmail.ForeColor = Color.LightGray

        End If
    End Sub

    Private Sub txtEmail_Enter(sender As Object, e As EventArgs) Handles txtEmail.Enter

        'clear the textbox when the textbox gets clicked
        Dim email As String = txtEmail.Text
        'check if the username is empty
        'check if the textbox contains the default value "username"
        If email.Trim().ToLower() = "example@yahoo.com" Or email.Trim() = "" Then

            'clear the textbox
            txtEmail.Text = ""
            'change the textbox color
            txtEmail.ForeColor = Color.Black

        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        ' check if textbox are empty
        ' check if the username already exists

        ' textboxes values
        Dim sname As String = txtSurname.Text
        Dim fname As String = txtFName.Text
        Dim mname As String = txtMiddle.Text
        Dim age As String = txtAge.Text
        Dim studentid As String = txtID.Text
        Dim add As String = txtAdd.Text
        Dim cont As String = txtCont.Text
        Dim email As String = txtEmail.Text
        Dim emername As String = txtName.Text
        Dim emeradd As String = txtAdd2.Text
        Dim emercont As String = txtCont2.Text
        Dim emerrelate As String = txtRelate.Text
        Dim password As String = txtPassword.Text
        Dim txtCon As String = txtConfirm.Text


        If sname.Trim() = "" Or fname.Trim() = "" Or mname.Trim() = "" Or age.ToString() = "" Or studentid.Trim() = "" Or
            add.Trim() = "" Or cont.Trim() = "" Or email.Trim() = "" Or emername.Trim() = "" Or emeradd.Trim() = "" Or
            emercont.ToString() = "" Or emerrelate.Trim() = "" Or password.Trim() = "" Then

            MsgBox("Empty Fields")

        ElseIf Not String.Equals(password, txtCon) Then

            MsgBox("Password not the same")

        ElseIf usernameExist(studentid) Then

            MsgBox("This username already exist")
        Else
            ' add new user
            Dim conn As New Connection()
            Dim command As New MySqlCommand("INSERT INTO `students`(`Studentid`, `Password`, `Surname`, `FName`, 
            `MName`, `Age`, `Address`, `Contact`, `Email`, `EmerName`, `EmerAdd`, `EmerRelate`, `DOB`, `Emercont`,`gender` ) VALUES 
            (@studid,@password,@sname,@fname,@mname,@age,@add,@cont,@email,@emername,@emeradd,@emerrelate,@DOB, @emercont, @gender)", conn.getConnection)

            command.Parameters.Add("@studid", MySqlDbType.VarChar).Value = studentid.Trim()
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Trim()
            command.Parameters.Add("@sname", MySqlDbType.VarChar).Value = sname.Trim()
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname.Trim()
            command.Parameters.Add("@mname", MySqlDbType.VarChar).Value = mname.Trim()
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value = age.ToString
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = add.Trim()
            command.Parameters.Add("@cont", MySqlDbType.VarChar).Value = cont.ToString
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email.Trim()
            command.Parameters.Add("@emername", MySqlDbType.VarChar).Value = emername.Trim()
            command.Parameters.Add("@emercont", MySqlDbType.VarChar).Value = emercont.Trim()
            command.Parameters.Add("@emeradd", MySqlDbType.VarChar).Value = emeradd.Trim()
            command.Parameters.Add("@emerrelate", MySqlDbType.VarChar).Value = emerrelate.Trim()
            command.Parameters.Add("@DOB", MySqlDbType.VarChar).Value = DOB.Value.ToString()
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender


            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then

                MsgBox("Thank you For Registering!")
                conn.closeConnection()
            Else
                MsgBox("Something's Wrong!")
                conn.closeConnection()
            End If

        End If
    End Sub

    'create function to check if the username already exists
    Public Function usernameExist(ByVal username As String) As Boolean

        Dim con As New Connection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT * FROM `students` WHERE `Studentid`= @studid", con.getConnection())
        command.Parameters.Add("@studid", MySqlDbType.VarChar).Value = txtID2.Text.Trim

        adapter.SelectCommand = command
        adapter.Fill(table)

        ' if the student number exist
        If table.Rows.Count > 0 Then
            Return True

            ' if not return false
        Else
            Return False

        End If

    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        login.Show()
        Me.Close()
    End Sub

    Private Sub rbtnMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub rbtnFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFemale.CheckedChanged
        gender = "Female"
    End Sub
End Class
