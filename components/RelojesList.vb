Imports RelojVBNET.Models

Public Class RelojesList

    Public Dispositivos As List(Of DispositivoModel)

    Public Event LeerDispostivos(Lista As List(Of DispositivoModel), Parametros As LecturaParametros)

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
        node.SubItems.Add("") ' estado
        node.Tag = data
        LvDispositivos.Items.Add(node)
    End Sub

    ''' <summary>
    ''' Registrar la lista de dispositivos
    ''' </summary>
    ''' <param name="data"></param>
    Public Sub RegistrarTodo(data As List(Of DispositivoModel))
        For Each row As DispositivoModel In data
            RegisterDevice(row)
        Next

    End Sub

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
                .Modo = panel.Modo
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

    Private Sub LecturaSeleccionados()

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

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
        'pregunta a conciencia si quiere ejecutar el borrado de registro de attendance 
        Dim resp = MessageBox.Show("Estas seguro de borrar los registros de marcaciones? Esta operación no es reversible y se aplicara de inmediato", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resp = DialogResult.Yes Then
            'borrar
        End If
    End Sub

    Private Async Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Await Task.Run(Sub() VerificarRelojes())
    End Sub

    Public Sub VerificarRelojes()
        'check ping de los relojes
        Me.Invoke(Sub()
                      For Each row As ListViewItem In LvDispositivos.Items
                          Dim dispositivo As DispositivoModel = DirectCast(row.Tag, DispositivoModel)
                          Dim resultado = Utiles.Ping(dispositivo.DireccionIp)

                          If resultado Then
                              row.ImageIndex = 6
                              row.ForeColor = Color.DarkGreen
                              row.SubItems(3).Text = "Online"
                          Else
                              row.ImageIndex = 7
                              row.ForeColor = Color.DarkRed
                              row.SubItems(3).Text = "Offline"
                          End If
                      Next
                  End Sub)
    End Sub
End Class
