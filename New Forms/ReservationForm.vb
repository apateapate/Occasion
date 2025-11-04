Imports MySql.Data.MySqlClient

Public Class ReservationForm

    ' ✅ Property to receive venue from previous form
    Public Property SelectedVenue As String

    Private Sub placeReservationForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Automatically set and lock the venue ComboBox
        If Not String.IsNullOrEmpty(SelectedVenue) Then
            cmbVenue.Text = SelectedVenue
            cmbVenue.Enabled = False
        End If
    End Sub

    ' ✅ GENERAL VALIDATION FUNCTION
    Private Function ValidateAllFields() As Boolean
        Dim isValid As Boolean = True

        ' Reset label colors and text before checking
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

        ' Check all required fields
        If String.IsNullOrWhiteSpace(txtClientName.Text) Then
            lblClientName.ForeColor = Color.Red
            lblClientName.Text = "Please fill all the tabs"
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtEmail.Text) Then
            lblEmail.ForeColor = Color.Red
            lblEmail.Text = "Please fill all the tabs"
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtContact.Text) Then
            lblContact.ForeColor = Color.Red
            lblContact.Text = "Please fill all the tabs"
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtAltContact.Text) Then
            lblAltContact.ForeColor = Color.Red
            lblAltContact.Text = "Please fill all the tabs"
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtEventName.Text) Then
            lblEventName.ForeColor = Color.Red
            lblEventName.Text = "Please fill all the tabs"
            isValid = False
        End If

        If String.IsNullOrWhiteSpace(txtDuration.Text) Then
            lblDuration.ForeColor = Color.Red
            lblDuration.Text = "Please fill all the tabs"
            isValid = False
        End If

        If numAttendees.Value <= 0 Then
            lblAttendees.ForeColor = Color.Red
            lblAttendees.Text = "Please fill all the tabs"
            isValid = False
        End If

        If cmbVenue.SelectedIndex = -1 OrElse String.IsNullOrWhiteSpace(cmbVenue.Text) Then
            lblVenue.ForeColor = Color.Red
            lblVenue.Text = "Please fill all the tabs"
            isValid = False
        End If

        Return isValid
    End Function


    ' ✅ Reserve Button
    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' 🔴 Check if form passes all validations before saving
        If Not IsFormValid() Then
            MessageBox.Show("Please correct all errors before saving. Some fields in other tabs may still be invalid.",
                        "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 🔴 Extra protection: check if there are still red labels (validation errors)
        For Each ctrl As Control In Me.Controls
            If Not HasErrorLabel(ctrl) Then
                Continue For
            End If
            MessageBox.Show("You still have errors on the form. Please fix them before saving.",
                        "Invalid Inputs", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        Next

        Try
            OpenConnection()

            Dim query As String = "INSERT INTO occasion_reservations 
            (client_name, client_email, client_contact, client_alt_contact, event_name, event_duration, event_date, event_time, attendees, venue_name, event_status)
            VALUES (@name, @email, @contact, @alt, @event, @duration, @date, @time, @attendees, @venue, 'Pending')"

            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", txtClientName.Text)
                cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                cmd.Parameters.AddWithValue("@contact", txtContact.Text)
                cmd.Parameters.AddWithValue("@alt", txtAltContact.Text)
                cmd.Parameters.AddWithValue("@event", txtEventName.Text)
                cmd.Parameters.AddWithValue("@duration", txtDuration.Text)
                cmd.Parameters.AddWithValue("@date", dtpEventDate.Value.Date)
                cmd.Parameters.AddWithValue("@time", dtpEventTime.Value.TimeOfDay)
                cmd.Parameters.AddWithValue("@attendees", Convert.ToInt32(numAttendees.Value))
                cmd.Parameters.AddWithValue("@venue", cmbVenue.Text)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Reservation successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try

    End Sub

    ' ✅ Check if any label still has red text (indicating an error)
    Private Function HasErrorLabel(ctrl As Control) As Boolean
        ' Only check Label controls
        If TypeOf ctrl Is Label Then
            Dim lbl As Label = DirectCast(ctrl, Label)
            If lbl.ForeColor = Color.Red Then
                Return True
            End If
        End If

        ' Recursively check child controls (like inside panels or groupboxes)
        For Each child As Control In ctrl.Controls
            If HasErrorLabel(child) Then
                Return True
            End If
        Next

        Return False
    End Function


    Private Sub picBack_Click(sender As Object, e As EventArgs) Handles picBack.Click
        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to close this form? Unsaved data will be lost.",
            "Confirm Return",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If confirm = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtClientName_TextChanged(sender As Object, e As EventArgs) Handles txtClientName.TextChanged
        Dim currentText As String = txtClientName.Text

        ' Allow only letters and spaces
        Dim validText As String = System.Text.RegularExpressions.Regex.Replace(currentText, "[^a-zA-Z\s]", "")

        ' If invalid characters were entered, fix the text
        If currentText <> validText Then
            Dim cursorPos As Integer = txtClientName.SelectionStart
            txtClientName.Text = validText
            txtClientName.SelectionStart = Math.Max(0, cursorPos - 1)
        End If

        ' Label validation feedback
        If System.Text.RegularExpressions.Regex.IsMatch(currentText, "\d") Then
            lblClientName.ForeColor = Color.Red
            lblClientName.Text = "Client Name (letters only)"
        Else
            lblClientName.ForeColor = Color.Black
            lblClientName.Text = "Client Name"
        End If
    End Sub


    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        Dim currentText As String = txtContact.Text

        ' Allow only digits
        Dim digitsOnly As String = System.Text.RegularExpressions.Regex.Replace(currentText, "[^\d]", "")

        ' Enforce max length = 11
        If digitsOnly.Length > 11 Then
            digitsOnly = digitsOnly.Substring(0, 11)
        End If

        ' Update textbox if invalid characters were entered
        If currentText <> digitsOnly Then
            Dim cursorPos As Integer = txtContact.SelectionStart
            txtContact.Text = digitsOnly
            txtContact.SelectionStart = Math.Max(0, cursorPos - 1)
        End If

        ' Validate rules
        If digitsOnly.Length > 0 Then
            If Not digitsOnly.StartsWith("09") OrElse digitsOnly.Length > 11 Then
                lblContact.ForeColor = Color.Red
                lblContact.Text = "Client's Contact No. (must start with 09 and be 11 digits)"
            Else
                lblContact.ForeColor = Color.Black
                lblContact.Text = "Client's Contact No."
            End If
        Else
            lblContact.ForeColor = Color.Black
            lblContact.Text = "Client's Contact No."
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim email As String = txtEmail.Text.Trim()

        ' Check if email ends with "@gmail.com" (case-insensitive)
        If email.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) Then
            lblEmail.ForeColor = Color.Black
            lblEmail.Text = "Email"
        Else
            lblEmail.ForeColor = Color.Red
            lblEmail.Text = "Please enter a valid email"
        End If
    End Sub
    Private Sub txtDuration_TextChanged(sender As Object, e As EventArgs) Handles txtDuration.TextChanged
        ' Remove the word "hours" temporarily for validation
        Dim input As String = txtDuration.Text.Replace("hours", "").Trim()

        ' Allow only numbers
        Dim validInput As String = System.Text.RegularExpressions.Regex.Replace(input, "[^0-9]", "")

        ' If user typed invalid characters, correct it
        If input <> validInput Then
            Dim cursorPos As Integer = txtDuration.SelectionStart
            txtDuration.Text = validInput
            txtDuration.SelectionStart = Math.Max(0, cursorPos - 1)
        End If

        ' If textbox is empty, reset label
        If String.IsNullOrEmpty(validInput) Then
            lblDuration.ForeColor = Color.Black
            lblDuration.Text = "Duration"
            Exit Sub
        End If

        ' Convert to number
        Dim hours As Integer
        Integer.TryParse(validInput, hours)

        ' Validation checks
        If hours > 12 Then
            lblDuration.ForeColor = Color.Red
            lblDuration.Text = "The maximum duration is 12 hours"
        ElseIf hours <= 0 Then
            lblDuration.ForeColor = Color.Red
            lblDuration.Text = "Please enter a valid number of hours"
        Else
            lblDuration.ForeColor = Color.Black
            lblDuration.Text = "Duration"
        End If

        ' Update textbox to always end with " hours"
        txtDuration.Text = validInput & " hours"
        txtDuration.SelectionStart = txtDuration.Text.Length - 6 ' keep cursor before " hours"
    End Sub

    Private Sub dtpEventTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpEventTime.ValueChanged
        Dim selectedTime As DateTime = dtpEventTime.Value
        Dim startTime As DateTime = DateTime.Today.AddHours(8)  ' 8:00 AM
        Dim endTime As DateTime = DateTime.Today.AddHours(20)   ' 8:00 PM

        ' Validation: check if selected time is within the allowed hours
        If selectedTime.TimeOfDay < startTime.TimeOfDay OrElse selectedTime.TimeOfDay > endTime.TimeOfDay Then
            lblEventTime.ForeColor = Color.Red
            lblEventTime.Text = "Invalid time input (Open: 8 AM - 8 PM)"
        Else
            lblEventTime.ForeColor = Color.Black
            lblEventTime.Text = "Event Time"
        End If
    End Sub


    Private Sub dtpEventDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEventDate.ValueChanged
        Dim selectedDate As Date = dtpEventDate.Value.Date
        Dim selectedVenue As String = cmbVenue.Text.Trim()

        ' 🛑 Additional validation — prevent past dates
        If selectedDate < Date.Today Then
            lblEventDate.ForeColor = Color.Red
            lblEventDate.Text = "You cannot select a date from the past"
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(DatabaseConnection.connectionString)
                conn.Open()

                ' ✅ Check if the same venue is already booked on the same date
                Dim query As String = "SELECT COUNT(*) FROM occasion_reservations 
                               WHERE event_date = @event_date AND venue_name = @venue_name"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@event_date", selectedDate)
                    cmd.Parameters.AddWithValue("@venue_name", selectedVenue)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        lblEventDate.ForeColor = Color.Red
                        lblEventDate.Text = "This venue is already booked on this date"
                    Else
                        lblEventDate.ForeColor = Color.Black
                        lblEventDate.Text = "Event Date"
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub numAttendees_ValueChanged(sender As Object, e As EventArgs) Handles numAttendees.ValueChanged
        Dim attendees As Integer = Convert.ToInt32(numAttendees.Value)

        ' Check if attendees exceed limit
        If attendees > 200 Then
            lblAttendees.ForeColor = Color.Red
            lblAttendees.Text = "Maximum capacity exceeded"
        Else
            lblAttendees.ForeColor = Color.Black
            lblAttendees.Text = "Attendees"
        End If

        ' Always show the number with "pax" in the textbox
        numAttendees.Text = attendees.ToString() & " pax"
    End Sub

    Private Function IsFormValid() As Boolean
        Dim isValid As Boolean = True

        ' CLIENT NAME
        If String.IsNullOrWhiteSpace(txtClientName.Text) OrElse System.Text.RegularExpressions.Regex.IsMatch(txtClientName.Text, "\d") Then
            lblClientName.ForeColor = Color.Red
            lblClientName.Text = "Client Name (letters only)"
            isValid = False
        End If

        ' EMAIL
        If Not txtEmail.Text.Trim().EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) Then
            lblEmail.ForeColor = Color.Red
            lblEmail.Text = "Please enter a valid email"
            isValid = False
        End If

        ' CONTACT NUMBER
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtContact.Text, "^09\d{9}$") Then
            lblContact.ForeColor = Color.Red
            lblContact.Text = "Client's Contact No. (must start with 09 and be 11 digits)"
            isValid = False
        End If

        ' ALTERNATE CONTACT
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtAltContact.Text, "^09\d{9}$") Then
            lblAltContact.ForeColor = Color.Red
            lblAltContact.Text = "Invalid contact number"
            isValid = False
        End If

        ' DURATION
        Dim durationValue As Integer
        If Not Integer.TryParse(txtDuration.Text.Replace("hours", "").Trim(), durationValue) OrElse durationValue <= 0 OrElse durationValue > 12 Then
            lblDuration.ForeColor = Color.Red
            lblDuration.Text = "Duration must be between 1 and 12 hours"
            isValid = False
        End If

        ' EVENT TIME (8 AM - 8 PM)
        If dtpEventTime.Value.Hour < 8 OrElse dtpEventTime.Value.Hour >= 20 Then
            lblEventTime.ForeColor = Color.Red
            lblEventTime.Text = "Invalid time input (Open: 8 AM - 8 PM)"
            isValid = False
        End If

        ' ATTENDEES
        If numAttendees.Value <= 0 OrElse numAttendees.Value > 200 Then
            lblAttendees.ForeColor = Color.Red
            lblAttendees.Text = "Maximum capacity is 200 pax"
            isValid = False
        End If

        ' VENUE
        If String.IsNullOrWhiteSpace(cmbVenue.Text) Then
            lblVenue.ForeColor = Color.Red
            lblVenue.Text = "Please select a venue"
            isValid = False
        End If

        ' EVENT DATE (Check if already booked)
        Dim selectedDate As Date = dtpEventDate.Value.Date
        Try
            Using conn As New MySqlConnection(DatabaseConnection.connectionString)
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM reservations WHERE event_date = @event_date"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@event_date", selectedDate)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        lblEventDate.ForeColor = Color.Red
                        lblEventDate.Text = "This date is already booked"
                        isValid = False
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message)
            isValid = False
        End Try

        Return isValid
    End Function

    Private Sub cmbVenue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVenue.SelectedIndexChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Ask user for confirmation before clearing fields
        Dim confirm As DialogResult = MessageBox.Show(
            "Are you sure you want to clear all fields? All entered data will be lost.",
            "Confirm Clear",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirm = DialogResult.Yes Then
            ' ✅ Clear all textboxes
            txtClientName.Clear()
            txtEmail.Clear()
            txtContact.Clear()
            txtAltContact.Clear()
            txtEventName.Clear()
            txtDuration.Clear()

            ' ✅ Reset numeric and dropdown
            numAttendees.Value = 0
            cmbVenue.SelectedIndex = -1

            ' ✅ Reset date and time pickers
            dtpEventDate.Value = DateTime.Today
            dtpEventTime.Value = DateTime.Now

            ' ✅ Reset all labels back to default
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

            MessageBox.Show("All fields have been cleared.", "Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub lblAttendees_Click(sender As Object, e As EventArgs) Handles lblAttendees.Click

    End Sub


    Private Sub txtAltContact_TextChanged_1(sender As Object, e As EventArgs) Handles txtAltContact.TextChanged
        Dim input As String = txtAltContact.Text

        ' Allow only numbers
        Dim validInput As String = System.Text.RegularExpressions.Regex.Replace(input, "[^\d]", "")

        ' Limit to 11 digits maximum
        If validInput.Length > 11 Then
            validInput = validInput.Substring(0, 11)
        End If

        ' If input changed, fix the text
        If input <> validInput Then
            Dim cursorPos As Integer = txtAltContact.SelectionStart
            txtAltContact.Text = validInput
            txtAltContact.SelectionStart = Math.Min(cursorPos, txtAltContact.Text.Length)
        End If

        ' Validation conditions
        If Not validInput.StartsWith("09") OrElse validInput.Length <> 11 Then
            lblAltContact.ForeColor = Color.Red
            lblAltContact.Text = "Invalid contact number"
        Else
            lblAltContact.ForeColor = Color.Black
            lblAltContact.Text = "Alternate Contact"
        End If
    End Sub


End Class
