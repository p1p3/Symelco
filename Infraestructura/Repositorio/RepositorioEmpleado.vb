Imports Core

Public Class RepositorioEmpleado
    Inherits BaseRepositorio(Of Empleado)
    Public Sub New(ByVal dbContext As EmpresasDBContext)
        MyBase.New(dbContext)
    End Sub
End Class
