Imports Core

Public Class RepositorioEmpresa
    Inherits BaseRepositorio(Of Empresa)

    Public Sub New(ByVal dbContext As EmpresasDBContext)
        MyBase.New(dbContext)
    End Sub
End Class
