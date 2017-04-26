Namespace Interfaces

    Public Interface IGenericRepository(Of TEntity, TKey)

        Sub Create(entity As TEntity)
        Function Find(key As TKey) As TEntity
        Function All() As IQueryable(Of TEntity)
        Sub Update(entity As TEntity)
        Sub Delete(key As TKey)

    End Interface

End Namespace