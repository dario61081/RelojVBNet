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
        For Each item As ListViewItem In LvDispositivos.Items
            item.Checked = True
        Next
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
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

        Dim panel As New ImportarFecha()
        Dim resultado = panel.ShowDialog()

        If resultado = DialogResult.OK Then



        End If


    End Sub
End Class
