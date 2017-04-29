Imports System.Web.Optimization

Public Class BundleConfig

    Public Shared Sub RegisterBundles(bundles As BundleCollection)
        bundles.Add(New ScriptBundle("~/bundles/scripts").
            IncludeDirectory("~/Scripts/Libraries", "*.js").
            IncludeDirectory("~/Scripts/Components", "*.js", True).
            Include("~/Scripts/app.js"))
    End Sub

End Class
