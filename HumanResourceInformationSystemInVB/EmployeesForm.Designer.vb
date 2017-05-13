<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employees
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroGrid1 = New MetroFramework.Controls.MetroGrid()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtBoxLastname = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxFirstname = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxTinId = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxPagibigId = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxSssId = New MetroFramework.Controls.MetroTextBox()
        Me.btnReset = New MetroFramework.Controls.MetroButton()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.btnDelete = New MetroFramework.Controls.MetroButton()
        Me.HtmlLabel1 = New MetroFramework.Drawing.Html.HtmlLabel()
        Me.lblId = New MetroFramework.Controls.MetroLabel()
        Me.txtBoxSearchByLastname = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroGrid1
        '
        Me.MetroGrid1.AllowUserToResizeRows = False
        Me.MetroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MetroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.MetroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MetroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.MetroGrid1.DefaultCellStyle = DataGridViewCellStyle2
        Me.MetroGrid1.EnableHeadersVisualStyles = False
        Me.MetroGrid1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MetroGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MetroGrid1.Location = New System.Drawing.Point(56, 63)
        Me.MetroGrid1.Name = "MetroGrid1"
        Me.MetroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MetroGrid1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.MetroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.MetroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MetroGrid1.Size = New System.Drawing.Size(674, 254)
        Me.MetroGrid1.TabIndex = 0
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(56, 347)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(109, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Employee Details"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(56, 399)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Lastname"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(50, 504)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Pagibig ID"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(79, 456)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Email"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(301, 395)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Firstname"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(325, 447)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(42, 19)
        Me.MetroLabel6.TabIndex = 6
        Me.MetroLabel6.Text = "Tin ID"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(321, 495)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel7.TabIndex = 7
        Me.MetroLabel7.Text = "SSS ID"
        '
        'txtBoxLastname
        '
        '
        '
        '
        Me.txtBoxLastname.CustomButton.Image = Nothing
        Me.txtBoxLastname.CustomButton.Location = New System.Drawing.Point(103, 1)
        Me.txtBoxLastname.CustomButton.Name = ""
        Me.txtBoxLastname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxLastname.CustomButton.TabIndex = 1
        Me.txtBoxLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxLastname.CustomButton.UseSelectable = True
        Me.txtBoxLastname.CustomButton.Visible = False
        Me.txtBoxLastname.Lines = New String(-1) {}
        Me.txtBoxLastname.Location = New System.Drawing.Point(144, 400)
        Me.txtBoxLastname.MaxLength = 32767
        Me.txtBoxLastname.Name = "txtBoxLastname"
        Me.txtBoxLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxLastname.PromptText = "Lastname"
        Me.txtBoxLastname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxLastname.SelectedText = ""
        Me.txtBoxLastname.SelectionLength = 0
        Me.txtBoxLastname.SelectionStart = 0
        Me.txtBoxLastname.ShortcutsEnabled = True
        Me.txtBoxLastname.Size = New System.Drawing.Size(125, 23)
        Me.txtBoxLastname.TabIndex = 8
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
        Me.txtBoxFirstname.CustomButton.Location = New System.Drawing.Point(103, 1)
        Me.txtBoxFirstname.CustomButton.Name = ""
        Me.txtBoxFirstname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxFirstname.CustomButton.TabIndex = 1
        Me.txtBoxFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxFirstname.CustomButton.UseSelectable = True
        Me.txtBoxFirstname.CustomButton.Visible = False
        Me.txtBoxFirstname.Lines = New String(-1) {}
        Me.txtBoxFirstname.Location = New System.Drawing.Point(382, 395)
        Me.txtBoxFirstname.MaxLength = 32767
        Me.txtBoxFirstname.Name = "txtBoxFirstname"
        Me.txtBoxFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxFirstname.PromptText = "Firstname"
        Me.txtBoxFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxFirstname.SelectedText = ""
        Me.txtBoxFirstname.SelectionLength = 0
        Me.txtBoxFirstname.SelectionStart = 0
        Me.txtBoxFirstname.ShortcutsEnabled = True
        Me.txtBoxFirstname.Size = New System.Drawing.Size(125, 23)
        Me.txtBoxFirstname.TabIndex = 9
        Me.txtBoxFirstname.UseSelectable = True
        Me.txtBoxFirstname.WaterMark = "Firstname"
        Me.txtBoxFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxFirstname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxEmail
        '
        '
        '
        '
        Me.txtBoxEmail.CustomButton.Image = Nothing
        Me.txtBoxEmail.CustomButton.Location = New System.Drawing.Point(103, 1)
        Me.txtBoxEmail.CustomButton.Name = ""
        Me.txtBoxEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxEmail.CustomButton.TabIndex = 1
        Me.txtBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxEmail.CustomButton.UseSelectable = True
        Me.txtBoxEmail.CustomButton.Visible = False
        Me.txtBoxEmail.Lines = New String(-1) {}
        Me.txtBoxEmail.Location = New System.Drawing.Point(144, 452)
        Me.txtBoxEmail.MaxLength = 32767
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxEmail.PromptText = "Email"
        Me.txtBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxEmail.SelectedText = ""
        Me.txtBoxEmail.SelectionLength = 0
        Me.txtBoxEmail.SelectionStart = 0
        Me.txtBoxEmail.ShortcutsEnabled = True
        Me.txtBoxEmail.Size = New System.Drawing.Size(125, 23)
        Me.txtBoxEmail.TabIndex = 10
        Me.txtBoxEmail.UseSelectable = True
        Me.txtBoxEmail.WaterMark = "Email"
        Me.txtBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxTinId
        '
        '
        '
        '
        Me.txtBoxTinId.CustomButton.Image = Nothing
        Me.txtBoxTinId.CustomButton.Location = New System.Drawing.Point(103, 1)
        Me.txtBoxTinId.CustomButton.Name = ""
        Me.txtBoxTinId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxTinId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxTinId.CustomButton.TabIndex = 1
        Me.txtBoxTinId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxTinId.CustomButton.UseSelectable = True
        Me.txtBoxTinId.CustomButton.Visible = False
        Me.txtBoxTinId.Lines = New String(-1) {}
        Me.txtBoxTinId.Location = New System.Drawing.Point(382, 447)
        Me.txtBoxTinId.MaxLength = 32767
        Me.txtBoxTinId.Name = "txtBoxTinId"
        Me.txtBoxTinId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxTinId.PromptText = "Tin ID"
        Me.txtBoxTinId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxTinId.SelectedText = ""
        Me.txtBoxTinId.SelectionLength = 0
        Me.txtBoxTinId.SelectionStart = 0
        Me.txtBoxTinId.ShortcutsEnabled = True
        Me.txtBoxTinId.Size = New System.Drawing.Size(125, 23)
        Me.txtBoxTinId.TabIndex = 11
        Me.txtBoxTinId.UseSelectable = True
        Me.txtBoxTinId.WaterMark = "Tin ID"
        Me.txtBoxTinId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxTinId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxPagibigId
        '
        '
        '
        '
        Me.txtBoxPagibigId.CustomButton.Image = Nothing
        Me.txtBoxPagibigId.CustomButton.Location = New System.Drawing.Point(103, 1)
        Me.txtBoxPagibigId.CustomButton.Name = ""
        Me.txtBoxPagibigId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxPagibigId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxPagibigId.CustomButton.TabIndex = 1
        Me.txtBoxPagibigId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxPagibigId.CustomButton.UseSelectable = True
        Me.txtBoxPagibigId.CustomButton.Visible = False
        Me.txtBoxPagibigId.Lines = New String(-1) {}
        Me.txtBoxPagibigId.Location = New System.Drawing.Point(144, 500)
        Me.txtBoxPagibigId.MaxLength = 32767
        Me.txtBoxPagibigId.Name = "txtBoxPagibigId"
        Me.txtBoxPagibigId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxPagibigId.PromptText = "Pagibig ID"
        Me.txtBoxPagibigId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxPagibigId.SelectedText = ""
        Me.txtBoxPagibigId.SelectionLength = 0
        Me.txtBoxPagibigId.SelectionStart = 0
        Me.txtBoxPagibigId.ShortcutsEnabled = True
        Me.txtBoxPagibigId.Size = New System.Drawing.Size(125, 23)
        Me.txtBoxPagibigId.TabIndex = 12
        Me.txtBoxPagibigId.UseSelectable = True
        Me.txtBoxPagibigId.WaterMark = "Pagibig ID"
        Me.txtBoxPagibigId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxPagibigId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxSssId
        '
        '
        '
        '
        Me.txtBoxSssId.CustomButton.Image = Nothing
        Me.txtBoxSssId.CustomButton.Location = New System.Drawing.Point(103, 1)
        Me.txtBoxSssId.CustomButton.Name = ""
        Me.txtBoxSssId.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxSssId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxSssId.CustomButton.TabIndex = 1
        Me.txtBoxSssId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxSssId.CustomButton.UseSelectable = True
        Me.txtBoxSssId.CustomButton.Visible = False
        Me.txtBoxSssId.Lines = New String(-1) {}
        Me.txtBoxSssId.Location = New System.Drawing.Point(382, 495)
        Me.txtBoxSssId.MaxLength = 32767
        Me.txtBoxSssId.Name = "txtBoxSssId"
        Me.txtBoxSssId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxSssId.PromptText = "SSS ID"
        Me.txtBoxSssId.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxSssId.SelectedText = ""
        Me.txtBoxSssId.SelectionLength = 0
        Me.txtBoxSssId.SelectionStart = 0
        Me.txtBoxSssId.ShortcutsEnabled = True
        Me.txtBoxSssId.Size = New System.Drawing.Size(125, 23)
        Me.txtBoxSssId.TabIndex = 13
        Me.txtBoxSssId.UseSelectable = True
        Me.txtBoxSssId.WaterMark = "SSS ID"
        Me.txtBoxSssId.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxSssId.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(557, 504)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(125, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseSelectable = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(557, 395)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(131, 23)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseSelectable = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(557, 447)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(131, 23)
        Me.btnDelete.TabIndex = 17
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseSelectable = True
        '
        'HtmlLabel1
        '
        Me.HtmlLabel1.AutoScroll = True
        Me.HtmlLabel1.AutoScrollMinSize = New System.Drawing.Size(24, 23)
        Me.HtmlLabel1.AutoSize = False
        Me.HtmlLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.HtmlLabel1.Location = New System.Drawing.Point(402, 347)
        Me.HtmlLabel1.Name = "HtmlLabel1"
        Me.HtmlLabel1.Size = New System.Drawing.Size(32, 23)
        Me.HtmlLabel1.TabIndex = 19
        Me.HtmlLabel1.Text = "ID:"
        '
        'lblId
        '
        Me.lblId.AccessibleDescription = " "
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(440, 347)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(13, 19)
        Me.lblId.TabIndex = 20
        Me.lblId.Text = " "
        '
        'txtBoxSearchByLastname
        '
        '
        '
        '
        Me.txtBoxSearchByLastname.CustomButton.Image = Nothing
        Me.txtBoxSearchByLastname.CustomButton.Location = New System.Drawing.Point(158, 1)
        Me.txtBoxSearchByLastname.CustomButton.Name = ""
        Me.txtBoxSearchByLastname.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxSearchByLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxSearchByLastname.CustomButton.TabIndex = 1
        Me.txtBoxSearchByLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxSearchByLastname.CustomButton.UseSelectable = True
        Me.txtBoxSearchByLastname.CustomButton.Visible = False
        Me.txtBoxSearchByLastname.Lines = New String(-1) {}
        Me.txtBoxSearchByLastname.Location = New System.Drawing.Point(508, 347)
        Me.txtBoxSearchByLastname.MaxLength = 32767
        Me.txtBoxSearchByLastname.Name = "txtBoxSearchByLastname"
        Me.txtBoxSearchByLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxSearchByLastname.PromptText = "Search Employee by lastname"
        Me.txtBoxSearchByLastname.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxSearchByLastname.SelectedText = ""
        Me.txtBoxSearchByLastname.SelectionLength = 0
        Me.txtBoxSearchByLastname.SelectionStart = 0
        Me.txtBoxSearchByLastname.ShortcutsEnabled = True
        Me.txtBoxSearchByLastname.Size = New System.Drawing.Size(180, 23)
        Me.txtBoxSearchByLastname.TabIndex = 21
        Me.txtBoxSearchByLastname.UseSelectable = True
        Me.txtBoxSearchByLastname.WaterMark = "Search Employee by lastname"
        Me.txtBoxSearchByLastname.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxSearchByLastname.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(613, 33)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel8.TabIndex = 22
        Me.MetroLabel8.Text = "Main Menu"
        '
        'Employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 602)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.txtBoxSearchByLastname)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.HtmlLabel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtBoxSssId)
        Me.Controls.Add(Me.txtBoxPagibigId)
        Me.Controls.Add(Me.txtBoxTinId)
        Me.Controls.Add(Me.txtBoxEmail)
        Me.Controls.Add(Me.txtBoxFirstname)
        Me.Controls.Add(Me.txtBoxLastname)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroGrid1)
        Me.Name = "Employees"
        Me.Text = "Employees"
        CType(Me.MetroGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroGrid1 As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBoxLastname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxFirstname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxTinId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxPagibigId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxSssId As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnReset As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents HtmlLabel1 As MetroFramework.Drawing.Html.HtmlLabel
    Friend WithEvents lblId As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtBoxSearchByLastname As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
End Class
