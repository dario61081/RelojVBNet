Public Class EventoLog
    Public Property Fecha As String
    Public Property Mensaje As String
    Public Property Tipo As EventoTipo = EventoTipo.INFO

    Public Sub New(fecha As String, mensaje As String, Optional tipo As EventoTipo = EventoTipo.INFO)
        Me.Fecha = fecha
        Me.Mensaje = mensaje
        Me.Tipo = tipo
    End Sub



End Class
