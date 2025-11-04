Imports MySql.Data.MySqlClient

Public Class LoginForm

    ' 🔹 LOGIN BUTTON
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter both username and password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using conn As New MySqlConnection(DatabaseConnection.connectionString)
            Try
                conn.Open()

                ' 🔍 First, check in admins table
                Dim adminQuery As String = "SELECT * FROM admins WHERE username=@username AND password=@password"
                Using adminCmd As New MySqlCommand(adminQuery, conn)
                    adminCmd.Parameters.AddWithValue("@username", username)
                    adminCmd.Parameters.AddWithValue("@password", password)

                    Dim adminReader As MySqlDataReader = adminCmd.ExecuteReader()
                    If adminReader.Read() Then
                        MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim mainform As New MainForm(username, "Admin")
                        mainform.Show()
                        Me.Hide()
                        adminReader.Close()
                        Exit Sub
                    End If
                    adminReader.Close()
                End Using

                ' 🔍 If not found, check in employees table
                Dim staffQuery As String = "SELECT * FROM employees WHERE username=@username AND password=@password"
                Using staffCmd As New MySqlCommand(staffQuery, conn)
                    staffCmd.Parameters.AddWithValue("@username", username)
                    staffCmd.Parameters.AddWithValue("@password", password)

                    Dim staffReader As MySqlDataReader = staffCmd.ExecuteReader()
                    If staffReader.Read() Then
                        MessageBox.Show("Welcome, Staff!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim mainform As New MainForm(username, "Staff")
                        mainform.Show()
                        Me.Hide()
                        staffReader.Close()
                    Else
                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    staffReader.Close()
                End Using

            Catch ex As Exception
                MessageBox.Show("Database connection error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub



End Class








