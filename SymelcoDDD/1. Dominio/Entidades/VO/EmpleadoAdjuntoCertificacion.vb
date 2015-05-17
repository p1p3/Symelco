Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class EmpleadoAdjuntoCertificacion
    Public Property idCertificacion As Integer

    <Required>
    <StringLength(500)>
    Public Property RutaAdjunto As String

    <Key>
    Public Property idAdjuntoCertificacion As Integer

    Public Overridable Property EmpleadoCertificacion As EmpleadoCertificacion
End Class
