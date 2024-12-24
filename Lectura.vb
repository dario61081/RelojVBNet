Imports System.ComponentModel
Imports System.IO
Imports RelojVBNET.Models
Imports RelojVBNET.SBO
Imports SAPbobsCOM
Imports RelojVBNET.ModelUtils
Imports RelojVBNET.RepositorioSAP




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



    Private Sub RelojesList1_LeerDispostivos(Lista As List(Of DispositivoModel), Parametros As LecturaParametros) Handles RelojesList1.LeerDispostivos

        'validar la conexion
        'Parametros.SapUsuario 
        'Parametros.SapPassword
        'If Not valido Then
        '    Return
        'End If


        'iniciar la lectura si el hilo esta liberado
        If Not BackgroundWorker1.IsBusy Then
            MarcacionesLogs1.Clear()

            ResetImportacionProgress()
            Dim worker_params As New WorkerParams() With {
                .Dispositivos = Lista,
                .Parametros = Parametros,
                .Eventos = New List(Of EventoDispositivoModel),
                .Marcaciones = New List(Of AttendanceRecord)
                }

            BackgroundWorker1.RunWorkerAsync(worker_params)

        End If







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

        Dim ocompany As Company = RepositorioSAP.GetInstance(New LocalServerParams())
        Dim Lista As List(Of DispositivoModel) = New List(Of DispositivoModel)

        If ocompany.Connect() > 0 Then
            Throw New Exception("No se pudo establecer conexion con la base de datos")
        End If

        Try
            Dim recordset As Recordset = CType(ocompany.GetBusinessObject(BoObjectTypes.BoRecordset), Recordset)
            Dim query = "select * from ""@RH_RELOJES_DISP"""
            recordset.DoQuery(query)

            While Not recordset.EoF

                Dim row As New DispositivoModel With {
                    .IdDispositivo = recordset.Fields.Item("U_ID_DISP").Value,
                    .Descripcion = recordset.Fields.Item("U_DESCRIPCION").Value,
                    .Puerto = recordset.Fields.Item("U_PUERTO").Value,
                    .ClaveAdmin = recordset.Fields.Item("U_CLAVE_ADMIN").Value,
                    .Estado = recordset.Fields.Item("U_ESTADO").Value,
                    .FechaCreacion = recordset.Fields.Item("U_FECHA_CREACION").Value
                }
                Lista.Add(row)


            End While


        Catch ex As Exception

        End Try







        ' version local
        'Dim ConfigFilename As String = Path.Combine(GetCacheDirectory("configuraciones"), "dispositivos.json")
        'Dim ArbolDispositivos As List(Of DispositivoModel) = ObjectReaderWriter(Of DispositivoModel).LoadFromJson(ConfigFilename)

        'If ArbolDispositivos Is Nothing Then
        '    Log("No se encontraron dispositivos en la base de datos, cargando datos locales")
        '    ArbolDispositivos = New List(Of DispositivoModel)
        'End If

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
        'leer relojes
        Dim worker As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)
        Dim _device As New ZKBiometricDevice()
        Dim estado As Boolean

        'parametros de la tarea
        Dim parametros As WorkerParams = CType(e.Argument, WorkerParams)
        'lista de dispositivos
        Dim dispositivos As List(Of DispositivoModel) = parametros.Dispositivos
        'lista de eventos
        Dim Eventos As List(Of EventoDispositivoModel) = parametros.Eventos

        Dim RegistrarLog As Action(Of String, DispositivoModel, TipoDeEvento) = Sub(message As String, dispositivo As DispositivoModel, tipodeevento As TipoDeEvento)
                                                                                    Eventos.Add(New EventoDispositivoModel() With {
                                                                      .FechaEvento = DateTime.Now,
                                                                .Descripcion = message,
                                                                .IdEvento = 0,
                                                                .TipoEvento = CInt(tipodeevento),
                                                                .TipoDeEvento = tipodeevento,
                                                                .IdDispositivo = dispositivo.IdDispositivo})
                                                                                End Sub
        Dim current As Integer = 0
        Dim progreso As Integer = 0

        For Each dispositivo As DispositivoModel In dispositivos
            Try
                'calcular el progreso del recorrido
                current += 1

                RegistrarLog($"accediendo a {dispositivo.Descripcion }", dispositivo, TipoDeEvento.Informacion)

                estado = _device.Connect(dispositivo)
                If Not estado Then
                    RegistrarLog($"No se pudo conectar al reloj {dispositivo.Descripcion} ({dispositivo.DireccionIp}:{dispositivo.Puerto})", dispositivo, TipoDeEvento.IsError)
                    Continue For

                End If
                'obtener marcaciones
                Dim lista As List(Of AttendanceRecord) = New List(Of AttendanceRecord)
                'backup marcaciones
                lista = _device.GetAttendanceLogs()
                'si no hay registros
                If lista Is Nothing OrElse lista.Count = 0 Then
                    RegistrarLog($"No se encontraron registros en el reloj {dispositivo.Descripcion}", dispositivo, TipoDeEvento.IsError)
                Else
                    RegistrarLog($"Se recuperaron {lista.Count} registros del reloj {dispositivo.Descripcion}", dispositivo, TipoDeEvento.Informacion)

                    'si el modo esta en filtrar por fecha
                    If parametros.Parametros.Modo = 1 Then
                        'filtrar por fecha 
                        lista = lista.Where(Function(x) x.DateTime.Date >= parametros.Parametros.FechaDesde.Date And x.DateTime.Date <= parametros.Parametros.FechaHasta.Date).ToList
                    End If

                    'concatenar marcaciones
                    parametros.Marcaciones.AddRange(lista)
                End If

                progreso = CInt((current / dispositivos.Count) * 100)
                worker.ReportProgress(progreso)

            Catch ex As Exception
                RegistrarLog($"Error al procesar los datos del reloj {dispositivo.Descripcion}: {ex.Message}", dispositivo, TipoDeEvento.IsError)
            Finally
                If estado Then
                    _device.Disconnect()
                    RegistrarLog($"Desconectado del reloj {dispositivo.Descripcion}", dispositivo, TipoDeEvento.Informacion)
                End If
            End Try
        Next

        'devolver el parametro actualizado
        e.Result = parametros
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

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'actualizar progreso
        'Debug.WriteLine($"progreso {e.ProgressPercentage }")
        progressbar2.Value = e.ProgressPercentage
        lblmensaje.Text = $"Procesando marcaciones, aguarde. ({e.ProgressPercentage}%)"

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Dim parametros As WorkerParams = CType(e.Result, WorkerParams)

        'anunciar finalizado
        'progressbar2.Value = 100
        progressbar2.Visible = False
        progressbar1.Visible = False

        'poblar la lista de marcaciones
        If (parametros IsNot Nothing And parametros.Marcaciones IsNot Nothing) Then
            MarcacionesLogs1.RegistrasMarcaciones(parametros.Marcaciones)
        End If
        'poblas los eventos ocurridos
        EventsLogs1.RegistrarEventos(parametros.Eventos)
        lblmensaje.Visible = False
        MarcacionesLogs1.UpdateListView()
        EventsLogs1.UpdateListView()
        MessageBox.Show("Tarea concluida", "Tareas", MessageBoxButtons.OK)

        'enviar listado a base de datos
        EnviarABaseDatos(parametros)


    End Sub

    Private Sub ResetImportacionProgress()
        lblmensaje.Visible = True

        progressbar2.Visible = True
        progressbar1.Visible = True
        progressbar2.Value = 0
    End Sub

    Public Sub EnviarABaseDatos(Parametros As WorkerParams)

        If Not BackgroundWorker2.IsBusy Then

            'iniciar migracion
            lblmensaje.Visible = True
            lblmensaje.Text = "Exportando datos (0%)"
            progressbar2.Visible = True

            BackgroundWorker2.RunWorkerAsync(Parametros) 'lanzar el thread
        End If

    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker2.DoWork
        Dim parametros As WorkerParams = CType(e.Argument, WorkerParams)
        Dim lista As List(Of AttendanceRecord) = parametros.Marcaciones
        Dim worker As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)
        Dim count = 0
        Dim progress = 0
        Dim cantidad = lista.Count

        'conectar a la base

        Dim SapUser As String = parametros.Parametros.SapUsuario
        Dim SapPass As String = parametros.Parametros.SapPassword
        Dim oCompany As Company = Nothing

        'Debug.WriteLine($"SAPUser: {SapUser} SAPPasswrd {SapPass} ")
        Try
            ' Configuración de conexión
            oCompany = New Company() With {
            .Server = "192.168.2.115:30015",
            .CompanyDB = "SELTZ29102024",
            .UserName = "Reloj",
            .Password = "123456",
            .LicenseServer = "192.168.2.115:40000",
            .DbServerType = BoDataServerTypes.dst_HANADB,
            .language = BoSuppLangs.ln_Spanish_La,
            .DbUserName = "SYSTEM",
            .DbPassword = "Seltz2024*",
            .UseTrusted = False
            }

            ' Conectar
            If oCompany.Connect() <> 0 Then
                e.Cancel = True
                Throw New Exception("No se pudo establecer conexion con la base de datos")
            End If

            oCompany.StartTransaction()

            'poblar datos
            Dim enviados = 0
            If oCompany IsNot Nothing AndAlso oCompany.Connected Then
                Dim servicio As CompanyService = oCompany.GetCompanyService()
                Dim general As GeneralService = servicio.GetGeneralService("RH_MARCACIONES")

                'insertar los registros de marcaciones a @RH_MARCACIONES
                Dim Data As GeneralData
                Dim c As Integer = 0
                count = lista.Count
                For Each row As AttendanceRecord In lista
                    c += 1
                    data = general.GetDataInterface(GeneralServiceDataInterfaces.gsGeneralData)
                    Data.SetProperty("U_LEGAJO", row.EnrollNumber)
                    Data.SetProperty("U_TIPO_EVENTO", row.InOutMode)
                    Data.SetProperty("U_FECHA", row.DateTime)
                    Data.SetProperty("U_ID_DISP", row.DeviceNumber)
                    Data.SetProperty("U_WORK_MODE", row.WorkMode)

                    Data.SetProperty("U_HORA", row.DateTime)
                    Data.SetProperty("U_ID", c)
                    general.Add(data)
                    'Debug.WriteLine($"{row.DateTime },{row.DeviceNumber }, {row.EnrollNumber }, {row.InOutMode }, {row.VerifyMode },{row.WorkMode}")

                    progress = CInt((c / count) * 100)
                    worker.ReportProgress(progress)

                Next

            End If

            oCompany.EndTransaction(BoWfTransOpt.wf_Commit)
            'Debug.WriteLine($"Finalizado, exportado {lista.Count } registros")






        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        Finally
            ' cerrar conexion
            If oCompany IsNot Nothing AndAlso oCompany.Connected Then
                'Debug.WriteLine("Cerrando conexion")
                oCompany.Disconnect()
            End If

        End Try












    End Sub

    Private Sub BackgroundWorker2_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker2.ProgressChanged
        progressbar2.Value = e.ProgressPercentage
        lblmensaje.Text = $"Exportando datos ({e.ProgressPercentage}%)"
    End Sub

    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted
        'If e.Cancelled Then
        '    ' Mostrar el mensaje de Result al cancelar
        '    MessageBox.Show("Operación cancelada. ")

        'ElseIf e.Error IsNot Nothing Then
        '    MessageBox.Show("Error durante la operación: " & e.Error.Message)

        'End If

        Log("Exportación concluida")
        MessageBox.Show("Exportacion finalizada", "Exportar", MessageBoxButtons.OK)
        progressbar2.Visible = False
        lblmensaje.Visible = False
    End Sub
End Class