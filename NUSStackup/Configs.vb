Public Class Configs
    Public Shared ReadOnly Property ConnectionString As String
        Get
            Return ConfigurationManager.ConnectionStrings("NUSConStr").ConnectionString
        End Get
    End Property

    Public Shared Function [Get](settingName As String) As String
        Return ConfigurationManager.AppSettings(settingName)
    End Function

End Class
