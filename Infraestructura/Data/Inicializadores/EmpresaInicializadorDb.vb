Public Class EmpresaInicializadorDb
    Inherits System.Data.Entity.DropCreateDatabaseAlways(Of EmpresasDBContext)
    Protected Overrides Sub Seed(context As EmpresasDBContext)
        Dim oCedula As New Core.Cedula With {.NumeroCedula = 1037694695, .FechaExpedicion = Date.FromOADate(2008 / 7 / 5)}

        context.Cedula.Add(oCedula)
        Dim oPersonaContacto As New Core.Contacto With {.Cedula = oCedula, .Nombre = "Felipe Jaramillo Gómez", _
                                                        .FechaNacimiento = Date.FromOADate(2001 / 7 / 5)}

        context.Contacto.Add(oPersonaContacto)

        Dim oEmpresa As New Core.Empresa With {.NIT = "123213-2", .Nombre = "Empresa1", .PersonaContacto = oPersonaContacto}

        context.Empresas.Add(oEmpresa)

        MyBase.Seed(context)
    End Sub
End Class
