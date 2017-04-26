Imports NLayerBoilerplate.Data.Models

Namespace Models

    Public Class PersonModel

        Private Property _Id As Integer

        Public Property Id As Integer
            Get
                Return _Id
            End Get
            Private Set(value As Integer)
                Me._Id = value
            End Set
        End Property

        Public Property Name As String

        Public Shared Narrowing Operator CType(model As Person) As PersonModel
            Return New PersonModel With {
                .Id = model.Id,
                .Name = model.Name
            }
        End Operator

        Public Shared Narrowing Operator CType(model As PersonModel) As Person
            Return New Person With {
                .Id = model.Id,
                .Name = model.Name
            }
        End Operator

    End Class

End Namespace