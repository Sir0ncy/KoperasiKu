Public Class FormDataAnggota
    Private Sub FormDataAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        Dim formDashboard = New FormDashboard
        Me.Hide()
        formDashboard.Show()
    End Sub
End Class