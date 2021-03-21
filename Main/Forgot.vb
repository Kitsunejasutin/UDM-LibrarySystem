Imports MySql.Data.MySqlClient
Public Class forgot
    Private Sub forgot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        Dim username As String = txtID.Text
        Dim npass As String = txtNPass.Text
        Dim contpass As String = txtConfirm.Text
        Dim conn As New Connection()
        Dim command As New MySqlCommand
        Dim rd As MySqlDataReader
        Dim command1 As New MySqlCommand



        command1.CommandText = "SELECT * FROM `students` WHERE `Studentid`= @studid "
        command1.Connection = conn.getConnection
        command.CommandText = "UPDATE `students` SET `Password`= @password WHERE `Studentid`= @studid"
        command.Connection = conn.getConnection

        command1.Parameters.Add("@studid", MySqlDbType.VarChar).Value = username.Trim()
        command.Parameters.Add("@studid", MySqlDbType.VarChar).Value = username.Trim()
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = npass.Trim()

        If npass.Trim() = "" Or username.Trim() = "" Then

            MsgBox("Fill Empty Values")

        ElseIf Not String.Equals(npass, contpass) Then

            MsgBox("Password not the same")

        Else
            conn.openConnection()
            rd = command1.ExecuteReader()

            With rd
                If .Read Then
                    If StrComp(username, rd.GetValue(1), 0) = 0 Then
                        MessageBox.Show("Password Changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Incorrect Username")
                    End If
                Else
                    MessageBox.Show("Incorrect Username or Password")
                End If
            End With
        End If

    End Sub

End Class