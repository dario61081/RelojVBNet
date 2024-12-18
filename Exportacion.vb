Imports System.ComponentModel

Public Class Exportacion
    Private Sub Exportacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        reset_controls()




    End Sub

    Sub reset_controls()
        ProgressBar1.Value = 0
        ProgressBar2.Value = 0
        lbltarea.Text = "Iniciando tareas"
        lblsubtarea.Text = ""

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'tarea
        Dim worker As System.ComponentModel.BackgroundWorker = CType(sender, System.ComponentModel.BackgroundWorker)

        For i As Integer = 1 To 100
            Threading.Thread.Sleep(20)
            worker.ReportProgress(1)

        Next


    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'actualizar progreso
        ProgressBar1.Value = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        'progreso completado
        MessageBox.Show("Tarea concluida")
    End Sub
End Class