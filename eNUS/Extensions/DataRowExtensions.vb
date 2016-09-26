Imports System.Runtime.CompilerServices

Namespace Extensions

    Public Module DataRowExtensions
        <Extension>
        Public Function GetStrSafe(row As DataRow, columnName As String) As String
            Return If(IsDBNull(row.Item(columnName)), String.Empty, CStr(row.Item(columnName)))
        End Function

        <Extension>
        Public Function GetIntSafe(row As DataRow, columnName As String) As Integer
            Return If(IsDBNull(row.Item(columnName)), 0, CInt(row.Item(columnName)))
        End Function

        <Extension>
        Public Function GetLngSafe(row As DataRow, columnName As String) As Long
            Return If(IsDBNull(row.Item(columnName)), 0, CLng(row.Item(columnName)))
        End Function

        <Extension>
        Public Function GetDblSafe(row As DataRow, columnName As String) As Double
            Return If(IsDBNull(row.Item(columnName)), 0, CDbl(row.Item(columnName)))
        End Function

        <Extension>
        Public Function GetBoolSafe(row As DataRow, columnName As String) As Boolean
            If IsDBNull(row.Item(columnName)) Then
                Return False
            Else
                Return CBool(row.Item(columnName))
            End If
        End Function

        <Extension>
        Public Function GetStrOrNull(row As DataRow, columnName As String) As String
            If IsDBNull(row.Item(columnName)) Then Return Nothing

            Dim result = row.Item(columnName).ToString()
            Return If(String.IsNullOrEmpty(result), Nothing, result)
        End Function

        'Added by TinMoe @20160713
        <Extension>
        Public Function GetDateOrNull(row As DataRow, columnName As String) As Date
            Return If(IsDBNull(row.Item(columnName)), Nothing, CDate(row.Item(columnName)))
        End Function
    End Module

End Namespace