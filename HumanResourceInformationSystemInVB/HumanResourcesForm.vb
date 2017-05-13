Imports System.Text.RegularExpressions
Imports Npgsql
Public Class HumanResourcesForm
    Dim str As String = "Server= 127.0.0.1;Port=5432;Database=hr_information_system_db;User Id=postgres;Password=1234;"
    Dim con As New NpgsqlConnection(str)
    Dim resourceId As String
    Dim departmentName As String
    Dim jobId As Integer
    Dim departmentId As Integer
    Dim requiredPersonnel As String
    Dim acquiredPersonnel As String
    Dim avalablePosition As String


    Friend Function checkJobExistence(jobId As Integer, departmentId As Integer) As Boolean
        con.Open()
        Dim cmd As New NpgsqlCommand
        Try
            Dim query As String = "select required_personnel from plantilla where job_id = " & jobId.ToString() & " and department_id=" & departmentId.ToString()
            Dim adpt As New NpgsqlDataAdapter(query, con)
            Dim ds As New DataSet()
            adpt.Fill(ds)
            Dim dt = ds.Tables(0)
            Dim arr(1) As String
            For Each DataRow In dt.Rows
                arr(0) = DataRow(0).ToString()
            Next
            'Dim arr As String() = (From myRow In ds.Tables(0).AsEnumerable Select myRow.Field(Of String)("required_personnel")).ToArray
            Dim query1 As String = "select count (*) from deployment where department_id = " & departmentId.ToString() & " And job_id =" & jobId.ToString()
            Dim adpt1 As New NpgsqlDataAdapter(query1, con)
            Dim ds1 As New DataSet()
            adpt1.Fill(ds1)
            Dim dt1 = ds1.Tables(0)

            Dim arr1(1) As String
            For Each DataRow In dt1.Rows
                arr1(0) = DataRow(0).ToString
            Next
            Dim requiredPersonnel As Integer = Integer.Parse(arr.GetValue(0).ToString())
            Dim personnel As Integer = Integer.Parse(arr1.GetValue(0).ToString())
            con.Close()
            If requiredPersonnel = 0 Then
                Return False
            ElseIf requiredPersonnel = personnel Then
                Return False
            Else
                Return True
            End If
            'MessageBox.Show(requiredPersonnel.ToString() & " " & personnel.ToString())

        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            con.Close()
            Return False

        End Try

    End Function



    Public Sub load()
        Dim query As String = "select pl.id, dept.name as department,job.name as job, pl.job_description, pl.required_personnel,
