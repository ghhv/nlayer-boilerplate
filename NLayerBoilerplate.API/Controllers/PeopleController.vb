Imports NLayerBoilerplate.Core.Managers
Imports NLayerBoilerplate.Core.Models
Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class PeopleController
        Inherits ApiController

        Private PersonManager As New PersonManager

        ' GET: api/People
        Public Function GetValues() As IHttpActionResult
            Return Ok(PersonManager.GetAll())
        End Function

        ' GET: api/People/5
        Public Function GetValue(ByVal id As Integer) As IHttpActionResult
            Return Ok(PersonManager.FindById(id))
        End Function

        ' DELETE: api/People/5
        Public Function DeleteValue(ByVal id As Integer) As IHttpActionResult
            Try
                PersonManager.Delete(id)
                Return Ok()
            Catch
                Return NotFound()
            End Try
        End Function
    End Class
End Namespace