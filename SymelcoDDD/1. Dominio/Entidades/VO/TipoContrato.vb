Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class TipoContrato
    'Public Sub New()
    '    Empleados = New HashSet(Of Empleado)()
    'End Sub

    <Key>
    Public Property idTipoContrato As Integer

    <Required>
    <StringLength(100)>
    Public Property Nombre As String

    Public Property Activo As Boolean

    'Public Overridable Property Empleados As ICollection(Of Empleado)
End Class
