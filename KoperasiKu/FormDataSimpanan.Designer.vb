<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataSimpanan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lAnggota = New Label()
        lJenis = New Label()
        lTanggal = New Label()
        lJumlah = New Label()
        cbJnsSimpanan = New ComboBox()
        dtTanggal = New DateTimePicker()
        panelMain = New Panel()
        tbSimpanan = New TextBox()
        tbNamaAnggota = New TextBox()
        lTotalSimpan = New Label()
        lTotalLabel = New Label()
        dgvSimpanan = New DataGridView()
        colId = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colJenis = New DataGridViewTextBoxColumn()
        colTanggal = New DataGridViewTextBoxColumn()
        colJumlah = New DataGridViewTextBoxColumn()
        lDaftarTitle = New Label()
        bBatal = New Button()
        bHapus = New Button()
        bEdit = New Button()
        bSimpan = New Button()
        lTitle = New Label()
        bBack = New Button()
        panelMain.SuspendLayout()
        CType(dgvSimpanan, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lAnggota
        ' 
        lAnggota.AutoSize = True
        lAnggota.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lAnggota.Location = New Point(36, 93)
        lAnggota.Name = "lAnggota"
        lAnggota.Size = New Size(119, 17)
        lAnggota.TabIndex = 0
        lAnggota.Text = "Nama Anggota:"
        ' 
        ' lJenis
        ' 
        lJenis.AutoSize = True
        lJenis.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lJenis.Location = New Point(33, 131)
        lJenis.Name = "lJenis"
        lJenis.Size = New Size(122, 17)
        lJenis.TabIndex = 1
        lJenis.Text = "Jenis Simpanan:"
        ' 
        ' lTanggal
        ' 
        lTanggal.AutoSize = True
        lTanggal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lTanggal.Location = New Point(11, 169)
        lTanggal.Name = "lTanggal"
        lTanggal.Size = New Size(144, 17)
        lTanggal.TabIndex = 2
        lTanggal.Text = "Tanggal Simpanan:"
        ' 
        ' lJumlah
        ' 
        lJumlah.AutoSize = True
        lJumlah.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lJumlah.Location = New Point(19, 212)
        lJumlah.Name = "lJumlah"
        lJumlah.Size = New Size(136, 17)
        lJumlah.TabIndex = 3
        lJumlah.Text = "Jumlah Simpanan:"
        ' 
        ' cbJnsSimpanan
        ' 
        cbJnsSimpanan.DropDownStyle = ComboBoxStyle.DropDownList
        cbJnsSimpanan.FlatStyle = FlatStyle.Flat
        cbJnsSimpanan.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbJnsSimpanan.FormattingEnabled = True
        cbJnsSimpanan.Items.AddRange(New Object() {"Pokok", "Wajib", "Sukarela"})
        cbJnsSimpanan.Location = New Point(161, 128)
        cbJnsSimpanan.Name = "cbJnsSimpanan"
        cbJnsSimpanan.Size = New Size(335, 25)
        cbJnsSimpanan.TabIndex = 6
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Cursor = Cursors.Hand
        dtTanggal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtTanggal.Location = New Point(161, 166)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(276, 25)
        dtTanggal.TabIndex = 8
        ' 
        ' panelMain
        ' 
        panelMain.Controls.Add(tbSimpanan)
        panelMain.Controls.Add(tbNamaAnggota)
        panelMain.Controls.Add(lTotalSimpan)
        panelMain.Controls.Add(lTotalLabel)
        panelMain.Controls.Add(dgvSimpanan)
        panelMain.Controls.Add(lDaftarTitle)
        panelMain.Controls.Add(bBatal)
        panelMain.Controls.Add(bHapus)
        panelMain.Controls.Add(bEdit)
        panelMain.Controls.Add(bSimpan)
        panelMain.Controls.Add(lTitle)
        panelMain.Controls.Add(lTanggal)
        panelMain.Controls.Add(lAnggota)
        panelMain.Controls.Add(dtTanggal)
        panelMain.Controls.Add(lJenis)
        panelMain.Controls.Add(lJumlah)
        panelMain.Controls.Add(cbJnsSimpanan)
        panelMain.Location = New Point(91, 36)
        panelMain.Name = "panelMain"
        panelMain.Size = New Size(920, 600)
        panelMain.TabIndex = 10
        ' 
        ' tbSimpanan
        ' 
        tbSimpanan.Location = New Point(160, 206)
        tbSimpanan.Name = "tbSimpanan"
        tbSimpanan.Size = New Size(336, 27)
        tbSimpanan.TabIndex = 20
        ' 
        ' tbNamaAnggota
        ' 
        tbNamaAnggota.Location = New Point(160, 87)
        tbNamaAnggota.Name = "tbNamaAnggota"
        tbNamaAnggota.Size = New Size(336, 27)
        tbNamaAnggota.TabIndex = 19
        ' 
        ' lTotalSimpan
        ' 
        lTotalSimpan.AutoSize = True
        lTotalSimpan.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lTotalSimpan.Location = New Point(167, 550)
        lTotalSimpan.Name = "lTotalSimpan"
        lTotalSimpan.Size = New Size(23, 17)
        lTotalSimpan.TabIndex = 18
        lTotalSimpan.Text = "---"
        ' 
        ' lTotalLabel
        ' 
        lTotalLabel.AutoSize = True
        lTotalLabel.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lTotalLabel.Location = New Point(15, 550)
        lTotalLabel.Name = "lTotalLabel"
        lTotalLabel.Size = New Size(163, 17)
        lTotalLabel.TabIndex = 17
        lTotalLabel.Text = "Total Simpanan : Rp. "
        ' 
        ' dgvSimpanan
        ' 
        dgvSimpanan.AllowUserToResizeColumns = False
        dgvSimpanan.AllowUserToResizeRows = False
        dgvSimpanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSimpanan.Columns.AddRange(New DataGridViewColumn() {colId, colNama, colJenis, colTanggal, colJumlah})
        dgvSimpanan.Location = New Point(46, 307)
        dgvSimpanan.Name = "dgvSimpanan"
        dgvSimpanan.RowHeadersVisible = False
        dgvSimpanan.RowHeadersWidth = 51
        dgvSimpanan.Size = New Size(828, 216)
        dgvSimpanan.TabIndex = 16
        ' 
        ' colId
        ' 
        colId.HeaderText = "ID"
        colId.MinimumWidth = 6
        colId.Name = "colId"
        colId.ReadOnly = True
        colId.Width = 50
        ' 
        ' colNama
        ' 
        colNama.HeaderText = "Nama Anggota"
        colNama.MinimumWidth = 6
        colNama.Name = "colNama"
        colNama.ReadOnly = True
        colNama.Width = 250
        ' 
        ' colJenis
        ' 
        colJenis.HeaderText = "Jenis"
        colJenis.MinimumWidth = 6
        colJenis.Name = "colJenis"
        colJenis.ReadOnly = True
        colJenis.Width = 175
        ' 
        ' colTanggal
        ' 
        colTanggal.HeaderText = "Tanggal"
        colTanggal.MinimumWidth = 6
        colTanggal.Name = "colTanggal"
        colTanggal.ReadOnly = True
        colTanggal.Width = 175
        ' 
        ' colJumlah
        ' 
        colJumlah.HeaderText = "Jumlah"
        colJumlah.MinimumWidth = 6
        colJumlah.Name = "colJumlah"
        colJumlah.ReadOnly = True
        colJumlah.Width = 175
        ' 
        ' lDaftarTitle
        ' 
        lDaftarTitle.AutoSize = True
        lDaftarTitle.Font = New Font("Lucida Sans", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lDaftarTitle.Location = New Point(238, 259)
        lDaftarTitle.Name = "lDaftarTitle"
        lDaftarTitle.Size = New Size(407, 27)
        lDaftarTitle.TabIndex = 15
        lDaftarTitle.Text = "DAFTAR  SIMPANAN ANGGOTA"
        ' 
        ' bBatal
        ' 
        bBatal.BackColor = Color.Azure
        bBatal.Cursor = Cursors.Hand
        bBatal.FlatAppearance.BorderColor = Color.Silver
        bBatal.FlatAppearance.CheckedBackColor = Color.Black
        bBatal.FlatAppearance.MouseDownBackColor = Color.DarkGray
        bBatal.FlatAppearance.MouseOverBackColor = Color.White
        bBatal.FlatStyle = FlatStyle.Flat
        bBatal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bBatal.Location = New Point(558, 166)
        bBatal.Name = "bBatal"
        bBatal.Size = New Size(108, 47)
        bBatal.TabIndex = 14
        bBatal.Text = "Clear"
        bBatal.UseVisualStyleBackColor = False
        ' 
        ' bHapus
        ' 
        bHapus.BackColor = Color.HotPink
        bHapus.Cursor = Cursors.Hand
        bHapus.FlatAppearance.BorderColor = Color.Silver
        bHapus.FlatAppearance.CheckedBackColor = Color.Black
        bHapus.FlatAppearance.MouseDownBackColor = Color.DarkGray
        bHapus.FlatAppearance.MouseOverBackColor = Color.White
        bHapus.FlatStyle = FlatStyle.Flat
        bHapus.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bHapus.Location = New Point(689, 93)
        bHapus.Name = "bHapus"
        bHapus.Size = New Size(108, 47)
        bHapus.TabIndex = 13
        bHapus.Text = "Hapus"
        bHapus.UseVisualStyleBackColor = False
        ' 
        ' bEdit
        ' 
        bEdit.BackColor = Color.Khaki
        bEdit.Cursor = Cursors.Hand
        bEdit.FlatAppearance.BorderColor = Color.Silver
        bEdit.FlatAppearance.CheckedBackColor = Color.Black
        bEdit.FlatAppearance.MouseDownBackColor = Color.DarkGray
        bEdit.FlatAppearance.MouseOverBackColor = Color.White
        bEdit.FlatStyle = FlatStyle.Flat
        bEdit.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bEdit.Location = New Point(689, 166)
        bEdit.Name = "bEdit"
        bEdit.Size = New Size(108, 47)
        bEdit.TabIndex = 12
        bEdit.Text = "Edit"
        bEdit.UseVisualStyleBackColor = False
        ' 
        ' bSimpan
        ' 
        bSimpan.BackColor = Color.PowderBlue
        bSimpan.Cursor = Cursors.Hand
        bSimpan.FlatAppearance.BorderColor = Color.Silver
        bSimpan.FlatAppearance.CheckedBackColor = Color.Black
        bSimpan.FlatAppearance.MouseDownBackColor = Color.DarkGray
        bSimpan.FlatAppearance.MouseOverBackColor = Color.White
        bSimpan.FlatStyle = FlatStyle.Flat
        bSimpan.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bSimpan.Location = New Point(558, 92)
        bSimpan.Name = "bSimpan"
        bSimpan.Size = New Size(108, 47)
        bSimpan.TabIndex = 11
        bSimpan.Text = "Simpan"
        bSimpan.UseVisualStyleBackColor = False
        ' 
        ' lTitle
        ' 
        lTitle.AutoSize = True
        lTitle.Font = New Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lTitle.Location = New Point(275, 19)
        lTitle.Name = "lTitle"
        lTitle.Size = New Size(382, 34)
        lTitle.TabIndex = 10
        lTitle.Text = "FORM DATA SIMPANAN"
        ' 
        ' bBack
        ' 
        bBack.Location = New Point(12, 12)
        bBack.Name = "bBack"
        bBack.Size = New Size(73, 53)
        bBack.TabIndex = 11
        bBack.Text = "< Back"
        bBack.UseVisualStyleBackColor = True
        ' 
        ' FormDataSimpanan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1102, 673)
        Controls.Add(bBack)
        Controls.Add(panelMain)
        Name = "FormDataSimpanan"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Data Simpanan"
        panelMain.ResumeLayout(False)
        panelMain.PerformLayout()
        CType(dgvSimpanan, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lAnggota As Label
    Friend WithEvents lJenis As Label
    Friend WithEvents lTanggal As Label
    Friend WithEvents lJumlah As Label
    Friend WithEvents cbJnsSimpanan As ComboBox
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents panelMain As Panel
    Friend WithEvents lTitle As Label
    Friend WithEvents bBatal As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents bEdit As Button
    Friend WithEvents bSimpan As Button
    Friend WithEvents lDaftarTitle As Label
    Friend WithEvents dgvSimpanan As DataGridView
    Friend WithEvents lTotalLabel As Label
    Friend WithEvents lTotalSimpan As Label
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colJenis As DataGridViewTextBoxColumn
    Friend WithEvents colTanggal As DataGridViewTextBoxColumn
    Friend WithEvents colJumlah As DataGridViewTextBoxColumn
    Friend WithEvents bBack As Button
    Friend WithEvents tbSimpanan As TextBox
    Friend WithEvents tbNamaAnggota As TextBox
End Class
