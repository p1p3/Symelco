Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class Empresa

    Public Sub New()
        Empleados = New HashSet(Of EmpleadoEmpresa)()
        Sedes = New HashSet(Of Sede)()
    End Sub
    <Key>
    Public Property idEmpresa As Integer

    <Required>
    <StringLength(50)>
    Public Property Nombre As String

    <Required>
    <StringLength(50)>
    Public Property NIT As String

    Public Property Activo As Boolean

    Public Overridable Property Empleados As ICollection(Of EmpleadoEmpresa)

    Public Overridable Property Sedes As ICollection(Of Sede)

    Public Overloads Function Equals(ByVal obj As Object) As Boolean
        If IsNothing(obj) OrElse Not Me.GetType() Is obj.GetType() Then Return False
        Dim Empresa As Empresa = CType(obj, Empresa)
        Return Me.NIT = Empresa.NIT OrElse Me.Nombre = Empresa.Nombre
    End Function


End Class





