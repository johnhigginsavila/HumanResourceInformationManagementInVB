Imports Npgsql

Public Class formLogIn
    Dim conn As New Npgsql.NpgsqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If txtBoxEmail.Text = "" Then
            MsgBox("Enter Email")
        ElseIf txtBoxPassword.Text = "" Then
            MsgBox("Enter Password")
        Else

            Dim connection As New NpgsqlConnection("Server= 127.0.0.1;Port=5432;Database=hr_information_system_db;User Id=postgres;Password=1234")
            Dim command As New NpgsqlCommand("SELECT * FROM employee WHERE email = @email AND password = @password", connection)
            command.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = txtBoxEmail.Text
            command.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = txtBoxPassword.Text
            Dim adapter As New NpgsqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count() <= 0 Then
                MessageBox.Show("Username or password Are Invalid")
            Else

                Dim command2 As New NpgsqlCommand("SELECT * FROM employee WHERE email = @email AND password = @password AND admin = @admin", connection)
                command2.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar).Value = txtBoxEmail.Text
                command2.Parameters.Add("@password", NpgsqlTypes.NpgsqlDbType.Varchar).Value = txtBoxPassword.Text
                command2.Parameters.Add("@admin", NpgsqlTypes.NpgsqlDbType.Boolean).Value = True
                Dim adapter2 As New NpgsqlDataAdapter(command2)
                Dim table2 As New DataTable()
                adapter2.Fill(table2)
                If table2.Rows.Count() <= 0 Then
                    MessageBox.Show("You are not an admin")
                Else
                    MessageBox.Show("Log In successful")
                    Me.Hide()
                    MainForm.Show()
                End If


            End If
        End If
    End Sub




End Class
