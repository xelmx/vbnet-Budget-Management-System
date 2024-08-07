<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCategory
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
        Me.btnSaveCategory = New System.Windows.Forms.Button()
        Me.txtCategoryName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSaveCategory
        '
        Me.btnSaveCategory.BackColor = System.Drawing.Color.DarkBlue
        Me.btnSaveCategory.FlatAppearance.BorderSize = 0
        Me.btnSaveCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.btnSaveCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCategory.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveCategory.ForeColor = System.Drawing.Color.White
        Me.btnSaveCategory.Location = New System.Drawing.Point(27, 83)
        Me.btnSaveCategory.Name = "btnSaveCategory"
        Me.btnSaveCategory.Size = New System.Drawing.Size(246, 38)
        Me.btnSaveCategory.TabIndex = 6
        Me.btnSaveCategory.Text = "Save"
        Me.btnSaveCategory.UseVisualStyleBackColor = False
        '
        'txtCategoryName
        '
        Me.txtCategoryName.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategoryName.Location = New System.Drawing.Point(27, 45)
        Me.txtCategoryName.Name = "txtCategoryName"
        Me.txtCategoryName.Size = New System.Drawing.Size(246, 25)
        Me.txtCategoryName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Enter Category Name"
        '
        'frmAddCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(292, 142)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSaveCategory)
        Me.Controls.Add(Me.txtCategoryName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmAddCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveCategory As Button
    Friend WithEvents txtCategoryName As TextBox
    Friend WithEvents Label3 As Label
End Class
