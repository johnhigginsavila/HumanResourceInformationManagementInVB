Imports Npgsql

Public Class PaySlip

    Public id As String
    Public lastname As String
    Public firstname As String
    Public department As String
    Public job As String
    Public salary As String

    Dim salaryGrade1 As Double = 16000
    Dim salaryGrade2 As Double = 18000
    Dim salaryGrade3 As Double = 20000
    Dim salaryGrade4 As Double = 24000
    Dim salaryGrade5 As Double = 30000


    Private Sub PaySlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub


    Function getPagibigDeduction(salary As Double) As Double
        Dim pagibigDeduction As Double

        pagibigDeduction = salary * 0.01

        Return pagibigDeduction
    End Function

    Function getSssDeduction(salary As Double) As Double
        Dim sssDeduction As Double
        sssDeduction = 581
        Return sssDeduction
    End Function

    Function getPhilHealthDeduction(salary As Double) As Double
        Dim philHealthDeduction As Double
        If salary = salaryGrade1 Then
            philHealthDeduction = 200
        ElseIf salary = salaryGrade2 Then
            philHealthDeduction = 225
        ElseIf salary = salaryGrade3 Then
            philHealthDeduction = 250
        ElseIf salary = salaryGrade4 Then
            philHealthDeduction = 300
        Else
            philHealthDeduction = 375
        End If

        Return philHealthDeduction
    End Function

    Function getTaxDeduction(deductedSalary As Double) As Double
        Dim taxDeduction As Double
        Dim annualSalary As Double = deductedSalary * 12
        Dim taxableIncome As Double = annualSalary - 50000
        Dim taxableMonthlyIncome As Double = taxableIncome / 12

        If taxableMonthlyIncome < 10001 Then
            taxDeduction = taxableMonthlyIncome * 0.05
        ElseIf taxableMonthlyIncome > 10000 And taxableMonthlyIncome < 30001 Then
            taxDeduction = 500 + ((taxableMonthlyIncome - 10000) * 0.1)
        ElseIf taxableMonthlyIncome > 30000 And taxableMonthlyIncome < 70001 Then
            taxDeduction = 2500 + ((taxableMonthlyIncome - 30000) * 0.15)
        ElseIf taxableMonthlyIncome > 70000 And taxableMonthlyIncome < 140001 Then
            taxDeduction = 8500 + ((taxableMonthlyIncome - 70000) * 0.2)
        End If
        Return taxDeduction
    End Function

    Function getDeductedSalary(salary As Double) As Double
        Dim deductedSalary As Double
        Dim sss As Double = getSssDeduction(salary)
        Dim pagibig As Double = getPagibigDeduction(salary)
        Dim philhealth As Double = getPhilHealthDeduction(salary)
        Dim totalDeduction As Double = sss + pagibig + philhealth
        deductedSalary = salary - totalDeduction
        Return deductedSalary
    End Function

    Public Sub load()
        Dim pagIbig As Double = getPagibigDeduction(Double.Parse(salary))
        Dim sss As Double = getSssDeduction(Double.Parse(salary))
        Dim philHealth As Double = getPhilHealthDeduction(Double.Parse(salary))
        Dim deductedSalary As Double = getDeductedSalary(Double.Parse(salary))
        Dim incomeTax As Double = getTaxDeduction(deductedSalary)
        Dim netIncome As Double = Double.Parse(salary) - (pagIbig + sss + philHealth + incomeTax)
        lblDepartment.Text = department
        lblJob.Text = job
        lblId.Text = id
        lblName.Text = firstname & " " & lastname
        lblGrossIncome.Text = salary
        lblPagibig.Text = pagIbig.ToString()
        lblSSS.Text = sss.ToString()
        lblPhilhealth.Text = philHealth.ToString()
        lblIncomeTax.Text = incomeTax.ToString()
        lblNetIncome.Text = netIncome.ToString()

    End Sub


End Class