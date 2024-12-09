Imports RelojVBNET.Models

Public Class RelojesList

    Public Dispositivos As List(Of DispositivoModel)

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
            .Text = data.DireccionIp
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


End Class
