<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.employeeGender = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.workForceCount = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.departmentEmployee = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.employeeGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.workForceCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.departmentEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.departmentEmployee)
        Me.MetroPanel1.Controls.Add(Me.workForceCount)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.employeeGender)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(24, 64)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1002, 658)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'employeeGender
        '
        ChartArea3.Name = "employeeGenderChartArea"
        Me.employeeGender.ChartAreas.Add(ChartArea3)
        Me.employeeGender.Location = New System.Drawing.Point(37, 37)
        Me.employeeGender.Name = "employeeGender"
        Me.employeeGender.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series9.ChartArea = "employeeGenderChartArea"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series9.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series9.Label = "Male Employee"
        Series9.Name = "maleEmployee"
        Series10.ChartArea = "employeeGenderChartArea"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series10.Color = System.Drawing.Color.Red
        Series10.Label = "Female Employee"
        Series10.Name = "femaleEmployee"
        Me.employeeGender.Series.Add(Series9)
        Me.employeeGender.Series.Add(Series10)
        Me.employeeGender.Size = New System.Drawing.Size(395, 224)
        Me.employeeGender.TabIndex = 5
        Me.employeeGender.Text = "Chart1"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(52, 15)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel1.TabIndex = 4
        Me.MetroLabel1.Text = "Employee Gender"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(646, 28)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Main Menu"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(556, 5)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(117, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Work Force Count"
        '
        'workForceCount
        '
        ChartArea2.Name = "ChartArea1"
        Me.workForceCount.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.workForceCount.Legends.Add(Legend2)
        Me.workForceCount.Location = New System.Drawing.Point(527, 27)
        Me.workForceCount.Name = "workForceCount"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.IsVisibleInLegend = False
        Series2.IsXValueIndexed = True
        Series2.Legend = "Legend1"
        Series2.Name = "adminAssistant"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.IsVisibleInLegend = False
        Series3.IsXValueIndexed = True
        Series3.Legend = "Legend1"
        Series3.Name = "head"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series4.IsVisibleInLegend = False
        Series4.IsXValueIndexed = True
        Series4.Legend = "Legend1"
        Series4.Name = "technician"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series5.IsVisibleInLegend = False
        Series5.IsXValueIndexed = True
        Series5.Legend = "Legend1"
        Series5.Name = "officeClerk"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series6.IsVisibleInLegend = False
        Series6.IsXValueIndexed = True
        Series6.Legend = "Legend1"
        Series6.Name = "janitorial"
        Series7.ChartArea = "ChartArea1"
        Series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series7.IsVisibleInLegend = False
        Series7.IsXValueIndexed = True
        Series7.Legend = "Legend1"
        Series7.Name = "headAssistant"
        Series8.ChartArea = "ChartArea1"
        Series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series8.IsVisibleInLegend = False
        Series8.IsXValueIndexed = True
        Series8.Legend = "Legend1"
        Series8.Name = "messanger"
        Me.workForceCount.Series.Add(Series2)
        Me.workForceCount.Series.Add(Series3)
        Me.workForceCount.Series.Add(Series4)
        Me.workForceCount.Series.Add(Series5)
        Me.workForceCount.Series.Add(Series6)
        Me.workForceCount.Series.Add(Series7)
        Me.workForceCount.Series.Add(Series8)
        Me.workForceCount.Size = New System.Drawing.Size(472, 234)
        Me.workForceCount.TabIndex = 7
        Me.workForceCount.Text = "workForceCount"
        '
        'departmentEmployee
        '
        ChartArea1.Name = "ChartArea1"
        Me.departmentEmployee.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.departmentEmployee.Legends.Add(Legend1)
        Me.departmentEmployee.Location = New System.Drawing.Point(52, 349)
        Me.departmentEmployee.Name = "departmentEmployee"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "numberOfEmployees"
        Me.departmentEmployee.Series.Add(Series1)
        Me.departmentEmployee.Size = New System.Drawing.Size(476, 300)
        Me.departmentEmployee.TabIndex = 8
        Me.departmentEmployee.Text = "departmentEmployee"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(52, 316)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(170, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Employees Per Department"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 739)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Name = "DashboardForm"
        Me.Text = "Dash Board"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.employeeGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.workForceCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.departmentEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents employeeGender As DataVisualization.Charting.Chart
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents workForceCount As DataVisualization.Charting.Chart
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents departmentEmployee As DataVisualization.Charting.Chart
End Class
