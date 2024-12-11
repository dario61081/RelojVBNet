Imports System.IO
Imports RelojVBNET.Models


Public Class Lectura
    Private Dispositivos As Relojes
    Private WithEvents Device As New ZKBiometricDevice()




    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Device = New ZKBiometricDevice()
        Dispositivos = New Relojes()
    End Sub


    Private Sub MarcacionesLogs1_Load(sender As Object, e As EventArgs) Handles MarcacionesLogs1.Load
        Dim numeroBuild As String = AppInfo.ObtenerNumeroBuild()
        'leer relojes de la base de datos 
        Dim relojes As List(Of DispositivoModel) = CargarDispositivosBBDD()
        Log("Cargando relojes de la base de datos")
        For Each row As DispositivoModel In relojes
            Dim _reloj As New Reloj()
            _reloj.Dispositivo = row
            Dispositivos.RegistrarReloj(_reloj)
        Next

        lblversion.Text = $"Ver: 1.0.{numeroBuild}"


        RelojesList1.RegistrarTodo(relojes)
        RelojesList1.VerificarRelojes()
        Log("Listo")

        MarcacionesLogs1.UpdateListView()
        EventsLogs1.UpdateListView()
    End Sub

    Private Async Sub RelojesList1_LeerDispostivos(Lista As List(Of DispositivoModel), Parametros As LecturaParametros) Handles RelojesList1.LeerDispostivos
        Me.Invoke(Sub()
                      progressbar1.Visible = True
                      progressbar1.Style = ProgressBarStyle.Marquee
                  End Sub)

        MarcacionesLogs1.Clear()
        Log("Iniciando lectura datos, aguarde...")

        For Each row As DispositivoModel In Lista
            'leer marcaciones
            Await Task.Run(Sub() LeerAttendances(row, Parametros))
        Next
        Log("Finalizado lectura de datos")
        Me.Invoke(Sub()
                      progressbar1.Visible = False
                      progressbar1.Style = ProgressBarStyle.Marquee
                  End Sub)

        'avisar que la lectura ha terminado con un messagebox
        Me.Invoke(Sub()
                      MarcacionesLogs1.UpdateListView()
                      EventsLogs1.UpdateListView()

                      MessageBox.Show("Lectura finalizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                  End Sub)


    End Sub

    ''' <summary>
    ''' Cachear los datos del marcado de los relojes
    ''' </summary>
    ''' <param name="dispositivo"></param>
    ''' <param name="data"></param>
    Private Async Sub BackupLecturas(dispositivo As DispositivoModel, data As List(Of AttendanceRecord))
        'genera el nombre del archivo del reloj 
        Dim backupfolder As String = GetCacheDirectory("marcaciones")
        'genera el nombre del archivo con timestamp
        Dim filename As String = Path.Combine(backupfolder, "marcaciones_" & dispositivo.DireccionIp & $"_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}" & ".json")

        Await Task.Run(Sub() ObjectReaderWriter(Of AttendanceRecord).SaveToJson(data, filename))


    End Sub



    Private Async Sub LeerAttendances(dispositivo As DispositivoModel, params As LecturaParametros)
        Log($"Leyendo datos del reloj {dispositivo.Descripcion} ({dispositivo.DireccionIp}:{dispositivo.Puerto})")
        Log($"Parametros: Modo={params.Modo}, FechaDesde={params.FechaDesde}, FechaHasta={params.FechaHasta}")

        Dim _device As New ZKBiometricDevice()
        Dim estado As Boolean

        Try
            estado = _device.Connect(dispositivo)
            If Not estado Then
                LogError($"No se pudo conectar al reloj {dispositivo.Descripcion} ({dispositivo.DireccionIp}:{dispositivo.Puerto})", dispositivo)
                Return
            End If
            'obtener marcaciones
            Dim lista As List(Of AttendanceRecord) = Await _device.GetAttendanceLogsAsync()
            'backup marcaciones
            Await Task.Run(Sub() BackupLecturas(dispositivo, lista))
            'si no hay registros
            If lista Is Nothing OrElse lista.Count = 0 Then
                Log($"No se encontraron registros en el reloj {dispositivo.Descripcion}", dispositivo)
            Else
                Log($"Se recuperaron {lista.Count} registros del reloj {dispositivo.Descripcion}", dispositivo)
                Me.Invoke(Sub()
                              MarcacionesLogs1.RegistrasMarcaciones(lista, dispositivo)
                          End Sub)
            End If

        Catch ex As Exception
            LogError($"Error al procesar los datos del reloj {dispositivo.Descripcion}: {ex.Message}", dispositivo)
        Finally
            If estado Then
                _device.Disconnect()
                Log($"Desconectado del reloj {dispositivo.Descripcion}", dispositivo)
            End If
        End Try
    End Sub

    Public Function CargarDispositivosBBDD() As List(Of DispositivoModel)

        Dim ArbolDispositivos As List(Of DispositivoModel) = New List(Of DispositivoModel)
        Dim ConfigFilename As String = Path.Combine(GetCacheDirectory("configuraciones"), "dispositivos.json")

        ArbolDispositivos = ObjectReaderWriter(Of DispositivoModel).LoadFromJson(ConfigFilename)
        If ArbolDispositivos Is Nothing Then
            Log("No se encontraron dispositivos en la base de datos, cargando datos locales")
            Dim ConfigDemoFilename As String = Path.Combine(GetCacheDirectory("configuraciones"), "dispositivos_demo.json")
            ArbolDispositivos = ObjectReaderWriter(Of DispositivoModel).LoadFromJson(ConfigDemoFilename)
        End If
        Return ArbolDispositivos
    End Function

    ''' <summary>
    ''' registrar eventos del sistema
    ''' </summary>
    ''' <param name="message"></param>
    Public Sub Log(message As String, Optional Dispositivo As DispositivoModel = Nothing)
        Debug.WriteLine($"Log: {message}")
        Me.Invoke(
            Sub()
                EventsLogs1.RegistrarEvento(message, Dispositivo)
            End Sub
            )

    End Sub
    Public Sub LogError(message As String, Optional Dispositivo As DispositivoModel = Nothing)
        Debug.WriteLine($"Error: {message}")
        Me.Invoke(
            Sub()
                EventsLogs1.RegistrarError(message, Dispositivo)
            End Sub
            )
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'para exportar los datos al dataset
    End Sub

    Private Async Sub RelojesList1_BorrarMarcaciones(Lista As List(Of DispositivoModel)) Handles RelojesList1.BorrarMarcaciones
        If Lista Is Nothing Then
            Return
        End If
        Dim _device As New ZKBiometricDevice()
        Dim estado As Boolean
        Me.Invoke(Sub()
                      progressbar1.Visible = True
                      progressbar1.Style = ProgressBarStyle.Marquee
                  End Sub)
        For Each dispositivo In Lista
            Log($"Borrando datos del reloj {dispositivo.Descripcion} ({dispositivo.DireccionIp}:{dispositivo.Puerto})")

            Try
                Await Task.Run(Sub() estado = _device.Connect(dispositivo))

                If Not estado Then
                    LogError($"No se pudo conectar al reloj {dispositivo.Descripcion} ({dispositivo.DireccionIp}:{dispositivo.Puerto})", dispositivo)
                    Continue For
                End If

                Await Task.Run(Sub()
                                   estado = _device.ClearLogs()
                               End Sub)

                If estado = False Then
                    LogError($"No se borraron registros del reloj {dispositivo.Descripcion}", dispositivo)
                End If

            Catch ex As Exception
                LogError($"Error al borrar registros del reloj {dispositivo.Descripcion}: {ex.Message}", dispositivo)
            Finally
                If estado Then
                    _device.Disconnect()
                    Log($"Desconectado del reloj {dispositivo.Descripcion}", dispositivo)
                End If
            End Try
        Next

        Me.Invoke(Sub()
                      progressbar1.Visible = False
                      progressbar1.Style = ProgressBarStyle.Marquee
                      MessageBox.Show("Tarea finalizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                  End Sub)
    End Sub


End Class