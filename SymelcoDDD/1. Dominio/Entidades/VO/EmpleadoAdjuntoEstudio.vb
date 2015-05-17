Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class EmpleadoAdjuntoEstudio
    Public Property idEstudio As Integer

    <Required>
    <StringLength(500)>
    Public Property RutaAdjunto As String

    <Key>
    Public Property idAdjuntoEstudio As Integer

    Public Overridable Property EmpleadoEstudio As EmpleadoEstudio
End Class
