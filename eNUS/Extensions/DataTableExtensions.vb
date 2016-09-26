Imports System.Runtime.CompilerServices

Namespace Extensions

    Public Module DataTableExtensions
        <Extension>
        Public Function HasRow(dt As DataTable) As Boolean
            If IsNothing(dt) Then
                Return False
            End If

            Return dt.Rows.Count > 0
        End Function
    End Module

End Namespace