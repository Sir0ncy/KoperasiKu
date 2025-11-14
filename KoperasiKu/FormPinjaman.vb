Public Class FormPinjaman
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        Dim formDashboard = New FormDashboard
        Me.Hide()
        formDashboard.Show()
    End Sub
End Class