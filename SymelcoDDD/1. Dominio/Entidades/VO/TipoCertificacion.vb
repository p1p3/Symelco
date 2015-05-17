Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("TiposCertificacion")>
Partial Public Class TiposCertificacion
    Public Sub New()
        EmpleadosCertificaciones = New HashSet(Of EmpleadoCertificacion)()
    End Sub

    <Key>
    Public Property idTipoCertificacion As Integer

    <Required>
    <StringLength(100)>
    Public Property TipoCertificacion As String

    Public Property Activo As Boolean

    Public Overridable Property EmpleadosCertificaciones As ICollection(Of EmpleadoCertificacion)
End Class
