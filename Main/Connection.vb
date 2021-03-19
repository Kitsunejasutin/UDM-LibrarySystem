Imports MySql.Data.MySqlClient

Public Class Connection

    'create connection

    Private connection As New MySqlConnection("server=localhost;port=3306;username=root;password=;database=database1")

    'return connection
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get

    End Property


    'open connection
    Sub openConnection()

        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Sub closeConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Class
