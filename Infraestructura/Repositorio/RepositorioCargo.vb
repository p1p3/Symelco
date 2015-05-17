Imports Core
Public Class RepositorioCargo
    Inherits BaseRepositorio(Of Cargo)

    Public Sub New(ByVal dbContext As EFContext)
        MyBase.New(dbContext)
    End Sub
End Class
