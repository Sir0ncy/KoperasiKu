Imports MySql.Data.MySqlClient

Public Class FormDataAnggota

    Dim Conn As MySqlConnection = MySQLCon.conn
    Dim Cmd As MySqlCommand
    Dim Adp As MySqlDataAdapter
    Dim Dt As DataTable
    Dim selectedID = -1

    Sub LoadDataAnggota()
        Try
            Connect()

            Dim query As String =
                "SELECT id_anggota, nama, alamat, no_hp, tanggal_gabung, simpanan_awal FROM anggota"

            Adp = New MySqlDataAdapter(query, Conn)
            Dt = New DataTable
            Adp.Fill(Dt)

            If dgvAnggota.Columns.Count = 0 Then
                dgvAnggota.Columns.Add("id_anggota", "ID")
                dgvAnggota.Columns("id_anggota").Visible = False ' HIDDEN
                dgvAnggota.Columns.Add("nama", "Nama")
                dgvAnggota.Columns.Add("alamat", "Alamat")
                dgvAnggota.Columns.Add("no_hp", "No HP")
                dgvAnggota.Columns.Add("tanggal", "Tanggal")
                dgvAnggota.Columns.Add("simpanan", "Simpanan Awal")
            End If

            dgvAnggota.Rows.Clear()

            If dgvAnggota.Columns.Count > 5 Then
                With dgvAnggota.Columns(5)
                    .ValueType = GetType(Decimal)
                    .DefaultCellStyle.Format = "C0"
                    .DefaultCellStyle.FormatProvider = System.Globalization.CultureInfo.GetCultureInfo("id-ID")
                End With
            End If

            For Each row As DataRow In Dt.Rows
                Dim simpananValue As Decimal = 0D
                Decimal.TryParse(Convert.ToString(row("simpanan_awal")), simpananValue)

                dgvAnggota.Rows.Add(
                    row("id_anggota"),
                    Convert.ToString(row("nama")),
                    Convert.ToString(row("alamat")),
                    Convert.ToString(row("no_hp")),
                    Convert.ToDateTime(row("tanggal_gabung")).ToString("yyyy-MM-dd"),
                    simpananValue
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

    'Buat cari anggota
    Sub SearchAnggota()
        If tbCari.Text = "" Then
            LoadDataAnggota()
            Exit Sub
        End If

        Try
            Connect()
            Dim query As String =
            "SELECT * FROM anggota WHERE nama LIKE @nama"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nama", "%" & tbCari.Text & "%")

            Adp = New MySqlDataAdapter(Cmd)
            Dt = New DataTable
            Adp.Fill(Dt)

            dgvAnggota.Rows.Clear()

            If Dt.Rows.Count = 0 Then
                MsgBox("Data tidak ditemukan.", MsgBoxStyle.Information)
                Exit Sub
            End If

            ' TAMPILKAN KE TEXTBOX (ambil baris pertama)
            Dim r As DataRow = Dt.Rows(0)

            selectedID = Convert.ToInt32(r("id_anggota"))

            txtNama.Text = r("nama").ToString()
            txtAlamat.Text = r("alamat").ToString()
            txtNoHp.Text = r("no_hp").ToString()
            txtSimpananAwal.Text = r("simpanan_awal").ToString()
            dtpTanggal.Value = Convert.ToDateTime(r("tanggal_gabung"))

            ' TAMPILKAN KE DATAGRIDVIEW
            For Each row As DataRow In Dt.Rows
                dgvAnggota.Rows.Add(
                Convert.ToInt32(row("id_anggota")),
                row("nama").ToString(),
                row("alamat").ToString(),
                row("no_hp").ToString(),
                Convert.ToDateTime(row("tanggal_gabung")).ToString("yyyy-MM-dd"),
                row("simpanan_awal")
            )
            Next

        Catch ex As Exception
            MsgBox("Gagal mencari data: " & ex.Message)
        Finally
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

    Private Sub FormDataAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataAnggota()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click

        If txtNama.Text = "" Or txtAlamat.Text = "" Or txtNoHp.Text = "" Or txtSimpananAwal.Text = "" Then
            MsgBox("Semua data harus diisi!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Connect()

            Dim query As String =
                "INSERT INTO anggota (nama, alamat, no_hp, tanggal_gabung, simpanan_awal) 
                 VALUES (@nama, @alamat, @no_hp, @tanggal, @simpanan)"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            Cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            Cmd.Parameters.AddWithValue("@no_hp", txtNoHp.Text)
            Cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
            Dim simpanan As Decimal =
            Decimal.Parse(txtSimpananAwal.Text, Globalization.CultureInfo.GetCultureInfo("id-ID"))

            Cmd.Parameters.AddWithValue("@simpanan",
            simpanan.ToString(Globalization.CultureInfo.InvariantCulture))

            Cmd.ExecuteNonQuery()

            MsgBox("Data anggota berhasil disimpan!", MsgBoxStyle.Information)

            LoadDataAnggota()
            ClearForm()
            Conn.Close()

        Catch ex As Exception
            MsgBox("Gagal menyimpan data: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Sub ClearForm()
        txtNama.Clear()
        txtAlamat.Clear()
        txtNoHp.Clear()
        txtSimpananAwal.Clear()
        dtpTanggal.Value = Date.Now
    End Sub

    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        Me.Hide()
        FormDashboard.Show()
    End Sub

    Private Sub bCari_Click(sender As Object, e As EventArgs) Handles bCari.Click
        SearchAnggota()
    End Sub

    Private Sub tbCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCari.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchAnggota()
        End If
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        If selectedID = -1 Then
            MsgBox("Pilih/cari data terlebih dahulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Connect()

            Dim query As String =
                "UPDATE anggota SET 
                nama=@nama,
                alamat=@alamat,
                no_hp=@no_hp,
                tanggal_gabung=@tanggal,
                simpanan_awal=@simpanan
             WHERE id_anggota=@id"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@nama", txtNama.Text)
            Cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
            Cmd.Parameters.AddWithValue("@no_hp", txtNoHp.Text)
            Cmd.Parameters.AddWithValue("@tanggal", dtpTanggal.Value.ToString("yyyy-MM-dd"))
            Dim simpanan As Decimal =
            Decimal.Parse(txtSimpananAwal.Text, Globalization.CultureInfo.GetCultureInfo("id-ID"))
            Cmd.Parameters.AddWithValue("@simpanan",
            simpanan.ToString(Globalization.CultureInfo.InvariantCulture))
            Cmd.Parameters.AddWithValue("@id", selectedID)

            Cmd.ExecuteNonQuery()

            MsgBox("Data berhasil diupdate!", MsgBoxStyle.Information)
            LoadDataAnggota()
            ClearForm()
            selectedID = -1
            Conn.Close()

        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        If selectedID = -1 Then
            MsgBox("Pilih data terlebih dahulu!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If MsgBox("Yakin ingin menghapus data ini?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Try
            Connect()

            Dim query As String = "DELETE FROM anggota WHERE id_anggota=@id"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@id", selectedID)

            Cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information)
            LoadDataAnggota()
            ClearForm()
            selectedID = -1
            Conn.Close()

        Catch ex As Exception
            MsgBox("Gagal hapus: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub dgvAnggota_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAnggota.CellClick
        Try
            If e.RowIndex >= 0 Then
                selectedID = Convert.ToInt32(dgvAnggota.Rows(e.RowIndex).Cells(0).Value)
                txtNama.Text = dgvAnggota.Rows(e.RowIndex).Cells(1).Value.ToString()
                txtAlamat.Text = dgvAnggota.Rows(e.RowIndex).Cells(2).Value.ToString()
                txtNoHp.Text = dgvAnggota.Rows(e.RowIndex).Cells(3).Value.ToString()
                dtpTanggal.Value = Convert.ToDateTime(dgvAnggota.Rows(e.RowIndex).Cells(4).Value)
                txtSimpananAwal.Text = dgvAnggota.Rows(e.RowIndex).Cells(5).Value.ToString()
            End If
        Catch ex As Exception
            MsgBox("Gagal mengambil data: " & ex.Message)
        End Try
    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        ClearForm()
    End Sub
End Class
