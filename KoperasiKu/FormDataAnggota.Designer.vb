<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDataAnggota
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
        components = New ComponentModel.Container()
        dgvAnggota = New DataGridView()
        bindingSource1 = New BindingSource(components)
        tbCari = New TextBox()
        bCari = New Button()
        txtNama = New TextBox()
        txtAlamat = New TextBox()
        txtNoHp = New TextBox()
        txtSimpananAwal = New TextBox()
        lNama = New Label()
        lAlamat = New Label()
        lNomor = New Label()
        lSimpanan = New Label()
        dtpTanggal = New DateTimePicker()
        lTanggal = New Label()
        bTambah = New Button()
        bSimpan = New Button()
        bEdit = New Button()
        bHapus = New Button()
        bBatal = New Button()
        labelTitle = New Label()
        bBack = New Button()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        CType(dgvAnggota, ComponentModel.ISupportInitialize).BeginInit()
        CType(bindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAnggota
        ' 
        dgvAnggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAnggota.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgvAnggota.Location = New Point(513, 85)
        dgvAnggota.Name = "dgvAnggota"
        dgvAnggota.ReadOnly = True
        dgvAnggota.RowHeadersWidth = 51
        dgvAnggota.Size = New Size(430, 387)
        dgvAnggota.TabIndex = 12
        ' 
        ' tbCari
        ' 
        tbCari.Font = New Font("Lucida Sans", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        tbCari.Location = New Point(513, 58)
        tbCari.Name = "tbCari"
        tbCari.Size = New Size(192, 22)
        tbCari.TabIndex = 19
        tbCari.Text = "Search"
        ' 
        ' bCari
        ' 
        bCari.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bCari.Location = New Point(710, 56)
        bCari.Name = "bCari"
        bCari.Size = New Size(53, 23)
        bCari.TabIndex = 20
        bCari.Text = "CARI"
        bCari.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(155, 134)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(335, 22)
        txtNama.TabIndex = 0
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(155, 172)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(335, 22)
        txtAlamat.TabIndex = 1
        ' 
        ' txtNoHp
        ' 
        txtNoHp.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNoHp.Location = New Point(155, 211)
        txtNoHp.Name = "txtNoHp"
        txtNoHp.Size = New Size(335, 22)
        txtNoHp.TabIndex = 2
        ' 
        ' txtSimpananAwal
        ' 
        txtSimpananAwal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSimpananAwal.Location = New Point(155, 296)
        txtSimpananAwal.Name = "txtSimpananAwal"
        txtSimpananAwal.Size = New Size(335, 22)
        txtSimpananAwal.TabIndex = 4
        ' 
        ' lNama
        ' 
        lNama.AutoSize = True
        lNama.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lNama.Location = New Point(92, 134)
        lNama.Name = "lNama"
        lNama.Size = New Size(45, 15)
        lNama.TabIndex = 5
        lNama.Text = "Nama:"
        ' 
        ' lAlamat
        ' 
        lAlamat.AutoSize = True
        lAlamat.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lAlamat.Location = New Point(84, 172)
        lAlamat.Name = "lAlamat"
        lAlamat.Size = New Size(53, 15)
        lAlamat.TabIndex = 6
        lAlamat.Text = "Alamat:"
        ' 
        ' lNomor
        ' 
        lNomor.AutoSize = True
        lNomor.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lNomor.Location = New Point(61, 211)
        lNomor.Name = "lNomor"
        lNomor.Size = New Size(70, 15)
        lNomor.TabIndex = 7
        lNomor.Text = "Nomor HP:"
        ' 
        ' lSimpanan
        ' 
        lSimpanan.AutoSize = True
        lSimpanan.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lSimpanan.Location = New Point(32, 296)
        lSimpanan.Name = "lSimpanan"
        lSimpanan.Size = New Size(102, 15)
        lSimpanan.TabIndex = 9
        lSimpanan.Text = "Simpanan Awal:"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTanggal.Location = New Point(155, 255)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(216, 22)
        dtpTanggal.TabIndex = 10
        ' 
        ' lTanggal
        ' 
        lTanggal.AutoSize = True
        lTanggal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lTanggal.Location = New Point(6, 255)
        lTanggal.Name = "lTanggal"
        lTanggal.Size = New Size(125, 15)
        lTanggal.TabIndex = 11
        lTanggal.Text = "Tanggal Bergabung:"
        ' 
        ' bTambah
        ' 
        bTambah.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bTambah.Location = New Point(36, 354)
        bTambah.Name = "bTambah"
        bTambah.Size = New Size(128, 49)
        bTambah.TabIndex = 13
        bTambah.Text = "TAMBAH"
        bTambah.UseVisualStyleBackColor = True
        ' 
        ' bSimpan
        ' 
        bSimpan.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bSimpan.Location = New Point(190, 354)
        bSimpan.Name = "bSimpan"
        bSimpan.Size = New Size(128, 49)
        bSimpan.TabIndex = 14
        bSimpan.Text = "SIMPAN"
        bSimpan.UseVisualStyleBackColor = True
        ' 
        ' bEdit
        ' 
        bEdit.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bEdit.Location = New Point(341, 354)
        bEdit.Name = "bEdit"
        bEdit.Size = New Size(128, 49)
        bEdit.TabIndex = 15
        bEdit.Text = "EDIT"
        bEdit.UseVisualStyleBackColor = True
        ' 
        ' bHapus
        ' 
        bHapus.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bHapus.Location = New Point(114, 423)
        bHapus.Name = "bHapus"
        bHapus.Size = New Size(128, 49)
        bHapus.TabIndex = 16
        bHapus.Text = "HAPUS"
        bHapus.UseVisualStyleBackColor = True
        ' 
        ' bBatal
        ' 
        bBatal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bBatal.Location = New Point(273, 423)
        bBatal.Name = "bBatal"
        bBatal.Size = New Size(128, 49)
        bBatal.TabIndex = 17
        bBatal.Text = "BATAL"
        bBatal.UseVisualStyleBackColor = True
        ' 
        ' labelTitle
        ' 
        labelTitle.AutoSize = True
        labelTitle.Font = New Font("Lucida Sans", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTitle.Location = New Point(114, 46)
        labelTitle.Name = "labelTitle"
        labelTitle.Size = New Size(316, 39)
        labelTitle.TabIndex = 18
        labelTitle.Text = "DATA ANGGOTA"
        ' 
        ' bBack
        ' 
        bBack.Location = New Point(10, 9)
        bBack.Margin = New Padding(3, 2, 3, 2)
        bBack.Name = "bBack"
        bBack.Size = New Size(64, 40)
        bBack.TabIndex = 21
        bBack.Text = "< Back"
        bBack.UseVisualStyleBackColor = True
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Nama"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Alamat"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Nomor"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Tanggal"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Simpanan Awal"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        ' 
        ' FormDataAnggota
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(964, 505)
        Controls.Add(bBack)
        Controls.Add(bCari)
        Controls.Add(tbCari)
        Controls.Add(labelTitle)
        Controls.Add(bBatal)
        Controls.Add(bHapus)
        Controls.Add(bEdit)
        Controls.Add(bSimpan)
        Controls.Add(bTambah)
        Controls.Add(dgvAnggota)
        Controls.Add(lTanggal)
        Controls.Add(dtpTanggal)
        Controls.Add(lSimpanan)
        Controls.Add(lNomor)
        Controls.Add(lAlamat)
        Controls.Add(lNama)
        Controls.Add(txtSimpananAwal)
        Controls.Add(txtNoHp)
        Controls.Add(txtAlamat)
        Controls.Add(txtNama)
        Name = "FormDataAnggota"
        Text = "FormDataAnggota"
        CType(dgvAnggota, ComponentModel.ISupportInitialize).EndInit()
        CType(bindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvAnggota As DataGridView
    Friend WithEvents bindingSource1 As BindingSource
    Friend WithEvents tbCari As TextBox
    Friend WithEvents bCari As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtNoHp As TextBox
    Friend WithEvents txtSimpananAwal As TextBox
    Friend WithEvents lNama As Label
    Friend WithEvents lAlamat As Label
    Friend WithEvents lNomor As Label
    Friend WithEvents lSimpanan As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents lTanggal As Label
    Friend WithEvents bTambah As Button
    Friend WithEvents bSimpan As Button
    Friend WithEvents bEdit As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents bBatal As Button
    Friend WithEvents labelTitle As Label
    Friend WithEvents bBack As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
