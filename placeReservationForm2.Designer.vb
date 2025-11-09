<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class placeReservationForm2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(placeReservationForm2))
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtAltContact = New System.Windows.Forms.TextBox()
        Me.numAttendees = New System.Windows.Forms.NumericUpDown()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.lblAttendees = New System.Windows.Forms.Label()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.cmbVenue = New System.Windows.Forms.ComboBox()
        Me.dtpEventTime = New System.Windows.Forms.DateTimePicker()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblEventTime = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lblAltContact = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.picBack = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.numAttendees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(453, 95)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(255, 22)
        Me.txtContact.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(112, 168)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 22)
        Me.txtEmail.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OldLace
        Me.Panel1.Controls.Add(Me.txtAltContact)
        Me.Panel1.Controls.Add(Me.numAttendees)
        Me.Panel1.Controls.Add(Me.dtpEventDate)
        Me.Panel1.Controls.Add(Me.lblAttendees)
        Me.Panel1.Controls.Add(Me.lblEventName)
        Me.Panel1.Controls.Add(Me.lblEventDate)
        Me.Panel1.Controls.Add(Me.txtEventName)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.txtClientName)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblClientName)
        Me.Panel1.Controls.Add(Me.lblVenue)
        Me.Panel1.Controls.Add(Me.cmbVenue)
        Me.Panel1.Controls.Add(Me.dtpEventTime)
        Me.Panel1.Controls.Add(Me.lblDuration)
        Me.Panel1.Controls.Add(Me.lblEventTime)
        Me.Panel1.Controls.Add(Me.txtDuration)
        Me.Panel1.Controls.Add(Me.lblAltContact)
        Me.Panel1.Controls.Add(Me.lblContact)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.picBack)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(820, 450)
        Me.Panel1.TabIndex = 5
        '
        'txtAltContact
        '
        Me.txtAltContact.Location = New System.Drawing.Point(454, 164)
        Me.txtAltContact.Name = "txtAltContact"
        Me.txtAltContact.Size = New System.Drawing.Size(255, 22)
        Me.txtAltContact.TabIndex = 31
        '
        'numAttendees
        '
        Me.numAttendees.Location = New System.Drawing.Point(112, 366)
        Me.numAttendees.Name = "numAttendees"
        Me.numAttendees.Size = New System.Drawing.Size(250, 22)
        Me.numAttendees.TabIndex = 27
        '
        'dtpEventDate
        '
        Me.dtpEventDate.Location = New System.Drawing.Point(112, 296)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(250, 22)
        Me.dtpEventDate.TabIndex = 20
        '
        'lblAttendees
        '
        Me.lblAttendees.AutoSize = True
        Me.lblAttendees.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendees.Location = New System.Drawing.Point(113, 340)
        Me.lblAttendees.Name = "lblAttendees"
        Me.lblAttendees.Size = New System.Drawing.Size(139, 23)
        Me.lblAttendees.TabIndex = 23
        Me.lblAttendees.Text = "Number of Attendees:"
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventName.Location = New System.Drawing.Point(108, 205)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(99, 23)
        Me.lblEventName.TabIndex = 16
        Me.lblEventName.Text = "Name of Event:"
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDate.Location = New System.Drawing.Point(108, 270)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(75, 23)
        Me.lblEventDate.TabIndex = 18
        Me.lblEventDate.Text = "Event Date:"
        '
        'txtEventName
        '
        Me.txtEventName.Location = New System.Drawing.Point(112, 240)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(250, 22)
        Me.txtEventName.TabIndex = 14
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(108, 142)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(94, 23)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Client's E-mail:"
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(112, 95)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(250, 22)
        Me.txtClientName.TabIndex = 0
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientName.Location = New System.Drawing.Point(113, 69)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(93, 23)
        Me.lblClientName.TabIndex = 6
        Me.lblClientName.Text = "Client's Name:"
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.Location = New System.Drawing.Point(450, 340)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(83, 23)
        Me.lblVenue.TabIndex = 29
        Me.lblVenue.Text = "Venue Place:"
        '
        'cmbVenue
        '
        Me.cmbVenue.FormattingEnabled = True
        Me.cmbVenue.Items.AddRange(New Object() {"The Enchanted Bloom Hall 🌸", "The Royal Radiance Grand Hall 👑", "The Crystal Mirage Ballroom ✨", "The Golden Grace Lounge 💫"})
        Me.cmbVenue.Location = New System.Drawing.Point(453, 366)
        Me.cmbVenue.Name = "cmbVenue"
        Me.cmbVenue.Size = New System.Drawing.Size(255, 24)
        Me.cmbVenue.TabIndex = 28
        '
        'dtpEventTime
        '
        Me.dtpEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEventTime.Location = New System.Drawing.Point(453, 296)
        Me.dtpEventTime.Name = "dtpEventTime"
        Me.dtpEventTime.Size = New System.Drawing.Size(255, 22)
        Me.dtpEventTime.TabIndex = 21
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(450, 205)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(98, 23)
        Me.lblDuration.TabIndex = 17
        Me.lblDuration.Text = "Event Duration:"
        '
        'lblEventTime
        '
        Me.lblEventTime.AutoSize = True
        Me.lblEventTime.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTime.Location = New System.Drawing.Point(449, 270)
        Me.lblEventTime.Name = "lblEventTime"
        Me.lblEventTime.Size = New System.Drawing.Size(76, 23)
        Me.lblEventTime.TabIndex = 19
        Me.lblEventTime.Text = "Event Time:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(454, 240)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(255, 22)
        Me.txtDuration.TabIndex = 15
        '
        'lblAltContact
        '
        Me.lblAltContact.AutoSize = True
        Me.lblAltContact.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltContact.Location = New System.Drawing.Point(449, 133)
        Me.lblAltContact.Name = "lblAltContact"
        Me.lblAltContact.Size = New System.Drawing.Size(180, 23)
        Me.lblAltContact.TabIndex = 9
        Me.lblAltContact.Text = "Client's Alternate Contact No."
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(457, 69)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(124, 23)
        Me.lblContact.TabIndex = 7
        Me.lblContact.Text = "Client's Contact No."
        '
        'picBack
        '
        Me.picBack.Image = CType(resources.GetObject("picBack.Image"), System.Drawing.Image)
        Me.picBack.Location = New System.Drawing.Point(12, 9)
        Me.picBack.Name = "picBack"
        Me.picBack.Size = New System.Drawing.Size(55, 41)
        Me.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBack.TabIndex = 30
        Me.picBack.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Indigo
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(255, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 50)
        Me.Panel2.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Indigo
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(76, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 41)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fill up Form"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Indigo
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.Color.Orange
        Me.btnSave.Location = New System.Drawing.Point(622, 404)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 29)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Indigo
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.ForeColor = System.Drawing.Color.Orange
        Me.btnClear.Location = New System.Drawing.Point(532, 404)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 29)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'placeReservationForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "placeReservationForm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "placeReservationForm2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.numAttendees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAltContact As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblAttendees As Label
    Friend WithEvents dtpEventTime As DateTimePicker
    Friend WithEvents dtpEventDate As DateTimePicker
    Friend WithEvents lblEventTime As Label
    Friend WithEvents lblEventDate As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblEventName As Label
    Friend WithEvents txtEventName As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblVenue As Label
    Friend WithEvents picBack As PictureBox
    Friend WithEvents numAttendees As NumericUpDown
    Friend WithEvents cmbVenue As ComboBox
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents lblClientName As Label
    Friend WithEvents txtAltContact As TextBox
End Class
