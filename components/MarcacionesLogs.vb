Public Class MarcacionesLogs


    Public Sub RegistrarMarcacion(Record As AttendanceRecord)
        Dim row As New ListViewItem With {
            .Text = Record.DateTime
        }
        row.SubItems.Add(Record.EnrollNumber)
        row.SubItems.Add(Record.VerifyMode)
        row.SubItems.Add(Record.WorkMode)

        ListView1.Items.Add(row)

        ''mostrar siempre el ultimo item
        If ListView1.Items.Count > 0 Then
            ListView1.Items(ListView1.Items.Count - 1).EnsureVisible()
        End If

    End Sub
    ''' <summary>
    ''' Limpia la lista
    ''' </summary>
    Public Sub Clear()
        ListView1.Items.Clear()
    End Sub

End Class
