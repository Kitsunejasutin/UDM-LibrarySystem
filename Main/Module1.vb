Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Sub openCon()
        con.ConnectionString = "server=localhost;username=root;password;=;database=database1"
        con.Open()

    End Sub
End Module
