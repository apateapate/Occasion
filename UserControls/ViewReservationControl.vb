Imports MySql.Data.MySqlClient

Public Class ViewReservationControl

    Private mainForm As LoginForm
    Private currentMonth As Date = Date.Today
    Private reservations As New List(Of ReservationModel)

    Private Sub ViewReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReservationsFromDatabase()
        UpdateCalendar()
    End Sub

    Private Sub btnPrevMonth_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        currentMonth = currentMonth.AddMonths(-1)
        UpdateCalendar()
    End Sub

    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentMonth = currentMonth.AddMonths(1)
        UpdateCalendar()
    End Sub

    ' 🟢 Load all reservations from MySQL
    Private Sub LoadReservationsFromDatabase()
        reservations.Clear()

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM occasion_reservations"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            reservations.Add(New ReservationModel With {
                                .Id = Convert.ToInt32(reader("id")),
                                .ClientName = reader("client_name").ToString(),
                                .ClientEmail = reader("client_email").ToString(),
                                .ClientContact = reader("client_contact").ToString(),
                                .ClientAltContact = reader("client_alt_contact").ToString(),
                                .EventName = reader("event_name").ToString(),
                                .EventDuration = reader("event_duration").ToString(),
                                .EventDate = Convert.ToDateTime(reader("event_date")),
                                .EventTime = TimeSpan.Parse(reader("event_time").ToString()),
                                .Attendees = Convert.ToInt32(reader("attendees")),
                                .VenueName = reader("venue_name").ToString(),
                                .EventStatus = reader("event_status").ToString()
                            })
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading reservations: " & ex.Message)
        End Try
    End Sub

    ' 🗓️ Generate the calendar view
    Private Sub UpdateCalendar()
        tblCalendar.Controls.Clear()
        lblMonth.Text = currentMonth.ToString("MMMM (yyyy)").ToUpper()

        Dim firstDay As New Date(currentMonth.Year, currentMonth.Month, 1)
        Dim daysInMonth As Integer = Date.DaysInMonth(currentMonth.Year, currentMonth.Month)
        Dim startCol As Integer = CInt(firstDay.DayOfWeek)
        Dim row As Integer = 0
        Dim col As Integer = startCol

        For day As Integer = 1 To daysInMonth
            Dim btnDay As New Button()
            btnDay.Text = day.ToString()
            btnDay.Dock = DockStyle.Fill
            btnDay.Margin = New Padding(3)
            btnDay.BackColor = Color.White
            btnDay.Font = New Font("Segoe UI", 10, FontStyle.Bold)

            Dim eventDate As New Date(currentMonth.Year, currentMonth.Month, day)
            Dim resOnDate = reservations.Where(Function(r) r.EventDate.Date = eventDate).ToList()

            ' Highlight based on first reservation's status
            If resOnDate.Any() Then
                Dim firstRes = resOnDate.First()
                Select Case firstRes.EventStatus.ToLower()
                    Case "pending" : btnDay.BackColor = Color.Khaki
                    Case "ongoing" : btnDay.BackColor = Color.LightGreen
                    Case "cancelled" : btnDay.BackColor = Color.LightCoral
                    Case "postponed" : btnDay.BackColor = Color.Orange
                    Case "done" : btnDay.BackColor = Color.LightGray
                    Case Else : btnDay.BackColor = Color.White
                End Select

                ' Show first event name for quick glance
                btnDay.Text &= vbCrLf & firstRes.EventName
            End If

            ' 📅 On click — show or add reservation
            AddHandler btnDay.Click,
                Sub()
                    If Not resOnDate.Any() Then
                        Dim result As DialogResult = MessageBox.Show(
                            $"No events scheduled on {eventDate:MMMM d, yyyy}.{Environment.NewLine}Would you like to place an event for this date?",
                            "Event Details",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        )

                        If result = DialogResult.Yes Then
                            Dim placeForm As New ReservationForm()
                            placeForm.dtpEventDate.Value = eventDate ' prefill date
                            placeForm.Show()
                            Me.Hide()
                        End If
                        Exit Sub
                    End If

                    ' Show events if there are any
                    Dim msg As String = $"📅 Events on {eventDate:MMMM d, yyyy}" & vbCrLf & New String("-"c, 40) & vbCrLf

                    For Each r In resOnDate
                        msg &= $"Event Name: {r.EventName}" & vbCrLf &
                               $"Client: {r.ClientName}" & vbCrLf &
                               $"Email: {r.ClientEmail}" & vbCrLf &
                               $"Contact: {r.ClientContact}" & vbCrLf &
                               $"Alternate: {r.ClientAltContact}" & vbCrLf &
                               $"Time: {Date.Today.Add(r.EventTime):hh:mm tt}" & vbCrLf &
                               $"Duration: {r.EventDuration}" & vbCrLf &
                               $"Attendees: {r.Attendees}" & vbCrLf &
                               $"Venue: {r.VenueName}" & vbCrLf &
                               $"Status: {r.EventStatus}" & vbCrLf &
                               New String("-"c, 40) & vbCrLf
                    Next

                    ' Options for edit or delete
                    Dim selectedRes = resOnDate.First()
                    Dim result2 As DialogResult = MessageBox.Show(msg & vbCrLf &
                                                                 "Would you like to edit this reservation?",
                                                                 "Event Details",
                                                                 MessageBoxButtons.YesNoCancel,
                                                                 MessageBoxIcon.Information)

                    If result2 = DialogResult.Yes Then
                        Dim editForm As New EditReservationForm()
                        editForm.SelectedReservation = selectedRes
                        editForm.ShowDialog()
                        LoadReservationsFromDatabase()
                        UpdateCalendar()
                    ElseIf result2 = DialogResult.No Then
                        Dim confirmDelete = MessageBox.Show("Do you want to delete this reservation?",
                                                            "Confirm Deletion",
                                                            MessageBoxButtons.YesNo,
                                                            MessageBoxIcon.Warning)
                        If confirmDelete = DialogResult.Yes Then
                            DeleteReservation(selectedRes.Id)
                            LoadReservationsFromDatabase()
                            UpdateCalendar()
                        End If
                    End If
                End Sub

            tblCalendar.Controls.Add(btnDay, col, row)
            col += 1
            If col > 6 Then
                col = 0
                row += 1
            End If
        Next
    End Sub

    ' 🗑️ Delete reservation from MySQL
    Private Sub DeleteReservation(resId As Integer)
        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "DELETE FROM occasion_reservations WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", resId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Reservation deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error deleting reservation: " & ex.Message)
        End Try
    End Sub

End Class

' 🔸 Reservation class model
Public Class ReservationModel
    Public Property Id As Integer
    Public Property ClientName As String
    Public Property ClientEmail As String
    Public Property ClientContact As String
    Public Property ClientAltContact As String
    Public Property EventName As String
    Public Property EventDuration As String
    Public Property EventDate As Date
    Public Property EventTime As TimeSpan
    Public Property Attendees As Integer
    Public Property VenueName As String
    Public Property EventStatus As String
End Class
