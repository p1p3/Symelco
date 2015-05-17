Imports System.Linq.Expressions

Public Interface IRepositorio(Of TEntity)
    Function GetAll() As IEnumerable(Of TEntity)
    Sub Add(Entidad As TEntity)
    Sub Edit(Entidad As TEntity)
    Sub Remove(id As Int32)
    Function FindById(id As Int32) As TEntity
    Function GetPaged(Of KProperty)(pageIndex As Int32, pageCount As Int32, orderByExpression As Expression(Of Func(Of TEntity, KProperty)), ascending As Boolean) As IEnumerable(Of TEntity)
    Function GetFiltered(filter As List(Of Expression(Of Func(Of TEntity, Boolean)))) As IEnumerable(Of TEntity)

End Interface
