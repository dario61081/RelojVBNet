Imports RelojVBNET.Models

Public Class Reloj
    Public _id As String
    Public Dispositivo As DispositivoModel
    Public Conexion As ZKBiometricDevice

    Public Sub New()
        _id = Guid.NewGuid().ToString
        Dispositivo = New DispositivoModel()
        Conexion = New ZKBiometricDevice()
    End Sub



    Public Sub Dispose()
        Dispositivo = Nothing
        Conexion = Nothing
    End Sub


End Class
