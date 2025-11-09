<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class placeReservationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(placeReservationForm))
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tblVenues = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.venue3 = New System.Windows.Forms.PictureBox()
        Me.venue4 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.venue2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.venue1 = New System.Windows.Forms.PictureBox()
        Me.MainPanel.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblVenues.SuspendLayout()
        CType(Me.venue3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venue4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venue2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venue1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Rockwell", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.Orange
        Me.LabelTitle.Location = New System.Drawing.Point(68, 6)
        Me.LabelTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(530, 53)
        Me.LabelTitle.TabIndex = 7
        Me.LabelTitle.Text = "CHOOSE A LOCATION!"
        '
        'MainPanel
        '
        Me.MainPanel.AutoSize = True
        Me.MainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.MainPanel.Controls.Add(Me.HeaderPanel)
        Me.MainPanel.Controls.Add(Me.tblVenues)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(800, 450)
        Me.MainPanel.TabIndex = 12
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.Indigo
        Me.HeaderPanel.Controls.Add(Me.LabelTitle)
        Me.HeaderPanel.Controls.Add(Me.PictureBox1)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(800, 78)
        Me.HeaderPanel.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(658, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'tblVenues
        '
        Me.tblVenues.BackColor = System.Drawing.Color.Indigo
        Me.tblVenues.ColumnCount = 2
        Me.tblVenues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblVenues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblVenues.Controls.Add(Me.Label4, 0, 3)
        Me.tblVenues.Controls.Add(Me.Label5, 1, 3)
        Me.tblVenues.Controls.Add(Me.venue3, 0, 2)
        Me.tblVenues.Controls.Add(Me.venue4, 1, 2)
        Me.tblVenues.Controls.Add(Me.Label3, 1, 1)
        Me.tblVenues.Controls.Add(Me.venue2, 1, 0)
        Me.tblVenues.Controls.Add(Me.Label1, 0, 1)
        Me.tblVenues.Controls.Add(Me.venue1, 0, 0)
        Me.tblVenues.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tblVenues.Location = New System.Drawing.Point(0, 69)
        Me.tblVenues.Name = "tblVenues"
        Me.tblVenues.RowCount = 4
        Me.tblVenues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblVenues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblVenues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblVenues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tblVenues.Size = New System.Drawing.Size(800, 381)
        Me.tblVenues.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(4, 350)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(293, 31)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "The Crystal Mirage Ballroom ✨"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(404, 350)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(387, 31)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "The Golden Grace Lounge 💫" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'venue3
        '
        Me.venue3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.venue3.Image = CType(resources.GetObject("venue3.Image"), System.Drawing.Image)
        Me.venue3.Location = New System.Drawing.Point(3, 193)
        Me.venue3.Name = "venue3"
        Me.venue3.Size = New System.Drawing.Size(394, 154)
        Me.venue3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.venue3.TabIndex = 13
        Me.venue3.TabStop = False
        Me.venue3.Tag = "The Crystal Mirage Ballroom ✨"
        '
        'venue4
        '
        Me.venue4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.venue4.Image = CType(resources.GetObject("venue4.Image"), System.Drawing.Image)
        Me.venue4.Location = New System.Drawing.Point(403, 193)
        Me.venue4.Name = "venue4"
        Me.venue4.Size = New System.Drawing.Size(394, 154)
        Me.venue4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.venue4.TabIndex = 14
        Me.venue4.TabStop = False
        Me.venue4.Tag = "The Golden Grace Lounge 💫"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(404, 160)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(387, 30)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "The Royal Radiance Grand Hall 👑" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'venue2
        '
        Me.venue2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.venue2.Image = CType(resources.GetObject("venue2.Image"), System.Drawing.Image)
        Me.venue2.Location = New System.Drawing.Point(403, 3)
        Me.venue2.Name = "venue2"
        Me.venue2.Size = New System.Drawing.Size(394, 154)
        Me.venue2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.venue2.TabIndex = 15
        Me.venue2.TabStop = False
        Me.venue2.Tag = "The Royal Radiance Grand Hall 👑"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(4, 160)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 30)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "The Enchanted Bloom Hall 🌸"
        '
        'venue1
        '
        Me.venue1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.venue1.Image = CType(resources.GetObject("venue1.Image"), System.Drawing.Image)
        Me.venue1.Location = New System.Drawing.Point(3, 3)
        Me.venue1.Name = "venue1"
        Me.venue1.Size = New System.Drawing.Size(394, 154)
        Me.venue1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.venue1.TabIndex = 12
        Me.venue1.TabStop = False
        Me.venue1.Tag = "The Enchanted Bloom Hall 🌸"
        '
        'placeReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "placeReservationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "placeReservationForm"
        Me.MainPanel.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblVenues.ResumeLayout(False)
        Me.tblVenues.PerformLayout()
        CType(Me.venue3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venue4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venue2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venue1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelTitle As Label
    Friend WithEvents MainPanel As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents venue2 As PictureBox
    Friend WithEvents venue4 As PictureBox
    Friend WithEvents venue3 As PictureBox
    Friend WithEvents venue1 As PictureBox
    Friend WithEvents tblVenues As TableLayoutPanel
    Friend WithEvents HeaderPanel As Panel
End Class
