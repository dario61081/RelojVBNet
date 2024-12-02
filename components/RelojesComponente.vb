Imports RelojVBNET.Models

Public Class RelojesComponente
	Public registro As List(Of DispositivoModel)

	' si se selecciona el elemento
	Public Event OnSelectedItem(record As DispositivoModel)

	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		registro = New List(Of DispositivoModel)
	End Sub

	Public Sub AddItem(record As DispositivoModel)
		registro.Add(record)
		RefreshList()

	End Sub

	Public Sub RefreshList()
		' listar los datos dentro 
		lvdispositivos.Items.Clear()
		For Each row As DispositivoModel In registro
			Dim item As New ListViewItem With {
				.ImageIndex = 0,
				.StateImageIndex = 0,
				.Text = row.DireccionIp,
				.Tag = row
			}
			item.SubItems.Add(row.Descripcion)
			lvdispositivos.Items.Add(item)
		Next



	End Sub

	Private Sub lvdispositivos_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lvdispositivos.ItemSelectionChanged
		If e.IsSelected Then
			Dim seleccionado As DispositivoModel = DirectCast(e.Item.Tag, DispositivoModel)

			RaiseEvent OnSelectedItem(seleccionado)

		End If

	End Sub
End Class
