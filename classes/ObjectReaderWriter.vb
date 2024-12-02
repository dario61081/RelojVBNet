Imports System.IO
Imports Newtonsoft.Json

Public Class ObjectReaderWriter(Of T As New)

    Public Shared Sub SaveToJson(Instance As List(Of T), Filepath As String)

        If Instance Is Nothing Then
            Throw New ArgumentNullException(NameOf(Instance), "La lista no puede ser nula")
        End If

        Dim jsonData As String = JsonConvert.SerializeObject(Instance, Formatting.Indented)
        File.WriteAllText(Filepath, jsonData)

    End Sub

    Public Shared Function LoadFromJson(Filepath As String) As List(Of T)
        If Not File.Exists(Filepath) Then
            Return Nothing
        End If

        Dim jsonData As String = File.ReadAllText(Filepath)
        Return JsonConvert.DeserializeObject(Of List(Of T))(jsonData)

    End Function




End Class