(select count(*) from deployment as personnel where dept.id=personnel.department_id and job.id = personnel.job_id) as aquired_personnel,
(select (select plan.required_personnel from plantilla plan where plan.id = pl.id ) - (select count(*) from deployment as personnel where dept.id=personnel.department_id and job.id = personnel.job_id)) as vacancy
from plantilla pl inner join department dept on (pl.department_id = dept.id) inner join job job on (pl.job_id = job.id) order by pl.id asc;"
        Dim adpt As New NpgsqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        MetroGrid1.DataSource = ds.Tables(0)
        con.Close()
        txtBoxJobDescription.Clear()
        txtBoxUpdateJobDescription.Clear()
        cbDepartment.Text = ""
        cbJob.Text = ""
        lblId.Text = ""

    End Sub



    Private Sub HumanResourcesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub

    Private Sub MetroLabel1_Click(sender As Object, e As EventArgs) Handles MetroLabel1.Click
        MainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        load()
    End Sub

    Private Sub MetroGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellClick
        Dim row As DataGridViewRow = MetroGrid1.CurrentRow
        Try
            lblId.Text = row.Cells(0).Value.ToString()
            resourceId = row.Cells(0).Value.ToString()
            departmentName = row.Cells(1).Value.ToString()
            txtBoxUpdateJobDescription.Text = row.Cells(3).Value.ToString()
            acquiredPersonnel = row.Cells(5).Value.ToString()
            requiredPersonnel = row.Cells(4).Value.ToString()
            avalablePosition = row.Cells(6).Value.ToString()
            'txtBoxFirstname.Text = row.Cells(2).Value.ToString()
            'txtBoxEmail.Text = row.Cells(3).Value.ToString()
            'txtBoxTinId.Text = row.Cells(7).Value.ToString()
            'txtBoxPagibigId.Text = row.Cells(8).Value.ToString()
            'txtBoxSssId.Text = row.Cells(9).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateJobDescription_Click(sender As Object, e As EventArgs) Handles btnUpdateJobDescription.Click
        If lblId.Text = "" Then
            MessageBox.Show("Please select a record.")
        ElseIf txtBoxUpdateJobDescription.Text = "" Then
            MessageBox.Show("Please input the Updated Job description.")
        Else
            Dim cmd As NpgsqlCommand
            con.Open()
            Try
                cmd = con.CreateCommand()
                cmd.CommandText = "update plantilla set job_description = @updatedJobDescription where id = @resourceId"
                cmd.Parameters.AddWithValue("@updatedJobDescription", txtBoxUpdateJobDescription.Text)
                cmd.Parameters.AddWithValue("@resourceId", Integer.Parse(resourceId))
                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception
                Close()
                load()
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


    Private Sub btnAddJob_Click(sender As Object, e As EventArgs) Handles btnAddJob.Click


        If txtBoxJobDescription.Text = "" Or cbJob.Text = "" Or cbDepartment.text = "" Then
            MessageBox.Show("Input the Job Description.")

        Else
            Dim numOfPersonnel As Integer = Integer.Parse(numNumOfPersonnel.Value)
            If numOfPersonnel < 1 Or numOfPersonnel Mod 1 > 0 Then
                MessageBox.Show("Invalid number of personnel.(positive whole numbers only)")
            Else
                Try
                    'MessageBox.Show("Valid Credentials!!")
                    jobId = cbJob.SelectedIndex + 1
                    departmentId = cbDepartment.SelectedIndex + 1

                    Dim jobExist As Boolean = checkJobExistence(jobId, departmentId)

                    If jobExist Then
                        MessageBox.Show("The Job is already available")

                    Else
                        Try
                            Dim cmd As NpgsqlCommand
                            con.Open()
                            cmd = con.CreateCommand()
                            cmd.CommandText = "insert into plantilla (department_id, job_id, required_personnel, job_description) values (@departmentId, @jobId, @requiredPersonnel, @jobDescription);"
                            cmd.Parameters.AddWithValue("@departmentId", departmentId)
                            cmd.Parameters.AddWithValue("@jobId", jobId)
                            cmd.Parameters.AddWithValue("@requiredPersonnel", numOfPersonnel)
                            cmd.Parameters.AddWithValue("@jobDescription", txtBoxJobDescription.Text)
                            cmd.ExecuteNonQuery()
                            con.Close()
                            MessageBox.Show("Successfully added a Job!")
                            load()
                        Catch ex As Exception
                            Close()
                            load()
                            MessageBox.Show(ex.Message)
                        End Try
                    End If


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub

    Private Sub btnIncreaseRequiredPersonnel_Click(sender As Object, e As EventArgs) Handles btnIncreaseRequiredPersonnel.Click
        If lblId.Text = "" Then
            MessageBox.Show("Please choos a record.")
        Else
            Dim cmd As NpgsqlCommand
            Dim addedPersonnel = Integer.Parse(requiredPersonnel) + 1
            con.Open()
            Try
                cmd = con.CreateCommand()
                cmd.CommandText = "update plantilla set required_personnel = @addedPersonnel where id = @resourceId"
                cmd.Parameters.AddWithValue("@addedPersonnel", addedPersonnel)
                cmd.Parameters.AddWithValue("@resourceId", Integer.Parse(resourceId))
                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception
                Close()
                load()
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnDecreseRequiredPersonnel_Click(sender As Object, e As EventArgs) Handles btnDecreseRequiredPersonnel.Click
        If lblId.Text = "" Then

        ElseIf Integer.Parse(requiredPersonnel) = Integer.Parse(acquiredPersonnel) Or Integer.Parse(requiredPersonnel) = 1 Then
            MessageBox.Show("You cannot further decrease the number of personnel.")
        Else
            Dim cmd As NpgsqlCommand
            Dim decreasedPersonnel = Integer.Parse(requiredPersonnel) - 1
            con.Open()
            Try
                cmd = con.CreateCommand()
                cmd.CommandText = "update plantilla set required_personnel = @decreasedPersonnel where id = @resourceId"
                cmd.Parameters.AddWithValue("@decreasedPersonnel", decreasedPersonnel)
                cmd.Parameters.AddWithValue("@resourceId", Integer.Parse(resourceId))
                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception
                Close()
                load()
                MessageBox.Show(ex.Message)
            End Try

        End If
    End Sub

    Private Sub txtBoxSortRecordsByDepartment_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSortRecordsByDepartment.TextChanged
        Dim adapter As NpgsqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapter = New NpgsqlDataAdapter("select pl.id, dept.name as department,job.name as job, pl.job_description, pl.required_personnel,
(select count(*) from deployment as personnel where dept.id=personnel.department_id and job.id = personnel.job_id) as aquired_personnel,
(select (select plan.required_personnel from plantilla plan where plan.id = pl.id ) - (select count(*) from deployment as personnel where dept.id=personnel.department_id and job.id = personnel.job_id)) as vacancy
from plantilla pl inner join department dept on (pl.department_id = dept.id) inner join job job on (pl.job_id = job.id) where lower(dept.name) like '%" & txtBoxSortRecordsByDepartment.Text & "%' order by pl.id asc", con)
            adapter.Fill(ds)
            MetroGrid1.DataSource = ds.Tables(0)
            con.Close()
            txtBoxJobDescription.Clear()
            txtBoxUpdateJobDescription.Clear()
            cbDepartment.Text = ""
            cbJob.Text = ""
            lblId.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtBoxSortRecordsByJob_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSortRecordsByJob.TextChanged
        Dim adapter As NpgsqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapter = New NpgsqlDataAdapter("select pl.id, dept.name as department,job.name as job, pl.job_description, pl.required_personnel,
(select count(*) from deployment as personnel where dept.id=personnel.department_id and job.id = personnel.job_id) as aquired_personnel,
(select (select plan.required_personnel from plantilla plan where plan.id = pl.id ) - (select count(*) from deployment as personnel where dept.id=personnel.department_id and job.id = personnel.job_id)) as vacancy
from plantilla pl inner join department dept on (pl.department_id = dept.id) inner join job job on (pl.job_id = job.id) where lower(job.name) like '%" & txtBoxSortRecordsByJob.Text & "%' order by pl.id asc", con)
            adapter.Fill(ds)
            MetroGrid1.DataSource = ds.Tables(0)
            con.Close()
            txtBoxJobDescription.Clear()
            txtBoxUpdateJobDescription.Clear()
            cbDepartment.Text = ""
            cbJob.Text = ""
            lblId.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class