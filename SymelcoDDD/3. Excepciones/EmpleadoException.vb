Public Class EmpleadoException
    Inherits Exception

    Public Sub New()
    End Sub

    Public Sub New(Mensaje As String)
        MyBase.New(Mensaje)
    End Sub

    Public Sub New(Mensaje As String, inner As Exception)
        MyBase.New(Mensaje, inner)
    End Sub
End Class
