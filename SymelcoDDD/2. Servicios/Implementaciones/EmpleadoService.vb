Public Class EmpleadoService
    Implements IEmpleadoService
    Private RepositorioEmpleado As IRepositorio(Of Empleado)

    Public Sub New(ByVal Repositorio As IRepositorio(Of Empleado))
        Me.RepositorioEmpleado = Repositorio
    End Sub

    Public Sub CrearEmpleado(Empleado As Empleado) Implements IEmpleadoService.CrearEmpleado
        If Empleado.isValid() Then
            Try
                Me.RepositorioEmpleado.Add(Empleado)
            Catch ex As Exception
                Throw ex
            End Try
        Else
            Throw New EmpleadoException("El empleado no es válido")
        End If
    End Sub


    Public Function EncontrarPorId(id As Integer) As Empleado Implements IEmpleadoService.EncontrarPorId
        Return RepositorioEmpleado.FindById(id)
    End Function

    Public Function ObtenerTodos() As IEnumerable(Of Empleado) Implements IEmpleadoService.ObtenerTodos
        Return RepositorioEmpleado.GetAll()
    End Function



End Class
