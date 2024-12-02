Imports System

Namespace Models
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
        Public Property TipoEvento As String

        ''' <summary>
        ''' Fecha y hora del evento
        ''' </summary>
        Public Property FechaEvento As DateTime
    End Class
End Namespace
