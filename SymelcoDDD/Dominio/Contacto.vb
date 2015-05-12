Public Class Contacto
    Implements IPersona

    Public Property CedulaId As Int32 Implements IPersona.CedulaId

    Public Property Cedula As Cedula

    Public Property Correos As List(Of String()) Implements IPersona.Correos

    Public Property Direcciones As List(Of String()) Implements IPersona.Direcciones

    Public Property FechaNacimiento As Date Implements IPersona.FechaNacimiento

    Public Property ContactoId As Int32 Implements IPersona.Id

    Public Property Nombre As String Implements IPersona.Nombre

    Public Property Telefonos As List(Of String()) Implements IPersona.Telefonos
End Class
