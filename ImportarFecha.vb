Option Explicit On



Public Class ImportarFecha
    Public FechaDesde As Date
    Public Property FechaHasta As Date
    Public Property Modo As Integer = 0
    Public Property SapUsername As String
    Public Property SapPassword As String

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
        SapUsername = TextBox1.Text
        SapPassword = TextBox2.Text
        DialogResult = DialogResult.OK
        Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DialogResult = DialogResult.Cancel
        Close()

    End Sub

    Private Sub ImportarFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaDesde.MaxDate = DateTime.Now
        dtpFechaHasta.MaxDate = DateTime.Now

        dtpFechaDesde.Value = GetFirstDayOfMonth()
        dtpFechaHasta.Value = DateTime.Now

    End Sub
End Class