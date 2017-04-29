Imports System.Web.Mvc
Imports NLayerBoilerplate.Core

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        ' GET: Home
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace