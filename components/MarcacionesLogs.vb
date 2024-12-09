Imports RelojVBNET.Models

Public Class MarcacionesLogs


    Public Sub RegistrarMarcacion(Record As AttendanceRecord, Optional Dispositivo As DispositivoModel = Nothing)
        Dim DispositivoID As Integer = If(Dispositivo?.IdDispositivo, 0)

        Dim row As New ListViewItem With {
            .Text = Record.DateTime
        }
        row.SubItems.Add(Record.EnrollNumber)
        row.SubItems.Add(Record.VerifyMode)
        row.SubItems.Add(DispositivoID)
        row.SubItems.Add(Record.WorkMode)

        ListView1.Items.Add(row)

        ''mostrar siempre el ultimo item
        If ListView1.Items.Count > 0 Then
            ListView1.Items(ListView1.Items.Count - 1).EnsureVisible()
        End If

        ContarEncontrados()

    End Sub

    Private Sub ContarEncontrados()
        lblContador.Text = $"Encontrado(s): {ListView1.Items.Count}"
    End Sub

    ''' <summary>
    ''' Limpia la lista
    ''' </summary>
    Public Sub Clear()
        ListView1.Items.Clear()
        ContarEncontrados()
    End Sub

End Class
