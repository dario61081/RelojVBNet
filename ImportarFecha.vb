Option Explicit On



Public Class ImportarFecha
    Public FechaDesde As Date
    Public Property FechaHasta As Date
    Public Property Modo As Integer = 0
    Public Property SapUsername As String
    Public Property SapPassword As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(edtSapPassword.Text) Or String.IsNullOrEmpty(edtSapPassword.Text) Then
            MessageBox.Show("Los campos de usuario y password son obligatorios", "Importar")
            Return
        End If



        'guardar info de todos o por fecha
        If rdTodos.Checked Then
            Modo = 0
        Else
            Modo = 1
        End If
        'datos del rango de fecha
        FechaDesde = dtpFechaDesde.Value
        FechaHasta = dtpFechaHasta.Value
        SapUsername = edtSapUsername.Text
        SapPassword = edtSapPassword.Text
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

        dtpFechaDesde.Value = GetFirstDayOfMonth().Date
        dtpFechaHasta.Value = DateTime.Now.Date

    End Sub
End Class