Imports System.Net
Imports System.Net.Http
Imports System.Web.Http
Imports NUSStackup.Models.Response

Public Class BaseApiController
    Inherits ApiController

    Protected Function NUSErrorResponse(httpCode As HttpStatusCode, errorCode As ErrorStatusCode) As HttpResponseMessage
        Dim errorMessage As String
        Select Case errorCode
            Case ErrorStatusCode.InvalidParameter
                errorMessage = "Invalid parameter(s)."
            Case ErrorStatusCode.InvalidToken
                errorMessage = "Invalid token."
            Case ErrorStatusCode.NotFound
                errorMessage = "Resources not found."
            Case ErrorStatusCode.Unauthorized
                errorMessage = "Not authorized."
            Case Else
                errorMessage = "Error Occurred."
        End Select
        Return NUSErrorResponse(httpCode, errorCode, errorMessage)
    End Function

    Protected Function NUSErrorResponse(httpCode As HttpStatusCode, errorCode As ErrorStatusCode, errorMessage As String) As HttpResponseMessage
        Dim errResponse As New nusResponse(Of ResponseError)
        errResponse.Status = errorCode.ToString()
        errResponse.Data = New ResponseError(errorCode, errorMessage)
        Return Request.CreateResponse(httpCode, errResponse)
    End Function

End Class
