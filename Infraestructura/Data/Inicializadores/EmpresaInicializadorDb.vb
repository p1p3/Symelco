﻿Imports System.Data.Entity
Imports Microsoft.AspNet.Identity
Imports Microsoft.AspNet.Identity.EntityFramework

Public Class EmpresaInicializadorDb
    Inherits System.Data.Entity.DropCreateDatabaseAlways(Of EFContext)

    'Public Overrides Sub InitializeDatabase(context As EFContext)
    '    context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, String.Format("ALTER DATABASE {0} SET SINGLE_USER WITH ROLLBACK IMMEDIATE", context.Database.Connection.Database))
    '    MyBase.InitializeDatabase(context)
    'End Sub

    Protected Overrides Sub Seed(context As EFContext)

        Dim oCargo As New Core.Cargo With {.Nombre = "CargoLoad", .Activo = True}

        Dim oRH As New Core.RH With {.Nombre = "A+"}

        Dim oTipoContrato As New Core.TipoContrato With {.Nombre = "Temporal", .Activo = True}

        Dim oEmpleado As New Core.Empleado With {.Nombre = "Empleado 1", .Activo = True, .Cargo = oCargo, .Cedula = 123, .FechaNacimiento = Date.FromOADate(2001 / 7 / 5), _
                                                 .RH = oRH, .TipoContrato = oTipoContrato}

        Dim oEmpleado2 As New Core.Empleado With {.Nombre = "Empleado 2", .Activo = True, .Cargo = oCargo, .Cedula = 1234, .FechaNacimiento = Date.FromOADate(2001 / 7 / 5), _
                                                .RH = oRH, .TipoContrato = oTipoContrato}



        Dim oUsuario As New Core.Usuario With {.UserName = "SuperPowerUser", .Email = "taiseer.joudeh@mymail.com", .EmailConfirmed = True, _
                                         .FirstName = "Felipe", .LastName = "Jaramillo", .Level = 1, .JoinDate = DateTime.Now.AddYears(-3)}


        Dim manager = New UserManager(Of Core.Usuario)(New UserStore(Of Core.Usuario)(New EFContext))

        manager.Create(oUsuario, "MySuperP@ssword!")

        'Dim oPersonaContacto As New Core.Contacto With {.Cedula = oCedula, .Nombre = "Felipe Jaramillo Gómez", _
        '                                                .FechaNacimiento = Date.FromOADate(2001 / 7 / 5)}

        'context.Contacto.Add(oPersonaContacto)

        'Dim oEmpresa As New Core.Empresa With {.NIT = "123213-2", .Nombre = "Empresa1", .PersonaContacto = oPersonaContacto}

        'context.Empresas.Add(oEmpresa)


        context.Empleados.Add(oEmpleado)
        context.Empleados.Add(oEmpleado2)
        MyBase.Seed(context)
    End Sub

End Class
