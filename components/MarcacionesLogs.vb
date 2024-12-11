Imports RelojVBNET.Models

Public Class MarcacionesLogs


    Private Sub RegistrarMarcacion(Record As AttendanceRecord, Optional Dispositivo As DispositivoModel = Nothing)

        With ListView1.Items.Add(Record.DateTime)
            .SubItems.Add(Record.EnrollNumber)
            .SubItems.Add(Record.InOutMode)
            .SubItems.Add(Record.DeviceNumber)
            .SubItems.Add(Record.WorkMode)
            .ImageIndex = 0
        End With

        If ListView1.Items.Count > 0 Then ListView1.Items(ListView1.Items.Count - 1).EnsureVisible()
        ContarEncontrados()
    End Sub

    Public Sub RegistrasMarcaciones(Records As List(Of AttendanceRecord), Optional Dispositivo As DispositivoModel = Nothing)
        If Records Is Nothing Then
            Return
        End If

        ListView1.BeginUpdate()
        For Each record As AttendanceRecord In Records
            RegistrarMarcacion(record, Dispositivo)
        Next
        ListView1.EndUpdate()
    End Sub

    Public Sub UpdateListView()
        Utiles.ResizeListviewColumns(listView:=ListView1)
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
