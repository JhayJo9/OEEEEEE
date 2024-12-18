Public Class frmMain

    Private Sub btnAddQuestion_Click(sender As Object, e As EventArgs) Handles btnAddQuestion.Click
        Dim frm As New frmAddQuestion()
        frm.ShowDialog()
    End Sub

    Private Sub btnRegisterStudent_Click(sender As Object, e As EventArgs) Handles btnRegisterStudent.Click
        Dim frm As New frmStudentRegistration()
        frm.ShowDialog()
    End Sub

    Private Sub btnAssignSections_Click(sender As Object, e As EventArgs) Handles btnAssignSections.Click
        'Dim frm As New frmAssignSections()
        'frm.ShowDialog()
    End Sub
End Class