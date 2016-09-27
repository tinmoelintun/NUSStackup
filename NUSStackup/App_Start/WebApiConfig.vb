Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
        config.Routes.MapHttpRoute(name:="UserRoute", routeTemplate:="v1/users/{id}/{email}/{action}",
                                   defaults:=New With {.controller = "User"})

    End Sub
End Module
