Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

<Table("HorariosIO")>
Partial Public Class HorariosIO
    <Key>
    Public Property idHorario As Integer

    Public Property HoraIngreso As Date

    Public Property HoraSalida As Date
End Class
