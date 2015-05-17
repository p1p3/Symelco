Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class Cargo
    <Key>
    Public Property idCargo As Integer

    <Required>
    <StringLength(50)>
    Public Property Nombre As String

    Public Property Activo As Boolean

End Class
