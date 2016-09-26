Imports System.Data.SqlClient
Imports eNUS.Extensions

Namespace DataAccessLayer

    Public Class RepositoryBase
        Protected ReadOnly ConnectionString As String

        Public Sub New()
        End Sub

        Public Sub New(connectionString As String)
            If String.IsNullOrEmpty(connectionString) Then
                Throw New ArgumentNullException
            End If
            Me.ConnectionString = connectionString
        End Sub

        Protected Function GetDataRow(cmd As SqlCommand) As DataRow
            Dim dt = GetDataTable(cmd)
            Return If(dt.HasRow(), dt.Rows(0), Nothing)
        End Function

        Protected Function GetDataTable(cmd As SqlCommand) As DataTable
            Dim dt As New DataTable
            Using conn As New SqlConnection(ConnectionString)
                cmd.Connection = conn
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            End Using
        End Function

        Protected Function ExecuteNonQuery(cmd As SqlCommand) As Integer
            Using conn As New SqlConnection(ConnectionString)
                cmd.Connection = conn
                conn.Open()
                Return cmd.ExecuteNonQuery()
            End Using
        End Function

        Protected Function ExecuteScalar(cmd As SqlCommand) As Object
            Using conn As New SqlConnection(ConnectionString)
                cmd.Connection = conn
                conn.Open()
                Return cmd.ExecuteScalar()
            End Using
        End Function

    End Class

End Namespace
