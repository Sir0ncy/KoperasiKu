<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        TextBoxJabatan = New TextBox()
        TextBoxNama = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        TextBoxGaji = New TextBox()
        Label3 = New Label()
        ButtonHitung = New Button()
        ListDaftarPegawai = New ListBox()
        SuspendLayout()
        ' 
        ' TextBoxJabatan
        ' 
        TextBoxJabatan.Location = New Point(229, 96)
        TextBoxJabatan.Name = "TextBoxJabatan"
        TextBoxJabatan.Size = New Size(183, 27)
        TextBoxJabatan.TabIndex = 7
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(229, 39)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(183, 27)
        TextBoxNama.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 20)
        Label2.TabIndex = 5
        Label2.Text = "Jabatan"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(46, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 20)
        Label1.TabIndex = 4
        Label1.Text = "Nama Pegawai"
        ' 
        ' TextBoxGaji
        ' 
        TextBoxGaji.Location = New Point(229, 154)
        TextBoxGaji.Name = "TextBoxGaji"
        TextBoxGaji.Size = New Size(183, 27)
        TextBoxGaji.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 8
        Label3.Text = "Gaji Pokok"
        ' 
        ' ButtonHitung
        ' 
        ButtonHitung.Location = New Point(187, 211)
        ButtonHitung.Name = "ButtonHitung"
        ButtonHitung.Size = New Size(94, 29)
        ButtonHitung.TabIndex = 10
        ButtonHitung.Text = "Hitung Gaji"
        ButtonHitung.UseVisualStyleBackColor = True
        ' 
        ' ListDaftarPegawai
        ' 
        ListDaftarPegawai.FormattingEnabled = True
        ListDaftarPegawai.Location = New Point(46, 262)
        ListDaftarPegawai.Name = "ListDaftarPegawai"
        ListDaftarPegawai.Size = New Size(382, 164)
        ListDaftarPegawai.TabIndex = 11
        ListDaftarPegawai.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1102, 673)
        Controls.Add(ListDaftarPegawai)
        Controls.Add(ButtonHitung)
        Controls.Add(TextBoxGaji)
        Controls.Add(Label3)
        Controls.Add(TextBoxJabatan)
        Controls.Add(TextBoxNama)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Nomer2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxJabatan As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxGaji As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonHitung As Button
    Friend WithEvents ListDaftarPegawai As ListBox

End Class
