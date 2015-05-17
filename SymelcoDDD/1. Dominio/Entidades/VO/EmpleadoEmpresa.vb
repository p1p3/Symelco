Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Partial Public Class EmpleadoEmpresa
    <Key, Column(Order:=1)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property idEmpleado As Integer

    <Key, Column(Order:=2)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property idEmpresa As Integer

    Public Property idHorarioLunes As Integer?

    Public Property idHorarioMartes As Integer?

    Public Property idHorarioMiercoles As Integer?

    Public Property idHorarioJueves As Integer?

    Public Property idHorarioViernes As Integer?

    Public Property idHorarioSabado As Integer?

    Public Property idHorarioDomingo As Integer?

    Public Overridable Property Empleado As Empleado

    Public Overridable Property Empresa As Empresa
End Class
