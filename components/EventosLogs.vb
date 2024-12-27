Imports RelojVBNET.Models

Public Class EventsLogs

    Public Event OnGuardarEventos(lista As List(Of EventoDispositivoModel))

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub UpdateListView()
        ResizeListviewColumns(lvLog)
    End Sub

    Public Sub RegistrarEventos(lista As List(Of EventoDispositivoModel))


        lvLog.BeginUpdate()
        For Each record As EventoDispositivoModel In lista
            Dim row As New ListViewItem() With {.Text = record.FechaEvento}

            row.SubItems.Add(record.IdDispositivo)
            row.SubItems.Add(record.IdEvento)
            row.SubItems.Add(record.Descripcion)
            row.Tag = record
            Select Case record.TipoDeEvento
                Case TipoDeEvento.IsError, TipoDeEvento.Critico
                    row.ImageIndex = 2
                    row.ForeColor = Color.DarkRed
                Case TipoDeEvento.Advertencia
                    row.ImageIndex = 1
                    row.ForeColor = Color.DarkOrange
                Case Else
                    row.ImageIndex = 0
                    row.ImageIndex = 0
                    row.ForeColor = Color.DarkGreen
            End Select


            lvLog.Items.Add(row)
        Next
        'hacer visible el ultimo renglon
        If lvLog.Items.Count > 0 Then
            lvLog.Items(lvLog.Items.Count - 1).EnsureVisible()
        End If
        lvLog.EndUpdate()
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

    Private Function GetEventos() As List(Of EventoDispositivoModel)
        Dim l As List(Of EventoDispositivoModel) = New List(Of EventoDispositivoModel)
        For Each row As ListViewItem In lvLog.Items
            Dim record As EventoDispositivoModel = CType(row.Tag, EventoDispositivoModel)
            'si no existe el registro, crear 
            If record Is Nothing Then
                Debug.WriteLine($"{row.Text}, {row.SubItems(0).Text}, {row.SubItems(1).Text},{row.SubItems(2).Text}, {row.SubItems(3).Text}")
                record = New EventoDispositivoModel() With {
                    .IdDispositivo = CInt(row.SubItems(1).Text),
                    .TipoEvento = CInt(row.SubItems(2).Text),
                    .Descripcion = row.SubItems(3).Text
                }

                If Not DateTime.TryParse(row.SubItems(0).Text, record.FechaEvento) Then
                    Throw New Exception($"Formato invalido")
                End If

            End If

            'agregar a lista
            If record IsNot Nothing Then
                l.Add(record)
            End If

        Next

        Return l
    End Function

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        'Dim lista As List(Of EventoDispositivoModel) = New List(Of EventoDispositivoModel)


        RaiseEvent OnGuardarEventos(GetEventos)




    End Sub
End Class
