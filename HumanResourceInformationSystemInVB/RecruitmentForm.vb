Imports Npgsql
Public Class RecruitmentForm
    Dim str As String = "Server= 127.0.0.1;Port=5432;Database=hr_information_system_db;User Id=postgres;Password=1234;"
    Dim con As New NpgsqlConnection(str)
    Public Sub load()
        Dim query As String = "select id, lastname, firstname, email, tin_id , pagibig_id, sss_id, philhealth_id, gender from employee where admin = false and employed = false order by id asc"
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
        cbGender.Text = ""
        txtBoxPhilhealth.Clear()
    End Sub
    Private Sub RecruitmentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load()
    End Sub


    Private Sub btnAddApplicant_Click(sender As Object, e As EventArgs) Handles btnAddApplicant.Click
        If (txtBoxFirstname.Text = "" Or txtBoxLastname.Text = "" Or txtBoxEmail.Text = "" Or txtBoxTinId.Text = "" Or txtBoxPagibigId.Text = "" Or txtBoxSssId.Text = "" Or txtBoxPhilhealth.Text = "" Or cbGender.Text = "") Then
            MessageBox.Show("Complete the Application details.")
        Else
            Dim cmd As NpgsqlCommand
            con.Open()
            Try
                cmd = con.CreateCommand
                cmd.CommandText = "insert into employee (lastname, firstname, email, tin_id, pagibig_id, sss_id, philhealth_id, gender)values(@lastname, @firstname, @email, @tin_id, @pagibig_id, @sss_id, @philhealth_id, @gender)"
                cmd.Parameters.AddWithValue("@lastname", txtBoxLastname.Text)
                cmd.Parameters.AddWithValue("@firstname", txtBoxFirstname.Text)
                cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text)
                cmd.Parameters.AddWithValue("@tin_id", txtBoxTinId.Text)
                cmd.Parameters.AddWithValue("@pagibig_id", txtBoxPagibigId.Text)
                cmd.Parameters.AddWithValue("@sss_id", txtBoxSssId.Text)
                cmd.Parameters.AddWithValue("@philhealth_id", txtBoxPhilhealth)
                cmd.Parameters.AddWithValue("@gender", cbGender.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                load()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub MetroGrid1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles MetroGrid1.CellClick
        Dim row As DataGridViewRow = MetroGrid1.CurrentRow
        Try
            id.Text = row.Cells(0).Value.ToString()
            txtBoxLastname.Text = row.Cells(1).Value.ToString()
            txtBoxFirstname.Text = row.Cells(2).Value.ToString()
            txtBoxEmail.Text = row.Cells(3).Value.ToString()
            txtBoxTinId.Text = row.Cells(4).Value.ToString()
            txtBoxPagibigId.Text = row.Cells(5).Value.ToString()
            txtBoxSssId.Text = row.Cells(6).Value.ToString()
            txtBoxPhilhealth.Text = row.Cells(7).Value.ToString()
            cbGender.Text = row.Cells(8).Value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        load()
    End Sub

    Private Sub btnUpdateApplicant_Click(sender As Object, e As EventArgs) Handles btnUpdateApplicant.Click
        If (txtBoxFirstname.Text = "" Or txtBoxLastname.Text = "" Or txtBoxEmail.Text = "" Or txtBoxTinId.Text = "" Or txtBoxPagibigId.Text = "" Or txtBoxSssId.Text = "" Or txtBoxPhilhealth.Text = "" Or cbGender.Text = "") Then
            MessageBox.Show("Please Select a record.")
        Else
            Dim cmd As NpgsqlCommand
            con.Open()
            Try
                cmd = con.CreateCommand()
                cmd.CommandText = "update employee set lastname=@lastname, firstname=@firstname, email=@email, tin_id=@tin_id, pagibig_id =@pagibig_id, sss_id = @sss_id, philhealth_id = @philhealth_id, gender=@gender where id=@id"
                cmd.Parameters.AddWithValue("@lastname", txtBoxLastname.Text)
                cmd.Parameters.AddWithValue("@firstname", txtBoxFirstname.Text)
                cmd.Parameters.AddWithValue("@email", txtBoxEmail.Text)
                cmd.Parameters.AddWithValue("@tin_id", txtBoxTinId.Text)
                cmd.Parameters.AddWithValue("@pagibig_id", txtBoxPagibigId.Text)
                cmd.Parameters.AddWithValue("@sss_id", txtBoxSssId.Text)
                cmd.Parameters.AddWithValue("@philhealth_id", txtBoxPhilhealth.Text)
                cmd.Parameters.AddWithValue("@gender", cbGender.Text)
                cmd.Parameters.AddWithValue("@id", Integer.Parse(id.Text))
                cmd.ExecuteNonQuery()
                con.Close()
                load()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If


    End Sub

    Private Sub btnDeleteApplicant_Click(sender As Object, e As EventArgs) Handles btnDeleteApplicant.Click
        Dim cmd As NpgsqlCommand
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandText = "delete from employee where id=@id"
            cmd.Parameters.AddWithValue("@id", Integer.Parse(id.Text))
            cmd.ExecuteNonQuery()
            con.Close()
            load()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtBoxSeachByLastname_TextChanged(sender As Object, e As EventArgs) Handles txtBoxSeachByLastname.TextChanged
        Dim adapter As NpgsqlDataAdapter
        Dim ds As New DataSet
        Try
            con.Open()
            adapter = New NpgsqlDataAdapter("select id, lastname, firstname, email, tin_id , pagibig_id, sss_id, philhealth_id, gender from employee where admin=false and employed=false and lower(lastname) like '%" & txtBoxSeachByLastname.Text & "%'", con)
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

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If id.Text = " " Then
            MessageBox.Show("Please choose an applicant")
        Else
            HireForm.applicantName = txtBoxFirstname.Text + " " + txtBoxLastname.Text
            HireForm.id = id.Text
            HireForm.show()
        End If
    End Sub

    Private Sub MetroLabel8_Click(sender As Object, e As EventArgs) Handles MetroLabel8.Click

        MainForm.Show()
        Me.Hide()
    End Sub


End Class