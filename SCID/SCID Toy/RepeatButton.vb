Imports System.Xml

Public Class RepeatButton
    Inherits Button

    ' The list of questions this button allows us to repeat
    Private MyQuestionPanelList As New List(Of QuestionLayoutPanel)
    Private MyContinueLogic As XmlElement

    Public Sub New(ByVal QuestionPanelList As List(Of QuestionLayoutPanel), ByVal ContinueLogic As XmlElement)
        MyQuestionPanelList.AddRange(QuestionPanelList)
        If ContinueLogic Is Nothing Then
            MyContinueLogic = Nothing
        Else
            MyContinueLogic = ContinueLogic.Clone
        End If
        AutoSize = True
        Text = "Edit " + MyQuestionPanelList.First.Id + "-" + MyQuestionPanelList.Last.Id
    End Sub

    Public ReadOnly Property QuestionPanelList As List(Of QuestionLayoutPanel)
        Get
            Return MyQuestionPanelList
        End Get
    End Property

    Public ReadOnly Property ContinueLogic As XmlElement
        Get
            Return MyContinueLogic
        End Get
    End Property
End Class