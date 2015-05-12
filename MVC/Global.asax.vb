Imports System.Web.Optimization
Imports Microsoft.Practices.Unity
Imports Unity.Mvc5


Public Class MvcApplication
    Inherits System.Web.HttpApplication

    Private _container As UnityContainer
    Public Property Container() As UnityContainer
        Get
            Return _container
        End Get
        Set(ByVal value As UnityContainer)
            _container = value
        End Set
    End Property


    Protected Sub Application_Start()
        AreaRegistration.RegisterAllAreas()
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)
        Dim db As Infraestructura.EmpresaInicializadorDb = New Infraestructura.EmpresaInicializadorDb
        System.Data.Entity.Database.SetInitializer(db)
        InitiContainer()
    End Sub

    Private Sub InitiContainer()
        If IsNothing(_container) Then
            _container = New UnityContainer
        End If
        _container.RegisterType(Of Core.IRepositorio(Of Core.Empresa), Infraestructura.RepositorioEmpresa)()
        DependencyResolver.SetResolver(New UnityDependencyResolver(Container))
    End Sub

    Private Sub Application_End(sender As Object, e As EventArgs)
        CleanUp()
    End Sub

    Private Sub CleanUp()
        If Not IsNothing(_container) Then Container.Dispose()
    End Sub
End Class
