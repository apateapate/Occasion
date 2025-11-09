Imports MySql.Data.MySqlClient

Public Class Form1

    ' ✅ Database connection string
    Private connectionString As String = "server=localhost;userid=root;password=;database=reservation_db;"

    ' 🔹 LOGIN BUTTON
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" OrElse password = "" Then
            MessageBox.Show("Please enter both username and password.", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
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
                        Dim adminForm As New adminForm()
                        adminForm.Show()
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
                        Dim staffForm As New staffForm()
                        staffForm.Show()
                        Me.Hide()
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

    ' 🔹 EXIT BUTTON
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' ================================
    ' ✅ FORM RESIZING (from your original code)
    ' ================================

    Private originalFormSize As Size
    Private originalControlData As New Dictionary(Of Control, Rectangle)

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fix the left branding panel
        PanelLeft.Dock = DockStyle.Left
        PanelLeft.Width = 300 ' Adjust this as needed

        ' Dock the right panel so it fills the remaining space
        PanelLogin.Dock = DockStyle.Fill

        ' Store original layout info for controls in PanelLogin only
        originalFormSize = PanelLogin.Size
        SaveOriginalControlData(PanelLogin)
    End Sub

    Private Sub LoginForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ResizeAllControls(PanelLogin)
    End Sub

    ' Store original sizes and positions
    Private Sub SaveOriginalControlData(parent As Control)
        For Each ctrl As Control In parent.Controls
            originalControlData(ctrl) = New Rectangle(ctrl.Location, ctrl.Size)
            If ctrl.Controls.Count > 0 Then
                SaveOriginalControlData(ctrl)
            End If
        Next
    End Sub

    ' Resize only controls inside PanelLogin proportionally
    Private Sub ResizeAllControls(parent As Control)
        If originalFormSize.Width = 0 OrElse originalFormSize.Height = 0 Then Exit Sub

        Dim xRatio As Double = PanelLogin.Width / originalFormSize.Width
        Dim yRatio As Double = PanelLogin.Height / originalFormSize.Height

        For Each ctrl As Control In parent.Controls
            If originalControlData.ContainsKey(ctrl) Then
                Dim origRect As Rectangle = originalControlData(ctrl)
                Dim newX As Integer = CInt(origRect.X * xRatio)
                Dim newY As Integer = CInt(origRect.Y * yRatio)
                Dim newWidth As Integer = CInt(origRect.Width * xRatio)
                Dim newHeight As Integer = CInt(origRect.Height * yRatio)
                ctrl.Bounds = New Rectangle(newX, newY, newWidth, newHeight)
            End If

            If ctrl.Controls.Count > 0 Then
                ResizeAllControls(ctrl)
            End If
        Next
    End Sub

End Class








