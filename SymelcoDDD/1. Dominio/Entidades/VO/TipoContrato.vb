Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class TipoContrato
    <Key>
    Public Property idTipoContrato As Integer

    <Required>
    <StringLength(100)>
    Public Property Nombre As String

    Public Property Activo As Boolean

End Class
