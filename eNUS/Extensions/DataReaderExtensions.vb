Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices


Namespace Extensions

    Public Module DataReaderExtensions
        <Extension>
        Public Function GetStrSafe(dataReader As SqlDataReader, columnName As String) As String
            Return If(IsDBNull(dataReader(columnName)), String.Empty, CStr(dataReader(columnName)))
        End Function

        <Extension>
        Public Function GetIntSafe(dataReader As SqlDataReader, columnName As String) As Integer
            Return If(IsDBNull(dataReader(columnName)), 0, CInt(dataReader(columnName)))
        End Function

        <Extension>
        Public Function GetDblSafe(dataReader As SqlDataReader, columnName As String) As Double
            Return If(IsDBNull(dataReader(columnName)), 0, CDbl(dataReader(columnName)))
        End Function

        <Extension>
        Public Function GetBoolSafe(dataReader As SqlDataReader, columnName As String) As Boolean
            If IsDBNull(dataReader(columnName)) Then
                Return False
            Else
                Return CBool(dataReader(columnName))
            End If
        End Function

        <Extension>
        Public Function GetStrOrNull(dataReader As SqlDataReader, columnName As String) As String
            If IsDBNull(dataReader(columnName)) Then Return Nothing

            Dim value = CStr(dataReader(columnName))
            Return If(String.IsNullOrEmpty(value), Nothing, value)
        End Function

        <Extension>
        Public Function GetIntOrNull(dataReader As SqlDataReader, columnName As String, toNullValue As Integer) As Integer
            If IsDBNull(dataReader(columnName)) Then Return Nothing

            Dim value = CInt(dataReader(columnName))
            Return If(value = toNullValue, Nothing, value)
        End Function
    End Module

End Namespace