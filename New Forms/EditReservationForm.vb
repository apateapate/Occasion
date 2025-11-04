Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class EditReservationForm

    ' 🟢 Property to receive the selected reservation from the calendar
    Public Property SelectedReservation As ReservationModel
    Private conn As MySqlConnection

    ' 🔹 LOAD RESERVATION DATA INTO FIELDS
    Private Sub EditReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If SelectedReservation IsNot Nothing Then
                txtClientName.Text = SelectedReservation.ClientName
                txtEmail.Text = SelectedReservation.ClientEmail
                txtContact.Text = SelectedReservation.ClientContact
                txtAltContact.Text = SelectedReservation.ClientAltContact
                txtEventName.Text = SelectedReservation.EventName
                txtDuration.Text = SelectedReservation.EventDuration
                dtpEventDate.Value = SelectedReservation.EventDate
                dtpEventTime.Value = Date.Today.Add(SelectedReservation.EventTime)
                numAttendees.Value = SelectedReservation.Attendees
                cmbVenue.Text = SelectedReservation.VenueName
                cmbStatus.Text = SelectedReservation.EventStatus
            End If
            Me.StartPosition = FormStartPosition.CenterScreen
        Catch ex As Exception
            MessageBox.Show("Error loading reservation data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------------------
    ' Update button
    ' ---------------------------
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' 1) Run validation
        If Not ValidateForm() Then
            MessageBox.Show("Please correct all highlighted errors before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2) Proceed to update
        Try
            Using conn As New MySqlConnection(DatabaseConnection.connectionString)
                conn.Open()

                Dim query As String = "
                    UPDATE occasion_reservations SET 
                        client_name=@name,
                        client_email=@email,
                        client_contact=@contact,
                        client_alt_contact=@alt,
                        event_name=@event,
                        event_duration=@duration,
                        event_date=@date,
                        event_time=@time,
                        attendees=@attendees,
                        venue_name=@venue,
                        event_status=@status
                    WHERE id=@id
                "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", txtClientName.Text.Trim())
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim())
                    cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim())
                    cmd.Parameters.AddWithValue("@alt", txtAltContact.Text.Trim())
                    cmd.Parameters.AddWithValue("@event", txtEventName.Text.Trim())
                    cmd.Parameters.AddWithValue("@duration", txtDuration.Text.Trim())
                    cmd.Parameters.AddWithValue("@date", dtpEventDate.Value.Date)
                    cmd.Parameters.AddWithValue("@time", dtpEventTime.Value.TimeOfDay)
                    cmd.Parameters.AddWithValue("@attendees", Convert.ToInt32(numAttendees.Value))
                    cmd.Parameters.AddWithValue("@venue", cmbVenue.Text.Trim())
                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", SelectedReservation.Id)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Reservation updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating reservation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------------------
    ' Validation
    ' ---------------------------
    Private Function ValidateForm() As Boolean
        Dim isValid As Boolean = True

        ' Reset all label colors/texts
        lblClientName.ForeColor = Color.Black : lblClientName.Text = "Client Name"
        lblEmail.ForeColor = Color.Black : lblEmail.Text = "Email"
        lblContact.ForeColor = Color.Black : lblContact.Text = "Client's Contact No."
        lblAltContact.ForeColor = Color.Black : lblAltContact.Text = "Alternate Contact"
        lblEventName.ForeColor = Color.Black : lblEventName.Text = "Event Name"
        lblDuration.ForeColor = Color.Black : lblDuration.Text = "Duration"
        lblEventDate.ForeColor = Color.Black : lblEventDate.Text = "Event Date"
        lblEventTime.ForeColor = Color.Black : lblEventTime.Text = "Event Time"
        lblAttendees.ForeColor = Color.Black : lblAttendees.Text = "Attendees"
        lblVenue.ForeColor = Color.Black : lblVenue.Text = "Venue"

        ' ✅ Client name (letters only)
        If String.IsNullOrWhiteSpace(txtClientName.Text) OrElse Regex.IsMatch(txtClientName.Text, "\d") Then
            lblClientName.ForeColor = Color.Red
            lblClientName.Text = "Client Name (letters only)"
            isValid = False
        End If

        ' ✅ Email
        If Not txtEmail.Text.Trim().EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) Then
            lblEmail.ForeColor = Color.Red
            lblEmail.Text = "Please enter a valid email (@gmail.com)"
            isValid = False
        End If

        ' ✅ Contact numbers
        If Not Regex.IsMatch(txtContact.Text.Trim(), "^09\d{9}$") Then
            lblContact.ForeColor = Color.Red
            lblContact.Text = "Contact must start with 09 and be 11 digits"
            isValid = False
        End If

        If txtAltContact.Text.Trim() <> "" AndAlso Not Regex.IsMatch(txtAltContact.Text.Trim(), "^09\d{9}$") Then
            lblAltContact.ForeColor = Color.Red
            lblAltContact.Text = "Invalid alternate contact (09xxxxxxxxx)"
            isValid = False
        End If

        ' ✅ Duration
        Dim dur As Integer
        If Not Integer.TryParse(Regex.Replace(txtDuration.Text, "[^\d]", ""), dur) OrElse dur < 1 OrElse dur > 12 Then
            lblDuration.ForeColor = Color.Red
            lblDuration.Text = "Duration must be 1-12 hours"
            isValid = False
        End If

        ' ✅ Event time (8 AM–8 PM)
        If dtpEventTime.Value.Hour < 8 OrElse dtpEventTime.Value.Hour >= 20 Then
            lblEventTime.ForeColor = Color.Red
            lblEventTime.Text = "Invalid time (8 AM–8 PM)"
            isValid = False
        End If

        ' ✅ Attendees
        If numAttendees.Value < 1 OrElse numAttendees.Value > 200 Then
            lblAttendees.ForeColor = Color.Red
            lblAttendees.Text = "Attendees must be 1–200 pax"
            isValid = False
        End If

        ' ✅ Venue
        If String.IsNullOrWhiteSpace(cmbVenue.Text) Then
            lblVenue.ForeColor = Color.Red
            lblVenue.Text = "Please select a venue"
            isValid = False
        End If

        ' ✅ Event date not in the past
        If dtpEventDate.Value.Date < Date.Today Then
            lblEventDate.ForeColor = Color.Red
            lblEventDate.Text = "You cannot select a past date"
            isValid = False
        End If

        ' ✅ Venue availability check
        If isValid Then
            Try
                Using conn As New MySqlConnection(DatabaseConnection.connectionString)
                    conn.Open()
                    Dim query As String = "SELECT COUNT(*) FROM occasion_reservations WHERE event_date=@date AND venue_name=@venue AND id<>@id"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@date", dtpEventDate.Value.Date)
                        cmd.Parameters.AddWithValue("@venue", cmbVenue.Text.Trim())
                        cmd.Parameters.AddWithValue("@id", SelectedReservation.Id)
                        If Convert.ToInt32(cmd.ExecuteScalar()) > 0 Then
                            lblEventDate.ForeColor = Color.Red
                            lblEventDate.Text = "Venue already booked on this date"
                            isValid = False
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Database validation error: " & ex.Message)
                isValid = False
            End Try
        End If

        Return isValid
    End Function

    ' 🔹 CANCEL BUTTON
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

End Class


