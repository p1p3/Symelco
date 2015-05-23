Imports Microsoft.Practices.Unity
Imports System
Imports System.Collections.Generic
Imports System.Web.Http.Dependencies

Public Class UnityResolver
    Implements IDependencyResolver

    Protected container As IUnityContainer

    Public Sub New(container As IUnityContainer)
        If IsNothing(container) Then Throw New ArgumentNullException("container")
        Me.container = container
    End Sub

    Public Function GetService(serviceType As Type) As Object Implements IDependencyScope.GetService
        Try
            Return container.Resolve(serviceType)
        Catch ex As ResolutionFailedException
            Return Nothing
        End Try
    End Function

    Public Function GetServices(serviceType As Type) As IEnumerable(Of Object) Implements IDependencyScope.GetServices
        Try
            Return container.ResolveAll(serviceType)
        Catch ex As ResolutionFailedException
            Return New List(Of Object)()
        End Try
    End Function

    Public Function BeginScope() As IDependencyScope Implements IDependencyResolver.BeginScope
        Dim child = container.CreateChildContainer()
        Return New UnityResolver(child)
    End Function


#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                container.Dispose()
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
