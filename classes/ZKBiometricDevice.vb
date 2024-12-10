

Imports RelojVBNET.Models
Imports zkemkeeper

Public Class ZKBiometricDevice
    Private WithEvents Zkem As CZKEM

    Private IsConnected As Boolean
    Private DeviceNumber As Integer

    Public Sub New()
        Zkem = New CZKEM()
        IsConnected = False
        DeviceNumber = 1
    End Sub



    ''' <summary>
    ''' Conecta al dispositivo biométrico.
    ''' </summary>
    ''' <param name="ip">Dirección IP del dispositivo.</param>
    ''' <param name="port">Puerto del dispositivo (por defecto 4370).</param>
    ''' <returns>True si la conexión es exitosa, False en caso contrario.</returns>
    Public Function Connect(Dispositivo As DispositivoModel) As Boolean
        DeviceNumber = Dispositivo.IdDispositivo
        If Zkem.Connect_Net(Dispositivo.DireccionIp, Dispositivo.Puerto) Then
            IsConnected = True
            ' Establecer la máquina en modo normal
            Zkem.EnableDevice(DeviceNumber, True)

            Return True
        Else
            IsConnected = False
            Return False
        End If
    End Function

    ''' <summary>
    ''' Desconecta el dispositivo biométrico.
    ''' </summary>
    Public Sub Disconnect()
        If IsConnected Then
            ' zkem.EnableDevice(deviceNumber, True)
            Zkem.Disconnect()
            IsConnected = False
        End If
    End Sub

    ''' <summary>
    ''' Obtiene los registros de asistencia del dispositivo.
    ''' </summary>
    ''' <returns>Lista de registros de asistencia.</returns>
    Public Function GetAttendanceLogs() As List(Of AttendanceRecord)
        Dim records As New List(Of AttendanceRecord)()

        If IsConnected Then
            Dim dwEnrollNumber As String = ""
            Dim dwVerifyMode As Integer
            Dim dwInOutMode As Integer
            Dim dwYear As Integer
            Dim dwMonth As Integer
            Dim dwDay As Integer
            Dim dwHour As Integer
            Dim dwMinute As Integer
            Dim dwSecond As Integer
            Dim dwWorkMode As Integer

            If Zkem.ReadGeneralLogData(DeviceNumber) Then
                While Zkem.SSR_GetGeneralLogData(DeviceNumber, dwEnrollNumber, dwVerifyMode, dwInOutMode, dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond, dwWorkMode)
                    Dim record As New AttendanceRecord With {
                        .DeviceNumber = DeviceNumber,
                        .EnrollNumber = dwEnrollNumber,
                        .VerifyMode = dwVerifyMode,
                        .InOutMode = dwInOutMode,
                        .DateTime = New DateTime(dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond),
                        .WorkMode = dwWorkMode
                    }
                    records.Add(record)
                End While
            End If
        End If

        Return records
    End Function

    ''' <summary>
    ''' Comprueba si el dispositivo está conectado.
    ''' </summary>
    ''' <returns>True si está conectado, False en caso contrario.</returns>
    Public Function Connected() As Boolean
        Return IsConnected
    End Function





End Class




