Imports NLog
Imports RelojVBNET.Models
Imports zkemkeeper

Public Class ConectorReloj
    Private Shared logger As Logger = LogManager.GetCurrentClassLogger()

    Public Shared Async Function GetAttendances(Dispositivo As DispositivoModel, Params As LecturaParametros) As Task(Of Result(Of List(Of AttendanceRecord)))
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
        Dim records As New List(Of AttendanceRecord)()
        Const ErrorInvalidParameterParam = "Parametros insuficientes"
        Const ErrorInvalidConnection = "No se pudo establecer conexion con el reloj"

        Return Task.Run(
            Function()



                If Params Is Nothing Then
                    logger.Error(ErrorInvalidParameterParam)
                    Return Result(Of List(Of AttendanceRecord)).Failure(ErrorInvalidParameterParam)
                End If

                Dim reloj As CZKEM = Nothing
                logger.Debug($"Iniciando lectura para {Dispositivo.Descripcion}({Dispositivo.DireccionIp })")
                Try

                    reloj = New CZKEM()


                    'clave administrador
                    If Not String.IsNullOrEmpty(Dispositivo.ClaveAdmin) Then
                        logger.Info("Estableciendo clave de administrador OK")
                        reloj.SetCommPassword(Dispositivo.ClaveAdmin)
                    End If

                    If Not reloj.Connect_Net(Dispositivo.DireccionIp, Dispositivo.Puerto) Then
                        logger.Error(ErrorInvalidConnection)
                        Throw New Exception(ErrorInvalidConnection)

                    End If

                    If reloj.ReadGeneralLogData(Dispositivo.IdDispositivo) Then
                        While reloj.SSR_GetGeneralLogData(Dispositivo.IdDispositivo, dwEnrollNumber, dwVerifyMode, dwInOutMode, dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond, dwWorkMode)
                            Dim record As New AttendanceRecord With {
                        .DeviceNumber = Dispositivo.IdDispositivo,
                        .EnrollNumber = dwEnrollNumber,
                        .VerifyMode = dwVerifyMode,
                        .InOutMode = dwInOutMode,
                        .DateTime = New DateTime(dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond),
                        .WorkMode = dwWorkMode
                    }
                            records.Add(record)
                        End While
                    End If

                    logger.Info($"importado {records.Count } registro(s)")



                Catch Ex As Exception
                    logger.Error($"Ha ocurrido un error la lectura {Ex.Message }")
                    Return Result(Of List(Of AttendanceRecord)).Failure(Ex.Message)

                Finally
                    logger.Info($"Desconectando con {Dispositivo.Descripcion}({Dispositivo.DireccionIp})")
                    If reloj IsNot Nothing Then
                        reloj.Disconnect()
                    End If
                    reloj = Nothing

                End Try
                Return Result(Of List(Of AttendanceRecord)).Success(records)
            End Function).Result

    End Function

End Class
