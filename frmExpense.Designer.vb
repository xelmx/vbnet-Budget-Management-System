<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpense
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtpDateExpense = New System.Windows.Forms.DateTimePicker()
        Me.cboCategoryExpense = New System.Windows.Forms.ComboBox()
        Me.txtAmountExpense = New System.Windows.Forms.TextBox()
        Me.txtRemarksExpense = New System.Windows.Forms.TextBox()
        Me.btnSaveExpense = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCategory = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpDateExpense
        '
        Me.dtpDateExpense.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDateExpense.Location = New System.Drawing.Point(64, 48)
        Me.dtpDateExpense.Name = "dtpDateExpense"
        Me.dtpDateExpense.Size = New System.Drawing.Size(207, 25)
        Me.dtpDateExpense.TabIndex = 0
        '
        'cboCategoryExpense
        '
        Me.cboCategoryExpense.FormattingEnabled = True
        Me.cboCategoryExpense.Location = New System.Drawing.Point(64, 107)
        Me.cboCategoryExpense.Name = "cboCategoryExpense"
        Me.cboCategoryExpense.Size = New System.Drawing.Size(158, 25)
        Me.cboCategoryExpense.TabIndex = 1
        Me.cboCategoryExpense.Text = "Select a Category"
        '
        'txtAmountExpense
        '
        Me.txtAmountExpense.Location = New System.Drawing.Point(64, 166)
        Me.txtAmountExpense.Name = "txtAmountExpense"
        Me.txtAmountExpense.Size = New System.Drawing.Size(207, 25)
        Me.txtAmountExpense.TabIndex = 2
        '
        'txtRemarksExpense
        '
        Me.txtRemarksExpense.Location = New System.Drawing.Point(64, 238)
        Me.txtRemarksExpense.Multiline = True
        Me.txtRemarksExpense.Name = "txtRemarksExpense"
        Me.txtRemarksExpense.Size = New System.Drawing.Size(207, 86)
        Me.txtRemarksExpense.TabIndex = 3
        '
        'btnSaveExpense
        '
        Me.btnSaveExpense.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSaveExpense.FlatAppearance.BorderSize = 0
        Me.btnSaveExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnSaveExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveExpense.ForeColor = System.Drawing.Color.White
        Me.btnSaveExpense.Location = New System.Drawing.Point(64, 344)
        Me.btnSaveExpense.Name = "btnSaveExpense"
        Me.btnSaveExpense.Size = New System.Drawing.Size(207, 46)
        Me.btnSaveExpense.TabIndex = 4
        Me.btnSaveExpense.Text = "Save"
        Me.btnSaveExpense.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Category"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Amount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 17)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Additional Details / Remarks"
        '
        'btnCategory
        '
        Me.btnCategory.BackColor = System.Drawing.Color.DarkBlue
        Me.btnCategory.FlatAppearance.BorderSize = 0
        Me.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategory.ForeColor = System.Drawing.Color.White
        Me.btnCategory.Location = New System.Drawing.Point(228, 106)
        Me.btnCategory.Name = "btnCategory"
        Me.btnCategory.Size = New System.Drawing.Size(43, 25)
        Me.btnCategory.TabIndex = 10
        Me.btnCategory.Text = "+"
        Me.btnCategory.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(64, 395)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(207, 43)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmExpense
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(328, 466)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCategory)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSaveExpense)
        Me.Controls.Add(Me.txtRemarksExpense)
        Me.Controls.Add(Me.txtAmountExpense)
        Me.Controls.Add(Me.cboCategoryExpense)
        Me.Controls.Add(Me.dtpDateExpense)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmExpense"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expense"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDateExpense As DateTimePicker
    Friend WithEvents cboCategoryExpense As ComboBox
    Friend WithEvents txtAmountExpense As TextBox
    Friend WithEvents txtRemarksExpense As TextBox
    Friend WithEvents btnSaveExpense As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCategory As Button
    Friend WithEvents btnClear As Button
End Class
