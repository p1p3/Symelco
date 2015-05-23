Imports System.Net
Imports System.Web.Http
Imports Microsoft.Practices.Unity
Imports System.Web.Http.Cors

Namespace Controllers
    Public Class EmpleadoController
        Inherits ApiController

        Dim Service As Core.EmpleadoService

        Public Sub New(ByVal Service As Core.IEmpleadoService)
            Me.Service = Service
        End Sub

        Public Function GetAll() As IEnumerable(Of Core.Empleado)
            Return Service
        End Function

        Public Function GetEmpleado(Id As Int32) As IHttpActionResult
            Dim UnityContainer As New UnityContainer
            UnityContainer.RegisterType(Of Core.IRepositorio(Of Core.Empleado), Infraestructura.RepositorioEmpleado)()
            UnityContainer.RegisterType(Of Core.IEmpleadoService, Core.EmpleadoService)()
            Dim servicioEmpleado = UnityContainer.Resolve(Of Core.EmpleadoService)()

            Dim oEmpleado As Core.Empleado = servicioEmpleado.FindById(Id)

            If IsNothing(oEmpleado) Then
                Return NotFound()
            Else
                Return Ok(oEmpleado)
            End If
        End Function



    End Class
End Namespace