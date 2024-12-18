Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmAssignSections

    Private Sub frmAssignSections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
        LoadSections()
    End Sub

    Private Sub LoadStudents()
        Dim query As String = "SELECT student_id, student_name FROM students"
        Dim dt As New DataTable()

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If

        'cmbStudent.DataSource = dt
        'cmbStudent.DisplayMember = "student_name"
        'cmbStudent.ValueMember = "student_id"
    End Sub

    Private Sub LoadSections()
        Dim query As String = "SELECT section_id, section_name FROM sections"
        Dim dt As New DataTable()

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If

        'cmbSection.DataSource = dt
        'cmbSection.DisplayMember = "section_name"
        'cmbSection.ValueMember = "section_id"
    End Sub

    'Private Sub btnAssign_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
    '    'Dim studentId As Integer = Convert.ToInt32(cmbStudent.SelectedValue)
    '    'Dim sectionId As Integer = Convert.ToInt32(cmbSection.SelectedValue)

    '    Dim query As String = "UPDATE students SET section_id = @section_id WHERE student_id = @student_id"

    '    If DatabaseModule.openconnection() Then
    '        Using cmd As New MySqlCommand(query, DatabaseModule.conn)
    '            ' Add parameters to the command
    '            cmd.Parameters.AddWithValue("@section_id", sectionId)
    '            cmd.Parameters.AddWithValue("@student_id", studentId)

    '            ' Execute the command
    '            cmd.ExecuteNonQuery()
    '        End Using
    '        DatabaseModule.closeconnection()
    '    End If

    '    MessageBox.Show("Section assigned successfully!")
    'End Sub
End Class