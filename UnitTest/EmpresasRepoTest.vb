Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class EmpresasRepoTest
    Dim repoEmpleado As Infraestructura.RepositorioEmpleado
    Dim repoCargo As Infraestructura.RepositorioCargo

    <TestInitialize>
    Public Sub TestSetUp()
        Dim Initializer As Infraestructura.EmpresaInicializadorDb = New Infraestructura.EmpresaInicializadorDb
        System.Data.Entity.Database.SetInitializer(Initializer)
        Dim dbContext As New Infraestructura.EFContext
        dbContext.Database.Initialize(True)
        repoEmpleado = New Infraestructura.RepositorioEmpleado(dbContext)
        repoCargo = New Infraestructura.RepositorioCargo(dbContext)
    End Sub

    <TestMethod()>
    Public Sub RepositorioInicializado()
        Dim resultadoEmpleado = repoEmpleado.GetAll()
        Dim resultadoCargo = repoCargo.GetAll()
        Assert.IsNotNull(resultadoEmpleado)
        Assert.IsNotNull(resultadoCargo)
        Dim NumeroEmpleados = resultadoEmpleado.ToList().Count
        Dim NumeroCargo = resultadoCargo.ToList().Count

        Assert.AreEqual(2, NumeroEmpleados + NumeroCargo)
        repoEmpleado.Dispose()
    End Sub

End Class