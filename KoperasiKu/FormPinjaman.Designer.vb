<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPinjaman
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        dtPinjaman = New DateTimePicker()
        tbJumlahPinjaman = New TextBox()
        tbBunga = New TextBox()
        tbLamaCicilan = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        tbCicilanperBulan = New TextBox()
        tbSisaPinjaman = New TextBox()
        lblStatus = New Label()
        bHitung = New Button()
        bSimpan = New Button()
        bEdit = New Button()
        bClear = New Button()
        bHapus = New Button()
        dgvDaftarPinjam = New DataGridView()
        Label11 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        bBack = New Button()
        tbNamaAnggota = New TextBox()
        CType(dgvDaftarPinjam, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(379, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(349, 39)
        Label1.TabIndex = 0
        Label1.Text = "Form Data Pinjaman"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(51, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 23)
        Label2.TabIndex = 1
        Label2.Text = "Nama Anggota:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(33, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(178, 23)
        Label3.TabIndex = 2
        Label3.Text = "Jumlah Pinjaman:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(102, 159)
        Label4.Name = "Label4"
        Label4.Size = New Size(109, 23)
        Label4.TabIndex = 3
        Label4.Text = "Bunga (%):"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(72, 198)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 23)
        Label5.TabIndex = 4
        Label5.Text = "Lama Cicilan:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(706, 86)
        Label6.Name = "Label6"
        Label6.Size = New Size(95, 23)
        Label6.TabIndex = 5
        Label6.Text = "Tanggal:"
        ' 
        ' dtPinjaman
        ' 
        dtPinjaman.Location = New Point(807, 84)
        dtPinjaman.Name = "dtPinjaman"
        dtPinjaman.Size = New Size(264, 27)
        dtPinjaman.TabIndex = 6
        ' 
        ' tbJumlahPinjaman
        ' 
        tbJumlahPinjaman.Location = New Point(217, 122)
        tbJumlahPinjaman.Name = "tbJumlahPinjaman"
        tbJumlahPinjaman.Size = New Size(398, 27)
        tbJumlahPinjaman.TabIndex = 8
        ' 
        ' tbBunga
        ' 
        tbBunga.Location = New Point(217, 159)
        tbBunga.Name = "tbBunga"
        tbBunga.Size = New Size(59, 27)
        tbBunga.TabIndex = 9
        ' 
        ' tbLamaCicilan
        ' 
        tbLamaCicilan.Location = New Point(217, 198)
        tbLamaCicilan.Name = "tbLamaCicilan"
        tbLamaCicilan.Size = New Size(59, 27)
        tbLamaCicilan.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(282, 206)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 19)
        Label7.TabIndex = 12
        Label7.Text = "bulan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(51, 252)
        Label8.Name = "Label8"
        Label8.Size = New Size(158, 23)
        Label8.TabIndex = 13
        Label8.Text = "Cicilan / Bulan:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(60, 291)
        Label9.Name = "Label9"
        Label9.Size = New Size(149, 23)
        Label9.TabIndex = 14
        Label9.Text = "Sisa Pinjaman:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(724, 252)
        Label10.Name = "Label10"
        Label10.Size = New Size(77, 23)
        Label10.TabIndex = 15
        Label10.Text = "Status:"
        ' 
        ' tbCicilanperBulan
        ' 
        tbCicilanperBulan.Location = New Point(215, 252)
        tbCicilanperBulan.Name = "tbCicilanperBulan"
        tbCicilanperBulan.Size = New Size(398, 27)
        tbCicilanperBulan.TabIndex = 16
        ' 
        ' tbSisaPinjaman
        ' 
        tbSisaPinjaman.Location = New Point(217, 287)
        tbSisaPinjaman.Name = "tbSisaPinjaman"
        tbSisaPinjaman.Size = New Size(396, 27)
        tbSisaPinjaman.TabIndex = 17
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.LawnGreen
        lblStatus.Location = New Point(807, 251)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(194, 27)
        lblStatus.TabIndex = 18
        lblStatus.Text = "Aktif / Lunas"
        ' 
        ' bHitung
        ' 
        bHitung.BackColor = Color.LightSteelBlue
        bHitung.Location = New Point(33, 331)
        bHitung.Name = "bHitung"
        bHitung.Size = New Size(149, 43)
        bHitung.TabIndex = 19
        bHitung.Text = "Hitung"
        bHitung.UseVisualStyleBackColor = False
        ' 
        ' bSimpan
        ' 
        bSimpan.BackColor = Color.PowderBlue
        bSimpan.Location = New Point(207, 331)
        bSimpan.Name = "bSimpan"
        bSimpan.Size = New Size(149, 43)
        bSimpan.TabIndex = 20
        bSimpan.Text = "Simpan"
        bSimpan.UseVisualStyleBackColor = False
        ' 
        ' bEdit
        ' 
        bEdit.BackColor = Color.Khaki
        bEdit.Location = New Point(379, 331)
        bEdit.Name = "bEdit"
        bEdit.Size = New Size(149, 43)
        bEdit.TabIndex = 21
        bEdit.Text = "Edit"
        bEdit.UseVisualStyleBackColor = False
        ' 
        ' bClear
        ' 
        bClear.BackColor = Color.Azure
        bClear.Location = New Point(721, 331)
        bClear.Name = "bClear"
        bClear.Size = New Size(149, 43)
        bClear.TabIndex = 23
        bClear.Text = "Clear"
        bClear.UseVisualStyleBackColor = False
        ' 
        ' bHapus
        ' 
        bHapus.BackColor = Color.HotPink
        bHapus.Location = New Point(549, 331)
        bHapus.Name = "bHapus"
        bHapus.Size = New Size(149, 43)
        bHapus.TabIndex = 22
        bHapus.Text = "Hapus"
        bHapus.UseVisualStyleBackColor = False
        ' 
        ' dgvDaftarPinjam
        ' 
        dgvDaftarPinjam.BackgroundColor = SystemColors.ControlLight
        dgvDaftarPinjam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDaftarPinjam.Location = New Point(33, 436)
        dgvDaftarPinjam.Name = "dgvDaftarPinjam"
        dgvDaftarPinjam.RowHeadersWidth = 51
        dgvDaftarPinjam.Size = New Size(1038, 225)
        dgvDaftarPinjam.TabIndex = 24
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(431, 401)
        Label11.Name = "Label11"
        Label11.Size = New Size(234, 32)
        Label11.TabIndex = 25
        Label11.Text = "Daftar Pinjaman"
        ' 
        ' Label12
        ' 
        Label12.BorderStyle = BorderStyle.Fixed3D
        Label12.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(1, 235)
        Label12.Name = "Label12"
        Label12.Size = New Size(1100, 2)
        Label12.TabIndex = 26
        ' 
        ' Label13
        ' 
        Label13.BorderStyle = BorderStyle.Fixed3D
        Label13.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(1, 388)
        Label13.Name = "Label13"
        Label13.Size = New Size(1100, 2)
        Label13.TabIndex = 27
        ' 
        ' Label14
        ' 
        Label14.BorderStyle = BorderStyle.Fixed3D
        Label14.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(1, 62)
        Label14.Name = "Label14"
        Label14.Size = New Size(1100, 2)
        Label14.TabIndex = 28
        ' 
        ' bBack
        ' 
        bBack.Location = New Point(12, 6)
        bBack.Name = "bBack"
        bBack.Size = New Size(73, 53)
        bBack.TabIndex = 29
        bBack.Text = "< Back"
        bBack.UseVisualStyleBackColor = True
        ' 
        ' tbNamaAnggota
        ' 
        tbNamaAnggota.Location = New Point(217, 82)
        tbNamaAnggota.Name = "tbNamaAnggota"
        tbNamaAnggota.Size = New Size(398, 27)
        tbNamaAnggota.TabIndex = 30
        ' 
        ' FormPinjaman
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1102, 673)
        Controls.Add(tbNamaAnggota)
        Controls.Add(bBack)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(dgvDaftarPinjam)
        Controls.Add(bClear)
        Controls.Add(bHapus)
        Controls.Add(bEdit)
        Controls.Add(bSimpan)
        Controls.Add(bHitung)
        Controls.Add(lblStatus)
        Controls.Add(tbSisaPinjaman)
        Controls.Add(tbCicilanperBulan)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(tbLamaCicilan)
        Controls.Add(tbBunga)
        Controls.Add(tbJumlahPinjaman)
        Controls.Add(dtPinjaman)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormPinjaman"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormPinjaman"
        CType(dgvDaftarPinjam, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtPinjaman As DateTimePicker
    Friend WithEvents tbJumlahPinjaman As TextBox
    Friend WithEvents tbBunga As TextBox
    Friend WithEvents tbLamaCicilan As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbCicilanperBulan As TextBox
    Friend WithEvents tbSisaPinjaman As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents bHitung As Button
    Friend WithEvents bSimpan As Button
    Friend WithEvents bEdit As Button
    Friend WithEvents bClear As Button
    Friend WithEvents bHapus As Button
    Friend WithEvents dgvDaftarPinjam As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents bBack As Button
    Friend WithEvents tbNamaAnggota As TextBox
End Class
