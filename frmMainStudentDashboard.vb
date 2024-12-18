Public Class frmMainStudentDashboard
    Private Sub btnExam_Click(sender As Object, e As EventArgs) Handles btnExam.Click

        Dim studentId As Integer = 2 ' Assuming you have a studentId variable
        ' Create an instance of frmStudentDashboard
        Dim studentDashboard As New frmStudentDashboard(studentId) ' Assuming you have a currentStudentId variable

        ' Set the form properties to be embedded in the panel
        studentDashboard.TopLevel = False
        studentDashboard.FormBorderStyle = FormBorderStyle.None
        studentDashboard.Dock = DockStyle.Fill

        ' Clear existing controls and add the new form
        Panel2.Controls.Clear()
        Panel2.Controls.Add(studentDashboard)

        ' Show the form
        studentDashboard.Show()
        studentDashboard.BringToFront()
    End Sub

End Class