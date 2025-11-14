<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDashboard
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
        Panel1 = New Panel()
        bLogOut = New Button()
        bAngsuranAnggota = New Button()
        bPinjamanAnggota = New Button()
        bSimpananAnggota = New Button()
        Label1 = New Label()
        bDataAnggota = New Button()
        lTitle = New Label()
        Panel2 = New Panel()
        Label2 = New Label()
        lTanggal = New Label()
        lAnggota = New Label()
        lJumlah = New Label()
        lJenis = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(bLogOut)
        Panel1.Controls.Add(bAngsuranAnggota)
        Panel1.Controls.Add(bPinjamanAnggota)
        Panel1.Controls.Add(bSimpananAnggota)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(bDataAnggota)
        Panel1.Location = New Point(53, 107)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(283, 438)
        Panel1.TabIndex = 0
        ' 
        ' bLogOut
        ' 
        bLogOut.Location = New Point(20, 355)
        bLogOut.Name = "bLogOut"
        bLogOut.Size = New Size(245, 51)
        bLogOut.TabIndex = 16
        bLogOut.Text = "Log Out"
        bLogOut.UseVisualStyleBackColor = True
        ' 
        ' bAngsuranAnggota
        ' 
        bAngsuranAnggota.Location = New Point(20, 284)
        bAngsuranAnggota.Name = "bAngsuranAnggota"
        bAngsuranAnggota.Size = New Size(245, 51)
        bAngsuranAnggota.TabIndex = 15
        bAngsuranAnggota.Text = "Angsuran Anggota"
        bAngsuranAnggota.UseVisualStyleBackColor = True
        ' 
        ' bPinjamanAnggota
        ' 
        bPinjamanAnggota.Location = New Point(20, 212)
        bPinjamanAnggota.Name = "bPinjamanAnggota"
        bPinjamanAnggota.Size = New Size(245, 51)
        bPinjamanAnggota.TabIndex = 14
        bPinjamanAnggota.Text = "Pinjaman Anggota"
        bPinjamanAnggota.UseVisualStyleBackColor = True
        ' 
        ' bSimpananAnggota
        ' 
        bSimpananAnggota.Location = New Point(20, 139)
        bSimpananAnggota.Name = "bSimpananAnggota"
        bSimpananAnggota.Size = New Size(245, 51)
        bSimpananAnggota.TabIndex = 13
        bSimpananAnggota.Text = "Simpanan Anggota"
        bSimpananAnggota.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(90, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 34)
        Label1.TabIndex = 12
        Label1.Text = "Menu"
        ' 
        ' bDataAnggota
        ' 
        bDataAnggota.Location = New Point(20, 67)
        bDataAnggota.Name = "bDataAnggota"
        bDataAnggota.Size = New Size(245, 51)
        bDataAnggota.TabIndex = 0
        bDataAnggota.Text = "Data Anggota"
        bDataAnggota.UseVisualStyleBackColor = True
        ' 
        ' lTitle
        ' 
        lTitle.AutoSize = True
        lTitle.Font = New Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lTitle.Location = New Point(374, 35)
        lTitle.Name = "lTitle"
        lTitle.Size = New Size(369, 34)
        lTitle.TabIndex = 11
        lTitle.Text = "Dashboard KoperasiKu"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(lTanggal)
        Panel2.Controls.Add(lAnggota)
        Panel2.Controls.Add(lJumlah)
        Panel2.Controls.Add(lJenis)
        Panel2.Location = New Point(358, 174)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(683, 274)
        Panel2.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Lucida Sans", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(292, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 34)
        Label2.TabIndex = 17
        Label2.Text = "Summary"
        ' 
        ' lTanggal
        ' 
        lTanggal.AutoSize = True
        lTanggal.Font = New Font("Lucida Sans", 13.8F)
        lTanggal.Location = New Point(36, 172)
        lTanggal.Name = "lTanggal"
        lTanggal.Size = New Size(186, 26)
        lTanggal.TabIndex = 15
        lTanggal.Text = "Pinjaman Aktif:"
        ' 
        ' lAnggota
        ' 
        lAnggota.AutoSize = True
        lAnggota.Font = New Font("Lucida Sans", 13.8F)
        lAnggota.Location = New Point(42, 82)
        lAnggota.Name = "lAnggota"
        lAnggota.Size = New Size(180, 26)
        lAnggota.TabIndex = 13
        lAnggota.Text = "Total Anggota:"
        ' 
        ' lJumlah
        ' 
        lJumlah.AutoSize = True
        lJumlah.Font = New Font("Lucida Sans", 13.8F)
        lJumlah.Location = New Point(32, 221)
        lJumlah.Name = "lJumlah"
        lJumlah.Size = New Size(190, 26)
        lJumlah.TabIndex = 16
        lJumlah.Text = "Total Pinjaman:"
        ' 
        ' lJenis
        ' 
        lJenis.AutoSize = True
        lJenis.Font = New Font("Lucida Sans", 13.8F)
        lJenis.Location = New Point(25, 128)
        lJenis.Name = "lJenis"
        lJenis.Size = New Size(197, 26)
        lJenis.TabIndex = 14
        lJenis.Text = "Total Simpanan:"
        ' 
        ' FormDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1102, 673)
        Controls.Add(Panel2)
        Controls.Add(lTitle)
        Controls.Add(Panel1)
        Name = "FormDashboard"
        Text = "FormDashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bSimpananAnggota As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents bDataAnggota As Button
    Friend WithEvents lTitle As Label
    Friend WithEvents bLogOut As Button
    Friend WithEvents bAngsuranAnggota As Button
    Friend WithEvents bPinjamanAnggota As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lTanggal As Label
    Friend WithEvents lAnggota As Label
    Friend WithEvents lJumlah As Label
    Friend WithEvents lJenis As Label
End Class
