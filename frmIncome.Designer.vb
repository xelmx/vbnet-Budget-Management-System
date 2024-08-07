<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncome
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
        Me.txtIncomeAmount = New System.Windows.Forms.MaskedTextBox()
        Me.btnSaveIncome = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtIncomeAmount
        '
        Me.txtIncomeAmount.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncomeAmount.Location = New System.Drawing.Point(69, 59)
        Me.txtIncomeAmount.Name = "txtIncomeAmount"
        Me.txtIncomeAmount.Size = New System.Drawing.Size(238, 37)
        Me.txtIncomeAmount.TabIndex = 1
        '
        'btnSaveIncome
        '
        Me.btnSaveIncome.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSaveIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnSaveIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveIncome.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveIncome.ForeColor = System.Drawing.Color.White
        Me.btnSaveIncome.Location = New System.Drawing.Point(69, 95)
        Me.btnSaveIncome.Name = "btnSaveIncome"
        Me.btnSaveIncome.Size = New System.Drawing.Size(238, 46)
        Me.btnSaveIncome.TabIndex = 2
        Me.btnSaveIncome.Text = "Save"
        Me.btnSaveIncome.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(326, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter or Update Your Income Amount"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(69, 147)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(238, 46)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'frmIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(386, 212)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveIncome)
        Me.Controls.Add(Me.txtIncomeAmount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmIncome"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Income"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIncomeAmount As MaskedTextBox
    Friend WithEvents btnSaveIncome As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdate As Button
End Class
