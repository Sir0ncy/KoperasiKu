Imports MySql.Data.MySqlClient

Public Class FormDataAnggota

    Dim Conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Dim Adp As MySqlDataAdapter
    Dim Dt As DataTable

    '=== KONEKSI ==='
    Sub Koneksi()
        Try
            Conn = New MySqlConnection("server=localhost;user id=root;password=;database=koperasi")
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi gagal: " & ex.Message)
        End Try
    End Sub

    '=== LOAD DATA ==='
    Sub LoadDataAnggota()
        Try
            Koneksi()

            Dim query As String =
                "SELECT nama, alamat, no_hp, tanggal_gabung, simpanan_awal FROM anggota"

            Adp = New MySqlDataAdapter(query, Conn)
            Dt = New DataTable
            Adp.Fill(Dt)

            dgvAnggota.Rows.Clear()

            For Each row As DataRow In Dt.Rows
                dgvAnggota.Rows.Add(
                    row("nama"),
                    row("alamat"),
                    row("no_hp"),
                    row("tanggal_gabung"),
                    row("simpanan_awal")
                )
            Next

        Catch ex As Exception
            MsgBox("Gagal memuat data: " & ex.Message)
        Finally
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

    '=== FORM LOAD ==='
    Private Sub FormDataAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataAnggota()
    End Sub

    '=== TOMBOL SIMPAN ==='
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click

        If txtNama.Text = "" Or txtAlamat.Text = "" Or txtNoHp.Text = "" Or txtSimpananAwal.Text = "" Then
            MsgBox("Semua data harus diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Koneksi()

            Dim query As String =
                "INSERT INTO anggota (nama, alamat, no_hp, tanggal_gabung, simpanan_awal) 
                 VALUES (@nama, @alamat, @no_hp, @tanggal, @simpanan)"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            Cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            Cmd.Parameters.AddWithValue("@no_hp", txtNoHp.Text)
            Cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@simpanan", txtSimpananAwal.Text)

            Cmd.ExecuteNonQuery()

            MsgBox("Data anggota berhasil disimpan!", MsgBoxStyle.Information)

            LoadDataAnggota()
            ClearForm()

        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message)
        Finally
            Conn.Close()
        End Try

    End Sub

    '=== CLEAR FORM ==='
    Sub ClearForm()
        txtNama.Clear()
        txtAlamat.Clear()
        txtNoHP.Clear()
        txtSimpananAwal.Clear()
        dtpTanggal.Value = Date.Now
    End Sub

    '=== TOMBOL BACK ==='
    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        Me.Hide()
        FormDashboard.Show()
    End Sub

End Class
