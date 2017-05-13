<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecruitmentForm
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddApplicant = New MetroFramework.Controls.MetroButton()
        Me.btnDeleteApplicant = New MetroFramework.Controls.MetroButton()
        Me.txtBoxSeachByLastname = New MetroFramework.Controls.MetroTextBox()
        Me.btnUpdateApplicant = New MetroFramework.Controls.MetroButton()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.txtBoxLastname = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxFirstname = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxTinId = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxPagibigId = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxSssId = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.id = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAddApplicant
        '
        Me.btnAddApplicant.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddApplicant.Location = New System.Drawing.Point(629, 376)
        Me.btnAddApplicant.Name = "btnAddApplicant"
        Me.btnAddApplicant.Size = New System.Drawing.Size(113, 23)
        Me.btnAddApplicant.TabIndex = 1
        Me.btnAddApplicant.Text = "Add Applicant"
        Me.btnAddApplicant.UseSelectable = True
        '
        'btnDeleteApplicant
        '
        Me.btnDeleteApplicant.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteApplicant.Location = New System.Drawing.Point(629, 460)
        Me.btnDeleteApplicant.Name = "btnDeleteApplicant"
        Me.btnDeleteApplicant.Size = New System.Drawing.Size(113, 23)
        Me.btnDeleteApplicant.TabIndex = 2
        Me.btnDeleteApplicant.Text = "Delete Applicant"
        Me.btnDeleteApplicant.UseSelectable = True
        '
        'txtBoxSeachByLastname
        '
        Me.txtBoxSeachByLastname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtBoxSeachByLastname.CustomButton.Image = Nothing
        Me.txtBoxSeachByLastname.CustomButton.Location = New System.Drawing.Point(152, 1)
        Me.txtBoxSeachByLastname.CustomButton.Name = ""
        Me.txtBoxSeachByLastname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxSeachByLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxSeachByLastname.CustomButton.TabIndex = 1
        Me.txtBoxSeachByLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxSeachByLastname.CustomButton.UseSelectable = True
        Me.txtBoxSeachByLastname.CustomButton.Visible = False
        Me.txtBoxSeachByLastname.Lines = New String(-1) {}
        Me.txtBoxSeachByLastname.Location = New System.Drawing.Point(568, 326)
        Me.txtBoxSeachByLastname.MaxLength = 32767
        Me.txtBoxSeachByLastname.Name = "txtBoxSeachByLastname"
        Me.txtBoxSeachByLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxSeachByLastname.PromptText = "Search by lastname"
        Me.txtBoxSeachByLastname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxSeachByLastname.SelectedText = ""
        Me.txtBoxSeachByLastname.SelectionLength = 0
        Me.txtBoxSeachByLastname.SelectionStart = 0
        Me.txtBoxSeachByLastname.ShortcutsEnabled = True
        Me.txtBoxSeachByLastname.Size = New System.Drawing.Size(174, 23)
        Me.txtBoxSeachByLastname.TabIndex = 3
        Me.txtBoxSeachByLastname.UseSelectable = True
        Me.txtBoxSeachByLastname.WaterMark = "Search by lastname"
        Me.txtBoxSeachByLastname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxSeachByLastname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnUpdateApplicant
        '
        Me.btnUpdateApplicant.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateApplicant.Location = New System.Drawing.Point(629, 415)
        Me.btnUpdateApplicant.Name = "btnUpdateApplicant"
        Me.btnUpdateApplicant.Size = New System.Drawing.Size(113, 23)
        Me.btnUpdateApplicant.TabIndex = 4
        Me.btnUpdateApplicant.Text = "Update"
        Me.btnUpdateApplicant.UseSelectable = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(423, 516)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(113, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseSelectable = True
        '
        'txtBoxLastname
        '
        Me.txtBoxLastname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtBoxLastname.CustomButton.Image = Nothing
        Me.txtBoxLastname.CustomButton.Location = New System.Drawing.Point(134, 1)
        Me.txtBoxLastname.CustomButton.Name = ""
        Me.txtBoxLastname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxLastname.CustomButton.TabIndex = 1
        Me.txtBoxLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxLastname.CustomButton.UseSelectable = True
        Me.txtBoxLastname.CustomButton.Visible = False
        Me.txtBoxLastname.Lines = New String(-1) {}
        Me.txtBoxLastname.Location = New System.Drawing.Point(120, 376)
        Me.txtBoxLastname.MaxLength = 32767
        Me.txtBoxLastname.Name = "txtBoxLastname"
        Me.txtBoxLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxLastname.PromptText = "Lastname"
        Me.txtBoxLastname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxLastname.SelectedText = ""
        Me.txtBoxLastname.SelectionLength = 0
        Me.txtBoxLastname.SelectionStart = 0
        Me.txtBoxLastname.ShortcutsEnabled = True
        Me.txtBoxLastname.Size = New System.Drawing.Size(156, 23)
        Me.txtBoxLastname.TabIndex = 6
        Me.txtBoxLastname.UseSelectable = True
        Me.txtBoxLastname.WaterMark = "Lastname"
        Me.txtBoxLastname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxLastname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxFirstname
        '
        '
        '
        '
        Me.txtBoxFirstname.CustomButton.Image = Nothing
        Me.txtBoxFirstname.CustomButton.Location = New System.Drawing.Point(134, 1)
        Me.txtBoxFirstname.CustomButton.Name = ""
        Me.txtBoxFirstname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxFirstname.CustomButton.TabIndex = 1
        Me.txtBoxFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxFirstname.CustomButton.UseSelectable = True
        Me.txtBoxFirstname.CustomButton.Visible = False
        Me.txtBoxFirstname.Lines = New String(-1) {}
        Me.txtBoxFirstname.Location = New System.Drawing.Point(380, 376)
        Me.txtBoxFirstname.MaxLength = 32767
        Me.txtBoxFirstname.Name = "txtBoxFirstname"
        Me.txtBoxFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxFirstname.PromptText = "Firstname"
        Me.txtBoxFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxFirstname.SelectedText = ""
        Me.txtBoxFirstname.SelectionLength = 0
        Me.txtBoxFirstname.SelectionStart = 0
        Me.txtBoxFirstname.ShortcutsEnabled = True
        Me.txtBoxFirstname.Size = New System.Drawing.Size(156, 23)
        Me.txtBoxFirstname.TabIndex = 7
        Me.txtBoxFirstname.UseSelectable = True
        Me.txtBoxFirstname.WaterMark = "Firstname"
        Me.txtBoxFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxFirstname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxEmail
        '
        Me.txtBoxEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtBoxEmail.CustomButton.Image = Nothing
        Me.txtBoxEmail.CustomButton.Location = New System.Drawing.Point(134, 1)
        Me.txtBoxEmail.CustomButton.Name = ""
        Me.txtBoxEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxEmail.CustomButton.TabIndex = 1
        Me.txtBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxEmail.CustomButton.UseSelectable = True
        Me.txtBoxEmail.CustomButton.Visible = False
        Me.txtBoxEmail.Lines = New String(-1) {}
        Me.txtBoxEmail.Location = New System.Drawing.Point(120, 415)
        Me.txtBoxEmail.MaxLength = 32767
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxEmail.PromptText = "Email"
        Me.txtBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxEmail.SelectedText = ""
        Me.txtBoxEmail.SelectionLength = 0
        Me.txtBoxEmail.SelectionStart = 0
        Me.txtBoxEmail.ShortcutsEnabled = True
        Me.txtBoxEmail.Size = New System.Drawing.Size(156, 23)
        Me.txtBoxEmail.TabIndex = 8
        Me.txtBoxEmail.UseSelectable = True
        Me.txtBoxEmail.WaterMark = "Email"
        Me.txtBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxTinId
        '
        Me.txtBoxTinId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtBoxTinId.CustomButton.Image = Nothing
        Me.txtBoxTinId.CustomButton.Location = New System.Drawing.Point(134, 1)
        Me.txtBoxTinId.CustomButton.Name = ""
        Me.txtBoxTinId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxTinId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxTinId.CustomButton.TabIndex = 1
        Me.txtBoxTinId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxTinId.CustomButton.UseSelectable = True
        Me.txtBoxTinId.CustomButton.Visible = False
        Me.txtBoxTinId.Lines = New String(-1) {}
        Me.txtBoxTinId.Location = New System.Drawing.Point(380, 419)
        Me.txtBoxTinId.MaxLength = 32767
        Me.txtBoxTinId.Name = "txtBoxTinId"
        Me.txtBoxTinId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxTinId.PromptText = "Tin Id"
        Me.txtBoxTinId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxTinId.SelectedText = ""
        Me.txtBoxTinId.SelectionLength = 0
        Me.txtBoxTinId.SelectionStart = 0
        Me.txtBoxTinId.ShortcutsEnabled = True
        Me.txtBoxTinId.Size = New System.Drawing.Size(156, 23)
        Me.txtBoxTinId.TabIndex = 9
        Me.txtBoxTinId.UseSelectable = True
        Me.txtBoxTinId.WaterMark = "Tin Id"
        Me.txtBoxTinId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxTinId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxPagibigId
        '
        Me.txtBoxPagibigId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtBoxPagibigId.CustomButton.Image = Nothing
        Me.txtBoxPagibigId.CustomButton.Location = New System.Drawing.Point(134, 1)
        Me.txtBoxPagibigId.CustomButton.Name = ""
        Me.txtBoxPagibigId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxPagibigId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxPagibigId.CustomButton.TabIndex = 1
        Me.txtBoxPagibigId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxPagibigId.CustomButton.UseSelectable = True
        Me.txtBoxPagibigId.CustomButton.Visible = False
        Me.txtBoxPagibigId.Lines = New String(-1) {}
        Me.txtBoxPagibigId.Location = New System.Drawing.Point(120, 460)
        Me.txtBoxPagibigId.MaxLength = 32767
        Me.txtBoxPagibigId.Name = "txtBoxPagibigId"
        Me.txtBoxPagibigId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxPagibigId.PromptText = "Pagibig Id"
        Me.txtBoxPagibigId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxPagibigId.SelectedText = ""
        Me.txtBoxPagibigId.SelectionLength = 0
        Me.txtBoxPagibigId.SelectionStart = 0
        Me.txtBoxPagibigId.ShortcutsEnabled = True
        Me.txtBoxPagibigId.Size = New System.Drawing.Size(156, 23)
        Me.txtBoxPagibigId.TabIndex = 10
        Me.txtBoxPagibigId.UseSelectable = True
        Me.txtBoxPagibigId.WaterMark = "Pagibig Id"
        Me.txtBoxPagibigId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxPagibigId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxSssId
        '
        Me.txtBoxSssId.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtBoxSssId.CustomButton.Image = Nothing
        Me.txtBoxSssId.CustomButton.Location = New System.Drawing.Point(134, 1)
        Me.txtBoxSssId.CustomButton.Name = ""
        Me.txtBoxSssId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxSssId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxSssId.CustomButton.TabIndex = 1
        Me.txtBoxSssId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxSssId.CustomButton.UseSelectable = True
        Me.txtBoxSssId.CustomButton.Visible = False
        Me.txtBoxSssId.Lines = New String(-1) {}
        Me.txtBoxSssId.Location = New System.Drawing.Point(380, 460)
        Me.txtBoxSssId.MaxLength = 32767
        Me.txtBoxSssId.Name = "txtBoxSssId"
        Me.txtBoxSssId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxSssId.PromptText = "SSS Id"
        Me.txtBoxSssId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxSssId.SelectedText = ""
        Me.txtBoxSssId.SelectionLength = 0
        Me.txtBoxSssId.SelectionStart = 0
        Me.txtBoxSssId.ShortcutsEnabled = True
        Me.txtBoxSssId.Size = New System.Drawing.Size(156, 23)
        Me.txtBoxSssId.TabIndex = 11
        Me.txtBoxSssId.UseSelectable = True
        Me.txtBoxSssId.WaterMark = "SSS Id"
        Me.txtBoxSssId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxSssId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(50, 330)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel1.TabIndex = 12
        Me.MetroLabel1.Text = "Applicant Details"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(50, 376)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel2.TabIndex = 13
        Me.MetroLabel2.Text = "Lastname"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(295, 376)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel3.TabIndex = 14
        Me.MetroLabel3.Text = "Firstname"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(50, 419)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 15
        Me.MetroLabel4.Text = "Email"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(297, 423)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel5.TabIndex = 16
        Me.MetroLabel5.Text = "Tin ID"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(50, 464)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel6.TabIndex = 17
        Me.MetroLabel6.Text = "Pagibig ID"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(297, 464)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel7.TabIndex = 18
        Me.MetroLabel7.Text = "SSS ID"
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.MetroGrid1.Location = New System.Drawing.Point(50, 78)
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
        Me.MetroGrid1.Size = New System.Drawing.Size(682, 214)
        Me.MetroGrid1.TabIndex = 19
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(452, 329)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(13, 19)
        Me.id.TabIndex = 20
        Me.id.Text = " "
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(416, 329)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(21, 19)
        Me.MetroLabel9.TabIndex = 21
        Me.MetroLabel9.Text = "ID"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(629, 516)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(113, 23)
        Me.MetroButton1.TabIndex = 22
        Me.MetroButton1.Text = "Hire"
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(629, 28)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel8.TabIndex = 23
        Me.MetroLabel8.Text = "Main Menu"
        '
        'RecruitmentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 602)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtBoxSssId)
        Me.Controls.Add(Me.txtBoxPagibigId)
        Me.Controls.Add(Me.txtBoxTinId)
        Me.Controls.Add(Me.txtBoxEmail)
        Me.Controls.Add(Me.txtBoxFirstname)
        Me.Controls.Add(Me.txtBoxLastname)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnUpdateApplicant)
        Me.Controls.Add(Me.txtBoxSeachByLastname)
        Me.Controls.Add(Me.btnDeleteApplicant)
        Me.Controls.Add(Me.btnAddApplicant)
        Me.Movable = False
        Me.Name = "RecruitmentForm"
        Me.Resizable = False
        Me.Text = "Recruitment"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddApplicant As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDeleteApplicant As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBoxSeachByLastname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnUpdateApplicant As MetroFramework.Controls.MetroButton
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBoxLastname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxFirstname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxTinId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxPagibigId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxSssId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents id As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
End Class
