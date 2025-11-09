
Imports MySql.Data.MySqlClient

Public Class placeReservationForm

    ' Store original size and control data for proportional resizing
    Private originalFormSize As Size
    Private originalControlData As New Dictionary(Of Control, Rectangle)

    ' 💡 Extra: store original font sizes & icon size for header scaling
    Private originalHeaderFontSize As Single
    Private originalIconSize As Size

    ' 🔹 VENUE CLICK EVENTS
    Private Sub venue1_Click(sender As Object, e As EventArgs) Handles venue1.Click, Label1.Click
        Dim venueName As String = "The Enchanted Bloom Hall 🌸"
        If ConfirmVenue(venueName) Then OpenVenueForm(venueName)
    End Sub

    Private Sub venue2_Click(sender As Object, e As EventArgs) Handles venue2.Click, Label3.Click
        Dim venueName As String = "The Royal Radiance Grand Hall 👑"
        If ConfirmVenue(venueName) Then OpenVenueForm(venueName)
    End Sub

    Private Sub venue3_Click(sender As Object, e As EventArgs) Handles venue3.Click, Label4.Click
        Dim venueName As String = "The Crystal Mirage Ballroom ✨"
        If ConfirmVenue(venueName) Then OpenVenueForm(venueName)
    End Sub

    Private Sub venue4_Click(sender As Object, e As EventArgs) Handles venue4.Click, Label5.Click
        Dim venueName As String = "The Golden Grace Lounge 💫"
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
        Dim nextForm As New placeReservationForm2()
        nextForm.SelectedVenue = venueName
        nextForm.Show()
        Me.Hide()
    End Sub

    ' 🔹 FORM LOAD — Center and prepare for resizing
    Private Sub placeReservationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the main panel
        CenterMainPanel()

        ' Store original layout info
        originalFormSize = MainPanel.Size
        SaveOriginalControlData(MainPanel)

        ' 💡 Store header data (change these control names as yours)
        originalHeaderFontSize = LabelTitle.Font.Size
        originalIconSize = PictureBox1.Size
    End Sub

    ' 🔹 When form resizes, adjust everything proportionally
    Private Sub placeReservationForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ResizeAllControls(MainPanel)
        ResizeHeaderElements() ' 💡 added for title + icon resizing
        CenterMainPanel()
    End Sub

    ' 🔹 Center the main panel horizontally & vertically
    Private Sub CenterMainPanel()
        MainPanel.Left = (Me.ClientSize.Width - MainPanel.Width) \ 2
        MainPanel.Top = (Me.ClientSize.Height - MainPanel.Height) \ 2
    End Sub

    ' 🔹 Save original size and position of controls
    Private Sub SaveOriginalControlData(parent As Control)
        For Each ctrl As Control In parent.Controls
            originalControlData(ctrl) = New Rectangle(ctrl.Location, ctrl.Size)
            If ctrl.Controls.Count > 0 Then
                SaveOriginalControlData(ctrl)
            End If
        Next
    End Sub

    ' 🔹 Resize all controls proportionally
    Private Sub ResizeAllControls(parent As Control)
        If originalFormSize.Width = 0 OrElse originalFormSize.Height = 0 Then Exit Sub

        Dim xRatio As Double = MainPanel.Width / originalFormSize.Width
        Dim yRatio As Double = MainPanel.Height / originalFormSize.Height

        For Each ctrl As Control In parent.Controls
            If originalControlData.ContainsKey(ctrl) Then
                Dim origRect As Rectangle = originalControlData(ctrl)
                ctrl.Bounds = New Rectangle(
                    CInt(origRect.X * xRatio),
                    CInt(origRect.Y * yRatio),
                    CInt(origRect.Width * xRatio),
                    CInt(origRect.Height * yRatio))
            End If

            If ctrl.Controls.Count > 0 Then
                ResizeAllControls(ctrl)
            End If
        Next
    End Sub

    ' 💡 Resize header label and icon smoothly
    Private Sub ResizeHeaderElements()
        If originalHeaderFontSize <= 0 OrElse originalFormSize.Width = 0 Then Exit Sub

        Dim scaleX As Double = Me.Width / originalFormSize.Width
        Dim scaleY As Double = Me.Height / originalFormSize.Height
        Dim scale As Double = Math.Min(scaleX, scaleY)

        ' Adjust title font
        LabelTitle.Font = New Font(LabelTitle.Font.FontFamily, CSng(originalHeaderFontSize * scale), FontStyle.Bold)

        ' Adjust icon size
        PictureBox1.Width = CInt(originalIconSize.Width * scale)
        PictureBox1.Height = CInt(originalIconSize.Height * scale)
    End Sub

    Private Sub tblVenues_Paint(sender As Object, e As PaintEventArgs) Handles tblVenues.Paint
    End Sub

End Class


