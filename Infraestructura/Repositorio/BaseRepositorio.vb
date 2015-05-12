Imports System.Data.Entity

Public Class BaseRepositorio(Of TEntity As Class)
    Implements Core.IRepositorio(Of TEntity)

    Implements IDisposable

    Private _Contexto As DbContext

    Public Sub New(ByVal contexto As DbContext)
        _Contexto = contexto
    End Sub

    Public Sub Add(Entity As TEntity) Implements Core.IRepositorio(Of TEntity).Add
        _Contexto.[Set](Of TEntity)().Add(Entity)
        _Contexto.SaveChanges()
    End Sub

    Public Sub Edit(Entity As TEntity) Implements Core.IRepositorio(Of TEntity).Edit
        _Contexto.[Set](Of TEntity)().Attach(Entity)
        _Contexto.Entry(Of TEntity)(Entity).State = EntityState.Modified
        _Contexto.SaveChanges()
    End Sub

    Public Function FindById(id As Integer) As TEntity Implements Core.IRepositorio(Of TEntity).FindById
        Return _Contexto.[Set](Of TEntity)().Find(id)
    End Function

    Public Function GetAll() As IEnumerable(Of TEntity) Implements Core.IRepositorio(Of TEntity).GetAll
        Return _Contexto.[Set](Of TEntity)()
    End Function

    Public Sub Remove(id As Integer) Implements Core.IRepositorio(Of TEntity).Remove
        Dim Entity As TEntity = _Contexto.[Set](Of TEntity)().Find(id)
        _Contexto.Entry(Of TEntity)(Entity).State = EntityState.Deleted
        _Contexto.SaveChanges()
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        _Contexto.Dispose()
    End Sub

    Public Function GetFiltered(filter As List(Of Expressions.Expression(Of Func(Of TEntity, Boolean)))) As IEnumerable(Of TEntity) Implements Core.IRepositorio(Of TEntity).GetFiltered
        Return _Contexto.[Set](Of TEntity)()
    End Function

    Public Function GetPaged(Of KProperty)(pageIndex As Integer, pageCount As Integer, orderByExpression As Expressions.Expression(Of Func(Of TEntity, KProperty)), ascending As Boolean) As IEnumerable(Of TEntity) Implements Core.IRepositorio(Of TEntity).GetPaged
        Return _Contexto.[Set](Of TEntity)()
    End Function


    Public Function Include(Of KProperty)(source As IQueryable(Of TEntity), path As Expressions.Expression(Of Func(Of TEntity, KProperty))) As IQueryable(Of TEntity)
        'Dim source As IQueryable(Of TEntity)
        'Dim path As Expressions.Expression(Of Func(Of TEntity, KProperty))
        'Dim returnValue As IQueryable(Of TEntity)
        'returnValue = source.Include(path)
    End Function



End Class
