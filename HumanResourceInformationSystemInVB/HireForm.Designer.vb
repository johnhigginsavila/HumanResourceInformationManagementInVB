<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HireForm
    Inherits MetroFramework.Forms.MetroForm

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
        Me.cbDepartment = New MetroFramework.Controls.MetroComboBox()
        Me.HtmlLabel1 = New MetroFramework.Drawing.Html.HtmlLabel()
        Me.HtmlLabel2 = New MetroFramework.Drawing.Html.HtmlLabel()
        Me.btnHireApplicant = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.lblName = New MetroFramework.Controls.MetroLabel()
        Me.lblID = New MetroFramework.Controls.MetroLabel()
        Me.cbJob = New MetroFramework.Controls.MetroComboBox()
        Me.calStartDate = New MetroFramework.Controls.MetroDateTime()
        Me.calEndDate = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'cbDepartment
        '
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.ItemHeight = 23
        Me.cbDepartment.Items.AddRange(New Object() {"Engineering", "Sales", "Human Resource", "Legal", "Maintenance"})
        Me.cbDepartment.Location = New System.Drawing.Point(167, 150)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(117, 29)
        Me.cbDepartment.TabIndex = 0
        Me.cbDepartment.UseSelectable = True
        '
        'HtmlLabel1
        '
        Me.HtmlLabel1.AutoScroll = True
        Me.HtmlLabel1.AutoScrollMinSize = New System.Drawing.Size(67, 23)
        Me.HtmlLabel1.AutoSize = False
        Me.HtmlLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.HtmlLabel1.Location = New System.Drawing.Point(70, 150)
        Me.HtmlLabel1.Name = "HtmlLabel1"
        Me.HtmlLabel1.Size = New System.Drawing.Size(68, 23)
        Me.HtmlLabel1.TabIndex = 1
        Me.HtmlLabel1.Text = "Department"
        '
        'HtmlLabel2
        '
        Me.HtmlLabel2.AutoScroll = True
        Me.HtmlLabel2.AutoScrollMinSize = New System.Drawing.Size(28, 23)
        Me.HtmlLabel2.AutoSize = False
        Me.HtmlLabel2.BackColor = System.Drawing.SystemColors.Window
        Me.HtmlLabel2.Location = New System.Drawing.Point(107, 203)
        Me.HtmlLabel2.Name = "HtmlLabel2"
        Me.HtmlLabel2.Size = New System.Drawing.Size(31, 23)
        Me.HtmlLabel2.TabIndex = 2
        Me.HtmlLabel2.Text = "Job"
        '
        'btnHireApplicant
        '
        Me.btnHireApplicant.Location = New System.Drawing.Point(70, 394)
        Me.btnHireApplicant.Name = "btnHireApplicant"
        Me.btnHireApplicant.Size = New System.Drawing.Size(214, 23)
        Me.btnHireApplicant.TabIndex = 6
        Me.btnHireApplicant.Text = "Hire Applicant"
        Me.btnHireApplicant.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel2.Location = New System.Drawing.Point(211, 35)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(32, 25)
        Me.MetroLabel2.TabIndex = 7
        Me.MetroLabel2.Text = "ID:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(140, 96)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(83, 19)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "MetroLabel3"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblID.Location = New System.Drawing.Point(239, 34)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(106, 25)
        Me.lblID.TabIndex = 9
        Me.lblID.Text = "MetroLabel4"
        '
        'cbJob
        '
        Me.cbJob.FormattingEnabled = True
        Me.cbJob.ItemHeight = 23
        Me.cbJob.Items.AddRange(New Object() {"Administrativ Assistant", "Head", "Technician", "Office Clerk", "Janitorial", "Head Assistant", "Messanger"})
        Me.cbJob.Location = New System.Drawing.Point(167, 203)
        Me.cbJob.Name = "cbJob"
        Me.cbJob.Size = New System.Drawing.Size(117, 29)
        Me.cbJob.TabIndex = 10
        Me.cbJob.UseSelectable = True
        '
        'calStartDate
        '
        Me.calStartDate.Location = New System.Drawing.Point(167, 257)
        Me.calStartDate.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.calStartDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.calStartDate.Name = "calStartDate"
        Me.calStartDate.Size = New System.Drawing.Size(114, 29)
        Me.calStartDate.TabIndex = 11
        '
        'calEndDate
        '
        Me.calEndDate.Location = New System.Drawing.Point(167, 310)
        Me.calEndDate.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.calEndDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.calEndDate.Name = "calEndDate"
        Me.calEndDate.Size = New System.Drawing.Size(114, 29)
        Me.calEndDate.TabIndex = 12
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(71, 257)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel1.TabIndex = 13
        Me.MetroLabel1.Text = "Start Date"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(71, 310)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel3.TabIndex = 14
        Me.MetroLabel3.Text = "End Date"
        '
        'HireForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 464)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.calEndDate)
        Me.Controls.Add(Me.calStartDate)
        Me.Controls.Add(Me.cbJob)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnHireApplicant)
        Me.Controls.Add(Me.HtmlLabel2)
        Me.Controls.Add(Me.HtmlLabel1)
        Me.Controls.Add(Me.cbDepartment)
        Me.Name = "HireForm"
        Me.Text = "Hire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbDepartment As MetroFramework.Controls.MetroComboBox
    Friend WithEvents HtmlLabel1 As MetroFramework.Drawing.Html.HtmlLabel
    Friend WithEvents HtmlLabel2 As MetroFramework.Drawing.Html.HtmlLabel
    Friend WithEvents btnHireApplicant As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblID As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbJob As MetroFramework.Controls.MetroComboBox
    Friend WithEvents calStartDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents calEndDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
