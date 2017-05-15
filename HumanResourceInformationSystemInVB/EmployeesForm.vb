Imports Npgsql
Public Class Employees
    Dim str As String = "Server= 127.0.0.1;Port=5432;Database=hr_information_system_db;User Id=postgres;Password=1234;"
    Dim con As New NpgsqlConnection(str)




    Public Sub load()
        Dim query As String = "select em.id, em.lastname, em.firstname, em.email, dept.name as department, job.name as job, sal.salary, em.tin_id , em.pagibig_id, em.sss_id, de.start_date, de.end_date, em.philhealth_id, em.gender from employee em inner join deployment de on(em.id = de.employee_id) inner join department dept on (de.department_id = dept.id) inner join job job on (de.job_id = job.id) inner join salary sal on (job.salary_grade = sal.id) where em.employed = true order by em.id asc"
        Dim adpt As New NpgsqlDataAdapter(query, con)
        Dim ds As New DataSet()
        adpt.Fill(ds)
        MetroGrid1.DataSource = ds.Tables(0)
        con.Close()
        txtBoxLastname.Clear()
        txtBoxFirstname.Clear()
        txtBoxEmail.Clear()
        txtBoxTinId.Clear()
        txtBoxPagibigId.Clear()
        txtBoxSssId.Clear()
    End Sub
    Private Sub Employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim cmd As NpgsqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "update employee set lastname=@lastname, firstname=@firstname, email=@email, tin_id=@tin_id, pagibig_id =@pagibig_id, sss_id = @sss_id, philhealth_id=@philhealth_id, gender=@gender where id=@id"
            cmd.Parameters.AddWithValue("@lastname", txtBoxLastname.Text)
            cmd.Parameters.AddWithValue("@firstname", txtBoxFirstname.Text)
            cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text)
            cmd.Parameters.AddWithValue("@tin_id", txtBoxTinId.Text)
            cmd.Parameters.AddWithValue("@pagibig_id", txtBoxPagibigId.Text)
            cmd.Parameters.AddWithValue("@sss_id", txtBoxSssId.Text)
            cmd.Parameters.AddWithValue("@philhealth_id", txtBoxPhilhealthId.text)
            cmd.Parameters.AddWithValue("@gender", cbGender.text)
            cmd.Parameters.AddWithValue("@id", Integer.Parse(lblId.Text))
            cmd.ExecuteNonQuery()
            con.Close()
            load()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If lblId.Text = " " Then
            MessageBox.Show("Please choose an employee.")
        Else

            Dim cmd As NpgsqlCommand
            Dim cmd2 As NpgsqlCommand

            con.Open()
            Try
                cmd = con.CreateCommand()
                cmd.CommandText = "update employee set employed = false where id=@id"
                cmd.Parameters.AddWithValue("@id", Integer.Parse(lblId.Text))
                cmd.ExecuteNonQuery()
                cmd2 = con.CreateCommand()
                cmd2.CommandText = "delete from deployment where employee_id = @id"
                cmd2.Parameters.AddWithValue("@id", Integer.Parse(lblId.Text))
                cmd2.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        load()
    End Sub

    Private Sub txtBoxSearchByLastname_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSearchByLastname.TextChanged
        Dim adapter As NpgsqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapter = New NpgsqlDataAdapter("select em.id, em.lastname, em.firstname, em.email, dept.name as department, job.name as job, sal.salary, em.tin_id , em.pagibig_id, em.sss_id, de.start_date, de.end_date, em.philhealth_id, em.gender from employee em inner join deployment de on(em.id = de.employee_id) inner join department dept on (de.department_id = dept.id) inner join job job on (de.job_id = job.id) inner join salary sal on (job.salary_grade = sal.id) where employed=true and lower(em.lastname) like '%" & txtBoxSearchByLastname.Text & "%'", con)
            adapter.Fill(ds)
            MetroGrid1.DataSource = ds.Tables(0)
            con.Close()
            txtBoxLastname.Clear()
            txtBoxFirstname.Clear()
            txtBoxEmail.Clear()
            txtBoxTinId.Clear()
            txtBoxPagibigId.Clear()
            txtBoxSssId.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MetroGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellClick
        Dim row As DataGridViewRow = MetroGrid1.CurrentRow
        Try
            lblId.Text = row.Cells(0).Value.ToString()
            txtBoxLastname.Text = row.Cells(1).Value.ToString()
            txtBoxFirstname.Text = row.Cells(2).Value.ToString()
            txtBoxEmail.Text = row.Cells(3).Value.ToString()
            txtBoxTinId.Text = row.Cells(7).Value.ToString()
            txtBoxPagibigId.Text = row.Cells(8).Value.ToString()
            txtBoxSssId.Text = row.Cells(9).Value.ToString()
            txtBoxPhilhealthId.Text = row.Cells(12).Value.ToString()
            cbGender.Text = row.Cells(13).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MetroLabel8_Click(sender As Object, e As EventArgs) Handles MetroLabel8.Click
        MainForm.Show()
        Me.Hide()
    End Sub




End Class