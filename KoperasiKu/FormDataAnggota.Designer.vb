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
        bSimpan = New Button()
        bEdit = New Button()
        bHapus = New Button()
        bBatal = New Button()
        labelTitle = New Label()
        bBack = New Button()
        bClear = New Button()
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
        tbCari.Font = New Font("Lucida Sans", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        tbCari.Location = New Point(586, 77)
        tbCari.Margin = New Padding(3, 4, 3, 4)
        tbCari.Name = "tbCari"
        tbCari.Size = New Size(219, 25)
        tbCari.TabIndex = 19
        ' 
        ' bCari
        ' 
        bCari.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bCari.Location = New Point(811, 75)
        bCari.Margin = New Padding(3, 4, 3, 4)
        bCari.Name = "bCari"
        bCari.Size = New Size(61, 31)
        bCari.TabIndex = 20
        bCari.Text = "CARI"
        bCari.UseVisualStyleBackColor = True
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNama.Location = New Point(177, 179)
        txtNama.Margin = New Padding(3, 4, 3, 4)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(381, 25)
        txtNama.TabIndex = 0
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAlamat.Location = New Point(177, 229)
        txtAlamat.Margin = New Padding(3, 4, 3, 4)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(381, 25)
        txtAlamat.TabIndex = 1
        ' 
        ' txtNoHp
        ' 
        txtNoHp.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNoHp.Location = New Point(177, 281)
        txtNoHp.Margin = New Padding(3, 4, 3, 4)
        txtNoHp.Name = "txtNoHp"
        txtNoHp.Size = New Size(381, 25)
        txtNoHp.TabIndex = 2
        ' 
        ' txtSimpananAwal
        ' 
        txtSimpananAwal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSimpananAwal.Location = New Point(177, 395)
        txtSimpananAwal.Margin = New Padding(3, 4, 3, 4)
        txtSimpananAwal.Name = "txtSimpananAwal"
        txtSimpananAwal.Size = New Size(381, 25)
        txtSimpananAwal.TabIndex = 4
        ' 
        ' lNama
        ' 
        lNama.AutoSize = True
        lNama.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lNama.Location = New Point(105, 179)
        lNama.Name = "lNama"
        lNama.Size = New Size(53, 17)
        lNama.TabIndex = 5
        lNama.Text = "Nama:"
        ' 
        ' lAlamat
        ' 
        lAlamat.AutoSize = True
        lAlamat.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lAlamat.Location = New Point(96, 229)
        lAlamat.Name = "lAlamat"
        lAlamat.Size = New Size(62, 17)
        lAlamat.TabIndex = 6
        lAlamat.Text = "Alamat:"
        ' 
        ' lNomor
        ' 
        lNomor.AutoSize = True
        lNomor.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lNomor.Location = New Point(70, 281)
        lNomor.Name = "lNomor"
        lNomor.Size = New Size(88, 17)
        lNomor.TabIndex = 7
        lNomor.Text = "Nomor HP:"
        ' 
        ' lSimpanan
        ' 
        lSimpanan.AutoSize = True
        lSimpanan.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lSimpanan.Location = New Point(37, 395)
        lSimpanan.Name = "lSimpanan"
        lSimpanan.Size = New Size(122, 17)
        lSimpanan.TabIndex = 9
        lSimpanan.Text = "Simpanan Awal:"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        dtpTanggal.Location = New Point(177, 340)
        dtpTanggal.Margin = New Padding(3, 4, 3, 4)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(288, 25)
        dtpTanggal.TabIndex = 10
        ' 
        ' lTanggal
        ' 
        lTanggal.AutoSize = True
        lTanggal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lTanggal.Location = New Point(7, 340)
        lTanggal.Name = "lTanggal"
        lTanggal.Size = New Size(151, 17)
        lTanggal.TabIndex = 11
        lTanggal.Text = "Tanggal Bergabung:"
        ' 
        ' bSimpan
        ' 
        bSimpan.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bSimpan.Location = New Point(37, 472)
        bSimpan.Margin = New Padding(3, 4, 3, 4)
        bSimpan.Name = "bSimpan"
        bSimpan.Size = New Size(145, 65)
        bSimpan.TabIndex = 14
        bSimpan.Text = "SIMPAN"
        bSimpan.UseVisualStyleBackColor = True
        ' 
        ' bEdit
        ' 
        bEdit.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bEdit.Location = New Point(220, 472)
        bEdit.Margin = New Padding(3, 4, 3, 4)
        bEdit.Name = "bEdit"
        bEdit.Size = New Size(145, 65)
        bEdit.TabIndex = 15
        bEdit.Text = "EDIT"
        bEdit.UseVisualStyleBackColor = True
        ' 
        ' bHapus
        ' 
        bHapus.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bHapus.Location = New Point(130, 564)
        bHapus.Margin = New Padding(3, 4, 3, 4)
        bHapus.Name = "bHapus"
        bHapus.Size = New Size(145, 65)
        bHapus.TabIndex = 16
        bHapus.Text = "HAPUS"
        bHapus.UseVisualStyleBackColor = True
        ' 
        ' bBatal
        ' 
        bBatal.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bBatal.Location = New Point(312, 564)
        bBatal.Margin = New Padding(3, 4, 3, 4)
        bBatal.Name = "bBatal"
        bBatal.Size = New Size(145, 65)
        bBatal.TabIndex = 17
        bBatal.Text = "BATAL"
        bBatal.UseVisualStyleBackColor = True
        ' 
        ' labelTitle
        ' 
        labelTitle.AutoSize = True
        labelTitle.Font = New Font("Lucida Sans", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelTitle.Location = New Point(130, 61)
        labelTitle.Name = "labelTitle"
        labelTitle.Size = New Size(393, 50)
        labelTitle.TabIndex = 18
        labelTitle.Text = "DATA ANGGOTA"
        ' 
        ' bBack
        ' 
        bBack.Location = New Point(11, 12)
        bBack.Name = "bBack"
        bBack.Size = New Size(73, 53)
        bBack.TabIndex = 21
        bBack.Text = "< Back"
        bBack.UseVisualStyleBackColor = True
        ' 
        ' bClear
        ' 
        bClear.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bClear.Location = New Point(399, 472)
        bClear.Margin = New Padding(3, 4, 3, 4)
        bClear.Name = "bClear"
        bClear.Size = New Size(145, 65)
        bClear.TabIndex = 22
        bClear.Text = "CLEAR"
        bClear.UseVisualStyleBackColor = True
        ' 
        ' FormDataAnggota
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1102, 673)
        Controls.Add(bClear)
        Controls.Add(bBack)
        Controls.Add(bCari)
        Controls.Add(tbCari)
        Controls.Add(labelTitle)
        Controls.Add(bBatal)
        Controls.Add(bHapus)
        Controls.Add(bEdit)
        Controls.Add(bSimpan)
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
    Friend WithEvents bSimpan As Button
    Friend WithEvents bEdit As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents bBatal As Button
    Friend WithEvents labelTitle As Label
    Friend WithEvents bBack As Button
    Friend WithEvents bClear As Button
End Class
