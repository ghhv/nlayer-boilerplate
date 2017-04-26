Imports NLayerBoilerplate.Core.Services
Imports NLayerBoilerplate.Core.Models

Namespace Managers

    Public Class PersonManager

        Private Property PersonService As New PersonService

        Public Sub Create(person As PersonModel)
            PersonService.Create(person)
        End Sub

        Public Function FindById(id As Integer) As PersonModel
            Return PersonService.GetById(id)
        End Function

        Public Sub Update(person As PersonModel)
            PersonService.Update(person)
        End Sub

        Public Sub Delete(person As PersonModel)
            PersonService.Delete(person)
        End Sub

    End Class

End Namespace