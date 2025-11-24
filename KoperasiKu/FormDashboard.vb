Imports MySql.Data.MySqlClient

Public Class FormDashboard

    Dim Conn As MySqlConnection = MySQLCon.conn
    Dim Cmd As MySqlCommand
    Dim Rd As MySqlDataReader

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDashboard()
    End Sub

    Private Sub LoadDashboard()
        Try
            Using Conn As New MySqlConnection("server=172.19.158.154; database=koperasi; userid=root; password=''")
                Conn.Open()

                Using Cmd As New MySqlCommand("SELECT COUNT(*) FROM anggota", Conn)
                    lTotalAnggota.Text = Cmd.ExecuteScalar().ToString()
                End Using

                Using Cmd As New MySqlCommand("SELECT IFNULL(SUM(jumlah),0) FROM simpanan", Conn)
                    lTotalSimpanan.Text = "Rp " & FormatNumber(Cmd.ExecuteScalar(), 0)
                End Using

                Using Cmd As New MySqlCommand("SELECT COUNT(*) FROM pinjaman WHERE status='aktif'", Conn)
                    lPinjamanAktif.Text = Cmd.ExecuteScalar().ToString()
                End Using

                Using Cmd As New MySqlCommand("SELECT IFNULL(SUM(sisa_pinjaman),0) FROM pinjaman WHERE status='aktif'", Conn)
                    lTotalPinjaman.Text = "Rp " & FormatNumber(Cmd.ExecuteScalar(), 0)
                End Using
            End Using

        Catch ex As Exception
            MsgBox("Gagal load data dashboard: " & ex.Message)
        End Try
    End Sub

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
