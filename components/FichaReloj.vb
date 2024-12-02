Imports RelojVBNET.Models

Public Class FichaReloj

	Public dispositivo As DispositivoModel

	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		dispositivo = New DispositivoModel()
	End Sub

	Public Sub RefreshData()

		If dispositivo Is Nothing Then
			Return

		End If

		edtDireccionIp.Text = dispositivo.DireccionIp
		edtNombre.Text = dispositivo.Descripcion





	End Sub




End Class
