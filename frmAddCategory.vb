Imports System.IO
Imports MySql.Data.MySqlClient

Public Class frmAddCategory
    Private Sub frmAddCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Private Sub btnSaveCategory_Click(sender As Object, e As EventArgs) Handles btnSaveCategory.Click
        Try
            OpenConnection()
            cmd = New MySqlCommand("INSERT INTO `tblcategory`(`category`) VALUES (@category)", conn)
            cmd.Parameters.AddWithValue("@category", txtCategoryName.Text)

            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New Category Saved!", vbInformation)
            Else
                MsgBox("Category Save Failed!", vbInformation)
            End If

            txtCategoryName.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            CloseConnection()
        End Try

        frmExpense.cboCategoryExpenseLoad()
    End Sub
End Class