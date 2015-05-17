Imports System
Imports System.Data.Entity
Imports System.Linq
Imports Core

Public Class EFContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Sql2012Pruebas")
    End Sub

    Public Overridable Property Cargos As DbSet(Of Cargo)
    Public Overridable Property Contactos As DbSet(Of Contacto)
    Public Overridable Property ContactosCorreos As DbSet(Of ContactoCorreo)
    Public Overridable Property ContactosTelefonos As DbSet(Of ContactoTelefono)
    Public Overridable Property Empleados As DbSet(Of Empleado)
    Public Overridable Property EmpleadosAdjuntosCertificaciones As DbSet(Of EmpleadoAdjuntoCertificacion)
    Public Overridable Property EmpleadosAdjuntosEstudios As DbSet(Of EmpleadoAdjuntoEstudio)
    Public Overridable Property EmpleadosCertificaciones As DbSet(Of EmpleadoCertificacion)
    Public Overridable Property EmpleadosCorreos As DbSet(Of EmpleadoCorreo)
    Public Overridable Property EmpleadosEmpresas As DbSet(Of EmpleadoEmpresa)
    Public Overridable Property EmpleadosEstudios As DbSet(Of EmpleadoEstudio)
    Public Overridable Property EmpleadosTelefonos As DbSet(Of EmpleadoTelefono)
    Public Overridable Property Empresas As DbSet(Of Empresa)
    Public Overridable Property HorariosIOs As DbSet(Of HorariosIO)
    Public Overridable Property RHs As DbSet(Of RH)
    Public Overridable Property Sedes As DbSet(Of Sede)
    Public Overridable Property TiposCertificacions As DbSet(Of TiposCertificacion)
    Public Overridable Property TiposContratoes As DbSet(Of TipoContrato)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        'modelBuilder.Entity(Of Cargo)() _
        '    .HasMany(Function(e) e.Empleados) _
        '    .WithRequired(Function(e) e.Cargo) _
        '    .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Contacto)() _
            .HasMany(Function(e) e.Telefonos) _
            .WithRequired(Function(e) e.Contacto) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Contacto)() _
            .HasMany(Function(e) e.Correos) _
            .WithRequired(Function(e) e.Contacto) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Empleado)() _
            .HasMany(Function(e) e.Certificaciones) _
            .WithRequired(Function(e) e.Empleado) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Empleado)() _
            .HasMany(Function(e) e.Correos) _
            .WithRequired(Function(e) e.Empleado) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Empleado)() _
            .HasMany(Function(e) e.Empresas) _
            .WithRequired(Function(e) e.Empleado) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Empleado)() _
            .HasMany(Function(e) e.Telefonos) _
            .WithRequired(Function(e) e.Empleado) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of EmpleadoCertificacion)() _
            .HasMany(Function(e) e.EmpleadosAdjuntosCertificaciones) _
            .WithRequired(Function(e) e.EmpleadoCertificacion) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of EmpleadoEstudio)() _
            .HasMany(Function(e) e.EmpleadosAdjuntosEstudios) _
            .WithRequired(Function(e) e.EmpleadoEstudio) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Empresa)() _
            .HasMany(Function(e) e.Empleados) _
            .WithRequired(Function(e) e.Empresa) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Empresa)() _
            .HasMany(Function(e) e.Sedes) _
            .WithRequired(Function(e) e.Empresa) _
            .WillCascadeOnDelete(False)

        'modelBuilder.Entity(Of RH)() _
        '    .HasMany(Function(e) e.Empleados) _
        '    .WithRequired(Function(e) e.RH) _
        '    .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of Sede)() _
            .HasMany(Function(e) e.Contactos) _
            .WithRequired(Function(e) e.Sede) _
            .WillCascadeOnDelete(False)

        modelBuilder.Entity(Of TiposCertificacion)() _
            .HasMany(Function(e) e.EmpleadosCertificaciones) _
            .WithRequired(Function(e) e.TipoCertificacion) _
            .WillCascadeOnDelete(False)

        'modelBuilder.Entity(Of TipoContrato)() _
        '    .HasMany(Function(e) e.Empleados) _
        '    .WithRequired(Function(e) e.TipoContrato) _
        '    .WillCascadeOnDelete(False)
    End Sub

End Class

