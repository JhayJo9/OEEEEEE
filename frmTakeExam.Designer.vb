<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTakeExam
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
        btnPrev = New Button()
        txtQuestion = New TextBox()
        GroupBox1 = New GroupBox()
        rbOptionA = New RadioButton()
        rbOptionB = New RadioButton()
        rbOptionC = New RadioButton()
        rbOptionD = New RadioButton()
        btnNext = New Button()
        btnSubmit = New Button()
        lblCourse = New Label()
        Label2 = New Label()
        lblAssessmentType = New Label()
        Label4 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPrev
        ' 
        btnPrev.Location = New Point(40, 450)
        btnPrev.Name = "btnPrev"
        btnPrev.Size = New Size(94, 29)
        btnPrev.TabIndex = 23
        btnPrev.Text = "Button1"
        btnPrev.UseVisualStyleBackColor = True
        ' 
        ' txtQuestion
        ' 
        txtQuestion.Location = New Point(40, 183)
        txtQuestion.Multiline = True
        txtQuestion.Name = "txtQuestion"
        txtQuestion.Size = New Size(369, 92)
        txtQuestion.TabIndex = 17
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbOptionD)
        GroupBox1.Controls.Add(rbOptionC)
        GroupBox1.Controls.Add(rbOptionB)
        GroupBox1.Controls.Add(rbOptionA)
        GroupBox1.Location = New Point(38, 283)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(892, 152)
        GroupBox1.TabIndex = 24
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' rbOptionA
        ' 
        rbOptionA.AutoSize = True
        rbOptionA.Location = New Point(8, 26)
        rbOptionA.Name = "rbOptionA"
        rbOptionA.Size = New Size(121, 24)
        rbOptionA.TabIndex = 0
        rbOptionA.TabStop = True
        rbOptionA.Text = "RadioButton1"
        rbOptionA.UseVisualStyleBackColor = True
        ' 
        ' rbOptionB
        ' 
        rbOptionB.AutoSize = True
        rbOptionB.Location = New Point(6, 56)
        rbOptionB.Name = "rbOptionB"
        rbOptionB.Size = New Size(121, 24)
        rbOptionB.TabIndex = 1
        rbOptionB.TabStop = True
        rbOptionB.Text = "RadioButton2"
        rbOptionB.UseVisualStyleBackColor = True
        ' 
        ' rbOptionC
        ' 
        rbOptionC.AutoSize = True
        rbOptionC.Location = New Point(6, 86)
        rbOptionC.Name = "rbOptionC"
        rbOptionC.Size = New Size(121, 24)
        rbOptionC.TabIndex = 2
        rbOptionC.TabStop = True
        rbOptionC.Text = "RadioButton3"
        rbOptionC.UseVisualStyleBackColor = True
        ' 
        ' rbOptionD
        ' 
        rbOptionD.AutoSize = True
        rbOptionD.Location = New Point(6, 116)
        rbOptionD.Name = "rbOptionD"
        rbOptionD.Size = New Size(121, 24)
        rbOptionD.TabIndex = 3
        rbOptionD.TabStop = True
        rbOptionD.Text = "RadioButton4"
        rbOptionD.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(140, 450)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(94, 29)
        btnNext.TabIndex = 25
        btnNext.Text = "Button1"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(240, 450)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(94, 29)
        btnSubmit.TabIndex = 26
        btnSubmit.Text = "Button1"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Location = New Point(40, 31)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(53, 20)
        lblCourse.TabIndex = 27
        lblCourse.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(46, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 28
        Label2.Text = "Label2"
        ' 
        ' lblAssessmentType
        ' 
        lblAssessmentType.AutoSize = True
        lblAssessmentType.Location = New Point(38, 51)
        lblAssessmentType.Name = "lblAssessmentType"
        lblAssessmentType.Size = New Size(53, 20)
        lblAssessmentType.TabIndex = 28
        lblAssessmentType.Text = "Label2"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(46, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 29
        Label4.Text = "Label4"
        ' 
        ' frmTakeExam
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1002, 586)
        Controls.Add(Label4)
        Controls.Add(lblAssessmentType)
        Controls.Add(Label2)
        Controls.Add(lblCourse)
        Controls.Add(btnSubmit)
        Controls.Add(btnNext)
        Controls.Add(GroupBox1)
        Controls.Add(btnPrev)
        Controls.Add(txtQuestion)
        Name = "frmTakeExam"
        Text = "frmTakeExam"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrev As Button
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbOptionB As RadioButton
    Friend WithEvents rbOptionA As RadioButton
    Friend WithEvents rbOptionD As RadioButton
    Friend WithEvents rbOptionC As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents lblCourse As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAssessmentType As Label
    Friend WithEvents Label4 As Label
End Class
