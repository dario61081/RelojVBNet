Imports RelojVBNET.Models

Public Class EventsLogs



    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub UpdateListView()
        ResizeListviewColumns(lvLog)
    End Sub

    Public Sub RegistrarEventos(lista As List(Of EventoDispositivoModel))



        For Each record As EventoDispositivoModel In lista
            Dim row As New ListViewItem() With {.Text = record.FechaEvento}

            row.SubItems.Add(record.IdDispositivo)
            row.SubItems.Add(0)
            row.SubItems.Add(record.TipoEvento)
            row.ImageIndex = 2
            row.ForeColor = Color.DarkRed
            lvLog.Items.Add(row)
        Next
        'hacer visible el ultimo renglon
        If lvLog.Items.Count > 0 Then
            lvLog.Items(lvLog.Items.Count - 1).EnsureVisible()
        End If

        ContarEncontrados()


    End Sub
    Public Sub RegistrarError(message As String, Optional Dispositivo As DispositivoModel = Nothing)
        Dim row As New ListViewItem
        Dim dispositivoID As Integer = If(Dispositivo?.IdDispositivo, 0)
        row.Text = DateTime.Now

        row.SubItems.Add(dispositivoID)
        row.SubItems.Add(0)
        row.SubItems.Add(message)
        row.ImageIndex = 2
        row.ForeColor = Color.DarkRed
        lvLog.Items.Add(row)
        'hacer visible el ultimo renglon
        If lvLog.Items.Count > 0 Then
            lvLog.Items(lvLog.Items.Count - 1).EnsureVisible()
        End If

        ContarEncontrados()

    End Sub


    Public Sub RegistrarEvento(message As String, Optional Dispositivo As DispositivoModel = Nothing)
        Dim row As New ListViewItem
        Dim dispositivoID As Integer = If(Dispositivo?.IdDispositivo, 0)
        row.Text = DateTime.Now
        row.SubItems.Add(dispositivoID)
        row.SubItems.Add(0)
        row.SubItems.Add(message)
        row.ImageIndex = 0
        row.ForeColor = Color.DarkGreen

        lvLog.Items.Add(row)
        'hacer visible el ultimo renglon
        If lvLog.Items.Count > 0 Then
            lvLog.Items(lvLog.Items.Count - 1).EnsureVisible()
        End If

        ContarEncontrados()

    End Sub

    Private Sub ContarEncontrados()
        'contar encontrados
        lblContador.Text = $"Encontrado(s) : {lvLog.Items.Count}"
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'confirmar si quiere limpiar
        Dim result = MessageBox.Show("Desea limpiar los eventos?", "Limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            lvLog.Items.Clear()
        End If
        ContarEncontrados()
    End Sub
End Class
