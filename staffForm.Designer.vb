<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(staffForm))
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PanelPlace = New System.Windows.Forms.Panel()
        Me.picPlace = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.picView = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.picExit = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelLeft.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPlace.SuspendLayout()
        CType(Me.picPlace, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.picView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPlace
        '
        Me.btnPlace.BackColor = System.Drawing.Color.Indigo
        Me.btnPlace.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlace.ForeColor = System.Drawing.Color.Orange
        Me.btnPlace.Location = New System.Drawing.Point(88, 0)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(265, 82)
        Me.btnPlace.TabIndex = 7
        Me.btnPlace.Text = "PLACE RESERVATION"
        Me.btnPlace.UseVisualStyleBackColor = False
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Indigo
        Me.btnView.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.Orange
        Me.btnView.Location = New System.Drawing.Point(88, 1)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(265, 82)
        Me.btnView.TabIndex = 8
        Me.btnView.Text = "VIEW RESERVATION"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.Indigo
        Me.PanelLeft.Controls.Add(Me.PictureBox1)
        Me.PanelLeft.Controls.Add(Me.Label5)
        Me.PanelLeft.Controls.Add(Me.Label3)
        Me.PanelLeft.Controls.Add(Me.Label1)
        Me.PanelLeft.Controls.Add(Me.Label6)
        Me.PanelLeft.Controls.Add(Me.Label4)
        Me.PanelLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(278, 450)
        Me.PanelLeft.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(84, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(4, 247)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 38)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "EVENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(4, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 38)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "AWAY FROM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(4, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 38)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ONE BOOK"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(102, 87)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 38)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "YOU'RE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(4, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(258, 38)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "YOUR PERFECT"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Indigo
        Me.btnExit.Font = New System.Drawing.Font("Rockwell", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Orange
        Me.btnExit.Location = New System.Drawing.Point(85, -2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(266, 86)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "RETURN"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PanelPlace
        '
        Me.PanelPlace.Controls.Add(Me.picPlace)
        Me.PanelPlace.Controls.Add(Me.btnPlace)
        Me.PanelPlace.Location = New System.Drawing.Point(348, 89)
        Me.PanelPlace.Name = "PanelPlace"
        Me.PanelPlace.Size = New System.Drawing.Size(354, 82)
        Me.PanelPlace.TabIndex = 11
        '
        'picPlace
        '
        Me.picPlace.Image = CType(resources.GetObject("picPlace.Image"), System.Drawing.Image)
        Me.picPlace.Location = New System.Drawing.Point(3, 3)
        Me.picPlace.Name = "picPlace"
        Me.picPlace.Size = New System.Drawing.Size(83, 76)
        Me.picPlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPlace.TabIndex = 8
        Me.picPlace.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.picView)
        Me.Panel3.Controls.Add(Me.btnView)
        Me.Panel3.Location = New System.Drawing.Point(348, 194)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(354, 82)
        Me.Panel3.TabIndex = 12
        '
        'picView
        '
        Me.picView.Image = CType(resources.GetObject("picView.Image"), System.Drawing.Image)
        Me.picView.Location = New System.Drawing.Point(3, 3)
        Me.picView.Name = "picView"
        Me.picView.Size = New System.Drawing.Size(83, 76)
        Me.picView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picView.TabIndex = 9
        Me.picView.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.picExit)
        Me.Panel4.Controls.Add(Me.btnExit)
        Me.Panel4.Location = New System.Drawing.Point(351, 299)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(351, 83)
        Me.Panel4.TabIndex = 13
        '
        'picExit
        '
        Me.picExit.Image = CType(resources.GetObject("picExit.Image"), System.Drawing.Image)
        Me.picExit.Location = New System.Drawing.Point(0, 1)
        Me.picExit.Name = "picExit"
        Me.picExit.Size = New System.Drawing.Size(83, 82)
        Me.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picExit.TabIndex = 11
        Me.picExit.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(278, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(493, 53)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BOOK RESERVATION"
        '
        'staffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(820, 450)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.PanelPlace)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "staffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staffForm"
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelLeft.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPlace.ResumeLayout(False)
        CType(Me.picPlace, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.picView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.picExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlace As Button
    Friend WithEvents btnView As Button
    Friend WithEvents PanelLeft As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelPlace As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picPlace As PictureBox
    Friend WithEvents picView As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents picExit As PictureBox
    Friend WithEvents Label2 As Label
End Class
