<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formLogIn
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
        Me.txtBoxEmail = New MetroFramework.Controls.MetroTextBox()
        Me.txtBoxPassword = New MetroFramework.Controls.MetroTextBox()
        Me.btnLogIn = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtBoxEmail
        '
        '
        '
        '
        Me.txtBoxEmail.CustomButton.Image = Nothing
        Me.txtBoxEmail.CustomButton.Location = New System.Drawing.Point(269, 1)
        Me.txtBoxEmail.CustomButton.Name = ""
        Me.txtBoxEmail.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxEmail.CustomButton.TabIndex = 1
        Me.txtBoxEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxEmail.CustomButton.UseSelectable = True
        Me.txtBoxEmail.CustomButton.Visible = False
        Me.txtBoxEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBoxEmail.Lines = New String(-1) {}
        Me.txtBoxEmail.Location = New System.Drawing.Point(64, 151)
        Me.txtBoxEmail.MaxLength = 32767
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBoxEmail.PromptText = "Email"
        Me.txtBoxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxEmail.SelectedText = ""
        Me.txtBoxEmail.SelectionLength = 0
        Me.txtBoxEmail.SelectionStart = 0
        Me.txtBoxEmail.ShortcutsEnabled = True
        Me.txtBoxEmail.Size = New System.Drawing.Size(291, 23)
        Me.txtBoxEmail.TabIndex = 0
        Me.txtBoxEmail.UseSelectable = True
        Me.txtBoxEmail.WaterMark = "Email"
        Me.txtBoxEmail.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxEmail.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBoxPassword
        '
        '
        '
        '
        Me.txtBoxPassword.CustomButton.Image = Nothing
        Me.txtBoxPassword.CustomButton.Location = New System.Drawing.Point(269, 1)
        Me.txtBoxPassword.CustomButton.Name = ""
        Me.txtBoxPassword.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBoxPassword.CustomButton.TabIndex = 1
        Me.txtBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBoxPassword.CustomButton.UseSelectable = True
        Me.txtBoxPassword.CustomButton.Visible = False
        Me.txtBoxPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBoxPassword.Lines = New String(-1) {}
        Me.txtBoxPassword.Location = New System.Drawing.Point(64, 210)
        Me.txtBoxPassword.MaxLength = 32767
        Me.txtBoxPassword.Name = "txtBoxPassword"
        Me.txtBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBoxPassword.PromptText = "Password"
        Me.txtBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBoxPassword.SelectedText = ""
        Me.txtBoxPassword.SelectionLength = 0
        Me.txtBoxPassword.SelectionStart = 0
        Me.txtBoxPassword.ShortcutsEnabled = True
        Me.txtBoxPassword.Size = New System.Drawing.Size(291, 23)
        Me.txtBoxPassword.TabIndex = 1
        Me.txtBoxPassword.UseSelectable = True
        Me.txtBoxPassword.WaterMark = "Password"
        Me.txtBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBoxPassword.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(64, 287)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(291, 23)
        Me.btnLogIn.TabIndex = 2
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseSelectable = True
        '
        'formLogIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 532)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.txtBoxPassword)
        Me.Controls.Add(Me.txtBoxEmail)
        Me.Name = "formLogIn"
        Me.Text = "Log In"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtBoxEmail As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBoxPassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnLogIn As MetroFramework.Controls.MetroButton
End Class
