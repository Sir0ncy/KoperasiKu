Imports System.Globalization
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class FormAngsuran
    Dim Conn As MySqlConnection = MySQLCon.conn
    Dim Cmd As MySqlCommand
    Dim Adp As MySqlDataAdapter
    Dim Dt As DataTable
    Dim selectedAnggotaID As Integer = -1
    Dim selectedAngsuranID As Integer = -1
    Dim selectedPinjamanID As Integer = -1

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

    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        Dim formDashboard = New FormDashboard
        Me.Hide()
        formDashboard.Show()
    End Sub

    Sub LoadListAngsuran()
        Try
            Connect()

            Dim query As String = "SELECT a.id_angsuran, n.nama, p.jumlah, p.cicilan_per_bulan, a.tanggal_bayar, a.jumlah_bayar, p.sisa_pinjaman
                                    FROM pinjaman p JOIN anggota n ON p.id_anggota = n.id_anggota JOIN angsuran a ON a.id_pinjaman = p.id_pinjaman"
            Adp = New MySqlDataAdapter(query, Conn)
            Dt = New DataTable
            Adp.Fill(Dt)

            If dgvDaftarAngsuran.ColumnCount = 0 Then
                dgvDaftarAngsuran.Columns.Add("id_angsuran", "ID Angsur")
                dgvDaftarAngsuran.Columns.Add("nama", "Nama")
                dgvDaftarAngsuran.Columns.Add("jumlah", "Jumlah Pinjaman")
                dgvDaftarAngsuran.Columns.Add("cicilan_per_bulan", "Cicilan / Bulan")
                dgvDaftarAngsuran.Columns.Add("tanggal_bayar", "Tanggal Bayar")
                dgvDaftarAngsuran.Columns.Add("jumlah_bayar", "Jumlah Bayar")
                dgvDaftarAngsuran.Columns.Add("sisa_pinjaman", "Sisa Pinjaman")
            End If

            dgvDaftarAngsuran.Rows.Clear()
            Dim idr = System.Globalization.CultureInfo.GetCultureInfo("id-ID")

            With dgvDaftarAngsuran
                .Columns("jumlah").DefaultCellStyle.Format = "C0"
                .Columns("jumlah").DefaultCellStyle.FormatProvider = idr

                .Columns("cicilan_per_bulan").DefaultCellStyle.Format = "C0"
                .Columns("cicilan_per_bulan").DefaultCellStyle.FormatProvider = idr

                .Columns("jumlah_bayar").DefaultCellStyle.Format = "C0"
                .Columns("jumlah_bayar").DefaultCellStyle.FormatProvider = idr

                .Columns("sisa_pinjaman").DefaultCellStyle.Format = "C0"
                .Columns("sisa_pinjaman").DefaultCellStyle.FormatProvider = idr
            End With

            For Each r As DataRow In Dt.Rows
                dgvDaftarAngsuran.Rows.Add(
                    r("id_angsuran"),
                    r("nama").ToString,
                    r("jumlah"),
                    r("cicilan_per_bulan"),
                    r("tanggal_bayar").ToString,
                    r("jumlah_bayar"),
                    r("sisa_pinjaman")
            )
            Next
        Catch ex As Exception
            MsgBox("Gagal memuat data angsuran: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Sub searchAnggota()
        Try
            Connect()

            Dim query As String =
                "SELECT a.id_angsuran, p.id_pinjaman, n.nama, n.id_anggota, p.cicilan_per_bulan, p.sisa_pinjaman 
                FROM pinjaman p 
                JOIN anggota n ON p.id_anggota = n.id_anggota 
                LEFT JOIN angsuran a ON a.id_pinjaman = p.id_pinjaman
                WHERE n.nama LIKE @nama AND p.status = 'aktif'
                LIMIT 1"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nama", "%" & tbNamaAnggota.Text & "%")

            Dim rd = Cmd.ExecuteReader()

            If rd.Read() Then
                selectedAnggotaID = rd("id_anggota")
                selectedAngsuranID = If(IsDBNull(rd("id_angsuran")), -1, rd("id_angsuran"))
                selectedPinjamanID = rd("id_pinjaman")
                tbNamaAnggota.Text = rd("nama")
                tbJumlahAngsur.Text = CleanGridValue(rd("cicilan_per_bulan"))
                tbSisaAngsur.Text = CleanGridValue(rd("sisa_pinjaman"))
            Else
                selectedAnggotaID = -1
                selectedPinjamanID = -1
                selectedAngsuranID = -1
            End If

            rd.Close()

        Catch ex As Exception
            MsgBox("Gagal mencari anggota: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Function GetSisaPinjamanSekarang(idPinjaman As Integer) As Decimal
        Try
            Connect()
            Dim query As String = "SELECT sisa_pinjaman FROM pinjaman WHERE id_pinjaman=@id LIMIT 1"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@id", idPinjaman)

            Dim result = Cmd.ExecuteScalar()
            If result IsNot Nothing Then
                Return Convert.ToDecimal(result)
            End If

        Catch ex As Exception
            MsgBox("Gagal mengambil sisa pinjaman: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try

        Return 0
    End Function
    Function GetPinjamanIDByNama(nama As String) As Integer
        Dim idPinjaman As Integer = -1

        Try
            Connect()

            Dim query As String =
            "SELECT p.id_pinjaman 
             FROM pinjaman p 
             JOIN anggota a ON p.id_anggota = a.id_anggota
             WHERE a.nama LIKE @nama AND p.status = 'aktif'
             LIMIT 1"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nama", "%" & nama & "%")

            Dim result = Cmd.ExecuteScalar()

            If result IsNot Nothing Then
                idPinjaman = Convert.ToInt32(result)
            End If

        Catch ex As Exception
            MsgBox("Gagal mengambil ID pinjaman: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try

        Return idPinjaman
    End Function

    Private Sub FormAngsuran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadListAngsuran()
    End Sub
    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        If selectedPinjamanID = -1 Then
            MsgBox("Pinjaman tidak ditemukan!")
            Exit Sub
        End If

        If tbJumlahAngsur.Text = "" Then
            MsgBox("Masukkan jumlah angsuran!")
            Exit Sub
        End If

        Try
            Dim bayar As Decimal = Convert.ToDecimal(tbJumlahAngsur.Text)
            Dim sisaLama As Decimal = GetSisaPinjamanSekarang(selectedPinjamanID)

            If bayar > sisaLama Then
                MsgBox("Jumlah bayar melebihi sisa pinjaman!")
                Exit Sub
            End If

            Dim sisaBaru As Decimal = sisaLama - bayar

            Connect()

            Dim trans = Conn.BeginTransaction()

            Dim query1 As String =
                "INSERT INTO angsuran (id_pinjaman, tanggal_bayar, jumlah_bayar)
             VALUES (@id, @tgl, @bayar)"

            Dim cmd1 As New MySqlCommand(query1, Conn, trans)
            cmd1.Parameters.AddWithValue("@id", selectedPinjamanID)
            cmd1.Parameters.AddWithValue("@tgl", dtAngsur.Value.ToString("yyyy-MM-dd"))
            cmd1.Parameters.AddWithValue("@bayar", bayar)
            cmd1.ExecuteNonQuery()

            Dim query2 As String =
                "UPDATE pinjaman SET sisa_pinjaman=@sisa, 
                status = CASE WHEN @sisa = 0 THEN 'lunas' ELSE 'aktif' END
             WHERE id_pinjaman=@id"

            Dim cmd2 As New MySqlCommand(query2, Conn, trans)
            cmd2.Parameters.AddWithValue("@sisa", sisaBaru)
            cmd2.Parameters.AddWithValue("@id", selectedPinjamanID)
            cmd2.ExecuteNonQuery()

            trans.Commit()

            MsgBox("Angsuran berhasil disimpan!", MsgBoxStyle.Information)
            LoadListAngsuran()

        Catch ex As Exception
            MsgBox("Gagal menyimpan angsuran: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub tbNamaAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNamaAnggota.KeyPress
        If e.KeyChar = Chr(13) Then
            searchAnggota()
        End If
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        If selectedAngsuranID = -1 Then
            MsgBox("Pilih data angsuran dulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Yakin ingin menghapus angsuran ini?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Try
            Connect()

            ' Ambil jumlah bayar untuk mengembalikan sisa pinjaman
            Dim queryGet As String = "SELECT jumlah_bayar, id_pinjaman FROM angsuran WHERE id_angsuran=@id"
            Dim cmdGet As New MySqlCommand(queryGet, Conn)
            cmdGet.Parameters.AddWithValue("@id", selectedAngsuranID)
            Dim rd = cmdGet.ExecuteReader()

            Dim jumlahBayar As Decimal = 0
            Dim pinjamanID As Integer = -1

            If rd.Read() Then
                jumlahBayar = rd("jumlah_bayar")
                pinjamanID = rd("id_pinjaman")
            End If
            rd.Close()

            ' Hapus data angsuran
            Dim queryDelete As String = "DELETE FROM angsuran WHERE id_angsuran=@id"
            Dim cmdDelete As New MySqlCommand(queryDelete, Conn)
            cmdDelete.Parameters.AddWithValue("@id", selectedAngsuranID)
            cmdDelete.ExecuteNonQuery()

            ' Kembalikan sisa pinjaman
            Dim queryUpdate As String =
                "UPDATE pinjaman 
             SET sisa_pinjaman = sisa_pinjaman + @kembali,
                 status = 'aktif'
             WHERE id_pinjaman=@idp"

            Dim cmdUpdate As New MySqlCommand(queryUpdate, Conn)
            cmdUpdate.Parameters.AddWithValue("@kembali", jumlahBayar)
            cmdUpdate.Parameters.AddWithValue("@idp", pinjamanID)
            cmdUpdate.ExecuteNonQuery()

            MsgBox("Data angsuran berhasil dihapus!")
            LoadListAngsuran()

        Catch ex As Exception
            MsgBox("Gagal hapus: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        tbNamaAnggota.Clear()
        dtAngsur.Value = Date.Now
        tbJumlahAngsur.Clear()
        tbSisaAngsur.Clear()
    End Sub

    Private Sub dgvDaftarAngsuran_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDaftarAngsuran.CellContentClick
        If e.RowIndex >= 0 Then
            selectedAngsuranID = dgvDaftarAngsuran.Rows(e.RowIndex).Cells(0).Value
            tbNamaAnggota.Text = dgvDaftarAngsuran.Rows(e.RowIndex).Cells(1).Value
            selectedPinjamanID = GetPinjamanIDByNama(tbNamaAnggota.Text)
            tbJumlahAngsur.Text = CleanGridValue(dgvDaftarAngsuran.Rows(e.RowIndex).Cells(5).Value)
        End If
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        If selectedAngsuranID = -1 Then
            MsgBox("Pilih data angsuran dulu!")
            Exit Sub
        End If

        If tbJumlahAngsur.Text = "" Then
            MsgBox("Jumlah angsuran harus diisi!")
            Exit Sub
        End If

        Try
            Connect()

            Dim query As String =
            "UPDATE angsuran 
             SET tanggal_bayar=@tgl, jumlah_bayar=@bayar 
             WHERE id_angsuran=@id"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@tgl", dtAngsur.Value.ToString("yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@bayar", tbJumlahAngsur.Text)
            Cmd.Parameters.AddWithValue("@id", selectedAngsuranID)

            Cmd.ExecuteNonQuery()

            MsgBox("Data angsuran berhasil diupdate!")
            LoadListAngsuran()

        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub
End Class