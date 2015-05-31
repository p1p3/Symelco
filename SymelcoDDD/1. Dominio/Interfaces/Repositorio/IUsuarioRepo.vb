Public Interface IUsuarioRepo
    Sub Add(Usuario As Usuario)
    Sub Edit(Usuario As Usuario)
    Sub Remove(id As Int32)
    Function FindById(id As Int32) As Usuario
End Interface
