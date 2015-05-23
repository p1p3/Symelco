Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.Http
Imports Microsoft.Practices.Unity
Imports System.Web.Http.Cors

Public Module WebApiConfig
    Public Sub Register(ByVal config As HttpConfiguration)
    
        ' Web API configuration and services
        Dim container As New UnityContainer
        container.RegisterType(Of Core.IRepositorio(Of Core.Empleado), Infraestructura.RepositorioEmpleado)()
        container.RegisterType(Of Core.IEmpleadoService, Core.EmpleadoService)()
        config.DependencyResolver = New UnityResolver(container)

        Dim cors = New EnableCorsAttribute("http://localhost:51548", "*", "*")
        config.EnableCors(Cors)

        ' Web API routes
        config.MapHttpAttributeRoutes()

        config.Routes.MapHttpRoute(
            name:="DefaultApi",
            routeTemplate:="api/{controller}/{id}",
            defaults:=New With {.id = RouteParameter.Optional}
        )
    End Sub
End Module
