Public Class EmpleadoService
    Implements IEmpleadoService
    Private repoEmpleado As IRepositorio(Of Empleado)

    Public Sub New(ByVal repo As IRepositorio(Of Empleado))
        Me.repoEmpleado = repo
    End Sub

    Public Sub Add(Empleado As Empleado)
        If Empleado.isValid() Then
            Try
                Me.repoEmpleado.Add(Empleado)
            Catch ex As Exception
                Throw ex
            End Try
        Else
            Throw New EmpleadoException("El empleado no es válido")
        End If
    End Sub

    Public Function FindById(id As Integer) As Empleado
        Return repoEmpleado.FindById(id)
    End Function

    Public Function GetAll() As IEnumerable(Of Empleado)
        Return repoEmpleado.GetAll()
    End Function

End Class
