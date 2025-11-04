
Imports MySql.Data.MySqlClient

Public Class ReservationControl
    ' 🔹 VENUE CLICK EVENTS
    Private Sub venue1_Click(sender As Object, e As EventArgs) Handles lblMonth.Click, venue1.Click
        Dim venueName As String = "The Enchanted Bloom Hall"
        If ConfirmVenue(venueName) Then OpenVenueForm(venueName)
    End Sub

    Private Sub venue2_Click(sender As Object, e As EventArgs) Handles venue2.Click, Label3.Click
        Dim venueName As String = "The Royal Radiance Grand Hall"
        If ConfirmVenue(venueName) Then OpenVenueForm(venueName)
    End Sub

    Private Sub venue3_Click(sender As Object, e As EventArgs) Handles venue3.Click, Label4.Click
        Dim venueName As String = "The Crystal Mirage Ballroom"
        If ConfirmVenue(venueName) Then OpenVenueForm(venueName)
    End Sub

    Private Sub venue4_Click(sender As Object, e As EventArgs) Handles venue4.Click, Label5.Click
        Dim venueName As String = "The Golden Grace Lounge"
        If ConfirmVenue(venueName) Then OpenVenueForm(venueName)
    End Sub

    ' 💡 Helper functions for cleaner venue click code
    Private Function ConfirmVenue(venueName As String) As Boolean
        Return MessageBox.Show(
            $"Do you want to reserve the {venueName}?",
            "Confirm Venue",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Private Sub OpenVenueForm(venueName As String)
        Dim nextForm As New ReservationForm()
        nextForm.SelectedVenue = venueName
        nextForm.Show()
        Me.Hide()
    End Sub


End Class


