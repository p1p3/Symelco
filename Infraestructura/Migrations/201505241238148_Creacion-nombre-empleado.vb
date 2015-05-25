Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class Creacionnombreempleado
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.Empleadoes", "Nombre", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.Empleadoes", "Nombre")
        End Sub
    End Class
End Namespace
