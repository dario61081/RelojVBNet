Public Class Result(Of T)
    Public Property IsSuccess As Boolean
    Public Property Value As T
    Public Property ErrorMessage As String

    Private Sub New(isSuccess As Boolean, value As T, errorMessage As String)
        Me.IsSuccess = isSuccess
        Me.Value = value
        Me.ErrorMessage = errorMessage
    End Sub

    Public Shared Function Success(value As T) As Result(Of T)
        Return New Result(Of T)(True, value, Nothing)
    End Function

    Public Shared Function Failure(errorMessage As String) As Result(Of T)
        Return New Result(Of T)(False, Nothing, errorMessage)
    End Function
End Class

