Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormDataSimpanan
    Dim conn As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim ketemu As Boolean
    Dim selectedIDSimpanan As Integer

    Sub koneksi()
        conn = New MySqlConnection("server=localhost;userid=root;password='';database=koperasi")
    End Sub
    Sub tampildata()
        koneksi()
        conn.Open()
        da = New MySqlDataAdapter("SELECT s.id_simpanan, a.nama, s.jenis_simpanan, s.tanggal_simpan ,s.jumlah
                                    FROM simpanan s
                                    JOIN anggota a ON s.id_anggota = a.id_anggota", conn)
        dt = New DataTable
        da.Fill(dt)
        dgvSimpanan.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgvSimpanan.Rows.Add(dt.Rows(i).Item(0))
            dgvSimpanan.Rows(i).Cells(1).Value = dt.Rows(i).Item(1)
            dgvSimpanan.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
            dgvSimpanan.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)
            dgvSimpanan.Rows(i).Cells(4).Value = dt.Rows(i).Item(4)
        Next
        conn.Close()
    End Sub
    Private Sub LoadAnggota()
        Try
            koneksi()
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT id_anggota, nama FROM anggota", conn)
            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader())

            cbNmAnggota.DataSource = dt
            cbNmAnggota.DisplayMember = "nama"
            cbNmAnggota.ValueMember = "id_anggota"
            cbNmAnggota.SelectedIndex = -1

            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildata()
        LoadAnggota()
        HitungTotalSimpanan()
    End Sub
    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        Try
            If cbNmAnggota.SelectedIndex = -1 Then
                MessageBox.Show("Pilih nama anggota dulu!")
                Exit Sub
            End If

            If cbJnsSimpanan.SelectedIndex = -1 Then
                MessageBox.Show("Jenis simpanan belum dipilih!")
                Exit Sub
            End If

            If tbSimpanan.Text.Trim() = "" Then
                MessageBox.Show("Jumlah tidak boleh kosong!")
                Exit Sub
            End If

            koneksi()
            conn.Open()

            Dim query As String = "INSERT INTO simpanan (id_anggota, tanggal_simpan, jenis_simpanan, jumlah) " &
                                  "VALUES (@id_anggota, @tanggal, @jenis, @jumlah)"

            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id_anggota", cbNmAnggota.SelectedValue)
            cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@jenis", cbJnsSimpanan.Text)
            cmd.Parameters.AddWithValue("@jumlah", Decimal.Parse(tbSimpanan.Text))

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data simpanan berhasil ditambahkan!")

            conn.Close()

            tampildata()
            HitungTotalSimpanan()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub dgvSimpanan_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSimpanan.CellDoubleClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSimpanan.Rows(e.RowIndex)

            selectedIDSimpanan = CInt(row.Cells(0).Value)

            cbNmAnggota.Text = row.Cells(1).Value.ToString()
            cbJnsSimpanan.Text = row.Cells(2).Value.ToString()
            dtTanggal.Value = DateTime.Parse(row.Cells(3).Value.ToString())
            tbSimpanan.Text = row.Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        Try
            If selectedIDSimpanan = 0 Then
                MessageBox.Show("Pilih data dulu dengan double-click!")
                Exit Sub
            End If

            koneksi()
            conn.Open()

            Dim updateQuery As String =
            "UPDATE simpanan SET 
            id_anggota = @id_anggota,
            tanggal_simpan = @tanggal,
            jenis_simpanan = @jenis,
            jumlah = @jumlah
            WHERE id_simpanan = @id"

            Dim cmd As New MySqlCommand(updateQuery, conn)

            cmd.Parameters.AddWithValue("@id", selectedIDSimpanan)
            cmd.Parameters.AddWithValue("@id_anggota", cbNmAnggota.SelectedValue)
            cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@jenis", cbJnsSimpanan.Text)
            cmd.Parameters.AddWithValue("@jumlah", Decimal.Parse(tbSimpanan.Text))

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data berhasil diperbarui!")

            tampildata()
            HitungTotalSimpanan()

            selectedIDSimpanan = 0

            selectedIDSimpanan = 0
            cbNmAnggota.SelectedIndex = -1
            cbJnsSimpanan.SelectedIndex = -1
            tbSimpanan.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        Try
            If selectedIDSimpanan = 0 Then
                MessageBox.Show("Pilih data yang ingin dihapus dengan double-click!")
                Exit Sub
            End If

            Dim result = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If result = DialogResult.No Then
                Exit Sub
            End If

            koneksi()
            conn.Open()

            Dim deleteQuery As String = "DELETE FROM simpanan WHERE id_simpanan = @id"

            Dim cmd As New MySqlCommand(deleteQuery, conn)
            cmd.Parameters.AddWithValue("@id", selectedIDSimpanan)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Data berhasil dihapus!")

            tampildata()
            HitungTotalSimpanan()

            selectedIDSimpanan = 0

            selectedIDSimpanan = 0
            cbNmAnggota.SelectedIndex = -1
            cbJnsSimpanan.SelectedIndex = -1
            tbSimpanan.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub bBatal_Click(sender As Object, e As EventArgs) Handles bBatal.Click
        selectedIDSimpanan = 0
        cbNmAnggota.SelectedIndex = -1
        cbJnsSimpanan.SelectedIndex = -1
        tbSimpanan.Clear()
    End Sub
    Private Sub HitungTotalSimpanan()
        Try
            koneksi()
            conn.Open()

            Dim cmd As New MySqlCommand("SELECT SUM(jumlah) FROM simpanan", conn)
            Dim hasil = cmd.ExecuteScalar()

            If IsDBNull(hasil) Or hasil Is Nothing Then
                lTotalSimpan.Text = "0"
            Else
                lTotalSimpan.Text = hasil.ToString()
            End If

            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        Dim formDashboard = New FormDashboard
        Me.Hide()
        formDashboard.Show()
    End Sub
End Class