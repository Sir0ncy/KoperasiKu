Public Class FormLogin
    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        Dim FormDashboard = New FormDashboard

        Me.Hide()
        FormDashboard.Show()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Me.Close()
    End Sub
End Class