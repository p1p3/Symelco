Public Interface IEmpleadoService
    Sub CrearEmpleado(Empleado As Empleado)
    Function EncontrarPorId(id As Integer) As Empleado
    Function ObtenerTodos() As IEnumerable(Of Empleado)
End Interface
