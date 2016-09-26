Namespace Models.Response

    Public Class NUSResponse(Of T)
        Public Property Status As String
        Public Property Data As T

        Sub New()
            Me.Status = NUSResponseStatus.Ok.ToString()
        End Sub

        Sub New(data As T)
            Me.Status = NUSResponseStatus.Ok.ToString()
            Me.Data = data
        End Sub

        Sub New(status As NUSResponseStatus, data As T)
            Me.Status = status.ToString()
            Me.Data = data
        End Sub

    End Class

    Public Enum NUSResponseStatus
        Ok
        Unauthorized
        Errors
    End Enum

End Namespace
