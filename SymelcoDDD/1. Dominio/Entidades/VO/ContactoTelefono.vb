Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class ContactoTelefono
    <Key, Column(Order:=1)>
    Public Property idTelefono As Integer

    <Key, Column(Order:=2)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property idContacto As Integer

    <Required>
    <StringLength(100)>
    Public Property Telefono As String


    Public Property Activo As Boolean

    Public Overridable Property Contacto As Contacto
End Class
