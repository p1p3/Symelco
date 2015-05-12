Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class InitialCreate
        Inherits DbMigration
    
        Public Overrides Sub Up()
            CreateTable(
                "dbo.Cedulas",
                Function(c) New With
                    {
                        .CedulaId = c.Int(nullable := False, identity := True),
                        .NumeroCedula = c.Int(nullable := False),
                        .FechaExpedicion = c.DateTime(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.CedulaId)
            
            CreateTable(
                "dbo.Contactoes",
                Function(c) New With
                    {
                        .ContactoId = c.Int(nullable := False, identity := True),
                        .CedulaId = c.Int(nullable := False),
                        .FechaNacimiento = c.DateTime(nullable := False),
                        .Nombre = c.String()
                    }) _
                .PrimaryKey(Function(t) t.ContactoId) _
                .ForeignKey("dbo.Cedulas", Function(t) t.CedulaId, cascadeDelete := True) _
                .Index(Function(t) t.CedulaId)
            
            CreateTable(
                "dbo.Empresas",
                Function(c) New With
                    {
                        .EmpresaId = c.Int(nullable := False, identity := True),
                        .Nombre = c.String(maxLength := 50),
                        .NIT = c.String(nullable := False),
                        .ContactoId = c.Int(nullable := False)
                    }) _
                .PrimaryKey(Function(t) t.EmpresaId) _
                .ForeignKey("dbo.Contactoes", Function(t) t.ContactoId, cascadeDelete := True) _
                .Index(Function(t) t.ContactoId)
            
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Empresas", "ContactoId", "dbo.Contactoes")
            DropForeignKey("dbo.Contactoes", "CedulaId", "dbo.Cedulas")
            DropIndex("dbo.Empresas", New String() { "ContactoId" })
            DropIndex("dbo.Contactoes", New String() { "CedulaId" })
            DropTable("dbo.Empresas")
            DropTable("dbo.Contactoes")
            DropTable("dbo.Cedulas")
        End Sub
    End Class
End Namespace
