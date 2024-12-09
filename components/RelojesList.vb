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

    Public Sub RegisterDevice(data As DispositivoModel)
        Dim node As New ListViewItem() With {
            .Text = data.DireccionIp
        }
        node.SubItems.Add(data.Descripcion)
        node.Tag = data
        LvDispositivos.Items.Add(node)
    End Sub




End Class
