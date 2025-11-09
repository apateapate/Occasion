Imports System.Runtime.InteropServices

Public Class staffForm



    Private Sub staffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Center the form when opened
        Me.StartPosition = FormStartPosition.CenterScreen

    End Sub
    <DllImport("user32.dll")>
    Public Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll")>
    Public Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2

    Private Sub Form_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub

    ' 🔹 PLACE RESERVATION
    Private Sub btnPlaceReservation_Click(sender As Object, e As EventArgs) Handles btnPlace.Click
        OpenPlaceReservation()
    End Sub

    Private Sub picPlaceReservation_Click(sender As Object, e As EventArgs) Handles picPlace.Click
        OpenPlaceReservation()
    End Sub

    Private Sub OpenPlaceReservation()
        Dim frm As New placeReservationForm()
        frm.Show()
        Me.Hide()
    End Sub

    ' 🔹 VIEW RESERVATION
    Private Sub btnViewReservation_Click(sender As Object, e As EventArgs) Handles btnView.Click
        OpenViewReservation()
    End Sub

    Private Sub picViewReservation_Click(sender As Object, e As EventArgs) Handles picView.Click
        OpenViewReservation()
    End Sub

    Private Sub OpenViewReservation()
        Dim frm As New ViewReservationForm(Form1)

        frm.Show()
        Me.Hide()
    End Sub

    ' 🔹 EXIT
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ExitApp()
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        ExitApp()
    End Sub

    Private Sub ExitApp()
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Form1.Show()
            Me.Close()
        End If
    End Sub

End Class
