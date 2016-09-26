Imports System.Data.SqlClient

Namespace DataAccessLayer

    Public Class UserRepository
        Inherits RepositoryBase

        Public Sub New(connectionString As String)
            MyBase.New(connectionString)
        End Sub

        Public Function GetUserDetail(id As Integer, email As String) As DataRow
            Dim cmd As New SqlCommand("SELECT * FROM users WHERE id=@id AND email=@email")
            cmd.Parameters.AddWithValue("@visitno", id)
            cmd.Parameters.AddWithValue("@pcno", email)
            Dim row = GetDataRow(cmd)

            Return row
        End Function

    End Class

End Namespace
