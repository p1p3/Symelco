Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class listas
        Inherits DbMigration
    
        Public Overrides Sub Up()
            DropForeignKey("dbo.Empleadoes", "idCargo", "dbo.Cargoes")
            DropForeignKey("dbo.Empleadoes", "idRH", "dbo.RHs")
            DropForeignKey("dbo.Empleadoes", "idTipoContrato", "dbo.TipoContratoes")
            AddForeignKey("dbo.Empleadoes", "idCargo", "dbo.Cargoes", "idCargo", cascadeDelete := True)
            AddForeignKey("dbo.Empleadoes", "idRH", "dbo.RHs", "idRH", cascadeDelete := True)
            AddForeignKey("dbo.Empleadoes", "idTipoContrato", "dbo.TipoContratoes", "idTipoContrato", cascadeDelete := True)
        End Sub
        
        Public Overrides Sub Down()
            DropForeignKey("dbo.Empleadoes", "idTipoContrato", "dbo.TipoContratoes")
            DropForeignKey("dbo.Empleadoes", "idRH", "dbo.RHs")
            DropForeignKey("dbo.Empleadoes", "idCargo", "dbo.Cargoes")
            AddForeignKey("dbo.Empleadoes", "idTipoContrato", "dbo.TipoContratoes", "idTipoContrato")
            AddForeignKey("dbo.Empleadoes", "idRH", "dbo.RHs", "idRH")
            AddForeignKey("dbo.Empleadoes", "idCargo", "dbo.Cargoes", "idCargo")
        End Sub
    End Class
End Namespace
