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

        For Each row As DispositivoModel In Lista
            LeerAttendances(row, Parametros)
        Next

        Log("Lectura finalizada")


    End Sub


    Private Sub LeerAttendances(dispositivo As DispositivoModel, params As LecturaParametros)
        Log($"Leyendo datos del reloj {dispositivo.Descripcion }")
        Dim _device As New ZKBiometricDevice()
        _device.Connect(dispositivo.DireccionIp, dispositivo.Puerto)
        Dim lista = _device.GetAttendanceLogs()


        For Each record As AttendanceRecord In lista
            MarcacionesLogs1.RegistrarMarcacion(record)
        Next


        _device.Disconnect()
        Log("Finalizado lectura de datos")
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

End Class