Imports System.Web.UI.DataVisualization.Charting
Imports Npgsql
Public Class DashboardForm
    Dim str As String = "Server= 127.0.0.1;Port=5432;Database=hr_information_system_db;User Id=postgres;Password=1234;"
    Dim con As New NpgsqlConnection(str)
    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
        loadWorkForce()
        loadDepartmentEmployee()



    End Sub



    Public Sub load()
        Try
            con.Open()
            Dim query As String = "select (select count(*) from employee where gender = 'Male' and employed=true) as male, (select count(*) from employee where gender = 'Female' and employed = true) as female"
            Dim command As New NpgsqlCommand(query, con)
            Dim reader As NpgsqlDataReader
            reader = command.ExecuteReader()

            While reader.Read
                employeeGender.Series("maleEmployee").Points.AddXY("Employee Gender", reader.GetInt32(0))
                employeeGender.Series("femaleEmployee").Points.AddXY("Employee Gender", reader.GetInt32(1))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        'Dim ds As New DataSet()
        'adpt.Fill(ds)
        'MetroGrid1.DataSource = ds.Tables(0)
        'con.Close()
        'txtBoxLastname.Clear()
        'txtBoxFirstname.Clear()
        'txtBoxEmail.Clear()
        'txtBoxTinId.Clear()
        'txtBoxPagibigId.Clear()
        'txtBoxSssId.Clear()
    End Sub

    Public Sub loadWorkForce()
        Try
            con.Open()
            Dim query As String = "select job.name, (select count (*) from deployment de where de.job_id = job.id) as number_of_employees from job job order by job.id asc;"
            Dim command As New NpgsqlCommand(query, con)
            Dim reader As NpgsqlDataReader
            reader = command.ExecuteReader()

            Dim jobArray(0 To 6) As String
            jobArray(0) = "adminAssistant"
            jobArray(1) = "head"
            jobArray(2) = "technician"
            jobArray(3) = "officeClerk"
            jobArray(4) = "janitorial"
            jobArray(5) = "headAssistant"
            jobArray(6) = "messanger"
            Dim i As Integer = 0

            While reader.Read
                'employeeGender.Series("maleEmployee").Points.AddXY("Employee Gender", reader.GetInt32(0))
                'employeeGender.Series("femaleEmployee").Points.AddXY("Employee Gender", reader.GetInt32(1))

                workForceCount.Series("adminAssistant").Points.AddXY(reader.GetString(0), reader.GetInt32(1))
                workForceCount.Series("head").Points.AddXY(reader.GetString(0), reader.GetInt32(1))
                workForceCount.Series("technician").Points.AddXY(reader.GetString(0), reader.GetInt32(1))
                workForceCount.Series("officeClerk").Points.AddXY(reader.GetString(0), reader.GetInt32(1))
                workForceCount.Series("janitorial").Points.AddXY(reader.GetString(0), reader.GetInt32(1))
                workForceCount.Series("headAssistant").Points.AddXY(reader.GetString(0), reader.GetInt32(1))
                workForceCount.Series("messanger").Points.AddXY(reader.GetString(0), reader.GetInt32(1))




            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        'Dim ds As New DataSet()
        'adpt.Fill(ds)
        'MetroGrid1.DataSource = ds.Tables(0)
        'con.Close()
        'txtBoxLastname.Clear()
        'txtBoxFirstname.Clear()
        'txtBoxEmail.Clear()
        'txtBoxTinId.Clear()
        'txtBoxPagibigId.Clear()
        'txtBoxSssId.Clear()
    End Sub

    Public Sub loadDepartmentEmployee()
        Try
            con.Open()
            Dim query As String = "select dept.name, (select count(*) from deployment de where de.department_id = dept.id) from department dept order by dept.id asc;"
            Dim command As New NpgsqlCommand(query, con)
            Dim reader As NpgsqlDataReader
            reader = command.ExecuteReader()



            While reader.Read
                'employeeGender.Series("maleEmployee").Points.AddXY("Employee Gender", reader.GetInt32(0))
                'employeeGender.Series("femaleEmployee").Points.AddXY("Employee Gender", reader.GetInt32(1))

                departmentEmployee.Series("numberOfEmployees").Points.AddXY(reader.GetString(0), reader.GetInt32(1))
                'departmentEmployee.Series("sales").Points.AddXY(reader.GetString(0), reader.GetInt32(1))
                'departmentEmployee.Series("humanResource").Points.AddXY(reader.GetString(0), reader.GetInt32(1))
                'departmentEmployee.Series("legal").Points.AddXY(reader.GetString(0), reader.GetInt32(1))
                'departmentEmployee.Series("maintenance").Points.AddXY(reader.GetString(0), reader.GetInt32(1))




            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

        'Dim ds As New DataSet()
        'adpt.Fill(ds)
        'MetroGrid1.DataSource = ds.Tables(0)
        'con.Close()
        'txtBoxLastname.Clear()
        'txtBoxFirstname.Clear()
        'txtBoxEmail.Clear()
        'txtBoxTinId.Clear()
        'txtBoxPagibigId.Clear()
        'txtBoxSssId.Clear()
    End Sub

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click
        MainForm.Show()
        Me.Hide()
    End Sub
End Class