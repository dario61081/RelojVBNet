Public Class EventsLogs

    Dim ListaEventos As List(Of EventoLog)

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ListaEventos = New List(Of EventoLog)
        ListaEventos.Clear()
    End Sub

    Public Sub RecordLog(Data As EventoLog)
        ListaEventos.Add(Data)

    End Sub

    Private Sub ExportarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem.Click
        'exportar los datos
    End Sub
End Class
