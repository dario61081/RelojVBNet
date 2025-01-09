


Imports System.Net.NetworkInformation
Imports System.Threading

Public Class PingThread
    Private ReadOnly ipList As List(Of String)
    Private ReadOnly interval As Integer ' Intervalo en milisegundos
    Private thread As Thread
    Private running As Boolean

    ' Evento para notificar el estado de las IPs
    Public Event PingResult(ip As String, status As Boolean)

    Public Sub New(ipList As List(Of String), interval As Integer)
        Me.ipList = ipList
        Me.interval = interval
        Me.running = False
    End Sub

    ' Inicia el hilo de ping
    Public Sub Start()
        If thread Is Nothing OrElse Not thread.IsAlive Then
            running = True
            thread = New Thread(AddressOf PingLoop)
            thread.IsBackground = True
            thread.Start()
        End If
    End Sub

    ' Detiene el hilo de ping
    Public Sub [Stop]()
        running = False
        If thread IsNot Nothing AndAlso thread.IsAlive Then
            thread.Join()
        End If
    End Sub

    ' Bucle principal del hilo
    Private Sub PingLoop()
        Dim pinger As New Ping()

        While running
            For Each ip In ipList
                Try
                    Dim reply = pinger.Send(ip)
                    Dim status = reply.Status = IPStatus.Success
                    RaiseEvent PingResult(ip, status)
                Catch ex As Exception
                    RaiseEvent PingResult(ip, False)
                End Try
            Next

            Thread.Sleep(interval)
        End While
    End Sub






End Class
