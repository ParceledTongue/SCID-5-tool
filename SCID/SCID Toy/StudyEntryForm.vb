Public Class StudyEntryForm

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        Try
            If Not IsNumeric(IdBox.Text) Then
                MessageBox.Show("The ID you entered is invalid. An ID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Me.StudyTableAdapter.IdCount(IdBox.Text) = 1 Then
                MessageBox.Show("The ID you entered is already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.StudyTableAdapter.InsertStudy(IdBox.Text, TitleBox.Text)
                Me.SaveData()
                MessageBox.Show("Study " & TitleBox.Text & " (ID " & IdBox.Text & ") was successfully added to the database.", _
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("An unknown error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveData()
        Me.Validate()
        Me.StudyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
    End Sub

    Private Sub StudyEntryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.study' table. You can move, or remove it, as needed.
        Me.StudyTableAdapter.Fill(Me.Database1DataSet.study)
    End Sub

    Private Sub AutoIdButton_Click(sender As System.Object, e As System.EventArgs) Handles AutoIdButton.Click
        IdBox.Text = Me.StudyTableAdapter.MaxId() + 1
    End Sub

End Class