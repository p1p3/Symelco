Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class Empleado
    Public Sub New()
        Certificaciones = New HashSet(Of EmpleadoCertificacion)()
        Correos = New HashSet(Of EmpleadoCorreo)()
        Empresas = New HashSet(Of EmpleadoEmpresa)()
        Telefonos = New HashSet(Of EmpleadoTelefono)()
    End Sub

    <Key>
    Public Property idEmpleado As Integer

    <Column(TypeName:="smalldatetime")>
    Public Property FechaNacimiento As Date

    Public Property idRH As Integer

    Public Property idCargo As Integer

    Public Property idTipoContrato As Integer

    Public Property Cedula As Integer

    Public Property Activo As Boolean

    Public Overridable Property Cargo As Cargo

    Public Overridable Property Certificaciones As ICollection(Of EmpleadoCertificacion)

    Public Overridable Property RH As RH

    Public Overridable Property TipoContrato As TipoContrato

    Public Overridable Property Correos As ICollection(Of EmpleadoCorreo)

    Public Overridable Property Empresas As ICollection(Of EmpleadoEmpresa)

    Public Overridable Property Telefonos As ICollection(Of EmpleadoTelefono)

    Public Overloads Function Equals(ByVal obj As Object) As Boolean
        If IsNothing(obj) OrElse Not Me.GetType() Is obj.GetType() Then Return False
        Dim Empleado As Empleado = CType(obj, Empleado)
        Return Me.Cedula = Empleado.Cedula OrElse Me.idEmpleado = Empleado.idEmpleado
    End Function

    Public Function isValid() As Boolean
        Return IsNothing(Me)
        Return Not IsNumeric(Me.Cedula)
        Return IsNothing(Me.Cargo)
        Return IsNothing(Me.Telefonos) OrElse Me.Telefonos.Count < 1
    End Function

End Class
