<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentRegistration
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
        cmbSection = New ComboBox()
        btnRegister = New Button()
        txtStudentName = New TextBox()
        SuspendLayout()
        ' 
        ' cmbSection
        ' 
        cmbSection.FormattingEnabled = True
        cmbSection.Location = New Point(106, 120)
        cmbSection.Name = "cmbSection"
        cmbSection.Size = New Size(151, 28)
        cmbSection.TabIndex = 0
        ' 
        ' btnRegister
        ' 
        btnRegister.Location = New Point(106, 183)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(94, 29)
        btnRegister.TabIndex = 1
        btnRegister.Text = "Button1"
        btnRegister.UseVisualStyleBackColor = True
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Location = New Point(106, 70)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.Size = New Size(125, 27)
        txtStudentName.TabIndex = 2
        ' 
        ' frmStudentRegistration
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 442)
        Controls.Add(txtStudentName)
        Controls.Add(btnRegister)
        Controls.Add(cmbSection)
        Name = "frmStudentRegistration"
        Text = "frmStudentRegistration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbSection As ComboBox
    Friend WithEvents btnRegister As Button
    Friend WithEvents txtStudentName As TextBox
End Class
