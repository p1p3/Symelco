Imports System.Net
Imports System.Web.Http
Imports Microsoft.Practices.Unity
Imports System.Net.Http


Namespace Controllers
    Public Class EmpleadoController
        Inherits ApiController

        Dim Service As Core.EmpleadoService

        Public Sub New(ByVal Service As Core.IEmpleadoService)
            Me.Service = Service
        End Sub

        'Public Function GetAll() As IEnumerable(Of Core.Empleado)
        '    Return Service.ObtenerTodos()
        'End Function

        Public Function GetAll() As HttpResponseMessage
            Dim empleados = Service.ObtenerTodos()
            If IsNothing(empleados) OrElse empleados.Count = 0 Then Throw New HttpResponseException(HttpStatusCode.NotFound)
            Return Request.CreateResponse2(Of IEnumerable(Of Core.Empleado))(HttpStatusCode.OK, empleados)
        End Function

        Public Function GetEmpleado(Id As Int32) As IHttpActionResult
            Dim oEmpleado As Core.Empleado = Service.EncontrarPorId(Id)

            If IsNothing(oEmpleado) Then
                Return NotFound()
            Else
                Return Ok(oEmpleado)
            End If
        End Function

        Public Sub Create(ByVal oEmpleado As Core.Empleado)
            Service.CrearEmpleado(oEmpleado)
        End Sub

    End Class
End Namespace