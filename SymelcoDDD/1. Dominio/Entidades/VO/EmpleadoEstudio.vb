Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class EmpleadoEstudio

    <Key>
    Public Property idEstudio As Integer

    <Column(TypeName:="smalldatetime")>
    Public Property FechaGraduacion As Date

    <Required>
    <StringLength(50)>
    Public Property Titulo As String

    <Required>
    <StringLength(100)>
    Public Property EntidadEducativa As String

    Public Overridable Property EmpleadosAdjuntosEstudios As ICollection(Of EmpleadoAdjuntoEstudio)
End Class
