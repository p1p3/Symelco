Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class EmpresasRepoTest
    Dim repo As Infraestructura.RepositorioEmpresa

    <TestInitialize>
    Public Sub TestSetUp()
        Dim db As Infraestructura.EmpresaInicializadorDb = New Infraestructura.EmpresaInicializadorDb
        System.Data.Entity.Database.SetInitializer(db)
        Dim dbContext As New Infraestructura.EmpresasDBContext
        repo = New Infraestructura.RepositorioEmpresa(dbContext)
    End Sub

    <TestMethod()>
    Public Sub RepositorioInicializado()
        Dim resultado = repo.GetAll()
        Assert.IsNotNull(resultado)
        Dim NumeroRegistros = resultado.ToList().Count
        Assert.AreEqual(1, NumeroRegistros)
        repo.Dispose()
    End Sub

End Class