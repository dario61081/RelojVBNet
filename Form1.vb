Imports System.Globalization
Imports System.IO
Imports System.Threading
Imports RelojVBNET.Models

Public Enum EventoTipo
    INFO = 0
    SUCCESS = 10
    WARN = 20
    DANGER = 30
End Enum

Public Class Form1

    Public WithEvents Device As ZKBiometricDevice

    Private Sub Conectar(ipaddress As String)



        Me.Cursor = Cursors.WaitCursor

        If Device Is Nothing Then
            log("Iniciando dispositivo", True)
            Device = New ZKBiometricDevice()
        End If

        If Device.Connected Then
            log("(!) ya esta conectado", True)
            Return
        End If


        Dim estado = Device.Connect(ipaddress, 4370)
        If estado Then
            log("(ok) dispositivo conectado", True)
        ElseIf Not estado Then
            log("(fail) dispositivo no encontrado", True)
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Function LeerLogs() As List(Of AttendanceRecord)



        If Device Is Nothing OrElse Not Device.Connected Then

            Return Nothing
        End If

        Dim listado = Device.GetAttendanceLogs()

        Return listado




    End Function
    Private Sub Desconectar()

        If Device Is Nothing Then
            log("(!) dispositivo no iniciado", True)
            Return
        End If

        If Device.Connected Then
            log("(OK) dispositivo desconectado", True)
            Device.Disconnect()
        End If

        log("(system) liberado asignacion de memoria", True)
        Device = Nothing

    End Sub


    Public Sub log(message As String, Optional Level As EventoTipo = EventoTipo.INFO, Optional allowMessage As Boolean = False)

        Dim item As New ListViewItem With {
            .Text = $"{DateTime.Now().GetDateTimeFormats()(0)}"
        }
        item.SubItems.Add(message)
        lvEventos.Items.Add(item)

        If lvEventos.Items.Count > 0 Then
            lvEventos.Items(lvEventos.Items.Count - 1).EnsureVisible()
        End If

        If allowMessage Then
            With NotifyIcon1
                .BalloonTipTitle = "Mensaje"
                .BalloonTipText = message
                .BalloonTipIcon = ToolTipIcon.Info ' Opciones: Info, Warning, Error, None
                .ShowBalloonTip(5000)
            End With
        End If


    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NotifyIcon1.Visible = True
        log("Iniciando", True)

        ' objectos de prueba
        Dim lista_dispositivos = New List(Of DispositivoModel) From {
            New DispositivoModel With {
                .Descripcion = "Local",
                .DireccionIp = "192.168.0.201"
            }
        }

        ' lista de relojes
        For Each row As DispositivoModel In lista_dispositivos
            Relojes.AddItem(row)
        Next

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If Device Is Nothing Then
            log("(fail) dispositivo no ha sido conectado", allowMessage:=True)
            Return
        End If

        If Device.Connected Then
            Device.Disconnect()
            log("(ok) dispositivo desconectado", allowMessage:=True)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        Dim Uestado = Device.ClearLogs
        If Uestado Then
            log("(OK) logs limpiados")
        ElseIf Not Uestado Then
            log("(Fail) no se ha ejecutado la limpieza de logs")
        End If

    End Sub

    Private Sub Device_OnFinger() Handles Device.OnFinger
        log("Dedo")
    End Sub

    Private Sub Device_OnKeyPress() Handles Device.OnKeyPress
        log("Teclado")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' Device.Disconnect()


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ActualizarListaToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Relojes.RefreshList()
        log("(ok) Registro de relojes actualizado", allowMessage:=True)
    End Sub

    Private Sub Relojes_OnSelectedItem(record As DispositivoModel) Handles Relojes.OnSelectedItem

        If record Is Nothing Then
            log("No hay seleccionados")
            Return
        End If

        log($"(selected) {record.Descripcion }")

        FichaReloj1.MostrarFicha(record)


    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvEventos.SelectedIndexChanged

    End Sub

    Private Async Sub Relojes_OnReadLogs(record As DispositivoModel, Mode As Integer, DateFrom As Date, DateTo As Date) Handles Relojes.OnReadLogs
        Dim lista_registro As List(Of AttendanceRecord) = Nothing

        TabControl1.SelectedTab = TabPage2
        StatusPB.Visible = True
        log($"(espere) leyendo datos del reloj {Mode};{DateFrom.Date};{DateTo.Date }", allowMessage:=True)

        ' Leer los registros en segundo plano
        Await Task.Run(Sub() lista_registro = LeerLogs())

        lvLog.Items.Clear()
        lvLog.BeginUpdate()

        ' Procesar registros
        For Each row In lista_registro

            If Mode = 1 AndAlso (row.DateTime.Date < DateFrom.Date OrElse row.DateTime.Date > DateTo.Date) Then Continue For

            Dim nitem As New ListViewItem With {.Text = row.DateTime}
            nitem.SubItems.Add(row.EnrollNumber)
            nitem.SubItems.Add(row.InOutMode)
            nitem.SubItems.Add(row.VerifyMode)
            nitem.SubItems.Add(row.WorkMode)
            lvLog.Items.Add(nitem)
        Next

        lvLog.EndUpdate()
        exportar_logs(lista_registro, $"db_{record.DireccionIp}.json")

        StatusPB.Visible = False
        Cursor = Cursors.Default
        log("(OK) Lectura finalizada", allowMessage:=True)
    End Sub

    Private Async Sub exportar_logs(lista_registro As List(Of AttendanceRecord), filename As String)

        ' Exportar los datos
        Dim base_filename As String = Utiles.GetTempFilename()
        Dim dumps_directory = Utiles.GetDirectory("dumps")
        Dim save_filename As String = Path.Combine(dumps_directory, filename)

        Await Task.Run(Sub() ObjectReaderWriter(Of AttendanceRecord).SaveToJson(lista_registro, save_filename))


    End Sub


    Private Sub Relojes_OnDisconnecting(record As DispositivoModel) Handles Relojes.OnDisconnecting
        log($"Desconectar reloj {record.DireccionIp }")
        Desconectar()
    End Sub

    Private Sub Relojes_OnClearlogs(record As DispositivoModel) Handles Relojes.OnClearlogs
        log($"Limpiando todos los logs de {record.DireccionIp }")

        lvLog.Items.Clear()
    End Sub

    Private Sub Relojes_OnConnecting(record As DispositivoModel) Handles Relojes.OnConnecting
        log($"iniciar Conexion a {record.DireccionIp }")
        Conectar(record.DireccionIp)
        Relojes.ListaBloqueada = True

    End Sub



    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Close()

    End Sub
End Class
