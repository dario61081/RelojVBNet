Imports System.IO

Module Utiles


    'Genera un nombre de archivo temporal
    Public Function GetTempFilename(Optional extension As String = ".json") As String
        Dim timestamp As DateTime = DateTime.UtcNow
        Return timestamp.ToString("yyyy_MM_dd_hhmmss") + extension
    End Function

    'Retorna el directorio de trabajo
    Public Function GetDirectory(Optional folder As String = "data") As String

        Dim source = Path.Combine(Directory.GetCurrentDirectory, folder)
        If Not Directory.Exists(source) Then
            Directory.CreateDirectory(source)
        End If

        Return source

    End Function


End Module
