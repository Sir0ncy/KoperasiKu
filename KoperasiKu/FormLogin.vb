Imports MySql.Data.MySqlClient

Public Class FormLogin

    Dim Conn As MySqlConnection
    Dim Cmd As MySqlCommand
    Dim Rd As MySqlDataReader

    '=== KONEKSI DATABASE ==='
    Sub Koneksi()
        Try
            Conn = New MySqlConnection("server=localhost;user id=root;password=;database=koperasi")
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi gagal: " & ex.Message)
        End Try
    End Sub

    '=== LOGIN BUTTON ==='
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Try
            Koneksi()

            Dim query As String =
                "SELECT * FROM user WHERE username=@username AND password=@password"

            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            Cmd.Parameters.AddWithValue("@password", txtPassword.Text)

            Rd = Cmd.ExecuteReader()

            If Rd.Read() Then
                MsgBox("Login Berhasil!", MsgBoxStyle.Information)

                Me.Hide()
                FormDataAnggota.Show()   ' Buka form utama
            Else
                MsgBox("Username atau Password salah!", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Error login: " & ex.Message)

        Finally
            If Rd IsNot Nothing Then Rd.Close()
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then Conn.Close()
        End Try

    End Sub

End Class
