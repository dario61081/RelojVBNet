Imports System.IO


Module Utiles


    'Genera un nombre de archivo temporal
    Public Function GetTempFilename(Optional extension As String = ".json") As String
        Dim timestamp As DateTime = DateTime.UtcNow
        Return timestamp.ToString("yyyy_MM_dd_hhmmss") + extension
    End Function

    'Retorna el directorio de trabajo
    Public Function GetDirectory(Optional folder As String = "data") As String

        Dim source = Path.Combine(Directory.GetCurrentDirectory, folder)
        If Not Directory.Exists(source) Then
            Directory.CreateDirectory(source)
        End If

        Return source

    End Function


    Public Function GetFirstDayOfMonth() As DateTime
        Dim fecha = DateTime.Now
        Dim firstDayOfMonth = New DateTime(fecha.Year, fecha.Month, 1)
        Return firstDayOfMonth
    End Function

    Public Function Ping(host As String) As Result(Of String)
        Const Timeout As Integer = 2500
        Try
            Dim reply = New System.Net.NetworkInformation.Ping().Send(host, Timeout)
            Dim ping_time As Long = 0
            If reply.Status = Global.System.Net.NetworkInformation.IPStatus.Success Then

                ping_time = reply.RoundtripTime
            Else
                Throw New Exception("Tiempo agotado, sin respuesta")


            End If
            Return Result(Of String).Success($"Detectado ({ping_time}ms)")
        Catch ex As Exception
            Return Result(Of String).Failure($"No detectado, [{ex.Message}]")

        End Try
    End Function

    ''' <summary>
    ''' Recalcular los anchos del listview
    ''' </summary>
    ''' <param name="listView"></param>
    Public Sub ResizeListviewColumns(listView As ListView)
        listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)
        listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
    End Sub

    Public Function GetCacheDirectory(Optional subfolder As String = "cache")
        'genera un path para el directorio subfolder
        Dim source = Path.Combine(GetDirectory(), subfolder)
        If Not Directory.Exists(source) Then
            Directory.CreateDirectory(source)
        End If

        Return source

    End Function



End Module
