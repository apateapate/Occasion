Public Class adminForm

    Private Sub SidebarButton_MouseEnter(sender As Object, e As EventArgs) _
        Handles btnDashboard.MouseEnter, btnReservations.MouseEnter, btnVenues.MouseEnter, btnAnalytics.MouseEnter, btnSettings.MouseEnter

        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.FromArgb(0, 170, 200) ' Slightly darker shade on hover
        btn.ForeColor = Color.White
    End Sub

    Private Sub SidebarButton_MouseLeave(sender As Object, e As EventArgs) _
        Handles btnDashboard.MouseLeave, btnReservations.MouseLeave, btnVenues.MouseLeave, btnAnalytics.MouseLeave, btnSettings.MouseLeave

        Dim btn As Button = CType(sender, Button)
        btn.BackColor = Color.Transparent
        btn.ForeColor = Color.Black
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
