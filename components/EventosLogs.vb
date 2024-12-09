Public Class EventsLogs



    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Public Sub RegistrarEvento(message As String)
        Dim row As New ListViewItem
        row.Text = DateTime.Now
        row.SubItems.Add(0)
        row.SubItems.Add(0)
        row.SubItems.Add(message)

        lvLog.Items.Add(row)
        'hacer visible el ultimo renglon
        If lvLog.Items.Count > 0 Then
            lvLog.Items(lvLog.Items.Count - 1).EnsureVisible()
        End If
    End Sub


End Class
