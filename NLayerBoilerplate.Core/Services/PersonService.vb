Imports NLayerBoilerplate.Core.Interfaces
Imports NLayerBoilerplate.Core.Models
Imports NLayerBoilerplate.Data.Models
Imports NLayerBoilerplate.Data

Namespace Services

    Public Class PersonService
        Implements IPersonService

        Private ReadOnly Property UnitOfWork As EFUnitOfWork(Of Person, Integer)

        Public Sub Create(person As PersonModel) Implements IPersonService.Create
            UnitOfWork.Repository.Create(person)
            UnitOfWork.SaveChanges()
        End Sub

        Public Function GetById(id As Integer) As PersonModel Implements IPersonService.GetById
            Return UnitOfWork.Repository.Find(id)
        End Function

        Public Function GetAll() As IEnumerable(Of PersonModel) Implements IPersonService.GetAll
            Dim people As New List(Of PersonModel)
            UnitOfWork.Repository.All.ToList.ForEach(Sub(i) people.Add(i))
            Return people
        End Function

        Public Sub Update(person As PersonModel) Implements IPersonService.Update
            UnitOfWork.Repository.Update(person)
            UnitOfWork.SaveChanges()
        End Sub

        Public Sub Delete(person As PersonModel) Implements IPersonService.Delete
            UnitOfWork.Repository.Delete(person.Id)
            UnitOfWork.SaveChanges()
        End Sub

    End Class

End Namespace