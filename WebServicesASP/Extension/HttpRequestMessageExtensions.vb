Imports System.Net
Imports System.Net.Http
Imports System.Web
Imports System.Runtime.CompilerServices
Imports System.Web.Http

Module HttpRequestMessageExtensions
    <Extension()> _
    Public Function CreateResponse2(Of T)(ByVal request As HttpRequestMessage, statusCode As HttpStatusCode, value As T) As HttpResponseMessage
        Return request.CreateResponse(Of T)(statusCode, value)
    End Function

    <Extension()> _
    Public Function CreateResponse2(Of T)(ByVal request As HttpRequestMessage, statusCode As HttpStatusCode, value As T, Configuration As HttpConfiguration) As HttpResponseMessage
        Return request.CreateResponse(Of T)(statusCode, value, Configuration)
    End Function

    <Extension()> _
    Public Function CreateResponse2(Of T)(ByVal request As HttpRequestMessage, statusCode As HttpStatusCode, value As T, mediaType As String) As HttpResponseMessage
        Return request.CreateResponse(Of T)(statusCode, value, mediaType)
    End Function

    <Extension()> _
    Public Function CreateResponse2(Of T)(ByVal request As HttpRequestMessage, statusCode As HttpStatusCode, value As T, formatter As Formatting.MediaTypeFormatter) As HttpResponseMessage
        Return request.CreateResponse(Of T)(statusCode, value, formatter)
    End Function

    <Extension()> _
    Public Function CreateResponse2(Of T)(ByVal request As HttpRequestMessage, statusCode As HttpStatusCode, value As T, mediaType As Headers.MediaTypeHeaderValue) As HttpResponseMessage
        Return request.CreateResponse(Of T)(statusCode, value, mediaType)
    End Function

    <Extension()> _
    Public Function CreateResponse2(Of T)(ByVal request As HttpRequestMessage, statusCode As HttpStatusCode, value As T, formatter As Formatting.MediaTypeFormatter, mediaType As String) As HttpResponseMessage
        Return request.CreateResponse(Of T)(statusCode, value, formatter, mediaType)
    End Function

    <Extension()> _
    Public Function CreateResponse2(Of T)(ByVal request As HttpRequestMessage, statusCode As HttpStatusCode, value As T, formatter As Formatting.MediaTypeFormatter, mediaType As Headers.MediaTypeHeaderValue) As HttpResponseMessage
        Return request.CreateResponse(Of T)(statusCode, value, formatter, mediaType)
    End Function

End Module
