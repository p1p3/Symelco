Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class third
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Contactoes", "Nombre", Function(c) c.String(nullable := False, maxLength := 200))
            DropColumn("dbo.Contactoes", "Nombres")
            DropColumn("dbo.Contactoes", "Apellidos")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Contactoes", "Apellidos", Function(c) c.String(nullable := False, maxLength := 200))
            AddColumn("dbo.Contactoes", "Nombres", Function(c) c.String(nullable := False, maxLength := 200))
            DropColumn("dbo.Contactoes", "Nombre")
        End Sub
    End Class
End Namespace
