<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnRegisterStudent = New Button()
        btnAssignSections = New Button()
        btnAddQuestion = New Button()
        SuspendLayout()
        ' 
        ' btnRegisterStudent
        ' 
        btnRegisterStudent.Location = New Point(97, 335)
        btnRegisterStudent.Name = "btnRegisterStudent"
        btnRegisterStudent.Size = New Size(94, 29)
        btnRegisterStudent.TabIndex = 0
        btnRegisterStudent.Text = "R"
        btnRegisterStudent.UseVisualStyleBackColor = True
        ' 
        ' btnAssignSections
        ' 
        btnAssignSections.Location = New Point(227, 329)
        btnAssignSections.Name = "btnAssignSections"
        btnAssignSections.Size = New Size(94, 29)
        btnAssignSections.TabIndex = 1
        btnAssignSections.Text = "AS"
        btnAssignSections.UseVisualStyleBackColor = True
        ' 
        ' btnAddQuestion
        ' 
        btnAddQuestion.Location = New Point(368, 335)
        btnAddQuestion.Name = "btnAddQuestion"
        btnAddQuestion.Size = New Size(94, 29)
        btnAddQuestion.TabIndex = 2
        btnAddQuestion.Text = "AQ\"
        btnAddQuestion.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnAddQuestion)
        Controls.Add(btnAssignSections)
        Controls.Add(btnRegisterStudent)
        Name = "frmMain"
        Text = "frmMain"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnRegisterStudent As Button
    Friend WithEvents btnAssignSections As Button
    Friend WithEvents btnAddQuestion As Button
End Class
