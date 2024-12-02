Imports System.IO
Imports System.Threading
Imports RelojVBNET.Models


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


	Public Sub log(message As String, Optional allowMessage As Boolean = False)

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

	Private Sub Button1_Click(sender As Object, e As EventArgs)
		Conectar(txtIpAddress.Text)
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs)





	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs)
		If Device Is Nothing Then
			log("(fail) dispositivo no ha sido conectado", True)
			Return
		End If

		If Device.Connected Then
			Device.Disconnect()
			log("(ok) dispositivo desconectado", True)
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
		log("(ok) Registro de relojes actualizado", True)
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

	Private Sub Relojes_OnReadLogs(record As DispositivoModel) Handles Relojes.OnReadLogs


		Dim lista_registro As List(Of AttendanceRecord) = Nothing
		Dim thread As New Thread(Sub() lista_registro = LeerLogs())
		' actualizar el indice
		TabControl1.SelectedTab = TabPage2

		log("(espere) leyendo datos del reloj...", True)
		thread.Start()
		thread.Join()

		lvLog.Items.Clear()
		For Each row In lista_registro
			log($"{row.DateTime } {row.EnrollNumber } {row.InOutMode }")

			Dim nitem As New ListViewItem With {
				.Text = row.DateTime
			}
			nitem.SubItems.Add(row.VerifyMode)
			nitem.SubItems.Add(row.InOutMode)
			nitem.SubItems.Add(row.EnrollNumber)

			lvLog.Items.Add(nitem)

		Next


		Dim timestamp As DateTime = DateTime.UtcNow
		Dim tag As String = timestamp.ToString("yyyy-mm-dd hhmmss")
		Dim dump_directory = Path.Combine(Directory.GetCurrentDirectory, "dumps")
		If Not Directory.Exists(dump_directory) Then
			Directory.CreateDirectory(dump_directory)
		End If

		Dim save_filename As String = Path.Combine(dump_directory, $"db_{record.DireccionIp }_{tag}.json")

		ObjectReaderWriter(Of AttendanceRecord).SaveToJson(lista_registro, save_filename)

		log("(OK) Lectura finalizada", True)
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
End Class
