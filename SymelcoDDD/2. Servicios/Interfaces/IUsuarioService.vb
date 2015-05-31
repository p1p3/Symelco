Public Interface IUsuarioService
    Sub CrearUsuario(Empleado As Usuario, Password As String)
    Function EncontrarPorId(id As Integer) As Usuario
    Function ObtenerTodos() As IEnumerable(Of Usuario)
End Interface
