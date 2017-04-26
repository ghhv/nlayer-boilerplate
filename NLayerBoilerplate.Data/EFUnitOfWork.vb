Imports NLayerBoilerplate.Data.Interfaces
Imports NLayerBoilerplate.Data.Repositories
Imports System.Data.Entity

Public Class EFUnitOfWork(Of TEntity As Class, TKey)
    Implements IUnitOfWork(Of TEntity, TKey), IDisposable

    Private ReadOnly Property DbContext As DbContext
    Public Property Repository As IGenericRepository(Of TEntity, TKey) Implements IUnitOfWork(Of TEntity, TKey).Repository

    Public Sub New(dbContext As DbContext)
        Me.DbContext = dbContext
        Me.Repository = New EFGenericRepository(Of TEntity, TKey)(Me.DbContext)
    End Sub

    Public Sub SaveChanges() Implements IUnitOfWork(Of TEntity, TKey).SaveChanges
        DbContext.SaveChanges()
    End Sub

#Region "IDisposable Support"
    Private disposed As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposed Then
            If disposing Then
                DbContext.Dispose()
            End If
        End If
        disposed = True
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        System.GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class
