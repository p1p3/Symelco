Imports Microsoft.AspNet.Identity.EntityFramework
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Usuario
    Inherits IdentityUser

    <Required>
    <MaxLength(100)>
    Public Property FirstName As String

    <Required>
    <MaxLength(100)>
    Public Property LastName As String

    <Required>
    Public Property Level As Byte

    <Required>
    Public Property JoinDate As DateTime
End Class
