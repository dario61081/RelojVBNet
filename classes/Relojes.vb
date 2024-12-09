Public Class Relojes
    Private ListaDispositivos As List(Of Reloj)
    Public Sub New()
        ListaDispositivos = New List(Of Reloj)
    End Sub

    Public Sub RegistrarReloj(value As Reloj)
        If value Is Nothing Then
            Return
        End If
        ListaDispositivos.Add(value)
    End Sub

    Public Function ListarRelojes() As List(Of Reloj)
        Return ListaDispositivos
    End Function

End Class
