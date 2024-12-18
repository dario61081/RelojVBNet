Imports RelojVBNET.Models

Public Class WorkerParams
    Public Property Dispositivos As List(Of DispositivoModel)
    Public Property Parametros As LecturaParametros
    Public Property Eventos As List(Of EventoDispositivoModel)
    Public Property Marcaciones As List(Of AttendanceRecord)
End Class
