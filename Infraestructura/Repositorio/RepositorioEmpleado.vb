﻿Imports Core

Public Class RepositorioEmpleado
    Inherits BaseRepositorio(Of Empleado)

    Public Sub New(ByVal dbContext As EFContext)
        MyBase.New(dbContext)
    End Sub
End Class
