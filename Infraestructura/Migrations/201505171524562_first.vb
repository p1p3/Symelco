Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class first
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Cargoes",
                Function(c) New With
                    {
                        .idCargo = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(nullable := False, maxLength := 50),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.idCargo)
            
            CreateTable(
                "dbo.Empleadoes",
                Function(c) New With
                    {
                        .idEmpleado = c.Int(nullable := False, identity := True),
                        .FechaNacimiento = c.DateTime(nullable := False, storeType := "smalldatetime"),
                        .idRH = c.Int(nullable := False),
                        .idCargo = c.Int(nullable := False),
                        .idTipoContrato = c.Int(nullable := False),
                        .Cedula = c.Int(nullable := False),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.idEmpleado) _
                .ForeignKey("dbo.RHs", Function(t) t.idRH) _
                .ForeignKey("dbo.TipoContratoes", Function(t) t.idTipoContrato) _
                .ForeignKey("dbo.Cargoes", Function(t) t.idCargo) _
                .Index(Function(t) t.idRH) _
                .Index(Function(t) t.idCargo) _
                .Index(Function(t) t.idTipoContrato)
            
            CreateTable(
                "dbo.EmpleadoCertificacions",
                Function(c) New With
                    {
                        .idCertificacion = c.Int(nullable := False, identity := True),
                        .FechaExpedicion = c.DateTime(nullable := False, storeType := "smalldatetime"),
                        .FechaVencimiento = c.DateTime(storeType := "smalldatetime"),
                        .EnteCertificador = c.String(maxLength := 100),
                        .idTipoCertificacion = c.Int(nullable := False),
                        .idEmpleado = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.idCertificacion) _
                .ForeignKey("dbo.TiposCertificacion", Function(t) t.idTipoCertificacion) _
                .ForeignKey("dbo.Empleadoes", Function(t) t.idEmpleado) _
                .Index(Function(t) t.idTipoCertificacion) _
                .Index(Function(t) t.idEmpleado)
            
            CreateTable(
                "dbo.EmpleadoAdjuntoCertificacions",
                Function(c) New With
                    {
                        .idAdjuntoCertificacion = c.Int(nullable := False, identity := True),
                        .idCertificacion = c.Int(nullable := False),
                        .RutaAdjunto = c.String(nullable := False, maxLength := 500)
                    }) _
                .PrimaryKey(Function(t) t.idAdjuntoCertificacion) _
                .ForeignKey("dbo.EmpleadoCertificacions", Function(t) t.idCertificacion) _
                .Index(Function(t) t.idCertificacion)
            
            CreateTable(
                "dbo.TiposCertificacion",
                Function(c) New With
                    {
                        .idTipoCertificacion = c.Int(nullable := False, identity := True),
                        .TipoCertificacion = c.String(nullable := False, maxLength := 100),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.idTipoCertificacion)
            
            CreateTable(
                "dbo.EmpleadoCorreos",
                Function(c) New With
                    {
                        .idEmpleado = c.Int(nullable := False),
                        .idCorreo = c.Int(nullable := False),
                        .Correo = c.String(nullable := False, maxLength := 100),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) New With { t.idEmpleado, t.idCorreo }) _
                .ForeignKey("dbo.Empleadoes", Function(t) t.idEmpleado) _
                .Index(Function(t) t.idEmpleado)
            
            CreateTable(
                "dbo.EmpleadoEmpresas",
                Function(c) New With
                    {
                        .idEmpleado = c.Int(nullable := False),
                        .idEmpresa = c.Int(nullable := False),
                        .idHorarioLunes = c.Int(),
                        .idHorarioMartes = c.Int(),
                        .idHorarioMiercoles = c.Int(),
                        .idHorarioJueves = c.Int(),
                        .idHorarioViernes = c.Int(),
                        .idHorarioSabado = c.Int(),
                        .idHorarioDomingo = c.Int()
                    }) _
                .PrimaryKey(Function(t) New With { t.idEmpleado, t.idEmpresa }) _
                .ForeignKey("dbo.Empresas", Function(t) t.idEmpresa) _
                .ForeignKey("dbo.Empleadoes", Function(t) t.idEmpleado) _
                .Index(Function(t) t.idEmpleado) _
                .Index(Function(t) t.idEmpresa)
            
            CreateTable(
                "dbo.Empresas",
                Function(c) New With
                    {
                        .idEmpresa = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(nullable := False, maxLength := 50),
                        .NIT = c.String(nullable := False, maxLength := 50),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.idEmpresa)
            
            CreateTable(
                "dbo.Sedes",
                Function(c) New With
                    {
                        .idSede = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(nullable := False, maxLength := 200),
                        .Direccion = c.String(nullable := False, maxLength := 200),
                        .idEmpresa = c.Int(nullable := False),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.idSede) _
                .ForeignKey("dbo.Empresas", Function(t) t.idEmpresa) _
                .Index(Function(t) t.idEmpresa)
            
            CreateTable(
                "dbo.Contactoes",
                Function(c) New With
                    {
                        .idContacto = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(nullable := False, maxLength := 200),
                        .idCedula = c.Int(nullable := False),
                        .idSede = c.Int(nullable := False),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.idContacto) _
                .ForeignKey("dbo.Sedes", Function(t) t.idSede) _
                .Index(Function(t) t.idSede)
            
            CreateTable(
                "dbo.ContactoCorreos",
                Function(c) New With
                    {
                        .idContacto = c.Int(nullable := False),
                        .idCorreo = c.Int(nullable := False),
                        .Correo = c.String(nullable := False, maxLength := 100),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) New With { t.idContacto, t.idCorreo }) _
                .ForeignKey("dbo.Contactoes", Function(t) t.idContacto) _
                .Index(Function(t) t.idContacto)
            
            CreateTable(
                "dbo.ContactoTelefonoes",
                Function(c) New With
                    {
                        .idTelefono = c.Int(nullable := False),
                        .idContacto = c.Int(nullable := False),
                        .Telefono = c.String(nullable := False, maxLength := 100),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) New With { t.idTelefono, t.idContacto }) _
                .ForeignKey("dbo.Contactoes", Function(t) t.idContacto) _
                .Index(Function(t) t.idContacto)
            
            CreateTable(
                "dbo.RHs",
                Function(c) New With
                    {
                        .idRH = c.Int(nullable := False, identity := True),
                        .RH = c.String(nullable := False, maxLength := 10)
                    }) _
                .PrimaryKey(Function(t) t.idRH)
            
            CreateTable(
                "dbo.EmpleadoTelefonoes",
                Function(c) New With
                    {
                        .idTelefono = c.Int(nullable := False),
                        .idEmpleado = c.Int(nullable := False),
                        .Telefono = c.String(nullable := False, maxLength := 100),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) New With { t.idTelefono, t.idEmpleado }) _
                .ForeignKey("dbo.Empleadoes", Function(t) t.idEmpleado) _
                .Index(Function(t) t.idEmpleado)
            
            CreateTable(
                "dbo.TipoContratoes",
                Function(c) New With
                    {
                        .idTipoContrato = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(nullable := False, maxLength := 100),
                        .Activo = c.Boolean(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.idTipoContrato)
            
            CreateTable(
                "dbo.EmpleadoAdjuntoEstudios",
                Function(c) New With
                    {
                        .idAdjuntoEstudio = c.Int(nullable := False, identity := True),
                        .idEstudio = c.Int(nullable := False),
                        .RutaAdjunto = c.String(nullable := False, maxLength := 500)
                    }) _
                .PrimaryKey(Function(t) t.idAdjuntoEstudio) _
                .ForeignKey("dbo.EmpleadoEstudios", Function(t) t.idEstudio) _
                .Index(Function(t) t.idEstudio)
            
            CreateTable(
                "dbo.EmpleadoEstudios",
                Function(c) New With
                    {
                        .idEstudio = c.Int(nullable := False, identity := True),
                        .FechaGraduacion = c.DateTime(nullable := False, storeType := "smalldatetime"),
                        .Titulo = c.String(nullable := False, maxLength := 50),
                        .EntidadEducativa = c.String(nullable := False, maxLength := 100)
                    }) _
                .PrimaryKey(Function(t) t.idEstudio)
            
            CreateTable(
                "dbo.HorariosIO",
                Function(c) New With
                    {
                        .idHorario = c.Int(nullable := False, identity := True),
                        .HoraIngreso = c.DateTime(nullable := False),
                        .HoraSalida = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.idHorario)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.EmpleadoAdjuntoEstudios", "idEstudio", "dbo.EmpleadoEstudios")
            DropForeignKey("dbo.Empleadoes", "idCargo", "dbo.Cargoes")
            DropForeignKey("dbo.Empleadoes", "idTipoContrato", "dbo.TipoContratoes")
            DropForeignKey("dbo.EmpleadoTelefonoes", "idEmpleado", "dbo.Empleadoes")
            DropForeignKey("dbo.Empleadoes", "idRH", "dbo.RHs")
            DropForeignKey("dbo.EmpleadoEmpresas", "idEmpleado", "dbo.Empleadoes")
            DropForeignKey("dbo.Sedes", "idEmpresa", "dbo.Empresas")
            DropForeignKey("dbo.Contactoes", "idSede", "dbo.Sedes")
            DropForeignKey("dbo.ContactoTelefonoes", "idContacto", "dbo.Contactoes")
            DropForeignKey("dbo.ContactoCorreos", "idContacto", "dbo.Contactoes")
            DropForeignKey("dbo.EmpleadoEmpresas", "idEmpresa", "dbo.Empresas")
            DropForeignKey("dbo.EmpleadoCorreos", "idEmpleado", "dbo.Empleadoes")
            DropForeignKey("dbo.EmpleadoCertificacions", "idEmpleado", "dbo.Empleadoes")
            DropForeignKey("dbo.EmpleadoCertificacions", "idTipoCertificacion", "dbo.TiposCertificacion")
            DropForeignKey("dbo.EmpleadoAdjuntoCertificacions", "idCertificacion", "dbo.EmpleadoCertificacions")
            DropIndex("dbo.EmpleadoAdjuntoEstudios", New String() { "idEstudio" })
            DropIndex("dbo.EmpleadoTelefonoes", New String() { "idEmpleado" })
            DropIndex("dbo.ContactoTelefonoes", New String() { "idContacto" })
            DropIndex("dbo.ContactoCorreos", New String() { "idContacto" })
            DropIndex("dbo.Contactoes", New String() { "idSede" })
            DropIndex("dbo.Sedes", New String() { "idEmpresa" })
            DropIndex("dbo.EmpleadoEmpresas", New String() { "idEmpresa" })
            DropIndex("dbo.EmpleadoEmpresas", New String() { "idEmpleado" })
            DropIndex("dbo.EmpleadoCorreos", New String() { "idEmpleado" })
            DropIndex("dbo.EmpleadoAdjuntoCertificacions", New String() { "idCertificacion" })
            DropIndex("dbo.EmpleadoCertificacions", New String() { "idEmpleado" })
            DropIndex("dbo.EmpleadoCertificacions", New String() { "idTipoCertificacion" })
            DropIndex("dbo.Empleadoes", New String() { "idTipoContrato" })
            DropIndex("dbo.Empleadoes", New String() { "idCargo" })
            DropIndex("dbo.Empleadoes", New String() { "idRH" })
            DropTable("dbo.HorariosIO")
            DropTable("dbo.EmpleadoEstudios")
            DropTable("dbo.EmpleadoAdjuntoEstudios")
            DropTable("dbo.TipoContratoes")
            DropTable("dbo.EmpleadoTelefonoes")
            DropTable("dbo.RHs")
            DropTable("dbo.ContactoTelefonoes")
            DropTable("dbo.ContactoCorreos")
            DropTable("dbo.Contactoes")
            DropTable("dbo.Sedes")
            DropTable("dbo.Empresas")
            DropTable("dbo.EmpleadoEmpresas")
            DropTable("dbo.EmpleadoCorreos")
            DropTable("dbo.TiposCertificacion")
            DropTable("dbo.EmpleadoAdjuntoCertificacions")
            DropTable("dbo.EmpleadoCertificacions")
            DropTable("dbo.Empleadoes")
            DropTable("dbo.Cargoes")
        End Sub
    End Class
End Namespace
