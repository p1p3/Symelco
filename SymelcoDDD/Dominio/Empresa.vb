Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Empresa

    <Required>
    Property EmpresaId As Int32

    <MaxLength(50)>
    Property Nombre As String

    <Required> _
    Property NIT As String

    <Required>
    Property ContactoId As Int32

    Property PersonaContacto As Contacto
End Class
