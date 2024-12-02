

Imports zkemkeeper

Public Class ZKBiometricDevice
    Private WithEvents zkem As CZKEM

    Public Event OnFinger()
    Public Event OnKeyPress()


    Private isConnected As Boolean
    Private deviceNumber As Integer

    Public Sub New()
        zkem = New CZKEM()
        isConnected = False
        deviceNumber = 1
    End Sub



    ''' <summary>
    ''' Conecta al dispositivo biométrico.
    ''' </summary>
    ''' <param name="ip">Dirección IP del dispositivo.</param>
    ''' <param name="port">Puerto del dispositivo (por defecto 4370).</param>
    ''' <returns>True si la conexión es exitosa, False en caso contrario.</returns>
    Public Function Connect(ip As String, port As Integer) As Boolean

        If zkem.Connect_Net(ip, port) Then
            isConnected = True
            ' Establecer la máquina en modo normal
            zkem.EnableDevice(deviceNumber, True)

            Return True
        Else
            isConnected = False
            Return False
        End If
    End Function

    ''' <summary>
    ''' Desconecta el dispositivo biométrico.
    ''' </summary>
    Public Sub Disconnect()
        If isConnected Then
            ' zkem.EnableDevice(deviceNumber, True)
            zkem.Disconnect()
            isConnected = False
        End If
    End Sub

    ''' <summary>
    ''' Obtiene los registros de asistencia del dispositivo.
    ''' </summary>
    ''' <returns>Lista de registros de asistencia.</returns>
    Public Function GetAttendanceLogs() As List(Of AttendanceRecord)
        Dim records As New List(Of AttendanceRecord)()

        If isConnected Then
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

            If zkem.ReadGeneralLogData(deviceNumber) Then
                While zkem.SSR_GetGeneralLogData(deviceNumber, dwEnrollNumber, dwVerifyMode, dwInOutMode, dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond, dwWorkMode)
                    Dim record As New AttendanceRecord With {
                        .EnrollNumber = dwEnrollNumber,
                        .VerifyMode = dwVerifyMode,
                        .InOutMode = dwInOutMode,
                        .DateTime = New DateTime(dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond)
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
        Return isConnected
    End Function


    Public Function ClearLogs() As Boolean
        If Not isConnected Then
            Return False
        End If

        Dim ultimo_estado = zkem.ClearGLog(dwMachineNumber:=deviceNumber)
        Return ultimo_estado


    End Function

    Private Sub zkem_OnAttTransaction(EnrollNumber As Integer, IsInValid As Integer, AttState As Integer, VerifyMethod As Integer, Year As Integer, Month As Integer, Day As Integer, Hour As Integer, Minute As Integer, Second As Integer) Handles zkem.OnAttTransaction
        RaiseEvent OnFinger()
    End Sub

    Private Sub zkem_OnGeneralEvent(DataStr As String) Handles zkem.OnGeneralEvent
        RaiseEvent OnFinger()
    End Sub

    Private Sub zkem_OnKeyPress(Key As Integer) Handles zkem.OnKeyPress
        RaiseEvent OnKeyPress()
    End Sub
End Class



''' <summary>
''' Representa un registro de asistencia.
''' </summary>
Public Class AttendanceRecord
    Public Property EnrollNumber As String
    Public Property VerifyMode As Integer
    Public Property InOutMode As Integer
    Public Property DateTime As DateTime
End Class

