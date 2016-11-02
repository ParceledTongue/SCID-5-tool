Public Class StartForm

    Private Sub StartForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.Database1DataSet.subject)
        'TODO: This line of code loads data into the 'Database1DataSet.study' table. You can move, or remove it, as needed.
        Me.StudyTableAdapter.Fill(Me.Database1DataSet.study)
        'TODO: This line of code loads data into the 'Database1DataSet.rater' table. You can move, or remove it, as needed.
        Me.RaterTableAdapter.Fill(Me.Database1DataSet.rater)
        'TODO: This line of code loads data into the 'Database1DataSet.interview' table. You can move, or remove it, as needed.
        Me.InterviewTableAdapter.Fill(Me.Database1DataSet.interview)
    End Sub

    Private Sub AddSubjectButton_Click(sender As System.Object, e As System.EventArgs) Handles AddSubjectButton.Click
        Dim NewWindow As SubjectEntryForm
        NewWindow = New SubjectEntryForm()
        NewWindow.ShowDialog()
        NewWindow = Nothing
        Me.SubjectTableAdapter.Fill(Me.Database1DataSet.subject)
    End Sub

    Private Sub AddRaterButton_Click(sender As System.Object, e As System.EventArgs) Handles AddRaterButton.Click
        Dim NewWindow As RaterEntryForm
        NewWindow = New RaterEntryForm()
        NewWindow.ShowDialog()
        NewWindow = Nothing
        Me.RaterTableAdapter.Fill(Me.Database1DataSet.rater)
    End Sub

    Private Sub AddStudyButton_Click(sender As System.Object, e As System.EventArgs) Handles AddStudyButton.Click
        Dim NewWindow As StudyEntryForm
        NewWindow = New StudyEntryForm()
        NewWindow.ShowDialog()
        NewWindow = Nothing
        Me.StudyTableAdapter.Fill(Me.Database1DataSet.study)
    End Sub

    Private Sub AutoIdButton_Click(sender As System.Object, e As System.EventArgs) Handles AutoIdButton.Click
        InterviewIdBox.Text = Me.InterviewTableAdapter.MaxId() + 1
    End Sub

    Private Sub BeginButton_Click(sender As System.Object, e As System.EventArgs) Handles BeginButton.Click
        If Not IsNumeric(InterviewIdBox.Text) Then
            MessageBox.Show("The interview ID you entered is invalid. An ID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Me.InterviewTableAdapter.IdCount(InterviewIdBox.Text) = 1 Then
            MessageBox.Show("The interview ID you entered is already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim InterviewNumber As Integer = Me.InterviewTableAdapter.SubjectInterviewCount(SubjectComboBox.SelectedValue) + 1
            Me.InterviewTableAdapter.InsertInterview(InterviewIdBox.Text, SubjectComboBox.SelectedValue, RaterComboBox.SelectedValue, StudyComboBox.SelectedValue, Date.Now(), InterviewNumber)
            MessageBox.Show("The new interview (ID " & InterviewIdBox.Text & ") was successfully added to the database.", _
            "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Dim NewWindow As New QuestionForm(InterviewIdBox.Text)
            NewWindow.Show()
            Me.Close()
        End If
    End Sub

    Private Sub LoadButton_Click(sender As System.Object, e As System.EventArgs) Handles LoadButton.Click
        If Not IsNumeric(InterviewIdToLoadBox.Text) Then
            MessageBox.Show("The interview ID you entered is invalid. An ID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf InterviewTableAdapter.IdCount(InterviewIdToLoadBox.Text) = 0 Then
            MessageBox.Show("There is no interview with this ID in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim NewWindow As New QuestionForm(InterviewIdToLoadBox.Text)
            NewWindow.Show()
            Me.Close()
        End If
    End Sub
End Class
