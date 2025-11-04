Imports MySql.Data.MySqlClient

Module DatabaseConnection
    ' 🔹 Change your database name or port here if needed
    Public connectionString As String = "server=localhost;userid=root;password=;database=occasion;"
    Public conn As New MySqlConnection(connectionString)

    Public Sub OpenConnection()
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error opening connection: " & ex.Message)
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error closing connection: " & ex.Message)
        End Try
    End Sub
End Module
