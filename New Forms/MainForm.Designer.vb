<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.dashboardPanel = New System.Windows.Forms.Panel()
        Me.btnDashboard = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.reservationPanel = New System.Windows.Forms.Panel()
        Me.btnReservations = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.analyticsPanel = New System.Windows.Forms.Panel()
        Me.btnAnalytics = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.settingsPanel = New System.Windows.Forms.Panel()
        Me.btnSettings = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.profilePanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ImageButton1 = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.ContentPanel = New System.Windows.Forms.Panel()
        Me.viewreservesPanel = New System.Windows.Forms.Panel()
        Me.btnViewReservations = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.dashboardPanel.SuspendLayout()
        Me.reservationPanel.SuspendLayout()
        Me.analyticsPanel.SuspendLayout()
        Me.settingsPanel.SuspendLayout()
        Me.profilePanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2GradientPanel2.SuspendLayout()
        Me.viewreservesPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 20
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.profilePanel)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(200, 500)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.dashboardPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.reservationPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.viewreservesPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.analyticsPanel)
        Me.FlowLayoutPanel1.Controls.Add(Me.settingsPanel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 94)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 336)
        Me.FlowLayoutPanel1.TabIndex = 3
        '
        'dashboardPanel
        '
        Me.dashboardPanel.BackColor = System.Drawing.Color.Transparent
        Me.dashboardPanel.Controls.Add(Me.btnDashboard)
        Me.dashboardPanel.Location = New System.Drawing.Point(0, 10)
        Me.dashboardPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.dashboardPanel.Name = "dashboardPanel"
        Me.dashboardPanel.Size = New System.Drawing.Size(200, 50)
        Me.dashboardPanel.TabIndex = 2
        '
        'btnDashboard
        '
        Me.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnDashboard.FillColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FillColor2 = System.Drawing.Color.Transparent
        Me.btnDashboard.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), System.Drawing.Image)
        Me.btnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnDashboard.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 50)
        Me.btnDashboard.TabIndex = 3
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDashboard.TextOffset = New System.Drawing.Point(10, 2)
        '
        'reservationPanel
        '
        Me.reservationPanel.BackColor = System.Drawing.Color.Transparent
        Me.reservationPanel.Controls.Add(Me.btnReservations)
        Me.reservationPanel.Location = New System.Drawing.Point(0, 60)
        Me.reservationPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.reservationPanel.Name = "reservationPanel"
        Me.reservationPanel.Size = New System.Drawing.Size(200, 50)
        Me.reservationPanel.TabIndex = 3
        '
        'btnReservations
        '
        Me.btnReservations.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReservations.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReservations.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReservations.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReservations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReservations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnReservations.FillColor = System.Drawing.Color.Transparent
        Me.btnReservations.FillColor2 = System.Drawing.Color.Transparent
        Me.btnReservations.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservations.ForeColor = System.Drawing.Color.White
        Me.btnReservations.Image = CType(resources.GetObject("btnReservations.Image"), System.Drawing.Image)
        Me.btnReservations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReservations.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnReservations.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnReservations.Location = New System.Drawing.Point(0, 0)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Size = New System.Drawing.Size(200, 50)
        Me.btnReservations.TabIndex = 3
        Me.btnReservations.Text = "Reservations"
        Me.btnReservations.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnReservations.TextOffset = New System.Drawing.Point(10, 2)
        '
        'analyticsPanel
        '
        Me.analyticsPanel.BackColor = System.Drawing.Color.Transparent
        Me.analyticsPanel.Controls.Add(Me.btnAnalytics)
        Me.analyticsPanel.Location = New System.Drawing.Point(0, 160)
        Me.analyticsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.analyticsPanel.Name = "analyticsPanel"
        Me.analyticsPanel.Size = New System.Drawing.Size(200, 50)
        Me.analyticsPanel.TabIndex = 4
        '
        'btnAnalytics
        '
        Me.btnAnalytics.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAnalytics.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAnalytics.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAnalytics.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAnalytics.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAnalytics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAnalytics.FillColor = System.Drawing.Color.Transparent
        Me.btnAnalytics.FillColor2 = System.Drawing.Color.Transparent
        Me.btnAnalytics.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalytics.ForeColor = System.Drawing.Color.White
        Me.btnAnalytics.Image = CType(resources.GetObject("btnAnalytics.Image"), System.Drawing.Image)
        Me.btnAnalytics.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAnalytics.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnAnalytics.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnAnalytics.Location = New System.Drawing.Point(0, 0)
        Me.btnAnalytics.Name = "btnAnalytics"
        Me.btnAnalytics.Size = New System.Drawing.Size(200, 50)
        Me.btnAnalytics.TabIndex = 3
        Me.btnAnalytics.Text = "Analytics"
        Me.btnAnalytics.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnAnalytics.TextOffset = New System.Drawing.Point(10, 2)
        '
        'settingsPanel
        '
        Me.settingsPanel.BackColor = System.Drawing.Color.Transparent
        Me.settingsPanel.Controls.Add(Me.btnSettings)
        Me.settingsPanel.Location = New System.Drawing.Point(0, 210)
        Me.settingsPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.settingsPanel.Name = "settingsPanel"
        Me.settingsPanel.Size = New System.Drawing.Size(200, 50)
        Me.settingsPanel.TabIndex = 5
        '
        'btnSettings
        '
        Me.btnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSettings.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnSettings.FillColor = System.Drawing.Color.Transparent
        Me.btnSettings.FillColor2 = System.Drawing.Color.Transparent
        Me.btnSettings.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Image = CType(resources.GetObject("btnSettings.Image"), System.Drawing.Image)
        Me.btnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettings.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnSettings.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnSettings.Location = New System.Drawing.Point(0, 0)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(200, 50)
        Me.btnSettings.TabIndex = 3
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSettings.TextOffset = New System.Drawing.Point(10, 2)
        '
        'profilePanel
        '
        Me.profilePanel.BackColor = System.Drawing.Color.Transparent
        Me.profilePanel.Controls.Add(Me.Guna2Separator1)
        Me.profilePanel.Controls.Add(Me.TableLayoutPanel1)
        Me.profilePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.profilePanel.Location = New System.Drawing.Point(0, 430)
        Me.profilePanel.Margin = New System.Windows.Forms.Padding(0)
        Me.profilePanel.Name = "profilePanel"
        Me.profilePanel.Padding = New System.Windows.Forms.Padding(5)
        Me.profilePanel.Size = New System.Drawing.Size(200, 70)
        Me.profilePanel.TabIndex = 2
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Separator1.Location = New System.Drawing.Point(5, -2)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(190, 10)
        Me.Guna2Separator1.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblRole, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblUsername, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(5, 8)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(190, 57)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lblRole
        '
        Me.lblRole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRole.Font = New System.Drawing.Font("Poppins Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.ForeColor = System.Drawing.Color.White
        Me.lblRole.Location = New System.Drawing.Point(49, 30)
        Me.lblRole.Margin = New System.Windows.Forms.Padding(0)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.lblRole.Size = New System.Drawing.Size(101, 27)
        Me.lblRole.TabIndex = 5
        Me.lblRole.Text = "Userrole"
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.Controls.Add(Me.Guna2ImageButton1)
        Me.Guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Panel4.Location = New System.Drawing.Point(150, 0)
        Me.Guna2Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.TableLayoutPanel1.SetRowSpan(Me.Guna2Panel4, 2)
        Me.Guna2Panel4.Size = New System.Drawing.Size(40, 57)
        Me.Guna2Panel4.TabIndex = 3
        '
        'Guna2ImageButton1
        '
        Me.Guna2ImageButton1.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Image = CType(resources.GetObject("Guna2ImageButton1.Image"), System.Drawing.Image)
        Me.Guna2ImageButton1.ImageOffset = New System.Drawing.Point(0, 0)
        Me.Guna2ImageButton1.ImageRotate = 0!
        Me.Guna2ImageButton1.Location = New System.Drawing.Point(0, 14)
        Me.Guna2ImageButton1.Name = "Guna2ImageButton1"
        Me.Guna2ImageButton1.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.Guna2ImageButton1.Size = New System.Drawing.Size(30, 30)
        Me.Guna2ImageButton1.TabIndex = 0
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.TableLayoutPanel1.SetRowSpan(Me.Guna2Panel3, 2)
        Me.Guna2Panel3.Size = New System.Drawing.Size(49, 57)
        Me.Guna2Panel3.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(7, 6)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'lblUsername
        '
        Me.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsername.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.White
        Me.lblUsername.Location = New System.Drawing.Point(49, 0)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(101, 30)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Name"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.ForeColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Guna2Panel1.Size = New System.Drawing.Size(200, 94)
        Me.Guna2Panel1.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(190, 94)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 34)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "System"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reservation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2GradientPanel2.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2GradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(200, 0)
        Me.Guna2GradientPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(800, 40)
        Me.Guna2GradientPanel2.TabIndex = 1
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(706, 8)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(23, 20)
        Me.Guna2ControlBox3.TabIndex = 2
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(735, 8)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(23, 20)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.CustomClick = True
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(764, 8)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(23, 20)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2GradientPanel2
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'ContentPanel
        '
        Me.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ContentPanel.Location = New System.Drawing.Point(200, 40)
        Me.ContentPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ContentPanel.Name = "ContentPanel"
        Me.ContentPanel.Size = New System.Drawing.Size(800, 460)
        Me.ContentPanel.TabIndex = 2
        '
        'viewreservesPanel
        '
        Me.viewreservesPanel.BackColor = System.Drawing.Color.Transparent
        Me.viewreservesPanel.Controls.Add(Me.btnViewReservations)
        Me.viewreservesPanel.Location = New System.Drawing.Point(0, 110)
        Me.viewreservesPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.viewreservesPanel.Name = "viewreservesPanel"
        Me.viewreservesPanel.Size = New System.Drawing.Size(200, 50)
        Me.viewreservesPanel.TabIndex = 4
        '
        'btnViewReservations
        '
        Me.btnViewReservations.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewReservations.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewReservations.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewReservations.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewReservations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewReservations.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnViewReservations.FillColor = System.Drawing.Color.Transparent
        Me.btnViewReservations.FillColor2 = System.Drawing.Color.Transparent
        Me.btnViewReservations.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewReservations.ForeColor = System.Drawing.Color.White
        Me.btnViewReservations.Image = CType(resources.GetObject("btnViewReservations.Image"), System.Drawing.Image)
        Me.btnViewReservations.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewReservations.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnViewReservations.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnViewReservations.Location = New System.Drawing.Point(0, 0)
        Me.btnViewReservations.Name = "btnViewReservations"
        Me.btnViewReservations.Size = New System.Drawing.Size(200, 50)
        Me.btnViewReservations.TabIndex = 3
        Me.btnViewReservations.Text = "View Reserves"
        Me.btnViewReservations.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnViewReservations.TextOffset = New System.Drawing.Point(10, 2)
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 500)
        Me.Controls.Add(Me.ContentPanel)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1000, 500)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainForm"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.dashboardPanel.ResumeLayout(False)
        Me.reservationPanel.ResumeLayout(False)
        Me.analyticsPanel.ResumeLayout(False)
        Me.settingsPanel.ResumeLayout(False)
        Me.profilePanel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Guna2GradientPanel2.ResumeLayout(False)
        Me.viewreservesPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents profilePanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2ImageButton1 As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents dashboardPanel As Panel
    Friend WithEvents btnDashboard As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents settingsPanel As Panel
    Friend WithEvents btnSettings As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents analyticsPanel As Panel
    Friend WithEvents btnAnalytics As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents reservationPanel As Panel
    Friend WithEvents btnReservations As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ContentPanel As Panel
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents viewreservesPanel As Panel
    Friend WithEvents btnViewReservations As Guna.UI2.WinForms.Guna2GradientButton
End Class
