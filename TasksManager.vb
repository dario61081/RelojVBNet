Imports System.Collections.Concurrent
Imports System.Threading

Module TasksManager
    ' Una cola concurrente para manejar funciones que devuelven un resultado
    Dim taskQueue As New ConcurrentQueue(Of Func(Of String))
    Dim cancellationTokenSource As New CancellationTokenSource()
    Dim isProcessing As Boolean = False

    'Sub Main()
    '    ' Agregar funciones a la cola
    '    EnqueueTask(Function() "Resultado de la Tarea 1 ejecutada en hilo: " & Thread.CurrentThread.ManagedThreadId)
    '    EnqueueTask(Function() "Resultado de la Tarea 2 ejecutada en hilo: " & Thread.CurrentThread.ManagedThreadId)
    '    EnqueueTask(Function() "Resultado de la Tarea 3 ejecutada en hilo: " & Thread.CurrentThread.ManagedThreadId)

    '    ' Comenzar a procesar las tareas
    '    StartProcessing()

    '    ' Esperar antes de salir
    '    Thread.Sleep(3000)
    '    StopProcessing()
    'End Sub

    ' Método para agregar tareas a la cola
    Sub EnqueueTask(task As Func(Of String))
        taskQueue.Enqueue(task)
        If Not isProcessing Then
            StartProcessing()
        End If
    End Sub

    ' Método para procesar tareas
    Sub StartProcessing()
        If isProcessing Then Return
        isProcessing = True

        Task.Run(Sub()
                     While Not cancellationTokenSource.Token.IsCancellationRequested
                         Dim currentTask As Func(Of String) = Nothing

                         ' Intentar obtener una tarea de la cola
                         If taskQueue.TryDequeue(currentTask) Then
                             Try
                                 ' Ejecutar la función y obtener el resultado
                                 Dim result As String = currentTask.Invoke()
                                 Console.WriteLine("Resultado de la tarea: " & result)
                             Catch ex As Exception
                                 Console.WriteLine("Error al ejecutar la tarea: " & ex.Message)
                             End Try
                         Else
                             ' Si no hay tareas, esperar un poco para no saturar la CPU
                             Thread.Sleep(100)
                         End If
                     End While
                 End Sub)
    End Sub

    ' Método para detener el procesamiento
    Sub StopProcessing()
        cancellationTokenSource.Cancel()
        isProcessing = False
    End Sub
End Module
