Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmAddQuestion

    Private Sub frmAddQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCourses()
        LoadSections()
        LoadAssessmentTypes()
    End Sub

    Private Sub LoadCourses()
        Dim query As String = "SELECT * FROM courses"
        Dim dt As New DataTable()

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If

        cmbCourse.DataSource = dt
        cmbCourse.DisplayMember = "course_name"
        cmbCourse.ValueMember = "course_id"
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

    Private Sub LoadAssessmentTypes()
        Dim query As String = "SELECT * FROM assessment_types"
        Dim dt As New DataTable()

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If

        cmbAssessmentType.DataSource = dt
        cmbAssessmentType.DisplayMember = "assessment_type_name"
        cmbAssessmentType.ValueMember = "assessment_type_id"
    End Sub

    Private Sub btnAddQuestion_Click(sender As Object, e As EventArgs) Handles btnAddQuestion.Click
        Dim courseId As Integer = Convert.ToInt32(cmbCourse.SelectedValue)
        Dim sectionId As Integer = Convert.ToInt32(cmbSection.SelectedValue)
        Dim assessmentTypeId As Integer = Convert.ToInt32(cmbAssessmentType.SelectedValue)
        Dim questionText As String = txtQuestion.Text
        Dim optionA As String = txtOptionA.Text
        Dim optionB As String = txtOptionB.Text
        Dim optionC As String = txtOptionC.Text
        Dim optionD As String = txtOptionD.Text
        Dim correctAnswer As String = cmbCorrectAnswer.SelectedItem.ToString()

        Dim query As String = "INSERT INTO questions (course_id, assessment_type_id, section_id, question_text, optiona, optionb, optionc, optiond, correct_answer) " &
                              "VALUES (@course_id, @assessment_type_id, @section_id, @question_text, @optiona, @optionb, @optionc, @optiond, @correct_answer)"

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                ' Add parameters to the command
                cmd.Parameters.AddWithValue("@course_id", courseId)
                cmd.Parameters.AddWithValue("@assessment_type_id", assessmentTypeId)
                cmd.Parameters.AddWithValue("@section_id", sectionId)
                cmd.Parameters.AddWithValue("@question_text", questionText)
                cmd.Parameters.AddWithValue("@optiona", optionA)
                cmd.Parameters.AddWithValue("@optionb", optionB)
                cmd.Parameters.AddWithValue("@optionc", optionC)
                cmd.Parameters.AddWithValue("@optiond", optionD)
                cmd.Parameters.AddWithValue("@correct_answer", correctAnswer)

                ' Execute the command
                cmd.ExecuteNonQuery()
            End Using
            DatabaseModule.closeconnection()
        End If

        MessageBox.Show("Question added successfully!")
    End Sub
End Class