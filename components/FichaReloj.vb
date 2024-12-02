Imports RelojVBNET.Models

Public Class FichaReloj

	Public dispositivo As DispositivoModel

	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().

	End Sub



	Public Sub MostrarFicha(data As DispositivoModel)

		If data Is Nothing Then
			Return
		End If

		edtDireccionIp.Text = data.DireccionIp
		edtNombre.Text = data.Descripcion
		edtTerminalNumber.Text = data.IdDispositivo

	End Sub




End Class
