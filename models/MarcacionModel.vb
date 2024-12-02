Imports System

Namespace Models
    ''' <summary>
    ''' Representa un registro de marcación de tiempo de un empleado
    ''' </summary>
    Public Class MarcacionModel
        ''' <summary>
        ''' Identificador único de la marcación
        ''' </summary>
        Public Property Id As Integer

        ''' <summary>
        ''' Número de legajo del empleado
        ''' </summary>
        Public Property Legajo As Integer

        ''' <summary>
        ''' Tipo de evento de marcación
        ''' 0: Entrada
        ''' 1: Salida
        ''' </summary>
        Public Property TipoEvento As Integer

        ''' <summary>
        ''' Fecha y hora de la marcación
        ''' </summary>
        Public Property Fecha As DateTime

        ''' <summary>
        ''' Identificador del dispositivo que registró la marcación
        ''' </summary>
        Public Property IdDispositivo As Integer
    End Class
End Namespace
