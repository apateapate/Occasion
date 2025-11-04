<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditReservationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.editPanel = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.lblVenue = New System.Windows.Forms.Label()
        Me.cmbVenue = New System.Windows.Forms.ComboBox()
        Me.numAttendees = New System.Windows.Forms.NumericUpDown()
        Me.lblAttendees = New System.Windows.Forms.Label()
        Me.dtpEventTime = New System.Windows.Forms.DateTimePicker()
        Me.dtpEventDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEventTime = New System.Windows.Forms.Label()
        Me.lblEventDate = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblEventName = New System.Windows.Forms.Label()
        Me.txtEventName = New System.Windows.Forms.TextBox()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.lblAltContact = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.txtClientName = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtAltContact = New System.Windows.Forms.TextBox()
        Me.editPanel.SuspendLayout()
        CType(Me.numAttendees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'editPanel
        '
        Me.editPanel.BackColor = System.Drawing.Color.OldLace
        Me.editPanel.Controls.Add(Me.btnCancel)
        Me.editPanel.Controls.Add(Me.btnUpdate)
        Me.editPanel.Controls.Add(Me.Label5)
        Me.editPanel.Controls.Add(Me.cmbStatus)
        Me.editPanel.Controls.Add(Me.lblVenue)
        Me.editPanel.Controls.Add(Me.cmbVenue)
        Me.editPanel.Controls.Add(Me.numAttendees)
        Me.editPanel.Controls.Add(Me.lblAttendees)
        Me.editPanel.Controls.Add(Me.dtpEventTime)
        Me.editPanel.Controls.Add(Me.dtpEventDate)
        Me.editPanel.Controls.Add(Me.lblEventTime)
        Me.editPanel.Controls.Add(Me.lblEventDate)
        Me.editPanel.Controls.Add(Me.lblDuration)
        Me.editPanel.Controls.Add(Me.lblEventName)
        Me.editPanel.Controls.Add(Me.txtEventName)
        Me.editPanel.Controls.Add(Me.txtDuration)
        Me.editPanel.Controls.Add(Me.lblAltContact)
        Me.editPanel.Controls.Add(Me.lblEmail)
        Me.editPanel.Controls.Add(Me.lblContact)
        Me.editPanel.Controls.Add(Me.lblClientName)
        Me.editPanel.Controls.Add(Me.txtClientName)
        Me.editPanel.Controls.Add(Me.txtContact)
        Me.editPanel.Controls.Add(Me.txtEmail)
        Me.editPanel.Controls.Add(Me.txtAltContact)
        Me.editPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editPanel.Location = New System.Drawing.Point(0, 0)
        Me.editPanel.Name = "editPanel"
        Me.editPanel.Size = New System.Drawing.Size(800, 450)
        Me.editPanel.TabIndex = 0
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Indigo
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.Color.Orange
        Me.btnCancel.Location = New System.Drawing.Point(659, 391)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 36)
        Me.btnCancel.TabIndex = 53
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Indigo
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.Orange
        Me.btnUpdate.Location = New System.Drawing.Point(566, 391)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(87, 36)
        Me.btnUpdate.TabIndex = 52
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(103, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Event Status:"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Pending", "Ongoing", "Postponed", "Cancelled", "Done"})
        Me.cmbStatus.Location = New System.Drawing.Point(106, 391)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(250, 24)
        Me.cmbStatus.TabIndex = 50
        '
        'lblVenue
        '
        Me.lblVenue.AutoSize = True
        Me.lblVenue.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVenue.Location = New System.Drawing.Point(440, 297)
        Me.lblVenue.Name = "lblVenue"
        Me.lblVenue.Size = New System.Drawing.Size(83, 23)
        Me.lblVenue.TabIndex = 49
        Me.lblVenue.Text = "Venue Place:"
        '
        'cmbVenue
        '
        Me.cmbVenue.FormattingEnabled = True
        Me.cmbVenue.Items.AddRange(New Object() {"The Enchanted Bloom Hall 🌸", "The Royal Radiance Grand Hall 👑", "The Crystal Mirage Ballroom ✨", "The Golden Grace Lounge 💫"})
        Me.cmbVenue.Location = New System.Drawing.Point(443, 323)
        Me.cmbVenue.Name = "cmbVenue"
        Me.cmbVenue.Size = New System.Drawing.Size(255, 24)
        Me.cmbVenue.TabIndex = 48
        '
        'numAttendees
        '
        Me.numAttendees.Location = New System.Drawing.Point(106, 325)
        Me.numAttendees.Name = "numAttendees"
        Me.numAttendees.Size = New System.Drawing.Size(250, 22)
        Me.numAttendees.TabIndex = 47
        '
        'lblAttendees
        '
        Me.lblAttendees.AutoSize = True
        Me.lblAttendees.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAttendees.Location = New System.Drawing.Point(102, 299)
        Me.lblAttendees.Name = "lblAttendees"
        Me.lblAttendees.Size = New System.Drawing.Size(139, 23)
        Me.lblAttendees.TabIndex = 46
        Me.lblAttendees.Text = "Number of Attendees:"
        '
        'dtpEventTime
        '
        Me.dtpEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpEventTime.Location = New System.Drawing.Point(443, 255)
        Me.dtpEventTime.Name = "dtpEventTime"
        Me.dtpEventTime.Size = New System.Drawing.Size(255, 22)
        Me.dtpEventTime.TabIndex = 45
        '
        'dtpEventDate
        '
        Me.dtpEventDate.Location = New System.Drawing.Point(106, 255)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(250, 22)
        Me.dtpEventDate.TabIndex = 44
        '
        'lblEventTime
        '
        Me.lblEventTime.AutoSize = True
        Me.lblEventTime.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventTime.Location = New System.Drawing.Point(439, 229)
        Me.lblEventTime.Name = "lblEventTime"
        Me.lblEventTime.Size = New System.Drawing.Size(76, 23)
        Me.lblEventTime.TabIndex = 43
        Me.lblEventTime.Text = "Event Time:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventDate.Location = New System.Drawing.Point(102, 229)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(75, 23)
        Me.lblEventDate.TabIndex = 42
        Me.lblEventDate.Text = "Event Date:"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(439, 167)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(98, 23)
        Me.lblDuration.TabIndex = 41
        Me.lblDuration.Text = "Event Duration:"
        '
        'lblEventName
        '
        Me.lblEventName.AutoSize = True
        Me.lblEventName.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventName.Location = New System.Drawing.Point(102, 167)
        Me.lblEventName.Name = "lblEventName"
        Me.lblEventName.Size = New System.Drawing.Size(99, 23)
        Me.lblEventName.TabIndex = 40
        Me.lblEventName.Text = "Name of Event:"
        '
        'txtEventName
        '
        Me.txtEventName.Location = New System.Drawing.Point(106, 202)
        Me.txtEventName.Name = "txtEventName"
        Me.txtEventName.Size = New System.Drawing.Size(250, 22)
        Me.txtEventName.TabIndex = 38
        '
        'txtDuration
        '
        Me.txtDuration.Location = New System.Drawing.Point(443, 202)
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.Size = New System.Drawing.Size(255, 22)
        Me.txtDuration.TabIndex = 39
        '
        'lblAltContact
        '
        Me.lblAltContact.AutoSize = True
        Me.lblAltContact.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAltContact.Location = New System.Drawing.Point(439, 97)
        Me.lblAltContact.Name = "lblAltContact"
        Me.lblAltContact.Size = New System.Drawing.Size(180, 23)
        Me.lblAltContact.TabIndex = 37
        Me.lblAltContact.Text = "Client's Alternate Contact No."
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(102, 97)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(94, 23)
        Me.lblEmail.TabIndex = 36
        Me.lblEmail.Text = "Client's E-mail:"
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact.Location = New System.Drawing.Point(439, 35)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(124, 23)
        Me.lblContact.TabIndex = 35
        Me.lblContact.Text = "Client's Contact No."
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Font = New System.Drawing.Font("Myanmar Text", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientName.Location = New System.Drawing.Point(108, 35)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(93, 23)
        Me.lblClientName.TabIndex = 34
        Me.lblClientName.Text = "Client's Name:"
        '
        'txtClientName
        '
        Me.txtClientName.Location = New System.Drawing.Point(106, 70)
        Me.txtClientName.Name = "txtClientName"
        Me.txtClientName.Size = New System.Drawing.Size(250, 22)
        Me.txtClientName.TabIndex = 30
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(443, 70)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(255, 22)
        Me.txtContact.TabIndex = 32
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(106, 123)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 22)
        Me.txtEmail.TabIndex = 33
        '
        'txtAltContact
        '
        Me.txtAltContact.Location = New System.Drawing.Point(443, 123)
        Me.txtAltContact.Name = "txtAltContact"
        Me.txtAltContact.Size = New System.Drawing.Size(255, 22)
        Me.txtAltContact.TabIndex = 31
        '
        'EditReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.editPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditReservationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editReservationForm"
        Me.editPanel.ResumeLayout(False)
        Me.editPanel.PerformLayout()
        CType(Me.numAttendees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents editPanel As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents lblVenue As Label
    Friend WithEvents cmbVenue As ComboBox
    Friend WithEvents numAttendees As NumericUpDown
    Friend WithEvents lblAttendees As Label
    Friend WithEvents dtpEventTime As DateTimePicker
    Friend WithEvents dtpEventDate As DateTimePicker
    Friend WithEvents lblEventTime As Label
    Friend WithEvents lblEventDate As Label
    Friend WithEvents lblDuration As Label
    Friend WithEvents lblEventName As Label
    Friend WithEvents txtEventName As TextBox
    Friend WithEvents txtDuration As TextBox
    Friend WithEvents lblAltContact As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents lblClientName As Label
    Friend WithEvents txtClientName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAltContact As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdate As Button
End Class
