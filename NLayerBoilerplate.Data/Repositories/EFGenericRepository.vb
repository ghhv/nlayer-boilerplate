Imports NLayerBoilerplate.Data.Interfaces
Imports System.Data.Entity

Namespace Repositories

    Public Class EFGenericRepository(Of TEntity As Class, TKey)
        Implements IGenericRepository(Of TEntity, TKey)

        Private Property DbContext As DbContext

        Public Sub New(dbContext As DbContext)
            Me.DbContext = dbContext
        End Sub

        Public Sub Create(entity As TEntity) Implements IGenericRepository(Of TEntity, TKey).Create
            DbContext.Set(Of TEntity).Add(entity)
        End Sub

        Public Function Find(key As TKey) As TEntity Implements IGenericRepository(Of TEntity, TKey).Find
            Return DbContext.Set(Of TEntity).Find(key)
        End Function

        Public Function All() As IQueryable(Of TEntity) Implements IGenericRepository(Of TEntity, TKey).All
            Return DbContext.Set(Of TEntity).AsQueryable
        End Function

        Public Sub Update(entity As TEntity) Implements IGenericRepository(Of TEntity, TKey).Update
            DbContext.Set(Of TEntity).Attach(entity)
            DbContext.Entry(entity).State = EntityState.Modified
        End Sub

        Public Sub Delete(key As TKey) Implements IGenericRepository(Of TEntity, TKey).Delete
            Dim entity As TEntity = DbContext.Set(Of TEntity).Find(key)
            If DbContext.Entry(entity).State = EntityState.Detached Then
                DbContext.Set(Of TEntity).Attach(entity)
            End If
            DbContext.Set(Of TEntity).Remove(entity)
        End Sub
    End Class

End Namespace