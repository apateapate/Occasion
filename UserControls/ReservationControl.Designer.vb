<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReservationControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReservationControl))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.venue1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.venue2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.venue4 = New System.Windows.Forms.PictureBox()
        Me.venue3 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tblVenues = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.venue1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venue2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venue4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.venue3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblVenues.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(790, 517)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.lblMonth)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 20)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(790, 50)
        Me.Guna2Panel1.TabIndex = 0
        '
        'lblMonth
        '
        Me.lblMonth.BackColor = System.Drawing.Color.Transparent
        Me.lblMonth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMonth.Font = New System.Drawing.Font("Poppins", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(0, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(790, 50)
        Me.lblMonth.TabIndex = 0
        Me.lblMonth.Text = "CHOOSE YOUR RESERVATION PLACE"
        Me.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.tblVenues)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 80)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel1.Size = New System.Drawing.Size(790, 437)
        Me.Panel1.TabIndex = 1
        '
        'venue1
        '
        Me.venue1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.venue1.Image = CType(resources.GetObject("venue1.Image"), System.Drawing.Image)
        Me.venue1.Location = New System.Drawing.Point(2, 2)
        Me.venue1.Margin = New System.Windows.Forms.Padding(2)
        Me.venue1.Name = "venue1"
        Me.venue1.Size = New System.Drawing.Size(371, 170)
        Me.venue1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.venue1.TabIndex = 12
        Me.venue1.TabStop = False
        Me.venue1.Tag = "The Enchanted Bloom Hall 🌸"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 24)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "The Enchanted Bloom Hall"
        '
        'venue2
        '
        Me.venue2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.venue2.Image = CType(resources.GetObject("venue2.Image"), System.Drawing.Image)
        Me.venue2.Location = New System.Drawing.Point(377, 2)
        Me.venue2.Margin = New System.Windows.Forms.Padding(2)
        Me.venue2.Name = "venue2"
        Me.venue2.Size = New System.Drawing.Size(371, 170)
        Me.venue2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.venue2.TabIndex = 15
        Me.venue2.TabStop = False
        Me.venue2.Tag = "The Royal Radiance Grand Hall 👑"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(378, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 24)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "The Royal Radiance Grand Hall"
        '
        'venue4
        '
        Me.venue4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.venue4.Image = CType(resources.GetObject("venue4.Image"), System.Drawing.Image)
        Me.venue4.Location = New System.Drawing.Point(377, 200)
        Me.venue4.Margin = New System.Windows.Forms.Padding(2)
        Me.venue4.Name = "venue4"
        Me.venue4.Size = New System.Drawing.Size(371, 170)
        Me.venue4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.venue4.TabIndex = 14
        Me.venue4.TabStop = False
        Me.venue4.Tag = "The Golden Grace Lounge 💫"
        '
        'venue3
        '
        Me.venue3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.venue3.Image = CType(resources.GetObject("venue3.Image"), System.Drawing.Image)
        Me.venue3.Location = New System.Drawing.Point(2, 200)
        Me.venue3.Margin = New System.Windows.Forms.Padding(2)
        Me.venue3.Name = "venue3"
        Me.venue3.Size = New System.Drawing.Size(371, 170)
        Me.venue3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.venue3.TabIndex = 13
        Me.venue3.TabStop = False
        Me.venue3.Tag = "The Crystal Mirage Ballroom ✨"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(378, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 25)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "The Golden Grace Lounge"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "The Crystal Mirage Ballroom"
        '
        'tblVenues
        '
        Me.tblVenues.BackColor = System.Drawing.Color.Transparent
        Me.tblVenues.ColumnCount = 2
        Me.tblVenues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblVenues.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblVenues.Controls.Add(Me.Label4, 0, 3)
        Me.tblVenues.Controls.Add(Me.Label5, 1, 3)
        Me.tblVenues.Controls.Add(Me.venue3, 0, 2)
        Me.tblVenues.Controls.Add(Me.venue4, 1, 2)
        Me.tblVenues.Controls.Add(Me.Label3, 1, 1)
        Me.tblVenues.Controls.Add(Me.venue2, 1, 0)
        Me.tblVenues.Controls.Add(Me.Label2, 0, 1)
        Me.tblVenues.Controls.Add(Me.venue1, 0, 0)
        Me.tblVenues.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblVenues.Location = New System.Drawing.Point(20, 20)
        Me.tblVenues.Margin = New System.Windows.Forms.Padding(0)
        Me.tblVenues.Name = "tblVenues"
        Me.tblVenues.RowCount = 4
        Me.tblVenues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblVenues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tblVenues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblVenues.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tblVenues.Size = New System.Drawing.Size(750, 397)
        Me.tblVenues.TabIndex = 21
        '
        'ReservationControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ReservationControl"
        Me.Size = New System.Drawing.Size(790, 517)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.venue1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venue2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venue4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.venue3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblVenues.ResumeLayout(False)
        Me.tblVenues.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblMonth As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tblVenues As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents venue3 As PictureBox
    Friend WithEvents venue4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents venue2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents venue1 As PictureBox
End Class
