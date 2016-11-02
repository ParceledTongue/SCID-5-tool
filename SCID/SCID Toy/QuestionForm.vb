Imports System.Xml
Imports System.Collections

Public Class QuestionForm

    ' The ID of the interview being conducted
    Private MyInterviewId As Integer
    ' The name of the module currently being administered
    Private MyCurrentModuleId As String
    ' Initialize name label
    Private ModuleNameLabel As New Label
    ' Initialize instructions label
    Private ModuleInstructionsLabel As New Label
    ' Initialize interview XML document object
    Private InterviewDocument As New XmlDocument
    ' Initialize list of interview nodes
    Private InterviewNodeList As XmlNodeList
    ' Initialize continue button
    WithEvents ContinueButton As New Button
    ' Itialize "Go to next module" label
    Private NextModuleLabel As New Label
    ' Initialize node holding the skip logic to be executed when ContinueButton is clicked
    Private CurrentContinueLogic As XmlElement
    ' Initialize list of module IDs and a tracking index
    Private ModuleIdList As XmlNodeList
    Private ModuleIdListIndex As Integer = 0
    ' Initialize NavBox source array list
    Private NavBoxSource As New ArrayList
    ' Initialize list of question(s) currently answerable
    Private CurrentQuestionPanelList As New List(Of QuestionLayoutPanel)

    Public Sub New(ByVal InterviewId As Integer)
        ' Initialize the form
        InitializeComponent()
        ' Load data into the table adapters
        Me.ResponseTableAdapter.Fill(Me.Database1DataSet.response)
        Me.CommentTableAdapter.Fill(Me.Database1DataSet.comment)
        ' Load interview XML document
        InterviewDocument.Load("Y:\DIRECTENTRY\SCID\Interview.xml")
        ' Populate list of modules
        ModuleIdList = InterviewDocument.SelectNodes("/scid/module/id")
        ' Set up the NavBox
        For Each N As XmlNode In ModuleIdList
            Dim CurrentItem = New TaggedText(InterviewDocument.SelectSingleNode("/scid/module[id = '" & N.InnerText & "']/name").InnerText, N.InnerText)
            NavBoxSource.Add(CurrentItem)
        Next
        NavBox.DataSource = NavBoxSource
        NavBox.DisplayMember = "Text"
        NavBox.ValueMember = "Tag"
        ' Get the starting module from the list
        MyCurrentModuleId = ModuleIdList.Item(ModuleIdListIndex).InnerText
        ' Set the interview ID
        MyInterviewId = InterviewId
        ' Load the initial module
        Me.LoadModule(MyCurrentModuleId)
    End Sub

    Private Sub LoadModule(ByVal IdToLoad As String)
        ' Update the current module
        MyCurrentModuleId = IdToLoad
        ' Update the module list index
        For i As Integer = 0 To ModuleIdList.Count - 1
            If ModuleIdList(i).InnerText = IdToLoad Then
                ModuleIdListIndex = i
            End If
        Next
        ' Load the module questions as a list of nodes
        InterviewNodeList = InterviewDocument.SelectNodes("/scid/module[id = '" & MyCurrentModuleId & "']/question | /scid/module[id = '" & MyCurrentModuleId & "']/skip")
        ' Clear panel
        MainFlowLayoutPanel.Controls.Clear()
        ' Clear the current question panel list and continue logic
        CurrentQuestionPanelList.Clear()
        CurrentContinueLogic = Nothing
        ' Get instruction information for the module
        Dim ModuleInstructions As String = InterviewDocument.SelectSingleNode("/scid/module[id = '" & MyCurrentModuleId & "']/instructions").InnerText
        ' Make the title label
        With ModuleNameLabel
            .Font = FormattingDefaults.TitleFont
            .ForeColor = FormattingDefaults.TitleColor
            .Text = InterviewDocument.SelectSingleNode("/scid/module[id = '" & MyCurrentModuleId & "']/name").InnerText
            .AutoSize = True
        End With
        MainFlowLayoutPanel.Controls.Add(ModuleNameLabel)
        MainFlowLayoutPanel.SetFlowBreak(ModuleNameLabel, True)
        ' Make the instructions label
        With ModuleInstructionsLabel
            .Font = FormattingDefaults.ContentFont
            .ForeColor = FormattingDefaults.ContentColor
            .Text = ModuleInstructions
            .AutoSize = True
            .Margin = New Padding(3, 10, 3, 10)
        End With
        MainFlowLayoutPanel.Controls.Add(ModuleInstructionsLabel)
        MainFlowLayoutPanel.SetFlowBreak(ModuleInstructionsLabel, True)
        ' Update the NavBox
        NavBox.SelectedValue = IdToLoad
        ' Update the text in the Comments box
        CommentBox.Text = GetModuleComments(MyCurrentModuleId)
        ' Set up the "Continue" button
        With ContinueButton
            .Text = "Continue"
            .AutoSize = True
            .Margin = New Padding(3, 10, 3, 40)
        End With
        ContinueButton.TabIndex = Integer.MaxValue
        ' Set up the "Continue to next module" label
        With NextModuleLabel
            .Text = "Continue to next module"
            .Font = FormattingDefaults.TitleFont
            .ForeColor = FormattingDefaults.TitleColor
            .AutoSize = True
            .Margin = New Padding(3, 10, 3, 40)
        End With
        ' Make the first set of questions
        Dim FirstItem As XmlElement = InterviewNodeList.ItemOf(0)
        ContinueModuleFromElement(FirstItem)
    End Sub

    Private Sub ContinueModuleFromElement(ByVal StartElement As XmlElement)
        ' Disable input while loading
        Enabled = False
        ' Get the starting index
        Dim StartIndex = -1
        For i As Integer = 0 To InterviewNodeList.Count - 1
            Dim CurrentElement As XmlElement = InterviewNodeList.ItemOf(i)
            If CurrentElement.Equals(StartElement) Then
                StartIndex = i
                Exit For
            End If
        Next
        If StartIndex = -1 Then
            MessageBox.Show("The target element was not found.")
            Exit Sub
        End If
        ' Add sizeless label to the panel (workaround for a formatting quirk in Visual Basic)
        Dim EmptyLabel = New Label
        EmptyLabel.Size = New Size(0, 0)
        EmptyLabel.Margin = New Padding(0)
        MainFlowLayoutPanel.Controls.Add(EmptyLabel)
        ' Remove the continue button
        RemoveContinueButton()
        ' Create question panels (and add questions to CurrentQuestionList) up until the next skip command
        For i As Integer = StartIndex To InterviewNodeList.Count - 1
            Dim CurrentElement As XmlElement = InterviewNodeList.ItemOf(i)
            If CurrentElement.Name = "question" Then
                Dim CurrentQuestionPanel = MakeQuestionLayoutPanel(CurrentElement)
                CurrentQuestionPanelList.Add(CurrentQuestionPanel)
                MainFlowLayoutPanel.Controls.Add(CurrentQuestionPanel)
                MainFlowLayoutPanel.SetFlowBreak(CurrentQuestionPanel, True)
                If Not GetResponse(CurrentQuestionPanel.Id) Is Nothing Then
                    CurrentQuestionPanel.SetAnswer(GetResponse(CurrentQuestionPanel.Id))
                End If
            ElseIf CurrentElement.Name = "skip" Then
                Dim CurrentSkipPanel = MakeSkipLayoutPanel(CurrentElement)
                CurrentSkipPanel.BorderStyle = BorderStyle.None
                CurrentQuestionPanelList.Add(CurrentSkipPanel)
                MainFlowLayoutPanel.Controls.Add(CurrentSkipPanel)
                MainFlowLayoutPanel.SetFlowBreak(CurrentSkipPanel, True)
            Else
                ' ERROR: unexpected node name
                MessageBox.Show("Unexpected node name")
            End If
            If i = InterviewNodeList.Count - 1 Then
                FinishModule()
            End If
        Next
        ' Re-enable input
        Enabled = True
        ' Focus on top new question (if it exists)
        If CurrentQuestionPanelList.Count > 0 Then
            CurrentQuestionPanelList.First.Focus()
        End If
    End Sub

    Private Sub FinishModule()
        If CurrentQuestionPanelList.Count > 0 Then
            ' Clear the current question panel list and continue logic
            CurrentQuestionPanelList.Clear()
            CurrentContinueLogic = Nothing
        End If
        RemoveContinueButton()
        MakeNextModuleLabel()
        MainFlowLayoutPanel.AutoScrollPosition = New Point(0, MainFlowLayoutPanel.VerticalScroll.Maximum)
    End Sub

    Private Sub ContinueButton_Click(sender As System.Object, e As System.EventArgs) Handles ContinueButton.Click
        ' Create an array of the numbers of all unanswered questions
        Dim Unanswered = GetUnanswered()
        ' If they are not all answered, show the next question
        If Unanswered.Count > 0 Then
            MessageBox.Show("You must answer all questions before continuing.", "Error")
        Else ' Otherwise, continue the module
            ContinueModule()
        End If
    End Sub

    Private Sub ContinueModule()
        CommitCurrentAnswers()
        ' If there is no skip logic to act on, the module is over
        If CurrentContinueLogic Is Nothing Then
            FinishModule()
        Else ' Otherwise, execute the skip logic
            ExecuteSkip(CurrentContinueLogic)
        End If
    End Sub

    Private Sub MakeContinueButton()
        MainFlowLayoutPanel.Controls.Add(ContinueButton)
        MainFlowLayoutPanel.SetFlowBreak(ContinueButton, True)
    End Sub

    Private Sub RemoveContinueButton()
        MainFlowLayoutPanel.Controls.Remove(ContinueButton)
    End Sub

    Private Sub MakeNextModuleLabel()
        MainFlowLayoutPanel.Controls.Add(NextModuleLabel)
    End Sub

    Private Sub MakeRepeatButton(ByVal QuestionPanelList As List(Of QuestionLayoutPanel), ByVal ContinueLogic As XmlElement)
        ' Make the repeat button
        Dim NewRepeatButton As New RepeatButton(QuestionPanelList, ContinueLogic)
        NewRepeatButton.Name = "Repeat" + QuestionPanelList.First.Id
        AddHandler NewRepeatButton.Click, AddressOf RepeatButton_Click
        MainFlowLayoutPanel.Controls.Add(NewRepeatButton)
        MainFlowLayoutPanel.Controls.SetChildIndex(NewRepeatButton, MainFlowLayoutPanel.Controls.IndexOf(QuestionPanelList.Last) + 1)
        MainFlowLayoutPanel.SetFlowBreak(NewRepeatButton, True)
    End Sub

    Private Sub RepeatButton_Click(ByVal sender As RepeatButton, ByVal e As EventArgs)
        ' Commit current answers and remove question panels
        CommitCurrentAnswers()
        Dim DeletionIndex = MainFlowLayoutPanel.Controls.IndexOf(sender) + 1
        For i As Integer = DeletionIndex To MainFlowLayoutPanel.Controls.Count - 1
            MainFlowLayoutPanel.Controls.RemoveAt(DeletionIndex)
        Next
        ' Clear data and enable button input
        For Each Q As QuestionLayoutPanel In sender.QuestionPanelList
            DeleteResponse(Q.Id)
            Q.EnableButtons()
        Next
        ' Update current question panel list
        CurrentQuestionPanelList.Clear()
        CurrentQuestionPanelList.AddRange(sender.QuestionPanelList)
        ' Update current continue logic
        CurrentContinueLogic = sender.ContinueLogic
        ' Delete the repeat button
        MainFlowLayoutPanel.Controls.Remove(sender)
        ' Make the continue button
        MakeContinueButton()
        ' Scroll to the first question
        MainFlowLayoutPanel.ScrollControlIntoView(CurrentQuestionPanelList.First())
    End Sub

    Private Sub ExecuteSkip(ByVal SkipElement As XmlElement)
        System.Diagnostics.Debug.WriteLine("Executing skip...")
        Dim CommandNode As XmlNode
        If ConditionsSatisfied(SkipElement) Then
            CommandNode = SkipElement.GetElementsByTagName("true").ItemOf(0)
        Else
            CommandNode = SkipElement.GetElementsByTagName("false").ItemOf(0)
        End If
        RunCommands(CommandNode)
    End Sub

    Private Sub RunCommands(CommandNode As XmlNode)
        System.Diagnostics.Debug.WriteLine("Running commands...")
        Dim ClearCommands = CommandNode.SelectNodes("./clear")
        Dim AssignCommands = CommandNode.SelectNodes("./assign")
        Dim RepeatCommands = CommandNode.SelectNodes("./repeat")
        Dim GoToCommands = CommandNode.SelectNodes("./goto")
        Dim NextModuleCommands = CommandNode.SelectNodes("./next_module")
        ' Run all 'clear' commands
        For Each C As XmlElement In ClearCommands
            System.Diagnostics.Debug.WriteLine("Deleting response " + C.InnerText)
            DeleteResponse(C.InnerText)
        Next
        ' Run all 'assign' commands
        For Each C As XmlElement In AssignCommands
            System.Diagnostics.Debug.WriteLine("Inserting response " + C.SelectSingleNode("./response").InnerText + " to question " + C.SelectSingleNode("./id").InnerText)
            InsertResponse(C.SelectSingleNode("./id").InnerText, C.SelectSingleNode("./response").InnerText)
        Next
        ' If there is a 'next_module' command, finish the module
        If NextModuleCommands.Count > 0 Then
            System.Diagnostics.Debug.WriteLine("Finishing module")
            FinishModule()
        ElseIf GoToCommands.Count > 0 Then ' Otherwise, run the first 'goto' command
            System.Diagnostics.Debug.WriteLine("Going to " + GoToCommands.ItemOf(0).InnerText)
            ContinueModuleFromElement(GetElement(GoToCommands.ItemOf(0).InnerText))
        ElseIf RepeatCommands.Count > 0 Then ' If there are none of those, run the first 'repeat' command
            System.Diagnostics.Debug.WriteLine("Repeating " + RepeatCommands(0).InnerText)
            RepeatButton_Click(MainFlowLayoutPanel.Controls("Repeat" + RepeatCommands(0).InnerText), Nothing)
        Else
            ' ERROR: no redirection command
        End If
    End Sub

    Private Sub CommitCurrentAnswers()
        For Each Q As QuestionLayoutPanel In CurrentQuestionPanelList
            If Not Q.Id = "" And Not Q.AnswerType = "" And Not Q.Answer = Nothing Then
                Try
                    InsertResponse(Q.Id, Q.Answer)
                Catch ex As Exception
                    MessageBox.Show("Failed to commit response to question " & Q.Id)
                End Try
            End If
        Next
        SaveData()
    End Sub

    Private Sub DecommitCurrentAnswers()
        For Each Q As QuestionLayoutPanel In CurrentQuestionPanelList
            If Not Q.Id = "" And Not Q.AnswerType = "" Then
                Try
                    DeleteResponse(Q.Id)
                Catch ex As Exception
                    ' Did not delete response (maybe because it wasn't there in the first place)
                End Try
            End If
        Next
    End Sub

    Private Sub SaveData()
        Me.Validate()
        Me.ResponseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)
    End Sub

    Private Sub InsertResponse(ByVal QuestionId As String, ByVal ResponseText As String)
        Dim OldResponse = GetResponse(QuestionId)
        If OldResponse Is Nothing Then
            ResponseTableAdapter.InsertResponse(QuestionId, MyInterviewId, ResponseText)
        Else
            If Not OldResponse = ResponseText Then
                DeleteResponse(QuestionId)
                ResponseTableAdapter.InsertResponse(QuestionId, MyInterviewId, ResponseText)
                MessageBox.Show("Response " & QuestionId & " changed from " & OldResponse & " to " & ResponseText)
            End If
        End If
    End Sub

    Private Sub SetModuleComments(ByVal ModuleId As String, ByVal CommentText As String)
        Dim OldComments = GetModuleComments(ModuleId)
        If OldComments Is Nothing Then
            CommentTableAdapter.InsertComment(MyInterviewId, ModuleId, CommentBox.Text)
        Else
            If Not OldComments = CommentText Then
                DeleteComment(ModuleId)
                CommentTableAdapter.InsertComment(MyInterviewId, ModuleId, CommentBox.Text)
            End If
        End If
    End Sub

    Private Sub DeleteResponse(ByVal QuestionId As String)
        ResponseTableAdapter.DeleteResponse(QuestionId, MyInterviewId)
    End Sub

    Private Sub DeleteComment(ByVal ModuleId As String)
        CommentTableAdapter.DeleteComment(MyInterviewId, ModuleId)
    End Sub

    Private Sub NavigateToModule() Handles NavBox.DoubleClick
        If Not NavBox.SelectedValue = MyCurrentModuleId Then
            If MyCurrentModuleId = "S" And Not MainFlowLayoutPanel.Controls.Contains(NextModuleLabel) Then
                MessageBox.Show("You cannot navigate away from the screening module without completing it!")
            Else
                CommitCurrentAnswers()
                LoadModule(NavBox.SelectedValue)
                MainFlowLayoutPanel.Focus()
                MainFlowLayoutPanel.AutoScrollPosition = New Point(0, MainFlowLayoutPanel.VerticalScroll.Minimum)
            End If
        End If
    End Sub

    Private Sub NavBox_LoseFocus() Handles NavBox.LostFocus
        NavBox.SelectedValue = MyCurrentModuleId
    End Sub

    Private Sub CommentBox_LoseFocus() Handles CommentBox.LostFocus
        SetModuleComments(MyCurrentModuleId, CommentBox.Text)
    End Sub

    Private Sub FocusPanel() Handles MainFlowLayoutPanel.Click
        MainFlowLayoutPanel.Focus()
    End Sub

    Private Sub WindowClosed() Handles Me.FormClosing
        CommitCurrentAnswers()
    End Sub

    Private Function ConditionsSatisfied(ByVal SkipElement As XmlElement) As Boolean
        Dim TotalSatisfied As Integer = 0
        Dim TotalNeeded As Integer = SkipElement.GetElementsByTagName("total").ItemOf(0).InnerText
        Dim ConditionNodeList = SkipElement.GetElementsByTagName("condition")
        If ConditionNodeList.Count > 0 Then
            For Each C As XmlElement In ConditionNodeList
                Dim DesiredResponse = C.GetElementsByTagName("response").Item(0).InnerText
                Dim ActualResponse = GetResponse(C.GetElementsByTagName("id").Item(0).InnerText)
                If ActualResponse IsNot Nothing And DesiredResponse = ActualResponse Then
                    TotalSatisfied = TotalSatisfied + 1
                End If
            Next
        End If
        If TotalSatisfied < TotalNeeded Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function MakeQuestionLayoutPanel(ByVal QuestionElement As XmlElement) As QuestionLayoutPanel
        Dim ThisId As String = QuestionElement.GetElementsByTagName("id").Item(0).InnerText
        Dim ThisText As String = QuestionElement.GetElementsByTagName("question_text").Item(0).InnerText
        Dim ThisDescription As String = QuestionElement.GetElementsByTagName("description").Item(0).InnerText
        Dim ThisAnswerType As String = QuestionElement.GetElementsByTagName("answer_type").Item(0).InnerText
        Return New QuestionLayoutPanel(ThisId, ThisText, ThisDescription, ThisAnswerType)
    End Function

    Private Function MakeSkipLayoutPanel(ByVal SkipElement As XmlElement) As QuestionLayoutPanel
        Dim ThisId As String = ""
        Dim IdNode As XmlNode = SkipElement.SelectSingleNode("./id")
        If Not IdNode Is Nothing Then
            ThisId = IdNode.InnerText
        End If
        Dim ThisText As String = ""
        Dim ThisDescription = MakeDescription(SkipElement)
        Dim ThisAnswerType As String = ""
        Return New QuestionLayoutPanel(ThisId, ThisText, ThisDescription, ThisAnswerType)
    End Function

    Private Function MakeDescription(ByVal SkipElement As XmlElement) As String
        Dim ReturnString As String = ""
        If SkipElement.GetElementsByTagName("total").Item(0).InnerText = "0" Then
            ' There is no conditional text since this branch is always taken
        ElseIf SkipElement.GetElementsByTagName("total").Item(0).InnerText = "1" Then
            ' This is an "or" clause if there is more than one condition
            ReturnString += "If "
            Dim ConditionNodeList = SkipElement.GetElementsByTagName("condition")
            For i = 0 To (ConditionNodeList.Count - 1)
                Dim C As XmlElement = ConditionNodeList.Item(i)
                ReturnString += C.GetElementsByTagName("id").Item(0).InnerText
                ReturnString += " is "
                ReturnString += C.GetElementsByTagName("response").Item(0).InnerText
                If i = ConditionNodeList.Count - 1 Then
                    ReturnString += ", "
                Else
                    ReturnString += " or "
                End If
            Next
        Else
            ' This is an "and" clause if there is more than one condition
            ReturnString += "If "
            Dim ConditionNodeList = SkipElement.GetElementsByTagName("condition")
            For i = 0 To (ConditionNodeList.Count - 1)
                Dim C As XmlElement = ConditionNodeList.Item(i)
                ReturnString += C.GetElementsByTagName("id").Item(0).InnerText
                ReturnString += " is "
                ReturnString += C.GetElementsByTagName("response").Item(0).InnerText
                If i = ConditionNodeList.Count - 1 Then
                    ReturnString += ", "
                Else
                    ReturnString += " and "
                End If
            Next
        End If
        Dim TrueGoto As XmlNode = SkipElement.SelectSingleNode("./true/goto")
        Dim FalseGoto As XmlNode = SkipElement.SelectSingleNode("./false/goto")
        If Not TrueGoto Is Nothing Then
            ReturnString += "go to " + TrueGoto.InnerText + ". "
        Else
            ReturnString += "go to the next module. "
        End If
        If Not FalseGoto Is Nothing Then
            ReturnString += "Otherwise, go to " + FalseGoto.InnerText + "."
        Else
            ReturnString += "Otherwise, go to the next module."
        End If
        Return ReturnString
    End Function

    Private Function GetElement(ByVal Id As String) As XmlElement
        System.Diagnostics.Debug.WriteLine("Getting element by ID " + Id + "...")
        For Each E As XmlElement In InterviewNodeList
            If E.GetElementsByTagName("id").Count > 0 And E.GetElementsByTagName("id").ItemOf(0).InnerText = Id Then
                Return E
            End If
        Next
        Return Nothing
    End Function

    Private Function GetResponse(ByVal QuestionId As String) As String
        System.Diagnostics.Debug.WriteLine("Getting response by ID " + QuestionId + "...")
        Try
            Return ResponseTableAdapter.GetData.FindByquestion_idinterview_id(QuestionId, MyInterviewId).response_text
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Not found.")
            Return Nothing
        End Try
    End Function

    Private Function GetModuleComments(ByVal ModuleId As String) As String
        Try
            Return CommentTableAdapter.GetData.FindByinterview_idmodule_id(MyInterviewId, ModuleId).comment_text
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine("Not found.")
            Return Nothing
        End Try
    End Function

    Private Function GetUnanswered() As ArrayList
        Dim Unanswered As New ArrayList
        For Each Q As QuestionLayoutPanel In CurrentQuestionPanelList
            If Q.Answer = Nothing And Not (Q.AnswerType = "" Or Q.AnswerType = "none") Then
                Unanswered.Add(Q)
            End If
        Next
        Return Unanswered
    End Function

    Public Property InterviewId() As Integer
        Get
            Return MyInterviewId
        End Get
        Set(value As Integer)
            MyInterviewId = value
        End Set
    End Property

    Private Sub SplitContainer2_Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub
End Class