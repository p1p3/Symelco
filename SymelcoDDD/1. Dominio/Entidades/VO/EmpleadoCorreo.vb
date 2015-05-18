Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class EmpleadoCorreo
    <Key, Column(Order:=1)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property idEmpleado As Integer

    <Key, Column(Order:=2)>
    Public Property idCorreo As Integer

    <Required>
    <StringLength(100)>
    Public Property Correo As String

    Public Property Activo As Boolean

    Public Overridable Property Empleado As Empleado
End Class
