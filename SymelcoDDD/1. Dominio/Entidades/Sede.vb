Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class Sede
    Public Sub New()
        Contactos = New HashSet(Of Contacto)()
    End Sub

    <Key>
    Public Property idSede As Integer

    <Required>
    <StringLength(200)>
    Public Property Nombre As String

    <Required>
    <StringLength(200)>
    Public Property Direccion As String

    Public Property idEmpresa As Integer

    Public Property Activo As Boolean

    Public Overridable Property Contactos As ICollection(Of Contacto)

    Public Overridable Property Empresa As Empresa
End Class

