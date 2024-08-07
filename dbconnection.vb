Imports MySql.Data.MySqlClient
Imports System.IO

Module dbconnection

    Public Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
    Public Sub OpenConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub


    Public conn As New MySqlConnection
    Dim result As Boolean
    Public cmd As New MySqlCommand
    Public da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable
    Public i As Integer

    Public Function dbconn() As Boolean
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;user=root;password=;port=3306;database=dbbudgetsys"
                result = True
            End If

        Catch ex As Exception
            result = False
            MsgBox("Server Connection Lost !", vbExclamation)
        End Try

        Return result
    End Function


End Module
