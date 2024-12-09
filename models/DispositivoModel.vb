Namespace Models
    ''' <summary>
    ''' Representa un dispositivo de registro de tiempo
    ''' </summary>
    Public Class DispositivoModel
        ''' <summary>
        ''' Identificador único del dispositivo
        ''' </summary>
        Public Property IdDispositivo As Integer

        ''' <summary>
        ''' Descripción del dispositivo
        ''' </summary>
        Public Property Descripcion As String

        ''' <summary>
        ''' Dirección IP del dispositivo
        ''' </summary>
        Public Property DireccionIp As String

        ''' <summary>
        ''' Puerto de conexión del dispositivo
        ''' </summary>
        Public Property Puerto As String

        ''' <summary>
        ''' Clave de administrador del dispositivo
        ''' </summary>
        Public Property ClaveAdmin As String

        ''' <summary>
        ''' Estado del dispositivo (habilitado/deshabilitado)
        ''' </summary>
        Public Property Estado As Boolean

        ''' <summary>
        ''' Fecha de creación del dispositivo
        ''' </summary>
        Public Property FechaCreacion As DateTime



    End Class
End Namespace
