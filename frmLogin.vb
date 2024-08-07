Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmlogin

    Dim strName As String
    Dim strUsername As String
    Dim strPassword As String
    Dim strRole As String

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure want to Exit?", vbExclamation + vbYesNo) = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            conn.Open()
            Dim found As Boolean = False '
            cmd = New MySqlCommand("SELECT `name`, `userName`, `password`, `role` FROM `tbluser` WHERE userName like '" & txtUserName.Text & "' and password like '" & txtPassword.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                found = True
                strName = dr.Item("name").ToString
                strUsername = dr.Item("username").ToString
                strPassword = dr.Item("password").ToString
                strRole = dr.Item("role").ToString
            Else
                found = False
                strName = ""
                strUsername = ""
                strPassword = ""
                strRole = ""

            End If

            If found = True Then
                If StrComp(txtUserName.Text, strUsername, CompareMethod.Binary) Or StrComp(txtPassword.Text, strPassword, CompareMethod.Binary) Then
                    MsgBox("Wrong Username or Password", vbExclamation)
                Else
                    txtUserName.Clear()
                    txtPassword.Clear()
                    If UCase(strRole) = "ADMIN" Then
                        Me.Hide()
                        frmmainPage.Show()
                        frmmainPage.lblLoginInfo.Text = "Login User: " & strName & " Login Time: " & Date.Now.ToString("hh:mm:ss tt")

                    End If
                End If
            Else
                MsgBox("Wrong Username or Password", vbExclamation)
                txtUserName.Clear()
                txtPassword.Clear()

                txtUserName.Focus()
            End If

            txtUserName.Clear()
            txtUserName.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()


    End Sub
End Class
