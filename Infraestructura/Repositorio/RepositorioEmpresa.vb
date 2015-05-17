Imports Core

Public Class RepositorioEmpresa
    Inherits BaseRepositorio(Of Empresa)

    Public Sub New(ByVal dbContext As EFContext)
        MyBase.New(dbContext)
    End Sub
End Class
