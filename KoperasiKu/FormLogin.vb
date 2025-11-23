Imports MySql.Data.MySqlClient

Public Class FormLogin

    Dim Conn As MySqlConnection = MySQLCon.conn
    Dim Cmd As MySqlCommand
    Dim Rd As MySqlDataReader

    Sub login()
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Connect()

            Dim query As String =
                "SELECT * FROM user WHERE username=@username AND password=@password"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            Cmd.Parameters.AddWithValue("@password", txtPassword.Text)

            Rd = Cmd.ExecuteReader()

            If Rd.Read() Then
                MsgBox("Login Berhasil!", MsgBoxStyle.Information)
                Conn.Close()
                Me.Hide()
                FormDashboard.Show()
            Else
                MsgBox("Username atau Password salah!", MsgBoxStyle.Critical)
                Conn.Close()
            End If
            Conn.Close()
        Catch ex As Exception
            MsgBox("Error login: " & ex.Message)

        Finally
            If Rd IsNot Nothing Then Rd.Close()
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
End Class
