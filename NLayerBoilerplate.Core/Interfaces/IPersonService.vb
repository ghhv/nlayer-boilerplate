Imports NLayerBoilerplate.Core.Models

Namespace Interfaces

    Public Interface IPersonService

        Sub Create(person As PersonModel)
        Function GetById(id As Integer) As PersonModel
        Function GetAll() As IEnumerable(Of PersonModel)
        Sub Update(person As PersonModel)
        Sub Delete(person As PersonModel)

    End Interface

End Namespace