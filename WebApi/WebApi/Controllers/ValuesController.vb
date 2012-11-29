﻿Imports System.Net
Imports System.Web.Http
Imports System.Net.Http

Public Class ValuesController
    Inherits ApiController

    ' GET api/values
    Public Function GetValues() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function

    ' GET api/values/5
    Public Function GetValue(ByVal id As Integer) As String
        Return "value"
    End Function

    ' POST api/values
    Public Function PostValue(ByVal value As IletisimModel) As HttpResponseMessage
        Dim response As HttpResponseMessage
        If value.MesajAt Then
            response = Request.CreateResponse(HttpStatusCode.OK)
        Else
            response = Request.CreateResponse(HttpStatusCode.BadGateway)
        End If
        Return response
    End Function

    ' PUT api/values/5
    Public Sub PutValue(ByVal id As Integer, ByVal value As String)

    End Sub

    ' DELETE api/values/5
    Public Sub DeleteValue(ByVal id As Integer)

    End Sub
End Class
