Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Namespace Models

    <Table("Person")>
    Public Class Person

        <Key>
        Public Property Id As Integer

        <Required>
        Public Property Name As String

    End Class

End Namespace