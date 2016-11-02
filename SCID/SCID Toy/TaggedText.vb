Public Class TaggedText

    Private MyText As String
    Private MyTag As String

    Public Sub New(ByVal Text As String, ByVal Tag As String)
        MyText = Text
        MyTag = Tag
    End Sub

    Public Property Text As String
        Get
            Return MyText
        End Get
        Set(value As String)
            MyText = value
        End Set
    End Property

    Public Property Tag As String
        Get
            Return MyTag
        End Get
        Set(value As String)
            MyTag = value
        End Set
    End Property

End Class
