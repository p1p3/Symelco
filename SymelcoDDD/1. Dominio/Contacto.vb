Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Contactos")>
Partial Public Class Contacto
    Public Sub New()
        Sedes = New HashSet(Of Sede)()
        Correos = New HashSet(Of Correo)()
        Telefonos = New HashSet(Of Telefono)()
    End Sub

    <Key>
    Public Property idContacto As Integer

    <Required>
    <StringLength(200)>
    Public Property Nombre As String

    Public Property idCedula As Integer

    Public Overridable Property Cedula As Cedula

    Public Overridable Property Sedes As ICollection(Of Sede)

    Public Overridable Property Correos As ICollection(Of Correo)

    Public Overridable Property Telefonos As ICollection(Of Telefono)
End Class
