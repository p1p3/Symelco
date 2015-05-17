Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class RH
    <Key>
    Public Property idRH As Integer

    <Column("RH")>
    <Required>
    <StringLength(10)>
    Public Property Nombre As String

End Class
