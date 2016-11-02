Public Class QuestionLayoutPanel
    Inherits FlowLayoutPanel

    ' Create the layout panel and its controls (not including the answer buttons), and define local variables
    Private WithEvents QuestionTextLabel As New Label
    Private WithEvents QuestionDescriptionLabel As New Label
    Private WithEvents QuestionIdLabel As New Label
    Private MyId As String
    Private MyQuestionText As String
    Private MyDescription As String
    Private MyAnswer As String
    Private MyAnswerType As String
    Private AnswerPanel As New FlowLayoutPanel
    Private BorderColor As New Color

    Public Sub New(ByVal Id As String, ByVal QuestionText As String, ByVal Description As String, ByVal AnswerType As String)
        TabStop = True
        DoubleBuffered = True
        MyId = Id
        MyQuestionText = QuestionText
        MyDescription = Description
        MyAnswer = Nothing
        MyAnswerType = AnswerType
        ' Set the layout panel formatting
        AutoSize = True
        BackColor = FormattingDefaults.BackgroundColor
        ForeColor = FormattingDefaults.ContentColor
        BorderColor = FormattingDefaults.ContentColor
        Font = FormattingDefaults.ContentFont
        ' Set question and description text and add labels to the layout panel
        With QuestionTextLabel
            .Text = QuestionText
            .AutoSize = True
            .Font = New Font(FormattingDefaults.ContentFont.ToString(), FormattingDefaults.ContentFont.Size, FontStyle.Bold)
            .MinimumSize = New Size(300, 0)
            .MaximumSize = New Size(300, 0)
            .Margin = New Padding(5)
        End With
        Controls.Add(QuestionTextLabel)
        With QuestionDescriptionLabel
            .Text = Description
            .AutoSize = True
            .MinimumSize = New Size(300, 0)
            .MaximumSize = New Size(300, 0)
            .Margin = New Padding(5)
        End With
        Controls.Add(QuestionDescriptionLabel)
        With AnswerPanel
            ' .FlowDirection = Windows.Forms.FlowDirection.TopDown
            .AutoSize = True
            .MinimumSize = New Size(120, 0)
            .MaximumSize = New Size(120, 0)
            .Margin = New Padding(5)
        End With
        Controls.Add(AnswerPanel)
        ' Make the answer buttons and add them to the layout panel
        MakeAnswerButtons(AnswerType)
        ' Set ID label text and add it to the layout panel
        QuestionIdLabel.Text = Id
        QuestionIdLabel.AutoSize = True
        QuestionIdLabel.Margin = New Padding(4)
        QuestionIdLabel.Font = New Font(FormattingDefaults.ContentFont.ToString(), FormattingDefaults.ContentFont.Size, FontStyle.Bold)
        QuestionIdLabel.ForeColor = FormattingDefaults.TitleColor
        QuestionIdLabel.Margin = New Padding(5)
        Controls.Add(QuestionIdLabel)
    End Sub

    ' Create buttons for the appropriate answer type and add them to the panel
    Private Sub MakeAnswerButtons(ByVal Type As String)
        If Type = "123" Then
            ' Create the answer buttons
            Dim AnswerButton1 As New RadioButton
            Dim AnswerButton2 As New RadioButton
            Dim AnswerButton3 As New RadioButton
            ' Set the button text
            AnswerButton1.Text = "1"
            AnswerButton2.Text = "2"
            AnswerButton3.Text = "3"
            ' Add the buttons to the panel
            With AnswerPanel.Controls
                .Add(AnswerButton1)
                .Add(AnswerButton2)
                .Add(AnswerButton3)
            End With
        ElseIf Type = "13" Then
            ' Create the answer buttons
            Dim AnswerButton1 As New RadioButton
            Dim AnswerButton3 As New RadioButton
            ' Set the button text
            AnswerButton1.Text = "1"
            AnswerButton3.Text = "3"
            ' Add the buttons to the panel
            With AnswerPanel.Controls
                .Add(AnswerButton1)
                .Add(AnswerButton3)
            End With
        ElseIf Type = "1234" Then
            ' Create the answer buttons
            Dim AnswerButton1 As New RadioButton
            Dim AnswerButton2 As New RadioButton
            Dim AnswerButton3 As New RadioButton
            Dim AnswerButton4 As New RadioButton
            ' Set the button text
            AnswerButton1.Text = "1"
            AnswerButton2.Text = "2"
            AnswerButton3.Text = "3"
            AnswerButton4.Text = "4"
            ' Add the buttons to the panel
            With AnswerPanel.Controls
                .Add(AnswerButton1)
                .Add(AnswerButton2)
                .Add(AnswerButton3)
                .Add(AnswerButton4)
            End With
        ElseIf Type = "12345" Then
            ' Create the answer buttons
            Dim AnswerButton1 As New RadioButton
            Dim AnswerButton2 As New RadioButton
            Dim AnswerButton3 As New RadioButton
            Dim AnswerButton4 As New RadioButton
            Dim AnswerButton5 As New RadioButton
            ' Set the button text
            AnswerButton1.Text = "1"
            AnswerButton2.Text = "2"
            AnswerButton3.Text = "3"
            AnswerButton4.Text = "4"
            AnswerButton5.Text = "5"
            ' Add the buttons to the panel
            With AnswerPanel.Controls
                .Add(AnswerButton1)
                .Add(AnswerButton2)
                .Add(AnswerButton3)
                .Add(AnswerButton4)
                .Add(AnswerButton5)
            End With
        ElseIf Type = "1234567" Then
            ' Create the answer buttons
            Dim AnswerButton1 As New RadioButton
            Dim AnswerButton2 As New RadioButton
            Dim AnswerButton3 As New RadioButton
            Dim AnswerButton4 As New RadioButton
            Dim AnswerButton5 As New RadioButton
            Dim AnswerButton6 As New RadioButton
            Dim AnswerButton7 As New RadioButton
            ' Set the button text
            AnswerButton1.Text = "1"
            AnswerButton2.Text = "2"
            AnswerButton3.Text = "3"
            AnswerButton4.Text = "4"
            AnswerButton5.Text = "5"
            AnswerButton6.Text = "6"
            AnswerButton7.Text = "7"
            ' Add the buttons to the panel
            With AnswerPanel.Controls
                .Add(AnswerButton1)
                .Add(AnswerButton2)
                .Add(AnswerButton3)
                .Add(AnswerButton4)
                .Add(AnswerButton5)
                .Add(AnswerButton6)
                .Add(AnswerButton7)
            End With
        ElseIf Type = "YN" Then
            ' Create the answer buttons
            Dim AnswerButtonN As New RadioButton
            Dim AnswerButtonY As New RadioButton
            ' Set the button text
            AnswerButtonN.Text = "NO"
            AnswerButtonY.Text = "YES"
            ' Add the buttons to the panel
            With AnswerPanel.Controls
                .Add(AnswerButtonN)
                .Add(AnswerButtonY)
            End With
        ElseIf Type = "num" Then
            Dim AnswerBox As New TextBox
            AnswerPanel.Controls.Add(AnswerBox)
        ElseIf Type = "none" Then
            ' Don't add anything to the answer panel
        ElseIf Type = "" Then ' Probably won't want this, it was for section headers
            ' Get rid of the border
            BorderColor = FormattingDefaults.BackgroundColor
            ' Don't add anything to the answer panel
        Else
            ' The procedure has been passed an unrecognized answer type
            MessageBox.Show(Type & " is not a valid answer type.")
        End If

        For Each C As Control In AnswerPanel.Controls
            C.Font = FormattingDefaults.ContentFont
            AddHandler C.GotFocus, AddressOf QuestionFocused
            If AnswerPanel.Controls.IndexOf(C) = 0 Then
                C.TabStop = True
            End If
            If TypeOf C Is RadioButton Then
                CType(C, RadioButton).AutoSize = True
                AddHandler CType(C, RadioButton).CheckedChanged, AddressOf AnswerChanged
            ElseIf TypeOf C Is TextBox Then
                AddHandler CType(C, TextBox).TextChanged, AddressOf AnswerChanged
            End If
        Next
    End Sub

    Private Sub AnswerChanged(ByVal sender As Control, ByVal e As EventArgs)
        ' Update the answer variable to reflect the new selection
        MyAnswer = sender.Text
    End Sub

    Private Sub QuestionFocused(ByVal sender As Control, ByVal e As EventArgs)
        ' Bring this QuestionLayoutPanel into focus
        CType(Parent, FlowLayoutPanel).ScrollControlIntoView(Me)
    End Sub

    Private Sub FocusMainPanel() Handles Me.Click, QuestionTextLabel.Click, QuestionDescriptionLabel.Click, QuestionIdLabel.Click
        Parent.Focus()
    End Sub

    Public Sub DisableButtons()
        For Each C As Control In AnswerPanel.Controls
            C.Enabled = False
            C.TabStop = False
        Next
        BorderColor = ControlPaint.Dark(FormattingDefaults.BackgroundColor)
    End Sub

    Public Sub EnableButtons()
        For Each C As Control In AnswerPanel.Controls
            C.Enabled = True
            If AnswerPanel.Controls.IndexOf(C) = 0 Then
                C.TabStop = True
            End If
        Next
        BorderColor = FormattingDefaults.ContentColor
    End Sub

    Public Sub SetAnswer(ByVal Answer As String)
        MyAnswer = Answer
        If MyAnswerType = "number" Then
            AnswerPanel.Controls(0).Text = Answer
        ElseIf MyAnswerType = "123" Or MyAnswerType = "13" Or MyAnswerType = "YN" Then
            For Each C As RadioButton In AnswerPanel.Controls
                If C.Text = Answer Then
                    C.Checked = True
                End If
            Next
        End If
    End Sub

    Public ReadOnly Property Id As String
        Get
            Return MyId
        End Get
    End Property

    Public ReadOnly Property QuestionText As String
        Get
            Return MyQuestionText
        End Get
    End Property

    Public ReadOnly Property Description As String
        Get
            Return MyDescription
        End Get
    End Property

    Public ReadOnly Property Answer As String
        Get
            Return MyAnswer
        End Get
    End Property

    Public ReadOnly Property AnswerType As String
        Get
            Return MyAnswerType
        End Get
    End Property

    Protected Overrides Sub OnPaint(e As System.Windows.Forms.PaintEventArgs)
        e.Graphics.Clear(BackColor)
        Dim pen = New Pen(BorderColor, 1)
        e.Graphics.DrawRectangle(pen, 0, 0, Width - 1, Height - 1)
        pen.Dispose()
        MyBase.OnPaint(e)
    End Sub

    Private Sub Redraw() Handles Me.Move
        Invalidate()
    End Sub

End Class
