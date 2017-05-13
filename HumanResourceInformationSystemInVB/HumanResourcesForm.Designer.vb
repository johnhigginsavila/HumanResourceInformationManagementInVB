<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HumanResourcesForm
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtBoxUpdateJobDescription = New System.Windows.Forms.TextBox()
        Me.btnUpdateJobDescription = New MetroFramework.Controls.MetroButton()
        Me.btnDecreseRequiredPersonnel = New MetroFramework.Controls.MetroButton()
        Me.txtBoxJobDescription = New System.Windows.Forms.TextBox()
        Me.btnAddJob = New MetroFramework.Controls.MetroButton()
        Me.cbDepartment = New MetroFramework.Controls.MetroComboBox()
        Me.cbJob = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.btnIncreaseRequiredPersonnel = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.lblId = New MetroFramework.Controls.MetroLabel()
        Me.numNumOfPersonnel = New System.Windows.Forms.NumericUpDown()
        Me.txtBoxSortRecordsByDepartment = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxSortRecordsByJob = New MetroFramework.Controls.MetroTextBox()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNumOfPersonnel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle5
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(45, 115)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(689, 206)
        Me.MetroGrid1.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(631, 69)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Main Menu"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(389, 358)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(146, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Update Job Description"
        '
        'txtBoxUpdateJobDescription
        '
        Me.txtBoxUpdateJobDescription.Location = New System.Drawing.Point(392, 427)
        Me.txtBoxUpdateJobDescription.Multiline = True
        Me.txtBoxUpdateJobDescription.Name = "txtBoxUpdateJobDescription"
        Me.txtBoxUpdateJobDescription.Size = New System.Drawing.Size(146, 111)
        Me.txtBoxUpdateJobDescription.TabIndex = 3
        '
        'btnUpdateJobDescription
        '
        Me.btnUpdateJobDescription.Location = New System.Drawing.Point(392, 556)
        Me.btnUpdateJobDescription.Name = "btnUpdateJobDescription"
        Me.btnUpdateJobDescription.Size = New System.Drawing.Size(146, 23)
        Me.btnUpdateJobDescription.TabIndex = 4
        Me.btnUpdateJobDescription.Text = "Update"
        Me.btnUpdateJobDescription.UseSelectable = True
        '
        'btnDecreseRequiredPersonnel
        '
        Me.btnDecreseRequiredPersonnel.Location = New System.Drawing.Point(590, 501)
        Me.btnDecreseRequiredPersonnel.Name = "btnDecreseRequiredPersonnel"
        Me.btnDecreseRequiredPersonnel.Size = New System.Drawing.Size(165, 23)
        Me.btnDecreseRequiredPersonnel.TabIndex = 5
        Me.btnDecreseRequiredPersonnel.Text = "Decrese Required Personnel"
        Me.btnDecreseRequiredPersonnel.UseSelectable = True
        '
        'txtBoxJobDescription
        '
        Me.txtBoxJobDescription.Location = New System.Drawing.Point(210, 427)
        Me.txtBoxJobDescription.Multiline = True
        Me.txtBoxJobDescription.Name = "txtBoxJobDescription"
        Me.txtBoxJobDescription.Size = New System.Drawing.Size(134, 123)
        Me.txtBoxJobDescription.TabIndex = 6
        '
        'btnAddJob
        '
        Me.btnAddJob.Location = New System.Drawing.Point(23, 556)
        Me.btnAddJob.Name = "btnAddJob"
        Me.btnAddJob.Size = New System.Drawing.Size(321, 23)
        Me.btnAddJob.TabIndex = 7
        Me.btnAddJob.Text = "Add"
        Me.btnAddJob.UseSelectable = True
        '
        'cbDepartment
        '
        Me.cbDepartment.FormattingEnabled = True
        Me.cbDepartment.ItemHeight = 23
        Me.cbDepartment.Items.AddRange(New Object() {"Engineering", "Sales", "Human Resource", "Legal", "Maintenance"})
        Me.cbDepartment.Location = New System.Drawing.Point(23, 427)
        Me.cbDepartment.Name = "cbDepartment"
        Me.cbDepartment.Size = New System.Drawing.Size(168, 29)
        Me.cbDepartment.TabIndex = 8
        Me.cbDepartment.UseSelectable = True
        '
        'cbJob
        '
        Me.cbJob.FormattingEnabled = True
        Me.cbJob.ItemHeight = 23
        Me.cbJob.Items.AddRange(New Object() {"Administrative Assistant", "Head", "Technician", "Office Clerk", "Janitorial", "Head Assistant", "Messanger"})
        Me.cbJob.Location = New System.Drawing.Point(23, 486)
        Me.cbJob.Name = "cbJob"
        Me.cbJob.Size = New System.Drawing.Size(168, 29)
        Me.cbJob.TabIndex = 9
        Me.cbJob.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 519)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel3.TabIndex = 11
        Me.MetroLabel3.Text = "Personnel"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(210, 394)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(99, 19)
        Me.MetroLabel4.TabIndex = 12
        Me.MetroLabel4.Text = "Job Description"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 358)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel5.TabIndex = 13
        Me.MetroLabel5.Text = "Add Job"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(590, 556)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(165, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseSelectable = True
        '
        'btnIncreaseRequiredPersonnel
        '
        Me.btnIncreaseRequiredPersonnel.Location = New System.Drawing.Point(590, 455)
        Me.btnIncreaseRequiredPersonnel.Name = "btnIncreaseRequiredPersonnel"
        Me.btnIncreaseRequiredPersonnel.Size = New System.Drawing.Size(165, 23)
        Me.btnIncreaseRequiredPersonnel.TabIndex = 15
        Me.btnIncreaseRequiredPersonnel.Text = "Increase Required Personnel"
        Me.btnIncreaseRequiredPersonnel.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 403)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel6.TabIndex = 16
        Me.MetroLabel6.Text = "Department"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 459)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(30, 19)
        Me.MetroLabel7.TabIndex = 17
        Me.MetroLabel7.Text = "Job"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(392, 394)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel8.TabIndex = 18
        Me.MetroLabel8.Text = "ResourceID: "
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(514, 394)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 19)
        Me.lblId.TabIndex = 19
        Me.lblId.Text = "ID"
        '
        'numNumOfPersonnel
        '
        Me.numNumOfPersonnel.Location = New System.Drawing.Point(108, 521)
        Me.numNumOfPersonnel.Name = "numNumOfPersonnel"
        Me.numNumOfPersonnel.Size = New System.Drawing.Size(83, 20)
        Me.numNumOfPersonnel.TabIndex = 20
        '
        'txtBoxSortRecordsByDepartment
        '
        '
        '
        '
        Me.txtBoxSortRecordsByDepartment.CustomButton.Image = Nothing
        Me.txtBoxSortRecordsByDepartment.CustomButton.Location = New System.Drawing.Point(143, 1)
        Me.txtBoxSortRecordsByDepartment.CustomButton.Name = ""
        Me.txtBoxSortRecordsByDepartment.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxSortRecordsByDepartment.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxSortRecordsByDepartment.CustomButton.TabIndex = 1
        Me.txtBoxSortRecordsByDepartment.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxSortRecordsByDepartment.CustomButton.UseSelectable = True
        Me.txtBoxSortRecordsByDepartment.CustomButton.Visible = False
        Me.txtBoxSortRecordsByDepartment.Lines = New String(-1) {}
        Me.txtBoxSortRecordsByDepartment.Location = New System.Drawing.Point(590, 358)
        Me.txtBoxSortRecordsByDepartment.MaxLength = 32767
        Me.txtBoxSortRecordsByDepartment.Name = "txtBoxSortRecordsByDepartment"
        Me.txtBoxSortRecordsByDepartment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxSortRecordsByDepartment.PromptText = "Sort Records by Department"
        Me.txtBoxSortRecordsByDepartment.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxSortRecordsByDepartment.SelectedText = ""
        Me.txtBoxSortRecordsByDepartment.SelectionLength = 0
        Me.txtBoxSortRecordsByDepartment.SelectionStart = 0
        Me.txtBoxSortRecordsByDepartment.ShortcutsEnabled = True
        Me.txtBoxSortRecordsByDepartment.Size = New System.Drawing.Size(165, 23)
        Me.txtBoxSortRecordsByDepartment.TabIndex = 21
        Me.txtBoxSortRecordsByDepartment.UseSelectable = True
        Me.txtBoxSortRecordsByDepartment.WaterMark = "Sort Records by Department"
        Me.txtBoxSortRecordsByDepartment.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxSortRecordsByDepartment.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxSortRecordsByJob
        '
        '
        '
        '
        Me.txtBoxSortRecordsByJob.CustomButton.Image = Nothing
        Me.txtBoxSortRecordsByJob.CustomButton.Location = New System.Drawing.Point(143, 1)
        Me.txtBoxSortRecordsByJob.CustomButton.Name = ""
        Me.txtBoxSortRecordsByJob.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxSortRecordsByJob.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxSortRecordsByJob.CustomButton.TabIndex = 1
        Me.txtBoxSortRecordsByJob.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxSortRecordsByJob.CustomButton.UseSelectable = True
        Me.txtBoxSortRecordsByJob.CustomButton.Visible = False
        Me.txtBoxSortRecordsByJob.Lines = New String(-1) {}
        Me.txtBoxSortRecordsByJob.Location = New System.Drawing.Point(590, 394)
        Me.txtBoxSortRecordsByJob.MaxLength = 32767
        Me.txtBoxSortRecordsByJob.Name = "txtBoxSortRecordsByJob"
        Me.txtBoxSortRecordsByJob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxSortRecordsByJob.PromptText = "Sort Records by Job"
        Me.txtBoxSortRecordsByJob.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxSortRecordsByJob.SelectedText = ""
        Me.txtBoxSortRecordsByJob.SelectionLength = 0
        Me.txtBoxSortRecordsByJob.SelectionStart = 0
        Me.txtBoxSortRecordsByJob.ShortcutsEnabled = True
        Me.txtBoxSortRecordsByJob.Size = New System.Drawing.Size(165, 23)
        Me.txtBoxSortRecordsByJob.TabIndex = 22
        Me.txtBoxSortRecordsByJob.UseSelectable = True
        Me.txtBoxSortRecordsByJob.WaterMark = "Sort Records by Job"
        Me.txtBoxSortRecordsByJob.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxSortRecordsByJob.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'HumanResourcesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 602)
        Me.Controls.Add(Me.txtBoxSortRecordsByJob)
        Me.Controls.Add(Me.txtBoxSortRecordsByDepartment)
        Me.Controls.Add(Me.numNumOfPersonnel)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.btnIncreaseRequiredPersonnel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.cbJob)
        Me.Controls.Add(Me.cbDepartment)
        Me.Controls.Add(Me.btnAddJob)
        Me.Controls.Add(Me.txtBoxJobDescription)
        Me.Controls.Add(Me.btnDecreseRequiredPersonnel)
        Me.Controls.Add(Me.btnUpdateJobDescription)
        Me.Controls.Add(Me.txtBoxUpdateJobDescription)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "HumanResourcesForm"
        Me.Text = "HumanResourcesForm"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNumOfPersonnel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBoxUpdateJobDescription As TextBox
    Friend WithEvents btnUpdateJobDescription As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDecreseRequiredPersonnel As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBoxJobDescription As TextBox
    Friend WithEvents btnAddJob As MetroFramework.Controls.MetroButton
    Friend WithEvents cbDepartment As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbJob As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents btnIncreaseRequiredPersonnel As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblId As MetroFramework.Controls.MetroLabel
    Friend WithEvents numNumOfPersonnel As NumericUpDown
    Friend WithEvents txtBoxSortRecordsByDepartment As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxSortRecordsByJob As MetroFramework.Controls.MetroTextBox
End Class
