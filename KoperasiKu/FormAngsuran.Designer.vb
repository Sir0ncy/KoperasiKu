<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAngsuran
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label14 = New Label()
        Label13 = New Label()
        Label11 = New Label()
        dgvDaftarAngsuran = New DataGridView()
        bHapus = New Button()
        bSimpan = New Button()
        tbJumlahAngsur = New TextBox()
        dtAngsur = New DateTimePicker()
        Label6 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        tbSisaAngsur = New TextBox()
        Label4 = New Label()
        bClear = New Button()
        bBack = New Button()
        tbNamaAnggota = New TextBox()
        bEdit = New Button()
        CType(dgvDaftarAngsuran, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label14
        ' 
        Label14.BorderStyle = BorderStyle.Fixed3D
        Label14.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(1, 63)
        Label14.Name = "Label14"
        Label14.Size = New Size(1100, 2)
        Label14.TabIndex = 56
        ' 
        ' Label13
        ' 
        Label13.BorderStyle = BorderStyle.Fixed3D
        Label13.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(6, 302)
        Label13.Name = "Label13"
        Label13.Size = New Size(1100, 2)
        Label13.TabIndex = 55
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(436, 315)
        Label11.Name = "Label11"
        Label11.Size = New Size(241, 32)
        Label11.TabIndex = 53
        Label11.Text = "Daftar Angsuran"
        ' 
        ' dgvDaftarAngsuran
        ' 
        dgvDaftarAngsuran.BackgroundColor = SystemColors.ControlLight
        dgvDaftarAngsuran.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDaftarAngsuran.Location = New Point(38, 350)
        dgvDaftarAngsuran.Name = "dgvDaftarAngsuran"
        dgvDaftarAngsuran.RowHeadersWidth = 51
        dgvDaftarAngsuran.Size = New Size(1038, 298)
        dgvDaftarAngsuran.TabIndex = 52
        ' 
        ' bHapus
        ' 
        bHapus.BackColor = Color.HotPink
        bHapus.ForeColor = SystemColors.ButtonHighlight
        bHapus.Location = New Point(206, 247)
        bHapus.Name = "bHapus"
        bHapus.Size = New Size(149, 43)
        bHapus.TabIndex = 50
        bHapus.Text = "Hapus"
        bHapus.UseVisualStyleBackColor = False
        ' 
        ' bSimpan
        ' 
        bSimpan.BackColor = Color.PowderBlue
        bSimpan.Location = New Point(38, 247)
        bSimpan.Name = "bSimpan"
        bSimpan.Size = New Size(149, 43)
        bSimpan.TabIndex = 48
        bSimpan.Text = "Simpan"
        bSimpan.UseVisualStyleBackColor = False
        ' 
        ' tbJumlahAngsur
        ' 
        tbJumlahAngsur.Location = New Point(215, 155)
        tbJumlahAngsur.Name = "tbJumlahAngsur"
        tbJumlahAngsur.Size = New Size(398, 27)
        tbJumlahAngsur.TabIndex = 36
        ' 
        ' dtAngsur
        ' 
        dtAngsur.Location = New Point(215, 116)
        dtAngsur.Name = "dtAngsur"
        dtAngsur.Size = New Size(264, 27)
        dtAngsur.TabIndex = 35
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(38, 118)
        Label6.Name = "Label6"
        Label6.Size = New Size(171, 23)
        Label6.TabIndex = 34
        Label6.Text = "Tanggal Angsur:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Lucida Sans", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(67, 155)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 23)
        Label3.TabIndex = 31
        Label3.Text = "Jumlah Bayar:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(49, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 23)
        Label2.TabIndex = 30
        Label2.Text = "Nama Anggota:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(379, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 39)
        Label1.TabIndex = 29
        Label1.Text = "Form Data Angsuran"
        ' 
        ' tbSisaAngsur
        ' 
        tbSisaAngsur.Location = New Point(215, 197)
        tbSisaAngsur.Name = "tbSisaAngsur"
        tbSisaAngsur.Size = New Size(398, 27)
        tbSisaAngsur.TabIndex = 58
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(60, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 23)
        Label4.TabIndex = 57
        Label4.Text = "Sisa Pinjaman:"
        ' 
        ' bClear
        ' 
        bClear.BackColor = Color.Azure
        bClear.Location = New Point(539, 247)
        bClear.Name = "bClear"
        bClear.Size = New Size(149, 43)
        bClear.TabIndex = 51
        bClear.Text = "Clear"
        bClear.UseVisualStyleBackColor = False
        ' 
        ' bBack
        ' 
        bBack.Location = New Point(12, 7)
        bBack.Name = "bBack"
        bBack.Size = New Size(73, 53)
        bBack.TabIndex = 59
        bBack.Text = "< Back"
        bBack.UseVisualStyleBackColor = True
        ' 
        ' tbNamaAnggota
        ' 
        tbNamaAnggota.Location = New Point(215, 78)
        tbNamaAnggota.Name = "tbNamaAnggota"
        tbNamaAnggota.Size = New Size(398, 27)
        tbNamaAnggota.TabIndex = 60
        ' 
        ' bEdit
        ' 
        bEdit.BackColor = Color.Khaki
        bEdit.ForeColor = SystemColors.ButtonHighlight
        bEdit.Location = New Point(373, 247)
        bEdit.Name = "bEdit"
        bEdit.Size = New Size(149, 43)
        bEdit.TabIndex = 61
        bEdit.Text = "Edit"
        bEdit.UseVisualStyleBackColor = False
        ' 
        ' FormAngsuran
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1102, 673)
        Controls.Add(bEdit)
        Controls.Add(tbNamaAnggota)
        Controls.Add(bBack)
        Controls.Add(tbSisaAngsur)
        Controls.Add(Label4)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(dgvDaftarAngsuran)
        Controls.Add(bClear)
        Controls.Add(bHapus)
        Controls.Add(bSimpan)
        Controls.Add(tbJumlahAngsur)
        Controls.Add(dtAngsur)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FormAngsuran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FormAngsuran"
        CType(dgvDaftarAngsuran, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvDaftarAngsuran As DataGridView
    Friend WithEvents bHapus As Button
    Friend WithEvents bSimpan As Button
    Friend WithEvents tbJumlahAngsur As TextBox
    Friend WithEvents dtAngsur As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbSisaAngsur As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bClear As Button
    Friend WithEvents bBack As Button
    Friend WithEvents tbNamaAnggota As TextBox
    Friend WithEvents bEdit As Button

    'Friend WithEvents Label14 As Label
    'Friend WithEvents Label13 As Label
    'Friend WithEvents Label12 As Label
    'Friend WithEvents Label11 As Label
    'Friend WithEvents dgvDaftarPinjam As DataGridView
    'Friend WithEvents bHapus As Button
    'Friend WithEvents Button3 As Button
    'Friend WithEvents bSimpan As Button
    'Friend WithEvents bHitung As Button
    'Friend WithEvents lblStatus As Label
    'Friend WithEvents tbSisaPinjaman As TextBox
    'Friend WithEvents tbCicilanperBulan As TextBox
    'Friend WithEvents Label10 As Label
    'Friend WithEvents Label9 As Label
    'Friend WithEvents Label8 As Label
    'Friend WithEvents cbAnggota As ComboBox
    'Friend WithEvents tbJumlahPinjaman As TextBox
    'Friend WithEvents dtPinjaman As DateTimePicker
    'Friend WithEvents Label6 As Label
    'Friend WithEvents Label3 As Label
    'Friend WithEvents Label2 As Label
    'Friend WithEvents Label1 As Label
    'Friend WithEvents tbSisaAngsur As TextBox
    'Friend WithEvents Label4 As Label
    'Friend WithEvents bClear As Button
End Class
