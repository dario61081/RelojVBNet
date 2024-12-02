Public Class EventOnFingerEnroll
    Inherits EventArgs

    Public Property Records As List(Of AttendanceRecord)

    Public Sub New(records As List(Of AttendanceRecord))
        Me.Records = records
    End Sub


End Class
