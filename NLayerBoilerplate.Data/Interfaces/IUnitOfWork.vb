Imports System.Data.Entity

Namespace Interfaces

    Public Interface IUnitOfWork(Of TEntity, TKey)

        ReadOnly Property Repository As IGenericRepository(Of TEntity, TKey)
        Sub SaveChanges()

    End Interface

End Namespace
