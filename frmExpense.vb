Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmExpense
    Private Sub frmExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
        cboCategoryExpenseLoad()
    End Sub

    Private Sub btnCategory_Click(sender As Object, e As EventArgs) Handles btnCategory.Click
        frmAddCategory.ShowDialog()
    End Sub

    Public Sub cboCategoryExpenseLoad()

        cboCategoryExpense.Items.Clear()
        Try
            OpenConnection()
            cmd = New MySqlCommand("SELECT * FROM `tblcategory`", conn)
            dr = cmd.ExecuteReader
            While dr.Read = True
                cboCategoryExpense.Items.Add(dr.Item("category").ToString)
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseConnection()
        End Try


    End Sub

    Public Sub Clear()
        txtAmountExpense.Clear()
        txtRemarksExpense.Clear()
        dtpDateExpense.ResetText()
        cboCategoryExpense.SelectedIndex = -1
    End Sub
    Private Sub btnSaveExpense_Click(sender As Object, e As EventArgs) Handles btnSaveExpense.Click

        ' Validate if txtAmountExpense.Text is not empty and is a valid number
        If String.IsNullOrWhiteSpace(txtAmountExpense.Text) OrElse Not Decimal.TryParse(txtAmountExpense.Text, Nothing) Then
            MsgBox("Please enter a valid amount.", vbExclamation)
            Return ' Exit the method if validation fails
        End If

        Try
            OpenConnection()
            cmd = New MySqlCommand("INSERT INTO `tblexpense`(`ydate`, `month`, `monthyear`, `category`, `amount`, `remarks`) VALUES (@ydate, @month, @monthyear, @category, @amount, @remarks)", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@ydate", CDate(dtpDateExpense.Text))
            cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))
            cmd.Parameters.AddWithValue("monthyear", Date.Now.ToString("MMMM-yyyy"))
            cmd.Parameters.AddWithValue("@category", cboCategoryExpense.Text)
            cmd.Parameters.AddWithValue("@amount", CDec(txtAmountExpense.Text))
            cmd.Parameters.AddWithValue("@remarks", txtRemarksExpense.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Expense Saved Successfully!", vbInformation)
            Else
                MsgBox("Expense Save Failed!", vbInformation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseConnection()
        End Try


        Clear()
        'use to update the dashboard when clicking the save button
        With frmmainPage
            .TotalIncome()
            .TotalExpense()
            .TodayExpense()
            .AccBalance()
        End With

    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Clear()
    End Sub

End Class