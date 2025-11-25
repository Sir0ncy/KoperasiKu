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

                Dim jumlahData As Integer = 0
                Using Cmd As New MySqlCommand("SELECT COUNT(*) FROM simpanan", Conn)
                    jumlahData = Convert.ToInt32(Cmd.ExecuteScalar())
                End Using

                If jumlahData = 0 Then
                    lTotalSimpanan.Text = "Rp 0"
                    Exit Sub
                End If

                Dim arrSimpanan(jumlahData - 1) As Double

                Dim index As Integer = 0
                Using Cmd As New MySqlCommand("SELECT jumlah FROM simpanan", Conn)
                    Using Rd As MySqlDataReader = Cmd.ExecuteReader()
                        While Rd.Read()
                            arrSimpanan(index) = Convert.ToDouble(Rd("jumlah"))
                            index += 1
                        End While
                    End Using
                End Using

                Dim total As Double = 0
                For i As Integer = 0 To arrSimpanan.Length - 1
                    total += arrSimpanan(i)
                Next

                lTotalSimpanan.Text = "Rp " & FormatNumber(total, 0)

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
