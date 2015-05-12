Imports System.ComponentModel.DataAnnotations

Public Class Empleado
    Implements IPersona

    Public Property CedulaId As Int32 Implements IPersona.CedulaId

    Public Property Cedula As Cedula

    Public Property Correos As List(Of String()) Implements IPersona.Correos

    Public Property Direcciones As List(Of String()) Implements IPersona.Direcciones

    Public Property FechaNacimiento As Date Implements IPersona.FechaNacimiento

    Public Property EmpleadoId As Int32 Implements IPersona.Id

    Public Property Nombre As String Implements IPersona.Nombre

    Public Property Telefonos As List(Of String()) Implements IPersona.Telefonos

    Public Property CertificacionAltura As List(Of CertificacionAltura)

    Public Property Estudios As List(Of Estudios)

    Public Property Empresas As List(Of Empresa)

    Public Property HorariosLaborales As List(Of HorarioLaboral)
End Class
