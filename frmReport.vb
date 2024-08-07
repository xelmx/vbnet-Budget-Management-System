Imports System.IO
Imports MySql.Data.MySqlClient


Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

        DataGridView1.RowTemplate.Height = 30

        'Expense Page Report
        Expense_Load()
        Expense_Load_MonthYear()
        Expense_Total()


        'Income Page Report
        Income_Load()
        IncomeMonthYear_Load()
        Income_Total()

    End Sub

    Public Sub Expense_Load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `ydate`, `month`, `monthyear`, `category`, `amount`, `remarks` FROM `tblexpense`", conn)
            dr = cmd.ExecuteReader

            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ydate"), dr.Item("month").ToString, dr.Item("monthyear").ToString, dr.Item("category").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
            End While



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Expense_Total()

    End Sub



    Private Sub txtSearchCategory_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCategory.TextChanged

        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `ydate`, `month`, `monthyear`, `category`, `amount`, `remarks` FROM `tblexpense` WHERE category like '%" & txtSearchCategory.Text & "%'", conn)
            dr = cmd.ExecuteReader

            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ydate"), dr.Item("month").ToString, dr.Item("monthyear").ToString, dr.Item("category").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
            End While



        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Expense_Total()
    End Sub

    Public Sub Expense_Load_MonthYear()

        cboFilterExpenseMonthYear.Items.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM `tblexpense` group by monthyear", conn)
            dr = cmd.ExecuteReader

            While dr.Read = True
                cboFilterExpenseMonthYear.Items.Add(dr.Item("monthyear").ToString)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub btnExpenseFilter_Click(sender As Object, e As EventArgs) Handles btnExpenseFilter.Click

        Dim date1 As String = dtpFirst.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = dtpSecond.Value.ToString("yyyy-MM-dd")

        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `ydate`, `month`, `monthyear`, `category`, `amount`, `remarks` FROM `tblexpense` WHERE ydate BETWEEN '" & date1 & "' AND '" & date2 & "' ", conn)
            dr = cmd.ExecuteReader

            While dr.Read = True
                DataGridView1.Rows.Add(DataGridView1.Rows.Count + 1, dr.Item("ydate"), dr.Item("month").ToString, dr.Item("monthyear").ToString, dr.Item("category").ToString, dr.Item("amount").ToString, dr.Item("remarks").ToString)
            End While



        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()
        End Try


        Expense_Total()

    End Sub

    Sub Expense_Total()
        Dim sum As Double = 0
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            sum = sum + DataGridView1.Rows(i).Cells(5).Value
        Next

        lblTotalExpense.Text = Format(sum, "#,##0.00")

    End Sub

    Private Sub btnExitReport_Click(sender As Object, e As EventArgs) Handles btnExitReport.Click
        Me.Close()
        frmmainPage.Show()
    End Sub

    Public Sub Income_Load()
        DataGridView2.Rows.Clear()
        Try

            conn.Open()
            cmd = New MySqlCommand("SELECT `month`, `monthyear`, `amount` FROM `tblincome`", conn)
            dr = cmd.ExecuteReader

            While dr.Read = True
                DataGridView2.Rows.Add(DataGridView2.Rows.Count + 1, dr.Item("month").ToString, dr.Item("monthyear").ToString, dr.Item("amount").ToString)

            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()
        End Try
        Income_Total()

    End Sub

    Public Sub IncomeMonthYear_Load()

        cboFilterIncomeMonthYear.Items.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `month`, `monthyear`, `amount` FROM `tblincome` group by monthyear", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cboFilterIncomeMonthYear.Items.Add(dr.Item("monthyear").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            conn.Close()
        End Try

        Income_Total()
    End Sub

    Private Sub cboFilterIncomeMonthYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterIncomeMonthYear.SelectedIndexChanged

        cboFilterIncomeMonthYear.Items.Clear()
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT `month`, `monthyear`, `amount` FROM `tblincome` WHERE monthyear like '%" & cboFilterIncomeMonthYear.Text & "%' group by monthyear", conn)
            dr = cmd.ExecuteReader

            While dr.Read
                cboFilterIncomeMonthYear.Items.Add(dr.Item("monthyear").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Income_Total()
    End Sub


    Sub Income_Total()

        Dim sum As Double = 0
        For i As Integer = 0 To DataGridView2.Rows.Count() - 1 Step +1
            sum = sum + DataGridView2.Rows(i).Cells(3).Value
        Next

        lblIncomeTotal.Text = Format(sum, "#,##0.00")

    End Sub
End Class