Imports Guna.UI2.WinForms

Public Class MainForm

    Private activeNavButton As Guna2GradientButton = Nothing

    Private ReadOnly ActiveColor As Color = Color.FromArgb(5, 33, 90)
    Private ReadOnly HoverColor As Color = Color.FromArgb(5, 33, 90)

    Private ReadOnly FillColor2 As Color = Color.MediumSeaGreen

    Private ReadOnly NormalColor As Color = Color.Transparent

    Private _Username As String
    Private _UserRole As String

    Public Sub New(Username As String, UserRole As String)
        InitializeComponent()
        _Username = Username
        _UserRole = UserRole
        ApplyRolePermissions()  ' ✅ Now it applies correctly
    End Sub

    Private Sub ApplyRolePermissions()
        If _UserRole.Equals("Staff", StringComparison.OrdinalIgnoreCase) Then
            dashboardPanel.Visible = False
            btnDashboard.Visible = False
            settingsPanel.Visible = False
            btnSettings.Visible = False
        Else
            dashboardPanel.Visible = True
            btnDashboard.Visible = True
            settingsPanel.Visible = True
            btnSettings.Visible = True
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRole.Text = _UserRole
        lblUsername.Text = _Username

        AddHandler btnDashboard.Click, AddressOf NavButton_Click
        AddHandler btnAnalytics.Click, AddressOf NavButton_Click
        AddHandler btnReservations.Click, AddressOf NavButton_Click
        AddHandler btnSettings.Click, AddressOf NavButton_Click
        AddHandler btnViewReservations.Click, AddressOf NavButton_Click
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Dim loginForm As New LoginForm()
            loginForm.StartPosition = FormStartPosition.CenterScreen
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub LoadUserControls(contentUC As UserControl)

        ' Clear and load content
        ContentPanel.Controls.Clear()

        contentUC.AutoScaleMode = AutoScaleMode.None
        contentUC.Dock = DockStyle.Fill

        ContentPanel.Controls.Add(contentUC)
    End Sub



    Private Sub SetActiveButton(clickedButton As Guna2GradientButton)
        If activeNavButton IsNot Nothing Then
            activeNavButton.FillColor = NormalColor
            activeNavButton.FillColor2 = NormalColor
        End If

        clickedButton.FillColor2 = FillColor2
        activeNavButton = clickedButton
    End Sub

    Private Sub NavButton_Hover(sender As Object, e As EventArgs)
        Dim btn As Guna2GradientButton = CType(sender, Guna2GradientButton)
        If btn IsNot activeNavButton Then
            If e.GetType Is GetType(MouseEventArgs) Then
                btn.BackColor = HoverColor
            Else
                btn.BackColor = NormalColor
            End If

        End If
    End Sub


    Private Sub NavButton_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Guna2GradientButton = CType(sender, Guna2GradientButton)
        LoadSection(clickedButton)
    End Sub

    'ITO YUNG NAG LOLOAD NG USERCONTROLS BASED ON BUTTON CLICK
    Private Sub LoadSection(clickedButton As Guna2GradientButton)
        Dim titleBar As UserControl = Nothing
        Dim content As UserControl = Nothing

        Select Case clickedButton.Name
            Case "btnDashboard"
                content = New DashboardControl()
            Case "btnAnalytics"
                'content = New MachinesControl()
            Case "btnSettings"
                'content = New TransactionsControl()
            Case "btnReservations"
                content = New ReservationControl()
            Case "btnViewReservations"
                content = New ViewReservationControl()

            Case Else
                Return
        End Select

        LoadUserControls(content)
        SetActiveButton(clickedButton)
    End Sub


    Private Sub ContentPanel_Resize(sender As Object, e As EventArgs) Handles ContentPanel.Resize
        If ContentPanel.Controls.Count > 0 Then
            Dim contentUC = ContentPanel.Controls(0)
            contentUC.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub
End Class
