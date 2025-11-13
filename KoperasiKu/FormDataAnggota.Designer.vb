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
        tbNama = New TextBox()
        tbAlamat = New TextBox()
        tbNomor = New TextBox()
        tbSimpanan = New TextBox()
        lNama = New Label()
        lAlamat = New Label()
        lNomor = New Label()
        lSimpanan = New Label()
        dtTanggal = New DateTimePicker()
        lTanggal = New Label()
        bTambah = New Button()
        bSimpan = New Button()
        bEdit = New Button()
        bHapus = New Button()
        bBatal = New Button()
        labelTitle = New Label()
        CType(dgvAnggota, ComponentModel.ISupportInitialize).BeginInit()
        CType(bindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvAnggota
        ' 
        dgvAnggota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAnggota.Location = New Point(586, 113)
        dgvAnggota.Margin = New Padding(3, 4, 3, 4)
        dgvAnggota.Name = "dgvAnggota"
        dgvAnggota.ReadOnly = True
        dgvAnggota.RowHeadersWidth = 51
        dgvAnggota.Size = New Size(491, 516)
        dgvAnggota.TabIndex = 12
        ' 
        ' tbCari
        ' 
        tbCari.Font = New Font("Lucida Sans", 9.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        tbCari.Location = New Point(586, 78)
        tbCari.Margin = New Padding(3, 4, 3, 4)
        tbCari.Name = "tbCari"
        tbCari.Size = New Size(219, 25)
        tbCari.TabIndex = 19
        tbCari.Text = "Search"
        ' 
        ' bCari
        ' 
        bCari.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bCari.Location = New Point(812, 74)
        bCari.Margin = New Padding(3, 4, 3, 4)
        bCari.Name = "bCari"
        bCari.Size = New Size(61, 31)
        bCari.TabIndex = 20
        bCari.Text = "CARI"
        bCari.UseVisualStyleBackColor = True
        ' 
        ' tbNama
        ' 
        tbNama.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbNama.Location = New Point(177, 178)
        tbNama.Margin = New Padding(3, 4, 3, 4)
        tbNama.Name = "tbNama"
        tbNama.Size = New Size(382, 25)
        tbNama.TabIndex = 0
        ' 
        ' tbAlamat
        ' 
        tbAlamat.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbAlamat.Location = New Point(177, 229)
        tbAlamat.Margin = New Padding(3, 4, 3, 4)
        tbAlamat.Name = "tbAlamat"
        tbAlamat.Size = New Size(382, 25)
        tbAlamat.TabIndex = 1
        ' 
        ' tbNomor
        ' 
        tbNomor.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbNomor.Location = New Point(177, 281)
        tbNomor.Margin = New Padding(3, 4, 3, 4)
        tbNomor.Name = "tbNomor"
        tbNomor.Size = New Size(382, 25)
        tbNomor.TabIndex = 2
        ' 
        ' tbSimpanan
        ' 
        tbSimpanan.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbSimpanan.Location = New Point(177, 394)
        tbSimpanan.Margin = New Padding(3, 4, 3, 4)
        tbSimpanan.Name = "tbSimpanan"
        tbSimpanan.Size = New Size(382, 25)
        tbSimpanan.TabIndex = 4
        ' 
        ' lNama
        ' 
        lNama.AutoSize = True
        lNama.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lNama.Location = New Point(105, 178)
        lNama.Name = "lNama"
        lNama.Size = New Size(53, 17)
        lNama.TabIndex = 5
        lNama.Text = "Nama:"
        ' 
        ' lAlamat
        ' 
        lAlamat.AutoSize = True
        lAlamat.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lAlamat.Location = New Point(96, 229)
        lAlamat.Name = "lAlamat"
        lAlamat.Size = New Size(62, 17)
        lAlamat.TabIndex = 6
        lAlamat.Text = "Alamat:"
        ' 
        ' lNomor
        ' 
        lNomor.AutoSize = True
        lNomor.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lNomor.Location = New Point(70, 281)
        lNomor.Name = "lNomor"
        lNomor.Size = New Size(88, 17)
        lNomor.TabIndex = 7
        lNomor.Text = "Nomor HP:"
        ' 
        ' lSimpanan
        ' 
        lSimpanan.AutoSize = True
        lSimpanan.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lSimpanan.Location = New Point(36, 394)
        lSimpanan.Name = "lSimpanan"
        lSimpanan.Size = New Size(122, 17)
        lSimpanan.TabIndex = 9
        lSimpanan.Text = "Simpanan Awal:"
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtTanggal.Location = New Point(177, 340)
        dtTanggal.Margin = New Padding(3, 4, 3, 4)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(246, 25)
        dtTanggal.TabIndex = 10
        ' 
        ' lTanggal
        ' 
        lTanggal.AutoSize = True
        lTanggal.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lTanggal.Location = New Point(7, 340)
        lTanggal.Name = "lTanggal"
        lTanggal.Size = New Size(151, 17)
        lTanggal.TabIndex = 11
        lTanggal.Text = "Tanggal Bergabung:"
        ' 
        ' bTambah
        ' 
        bTambah.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bTambah.Location = New Point(41, 472)
        bTambah.Margin = New Padding(3, 4, 3, 4)
        bTambah.Name = "bTambah"
        bTambah.Size = New Size(146, 65)
        bTambah.TabIndex = 13
        bTambah.Text = "TAMBAH"
        bTambah.UseVisualStyleBackColor = True
        ' 
        ' bSimpan
        ' 
        bSimpan.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bSimpan.Location = New Point(217, 472)
        bSimpan.Margin = New Padding(3, 4, 3, 4)
        bSimpan.Name = "bSimpan"
        bSimpan.Size = New Size(146, 65)
        bSimpan.TabIndex = 14
        bSimpan.Text = "SIMPAN"
        bSimpan.UseVisualStyleBackColor = True
        ' 
        ' bEdit
        ' 
        bEdit.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bEdit.Location = New Point(390, 472)
        bEdit.Margin = New Padding(3, 4, 3, 4)
        bEdit.Name = "bEdit"
        bEdit.Size = New Size(146, 65)
        bEdit.TabIndex = 15
        bEdit.Text = "EDIT"
        bEdit.UseVisualStyleBackColor = True
        ' 
        ' bHapus
        ' 
        bHapus.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bHapus.Location = New Point(130, 564)
        bHapus.Margin = New Padding(3, 4, 3, 4)
        bHapus.Name = "bHapus"
        bHapus.Size = New Size(146, 65)
        bHapus.TabIndex = 16
        bHapus.Text = "HAPUS"
        bHapus.UseVisualStyleBackColor = True
        ' 
        ' bBatal
        ' 
        bBatal.Font = New Font("Lucida Sans", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bBatal.Location = New Point(312, 564)
        bBatal.Margin = New Padding(3, 4, 3, 4)
        bBatal.Name = "bBatal"
        bBatal.Size = New Size(146, 65)
        bBatal.TabIndex = 17
        bBatal.Text = "BATAL"
        bBatal.UseVisualStyleBackColor = True
        ' 
        ' labelTitle
        ' 
        labelTitle.AutoSize = True
        labelTitle.Font = New Font("Lucida Sans", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTitle.Location = New Point(130, 62)
        labelTitle.Name = "labelTitle"
        labelTitle.Size = New Size(393, 50)
        labelTitle.TabIndex = 18
        labelTitle.Text = "DATA ANGGOTA"
        ' 
        ' FormDataAnggota
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1102, 673)
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
        Controls.Add(dtTanggal)
        Controls.Add(lSimpanan)
        Controls.Add(lNomor)
        Controls.Add(lAlamat)
        Controls.Add(lNama)
        Controls.Add(tbSimpanan)
        Controls.Add(tbNomor)
        Controls.Add(tbAlamat)
        Controls.Add(tbNama)
        Margin = New Padding(3, 4, 3, 4)
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
    Friend WithEvents tbNama As TextBox
    Friend WithEvents tbAlamat As TextBox
    Friend WithEvents tbNomor As TextBox
    Friend WithEvents tbSimpanan As TextBox
    Friend WithEvents lNama As Label
    Friend WithEvents lAlamat As Label
    Friend WithEvents lNomor As Label
    Friend WithEvents lSimpanan As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents lTanggal As Label
    Friend WithEvents bTambah As Button
    Friend WithEvents bSimpan As Button
    Friend WithEvents bEdit As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents bBatal As Button
    Friend WithEvents labelTitle As Label
End Class
