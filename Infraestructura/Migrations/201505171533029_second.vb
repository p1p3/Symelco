Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class second
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Contactoes", "Nombres", Function(c) c.String(nullable := False, maxLength := 200))
            AddColumn("dbo.Contactoes", "Apellidos", Function(c) c.String(nullable := False, maxLength := 200))
            DropColumn("dbo.Contactoes", "Nombre")
        End Sub
        
        Public Overrides Sub Down()
            AddColumn("dbo.Contactoes", "Nombre", Function(c) c.String(nullable := False, maxLength := 200))
            DropColumn("dbo.Contactoes", "Apellidos")
            DropColumn("dbo.Contactoes", "Nombres")
        End Sub
    End Class
End Namespace
