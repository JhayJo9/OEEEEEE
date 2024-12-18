Imports MySql.Data.MySqlClient

Public Class frmStudentDashboard
    Private currentStudentId As Integer

    Public Sub New(studentId As Integer)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        currentStudentId = studentId
    End Sub

    Private Sub frmStudentDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeDataGridView()
        LoadStudentData()
    End Sub

    Private Sub InitializeDataGridView()
        With DataGridView1
            .Columns.Clear() ' Clear existing columns if any
            .Columns.Add("course_name", "Course Name")
            .Columns.Add("assessment_type_name", "Assessment Type")
            .Columns.Add("question_count", "Question Count")
            .Columns.Add("status", "Status")
            Dim btnCol As New DataGridViewButtonColumn()
            btnCol.HeaderText = "Take Exam"
            btnCol.Name = "TakeExam" ' Use a meaningful name
            btnCol.Text = "Take Exam"
            btnCol.UseColumnTextForButtonValue = True
            .Columns.Add(btnCol)
        End With
    End Sub

    Private Sub LoadStudentData()
        Dim query As String = "SELECT c.course_name, a.assessment_type_name, COUNT(q.question_id) AS question_count, " &
                              "CASE WHEN sr.status IS NOT NULL THEN 'Taken' ELSE 'Not Taken' END AS status " &
                              "FROM section_assignments sa " &
                              "JOIN courses c ON sa.course_id = c.course_id " &
                              "JOIN assessment_types a ON sa.assessment_type_id = a.assessment_type_id " &
                              "LEFT JOIN questions q ON sa.question_id = q.question_id " &
                              "LEFT JOIN (SELECT q.course_id, q.assessment_type_id, 'Taken' AS status " &
                              "           FROM student_responses sr " &
                              "           JOIN questions q ON sr.question_id = q.question_id " &
                              "           WHERE sr.student_id = @student_id " &
                              "           GROUP BY q.course_id, q.assessment_type_id) sr " &
                              "ON sa.course_id = sr.course_id AND sa.assessment_type_id = sr.assessment_type_id " &
                              "JOIN students stu ON stu.section_id = sa.section_id " &
                              "WHERE stu.student_id = @student_id " &
                              "GROUP BY c.course_name, a.assessment_type_name, sr.status"

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                cmd.Parameters.AddWithValue("@student_id", currentStudentId)
                Using reader As MySqlDataReader = cmd.ExecuteReader
                    DataGridView1.Rows.Clear() ' Clear existing rows
                    While reader.Read()
                        Dim course As String = reader.GetString("course_name")
                        Dim assess As String = reader.GetString("assessment_type_name")
                        Dim count As Integer = reader.GetInt32("question_count")
                        Dim status As String = reader.GetString("status")

                        DataGridView1.Rows.Add(course, assess, count, status)
                    End While
                End Using
            End Using
            DatabaseModule.closeconnection()
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            ' Check if the clicked cell is in the "Take Exam" column
            If e.ColumnIndex = DataGridView1.Columns("TakeExam").Index AndAlso e.RowIndex >= 0 Then
                Dim courseName As String = DataGridView1.Rows(e.RowIndex).Cells("course_name").Value.ToString()
                Dim assessmentTypeName As String = DataGridView1.Rows(e.RowIndex).Cells("assessment_type_name").Value.ToString()
                ' Get course_id and assessment_type_id from the respective functions
                Dim courseId As Integer = GetCourseId(courseName)
                Dim assessmentTypeId As Integer = GetAssessmentTypeId(assessmentTypeName)
                Dim statuss As String = DataGridView1.Rows(e.RowIndex).Cells("status").Value.ToString()
                If statuss = "Taken" Then
                    MsgBox("fsdgs")
                Else
                    ' Show the Take Exam form
                    Dim frm As New frmTakeExam(currentStudentId, courseId, assessmentTypeId)
                    frm.ShowDialog()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Function GetCourseId(courseName As String) As Integer
        Dim query As String = "SELECT course_id FROM courses WHERE course_name = @course_name"
        Dim courseId As Integer = 0

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                cmd.Parameters.AddWithValue("@course_name", courseName)
                courseId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
            DatabaseModule.closeconnection()
        End If

        Return courseId
    End Function

    Private Function GetAssessmentTypeId(assessmentTypeName As String) As Integer
        Dim query As String = "SELECT assessment_type_id FROM assessment_types WHERE assessment_type_name = @assessment_type_name"
        Dim assessmentTypeId As Integer = 0

        If DatabaseModule.openconnection() Then
            Using cmd As New MySqlCommand(query, DatabaseModule.conn)
                cmd.Parameters.AddWithValue("@assessment_type_name", assessmentTypeName)
                assessmentTypeId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
            DatabaseModule.closeconnection()
        End If

        Return assessmentTypeId
    End Function
End Class