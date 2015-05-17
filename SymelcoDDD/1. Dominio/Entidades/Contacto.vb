Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema


Partial Public Class Contacto
    Public Sub New()
        Telefonos = New HashSet(Of ContactoTelefono)()
        Correos = New HashSet(Of ContactoCorreo)()
    End Sub

    <Key>
    Public Property idContacto As Integer

    <Required>
    <StringLength(200)>
    Public Property Nombre As String

    Public Property idCedula As Integer

    Public Property idSede As Integer

    Public Property Activo As Boolean

    Public Overridable Property Sede As Sede

    Public Overridable Property Telefonos As ICollection(Of ContactoTelefono)

    Public Overridable Property Correos As ICollection(Of ContactoCorreo)
End Class
