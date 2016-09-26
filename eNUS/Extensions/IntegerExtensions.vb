Imports System.Runtime.CompilerServices

Namespace Extensions

    Public Module IntegerExtensions
        <Extension>
        Public Function Sg(value As DateTime) As DateTime
            Return DateTime.UtcNow.AddHours(8)
        End Function
    End Module

End Namespace