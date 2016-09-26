Imports System.Net
Imports System.Web.Http
Imports System.Net.Http
Imports eNUS.BusinessLogicLayer
Imports NUSStackup.Models.Response
Imports eNUS.Models

Namespace Controllers

    Public Class UserController
        Inherits BaseApiController

        'GET v1/user/{userid}/{email} 
        <HttpGet>
        <ActionName("json")>
        Public Function GetUserDetail(id As Integer, emailadddress As String) As HttpResponseMessage

            Dim detail = New UserManager(Configs.ConnectionString).GetUserDetail(id, emailadddress)
            If IsNothing(detail) Then
                Return NUSErrorResponse(HttpStatusCode.NotFound, ErrorStatusCode.NotFound)
            End If

            Dim ehaResponse As New NUSResponse(Of UserDetail)(detail)
            Return Request.CreateResponse(HttpStatusCode.OK, ehaResponse)
        End Function

    End Class

End Namespace
