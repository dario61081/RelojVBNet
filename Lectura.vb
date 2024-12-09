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

        'leer relojes de la base de datos 
        Dim relojes As List(Of DispositivoModel) = CargarDispositivosBBDD()
        Log("Cargando relojes de la base de datos")
        For Each row As DispositivoModel In relojes
            Dim _reloj As New Reloj()
            _reloj.Dispositivo = row
            Dispositivos.RegistrarReloj(_reloj)
        Next


        RelojesList1.RegistrarTodo(relojes)
        Log("Listo")
    End Sub

    Private Sub RelojesList1_LeerDispostivos(Lista As List(Of DispositivoModel), Parametros As LecturaParametros) Handles RelojesList1.LeerDispostivos
        MarcacionesLogs1.Clear()
        Log("Iniciando lectura datos, aguarde...")
        For Each row As DispositivoModel In Lista
            LeerAttendances(row, Parametros)
        Next
        Log("Finalizado lectura de datos")

    End Sub


    Private Async Sub LeerAttendances(dispositivo As DispositivoModel, params As LecturaParametros)


        Log($"Leyendo datos del reloj {dispositivo.Descripcion } ({dispositivo.DireccionIp}:{dispositivo.Puerto})")
        Log($"Parametros {params.Modo } - {params.FechaDesde } - {params.FechaHasta }")
        Dim _device As New ZKBiometricDevice()
        Dim estado = _device.Connect(dispositivo.DireccionIp, dispositivo.Puerto)
        'preguntar si esta conectado, si no avisar y volver
        If estado = False Then
            Log($"No se pudo conectar al reloj {dispositivo.Descripcion } ({dispositivo.DireccionIp}:{dispositivo.Puerto})")
            Return
        End If

        Dim lista As List(Of AttendanceRecord)

        Await Task.Run(Sub() lista = _device.GetAttendanceLogs())


        For Each record As AttendanceRecord In lista

            If params.Modo = 1 AndAlso (record.DateTime.Date >= params.FechaDesde.Date AndAlso record.DateTime.Date <= params.FechaHasta.Date) Then
                MarcacionesLogs1.RegistrarMarcacion(record)
                Continue For
            End If

            MarcacionesLogs1.RegistrarMarcacion(record)
        Next


        _device.Disconnect()

    End Sub



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
    Public Sub Log(message As String)
        Debug.WriteLine(message)
        EventsLogs1.RegistrarEvento(message)
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()
    End Sub
End Class