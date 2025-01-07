Imports RelojVBNET.Models

Public Class RelojesList
    Public Property Ocupado As Boolean
        Get
            Return Loading1.Visible
        End Get
        Set(value As Boolean)
            Loading1.Visible = value
        End Set
    End Property
    Public Dispositivos As List(Of DispositivoModel)

    Public Event LeerDispostivos(Lista As List(Of DispositivoModel), Parametros As LecturaParametros)
    Public Event BorrarMarcaciones(Lista As List(Of DispositivoModel))

    ''' <summary>
    ''' Representa un arbol de relojes
    ''' </summary>
    Public Sub New()
        InitializeComponent()

        Dispositivos = New List(Of DispositivoModel)

    End Sub

    ''' <summary>
    ''' Registrar un dispositivo
    ''' </summary>
    ''' <param name="data"></param>
    Public Sub RegisterDevice(data As DispositivoModel)
        Dim node As New ListViewItem() With {
            .Text = data.DireccionIp,
            .ImageIndex = 0
        }
        node.SubItems.Add(data.Descripcion)
        node.SubItems.Add(data.IdDispositivo)
        node.SubItems.Add("No detectado") ' estado offline por defecto
        node.Tag = data
        LvDispositivos.Items.Add(node)
    End Sub

    ''' <summary>
    ''' Registrar la lista de dispositivos
    ''' </summary>
    ''' <param name="data"></param>
    Public Async Function RegistrarTodo(data As List(Of DispositivoModel)) As Task
        Await Task.Run(Sub()
                           Me.Invoke(Sub()
                                         For Each row As DispositivoModel In data
                                             RegisterDevice(row)
                                         Next
                                     End Sub)
                       End Sub)
    End Function

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        SeleccionarTodo()
    End Sub

    Private Sub SeleccionarTodo()
        For Each item As ListViewItem In LvDispositivos.Items
            item.Checked = True
        Next
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        DeseleccionarTodos()
    End Sub

    Private Sub DeseleccionarTodos()
        For Each item As ListViewItem In LvDispositivos.Items
            item.Checked = False
        Next
    End Sub

    ''' <summary>
    ''' Ejecutar lectura de dispositivos
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        LecturaMarcaciones()

    End Sub

    Private Sub LecturaMarcaciones()
        If LvDispositivos.CheckedItems.Count = 0 Then
            MessageBox.Show("No hay relojes seleccionados", "Importar")
            Return
        End If


        Dim panel As New ImportarFecha()
        Dim resultado = panel.ShowDialog()

        If resultado = DialogResult.OK Then

            'preparar los parametros
            Dim result As New LecturaParametros With {
                .FechaDesde = panel.FechaDesde,
                .FechaHasta = panel.FechaHasta,
                .SapUsuario = panel.SapUsername,
                .SapPassword = panel.SapPassword,
                .Modo = panel.Modo,
                .VerificarDuplicados = panel.VerificarDuplicados
            }
            'filtrar los checkeados
            Dim relojesSeleccionados As New List(Of DispositivoModel)
            For Each row As ListViewItem In LvDispositivos.CheckedItems
                relojesSeleccionados.Add(DirectCast(row.Tag, DispositivoModel))

            Next
            'enviar listado a lectura
            RaiseEvent LeerDispostivos(relojesSeleccionados, result)

        End If
    End Sub





    Private Sub LeerEventosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeerEventosToolStripMenuItem.Click
        LecturaMarcaciones()
    End Sub

    Private Sub SeleccionarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarTodosToolStripMenuItem.Click
        'seleccionar todos
        SeleccionarTodo()
    End Sub

    Private Sub DeseleccionarTodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeseleccionarTodosToolStripMenuItem.Click
        'deseleccionar todos
        DeseleccionarTodos()
    End Sub

    Private Sub BorrarMarcacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarMarcacionesToolStripMenuItem.Click
        If LvDispositivos.CheckedItems.Count = 0 Then
            MessageBox.Show("No hay relojes seleccionados", "Borrar")
            Return
        End If


        'pregunta a conciencia si quiere ejecutar el borrado de registro de attendance 
        Dim resp = MessageBox.Show("Estas seguro de borrar los registros de marcaciones? Esta operación no es reversible y se aplicara de inmediato", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resp = DialogResult.Yes Then
            'borrar
            Dim lista_dispositivos As List(Of DispositivoModel) = New List(Of DispositivoModel)

            For Each item As ListViewItem In LvDispositivos.CheckedItems
                lista_dispositivos.Add(DirectCast(item.Tag, DispositivoModel))
            Next

            RaiseEvent BorrarMarcaciones(lista_dispositivos)

        End If
    End Sub

    Private Async Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Await VerificarRelojes()
    End Sub

    Public Async Function VerificarRelojes() As Task

        Await Task.Run(Sub()
                           Me.Invoke(Sub()
                                         For Each row As ListViewItem In LvDispositivos.Items
                                             Dim dispositivo As DispositivoModel = DirectCast(row.Tag, DispositivoModel)
                                             Dim resultado = Utiles.Ping(dispositivo.DireccionIp)

                                             If resultado Then
                                                 row.ImageIndex = 6
                                                 row.ForeColor = Color.DarkGreen
                                                 row.SubItems(3).Text = "Detectado"
                                             Else
                                                 row.ImageIndex = 7
                                                 row.ForeColor = Color.DarkRed
                                                 row.SubItems(3).Text = "No detectado"
                                             End If
                                         Next
                                     End Sub)
                       End Sub)
    End Function
End Class
