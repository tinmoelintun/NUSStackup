Namespace Models.Response

    Public Class ResponseError
        Public Property ErrorCode As String
        Public Property ErrorMessage As String
        Public Property ErrorHelp As String

        Public Sub New()

        End Sub

        Public Sub New(code As ErrorStatusCode)
            ErrorCode = code.ToString()
        End Sub

        Public Sub New(code As ErrorStatusCode, message As String)
            ErrorCode = code.ToString()
            ErrorMessage = message
        End Sub

        Public Sub New(code As ErrorStatusCode, message As String, help As String)
            ErrorCode = code.ToString()
            ErrorMessage = message
            ErrorHelp = help
        End Sub

    End Class

    Public Enum ErrorStatusCode
        NotFound
        Duplicated
        InvalidParameter
        InvalidToken
        Errors
        Unauthorized

    End Enum

End Namespace
