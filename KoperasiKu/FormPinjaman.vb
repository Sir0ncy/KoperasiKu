Imports System.Globalization
Imports System.Runtime.Intrinsics.Arm
Imports MySql.Data.MySqlClient

Public Class FormPinjaman
    Dim Conn As MySqlConnection = MySQLCon.conn
    Dim Cmd As MySqlCommand
    Dim Adp As MySqlDataAdapter
    Dim Dt As DataTable
    Dim selectedPeminjamanID As Integer = -1
    Dim selectedAnggotaID As Integer = -1

    Function CleanNumber(input As String) As Decimal
        Dim cleaned As String = input.Replace("Rp", "") _
                                 .Replace(".", "") _
                                 .Replace(",", "") _
                                 .Trim()

        If cleaned = "" Then Return 0
        Return Decimal.Parse(cleaned, CultureInfo.InvariantCulture)
    End Function
    Function CleanGridValue(value As Object) As String
        If value Is Nothing Then Return ""

        Dim s As String = value.ToString()

        If s.Contains(",") Then
            s = s.Split(","c)(0)
        End If

        ' Hapus format IDR dari DataGridView
        s = s.Replace("Rp", "") _
         .Replace(".", "") _
         .Replace(",", "") _
         .Trim()

        Return s
    End Function

    Sub LoadPinjaman()
        Try
            Connect()

            Dim query As String =
                "SELECT p.id_pinjaman, a.nama, p.tanggal_pinjam, p.jumlah, p.bunga, 
                        p.lama_cicilan, p.cicilan_per_bulan, p.sisa_pinjaman, p.status
                 FROM pinjaman p
                 JOIN anggota a ON p.id_anggota = a.id_anggota
                 ORDER BY p.id_pinjaman DESC"

            Adp = New MySqlDataAdapter(query, Conn)
            Dt = New DataTable
            Adp.Fill(Dt)

            If dgvDaftarPinjam.ColumnCount = 0 Then
                dgvDaftarPinjam.Columns.Add("id_pinjaman", "ID Pinjam")
                dgvDaftarPinjam.Columns.Add("nama", "Nama")
                dgvDaftarPinjam.Columns.Add("tanggal_pinjam", "Tanggal Pinjam")
                dgvDaftarPinjam.Columns.Add("jumlah", "Jumlah")
                dgvDaftarPinjam.Columns.Add("bunga", "Bunga")
                dgvDaftarPinjam.Columns.Add("lama_cicilan", "Lama Cicilan")
                dgvDaftarPinjam.Columns.Add("cicilan_per_bulan", "Cicilan / Bulan")
                dgvDaftarPinjam.Columns.Add("sisa_pinjaman", "Sisa Pinjaman")
                dgvDaftarPinjam.Columns.Add("status", "Status")
            End If

            dgvDaftarPinjam.Rows.Clear()

            Dim idr = System.Globalization.CultureInfo.GetCultureInfo("id-ID")

            With dgvDaftarPinjam
                .Columns("jumlah").DefaultCellStyle.Format = "C0"
                .Columns("jumlah").DefaultCellStyle.FormatProvider = idr

                .Columns("cicilan_per_bulan").DefaultCellStyle.Format = "C0"
                .Columns("cicilan_per_bulan").DefaultCellStyle.FormatProvider = idr

                .Columns("sisa_pinjaman").DefaultCellStyle.Format = "C0"
                .Columns("sisa_pinjaman").DefaultCellStyle.FormatProvider = idr
            End With


            For Each r As DataRow In Dt.Rows
                dgvDaftarPinjam.Rows.Add(
                    r("id_pinjaman"),
                    r("nama").ToString(),
                    r("tanggal_pinjam").ToString(),
                    r("jumlah"),
                    r("bunga"),
                    r("lama_cicilan"),
                    r("cicilan_per_bulan"),
                    r("sisa_pinjaman"),
                    r("status").ToString()
                )
            Next


        Catch ex As Exception
            MsgBox("Gagal memuat data pinjaman: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Sub CariAnggota()
        Try
            Connect()

            Dim query As String =
                "SELECT id_anggota, nama FROM anggota WHERE nama LIKE @nama LIMIT 1"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nama", "%" & tbNamaAnggota.Text & "%")

            Dim rd = Cmd.ExecuteReader()

            If rd.Read() Then
                selectedAnggotaID = rd("id_anggota")
                lblStatus.Text = "Anggota ditemukan"
                lblStatus.ForeColor = Color.LightGreen
                tbNamaAnggota.Text = rd("nama")
            Else
                lblStatus.Text = "Tidak ditemukan"
                lblStatus.ForeColor = Color.Red
                selectedAnggotaID = -1
            End If

            rd.Close()

        Catch ex As Exception
            MsgBox("Gagal mencari anggota: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub tbNamaAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNamaAnggota.KeyPress
        If e.KeyChar = Chr(13) Then
            CariAnggota()
        End If
    End Sub

    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        Dim formDashboard = New FormDashboard
        Me.Hide()
        formDashboard.Show()
    End Sub

    Private Sub bHitung_Click(sender As Object, e As EventArgs) Handles bHitung.Click
        Try
            Dim jumlah As Decimal = CleanNumber(tbJumlahPinjaman.Text)
            Dim bunga As Decimal = CleanNumber(tbBunga.Text)
            Dim lama As Integer = Integer.Parse(tbLamaCicilan.Text)

            Dim bungaTotal As Decimal = jumlah * (bunga / 100D)
            Dim totalHutang As Decimal = jumlah + bungaTotal
            Dim cicilan As Decimal = totalHutang / lama

            tbCicilanperBulan.Text = cicilan.ToString("N0", CultureInfo.GetCultureInfo("id-ID"))
            tbSisaPinjaman.Text = totalHutang.ToString("N0", CultureInfo.GetCultureInfo("id-ID"))

        Catch ex As Exception
            MsgBox("Input tidak valid: " & ex.Message)
        End Try
    End Sub

    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        If selectedAnggotaID = -1 Then
            MsgBox("Nama anggota tidak valid!")
            Exit Sub
        End If

        Try
            Connect()

            Dim query As String =
                "INSERT INTO pinjaman
                (id_anggota, tanggal_pinjam, jumlah, bunga, lama_cicilan, cicilan_per_bulan, sisa_pinjaman, status)
                VALUES
                (@id_anggota, @tanggal, @jumlah, @bunga, @lama, @cicilan, @sisa, 'aktif')"

            Cmd = New MySqlCommand(query, Conn)

            Cmd.Parameters.AddWithValue("@id_anggota", selectedAnggotaID)
            Cmd.Parameters.AddWithValue("@jumlah", CleanNumber(tbJumlahPinjaman.Text))
            Cmd.Parameters.AddWithValue("@bunga", CleanNumber(tbBunga.Text))
            Cmd.Parameters.AddWithValue("@lama", tbLamaCicilan.Text)
            Cmd.Parameters.AddWithValue("@cicilan", CleanNumber(tbCicilanperBulan.Text))
            Cmd.Parameters.AddWithValue("@sisa", CleanNumber(tbSisaPinjaman.Text))

            Cmd.ExecuteNonQuery()

            MsgBox("Pinjaman berhasil disimpan!")

            LoadPinjaman()

        Catch ex As Exception
            MsgBox("Gagal simpan: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        If selectedPeminjamanID = -1 Then
            MsgBox("Pilih data dari tabel!")
            Exit Sub
        End If

        Try
            Connect()

            Dim query As String =
                "UPDATE pinjaman SET 
                    jumlah=@jumlah, bunga=@bunga, lama_cicilan=@lama,
                    cicilan_per_bulan=@cicilan, sisa_pinjaman=@sisa
                 WHERE id_pinjaman=@id"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@jumlah", CleanNumber(tbJumlahPinjaman.Text))
            Cmd.Parameters.AddWithValue("@bunga", CleanNumber(tbBunga.Text))
            Cmd.Parameters.AddWithValue("@lama", tbLamaCicilan.Text)
            Cmd.Parameters.AddWithValue("@cicilan", CleanNumber(tbCicilanperBulan.Text))
            Cmd.Parameters.AddWithValue("@sisa", CleanNumber(tbSisaPinjaman.Text))
            Cmd.Parameters.AddWithValue("@id", selectedPeminjamanID)


            Cmd.ExecuteNonQuery()

            MsgBox("Pinjaman berhasil diupdate!")
            LoadPinjaman()

        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click

    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        tbNamaAnggota.Clear()
        tbJumlahPinjaman.Clear()
        tbBunga.Clear()
        tbLamaCicilan.Clear()
        dtPinjaman.Value = Date.Now
        tbCicilanperBulan.Clear()
        tbSisaPinjaman.Clear()
        lblStatus.Text = ""
    End Sub


    Private Sub dgvDaftarPinjam_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDaftarPinjam.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                selectedPeminjamanID = dgvDaftarPinjam.Rows(e.RowIndex).Cells(0).Value
                tbNamaAnggota.Text = dgvDaftarPinjam.Rows(e.RowIndex).Cells(1).Value
                dtPinjaman.Value = dgvDaftarPinjam.Rows(e.RowIndex).Cells(2).Value
                tbJumlahPinjaman.Text = CleanGridValue(dgvDaftarPinjam.Rows(e.RowIndex).Cells(3).Value)
                tbBunga.Text = CleanGridValue(dgvDaftarPinjam.Rows(e.RowIndex).Cells(4).Value)
                tbLamaCicilan.Text = dgvDaftarPinjam.Rows(e.RowIndex).Cells(5).Value.ToString()
                tbCicilanperBulan.Text = CleanGridValue(dgvDaftarPinjam.Rows(e.RowIndex).Cells(6).Value)
                tbSisaPinjaman.Text = CleanGridValue(dgvDaftarPinjam.Rows(e.RowIndex).Cells(7).Value)
                lblStatus.Text = dgvDaftarPinjam.Rows(e.RowIndex).Cells(8).Value
                If lblStatus.Text = "aktif" Then
                    lblStatus.ForeColor = Color.Red
                Else
                    lblStatus.ForeColor = Color.Green
                End If
            End If
        Catch ex As Exception
            MsgBox("Gagal ambil data: " & ex.Message)
        End Try
    End Sub
    Private Sub FormPinjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPinjaman()
    End Sub
End Class