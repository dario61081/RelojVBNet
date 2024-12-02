Imports RelojVBNET.Models

Public Class RelojesComponente
	Public registro As List(Of DispositivoModel)
	Private _lista_bloqueada As Boolean
	Public Property ListaBloqueada As Boolean
		Get
			Return _lista_bloqueada
		End Get
		Set(value As Boolean)
			_lista_bloqueada = value
			lvdispositivos.Enabled = _lista_bloqueada
		End Set
	End Property

	' si se selecciona el elemento
	Public Event OnSelectedItem(record As DispositivoModel)
	Public Event OnConnecting(record As DispositivoModel)
	Public Event OnDisconnecting(record As DispositivoModel)
	Public Event OnReadLogs(record As DispositivoModel)
	Public Event OnClearlogs(record As DispositivoModel)

	Public Sub New()

		' Esta llamada es exigida por el diseñador.
		InitializeComponent()

		' Agregue cualquier inicialización después de la llamada a InitializeComponent().
		registro = New List(Of DispositivoModel)
		lvdispositivos.MultiSelect = False
	End Sub

	Public Sub AddItem(record As DispositivoModel)
		registro.Add(record)
		RefreshList()
	End Sub

	Public Sub RemoveItem(record As DispositivoModel)
		registro.Remove(record)
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

	Private Sub lvdispositivos_Click(sender As Object, e As EventArgs) Handles lvdispositivos.Click






	End Sub

	Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

	End Sub

	Private Sub ConectarRelojToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConectarRelojToolStripMenuItem.Click

		Dim obj = DirectCast(lvdispositivos.SelectedItems(0).Tag, DispositivoModel)

		'enviar el comando para conectar 
		RaiseEvent OnConnecting(obj)

	End Sub

	Private Sub DesconectarRelojToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesconectarRelojToolStripMenuItem.Click
		Dim obj = DirectCast(lvdispositivos.SelectedItems(0).Tag, DispositivoModel)
		RaiseEvent OnDisconnecting(obj)

	End Sub

	Private Sub LeerEventosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeerEventosToolStripMenuItem.Click

		Dim obj = DirectCast(lvdispositivos.SelectedItems(0).Tag, DispositivoModel)
		RaiseEvent OnReadLogs(obj)

	End Sub

	Private Sub BorrarEventosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarEventosToolStripMenuItem.Click
		Dim obj = DirectCast(lvdispositivos.SelectedItems(0).Tag, DispositivoModel)
		RaiseEvent OnClearlogs(obj)

	End Sub
End Class
