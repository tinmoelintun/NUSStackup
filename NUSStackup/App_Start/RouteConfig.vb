﻿Imports System.Web.Mvc
Imports System.Web.Routing

Public Class RouteConfig
    Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")

        'routes.MapRoute( _
        '    name:="Default", _
        '    url:="{controller}/{action}/{id}", _
        '    defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional} _
        ')
        routes.MapRoute(name:="Default", url:="index.html")
    End Sub

End Class
