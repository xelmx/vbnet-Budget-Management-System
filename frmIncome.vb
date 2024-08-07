Imports System.IO
Imports MySql.Data.MySqlClient


Public Class frmIncome


    Private Sub frmIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()

    End Sub

    Private Sub btnSaveIncome_Click(sender As Object, e As EventArgs) Handles btnSaveIncome.Click


        If txtIncomeAmount.TextLength < 1 OrElse Not Decimal.TryParse(txtIncomeAmount.Text, Nothing) Then
            MsgBox("Input a valid Monthly Income Amount!", vbExclamation)
            txtIncomeAmount.Clear()
            txtIncomeAmount.Focus()
            Return
        Else
            cmd = New MySqlCommand("SELECT * FROM `tblincome` WHERE `month`=@month", conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                MsgBox("Already " & Date.Now.ToString("MMMM-yyyy") & " Monthly Income Amount Update!", vbExclamation)
            Else
                Try
                    OpenConnection()
                    cmd = New MySqlCommand("INSERT INTO `tblincome`(`month`, `monthyear`, `amount`) VALUES (@month,@monthyear,@amount)", conn)
                    cmd.Parameters.Clear()
                    cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))
                    cmd.Parameters.AddWithValue("@monthyear", Date.Now.ToString("MMMM-yyyy"))
                    cmd.Parameters.AddWithValue("@amount", CDec(txtIncomeAmount.Text))

                    i = cmd.ExecuteNonQuery
                    If i > 0 Then
                        MsgBox("Income Save Successfully!" & vbNewLine & "Current Month: " & Date.Now.ToString("MMMM-yyyy"), vbInformation)
                    Else
                        MsgBox("Income Save Failed!", vbExclamation)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                End Try
            End If
        End If
        txtIncomeAmount.Clear()
        CloseConnection()

        'use to update the dashboard when clicking the save button
        With frmmainPage
            .TotalIncome()
            .TotalExpense()
            .TodayExpense()
            .AccBalance()
        End With
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Prompt the user with a Yes/No/Cancel dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update your current income?", "Confirm Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked Yes, proceed with the update
            If txtIncomeAmount.TextLength < 1 OrElse Not Decimal.TryParse(txtIncomeAmount.Text, Nothing) Then
                MsgBox("Input a valid Monthly Income Amount!", vbExclamation)
                txtIncomeAmount.Clear()
                txtIncomeAmount.Focus()
                Return
            Else
                cmd = New MySqlCommand("SELECT * FROM `tblincome` WHERE `month`=@month", conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))
                da = New MySqlDataAdapter
                dt = New DataTable
                da.SelectCommand = cmd
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    Try
                        OpenConnection()
                        cmd = New MySqlCommand("UPDATE `tblincome` SET `amount`=@amount WHERE `month`=@month", conn)
                        cmd.Parameters.Clear()
                        cmd.Parameters.AddWithValue("@amount", CDec(txtIncomeAmount.Text))
                        cmd.Parameters.AddWithValue("@month", Date.Now.ToString("MM"))

                        i = cmd.ExecuteNonQuery
                        If i > 0 Then
                            MsgBox("Monthly Income Amount Updated Successfully!" & vbNewLine & "Current Month: " & Date.Now.ToString("MMMM-yyyy"), vbInformation)
                        Else
                            MsgBox("Income Update Failed!", vbExclamation)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    Finally
                        CloseConnection()
                    End Try
                End If
            End If
            txtIncomeAmount.Clear()
            CloseConnection()

            ' Use to update the dashboard when clicking the save button
            With frmmainPage
                .TotalIncome()
                .TotalExpense()
                .TodayExpense()
                .AccBalance()
            End With
        ElseIf result = DialogResult.No Then
            ' User clicked No, do nothing
            txtIncomeAmount.Clear()
        Else
            ' User clicked Cancel, do nothing or handle accordingly
        End If
    End Sub


End Class