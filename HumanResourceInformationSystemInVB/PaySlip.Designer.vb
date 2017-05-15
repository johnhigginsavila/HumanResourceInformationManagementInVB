<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaySlip
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.lblGrossIncome = New MetroFramework.Controls.MetroLabel()
        Me.lblIncomeTax = New MetroFramework.Controls.MetroLabel()
        Me.lblPagibig = New MetroFramework.Controls.MetroLabel()
        Me.lblSSS = New MetroFramework.Controls.MetroLabel()
        Me.lblPhilhealth = New MetroFramework.Controls.MetroLabel()
        Me.lblNetIncome = New MetroFramework.Controls.MetroLabel()
        Me.lblId = New MetroFramework.Controls.MetroLabel()
        Me.lblName = New MetroFramework.Controls.MetroLabel()
        Me.lblDepartment = New MetroFramework.Controls.MetroLabel()
        Me.lblJob = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(383, 29)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Employee ID:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(421, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Name:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(387, 92)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Department:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(436, 122)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Job:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(76, 158)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "Pay Slip Details"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(165, 196)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(137, 19)
        Me.MetroLabel6.TabIndex = 6
        Me.MetroLabel6.Text = "Gross Income in Peso:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(116, 236)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel7.TabIndex = 7
        Me.MetroLabel7.Text = "Deductions"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(177, 264)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel8.TabIndex = 8
        Me.MetroLabel8.Text = "Income Tax in Peso:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(199, 299)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel9.TabIndex = 9
        Me.MetroLabel9.Text = "Pagibig in Peso:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(223, 330)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(79, 19)
        Me.MetroLabel10.TabIndex = 10
        Me.MetroLabel10.Text = "SSS in Peso:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(188, 362)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel11.TabIndex = 11
        Me.MetroLabel11.Text = "Philhealth in Peso:"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(176, 417)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(126, 19)
        Me.MetroLabel12.TabIndex = 12
        Me.MetroLabel12.Text = "Net Income in Peso:"
        '
        'lblGrossIncome
        '
        Me.lblGrossIncome.AutoSize = True
        Me.lblGrossIncome.Location = New System.Drawing.Point(315, 196)
        Me.lblGrossIncome.Name = "lblGrossIncome"
        Me.lblGrossIncome.Size = New System.Drawing.Size(90, 19)
        Me.lblGrossIncome.TabIndex = 13
        Me.lblGrossIncome.Text = "MetroLabel13"
        '
        'lblIncomeTax
        '
        Me.lblIncomeTax.AutoSize = True
        Me.lblIncomeTax.Location = New System.Drawing.Point(315, 264)
        Me.lblIncomeTax.Name = "lblIncomeTax"
        Me.lblIncomeTax.Size = New System.Drawing.Size(90, 19)
        Me.lblIncomeTax.TabIndex = 14
        Me.lblIncomeTax.Text = "MetroLabel14"
        '
        'lblPagibig
        '
        Me.lblPagibig.AutoSize = True
        Me.lblPagibig.Location = New System.Drawing.Point(315, 299)
        Me.lblPagibig.Name = "lblPagibig"
        Me.lblPagibig.Size = New System.Drawing.Size(90, 19)
        Me.lblPagibig.TabIndex = 15
        Me.lblPagibig.Text = "MetroLabel15"
        '
        'lblSSS
        '
        Me.lblSSS.AutoSize = True
        Me.lblSSS.Location = New System.Drawing.Point(315, 330)
        Me.lblSSS.Name = "lblSSS"
        Me.lblSSS.Size = New System.Drawing.Size(90, 19)
        Me.lblSSS.TabIndex = 16
        Me.lblSSS.Text = "MetroLabel16"
        '
        'lblPhilhealth
        '
        Me.lblPhilhealth.AutoSize = True
        Me.lblPhilhealth.Location = New System.Drawing.Point(315, 362)
        Me.lblPhilhealth.Name = "lblPhilhealth"
        Me.lblPhilhealth.Size = New System.Drawing.Size(90, 19)
        Me.lblPhilhealth.TabIndex = 17
        Me.lblPhilhealth.Text = "MetroLabel17"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.Location = New System.Drawing.Point(315, 417)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(90, 19)
        Me.lblNetIncome.TabIndex = 18
        Me.lblNetIncome.Text = "MetroLabel18"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(486, 29)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(90, 19)
        Me.lblId.TabIndex = 19
        Me.lblId.Text = "MetroLabel19"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(486, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 19)
        Me.lblName.TabIndex = 20
        Me.lblName.Text = "MetroLabel20"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(486, 92)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(90, 19)
        Me.lblDepartment.TabIndex = 21
        Me.lblDepartment.Text = "MetroLabel21"
        '
        'lblJob
        '
        Me.lblJob.AutoSize = True
        Me.lblJob.Location = New System.Drawing.Point(486, 122)
        Me.lblJob.Name = "lblJob"
        Me.lblJob.Size = New System.Drawing.Size(90, 19)
        Me.lblJob.TabIndex = 22
        Me.lblJob.Text = "MetroLabel22"
        '
        'PaySlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 483)
        Me.Controls.Add(Me.lblJob)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.lblPhilhealth)
        Me.Controls.Add(Me.lblSSS)
        Me.Controls.Add(Me.lblPagibig)
        Me.Controls.Add(Me.lblIncomeTax)
        Me.Controls.Add(Me.lblGrossIncome)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.MetroLabel11)
        Me.Controls.Add(Me.MetroLabel10)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "PaySlip"
        Me.Text = "PaySlip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblGrossIncome As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblIncomeTax As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPagibig As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSSS As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblPhilhealth As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNetIncome As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblId As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblName As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDepartment As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblJob As MetroFramework.Controls.MetroLabel
End Class
