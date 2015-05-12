Imports System
Imports System.Data.Entity
Imports System.Linq
Imports Core

Public Class EmpresasDBContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=EmpresasDBContext")
        Dim a = Database.Connection.ConnectionString
    End Sub

    Public Overridable Property Empresas() As DbSet(Of Empresa)
    Public Overridable Property Contacto() As DbSet(Of Contacto)
    Public Overridable Property Cedula() As DbSet(Of Cedula)

    ' Add a DbSet for each entity type that you want to include in your model. For more information 
    ' on configuring and using a Code First model, see http:'go.microsoft.com/fwlink/?LinkId=390109.
    ' Public Overridable Property MyEntities() As DbSet(Of MyEntity)

End Class

