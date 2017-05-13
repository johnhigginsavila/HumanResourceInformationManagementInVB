Imports Npgsql
Public Class HireForm
    Public id As String
    Public applicantName As String
    Dim str As String = "Server= 127.0.0.1;Port=5432;Database=hr_information_system_db;User Id=postgres;Password=1234;"
    Dim con As New NpgsqlConnection(str)

    Friend Function checkJobAvailability(jobId As Integer, departmentId As Integer) As Boolean
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
    Private Sub HireForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblID.Text = id
        lblName.Text = applicantName

    End Sub

    Private Sub btnHireApplicant_Click(sender As Object, e As EventArgs) Handles btnHireApplicant.Click
        If cbDepartment.Text = "" Or cbJob.Text = "" Then
            MessageBox.Show("Complete the form to continue.")
        Else
            Dim departmentId As Integer = cbDepartment.SelectedIndex + 1
            Dim jobId As Integer = cbJob.SelectedIndex + 1
            Dim employeeId As Integer = id
            Dim startDate As Date = calStartDate.Value
            Dim endDate As Date = calEndDate.Value
            'MessageBox.Show("DepartmentID: " + departmentId.ToString + " JobID: " + jobId.ToString)
            Dim result As Boolean = checkJobAvailability(jobId, departmentId)
            'MessageBox.Show(result.ToString())

            If result = False Then
                MessageBox.Show("There are no opennings for this position!")
            Else

                'MessageBox.Show("Start date: " & startDate & ", End Date: " & endDate)
                Dim cmd As NpgsqlCommand
                con.Open()
                Try
                    cmd = con.CreateCommand
                    cmd.CommandText = "insert into deployment (employee_id, department_id, job_id, start_date, end_date)values(@employeeId, @departmentId, @jobId, @startDate, @endDate)"
                    cmd.Parameters.AddWithValue("@employeeId", employeeId)
                    cmd.Parameters.AddWithValue("@departmentId", departmentId)
                    cmd.Parameters.AddWithValue("@jobId", jobId)
                    cmd.Parameters.AddWithValue("@startDate", startDate)
                    cmd.Parameters.AddWithValue("@endDate", endDate)
                    cmd.ExecuteNonQuery()
                    cmd = con.CreateCommand()
                    cmd.CommandText = "update employee set employed=true where id=@id"
                    cmd.Parameters.AddWithValue("@id", employeeId)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    Me.Hide()
                    RecruitmentForm.load()
                    RecruitmentForm.Show()
                    MessageBox.Show("Successfully added" & applicantName & " as a new Employee")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try


            End If
        End If
    End Sub
End Class