Public Interface IPersona
    Property Id As Int32
    Property Nombre As String
    Property Telefonos As List(Of String())
    Property Direcciones As List(Of String())
    Property Correos As List(Of String())
    Property FechaNacimiento As DateTime
    Property CedulaId As Int32
End Interface
