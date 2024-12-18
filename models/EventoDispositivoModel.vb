Imports System

Namespace Models


    Public Enum TipoDeEvento
        Informacion = 1       ' Evento informativo
        Advertencia = 2       ' Advertencia o precaución
        IsError = 3           ' Error grave
        Depuracion = 4        ' Información para depuración
        Critico = 5           ' Evento crítico que requiere atención inmediata
    End Enum



    ''' <summary>
    ''' Representa un evento de un dispositivo de registro de tiempo
    ''' </summary>
    Public Class EventoDispositivoModel
        ''' <summary>
        ''' Identificador único del evento
        ''' </summary>
        Public Property IdEvento As Integer

        ''' <summary>
        ''' Identificador del dispositivo asociado
        ''' </summary>
        Public Property IdDispositivo As Integer

        ''' <summary>
        ''' Descripción del evento
        ''' </summary>
        Public Property Descripcion As String

        ''' <summary>
        ''' Tipo de evento (SUCCESS, ERROR, etc.)
        ''' </summary>
        Public Property TipoDeEvento As TipoDeEvento = TipoDeEvento.Informacion
        Public Property TipoEvento As Integer

        ''' <summary>
        ''' Fecha y hora del evento
        ''' </summary>
        Public Property FechaEvento As DateTime
    End Class
End Namespace
