Imports System.Runtime.CompilerServices

Namespace Extensions

    Public Module StringExtensions
        ''' <summary>
        ''' To check a given string is integer
        ''' </summary>
        ''' <param name="value"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <Extension>
        Public Function IsInteger(value As String) As Boolean
            If String.IsNullOrEmpty(value) Then Return False
            Return Integer.TryParse(value, Nothing)
        End Function

        ''' <summary>
        ''' String To Integer Extension. Return 0 when value is not a valid integer.
        ''' </summary>
        ''' <param name="value">String to convert</param>
        ''' <param name="defaultValue">Default value if conversion failed.</param>
        <Extension>
        Public Function ToInteger(value As String, defaultValue As Integer) As Integer
            If value.IsInteger Then
                Return Integer.Parse(value)
            Else
                Return defaultValue
            End If
        End Function

        <Extension>
        Public Function ToStringSafe(value As String) As String
            If String.IsNullOrEmpty(value) Then
                Return String.Empty
            End If
            Return value
        End Function

        ''' <summary>
        ''' Throw ArgumentNullException if value didn't return true on String.IsNullOrEmpty
        ''' </summary>
        ''' <param name="input"></param>
        ''' <param name="name"></param>
        ''' <param name="msg"></param>
        ''' <remarks></remarks>
        <Extension>
        Public Sub ThrowIfNullOrEmpty(input As String, Optional name As String = "", Optional msg As String = "")
            If String.IsNullOrEmpty(input) Then
                If Not name = "" AndAlso Not msg = "" Then
                    Throw New ArgumentNullException(name, "ArgumentNullException: " & msg)
                ElseIf Not name = "" Then
                    Throw New ArgumentNullException(name)
                Else
                    Throw New ArgumentNullException
                End If
            End If
        End Sub

        ''' <summary>
        ''' String extension to get the string value. Return empty string is value didn't pass String.IsNullOrEmpty test
        ''' </summary>
        <Extension>
        Public Function ValueOrDefault(value As String) As String
            If String.IsNullOrEmpty(value) Then
                Return ""
            Else
                Return value
            End If
        End Function

        ''' <summary>
        ''' String extension to get the string value. Return empty string if value didn't pass String.IsNullOrEmpty test.
        ''' </summary>
        ''' <param name="value"></param>
        ''' <param name="defaultValue">Specify a default value to return if test failed.</param>
        <Extension>
        Public Function ValueOrDefault(value As String, defaultValue As String) As String
            If String.IsNullOrEmpty(value) Then
                Return ""
            Else
                Return value
            End If
        End Function
    End Module

End Namespace