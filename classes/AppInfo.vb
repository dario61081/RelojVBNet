Imports System.Reflection

Public Class AppInfo
    Public Shared Function ObtenerNumeroBuild() As String
        ' Obtener la información del ensamblado actual
        Dim ensamblado As Assembly = Assembly.GetExecutingAssembly()
        Dim version As Version = ensamblado.GetName().Version

        ' Retornar el número de compilación
        Return version.Build.ToString()
    End Function
End Class