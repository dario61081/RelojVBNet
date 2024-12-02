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
		lbmessages.Items.Add($"{DateTime.Now } - {message}")
		lbmessages.TopIndex = lbmessages.Items.Count - 1
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
			},
			New DispositivoModel With {
				.Descripcion = "Cocina 1",
				.DireccionIp = "192.168.0.202"
			},
			New DispositivoModel With {
				.Descripcion = "Cocina 2",
				.DireccionIp = "192.168.0.203"
			},
			 New DispositivoModel With {
				.Descripcion = "Cocina 3",
				.DireccionIp = "192.168.0.204"
			},
			 New DispositivoModel With {
				.Descripcion = "Cocina 5",
				.DireccionIp = "192.168.0.205"
			},
			 New DispositivoModel With {
				.Descripcion = "Cocina 6",
				.DireccionIp = "192.168.0.206"
			},
			 New DispositivoModel With {
				.Descripcion = "Cocina 7",
				.DireccionIp = "192.168.0.207"
			},
			 New DispositivoModel With {
				.Descripcion = "Cocina 8",
				.DireccionIp = "192.168.0.208"
			},
			 New DispositivoModel With {
				.Descripcion = "Cocina 9",
				.DireccionIp = "192.168.0.209"
			},
			 New DispositivoModel With {
				.Descripcion = "Cocina 10",
				.DireccionIp = "192.168.0.210"
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
		Dim lista_registro As List(Of AttendanceRecord) = Nothing
		Dim thread As New Thread(Sub() lista_registro = LeerLogs())



		log("(espere) leyendo datos del reloj...", True)
		thread.Start()
		thread.Join()

		For Each row In lista_registro
			log($"{row.DateTime } {row.EnrollNumber } {row.InOutMode }")
		Next

		log("(OK) Lectura finalizada", True)




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

	Private Sub ActualizarListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarListaToolStripMenuItem.Click

		Relojes.RefreshList()
		log("(ok) Registro de relojes actualizado", True)
	End Sub

	Private Sub Relojes_OnSelectedItem(record As DispositivoModel) Handles Relojes.OnSelectedItem

		If record Is Nothing Then
			log("No hay seleccionados")
			Return
		End If

		log($"(selected) {record.Descripcion }")


	End Sub
End Class
