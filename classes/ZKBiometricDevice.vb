

Imports System.IO
Imports RelojVBNET.Models
Imports zkemkeeper

Public Class ZKBiometricDevice
    Private WithEvents Zkem As CZKEM

    Private IsConnected As Boolean
    Private DeviceNumber As Integer
    Public SerialNumber As String
    Public Password As Long

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
        If Not String.IsNullOrEmpty(Dispositivo.ClaveAdmin) Then
            Password = Dispositivo.ClaveAdmin

            Try
                Dim status = Zkem.SetCommPassword(Password)
                LogError($"Set communication password: {status}")
            Catch ex As Exception
                LogError($"Error setting communication password: {ex.Message}")
                Return False
            End Try
        End If


        If Zkem.Connect_Net(Dispositivo.DireccionIp, Dispositivo.Puerto) Then
            Zkem.GetSerialNumber(DeviceNumber, SerialNumber)

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

        Try
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
                Else
                    LogError("Failed to read general log data from the device.")
                End If
            Else
                LogError("Device is not connected.")
            End If
        Catch ex As Exception
            LogError($"Error retrieving attendance logs: {ex.Message}")
        End Try

        Return records
    End Function

    ' Enhanced Asynchronous Version
    Public Async Function GetAttendanceLogsAsync() As Task(Of List(Of AttendanceRecord))
        Return Await Task.Run(Function() GetAttendanceLogs())
    End Function

    ' Helper Method for Logging
    Private Sub LogError(message As String)
        Try
            Dim logFilePath As String = "AttendanceLogErrors.txt"
            File.AppendAllText(logFilePath, $"{DateTime.Now}: {message}{Environment.NewLine}")
        Catch
            ' If logging fails, suppress errors to avoid cascading failures.
        End Try
    End Sub

    ''' <summary>
    ''' Comprueba si el dispositivo está conectado.
    ''' </summary>
    ''' <returns>True si está conectado, False en caso contrario.</returns>
    Public Function Connected() As Boolean
        Return IsConnected
    End Function


    'clear logs
    Public Function ClearLogs() As Boolean

        Return Zkem.ClearGLog(DeviceNumber)

    End Function






End Class




