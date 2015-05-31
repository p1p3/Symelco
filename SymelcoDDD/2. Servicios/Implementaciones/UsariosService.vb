Imports Microsoft.AspNet.Identity

Public Class UsariosService
    Implements IUsuarioService

    Private userManager As UserManager(Of Usuario)
    Private Repositorio As IUsuarioRepo

    Public Sub New(ByVal Repositorio As IUsuarioRepo, UserStore As IUserStore(Of Usuario))
        Me.Repositorio = Repositorio
        Me.userManager = New UserManager(Of Core.Usuario)(UserStore)
    End Sub

    Public Sub CrearUsuario(oUsuario As Usuario, ByVal Password As String) Implements IUsuarioService.CrearUsuario
        Try
            Me.userManager.Create(oUsuario, Password)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function EncontrarPorId(id As Integer) As Usuario Implements IUsuarioService.EncontrarPorId
        Return userManager.findbyid(id)
    End Function

    Public Function ObtenerTodos() As IEnumerable(Of Usuario) Implements IUsuarioService.ObtenerTodos
        Return userManager.Users
    End Function

    Public Function BorrarUsuario(Usuario As Usuario)
        userManager.DeleteAsync(Usuario)
        Return True
    End Function
End Class
