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
    End Sub

    Private Async Sub RelojesList1_LeerDispostivos(Lista As List(Of DispositivoModel), Parametros As LecturaParametros) Handles RelojesList1.LeerDispostivos
        Me.Invoke(Sub()
                      progressbar1.Visible = True
                      progressbar1.Style = ProgressBarStyle.Marquee
                  End Sub)

        MarcacionesLogs1.Clear()
        Log("Iniciando lectura datos, aguarde...")
        For Each row As DispositivoModel In Lista
            Await Task.Run(Sub() LeerAttendances(row, Parametros))
        Next
        Log("Finalizado lectura de datos")
        Me.Invoke(Sub()
                      progressbar1.Visible = False
                      progressbar1.Style = ProgressBarStyle.Marquee
                  End Sub)

        'avisar que la lectura ha terminado con un messagebox
        Me.Invoke(Sub()
                      MessageBox.Show("Lectura finalizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                  End Sub)

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

            Dim lista As List(Of AttendanceRecord) = Nothing
            Await Task.Run(Sub()
                               lista = _device.GetAttendanceLogs()
                           End Sub)

            If lista IsNot Nothing AndAlso lista.Count > 0 Then
                Log($"Se recuperaron {lista.Count} registros del reloj {dispositivo.Descripcion}", dispositivo)
                For Each record As AttendanceRecord In lista
                    Dim processRecord As Boolean = params.Modo <> 1 OrElse
                                               (record.DateTime.Date >= params.FechaDesde.Date AndAlso record.DateTime.Date <= params.FechaHasta.Date)
                    If processRecord Then
                        Me.Invoke(Sub()
                                      MarcacionesLogs1.RegistrarMarcacion(record)
                                  End Sub)
                    End If
                Next
            Else
                Log($"No se encontraron registros en el reloj {dispositivo.Descripcion}", dispositivo)
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

    'Private Async Sub LeerAttendances(dispositivo As DispositivoModel, params As LecturaParametros)


    '    Log($"Leyendo datos del reloj {dispositivo.Descripcion } ({dispositivo.DireccionIp}:{dispositivo.Puerto})")
    '    Log($"Parametros {params.Modo } - {params.FechaDesde } - {params.FechaHasta }")
    '    Dim _device As New ZKBiometricDevice()
    '    Dim estado = _device.Connect(dispositivo.DireccionIp, dispositivo.Puerto)
    '    'preguntar si esta conectado, si no avisar y volver
    '    If estado = False Then
    '        Log($"No se pudo conectar al reloj {dispositivo.Descripcion } ({dispositivo.DireccionIp}:{dispositivo.Puerto})")
    '        Return
    '    End If

    '    Dim lista As List(Of AttendanceRecord)

    '    Await Task.Run(Sub() lista = _device.GetAttendanceLogs())

    '    If lista IsNot Nothing Then

    '        For Each record As AttendanceRecord In lista

    '            If params.Modo = 1 AndAlso (record.DateTime.Date >= params.FechaDesde.Date AndAlso record.DateTime.Date <= params.FechaHasta.Date) Then
    '                Me.Invoke(Sub()
    '                              MarcacionesLogs1.RegistrarMarcacion(record)
    '                          End Sub)
    '                Continue For
    '            End If
    '            Me.Invoke(Sub()
    '                          MarcacionesLogs1.RegistrarMarcacion(record)
    '                      End Sub)
    '        Next

    '    End If
    '    _device.Disconnect()

    'End Sub



    Public Function CargarDispositivosBBDD() As List(Of DispositivoModel)

        Dim Local As New List(Of DispositivoModel) From {
            New DispositivoModel() With {
                .DireccionIp = "192.168.0.201",
                .Puerto = 4370,
                .ClaveAdmin = "",
                .Descripcion = "Reloj de prueba",
                .Estado = 0,
                .FechaCreacion = Nothing,
                .IdDispositivo = 1
            },
             New DispositivoModel() With {
                .DireccionIp = "127.0.0.1",
                .Puerto = 12345,
                .ClaveAdmin = "",
                .Descripcion = "Reloj de prueba local",
                .Estado = 0,
                .FechaCreacion = Nothing,
                .IdDispositivo = 2
            },
              New DispositivoModel() With {
                .DireccionIp = "192.168.0.202",
                .Puerto = 4370,
                .ClaveAdmin = "",
                .Descripcion = "Reloj de fallo",
                .Estado = 0,
                .FechaCreacion = Nothing,
                .IdDispositivo = 3
            }
        }

        Return Local
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
                estado = _device.Connect(dispositivo)
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
                  End Sub)
        Me.Invoke(Sub()
                      MessageBox.Show("Tarea finalizada", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                  End Sub)
    End Sub
End Class