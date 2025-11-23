Imports System.Security.Policy
Imports MySql.Data.MySqlClient
Module MySQLCon
    Dim creds As String = "server=172.19.158.154; database=koperasi; userid=root; password=''"
    Public conn As New MySqlConnection(creds)
    Public da As MySqlDataAdapter = Nothing
    Public cmd As MySqlCommand = Nothing
    Public dt As New DataTable
    Public dr As MySqlDataReader

    Public find As Boolean = False

    Public Sub Connect()
        Try
            conn.Open()
            ''MsgBox("Conn Success (DB)")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
