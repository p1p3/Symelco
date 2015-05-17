Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class EmpleadoCertificacion
    Public Sub New()
        EmpleadosAdjuntosCertificaciones = New HashSet(Of EmpleadoAdjuntoCertificacion)()
    End Sub

    <Key>
    Public Property idCertificacion As Integer

    <Column(TypeName:="smalldatetime")>
    Public Property FechaExpedicion As Date

    <Column(TypeName:="smalldatetime")>
    Public Property FechaVencimiento As Date?

    <StringLength(100)>
    Public Property EnteCertificador As String

    Public Property idTipoCertificacion As Integer

    Public Property idEmpleado As Integer

    Public Overridable Property Empleado As Empleado

    Public Overridable Property EmpleadosAdjuntosCertificaciones As ICollection(Of EmpleadoAdjuntoCertificacion)

    Public Overridable Property TipoCertificacion As TiposCertificacion
End Class
