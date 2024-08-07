Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmmainPage

    Private Sub frmmainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        TotalIncome()
        TotalExpense()
        TodayExpense()
        AccBalance()



        lblMonthYearTotalIncome.Text = Date.Now.ToString("MMMM-yyyy")
        lblMonthYearTotalExpense.Text = Date.Now.ToString("MMMM-yyyy")
        lblMonthYearTodayExpense.Text = Date.Now.ToString("D")
        lblMonthYearAccBalance.Text = Date.Now.ToString("MMMM-yyyy")



    End Sub

    Private Sub btnIncome_Click(sender As Object, e As EventArgs) Handles btnIncome.Click
        frmIncome.ShowDialog()
    End Sub

    Private Sub btnExpense_Click(sender As Object, e As EventArgs) Handles btnExpense.Click
        frmExpense.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        frmlogin.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        frmReport.ShowDialog()
    End Sub


    Public Sub TotalIncome()
        CloseConnection()
        Try
            OpenConnection()
            cmd = New MySqlCommand("SELECT SUM(amount) FROM `tblincome` WHERE `month`=@month", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))

            If cmd.ExecuteScalar() IsNot DBNull.Value Then
                'is not DBNull, so it's safe to convert to Integer
                lblMainTotalIncome.Text = CDec(cmd.ExecuteScalar()).ToString("N2")
            Else
                'is DBNull
                lblMainTotalIncome.Text = "0.00"
            End If
        Catch ex As Exception
            MsgBox("Error executing command: " & ex.Message & vbCrLf & "Command: " & cmd.CommandText)
        Finally
            CloseConnection()
        End Try
    End Sub

    Public Sub TotalExpense()

        Try
            OpenConnection()
            cmd = New MySqlCommand("SELECT SUM(amount) FROM `tblexpense` WHERE `month`=@month", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))
            If cmd.ExecuteScalar() IsNot DBNull.Value Then
                'is not DBNull, so it's safe to convert to Integer
                lblMainTotalExpense.Text = CDec(cmd.ExecuteScalar()).ToString("N2")
            Else
                'is DBNull
                lblMainTotalExpense.Text = "0.00"
            End If

        Catch ex As Exception
            MsgBox("Error executing command: " & ex.Message & vbCrLf & "Command: " & cmd.CommandText)
        Finally
            CloseConnection()
        End Try
    End Sub

    Public Sub TodayExpense()


        Try
            OpenConnection()
            cmd = New MySqlCommand("SELECT SUM(amount) FROM `tblexpense` WHERE `ydate`=@ydate", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ydate", Date.Now.ToString("yyyy/MM/dd"))

            If cmd.ExecuteScalar() IsNot DBNull.Value Then
                'is not DBNull, so it's safe to convert to Integer
                lblMainTodayExpense.Text = CDec(cmd.ExecuteScalar()).ToString("N2")
            Else
                'is DBNull
                lblMainTodayExpense.Text = "0.00"
            End If

        Catch ex As Exception
            MsgBox("Error executing command: " & ex.Message & vbCrLf & "Command: " & cmd.CommandText)
        Finally
            CloseConnection()
        End Try
    End Sub


    Public Sub AccBalance()
        Try
            Dim accountBalance As Decimal = CDec(lblMainTotalIncome.Text) - CDec(lblMainTotalExpense.Text)
            lblMainAccountBalance.Text = accountBalance.ToString("N2")
        Catch ex As Exception
            MsgBox("Error executing command: " & ex.Message & vbCrLf & "Command: " & cmd.CommandText)
            'MsgBox("Enter your Monthly Income First!", vbExclamation)
        End Try
    End Sub

    Private Sub MainTimer1_Tick(sender As Object, e As EventArgs) Handles MainTimer1.Tick
        AccBalance()
    End Sub

    Private Sub MainTimer2_Tick(sender As Object, e As EventArgs) Handles MainTimer2.Tick
        lblHourTime.Text = Date.Now.ToString("hh:mm:ss tt")
        lblDate.Text = Date.Now.ToString("dd-MMMM-yyyy dddd")
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class