Imports RelojVBNET.Models

Public Class FichaReloj

	Public dispositivo As DispositivoModel

	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		dispositivo = New DispositivoModel()
	End Sub

	Private Sub FichaReloj_Load(sender As Object, e As EventArgs) Handles MyBase.Load



	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub
End Class
