Imports NLayerBoilerplate.Data.Models
Imports System.Data.Entity

Public Class ExampleDbContext
    Inherits DbContext

    Public Property People As DbSet(Of Person)

    Public Sub New()
        MyBase.New("Name=Example")
    End Sub

End Class
