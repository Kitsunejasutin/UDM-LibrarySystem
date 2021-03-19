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

        If npass.Trim() = "" Or username.Trim() = "" Then

            MsgBox("Fill Empty Values")

        ElseIf Not String.Equals(npass, contpass) Then

            MsgBox("Password not the same")

        Else
            Dim conn As New Connection()

            conn.openConnection()

            Dim command As New MySqlCommand("UPDATE `students` SET `Password`= @password WHERE `Studentid`= @studid", conn.getConnection)

            command.Parameters.Add("@studid", MySqlDbType.VarChar).Value = txtID.Text
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = txtNPass.Text

            If command.ExecuteNonQuery() = 1 Then
                    MsgBox("Password Updated")
                    conn.closeConnection()
                Else
                    MsgBox("Username not found!")
                    conn.closeConnection()
                End If
            End If

    End Sub

End Class