Public Class MarcacionesLogs


    Public Sub RegistrarMarcacion(Record As AttendanceRecord)

        Dim row As New ListViewItem
        row.Text = Record.DateTime
        row.SubItems.Add(Record.EnrollNumber)
        row.SubItems.Add(Record.VerifyMode)
        row.SubItems.Add(Record.WorkMode)

        ListView1.Items.Add(row)


    End Sub

End Class
