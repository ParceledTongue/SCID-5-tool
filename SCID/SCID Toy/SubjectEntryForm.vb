Public Class SubjectEntryForm

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        Try
            If Not IsNumeric(IdBox.Text) Then
                MessageBox.Show("The ID you entered is invalid. An ID must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf Me.SubjectTableAdapter.IdCount(IdBox.Text) = 1 Then
                MessageBox.Show("The ID you entered is already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Me.SubjectTableAdapter.InsertSubject(IdBox.Text, NameBox.Text, SurnameBox.Text)
                Me.SaveData()
                MessageBox.Show("Subject " & NameBox.Text & " " & SurnameBox.Text & " (ID " & IdBox.Text & ") was successfully added to the database.", _
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("An unknown error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveData()
        Me.Validate()
        Me.SubjectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
    End Sub

    Private Sub SubjectEntryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.subject' table. You can move, or remove it, as needed.
        Me.SubjectTableAdapter.Fill(Me.Database1DataSet.subject)
    End Sub

    Private Sub AutoIdButton_Click(sender As System.Object, e As System.EventArgs) Handles AutoIdButton.Click
        IdBox.Text = Me.SubjectTableAdapter.MaxId() + 1
    End Sub

End Class