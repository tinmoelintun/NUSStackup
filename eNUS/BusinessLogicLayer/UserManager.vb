Imports eNUS.DataAccessLayer
Imports eNUS.Models
Imports eNUS.Extensions

Namespace BusinessLogicLayer

    Public Class UserManager
        Private ReadOnly _connectionString As String

        Public Sub New(connectionString As String)
            If String.IsNullOrEmpty(connectionString) Then
                Throw New ArgumentNullException
            End If
            _connectionString = connectionString
        End Sub

        Public Function GetUserDetail(id As Integer, email As String) As UserDetail

            Dim row = New UserRepository(_connectionString).GetUserDetail(id, email)
            Return If(row Is Nothing, Nothing, Serialize(row))
        End Function

        Private Function Serialize(row As DataRow) As UserDetail

            Dim detail As New UserDetail With {
                .id = row.GetIntSafe("id"),
                .email = row.GetStrSafe("email"),
                .encrypted_password = row.GetStrSafe("encrypted_password"),
                .reset_password_token = row.GetStrSafe("reset_password_token"),
                .remember_created_at = row.GetDateOrNull("remember_created_at"),
                .sign_in_count = row.GetIntSafe("sign_in_count"),
                .current_sign_in_at = row.GetDateOrNull("current_sign_in_at"),
                .last_sign_in_at = row.GetDateOrNull("last_sign_in_at"),
                .current_sign_in_ip = row.GetStrSafe("current_sign_in_ip"),
                .last_sign_in_ip = row.GetStrSafe("last_sign_in_ip"),
                .name = row.GetStrSafe("name"),
                .phone = row.GetStrSafe("phone"),
                .bio = row.GetStrSafe("bio"),
                .receive_announcements = row.GetIntSafe("receive_announcements"),
                .avatar_image_uid = row.GetStrSafe("avatar_image_uid"),
                .authentication_token = row.GetStrSafe("authentication_token"),
                .createdAt = row.GetDateOrNull("createdAt"),
                .updatedAt = row.GetDateOrNull("updatedAt"),
                .reset_password_sent_at = row.GetDateOrNull("reset_password_sent_at")
                }

            Return detail

        End Function


    End Class

End Namespace
