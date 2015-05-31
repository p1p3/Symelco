Imports Microsoft.Practices.Unity
' NOTE: You can use the "Rename" command on the context menu to change the class name "EmpleadoService" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select EmpleadoService.svc or EmpleadoService.svc.vb at the Solution Explorer and start debugging.

Public Class EmpleadoService
    Implements IEmpleadoService

    Public Function GetEmpleado(EmpleadoId As String) As String Implements IEmpleadoService.GetEmpleado
        'Dim UnityContainer As New UnityContainer
        'UnityContainer.RegisterType(Of Core.IRepositorio(Of Core.Empleado), Infraestructura.RepositorioEmpleado)()
        'UnityContainer.RegisterType(Of Core.IEmpleadoService, Core.EmpleadoService)()
        'Dim servicioEmpleado = UnityContainer.Resolve(Of Core.EmpleadoService)()
        'Dim oEmpleado As Core.Empleado = servicioEmpleado.FindById(EmpleadoId)
        'oEmpleado.Cargo.Empleados = Nothing
        'oEmpleado.RH.Empleados = Nothing
        'oEmpleado.TipoContrato.Empleados = Nothing

        'Return JsonConvert.SerializeObject(oEmpleado)
        Return Nothing
    End Function

End Class
