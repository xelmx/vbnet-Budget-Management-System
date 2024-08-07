<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmainPage
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmainPage))
        Me.pnlPanel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnExpense = New System.Windows.Forms.Button()
        Me.btnIncome = New System.Windows.Forms.Button()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblLoginInfo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblMainTotalIncome = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMonthYearTotalIncome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMainTotalExpense = New System.Windows.Forms.Label()
        Me.lblMonthYearTotalExpense = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblMainTodayExpense = New System.Windows.Forms.Label()
        Me.lblMonthYearTodayExpense = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblMainAccountBalance = New System.Windows.Forms.Label()
        Me.lblMonthYearAccBalance = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.MainTimer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblHourTime = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.MainTimer2 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPanel1
        '
        Me.pnlPanel1.BackColor = System.Drawing.Color.DarkBlue
        Me.pnlPanel1.Controls.Add(Me.PictureBox1)
        Me.pnlPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.pnlPanel1.Controls.Add(Me.lblLogo)
        Me.pnlPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlPanel1.Location = New System.Drawing.Point(0, 0)
        Me.pnlPanel1.Name = "pnlPanel1"
        Me.pnlPanel1.Size = New System.Drawing.Size(1200, 85)
        Me.pnlPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(29, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnLogout, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReport, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExpense, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnIncome, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(466, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(734, 82)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Transparent
        Me.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Transparent
        Me.btnLogout.Location = New System.Drawing.Point(552, 3)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(177, 76)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.Transparent
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.Transparent
        Me.btnReport.Location = New System.Drawing.Point(369, 3)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(177, 76)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnExpense
        '
        Me.btnExpense.BackColor = System.Drawing.Color.Transparent
        Me.btnExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExpense.FlatAppearance.BorderSize = 0
        Me.btnExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGoldenrod
        Me.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExpense.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpense.ForeColor = System.Drawing.Color.Transparent
        Me.btnExpense.Location = New System.Drawing.Point(186, 3)
        Me.btnExpense.Name = "btnExpense"
        Me.btnExpense.Size = New System.Drawing.Size(177, 76)
        Me.btnExpense.TabIndex = 2
        Me.btnExpense.Text = "Expense"
        Me.btnExpense.UseVisualStyleBackColor = False
        '
        'btnIncome
        '
        Me.btnIncome.BackColor = System.Drawing.Color.Transparent
        Me.btnIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnIncome.FlatAppearance.BorderSize = 0
        Me.btnIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncome.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncome.ForeColor = System.Drawing.Color.Transparent
        Me.btnIncome.Location = New System.Drawing.Point(3, 3)
        Me.btnIncome.Name = "btnIncome"
        Me.btnIncome.Size = New System.Drawing.Size(177, 76)
        Me.btnIncome.TabIndex = 1
        Me.btnIncome.Text = "Income"
        Me.btnIncome.UseVisualStyleBackColor = False
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.BackColor = System.Drawing.Color.Transparent
        Me.lblLogo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblLogo.Location = New System.Drawing.Point(65, 33)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(163, 21)
        Me.lblLogo.TabIndex = 3
        Me.lblLogo.Text = "udget Bridge Builder"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.lblLoginInfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 617)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 68)
        Me.Panel1.TabIndex = 1
        '
        'lblLoginInfo
        '
        Me.lblLoginInfo.AutoSize = True
        Me.lblLoginInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblLoginInfo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoginInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLoginInfo.Location = New System.Drawing.Point(23, 18)
        Me.lblLoginInfo.Name = "lblLoginInfo"
        Me.lblLoginInfo.Size = New System.Drawing.Size(228, 21)
        Me.lblLoginInfo.TabIndex = 4
        Me.lblLoginInfo.Text = "Expense Management System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel2.Controls.Add(Me.lblMainTotalIncome)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblMonthYearTotalIncome)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(27, 157)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(293, 150)
        Me.Panel2.TabIndex = 2
        '
        'lblMainTotalIncome
        '
        Me.lblMainTotalIncome.AutoSize = True
        Me.lblMainTotalIncome.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTotalIncome.Location = New System.Drawing.Point(51, 102)
        Me.lblMainTotalIncome.Name = "lblMainTotalIncome"
        Me.lblMainTotalIncome.Size = New System.Drawing.Size(41, 21)
        Me.lblMainTotalIncome.TabIndex = 5
        Me.lblMainTotalIncome.Text = "0.00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Php"
        '
        'lblMonthYearTotalIncome
        '
        Me.lblMonthYearTotalIncome.AutoSize = True
        Me.lblMonthYearTotalIncome.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthYearTotalIncome.Location = New System.Drawing.Point(26, 47)
        Me.lblMonthYearTotalIncome.Name = "lblMonthYearTotalIncome"
        Me.lblMonthYearTotalIncome.Size = New System.Drawing.Size(76, 17)
        Me.lblMonthYearTotalIncome.TabIndex = 4
        Me.lblMonthYearTotalIncome.Text = "Month-Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total Income"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Php"
        '
        'lblMainTotalExpense
        '
        Me.lblMainTotalExpense.AutoSize = True
        Me.lblMainTotalExpense.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTotalExpense.Location = New System.Drawing.Point(50, 102)
        Me.lblMainTotalExpense.Name = "lblMainTotalExpense"
        Me.lblMainTotalExpense.Size = New System.Drawing.Size(41, 21)
        Me.lblMainTotalExpense.TabIndex = 5
        Me.lblMainTotalExpense.Text = "0.00"
        '
        'lblMonthYearTotalExpense
        '
        Me.lblMonthYearTotalExpense.AutoSize = True
        Me.lblMonthYearTotalExpense.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthYearTotalExpense.Location = New System.Drawing.Point(26, 47)
        Me.lblMonthYearTotalExpense.Name = "lblMonthYearTotalExpense"
        Me.lblMonthYearTotalExpense.Size = New System.Drawing.Size(76, 17)
        Me.lblMonthYearTotalExpense.TabIndex = 4
        Me.lblMonthYearTotalExpense.Text = "Month-Year"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 21)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Total Expense"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Brown
        Me.Panel3.Controls.Add(Me.lblMainTotalExpense)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblMonthYearTotalExpense)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.ForeColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(353, 157)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(293, 150)
        Me.Panel3.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 21)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Php"
        '
        'lblMainTodayExpense
        '
        Me.lblMainTodayExpense.AutoSize = True
        Me.lblMainTodayExpense.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainTodayExpense.Location = New System.Drawing.Point(51, 102)
        Me.lblMainTodayExpense.Name = "lblMainTodayExpense"
        Me.lblMainTodayExpense.Size = New System.Drawing.Size(41, 21)
        Me.lblMainTodayExpense.TabIndex = 5
        Me.lblMainTodayExpense.Text = "0.00"
        '
        'lblMonthYearTodayExpense
        '
        Me.lblMonthYearTodayExpense.AutoSize = True
        Me.lblMonthYearTodayExpense.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthYearTodayExpense.Location = New System.Drawing.Point(26, 47)
        Me.lblMonthYearTodayExpense.Name = "lblMonthYearTodayExpense"
        Me.lblMonthYearTodayExpense.Size = New System.Drawing.Size(103, 17)
        Me.lblMonthYearTodayExpense.TabIndex = 4
        Me.lblMonthYearTodayExpense.Text = "Day-Month-Year"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 21)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Today Expense"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Peru
        Me.Panel5.Controls.Add(Me.lblMainTodayExpense)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.lblMonthYearTodayExpense)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(27, 340)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(293, 150)
        Me.Panel5.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(16, 102)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 21)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Php"
        '
        'lblMainAccountBalance
        '
        Me.lblMainAccountBalance.AutoSize = True
        Me.lblMainAccountBalance.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainAccountBalance.Location = New System.Drawing.Point(50, 102)
        Me.lblMainAccountBalance.Name = "lblMainAccountBalance"
        Me.lblMainAccountBalance.Size = New System.Drawing.Size(41, 21)
        Me.lblMainAccountBalance.TabIndex = 5
        Me.lblMainAccountBalance.Text = "0.00"
        '
        'lblMonthYearAccBalance
        '
        Me.lblMonthYearAccBalance.AutoSize = True
        Me.lblMonthYearAccBalance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthYearAccBalance.Location = New System.Drawing.Point(26, 47)
        Me.lblMonthYearAccBalance.Name = "lblMonthYearAccBalance"
        Me.lblMonthYearAccBalance.Size = New System.Drawing.Size(76, 17)
        Me.lblMonthYearAccBalance.TabIndex = 4
        Me.lblMonthYearAccBalance.Text = "Month-Year"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(131, 21)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Account Balance"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel6.Controls.Add(Me.lblMainAccountBalance)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.lblMonthYearAccBalance)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.ForeColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(353, 340)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(293, 150)
        Me.Panel6.TabIndex = 7
        '
        'MainTimer1
        '
        '
        'lblHourTime
        '
        Me.lblHourTime.AutoSize = True
        Me.lblHourTime.Font = New System.Drawing.Font("Segoe UI Semibold", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourTime.Location = New System.Drawing.Point(791, 157)
        Me.lblHourTime.Name = "lblHourTime"
        Me.lblHourTime.Size = New System.Drawing.Size(77, 37)
        Me.lblHourTime.TabIndex = 8
        Me.lblHourTime.Text = "Time"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(793, 204)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(53, 25)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "Date"
        '
        'MainTimer2
        '
        Me.MainTimer2.Enabled = True
        '
        'frmmainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 685)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblHourTime)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmmainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.pnlPanel1.ResumeLayout(False)
        Me.pnlPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlPanel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnIncome As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnExpense As Button
    Friend WithEvents lblLogo As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblLoginInfo As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblMonthYearTotalIncome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMainTotalIncome As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblMainTotalExpense As Label
    Friend WithEvents lblMonthYearTotalExpense As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents lblMainTodayExpense As Label
    Friend WithEvents lblMonthYearTodayExpense As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents lblMainAccountBalance As Label
    Friend WithEvents lblMonthYearAccBalance As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents MainTimer1 As Timer
    Friend WithEvents lblHourTime As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents MainTimer2 As Timer
End Class
