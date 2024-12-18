Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmStudentRegistration

    Private Sub frmStudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSections()
    End Sub

    Private Sub LoadSections()
        Dim query As String = "SELECT * FROM sections"
        Dim dt As New DataTable()

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If

        cmbSection.DataSource = dt
        cmbSection.DisplayMember = "section_name"
        cmbSection.ValueMember = "section_id"
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim studentName As String = txtStudentName.Text
        Dim sectionId As Integer = Convert.ToInt32(cmbSection.SelectedValue)

        Dim query As String = "INSERT INTO students (student_name, section_id) VALUES (@student_name, @section_id)"

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                ' Add parameters to the command
                cmd.Parameters.AddWithValue("@student_name", studentName)
                cmd.Parameters.AddWithValue("@section_id", sectionId)

                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using
            DatabaseModule.closeconnection()
        End If

        MessageBox.Show("Student registered successfully!")
    End Sub
End Class