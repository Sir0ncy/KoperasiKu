Public Class FormDashboard
    Private Sub bDataAnggota_Click(sender As Object, e As EventArgs) Handles bDataAnggota.Click
        Dim formDataAnggota = New FormDataAnggota
        Me.Hide()
        formDataAnggota.Show()
    End Sub

    Private Sub bSimpananAnggota_Click(sender As Object, e As EventArgs) Handles bSimpananAnggota.Click
        Dim formDataSimpanan = New FormDataSimpanan
        Me.Hide()
        formDataSimpanan.Show()
    End Sub

    Private Sub bPinjamanAnggota_Click(sender As Object, e As EventArgs) Handles bPinjamanAnggota.Click
        Dim formPinjaman = New FormPinjaman
        Me.Hide()
        formPinjaman.Show()
    End Sub

    Private Sub bAngsuranAnggota_Click(sender As Object, e As EventArgs) Handles bAngsuranAnggota.Click
        Dim formAngsuran = New FormAngsuran
        Me.Hide()
        formAngsuran.Show()
    End Sub

    Private Sub bLogOut_Click(sender As Object, e As EventArgs) Handles bLogOut.Click
        Dim formLogin = New FormLogin
        Me.Hide()
        formLogin.Show()
    End Sub
End Class