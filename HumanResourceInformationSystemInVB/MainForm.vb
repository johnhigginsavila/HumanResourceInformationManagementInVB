Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click

        HumanResourcesForm.Show()
        Me.Hide()
    End Sub

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click

        Employees.Show()
        Me.Hide()
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click

        RecruitmentForm.Show()
        Me.Hide()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs)

        ReportsForm.Show()
        Me.Hide()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click

        DashboardForm.Show()
        Me.Hide()
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        formLogIn.Show()
        Me.Hide()
    End Sub

    Private Sub MetroTile3_Click_1(sender As Object, e As EventArgs) Handles MetroTile3.Click
        Payroll.Show()
        Me.Hide()
    End Sub
End Class