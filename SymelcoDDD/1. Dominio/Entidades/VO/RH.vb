Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class RH
    'Public Sub New()
    '    Empleados = New HashSet(Of Empleado)()
    'End Sub

    <Key>
    Public Property idRH As Integer

    <Column("RH")>
    <Required>
    <StringLength(10)>
    Public Property Nombre As String

    'Public Overridable Property Empleados As ICollection(Of Empleado)
End Class
