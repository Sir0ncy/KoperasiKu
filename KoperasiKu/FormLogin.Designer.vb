<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        lUser = New Label()
        lPassword = New Label()
        bLogin = New Button()
        bExit = New Button()
        label1 = New Label()
        panel1 = New Panel()
        label2 = New Label()
        panel2 = New Panel()
        panel1.SuspendLayout()
        panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(95, 130)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(333, 22)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(95, 169)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(333, 22)
        txtPassword.TabIndex = 1
        ' 
        ' lUser
        ' 
        lUser.AutoSize = True
        lUser.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lUser.Location = New Point(14, 133)
        lUser.Name = "lUser"
        lUser.Size = New Size(64, 15)
        lUser.TabIndex = 2
        lUser.Text = "Username"
        ' 
        ' lPassword
        ' 
        lPassword.AutoSize = True
        lPassword.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lPassword.Location = New Point(17, 172)
        lPassword.Name = "lPassword"
        lPassword.Size = New Size(63, 15)
        lPassword.TabIndex = 3
        lPassword.Text = "Password"
        ' 
        ' bLogin
        ' 
        bLogin.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bLogin.Location = New Point(95, 219)
        bLogin.Name = "bLogin"
        bLogin.Size = New Size(154, 45)
        bLogin.TabIndex = 4
        bLogin.Text = "LOGIN"
        bLogin.UseVisualStyleBackColor = True
        ' 
        ' bExit
        ' 
        bExit.Font = New Font("Lucida Sans", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bExit.Location = New Point(274, 219)
        bExit.Name = "bExit"
        bExit.Size = New Size(154, 45)
        bExit.TabIndex = 5
        bExit.Text = "EXIT"
        bExit.UseVisualStyleBackColor = True
        ' 
        ' label1
        ' 
        label1.AutoSize = True
        label1.Font = New Font("Lucida Sans", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label1.Location = New Point(117, 40)
        label1.Name = "label1"
        label1.Size = New Size(226, 33)
        label1.TabIndex = 6
        label1.Text = "LOGIN ADMIN"
        ' 
        ' panel1
        ' 
        panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        panel1.BackColor = SystemColors.Control
        panel1.Controls.Add(label1)
        panel1.Controls.Add(txtUsername)
        panel1.Controls.Add(bExit)
        panel1.Controls.Add(txtPassword)
        panel1.Controls.Add(bLogin)
        panel1.Controls.Add(lUser)
        panel1.Controls.Add(lPassword)
        panel1.Location = New Point(253, 145)
        panel1.Name = "panel1"
        panel1.Size = New Size(459, 314)
        panel1.TabIndex = 7
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Font = New Font("Lucida Sans", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label2.Location = New Point(349, 26)
        label2.Name = "label2"
        label2.Size = New Size(254, 45)
        label2.TabIndex = 7
        label2.Text = "KoperasiKu"
        ' 
        ' panel2
        ' 
        panel2.BackColor = SystemColors.Control
        panel2.Controls.Add(label2)
        panel2.Location = New Point(-1, 0)
        panel2.Name = "panel2"
        panel2.Size = New Size(1109, 94)
        panel2.TabIndex = 8
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(964, 505)
        Controls.Add(panel2)
        Controls.Add(panel1)
        Name = "FormLogin"
        Text = "FormLogin"
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        panel2.ResumeLayout(False)
        panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lUser As Label
    Friend WithEvents lPassword As Label
    Friend WithEvents bLogin As Button
    Friend WithEvents bExit As Button
    Friend WithEvents label1 As Label
    Friend WithEvents panel1 As Panel
    Friend WithEvents label2 As Label
    Friend WithEvents panel2 As Panel
End Class
