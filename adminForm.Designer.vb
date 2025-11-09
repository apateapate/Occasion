<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.btnAnalytics = New System.Windows.Forms.Button()
        Me.btnVenues = New System.Windows.Forms.Button()
        Me.btnReservations = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Indigo
        Me.Panel1.Controls.Add(Me.btnSettings)
        Me.Panel1.Controls.Add(Me.btnAnalytics)
        Me.Panel1.Controls.Add(Me.btnVenues)
        Me.Panel1.Controls.Add(Me.btnReservations)
        Me.Panel1.Controls.Add(Me.btnDashboard)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 450)
        Me.Panel1.TabIndex = 0
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.White
        Me.btnSettings.Location = New System.Drawing.Point(3, 284)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(217, 31)
        Me.btnSettings.TabIndex = 6
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'btnAnalytics
        '
        Me.btnAnalytics.BackColor = System.Drawing.Color.Transparent
        Me.btnAnalytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnalytics.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnalytics.ForeColor = System.Drawing.Color.White
        Me.btnAnalytics.Location = New System.Drawing.Point(3, 247)
        Me.btnAnalytics.Name = "btnAnalytics"
        Me.btnAnalytics.Size = New System.Drawing.Size(217, 31)
        Me.btnAnalytics.TabIndex = 5
        Me.btnAnalytics.Text = "Analytics"
        Me.btnAnalytics.UseVisualStyleBackColor = False
        '
        'btnVenues
        '
        Me.btnVenues.BackColor = System.Drawing.Color.Transparent
        Me.btnVenues.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVenues.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVenues.ForeColor = System.Drawing.Color.White
        Me.btnVenues.Location = New System.Drawing.Point(3, 210)
        Me.btnVenues.Name = "btnVenues"
        Me.btnVenues.Size = New System.Drawing.Size(217, 31)
        Me.btnVenues.TabIndex = 4
        Me.btnVenues.Text = "Venues"
        Me.btnVenues.UseVisualStyleBackColor = False
        '
        'btnReservations
        '
        Me.btnReservations.BackColor = System.Drawing.Color.Transparent
        Me.btnReservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReservations.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservations.ForeColor = System.Drawing.Color.White
        Me.btnReservations.Location = New System.Drawing.Point(3, 173)
        Me.btnReservations.Name = "btnReservations"
        Me.btnReservations.Size = New System.Drawing.Size(217, 31)
        Me.btnReservations.TabIndex = 3
        Me.btnReservations.Text = "Reservations"
        Me.btnReservations.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(3, 136)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(217, 31)
        Me.btnDashboard.TabIndex = 1
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(61, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Reservation System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(61, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Event's Place"
        '
        'adminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnAnalytics As Button
    Friend WithEvents btnVenues As Button
    Friend WithEvents btnReservations As Button
    Friend WithEvents btnDashboard As Button
End Class
