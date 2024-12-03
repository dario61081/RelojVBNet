Public Class ImportarFecha
    Public FechaDesde As Date
    Public Property FechaHasta As Date
    Public Property Modo As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'guardar info de todos o por fecha
        If rdTodos.Checked Then
            Modo = 0
        Else
            Modo = 1
        End If
        'datos del rango de fecha
        FechaDesde = dtpFechaDesde.Value
        FechaHasta = dtpFechaHasta.Value
        DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = DialogResult.Cancel
        Close()

    End Sub
End Class