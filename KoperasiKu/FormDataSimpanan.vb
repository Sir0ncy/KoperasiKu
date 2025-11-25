Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormDataSimpanan
    Dim Conn As MySqlConnection = MySQLCon.conn
    Dim Adp As MySqlDataAdapter
    Dim Dt As DataTable
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader
    Dim ketemu As Boolean
    Dim selectedIDSimpanan As Integer
    Dim selectedAnggotaID As Integer = -1

    Sub LoadDataAnggota()
        Connect()
        da = New MySqlDataAdapter("SELECT s.id_simpanan, a.nama, s.jenis_simpanan, s.tanggal_simpan ,s.jumlah
                                    FROM simpanan s
                                    JOIN anggota a ON s.id_anggota = a.id_anggota", Conn)
        Dt = New DataTable
        da.Fill(Dt)
        dgvSimpanan.Rows.Clear()
        For i = 0 To Dt.Rows.Count - 1
            dgvSimpanan.Rows.Add(Dt.Rows(i).Item(0))
            dgvSimpanan.Rows(i).Cells(1).Value = Dt.Rows(i).Item(1)
            dgvSimpanan.Rows(i).Cells(2).Value = Dt.Rows(i).Item(2)
            dgvSimpanan.Rows(i).Cells(3).Value = Dt.Rows(i).Item(3)
            dgvSimpanan.Rows(i).Cells(4).Value = Dt.Rows(i).Item(4)
        Next
        Conn.Close()
    End Sub
    Private Sub SearchAnggota()
        Try
            Connect()

            Dim cmd As New MySqlCommand(
            "SELECT id_anggota, nama 
             FROM anggota 
             WHERE nama LIKE @nama LIMIT 1", Conn)

            cmd.Parameters.AddWithValue("@nama", "%" & tbNamaAnggota.Text & "%")

            Dim rd = cmd.ExecuteReader()

            If rd.Read Then
                selectedAnggotaID = rd("id_anggota")
                tbNamaAnggota.Text = rd("nama")
            Else
                MessageBox.Show("Nama anggota tidak ditemukan!")
                selectedAnggotaID = -1
            End If

            rd.Close()
            Conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conn.Close()
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataAnggota()
        HitungTotalSimpanan()
    End Sub
    Private Sub bSimpan_Click(sender As Object, e As EventArgs) Handles bSimpan.Click
        Try
            If tbNamaAnggota.Text = "" Then
                MessageBox.Show("Cari nama anggota dulu!")
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

            Connect()

            Dim query As String = "INSERT INTO simpanan (id_anggota, tanggal_simpan, jenis_simpanan, jumlah) " &
                                  "VALUES (@id_anggota, @tanggal, @jenis, @jumlah)"

            Dim cmd As New MySqlCommand(query, Conn)

            cmd.Parameters.AddWithValue("@id_anggota", selectedAnggotaID)
            cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@jenis", cbJnsSimpanan.Text)
            cmd.Parameters.AddWithValue("@jumlah", Decimal.Parse(tbSimpanan.Text))

            cmd.ExecuteNonQuery()

            MessageBox.Show("Data simpanan berhasil ditambahkan!")

            Conn.Close()

            LoadDataAnggota()
            HitungTotalSimpanan()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conn.Close()
        End Try
    End Sub

    Private Sub bEdit_Click(sender As Object, e As EventArgs) Handles bEdit.Click
        Try
            If selectedIDSimpanan = 0 Then
                MessageBox.Show("Pilih data dulu di list!")
                Exit Sub
            End If

            If selectedAnggotaID = -1 Then
                MessageBox.Show("ID Anggota tidak ditemukan!")
                Exit Sub
            End If

            Connect()

            Dim updateQuery As String =
        "UPDATE simpanan SET 
            id_anggota = @id_anggota,
            tanggal_simpan = @tanggal,
            jenis_simpanan = @jenis,
            jumlah = @jumlah
         WHERE id_simpanan = @id"

            Dim cmd As New MySqlCommand(updateQuery, Conn)

            cmd.Parameters.AddWithValue("@id_anggota", selectedAnggotaID)
            cmd.Parameters.AddWithValue("@tanggal", dtTanggal.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@jenis", cbJnsSimpanan.Text)
            cmd.Parameters.AddWithValue("@jumlah", Decimal.Parse(tbSimpanan.Text))
            cmd.Parameters.AddWithValue("@id", selectedIDSimpanan) ' ← WAJIB ADA

            cmd.ExecuteNonQuery()
            Conn.Close()

            MessageBox.Show("Data berhasil diperbarui!")

            LoadDataAnggota()
            HitungTotalSimpanan()

            selectedIDSimpanan = 0
            tbNamaAnggota.Clear()
            cbJnsSimpanan.SelectedIndex = -1
            tbSimpanan.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conn.Close()
        End Try
    End Sub

    Private Sub bHapus_Click(sender As Object, e As EventArgs) Handles bHapus.Click
        Try
            If selectedIDSimpanan = 0 Then
                MessageBox.Show("Pilih data yang ingin dihapus di list!")
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

            Connect()

            Dim deleteQuery As String = "DELETE FROM simpanan WHERE id_simpanan = @id"

            Dim cmd As New MySqlCommand(deleteQuery, Conn)
            cmd.Parameters.AddWithValue("@id", selectedIDSimpanan)

            cmd.ExecuteNonQuery()
            Conn.Close()

            MessageBox.Show("Data berhasil dihapus!")

            LoadDataAnggota()
            HitungTotalSimpanan()

            selectedIDSimpanan = 0

            selectedIDSimpanan = 0
            tbNamaAnggota.Clear()
            cbJnsSimpanan.SelectedIndex = -1
            tbSimpanan.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub bBatal_Click(sender As Object, e As EventArgs) Handles bBatal.Click
        selectedIDSimpanan = 0
        tbNamaAnggota.Clear()
        cbJnsSimpanan.SelectedIndex = -1
        tbSimpanan.Clear()
    End Sub
    Private Sub HitungTotalSimpanan()
        Try
            Connect()

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

    Function GetIDAnggotaByNama(nama As String) As Integer
        Try
            Connect()

            Dim cmd As New MySqlCommand(
            "SELECT id_anggota FROM anggota WHERE nama=@nama LIMIT 1", Conn)

            cmd.Parameters.AddWithValue("@nama", nama)

            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                Return Convert.ToInt32(result)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then Conn.Close()
        End Try

        Return -1
    End Function

    Private Sub dgvSimpanan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSimpanan.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSimpanan.Rows(e.RowIndex)

            selectedIDSimpanan = CInt(row.Cells(0).Value)
            tbNamaAnggota.Text = row.Cells(1).Value.ToString()
            cbJnsSimpanan.Text = row.Cells(2).Value.ToString()
            dtTanggal.Value = DateTime.Parse(row.Cells(3).Value.ToString())
            tbSimpanan.Text = row.Cells(4).Value.ToString()

            selectedAnggotaID = GetIDAnggotaByNama(tbNamaAnggota.Text)
        End If
    End Sub

    Private Sub tbNamaAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNamaAnggota.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchAnggota()
        End If
    End Sub
End Class