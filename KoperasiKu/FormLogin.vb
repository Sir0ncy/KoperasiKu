Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class FormLogin

    Dim Conn As MySqlConnection = MySQLCon.conn
    Dim Cmd As MySqlCommand
    Dim Rd As MySqlDataReader

    Sub login()
        If txtUsername.Text.Trim() = "" Or txtPassword.Text.Trim() = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            MySQLCon.Connect()

            Dim query As String =
                "SELECT * FROM user WHERE username=@username AND password=@password"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
            Cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

            Rd = Cmd.ExecuteReader()

            If Rd.Read() Then
                MsgBox("Login Berhasil!", MsgBoxStyle.Information)


                Me.Hide()
                FormDashboard.Show()
            Else
                MsgBox("Username atau Password salah!", MsgBoxStyle.Critical)
            End If



        Catch ex As Exception
            MsgBox("Error login: " & ex.Message)

        Finally
            If Rd IsNot Nothing AndAlso Not Rd.IsClosed Then Rd.Close()

            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then Conn.Close()
        End Try
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        login()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            login()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsername.Clear()
        txtPassword.Clear()
    End Sub


    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click

        If MsgBox("Apakah Anda yakin ingin keluar dari program?", vbYesNo + vbQuestion, "Konfirmasi Keluar") = vbYes Then
            Application.Exit()
        End If
    End Sub

End Class