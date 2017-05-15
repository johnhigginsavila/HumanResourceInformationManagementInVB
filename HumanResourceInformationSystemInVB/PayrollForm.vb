

Imports Npgsql
Public Class Payroll



    Dim str As String = "Server= 127.0.0.1;Port=5432;Database=hr_information_system_db;User Id=postgres;Password=1234;"
    Dim con As New NpgsqlConnection(str)
    Dim id As String = ""
    Dim lastname As String = ""
    Dim firstname As String = ""
    Dim email As String = ""
    Dim department As String = ""
    Dim job As String = ""
    Dim salary As String = ""


    Public Sub load()
        Dim query As String = "select em.id, em.lastname, em.firstname, em.email, dept.name as department, job.name as job, sal.salary, em.tin_id , em.pagibig_id, em.sss_id, de.start_date, de.end_date, em.philhealth_id, em.gender from employee em inner join deployment de on(em.id = de.employee_id) inner join department dept on (de.department_id = dept.id) inner join job job on (de.job_id = job.id) inner join salary sal on (job.salary_grade = sal.id) where em.employed = true order by em.id asc"
        Dim adpt As New NpgsqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds)
        MetroGrid1.DataSource = ds.Tables(0)
        lblId.Text = ""
        lblName.Text = ""
        lblJob.Text = ""
        lblDepartment.Text = ""
        'con.Close()
        'txtBoxLastname.Clear()
        'txtBoxFirstname.Clear()
        'txtBoxEmail.Clear()
        'txtBoxTinId.Clear()
        'txtBoxPagibigId.Clear()
        'txtBoxSssId.Clear()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If lblId.Text = "" Then
            MessageBox.Show("Please select a record.")
        Else

            PaySlip.firstname = firstname
            PaySlip.lastname = lastname
            PaySlip.id = id
            PaySlip.job = job
            PaySlip.department = department
            PaySlip.salary = salary
            PaySlip.Show()

        End If
    End Sub

    Private Sub Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub MetroGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellClick
        Dim row As DataGridViewRow = MetroGrid1.CurrentRow
        Try
            id = row.Cells(0).Value.ToString()
            lastname = row.Cells(1).Value.ToString()
            firstname = row.Cells(2).Value.ToString()
            email = row.Cells(3).Value.ToString()
            department = row.Cells(4).Value.ToString()
            job = row.Cells(5).Value.ToString()
            salary = row.Cells(6).Value.ToString()
            lblId.Text = id
            lblName.Text = firstname & " " & lastname
            lblDepartment.Text = department
            lblJob.Text = job
            'txtBoxTinId.Text = row.Cells(7).Value.ToString()
            'txtBoxPagibigId.Text = row.Cells(8).Value.ToString()
            'txtBoxSssId.Text = row.Cells(9).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click
        MainForm.Show()
        Me.Hide()
    End Sub
End Class